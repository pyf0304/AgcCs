
//----------------------
//生成代码版本：2012.10.19.1
//生成日期：2014/09/27
//生成者：潘以锋
//工程名称：AGC
//工程ID：0005
//模块中文名：字段、表维护
//模块英文名：Table_Field
//注意：1、需要数据底层（PubDataBase.dll）的版本：2013.11.06.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2013.11.08.1
//========================
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;

using AGC.BusinessLogicEx;
using AgcCommBase;
using AutoGCLib;
using AGC.WebSrv;

namespace AGC.WebSrv
{
    /// <summary>
    /// PrjTabService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class AutoGeneCodeService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GeneCode(string strClassName,
            string strTypeParas,
            string strLangType,
            string strDataBaseType, 
            string strTabId,
            string strViewId,
            string strCmPrjId,
            string strPrjId, 
            string strPrjDataBaseId,
            int intApplicationTypeId,
            string strUserId,
            ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strCodeText = "";
            string strCodeText_En = "";
            try
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("strClassName", strClassName);
                dictParam.Add("strTypeParas", strTypeParas);
                dictParam.Add("strLangType", strLangType);
                dictParam.Add("strDataBaseType", strDataBaseType);
                dictParam.Add("strTabId", strTabId);
                dictParam.Add("strViewId", strViewId);
                dictParam.Add("strPrjId", strPrjId);
                dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
                dictParam.Add("intApplicationTypeId", intApplicationTypeId.ToString());
                
                dictParam.Add("strUserId", strUserId);
                dictParam.Add("strRe_ClsName", strRe_ClsName);
                dictParam.Add("strRe_FileNameWithModuleName", strRe_FileNameWithModuleName);
                
                //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(strClassName);// clsPubConst.ClassName.CtlViewCode;
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(strLangType);// clsPubConst.LangType.JAVA;
                clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.GetDataBaseTypeByString(strDataBaseType);
                //string strTabId = "01690265";
                //string strViewId = "";
                //string strPrjId = "0169";
                //string strPrjDataBaseId = "0199";
                //string strUserId = "pyf";
                clsPubVar_WS.objLog.WriteDebugLog("显示参数：(In AutoGeneCodeService.GeneCode())");
                clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);

                strCodeText = AutoGC.GeneCode(strClassName, strTypeParas, ltLangType, dbtDataBaseType, 
                    strTabId, strViewId, strCmPrjId, strPrjId, strPrjDataBaseId, intApplicationTypeId, strUserId,
                    ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                strCodeText_En = clsString.HtmlEncode(strCodeText);
                //txtResult.Text = strCodeText;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成表Id:[{0}],界面Id：[{1}]时出错！错误：{2}.({3})",
                    strTabId, strViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WS.objLog.WriteDebugLog(strMsg);
                throw objException;
            }
            return strCodeText_En;
        }


        [WebMethod]
        public string GeneCode4SelfCreateWs(string strClassName,
            string strTypeParas,
            string strLangType,
            string strDataBaseType,
            string strWebSrvClassId,          
            string strPrjId,
            string strPrjDataBaseId,
            string strUserId,
            ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strCodeText = "";
            string strCodeText_En = "";
            try
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("strClassName", strClassName);
                dictParam.Add("strTypeParas", strTypeParas);
                dictParam.Add("strLangType", strLangType);
                dictParam.Add("strDataBaseType", strDataBaseType);
                dictParam.Add("strWebSrvClassId", strWebSrvClassId);
                //dictParam.Add("strViewId", strViewId);
                dictParam.Add("strPrjId", strPrjId);
                dictParam.Add("strPrjDataBaseId", strPrjDataBaseId);
                dictParam.Add("strUserId", strUserId);
                dictParam.Add("strRe_ClsName", strRe_ClsName);
                dictParam.Add("strRe_FileNameWithModuleName", strRe_FileNameWithModuleName);
                clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);


                clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByStringBak(strClassName);// clsPubConst.ClassName.CtlViewCode;
                clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(strLangType);// clsPubConst.LangType.JAVA;
                clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.GetDataBaseTypeByString(strDataBaseType);
                //string strWebSrvClassId = "01690265";
                //string strViewId = "";
                //string strPrjId = "0169";
                //string strPrjDataBaseId = "0199";
                //string strUserId = "pyf";

                strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, strTypeParas,
                    ltLangType, dbtDataBaseType, strWebSrvClassId, strPrjId, strPrjDataBaseId, strUserId,
                    ref strRe_ClsName, ref strRe_FileNameWithModuleName);

                strCodeText_En = clsString.HtmlEncode(strCodeText);
                //txtResult.Text = strCodeText;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成类名:[{0}]时出错！错误：{1}.({2})",
                      strClassName, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WS.objLog.WriteDebugLog(strMsg);
                throw objException;
            }
            return strCodeText_En;
        }


    }
}