using AGC.BusinessLogic;
using AGC.Entity;

using AgcCommBase;

using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.BusinessLogicEx;

namespace AutoGCLib
{
    public partial class AutoGC
    {
        //private static bool CheckTabFld(clsPrjTabENEx objPrjTabENEx)
        //{
        //    string strMsg = "";
        //    if (objPrjTabENEx.TabFldNum() == 0)
        //    {
        //        strMsg = string.Format("当前表:[{0}]的字段数为0,无法生成表相关代码!({1})",
        //            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (objPrjTabENEx.KeyFldNum() == 0)
        //    {
        //        strMsg = string.Format("当前表:[{0}]的关键字的个数为0,无法生成表相关代码!({1})",
        //            objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    return true;
        //}
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="objCodeTypeEN._NameValue">类名</param>
        /// <param name="strTypeParas">类型类型</param>
        /// <param name="ltLangType">语言类型</param>
        /// <param name="dbtDataBaseType">数据库类型</param>
        /// <param name="strTabId">表Id</param>
        /// <param name="strViewId">界面Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strPrjDataBaseId">数据库Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strRe_ClsName"></param>
        /// <param name="strRe_FileNameWithModuleName"></param>
        /// <returns></returns>
        public static string GeneCode4Feature(string strCodeTypeId,
            string strFeatureId,      
            clsPubConst.DataBaseType dbtDataBaseType,
            string strTabId,
            string strViewId,
            string strPrjId,
            string strPrjDataBaseId,
            string strUserId,
            ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
            var Re_objFunction4Code = new clsFunction4CodeEN();

            string strFunctionName = clsStackTrace.GetCurrClassFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("CodeTypeName", objCodeTypeEN.CodeTypeName);
            dictParam.Add("FeatureName", objPrjFeatureEN.FeatureName);
            dictParam.Add("strLangType", clsPubConst.GetLangTypeStringByLangType(ltLangType));
            dictParam.Add("strDataBaseType", clsPubConst.GetDataBaseTypeStrByDataBaseType(dbtDataBaseType));
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strRe_ClsName", strRe_ClsName);
            dictParam.Add("strRe_FileNameWithModuleName", strRe_FileNameWithModuleName);
            clsPubVar4BLEx.Log4GCDebug("调用生成代码函数：", strFunctionName, strUserId, dictParam);

            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {

            }
                        
            clsProjectsEN objCurrSelProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";

            clsGeneCodeBase4Tab objGeneCodeBase4Tab = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4View objGeneCodeBase4View = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);




            //string strClassFName = "";
            string strSqlDsTypeId = "";
            string strMsg = "";
            if (objCurrSelProject.IsRelaDataBase == true && string.IsNullOrEmpty(strTabId) == false)
            {
                if (clsPubFun4BLEx.TestConnectString(strPrjDataBaseId) == false)
                {
                    if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
                    {
                        strMsg = "PrjDataBaseId 为空,请设置一个合法的PrjDataBaseId(工程数据库号)!";
                    }
                    else
                    {
                        clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
                        strMsg = string.Format("错误:指向IP:{0}的数据库连接不可用,请检查!", objPrjDataBaseEN.IpAddress);
                    }
                    clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                    //objGCResult.errorMsg = strMsg;
                    //objGCResult.errorId = 1;
                    //objGCResult.re_ClsName = "";
                    //objGCResult.re_FileNameWithModuleName = "";
                    return strMsg;
                }
                try
                {
                    //判断是否可以删除
                    if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId, strPrjId, strPrjDataBaseId) == false)
                    {
                        throw new Exception("检查表字段不成功!");
                        //return false;
                    }
                }
                catch (Exception objException)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                    clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                    string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                    string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                    strMsg = string.Format("(errorId:0012)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
strTabName, strViewName,
objCodeTypeEN._NameValue,
objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                    
                    throw objException;
                }
            }
            string strClassName = string.Format("AutoGCLib.{0}4{1}", objCodeTypeEN.CodeTypeENName, ltLangType);
            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab = clsGeneCodeBase4Tab.GetClassByName(strClassName, strTabId, strPrjDataBaseId, strPrjId);
                if (objGeneCodeBase4Tab == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
            }
            else if (objCodeTypeEN.DependsOn == "View")
            {
                objGeneCodeBase4View = clsGeneCodeBase4View.GetClassByName(strClassName, strViewId, strPrjDataBaseId, strPrjId);
                if (objGeneCodeBase4View == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
            }

            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab.objPrjTabENEx.LangType = ltLangType;
                objGeneCodeBase4Tab.objPrjTabENEx.CodeTypeId = objCodeTypeEN.CodeTypeId;
                objGeneCodeBase4Tab.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                CheckTabFld(objGeneCodeBase4Tab.objPrjTabENEx);
                strSqlDsTypeId = objGeneCodeBase4Tab.objPrjTabENEx.SqlDsTypeId;
            }
            else if (objCodeTypeEN.DependsOn == "View")
            {
                objGeneCodeBase4View.objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                objGeneCodeBase4View.objViewInfoENEx.LangType = ltLangType;
                objGeneCodeBase4View.objViewInfoENEx.CodeTypeId = objCodeTypeEN.CodeTypeId;

            }
            StringBuilder sbCode = new StringBuilder();
            try
            {
                List < clsFeatureFuncRelaEN> arrFeatureFuncRela = clsFeatureFuncRelaBLEx.GetObjLstByFeatureIdCacheEx(strFeatureId);
                foreach (var objInfor in arrFeatureFuncRela)
                {
                    string strCodeText = "";

                    strCodeText = objGeneCodeBase4Tab.GeneCode4Function(objInfor.FuncId4GC, ref Re_objFunction4Code); //已完成
                    sbCode.AppendLine(strCodeText);
                }
            }
            catch (Exception objException)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                strMsg = string.Format("(errorId:108)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
strTabName, strViewName,
objCodeTypeEN.CodeTypeENName,
objException.Message, clsStackTrace.GetCurrClassFunction());

                throw objException;
            }
            //if (string.IsNullOrEmpty(strCodeText) == false)
            return sbCode.ToString();
          
        }

        public static clsGCResult GeneCode4Feature(clsGCPara objGCPara)
        {
            string strMsg = "";

            if (string.IsNullOrEmpty(objGCPara.prjDataBaseId) == true)
            {
                strMsg = string.Format("strPrjDataBaseId 不能为空!");
                throw new Exception(strMsg);
            }
            string strFunctionName = clsStackTrace.GetCurrClassFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("CodeTypeId", objGCPara.codeTypeId);
            //dictParam.Add("strClassName", objGCPara.ClsName);
            dictParam.Add("strTypeParas", objGCPara.typeParas);
            //dictParam.Add("strLangType", objGCPara.LangType);
            dictParam.Add("strDataBaseType", objGCPara.dataBaseType);
            dictParam.Add("FeatureId", objGCPara.featureId);
            dictParam.Add("strTabId", objGCPara.tabId);
            dictParam.Add("strViewId", objGCPara.viewId);

            dictParam.Add("strCmPrjId", objGCPara.cmPrjId);
            dictParam.Add("strPrjId", objGCPara.prjId);
            dictParam.Add("strPrjDataBaseId", objGCPara.prjDataBaseId);

            dictParam.Add("intApplicationTypeId", objGCPara.applicationTypeId.ToString());
            dictParam.Add("strUserId", objGCPara.gcUserId);
            if (string.IsNullOrEmpty(objGCPara.dataBaseType) == true)
            {
                var objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objGCPara.prjDataBaseId);
                objGCPara.dataBaseType = clsDataBaseTypeBL.GetObjByDataBaseTypeIdCache(objPrjDataBase.DataBaseTypeId).DataBaseTypeSimName;
            }
            //clsPubVar4BLEx.Log4GCDebug("调用生成代码函数：", strFunctionName, objGCPara.gcUserId, dictParam);
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objGCPara.codeTypeId);

            if (objCodeType == null)
            {
                strMsg = string.Format("No.2 获取objCodeTypeEN：{0}不成功!({3})",
    objGCPara.codeTypeId, objGCPara.viewId,
    objCodeType.CodeTypeName,
    clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            clsGCResult objGCResult = new clsGCResult();
            objGCResult.codeTypeId = objCodeType.CodeTypeId;
            objGCResult.codeTypeName = objCodeType.CodeTypeName;
            objGCResult.codeTypeENName = objCodeType.CodeTypeENName;
            objGCResult.gcUserId = objGCPara.gcUserId;
            objGCResult.errorId = 0;
            objGCResult.errorMsg = "";
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeENName);// clsPubConst.LangType.JAVA;

            clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.GetDataBaseTypeByString(objGCPara.dataBaseType);
            objGCResult.langType = objProgLangTypeEN.ProgLangTypeENName;
            objGCResult.dataBaseType = objGCPara.dataBaseType;

            clsProjectsEN objCurrSelProject = null;
            try
            {
                objCurrSelProject = clsProjectsBL.GetObjByPrjIdCache(objGCPara.prjId);
                strMsg = string.Format("当前工程Id:{0}获取对象成功!(In {1})",
                    objGCPara.prjId,
                    clsStackTrace.GetCurrClassFunction());
                //clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
            }
            catch (Exception objException)
            {
                strMsg = string.Format("工程Id:{0}所对应的对象不存在,请检查!错误:{1}(In {2})",
                    objGCPara.prjId, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            objGCResult.prjName = objCurrSelProject.PrjName;


            clsGeneCodeBase4Tab objGeneCodeBase4Tab = null;
            clsGeneCodeBase4View objGeneCodeBase4View = null;

            var Re_objFunction4Code = new clsFunction4CodeEN();

            //string strClassFName = "";
            string strSqlDsTypeId = "";
            clsPrjDataBaseEN objPrjDataBaseEN = null;
            if (objCurrSelProject.IsRelaDataBase == true && string.IsNullOrEmpty(objGCPara.tabId) == false)
            {

                if (clsPubFun4BLEx.TestConnectString(objGCPara.prjDataBaseId) == false)
                {
                    if (string.IsNullOrEmpty(objGCPara.prjDataBaseId) == true)
                    {
                        strMsg = "PrjDataBaseId 为空,请设置一个合法的PrjDataBaseId(工程数据库号)!";
                    }
                    else
                    {
                        objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objGCPara.prjDataBaseId);
                        strMsg = string.Format("错误:指向IP:{0}的数据库连接不可用,请检查!", objPrjDataBaseEN.IpAddress);
                    }
                    clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                    objGCResult.errorMsg = strMsg;
                    objGCResult.errorId = 1;
                    objGCResult.re_ClsName = "";
                    objGCResult.re_FileNameWithModuleName = "";
                    objGCResult.version = clsSysParaEN_Local.strVersion;
                    return objGCResult;
                    //                    throw new Exception(strMsg);
                }
            }
            try
            {
                if (objCurrSelProject.IsRelaDataBase == true && string.IsNullOrEmpty(objGCPara.tabId) == false)
                {
                    var arrTabCheckStatus = clsTabCheckStatusBL.GetObjLstCache(objGCPara.prjId);
                    arrTabCheckStatus = arrTabCheckStatus.Where(x => x.PrjDataBaseId == objGCPara.prjDataBaseId).ToList();
                    var objTabCheckStatus = arrTabCheckStatus.Find(x => x.TabId == objGCPara.tabId);
                    bool bolIsNeedCheck = false;
                    if (objTabCheckStatus != null && objTabCheckStatus.ErrorLevelId == 4)
                    {
                        bolIsNeedCheck = true;
                    }
                    if (objTabCheckStatus == null)
                    {
                        bolIsNeedCheck = true;
                    }
                    if (bolIsNeedCheck == true)
                    {
                        if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(objGCPara.tabId, objGCPara.prjId, objGCPara.prjDataBaseId) == false)
                        {
                            strMsg = string.Format("(errorId:0002)检查表字段不成功!.({0})",
                                     clsStackTrace.GetCurrClassFunction());
                            clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                            clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                            objGCResult.errorMsg = strMsg;
                            objGCResult.errorId = 2;
                            objGCResult.re_ClsName = "";
                            objGCResult.re_FileNameWithModuleName = "";
                            objGCResult.version = clsSysParaEN_Local.strVersion;
                            return objGCResult;
                            //return false;
                        }
                    }
                    objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objGCPara.prjDataBaseId);
                    objGCResult.prjDataBaseName = objPrjDataBaseEN.PrjDataBaseName;
                }
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errorId:0003)检查表字段出错!错误：{3}.({4})",
objGCPara.tabId, objGCPara.viewId,
objCodeType.CodeTypeName,
objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                objGCResult.errorMsg = strMsg;
                objGCResult.errorId = 1;
                objGCResult.re_ClsName = "";
                objGCResult.re_FileNameWithModuleName = "";
                objGCResult.version = clsSysParaEN_Local.strVersion;
                return objGCResult;
            }
          

            string strClassName = string.Format("AutoGCLib.{0}4{1}", objCodeType.CodeTypeENName, ltLangType);
            if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab = clsGeneCodeBase4Tab.GetClassByName(strClassName, objGCPara.tabId, objGCPara.prjDataBaseId, objGCPara.prjId);
                if (objGeneCodeBase4Tab == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
            }
            else if (objCodeType.DependsOn == "View")
            {
                objGeneCodeBase4View = clsGeneCodeBase4View.GetClassByName(strClassName, objGCPara.viewId, objGCPara.prjDataBaseId, objGCPara.prjId);
                if (objGeneCodeBase4View == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }

            }

            if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab.objPrjTabENEx.LangType = ltLangType;
                objGeneCodeBase4Tab.objPrjTabENEx.CodeTypeId = objGCPara.codeTypeId;
                objGeneCodeBase4Tab.objPrjTabENEx.ApplicationTypeId = objGCPara.applicationTypeId;
                objGeneCodeBase4Tab.objPrjTabENEx.UserId = objGCPara.gcUserId;
                strSqlDsTypeId = objGeneCodeBase4Tab.objPrjTabENEx.SqlDsTypeId;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objGCPara.tabId, objGCPara.prjId);
                objGCResult.tabName = objPrjTabEN.TabName;
            }
            else if (objCodeType.DependsOn == "View")
            {
                objGeneCodeBase4View.objViewInfoENEx.PrjDataBaseId = objGCPara.prjDataBaseId;
                objGeneCodeBase4View.objViewInfoENEx.LangType = ltLangType;
                objGeneCodeBase4View.objViewInfoENEx.CodeTypeId = objGCPara.codeTypeId;
                objGeneCodeBase4View.objViewInfoENEx.UserId = objGCPara.gcUserId;
                clsViewInfoEN objViewInfoEN = clsViewInfoBLEx.GetObjByViewIdCache(objGCPara.viewId, objGCPara.prjId);
                objGCResult.viewName = objViewInfoEN.ViewName;
            }
            try
            {
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                StringBuilder sbCode = new StringBuilder();
                List<clsFeatureFuncRelaEN> arrFeatureFuncRela = clsFeatureFuncRelaBLEx.GetObjLstByFeatureIdCacheEx(objGCPara.featureId);
                List<clsFunction4GeneCodeEN> arrFunction4GeneCode = clsFunction4GeneCodeBL.GetObjLstCache();
                var arrFunction4GeneCode_Sel = arrFunction4GeneCode.Where(x=>x.FuncCodeTypeId == objGCPara.codeTypeId);
                var arrFuncId4GC = arrFunction4GeneCode_Sel.Select(x => x.FuncId4GC).ToList();
                arrFeatureFuncRela = arrFeatureFuncRela.Where(x=> arrFuncId4GC.Contains(x.FuncId4GC) == true).ToList();
                foreach (var objInfor in arrFeatureFuncRela)
                {
                    string strCodeText = "";
                    strCodeText = objGeneCodeBase4Tab.GeneCode4Function(objInfor.FuncId4GC, ref Re_objFunction4Code); //已完成
                    sbCode.AppendLine(strCodeText);
                }
                //strCodeText = objGeneCodeBase.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                objGCResult.codeText = sbCode.ToString();
                objGCResult.re_ClsName = strRe_ClsName;
                objGCResult.re_FileNameWithModuleName = strRe_FileNameWithModuleName;
                objGCResult.version = clsSysParaEN_Local.strVersion;
            }
            catch (Exception objException)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objGCPara.tabId, objGCPara.prjId);
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(objGCPara.viewId, objGCPara.prjId);
                string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                strMsg = string.Format("(errorId:004)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
                       strTabName, strViewName,
                      objCodeType.CodeTypeENName,
                       objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                objGCResult.errorMsg = strMsg;
                objGCResult.errorId = 1;
                objGCResult.re_ClsName = "";
                objGCResult.re_FileNameWithModuleName = "";
                objGCResult.version = clsSysParaEN_Local.strVersion;
                return objGCResult;
            }
            if (objGCPara.isRecordLog == true)
            {
                if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
                {

                    clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, objGCPara.cmPrjId, objGCPara.applicationTypeId, objGCPara.gcUserId, clsSysParaEN_Local.strVersion);
                }
                else if (objCodeType.DependsOn == "View")
                {
                    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objGeneCodeBase4View.objViewInfoENEx.ViewId, objGCPara.gcUserId, clsSysParaEN_Local.strVersion);
                }
                else
                {
                    clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, objGCPara.cmPrjId, objGCPara.applicationTypeId, objGCPara.gcUserId, clsSysParaEN_Local.strVersion);
                }
            }
            //if (string.IsNullOrEmpty(strCodeText) == false) return strCodeText;
            //return "";
            return objGCResult;
        }

    }
}
