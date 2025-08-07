using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.json;
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlWApi
    {

        private static readonly string mstrApiControllerName = "SqlApi";


        /// <summary>
        /// 获取服务器中的当前时间
        /// </summary>
        /// <returns>服务器中的当前时间</returns>
        public static string DateTime_GetDataBaseDateTime14()
        {
            string strAction = "DateTime_GetDataBaseDateTime14";
            string strErrMsg = string.Empty;
            string strResult = "";           
            Dictionary<string, string> dictParam = new Dictionary<string, string>();  
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (string)jobjReturn["returnStr"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }              
                }
                else return "";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取时间出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }        
        }


        /// <summary>
        /// 获取服务器中的当前时间
        /// </summary>
        /// <returns>服务器中的当前时间</returns>
        public static DateTime DateTime_GetDataBaseDateTime()
        {
            string strAction = "DateTime_GetDataBaseDateTime";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (string)jobjReturn["ReturnStr"];
                        DateTime objDT =  DateTime.Parse(varResult);
                        return objDT;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return DateTime.Parse("2001-01-01") ;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取时间出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}
