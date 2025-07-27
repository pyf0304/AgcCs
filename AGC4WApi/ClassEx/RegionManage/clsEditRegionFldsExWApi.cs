
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsEditRegionFldsExWApi
表名:EditRegionFlds(00050116)
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
    /// 编辑区域字段列表(EditRegionFlds)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsEditRegionFldsExWApi
    {
        //private static readonly string mstrApiControllerName = "EditRegionFldsExApi";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsEditRegionFldsExWApi()
        {
        }
        public static List<clsEditRegionFldsENEx> GetObjExLstByRegionId4InUse(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conEditRegionFlds.InUse);

            List<clsEditRegionFldsENEx> arrObjENExList = new List<clsEditRegionFldsENEx>();
            List<clsEditRegionFldsEN> arrObjList = GetObjLstByRegionId_Cache4InUseEx(lngRegionId, strPrjId);
            foreach (clsEditRegionFldsEN objEditRegionFldsEN in arrObjList)
            {
                clsEditRegionFldsENEx objEditRegionFldsENEx = new clsEditRegionFldsENEx();
                clsEditRegionFldsWApi.CopyTo(objEditRegionFldsEN, objEditRegionFldsENEx);
                objEditRegionFldsENEx.ObjFieldTabENEx = clsFieldTabExWApi.GetObjExByFldIDCache(objEditRegionFldsENEx.FldId, strPrjId);

                arrObjENExList.Add(objEditRegionFldsENEx);
            }
            return arrObjENExList;
        }

    
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <param name = "strPrjId"></param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsEditRegionFldsEN> GetObjLstByRegionId_Cache4InUseEx(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Cache = clsEditRegionFldsWApi.GetObjLstCache(strPrjId);
            IEnumerable<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel1 =
            from objEditRegionFldsEN in arrEditRegionFldsObjLst_Cache
            where objEditRegionFldsEN.RegionId == lngRegionId && objEditRegionFldsEN.InUse == true
            orderby objEditRegionFldsEN.SeqNum
            select objEditRegionFldsEN;
            List<clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel = new List<clsEditRegionFldsEN>();
            foreach (clsEditRegionFldsEN obj in arrEditRegionFldsObjLst_Sel1)
            {
                arrEditRegionFldsObjLst_Sel.Add(obj);
            }
            //if (arrEditRegionFldsObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrEditRegionFldsObjLst_Sel;
        }
        public static List<string> getRelaTabId4Ddl(string lngRegionId, string strPrjId)
        {
            string strCondition = string.Format("{0}={1}",
                conEditRegionFlds.RegionId, lngRegionId);

            List<string> arrTabId = new List<string>();
            List<clsEditRegionFldsENEx> arrObjENExList = clsEditRegionFldsExWApi.GetObjExLstByRegionId4InUse(lngRegionId, strPrjId);

            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in arrObjENExList)
            {
                if (objEditRegionFldsENEx.CtlTypeId != enumCtlTypeWA.DropDownList_06) continue;
                string strTabId = objEditRegionFldsENEx.DsTabId;
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
            }

            return arrTabId;
        }
    }
}