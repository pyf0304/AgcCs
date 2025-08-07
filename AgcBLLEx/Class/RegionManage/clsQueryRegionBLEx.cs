using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;
using AGC.DAL;
using System.Collections;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.datetime;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsQueryRegionBLEx 
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
        //    if (clsQueryRegionBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsQueryRegionBL没有刷新缓存机制(clsQueryRegionBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjId_Cache_Init != strPrjId) arrQueryRegionObjLst_Cache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by RegionId");
        //    if (arrQueryRegionObjLst_Cache == null)
        //    {
        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by RegionId",
        //               clsQueryRegionEN.con_RegionId, clsvViewRegionEN._CurrTabName_S, clsvViewRegionEN.con_PrjId, strPrjId);
        //        arrQueryRegionObjLst_Cache = new clsQueryRegionDA().GetObjLst(strWhereCond);
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
        //public static clsQueryRegionEN GetObjByRegionId_CacheEx(string lngRegionId, string strPrjId)
        //{
        //    //初始化列表缓存
        //    List<clsQueryRegionEN> arrObjLst_Cache = clsQueryRegionBL.GetObjLst_Cache(strPrjId);

        //    IEnumerable<clsQueryRegionEN> arrQueryRegionObjLst_Sel1 =
        //    from objQueryRegionEN in arrObjLst_Cache
        //    where objQueryRegionEN.RegionId == lngRegionId
        //    select objQueryRegionEN;
        //    List<clsQueryRegionEN> arrQueryRegionObjLst_Sel = new List<clsQueryRegionEN>();
        //    foreach (clsQueryRegionEN obj in arrQueryRegionObjLst_Sel1)
        //    {
        //        arrQueryRegionObjLst_Sel.Add(obj);
        //    }
        //    if (arrQueryRegionObjLst_Sel.Count == 0)
        //    {
        //        return null;
        //    }
        //    return arrQueryRegionObjLst_Sel[0];
        //}

        //public static void GetQueryRegionEx(ref clsQueryRegionENEx objQueryRegionENEx, string strPrjId)
        //{
        //    //clsQueryRegionDAEx objQueryRegionDA = new clsQueryRegionDAEx();
        //    //bool bolResult = objQueryRegionDA.GetQueryRegionEx(ref objQueryRegionEN);
        //    //return bolResult;
        //    clsQueryRegionEN objQueryRegionEN = GetObjByRegionId_CacheEx(objQueryRegionENEx.RegionId, strPrjId);
        //   if (objQueryRegionEN == null)
        //    {
        //        string strMsg = string.Format("RegionId={0}的查询区不存在，请重新建立界面再试试！", objQueryRegionENEx.RegionId);
        //        throw new Exception(strMsg);
        //    }
        //    clsQueryRegionBL.CopyTo(objQueryRegionEN, objQueryRegionENEx);
        //}

    }

}
