
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUserDefaValue_LocalExWApi
表名:UserDefaValue_Local(00050089)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:51
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WebApi访问扩展层(WA_AccessEx)
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
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;

using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
    /// <summary>
    /// 用户缺省值(UserDefaValue_Local)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsUserDefaValue_LocalExWApi
    {
        private static readonly string mstrApiControllerName = "UserDefaValue_LocalExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsUserDefaValue_LocalEN> arrUserDefaValue_LocalObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsUserDefaValue_LocalExWApi()
        {
        }

        /// <summary>
        /// 获取用户缺省值
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCurrPrjId">当前选择的工程Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strDefaValName">缺省值名</param>
        /// <returns>返回对象列表</returns>
        public static string getUserDefaValue(string strCurrPrjId, string strCurrSelPrjId, string strUserId, string strDefaValName)
        {
            string strAction = "getUserDefaValue";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCurrPrjId"] = strCurrPrjId,
                ["strCurrSelPrjId"] = strCurrSelPrjId,
                ["strUserId"] = strUserId,
                ["strDefaValName"] = strDefaValName,
            };
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
                string strMsg = string.Format("获取用户缺省值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 设置用户缺省值
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCurrPrjId">当前选择的工程Id</param>
        /// <param name = "strCurrSelPrjId">当前选择的工程Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strDefaValName">缺省值名</param>
        /// <param name = "strUserDefaValue">用户缺省值</param>
        /// <returns>返回对象列表</returns>
        public static bool setUserDefaValue(string strCurrPrjId, string strCurrSelPrjId, string strUserId, string strDefaValName, string strUserDefaValue)
        {
            string strAction = "setUserDefaValue";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strCurrPrjId"] = strCurrPrjId,
                ["strCurrSelPrjId"] = strCurrSelPrjId,
                ["strUserId"] = strUserId,
                ["strDefaValName"] = strDefaValName,
                ["strUserDefaValue"] = strUserDefaValue,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置用户缺省值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}