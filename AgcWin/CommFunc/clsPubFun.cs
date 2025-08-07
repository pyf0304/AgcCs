using System;
using System.Data;
using System.IO;
using System.Text;

using AGC.Entity;
using AGC4WApi;
using com.taishsoft.common;
using com.taishsoft.datetime;


namespace AGC_CSWin
{
    public static class clsPubFun
    {
        public const string conDefaultWebServiceSet = "DefaultWebServiceSet";
        public const string conBackupWebServiceSet = "BackupWebServiceSet";
        public const string conBackupWebServiceSet180_153_158_158 = "BackupWebServiceSet180_153_158_158";
        public const string conBackupWebServiceSet115_5 = "BackupWebServiceSet115_5";
        public const string conBackupWebServiceSet115_6 = "BackupWebServiceSet115_6";
        public const string conBackupWebServiceSet202_195_112_201 = "BackupWebServiceSet202_195_112_201";



        public static void SetCommFun4BL()
        {
            clsPrjTabWApi.objCommFun4WApi = new clsCommFun4WA4PrjTab();
            clsFieldTabWApi.objCommFun4WApi = new clsCommFun4WA4FieldTab();
            clsFunction4GeneCodeWApi.objCommFun4WApi = new clsCommFun4WA4Function4GeneCode();
            clsPrjFeatureWApi.objCommFun4WApi = new clsCommFun4WA4PrjFeature();
            clsFunctionTypeWApi.objCommFun4WApi = new clsCommFun4WA4FunctionType();
            clsFunctionTemplateRelaWApi.objCommFun4WApi = new clsCommFun4WA4FunctionTemplateRela();
            clsFunctionGroupWApi.objCommFun4WApi = new clsCommFun4WA4FunctionGroup();
            //clsPrjObjectsWApi.objCommFun4WApi = new clsCommFun4WA4PrjObjects();
            clsSqlViewWApi.objCommFun4WApi = new clsCommFun4WA4SqlView();
            clsProjectsWApi.objCommFun4WApi = new clsCommFun4WA4Projects();
            clsUsersWApi.objCommFun4WApi = new clsCommFun4WA4Users();
            clsSQLDSTypeWApi.objCommFun4WApi = new clsCommFun4WA4SQLDSType();
            clsTabStateWApi.objCommFun4WApi = new clsCommFun4WA4TabState();
            clsTabTypeWApi.objCommFun4WApi = new clsCommFun4WA4TabType();
            clsPrjDataBaseWApi.objCommFun4WApi = new clsCommFun4WA4PrjDataBase();
            clsDataTypeAbbrWApi.objCommFun4WApi = new clsCommFun4WA4DataTypeAbbr();
            clsTabCheckErrorTypeWApi.objCommFun4WApi = new clsCommFun4WA4TabCheckErrorType();
            clsErrorLevelWApi.objCommFun4WApi = new clsCommFun4WA4ErrorLevel();
            clsApplicationTypeWApi.objCommFun4WApi = new clsCommFun4WA4ApplicationType();
            clsFieldTypeWApi.objCommFun4WApi = new clsCommFun4WA4FieldType();
            clsPrimaryTypeWApi.objCommFun4WApi = new clsCommFun4WA4PrimaryType();
            clsFuncModule_AgcWApi.objCommFun4WApi = new clsCommFun4WA4FuncModule_Agc();
            //clsProgLevelTypeWApi.objCommFun4WApi = new clsCommFun4WA4ProgLevelType();
            clsProgLangTypeWApi.objCommFun4WApi = new clsCommFun4WA4ProgLangType();
            clsPrjFeatureTypeWApi.objCommFun4WApi = new clsCommFun4WA4PrjFeatureType();
            clsFunctionRelaTypeWApi.objCommFun4WApi = new clsCommFun4WA4FunctionRelaType();
            clsFunctionTemplateWApi.objCommFun4WApi = new clsCommFun4WA4FunctionTemplate();
            clsCodeTypeWApi.objCommFun4WApi = new clsCommFun4WA4CodeType();
            clsSqlViewFldWApi.objCommFun4WApi = new clsCommFun4WA4SqlViewFld();
            clsTextResourceTypeWApi.objCommFun4WApi = new clsCommFun4WA4TextResourceType();
            clsTabRelationTypeWApi.objCommFun4WApi = new clsCommFun4WA4TabRelationType();
            clsSqlViewRelaTabWApi.objCommFun4WApi = new clsCommFun4WA4SqlViewRelaTab();
            clsSV_RelaTabTypeWApi.objCommFun4WApi = new clsCommFun4WA4SV_RelaTabType();
            clsPrjTabFldWApi.objCommFun4WApi = new clsCommFun4WA4PrjTabFld();
            clsUserRolesWApi.objCommFun4WApi = new clsCommFun4WA4UserRoles();
            clsFldOperationTypeWApi.objCommFun4WApi = new clsCommFun4WA4FldOperationType();
            //clsFldObjTabWApi.objCommFun4WApi = new clsCommFun4WA4FldObjTab();
            clsSoftStructureWApi.objCommFun4WApi = new clsCommFun4WA4SoftStructure();
            clsFldStateWApi.objCommFun4WApi = new clsCommFun4WA4FldState();
            clsErrorIdManageWApi.objCommFun4WApi = new clsCommFun4WA4ErrorIdManage();
            clsCtlTypeWApi.objCommFun4WApi = new clsCommFun4WA4CtlType();
            clsViewTypeCodeTabWApi.objCommFun4WApi = new clsCommFun4WA4ViewTypeCodeTab();
            clsUserCodePathWApi.objCommFun4WApi = new clsCommFun4WA4UserCodePath();
            clsUserStateWApi.objCommFun4WApi = new clsCommFun4WA4UserState();
            clsUserIdentityWApi.objCommFun4WApi = new clsCommFun4WA4UserIdentity();
            clsDepartmentInfoWApi.objCommFun4WApi = new clsCommFun4WA4DepartmentInfo();
            clsDepartmentTypeWApi.objCommFun4WApi = new clsCommFun4WA4DepartmentType();
            clsWebSrvClassWApi.objCommFun4WApi = new clsCommFun4WA4WebSrvClass();
            //clsViewInfoWApi.objCommFun4WApi = new clsCommFun4WA4ViewInfo();
            clsUserCodePrjMainPathWApi.objCommFun4WApi = new clsCommFun4WA4UserCodePrjMainPath();
            clsViewRegionWApi.objCommFun4WApi = new clsCommFun4WA4ViewRegion();
            //clsDGRegionWApi.objCommFun4WApi = new clsCommFun4WA4DGRegion();
            //clsEditRegionWApi.objCommFun4WApi = new clsCommFun4WA4EditRegion();
            //clsExcelExportRegionWApi.objCommFun4WApi = new clsCommFun4WA4ExcelExportRegion();
            //clsFeatureRegionWApi.objCommFun4WApi = new clsCommFun4WA4FeatureRegion();
            //clsQueryRegionWApi.objCommFun4WApi = new clsCommFun4WA4QueryRegion();
            //clsListViewRegionWApi.objCommFun4WApi = new clsCommFun4WA4ListViewRegion();

            clsDGRegionFldsWApi.objCommFun4WApi = new clsCommFun4WA4DGRegionFlds();
            clsEditRegionFldsWApi.objCommFun4WApi = new clsCommFun4WA4EditRegionFlds();
            clsExcelExportRegionFldsWApi.objCommFun4WApi = new clsCommFun4WA4ExcelExportRegionFlds();
            clsFeatureRegionFldsWApi.objCommFun4WApi = new clsCommFun4WA4FeatureRegionFlds();
            clsQryRegionFldsWApi.objCommFun4WApi = new clsCommFun4WA4QryRegionFlds();
            //clsListViewRegionFldsWApi.objCommFun4WApi = new clsCommFun4WA4ListViewRegionFlds();
            clsFeatureFuncRelaWApi.objCommFun4WApi = new clsCommFun4WA4FeatureFuncRela();
            clsDataGridStyleWApi.objCommFun4WApi = new clsCommFun4WA4DataGridStyle();
            clsAppCodeTypeRelaWApi.objCommFun4WApi = new clsCommFun4WA4AppCodeTypeRela();
            clsCharEncodingWApi.objCommFun4WApi = new clsCommFun4WA4CharEncoding();
            clsWebApiIPAndPortTabWApi.objCommFun4WApi = new clsCommFun4WA4WebApiIPAndPortTab();
            clsAppPageTypeWApi.objCommFun4WApi = new clsCommFun4WA4AppPageType();
            clsPrjFuncTemplateRelaWApi.objCommFun4WApi = new clsCommFun4WA4PrjFuncTemplateRela();
            clsFunction4CodeWApi.objCommFun4WApi = new clsCommFun4WA4Function4Code();
            clsFuncGCTypeWApi.objCommFun4WApi = new clsCommFun4WA4FuncGCType();
            clsRegionTypeWApi.objCommFun4WApi = new clsCommFun4WA4RegionType();
            clsInOutTypeWApi.objCommFun4WApi = new clsCommFun4WA4InOutType();
            clsPrjFileStateWApi.objCommFun4WApi = new clsCommFun4WA4PrjFileState();
            clsTabMainTypeWApi.objCommFun4WApi = new clsCommFun4WA4TabMainType();
            clsCMProjectWApi.objCommFun4WApi = new clsCommFun4WA4CMProject();
            clsTabCheckStatusWApi.objCommFun4WApi = new clsCommFun4WA4TabCheckStatus();
            clsCacheModeWApi.objCommFun4WApi = new clsCommFun4WA4CacheMode();
            clsViewRegionRelaWApi.objCommFun4WApi = new clsCommFun4WA4ViewRegionRela();
            clsFileResExcludePathWApi.objCommFun4WApi = new clsCommFun4WA4FileResExcludePath();
            clsUserCodePrjMainPath_MachineNameWApi.objCommFun4WApi = new clsCommFun4WA4UserCodePrjMainPath_MachineName();
        }
        public static string GetWebServiceSet()
        {
            string strWebServiceSet = "";
            try
            {
                string strCondition = new clsUserWebSrvSetEN()
                    .SetUserId(clsSysParaEN.strUserId)
                    .SetMachineName(Environment.MachineName)
                    .GetUniConditionStr();
                clsUserWebSrvSetEN objUserWebSrvSet = clsUserWebSrvSetWApi.GetFirstObj(strCondition);
                if (objUserWebSrvSet == null)
                {
                    strCondition = string.Format("1=1 Order By {0}", conWebApiIPAndPortTab.OrderNum);
                    clsWebApiIPAndPortTabEN objWebApiIPAndPortTab = clsWebApiIPAndPortTabWApi.GetFirstObj(strCondition);

                    objUserWebSrvSet = new clsUserWebSrvSetEN()
                           .SetUserId(clsSysParaEN.strUserId)
                    .SetMachineName(Environment.MachineName)
                    .SetWebApiIPAndPort(objWebApiIPAndPortTab.WebApiIPAndPort)
                    .SetWebApiVirtualPath(objWebApiIPAndPortTab.WebApiVirtualPath);
                    objUserWebSrvSet.EditRecordEx();
                }
                clsSysPara4WebApi_Agc.strCurrIPAddressAndPort = objUserWebSrvSet.WebApiIPAndPort;// "103.116.76.183";
                clsSysPara4WebApi_Agc.strCurrPrx = objUserWebSrvSet.WebApiVirtualPath;
            }
            catch (Exception objException)
            {
                throw objException;
            }


            return strWebServiceSet;
        }
        /// <summary>
        /// 检查WebApi地址是否可用
        /// </summary>
        /// <returns>若可用返回True</returns>
        public static bool CheckWebApi()
        {
            int c = AutoGeneCodeWApi.Plus(11, 22);
            if (c == 33) return true;
            return false;
        }
        /// <summary>
        /// 插入序号
        /// </summary>
        public static void InsertOrderNum(DataTable objDT, string strColumnName)
        {

            objDT.Columns.Add(strColumnName);
            int intOrderNum = 1;
            foreach (DataRow objDTRow in objDT.Rows)
            {
                objDTRow[strColumnName] = intOrderNum.ToString();
                intOrderNum++;
            }
        }

        public static Encoding GetEncodingByPrjUser(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            string strCurrCharEncodingId = "";
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaWApi.GetFirstObj(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingExWApi.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaWApi.AddNewRecord(objPrjUserCharEncodingRelaEN);
                strCurrCharEncodingId = strCharEncodingId;
            }
            else
            {
                strCurrCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId;
            }
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCurrCharEncodingId);
            return myEncoding;
        }
        /// <summary>
        /// 根据语言类型Id获取字符编码
        /// </summary>
        /// <param name="strProgLangTypeId"></param>
        /// <returns></returns>
        public static string GetCharEncodingIdByLangTypeId(string strProgLangTypeId)
        {

            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            string strCharEncodingId;
            if (objProgLangTypeEN == null)
            {
                strCharEncodingId = objProgLangTypeEN.CharEncodingId;
            }
            else
            {
                strCharEncodingId = objProgLangTypeEN.CharEncodingId;
            }

            return strCharEncodingId;
        }


        public static string GetCharEncodingIdByPrjUser1(string strPrjId, string strUserId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
            string strCurrCharEncodingId = "";
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaWApi.GetFirstObj(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingExWApi.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaWApi.AddNewRecord(objPrjUserCharEncodingRelaEN);
                strCurrCharEncodingId = strCharEncodingId;
            }
            else
            {
                strCurrCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId;
            }

            return strCurrCharEncodingId;
        }


        public static string SaveCharEncodingId4PrjUser1(string strPrjId, string strUserId, string strCurrCharEncodingId)
        {
            string strCondition = string.Format("PrjId='{0}' And UserId='{1}'", strPrjId, strUserId);

            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaWApi.GetFirstObj(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {

                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCurrCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaWApi.AddNewRecord(objPrjUserCharEncodingRelaEN);

            }
            else
            {
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCurrCharEncodingId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                objPrjUserCharEncodingRelaEN.Update();
            }

            return strCurrCharEncodingId;
        }
        public static void AccessIsExistPath(clsvUserCodePathEN objvUserCodePathEN)
        {
            if (objvUserCodePathEN.IsExistCodePathP == false)
            {
                string strMsg = string.Format("代码层:[{0}({1})]的生成目录:[{2}]不存在！请检查！",
                    objvUserCodePathEN.CodeTypeName,
                    objvUserCodePathEN.CodeTypeId,
                    objvUserCodePathEN.NewCodePath);
                throw new Exception(strMsg);
            }
        }
        public static void AccessIsExistPath(clsUserCodePathENEx objUserCodePathEN)
        {
            clsvCodeType_SimEN objCodeType = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(objUserCodePathEN.CodeTypeId);
            if (objUserCodePathEN.IsExistCodePathP == false)
            {
                string strMsg = string.Format("代码层:[{0}({1})]的生成目录:[{2}]不存在！请检查！",
                    objCodeType.CodeTypeName,
                    objUserCodePathEN.CodeTypeId,
                    objUserCodePathEN.NewCodePath);
                throw new Exception(strMsg);
            }
        }
        public static void AccessIsExistPathBak(clsUserCodePrjMainPathENEx objUserCodePrjMainPathEN)
        {
            if (objUserCodePrjMainPathEN == null)
            {
                string strMsg = string.Format("用户:[{0}]的生成主目录没有建立！请检查！",
                  clsSysParaEN.strUserId);
                throw new Exception(strMsg);
            }
            if (objUserCodePrjMainPathEN.IsExistCodePath == false)
            {
                if (Directory.Exists(objUserCodePrjMainPathEN.CodePath) == true)
                {
                    objUserCodePrjMainPathEN.IsExistCodePath = true;
                    //clsUserCodePrjMainPath_MachineNameExWApi.SetIsExistCodePath(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.MachineName, true);
                    objUserCodePrjMainPathEN.Update();
                    return;
                }
                clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = clsvUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(objUserCodePrjMainPathEN.UserCodePrjMainPathId);
                string strMsg = string.Format("用户:[{0}]的针对项目:[{1}]的生成主目录:[{2}]不存在！请检查！",
                    clsSysParaEN.strUserId,
                    objvUserCodePrjMainPathEN.ApplicationTypeName,
                    objUserCodePrjMainPathEN.CodePath);
                throw new Exception(strMsg);
            }
        }
        public static void SetIsShareCodePath(clsUserCodePathENEx objUserCodePathEx, clsvPrjTab_SimENEx objPrjTabEx)
        {

            if (objPrjTabEx.IsShare)
            {
                objUserCodePathEx.NewCodePath = objUserCodePathEx.NewCodePath.Replace("L3ForWApiEx\\", "L3ForWApiExShare\\");
                objUserCodePathEx.FullCodePath = objUserCodePathEx.FullCodePath.Replace("L3ForWApiEx\\", "L3ForWApiExShare\\");
            }
            else
            {
                objUserCodePathEx.NewCodePath = objUserCodePathEx.NewCodePath.Replace("L3ForWApiExShare\\", "L3ForWApiEx\\");
                objUserCodePathEx.FullCodePath = objUserCodePathEx.FullCodePath.Replace("L3ForWApiExShare\\", "L3ForWApiEx\\");
            }
        }
        public static void SetIsShareCodePath(clsvUserCodePathEN objUserCodePathEN, clsvPrjTab_SimEN objPrjTabEx)
        {

            if (objPrjTabEx.IsShare)
            {
                objUserCodePathEN.NewCodePath = objUserCodePathEN.NewCodePath.Replace("L3ForWApiEx\\", "L3ForWApiExShare\\");
                //objUserCodePathEN.FullCodePath = objUserCodePathEN.FullCodePath.Replace("L3ForWApiEx\\", "L3ForWApiExShare\\");
            }
            else
            {
                objUserCodePathEN.NewCodePath = objUserCodePathEN.NewCodePath.Replace("L3ForWApiExShare\\", "L3ForWApiEx\\");
                //objUserCodePathEN.FullCodePath = objUserCodePathEN.FullCodePath.Replace("L3ForWApiExShare\\", "L3ForWApiEx\\");
            }
        }
    }
}