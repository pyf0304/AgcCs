using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using Comm.WebApi;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using com.taishsoft.commdb;
using Microsoft.AspNetCore.Authorization;

namespace AGC.WebApiEx
{
    [ApiController]
    [Route("[controller]")]
    public class AutoGeneCodeApiController : ControllerBase
    {

        [HttpGet("Plus")]
        public int Plus(int a, int b)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("a", a.ToString());
            dictParam.Add("b", b.ToString());
            clsPubFun_WebApi.Log4Debug(this, "Plus", dictParam);
            return a + b;
        }
        [HttpGet("ReFresh4GC")]
        public ActionResult ReFresh4GC(string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

            try
            {
                string strDateTime = clsDateTime_Db.GetDataBaseDateTime14();
                clsvFieldTab2BL.ReFreshThisCache(strPrjId);
                clsFieldTabBL.ReFreshCache(strPrjId);
                clsPrjTabBL.ReFreshCache(strPrjId);
                clsPrjTabFldBL.ReFreshCache(strPrjId);
                clsViewInfoBL.ReFreshCache(strPrjId);
                clsTabFeatureBL.ReFreshCache(strPrjId);
                clsPrjConstraintBL.ReFreshCache(strPrjId);
                clsTabFeatureFldsBL.ReFreshCache(strPrjId);
                clsDetailRegionFldsBL.ReFreshCache(strPrjId);
                clsDGRegionFldsBL.ReFreshCache(strPrjId);
                clsEditRegionFldsBL.ReFreshCache(strPrjId);
                clsFeatureRegionFldsBL.ReFreshCache(strPrjId);
                clsQryRegionFldsBL.ReFreshCache(strPrjId);

                return Ok(new { errorId = 0, errorMsg = "", returnBool = true });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });

            }

        }
        [AllowAnonymous]
        [HttpPost("GeneCode")]
        public clsGCResult GeneCode([FromBody] clsGCPara objGCPara)
        {
            //string strCodeText = "";
            //string strCodeText_En = "";
            clsGCResult objGCResult = null;
            try
            {

                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("CodeTypeId", objGCPara.codeTypeId);
                dictParam.Add("DataBaseType", objGCPara.dataBaseType);
                dictParam.Add("TabId", objGCPara.tabId);
                dictParam.Add("ViewId", objGCPara.viewId);
                dictParam.Add("PrjId", objGCPara.prjId);
                dictParam.Add("PrjDataBaseId", objGCPara.prjDataBaseId);
                dictParam.Add("GCUserId", objGCPara.gcUserId);
                //dictParam.Add("ClassName", objGCPara.ClassName);
                //dictParam.Add("LangType", objGCPara.LangType);
                dictParam.Add("TypeParas", objGCPara.typeParas);

                clsPubFun_WebApi.Log4Debug(this, strFunctionName, objGCPara.gcUserId, dictParam);

                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(strClassName);// clsPubConst.ClassName.CtlViewCode;

                //string strTabId = "01690265";
                //string strViewId = "";
                //string strPrjId = "0169";
                //string strPrjDataBaseId = "0199";
                //string strUserId = "pyf";

                //clsPubVar_WS.objLog.WriteDebugLog("显示参数：(In AutoGeneCodeService.GeneCode())");
                //clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
                clsProjectDatabaseRelBLEx.CheckPrjDataBaseId(objGCPara.prjId, objGCPara.prjDataBaseId);

                objGCResult = AutoGC.GeneCode(objGCPara);
                string strMsg = string.Format("在生成表Id:[{0}],界面Id：[{1}]时已经成功！(In {2})",
                        objGCPara.tabId, objGCPara.viewId, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

            }
            catch (Exception objException)
            {
                string strErrMsg = "";
                if (objException.InnerException != null)
                {
                    strErrMsg += objException.InnerException.Message;
                }
                strErrMsg += objException.Message;
                string strMsg = string.Format("(ErrId:0001)在生成表Id:[{0}],界面Id：[{1}]时出错！错误：{2}.({3})",
                    objGCPara.tabId, objGCPara.viewId, strErrMsg, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                objGCResult = new clsGCResult();
                objGCResult.errorMsg = strMsg;
                objGCResult.errorId = -1;
                return objGCResult;
            }
            return objGCResult;
        }
        [AllowAnonymous]
        [HttpPost("GeneCode4Func")]
        public clsGCResult GeneCode4Func([FromBody] clsGCPara objGCPara)
        {
            //string strCodeText = "";
            //string strCodeText_En = "";
            clsGCResult objGCResult = null;
            try
            {

                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("CodeTypeId", objGCPara.codeTypeId);
                dictParam.Add("funcId4GC", objGCPara.funcId4GC);
                dictParam.Add("DataBaseType", objGCPara.dataBaseType);
                dictParam.Add("TabId", objGCPara.tabId);
                dictParam.Add("ViewId", objGCPara.viewId);
                dictParam.Add("PrjId", objGCPara.prjId);
                dictParam.Add("CmPrjId", objGCPara.cmPrjId);
                dictParam.Add("PrjDataBaseId", objGCPara.prjDataBaseId);
                dictParam.Add("GCUserId", objGCPara.gcUserId);
                //dictParam.Add("ClassName", objGCPara.ClassName);
                //dictParam.Add("LangType", objGCPara.LangType);
                dictParam.Add("TypeParas", objGCPara.typeParas);

                clsPubFun_WebApi.Log4Debug(this, strFunctionName, objGCPara.gcUserId, dictParam);

                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(strClassName);// clsPubConst.ClassName.CtlViewCode;

                //string strTabId = "01690265";
                //string strViewId = "";
                //string strPrjId = "0169";
                //string strPrjDataBaseId = "0199";
                //string strUserId = "pyf";

                //clsPubVar_WS.objLog.WriteDebugLog("显示参数：(In AutoGeneCodeService.GeneCode())");
                //clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);


                objGCResult = AutoGC.GeneCode4Func(objGCPara);
                string strMsg = string.Format("在生成表Id:[{0}],界面Id：[{1}]时已经成功！(In {2})",
                        objGCPara.tabId, objGCPara.viewId, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

            }
            catch (Exception objException)
            {
                string strErrMsg = "";
                if (objException.InnerException != null)
                {
                    strErrMsg += objException.InnerException.Message;
                }
                strErrMsg += objException.Message;
                string strMsg = string.Format("(ErrId:0001)在生成表Id:[{0}],界面Id：[{1}]时出错！错误：{2}.({3})",
                    objGCPara.tabId, objGCPara.viewId, strErrMsg, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                objGCResult = new clsGCResult();
                objGCResult.errorMsg = strMsg;
                objGCResult.errorId = -1;
                return objGCResult;
            }
            return objGCResult;
        }

        [HttpPost("GeneCode4Feature")]
        public clsGCResult GeneCode4Feature([FromBody] clsGCPara objGCPara)
        {
            //string strCodeText = "";
            //string strCodeText_En = "";
            clsGCResult objGCResult = null;
            try
            {

                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("CodeTypeId", objGCPara.codeTypeId);
                dictParam.Add("DataBaseType", objGCPara.dataBaseType);
                dictParam.Add("TabId", objGCPara.tabId);
                dictParam.Add("FeatureId", objGCPara.featureId);
                dictParam.Add("ViewId", objGCPara.viewId);
                dictParam.Add("PrjId", objGCPara.prjId);
                dictParam.Add("PrjDataBaseId", objGCPara.prjDataBaseId);
                dictParam.Add("GCUserId", objGCPara.gcUserId);
                //dictParam.Add("ClassName", objGCPara.ClassName);
                //dictParam.Add("LangType", objGCPara.LangType);
                dictParam.Add("TypeParas", objGCPara.typeParas);

                clsPubFun_WebApi.Log4Debug(this, strFunctionName, objGCPara.gcUserId, dictParam);

                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(strClassName);// clsPubConst.ClassName.CtlViewCode;

                //string strTabId = "01690265";
                //string strViewId = "";
                //string strPrjId = "0169";
                //string strPrjDataBaseId = "0199";
                //string strUserId = "pyf";

                //clsPubVar_WS.objLog.WriteDebugLog("显示参数：(In AutoGeneCodeService.GeneCode())");
                //clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);


                objGCResult = AutoGC.GeneCode4Feature(objGCPara);
                string strMsg = string.Format("在生成表Id:[{0}],界面Id：[{1}],代码类型:[{2}], 功能:[{3}]时已经成功！(In {4})",
                        objGCPara.tabId, objGCPara.viewId, objGCPara.codeTypeId, objGCPara.featureId, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

            }
            catch (Exception objException)
            {
                string strErrMsg = "";
                if (objException.InnerException != null)
                {
                    strErrMsg += objException.InnerException.Message;
                }
                strErrMsg += objException.Message;
                string strMsg = string.Format("(ErrId:0001)在生成表Id:[{0}],界面Id：[{1}]时出错！错误：{2}.({3})",
                    objGCPara.tabId, objGCPara.viewId, strErrMsg, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                objGCResult.errorMsg = strMsg;
                objGCResult.errorId = -1;
                return objGCResult;

            }
            return objGCResult;
        }


        [HttpPost("GeneCode4SelfCreateWs")]
        public string GeneCode4SelfCreateWs([FromBody] clsGCPara objGCPara)
        {
            string strCodeText = "";
            string strCodeText_En = "";
            try
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                //dictParam.Add("strClassName", objGCPara.ClassName);
                dictParam.Add("strTypeParas", objGCPara.typeParas);
                //dictParam.Add("strLangType", objGCPara.LangType);
                dictParam.Add("strDataBaseType", objGCPara.dataBaseType);
                dictParam.Add("strWebSrvClassId", objGCPara.webSrvClassId);
                //dictParam.Add("strViewId", strViewId);
                dictParam.Add("strPrjId", objGCPara.prjId);
                dictParam.Add("strPrjDataBaseId", objGCPara.prjDataBaseId);
                dictParam.Add("strUserId", objGCPara.gcUserId);
                //dictParam.Add("strRe_ClsName", strRe_ClsName);
                //dictParam.Add("strRe_FileNameWithModuleName", strRe_FileNameWithModuleName);
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);


                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByStringBak(strClassName);// clsPubConst.ClassName.CtlViewCode;
                //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(strLangType);// clsPubConst.LangType.JAVA;
                //clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.GetDataBaseTypeByString(strDataBaseType);
                //string strWebSrvClassId = "01690265";
                //string strViewId = "";
                //string strPrjId = "0169";
                //string strPrjDataBaseId = "0199";
                //string strUserId = "pyf";

                //strCodeText = "";// AutoGC.GeneCode4SelfCreateWs(cnClassName, objGCPara.typeParas,
                //    ltLangType, dbtDataBaseType, objGCPara.webSrvClassId, objGCPara.prjId, objGCPara.prjDataBaseId, objGCPara.gcUserId);

                strCodeText_En = clsString.HtmlEncode(strCodeText);
                //txtResult.Text = strCodeText;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成类名时出错！错误：{0}.({1})",
                       objException.Message, clsStackTrace.GetCurrClassFunction());
                //clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

                throw new Exception(strMsg);
            }
            return strCodeText_En;
        }

        /// <summary>
        /// 在Sql中建立表
        /// 调用方法: Get /api/clsPrjTabBLExApi/GenNewTabInSQL?strTabId=value&strPrjId=value&strPrjDataBaseId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("GenNewTabInSQL")]
        public ActionResult GenNewTabInSQL(string strTabId, string strPrjId, string strPrjDataBaseId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strTabId", strTabId);
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = AutoGC.GenNewTabInSQL(strTabId, strPrjId, strPrjDataBaseId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

    }
}