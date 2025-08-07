
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsWebSrvClassExWApi
表名:WebSrvClass(00050344)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:51
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCSharp
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
using System.Linq;
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
    /// <summary>
    /// WebSrv类(WebSrvClass)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsWebSrvClassExWApi
    {
        private static readonly string mstrApiControllerName = "WebSrvClassExApi";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsWebSrvClassExWApi()
        {
        }
       
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsWebSrvClassEN GetWebSrvClassObjByWebSrvClassId_CacheEx(string strWebSrvClassId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strWebSrvClassId) == true) return null;

            List<clsWebSrvClassEN> arrWebSrvClassObjLst_Cache = clsWebSrvClassWApi.GetObjLstCache(strPrjId);
            IEnumerable<clsWebSrvClassEN> arrWebSrvClassObjLst_Sel1 =
                from objWebSrvClassEN in arrWebSrvClassObjLst_Cache
                where objWebSrvClassEN.WebSrvClassId == strWebSrvClassId
                select objWebSrvClassEN;
            List<clsWebSrvClassEN> arrWebSrvClassObjLst_Sel = new List<clsWebSrvClassEN>();
            foreach (clsWebSrvClassEN obj in arrWebSrvClassObjLst_Sel1)
            {
                arrWebSrvClassObjLst_Sel.Add(obj);
            }
            if (arrWebSrvClassObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrWebSrvClassObjLst_Sel[0];
        }

        /// <summary>
        /// p_Init_Log4GC_WebSrvClass
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strUserId">strUserId</param>
        /// <returns>返回对象列表</returns>
        public static bool p_Init_Log4GC_WebSrvClass(string strPrjId, string strUserId)
        {
            string strAction = "p_Init_Log4GC_WebSrvClass";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
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
                string strMsg = string.Format("p_Init_Log4GC_WebSrvClass出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}