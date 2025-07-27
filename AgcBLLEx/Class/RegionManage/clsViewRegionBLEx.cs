using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;


namespace AGC.BusinessLogicEx
{
    public static class clsViewRegionBLEx_Static
    {
        public static bool InUseInViewId(this clsViewRegionEN objViewRegion, string strViewId, string strCmPrjId)
        {
            var objViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(strViewId, objViewRegion.RegionId, strCmPrjId, "");
            if (objViewRegionRela == null) return false;

            return objViewRegionRela.InUse;
        }
        public static bool InUseInViewInfo(this clsViewRegionEN objViewRegion, clsViewInfoEN objViewInfo)
        {
            var objViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(objViewInfo.ViewId, objViewRegion.RegionId, objViewInfo.PrjId, "");
            if (objViewRegionRela == null) return false;

            return objViewRegionRela.InUse;
        }

        public static bool IsDispInViewId(this clsViewRegionEN objViewRegion, string strViewId, string strCmPrjId)
        {
            var objViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(strViewId, objViewRegion.RegionId, strCmPrjId, "");
            if (objViewRegionRela == null) return false;

            return objViewRegionRela.IsDisp;
        }
        public static bool IsDispInViewInfo(this clsViewRegionEN objViewRegion, clsViewInfoEN objViewInfo)
        {
            var objViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(objViewInfo.ViewId, objViewRegion.RegionId, objViewInfo.PrjId, "");
            if (objViewRegionRela == null) return false;

            return objViewRegionRela.IsDisp || objViewRegionRela.InUse;
        }

        
        public static string PrjId(this clsViewRegionEN objViewRegion)
        {
            //if (string.IsNullOrEmpty(objViewRegion.PrjId) == true) return "";
            //var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(objViewRegion.PrjId);
            //if (objCmProject == null) return "";

            return objViewRegion.PrjId;
        }

        public static bool IsJumpPage(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }
        public static bool IsRadio(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return false;
            return false;
        }
        public static bool IsCheck(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool IsHaveDelBtn(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool IsHaveUpdBtn(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }
        public static bool IsHaveDetailBtn(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool IsHaveAddNewRecord(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> {enumPrjFeature.AddNewRecord_0136, enumPrjFeature.AddNewRecord_0197, enumPrjFeature.AddNewRecordWithMaxId_0183 };
            var arr1 = arrFeatureRegionFlds.Where(x=> arrPrjFeature.Contains( x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }

        public static bool IsHaveUpdateRecord(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }
        public static bool IsHaveUpdateRecord_Gv(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.UpdateRecord_Gv_0174 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }
        public static bool IsHaveDetailRecord(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.DetailRecord_0239, enumPrjFeature.DetailRecord_Gv_0181 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }
        public static bool IsHaveDelRecord(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.DelRecord_0138, enumPrjFeature.DelRecord_0184, enumPrjFeature.DelRecord_Gv_0175 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }
        public static bool IsHaveDetailRecord_Gv(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.DetailRecord_Gv_0181, enumPrjFeature.DelRecord_Gv_0175, };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }

        public static bool IsHaveDelRecordBySign(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.DelRecordBySign_0157 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }

        public static bool IsHaveAdjustOrderNum(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.AdjustOrderNum_0142,
                enumPrjFeature.AdjustOrderNum_0224,
                enumPrjFeature.AdjustOrderNum_0225,
                enumPrjFeature.AdjustOrderNum_1196  };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }

        public static bool IsHaveExportToFile(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.ExportToFile_0143, enumPrjFeature.ExportToFile_0196 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }
        public static bool IsHaveSetExportExcel(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.SetExportExcel4User_0144 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }

        public static bool IsHaveCopyRecord(this clsViewRegionEN objViewRegion)
        {
            var arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(objViewRegion.RegionId, objViewRegion.PrjId);
            List<string> arrPrjFeature = new List<string> { enumPrjFeature.CopyRecord_0141, enumPrjFeature.CopyRecord_0198 };
            var arr1 = arrFeatureRegionFlds.Where(x => arrPrjFeature.Contains(x.FeatureId));
            if (arr1.Count() > 0) return true;

            return false;
        }
        public static bool AllowSorting(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }
        public static bool AllowPaging(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool AutoGenerateColumns(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return false;
            return false;
        }

        public static string TabName(this clsViewRegionEN objViewRegion)
        {
            if (string.IsNullOrEmpty(objViewRegion.TabId) == true) return "";
            return clsPrjTabBL.GetNameByTabIdCache(objViewRegion.TabId, objViewRegion.PrjId());
        }



        public static bool IsInTab(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return false;
            return false;
        }


        public static int FieldNum(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.QueryRegion_0001) return 10;
            if (objViewRegion.RegionTypeId == enumRegionType.EditRegion_0003) return 10;

            return 0;
        }


        public static int FldCount(this clsViewRegionEN objViewRegion)
        {
            string strPrjId = objViewRegion.PrjId;
            int intFldCount = 0;
            switch (objViewRegion.RegionTypeId)
            {
                case enumRegionType.QueryRegion_0001:

                    intFldCount = clsQryRegionFldsBLEx.GetRecCountCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.EditRegion_0003:
                    intFldCount = clsEditRegionFldsBLEx.GetRecCountCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.FeatureRegion_0008:
                    intFldCount = clsFeatureRegionFldsBLEx.GetRecCountCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.ListRegion_0002:
                    intFldCount = clsDGRegionFldsBLEx.GetRecCountCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.ExcelExportRegion_0007:
                    intFldCount = clsExcelExportRegionFldsBLEx.GetRecCountCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.DetailRegion_0006:
                    intFldCount = clsDetailRegionFldsBLEx.GetRecCountCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                default:
                    return 0;
            }
        }

        public static int FldCountInUse(this clsViewRegionEN objViewRegion)
        {
            string strPrjId = objViewRegion.PrjId;
            int intFldCount = 0;
            switch (objViewRegion.RegionTypeId)
            {
                case enumRegionType.QueryRegion_0001:

                    intFldCount = clsQryRegionFldsBLEx.GetRecCount4InUseCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.EditRegion_0003:
                    intFldCount = clsEditRegionFldsBLEx.GetRecCount4InUseCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.FeatureRegion_0008:
                    intFldCount = clsFeatureRegionFldsBLEx.GetRecCount4InUseCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.ListRegion_0002:
                    intFldCount = clsDGRegionFldsBLEx.GetRecCount4InUseCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.ExcelExportRegion_0007:
                    intFldCount = clsExcelExportRegionFldsBLEx.GetRecCount4InUseCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                case enumRegionType.DetailRegion_0006:
                    intFldCount = clsDetailRegionFldsBLEx.GetRecCount4InUseCache1(objViewRegion.RegionId, objViewRegion.PrjId);
                    return intFldCount;
                default:
                    return 0;
            }
        }

        public static int StyleZindex(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return 1000;
            return 0;
        }
        public static int PageSize(this clsViewRegionEN objViewRegion)
        {
            if (objViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return 15;
            return 0;
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewRegionENS">源对象</param>
        /// <returns>目标对象=>clsViewRegionEN:objViewRegionENT</returns>
        public static clsViewRegionENEx CopyToEx(this clsViewRegionEN objViewRegionENS)
        {
            try
            {
                clsViewRegionENEx objViewRegionENT = new clsViewRegionENEx();
                clsViewRegionBL.CopyTo(objViewRegionENS, objViewRegionENT);
                return objViewRegionENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objViewRegionENS">源对象</param>
        /// <returns>目标对象=>clsViewRegionEN:objViewRegionENT</returns>
        public static clsViewRegionEN CopyTo(this clsViewRegionENEx objViewRegionENS)
        {
            try
            {
                clsViewRegionEN objViewRegionENT = new clsViewRegionEN();
                clsViewRegionBL.CopyTo(objViewRegionENS, objViewRegionENT);
                return objViewRegionENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }


    public partial class clsViewRegionBLEx : clsViewRegionBL
    {
        public static string strPrjIdCache_Init = "";

        /// <summary>
        /// 绑定基于Web的下拉框 
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程Id</param>
        public static void BindDdl_TabIdExCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选[工程表]...", "0");

            var arrViewRegion = clsViewRegionBL.GetObjLstCache(strPrjId);
            var arrTabId = arrViewRegion.Select(x => x.TabId).Distinct();
            List<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLstCache(strPrjId)
                .Where(x => arrTabId.Contains(x.TabId) && x.TabStateId == enumTabState.Normal_01)
                .OrderBy(x => x.TabName)
                .ToList();

            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        //public static bool CheckDuplicate(clsViewRegionEN objclsViewRegion)
        //{
        //    StringBuilder sbWhereCond = new StringBuilder();
        //    sbWhereCond.AppendFormat("ViewId = '{0}'", objclsViewRegion.ViewId);
        //    sbWhereCond.AppendFormat("And RegionName = '{0}'", objclsViewRegion.RegionName);
        //    return clsViewRegionBL.IsExistRecord(sbWhereCond.ToString());
        //}
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsViewRegionBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsViewRegionBL没有刷新缓存机制(clsViewRegionBL.objCommFun4BL == null), 请联系程序员！({1}->{0})",
        //            clsStackTrace.GetCurrClassFunction(),
        //            clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrViewRegionObjLstCache = null;

        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by RegionId");
        //    string strWhereCond = string.Format("{0} in (select {0} From {1} where {2}= '{3}') order by {4}",
        //           conViewRegion.ViewId,
        //           clsViewInfoEN._CurrTabName,
        //           clsViewInfoEN.con_PrjId,
        //           strPrjId, conViewRegion.RegionId);
        //    if (arrViewRegionObjLstCache == null)
        //    {
        //        arrViewRegionObjLstCache = new clsViewRegionDA().GetObjLst(strWhereCond);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strViewId">strViewId</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "strRegionTypeId">区域类型Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsViewRegionEN GetObjByRegionIdCacheEx2(string strViewId, string strRegionTypeId, string strPrjId)
        {
            //初始化列表缓存
            List<clsViewRegionEN> arrObjLstCache = clsViewRegionBL.GetObjLstCache(strPrjId);
            List<clsViewRegionRelaEN> arrObjLstRelaCache = clsViewRegionRelaBL.GetObjLstCache(strPrjId);

            IEnumerable<clsViewRegionRelaEN> arrViewRegionObjLst_Sel1 =
            from objViewRegionRelaEN in arrObjLstRelaCache
            where objViewRegionRelaEN.ViewId == strViewId
            select objViewRegionRelaEN;
            IEnumerable<string> arrRegionId_Sel1 = arrViewRegionObjLst_Sel1.Select(x => x.RegionId);


            List<clsViewRegionEN> arrViewRegionObjLst_Sel = arrObjLstCache.Where(x => arrRegionId_Sel1.Contains(x.RegionId))
                .Where(x => x.RegionTypeId == strRegionTypeId).ToList();

            if (arrViewRegionObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrViewRegionObjLst_Sel[0];
        }


        /// <summary>
        /// 根据界面Id和区域类型Id获取相关区域Id
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strRegionTypeId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static string GetRegionIdByTypeCache2(string strViewId, string strRegionTypeId, string strPrjId)
        {
            clsViewRegionEN objViewRegionEN = GetObjByRegionIdCacheEx2(strViewId, strRegionTypeId, strPrjId);
            if (objViewRegionEN != null) return objViewRegionEN.RegionId;

            return "";
        }

        public static clsViewRegionEN GetObjByTypeCache2(string strViewId, string strRegionTypeId, string strPrjId)
        {
            clsViewRegionEN objViewRegionEN = GetObjByRegionIdCacheEx2(strViewId, strRegionTypeId, strPrjId);
            if (objViewRegionEN != null) return objViewRegionEN;
            return null;
        }
        /// <summary>
        /// 根据区域类型获取某ViewId的区域Id
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strRegionTypeId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static string GetRegionIdByTypeEx(string strViewId, string strRegionTypeId, string strPrjId)
        {
            clsViewRegionEN objViewRegionEN = GetObjByRegionIdCacheEx2(strViewId, strRegionTypeId, strPrjId);
            if (objViewRegionEN != null) return objViewRegionEN.RegionId;

            return "";
        }




        public static bool SetClassName(string lngRegionId, int intApplicationTypeId)
        {
            K_RegionId_ViewRegion objKey = lngRegionId;
            clsViewRegionEN objViewRegionEN = objKey.GetObj();
            K_TabId_PrjTab objKey_TabId = objViewRegionEN.TabId;
            clsPrjTabEN objPrjTab = null;
            string strClassName = "";
            //K_ViewId_ViewInfo objKey2 = objViewRegionEN.ViewId;
            //clsViewInfoEN objViewInfoEN = objKey2.GetObj();
            switch ((enumApplicationType)intApplicationTypeId)
            {
                case enumApplicationType.WinApp_1:
                    switch (objViewRegionEN.RegionTypeId)
                    {
                        case enumRegionType.EditRegion_0003:
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("wuc{0}", objPrjTab.TabName);
                            break;

                        case enumRegionType.ListRegion_0002:
                            objKey_TabId = objViewRegionEN.TabId;
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("wuc{0}4Gv", objPrjTab.TabName);
                            break;

                    }
                    break;
                case enumApplicationType.WebApp_2:
                case enumApplicationType.Neo4JApp_24:
                    switch (objViewRegionEN.RegionTypeId)
                    {
                        case enumRegionType.EditRegion_0003:
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("wuc{0}", objPrjTab.TabName);
                            break;

                        case enumRegionType.ListRegion_0002:
                            objKey_TabId = objViewRegionEN.TabId;
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("wuc{0}4Gv", objPrjTab.TabName);
                            break;

                    }
                    break;
                case enumApplicationType.WebApp_JS_RJ_28:
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.SpaInCoreUT_27:

                    switch (objViewRegionEN.RegionTypeId)
                    {
                        case enumRegionType.EditRegion_0003:
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("{0}_Edit", objPrjTab.TabName);
                            break;
                        case enumRegionType.ListRegion_0002:
                            objKey_TabId = objViewRegionEN.TabId;
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("{0}_List", objPrjTab.TabName);
                            break;
                        case enumRegionType.DetailRegion_0006:
                            objKey_TabId = objViewRegionEN.TabId;
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("{0}_Detail", objPrjTab.TabName);
                            break;
                        case enumRegionType.FeatureRegion_0008:
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("{0}_Feature", objPrjTab.TabName);

                            break;

                        case enumRegionType.ExcelExportRegion_0007:
                            objPrjTab = objKey_TabId.GetObj();
                            if (objPrjTab == null) return true;
                            strClassName = string.Format("{0}_ExcelExport", objPrjTab.TabName);

                            break;
                        default:
                            string strMsg1 = string.Format("设置类名在函数中没有被处理！(In {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg1);

                    }
                    break;
                default:
                    string strMsg = string.Format("设置类名在函数中没有被处理！(In {0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //                    break;
            }
            string strClassName_New = strClassName;
            int intCount = 2;
            while (true)
            {
                string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                    conViewRegion.PrjId, objViewRegionEN.PrjId,
                    conViewRegion.ClsName, strClassName_New);
                if (clsViewRegionBL.IsExistRecord(strCondition) == true)
                {
                    strClassName_New = string.Format("{0}_{1}", strClassName, intCount);
                    intCount++;
                }
                else
                {
                    break;
                }
            }
            objViewRegionEN.ClsName = strClassName_New;
            return objViewRegionEN.Update();

        }

        public static bool SetClassName4ViewInfo(string strViewId)
        {
            var objViewInfo = clsViewInfoBL.GetObjByViewId(strViewId);
            List<string> arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewId(strViewId);

            foreach (string strRegionId in arrRegionId)
            {
                clsViewRegionBLEx.SetClassName(strRegionId, objViewInfo.ApplicationTypeId);
            }
            return true;
        }



        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrRegionIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetInUse(List<string> arrRegionIdLst, string strViewId, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (string strRegionId in arrRegionIdLst)
                {
                    clsViewRegionRelaEN objViewRegionRelaEN = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionId(strViewId, strRegionId);
                    objViewRegionRelaEN.InUse = true;
                    objViewRegionRelaEN.UpdUser = strUpdUser;
                    objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsViewRegionRelaBL.UpdateBySql2(objViewRegionRelaEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 功能:设置字段不可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrRegionIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置不可用的记录数</returns>
        public static int SetNotInUse(List<string> arrRegionIdLst, string strViewId, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (string strRegionId in arrRegionIdLst)
                {
                    clsViewRegionRelaEN objViewRegionRelaEN = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionId(strViewId, strRegionId);
                    objViewRegionRelaEN.InUse = false;
                    objViewRegionRelaEN.UpdUser = strUpdUser;
                    objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsViewRegionRelaBL.UpdateBySql2(objViewRegionRelaEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段不可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static bool DeleteByRegionIdEx(string strRegionId, string strCmPrjId)
        {
            //获取所有相关的ViewRegions对象列表
            string strPrjId_P = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionIdCache(strRegionId, strPrjId_P);
            if (objViewRegionEN == null)
            {
                string strMsg = string.Format("RegionId=[{0}](PrjId:{1})的区域不存在！", strRegionId, strPrjId_P);
                throw new Exception(strMsg);
            }
            switch (objViewRegionEN.RegionTypeId)
            {
                case clsRegionTypeBLEx.QUERYREGION:
                    clsQryRegionFldsBL.DelQryRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                    //clsQueryRegionBL.DelQueryRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                    break;
                case clsRegionTypeBLEx.EDITREGION:
                    clsEditRegionFldsBL.DelEditRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                    //clsEditRegionBL.DelEditRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                    break;
                case clsRegionTypeBLEx.DETAILREGION:
                    clsEditRegionFldsBL.DelEditRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                    //clsEditRegionBL.DelEditRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                    break;
                case clsRegionTypeBLEx.DGREGION:
                    clsDGRegionFldsBL.DelDGRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                    //clsDGRegionBL.DelDGRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                    break;
                //case clsRegionTypeBLEx.LISTVIEWREGION:
                //    clsListViewRegionFldsBL.DelListViewRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                //    clsListViewRegionBL.DelListViewRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                //    break;
                case clsRegionTypeBLEx.TREEVIEWREGION:
                    //						clsQryRegionFldsENEx.DelMultiRec("QryRegionFlds", "RegionId = " + objViewRegionEN.RegionId);
                    break;

            }
            clsViewRegionRelaBL.DelViewRegionRelasByCond("RegionId = " + objViewRegionEN.RegionId);
            clsViewRegionBL.DelRecord(objViewRegionEN.RegionId);
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(objViewRegionEN.RegionId);


            return true;
        }


        public static bool DeleteByRegionIdsEx(List<string> lstKey)
        {
            //获取所有相关的ViewRegions对象列表
            ArrayList arrObjList = clsViewRegionBLEx.GetObjLstEx(lstKey);
            foreach (clsViewRegionEN objViewRegionEN in arrObjList)
            {
                switch (objViewRegionEN.RegionTypeId)
                {
                    case clsRegionTypeBLEx.QUERYREGION:
                        clsQryRegionFldsBL.DelQryRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsQueryRegionBL.DelQueryRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    case clsRegionTypeBLEx.EDITREGION:
                        clsEditRegionFldsBL.DelEditRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsEditRegionBL.DelEditRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    case clsRegionTypeBLEx.DETAILREGION:
                        clsEditRegionFldsBL.DelEditRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsEditRegionBL.DelEditRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    case clsRegionTypeBLEx.DGREGION:
                        clsDGRegionFldsBL.DelDGRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsDGRegionBL.DelDGRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    //case clsRegionTypeBLEx.LISTVIEWREGION:
                    //    clsListViewRegionFldsBL.DelListViewRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                    //    clsListViewRegionBL.DelListViewRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                    //    break;
                    case clsRegionTypeBLEx.TREEVIEWREGION:
                        //						clsQryRegionFldsENEx.DelMultiRec("QryRegionFlds", "RegionId = " + objViewRegionEN.RegionId);
                        break;

                }
                clsViewRegionRelaBL.DelViewRegionRelasByCond("RegionId = " + objViewRegionEN.RegionId);
                clsViewRegionBL.DelRecord(objViewRegionEN.RegionId);
                //设置当前界面的修改日期
                clsViewInfoBLEx.SetViewUpdDate(objViewRegionEN.RegionId);

            }
            return true;
        }

        public static bool DeleteByViewIdEx(string strViewId)
        {
            //获取所有相关的ViewRegions对象列表
            List<clsViewRegionEN> arrObjList = clsViewRegionBLEx.GetObjLstByViewId(strViewId);
            foreach (clsViewRegionEN objViewRegionEN in arrObjList)
            {
                switch (objViewRegionEN.RegionTypeId)
                {
                    case clsRegionTypeBLEx.QUERYREGION:
                        clsQryRegionFldsBL.DelQryRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsQueryRegionBL.DelQueryRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    case clsRegionTypeBLEx.EDITREGION:
                        clsEditRegionFldsBL.DelEditRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsEditRegionBL.DelEditRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    case clsRegionTypeBLEx.DETAILREGION:
                        clsEditRegionFldsBL.DelEditRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsEditRegionBL.DelEditRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    case clsRegionTypeBLEx.DGREGION:
                        clsDGRegionFldsBL.DelDGRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                        //clsDGRegionBL.DelDGRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                        break;
                    //case clsRegionTypeBLEx.LISTVIEWREGION:
                    //    clsListViewRegionFldsBL.DelListViewRegionFldssByCond("RegionId = " + objViewRegionEN.RegionId);
                    //    clsListViewRegionBL.DelListViewRegionsByCond("RegionId = " + objViewRegionEN.RegionId);
                    //    break;
                    case clsRegionTypeBLEx.TREEVIEWREGION:
                        //						clsQryRegionFldsENEx.DelMultiRec("QryRegionFlds", "RegionId = " + objViewRegionEN.RegionId);
                        break;

                }
                clsViewRegionBL.DelRecord(objViewRegionEN.RegionId);
                string strCondition = string.Format("{0}='{1}'", conViewRegionRela.ViewId, strViewId);
                clsViewRegionRelaBL.DelViewRegionRelasByCond(strCondition);
                //设置当前界面的修改日期
                clsViewInfoBLEx.SetViewUpdDate4RegionId(objViewRegionEN.RegionId);

            }
            return true;
        }
        public static ArrayList GetObjLstEx(List<string> lstKey)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strKeyList;
            if (lstKey.Count == 0) return null;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
                else strKeyList += "," + "" + lstKey[i].ToString() + "";
            }
            strSQL = "Select * from ViewRegion where RegionId in (" + strKeyList + ")";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
                objViewRegionEN.RegionId = objRow["RegionId"].ToString().Trim();
                objViewRegionEN.RegionName = objRow["RegionName"].ToString().Trim();
                //objViewRegionEN.ViewId = objRow["ViewId"].ToString().Trim();
                objViewRegionEN.RegionTypeId = objRow["RegionTypeId"].ToString().Trim();
                //objViewRegionEN.RegionFunction = objRow["RegionFunction"].ToString().Trim();
                objViewRegionEN.Height = clsGeneralTab2.TransNullToInt_S(objRow["Height"].ToString().Trim());
                objViewRegionEN.Width = clsGeneralTab2.TransNullToInt_S(objRow["Width"].ToString().Trim());
                objViewRegionEN.Memo = objRow["Memo"].ToString().Trim();
                objViewRegionEN.InOutTypeId = objRow["InOutTypeId"].ToString().Trim();
                objViewRegionEN.TabId = objRow["TabId"].ToString().Trim();

                arrObjList.Add(objViewRegionEN);
            }
            objDT = null;
            return arrObjList;
        }



        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewRegionDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewRegionDAEx ViewRegionDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewRegionDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewRegionENEx> GetObjExLst(string strCondition)
        {
            List<clsViewRegionEN> arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
            List<clsViewRegionENEx> arrObjExLst = new List<clsViewRegionENEx>();
            foreach (clsViewRegionEN objInFor in arrObjLst)
            {
                clsViewRegionENEx objViewRegionENEx = new clsViewRegionENEx();
                clsViewRegionBL.CopyTo(objInFor, objViewRegionENEx);
                arrObjExLst.Add(objViewRegionENEx);
            }
            return arrObjExLst;
        }
        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewRegionENEx> GetObjExLstByViewIdBak(string strViewId)
        {
            string strCondition = string.Format("{0}='{1}'", conViewRegionRela.ViewId, strViewId);
            List<clsViewRegionEN> arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
            List<clsViewRegionENEx> arrObjExLst = new List<clsViewRegionENEx>();
            foreach (clsViewRegionEN objInFor in arrObjLst)
            {
                clsViewRegionENEx objViewRegionENEx = new clsViewRegionENEx();
                clsViewRegionBL.CopyTo(objInFor, objViewRegionENEx);
                arrObjExLst.Add(objViewRegionENEx);
            }
            return arrObjExLst;
        }

        public static List<clsViewRegionEN> GetObjLstByViewId(string strViewId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} where {2}='{3}')",
                conViewRegion.RegionId, clsViewRegionRelaEN._CurrTabName,
                conViewRegionRela.ViewId, strViewId);
            List<clsViewRegionEN> arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
            return arrObjLst;
        }
        /// <summary>
        /// 根据条件获取扩展对象列表  
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewRegionENEx> GetObjExLstByViewIdCache(string strViewId, string strPrjId)
        {
            var arrViewRegionRelaObjLst = clsViewRegionRelaBL.GetObjLstCache(strPrjId);
            arrViewRegionRelaObjLst = arrViewRegionRelaObjLst.Where(x => x.ViewId == strViewId).ToList();

            List<string> arrRegionId = arrViewRegionRelaObjLst.Select(x => x.RegionId).ToList();

            List<clsViewRegionEN> arrObjLstCache = clsViewRegionBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsViewRegionEN> arrObjLst = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId)).ToList();
            List<clsViewRegionENEx> arrObjExLst = new List<clsViewRegionENEx>();
            foreach (clsViewRegionEN objInFor in arrObjLst)
            {
                clsViewRegionENEx objViewRegionENEx = new clsViewRegionENEx();
                clsViewRegionBL.CopyTo(objInFor, objViewRegionENEx);
                arrObjExLst.Add(objViewRegionENEx);
            }
            return arrObjExLst;
        }

        public static List<clsViewRegionEN> GetObjLstByTabIdAndRegionTypeCache(string strTabId, string strRegionTypeId, string strPrjId)
        {
            var arrViewRegionRelaObjLst = clsViewRegionRelaBL.GetObjLstCache(strPrjId);
            //arrViewRegionRelaObjLst = arrViewRegionRelaObjLst.Where(x => x.ViewId == strViewId).ToList();

            List<string> arrRegionId = arrViewRegionRelaObjLst.Select(x => x.RegionId).ToList();

            List<clsViewRegionEN> arrObjLstCache = clsViewRegionBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsViewRegionEN> arrObjLst = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) && x.TabId == strTabId && x.RegionTypeId == strRegionTypeId).ToList();
           
            return arrObjLst;
        }

        public static List<clsViewRegionEN> GetObjLstByTabIdAndRegionType4CmPrjIdCache(string strTabId, string strRegionTypeId, string strCmPrjId)
        {
            string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var arrViewRegionRelaObjLst = clsViewRegionRelaBL.GetObjLstCache(strPrjId);
            var arrViewId = clsViewInfoCmPrjIdRelaBLEx.GetViewIdLstByCmPrjIdCache(strCmPrjId);
            arrViewRegionRelaObjLst = arrViewRegionRelaObjLst.Where(x => arrViewId.Contains(x.ViewId)).ToList();

            List<string> arrRegionId = arrViewRegionRelaObjLst.Select(x => x.RegionId).ToList();

            List<clsViewRegionEN> arrObjLstCache = clsViewRegionBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsViewRegionEN> arrObjLst = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) && x.TabId == strTabId && x.RegionTypeId == strRegionTypeId).ToList();

            return arrObjLst;
        }


        /// <summary>
        /// 根据条件获取扩展对象列表  
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewRegionEN> GetObjLstByViewIdCache(string strViewId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", conViewRegion.ViewId, strViewId);
            List<string> arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            List<clsViewRegionEN> arrObjLstCache = clsViewRegionBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsViewRegionEN> arrObjLst = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId)).ToList();
            return arrObjLst;
        }

        public static bool SetCmPrjIdBak20230301(string strRegionId, string strCmPrjId, string strUserId)
        {
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(strRegionId);
          bool bolResult =  objViewRegion
                .SetPrjId(strCmPrjId)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                            .SetUpdUser(strUserId)
                            .Update();
            if (bolResult == false) return false;
            return true;
            //switch (objViewRegion.RegionTypeId)
            //{
            //    case enumRegionType.QueryRegion_0001:
            //        return clsQryRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);               
            //    case enumRegionType.EditRegion_0003:
            //        return clsEditRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);
            //    case enumRegionType.FeatureRegion_0008:
            //        return clsFeatureRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);                  
            //    case enumRegionType.ListRegion_0002:
            //        return clsDGRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);                   
            //    case enumRegionType.ExcelExportRegion_0007:
            //        return clsExcelExportRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);                 
            //    case enumRegionType.DetailRegion_0006:         
            //        return clsDetailRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);

            //    default:
            //        return true;
            //}
        }

        public static bool SetCmPrjId(string strRegionId, string strCmPrjId, string strUserId)
        {
            var objViewRegionCmPrjIdRela = new clsViewRegionCmPrjIdRelaEN();//  clsViewRegionCmPrjIdRelaBL.GetObjByRegionId(strRegionId);
            objViewRegionCmPrjIdRela
                  .SetCmPrjId(strCmPrjId)
                  .SetRegionId(strRegionId)
                  .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                              .SetUpdUser(strUserId);

            string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
              conViewRegionCmPrjIdRela.RegionId, strRegionId,
              conViewRegionCmPrjIdRela.CmPrjId, strCmPrjId);
            if (clsViewRegionCmPrjIdRelaBL.IsExistRecord(strCondition) == false)
            {
                return objViewRegionCmPrjIdRela.AddNewRecord();
            }
            else
            {
                return objViewRegionCmPrjIdRela.UpdateWithCondition(strCondition);
            }
                     
            //if (bolResult == false) return false;
            //switch (objViewRegionCmPrjIdRela.RegionTypeId)
            //{
            //    case enumRegionType.QueryRegion_0001:
            //        return clsQryRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);
            //    case enumRegionType.EditRegion_0003:
            //        return clsEditRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);
            //    case enumRegionType.FeatureRegion_0008:
            //        return clsFeatureRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);
            //    case enumRegionType.ListRegion_0002:
            //        return clsDGRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);
            //    case enumRegionType.ExcelExportRegion_0007:
            //        return clsExcelExportRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);
            //    case enumRegionType.DetailRegion_0006:
            //        return clsDetailRegionFldsBLEx.SetCmPrjId(strRegionId, strCmPrjId, strUserId);

            //    default:
            //        return true;
            //}
        }


        /// <summary>
        /// 根据条件获取扩展对象列表  
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewRegionEN> GetObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            List<clsViewRegionEN> arrObjLstCache = clsViewRegionBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsViewRegionEN> arrObjLst = arrObjLstCache.Where(x => x.TabId == strTabId).ToList();
            return arrObjLst;
        }

        public static List<clsViewRegionEN> GetObjLstByPrjIdCache(string strPrjId)
        {
            List<clsViewRegionEN> arrObjLstCache = clsViewRegionBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsViewRegionEN> arrObjLst = arrObjLstCache.Where(x => x.PrjId == strPrjId).ToList();
            return arrObjLst;
        }
        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// </summary>
        /// <param name = "lngRegionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsViewRegionENEx GetObjExByRegionId(string lngRegionId)
        {
            clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId(lngRegionId);
            clsViewRegionENEx objViewRegionENEx = new clsViewRegionENEx();
            clsViewRegionBL.CopyTo(objViewRegionEN, objViewRegionENEx);
            return objViewRegionENEx;
        }
        /// <summary>
        /// 同步满足条件的学生信息到Web
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToServerByCondition(string strCondition, string strUserId)
        //{
        //    //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //    List<clsViewRegionEN> arrViewRegionENObjLst = clsViewRegionBL.GetObjLst(strCondition);
        //    foreach (clsViewRegionEN objViewRegionEN4Web in arrViewRegionENObjLst)
        //    {

        //        objViewRegionEN4Web.IsSynchToServer = true;
        //        objViewRegionEN4Web.SynchToServerDate = strCurrDate14;
        //        objViewRegionEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsViewRegionEN objViewRegionEN4Web2 = new clsViewRegionEN();
        //            clsViewRegionBL.CopyTo(objViewRegionEN4Web, objViewRegionEN4Web2);
        //            objViewRegionEN4Web2.SynSource = "Client";

        //            strCondition = objViewRegionEN4Web.GetUniquenessConditionString();

        //            clsViewRegionEN objViewRegion_Target = clsViewRegionBL.GetFirstObj_S(strCondition);

        //            if (objViewRegion_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objViewRegion_Target.UpdDate.CompareTo(objViewRegionEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objViewRegionEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                //if (clsFieldTabBL.IsExist(objViewRegionEN4Web2.ReqId) == false)
        //                //{
        //                //    clsFieldTabBLEx.SynchToServerByReqId(objViewRegionEN4Web2.ReqId, strUserId);
        //                //}
        //                clsViewRegionBL.AddNewRecordBySql2(objViewRegionEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsViewRegionBL.UpdateBySql2(objViewRegionEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，CM工程表字段：{0}({1})时出错。({3}).[上级抛错:{2}]", objViewRegionEN4Web.RegionId,
        //                        objViewRegionEN4Web.RegionName, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        ///// <summary>
        ///// 同步满足条件的学生信息到Web
        ///// </summary>
        ///// <param name="strCondition"></param>
        ///// <param name="strUserId"></param>
        ///// <returns></returns>
        //public static int SynchToClientByCondition(string strCondition, string strUserId)
        //{
        //    //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsViewRegionEN> arrViewRegionENObjLst = clsViewRegionBL.GetObjLst(strCondition);

        //    foreach (clsViewRegionEN objViewRegionEN4Main in arrViewRegionENObjLst)
        //    {

        //        objViewRegionEN4Main.IsSynchToClient = true;
        //        objViewRegionEN4Main.SynchToClientDate = strCurrDate14;
        //        objViewRegionEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //        try
        //        {
        //            clsViewRegionEN objViewRegionEN4Main2 = new clsViewRegionEN();
        //            clsViewRegionBL.CopyTo(objViewRegionEN4Main, objViewRegionEN4Main2);
        //            objViewRegionEN4Main2.SynSource = "Server";

        //            strCondition = objViewRegionEN4Main.GetUniquenessConditionString();
        //            clsViewRegionEN objViewRegion_Target = clsViewRegionBL.GetFirstObj_S(strCondition);

        //            if (objViewRegion_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objViewRegion_Target.UpdDate.CompareTo(objViewRegionEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objViewRegionEN4Main2.SetRegionId(objViewRegion_Target.RegionId);
        //                    objViewRegionEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                //if (clsFieldTabBL.IsExist(objViewRegionEN4Main2.ReqId) == false)
        //                //{
        //                //    clsFieldTabBLEx.SynchToClientByReqId(objViewRegionEN4Main2.ReqId, strUserId);
        //                //}
        //                clsViewRegionBL.AddNewRecordBySql2(objViewRegionEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsViewRegionBL.UpdateBySql2(objViewRegionEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表字段：{0}({1})时出错。({3}).[上级抛错:{2}]", objViewRegionEN4Main.RegionName,
        //                        objViewRegionEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">工程Id</param>
        public static void BindDdl_RegionIdExCache(System.Web.UI.WebControls.DropDownList objDDL, string strViewId, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面区域]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conViewRegion.RegionId);
            List<string> arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            IEnumerable<clsViewRegionEN> arrObjLst = clsViewRegionBL.GetObjLstCache(strPrjId);
            arrObjLst = arrObjLst.Where(x => arrRegionId.Contains(x.RegionId)).OrderBy(x => x.RegionId);
            objDDL.DataValueField = conViewRegion.RegionId;
            objDDL.DataTextField = conViewRegion.RegionName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static bool BindLst_RegionIdByViewIdEx(System.Web.UI.WebControls.ListBox lstViewRegion, string strViewId, int intApplicationTypeId, string strPrjId)
        {
            List<string> arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewId(strViewId);
            List<string> arrRelaTabId = clsViewInfoBLEx.getRelaTabId4InOut(strViewId, strPrjId);
            string strCondition = string.Format("{0} in ({1})  ",
                conViewRegion.TabId, clsArray.GetSqlInStrByArray(arrRelaTabId, true));
            if (arrRegionId.Count > 0)
            {
                strCondition += string.Format(" and {0} not in ({1})",
                    conViewRegion.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            }
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBL.GetObjLst(strCondition);
            lstViewRegion.DataValueField = conViewRegion.RegionId;
            lstViewRegion.DataTextField = conViewRegion.ClsName;
            lstViewRegion.DataSource = arrViewRegion;
            lstViewRegion.DataBind();
            if (arrViewRegion.Count == 0) return false;
            return true;
        }

        public static int SetDataTabId()
        {
            string strCondition = string.Format("{0}='' ", conViewRegion.TabId);
            var arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
            int intCount = 0;
            foreach (var objInFor in arrObjLst)
            {
                switch (objInFor.RegionTypeId)
                {
                    case enumRegionType.DetailRegion_0006:
                    case enumRegionType.ExcelExportRegion_0007:
                    case enumRegionType.FeatureRegion_0008:
                    case enumRegionType.ListRegion_0002:
                    case enumRegionType.QueryRegion_0001:
                    case enumRegionType.TreeViewRegion_0005:
                        objInFor.InOutTypeId = enumInOutType.OUT_03;
                        //objInFor.TabId = objInFor.OutRelaTabId;
                        break;
                    case enumRegionType.EditRegion_0003:
                        objInFor.InOutTypeId = enumInOutType.IN_02;
                        //objInFor.TabId = objInFor.InRelaTabId;
                        break;
                }
                objInFor.Update();
                intCount++;
            }
            return intCount;
        }

        public static int SetDefaRegionName()
        {
            string strCondition = string.Format("1=1", conViewRegion.TabId);
            var arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
            int intCount = 0;
            foreach (var objInFor in arrObjLst)
            {
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId());
                if (objPrjTab == null) continue;

                var objRegionType = clsRegionTypeBL.GetObjByRegionTypeIdCache(objInFor.RegionTypeId);
                string strTypeName = objRegionType.RegionTypeSimName;
                string strRegionName = string.Format("{0}-{1}", objPrjTab.TabName, strTypeName);
                int intNo = 1;
                string strRegionName_new = string.Format("{0}{1}", strRegionName, intNo);
                while (true)
                {
                    strRegionName_new = string.Format("{0}{1}", strRegionName, intNo);
                    strCondition = string.Format("{0}='{1}' and {2} <>'{3}'",
                        conViewRegion.RegionName, strRegionName_new,
                        conViewRegion.RegionId, objInFor.RegionId);
                    bool bolIsExist = clsViewRegionBL.IsExistRecord(strCondition);
                    if (bolIsExist == false) break;
                    intNo++;
                }
                objInFor.RegionName = strRegionName_new;
                objInFor.Update();
                intCount++;
            }
            return intCount;
        }

        //public static int SetFldCount()
        //{
        //    string strCondition = string.Format("{0} = 0 or {1} = 0[exclude]or[/exclude]", conViewRegion.FldCount, conViewRegion.FldCountInUse);
        //    var arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
        //    int intCount = 0;
        //    foreach (var objInFor in arrObjLst)
        //    {
        //        int intFldCount = 0;
        //        switch (objInFor.RegionTypeId)
        //        {
        //            case enumRegionType.DetailRegion_0006:
        //                intFldCount = clsvDetailRegionFldCountBLEx.GetFldCountCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.ListRegion_0002:
        //                intFldCount = clsvDGRegionFldCountBLEx.GetFldCountCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.EditRegion_0003:
        //                intFldCount = clsvEditRegionFldCountBLEx.GetFldCountCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.ExcelExportRegion_0007:
        //                intFldCount = clsvExcelExportRegionFldCountBLEx.GetFldCountCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.FeatureRegion_0008:
        //                intFldCount = clsvFeatureRegionFldCountBLEx.GetFldCountCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.QueryRegion_0001:
        //                intFldCount = clsvQryRegionFldCountBLEx.GetFldCountCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //        }
        //        objInFor.FldCount = intFldCount;

        //        objInFor.Update();
        //        intCount++;
        //    }
        //    return intCount;
        //}

        //public static int SetFldCount(string strRegionId)
        //{

        //    int intCount = 0;
        //    var objInFor = clsViewRegionBL.GetObjByRegionId(strRegionId);
        //    {
        //        int intFldCount = 0;
        //        switch (objInFor.RegionTypeId)
        //        {
        //            case enumRegionType.DetailRegion_0006:
        //                intFldCount = clsvDetailRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ListRegion_0002:
        //                intFldCount = clsvDGRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.EditRegion_0003:
        //                intFldCount = clsvEditRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ExcelExportRegion_0007:
        //                intFldCount = clsvExcelExportRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.FeatureRegion_0008:
        //                intFldCount = clsvFeatureRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.QueryRegion_0001:
        //                intFldCount = clsvQryRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //        }
        //        objInFor.FldCount = intFldCount;

        //        objInFor.Update();
        //        intCount++;
        //    }
        //    return intCount;
        //}

        //public static int SetFldCount(clsViewRegionEN objInFor)
        //{

        //    int intCount = 0;

        //    {
        //        int intFldCount = 0;
        //        switch (objInFor.RegionTypeId)
        //        {
        //            case enumRegionType.DetailRegion_0006:
        //                intFldCount = clsvDetailRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ListRegion_0002:
        //                intFldCount = clsvDGRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.EditRegion_0003:
        //                intFldCount = clsvEditRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ExcelExportRegion_0007:
        //                intFldCount = clsvExcelExportRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.FeatureRegion_0008:
        //                intFldCount = clsvFeatureRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //            case enumRegionType.QueryRegion_0001:
        //                intFldCount = clsvQryRegionFldCountBLEx.GetFldCount(objInFor.RegionId);
        //                break;
        //        }
        //        objInFor.FldCount = intFldCount;

        //        objInFor.Update();
        //        intCount++;
        //    }
        //    return intCount;
        //}

        //public static int SetFldCountInUse()
        //{
        //    string strCondition = string.Format("{0} = 0 or {1} = 0[exclude]or[/exclude]", conViewRegion.FldCount, conViewRegion.FldCountInUse);
        //    var arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
        //    int intCount = 0;
        //    foreach (var objInFor in arrObjLst)
        //    {
        //        int intFldCount = 0;
        //        switch (objInFor.RegionTypeId)
        //        {
        //            case enumRegionType.DetailRegion_0006:
        //                intFldCount = clsvDetailRegionFldCountInUseBLEx.GetFldCountInUseCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.ListRegion_0002:
        //                intFldCount = clsvDGRegionFldCountInUseBLEx.GetFldCountInUseCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.EditRegion_0003:
        //                intFldCount = clsvEditRegionFldCountInUseBLEx.GetFldCountInUseCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.ExcelExportRegion_0007:
        //                intFldCount = clsvExcelExportRegionFldCountInUseBLEx.GetFldCountInUseCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.FeatureRegion_0008:
        //                intFldCount = clsvFeatureRegionFldCountInUseBLEx.GetFldCountInUseCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //            case enumRegionType.QueryRegion_0001:
        //                intFldCount = clsvQryRegionFldCountInUseBLEx.GetFldCountInUseCache(objInFor.RegionId, objInFor.PrjId);
        //                break;
        //        }
        //        objInFor.FldCountInUse = intFldCount;

        //        objInFor.Update();
        //        intCount++;
        //    }
        //    return intCount;
        //}

        public static int GetReferCount(string strPrjId, int intApplicationTypeId, string regionId)
        {
            List<clsvViewRegionRelaEN> arrViewRegionRela = clsvViewRegionRelaBL.GetObjLstCache(strPrjId).ToList();

            var arrViewRegionRela_Sel = arrViewRegionRela.Where(x => x.ApplicationTypeId == intApplicationTypeId && x.RegionId == regionId).ToList();
            return arrViewRegionRela_Sel.Count;
        }

        //public static int SetFldCountInUse(string strRegionId)
        //{

        //    int intCount = 0;
        //    var objInFor = clsViewRegionBL.GetObjByRegionId(strRegionId);
        //    {
        //        int intFldCount = 0;
        //        switch (objInFor.RegionTypeId)
        //        {
        //            case enumRegionType.DetailRegion_0006:
        //                intFldCount = clsvDetailRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ListRegion_0002:
        //                intFldCount = clsvDGRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.EditRegion_0003:
        //                intFldCount = clsvEditRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ExcelExportRegion_0007:
        //                intFldCount = clsvExcelExportRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.FeatureRegion_0008:
        //                intFldCount = clsvFeatureRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.QueryRegion_0001:
        //                intFldCount = clsvQryRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //        }
        //        objInFor.FldCountInUse = intFldCount;

        //        objInFor.Update();
        //        intCount++;
        //    }
        //    return intCount;
        //}

        //public static int SetFldCountInUse(clsViewRegionEN objInFor)
        //{
        //    int intCount = 0;
        //    {
        //        int intFldCount = 0;
        //        switch (objInFor.RegionTypeId)
        //        {
        //            case enumRegionType.DetailRegion_0006:
        //                intFldCount = clsvDetailRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ListRegion_0002:
        //                intFldCount = clsvDGRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.EditRegion_0003:
        //                intFldCount = clsvEditRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.ExcelExportRegion_0007:
        //                intFldCount = clsvExcelExportRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.FeatureRegion_0008:
        //                intFldCount = clsvFeatureRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //            case enumRegionType.QueryRegion_0001:
        //                intFldCount = clsvQryRegionFldCountInUseBLEx.GetFldCountInUse(objInFor.RegionId);
        //                break;
        //        }
        //        objInFor.FldCountInUse = intFldCount;

        //        objInFor.Update();
        //        intCount++;
        //    }
        //    return intCount;
        //}

        public static string GetDefaRegionName(string strRegionId, string strTabId, string strPrjId, string strRegionTypeId)
        {

            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTab == null)
            {
                string strMsg = string.Format("TabId:{0}对应的表不存在！", strTabId);
                throw new Exception(strMsg);
            }
            var objRegionType = clsRegionTypeBL.GetObjByRegionTypeIdCache(strRegionTypeId);
            string strTypeName = objRegionType.RegionTypeSimName;
            string strRegionName = string.Format("{0}-{1}", objPrjTab.TabName, strTypeName);
            int intNo = 1;
            string strRegionName_new = string.Format("{0}{1}", strRegionName, intNo);
            while (true)
            {
                strRegionName_new = string.Format("{0}{1}", strRegionName, intNo);
                string strCondition = string.Format("{0}='{1}' and {2} <>'{3}'",
                        conViewRegion.RegionName, strRegionName_new,
                        conViewRegion.RegionId, strRegionId);
                bool bolIsExist = clsViewRegionBL.IsExistRecord(strCondition);
                if (bolIsExist == false) break;
                intNo++;
            }
            return strRegionName_new;
        }

        public static string GetDefaRegionName4Add(string strTabId, string strPrjId, string strRegionTypeId)
        {

            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTab == null)
            {
                string strMsg = string.Format("TabId:{0}对应的表不存在！", strTabId);
                throw new Exception(strMsg);
            }
            var objRegionType = clsRegionTypeBL.GetObjByRegionTypeIdCache(strRegionTypeId);
            string strTypeName = objRegionType.RegionTypeSimName;
            string strRegionName = string.Format("{0}-{1}", objPrjTab.TabName, strTypeName);
            int intNo = 1;
            string strRegionName_new = string.Format("{0}{1}", strRegionName, intNo);
            while (true)
            {
                strRegionName_new = string.Format("{0}{1}", strRegionName, intNo);
                string strCondition = string.Format("{0}='{1}'",
                        conViewRegion.RegionName, strRegionName_new);
                bool bolIsExist = clsViewRegionBL.IsExistRecord(strCondition);
                if (bolIsExist == false) break;
                intNo++;
            }
            return strRegionName_new;
        }

        public static bool Rename(string strRegionId, string strViewId, string strNewRegionName, string strOpUserId)
        {
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(strRegionId);
            objViewRegion.RegionName = strNewRegionName;
            objViewRegion.ClsName = strNewRegionName;
            //objViewRegion.ApplicationTypeId = int.Parse(intApplicationTypeId);
            objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objViewRegion.UpdUser = strOpUserId;
            objViewRegion.UpdateRecordEx();
            //clsViewRegionBLEx.SetFldCount(objViewRegion);
            //clsViewRegionBLEx.SetFldCountInUse(objViewRegion);
            if (string.IsNullOrEmpty(strViewId) == false)
            {
                clsViewInfoBLEx.SetViewUpdDate(strViewId);
            }
            return true;
        }

        public static string GetRelaViewNameRegionTypeByRegionId(string strRegionId, string strCmPrjId)
        {
            var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsViewRegionEN objViewRegion = null;
            try
            {
                objViewRegion = GetObjByRegionIdCache(strRegionId, strPrjId);
            }
            catch(Exception objException)
            {
                Console.WriteLine(objException.ToString());
                return "获取相关区域类型出错！";
            }
            var arrViewId = clsViewRegionRelaBLEx.GetViewIdLstByRegionIdCache(strRegionId, strPrjId);
            var arrViewInfo = clsViewInfoBLEx.GetObjLstByViewIdLstCache(arrViewId, strPrjId);
            string strMsg = string.Format("区域类型:[{0}]", clsRegionTypeBL.GetNameByRegionTypeIdCache( objViewRegion.RegionTypeId));
            int intCount = 0;
            foreach(var objInFor in arrViewInfo)
            {
                if (intCount == 0)
                {
                    strMsg += string.Format(", In 界面:{0}", objInFor.ViewName);                    
                }
                else
                {
                    strMsg += string.Format("、{0}", objInFor.ViewName);
                }
                intCount++;
            }         
            return strMsg;
        }
    }
}
