using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.json;

namespace AGC4WApi
{
    /// <summary>
    /// 
    /// </summary>
    public class clsTranslateWApi
    {

        private static readonly string mstrApiControllerName = "TranslateApi";


        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// </summary>
        /// <param name = "strFeatureId">表关键字</param>
        /// <returns>表对象</returns>
        public static string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName)
        {
            string strAction = "GetFieldCnNameByFieldName";
            string strErrMsg = string.Empty;
            string strResult = "";
            string strFieldCnName = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strTabName", strTabName);
            dictParam.Add("strFieldName", strFieldName);
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    strFieldCnName = strResult;
                    return strFieldCnName;
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取字段名获取中文字段名出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //return strFieldCnName;
        }
    }
}
