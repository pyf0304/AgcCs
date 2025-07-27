
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsLog4GeneTabCodeExWApi
表名:Log4GeneTabCode(00050279)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:19
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:日志管理
模块英文名:LogManage
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
    /// 生成表代码日志(Log4GeneTabCode)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsLog4GeneTabCodeExWApi
    {
        private static readonly string mstrApiControllerName = "Log4GeneTabCodeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsLog4GeneTabCodeExWApi()
        {
        }

        /// <summary>
        /// AddLog4GeneTabCode
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strCmPrjId">CM项目Id</param>
        /// <param name = "intApplicationTypeId">intApplicationTypeId</param>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "strVersion">版本</param>
        /// <returns>返回对象列表</returns>
        public static bool AddLog4GeneTabCode(string strTabId, string strGcPathId, int intApplicationTypeId, string strUserId, string strVersion)
        {
            if (string.IsNullOrEmpty(strVersion) == true)
            {
                string strMsg = string.Format("strVersion(版本)不能为空.(from {0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strAction = "AddLog4GeneTabCode";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strTabId"] = strTabId,
                ["strGcPathId"] = strGcPathId,
                ["intApplicationTypeId"] = intApplicationTypeId.ToString(),
                ["strUserId"] = strUserId,
                ["strVersion"] = strVersion,
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
                string strMsg = string.Format("AddLog4GeneTabCode出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}