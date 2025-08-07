using AGC.BusinessLogic;
using AGC.Entity;

using AgcCommBase;

using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.BusinessLogicEx;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace AutoGCLib
{
    public partial class AutoGC
    {
        private bool bolIsFstLcase = false;
        public static string GeneCode(string strCodeTypeId,
         string strTypeParas,
         clsPubConst.DataBaseType dbtDataBaseType,
         string strTabId,
         string strViewId,
         string strCmPrjId,
         string strPrjId,
         string strPrjDataBaseId,
         int intApplicationTypeId,
         string strUserId,
         ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            return GeneCode(objCodeTypeEN.CodeTypeENName,
             strTypeParas,
            ltLangType,
            dbtDataBaseType,
            strTabId,
            strViewId,
            strCmPrjId,
            strPrjId,
            strPrjDataBaseId,
            intApplicationTypeId,
            strUserId,
            ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="cnClassName">类名</param>
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
        public static string GeneCode(string cnClassName,
            string strTypeParas,
            clsPubConst.LangType ltLangType,
            clsPubConst.DataBaseType dbtDataBaseType,
            string strTabId,
            string strViewId,

            string strCmPrjId,
            string strPrjId,
            string strPrjDataBaseId,
            int intApplicationTypeId,
            string strGCUserId,
            ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
            {
                strMsg = string.Format("strPrjDataBaseId 不能为空!");
                throw new Exception(strMsg);
            }
            string strFunctionName = clsStackTrace.GetCurrClassFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strClassName", cnClassName);
            dictParam.Add("strTypeParas", strTypeParas);
            dictParam.Add("strLangType", clsPubConst.GetLangTypeStringByLangType(ltLangType));
            dictParam.Add("strDataBaseType", clsPubConst.GetDataBaseTypeStrByDataBaseType(dbtDataBaseType));
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());

            dictParam.Add("strUserId", strGCUserId);
            dictParam.Add("strRe_ClsName", strRe_ClsName);
            dictParam.Add("strRe_FileNameWithModuleName", strRe_FileNameWithModuleName);
            //clsPubVar4BLEx.Log4GCDebug("调用生成代码函数：", strFunctionName, strGCUserId, dictParam);

            clsProjectsEN objCurrSelProject = null;
            try
            {
                objCurrSelProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                strMsg = string.Format("当前工程Id:{0}获取对象成功!(In {1})",
                    strPrjId,
                    clsStackTrace.GetCurrClassFunction());
                //clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
            }
            catch (Exception objException)
            {
                strMsg = string.Format("工程Id:{0}所对应的对象不存在,请检查!错误:{1}(In {2})",
                    strPrjId, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
         

            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strCodeText = "";
            clsGeneCodeBase4Tab objGeneCodeBase4Tab = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4View objGeneCodeBase4View = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            
                 clsCodeTypeEN objCodeTypeEN = clsCodeTypeBLEx.GetObjByClassNameAndLangTypeCache(cnClassName, ltLangType);
            if (objCodeTypeEN == null)
            {
                strMsg = string.Format("No.2 获取objCodeTypeEN：{0}不成功!({3})",
    objCodeTypeEN.CodeTypeId, strViewId,
    cnClassName,
    clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            //string[] sstrTypeParas = strTypeParas.Split('|');
            clsGCResult objGCResult = new clsGCResult();
            objGCResult.codeTypeId = objCodeTypeEN.CodeTypeId;
            objGCResult.codeTypeName = objCodeTypeEN.CodeTypeName;
            objGCResult.codeTypeENName = objCodeTypeEN.CodeTypeENName;
            objGCResult.gcUserId = strGCUserId;
            objGCResult.errorId = 0;
            objGCResult.errorMsg = "";
            //string strClassFName = "";
            string strSqlDsTypeId = "";
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
                    objGCResult.errorMsg = strMsg;
                    objGCResult.errorId = 1;
                    objGCResult.re_ClsName = "";
                    objGCResult.re_FileNameWithModuleName = "";
                    objGCResult.version = clsSysParaEN_Local.strVersion;
                    //return objGCResult;
                    return strMsg;
//                    throw new Exception(strMsg);
                }
            }
            try
            {
                if (objCurrSelProject.IsRelaDataBase == true && string.IsNullOrEmpty(strTabId) == false)
                {
                    //判断是否可以删除
                    var arrTabCheckStatus = clsTabCheckStatusBL.GetObjLstCache(strPrjId);
                    arrTabCheckStatus = arrTabCheckStatus.Where(x => x.PrjDataBaseId == strPrjDataBaseId).ToList();
                    var objTabCheckStatus = arrTabCheckStatus.Find(x => x.TabId == strTabId);
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
                        if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId, strPrjId, strPrjDataBaseId) == false)
                        {
                            strMsg = string.Format("(errorId:0002)检查表字段不成功!.({0})",
                                     clsStackTrace.GetCurrClassFunction());
                            clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                            throw new Exception("检查表字段不成功!");
                            //return false;
                        }
                    }
                }
            }
            catch (Exception objException)
            {

                strMsg = string.Format("(errorId:0003)检查表字段出错!错误：{3}.({4})",
strTabId, strViewId,
cnClassName,
objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                throw objException;
            }


            string strClassName = string.Format("AutoGCLib.{0}4{1}", cnClassName, ltLangType);
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {

                objGeneCodeBase4Tab = clsGeneCodeBase4Tab.GetClassByName(strClassName, strTabId, strPrjDataBaseId, strPrjId);
                if (objGeneCodeBase4Tab == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
                objGeneCodeBase4Tab.CmPrjId = strCmPrjId;

            }
            else if (objCodeTypeEN.DependsOn == "View")
            {

                objGeneCodeBase4View = clsGeneCodeBase4View.GetClassByName(strClassName, strViewId, strPrjDataBaseId, strPrjId);
                if (objGeneCodeBase4View == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
                objGeneCodeBase4View.CmPrjId = strCmPrjId;
            }
            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab.objPrjTabENEx.LangType = ltLangType;
                objGeneCodeBase4Tab.objPrjTabENEx.CodeTypeId = objCodeTypeEN.CodeTypeId;
                objGeneCodeBase4Tab.objPrjTabENEx.ApplicationTypeId = intApplicationTypeId;
                objGeneCodeBase4Tab.objPrjTabENEx.UserId = strGCUserId;
                

                strSqlDsTypeId = objGeneCodeBase4Tab.objPrjTabENEx.SqlDsTypeId;
                objGeneCodeBase4Tab.IsFstLcase = objCMProject.IsFstLcase;
            }
            else if (objCodeTypeEN.DependsOn == "View")
            {
                objGeneCodeBase4View.objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                objGeneCodeBase4View.objViewInfoENEx.LangType = ltLangType;
                objGeneCodeBase4View.objViewInfoENEx.CodeTypeId = objCodeTypeEN.CodeTypeId;
                objGeneCodeBase4View.objViewInfoENEx.objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objCodeTypeEN.CodeTypeId);
                objGeneCodeBase4View.objViewInfoENEx.UserId = strGCUserId;
                objGeneCodeBase4View.IsFstLcase = objCMProject.IsFstLcase;
            }
            
            
            try
            {
                if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
                {
                    strCodeText = objGeneCodeBase4Tab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                }
                else
                {
                    strCodeText = objGeneCodeBase4View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                }
            }
            catch (Exception objException)
            {            

                string strTabName = "";// objPrjTab == null ? "" : objPrjTab.TabName;
                if (string.IsNullOrEmpty(strTabId))
                {

                }
                else
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                    strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                }
                string strViewName = "";// objViewInfo == null ? "" : objViewInfo.ViewName;
                if (string.IsNullOrEmpty(strViewId))
                {

                }
                else
                {
                    clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                    strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;
                }
                strMsg = string.Format("(errorId:007)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
                       strTabName, strViewName,
                      cnClassName,
                       objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                throw objException;
            }
            //if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            //{              
            //    clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strGCUserId, clsSysParaEN_Local.strVersion);
            //}
            //else if (objCodeTypeEN.DependsOn == "View")
            //{
            //    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objGeneCodeBase4View.objViewInfoENEx.ViewId, strGCUserId, clsSysParaEN_Local.strVersion);
            //}
            //else
            //{
            //    clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strGCUserId, clsSysParaEN_Local.strVersion);
            //}
            if (string.IsNullOrEmpty(strCodeText) == false) return strCodeText;
            return "";
        }

        public static clsGCResult GeneCode(clsGCPara objGCPara)
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
                objGCPara.dataBaseType =  clsDataBaseTypeBL.GetObjByDataBaseTypeIdCache( objPrjDataBase.DataBaseTypeId).DataBaseTypeSimName;
            }
            //clsPubVar4BLEx.Log4GCDebug("调用生成代码函数：", strFunctionName, objGCPara.gcUserId, dictParam);
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objGCPara.codeTypeId);
            
            if (objCodeType == null)
            {
                strMsg = $"No.2 获取objCodeTypeEN：{objGCPara.codeTypeId}不成功!({clsStackTrace.GetCurrClassFunction()})";
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
          
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strCodeText = "";
            clsGeneCodeBase4Tab objGeneCodeBase4Tab = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);


            clsGeneCodeBase4View objGeneCodeBase4View = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);

            //string[] sstrTypeParas = strTypeParas.Split('|');

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
                    arrTabCheckStatus = arrTabCheckStatus.Where(x=>x.PrjDataBaseId == objGCPara.prjDataBaseId).ToList();
                    var objTabCheckStatus = arrTabCheckStatus.Find(x=>x.TabId == objGCPara.tabId);
                    bool bolIsNeedCheck = false;
                    if (objTabCheckStatus!= null && objTabCheckStatus.ErrorLevelId == 4)
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
            //           strMsg = string.Format("No.3 检查表：{0}结束!({3})",
            //strTabId, strViewId,
            //cnClassName,
            //clsStackTrace.GetCurrClassFunction());
            //           clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

            string strClassName = string.Format("AutoGCLib.{0}4{1}", objCodeType.CodeTypeENName, ltLangType);
            if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
            {        
                objGeneCodeBase4Tab = clsGeneCodeBase4Tab.GetClassByName(strClassName, objGCPara.tabId, objGCPara.prjDataBaseId, objGCPara.prjId);
                if (objGeneCodeBase4Tab == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
                objGeneCodeBase4Tab.CmPrjId = objGCPara.cmPrjId;
            }
            else if (objCodeType.DependsOn == "View")
            {
                objGeneCodeBase4View = clsGeneCodeBase4View.GetClassByName(strClassName, objGCPara.viewId, objGCPara.prjDataBaseId, objGCPara.prjId);
                if (objGeneCodeBase4View == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
                objGeneCodeBase4View.CmPrjId = objGCPara.cmPrjId;
            }
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objGCPara.cmPrjId);

            if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab.objPrjTabENEx.LangType = ltLangType;
                objGeneCodeBase4Tab.objPrjTabENEx.CodeTypeId = objGCPara.codeTypeId;
                objGeneCodeBase4Tab.objPrjTabENEx.ApplicationTypeId = objGCPara.applicationTypeId;
                objGeneCodeBase4Tab.objPrjTabENEx.UserId = objGCPara.gcUserId;
                
                strSqlDsTypeId = objGeneCodeBase4Tab.objPrjTabENEx.SqlDsTypeId;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objGCPara.tabId, objGCPara.prjId);
                objGCResult.tabName = objPrjTabEN.TabName;
                objGeneCodeBase4Tab.IsFstLcase = objCMProject.IsFstLcase;
            }
            else if (objCodeType.DependsOn == "View")
            {
                objGeneCodeBase4View.objViewInfoENEx.PrjDataBaseId = objGCPara.prjDataBaseId;
                objGeneCodeBase4View.objViewInfoENEx.LangType = ltLangType;
                objGeneCodeBase4View.objViewInfoENEx.CodeTypeId = objGCPara.codeTypeId;
                objGeneCodeBase4View.objViewInfoENEx.UserId = objGCPara.gcUserId;
             
                clsViewInfoEN objViewInfoEN = clsViewInfoBLEx.GetObjByViewIdCache(objGCPara.viewId, objGCPara.prjId);
                objGCResult.viewName = objViewInfoEN.ViewName;
                objGeneCodeBase4View.IsFstLcase = objCMProject.IsFstLcase;
            }
            
      

            try
            {
                string strJson = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
                {
                    strCodeText = objGeneCodeBase4Tab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                    strJson = JsonConvert.SerializeObject(objGeneCodeBase4Tab.objCodeElement_Root, Formatting.Indented);
                }
                else
                {
                    strCodeText = objGeneCodeBase4View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                    strJson = JsonConvert.SerializeObject(objGeneCodeBase4View.objCodeElement_Root, Formatting.Indented);
                }

          
                objGCResult.codeElementJson = strJson;
                objGCResult.codeText = strCodeText;
                objGCResult.re_ClsName = strRe_ClsName;
                objGCResult.re_FileNameWithModuleName = strRe_FileNameWithModuleName;
                objGCResult.version = clsSysParaEN_Local.strVersion;
            }
            catch (Exception objException)
            {
                clsPrjTabEN objPrjTab = null;
                if (string.IsNullOrEmpty(objGCPara.tabId) == false)
                {
                    objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objGCPara.tabId, objGCPara.prjId);
                }
                clsViewInfoEN objViewInfo = null;
                if (string.IsNullOrEmpty(objGCPara.viewId) == false)
                {
                    objViewInfo = clsViewInfoBL.GetObjByViewIdCache(objGCPara.viewId, objGCPara.prjId);
                }
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
                //if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
                //{

                //    clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, objGCPara.cmPrjId, objGCPara.applicationTypeId, objGCPara.gcUserId, clsSysParaEN_Local.strVersion);
                //}
                //else if (objCodeType.DependsOn == "View")
                //{
                //    clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objGeneCodeBase4View.objViewInfoENEx.ViewId, objGCPara.gcUserId, clsSysParaEN_Local.strVersion);
                //}
                //else
                //{
                //    clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, objGCPara.cmPrjId, objGCPara.applicationTypeId, objGCPara.gcUserId, clsSysParaEN_Local.strVersion);
                //}
            }
            //if (string.IsNullOrEmpty(strCodeText) == false) return strCodeText;
            //return "";
            return objGCResult;
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="cnClassName">类名</param>
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
        public static string GeneCode(clsPubConst.ClassName cnClassName,
        string strTypeParas,
        clsPubConst.LangType ltLangType,
        clsPubConst.DataBaseType dbtDataBaseType,
        string strTabId,
        string strViewId,
        string strCmPrjId,
        string strPrjId,
        string strPrjDataBaseId,
        int intApplicationTypeId,
        string strUserId,
        ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = "";
            string strMsg1 = "";
            if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
            {
                strMsg = string.Format("strPrjDataBaseId 不能为空!");
                throw new Exception(strMsg);
            }
            string strFunctionName = clsStackTrace.GetCurrClassFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strClassName", clsPubConst.GetClassNameStringByClassName(cnClassName));
            dictParam.Add("strTypeParas", strTypeParas);
            dictParam.Add("strLangType", clsPubConst.GetLangTypeStringByLangType(ltLangType));
            dictParam.Add("strDataBaseType", clsPubConst.GetDataBaseTypeStrByDataBaseType(dbtDataBaseType));
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strRe_ClsName", strRe_ClsName);
            dictParam.Add("strRe_FileNameWithModuleName", strRe_FileNameWithModuleName);
            clsPubVar4BLEx.Log4GCDebug("调用生成代码函数：", strFunctionName, strUserId, dictParam);

            clsProjectsEN objCurrSelProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strCodeText = "";
            clsGeneCodeBase4Tab objGeneCodeBase4Tab = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4View objGeneCodeBase4View = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4Tab autoGCPubFunc = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4Tab autoGC6Cs_Business = null;// new AutoGC6Cs_Business(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4Tab autoGC6Cs_BL4Mvc = null;// new AutoGC6Cs_Business(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4Tab objAutoGC6Cs_WS = null;// new AutoGC6Cs_WS(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4Tab objAutoGC6Cs_WApi = null;// new AutoGC6Cs_WS(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4Tab objAutoGC6_Controller = null;// new AutoGC6_Controller(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4Tab objAutoGC6_WA_Controller = null;// new AutoGC6_Controller(strTabId, strPrjDataBaseId);
            clsFuncModule_AgcEN objFuncModule = null;

            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBLEx.GetObjByClassNameAndLangTypeCache(cnClassName, ltLangType);

            string[] sstrTypeParas = strTypeParas.Split('|');
            
            //string strClassFName = "";
            string strSqlDsTypeId = "";
            clsGCResult objGCResult = new clsGCResult();
            objGCResult.codeTypeId = objCodeTypeEN.CodeTypeId;
            objGCResult.codeTypeName = objCodeTypeEN.CodeTypeName;
            objGCResult.codeTypeENName = objCodeTypeEN.CodeTypeENName;
            objGCResult.gcUserId = strUserId;
            objGCResult.errorId = 0;
            objGCResult.errorMsg = "";
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
                    objGCResult.errorMsg = strMsg;
                    objGCResult.errorId = 1;
                    objGCResult.re_ClsName = "";
                    objGCResult.re_FileNameWithModuleName = "";
                    objGCResult.version = clsSysParaEN_Local.strVersion;
                    return strMsg;

//                    throw new Exception(strMsg);
                }
                try
                {
                    //判断是否可以删除
                    var arrTabCheckStatus = clsTabCheckStatusBL.GetObjLstCache(strPrjId);
                    arrTabCheckStatus = arrTabCheckStatus.Where(x => x.PrjDataBaseId == strPrjDataBaseId).ToList();
                    var objTabCheckStatus = arrTabCheckStatus.Find(x => x.TabId == strTabId);
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
                        if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId, strPrjId, strPrjDataBaseId) == false)
                        {

                            throw new Exception("检查表字段不成功!");
                            //return false;
                        }
                    }
                }
                catch (Exception objException)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                    clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                    string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                    string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                    strMsg = string.Format("(errorId:0011)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                    objGCResult.errorMsg = strMsg;
                    objGCResult.errorId = 1;
                    objGCResult.re_ClsName = "";
                    objGCResult.re_FileNameWithModuleName = "";
                    objGCResult.version = clsSysParaEN_Local.strVersion;
                    throw objException;
                }
            }
            string strClassName = string.Format("AutoGCLib.{0}4{1}", cnClassName, ltLangType);
            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab = clsGeneCodeBase4Tab.GetClassByName(strClassName, strTabId, strPrjDataBaseId, strPrjId);
                if (objGeneCodeBase4Tab == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
                objGeneCodeBase4Tab.CmPrjId = strCmPrjId;
            }
            else if (objCodeTypeEN.DependsOn == "View")
            {
                objGeneCodeBase4View = clsGeneCodeBase4View.GetClassByName(strClassName, strViewId, strPrjDataBaseId, strPrjId);
                if (objGeneCodeBase4View == null)
                {
                    strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                    throw new Exception(strMsg);
                }
                objGeneCodeBase4View.CmPrjId = strCmPrjId;
            }
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            bool bolIsFstLcase;
            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab.objPrjTabENEx.LangType = ltLangType;
                objGeneCodeBase4Tab.objPrjTabENEx.CodeTypeId = objCodeTypeEN.CodeTypeId;
                
                strSqlDsTypeId = objGeneCodeBase4Tab.objPrjTabENEx.SqlDsTypeId;
                objGeneCodeBase4Tab.IsFstLcase = objCMProject.IsFstLcase;
                bolIsFstLcase = objGeneCodeBase4Tab.IsFstLcase;
            }
            else if (objCodeTypeEN.DependsOn == "View")
            {
                objGeneCodeBase4View.objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                objGeneCodeBase4View.objViewInfoENEx.LangType = ltLangType;
                objGeneCodeBase4View.objViewInfoENEx.CodeTypeId = objCodeTypeEN.CodeTypeId;
                objGeneCodeBase4View.IsFstLcase = objCMProject.IsFstLcase;
                bolIsFstLcase = objGeneCodeBase4View.IsFstLcase;
            }
       
            
            
            try
            {
                if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
                {
                    strCodeText = objGeneCodeBase4Tab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                }
                else
                {
                    strCodeText = objGeneCodeBase4View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                }   
            }
            catch (Exception objException)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;
                
                strMsg = string.Format("(errorId:005)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
                       strTabName, strViewName,
                      clsPubConst.GetClassNameStringByClassName(cnClassName),
                       objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                throw objException;
            }
            if (objCodeTypeEN.DependsOn == "Table" || objCodeTypeEN.DependsOn == "PureClass")
            {

                clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
            }
            else if (objCodeTypeEN.DependsOn == "View")
            {
                clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objGeneCodeBase4View.objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);
            }
            else
            {
                clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objGeneCodeBase4Tab.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
            }
            if (string.IsNullOrEmpty(strCodeText) == false) return strCodeText;
            switch (cnClassName)
            {

                case clsPubConst.ClassName.Dict_PageName_Dic:
                    try
                    {
                        objAutoGC6Cs_WS = new Dict_PageName_Dic6Cs(strPrjId,"","");
                        objAutoGC6Cs_WS.objProjectsENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6Cs_WS.objProjectsENEx.CurrDate = clsDateTime.getTodayStr(0);
                        objAutoGC6Cs_WS.objProjectsENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JAVA:
                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = "";  //已完成
                                strMsg1 = string.Format("(errorId:004)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                       ltLangType,
                                       cnClassName,
                                       clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:005)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:006)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.EntityLayer:
                    //AutoGC6Cs_M autoGC6Cs_M = null;// new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    switch (ltLangType)
                    {
                        case clsPubConst.LangType.CSharp://"C#.NET"
                            switch (dbtDataBaseType)
                            {
                                case clsPubConst.DataBaseType.MsSql:
                                    autoGCPubFunc = new EntityLayer4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.MySql:
                                    autoGCPubFunc = new EntityLayer4CSharp_MySql(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.Oracle:
                                    autoGCPubFunc = new AutoGC6Cs_M_Ora(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                            }
                            break;
                        case clsPubConst.LangType.JAVA:
                            autoGCPubFunc = new EntityLayer4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift3:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift4:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        //case clsPubConst.LangType.JavaScript:
                        //    autoGCPubFunc = new EntityLayer4JavaScript(strTabId, strViewId, strPrjDataBaseId, strPrjId);
                        //    break;
                        case clsPubConst.LangType.TypeScript:
                            autoGCPubFunc = new EntityLayer4TypeScript(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.SilverLight:
                            autoGCPubFunc = new AutoGC6SilverLight_M(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                    }
                    autoGCPubFunc.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                    autoGCPubFunc.objPrjTabENEx.LangType = ltLangType;
                    autoGCPubFunc.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                    //AutoGC6Cs_M autoGC6Cs_M = new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(autoGCPubFunc.objPrjTabENEx.FuncModuleAgcId, autoGCPubFunc.objPrjTabENEx.PrjId);
                    strSqlDsTypeId = autoGCPubFunc.objPrjTabENEx.SqlDsTypeId;

                    try
                    {

                        strCodeText = autoGCPubFunc.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);   //已完成     

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGCPubFunc.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:007)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
      strTabName, strViewName,
      clsPubConst.GetClassNameStringByClassName(cnClassName),
      objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);


                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.EntityLayerEx:
                    //AutoGC6Cs_M autoGC6Cs_M = null;// new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    switch (ltLangType)
                    {
                        case clsPubConst.LangType.CSharp://"C#.NET"
                            switch (dbtDataBaseType)
                            {
                                case clsPubConst.DataBaseType.MsSql:
                                    autoGCPubFunc = new EntityLayerEx4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.MySql:
                                    autoGCPubFunc = new EntityLayerEx4CSharp_MySql(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.Oracle:
                                    autoGCPubFunc = new AutoGC6Cs_M_Ora(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                            }
                            break;
                        case clsPubConst.LangType.JAVA:
                            autoGCPubFunc = new EntityLayerEx4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId,  strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift3:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift4:
                            autoGCPubFunc = new EntityLayerEx4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        //case clsPubConst.LangType.JavaScript:
                        //    autoGCPubFunc = new EntityLayerEx4JavaScript(strTabId, strViewId, strPrjDataBaseId, strPrjId);
                        //    break;
                        case clsPubConst.LangType.SilverLight:
                            autoGCPubFunc = new AutoGC6SilverLight_M(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                    }
                    autoGCPubFunc.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                    autoGCPubFunc.objPrjTabENEx.LangType = ltLangType;
                    autoGCPubFunc.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                    //AutoGC6Cs_M autoGC6Cs_M = new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(autoGCPubFunc.objPrjTabENEx.FuncModuleAgcId, autoGCPubFunc.objPrjTabENEx.PrjId);
                    strSqlDsTypeId = autoGCPubFunc.objPrjTabENEx.SqlDsTypeId;

                    try
                    {

                        strCodeText = autoGCPubFunc.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);   //已完成     

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGCPubFunc.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:007)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
      strTabName, strViewName,
      clsPubConst.GetClassNameStringByClassName(cnClassName),
      objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);


                        throw objException;
                    }
                    return strCodeText;



                case clsPubConst.ClassName.EntityLayer_Sim:
                    //AutoGC6Cs_M autoGC6Cs_M = null;// new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    switch (ltLangType)
                    {
                        case clsPubConst.LangType.CSharp://"C#.NET"
                            switch (dbtDataBaseType)
                            {
                                case clsPubConst.DataBaseType.MsSql:
                                    //autoGCPubFunc = new AutoGC6Cs_M(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.MySql:
                                    autoGCPubFunc = new EntityLayer4CSharp_MySql(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.Oracle:
                                    autoGCPubFunc = new AutoGC6Cs_M_Ora(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                            }
                            break;
                        case clsPubConst.LangType.JAVA:
                            autoGCPubFunc = new EntityLayer4JAVA(strTabId,  strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift3:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift4:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        //case clsPubConst.LangType.JavaScript:
                        //    autoGCPubFunc = new EntityLayer4JavaScript(strTabId, strViewId, strPrjDataBaseId, strPrjId);
                        //    break;
                        case clsPubConst.LangType.SilverLight:
                            autoGCPubFunc = new AutoGC6SilverLight_M(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                    }
                    autoGCPubFunc.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                    autoGCPubFunc.objPrjTabENEx.LangType = ltLangType;
                    autoGCPubFunc.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                    //AutoGC6Cs_M autoGC6Cs_M = new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(autoGCPubFunc.objPrjTabENEx.FuncModuleAgcId, autoGCPubFunc.objPrjTabENEx.PrjId);
                    strSqlDsTypeId = autoGCPubFunc.objPrjTabENEx.SqlDsTypeId;


                    try
                    {

                        strCodeText = autoGCPubFunc.A_GenEntityLayerCode_Sim(ref strRe_ClsName, ref strRe_FileNameWithModuleName);   //已完成        

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGCPubFunc.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:010)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
                            strTabName, strViewName,
                            clsPubConst.GetClassNameStringByClassName(cnClassName),
                            objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.CondEntityLayer:
                    //AutoGC6Cs_M autoGC6Cs_M = null;// new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    switch (ltLangType)
                    {
                        case clsPubConst.LangType.CSharp://"C#.NET"
                            switch (dbtDataBaseType)
                            {
                                case clsPubConst.DataBaseType.MsSql:
                                    autoGCPubFunc = new AutoGC6Cs_M(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.MySql:
                                    autoGCPubFunc = new EntityLayer4CSharp_MySql(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.Oracle:
                                    autoGCPubFunc = new AutoGC6Cs_M_Ora(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                            }
                            break;
                        case clsPubConst.LangType.JAVA:
                            autoGCPubFunc = new EntityLayer4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift3:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift4:
                            autoGCPubFunc = new EntityLayer4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        //case clsPubConst.LangType.JavaScript:
                        //    autoGCPubFunc = new EntityLayer4JavaScript(strTabId, strViewId, strPrjDataBaseId, strPrjId);
                        //    break;
                        case clsPubConst.LangType.SilverLight:
                            autoGCPubFunc = new AutoGC6SilverLight_M(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                    }
                    autoGCPubFunc.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                    autoGCPubFunc.objPrjTabENEx.LangType = ltLangType;
                    autoGCPubFunc.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                    //AutoGC6Cs_M autoGC6Cs_M = new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(autoGCPubFunc.objPrjTabENEx.FuncModuleAgcId, autoGCPubFunc.objPrjTabENEx.PrjId);
                    strSqlDsTypeId = autoGCPubFunc.objPrjTabENEx.SqlDsTypeId;


                    try
                    {

                        strCodeText = autoGCPubFunc.A_GenEntityLayerCode_Cond(ref strRe_ClsName, ref strRe_FileNameWithModuleName);   //已完成    

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGCPubFunc.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:011)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.DALCode:

                    switch (ltLangType)
                    {
                        case clsPubConst.LangType.CSharp://"C#.NET"
                            switch (dbtDataBaseType)
                            {
                                case clsPubConst.DataBaseType.MsSql:
                                    autoGCPubFunc = new DALCode4CSharp(strTabId,  strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.MySql:
                                    autoGCPubFunc = new DALCode4CSharp_MySql(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.Oracle:
                                    autoGCPubFunc = new AutoGC6Cs_M_Ora(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                            }
                            break;
                        case clsPubConst.LangType.JAVA:
                            autoGCPubFunc = new DALCode4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift:
                        case clsPubConst.LangType.Swift3:
                        case clsPubConst.LangType.Swift4:
                            strMsg = string.Format("(errorId:012)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                           ltLangType,
                                           cnClassName,
                                           clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                        case clsPubConst.LangType.JavaScript:
                            strMsg = string.Format("(errorId:013)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                       ltLangType,
                                                                       cnClassName,
                                                                       clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                    autoGCPubFunc.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                    autoGCPubFunc.objPrjTabENEx.LangType = ltLangType;
                    autoGCPubFunc.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                    //AutoGC6Cs_M autoGC6Cs_M = new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(autoGCPubFunc.objPrjTabENEx.FuncModuleAgcId, autoGCPubFunc.objPrjTabENEx.PrjId);
                    strSqlDsTypeId = autoGCPubFunc.objPrjTabENEx.SqlDsTypeId;
                    try
                    {

                        strCodeText = autoGCPubFunc.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);   //已完成    

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGCPubFunc.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:014)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.DALExCode:

                    switch (ltLangType)
                    {
                        case clsPubConst.LangType.CSharp://"C#.NET"
                            switch (dbtDataBaseType)
                            {
                                case clsPubConst.DataBaseType.MsSql:
                                    autoGCPubFunc = new AutoGC6Cs_M(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.MySql:
                                    autoGCPubFunc = new EntityLayer4CSharp_MySql(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                                case clsPubConst.DataBaseType.Oracle:
                                    autoGCPubFunc = new AutoGC6Cs_M_Ora(strTabId, strPrjDataBaseId, strPrjId);
                                    break;
                            }
                            break;
                        case clsPubConst.LangType.JAVA:
                            autoGCPubFunc = new EntityLayer4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                            break;
                        case clsPubConst.LangType.Swift:
                        case clsPubConst.LangType.Swift3:
                        case clsPubConst.LangType.Swift4:
                            strMsg = string.Format("(errorId:015)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                           ltLangType,
                                           cnClassName,
                                           clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                        case clsPubConst.LangType.JavaScript:
                            strMsg = string.Format("(errorId:016)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                       ltLangType,
                                                                       cnClassName,
                                                                       clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                    autoGCPubFunc.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                    autoGCPubFunc.objPrjTabENEx.LangType = ltLangType;
                    autoGCPubFunc.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                    //AutoGC6Cs_M autoGC6Cs_M = new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                    objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(autoGCPubFunc.objPrjTabENEx.FuncModuleAgcId, autoGCPubFunc.objPrjTabENEx.PrjId);
                    strSqlDsTypeId = autoGCPubFunc.objPrjTabENEx.SqlDsTypeId;
                    try
                    {

                        strCodeText = autoGCPubFunc.A_GenDALExCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);   //已完成                

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGCPubFunc.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:017)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.BusinessLogic:
                    try
                    {
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                autoGC6Cs_Business = new BusinessLogic4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                                break;
                            case clsPubConst.LangType.JAVA:
                                autoGC6Cs_Business = new BusinessLogic4JAVA(strTabId, strPrjDataBaseId, strPrjId);

                                break;
                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                autoGC6Cs_Business = new BusinessLogic4Swift4(strTabId, strPrjDataBaseId, strPrjId);
                                break;
                            //case clsPubConst.LangType.JavaScript:
                            //    autoGC6Cs_Business = new BusinessLogic4JavaScript(strTabId, strViewId, strPrjDataBaseId, strPrjId);
                            //    break;
                            case clsPubConst.LangType.TypeScript:
                                autoGC6Cs_Business = new BusinessLogic4TypeScript(strTabId, strPrjDataBaseId, strPrjId);

                                break;
                            case clsPubConst.LangType.SilverLight:
                                //strCodeText = autoGC6Cs_Business.A_GenBusinessLogicCode_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName);  //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:018)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }
                        autoGC6Cs_Business.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        autoGC6Cs_Business.objPrjTabENEx.LangType = ltLangType;
                        autoGC6Cs_Business.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = autoGC6Cs_Business.objPrjTabENEx.SqlDsTypeId;

                        strCodeText = autoGC6Cs_Business.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                        
                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGC6Cs_Business.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:019)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.BusinessLogic4Mvc:
                    try
                    {
                        autoGC6Cs_BL4Mvc = new BusinessLogic4Mvc4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                        autoGC6Cs_BL4Mvc.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        autoGC6Cs_BL4Mvc.objPrjTabENEx.LangType = ltLangType;
                        autoGC6Cs_BL4Mvc.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = autoGC6Cs_BL4Mvc.objPrjTabENEx.SqlDsTypeId;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                switch (dbtDataBaseType)
                                {
                                    case clsPubConst.DataBaseType.MsSql:
                                        //  autoGCPubFunc = new AutoGC6Cs_M(strTabId, strPrjDataBaseId);
                                        strCodeText = autoGC6Cs_BL4Mvc.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                        break;
                                    case clsPubConst.DataBaseType.MySql:

                                        strCodeText = autoGC6Cs_BL4Mvc.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                        break;
                                    case clsPubConst.DataBaseType.Oracle:
                                        AutoGC6Cs_BL_Ora autoGC6Cs_BL_Ora = new AutoGC6Cs_BL_Ora(strTabId, strPrjDataBaseId, strPrjId);
                                        strCodeText = autoGC6Cs_BL_Ora.A_GenBusinessLogicCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                        break;
                                }


                                break;
                            case clsPubConst.LangType.JAVA:
                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.Swift:

                            case clsPubConst.LangType.Swift3:

                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JavaScript:
                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:018)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(autoGC6Cs_BL4Mvc.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:019)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WA_Srv:
                    try
                    {
                        objAutoGC6Cs_WApi = new WA_Srv4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6Cs_WApi.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6Cs_WApi.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6Cs_WApi.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6Cs_WApi.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JAVA:
                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = "";  //已完成
                                strMsg1 = string.Format("(errorId:022)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                        ltLangType,
                                        cnClassName,
                                        clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:023)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6Cs_WApi.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:024)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WS_Srv:
                    try
                    {
                        objAutoGC6Cs_WS = new WS_Srv4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6Cs_WS.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6Cs_WS.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6Cs_WS.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6Cs_WS.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JAVA:
                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = "";  //已完成
                                strMsg1 = string.Format("(errorId:022)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                        ltLangType,
                                        cnClassName,
                                        clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:023)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6Cs_WS.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:024)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WS_Srv4Front:
                    try
                    {
                        objAutoGC6Cs_WS = new WS_Srv4Front4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6Cs_WS.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6Cs_WS.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6Cs_WS.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6Cs_WS.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JAVA:
                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = "";  //已完成
                                strMsg1 = string.Format("(errorId:025)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                       ltLangType,
                                       cnClassName,
                                       clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:026)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6Cs_WS.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:027)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WS_Access:
                    try
                    {
                        objAutoGC6Cs_WS = new WS_Access4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6Cs_WS.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6Cs_WS.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6Cs_WS.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JAVA:

                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:

                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:028)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6Cs_WS.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:029)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WA_Access:
                    try
                    {
                        objAutoGC6Cs_WApi = new WA_Access4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6Cs_WApi.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6Cs_WApi.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6Cs_WApi.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JAVA:

                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:

                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.TypeScript:

                                strCodeText = objAutoGC6Cs_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.SilverLight:
                                strCodeText = "";  //已完成
                                strMsg1 = string.Format("(errorId:025)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                       ltLangType,
                                       cnClassName,
                                       clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:028)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }


                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6Cs_WApi.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:029)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WS_AccessHigh:
                    try
                    {
                        objAutoGC6_Controller = new WS_AccessHigh4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:030)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:
                                //strMsg1 = string.Format("(errorId:031)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:032)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:033)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WA_AccessHigh:
                    try
                    {
                        objAutoGC6_WA_Controller = new WA_AccessHigh4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WA_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WA_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:030)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                strCodeText = objAutoGC6_WA_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
     ltLangType,
     cnClassName,
     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenTableObjWSController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
     ltLangType,
     cnClassName,
     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenTableObjWSController_Swift3(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenTableObjWSController_Swift4(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.JavaScript:
                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenTableObjWSController_JavaScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenTableObjWSController_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            default:
                                strMsg = string.Format("(errorId:032)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        
                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WA_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:033)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.AppController:
                    try
                    {
                        objAutoGC6_Controller = new AppController4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:034)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:036)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:037)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WA_AppController:
                    try
                    {
                        objAutoGC6_WA_Controller = new WA_AppController4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WA_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WA_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:034)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_WA_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift3:

                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift3(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift4(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_JavaScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            default:
                                strMsg = string.Format("(errorId:036)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }


                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WA_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:037)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());

                       
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppBusiness:
                    try
                    {
                        objAutoGC6_Controller = new AppBusiness4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:034)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:035)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:036)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }


                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:0371)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
               
                case clsPubConst.ClassName.AppViewUnitTest:
                    try
                    {
                        objAutoGC6_Controller = new AppViewUnitTest4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:042)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:043)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:044)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }


                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:045)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);


                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WA_AppViewUT:
                    try
                    {
                        objAutoGC6_WA_Controller = new WA_AppViewUT4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WA_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WA_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:042)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:043)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_WA_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:043)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:043)语言类型：{0}没有生成类:[{1}]的功能!({2})",
     ltLangType,
     cnClassName,
     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift3_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:043)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift4_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.JavaScript:
                                strMsg1 = string.Format("(errorId:043)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_JavaScript_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:043)语言类型：{0}没有生成类:[{1}]的功能!({2})",
     ltLangType,
     cnClassName,
     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            default:
                                strMsg = string.Format("(errorId:044)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WA_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:045)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                                       

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewDdlBind:
                    try
                    {
                        objAutoGC6_Controller = new AppViewDdlBind4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:046)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:047)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                //strCodeText = objAutoGC6_Controller.A_GenController_Swift4_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                //strCodeText = objAutoGC6_Controller.A_GenController_JavaScript_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                //strCodeText = objAutoGC6_Controller.A_GenController_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:048)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:049)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                        
                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewDdlAdapter:
                    try
                    {
                        objAutoGC6_Controller = new AppViewDdlAdapter4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:050)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:051)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift:

                                //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                //strCodeText = objAutoGC6_Controller.A_GenController_Swift4_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                //strCodeText = objAutoGC6_Controller.A_GenController_JavaScript_UnitTest(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                //strCodeText = objAutoGC6_Controller.A_GenController_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:052)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        
                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:053)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                        
                        throw objException;
                    }
                    return strCodeText;


                case clsPubConst.ClassName.AppViewUTScript:
                    try
                    {
                        objAutoGC6_Controller = new AppViewUTScript4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:058)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_Controller.A_GenController_Java_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        
                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WA_AppViewUTScript:
                    try
                    {
                        objAutoGC6_WA_Controller = new WA_AppViewUTScript4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WA_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WA_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:058)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WA_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_WA_Controller.A_GenController_Java_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                                //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //break;
                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift4_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_JavaScript_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        
                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WA_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);


                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WA_ViewUTScript:
                    try
                    {
                        clsGeneCodeBase4Tab objAutoGC6_WApi = new WA_ViewUTScript4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WApi.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WApi.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WApi.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WApi.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_Controller.A_GenController_Java_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WApi.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WA_ViewUTScript_TS:
                    try
                    {
                        clsGeneCodeBase4Tab objAutoGC6_WApi = new WA_ViewUTScript_TS4Html(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WApi.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WApi.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WApi.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WApi.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_Controller.A_GenController_Java_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        
                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WApi.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WA_ViewScript_TS://WApi界面脚本_TS
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        WA_ViewScript_TS4Html objAutoGC6_WApi_View = new WA_ViewScript_TS4Html(strViewId);
                        //objAutoGC6_WApi_View.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objViewInfoENEx.LangType = ltLangType;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_Controller.A_GenController_Java_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WA_ViewUTScriptCS://WApi界面单元测试脚本后台
                    try
                    {
                        clsGeneCodeBase4Tab objAutoGC6_WApi = new WA_ViewUTScriptCS4CSharp(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WApi.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WApi.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WApi.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WApi.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_Controller.A_GenController_Java_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }



                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WApi.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WA_ViewUTScriptCS_TS://WApi界面单元测试脚本后台_TS
                    try
                    {
                        clsGeneCodeBase4Tab objAutoGC6_WApi = new WA_ViewUTScriptCS_TS4TypeScript(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WApi.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WApi.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WApi.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WApi.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_Controller.A_GenController_Java_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.TypeScript:
                                strCodeText = objAutoGC6_WApi.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }


                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WApi.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WA_ViewScriptCS_TS://WApi界面脚本后台_TS
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
                        WA_ViewScript_TS4Html objAutoGC6_WApi_View = new WA_ViewScript_TS4Html(strViewId);
                        objViewInfoENEx.LangType = ltLangType;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:059)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                                                                                                                  //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                  ltLangType,
                                  cnClassName,
                                  clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:061)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_Controller.A_GenController_Swift3_UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:

                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.TypeScript:
                                strCodeText = objAutoGC6_WApi_View.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:060)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:062)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objViewInfoENEx.ViewId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:063)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

          
                case clsPubConst.ClassName.AppViewUTScriptCS:
                    try
                    {
                        objAutoGC6_Controller = new AppViewUTScriptCS4JAVA(strTabId,  strPrjDataBaseId, strPrjId);
                        objAutoGC6_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:070)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:071)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_Controller.A_GenController_Java_UTScriptCS(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:072)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                        
                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:073)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WA_AppViewUTScriptCS:
                    try
                    {
                        objAutoGC6_WA_Controller = new WA_AppViewUTScriptCS4JAVA(strTabId, strPrjDataBaseId, strPrjId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_WA_Controller.objPrjTabENEx.LangType = ltLangType;
                        objAutoGC6_WA_Controller.objPrjTabENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        strSqlDsTypeId = objAutoGC6_WA_Controller.objPrjTabENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strMsg1 = string.Format("(errorId:070)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //strMsg1 = string.Format("(errorId:071)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                //if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                //{
                                strCodeText = objAutoGC6_WA_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                //else
                                //{
                                //    strCodeText = objAutoGC6_WA_Controller.A_GenController_Java_UTScriptCS(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                //}
                                break;
                            case clsPubConst.LangType.Swift:
                                strMsg1 = string.Format("(errorId:071)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift3:
                                strMsg1 = string.Format("(errorId:071)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift3_UTScriptCS(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:071)语言类型：{0}没有生成类:[{1}]的功能!({2})",
     ltLangType,
     cnClassName,
     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_Swift4_UTScriptCS(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.JavaScript:
                                strMsg1 = string.Format("(errorId:071)语言类型：{0}没有生成类:[{1}]的功能!({2})",
     ltLangType,
     cnClassName,
     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_JavaScript_UTScriptCS(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.SilverLight:
                                strMsg1 = string.Format("(errorId:071)语言类型：{0}没有生成类:[{1}]的功能!({2})",
     ltLangType,
     cnClassName,
     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            //strCodeText = objAutoGC6_WA_Controller.A_GenController_SilverLight(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            default:
                                strMsg = string.Format("(errorId:072)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }


                        clsLog4GeneTabCodeBLEx.AddLog4GeneTabCode(objAutoGC6_WA_Controller.objPrjTabENEx.TabId, strCmPrjId, intApplicationTypeId, strUserId, clsSysParaEN_Local.strVersion);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:073)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
      

                case clsPubConst.ClassName.WebViewCode:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        clsGeneCodeBase4View autoGC6Cs_VWeb = new WebViewCode4Html(strViewId, strPrjDataBaseId, strPrjId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strCodeText = autoGC6Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:078)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:079)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:080)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:081)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:082)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:083)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewScriptMain:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:084)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:085)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:086)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:087)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:088)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:089)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewScriptContent:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:090)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.A_GenViewCode_Web(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:091)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:092)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:093)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:094)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:095)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.AppViewScriptCS:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:096)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.A_GenAppViewScriptCS(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:097)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:098)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:099)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:100)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:101)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                        
                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewQryScript:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:102)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.A_GenAppViewUC_QryScript(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:103)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:104)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:105)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:106)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:107)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                        
                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewEdtScript:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:108)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.A_GenAppViewUCEdtScript(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:109)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:110)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:111)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:112)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:113)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewLvItemScript:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:114)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.A_GenAppViewLvItemScript(objViewInfoENEx, objViewInfoENEx.TabName_Out, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:115)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:116)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:117)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:118)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:119)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                        
                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewLvHeadScript:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:120)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.A_GenAppViewLvHeadScript(objViewInfoENEx, objViewInfoENEx.TabName_Out, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:121)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:122)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:123)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:124)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:125)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewListViewAdapter:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        AppViewScriptMain4JAVA autoGC6Java_AppWiew = new AppViewScriptMain4JAVA(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                strMsg1 = string.Format("(errorId:126)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JAVA:
                                strCodeText = autoGC6Java_AppWiew.A_GenAppViewListViewAdapter(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:127)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:128)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:129)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:130)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:131)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.Mvc_View:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        Mvc_View4CSharp autoGC6Cs_VWeb = new Mvc_View4CSharp(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = autoGC6Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:133)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:134)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);


                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:135)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:136)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:137)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;


                case clsPubConst.ClassName.Mvc_ViewLstAjax:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        Mvc_View4CSharp autoGC6Cs_VWeb = new Mvc_View4CSharp(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = autoGC6Cs_VWeb.A_GenMvcViewLstAjax(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:133)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:134)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);


                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:135)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:136)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:147)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                        
                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.Mvc_Controller:
                    try
                    {
                        bolIsFstLcase = true;   
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        Mvc_Controller4CSharp autoGC6Cs_VWeb = new Mvc_Controller4CSharp(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = autoGC6Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:133)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:134)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);


                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:135)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:136)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:157)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.Mvc_ModelEx:
                    try
                    {
                        bolIsFstLcase = true;   
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        Mvc_Model_View4CSharp autoGC6Cs_VWeb = new Mvc_Model_View4CSharp(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = autoGC6Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:133)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:134)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);


                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:135)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:136)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:167)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.Mvc_Model4Query:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        Mvc_Model_View4CSharp autoGC6Cs_VWeb = new Mvc_Model_View4CSharp(strViewId);
                        objViewInfoENEx.LangType = ltLangType;
                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = autoGC6Cs_VWeb.A_GenMvcModel4Query(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:132)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:133)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:134)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);


                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:135)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                               ltLangType,
                                                               cnClassName,
                                                               clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:136)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:177)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WebViewControlCode:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        WebCtlControlCode4CSharp autoGC6Cs_CWeb = new WebCtlControlCode4CSharp(strViewId);
                        WebCtlControlCode4CSharp autoGC7Cs_CWeb = new WebCtlControlCode4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                if (strTypeParas == "UserDefineFunc")
                                {
                                    //strCodeText = autoGC7Cs_CWeb.A_GenViewCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                }
                                else
                                {
                                    strCodeText = autoGC6Cs_CWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                }
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:138)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:139)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                            ltLangType,
                                                            cnClassName,
                                                            clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:140)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:141)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            default:
                                strMsg = string.Format("(errorId:142)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:143)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);


                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WebCtlViewCode:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
                        WebCtlViewCode4Html autoGC6Cs_VWeb = new WebCtlViewCode4Html(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                strCodeText = autoGC6Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:144)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:145)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                            ltLangType,
                                                            cnClassName,
                                                            clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:146)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:147)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:148)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);


                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:149)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WebCtlViewCode4Gv:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
                        clsGeneCodeBase4View autoGC6Cs_VWeb = new WebViewCode4Html( strViewId, strPrjDataBaseId, strPrjId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                //strCodeText = autoGC6Cs_VWeb.A_Gen_wucTabName4Gv(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:150)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:
                                strMsg1 = string.Format("(errorId:151)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                            ltLangType,
                                                            cnClassName,
                                                            clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:152)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:153)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:154)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);


                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:155)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WebCtlControlCode:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;

                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        WebCtlControlCode4CSharp autoGC6Cs_CWeb = new WebCtlControlCode4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                //strCodeText = autoGC6Cs_CWeb.A_GenCtlControlCodeforTab(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                                break;
                            case clsPubConst.LangType.JAVA:


                                strMsg1 = string.Format("(errorId:155)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:156)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:157)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:158)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:159)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);


                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:160)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WebCtlControlCode4Gv:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;

                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        WebCtlControlCode4CSharp autoGC6Cs_CWeb = new WebCtlControlCode4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                //strCodeText = autoGC6Cs_CWeb.A_Gen_wucTabName4Gv(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                                break;
                            case clsPubConst.LangType.JAVA:


                                strMsg1 = string.Format("(errorId:161)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:162)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:163)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:164)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:165)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);


                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:166)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WinViewCode_QD:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
                        //objViewInfoENEx.ViewTypeCode = (int)enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;

                        WinViewCode_QD4CSharp autoGC6Cs_VWin = new WinViewCode_QD4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                                objViewInfoENEx.IsDesign = false;
                                strCodeText = autoGC6Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                                //strCodeText = autoGC6Cs_VWeb.A_GenViewCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:167)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:168)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:
                                strMsg1 = string.Format("(errorId:169)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:170)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:171)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:172)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WinViewCode_QD_Gv:
                    try
                    {
                        bolIsFstLcase = true;   
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
                        //objViewInfoENEx.ViewTypeCode = (int)enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20;

                        WinViewCode_QD4CSharp autoGC6Cs_VWin = new WinViewCode_QD4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                                objViewInfoENEx.IsDesign = false;
                                strCodeText = autoGC6Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                                //strCodeText = autoGC6Cs_VWeb.A_GenViewCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:167)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:168)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:
                                strMsg1 = string.Format("(errorId:169)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:170)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:171)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:182)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);


                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WinViewCode_QD_Design:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
                        //objViewInfoENEx.ViewTypeCode = (int)enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;

                        WinViewCode_QD4CSharp autoGC6Cs_VWin = new WinViewCode_QD4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                //                            objViewInfoENEx.CurrUserName = strUserName;
                                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                                objViewInfoENEx.IsDesign = true;
                                //是否使用控件
                                //objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                                strCodeText = autoGC6Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:173)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:174)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                        ltLangType,
                                                        cnClassName,
                                                        clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:175)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:176)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:177)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:178)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

                case clsPubConst.ClassName.WinViewCode_QD_Gv_Design:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
                        //objViewInfoENEx.ViewTypeCode = (int)enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20;

                        WinViewCode_QD4CSharp autoGC6Cs_VWin = new WinViewCode_QD4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:
                                //                            objViewInfoENEx.CurrUserName = strUserName;
                                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.MainView;

                                objViewInfoENEx.IsDesign = true;
                                //是否使用控件
                                //objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                                strCodeText = autoGC6Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:173)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:174)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                        ltLangType,
                                                        cnClassName,
                                                        clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:175)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:176)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:177)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:188)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WinViewCode_UI:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        WinViewCode_QD4CSharp autoGC6Cs_VWin = new WinViewCode_QD4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                                objViewInfoENEx.IsDesign = false;
                                //是否使用控件
                                //objViewInfoENEx.IsUseCtl = bolIsUseCtl;

                                strCodeText = autoGC6Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:179)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                    ltLangType,
                                    cnClassName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);


                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:180)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                        ltLangType,
                                                        cnClassName,
                                                        clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:181)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:182)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:183)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);

                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:184)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.WinViewCode_UI_Design:
                    try
                    {
                        bolIsFstLcase = true;
                        clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                        clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, bolIsFstLcase, strPrjId);
                        objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
                        objViewInfoENEx.LangType = ltLangType;
                        objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        WinViewCode_QD4CSharp autoGC6Cs_VWin = new WinViewCode_QD4CSharp(strViewId);

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                objViewInfoENEx.MainSubViewType = clsPubConst.MainSubViewType.SubView;

                                objViewInfoENEx.IsDesign = true;
                                strCodeText = autoGC6Cs_VWin.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                                break;
                            case clsPubConst.LangType.JAVA:

                                strMsg1 = string.Format("(errorId:185)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                ltLangType,
                                cnClassName,
                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.Swift:
                            case clsPubConst.LangType.Swift3:
                            case clsPubConst.LangType.Swift4:

                                strMsg1 = string.Format("(errorId:186)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                        ltLangType,
                                                        cnClassName,
                                                        clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            case clsPubConst.LangType.JavaScript:

                                strMsg1 = string.Format("(errorId:187)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.SilverLight:

                                strMsg1 = string.Format("(errorId:188)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                                                ltLangType,
                                                                cnClassName,
                                                                clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);
                            default:
                                strMsg = string.Format("(errorId:189)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                        clsLog4GeneViewCodeBLEx.AddLog4GeneViewCode(objViewInfoENEx.ViewId, strUserId, clsSysParaEN_Local.strVersion);

                        
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                        string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                        strMsg = string.Format("(errorId:190)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
    strTabName, strViewName,
    clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                        
                        throw objException;
                    }
                    return strCodeText;
                default:
                    strMsg = string.Format("(errorId:216)代码类型：{0}在相应函数中没有被处理!({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 专门为自建的WS_Srv地址,生成相关的操作代码
        /// </summary>
        /// <param name="cnClassName">类名</param>
        /// <param name="strTypeParas">类型类型</param>
        /// <param name="ltLangType">语言</param>
        /// <param name="dbtDataBaseType">数据库类型</param>
        /// <param name="strWebSrvClassId">自建的WS_Srv的类Id</param>
        /// <param name="strPrjId">工程</param>
        /// <param name="strPrjDataBaseId"></param>
        /// <param name="strUserId"></param>
        /// <param name="strRe_ClsName"></param>
        /// <param name="strRe_FileNameWithModuleName"></param>
        /// <returns></returns>
        public static string GeneCode4SelfCreateWs(clsPubConst.ClassName cnClassName,
            string strTypeParas,
          clsPubConst.LangType ltLangType,
          clsPubConst.DataBaseType dbtDataBaseType,
          string strWebSrvClassId,
          string strPrjId,
          string strPrjDataBaseId,
          string strUserId,
          ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            clsProjectsEN objCurrSelProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strCodeText = "";
            clsGCBase objGeneCodeBase = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);

            //AutoGCPubFuncV6 autoGCPubFunc = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            //AutoGC6Cs_Business autoGC6Cs_Business = null;// new AutoGC6Cs_Business(strTabId, strPrjDataBaseId);
            clsGCBase objAutoGC6Cs_WS = null;// new AutoGC6Cs_WS(strTabId, strPrjDataBaseId);
            clsGCBase objAutoGC6_Controller = null;// new AutoGC6_Controller(strTabId, strPrjDataBaseId);
            string[] sstrTypeParas = strTypeParas.Split('|');

            string strMsg = "";
            string strClassName = string.Format("AutoGCLib.{0}_UDF4{1}", cnClassName, ltLangType);
            objGeneCodeBase = clsGeneCodeBase4Tab.GetClassByName(strClassName);
            if (objGeneCodeBase == null)
            {
                strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                throw new Exception(strMsg);
            }
            objAutoGC6Cs_WS.WebSrvClassId = strWebSrvClassId;
            objAutoGC6Cs_WS.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
            objAutoGC6Cs_WS.objWebSrvClassENEx.LangType = ltLangType;
            objAutoGC6Cs_WS.objWebSrvClassENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

            try
            {
                strCodeText = objGeneCodeBase.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errorId:006)在WebSrvClassId:[{0}],类名：[{1}]时出错!错误：{2}.({3})",
                       strWebSrvClassId,
                      clsPubConst.GetClassNameStringByClassName(cnClassName),
                       objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                throw objException;
            }
            if (string.IsNullOrEmpty(strCodeText) == false) return strCodeText;

            switch (cnClassName)
            {
                //                case clsPubConst.ClassName.WS_Access:
                //                    try
                //                    {
                //                        objAutoGC6Cs_WS = new AutoGC6Cs_WS();
                //                        objAutoGC6Cs_WS.WebSrvClassId = strWebSrvClassId;
                //                        objAutoGC6Cs_WS.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                //                        objAutoGC6Cs_WS.objWebSrvClassENEx.LangType = ltLangType;
                //                        objAutoGC6Cs_WS.objWebSrvClassENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                //                        switch (ltLangType)
                //                        {
                //                            case clsPubConst.LangType.CSharp:

                //                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                //                                break;
                //                            case clsPubConst.LangType.JAVA:

                //                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                //                                break;
                //                            case clsPubConst.LangType.Swift:
                //                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                //                                break;
                //                            case clsPubConst.LangType.Swift3:
                //                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                //                                break;
                //                            case clsPubConst.LangType.Swift4:
                //                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                //                                break;
                //                            case clsPubConst.LangType.JavaScript:

                //                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                //                                break;
                //                            case clsPubConst.LangType.SilverLight:

                //                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                //                                break;
                //                            default:
                //                                strMsg = string.Format("(errorId:191)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                //                                throw new Exception(strMsg);
                //                        }
                //                    }
                //                    catch (Exception objException)
                //                    {
                //                        strMsg = string.Format("(errorId:192)在生成Web类Id:[{0}],函数类名：[{1}]时出错!错误：{2}.({3})",
                //strWebSrvClassId,
                //        clsPubConst.GetClassNameStringByClassName(cnClassName),
                //    objException.Message, clsStackTrace.GetCurrClassFunction());
                //                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                //                        throw objException;
                //                    }
                //                    return strCodeText;
                case clsPubConst.ClassName.WS_AccessHigh:
                    try
                    {
                        objAutoGC6_Controller = new WS_AccessHigh_UDF4JAVA("","","");
                        objAutoGC6_Controller.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_Controller.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        objAutoGC6_Controller.objWebSrvClassENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objWebSrvClassENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:193)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //string strMsg1 = string.Format("(errorId:194)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:195)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                    }
                    catch (Exception objException)
                    {
                        strMsg = string.Format("(errorId:196)在生成Web类Id:[{0}],函数类名：[{1}]时出错!错误：{2}.({3})",
                        strWebSrvClassId,
                                clsPubConst.GetClassNameStringByClassName(cnClassName),
                            objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppController:
                    try
                    {
                        objAutoGC6_Controller = new AppController_UDF4JAVA("", "", "");
                        objAutoGC6_Controller.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_Controller.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_Controller.objWebSrvClassENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objWebSrvClassENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:197)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //string strMsg1 = string.Format("(errorId:198)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:199)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                    }
                    catch (Exception objException)
                    {
                        strMsg = string.Format("(errorId:200)在生成Web类Id:[{0}],函数类名：[{1}]时出错!错误：{2}.({3})",
strWebSrvClassId,
        clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewUnitTest:
                    try
                    {
                        objAutoGC6_Controller = new AppViewUnitTest_UDF4JAVA("","","");
                        objAutoGC6_Controller.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_Controller.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_Controller.objWebSrvClassENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objWebSrvClassENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:202)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //string strMsg1 = string.Format("(errorId:203)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     cnClassName,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:204)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }

                    }
                    catch (Exception objException)
                    {
                        strMsg = string.Format("(errorId:205)在生成Web类Id:[{0}],函数类名：[{1}]时出错!错误：{2}.({3})",
strWebSrvClassId,
        clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewUTScript:
                    try
                    {
                        objAutoGC6_Controller = new AppViewUTScript_UDF4JAVA("","","");
                        objAutoGC6_Controller.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_Controller.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_Controller.objWebSrvClassENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objWebSrvClassENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:206)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:
                                if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                {
                                    strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                }
                                else
                                {
                                    strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                }
                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift3:
                                string strMsg2 = string.Format("(errorId:207)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 cnClassName,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg2);
                            //                                strCodeText = objAutoGC6_Controller.A_GenController_Swift3_SelfDefWs4UTScript(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                            case clsPubConst.LangType.Swift4:
                                //string strMsg3 = string.Format("(errorId:208)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //       ltLangType,
                                //       cnClassName,
                                //       clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg3);
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成

                                break;
                            case clsPubConst.LangType.SilverLight:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:209)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                    catch (Exception objException)
                    {
                        strMsg = string.Format("(errorId:210)在生成Web类Id:[{0}],函数类名：[{1}]时出错!错误：{2}.({3})",
strWebSrvClassId,
        clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case clsPubConst.ClassName.AppViewUTScriptCS:
                    try
                    {
                        objAutoGC6_Controller = new AppViewUTScriptCS_UDF4JAVA("","","");
                        objAutoGC6_Controller.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_Controller.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_Controller.objWebSrvClassENEx.LangType = ltLangType;
                        objAutoGC6_Controller.objWebSrvClassENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:212)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     cnClassName,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:
                                if (sstrTypeParas.Contains(clsAppPageTypeBL.GetObjByAppPageTypeId(enumAppPageType.TabsPage_0001).AppPageTypeENName))
                                {
                                    strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                }
                                else
                                {
                                    strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                }
                                break;
                            case clsPubConst.LangType.Swift:
                                string strMsg2 = string.Format("(errorId:213)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   cnClassName,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg2);
                            //                                strCodeText = objAutoGC6_Controller.A_GenController_Swift_SelfDefWs4UTScriptCS(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                            //break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strCodeText = objAutoGC6_Controller.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
                                break;
                            default:
                                strMsg = string.Format("(errorId:214)语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                    catch (Exception objException)
                    {
                        strMsg = string.Format("(errorId:215)在生成Web类Id:[{0}],函数类名：[{1}]时出错!错误：{2}.({3})",
strWebSrvClassId,
        clsPubConst.GetClassNameStringByClassName(cnClassName),
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                default:
                    strMsg = string.Format("(errorId:215)代码类型：{0}在相应函数中没有被处理!({1})", cnClassName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }

        }


        public static bool GenNewTabInSQL(string strTabId, string strPrjId, string strPrjDataBaseId, string strOpUser)
        {
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                var strMsg = "请选择一个有效的表Id!";
                throw new Exception(strMsg);
            }
            try
            {
                bool bolIsSuccess = false;
                try
                {
                    bolIsSuccess = clsPrjTabBLEx_GeneCode.GenSQLCode4CreateTab(strTabId, strPrjId, strPrjDataBaseId);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在生成建表文本时出错：[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                string strCondition_Del = string.Format("TabId ='{0}'", strTabId);
                try
                {
                    clsTabCheckResultBL.DelTabCheckResultsByCond(strCondition_Del);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在删除表检查结果出错：[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在新建表时出错：{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }

    }
}
