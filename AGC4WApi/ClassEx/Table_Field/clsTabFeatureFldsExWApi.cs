
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTabFeatureFldsExWApi
表名:TabFeatureFlds(00050455)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:02:45
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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

namespace AGC4WApi
{
    /// <summary>
    /// 表功能字段(TabFeatureFlds)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsTabFeatureFldsExWApi
    {
        //private static readonly string mstrApiControllerName = "TabFeatureFldsExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsTabFeatureFldsEN> arrTabFeatureFldsObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsTabFeatureFldsExWApi()
        {
        }
        /// <summary>
        /// 根据strTabFeatureId获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strTabFeatureId">strTabFeatureId</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsTabFeatureFldsENEx> GetObjExLstByTabFeatureId(string strTabFeatureId)
        {
            string strCondition = string.Format("{0}='{1}'", conTabFeatureFlds.TabFeatureId, strTabFeatureId);
            List<clsTabFeatureFldsEN> arrObjLst = clsTabFeatureFldsWApi.GetObjLst(strCondition);
            List<clsTabFeatureFldsENEx> arrObjExLst = new List<clsTabFeatureFldsENEx>();
            foreach (clsTabFeatureFldsEN objInFor in arrObjLst)
            {
                clsTabFeatureFldsENEx objTabFeatureFldsENEx = new clsTabFeatureFldsENEx();
                clsTabFeatureFldsWApi.CopyTo(objInFor, objTabFeatureFldsENEx);
                arrObjExLst.Add(objTabFeatureFldsENEx);
            }
            return arrObjExLst;
        }

        public static List<clsvTabFeatureFlds_SimEN> GetObjLstByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", conTabFeatureFlds.TabFeatureId, strTabFeatureId);
            List<clsvTabFeatureFlds_SimEN> arrObjLst = clsvTabFeatureFlds_SimWApi.GetObjLstCache(strPrjId);
            var arrObjLst_Sel = arrObjLst.Where(x=>x.TabFeatureId == strTabFeatureId).ToList();
            return arrObjLst_Sel;
        }
    }
}