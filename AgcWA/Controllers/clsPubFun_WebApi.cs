using AGC.BusinessLogic;
using com.taishsoft.syspara;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;

namespace Comm.WebApi
{
    public class clsPubFun_WebApi
    {


        public static bool Log4Debug(ControllerBase myPage, string strFunctionName, string strUserId, Dictionary<string, string> dictParamNameValue)
        {
            if (clsDebugBase_Sql.IsDebug == false) return true;
            string strPageName = myPage.GetType().FullName;
            StringBuilder sbParam = new StringBuilder();
            foreach (string strKey in dictParamNameValue.Keys)
            {
                sbParam.AppendFormat("[{0}]:=[{1}];", strKey, dictParamNameValue[strKey]);
            }
            string strMsg = string.Format("WebApi:[{0}]-[{1}]-[{2}].",
                    strPageName,
                    strFunctionName, sbParam.ToString());
            clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
            ErrorInformationBL.AddInformation(strPageName, strFunctionName, strMsg, strUserId);
            return true;
        }
        public static bool Log4Debug(ControllerBase myPage, string strFunctionName, Dictionary<string, string> dictParamNameValue)
        {
            if (clsDebugBase_Sql.IsDebug == false) return true;
            string strPageName = myPage.GetType().FullName;
            StringBuilder sbParam = new StringBuilder();
            foreach (string strKey in dictParamNameValue.Keys)
            {
                sbParam.AppendFormat("[{0}]:=[{1}];", strKey, dictParamNameValue[strKey]);
            }
            string strMsg = string.Format("WebApi:[{0}]-[{1}]-[{2}].",
                    strPageName,
                    strFunctionName, sbParam.ToString());
            clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
            //ErrorInformationBL.AddInformation(strPageName, strFunctionName, strMsg, "WebApi");
            return true;
        }
        //public static bool Log4Error(ControllerBase myPage, string strFunctionName, Dictionary<string, string> dictParamNameValue)
        //{
        //    if (clsDebugBase_Sql.IsDebug == false) return true;
        //    string strPageName = myPage.GetType().FullName;
        //    StringBuilder sbParam = new StringBuilder();
        //    foreach (string strKey in dictParamNameValue.Keys)
        //    {
        //        sbParam.AppendFormat("[{0}]:=[{1}];", strKey, dictParamNameValue[strKey]);
        //    }
        //    string strMsg = string.Format("WebApi:[{0}]-[{1}]-[{2}].",
        //            strPageName,
        //            strFunctionName, sbParam.ToString());
        //    clsPubVar_WebApi.objErr.WriteDebugLog(strMsg);
        //    //ErrorInformationBL.AddInformation(strPageName, strFunctionName, strMsg, "WebApi");
        //    return true;
        //}
        public static bool AccessException(string strErrMsg, HttpStatusCode httpStatusCode)
        {
            //strErrMsg = strErrMsg.Replace("\r\n", ";;");
            //clsPubVar_WebApi.objLog.WriteDebugLog(strErrMsg);
            //string message = HttpUtility.UrlEncode(strErrMsg);
            //var resp = new HttpResponseMessage(httpStatusCode)
            //{

            //    Content = new StringContent(message),
            //    ReasonPhrase = message// "Key is Exist!"
            //};
            //throw new HttpResponseException(resp);
            return true;
        }
    }
}