using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;

using System.Collections;
using System.Text;
using CommFunc4WebForm;
using System.Diagnostics;
using System.IO;
using com.taishsoft.common;
using System.Data;

using com.taishsoft.datetime;
using System.Web.Services;
using com.taishsoft.syspara;
using AGC.BusinessLogicEx;

using AGC.WebSrv;
using AGC.BusinessLogic;

namespace AGC.WebSrv
{
    public class clsPubFun_WS
    {

        public static bool Log4Debug(System.Web.Services.WebService myPage, string strFunctionName, Dictionary<string, string> dictParamNameValue)
        {
            if (clsDebugBase_Sql.IsDebug == false) return true;
            string strPageName = myPage.GetType().FullName;
            StringBuilder sbParam = new StringBuilder();
            foreach (string strKey in dictParamNameValue.Keys)
            {
                sbParam.AppendFormat("{0}:={1};", strKey, dictParamNameValue[strKey]);
            }
            string strMsg = string.Format("WS:[{0}]-[{1}]-[{2}].",
                    strPageName,
                    strFunctionName, sbParam.ToString());
            clsPubVar_WS.objLog.WriteDebugLog(strMsg);
            try
            {
                ErrorInformationBL.AddInformation(strPageName, strFunctionName, strMsg, "WebService");
            }
            catch(Exception objException)
            {
                string strSS = objException.Message;
            }
            return true;
        }

    }
}