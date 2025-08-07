
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsGCVersionExWApi
表名:GCVersion(00050500)
生成代码版本:2020.01.01.1
生成日期:2020/01/02 12:10:13
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统参数
模块英文名:SysPara
框架-层名:WA_访问扩展层(WA_AccessEx)
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
using Newtonsoft.Json;

namespace AGC4WApi
{
    /// <summary>
    /// 生成代码版本(GCVersion)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsGCVersionExWApi
    {
        private static readonly string mstrApiControllerName = "GCVersionExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsGCVersionEN> arrGCVersionObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsGCVersionExWApi()
        {
        }

        /// <summary>
        /// GetNewestVersionObj
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <returns>返回对象列表</returns>
        public static clsGCVersionEN GetNewestVersionObj()
        {
            string strAction = "GetNewestVersionObj";
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
                        string strJson = JsonConvert.SerializeObject(jobjReturn["returnObj"]);
                        var varResult = JsonConvert.DeserializeObject<clsGCVersionEN>(strJson);

                        //var varResult = clsJSON.GetObjFromJson<clsGCVersionEN>((string)jobjReturn["returnObj"]);
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("GetNewestVersionObj出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}