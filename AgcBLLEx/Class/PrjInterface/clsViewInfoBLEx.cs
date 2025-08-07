using AGC.BusinessLogic;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
//using AGC.PureClassEx;

namespace AGC.BusinessLogicEx
{
    public class ASPDropDownListComparer : IEqualityComparer<ASPDropDownListEx>
    {
        public bool Equals(ASPDropDownListEx t1, ASPDropDownListEx t2)
        {
            return (t1.CtrlId == t2.CtrlId);
        }
        public int GetHashCode(ASPDropDownListEx t)
        {
            return t.ToString().GetHashCode();
        }
    }

    public static class clsViewInfoBLEx_Static
    {
        public static string FunctionTemplateId(this clsViewInfoENEx objViewInfoEx, string strCmPrjId)
        {
            //var strCmPrjId = objViewInfoEx.PrjId;
            if (string.IsNullOrEmpty(strCmPrjId) == true)
            {
                string strMsg = string.Format("界面:[{0}({1})]中没有设置Cm工程Id，请检查!(in {2})", objViewInfoEx.ViewName, objViewInfoEx.ViewId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            if (string.IsNullOrEmpty(objCMProject.FunctionTemplateId) == true)
            {
                string strMsg = string.Format("Cm工程:[{0}({1})]中没有设置函数模板，请检查!(in {2})", objCMProject.CmPrjName, objCMProject.CmPrjId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return objCMProject.FunctionTemplateId;
        }

    }
    public partial class clsViewInfoBLEx : clsViewInfoBL
    {
        public static string strPrjIdCache_Init = "";
        public clsViewInfoBLEx()
        {
        }
        public clsViewInfoBLEx(string strViewId)
        {

        }
        /// <summary>
        /// 导入界面区域、区域字段
        /// </summary>
        /// <param name = "strViewId"></param>
        /// <param name = "strRegionTypeId"></param>
        /// <param name = "strRegionName"></param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static bool ImportRegionAndFlds1(string strViewId, string strRegionTypeId, string strOpUserId, string strRegionName = "")
        {
            StringBuilder sbWhereCond;
            clsViewInfoEN objViewInfoENEx = clsViewInfoBL.GetObjByViewId(strViewId);
            if (objViewInfoENEx == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("界面Id:{0}在表中不存在,请检查!（in {1}）",
                    strViewId, clsStackTrace.GetCurrClassFunction());

                throw new clsDbObjException(sbMessage.ToString());
            }

            if (objViewInfoENEx.OutRelaTabId == "" || objViewInfoENEx.InRelaTabId == "")
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在界面:{1}({0})中输入/出(IN/OUT)相关表不存在,请检查!",
                    objViewInfoENEx.ViewName,
                    objViewInfoENEx.ViewCnName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            clsRegionTypeEN objRegionType = clsRegionTypeBL.GetObjByRegionTypeIdCache(strRegionTypeId);
            clsViewRegionEN objViewRegionEN = new clsViewRegionEN();    //初始化新对象



            objViewRegionEN.RegionTypeId = strRegionTypeId;
            //objViewRegionEN.RegionFunction = objViewRegionEN.RegionName;
            switch (objViewRegionEN.RegionTypeId)
            {
                case enumRegionType.DetailRegion_0006:
                case enumRegionType.ExcelExportRegion_0007:
                case enumRegionType.ListRegion_0002:
                case enumRegionType.QueryRegion_0001:
                case enumRegionType.TreeViewRegion_0005:
                    objViewRegionEN.InOutTypeId = enumInOutType.OUT_03;
                    objViewRegionEN.TabId = objViewInfoENEx.OutRelaTabId;
                    break;
                case enumRegionType.EditRegion_0003:
                case enumRegionType.FeatureRegion_0008:
                    objViewRegionEN.InOutTypeId = enumInOutType.IN_02;
                    objViewRegionEN.TabId = objViewInfoENEx.InRelaTabId;
                    break;
            }
            List<string> arrRegionName = new List<string>() { "查询区域", "编辑区域", "详细区域", "列表区域", "功能区域", "Excel导出区域" };
            if (string.IsNullOrEmpty(strRegionName) == true || arrRegionName.Contains(strRegionName) == true)
            {
                string strRegionName1 = clsViewRegionBLEx.GetDefaRegionName4Add(objViewRegionEN.TabId, objViewInfoENEx.PrjId, objViewRegionEN.RegionTypeId);
                objViewRegionEN.RegionName = strRegionName1;
            }
            else
            {
                objViewRegionEN.RegionName = strRegionName;
            }
            //objViewRegionEN.OutSqlDsTypeId = objViewInfoENEx.OutSqlDsTypeId;
            //objViewRegionEN.OutRelaTabId = objViewInfoENEx.OutRelaTabId;
            //objViewRegionEN.InSqlDsTypeId = objViewInfoENEx.InSqlDsTypeId;
            //objViewRegionEN.InRelaTabId = objViewInfoENEx.InRelaTabId;
            objViewRegionEN.Height = 100;
            objViewRegionEN.Width = objRegionType.DefaWidth;
            //objViewRegionEN.CmPrjId = objViewInfoENEx.PrjId;
            objViewRegionEN.PrjId = objViewInfoENEx.PrjId;
            //objViewRegionEN.ApplicationTypeId = objViewInfoENEx.ApplicationTypeId;
            objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objViewRegionEN.UpdUser = strOpUserId;
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewRegionEN.TabId, objViewRegionEN.PrjId());
            var strClassName = "";
            switch (strRegionTypeId)
            {
                case enumRegionType.QueryRegion_0001:
                    objViewRegionEN.ColNum = 4;
                    objViewRegionEN.PageDispModeId = enumPageDispMode.Left_04;
                    objViewRegionEN.ContainerTypeId = enumGCContainerType.TableContainer_0001;

                    strClassName = string.Format("{0}_Query", objPrjTab.TabName);

                    break;
                case enumRegionType.EditRegion_0003:

                    objViewRegionEN.ColNum = 2;
                    objViewRegionEN.PageDispModeId = enumPageDispMode.PopupBox_01;
                    objViewRegionEN.ContainerTypeId = enumGCContainerType.TableContainer_0001;
                    strClassName = string.Format("{0}_Edit", objPrjTab.TabName);

                    break;
                case enumRegionType.DetailRegion_0006:
                    objViewRegionEN.ColNum = 2;
                    objViewRegionEN.PageDispModeId = enumPageDispMode.PopupBox_01;
                    objViewRegionEN.ContainerTypeId = enumGCContainerType.TableContainer_0001;
                    strClassName = string.Format("{0}_Detail", objPrjTab.TabName);

                    break;
                case enumRegionType.FeatureRegion_0008:
                    strClassName = string.Format("{0}_Feature", objPrjTab.TabName);

                    break;
                case enumRegionType.ListRegion_0002:
                    strClassName = string.Format("{0}_List", objPrjTab.TabName);

                    break;
                case enumRegionType.ExcelExportRegion_0007:
                    strClassName = string.Format("{0}_ExcelExport", objPrjTab.TabName);

                    break;

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

            objViewRegionEN.Memo = objViewRegionEN.RegionName;
            //检查是否重复
            //if (clsViewRegionRelaBLEx.CheckDuplicate(objViewRegionEN) == true)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("在界面:{1}({0})中已存在相同的区域名称:{2},请检查,或者改变名称。",
            //        objViewInfoENEx.ViewName,
            //        objViewInfoENEx.ViewCnName,
            //        strRegionName);
            //    throw new clsDbObjException(sbMessage.ToString());
            //}

            clsViewRegionBL.AddNewRecordBySql2(objViewRegionEN);
            clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();    //初始化新对象

            objViewRegionRelaEN.RegionId = objViewRegionEN.RegionId;
            objViewRegionRelaEN.ViewId = strViewId;
            objViewRegionRelaEN.PrjId = objViewInfoENEx.PrjId;
            objViewRegionRelaEN.InUse = true;
            objViewRegionRelaEN.IsDisp = true;
            objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objViewRegionRelaEN.UpdUser = strOpUserId;
            objViewRegionRelaEN.EditRecordEx();

            sbWhereCond = new StringBuilder();
            sbWhereCond.AppendFormat("ViewId = '{0}' and RegionName = '{1}'",
                strViewId,
                objViewRegionEN.RegionName);


            //添加相关字段
            switch (strRegionTypeId)
            {
                case clsRegionTypeENEx.QUERYREGION:	//查询区域

                    clsQryRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
                    break;
                case clsRegionTypeENEx.DGREGION:	//DG区域
                    clsDGRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewRegionEN.PrjId, objViewInfoENEx.UserId);
                    break;
                case clsRegionTypeENEx.FEATUREREGION:	//功能区域
                    clsFeatureRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
                    break;
                //case clsRegionTypeENEx.LISTVIEWREGION:	//DG区域
                //    clsListViewRegionBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
                //    break;
                case clsRegionTypeENEx.EDITREGION:	//编辑区域
                    clsEditRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
                    break;
                case clsRegionTypeENEx.EXCELEXPORT_REGION:	//编辑区域
                    clsExcelExportRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewRegionEN.PrjId, objViewInfoENEx.UserId);
                    break;
                case clsRegionTypeENEx.DETAILREGION:	//编辑区域
                    clsDetailRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewRegionEN.PrjId, objViewInfoENEx.UserId);
                    break;

            }
            //clsViewRegionBLEx.SetFldCount(objViewRegionEN);
            //clsViewRegionBLEx.SetFldCountInUse(objViewRegionEN);

            return true;
        }

        public clsEditRegionFldsENEx getEditRegionKeyFld(clsViewInfoENEx objViewInfoENEx)
        {
            foreach (clsEditRegionFldsENEx objEditRegionFldsENEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsENEx.ObjFieldTabENEx.FldName
                     == objViewInfoENEx.objMainTabKeyField.ObjFieldTabENEx.FldName)
                {
                    return objEditRegionFldsENEx;
                }
            }
            return null;
        }
        /// <summary>
        /// 关键字字段名的列表串
        /// </summary>
        public string KeyFldNameLstStrWithAddStr(string strAdditionalStr, clsViewInfoENEx objViewInfoENEx
)
        {

            List<string> arrKeyFldNameLst = new List<string>();
            foreach (clsPrjTabFldENEx objField in objViewInfoENEx.arrKeyPrjTabFldSet)
            {
                arrKeyFldNameLst.Add(strAdditionalStr + objField.ObjFieldTabENEx.FldName);
            }
            string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
            return strKeyFldNameLst;

        }
        public static clsViewInfoENEx GetObjExByViewId(string strViewId, bool bolIsFstLcase, string strPrjId)
        {
            clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewId(strViewId);
            clsViewInfoENEx objViewInfoENEx = null;

            clsViewInfoBL.CopyTo(objViewInfoEN, objViewInfoENEx);
            clsPrjTabFldBLEx.strPrjIdCache = objViewInfoENEx.PrjId;

            objViewInfoENEx.arrKeyPrjTabFldSet = new List<clsPrjTabFldENEx>();

            objViewInfoENEx.FirstSortField = "";

            objViewInfoENEx.objViewStyleEN = clsViewStyleBLEx.GetObjByViewIdCacheEx(objViewInfoENEx.ViewId);
            if (objViewInfoENEx.objViewStyleEN == null)
            {
                string strMsg = string.Format("界面:{0}的界面类型为空,请检查!", objViewInfoENEx.ViewName);
                throw new Exception(strMsg);
            }
            objViewInfoENEx.objMainPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);

            objViewInfoENEx.arrFeatureId = clsPrjFeatureBLEx.GetFeatureIdLstByViewIdCache(objViewInfoENEx.ViewId, strPrjId);
            objViewInfoENEx.arrViewReferFiles = clsViewReferFilesBLEx.GetObjLstByViewIdCache(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
            objViewInfoENEx.arrViewRegion = clsViewRegionBLEx.GetObjExLstByViewIdCache(objViewInfoENEx.ViewId, strPrjId);

            clsDGRegionFldsBLEx.initDGRegionFldSet(objViewInfoENEx, bolIsFstLcase);
            clsEditRegionFldsBLEx.initEditRegionFldSet(objViewInfoENEx, bolIsFstLcase);
            clsDetailRegionFldsBLEx.initDetailRegionFldSet(objViewInfoENEx);

            clsExcelExportRegionFldsBLEx.initExcelExportRegionFldSet(objViewInfoENEx);
            clsQryRegionFldsBLEx.initQryRegionFldSet(objViewInfoENEx, bolIsFstLcase);
            clsFeatureRegionFldsBLEx.initFeatureRegionFldSet(objViewInfoENEx);
            clsViewFeatureFldsBLEx.initViewFeatureFlds(objViewInfoENEx, bolIsFstLcase);

            initViewRelaTabFldSet(objViewInfoENEx);

            InitViewGroupEx(objViewInfoENEx);

            objViewInfoENEx.objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId);
            objViewInfoENEx.ObjFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            objViewInfoENEx.NameSpace = objViewInfoENEx.objProjectsEN.PrjDomain;

            string strFunctionTemplateId = clsPrjFuncTemplateRelaBLEx.getFunctionTemplateIdByPrjId(objViewInfoENEx.PrjId);
            objViewInfoENEx.FunctionTemplateId = strFunctionTemplateId;
            return objViewInfoENEx;
        }


        public static bool GetViewInfoEx(ref clsViewInfoENEx objViewInfoENEx, bool bolIsFstLcase, string strPrjId)
        {

            clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewIdCache(objViewInfoENEx.ViewId, strPrjId);

            clsViewInfoBL.CopyTo(objViewInfoEN, objViewInfoENEx);
            clsPrjTabFldBLEx.strPrjIdCache = objViewInfoENEx.PrjId;

            objViewInfoENEx.arrKeyPrjTabFldSet = new List<clsPrjTabFldENEx>();

            objViewInfoENEx.FirstSortField = "";

            objViewInfoENEx.objViewStyleEN = clsViewStyleBLEx.GetObjByViewIdCacheEx(objViewInfoENEx.ViewId);
            if (objViewInfoENEx.objViewStyleEN == null)
            {
                objViewInfoENEx.objViewStyleEN = new clsViewStyleEN();
                objViewInfoENEx.objViewStyleEN.TitleStyleId = "00050003";
                objViewInfoENEx.objViewStyleEN.ViewId = objViewInfoENEx.ViewId;
                objViewInfoENEx.objViewStyleEN.DgStyleId = "0003";
                //string strMsg = string.Format("界面:{0}的界面类型为空,请检查!", objViewInfoENEx.ViewName);
                //throw new Exception(strMsg);
            }
            objViewInfoENEx.objMainPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);

            objViewInfoENEx.arrFeatureId = clsPrjFeatureBLEx.GetFeatureIdLstByViewIdCache(objViewInfoENEx.ViewId, strPrjId);
            objViewInfoENEx.arrViewReferFiles = clsViewReferFilesBLEx.GetObjLstByViewIdCache(objViewInfoENEx.ViewId, strPrjId);
            objViewInfoENEx.arrViewRegion = clsViewRegionBLEx.GetObjExLstByViewIdCache(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);


            clsDGRegionFldsBLEx.initDGRegionFldSet(objViewInfoENEx, bolIsFstLcase);
            clsEditRegionFldsBLEx.initEditRegionFldSet(objViewInfoENEx, bolIsFstLcase);
            clsDetailRegionFldsBLEx.initDetailRegionFldSet(objViewInfoENEx);

            clsExcelExportRegionFldsBLEx.initExcelExportRegionFldSet(objViewInfoENEx);
            clsQryRegionFldsBLEx.initQryRegionFldSet(objViewInfoENEx, bolIsFstLcase);
            clsFeatureRegionFldsBLEx.initFeatureRegionFldSet(objViewInfoENEx);
            clsViewFeatureFldsBLEx.initViewFeatureFlds(objViewInfoENEx, bolIsFstLcase);

            initViewRelaTabFldSet(objViewInfoENEx);

            InitViewGroupEx(objViewInfoENEx);

            objViewInfoENEx.objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId);
            objViewInfoENEx.ObjFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            objViewInfoENEx.NameSpace = objViewInfoENEx.objProjectsEN.PrjDomain;

            string strFunctionTemplateId = clsPrjFuncTemplateRelaBLEx.getFunctionTemplateIdByPrjId(objViewInfoENEx.PrjId);
            objViewInfoENEx.FunctionTemplateId = strFunctionTemplateId;


            Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj_Qry = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());
            Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj_Edit = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());
            Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());
            List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };

            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                //获取下拉框对象列表
                IEnumerable<clsQryRegionFldsENEx> arrQRF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                objViewInfoENEx.arrASPDropDownListObj = arrQRF4DropDownLst
                    .Select(GetDdlObj_Qry);
                if (objViewInfoENEx.arrEditRegionFldSet4InUse != null)
                {
                    IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                    IEnumerable<ASPDropDownListEx> arrDropDownListObj_Edit = arrERF4DropDownLst.Select(GetDdlObj_Edit);

                    objViewInfoENEx.arrASPDropDownListObj = objViewInfoENEx.arrASPDropDownListObj.Union(arrDropDownListObj_Edit);
                }
                //从界面功能字段中获取下拉框字段
                if (objViewInfoENEx.arrViewFeatureFlds != null)
                {
                    IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                    IEnumerable<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                        .Select(GetDdlObj2);
                    objViewInfoENEx.arrASPDropDownListObj = objViewInfoENEx.arrASPDropDownListObj.Union(arrASPDropDownListObj4WFF).Distinct(new ASPDropDownListComparer());
                }
            }
            else
            {
                if (objViewInfoENEx.arrEditRegionFldSet4InUse != null)
                {
                    IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                    IEnumerable<ASPDropDownListEx> arrDropDownListObj_Edit = arrERF4DropDownLst.Select(GetDdlObj_Edit);

                    objViewInfoENEx.arrASPDropDownListObj = arrDropDownListObj_Edit;
                }
                //从界面功能字段中获取下拉框字段
                if (objViewInfoENEx.arrViewFeatureFlds != null)
                {
                    IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                    IEnumerable<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                        .Select(GetDdlObj2);
                    if (objViewInfoENEx.arrASPDropDownListObj == null)
                    {
                        objViewInfoENEx.arrASPDropDownListObj = arrASPDropDownListObj4WFF;
                    }
                    else
                    {
                        objViewInfoENEx.arrASPDropDownListObj = objViewInfoENEx.arrASPDropDownListObj.Union(arrASPDropDownListObj4WFF).Distinct(new ASPDropDownListComparer());
                    }
                }
            }
            //获取缓存分类字段
            //clsPrjTabFldENEx objPrjTabFldCacheClassifyFld = null;
            string strCacheClassifyField = objViewInfoENEx.objMainPrjTab.CacheClassifyField;
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyField).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyField).First();
            }

            string strCacheClassifyField2 = objViewInfoENEx.objMainPrjTab.CacheClassifyField2;
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyField2).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View2 = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyField2).First();
            }

            string strCacheClassifyFieldTS = objViewInfoENEx.objMainPrjTab.CacheClassifyFieldTS;
            if (objViewInfoENEx.objMainPrjTab.CacheModeId != enumCacheMode.localStorage_03 && objViewInfoENEx.objMainPrjTab.CacheModeId != enumCacheMode.sessionStorage_04)
            {
                strCacheClassifyFieldTS = "";
            }
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyFieldTS).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View_TS = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyFieldTS).First();
            }

            string strCacheClassifyField2TS = objViewInfoENEx.objMainPrjTab.CacheClassifyField2TS;
            if (objViewInfoENEx.objMainPrjTab.CacheModeId != enumCacheMode.ClientCache_02 && objViewInfoENEx.objMainPrjTab.CacheModeId != enumCacheMode.sessionStorage_04)
            {
                strCacheClassifyField2TS = "";
            }
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyField2TS).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View2_TS = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == strCacheClassifyField2TS).First();
            }

            return true;
        }
        public static void InitViewGroupEx(clsViewInfoENEx objViewInfoENEx)
        {
            //objViewInfoENEx .objViewGroupEx = new clsViewGroupENEx(objViewInfoENEx.ViewGroupId, true);
            //objViewInfoENEx.objViewTypeCodeTab = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
            if (objViewInfoENEx.OutRelaTabId == "" || objViewInfoENEx.InRelaTabId == "")
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在界面:{1}({0})中输入/出(IN/OUT)相关表不存在,请检查!",
                    objViewInfoENEx.ViewName,
                    objViewInfoENEx.ViewCnName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            if (objViewInfoENEx.OutRelaTabId != "")
            {
                objViewInfoENEx.objOutRelaTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.OutRelaTabId, objViewInfoENEx.PrjId);
                //objViewInfoENEx.KeyName_Out = objViewInfoENEx.objOutRelaTab.KeyFldName;
            }
            if (objViewInfoENEx.InRelaTabId != "")
            {
                objViewInfoENEx.objInRelaTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.InRelaTabId, objViewInfoENEx.PrjId);
                //objViewInfoENEx.KeyName_In = objViewInfoENEx.objInRelaTab.KeyFldName;
            }
        }


        public static void InitCodeTab(List<clsFieldTabENEx> arrFieldTabENExObjLst)
        {
            foreach (clsFieldTabENEx objFieldTabENEx in arrFieldTabENExObjLst)
            {
                var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(objFieldTabENEx.FldId, objFieldTabENEx.PrjId);
                if (objFieldTab4CodeConv != null)
                {
                    try
                    {
                        if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabId) == true)
                        {
                            string strMsg = string.Format("字段：{0}为转换字段，转换表为空，请检查！", objFieldTabENEx.FldName);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                            continue;
                        }
                        if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabNameId) == true)
                        {
                            string strMsg = string.Format("字段：{0}为转换字段，名称字段为空，请检查！", objFieldTabENEx.FldName);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                            continue;
                        }

                        if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabCodeId) == true)
                        {
                            string strMsg = string.Format("字段：{0}为转换字段，代码字段为空，请检查！", objFieldTabENEx.FldName);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                            continue;
                        }
                        if (objFieldTabENEx.FldName == "FeatureTypeId")
                        {
                            //string ss = "";
                        }
                        objFieldTabENEx.CodeTabName = clsPrjTabBL.GetObjByTabIdCache(
                              objFieldTab4CodeConv.CodeTabId, objFieldTabENEx.PrjId).TabName;
                        objFieldTabENEx.CodeTabName = clsFieldTabBLEx.GetObjExByFldIDCache(
                                                  objFieldTab4CodeConv.CodeTabNameId, objFieldTabENEx.PrjId).FldName;

                        objFieldTabENEx.CodeTabCode = clsFieldTabBLEx.GetObjExByFldIDCache(
                                                  objFieldTab4CodeConv.CodeTabCodeId,
                                                  objFieldTabENEx.PrjId).FldName;
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("处理字段：{0}的转换字段属性时出错：{1}。({2})",
                            objFieldTabENEx.FldName, objException.Message, clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    }
                }
            }
        }





        public static void initViewRelaTabFldSet(clsViewInfoENEx objViewInfoENEx)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //  然后存到集合中
            //3、
            //
            objViewInfoENEx.TabKeyFldNum = 0;


            //根据<界面ID>获取主表ID和详细表ID
            string strMainTabId, strDetailTabId;

            strMainTabId = objViewInfoENEx.MainTabId;
            if (strMainTabId == "")
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有相关主表,请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            strDetailTabId = objViewInfoENEx.DetailTabId;
            //根据<表ID>获取表字段集
            if (strMainTabId != "")
            {
                objViewInfoENEx.arrRelaMainTabFldSet = clsPrjTabFldBLEx.GetObjExLst(strMainTabId, objViewInfoENEx.PrjId);
            }
            if (strDetailTabId != "")
            {
                objViewInfoENEx.arrRelaDetailTabFldSet = clsPrjTabFldBLEx.GetObjExLst(strDetailTabId, objViewInfoENEx.PrjId);
            }
            //获取表字段对象(PrjTabFld)的字段(FieldTab)对象属性
            bool bolIsHaveMainTabKeyFld = false;
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrRelaMainTabFldSet)
            {
                objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02)
                {
                    objViewInfoENEx.arrKeyPrjTabFldSet.Add(objPrjTabFldENEx);
                    objViewInfoENEx.objMainTabKeyField = objPrjTabFldENEx;
                    bolIsHaveMainTabKeyFld = true;
                }

                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.OrderNumField_09)
                {
                    objViewInfoENEx.objMainOrderNumField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.PrefixField_19)
                {
                    objViewInfoENEx.objPrefixField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.DelSignField_12)
                {
                    objViewInfoENEx.objMainDelSignField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.NameField_03)
                {
                    objViewInfoENEx.objMainNameField = objPrjTabFldENEx;
                }
            }
            if (bolIsHaveMainTabKeyFld == false)
            {
                StringBuilder sbMessage = new StringBuilder();

                sbMessage.AppendFormat("在表:{1}({0})中不存在相应的表关键字,不能生成相应代码,请检查!(In {2})",
                    objViewInfoENEx.objMainPrjTab.TabName, objViewInfoENEx.objMainPrjTab.TabCnName,
                    clsStackTrace.GetCurrClassFunction());
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat(", 当前所选界面名称:{0}", strViewName);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(sbMessage.ToString());
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrRelaDetailTabFldSet != null)
            {
                foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrRelaDetailTabFldSet)
                {
                    objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
                    if (objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02)
                    {
                        objViewInfoENEx.objDetailTabKeyField = objPrjTabFldENEx;
                    }
                }
            }
        }


        public static bool DelRecordEx(string strViewId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除ViewInfo本表中与当前对象有关的记录

            strSQL = strSQL + string.Format("Delete from {0} where ViewId = '{1}'", clsViewStyleEN._CurrTabName, strViewId);

            strSQL = strSQL + string.Format("Delete from {0} where {1} in (Select {1} From {2} Where {3} in (Select {3} From {4} where {5}= '{6}'));",
                clsViewFeatureFldsEN._CurrTabName, conViewFeatureFlds.ViewFeatureId,
                clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.RegionId,
                clsViewRegionRelaEN._CurrTabName, conViewRegionRela.ViewId, strViewId);

            strSQL = strSQL + string.Format("Delete from {0} where {1} in (Select {1} From {2} where {3}= '{4}');",
                clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.RegionId, clsViewRegionRelaEN._CurrTabName, conViewRegionRela.ViewId, strViewId);
            strSQL = strSQL + "Delete from ViewRelaTab where ViewId = " + "'" + strViewId + "'";
            strSQL = strSQL + "Delete from ViewBtnOptSteps where ViewId = " + "'" + strViewId + "'";
            objSQL.ExecSql(strSQL);
            //            clsViewRegionBLEx.DelViewRegionsEx(strViewId);
            strSQL = "Delete from ViewRegionRela where ViewId = " + "'" + strViewId + "'";
            strSQL = strSQL + "Delete from ViewInfo where ViewId = " + "'" + strViewId + "'";
            return objSQL.ExecSql(strSQL);
        }

        public static int SetViewUpdDate(string strViewId)
        {
            return clsViewInfoBL.SetFldValue("ViewInfo", "UpdDate", clsDateTime.getTodayDateTimeStr(1), "ViewId = " + "'" + strViewId + "'");
        }
        /// <summary>
        /// 设置界面的修改日期
        /// </summary>
        /// <param name="strViewId">视图Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <returns></returns>
        public static bool SetViewUpdDate(string strViewId, string strPrjId, string strUserId)
        {
            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
            objViewInfo.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .Update();
            return true;

        }
        public static int SetViewUpdDate4RegionId(string lngRegionId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewId in (Select ViewId from ViewRegionRela where RegionId = '{0}')", lngRegionId);
            return clsViewInfoBL.SetFldValue("ViewInfo", "UpdDate", clsDateTime.getTodayDateTimeStr(1), sbCondition.ToString());

        }
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="lngRegionId"></param>
        ///// <returns></returns>
        //public static clsViewInfoEN GetObjByRegionId(string lngRegionId)
        //{
        //    StringBuilder sbCondition = new StringBuilder();
        //    sbCondition.AppendFormat("ViewId in (Select ViewId from ViewRegionRela where RegionId = '{0}')", lngRegionId);
        //    return clsViewInfoBL.GetFirstObj_S(sbCondition.ToString());

        //}

        /// <summary>
        /// 导入界面区域、区域字段
        /// </summary>
        /// <param name = "strViewId"></param>
        /// <param name = "strRegionTypeId"></param>
        /// <param name = "strTabId"></param>
        /// <returns></returns>
        public static bool ImportRegionAndFlds(string strViewId, string strRegionTypeId, string strSqlDsTypeId, string strTabId, string strUserId)
        {
            StringBuilder sbWhereCond;
            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewId(strViewId);
            clsViewGroupEN objViewGroup = clsViewGroupBL.GetObjByViewGroupId(objViewInfo.ViewGroupId);

            clsViewRegionEN objViewRegionEN = new clsViewRegionEN();    //初始化新对象

            objViewRegionEN.RegionTypeId = strRegionTypeId;
            //objViewRegionEN.RegionFunction = objViewRegionEN.RegionName;
            switch (objViewRegionEN.RegionTypeId)
            {
                case enumRegionType.DetailRegion_0006:
                case enumRegionType.ExcelExportRegion_0007:
                case enumRegionType.FeatureRegion_0008:
                case enumRegionType.ListRegion_0002:
                case enumRegionType.QueryRegion_0001:
                case enumRegionType.TreeViewRegion_0005:
                    objViewRegionEN.InOutTypeId = enumInOutType.OUT_03;
                    objViewRegionEN.TabId = strTabId;
                    break;
                case enumRegionType.EditRegion_0003:
                    objViewRegionEN.InOutTypeId = enumInOutType.IN_02;
                    objViewRegionEN.TabId = objViewGroup.InRelaTabId;
                    break;
            }
            //objViewRegionEN.OutSqlDsTypeId = strSqlDsTypeId;
            //objViewRegionEN.OutRelaTabId = strTabId;
            //objViewRegionEN.InSqlDsTypeId = objViewGroup.InSqlDsTypeId;
            //objViewRegionEN.InRelaTabId = objViewGroup.InRelaTabId;

            objViewRegionEN.RegionName = clsViewRegionBLEx.GetDefaRegionName4Add(objViewRegionEN.TabId, objViewInfo.PrjId, strRegionTypeId);

            objViewRegionEN.Height = 100;
            objViewRegionEN.Width = 150;
            objViewRegionEN.Memo = objViewRegionEN.RegionName;
            objViewRegionEN.PrjId = objViewInfo.PrjId;
            //objViewRegionEN.ApplicationTypeId = objViewInfo.ApplicationTypeId;
            clsViewRegionBL.AddNewRecordBySql2(objViewRegionEN);

            clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();    //初始化新对象

            objViewRegionRelaEN.RegionId = objViewRegionEN.RegionId;
            objViewRegionRelaEN.ViewId = strViewId;
            objViewRegionRelaEN.PrjId = objViewInfo.PrjId;
            objViewRegionRelaEN.InUse = true;
            objViewRegionRelaEN.IsDisp = true;
            objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objViewRegionRelaEN.UpdUser = strUserId;
            objViewRegionRelaEN.EditRecordEx();


            sbWhereCond = new StringBuilder();
            sbWhereCond.AppendFormat("ViewId = '{0}' and RegionName = '{1}'",
                strViewId,
                objViewRegionEN.RegionName);

            objViewRegionEN.RegionId = clsViewRegionBL.GetFirstID_S(sbWhereCond.ToString());
            //添加相关字段
            switch (strRegionTypeId)
            {
                case clsRegionTypeBLEx.EDITREGION:	//编辑区域
                    clsEditRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfo.PrjId, objViewInfo.UserId);
                    break;
                case clsRegionTypeBLEx.QUERYREGION:	//查询区域
                    clsQryRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfo.PrjId, objViewInfo.UserId);
                    break;
                case clsRegionTypeBLEx.DGREGION:	//DG区域
                    clsDGRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfo.PrjId, objViewInfo.UserId);
                    break;
                case clsRegionTypeBLEx.EXCELEXPORT_REGION:	//EXCEL导出区域
                    clsExcelExportRegionFldsBLEx.ImportRelaFlds(objViewRegionEN.RegionId, objViewInfo.PrjId, objViewInfo.UserId);
                    break;

            }
            return true;
        }

        public static void AddDefaultViewStyle(string strPrjId, string strViewId)
        {
            clsViewStyleEN objViewStyleEN = new clsViewStyleEN(strViewId);
            objViewStyleEN.DgStyleId = clsDataGridStyleBLEx.GetDefaDGStyle();
            objViewStyleEN.TitleStyleId = clsTitleStyleBLEx.GetDefaTitleStyle(strPrjId);
            if (string.IsNullOrEmpty(objViewStyleEN.TitleStyleId) == true)
            {
                objViewStyleEN.TitleStyleId = "03";
            }
            if (clsViewStyleBL.IsExist(objViewStyleEN.ViewId) == false)
            {
                clsViewStyleBL.AddNewRecordBySql2(objViewStyleEN);
            }

        }
        /// <summary>
        /// 关键字字段名的列表串,附带双引号
        /// </summary>
        public static string KeyFldNameLstStrWithQuote(clsViewInfoENEx objViewInfoENEx)
        {

            ArrayList arrKeyFldNameLst = new ArrayList();
            foreach (clsPrjTabFldENEx objField in objViewInfoENEx.arrKeyPrjTabFldSet)
            {
                arrKeyFldNameLst.Add(string.Format("\"{0}\"", objField.ObjFieldTabENEx.FldName));
            }
            string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
            return strKeyFldNameLst;

        }

        /// <summary>
        /// 关键字字段名的列表串,使用实体类常量
        /// </summary>
        public static string KeyFldNameLstStrWithEntityConst(clsViewInfoENEx objViewInfoENEx)
        {

            ArrayList arrKeyFldNameLst = new ArrayList();
            foreach (clsPrjTabFldENEx objField in objViewInfoENEx.arrKeyPrjTabFldSet)
            {
                arrKeyFldNameLst.Add(string.Format("con{0}.{1}",
                   objViewInfoENEx.objMainPrjTab.TabName,
                   objField.ObjFieldTabENEx.FldName));
            }
            string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
            return strKeyFldNameLst;

        }

        public static List<string> GetViewIdLstByPrjId(string strPrjId)
        {

            //获取某学院所有专业信息
            string strSQL = string.Format("{0} = '{1}'",
                conViewInfo.PrjId, strPrjId);

            var arr = clsViewInfoBL.GetFldValue(conViewInfo.ViewId, strSQL);
            return arr;
        }
        public static System.Data.DataTable GetDataTable_ViewIdEx(string strPrjId)
        {

            //获取某学院所有专业信息
            string strSQL = string.Format("select ViewId, ViewName from ViewInfo Where {0} = '{1}' Order by {2}",
                conViewInfo.PrjId, strPrjId,
                conViewInfo.ViewName);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_ViewIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            var arrViewInfo = clsViewInfoBL.GetObjLstCache(strPrjId)
                            .OrderBy(x => x.ViewName);

            objDDL.DataValueField = "ViewId";
            objDDL.DataTextField = "ViewName";
            objDDL.DataSource = arrViewInfo;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_ViewIdByTabIdExBak(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strTabId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            var arrViewInfo = clsViewInfoBL.GetObjLstCache(strPrjId)
                            .Where(x => x.MainTabId == strTabId)
                            .OrderBy(x => x.ViewName);

            objDDL.DataValueField = "ViewId";
            objDDL.DataTextField = "ViewName";
            objDDL.DataSource = arrViewInfo;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_ViewIdByTabIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strTabId, string strCurrViewId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            var arrViewInfo = clsViewInfoBL.GetObjLstCache(strPrjId)
                            .Where(x => x.MainTabId == strTabId && x.ViewId != strCurrViewId)
                            .OrderBy(x => x.ViewName);

            objDDL.DataValueField = "ViewId";
            objDDL.DataTextField = "ViewName";
            objDDL.DataSource = arrViewInfo;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsViewInfoBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrViewInfoObjLstCache = null;

        //    //初始化列表缓存
        //    if (arrViewInfoObjLstCache == null)
        //    {
        //        string strWhereCond = string.Format("{0} = '{1}' order by {2}",
        //            conViewInfo.PrjId, strPrjId, conViewInfo.ViewId);

        //        arrViewInfoObjLstCache = clsViewInfoBL.GetObjLst(strWhereCond);

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
        /// <param name = "strViewId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        //public static clsViewInfoEN GetObjByViewIdCacheEx(string strViewId, string strPrjId)
        //{
        //    string strMsg = "";
        //    if (string.IsNullOrEmpty(strViewId) == true)
        //    {
        //        strMsg = string.Format("界面Id不能为空！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (string.IsNullOrEmpty(strViewId) == true) return null;
        //    //string strCondition = string.Format("{0} = '{1}' order by ViewId", conViewInfo.PrjId, strPrjId);
        //    //if (arrViewInfoObjLstCacheEx  ==  null)
        //    //{
        //    //    arrViewInfoObjLstCacheEx = new clsViewInfoDA().GetObjLst(strCondition);
        //    //}
        //    clsViewInfoBL.intFindFailCount = 0;
        //    List<clsViewInfoEN> arrObjLstCache = clsViewInfoBL.GetObjLstCache(strPrjId);

        //    List<clsViewInfoEN> arrViewInfoObjLst_Sel = null;
        //    while (clsViewInfoBL.intFindFailCount <= 1)
        //    {

        //        IEnumerable<clsViewInfoEN> arrViewInfoObjLst_Sel1 =
        //            from objViewInfoEN in arrObjLstCache
        //            where objViewInfoEN.ViewId == strViewId
        //            select objViewInfoEN;
        //        arrViewInfoObjLst_Sel = new List<clsViewInfoEN>();
        //        foreach (clsViewInfoEN obj in arrViewInfoObjLst_Sel1)
        //        {
        //            arrViewInfoObjLst_Sel.Add(obj);
        //        }
        //        //在缓存中找到数据，就返回第一条数据
        //        if (arrViewInfoObjLst_Sel.Count > 0)
        //        {
        //            return arrViewInfoObjLst_Sel[0];
        //        }
        //        //如果在缓存中找不到数据，就重新加载缓存，再试一次
        //        clsViewInfoBL.intFindFailCount++;

        //    }
        //    string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
        //    CacheHelper.Remove(strKey);

        //    strMsg = string.Format("界面Id:[{0}]，项目Id:[{1}]找不到相关对象！(intFindFailCount={2})(当前对象数:{3})({4})",
        //       strViewId, strPrjId, intFindFailCount,
        //       arrObjLstCache.Count,
        //       clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}

        /// <summary>
        /// 根据区域Id获取用户绑定下拉框的相关表Id
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4Ddl_AllRegion2(string strViewId, bool bolIsFstLcase, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {
                string lngRegionId_Edit = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId, clsRegionTypeENEx.EDITREGION, strPrjId);
                if (string.IsNullOrEmpty(lngRegionId_Edit) == false)
                {
                    List<string> arrTabId_Edit = clsEditRegionBLEx.getRelaTabId4Ddl2(lngRegionId_Edit, bolIsFstLcase, strPrjId, strViewId);
                    arrTabId.AddRange(arrTabId_Edit);
                }
            }
            {
                string lngRegionId_Qry = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId, clsRegionTypeENEx.QUERYREGION, strPrjId);
                if (string.IsNullOrEmpty(lngRegionId_Qry) == false)
                {
                    List<string> arrTabId_Qry = clsQueryRegionBLEx.getRelaTabId4Ddl2(lngRegionId_Qry, bolIsFstLcase, strPrjId, strViewId);
                    foreach (string strTabId in arrTabId_Qry)
                    {
                        if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
                    }
                }
            }
            {
                string lngRegionId_Feature = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId, clsRegionTypeENEx.FEATUREREGION, strPrjId);
                if (string.IsNullOrEmpty(lngRegionId_Feature) == false)
                {
                    List<string> arrTabId_Feature = clsFeatureRegionFldsBLEx.getRelaTabId4Ddl2(lngRegionId_Feature, strPrjId);
                    foreach (string strTabId in arrTabId_Feature)
                    {
                        if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
                    }
                }
            }

            return arrTabId;
        }

        public static List<string> getRelaTabId4Ddl_Edit(string strViewId, bool bolIsFstLcase, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {
                string lngRegionId_Edit = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId, clsRegionTypeENEx.EDITREGION, strPrjId);
                if (string.IsNullOrEmpty(lngRegionId_Edit) == false)
                {
                    List<string> arrTabId_Edit = clsEditRegionBLEx.getRelaTabId4Ddl2(lngRegionId_Edit, bolIsFstLcase, strPrjId, strViewId);
                    arrTabId.AddRange(arrTabId_Edit);
                }
            }

            return arrTabId;
        }

        public static List<string> getAllRelaTabId4AllRegion2(string strViewId, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {
                var objRegionEdit = clsViewRegionBLEx.GetObjByTypeCache2(strViewId, clsRegionTypeENEx.EDITREGION, strPrjId);
                if (objRegionEdit != null)
                {
                    arrTabId.Add(objRegionEdit.TabId);
                }
            }
            {
                var objRegionQry = clsViewRegionBLEx.GetObjByTypeCache2(strViewId, clsRegionTypeENEx.QUERYREGION, strPrjId);
                if (objRegionQry != null)
                {

                        if (arrTabId.Contains(objRegionQry.TabId) == false) arrTabId.Add(objRegionQry.TabId);

                }
            }
            {
                var objRegionFeature = clsViewRegionBLEx.GetObjByTypeCache2(strViewId, clsRegionTypeENEx.FEATUREREGION, strPrjId);
                if (objRegionFeature != null)
                {

                    if (arrTabId.Contains(objRegionFeature.TabId) == false) arrTabId.Add(objRegionFeature.TabId);

                }               
            }
            {
                var objRegionDetail = clsViewRegionBLEx.GetObjByTypeCache2(strViewId, clsRegionTypeENEx.DETAILREGION, strPrjId);
                if (objRegionDetail != null)
                {

                    if (arrTabId.Contains(objRegionDetail.TabId) == false) arrTabId.Add(objRegionDetail.TabId);

                }
            }
            {
                var objRegionDG = clsViewRegionBLEx.GetObjByTypeCache2(strViewId, clsRegionTypeENEx.DGREGION, strPrjId);
                if (objRegionDG != null)
                {

                    if (arrTabId.Contains(objRegionDG.TabId) == false) arrTabId.Add(objRegionDG.TabId);

                }
            }
            return arrTabId;
        }


        public static string getTabIdByRegionTypeId(string strViewId, string strRegionTypeId, string strPrjId)
        {

            var objRegionEdit = clsViewRegionBLEx.GetObjByTypeCache2(strViewId, strRegionTypeId, strPrjId);
            if (objRegionEdit != null)
            {
                return objRegionEdit.TabId;
            }
            return "";
        }



        public static List<string> getRelaTabId4Ddl_Qry2(string strViewId, bool bolIsFstLcase, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {

                string lngRegionId_Qry = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId, clsRegionTypeENEx.QUERYREGION, strPrjId);
                if (string.IsNullOrEmpty(lngRegionId_Qry) == false)
                {
                    List<string> arrTabId_Qry = clsQueryRegionBLEx.getRelaTabId4Ddl2(lngRegionId_Qry, bolIsFstLcase, strPrjId, strViewId);
                    foreach (string strTabId in arrTabId_Qry)
                    {
                        if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
                    }
                }
            }
            {
                string lngRegionId_Feature = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId, clsRegionTypeENEx.FEATUREREGION, strPrjId);
                if (string.IsNullOrEmpty(lngRegionId_Feature) == false)
                {
                    List<string> arrTabId_Feature = clsFeatureRegionFldsBLEx.getRelaTabId4Ddl2(lngRegionId_Feature, strPrjId);
                    foreach (string strTabId in arrTabId_Feature)
                    {
                        if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
                    }
                }
            }

            return arrTabId;
        }

        //public static List<string> getRelaTabId4Ddl_Feature(string strViewId, string strPrjId)
        //{
        //    List<string> arrTabId = new List<string>();
        //    {

        //        string lngRegionId_Feature = clsViewRegionBLEx.GetRegionIdByTypeCache(strViewId, clsRegionTypeENEx.FEATUREREGION, strPrjId);
        //        if (string.IsNullOrEmpty(lngRegionId_Feature) == false)
        //        {
        //            List<string> arrTabId_Feature = clsFeatureRegionFldsBLEx.getRelaTabId4Ddl(lngRegionId_Feature, strPrjId);
        //            foreach (string strTabId in arrTabId_Feature)
        //            {
        //                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
        //            }
        //        }
        //    }
        //    {
        //        string lngRegionId_Feature = clsViewRegionBLEx.GetRegionIdByTypeCache(strViewId, clsRegionTypeENEx.FEATUREREGION, strPrjId);
        //        if (string.IsNullOrEmpty(lngRegionId_Feature) == false)
        //        {
        //            List<string> arrTabId_Feature = clsFeatureRegionFldsBLEx.getRelaTabId4Ddl(lngRegionId_Feature, strPrjId);
        //            foreach (string strTabId in arrTabId_Feature)
        //            {
        //                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
        //            }
        //        }
        //    }

        //    return arrTabId;
        //}


        /// <summary>
        /// 根据界面Id获取输入输出的相关表Id
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4InOut(string strViewId, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {
                clsViewInfoEN objViewInfoEN = clsViewInfoBLEx.GetObjByViewIdCache(strViewId, strPrjId);
                string strTabId_In = objViewInfoEN.InRelaTabId;
                string strTabId_Out = objViewInfoEN.OutRelaTabId;

                if (string.IsNullOrEmpty(strTabId_In) == false)
                {
                    if (arrTabId.Contains(strTabId_In) == false) arrTabId.Add(strTabId_In);
                }
                if (string.IsNullOrEmpty(strTabId_Out) == false)
                {
                    if (arrTabId.Contains(strTabId_Out) == false) arrTabId.Add(strTabId_Out);
                }
            }

            return arrTabId;
        }

        /// <summary>
        /// 根据界面Id获取输入输出的相关表名称
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabName4InOut(string strViewId, string strPrjId)
        {
            List<string> arrTabId = new List<string>();
            {
                clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                string strTabId_In = objViewInfoEN.InRelaTabId;
                string strTabId_Out = objViewInfoEN.OutRelaTabId;

                if (string.IsNullOrEmpty(strTabId_In) == false)
                {
                    if (arrTabId.Contains(strTabId_In) == false) arrTabId.Add(strTabId_In);
                }
                if (string.IsNullOrEmpty(strTabId_Out) == false)
                {
                    if (arrTabId.Contains(strTabId_Out) == false) arrTabId.Add(strTabId_Out);
                }
            }
            List<string> arrTabName = new List<string>();
            foreach (string strTabId in arrTabId)
            {
                clsPrjTabEN obj = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                arrTabName.Add(obj.TabName);
            }

            return arrTabName;
        }

        public static string GetMainTabName(string strViewId, string strPrjId)
        {

            clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
            string strTabId_In = objViewInfoEN.MainTabId;
            clsPrjTabEN obj = clsPrjTabBL.GetObjByTabIdCache(strTabId_In, strPrjId);
            if (obj == null) return "";
            return obj.TabName;

        }


        public static bool CheckRegionFlds(string strViewId, string strPrjDataBaseId, string strCmPrjId, string strUpdUser)
        {
            var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            var arrViewRegion = clsViewRegionBL.GetObjLstByRegionIdLstCache(arrRegionId, strPrjId);
            var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);

            List<clsErrMsgENEx> arrErrMsg = new List<clsErrMsgENEx>();

            foreach (var objInFor in arrViewRegion)
            {
                switch (objInFor.RegionTypeId)
                {
                    case enumRegionType.QueryRegion_0001:
                        var objErrMsg_Qry = clsQryRegionFldsBLEx.CheckRegionFlds(objInFor.RegionId, strCmPrjId, strUpdUser, strViewId);
                        if (objErrMsg_Qry.ErrNum > 0) arrErrMsg.Add(objErrMsg_Qry);
                        break;
                    case enumRegionType.ListRegion_0002:
                        var objErrMsg_List = clsDGRegionFldsBLEx.CheckRegionFlds(strViewId, objInFor.RegionId, strCmPrjId, strUpdUser);
                        if (objErrMsg_List.ErrNum > 0) arrErrMsg.Add(objErrMsg_List);
                        break;
                    case enumRegionType.EditRegion_0003:
                        var objErrMsg_Edit = clsEditRegionFldsBLEx.CheckRegionFlds(objInFor.RegionId, strCmPrjId, strUpdUser, strViewId);
                        if (objErrMsg_Edit.ErrNum > 0) arrErrMsg.Add(objErrMsg_Edit);
                        break;

                    case enumRegionType.DetailRegion_0006:
                        var objErrMsg_Detail = clsDetailRegionFldsBLEx.CheckRegionFlds(objInFor.RegionId, strCmPrjId, strUpdUser);
                        if (objErrMsg_Detail.ErrNum > 0) arrErrMsg.Add(objErrMsg_Detail);
                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        var objErrMsg_ExcelExport = clsExcelExportRegionFldsBLEx.CheckRegionFlds(objInFor.RegionId, strCmPrjId, strUpdUser);
                        if (objErrMsg_ExcelExport.ErrNum > 0) arrErrMsg.Add(objErrMsg_ExcelExport);
                        break;
                    case enumRegionType.FeatureRegion_0008:
                        var objErrMsg_Feature = clsFeatureRegionFldsBLEx.CheckRegionFlds(objInFor.RegionId, strCmPrjId, strUpdUser);
                        if (objErrMsg_Feature.ErrNum > 0) arrErrMsg.Add(objErrMsg_Feature);
                        break;

                }
            }
            try
            {
                var arrTabId = clsViewInfoBLEx.getAllRelaTabId4AllRegion2(strViewId, strPrjId);
                foreach (var strTabId in arrTabId)
                {
                    clsPrjTabBLEx.CheckTabFlds(strTabId, strPrjDataBaseId, strCmPrjId, strUpdUser, strViewId);
                }   

            }
            catch (Exception objException)
            {
                string  strErrMsg = objException.Message;
                arrErrMsg.Add(new clsErrMsgENEx(strErrMsg, 1)); 
            }
            try
            {
                var arrViewIdGCVariableRela = clsViewIdGCVariableRelaBLEx.GetObjLstByViewId(strViewId, strPrjId);
                foreach (var objInFor in arrViewIdGCVariableRela)
                {
                    if (objInFor.RetrievalMethodId == enumRetrievalMethod.Undefined_01)
                    {
                        //var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strMsg = $"变量：{objInFor.VarId}在界面:{objViewInfo.ViewName}({strViewId})的变量表中获取方式为空，请检查 ！";
                        objInFor.ErrMsg = strMsg;
                        objInFor.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objInFor.Update();
                        clsViewIdGCVariableRelaBL.ReFreshCache(strPrjId);
                        throw new Exception(strMsg);
                    }
                }
            }
            catch (Exception objException)
            {
                string strErrMsg = objException.Message;
                arrErrMsg.Add(new clsErrMsgENEx(strErrMsg, 1));
            }
            if (arrErrMsg.Count > 0)
            {
                objViewInfo.ErrMsg = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg);
                objViewInfo.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objViewInfo.Update();

            }
            else
            {
                //if (objViewInfo.ErrMsg != null &&  objViewInfo.ErrMsg.Length>0)
                //{
                objViewInfo.ErrMsg = "";
                objViewInfo.Update();
                //}
            }
            
            return true;
        }
        public static bool Clone(string strViewId, string strPrjId, string strUpdUser)
        {
            clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
            objViewInfoEN.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(strPrjId);
            objViewInfoEN.ViewName = string.Format("Copy_{0}", objViewInfoEN.ViewName);
            objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objViewInfoEN.UpdUserId = strUpdUser;

            clsViewInfoBL.AddNewRecordBySql2(objViewInfoEN);
            //复制ViewStyle
            List<clsViewStyleEN> arrViewStyleObjLst = clsViewStyleBLEx.GetObjLstByViewIdEx(strViewId);
            foreach (clsViewStyleEN objInFor in arrViewStyleObjLst)
            {
                clsViewStyleEN objInFor_T = new clsViewStyleEN();
                clsViewStyleBL.CopyTo(objInFor, objInFor_T);
                objInFor_T.ViewId = objViewInfoEN.ViewId;
                clsViewStyleBL.AddNewRecordBySql2(objInFor_T);
            }

            List<clsViewReferFilesEN> arrViewReferFilesObjLst = clsViewReferFilesBLEx.GetObjLstByViewId(strViewId);
            foreach (clsViewReferFilesEN objInFor in arrViewReferFilesObjLst)
            {
                objInFor.SetViewId(objViewInfoEN.ViewId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUserId(strUpdUser).AddNewRecord();

            }
            List<clsViewRegionRelaEN> arrViewRegionObjLst = clsViewRegionRelaBLEx.GetObjLstByViewId(strViewId);
            List<string> arrRegionId = arrViewRegionObjLst.Select(x => x.RegionId).ToList();
            foreach (clsViewRegionRelaEN objInFor in arrViewRegionObjLst)
            {
                clsViewRegionRelaEN objInFor_T = new clsViewRegionRelaEN();
                clsViewRegionRelaBL.CopyTo(objInFor, objInFor_T);
                //objInFor_T.ViewId = objViewInfoEN.ViewId;
                string strMId = clsViewRegionRelaBL.AddNewRecordBySql2WithReturnKey(objInFor_T);
                //string lngRegionId = strRegionId;
                //enumRegionType typeRegionType = (enumRegionType)objInFor.RegionTypeId;
                //switch (objInFor.RegionTypeId)
                //{
                //    case enumRegionType.QueryRegion_0001:
                //        clsQueryRegionBLEx.CopyTo(objInFor.RegionId, lngRegionId, strPrjId, strUpdUser);

                //        break;

                //    case enumRegionType.ListRegion_0002:
                //        clsDGRegionBLEx.CopyTo(objInFor.RegionId, lngRegionId, objInFor.PrjId, strUpdUser);


                //        break;
                //    case enumRegionType.EditRegion_0003:
                //        clsEditRegionBLEx.CopyTo(objInFor.RegionId, lngRegionId, strPrjId, strUpdUser);

                //        break;
                //    case enumRegionType.DetailRegion_0006:
                //        clsDetailRegionBLEx.CopyTo(objInFor.RegionId, lngRegionId, objInFor.PrjId, strUpdUser);

                //        break;
                //    case enumRegionType.ExcelExportRegion_0007:
                //        clsExcelExportRegionBLEx.CopyTo(objInFor.RegionId, lngRegionId, objInFor.PrjId, strUpdUser);


                //        break;
                //    case enumRegionType.FeatureRegion_0008:
                //        clsFeatureRegionBLEx.CopyTo(strViewId, objInFor.RegionId, lngRegionId, objInFor.PrjId, strUpdUser);                        
                //        break;
                //}
            }
            return true;
        }


        public static ASPGridViewEx CreateGridView(clsViewInfoENEx objViewInfoENEx)
        {
            ASPGridViewEx objASPGridViewENEx_DG = new ASPGridViewEx();
            objASPGridViewENEx_DG.AspControlId = string.Format("gv{0}", objViewInfoENEx.objMainPrjTab.TabName);
            objASPGridViewENEx_DG.AspControlName = string.Format("gv{0}", objViewInfoENEx.objMainPrjTab.TabName);


            ASPTemplateFieldEx objASPTemplateFieldENEx = new ASPTemplateFieldEx();
            objASPTemplateFieldENEx.AspControlId = string.Format("tfSelAll");
            objASPTemplateFieldENEx.AspControlName = string.Format("tfSelAll");
            objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPTemplateFieldENEx);

            ASPHeaderStyleEx objASPHeaderStyleENEx = new ASPHeaderStyleEx();
            objASPHeaderStyleENEx.AspControlId = string.Format("hsSelAll");
            objASPHeaderStyleENEx.AspControlName = string.Format("hsSelAll");
            objASPHeaderStyleENEx.Width = 30;
            objASPTemplateFieldENEx.arrSubAspControlLst2.Add(objASPHeaderStyleENEx);

            ASPHeaderTemplateEx objASPHeaderTemplateENEx = new ASPHeaderTemplateEx();
            objASPHeaderTemplateENEx.AspControlId = string.Format("htSelAll");
            objASPHeaderTemplateENEx.AspControlName = string.Format("htSelAll");
            objASPHeaderTemplateENEx.Width = 30;
            objASPTemplateFieldENEx.arrSubAspControlLst2.Add(objASPHeaderTemplateENEx);

            ASPLinkButtonEx objASPLinkButtonENEx = new ASPLinkButtonEx();
            objASPLinkButtonENEx.AspControlId = string.Format("lbSelAll");
            objASPLinkButtonENEx.AspControlName = string.Format("lbSelAll");
            objASPLinkButtonENEx.CommandName = "lbSelAll";
            objASPLinkButtonENEx.CssClass = "DgSelAll";
            objASPLinkButtonENEx.Text = "全选";
            //<asp:Button ID = "lbSelAll" CommandName = "lbSelAll" runat = "server" CssClass = "DgSelAll">全选</asp:Button>

            objASPLinkButtonENEx.Width = 30;
            objASPHeaderTemplateENEx.arrSubAspControlLst2.Add(objASPLinkButtonENEx);


            ASPItemTemplateEx objASPItemTemplateENEx = new ASPItemTemplateEx();
            objASPItemTemplateENEx.AspControlId = string.Format("itSelAll");
            objASPItemTemplateENEx.AspControlName = string.Format("itSelAll");
            objASPItemTemplateENEx.Width = 30;
            objASPTemplateFieldENEx.arrSubAspControlLst2.Add(objASPItemTemplateENEx);


            ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
            objASPCheckBoxENEx.AspControlId = string.Format("chkCheckRec");
            objASPCheckBoxENEx.AspControlName = string.Format("chkCheckRec");
            //<asp:CheckBox ID = "chkCheckRec" runat = "server"></asp:CheckBox>

            objASPItemTemplateENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);


            ASPBoundFieldEx objASPBoundFieldENEx = null;


            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {

                objASPBoundFieldENEx = new ASPBoundFieldEx();
                objASPBoundFieldENEx.AspControlId = string.Format("bf{0}", objQryRegionFldsEx.ObjFieldTabENEx.FldName);
                objASPBoundFieldENEx.AspControlName = string.Format("bf{0}", objQryRegionFldsEx.ObjFieldTabENEx.FldName);
                objASPBoundFieldENEx.DataField = objQryRegionFldsEx.ObjFieldTabENEx.FldName;
                objASPBoundFieldENEx.SortExpression = objQryRegionFldsEx.ObjFieldTabENEx.FldName;
                objASPBoundFieldENEx.HeaderText = objQryRegionFldsEx.ObjFieldTabENEx.Caption;

                objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPBoundFieldENEx);

            }

            //修改按钮－－－－－－－－－－－－－－－－
            //<asp:Button ID = "lbUpdate" runat = "Server" CommandName = "Update" Text = "修改"></asp:Button>

            ASPTemplateFieldEx objASPTemplateFieldENEx_Update = new ASPTemplateFieldEx();
            objASPTemplateFieldENEx_Update.AspControlId = string.Format("tfUpdate");
            objASPTemplateFieldENEx_Update.AspControlName = string.Format("tfUpdate");
            objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPTemplateFieldENEx_Update);

            ASPItemTemplateEx objASPItemTemplateENEx_Update = new ASPItemTemplateEx();
            objASPItemTemplateENEx_Update.AspControlId = string.Format("itUpdate");
            objASPItemTemplateENEx_Update.AspControlName = string.Format("itUpdate");
            objASPItemTemplateENEx_Update.Width = 30;
            objASPTemplateFieldENEx_Update.arrSubAspControlLst2.Add(objASPItemTemplateENEx_Update);

            ASPLinkButtonEx objASPLinkButtonENEx_Update = new ASPLinkButtonEx();
            objASPLinkButtonENEx_Update.AspControlId = string.Format("lbUpdate");
            objASPLinkButtonENEx_Update.AspControlName = string.Format("lbUpdate");
            objASPLinkButtonENEx_Update.CommandName = "Update";
            //objASPLinkButtonENEx_Update.CssClass = "DgSelAll";
            objASPLinkButtonENEx_Update.Text = "修改";

            objASPItemTemplateENEx_Update.arrSubAspControlLst2.Add(objASPLinkButtonENEx_Update);

            //修改按钮＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

            //删除按钮－－－－－－－－－－－－－－－－
            //<asp:Button ID = "lbDelete" runat = "Server" CommandName = "Delete" Text = "删除"></asp:Button>

            ASPTemplateFieldEx objASPTemplateFieldENEx_Delete = new ASPTemplateFieldEx();
            objASPTemplateFieldENEx_Delete.AspControlId = string.Format("tfDelete");
            objASPTemplateFieldENEx_Delete.AspControlName = string.Format("tfDelete");
            objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPTemplateFieldENEx_Delete);

            ASPItemTemplateEx objASPItemTemplateENEx_Delete = new ASPItemTemplateEx();
            objASPItemTemplateENEx_Delete.AspControlId = string.Format("itDelete");
            objASPItemTemplateENEx_Delete.AspControlName = string.Format("itDelete");
            objASPItemTemplateENEx_Delete.Width = 30;
            objASPTemplateFieldENEx_Delete.arrSubAspControlLst2.Add(objASPItemTemplateENEx_Delete);

            ASPLinkButtonEx objASPLinkButtonENEx_Delete = new ASPLinkButtonEx();
            objASPLinkButtonENEx_Delete.AspControlId = string.Format("lbDelete");
            objASPLinkButtonENEx_Delete.AspControlName = string.Format("lbDelete");
            objASPLinkButtonENEx_Delete.CommandName = "Delete";
            //objASPLinkButtonENEx_Delete.CssClass = "DgSelAll";
            objASPLinkButtonENEx_Delete.Text = "删除";

            objASPItemTemplateENEx_Delete.arrSubAspControlLst2.Add(objASPLinkButtonENEx_Delete);

            //删除按钮＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

            ASPPagerTemplateEx objASPPagerTemplateENEx = new ASPPagerTemplateEx();
            objASPPagerTemplateENEx.AspControlId = "PagerTemplate";
            objASPPagerTemplateENEx.AspControlName = "PagerTemplate";

            objASPGridViewENEx_DG.objASPPagerTemplateENEx = objASPPagerTemplateENEx;

            return objASPGridViewENEx_DG;
        }

        public static ASPHtmlTableEx CreateFeatureRegion(clsViewInfoENEx objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_Func = new ASPHtmlTableEx();
            objASPHtmlTableENEx_Func.AspControlId = "tabFeatureRegion";
            objASPHtmlTableENEx_Func.AspControlName = "tabFeatureRegion";


            ASPRowEx objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trFuncRow");
            objASPRowENEx.AspControlName = string.Format("trFuncRow");
            objASPHtmlTableENEx_Func.arrSubAspControlLst2.Add(objASPRowENEx);
            int intCurrCol = 1;

            ASPColEx objASPColENEx = null;
            ASPLabelEx objASPLabelENEx = null;

            ASPButtonEx objASPButtonENEx = null;

            objASPLabelENEx = new ASPLabelEx();
            objASPLabelENEx.AspControlId = string.Format("lbl{0}List", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.AspControlName = string.Format("lbl{0}List", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.CssClass = "h6";
            objASPLabelENEx.Text = string.Format("{0}列表", objViewInfoENEx.objMainPrjTab.TabCnName);

            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdFuncCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdFuncCol{0}", intCurrCol);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

            objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);
            intCurrCol++;
            foreach (clsFeatureRegionFldsEN objFeatureRegionFldsENEx in objViewInfoENEx.arrFeatureRegionFlds)
            {
                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdFuncCol{0}", intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdFuncCol{0}", intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

                objASPButtonENEx = new ASPButtonEx();
                objASPButtonENEx.AspControlId = string.Format("btn{0}", objFeatureRegionFldsENEx.ButtonName);
                objASPButtonENEx.AspControlName = string.Format("btn{0}", objFeatureRegionFldsENEx.ButtonName);

                objASPButtonENEx.Text = string.Format("{0}", objFeatureRegionFldsENEx.Text);
                objASPButtonENEx.CssClass = "ButtonDefa";
                objASPColENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
                intCurrCol++;
            }
            //

            return objASPHtmlTableENEx_Func;
        }
        public static ASPHtmlTableEx CreateQueryRegion(clsViewInfoENEx objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_Query = new ASPHtmlTableEx();
            objASPHtmlTableENEx_Query.AspControlId = "tabQueryRegion";
            objASPHtmlTableENEx_Query.AspControlName = "tabQueryRegion";

            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0 * 2;
            int intCurrRow = 1;
            int intCurrCol = 1;

            ASPRowEx objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trQryRow{0}", intCurrRow);
            objASPRowENEx.AspControlName = string.Format("trQryRow{0}", intCurrRow);
            objASPHtmlTableENEx_Query.arrSubAspControlLst2.Add(objASPRowENEx);
            ASPColEx objASPColENEx = null;
            ASPLabelEx objASPLabelENEx = null;
            ASPTextBoxEx objASPTextBoxENEx = null;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

                objASPLabelENEx = new ASPLabelEx();
                objASPLabelENEx.AspControlId = string.Format("lbl{0}", objQryRegionFldsEx.ObjFieldTabENEx.FldName);
                objASPLabelENEx.AspControlName = string.Format("lbl{0}", objQryRegionFldsEx.ObjFieldTabENEx.FldName);

                objASPLabelENEx.Text = string.Format("lbl{0}", objQryRegionFldsEx.ObjFieldTabENEx.Caption);
                objASPLabelENEx.CssClass = "LabelDefa";
                objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);

                intCurrCol++;

                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

                objASPTextBoxENEx = new ASPTextBoxEx();
                objASPTextBoxENEx.AspControlId = string.Format("txt{0}", objQryRegionFldsEx.ObjFieldTabENEx.FldName);
                objASPTextBoxENEx.AspControlName = string.Format("txt{0}", objQryRegionFldsEx.ObjFieldTabENEx.FldName);

                objASPTextBoxENEx.Text = "";
                objASPTextBoxENEx.CssClass = "TextBoxDefa";
                objASPColENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);


                intCurrCol++;

                if (intCurrCol > intColNum)
                {
                    intCurrRow++; intCurrCol = 1;
                    objASPRowENEx = new ASPRowEx();
                    objASPRowENEx.AspControlId = string.Format("trQryRow{0}", intCurrRow);
                    objASPRowENEx.AspControlName = string.Format("trQryRow{0}", intCurrRow);
                    objASPHtmlTableENEx_Query.arrSubAspControlLst2.Add(objASPRowENEx);

                }

            }
            if (intCurrCol == intColNum)
            {
                intCurrRow++; intCurrCol = 1;
            }
            bool bolIsAddQueryButton = false;
            while (intCurrCol <= intColNum)
            {
                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);
                if (bolIsAddQueryButton == false)
                {
                    ASPButtonEx objASPButtonENEx = new ASPButtonEx();
                    objASPButtonENEx.AspControlId = string.Format("btnQuery");
                    objASPButtonENEx.AspControlName = string.Format("btnQuery");

                    objASPButtonENEx.Text = "";
                    objASPButtonENEx.CssClass = "ButtonDefa";
                    objASPColENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
                    bolIsAddQueryButton = true;
                }
                intCurrCol++;
            }
            //

            return objASPHtmlTableENEx_Query;
        }

        public static ASPHtmlTableEx CreateDGRegion(clsViewInfoENEx objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_DG = new ASPHtmlTableEx();
            objASPHtmlTableENEx_DG.AspControlId = string.Format("tab{0}GridView", objViewInfoENEx.objMainPrjTab.TabName);
            objASPHtmlTableENEx_DG.AspControlName = string.Format("tab{0}GridView", objViewInfoENEx.objMainPrjTab.TabName);


            ASPRowEx objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trDGRow");
            objASPRowENEx.AspControlName = string.Format("trDGRow");
            objASPHtmlTableENEx_DG.arrSubAspControlLst2.Add(objASPRowENEx);


            ASPColEx objASPColENEx = null;

            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdDGCol");
            objASPColENEx.AspControlName = string.Format("tdDGCol");
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);



            ASPGridViewEx objASPGridViewENEx_DG = CreateGridView(objViewInfoENEx);
            objASPColENEx.arrSubAspControlLst2.Add(objASPGridViewENEx_DG);

            return objASPHtmlTableENEx_DG;
        }

        public static bool SetCmPrjIdBak20230301(string strViewId, string strPrjId, string strUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            //string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
            objViewInfo.SetPrjId(strPrjId)
                .SetUpdUserId(strUserId)
                .SetUpdDate(strCurrDate)
                .Update();
            var arrViewRegionRela = clsViewRegionRelaBLEx.GetObjLstByViewId(strViewId);
            foreach (var objInFor in arrViewRegionRela)
            {
                objInFor
                .SetPrjId(strPrjId)
                .SetUpdUser(strUserId)
                .SetUpdDate(strCurrDate)
                .Update();
            }
            var arrViewRegion = clsViewRegionBLEx.GetObjLstByViewId(strViewId);

            foreach (var objInFor in arrViewRegion)
            {
                clsViewRegionBLEx.SetCmPrjId(objInFor.RegionId, strPrjId, strUserId);
            }
            return true;
        }

        public static bool SetCmPrjId(string strViewId, string strCmPrjId, string strUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRela = new clsViewInfoCmPrjIdRelaEN();
            objViewInfoCmPrjIdRela.SetCmPrjId(strCmPrjId)
                .SetViewId(strViewId)
                .SetUpdUserId(strUserId)
                .SetUpdDate(strCurrDate);
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", 
                conViewInfoCmPrjIdRela.ViewId, strViewId,
                conViewInfoCmPrjIdRela.CmPrjId, strCmPrjId);
            if (clsViewInfoCmPrjIdRelaBL.IsExistRecord(strCondition) == false)
            {
                objViewInfoCmPrjIdRela.AddNewRecord();
            }
            else
            { 
                objViewInfoCmPrjIdRela          .UpdateWithCondition(strCondition);
            }
            var arrViewRegion = clsViewRegionBLEx.GetObjLstByViewId(strViewId);

            foreach (var objInFor in arrViewRegion)
            {
                clsViewRegionBLEx.SetCmPrjId(objInFor.RegionId, strCmPrjId, strUserId);
            }
            return true;
        }

        /// <summary>
        /// 绑定基于Web的下拉框 
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程Id</param>
        public static void BindDdl_ApplicationTypeIdExCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[应用程序类型]...", "0");

            var arrViewInfo = clsViewInfoBL.GetObjLstCache(strPrjId);
            var arrApplicationTypeId = arrViewInfo.Select(x => x.ApplicationTypeId).Distinct();
            List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLstCache()
                .Where(x => arrApplicationTypeId.Contains(x.ApplicationTypeId) && x.IsVisible == true)
                .OrderBy(x => x.VisitedNum)
                .ThenBy(x => x.OrderNum)
                .ToList();

            objDDL.DataValueField = conApplicationType.ApplicationTypeId;
            objDDL.DataTextField = conApplicationType.ApplicationTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 功能:获取某一条件的DataTable,其中的代码转换成相应的名称
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetViewInfoTEx(string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select * ");
            strSQL.Append(" from vViewInfo ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }

        public static System.Data.DataTable GetViewId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewId, ViewName from ViewInfo ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }


        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_ViewInfo(System.Windows.Forms.ListView lvViewInfo, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviViewInfo;
            List<clsViewInfoEN> arrViewInfoObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrViewInfoObjList = clsViewInfoBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvViewInfo.Items.Clear();//清除原来所有Item
            lvViewInfo.Columns.Clear();//清除原来所有列头信息
            lvViewInfo.Columns.Add("界面ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            //lvViewInfo.Columns.Add("界面类型码", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("应用程序类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("功能模块Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("主表关键字", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("明细表关键字", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("是否需要排序", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("是否需要转换代码", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("工程ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("界面功能", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("界面说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("缺省菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("明细表ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("文件路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("主表ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.Columns.Add("视图中文名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewInfo.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsViewInfoEN objViewInfo in arrViewInfoObjList)
            {
                lviViewInfo = new System.Windows.Forms.ListViewItem();
                lviViewInfo.Tag = objViewInfo.ViewId;
                lviViewInfo.Text = objViewInfo.ViewId;
                lviViewInfo.SubItems.Add(objViewInfo.ViewName);
                //lviViewInfo.SubItems.Add(objViewInfo.ViewTypeCode.ToString("00"));
                lviViewInfo.SubItems.Add(objViewInfo.ApplicationTypeId.ToString("00"));
                lviViewInfo.SubItems.Add(objViewInfo.FuncModuleAgcId);
                lviViewInfo.SubItems.Add(objViewInfo.DataBaseName);
                lviViewInfo.SubItems.Add(objViewInfo.KeyForMainTab);
                lviViewInfo.SubItems.Add(objViewInfo.KeyForDetailTab);
                lviViewInfo.SubItems.Add(objViewInfo.IsNeedSort.ToString());
                lviViewInfo.SubItems.Add(objViewInfo.IsNeedTransCode.ToString());
                lviViewInfo.SubItems.Add(objViewInfo.ViewFunction);
                lviViewInfo.SubItems.Add(objViewInfo.ViewDetail);
                lviViewInfo.SubItems.Add(objViewInfo.DefaMenuName);
                lviViewInfo.SubItems.Add(objViewInfo.DetailTabId);
                lviViewInfo.SubItems.Add(objViewInfo.FileName);
                lviViewInfo.SubItems.Add(objViewInfo.FilePath);
                lviViewInfo.SubItems.Add(objViewInfo.MainTabId);
                lviViewInfo.SubItems.Add(objViewInfo.ViewCnName);
                lvViewInfo.Items.Add(lviViewInfo);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrViewInfoObjList.Count;
        }


        ///// <summary>
        ///// 同步满足条件的界面信息到Server
        ///// </summary>
        ///// <param name="strCondition"></param>
        ///// <param name="strUserId"></param>
        ///// <returns></returns>
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

        //    //string strPrjId4Ag1c = "0013";
        //    //string strTabName4Set = "ViewInfo";
        //    //string strCondition4DataSyn = string.Format("PrjId='{0}' And TabName='{1}'", strPrjId4Agc, strTabName4Set);
        //    //string strViewId = clsViewInfoBL.GetFirstID_S(strCondition4DataSyn);

        //    //clsViewInfoEN objViewInfoEN = new clsViewInfoEN(strId_TransferCourses);
        //    ////objViewInfoEN.Id_TransferCourses
        //    //clsViewInfoBL.GetViewInfo(ref objViewInfoEN);
        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //    List<clsViewInfoEN> arrViewInfoENObjLst = clsViewInfoBL.GetObjLst(strCondition);

        //    foreach (clsViewInfoEN objViewInfoEN4Web in arrViewInfoENObjLst)
        //    {

        //        objViewInfoEN4Web.IsSynchToServer = true;
        //        objViewInfoEN4Web.SynchToServerDate = strCurrDate14;
        //        objViewInfoEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";
        //        //string strCondition2 = string.Format("id_Stu='{0}' And ScrTermSeq={1} And id_course='{2}' and id_scoretype='{3}'",
        //        // objViewInfoEN4Web.Id_TransferCourses,
        //        // objViewInfoEN4Web.ScrTermSeq,
        //        // objViewInfoEN4Web.id_Course,
        //        // objViewInfoEN4Web.id_ScoreType);
        //        try
        //        {
        //            clsViewInfoEN objViewInfoEN4Web2 = new clsViewInfoEN();
        //            clsViewInfoBL.CopyTo(objViewInfoEN4Web, objViewInfoEN4Web2);
        //            objViewInfoEN4Web2.SynSource = "Client";
        //            clsViewInfoEN objViewInfo_Target = clsViewInfoBL.GetObjByViewId(objViewInfoEN4Web.ViewId);

        //            if (objViewInfo_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objViewInfo_Target.UpdDate.CompareTo(objViewInfoEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsViewInfoBL.UpdateBySql2(objViewInfoEN4Web2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsViewInfoBL.AddNewRecordBySql2(objViewInfoEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsViewInfoBL.UpdateBySql2(objViewInfoEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objViewInfoEN4Web.ViewId,
        //                        objViewInfoEN4Web.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        /// <summary>
        /// 同步满足条件的学生信息到Client
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
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

        //    //string strPrjId4Ag1c = "0013";
        //    //string strTabName4Set = "ViewInfo";
        //    //string strCondition4DataSyn = string.Format("{0}='{1}' And {2}='{3}'", 
        //    //    conViewInfo.PrjId,
        //    //    strPrjId4Agc, 
        //    //    conViewInfo.ViewName,
        //    //    strTabName4Set);
        //    //string strViewId = clsViewInfoBL.GetFirstID_S(strCondition4DataSyn);

        //    //clsViewInfoEN objViewInfoEN = new clsViewInfoEN(strId_TransferCourses);
        //    ////objViewInfoEN.Id_TransferCourses
        //    //clsViewInfoBL.GetViewInfo(ref objViewInfoEN);
        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsViewInfoEN> arrViewInfoENObjLst = clsViewInfoBL.GetObjLst(strCondition);

        //    foreach (clsViewInfoEN objViewInfoEN4Main in arrViewInfoENObjLst)
        //    {

        //        objViewInfoEN4Main.IsSynchToClient = true;
        //        objViewInfoEN4Main.SynchToClientDate = strCurrDate14;
        //        objViewInfoEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        //string strCondition2 = string.Format("id_Stu='{0}' And ScrTermSeq={1} And id_course='{2}' and id_scoretype='{3}'",
        //        // objViewInfoEN4Web.Id_TransferCourses,
        //        // objViewInfoEN4Web.ScrTermSeq,
        //        // objViewInfoEN4Web.id_Course,
        //        // objViewInfoEN4Web.id_ScoreType);
        //        try
        //        {
        //            clsViewInfoEN objViewInfoEN4Main2 = new clsViewInfoEN();
        //            clsViewInfoBL.CopyTo(objViewInfoEN4Main, objViewInfoEN4Main2);
        //            objViewInfoEN4Main2.SynSource = "Server";
        //            clsViewInfoEN objViewInfo_Target = clsViewInfoBL.GetObjByViewId(objViewInfoEN4Main.ViewId);

        //            if (objViewInfo_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objViewInfo_Target.UpdDate.CompareTo(objViewInfoEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsViewInfoBL.UpdateBySql2(objViewInfoEN4Main2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsViewInfoBL.AddNewRecordBySql2(objViewInfoEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsViewInfoBL.UpdateBySql2(objViewInfoEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objViewInfoEN4Main.ViewId,
        //                        objViewInfoEN4Main.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}
        public static int SynchInfoFromPrjTab(string strPrjId)
        {
            string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

            var strCondition = $"PrjId='{strPrjId}'";
            List<clsViewInfoEN> arrViewInfoENObjLst = clsViewInfoBL.GetObjLst(strCondition);
            var intCount = 0;
            foreach (clsViewInfoEN objViewInfoEN in arrViewInfoENObjLst)
            {
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoEN.MainTabId, strPrjId);
                if (objPrjTab == null) continue;
                if (objViewInfoEN.FuncModuleAgcId == objPrjTab.FuncModuleAgcId &&
                                objViewInfoEN.IsShare == objPrjTab.IsShare) continue;

                objViewInfoEN.FuncModuleAgcId = objPrjTab.FuncModuleAgcId;
                objViewInfoEN.IsShare = objPrjTab.IsShare;
                objViewInfoEN.UpdDate = strCurrDate14;
                clsViewInfoBL.UpdateBySql2(objViewInfoEN);
                intCount++;
            }
            return intCount;
        }
    }
}
