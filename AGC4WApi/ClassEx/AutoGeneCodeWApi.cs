
/*-- -- -- -- -- -- -- -- -- -- --
类名:AutoGeneCodeWApi
表名:PrjTab(00050009)
生成代码版本:2019.07.04.1
生成日期:2019/07/05 17:12:03
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:WebApi访问层(WA_Access)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using AGC.Entity;

using System.Collections.Generic;
using com.taishsoft.json;
using AgcCommBase;
using com.taishsoft.common;
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
    /// <summary>
    /// 工程表(PrjTab)
    /// (AutoGCLib.WA_Access4CSharp:GeneCode)
    /// </summary>
    public class AutoGeneCodeWApi
    {
        private static readonly string mstrApiControllerName = "AutoGeneCodeApi";
        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static clsGCResult GeneCode(clsGCPara objGCPara)
        {
            string strAction = "GeneCode";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJSON = clsJSON.GetJsonFromObj<clsGCPara>(objGCPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    clsGCResult objGCResult = clsJSON.GetObjFromJson<clsGCResult>(strResult);
                    return objGCResult;
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("生成代码出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取相关记录数
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>记录数</returns>
        public static bool ReFresh4GC(string strPrjId)
        {
            string strAction = "ReFresh4GC";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
                {
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        var bolReturn = (bool)jobjReturn0["returnBool"];
                        return bolReturn;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("刷新WebApi后台数据出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        public static clsGCResult GeneCode4SelfCreateWs(clsGCPara objGCPara)
        {
            string strAction = "GeneCode4SelfCreateWs";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJSON = clsJSON.GetJsonFromObj<clsGCPara>(objGCPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    clsGCResult objGCResult = clsJSON.GetObjFromJson<clsGCResult>(strResult);
                    return objGCResult;
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("生成代码出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 通过WebApi进行两个数相加,用来测试WebApi地址是否可用.
        /// </summary>
        /// <param name = "a">a</param>
        /// <param name = "b">b</param>
        /// <returns>两个数的和</returns>
        public static int Plus(int a, int b)
        {
            string strAction = "Plus";
            string strErrMsg = string.Empty;
            string strResult = "";
            string strFieldCnName = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("a", a.ToString());
            dictParam.Add("b", b.ToString());
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    strFieldCnName = strResult;
                    return int.Parse( strFieldCnName);
                }
                else return 0;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("通过WebApi进行两个数相加出错。错误:{0}.({1})", 
                    objException.Message, 
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //return 0;
        }

        /// <summary>
        /// 根据用户登录名获取Hello
        /// </summary>
        /// <param name="cnClassName">用户登录名</param>     
        /// <param name="strTypeParas">类型参数</param>            
        /// <param name="ltLangType">用户登录名</param>            
        /// <param name="dbtDataBaseType">用户登录名</param>            
        /// <param name="strWebSrvClassId">用户登录名</param>                         
        /// <param name="strPrjId">用户登录名</param>            
        /// <param name="strPrjDataBaseId">用户登录名</param>            
        /// <param name="strUserId">用户登录名</param>     
        /// <param name="strRe_ClsName">用户登录名</param>     
        /// <param name="strRe_FileNameWithModuleName">用户登录名</param>     
        /// <returns>返回生成的代码</returns>
        //public static string GeneCode4SelfCreateWs(clsPubConst.ClsName cnClassName,
        //    string strTypeParas, clsPubConst.LangType ltLangType,
        //    clsPubConst.DataBaseType dbtDataBaseType,
        //    string strWebSrvClassId,
        //    string strPrjId, string strPrjDataBaseId, string strUserId,
        //    ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strClassName = clsPubConst.GetClassNameStringByClassName(cnClassName);
        //    string strLangType = clsPubConst.GetLangTypeStringByLangType(ltLangType);
        //    string strDataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(dbtDataBaseType);

        //    AutoGeneCodeServiceSoapClient objAutoGeneCodeSoapClient = GetAutoGeneCodeSoapClient();
        //    string strCodeText = objAutoGeneCodeSoapClient.GeneCode4SelfCreateWs(strClassName,
        //        strTypeParas, strLangType,
        //        strDataBaseType, strWebSrvClassId, strPrjId, strPrjDataBaseId, strUserId,
        //    ref strRe_ClsName, ref strRe_FileNameWithModuleName);
        //    string strCodeText_Dn = clsString.HtmlDecode(strCodeText);
        //    return strCodeText_Dn;

        //}
    }
}