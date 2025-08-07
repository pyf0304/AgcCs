using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.common;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// clsvSqlViewFldBL扩展类
    /// </summary>
    public class clsvSqlViewFldBLEx : clsvSqlViewFldBL
    {


        #region 缓存操作
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// </summary>
        //public static List<clsvSqlViewFldEN> arrvSqlViewFldObjLstOrderByTabIdFldIdExCache = null;
       
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        //protected static int intFindFailCount = 0;


        ///// <summary>
        ///// 初始化列表缓存.
        ///// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        ///// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsFieldTabBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsSqlViewFldBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsSqlViewFldBL没有刷新缓存机制(clsSqlViewFldBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsProjectsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsPrjTabBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsSqlViewBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsSqlViewBL没有刷新缓存机制(clsSqlViewBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsTextResourceTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsTextResourceTypeBL没有刷新缓存机制(clsTextResourceTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsTabRelationTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsTabRelationTypeBL没有刷新缓存机制(clsTabRelationTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsSqlViewRelaTabBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsSqlViewRelaTabBL没有刷新缓存机制(clsSqlViewRelaTabBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsSV_RelaTabTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsSV_RelaTabTypeBL没有刷新缓存机制(clsSV_RelaTabTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //初始化列表缓存
        //    if (strPrjIdCache_Init != strPrjId) clsvSqlViewFldBL.ReFreshThisCache();

        //    string strWhereCond = string.Format("PrjId = '{0}' order by SqlViewId", strPrjId); 
        //    if (clsvSqlViewFldBL.arrvSqlViewFldObjLstCache == null)
        //    {
        //        clsvSqlViewFldBL.arrvSqlViewFldObjLstCache = clsvSqlViewFldBL.GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({2})",
        //          strPrjId, strPrjIdCache_Init, clsStackTrace.GetCurrClassFunction());
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}


        /// <summary>
        /// 根据[表Id(SqlViewId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strSqlViewId">表Id</param>
        /// <returns>根据[表Id(SqlViewId)]获取的相关对象子表</returns>
        public static List<clsvSqlViewFldEN> GetvSqlViewFldObjSubLstBySqlViewIdExCache(string strPrjId, string strSqlViewId)
        {
            List<clsvSqlViewFldEN> arrObjLstCache = clsvSqlViewFldBL.GetObjLstCache(strPrjId);
                      
            IEnumerable<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel1 =
from objvSqlViewFldEN in arrObjLstCache
where objvSqlViewFldEN.SqlViewId == strSqlViewId
select objvSqlViewFldEN;
            List<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel = arrvSqlViewFldObjLst_Sel1.OrderBy(x=>x.SqlViewId).ToList();   
            return arrvSqlViewFldObjLst_Sel;
        }

        /// <summary>
        /// 根据[表Id(SqlViewId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strSqlViewName">表Id</param>
        /// <returns>根据[表Id(SqlViewId)]获取的相关对象子表</returns>
        public static List<clsvSqlViewFldEN> GetvSqlViewFldObjSubLstBySqlViewNameExCache(string strPrjId, string strSqlViewName)
        {
            List<clsvSqlViewFldEN> arrObjLstCache = clsvSqlViewFldBL.GetObjLstCache(strPrjId);
                        
            IEnumerable<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel1 =
                from objvSqlViewFldEN in arrObjLstCache
                where objvSqlViewFldEN.SqlViewName == strSqlViewName
                select objvSqlViewFldEN;
            List<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel = arrvSqlViewFldObjLst_Sel1.OrderBy(x=>x.SqlViewName).ToList();
            return arrvSqlViewFldObjLst_Sel;
            
        }



        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "strFldName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvSqlViewFldEN GetvSqlViewFldObjByTabIdFldNameExCache(string strPrjId, 
            string strTabId, string strFldName)
        {
            //初始化列表缓存
            List<clsvSqlViewFldEN> arrObjLstCache = clsvSqlViewFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel1 =
            from objvSqlViewFldEN in arrObjLstCache
            where objvSqlViewFldEN.RelaTabId4SqlView == strTabId
            && objvSqlViewFldEN.FldName == strFldName
            select objvSqlViewFldEN;
            List<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel = new List<clsvSqlViewFldEN>();
            foreach (clsvSqlViewFldEN obj in arrvSqlViewFldObjLst_Sel1)
            {
                arrvSqlViewFldObjLst_Sel.Add(obj);
            }
            if (arrvSqlViewFldObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvSqlViewFldObjLst_Sel[0];
        }

        ///// <summary>
        ///// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        ///// </summary>
        ///// <param name = "lngmId">所给的关键字</param>
        ///// <returns>根据关键字获取的对象</returns>
        //public static clsvSqlViewFldEN GetvSqlViewFldObjByTabIdFldNameCache_Seq(string strPrjId, string strTabId, string strFldName)
        //{
        //    string strCondition = string.Format("1 = 1 And PrjId = '{0}' order by TabId, FldId", strPrjId);
        //    if (arrvSqlViewFldObjLstOrderByTabIdFldIdExCache  ==  null)
        //    {
        //        arrvSqlViewFldObjLstOrderByTabIdFldIdExCache = new clsvSqlViewFldDA().GetObjLst(strCondition);
        //    }
        //    foreach (clsvSqlViewFldEN objvSqlViewFldEN in arrvSqlViewFldObjLstOrderByTabIdFldIdExCache)
        //    {
        //        if (objvSqlViewFldEN.PrjId !=  strPrjId)
        //        {
        //            arrvSqlViewFldObjLstOrderByTabIdFldIdExCache = null;
        //            return GetvSqlViewFldObjByTabIdFldNameCache_Seq(strPrjId, strTabId, strFldName);
        //        }
        //        if (objvSqlViewFldEN.RelaTabId4SqlView  ==  strTabId && objvSqlViewFldEN.FldName  ==  strFldName && string .IsNullOrEmpty(objvSqlViewFldEN.FieldAliases)  ==  true)
        //        {
        //            intFindFailCount = 0;
        //            return objvSqlViewFldEN;
        //        }
        //    }
        //    return null;
        //    //intFindFailCount++;
        //    //// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        //    //arrvSqlViewFldObjLstOrderByTabIdFldIdExCache = null;
        //    //if (intFindFailCount  ==  1) return GetvSqlViewFldObjByTabIdFldIdCache_Seq(strPrjId, strTabId, strFldId);
        //    //string strErrMsgForGetObjById = string.Format("在vSqlViewFld对象缓存列表中,找不到记录[PrjId = {0}&TabId = {1}&FldId = {2}][intFindFailCount = {3}](函数:GetvSqlViewFldObjByTabIdFldIdCache_Seq)", strPrjId, strTabId, strFldId, intFindFailCount);
        //    //clsLog.LogErrorS2("clsvSqlViewFldBL", "GetvSqlViewFldObjByTabIdFldIdCache_Seq", strErrMsgForGetObjById, "", "");
        //    //throw new Exception(strErrMsgForGetObjById);
        //}
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "strFldName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvSqlViewFldEN GetvSqlViewFldObjByTabIdFieldAliasesExCache(string strPrjId,
      string strTabId, string strFldName)
        {
            //初始化列表缓存
            List<clsvSqlViewFldEN> arrObjLstCache = clsvSqlViewFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel1 =
            from objvSqlViewFldEN in arrObjLstCache
            where objvSqlViewFldEN.RelaTabId4SqlView == strTabId
            && objvSqlViewFldEN.FieldAliases == strFldName
            select objvSqlViewFldEN;
            List<clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel = new List<clsvSqlViewFldEN>();
            foreach (clsvSqlViewFldEN obj in arrvSqlViewFldObjLst_Sel1)
            {
                arrvSqlViewFldObjLst_Sel.Add(obj);
            }
            if (arrvSqlViewFldObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvSqlViewFldObjLst_Sel[0];
        }

        ///// <summary>
        ///// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        ///// </summary>
        ///// <param name = "lngmId">所给的关键字</param>
        ///// <returns>根据关键字获取的对象</returns>
        //public static clsvSqlViewFldEN GetvSqlViewFldObjByTabIdFieldAliasesCache_Seq(string strPrjId, string strTabId, string strFldName)
        //{
        //    string strCondition = string.Format("1 = 1 And PrjId = '{0}' order by TabId, FldId", strPrjId);
        //    if (arrvSqlViewFldObjLstOrderByTabIdFldIdExCache  ==  null)
        //    {
        //        arrvSqlViewFldObjLstOrderByTabIdFldIdExCache = new clsvSqlViewFldDA().GetObjLst(strCondition);
        //    }
        //    foreach (clsvSqlViewFldEN objvSqlViewFldEN in arrvSqlViewFldObjLstOrderByTabIdFldIdExCache)
        //    {
        //        if (objvSqlViewFldEN.PrjId !=  strPrjId)
        //        {
        //            arrvSqlViewFldObjLstOrderByTabIdFldIdExCache = null;
        //            return GetvSqlViewFldObjByTabIdFieldAliasesCache_Seq(strPrjId, strTabId, strFldName);
        //        }
        //        if (objvSqlViewFldEN.RelaTabId4SqlView  ==  strTabId && objvSqlViewFldEN.FieldAliases  ==  strFldName)
        //        {
        //            intFindFailCount = 0;
        //            return objvSqlViewFldEN;
        //        }
        //    }
        //    return null;
        //    //intFindFailCount++;
        //    //// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        //    //arrvSqlViewFldObjLstOrderByTabIdFldIdExCache = null;
        //    //if (intFindFailCount  ==  1) return GetvSqlViewFldObjByTabIdFldIdCache_Seq(strPrjId, strTabId, strFldId);
        //    //string strErrMsgForGetObjById = string.Format("在vSqlViewFld对象缓存列表中,找不到记录[PrjId = {0}&TabId = {1}&FldId = {2}][intFindFailCount = {3}](函数:GetvSqlViewFldObjByTabIdFldIdCache_Seq)", strPrjId, strTabId, strFldId, intFindFailCount);
        //    //clsLog.LogErrorS2("clsvSqlViewFldBL", "GetvSqlViewFldObjByTabIdFldIdCache_Seq", strErrMsgForGetObjById, "", "");
        //    //throw new Exception(strErrMsgForGetObjById);
        //}

        #endregion 缓存操作
    }
}
