using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using AGC.Entity;

using System.Collections.Generic;
using System.Text;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.IO;
using com.taishsoft.common;


namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar4BLEx
    {
        public clsPubVar4BLEx()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 专门用来记录生成代码的日志
        /// </summary>
        public static clsLog objLog4GC = null;//new clsLog();

        /// <summary>
        /// 专门用于记录错误的Log对象
        /// </summary>
        public static clsLog objLog4Error = null;// new clsLog();

        public static IDictionary<string, clsUserCodePrjMainPathEN> dicKey_UserCodePrjMainPath = null;

        /// <summary>
        /// 写Debug
        /// </summary>
        /// <param name="strClassName"></param>
        /// <param name="strFunctionName"></param>
        /// <param name="strUserId">用户Id</param>
        /// <param name="dictParamNameValue"></param>
        /// <returns></returns>
        public static bool Log4GCDebug(string strClassName, string strFunctionName, string strUserId, Dictionary<string, string> dictParamNameValue)
        {
            StringBuilder sbParam = new StringBuilder();
            foreach (string strKey in dictParamNameValue.Keys)
            {
                sbParam.AppendFormat("[{0}]:=[{1}];", strKey, dictParamNameValue[strKey]);
            }
            string strMsg = string.Format("AutoGC:[{0}]-[{1}]-[{2}].",
                    strClassName,
                    strFunctionName, sbParam.ToString());
            objLog4GC.WriteDebugLog(strMsg);
            try
            {
                ErrorInformationBL.AddInformation(strClassName, strFunctionName, strMsg, strUserId);
            }
            catch (Exception objException)
            {
                string strSS = objException.Message;
            }
            return true;
        }
        public static clsUserCodePrjMainPathEN GetUserCodePrjMainPath(string strUserCodePrjMainPathId)
        {
            clsUserCodePrjMainPathEN objUserCodePrjMainPath = null;

            if (clsPubVar4BLEx.dicKey_UserCodePrjMainPath == null)
            {
                clsPubVar4BLEx.dicKey_UserCodePrjMainPath = new Dictionary<string, clsUserCodePrjMainPathEN>();
                clsUserCodePrjMainPathEN objUserCodePrjMainPath_p = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                clsPubVar4BLEx.dicKey_UserCodePrjMainPath.Add(strUserCodePrjMainPathId, objUserCodePrjMainPath_p);
            }


            if (clsPubVar4BLEx.dicKey_UserCodePrjMainPath.ContainsKey(strUserCodePrjMainPathId) == false)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                clsPubVar4BLEx.dicKey_UserCodePrjMainPath.Add(strUserCodePrjMainPathId, objUserCodePrjMainPath);
            }
            objUserCodePrjMainPath = clsPubVar4BLEx.dicKey_UserCodePrjMainPath[strUserCodePrjMainPathId];
            if (objUserCodePrjMainPath == null)
            {
                objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                clsPubVar4BLEx.dicKey_UserCodePrjMainPath.Add(strUserCodePrjMainPathId, objUserCodePrjMainPath);
            }
            return objUserCodePrjMainPath;
        }
    }
}