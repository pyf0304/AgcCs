
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQryRegionFldsExWApi
表名:QryRegionFlds(00050115)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:00
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
    /// 查询区域字段列表(QryRegionFlds)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsQryRegionFldsExWApi
    {
        //private static readonly string mstrApiControllerName = "QryRegionFldsExApi";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsQryRegionFldsExWApi()
        {
        }
        /// <summary>
        /// 根据区域Id获取相关
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsQryRegionFldsENEx> GetObjExLstByRegionId_Cache4InUse(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} order by SeqNum", lngRegionId);
            List<clsQryRegionFldsENEx> arrObjENExList = new List<clsQryRegionFldsENEx>();
            List<clsQryRegionFldsEN> arrObjList = GetObjLstByRegionId_Cache4InUseEx(lngRegionId, strPrjId);
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrObjList)
            {
                clsQryRegionFldsENEx objQryRegionFldsENEx = new clsQryRegionFldsENEx();
                clsQryRegionFldsWApi.CopyTo(objQryRegionFldsEN, objQryRegionFldsENEx);
                arrObjENExList.Add(objQryRegionFldsENEx);
            }
            return arrObjENExList;
        }
              
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsQryRegionFldsEN> GetObjLstByRegionId_Cache4InUseEx(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Cache = clsQryRegionFldsWApi.GetObjLstCache(strPrjId);
            IEnumerable<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel1 =
            from objQryRegionFldsEN in arrQryRegionFldsObjLst_Cache
            where objQryRegionFldsEN.RegionId == lngRegionId && objQryRegionFldsEN.InUse == true
            orderby objQryRegionFldsEN.SeqNum
            select objQryRegionFldsEN;
            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel = new List<clsQryRegionFldsEN>();
            foreach (clsQryRegionFldsEN obj in arrQryRegionFldsObjLst_Sel1)
            {
                arrQryRegionFldsObjLst_Sel.Add(obj);
            }
            //if (arrQryRegionFldsObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrQryRegionFldsObjLst_Sel;
        }

        /// <summary>
        /// 根据区域Id获取用户绑定下拉框的相关表Id
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4Ddl(string lngRegionId, string strPrjId)
        {
            string strCondition = string.Format("{0}={1}",
                conQryRegionFlds.RegionId, lngRegionId);

            List<string> arrTabId = new List<string>();
            List<clsQryRegionFldsENEx> arrObjENExList = clsQryRegionFldsExWApi.GetObjExLstByRegionId_Cache4InUse(lngRegionId, strPrjId);

            foreach (clsQryRegionFldsENEx objQryRegionFldsENEx in arrObjENExList)
            {
                if (objQryRegionFldsENEx.CtlTypeId != enumCtlTypeWA.DropDownList_06) continue;
                string strTabId = objQryRegionFldsENEx.DsTabId;
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
            }

            return arrTabId;
        }
    }
}