
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFeatureRegionFldsExWApi
表名:FeatureRegionFlds(00050452)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:02:43
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:区域管理
模块英文名:RegionManage
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
using System.Runtime.Serialization;

namespace AGC4WApi
{
    [Serializable]
    [DataContractAttribute]
    public class stuFeatureRegionFlds4Save
    {
        [DataMember]
        public long RegionId { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string objString { get; set; }
    }
    /// <summary>
    /// 功能区域字段列表(FeatureRegionFlds)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsFeatureRegionFldsExWApi
    {
        private static readonly string mstrApiControllerName = "FeatureRegionFldsExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsFeatureRegionFldsExWApi()
        {
        }

        /// <summary>
        /// 添加记录
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static bool AddFeatureRegionFldsRecordSave(stuFeatureRegionFlds4Save objFeatureRegionFldsEN)
        {
            string strAction = "AddFeatureRegionFldsRecordSave";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJson = clsJSON.GetJsonFromObj<stuFeatureRegionFlds4Save>(objFeatureRegionFldsEN);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                        //clsFeatureRegionFldsWApi.ReFreshCache(objFeatureRegionFldsEN.PrjId);
                        var bolReturnBool = (bool)jobjReturn["returnBool"];
                        return bolReturnBool;
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
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }
        }

    }
}