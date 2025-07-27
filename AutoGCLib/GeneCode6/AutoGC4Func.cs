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
        private static bool CheckTabFld(clsPrjTabENEx objPrjTabENEx)
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = string.Format("当前表:[{0}]的字段数为0,无法生成表相关代码!({1})",
                    objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = string.Format("当前表:[{0}]的关键字的个数为0,无法生成表相关代码!({1})",
                    objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return true;
        }
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
        public static string GeneCode4Func(string strCodeTypeId,
            string strFuncId4GC,      
            clsPubConst.DataBaseType dbtDataBaseType,
            string strTabId,
            string strViewId,
            string strCmPrjId,
            string strPrjId,
            string strPrjDataBaseId,
            string strUserId,
            ref string strRe_ClsName, ref string strRe_FileNameWithModuleName, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);

            string strFunctionName = clsStackTrace.GetCurrClassFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("CodeTypeName", objCodeTypeEN.CodeTypeName);
            dictParam.Add("FuncName", objvFunction4GeneCodeEN.FuncName);
            dictParam.Add("strLangType", clsPubConst.GetLangTypeStringByLangType(ltLangType));
            dictParam.Add("strDataBaseType", clsPubConst.GetDataBaseTypeStrByDataBaseType(dbtDataBaseType));
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strViewId", strViewId);
            dictParam.Add("strCmPrjId", strCmPrjId);
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
            string strCodeText = "";
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
                //objGeneCodeBase.this.CmPrjId, = strCmPrjId;

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
            
            try
            {
                strCodeText = objGeneCodeBase4Tab.GeneCode4Function(strFuncId4GC, ref Re_objFunction4Code); //已完成
                
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
            return strCodeText;
          
        }

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
        public static clsGCResult GeneCode4Func(clsGCPara objGCPara)
        {

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objGCPara.codeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(objGCPara.funcId4GC);

            string strFunctionName = clsStackTrace.GetCurrClassFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("CodeTypeName", objCodeType.CodeTypeName);
            dictParam.Add("FuncName", objvFunction4GeneCodeEN.FuncName);
            dictParam.Add("strLangType", clsPubConst.GetLangTypeStringByLangType(ltLangType));
            dictParam.Add("strTabId", objGCPara.tabId);
            dictParam.Add("strFuncId4GC", objGCPara.funcId4GC);

            dictParam.Add("strViewId", objGCPara.viewId);
            dictParam.Add("strPrjId", objGCPara.prjId);
            dictParam.Add("strCmPrjId", objGCPara.cmPrjId);

            dictParam.Add("strPrjDataBaseId", objGCPara.prjDataBaseId);
            if (string.IsNullOrEmpty(objGCPara.dataBaseType) == true)
            {
                var objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objGCPara.prjDataBaseId);
                objGCPara.dataBaseType = clsDataBaseTypeBL.GetObjByDataBaseTypeIdCache(objPrjDataBase.DataBaseTypeId).DataBaseTypeSimName;
            }
            //dictParam.Add("strDataBaseType", clsPubConst.GetDataBaseTypeStrByDataBaseType(dbtDataBaseType));

            dictParam.Add("strUserId", objGCPara.gcUserId);
            //dictParam.Add("strRe_ClsName", objGCPara.Re_ClsName);
            //dictParam.Add("strRe_FileNameWithModuleName", strRe_FileNameWithModuleName);
            clsPubVar4BLEx.Log4GCDebug("调用生成代码函数：", strFunctionName, objGCPara.gcUserId, dictParam);

            if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
            {

            }

            clsProjectsEN objCurrSelProject = clsProjectsBL.GetObjByPrjIdCache(objGCPara.prjId);
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objGCPara.cmPrjId);
            

            string strCodeText = "";
            clsGeneCodeBase4Tab objGeneCodeBase4Tab = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            clsGeneCodeBase4View objGeneCodeBase4View = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);


            clsGCResult objGCResult = new clsGCResult();
            objGCResult.codeTypeId = objCodeType.CodeTypeId;
            objGCResult.codeTypeName = objCodeType.CodeTypeName;
            objGCResult.codeTypeENName = objCodeType.CodeTypeENName;
            objGCResult.gcUserId = objGCPara.gcUserId;
            objGCResult.errorId = 0;
            objGCResult.errorMsg = "";

            string strSqlDsTypeId = "";
            string strMsg = "";

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
                        clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(objGCPara.prjDataBaseId);
                        strMsg = string.Format("错误:指向IP:{0}的数据库连接不可用,请检查!", objPrjDataBaseEN.IpAddress);
                    }
                    clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                    objGCResult.errorMsg = strMsg;
                    objGCResult.errorId = 1;
                    objGCResult.re_ClsName = "";
                    objGCResult.re_FileNameWithModuleName = "";
                    return objGCResult;
                }
                try
                {
                    //判断是否可以删除
                    if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(objGCPara.tabId, objGCPara.prjId, objGCPara.prjDataBaseId) == false)
                    {
                        throw new Exception("检查表字段不成功!");
                        //return false;
                    }
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

                    strMsg = string.Format("(errorId:0012)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
strTabName, strViewName,
objCodeType._NameValue,
objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                    throw objException;
                }
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
                objGeneCodeBase4Tab.CmPrjId = objGCPara.cmPrjId;
                objGeneCodeBase4Tab.IsFstLcase = objCMProject.IsFstLcase;

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
                objGeneCodeBase4View.IsFstLcase = objCMProject.IsFstLcase;
            }
            if (objCodeType.DependsOn == "Table" || objCodeType.DependsOn == "PureClass")
            {
                objGeneCodeBase4Tab.objPrjTabENEx.LangType = ltLangType;
                objGeneCodeBase4Tab.objPrjTabENEx.CodeTypeId = objCodeType.CodeTypeId;
                //objGeneCodeBase.this.CmPrjId, = objGCPara.cmPrjId;
                objGeneCodeBase4Tab.objPrjTabENEx.UserId = clsUsersBL.GetUserNameByUserIdCache(objGCPara.gcUserId);
                CheckTabFld(objGeneCodeBase4Tab.objPrjTabENEx);
                strSqlDsTypeId = objGeneCodeBase4Tab.objPrjTabENEx.SqlDsTypeId;
            }
            else if (objCodeType.DependsOn == "View")
            {
                objGeneCodeBase4View.objViewInfoENEx.PrjDataBaseId = objGCPara.prjDataBaseId;
                objGeneCodeBase4View.objViewInfoENEx.LangType = ltLangType;
                objGeneCodeBase4View.objViewInfoENEx.CodeTypeId = objCodeType.CodeTypeId;


            }
        

            clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.GetDataBaseTypeByString(objGCPara.dataBaseType);
            objGCResult.langType = objProgLangTypeEN.ProgLangTypeENName;
            objGCResult.dataBaseType = objGCPara.dataBaseType;
            
            objGCResult.prjName = objCurrSelProject.PrjName;
            try
            {
                var Re_objFunction4Code = new clsFunction4CodeEN();
                strCodeText = objGeneCodeBase4Tab.GeneCode4Function(objGCPara.funcId4GC, ref Re_objFunction4Code); //已完成

                objGCResult.codeText = strCodeText.Replace("\r\n\r\n", "\r\n");
                objGCResult.re_ClsName = "";
                objGCResult.re_FileNameWithModuleName = "";
                objGCResult.re_FuncName = Re_objFunction4Code.FuncName4Code;
                objGCResult.re_FuncCHName = Re_objFunction4Code.FuncCHName4Code;

                objGCResult.version = clsSysParaEN_Local.strVersion;

            }
            catch (Exception objException)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objGCPara.tabId, objGCPara.prjId);
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(objGCPara.viewId, objGCPara.prjId);
                string strTabName = objPrjTab == null ? "" : objPrjTab.TabName;
                string strViewName = objViewInfo == null ? "" : objViewInfo.ViewName;

                strMsg = string.Format("(errorId:108)在生成表:[{0}],界面：[{1}],类名：[{2}]时出错!错误：{3}.({4})",
strTabName, strViewName,
objCodeType.CodeTypeENName,
objException.Message, clsStackTrace.GetCurrClassFunction());
                objGCResult.errorMsg = strMsg;
                objGCResult.errorId = 1;
                objGCResult.re_ClsName = "";
                objGCResult.re_FileNameWithModuleName = "";
                objGCResult.version = clsSysParaEN_Local.strVersion;
                return objGCResult;

            }
            //if (string.IsNullOrEmpty(strCodeText) == false)
            return objGCResult;

        }


        /// <summary>
        /// 专门为自建的WebService地址,生成相关的操作代码
        /// </summary>
        /// <param name="objCodeTypeEN._NameValue">类名</param>
        /// <param name="strTypeParas">类型类型</param>
        /// <param name="ltLangType">语言</param>
        /// <param name="dbtDataBaseType">数据库类型</param>
        /// <param name="strWebSrvClassId">自建的WebService的类Id</param>
        /// <param name="strPrjId">工程</param>
        /// <param name="strPrjDataBaseId"></param>
        /// <param name="strUserId"></param>
        /// <param name="strRe_ClsName"></param>
        /// <param name="strRe_FileNameWithModuleName"></param>
        /// <returns></returns>
        public static string GeneCode4SelfCreateWs(string strCodeTypeId,
            string strFuncId4GC,
          clsPubConst.LangType ltLangType,
          clsPubConst.DataBaseType dbtDataBaseType,
          string strWebSrvClassId,
          string strPrjId,
          string strPrjDataBaseId,
          string strUserId,
          ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
             clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);

            clsProjectsEN objCurrSelProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            string strCodeText = "";
            clsGeneCodeBase4Tab objGeneCodeBase = null;// new AutoGCPubFunc(strTabId, strPrjDataBaseId);
            string strMsg = "";
            clsGeneCodeBase4View objAutoGC6Cs_WS = null;// new AutoGC6Cs_WS(strTabId, strPrjDataBaseId);

            clsGeneCodeBase4Tab objAutoGC6_ControllerTab = null;// new AutoGC6_Controller(strTabId, strPrjDataBaseId);
            //clsGeneCodeBase4View objAutoGC6_ControllerView = null;// new AutoGC6_Controller(strTabId, strPrjDataBaseId);
            string strClassName = string.Format("AutoGCLib.{0}_UDF4{1}", objCodeTypeEN.CodeTypeENName, ltLangType);
            objGeneCodeBase = clsGeneCodeBase4Tab.GetClassByName(strClassName);
            if (objGeneCodeBase == null)
            {
                strMsg = string.Format("类型:{0}所对应的类不存在,请检查!", strClassName);
                throw new Exception(strMsg);
            }
            objAutoGC6Cs_WS.WebSrvClassId = strWebSrvClassId;
            objAutoGC6Cs_WS.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
            objAutoGC6Cs_WS.objWebSrvClassENEx.LangType = ltLangType;
            objAutoGC6Cs_WS.objWebSrvClassENEx.CodeTypeId = strCodeTypeId;

            try
            {
                strCodeText = objGeneCodeBase.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //已完成
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errorId:009)在WebSrvClassId:[{0}],类名：[{1}]时出错!错误：{2}.({3})",
                       strWebSrvClassId,
                      objCodeTypeEN._NameValue,
                       objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                throw objException;
            }

            if (string.IsNullOrEmpty(strCodeText) == false) return strCodeText;


            switch (strCodeTypeId)
            {
//                case enumCodeType.WS_Access_0010:
//                    try
//                    {
//                        objAutoGC6Cs_WS = new AutoGC6Cs_WS();
//                        objAutoGC6Cs_WS.WebSrvClassId = strWebSrvClassId;
//                        objAutoGC6Cs_WS.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
//                        objAutoGC6Cs_WS.objWebSrvClassENEx.LangType = ltLangType;
//                        objAutoGC6Cs_WS.objWebSrvClassENEx.CodeTypeId = strCodeTypeId;

//                        switch (ltLangType)
//                        {
//                            case clsPubConst.LangType.CSharp:

//                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

//                                break;
//                            case clsPubConst.LangType.JAVA:

//                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

//                                break;
//                            case clsPubConst.LangType.Swift:
//                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
//                                break;
//                            case clsPubConst.LangType.Swift3:
//                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
//                                break;
//                            case clsPubConst.LangType.Swift4:
//                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
//                                break;
//                            case clsPubConst.LangType.JavaScript:

//                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

//                                break;
//                            case clsPubConst.LangType.SilverLight:

//                                strCodeText = objAutoGC6Cs_WS.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
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
//        objCodeTypeEN._NameValue,
//    objException.Message, clsStackTrace.GetCurrClassFunction());
//                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

//                        throw objException;
//                    }
//                    return strCodeText;
                case enumCodeType.WS_AccessHigh_0012:
                    try
                    {
                        //objAutoGC6_ControllerView = new WS_AccessHigh_UDF4JAVA();
                        //objAutoGC6_Controller.WebSrvClassId = strWebSrvClassId;
                        //objAutoGC6_Controller.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);
                        //objAutoGC6_Controller.objWebSrvClassENEx.LangType = ltLangType;
                        //objAutoGC6_Controller.objWebSrvClassENEx.CodeTypeId = strCodeTypeId;

                        ////strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:193)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     objCodeTypeEN._NameValue,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //string strMsg1 = string.Format("(errorId:194)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     objCodeTypeEN._NameValue,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
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
                                objCodeTypeEN._NameValue,
                            objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case enumCodeType.AppController_0013:
                    try
                    {
                        objAutoGC6_ControllerTab = new AppController_UDF4JAVA("","","");
                        objAutoGC6_ControllerTab.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_ControllerTab.objWebSrvClassENEx.LangType = ltLangType;


                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;
                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CodeTypeId = strCodeTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:197)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     objCodeTypeEN._NameValue,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //string strMsg1 = string.Format("(errorId:198)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     objCodeTypeEN._NameValue,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.JavaScript:

                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
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
        objCodeTypeEN._NameValue,
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case enumCodeType.AppViewUnitTest_0025:
                    try
                    {
                        objAutoGC6_ControllerTab = new AppViewUnitTest_UDF4JAVA("", "", "");
                        objAutoGC6_ControllerTab.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_ControllerTab.objWebSrvClassENEx.LangType = ltLangType;

                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CodeTypeId = strCodeTypeId;

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:202)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     objCodeTypeEN._NameValue,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                //string strMsg1 = string.Format("(errorId:203)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //     ltLangType,
                                //     objCodeTypeEN._NameValue,
                                //     clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg1);
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.SilverLight:

                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
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
        objCodeTypeEN._NameValue,
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case enumCodeType.AppViewUTScript_0026:
                    try
                    {
                        objAutoGC6_ControllerTab = new AppViewUTScript_UDF4JAVA("", "", "");
                        objAutoGC6_ControllerTab.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_ControllerTab.objWebSrvClassENEx.LangType = ltLangType;
                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CodeTypeId = strCodeTypeId;

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:206)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     objCodeTypeEN._NameValue,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:

                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.Swift:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.Swift3:
                                string strMsg2 = string.Format("(errorId:207)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                 ltLangType,
                                 objCodeTypeEN._NameValue,
                                 clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg2);
                                //                                strCodeText = objAutoGC6_Controller.A_GenCode4Function_Controller(strFuncId4GC); //

                             
                            case clsPubConst.LangType.Swift4:
                                //string strMsg3 = string.Format("(errorId:208)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                //       ltLangType,
                                //       objCodeTypeEN._NameValue,
                                //       clsStackTrace.GetCurrClassFunction());
                                //throw new Exception(strMsg3);
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //

                                break;
                            case clsPubConst.LangType.SilverLight:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
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
        objCodeTypeEN._NameValue,
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;
                case enumCodeType.AppViewUTScriptCS_0027:
                    try
                    {
                        objAutoGC6_ControllerTab = new AppViewUTScriptCS_UDF4JAVA("", "", "");
                        objAutoGC6_ControllerTab.WebSrvClassId = strWebSrvClassId;
                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CurrUserName = clsUsersBL.GetUserNameByUserIdCache(strUserId);

                        objAutoGC6_ControllerTab.objWebSrvClassENEx.LangType = ltLangType;

                        objAutoGC6_ControllerTab.objWebSrvClassENEx.CodeTypeId = strCodeTypeId;

                        //strSqlDsTypeId = objAutoGC6_Controller.objWebSrvClassENEx.SqlDsTypeId;

                        switch (ltLangType)
                        {
                            case clsPubConst.LangType.CSharp:

                                string strMsg1 = string.Format("(errorId:212)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                     ltLangType,
                                     objCodeTypeEN._NameValue,
                                     clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg1);

                            case clsPubConst.LangType.JAVA:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.Swift:
                                string strMsg2 = string.Format("(errorId:213)语言类型：{0}没有生成类:[{1}]的功能!({2})",
                                   ltLangType,
                                   objCodeTypeEN._NameValue,
                                   clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg2);
                            //                                strCodeText = objAutoGC6_Controller.A_GenCode4Function_Controller(strFuncId4GC); //
                            //break;
                            case clsPubConst.LangType.Swift3:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.Swift4:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.JavaScript:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
                                break;
                            case clsPubConst.LangType.SilverLight:
                                strCodeText = objAutoGC6_ControllerTab.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName); //
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
        objCodeTypeEN._NameValue,
    objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                        throw objException;
                    }
                    return strCodeText;

            }
            return "";
        }
    }
}
