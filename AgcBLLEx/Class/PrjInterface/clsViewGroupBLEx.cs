using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public partial class clsViewGroupBLEx : clsViewGroupBL
    {
        public static string strPrjIdCache_Init = "";
        public static string GetFirstViewGroupId(string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            string strViewGroupId = clsViewGroupBL.GetFirstID_S(sbCondition.ToString());
            return strViewGroupId;
        }


        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsViewGroupBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsViewGroupBL没有刷新缓存机制(clsViewGroupBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrViewGroupObjLstCache = null;

        //    //初始化列表缓存
        //    if (arrViewGroupObjLstCache == null)
        //    {
        //        string strWhereCond = string.Format("{0} = '{1}' order by {2}",
        //            clsViewGroupEN.con_PrjId, strPrjId, clsViewGroupEN.con_ViewGroupId);

        //        arrViewGroupObjLstCache = clsViewGroupBL.GetObjLst(strWhereCond);

        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({4}->{3}->{2})",
        //            strPrjId, strPrjIdCache_Init,
        //            clsStackTrace.GetCurrClassFunction(),
        //            clsStackTrace.GetCurrClassFunctionByLevel(2),
        //            clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strViewGroupId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsViewGroupEN GetViewGroupObjByViewGroupIdCacheEx(string strViewGroupId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strViewGroupId) == true) return null;
            //string strCondition = string.Format("{0} = '{1}' order by ViewGroupId", clsViewGroupEN.con_PrjId, strPrjId);
            //if (arrViewGroupObjLstCacheEx  ==  null)
            //{
            //    arrViewGroupObjLstCacheEx = new clsViewGroupDA().GetObjLst(strCondition);
            //}
            List<clsViewGroupEN> arrObjLstCache = clsViewGroupBL.GetObjLstCache(strPrjId);

            IEnumerable<clsViewGroupEN> arrViewGroupObjLst_Sel1 =
                from objViewGroupEN in arrObjLstCache
                where objViewGroupEN.ViewGroupId == strViewGroupId
                select objViewGroupEN;
            List<clsViewGroupEN> arrViewGroupObjLst_Sel = new List<clsViewGroupEN>();
            foreach (clsViewGroupEN obj in arrViewGroupObjLst_Sel1)
            {
                arrViewGroupObjLst_Sel.Add(obj);
            }
            if (arrViewGroupObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrViewGroupObjLst_Sel[0];
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsViewGroupEN> GetViewGroupObjLstByPrjIdCache(string strPrjId)
        {
            //初始化列表缓存
            List<clsViewGroupEN> arrObjLstCache = clsViewGroupBL.GetObjLstCache(strPrjId).OrderBy(x=>x.ViewGroupName).ToList();

            return arrObjLstCache;
        }

    }
}
