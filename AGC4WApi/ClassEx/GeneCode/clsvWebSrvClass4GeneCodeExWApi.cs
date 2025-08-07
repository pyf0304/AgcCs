
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvWebSrvClass4GeneCodeExWApi
表名:vWebSrvClass4GeneCode(00050372)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:02:05
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
using Newtonsoft.Json.Linq; 
using Newtonsoft.Json;

namespace AGC4WApi
{
    /// <summary>
    /// vWebSrvClass4GeneCode(vWebSrvClass4GeneCode)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvWebSrvClass4GeneCodeExWApi
    {
        private static readonly string mstrApiControllerName = "vWebSrvClass4GeneCodeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvWebSrvClass4GeneCodeExWApi()
        {
        }
        

        /// <summary>
        /// GetObjLstByUserIdAndCondition
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
        /// </summary>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByUserIdAndCondition(string strUserId, string strCondition)
        {
            string strAction = "GetObjLstByUserIdAndCondition";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strCondition"] = strCondition,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn["returnObjLst"]);
                        var varResult = JsonConvert.DeserializeObject<List<clsvWebSrvClass4GeneCodeEN>>(strJson);
                        //var1 varResult = clsJSON.GetObjLstFromJson<clsvWebSrvClass4GeneCodeEN>((string)jobjReturn["returnObjLst"]);
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
                string strMsg = string.Format("GetObjLstByUserIdAndCondition出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
    }
}