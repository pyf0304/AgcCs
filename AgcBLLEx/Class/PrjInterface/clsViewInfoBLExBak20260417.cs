using AGC.BusinessLogic;
using AGC.DAL;
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
using static AGC.Entity.CopyTaskStatusResultDto;
//using AGC.PureClassEx;

namespace AGC.BusinessLogicEx
{
    

    public static class clsViewInfoBLEx_StaticBak260417
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
    public partial class clsViewInfoBLExBak260417 : clsViewInfoBL
    {
        public static string strPrjIdCache_Init = "";
        public clsViewInfoBLExBak260417()
        {
        }
        public clsViewInfoBLExBak260417(string strViewId)
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

            if (objViewInfoENEx.arrQryRegionFldSet4InUse != null)
            {
                //获取下拉框对象列表
                IEnumerable<clsQryRegionFldsENEx> arrQRF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
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
                clsFeatureRegionFldsEN._CurrTabName, conViewRegionRela.RegionId,
                clsViewRegionRelaEN._CurrTabName, conViewRegionRela.ViewId, strViewId);

            strSQL = strSQL + string.Format("Delete from {0} where {1} in (Select {1} From {2} where {3}= '{4}');",
                clsFeatureRegionFldsEN._CurrTabName, conViewRegionRela.RegionId, clsViewRegionRelaEN._CurrTabName, conViewRegionRela.ViewId, strViewId);
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
                string strErrMsg = objException.Message;
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


            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet4InUse)
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
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet4InUse)
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
                objViewInfoCmPrjIdRela.UpdateWithCondition(strCondition);
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
        //    //string strCondition4DataSyn = string.Format("{0}='{1}' And {2}='{3}'", 
        //    //    conViewInfo.PrjId,
        //    //    strPrjId4Agc, 
        //    //    conViewInfo.ViewName,
        //    //    strTabName4Set);
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
        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //    List<clsViewInfoEN> arrViewInfoENObjLst = clsViewInfoBL.GetObjLst(strCondition);

        //    foreach (clsViewInfoEN objViewInfoEN4Main in arrViewInfoENObjLst)
        //    {

        //        objViewInfoEN4Main.IsSynchToClient = true;
        //        objViewInfoEN4Main.SynchToClientDate = strCurrDate14;
        //        objViewInfoEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";
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

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsViewInfoBL.UpdateBySql2(objViewInfoEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Client库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objViewInfoEN4Main.ViewId,
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
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoEN.MainTabId, objViewInfoEN.PrjId);
                if (objPrjTab == null) continue;
                if (objViewInfoEN.FuncModuleAgcId == objPrjTab.FuncModuleAgcId &&
                                objViewInfoEN.IsShare == objPrjTab.IsShare) continue;

                objViewInfoEN.FuncModuleAgcId = objPrjTab.FuncModuleAgcId;
                objViewInfoEN.IsShare = objPrjTab.IsShare;
                objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsViewInfoBL.UpdateBySql2(objViewInfoEN);
                intCount++;
            }
            return intCount;
        }


        /// <summary>
        /// 执行复制任务（真正的复制逻辑，支持断点续传）
        /// </summary>
        public static ExecuteCopyTaskResultDto ExecuteCopyTaskBak(long lngTaskId)
        {
            ExecuteCopyTaskResultDto result = new ExecuteCopyTaskResultDto();

            try
            {
                // 1、读取任务头
                clsCopyTaskEN objTask = GetCopyTask(lngTaskId);
                if (objTask == null)
                {
                    result.success = false;
                    result.message = "任务不存在";
                    return result;
                }

                // 校验任务状态
                if (objTask.Status == "Success")
                {
                    result.success = true;
                    result.message = "任务已完成";
                    result.targetViewId = objTask.TargetViewId;
                    result.targetViewName = objTask.TargetViewName;
                    return result;
                }

                if (objTask.Status == "Canceled")
                {
                    result.success = false;
                    result.message = "任务已取消";
                    return result;
                }

                // 校验源界面和目标工程
                clsViewInfoEN objSouViewInfo = clsViewInfoBL.GetObjByViewId(objTask.SourceViewId);
                if (objSouViewInfo == null)
                {
                    UpdateTask(lngTaskId, "Failed", "Validate", "源界面不存在");
                    result.success = false;
                    result.message = "源界面不存在";
                    return result;
                }

                clsProjectsEN objTarProject = clsProjectsBL.GetObjByPrjId(objTask.TargetPrjId);
                if (objTarProject == null)
                {
                    UpdateTask(lngTaskId, "Failed", "Validate", "目标工程不存在");
                    result.success = false;
                    result.message = "目标工程不存在";
                    return result;
                }

                // 2、读取任务明细（按 StepOrder 排序）
                List<clsCopyTaskRegionEN> arrDetails = GetCopyTaskRegions(lngTaskId);
                if (arrDetails == null || arrDetails.Count == 0)
                {
                    UpdateTask(lngTaskId, "Failed", "Init", "任务明细不存在");
                    result.success = false;
                    result.message = "任务明细不存在";
                    return result;
                }

                // 3、把任务头标记为运行中
                UpdateTask(lngTaskId, "Running", "CopyRegions", "");

                // 4、执行区域复制（只处理 Pending 和 Failed 的区域）
                foreach (clsCopyTaskRegionEN objDetail in arrDetails)
                {
                    // 跳过已成功或已复用的区域
                    if (objDetail.CopyStatus == "Success" || objDetail.CopyStatus == "Reused")
                    {
                        continue;
                    }

                    try
                    {
                        // 解析或复制区域
                        string strTargetRegionId = ResolveOrCopyRegion(objTask, objDetail);

                        // 更新区域复制结果
                        string strCopyStatus = objDetail.CopyStatus == "Reused" ? "Reused" : "Success";
                        UpdateTaskRegionCopyResult(lngTaskId, objDetail.SourceRegionId, strTargetRegionId, strCopyStatus, "");

                        objDetail.TargetRegionId = strTargetRegionId;
                        objDetail.CopyStatus = strCopyStatus;
                    }
                    catch (Exception exRegion)
                    {
                        // 更新该区域为失败
                        string strErrorMsg = string.Format("复制区域失败:[{0}]，错误:{1}", objDetail.SourceClsName, exRegion.Message);
                        UpdateTaskRegionCopyResult(lngTaskId, objDetail.SourceRegionId, "", "Failed", strErrorMsg);

                        // 更新任务头为失败
                        UpdateTask(lngTaskId, "Failed", "CopyRegions", strErrorMsg);

                        result.success = false;
                        result.message = strErrorMsg;
                        return result;
                    }
                }

                // 5、执行界面复制
                UpdateTaskStep(lngTaskId, "CopyView");

                if (string.IsNullOrEmpty(objTask.TargetViewId))
                {
                    try
                    {
                        string strNewViewId = "";
                        string strNewViewName = "";
                        CopyViewCore(objTask, objSouViewInfo, out strNewViewId, out strNewViewName);

                        // 更新任务头的目标界面信息
                        UpdateTaskTargetView(lngTaskId, strNewViewId, strNewViewName);

                        objTask.TargetViewId = strNewViewId;
                        objTask.TargetViewName = strNewViewName;
                    }
                    catch (Exception exView)
                    {
                        string strErrorMsg = string.Format("复制界面失败，错误:{0}", exView.Message);
                        UpdateTask(lngTaskId, "Failed", "CopyView", strErrorMsg);

                        result.success = false;
                        result.message = strErrorMsg;
                        return result;
                    }
                }

                // 6、执行关系绑定（只处理 Pending 和 Failed 的关系）
                UpdateTaskStep(lngTaskId, "BindRelations");

                foreach (clsCopyTaskRegionEN objDetail in arrDetails)
                {
                    // 跳过已成功的关系
                    if (objDetail.RelationStatus == "Success")
                    {
                        continue;
                    }

                    try
                    {
                        // 建立界面与区域关系
                        BindViewRegion(objTask.TargetViewId, objDetail.TargetRegionId, objTask.TargetPrjId, objTask.CreatedBy);

                        // 更新关系状态
                        UpdateTaskRegionRelationResult(lngTaskId, objDetail.SourceRegionId, "Success", "");

                        objDetail.RelationStatus = "Success";
                    }
                    catch (Exception exRelation)
                    {
                        string strErrorMsg = string.Format("绑定关系失败:[{0}]，错误:{1}", objDetail.SourceClsName, exRelation.Message);
                        UpdateTaskRegionRelationResult(lngTaskId, objDetail.SourceRegionId, "Failed", strErrorMsg);

                        // 更新任务头为失败
                        UpdateTask(lngTaskId, "Failed", "BindRelations", strErrorMsg);

                        result.success = false;
                        result.message = strErrorMsg;
                        return result;
                    }
                }

                // 7、全部完成后更新任务头
                UpdateTask(lngTaskId, "Success", "Done", "");

                // 8、返回成功结果
                result.errorId = 0;
                result.success = true;
                result.message = "复制成功";
                result.targetViewId = objTask.TargetViewId;
                result.targetViewName = objTask.TargetViewName;
                result.totalRegions = arrDetails.Count;
                result.completedRegions = arrDetails.FindAll(d => d.CopyStatus == "Success" || d.CopyStatus == "Reused").Count;
                result.failedRegions = arrDetails.FindAll(d => d.CopyStatus == "Failed").Count;
                result.regionStatuses = ConvertToRegionStatusList(arrDetails);

                string strSuccessLog = string.Format("执行复制任务成功，TaskId:[{0}]，TargetViewId:[{1}]",
                    lngTaskId, objTask.TargetViewId);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strSuccessLog);

                return result;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行复制任务失败，TaskId:[{0}]，错误:{1}.(in {2})",
                    lngTaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

                UpdateTask(lngTaskId, "Failed", "Error", strMsg);

                result.success = false;
                result.message = strMsg;
                return result;
            }
        }

        /// <summary>
        /// 执行复制任务（真正的复制逻辑，支持断点续传）
        /// </summary>
        public static ExecuteCopyTaskResultDto ExecuteCopyTask(long lngTaskId)
        {
            ExecuteCopyTaskResultDto result = new ExecuteCopyTaskResultDto();

            try
            {
                // 1、读取任务头
                clsCopyTaskEN objTask = GetCopyTask(lngTaskId);
                if (objTask == null)
                {
                    result.success = false;
                    result.message = "任务不存在";
                    return result;
                }

                // 校验任务状态
                if (objTask.Status == "Success")
                {
                    result.success = true;
                    result.message = "任务已完成";
                    result.targetViewId = objTask.TargetViewId;
                    result.targetViewName = "";
                    return result;
                }

                if (objTask.Status == "Canceled")
                {
                    result.success = false;
                    result.message = "任务已取消";
                    return result;
                }

                // 校验源界面和目标工程
                clsViewInfoEN objSouViewInfo = clsViewInfoBL.GetObjByViewId(objTask.SourceViewId);
                if (objSouViewInfo == null)
                {
                    UpdateTask(lngTaskId, "Failed", "Validate", "源界面不存在");
                    result.success = false;
                    result.message = "源界面不存在";
                    return result;
                }

                clsProjectsEN objTarProject = clsProjectsBL.GetObjByPrjId(objTask.TargetPrjId);
                if (objTarProject == null)
                {
                    UpdateTask(lngTaskId, "Failed", "Validate", "目标工程不存在");
                    result.success = false;
                    result.message = "目标工程不存在";
                    return result;
                }

                // 2、【关键】先补全缺失的区域记录
                EnsureAllRegionsInTask(lngTaskId, objTask.SourceViewId);

                // 3、读取任务明细（按 StepOrder 排序）
                List<clsCopyTaskRegionEN> arrDetails = GetCopyTaskRegions(lngTaskId);
                if (arrDetails == null || arrDetails.Count == 0)
                {
                    UpdateTask(lngTaskId, "Failed", "Init", "任务明细不存在");
                    result.success = false;
                    result.message = "任务明细不存在";
                    return result;
                }

                // 4、把任务头标记为运行中
                UpdateTask(lngTaskId, "Running", "CopyRegions", "");

                // 5、执行区域复制（只处理 Pending 和 Failed 的区域）
                foreach (clsCopyTaskRegionEN objDetail in arrDetails)
                {
                    // 跳过已成功或已复用的区域
                    if (objDetail.CopyStatus == "Success" || objDetail.CopyStatus == "Reused")
                    {
                        continue;
                    }

                    try
                    {
                        // 解析或复制区域
                        string strTargetRegionId = ResolveOrCopyRegion(objTask, objDetail);

                        // 更新区域复制结果
                        string strCopyStatus = objDetail.CopyStatus == "Reused" ? "Reused" : "Success";
                        UpdateTaskRegionCopyResult(lngTaskId, objDetail.SourceRegionId, strTargetRegionId, strCopyStatus, "");

                        objDetail.TargetRegionId = strTargetRegionId;
                        objDetail.CopyStatus = strCopyStatus;
                    }
                    catch (Exception exRegion)
                    {
                        // 更新该区域为失败
                        string strErrorMsg = string.Format("复制区域失败:[{0}]，错误:{1}", objDetail.SourceClsName, exRegion.Message);
                        UpdateTaskRegionCopyResult(lngTaskId, objDetail.SourceRegionId, "", "Failed", strErrorMsg);

                        // 更新任务头为失败
                        UpdateTask(lngTaskId, "Failed", "CopyRegions", strErrorMsg);

                        result.success = false;
                        result.message = strErrorMsg;
                        return result;
                    }
                }

                // 6、执行界面复制
                UpdateTaskStep(lngTaskId, "CopyView");

                if (string.IsNullOrEmpty(objTask.TargetViewId))
                {
                    try
                    {
                        string strNewViewId = "";
                        string strNewViewName = "";
                        CopyViewCore(objTask, objSouViewInfo, out strNewViewId, out strNewViewName);

                        // 更新任务头的目标界面信息
                        UpdateTaskTargetView(lngTaskId, strNewViewId, strNewViewName);

                        objTask.TargetViewId = strNewViewId;
                    }
                    catch (Exception exView)
                    {
                        string strErrorMsg = string.Format("复制界面失败，错误:{0}", exView.Message);
                        UpdateTask(lngTaskId, "Failed", "CopyView", strErrorMsg);

                        result.success = false;
                        result.message = strErrorMsg;
                        return result;
                    }
                }

                // 7、执行关系绑定（只处理 Pending 和 Failed 的关系）
                UpdateTaskStep(lngTaskId, "BindRelations");

                foreach (clsCopyTaskRegionEN objDetail in arrDetails)
                {
                    // 跳过已成功的关系
                    if (objDetail.RelationStatus == "Success")
                    {
                        continue;
                    }

                    try
                    {
                        // 建立界面与区域关系
                        BindViewRegion(objTask.TargetViewId, objDetail.TargetRegionId, objTask.TargetPrjId, objTask.CreatedBy);

                        // 更新关系状态
                        UpdateTaskRegionRelationResult(lngTaskId, objDetail.SourceRegionId, "Success", "");

                        objDetail.RelationStatus = "Success";
                    }
                    catch (Exception exRelation)
                    {
                        string strErrorMsg = string.Format("绑定关系失败:[{0}]，错误:{1}", objDetail.SourceClsName, exRelation.Message);
                        UpdateTaskRegionRelationResult(lngTaskId, objDetail.SourceRegionId, "Failed", strErrorMsg);

                        // 更新任务头为失败
                        UpdateTask(lngTaskId, "Failed", "BindRelations", strErrorMsg);

                        result.success = false;
                        result.message = strErrorMsg;
                        return result;
                    }
                }

                // 8、全部完成后更新任务头
                UpdateTask(lngTaskId, "Success", "Done", "");

                // 9、返回成功结果
                result.success = true;
                result.message = "复制成功";
                result.targetViewId = objTask.TargetViewId;
                result.totalRegions = arrDetails.Count;
                result.completedRegions = arrDetails.FindAll(d => d.CopyStatus == "Success" || d.CopyStatus == "Reused").Count;
                result.failedRegions = arrDetails.FindAll(d => d.CopyStatus == "Failed").Count;
                result.regionStatuses = ConvertToRegionStatusList(arrDetails);

                string strSuccessLog = string.Format("执行复制任务成功，TaskId:[{0}]，TargetViewId:[{1}]",
                    lngTaskId, objTask.TargetViewId);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strSuccessLog);

                return result;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行复制任务失败，TaskId:[{0}]，错误:{1}.(in {2})",
                    lngTaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

                UpdateTask(lngTaskId, "Failed", "Error", strMsg);

                result.success = false;
                result.message = strMsg;
                return result;
            }
        }

        /// <summary>
        /// 确保所有源区域都在任务表中（补全缺失的区域记录）
        /// </summary>
        private static void EnsureAllRegionsInTask(long lngTaskId, string strSouViewId)
        {
            try
            {
                // 1、查询源界面的所有区域
                string strRegionCondition = string.Format("ViewId = '{0}'", strSouViewId);
                List<clsViewRegionRelaEN> arrSouRegionRelaLst = clsViewRegionRelaBL.GetObjLst(strRegionCondition);

                if (arrSouRegionRelaLst == null || arrSouRegionRelaLst.Count == 0)
                {
                    return;
                }

                // 2、查询已有的任务区域记录
                string strTaskRegionCondition = string.Format("TaskId = '{0}'", lngTaskId);
                List<clsCopyTaskRegionEN> arrExistingTaskRegions = clsCopyTaskRegionBL.GetObjLst(strTaskRegionCondition);

                // 创建已存在区域的字典（用于快速查找）
                Dictionary<string, bool> dictExistingRegions = new Dictionary<string, bool>();
                int intMaxStepOrder = 0;

                if (arrExistingTaskRegions != null)
                {
                    foreach (clsCopyTaskRegionEN objExisting in arrExistingTaskRegions)
                    {
                        dictExistingRegions[objExisting.SourceRegionId] = true;
                        if (objExisting.StepOrder > intMaxStepOrder)
                        {
                            intMaxStepOrder = objExisting.StepOrder;
                        }
                    }
                }

                // 3、补全缺失的区域
                int intStepOrder = intMaxStepOrder + 1;
                foreach (clsViewRegionRelaEN objSouRegionRela in arrSouRegionRelaLst)
                {
                    clsViewRegionEN objSouRegion = clsViewRegionBL.GetObjByRegionId(objSouRegionRela.RegionId);
                    if (objSouRegion == null) continue;

                    // 检查是否已存在
                    if (dictExistingRegions.ContainsKey(objSouRegion.RegionId))
                    {
                        continue; // 已存在，跳过
                    }

                    // 插入缺失的区域记录
                    clsCopyTaskRegionEN objTaskRegion = new clsCopyTaskRegionEN();
                    objTaskRegion.TaskId = lngTaskId;
                    objTaskRegion.SourceRegionId = objSouRegion.RegionId;
                    objTaskRegion.SourceClsName = objSouRegion.ClsName;
                    objTaskRegion.TargetRegionId = "";
                    objTaskRegion.CopyStatus = "Pending";
                    objTaskRegion.RelationStatus = "Pending";
                    objTaskRegion.ErrorMessage = "";
                    objTaskRegion.StepOrder = intStepOrder;
                    objTaskRegion.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

                    clsCopyTaskRegionBL.AddNewRecordBySql2(objTaskRegion);

                    string strLog = string.Format("补全缺失区域，TaskId:[{0}]，RegionId:[{1}]，ClsName:[{2}]，StepOrder:[{3}]",
                        lngTaskId, objSouRegion.RegionId, objSouRegion.ClsName, intStepOrder);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                    intStepOrder++;
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("补全缺失区域失败，TaskId:[{0}]，错误:{1}", lngTaskId, ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 查询复制任务状态（只查询，不修改数据）
        /// </summary>
        public static GetCopyTaskStatusResultDto GetCopyTaskStatus(long lngTaskId)
        {
            GetCopyTaskStatusResultDto result = new GetCopyTaskStatusResultDto();

            try
            {
                // 1、查任务头
                clsCopyTaskEN objTask = GetCopyTask(lngTaskId);
                if (objTask == null)
                {
                    result.status = "Failed";
                    result.message = "任务不存在";
                    return result;
                }

                // 2、查任务明细（按 StepOrder 排序）
                List<clsCopyTaskRegionEN> arrDetails = GetCopyTaskRegions(lngTaskId);

                // 3、如果有目标界面，补界面名称
                string strTargetViewName = "";
                if (!string.IsNullOrEmpty(objTask.TargetViewId))
                {
                    clsViewInfoEN objTargetView = clsViewInfoBL.GetObjByViewId(objTask.TargetViewId);
                    if (objTargetView != null)
                    {
                        strTargetViewName = objTargetView.ViewName;
                    }
                }

                // 4、组装返回对象
                result.taskId = lngTaskId;
                result.status = objTask.Status;
                result.currentStep = objTask.CurrentStep;
                result.message = objTask.ErrorMessage ?? "";
                result.targetViewId = objTask.TargetViewId ?? "";
                result.targetViewName = strTargetViewName;

                if (arrDetails != null && arrDetails.Count > 0)
                {
                    result.totalRegions = arrDetails.Count;
                    result.completedRegions = arrDetails.FindAll(d => d.CopyStatus == "Success" || d.CopyStatus == "Reused").Count;
                    result.failedRegions = arrDetails.FindAll(d => d.CopyStatus == "Failed").Count;
                    result.relationCompletedCount = arrDetails.FindAll(d => d.RelationStatus == "Success").Count;
                    result.regionStatuses = ConvertToRegionStatusList(arrDetails);
                }
                else
                {
                    result.totalRegions = 0;
                    result.completedRegions = 0;
                    result.failedRegions = 0;
                    result.relationCompletedCount = 0;
                    result.regionStatuses = new List<CopyRegionStatusDto>();
                }

                return result;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("查询任务状态失败，TaskId:[{0}]，错误:{1}.(in {2})",
                    lngTaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

                result.status = "Failed";
                result.message = strMsg;
                return result;
            }
        }

        /// <summary>
        /// 解析或复制区域（按唯一键查找，存在则复用，不存在则复制）
        /// </summary>
        private static string ResolveOrCopyRegionBak2(clsCopyTaskEN objTask, clsCopyTaskRegionEN objDetail)
        {
            try
            {
                // 获取源区域
                clsViewRegionEN objSouRegion = clsViewRegionBL.GetObjByRegionId(objDetail.SourceRegionId);
                if (objSouRegion == null)
                {
                    throw new Exception(string.Format("源区域不存在，RegionId:[{0}]", objDetail.SourceRegionId));
                }

                // 按唯一键 (PrjId, ClsName) 查找目标工程中是否已有对应区域
                string strCheckCond = string.Format("PrjId = '{0}' AND ClsName = '{1}'",
                    objTask.TargetPrjId, objSouRegion.ClsName);

                if (clsViewRegionBL.IsExistRecord(strCheckCond))
                {
                    // 复用现有区域
                    string strExistingRegionId = clsViewRegionBL.GetFirstID_S(strCheckCond);
                    objDetail.CopyStatus = "Reused";

                    string strLog = string.Format("复用现有区域，RegionId:[{0}]，ClsName:[{1}]",
                        strExistingRegionId, objSouRegion.ClsName);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                    return strExistingRegionId;
                }
                else
                {
                    // 复制新区域
                    string strNewRegionId = clsViewRegionBL.GetMaxStrId_S();
                    clsViewRegionEN objNewRegion = new clsViewRegionEN(strNewRegionId);

                    clsViewRegionBL.CopyTo(objSouRegion, objNewRegion);
                    objNewRegion.RegionId = strNewRegionId;
                    objNewRegion.PrjId = objTask.TargetPrjId;
                    objNewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objNewRegion.UpdUser = objTask.CreatedBy;

                    // 映射区域的 TabId（按表名映射）
                    if (!string.IsNullOrEmpty(objSouRegion.TabId))
                    {
                        string strTargetTabId = MapTabByName(objSouRegion.TabId, objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy);
                        objNewRegion.TabId = strTargetTabId;
                    }

                    if (!clsViewRegionBL.AddNewRecordBySql2(objNewRegion))
                    {
                        throw new Exception("添加区域记录失败");
                    }

                    // 复制区域字段
                    CopyRegionFields(objSouRegion.RegionId, strNewRegionId, objSouRegion.RegionTypeId,
                        objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy);

                    string strLog = string.Format("创建新区域成功，RegionId:[{0}]，ClsName:[{1}]",
                        strNewRegionId, objSouRegion.ClsName);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                    return strNewRegionId;
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("解析或复制区域失败，SourceRegionId:[{0}]，错误:{1}",
                    objDetail.SourceRegionId, ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        private static string ResolveOrCopyRegionBak(clsCopyTaskEN objTask, clsCopyTaskRegionEN objDetail)
        {
            try
            {
                // 获取源区域
                clsViewRegionEN objSouRegion = clsViewRegionBL.GetObjByRegionId(objDetail.SourceRegionId);
                if (objSouRegion == null)
                {
                    throw new Exception(string.Format("源区域不存在，RegionId:[{0}]", objDetail.SourceRegionId));
                }

                // 按唯一键 (PrjId, ClsName) 查找目标工程中是否已有对应区域
                string strCheckCond = string.Format("PrjId = '{0}' AND ClsName = '{1}'",
                    objTask.TargetPrjId, objSouRegion.ClsName);

                if (clsViewRegionBL.IsExistRecord(strCheckCond))
                {
                    // 复用现有区域
                    string strExistingRegionId = clsViewRegionBL.GetFirstID_S(strCheckCond);
                    objDetail.CopyStatus = "Reused";

                    string strLog = string.Format("复用现有区域，RegionId:[{0}]，ClsName:[{1}]",
                        strExistingRegionId, objSouRegion.ClsName);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                    return strExistingRegionId;
                }
                else
                {
                    // 复制新区域
                    string strNewRegionId = clsViewRegionBL.GetMaxStrId_S();
                    clsViewRegionEN objNewRegion = new clsViewRegionEN(strNewRegionId);

                    clsViewRegionBL.CopyTo(objSouRegion, objNewRegion);
                    objNewRegion.RegionId = strNewRegionId;
                    objNewRegion.PrjId = objTask.TargetPrjId;
                    objNewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objNewRegion.UpdUser = objTask.CreatedBy;

                    // 映射区域的 TabId（按表名映射）
                    if (!string.IsNullOrEmpty(objSouRegion.TabId))
                    {
                        string strTargetTabId = MapTabByName(objSouRegion.TabId, objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy);
                        objNewRegion.TabId = strTargetTabId;
                    }

                    if (!clsViewRegionBL.AddNewRecordBySql2(objNewRegion))
                    {
                        throw new Exception("添加区域记录失败");
                    }

                    // 复制区域字段
                    CopyRegionFields(objSouRegion.RegionId, strNewRegionId, objSouRegion.RegionTypeId,
                        objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy);

                    string strLog = string.Format("创建新区域成功，RegionId:[{0}]，ClsName:[{1}]",
                        strNewRegionId, objSouRegion.ClsName);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                    return strNewRegionId;
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("解析或复制区域失败，SourceRegionId:[{0}]，错误:{1}",
                    objDetail.SourceRegionId, ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 复制界面核心逻辑
        /// </summary>
        private static void CopyViewCore(clsCopyTaskEN objTask, clsViewInfoEN objSouViewInfo,
            out string strNewViewId, out string strNewViewName)
        {
            strNewViewId = "";
            strNewViewName = "";

            try
            {
                // 构建表映射
                Dictionary<string, string> dictTabMapping = new Dictionary<string, string>();
                string strMappingError = "";
                if (!BuildTabMapping(objSouViewInfo, objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy,
                    dictTabMapping, out strMappingError))
                {
                    throw new Exception(strMappingError);
                }

                // 处理界面重名冲突
                strNewViewName = objSouViewInfo.ViewName;
                string strCheckCondition = string.Format("PrjId = '{0}' AND ViewName = '{1}'",
                    objTask.TargetPrjId, objSouViewInfo.ViewName);

                if (clsViewInfoBL.IsExistRecord(strCheckCondition))
                {
                    switch (objTask.ConflictStrategy.ToLower())
                    {
                        case "skip":
                            throw new Exception(string.Format("跳过：目标工程中已存在同名界面 [{0}]", objSouViewInfo.ViewName));

                        case "overwrite":
                            string strExistingViewId = clsViewInfoBL.GetFirstID_S(strCheckCondition);
                            if (!DeleteViewWithRelations(strExistingViewId, objTask.TargetPrjId, objTask.CreatedBy))
                            {
                                throw new Exception("删除目标工程同名界面失败");
                            }
                            break;

                        case "rename":
                            strNewViewName = GenerateUniqueViewName(objTask.TargetPrjId, objSouViewInfo.ViewName);
                            break;
                    }
                }

                // 创建新界面
                strNewViewId = clsGeneralTab.GetMaxStrId("ViewInfo", "ViewId", 8, objTask.TargetPrjId);
                clsViewInfoEN objNewViewInfo = new clsViewInfoEN(strNewViewId);

                CopyViewInfoProperties(objSouViewInfo, objNewViewInfo, strNewViewId, objTask.TargetPrjId,
                    strNewViewName, objTask.CreatedBy, dictTabMapping);

                if (!clsViewInfoBL.AddNewRecordBySql2(objNewViewInfo))
                {
                    throw new Exception("添加界面记录失败");
                }

                // 复制界面样式
                CopyViewStyle(objSouViewInfo.ViewId, strNewViewId, objTask.CreatedBy);

                string strLog = string.Format("复制界面成功，ViewId:[{0}]，ViewName:[{1}]", strNewViewId, strNewViewName);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("复制界面核心逻辑失败，错误:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 绑定界面与区域关系
        /// </summary>
        private static void BindViewRegion(string strViewId, string strRegionId, string strPrjId, string strUserId)
        {
            try
            {
                // 检查关系是否已存在
                string strCheckCond = string.Format("ViewId = '{0}' AND RegionId = '{1}'", strViewId, strRegionId);
                if (clsViewRegionRelaBL.IsExistRecord(strCheckCond))
                {
                    // 关系已存在，跳过
                    return;
                }

                // 创建新关系
                clsViewRegionRelaEN objNewRela = new clsViewRegionRelaEN();
                objNewRela.ViewId = strViewId;
                objNewRela.RegionId = strRegionId;
                objNewRela.PrjId = strPrjId;
                objNewRela.InUse = true;
                objNewRela.IsDisp = true;
                objNewRela.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewRela.UpdUser = strUserId;

                if (!clsViewRegionRelaBL.AddNewRecordBySql2(objNewRela))
                {
                    throw new Exception("添加界面区域关系失败");
                }

                string strLog = string.Format("绑定界面区域关系成功，ViewId:[{0}]，RegionId:[{1}]", strViewId, strRegionId);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("绑定界面区域关系失败，错误:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 转换为区域状态列表
        /// </summary>
        private static List<CopyRegionStatusDto> ConvertToRegionStatusList(List<clsCopyTaskRegionEN> arrDetails)
        {
            List<CopyRegionStatusDto> regionStatuses = new List<CopyRegionStatusDto>();

            foreach (clsCopyTaskRegionEN objDetail in arrDetails)
            {
                CopyRegionStatusDto status = new CopyRegionStatusDto();
                status.sourceRegionId = objDetail.SourceRegionId;
                status.clsName = objDetail.SourceClsName;
                status.targetRegionId = objDetail.TargetRegionId;
                status.copyStatus = objDetail.CopyStatus;
                status.relationStatus = objDetail.RelationStatus;
                status.errorMessage = objDetail.ErrorMessage ?? "";

                regionStatuses.Add(status);
            }

            return regionStatuses;
        }

        /// <summary>
        /// 获取复制任务（从数据库）
        /// </summary>
        private static clsCopyTaskEN GetCopyTask(long lngTaskId)
        {
            try
            {
                clsCopyTaskEN objCopyTaskEN = clsCopyTaskBL.GetObjByTaskId(lngTaskId);
                if (objCopyTaskEN == null) return null;

                clsCopyTaskEN objTask = new clsCopyTaskEN();
                objTask.TaskId = objCopyTaskEN.TaskId;
                objTask.SourcePrjId = objCopyTaskEN.SourcePrjId;
                objTask.TargetPrjId = objCopyTaskEN.TargetPrjId;
                objTask.SourceViewId = objCopyTaskEN.SourceViewId;
                objTask.TargetViewId = objCopyTaskEN.TargetViewId;
                objTask.TargetViewName = objCopyTaskEN.TargetViewName;
                objTask.ConflictStrategy = objCopyTaskEN.ConflictStrategy;
                objTask.Status = objCopyTaskEN.Status;
                objTask.CurrentStep = objCopyTaskEN.CurrentStep;
                objTask.ErrorMessage = objCopyTaskEN.ErrorMessage;
                objTask.CreatedBy = objCopyTaskEN.CreatedBy;

                return objTask;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取复制任务失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取复制任务区域列表（从数据库，按 StepOrder 排序）
        /// </summary>
        private static List<clsCopyTaskRegionEN> GetCopyTaskRegions(long lngTaskId)
        {
            try
            {
                string strCondition = string.Format("TaskId = '{0}'", lngTaskId);
                List<clsCopyTaskRegionEN> arrCopyTaskRegionENList = clsCopyTaskRegionBL.GetObjLst(strCondition);

                List<clsCopyTaskRegionEN> arrRegions = new List<clsCopyTaskRegionEN>();

                if (arrCopyTaskRegionENList == null) return arrRegions;

                foreach (clsCopyTaskRegionEN objEN in arrCopyTaskRegionENList)
                {
                    clsCopyTaskRegionEN objRegion = new clsCopyTaskRegionEN();
                    objRegion.TaskId = objEN.TaskId;
                    objRegion.SourceRegionId = objEN.SourceRegionId;
                    objRegion.SourceClsName = objEN.SourceClsName;
                    objRegion.TargetRegionId = objEN.TargetRegionId;
                    objRegion.CopyStatus = objEN.CopyStatus;
                    objRegion.RelationStatus = objEN.RelationStatus;
                    objRegion.ErrorMessage = objEN.ErrorMessage;
                    objRegion.StepOrder = objEN.StepOrder;

                    arrRegions.Add(objRegion);
                }

                // 按 StepOrder 排序
                arrRegions.Sort((a, b) => a.StepOrder.CompareTo(b.StepOrder));

                return arrRegions;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取任务区域列表失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
                //return new List<clsCopyTaskRegionEN>();
            }
        }

        /// <summary>
        /// 插入复制任务（独立事务）
        /// </summary>
        private static long InsertCopyTask(string strSouPrjId, string strTarPrjId, string strSouViewId,
            string strConflictStrategy, string strUserId)
        {
            try
            {
                clsCopyTaskEN objCopyTask = new clsCopyTaskEN();
                objCopyTask.SourcePrjId = strSouPrjId;
                objCopyTask.TargetPrjId = strTarPrjId;
                objCopyTask.SourceViewId = strSouViewId;
                objCopyTask.TargetViewId = "";
                objCopyTask.TargetViewName = "";
                objCopyTask.ConflictStrategy = strConflictStrategy;
                objCopyTask.Status = "Pending";
                objCopyTask.CurrentStep = "Init";
                objCopyTask.ErrorMessage = "";
                objCopyTask.CreatedBy = strUserId;
                objCopyTask.CreatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));
                objCopyTask.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

                string strTaskId = clsCopyTaskBL.AddNewRecordBySql2WithReturnKey(objCopyTask);
                long lngTaskId = long.Parse(strTaskId);

                string strLog = string.Format("插入复制任务成功，TaskId:[{0}]", lngTaskId);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                return lngTaskId;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("插入复制任务失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 初始化复制任务区域清单（独立事务）
        /// </summary>
        private static int InitializeCopyTaskRegions(long lngTaskId, string strSouViewId)
        {
            try
            {
                string strRegionCondition = string.Format("ViewId = '{0}'", strSouViewId);
                List<clsViewRegionRelaEN> arrSouRegionRelaLst = clsViewRegionRelaBL.GetObjLst(strRegionCondition);

                if (arrSouRegionRelaLst == null || arrSouRegionRelaLst.Count == 0)
                {
                    return 0;
                }

                int intStepOrder = 1;
                foreach (clsViewRegionRelaEN objSouRegionRela in arrSouRegionRelaLst)
                {
                    clsViewRegionEN objSouRegion = clsViewRegionBL.GetObjByRegionId(objSouRegionRela.RegionId);
                    if (objSouRegion == null) continue;

                    clsCopyTaskRegionEN objTaskRegion = new clsCopyTaskRegionEN();
                    objTaskRegion.TaskId = lngTaskId;
                    objTaskRegion.SourceRegionId = objSouRegion.RegionId;
                    objTaskRegion.SourceClsName = objSouRegion.ClsName;
                    objTaskRegion.TargetRegionId = "";
                    objTaskRegion.CopyStatus = "Pending";
                    objTaskRegion.RelationStatus = "Pending";
                    objTaskRegion.ErrorMessage = "";
                    objTaskRegion.StepOrder = intStepOrder;
                    objTaskRegion.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

                    clsCopyTaskRegionBL.AddNewRecordBySql2(objTaskRegion);

                    intStepOrder++;
                }

                return arrSouRegionRelaLst.Count;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("初始化任务区域清单失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
                //return -1;
            }
        }

        /// <summary>
        /// 更新任务头（独立事务）
        /// </summary>
        private static void UpdateTask(long lngTaskId, string strStatus, string strCurrentStep, string strErrorMessage)
        {
            try
            {
                clsCopyTaskEN objTask = clsCopyTaskBL.GetObjByTaskId(lngTaskId);
                if (objTask == null)
                {
                    string strMsg = string.Format("任务不存在，TaskId:[{0}]", lngTaskId);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    return;
                }

                objTask.Status = strStatus;
                objTask.CurrentStep = strCurrentStep;
                objTask.ErrorMessage = strErrorMessage ?? "";
                objTask.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

                clsCopyTaskBL.UpdateBySql2(objTask);

                string strLog = string.Format("更新任务，TaskId:[{0}]，Status:[{1}]，Step:[{2}]",
                    lngTaskId, strStatus, strCurrentStep);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("更新任务失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 更新任务步骤（独立事务）
        /// </summary>
        private static void UpdateTaskStep(long lngTaskId, string strCurrentStep)
        {
            try
            {
                clsCopyTaskEN objTask = clsCopyTaskBL.GetObjByTaskId(lngTaskId);
                if (objTask == null) return;

                objTask.CurrentStep = strCurrentStep;
                objTask.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

                clsCopyTaskBL.UpdateBySql2(objTask);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("更新任务步骤失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 更新任务目标界面（独立事务）
        /// </summary>
        private static void UpdateTaskTargetView(long lngTaskId, string strTargetViewId, string strTargetViewName)
        {
            try
            {
                clsCopyTaskEN objTask = clsCopyTaskBL.GetObjByTaskId(lngTaskId);
                if (objTask == null) return;

                objTask.TargetViewId = strTargetViewId;
                objTask.TargetViewName = strTargetViewName;
                objTask.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

                clsCopyTaskBL.UpdateBySql2(objTask);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("更新任务目标界面失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 更新任务区域复制结果（独立事务）
        /// </summary>
        private static void UpdateTaskRegionCopyResult(long lngTaskId, string strSourceRegionId,
            string strTargetRegionId, string strCopyStatus, string strErrorMessage)
        {
            try
            {
                string strCondition = string.Format("TaskId = '{0}' AND SourceRegionId = '{1}'",
                    lngTaskId, strSourceRegionId);
                clsCopyTaskRegionEN objRegion = clsCopyTaskRegionBL.GetFirstObj_S(strCondition);
                if (objRegion == null) return;

                objRegion.TargetRegionId = strTargetRegionId ?? "";
                objRegion.CopyStatus = strCopyStatus;
                objRegion.ErrorMessage = strErrorMessage ?? "";
                objRegion.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

                clsCopyTaskRegionBL.UpdateBySql2(objRegion);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("更新区域复制结果失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 更新任务区域关系结果（独立事务）
        /// </summary>
        private static void UpdateTaskRegionRelationResult(long lngTaskId, string strSourceRegionId,
            string strRelationStatus, string strErrorMessage)
        {

            string strCondition = string.Format("TaskId = '{0}' AND SourceRegionId = '{1}'",
                lngTaskId, strSourceRegionId);
            clsCopyTaskRegionEN objRegion = clsCopyTaskRegionBL.GetFirstObj_S(strCondition);
            if (objRegion == null) return;

            objRegion.RelationStatus = strRelationStatus;
            objRegion.ErrorMessage = strErrorMessage ?? "";
            objRegion.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));

            clsCopyTaskRegionBL.UpdateBySql2(objRegion);

        }

        /// <summary>
        /// 启动或恢复复制任务（只创建/恢复任务，不执行复制）
        /// </summary>
        public static StartOrResumeCopyTaskResultDto StartOrResumeCopyTask(
            string strTarPrjId,
            string strSouViewId,
            string strUserId,
            string strConflictStrategy)
        {
            StartOrResumeCopyTaskResultDto result = new StartOrResumeCopyTaskResultDto();

            try
            {
                // 1、参数校验
                if (!ValidateCopyTaskInput(strTarPrjId, strSouViewId, strUserId, strConflictStrategy, out string strValidationError))
                {
                    result.status = "Failed";
                    result.message = strValidationError;
                    return result;
                }

                // 2、读取源界面并校验业务对象
                clsViewInfoEN objSouViewInfo = clsViewInfoBL.GetObjByViewId(strSouViewId);
                if (objSouViewInfo == null)
                {
                    result.status = "Failed";
                    result.message = string.Format("源界面ID:[{0}]不存在", strSouViewId);
                    return result;
                }

                string strSouPrjId = objSouViewInfo.PrjId;

                // 校验源工程存在
                clsProjectsEN objSouProject = clsProjectsBL.GetObjByPrjId(strSouPrjId);
                if (objSouProject == null)
                {
                    result.status = "Failed";
                    result.message = string.Format("源工程ID:[{0}]不存在", strSouPrjId);
                    return result;
                }

                // 校验目标工程存在
                clsProjectsEN objTarProject = clsProjectsBL.GetObjByPrjId(strTarPrjId);
                if (objTarProject == null)
                {
                    result.status = "Failed";
                    result.message = string.Format("目标工程ID:[{0}]不存在", strTarPrjId);
                    return result;
                }

                // 校验不能复制到同一个工程（可选）
                if (strSouPrjId == strTarPrjId)
                {
                    result.status = "Failed";
                    result.message = "不能复制到同一个工程";
                    return result;
                }

                // 3、查是否已有未完成任务
                clsCopyTaskEN objExistingTask = GetLatestUnfinishedTask(strSouPrjId, strTarPrjId, strSouViewId);

                if (objExistingTask != null)
                {
                    // 4、命中旧任务，做任务修正
                    NormalizeTaskForResume(objExistingTask);

                    // 统计区域完成情况
                    int intTotalRegions = 0;
                    int intCompletedRegions = 0;
                    GetTaskRegionProgress(objExistingTask.TaskId, out intTotalRegions, out intCompletedRegions);

                    result.taskId = objExistingTask.TaskId;
                    result.isNewTask = false;
                    result.status = objExistingTask.Status;
                    result.currentStep = objExistingTask.CurrentStep;
                    result.message = "已存在未完成任务，继续执行该任务。";
                    result.totalRegions = intTotalRegions;
                    result.completedRegions = intCompletedRegions;

                    return result;
                }

                // 5、创建新任务
                long lngTaskId = InsertCopyTask(strSouPrjId, strTarPrjId, strSouViewId, strConflictStrategy, strUserId);

                if (lngTaskId <= 0)
                {
                    result.status = "Failed";
                    result.message = "创建任务失败";
                    return result;
                }

                // 6、初始化任务明细（区域清单）
                int intRegionCount = InitializeCopyTaskRegions(lngTaskId, strSouViewId);

                if (intRegionCount < 0)
                {
                    result.status = "Failed";
                    result.message = "初始化任务明细失败";
                    return result;
                }

                // 7、返回任务信息
                result.taskId = lngTaskId;
                result.isNewTask = true;
                result.status = "Pending";
                result.currentStep = "Init";
                result.message = "复制任务已创建。";
                result.totalRegions = intRegionCount;
                result.completedRegions = 0;

                string strLog = string.Format("创建复制任务成功，TaskId:[{0}]，源界面:[{1}]，目标工程:[{2}]，区域数:[{3}]",
                    lngTaskId, strSouViewId, strTarPrjId, intRegionCount);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                return result;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("启动或恢复复制任务失败，错误:{0}.(in {1})",
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

                result.status = "Failed";
                result.message = strMsg;
                return result;
            }
        }

        /// <summary>
        /// 验证复制任务输入参数
        /// </summary>
        private static bool ValidateCopyTaskInput(string strTarPrjId, string strSouViewId, string strUserId,
            string strConflictStrategy, out string strError)
        {
            strError = "";

            if (string.IsNullOrEmpty(strTarPrjId))
            {
                strError = "目标工程ID不能为空";
                return false;
            }

            if (string.IsNullOrEmpty(strSouViewId))
            {
                strError = "源界面ID不能为空";
                return false;
            }

            if (string.IsNullOrEmpty(strUserId))
            {
                strError = "操作用户ID不能为空";
                return false;
            }

            List<string> validStrategies = new List<string> { "skip", "overwrite", "rename" };
            if (!validStrategies.Contains(strConflictStrategy?.ToLower()))
            {
                strError = "冲突策略必须是 skip、overwrite 或 rename";
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取最近的未完成任务
        /// </summary>
        private static clsCopyTaskEN GetLatestUnfinishedTask(string strSouPrjId, string strTarPrjId, string strSouViewId)
        {
            try
            {
                // 查询条件：SourcePrjId + TargetPrjId + SourceViewId
                string strCondition = string.Format(
                    "SourcePrjId = '{0}' AND TargetPrjId = '{1}' AND SourceViewId = '{2}'",
                    strSouPrjId, strTarPrjId, strSouViewId);

                List<clsCopyTaskEN> arrTasks = clsCopyTaskBL.GetObjLst(strCondition);
                if (arrTasks == null || arrTasks.Count == 0) return null;

                // 状态：Pending, Running, Failed
                List<string> unfinishedStatuses = new List<string> { "Pending", "Running", "Failed", "Error" };

                // 优先找未完成任务（按 TaskId 倒序）
                arrTasks.Sort((a, b) => b.TaskId.CompareTo(a.TaskId));

                foreach (clsCopyTaskEN objTaskEN in arrTasks)
                {
                    if (unfinishedStatuses.Contains(objTaskEN.Status))
                    {
                        clsCopyTaskEN objTask = new clsCopyTaskEN();
                        objTask.TaskId = objTaskEN.TaskId;
                        objTask.SourcePrjId = objTaskEN.SourcePrjId;
                        objTask.TargetPrjId = objTaskEN.TargetPrjId;
                        objTask.SourceViewId = objTaskEN.SourceViewId;
                        objTask.TargetViewId = objTaskEN.TargetViewId;
                        objTask.TargetViewName = objTaskEN.TargetViewName;
                        objTask.ConflictStrategy = objTaskEN.ConflictStrategy;
                        objTask.Status = objTaskEN.Status;
                        objTask.CurrentStep = objTaskEN.CurrentStep;
                        objTask.ErrorMessage = objTaskEN.ErrorMessage;
                        objTask.CreatedBy = objTaskEN.CreatedBy;

                        return objTask;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("查询未完成任务失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                return null;
            }
        }

        /// <summary>
        /// 修正任务状态以便恢复
        /// </summary>
        private static void NormalizeTaskForResume(clsCopyTaskEN objTask)
        {
            try
            {
                bool bolNeedUpdate = false;
                clsCopyTaskEN objCopyTaskEN = clsCopyTaskBL.GetObjByTaskId(objTask.TaskId);
                if (objCopyTaskEN == null)
                {
                    throw new Exception(string.Format("任务不存在，TaskId:[{0}]", objTask.TaskId));
                }

                // 如果状态是 Running，但实际上任务已中断，改回 Pending
                if (objCopyTaskEN.Status == "Running")
                {
                    objCopyTaskEN.Status = "Pending";
                    bolNeedUpdate = true;
                }

                // 如果 CurrentStep 是空，补成合适值
                if (string.IsNullOrEmpty(objCopyTaskEN.CurrentStep))
                {
                    objCopyTaskEN.CurrentStep = "Init";
                    bolNeedUpdate = true;
                }

                // 如果需要更新
                if (bolNeedUpdate)
                {
                    objCopyTaskEN.UpdatedTime = DateTime.Parse(clsDateTime.getTodayDateTimeStr(1));
                    clsCopyTaskBL.UpdateBySql2(objCopyTaskEN);

                    // 同步更新传入的对象
                    objTask.Status = objCopyTaskEN.Status;
                    objTask.CurrentStep = objCopyTaskEN.CurrentStep;
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("修正任务状态失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            }
        }

        /// <summary>
        /// 获取任务区域进度
        /// </summary>
        private static void GetTaskRegionProgress(long lngTaskId, out int intTotalRegions, out int intCompletedRegions)
        {
            intTotalRegions = 0;
            intCompletedRegions = 0;

            try
            {
                string strCondition = string.Format("TaskId = '{0}'", lngTaskId);
                List<clsCopyTaskRegionEN> arrRegions = clsCopyTaskRegionBL.GetObjLst(strCondition);

                if (arrRegions == null) return;

                intTotalRegions = arrRegions.Count;

                foreach (clsCopyTaskRegionEN objRegion in arrRegions)
                {
                    if (objRegion.CopyStatus == "Success" || objRegion.CopyStatus == "Reused")
                    {
                        if (objRegion.RelationStatus == "Success")
                        {
                            intCompletedRegions++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取任务进度失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            }
        }

        /// <summary>
        /// 取消复制任务
        /// </summary>
        public static bool CancelCopyTask(long lngTaskId, string strUserId)
        {
            try
            {
                clsCopyTaskEN objTask = GetCopyTaskById(lngTaskId);
                if (objTask == null)
                {
                    return false;
                }

                // 只有 Pending 或 Failed 状态才能取消
                if (objTask.Status != "Pending" && objTask.Status != "Failed")
                {
                    return false;
                }

                UpdateTaskField(lngTaskId, "Status", "Canceled");
                UpdateTaskField(lngTaskId, "UpdatedBy", strUserId);
                UpdateTaskField(lngTaskId, "UpdatedDate", clsDateTime.getTodayDateTimeStr(1));

                return true;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("取消任务失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                return false;
            }
        }

        /// <summary>
        /// 根据ID获取任务
        /// </summary>
        private static clsCopyTaskEN GetCopyTaskById(long lngTaskId)
        {
            try
            {
                // SELECT * FROM CopyTask WHERE TaskId = @TaskId
                // 这里需要根据你的实际任务表实现
                return null;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取任务失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                return null;
            }
        }

        /// <summary>
        /// 更新任务字段（独立事务）
        /// </summary>
        private static void UpdateTaskField(long lngTaskId, string strFieldName, string strValue)
        {
            try
            {
                // UPDATE CopyTask SET FieldName = @Value, UpdatedDate = GETDATE() WHERE TaskId = @TaskId
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("更新任务字段失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            }
        }

        /// <summary>
        /// 获取任务区域状态列表
        /// </summary>
        private static List<CopyRegionStatusDto> GetTaskRegionStatuses(long lngTaskId)
        {
            List<CopyRegionStatusDto> regionStatuses = new List<CopyRegionStatusDto>();

            try
            {
                // SELECT * FROM CopyTaskRegion WHERE TaskId = @TaskId ORDER BY StepOrder
                // 转换为 CopyRegionStatusDto 列表
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取区域状态列表失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            }

            return regionStatuses;
        }

        /// <summary>
        /// 执行复制核心逻辑（调用原来的方法）
        /// </summary>
        private static CopyViewWithRegionsResultDto ExecuteCopyViewWithRegionsCore(clsCopyTaskEN objTask)
        {
            // 这里调用之前实现的 CopyViewWithRegions 方法的核心逻辑
            // 或者重构成独立的核心方法
            return new CopyViewWithRegionsResultDto();
        }



        // ==================== 以下是所有辅助方法 ====================

        /// <summary>
        /// 按表名映射表ID
        /// </summary>
        private static string MapTabByName(string strSouTabId, string strSouPrjId, string strTarPrjId, string strUserId)
        {
            if (string.IsNullOrEmpty(strSouTabId)) return "";

            clsPrjTabEN objSouTab = clsPrjTabBL.GetObjByTabIdCache(strSouTabId, strSouPrjId);
            if (objSouTab == null) return "";

            string strCondition = string.Format("PrjId = '{0}' and TabName = '{1}'",
                strTarPrjId, objSouTab.TabName);

            if (clsPrjTabBL.IsExistRecord(strCondition))
            {
                return clsPrjTabBL.GetFirstID_S(strCondition);
            }
            else
            {
                return clsPrjTabBLEx.CopyPrjTab(strTarPrjId, strSouTabId, strUserId);
            }
        }

        /// <summary>
        /// 构建表映射（按 TabName）
        /// </summary>
        private static bool BuildTabMapping(clsViewInfoEN objSouViewInfo, string strSouPrjId, string strTarPrjId,
            string strUserId, Dictionary<string, string> dictTabMapping, out string strError)
        {
            strError = "";

            try
            {
                if (!string.IsNullOrEmpty(objSouViewInfo.MainTabId))
                {
                    string strTargetTabId = MapTabByName(objSouViewInfo.MainTabId, strSouPrjId, strTarPrjId, strUserId);
                    if (string.IsNullOrEmpty(strTargetTabId))
                    {
                        strError = "主表映射失败";
                        return false;
                    }
                    dictTabMapping[objSouViewInfo.MainTabId] = strTargetTabId;
                }

                if (!string.IsNullOrEmpty(objSouViewInfo.InRelaTabId))
                {
                    string strTargetTabId = MapTabByName(objSouViewInfo.InRelaTabId, strSouPrjId, strTarPrjId, strUserId);
                    if (string.IsNullOrEmpty(strTargetTabId))
                    {
                        strError = "输入表映射失败";
                        return false;
                    }
                    dictTabMapping[objSouViewInfo.InRelaTabId] = strTargetTabId;
                }

                if (!string.IsNullOrEmpty(objSouViewInfo.OutRelaTabId))
                {
                    string strTargetTabId = MapTabByName(objSouViewInfo.OutRelaTabId, strSouPrjId, strTarPrjId, strUserId);
                    if (string.IsNullOrEmpty(strTargetTabId))
                    {
                        strError = "输出表映射失败";
                        return false;
                    }
                    dictTabMapping[objSouViewInfo.OutRelaTabId] = strTargetTabId;
                }

                if (!string.IsNullOrEmpty(objSouViewInfo.DetailTabId))
                {
                    string strTargetTabId = MapTabByName(objSouViewInfo.DetailTabId, strSouPrjId, strTarPrjId, strUserId);
                    if (string.IsNullOrEmpty(strTargetTabId))
                    {
                        strError = "详细表映射失败";
                        return false;
                    }
                    dictTabMapping[objSouViewInfo.DetailTabId] = strTargetTabId;
                }

                return true;
            }
            catch (Exception ex)
            {
                strError = string.Format("表映射异常:{0}", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 删除界面及其关系
        /// </summary>
        private static bool DeleteViewWithRelations(string strViewId, string strPrjId, string strUserId)
        {
            try
            {
                string strRelaCondition = string.Format("ViewId = '{0}'", strViewId);
                List<clsViewRegionRelaEN> arrRelaLst = clsViewRegionRelaBL.GetObjLst(strRelaCondition);
                foreach (clsViewRegionRelaEN objRela in arrRelaLst)
                {
                    clsViewRegionRelaBL.DelRecord(objRela.mId);
                }

                string strStyleCondition = string.Format("ViewId = '{0}'", strViewId);
                clsViewStyleEN objStyle = clsViewStyleBL.GetFirstObj_S(strStyleCondition);
                if (objStyle != null)
                {

                    clsViewStyleBL.DelRecord(objStyle.ViewId);
                }

                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewId(strViewId);
                if (objViewInfo != null)
                {
                    clsViewInfoBL.DelRecord(strViewId);
                }

                return true;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("删除界面失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                return false;
            }
        }

        /// <summary>
        /// 生成唯一的界面名称
        /// </summary>
        private static string GenerateUniqueViewName(string strPrjId, string strOriginalName)
        {
            string strNewName = strOriginalName + "_Copy";
            int intCounter = 2;

            while (true)
            {
                string strCondition = string.Format("PrjId = '{0}' and ViewName = '{1}'", strPrjId, strNewName);
                if (!clsViewInfoBL.IsExistRecord(strCondition))
                {
                    return strNewName;
                }
                strNewName = strOriginalName + "_Copy" + intCounter;
                intCounter++;
            }
        }

        /// <summary>
        /// 复制界面属性
        /// </summary>
        private static void CopyViewInfoProperties(clsViewInfoEN objSouViewInfo, clsViewInfoEN objNewViewInfo,
            string strNewViewId, string strTarPrjId, string strFinalViewName, string strUserId,
            Dictionary<string, string> dictTabMapping)
        {
            objNewViewInfo.ViewId = strNewViewId;
            objNewViewInfo.ViewName = strFinalViewName;
            objNewViewInfo.ViewCnName = objSouViewInfo.ViewCnName;
            objNewViewInfo.PrjId = strTarPrjId;

            objNewViewInfo.MainTabId = dictTabMapping.ContainsKey(objSouViewInfo.MainTabId) ?
                dictTabMapping[objSouViewInfo.MainTabId] : "";
            objNewViewInfo.InRelaTabId = dictTabMapping.ContainsKey(objSouViewInfo.InRelaTabId) ?
                dictTabMapping[objSouViewInfo.InRelaTabId] : "";
            objNewViewInfo.OutRelaTabId = dictTabMapping.ContainsKey(objSouViewInfo.OutRelaTabId) ?
                dictTabMapping[objSouViewInfo.OutRelaTabId] : "";
            objNewViewInfo.DetailTabId = dictTabMapping.ContainsKey(objSouViewInfo.DetailTabId) ?
                dictTabMapping[objSouViewInfo.DetailTabId] : "";

            objNewViewInfo.ApplicationTypeId = objSouViewInfo.ApplicationTypeId;
            objNewViewInfo.FuncModuleAgcId = objSouViewInfo.FuncModuleAgcId;
            objNewViewInfo.DataBaseName = objSouViewInfo.DataBaseName;
            objNewViewInfo.KeyForMainTab = objSouViewInfo.KeyForMainTab;
            objNewViewInfo.KeyForDetailTab = objSouViewInfo.KeyForDetailTab;
            objNewViewInfo.IsNeedSort = objSouViewInfo.IsNeedSort;
            objNewViewInfo.IsNeedTransCode = objSouViewInfo.IsNeedTransCode;
            objNewViewInfo.IsNeedSetExportFld = objSouViewInfo.IsNeedSetExportFld;
            objNewViewInfo.UserId = strUserId;
            objNewViewInfo.ViewFunction = objSouViewInfo.ViewFunction;
            objNewViewInfo.ViewDetail = objSouViewInfo.ViewDetail;
            objNewViewInfo.DefaMenuName = objSouViewInfo.DefaMenuName;
            objNewViewInfo.FileName = objSouViewInfo.FileName;
            objNewViewInfo.FilePath = objSouViewInfo.FilePath;
            objNewViewInfo.ViewGroupId = objSouViewInfo.ViewGroupId;
            objNewViewInfo.InSqlDsTypeId = objSouViewInfo.InSqlDsTypeId;
            objNewViewInfo.OutSqlDsTypeId = objSouViewInfo.OutSqlDsTypeId;
            objNewViewInfo.DetailTabType = objSouViewInfo.DetailTabType;
            objNewViewInfo.DetailViewId = objSouViewInfo.DetailViewId;
            objNewViewInfo.MainTabType = objSouViewInfo.MainTabType;
            objNewViewInfo.MainViewId = objSouViewInfo.MainViewId;
            objNewViewInfo.ViewMasterId = objSouViewInfo.ViewMasterId;
            objNewViewInfo.IsShare = objSouViewInfo.IsShare;
            objNewViewInfo.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            objNewViewInfo.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objNewViewInfo.UpdUserId = strUserId;
            objNewViewInfo.Memo = string.IsNullOrEmpty(objSouViewInfo.Memo) ?
                "(复制)" : objSouViewInfo.Memo + "(复制)";
            objNewViewInfo.ErrMsg = "";
            objNewViewInfo.TaskId = null;
            objNewViewInfo.KeyId4Test = null;
            objNewViewInfo.RegionNum = objSouViewInfo.RegionNum;
        }

        /// <summary>
        /// 复制界面样式
        /// </summary>
        private static void CopyViewStyle(string strSouViewId, string strNewViewId, string strUserId)
        {
            try
            {
                string strStyleCondition = string.Format("ViewId = '{0}'", strSouViewId);
                clsViewStyleEN objSouViewStyle = clsViewStyleBL.GetFirstObj_S(strStyleCondition);

                if (objSouViewStyle != null)
                {
                    clsViewStyleEN objNewViewStyle = new clsViewStyleEN();
                    objNewViewStyle.ViewId = strNewViewId;
                    objNewViewStyle.TitleStyleId = objSouViewStyle.TitleStyleId;
                    objNewViewStyle.DgStyleId = objSouViewStyle.DgStyleId;

                    clsViewStyleBL.AddNewRecordBySql2(objNewViewStyle);
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("复制界面样式失败:{0}", ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            }
        }

        /// <summary>
        /// 复制区域相关的字段配置
        /// </summary>
        private static void CopyRegionFields(string strSouRegionId, string strNewRegionId, string strRegionTypeId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            try
            {
                switch (strRegionTypeId)
                {
                    case enumRegionType.EditRegion_0003:
                        CopyEditRegionFields(strSouRegionId, strNewRegionId, strSouPrjId, strTarPrjId, strUserId);
                        break;
                    case enumRegionType.ListRegion_0002:
                        CopyListRegionFields(strSouRegionId, strNewRegionId, strSouPrjId, strTarPrjId, strUserId);
                        break;
                    case enumRegionType.QueryRegion_0001:
                        CopyQueryRegionFields(strSouRegionId, strNewRegionId, strSouPrjId, strTarPrjId, strUserId);
                        break;
                    case enumRegionType.DetailRegion_0006:
                        CopyDetailRegionFields(strSouRegionId, strNewRegionId, strSouPrjId, strTarPrjId, strUserId);
                        break;
                    case enumRegionType.FeatureRegion_0008:
                        CopyFeatureRegionFields(strSouRegionId, strNewRegionId, strSouPrjId, strTarPrjId, strUserId);
                        break;
                    case enumRegionType.ExcelExportRegion_0007:
                        CopyExcelExportRegionFields(strSouRegionId, strNewRegionId, strSouPrjId, strTarPrjId, strUserId);
                        break;
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("复制区域字段失败，区域类型:[{0}]，错误:{1}.(in {2})",
                    strRegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            }
        }

        private static void CopyEditRegionFields(string strSouRegionId, string strNewRegionId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            string strCondition = string.Format("RegionId = '{0}'", strSouRegionId);
            List<clsEditRegionFldsEN> arrSouFieldsLst = clsEditRegionFldsBL.GetObjLst(strCondition);

            foreach (clsEditRegionFldsEN objSouField in arrSouFieldsLst)
            {
                clsEditRegionFldsEN objNewField = new clsEditRegionFldsEN();
                clsEditRegionFldsBL.CopyTo(objSouField, objNewField);

                objNewField.RegionId = strNewRegionId;
                objNewField.PrjId = strTarPrjId;
                objNewField.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewField.UpdUser = strUserId;
                objNewField.FldId = CopyFieldToTargetProject(objSouField.FldId, strSouPrjId, strTarPrjId, strUserId);
                //objNewField.TabFeatureId4Ddl =
                if (!string.IsNullOrEmpty(objSouField.FldIdCond1))
                {
                    objNewField.FldIdCond1 = CopyFieldToTargetProject(objSouField.FldIdCond1, strSouPrjId, strTarPrjId, strUserId);
                }
                if (!string.IsNullOrEmpty(objSouField.FldIdCond2))
                {
                    objNewField.FldIdCond2 = CopyFieldToTargetProject(objSouField.FldIdCond2, strSouPrjId, strTarPrjId, strUserId);
                }
                if (!string.IsNullOrEmpty(objSouField.DsTabId))
                {
                    objNewField.DsTabId = CopyTabIdToTargetProject(objSouField.DsTabId, strSouPrjId, strTarPrjId, strUserId);
                }
                objNewField.ErrMsg = "";

                clsEditRegionFldsBL.AddNewRecordBySql2(objNewField);
            }
        }

        private static void CopyListRegionFields(string strSouRegionId, string strNewRegionId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            string strCondition = string.Format("RegionId = '{0}'", strSouRegionId);
            List<clsDGRegionFldsEN> arrSouFieldsLst = clsDGRegionFldsBL.GetObjLst(strCondition);

            foreach (clsDGRegionFldsEN objSouField in arrSouFieldsLst)
            {
                clsDGRegionFldsEN objNewField = new clsDGRegionFldsEN();
                clsDGRegionFldsBL.CopyTo(objSouField, objNewField);

                objNewField.RegionId = strNewRegionId;
                objNewField.PrjId = strTarPrjId;
                objNewField.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewField.UpdUser = strUserId;
                objNewField.FldId = CopyFieldToTargetProject(objSouField.FldId, strSouPrjId, strTarPrjId, strUserId);

                clsDGRegionFldsBL.AddNewRecordBySql2(objNewField);
            }
        }

        private static void CopyQueryRegionFields(string strSouRegionId, string strNewRegionId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            string strCondition = string.Format("RegionId = '{0}'", strSouRegionId);
            List<clsQryRegionFldsEN> arrSouFieldsLst = clsQryRegionFldsBL.GetObjLst(strCondition);

            foreach (clsQryRegionFldsEN objSouField in arrSouFieldsLst)
            {
                clsQryRegionFldsEN objNewField = new clsQryRegionFldsEN();
                clsQryRegionFldsBL.CopyTo(objSouField, objNewField);

                objNewField.RegionId = strNewRegionId;
                objNewField.PrjId = strTarPrjId;
                objNewField.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewField.UpdUser = strUserId;
                objNewField.FldId = CopyFieldToTargetProject(objSouField.FldId, strSouPrjId, strTarPrjId, strUserId);

                clsQryRegionFldsBL.AddNewRecordBySql2(objNewField);
            }
        }

        private static void CopyDetailRegionFields(string strSouRegionId, string strNewRegionId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            string strCondition = string.Format("RegionId = '{0}'", strSouRegionId);
            List<clsDetailRegionFldsEN> arrSouFieldsLst = clsDetailRegionFldsBL.GetObjLst(strCondition);

            foreach (clsDetailRegionFldsEN objSouField in arrSouFieldsLst)
            {
                clsDetailRegionFldsEN objNewField = new clsDetailRegionFldsEN();
                clsDetailRegionFldsBL.CopyTo(objSouField, objNewField);

                objNewField.RegionId = strNewRegionId;
                objNewField.PrjId = strTarPrjId;
                objNewField.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewField.UpdUser = strUserId;
                objNewField.FldId = CopyFieldToTargetProject(objSouField.FldId, strSouPrjId, strTarPrjId, strUserId);

                clsDetailRegionFldsBL.AddNewRecordBySql2(objNewField);
            }
        }

        private static void CopyFeatureRegionFieldsBak(string strSouRegionId, string strNewRegionId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            string strCondition = string.Format("RegionId = '{0}'", strSouRegionId);
            List<clsFeatureRegionFldsEN> arrSouFieldsLst = clsFeatureRegionFldsBL.GetObjLst(strCondition);

            foreach (clsFeatureRegionFldsEN objSouField in arrSouFieldsLst)
            {
                clsFeatureRegionFldsEN objNewField = new clsFeatureRegionFldsEN();
                clsFeatureRegionFldsBL.CopyTo(objSouField, objNewField);

                objNewField.RegionId = strNewRegionId;
                objNewField.PrjId = strTarPrjId;
                objNewField.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewField.UpdUser = strUserId;

                if (!string.IsNullOrEmpty(objSouField.ReleTabId))
                {
                    objNewField.ReleTabId = CopyTabIdToTargetProject(objSouField.ReleTabId, strSouPrjId, strTarPrjId, strUserId);
                }
                if (!string.IsNullOrEmpty(objSouField.ReleFldId))
                {
                    objNewField.ReleFldId = CopyFieldToTargetProject(objSouField.ReleFldId, strSouPrjId, strTarPrjId, strUserId);
                }
                objNewField.ErrMsg = "";

                clsFeatureRegionFldsBL.AddNewRecordBySql2(objNewField);
            }
        }

        private static void CopyFeatureRegionFields(string strSouRegionId, string strNewRegionId,
    string strSouPrjId, string strTarPrjId, string strUserId)
        {
            string strCondition = string.Format("RegionId = '{0}'", strSouRegionId);
            List<clsFeatureRegionFldsEN> arrSouFieldsLst = clsFeatureRegionFldsBL.GetObjLst(strCondition);

            foreach (clsFeatureRegionFldsEN objSouField in arrSouFieldsLst)
            {
                clsFeatureRegionFldsEN objNewField = new clsFeatureRegionFldsEN();
                clsFeatureRegionFldsBL.CopyTo(objSouField, objNewField);

                objNewField.RegionId = strNewRegionId;
                objNewField.PrjId = strTarPrjId;
                objNewField.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewField.UpdUser = strUserId;

                if (!string.IsNullOrEmpty(objSouField.ReleTabId))
                {
                    objNewField.ReleTabId = CopyTabIdToTargetProject(objSouField.ReleTabId, strSouPrjId, strTarPrjId, strUserId);
                }
                if (!string.IsNullOrEmpty(objSouField.ReleFldId))
                {
                    objNewField.ReleFldId = CopyFieldToTargetProject(objSouField.ReleFldId, strSouPrjId, strTarPrjId, strUserId);
                }
                objNewField.ErrMsg = "";

                clsFeatureRegionFldsBL.AddNewRecordBySql2(objNewField);

                // 【关键】复制 ViewFeatureFlds 子表数据
                CopyViewFeatureFlds(objSouField.ViewFeatureId, objNewField.ViewFeatureId, strSouPrjId, strTarPrjId, strUserId);
            }
        }

        /// <summary>
        /// 复制功能字段的子表 ViewFeatureFlds
        /// </summary>
        private static void CopyViewFeatureFlds(string strSouViewFeatureId, string strNewViewFeatureId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            try
            {
                string strCondition = string.Format("ViewFeatureId = '{0}'", strSouViewFeatureId);
                List<clsViewFeatureFldsEN> arrSouViewFeatureFlds = clsViewFeatureFldsBL.GetObjLst(strCondition);

                if (arrSouViewFeatureFlds == null || arrSouViewFeatureFlds.Count == 0)
                {
                    return;
                }

                foreach (clsViewFeatureFldsEN objSouFld in arrSouViewFeatureFlds)
                {
                    clsViewFeatureFldsEN objNewFld = new clsViewFeatureFldsEN();
                    clsViewFeatureFldsBL.CopyTo(objSouFld, objNewFld);

                    objNewFld.ViewFeatureId = strNewViewFeatureId;
                    objNewFld.PrjId = strTarPrjId;
                    objNewFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objNewFld.UpdUser = strUserId;

                    // 复制字段ID
                    if (!string.IsNullOrEmpty(objSouFld.ReleFldId))
                    {
                        objNewFld.ReleFldId = CopyFieldToTargetProject(objSouFld.ReleFldId, strSouPrjId, strTarPrjId, strUserId);
                    }

                    // 复制条件字段1
                    if (!string.IsNullOrEmpty(objSouFld.FldIdCond1))
                    {
                        objNewFld.FldIdCond1 = CopyFieldToTargetProject(objSouFld.FldIdCond1, strSouPrjId, strTarPrjId, strUserId);
                    }

                    // 复制条件字段2
                    if (!string.IsNullOrEmpty(objSouFld.FldIdCond2))
                    {
                        objNewFld.FldIdCond2 = CopyFieldToTargetProject(objSouFld.FldIdCond2, strSouPrjId, strTarPrjId, strUserId);
                    }

                    // 复制数据源表ID
                    if (!string.IsNullOrEmpty(objSouFld.DsTabId))
                    {
                        objNewFld.DsTabId = CopyTabIdToTargetProject(objSouFld.DsTabId, strSouPrjId, strTarPrjId, strUserId);
                    }

                    //objNewFld.ErrMsg = "";

                    clsViewFeatureFldsBL.AddNewRecordBySql2(objNewFld);

                    string strLog = string.Format("复制ViewFeatureFlds成功，源ViewFeatureId:[{0}]，新ViewFeatureId:[{1}]，字段:[{2}]",
                        strSouViewFeatureId, strNewViewFeatureId, objSouFld.ReleFldId);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("复制ViewFeatureFlds失败，源ViewFeatureId:[{0}]，新ViewFeatureId:[{1}]，错误:{2}",
                    strSouViewFeatureId, strNewViewFeatureId, ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        private static void CopyExcelExportRegionFields(string strSouRegionId, string strNewRegionId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            string strCondition = string.Format("RegionId = '{0}'", strSouRegionId);
            List<clsExcelExportRegionFldsEN> arrSouFieldsLst = clsExcelExportRegionFldsBL.GetObjLst(strCondition);

            foreach (clsExcelExportRegionFldsEN objSouField in arrSouFieldsLst)
            {
                clsExcelExportRegionFldsEN objNewField = new clsExcelExportRegionFldsEN();
                clsExcelExportRegionFldsBL.CopyTo(objSouField, objNewField);

                objNewField.RegionId = strNewRegionId;
                objNewField.PrjId = strTarPrjId;
                objNewField.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objNewField.UpdUser = strUserId;
                objNewField.FldId = CopyFieldToTargetProject(objSouField.FldId, strSouPrjId, strTarPrjId, strUserId);

                clsExcelExportRegionFldsBL.AddNewRecordBySql2(objNewField);
            }
        }

        private static string CopyFieldToTargetProject(string strSouFldId, string strSouPrjId,
            string strTarPrjId, string strUserId)
        {
            if (string.IsNullOrEmpty(strSouFldId)) return "";

            try
            {
                return clsFieldTabBLEx.CopyField(strSouPrjId, strTarPrjId, strSouFldId, strUserId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("复制字段失败，字段ID:[{0}]，错误:{1}",
                    strSouFldId, objException.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                return "";
            }
        }

        private static string CopyTabIdToTargetProject(string strSouTabId, string strSouPrjId,
            string strTarPrjId, string strUserId)
        {
            if (string.IsNullOrEmpty(strSouTabId)) return "";

            try
            {
                clsPrjTabEN objSouTab = clsPrjTabBL.GetObjByTabIdCache(strSouTabId, strSouPrjId);
                if (objSouTab == null) return "";

                string strCondTabId = string.Format("PrjId = '{0}' and TabName = '{1}'",
                    strTarPrjId, objSouTab.TabName);

                if (clsPrjTabBL.IsExistRecord(strCondTabId))
                {
                    return clsPrjTabBL.GetFirstID_S(strCondTabId);
                }
                else
                {
                    return clsPrjTabBLEx.CopyPrjTab(strTarPrjId, strSouTabId, strUserId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("复制表失败，表ID:[{0}]，错误:{1}",
                    strSouTabId, objException.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                return "";
            }
        }

        /// <summary>
        /// 根据目标工程和源界面查询复制任务状态
        /// </summary>
        /// <param name="strTarPrjId">目标工程ID</param>
        /// <param name="strSouViewId">源界面ID</param>
        /// <returns>返回任务状态</returns>
        public static CopyTaskStatusResultDto GetCopyTaskStatusByViewBak(string strTarPrjId, string strSouViewId)
        {
            CopyTaskStatusResultDto result = new CopyTaskStatusResultDto();

            try
            {
                // 1、获取源界面所属工程
                clsViewInfoEN objSouViewInfo = clsViewInfoBL.GetObjByViewId(strSouViewId);
                if (objSouViewInfo == null)
                {
                    result.taskId = 0;
                    result.status = "NotStarted";
                    result.message = "源界面不存在";
                    return result;
                }

                string strSouPrjId = objSouViewInfo.PrjId;

                // 2、查询所有任务（按 TaskId 倒序）
                // TODO: 这里需要实现真实的数据库查询
                // SELECT * FROM CopyTask 
                // WHERE SourcePrjId = @SourcePrjId AND TargetPrjId = @TargetPrjId AND SourceViewId = @SourceViewId
                // ORDER BY TaskId DESC
                // 2、查询所有任务（按 TaskId 倒序）- 启用真实查询
                string strCondition = string.Format(
                    "SourcePrjId = '{0}' AND TargetPrjId = '{1}' AND SourceViewId = '{2}'",
                    strSouPrjId, strTarPrjId, strSouViewId);

                List<clsCopyTaskEN> arrTasks = clsCopyTaskBL.GetObjLst(strCondition);

                // 3、优先找未完成任务
                List<string> unfinishedStatuses = new List<string> { "Pending", "Running", "Failed", "Error" };
                clsCopyTaskEN objTask = null;

                foreach (clsCopyTaskEN task in arrTasks)
                {
                    if (unfinishedStatuses.Contains(task.Status))
                    {
                        objTask = task;
                        break;
                    }
                }

                // 4、若无未完成任务，取最近一条
                if (objTask == null && arrTasks.Count > 0)
                {
                    objTask = arrTasks[0];
                }

                // 5、一条都没有，返回 NotStarted
                if (objTask == null)
                {
                    result.taskId = 0;
                    result.status = "NotStarted";
                    result.currentStep = "";
                    result.message = "当前界面在目标工程尚未开始复制任务";
                    result.targetViewId = "";
                    result.targetViewName = "";
                    result.totalRegions = 0;
                    result.completedRegions = 0;
                    result.failedRegions = 0;
                    result.relationCompletedCount = 0;
                    result.regionStatuses = new List<CopyRegionStatusDto>();

                    return result;
                }

                // 6、查询任务区域明细
                //List<clsCopyTaskRegionEN> arrRegions = new List<clsCopyTaskRegionEN>(); // GetCopyTaskRegions(objTask.TaskId);
                // 6、查询任务区域明细
                List<clsCopyTaskRegionEN> arrRegions = GetCopyTaskRegions(objTask.TaskId);

                // 7、统计完成情况
                int intTotalRegions = arrRegions.Count;
                int intCompletedRegions = 0;
                int intFailedRegions = 0;
                int intRelationCompleted = 0;

                foreach (clsCopyTaskRegionEN region in arrRegions)
                {
                    if (region.CopyStatus == "Success" || region.CopyStatus == "Reused")
                    {
                        intCompletedRegions++;
                    }
                    if (region.CopyStatus == "Failed")
                    {
                        intFailedRegions++;
                    }
                    if (region.RelationStatus == "Success")
                    {
                        intRelationCompleted++;
                    }
                }
                // 8、如果有目标界面，查询界面名称
                string strTargetViewName = "";
                if (!string.IsNullOrEmpty(objTask.TargetViewId))
                {
                    clsViewInfoEN objTargetView = clsViewInfoBL.GetObjByViewId(objTask.TargetViewId);
                    if (objTargetView != null)
                    {
                        strTargetViewName = objTargetView.ViewName;
                    }
                }

                // 8、组装返回对象
                result.taskId = objTask.TaskId;
                result.status = objTask.Status ?? "";
                result.currentStep = objTask.CurrentStep ?? "";
                result.message = objTask.ErrorMessage ?? "";
                result.targetViewId = objTask.TargetViewId ?? "";
                result.targetViewName = objTask.TargetViewName ?? "";
                result.totalRegions = intTotalRegions;
                result.completedRegions = intCompletedRegions;
                result.failedRegions = intFailedRegions;
                result.relationCompletedCount = intRelationCompleted;

                // 转换区域状态列表
                result.regionStatuses = new List<CopyRegionStatusDto>();
                foreach (clsCopyTaskRegionEN region in arrRegions)
                {
                    CopyRegionStatusDto status = new CopyRegionStatusDto();
                    status.sourceRegionId = region.SourceRegionId ?? "";
                    status.clsName = region.SourceClsName ?? "";
                    status.targetRegionId = region.TargetRegionId ?? "";
                    status.copyStatus = region.CopyStatus ?? "";
                    status.relationStatus = region.RelationStatus ?? "";
                    status.errorMessage = region.ErrorMessage ?? "";
                    result.regionStatuses.Add(status);
                }

                return result;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("查询任务状态失败，错误:{0}.(in {1})",
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

                result.taskId = 0;
                result.status = "Error";
                result.message = strMsg;
                return result;
            }
        }

        /// <summary>
        /// 根据目标工程和源界面查询复制任务状态
        /// </summary>
        public static CopyTaskStatusResultDto GetCopyTaskStatusByView(string strTarPrjId, string strSouViewId)
        {
            CopyTaskStatusResultDto result = new CopyTaskStatusResultDto();

            try
            {
                // 1、获取源界面所属工程
                clsViewInfoEN objSouViewInfo = clsViewInfoBL.GetObjByViewId(strSouViewId);
                if (objSouViewInfo == null)
                {
                    result.taskId = 0;
                    result.status = "NotStarted";
                    result.message = "源界面不存在";
                    return result;
                }

                string strSouPrjId = objSouViewInfo.PrjId;

                // 2、查询所有任务（按 TaskId 倒序）
                string strCondition = string.Format(
                    "SourcePrjId = '{0}' AND TargetPrjId = '{1}' AND SourceViewId = '{2}'",
                    strSouPrjId, strTarPrjId, strSouViewId);

                List<clsCopyTaskEN> arrTasks = clsCopyTaskBL.GetObjLst(strCondition);

                if (arrTasks != null && arrTasks.Count > 0)
                {
                    arrTasks.Sort((a, b) => b.TaskId.CompareTo(a.TaskId));
                }

                // 3、优先找未完成任务
                List<string> unfinishedStatuses = new List<string> { "Pending", "Running", "Failed", "Error" };
                clsCopyTaskEN objTask = null;

                if (arrTasks != null)
                {
                    foreach (clsCopyTaskEN task in arrTasks)
                    {
                        if (unfinishedStatuses.Contains(task.Status))
                        {
                            objTask = task;
                            break;
                        }
                    }
                }

                // 4、若无未完成任务，取最近一条
                if (objTask == null && arrTasks != null && arrTasks.Count > 0)
                {
                    objTask = arrTasks[0];
                }

                // 5、一条都没有，返回 NotStarted
                if (objTask == null)
                {
                    result.taskId = 0;
                    result.status = "NotStarted";
                    result.currentStep = "";
                    result.message = "当前界面在目标工程尚未开始复制任务";
                    result.targetViewId = "";
                    result.targetViewName = "";
                    result.totalRegions = 0;
                    result.completedRegions = 0;
                    result.failedRegions = 0;
                    result.relationCompletedCount = 0;
                    result.regionStatuses = new List<CopyRegionStatusDto>();

                    return result;
                }

                // 6、查询源界面的所有区域（完整列表）
                string strRegionCondition = string.Format("ViewId = '{0}'", strSouViewId);
                List<clsViewRegionRelaEN> arrSouRegionRelaLst = clsViewRegionRelaBL.GetObjLst(strRegionCondition);

                // 7、查询任务区域明细（已记录的部分）
                List<clsCopyTaskRegionEN> arrTaskRegions = GetCopyTaskRegions(objTask.TaskId);

                // 创建已记录区域的字典（用于快速查找）
                Dictionary<string, clsCopyTaskRegionEN> dictTaskRegions = new Dictionary<string, clsCopyTaskRegionEN>();
                foreach (clsCopyTaskRegionEN region in arrTaskRegions)
                {
                    dictTaskRegions[region.SourceRegionId] = region;
                }

                // 8、组装完整的区域状态列表（包含缺失的区域）
                List<CopyRegionStatusDto> regionStatuses = new List<CopyRegionStatusDto>();
                int intStepOrder = 1;
                int intCompletedRegions = 0;
                int intFailedRegions = 0;
                int intRelationCompleted = 0;

                foreach (clsViewRegionRelaEN objSouRegionRela in arrSouRegionRelaLst)
                {
                    clsViewRegionEN objSouRegion = clsViewRegionBL.GetObjByRegionId(objSouRegionRela.RegionId);
                    if (objSouRegion == null) continue;

                    CopyRegionStatusDto status = new CopyRegionStatusDto();
                    status.sourceRegionId = objSouRegion.RegionId;
                    status.clsName = objSouRegion.ClsName;

                    // 检查是否已有任务记录
                    if (dictTaskRegions.ContainsKey(objSouRegion.RegionId))
                    {
                        // 已有记录，使用实际状态
                        clsCopyTaskRegionEN taskRegion = dictTaskRegions[objSouRegion.RegionId];
                        status.targetRegionId = taskRegion.TargetRegionId ?? "";
                        status.copyStatus = taskRegion.CopyStatus ?? "Pending";
                        status.relationStatus = taskRegion.RelationStatus ?? "Pending";
                        status.errorMessage = taskRegion.ErrorMessage ?? "";

                        // 统计
                        if (taskRegion.CopyStatus == "Success" || taskRegion.CopyStatus == "Reused")
                        {
                            intCompletedRegions++;
                        }
                        if (taskRegion.CopyStatus == "Failed")
                        {
                            intFailedRegions++;
                        }
                        if (taskRegion.RelationStatus == "Success")
                        {
                            intRelationCompleted++;
                        }
                    }
                    else
                    {
                        // 没有记录，说明还未开始处理
                        status.targetRegionId = "";
                        status.copyStatus = "Pending";
                        status.relationStatus = "Pending";
                        status.errorMessage = "";
                    }

                    regionStatuses.Add(status);
                }

                // 9、如果有目标界面，查询界面名称
                string strTargetViewName = "";
                if (!string.IsNullOrEmpty(objTask.TargetViewId))
                {
                    clsViewInfoEN objTargetView = clsViewInfoBL.GetObjByViewId(objTask.TargetViewId);
                    if (objTargetView != null)
                    {
                        strTargetViewName = objTargetView.ViewName;
                    }
                }

                // 10、组装返回对象
                result.taskId = objTask.TaskId;
                result.status = objTask.Status ?? "";
                result.currentStep = objTask.CurrentStep ?? "";
                result.message = objTask.ErrorMessage ?? "";
                result.targetViewId = objTask.TargetViewId ?? "";
                result.targetViewName = strTargetViewName;
                result.totalRegions = arrSouRegionRelaLst.Count; // 使用源界面的总区域数
                result.completedRegions = intCompletedRegions;
                result.failedRegions = intFailedRegions;
                result.relationCompletedCount = intRelationCompleted;
                result.regionStatuses = regionStatuses;

                return result;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("查询任务状态失败，错误:{0}.(in {1})",
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

                result.taskId = 0;
                result.status = "Error";
                result.message = strMsg;
                return result;
            }
        }

        /// <summary>
        /// 解析或复制区域（按唯一键查找，存在则复用，不存在则复制）
        /// </summary>
        private static string ResolveOrCopyRegion(clsCopyTaskEN objTask, clsCopyTaskRegionEN objDetail)
        {
            try
            {
                // 获取源区域
                clsViewRegionEN objSouRegion = clsViewRegionBL.GetObjByRegionId(objDetail.SourceRegionId);
                if (objSouRegion == null)
                {
                    throw new Exception(string.Format("源区域不存在，RegionId:[{0}]", objDetail.SourceRegionId));
                }

                // 按唯一键 (PrjId, ClsName) 查找目标工程中是否已有对应区域
                string strCheckCond = string.Format("PrjId = '{0}' AND ClsName = '{1}'",
                    objTask.TargetPrjId, objSouRegion.ClsName);

                if (clsViewRegionBL.IsExistRecord(strCheckCond))
                {
                    // 复用现有区域
                    string strExistingRegionId = clsViewRegionBL.GetFirstID_S(strCheckCond);
                    objDetail.CopyStatus = "Reused";

                    string strLog = string.Format("复用现有区域，RegionId:[{0}]，ClsName:[{1}]",
                        strExistingRegionId, objSouRegion.ClsName);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                    // 【关键】检查区域是否有字段，如果没有则需要复制字段
                    EnsureRegionHasFields(strExistingRegionId, objSouRegion.RegionId, objSouRegion.RegionTypeId,
                        objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy);

                    return strExistingRegionId;
                }
                else
                {
                    // 复制新区域
                    string strNewRegionId = clsGeneralTab.GetMaxStrId("ViewRegion", "RegionId", 8, objTask.TargetPrjId);
                    clsViewRegionEN objNewRegion = new clsViewRegionEN(strNewRegionId);

                    clsViewRegionBL.CopyTo(objSouRegion, objNewRegion);
                    objNewRegion.RegionId = strNewRegionId;
                    objNewRegion.PrjId = objTask.TargetPrjId;
                    objNewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objNewRegion.UpdUser = objTask.CreatedBy;

                    // 映射区域的 TabId（按表名映射）
                    if (!string.IsNullOrEmpty(objSouRegion.TabId))
                    {
                        string strTargetTabId = MapTabByName(objSouRegion.TabId, objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy);
                        objNewRegion.TabId = strTargetTabId;
                    }

                    if (!clsViewRegionBL.AddNewRecordBySql2(objNewRegion))
                    {
                        throw new Exception("添加区域记录失败");
                    }

                    // 复制区域字段
                    CopyRegionFields(objSouRegion.RegionId, strNewRegionId, objSouRegion.RegionTypeId,
                        objTask.SourcePrjId, objTask.TargetPrjId, objTask.CreatedBy);

                    string strLog = string.Format("创建新区域成功，RegionId:[{0}]，ClsName:[{1}]",
                        strNewRegionId, objSouRegion.ClsName);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);

                    return strNewRegionId;
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("解析或复制区域失败，SourceRegionId:[{0}]，错误:{1}",
                    objDetail.SourceRegionId, ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 确保区域有字段数据（如果没有则从源区域复制）
        /// </summary>
        private static void EnsureRegionHasFields(string strTargetRegionId, string strSourceRegionId, string strRegionTypeId,
            string strSouPrjId, string strTarPrjId, string strUserId)
        {
            try
            {
                bool bolHasFields = false;

                // 根据区域类型检查是否有字段
                switch (strRegionTypeId)
                {
                    case enumRegionType.EditRegion_0003:
                        string strEditCondition = string.Format("RegionId = '{0}'", strTargetRegionId);
                        bolHasFields = clsEditRegionFldsBL.IsExistRecord(strEditCondition);
                        if (!bolHasFields)
                        {
                            string strLog = string.Format("区域 [{0}] 没有字段，开始复制编辑区域字段", strTargetRegionId);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                            CopyEditRegionFields(strSourceRegionId, strTargetRegionId, strSouPrjId, strTarPrjId, strUserId);
                        }
                        break;

                    case enumRegionType.ListRegion_0002:
                        string strListCondition = string.Format("RegionId = '{0}'", strTargetRegionId);
                        bolHasFields = clsDGRegionFldsBL.IsExistRecord(strListCondition);
                        if (!bolHasFields)
                        {
                            string strLog = string.Format("区域 [{0}] 没有字段，开始复制列表区域字段", strTargetRegionId);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                            CopyListRegionFields(strSourceRegionId, strTargetRegionId, strSouPrjId, strTarPrjId, strUserId);
                        }
                        break;

                    case enumRegionType.QueryRegion_0001:
                        string strQueryCondition = string.Format("RegionId = '{0}'", strTargetRegionId);
                        bolHasFields = clsQryRegionFldsBL.IsExistRecord(strQueryCondition);
                        if (!bolHasFields)
                        {
                            string strLog = string.Format("区域 [{0}] 没有字段，开始复制查询区域字段", strTargetRegionId);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                            CopyQueryRegionFields(strSourceRegionId, strTargetRegionId, strSouPrjId, strTarPrjId, strUserId);
                        }
                        break;

                    case enumRegionType.DetailRegion_0006:
                        string strDetailCondition = string.Format("RegionId = '{0}'", strTargetRegionId);
                        bolHasFields = clsDetailRegionFldsBL.IsExistRecord(strDetailCondition);
                        if (!bolHasFields)
                        {
                            string strLog = string.Format("区域 [{0}] 没有字段，开始复制详细区域字段", strTargetRegionId);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                            CopyDetailRegionFields(strSourceRegionId, strTargetRegionId, strSouPrjId, strTarPrjId, strUserId);
                        }
                        break;

                    case enumRegionType.FeatureRegion_0008:
                        string strFeatureCondition = string.Format("RegionId = '{0}'", strTargetRegionId);
                        bolHasFields = clsFeatureRegionFldsBL.IsExistRecord(strFeatureCondition);
                        if (!bolHasFields)
                        {
                            string strLog = string.Format("区域 [{0}] 没有字段，开始复制功能区域字段", strTargetRegionId);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                            CopyFeatureRegionFields(strSourceRegionId, strTargetRegionId, strSouPrjId, strTarPrjId, strUserId);
                        }
                        break;

                    case enumRegionType.ExcelExportRegion_0007:
                        string strExcelCondition = string.Format("RegionId = '{0}'", strTargetRegionId);
                        bolHasFields = clsExcelExportRegionFldsBL.IsExistRecord(strExcelCondition);
                        if (!bolHasFields)
                        {
                            string strLog = string.Format("区域 [{0}] 没有字段，开始复制Excel导出区域字段", strTargetRegionId);
                            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                            CopyExcelExportRegionFields(strSourceRegionId, strTargetRegionId, strSouPrjId, strTarPrjId, strUserId);
                        }
                        break;
                }

                if (bolHasFields)
                {
                    string strLog = string.Format("区域 [{0}] 已有字段，跳过复制", strTargetRegionId);
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strLog);
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("确保区域有字段失败，TargetRegionId:[{0}]，错误:{1}",
                    strTargetRegionId, ex.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }
    }
}