
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewRegionExWApi
表名:ViewRegion(00050099)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:53
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
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// 界面区域(ViewRegion)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsViewRegionExWApi
    {
        //private static readonly string mstrApiControllerName = "ViewRegionExApi";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsViewRegionExWApi()
        {
        }
        /// <summary>
        /// 根据界面Id和区域类型Id获取相关区域Id
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strRegionTypeId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static string GetRegionIdByTypeCache(string strViewId, string strRegionTypeId, string strCmPrjId)
        {
            clsViewRegionEN objViewRegionEN = GetObjByRegionId_CacheEx(strViewId, strRegionTypeId, strCmPrjId);
            if (objViewRegionEN != null) return objViewRegionEN.RegionId;
            return "";
        }
        

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "strViewId">strViewId</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "strRegionTypeId">区域类型Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsViewRegionEN GetObjByRegionId_CacheEx(string strViewId, string strRegionTypeId, string strCmPrjId)
        {
            //初始化列表缓存
            var arrRegionId = clsViewRegionRelaExWApi.GetRegionIdLstByViewIdCache(strViewId, strCmPrjId);
            string strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            List<clsViewRegionEN> arrViewRegionObjLst_Cache = clsViewRegionWApi.GetObjLstCache(strPrjId);
            IEnumerable<clsViewRegionEN> arrViewRegionObjLst_Sel1 =
            from objViewRegionEN in arrViewRegionObjLst_Cache
            where arrRegionId.Contains( objViewRegionEN.RegionId) && objViewRegionEN.RegionTypeId == strRegionTypeId
            select objViewRegionEN;
            List<clsViewRegionEN> arrViewRegionObjLst_Sel = new List<clsViewRegionEN>();
            foreach (clsViewRegionEN obj in arrViewRegionObjLst_Sel1)
            {
                arrViewRegionObjLst_Sel.Add(obj);
            }
            if (arrViewRegionObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrViewRegionObjLst_Sel[0];
        }

    }
}