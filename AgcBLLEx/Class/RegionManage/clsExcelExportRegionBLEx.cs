using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.DAL;
using AGC.Entity;
using System.Collections;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.datetime;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsExcelExportRegionBLEx 
    {
        public static string strPrjId_Cache_Init = "";

        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsExcelExportRegionBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsExcelExportRegionBL没有刷新缓存机制(clsExcelExportRegionBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjId_Cache_Init != strPrjId) arrExcelExportRegionObjLst_Cache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by RegionId");
        //    if (arrExcelExportRegionObjLst_Cache == null)
        //    {           
        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by RegionId",
        //           clsExcelExportRegionEN.con_RegionId, clsvViewRegionEN._CurrTabName_S, clsvViewRegionEN.con_PrjId, strPrjId);

        //        arrExcelExportRegionObjLst_Cache = new clsExcelExportRegionDA().GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjId_Cache_Init={1}.({4}->{3}->{2})",
        //          strPrjId, strPrjId_Cache_Init,
        //          clsStackTrace.GetCurrClassFunction(),
        //          clsStackTrace.GetCurrClassFunctionByLevel(2),
        //          clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjId_Cache_Init = strPrjId;
        //    }
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        //public static clsExcelExportRegionEN GetObjByRegionId_CacheEx(string lngRegionId, string strPrjId)
        //{
        //    //初始化列表缓存
        //    List<clsExcelExportRegionEN> arrObjLst_Cache = clsExcelExportRegionBL.GetObjLst_Cache(strPrjId);

        //    IEnumerable<clsExcelExportRegionEN> arrExcelExportRegionObjLst_Sel1 =
        //    from objExcelExportRegionEN in arrObjLst_Cache
        //    where objExcelExportRegionEN.RegionId == lngRegionId
        //    select objExcelExportRegionEN;
        //    List<clsExcelExportRegionEN> arrExcelExportRegionObjLst_Sel = new List<clsExcelExportRegionEN>();
        //    foreach (clsExcelExportRegionEN obj in arrExcelExportRegionObjLst_Sel1)
        //    {
        //        arrExcelExportRegionObjLst_Sel.Add(obj);
        //    }
        //    if (arrExcelExportRegionObjLst_Sel.Count == 0)
        //    {
        //        return null;
        //    }
        //    return arrExcelExportRegionObjLst_Sel[0];
        //}

        //public static void GetExcelExportRegionEx(ref clsExcelExportRegionENEx objExcelExportRegionENEx, string strPrjId)
        //{
        //    //clsExcelExportRegionDAEx objExcelExportRegionDA = new clsExcelExportRegionDAEx();
        //    //bool bolResult = objExcelExportRegionDA.GetExcelExportRegionEx(ref objExcelExportRegionEN);
        //    //return bolResult;
        //    clsExcelExportRegionEN objExcelExportRegionEN = GetObjByRegionId_CacheEx(objExcelExportRegionENEx.RegionId, 
        //        strPrjId);
        //    if (objExcelExportRegionEN == null) return;
        //    clsExcelExportRegionBL.CopyTo(objExcelExportRegionEN, objExcelExportRegionENEx);
        //}

    
        }

}
