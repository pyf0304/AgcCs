using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;
using System.Text;

using AGC.BusinessLogic;
using System.Diagnostics;
using System.IO;
using com.taishsoft.common;
using System.Data;

using AGC.Entity;
using com.taishsoft.datetime;
using AGC.BusinessLogicEx;
using CommonTable.Entity;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Const;

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
            clsPrjTabBL.objCommFun4BL = new clsCommFun4BL4PrjTab();
            clsFieldTabBL.objCommFun4BL = new clsCommFun4BL4FieldTab();
            clsFunction4GeneCodeBL.objCommFun4BL = new clsCommFun4BL4Function4GeneCode();
            clsPrjFeatureBL.objCommFun4BL = new clsCommFun4BL4PrjFeature();
            clsFunctionTypeBL.objCommFun4BL = new clsCommFun4BL4FunctionType();
            clsFunctionTemplateRelaBL.objCommFun4BL = new clsCommFun4BL4FunctionTemplateRela();
            clsFunctionGroupBL.objCommFun4BL = new clsCommFun4BL4FunctionGroup();
            //clsPrjObjectsBL.objCommFun4BL = new clsCommFun4BL4PrjObjects();
            clsSqlViewBL.objCommFun4BL = new clsCommFun4BL4SqlView();
            clsProjectsBL.objCommFun4BL = new clsCommFun4BL4Projects();
            clsUsersBL.objCommFun4BL = new clsCommFun4BL4Users();
            clsSQLDSTypeBL.objCommFun4BL = new clsCommFun4BL4SQLDSType();
            clsTabStateBL.objCommFun4BL = new clsCommFun4BL4TabState();
            clsTabTypeBL.objCommFun4BL = new clsCommFun4BL4TabType();
            clsPrjDataBaseBL.objCommFun4BL = new clsCommFun4BL4PrjDataBase();
            clsDataTypeAbbrBL.objCommFun4BL = new clsCommFun4BL4DataTypeAbbr();
            clsTabCheckErrorTypeBL.objCommFun4BL = new clsCommFun4BL4TabCheckErrorType();
            clsErrorLevelBL.objCommFun4BL = new clsCommFun4BL4ErrorLevel();
            clsApplicationTypeBL.objCommFun4BL = new clsCommFun4BL4ApplicationType();
            clsFieldTypeBL.objCommFun4BL = new clsCommFun4BL4FieldType();
            clsPrimaryTypeBL.objCommFun4BL = new clsCommFun4BL4PrimaryType();
            clsFuncModule_AgcBL.objCommFun4BL = new clsCommFun4BL4FuncModule_Agc();
            //clsProgLevelTypeBL.objCommFun4BL = new clsCommFun4BL4ProgLevelType();
            clsProgLangTypeBL.objCommFun4BL = new clsCommFun4BL4ProgLangType();
            clsPrjFeatureTypeBL.objCommFun4BL = new clsCommFun4BL4PrjFeatureType();
            clsFunctionRelaTypeBL.objCommFun4BL = new clsCommFun4BL4FunctionRelaType();
            clsFunctionTemplateBL.objCommFun4BL = new clsCommFun4BL4FunctionTemplate();
            clsCodeTypeBL.objCommFun4BL = new clsCommFun4BL4CodeType();
            clsSqlViewFldBL.objCommFun4BL = new clsCommFun4BL4SqlViewFld();
            clsTextResourceTypeBL.objCommFun4BL = new clsCommFun4BL4TextResourceType();
            clsTabRelationTypeBL.objCommFun4BL = new clsCommFun4BL4TabRelationType();
            clsSqlViewRelaTabBL.objCommFun4BL = new clsCommFun4BL4SqlViewRelaTab();
            clsSV_RelaTabTypeBL.objCommFun4BL = new clsCommFun4BL4SV_RelaTabType();
            clsPrjTabFldBL.objCommFun4BL = new clsCommFun4BL4PrjTabFld();
            clsUserRolesBL.objCommFun4BL = new clsCommFun4BL4UserRoles();
            clsFldOperationTypeBL.objCommFun4BL = new clsCommFun4BL4FldOperationType();
            //clsFldObjTabBL.objCommFun4BL = new clsCommFun4BL4FldObjTab();
            clsSoftStructureBL.objCommFun4BL = new clsCommFun4BL4SoftStructure();
            clsFldStateBL.objCommFun4BL = new clsCommFun4BL4FldState();
            clsErrorIdManageBL.objCommFun4BL = new clsCommFun4BL4ErrorIdManage();
            clsCtlTypeAbbrBL.objCommFun4BL = new clsCommFun4BL4CtlTypeAbbr();
            clsViewTypeCodeTabBL.objCommFun4BL = new clsCommFun4BL4ViewTypeCodeTab();
            clsUserCodePathBL.objCommFun4BL = new clsCommFun4BL4UserCodePath();
            clsUserStateBL.objCommFun4BL = new clsCommFun4BL4UserState();
            clsUserIdentityBL.objCommFun4BL = new clsCommFun4BL4UserIdentity();
            clsDepartmentInfoBL.objCommFun4BL = new clsCommFun4BL4DepartmentInfo();
            clsDepartmentTypeBL.objCommFun4BL = new clsCommFun4BL4DepartmentType();
            clsWebSrvClassBL.objCommFun4BL = new clsCommFun4BL4WebSrvClass();
            clsViewInfoBL.objCommFun4BL = new clsCommFun4BL4ViewInfo();
            clsUserCodePrjMainPathBL.objCommFun4BL = new clsCommFun4BL4UserCodePrjMainPath();
            clsViewRegionBL.objCommFun4BL = new clsCommFun4BL4ViewRegion();
            clsDGRegionBL.objCommFun4BL = new clsCommFun4BL4DGRegion();
            clsEditRegionBL.objCommFun4BL = new clsCommFun4BL4EditRegion();
            clsExcelExportRegionBL.objCommFun4BL = new clsCommFun4BL4ExcelExportRegion();
            clsFeatureRegionBL.objCommFun4BL = new clsCommFun4BL4FeatureRegion();
            clsQueryRegionBL.objCommFun4BL = new clsCommFun4BL4QueryRegion();
            //clsListViewRegionBL.objCommFun4BL = new clsCommFun4BL4ListViewRegion();

            clsDGRegionFldsBL.objCommFun4BL = new clsCommFun4BL4DGRegionFlds();
            clsEditRegionFldsBL.objCommFun4BL = new clsCommFun4BL4EditRegionFlds();
            clsExcelExportRegionFldsBL.objCommFun4BL = new clsCommFun4BL4ExcelExportRegionFlds();
            clsFeatureRegionFldsBL.objCommFun4BL = new clsCommFun4BL4FeatureRegionFlds();
            clsQryRegionFldsBL.objCommFun4BL = new clsCommFun4BL4QryRegionFlds();
            //clsListViewRegionFldsBL.objCommFun4BL = new clsCommFun4BL4ListViewRegionFlds();
            clsFeatureFuncRelaBL.objCommFun4BL = new clsCommFun4BL4FeatureFuncRela();
            clsDataGridStyleBL.objCommFun4BL = new clsCommFun4BL4DataGridStyle();
            clsAppCodeTypeRelaBL.objCommFun4BL = new clsCommFun4BL4AppCodeTypeRela();
            clsCharEncodingBL.objCommFun4BL = new clsCommFun4BL4CharEncoding();
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
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaBL.GetFirstObj_S(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingBLEx.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.AddNewRecordBySql2(objPrjUserCharEncodingRelaEN);
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
        
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeId_Cache(strProgLangTypeId);
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
            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaBL.GetFirstObj_S(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {
                string strCharEncodingId = clsCharEncodingBLEx.GetDefaultCharEncoding();
                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.AddNewRecordBySql2(objPrjUserCharEncodingRelaEN);
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

            clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = clsPrjUserCharEncodingRelaBL.GetFirstObj_S(strCondition);
            if (objPrjUserCharEncodingRelaEN == null)
            {

                objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCurrCharEncodingId;
                objPrjUserCharEncodingRelaEN.PrjId = strPrjId;
                objPrjUserCharEncodingRelaEN.UserId = strUserId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.AddNewRecordBySql2(objPrjUserCharEncodingRelaEN);

            }
            else
            {
                objPrjUserCharEncodingRelaEN.CharEncodingId = strCurrCharEncodingId;
                objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserCharEncodingRelaEN.UpdUserId = strUserId;
                clsPrjUserCharEncodingRelaBL.UpdateBySql2(objPrjUserCharEncodingRelaEN);
            }

            return strCurrCharEncodingId;
        }
        public static void AccessIsExistPath(clsvUserCodePathEN objvUserCodePathEN)
        {
            if (objvUserCodePathEN .IsExistCodePathP == false)
            {
                string strMsg = string.Format("代码层:[{0}({1})]的生成目录:[{2}]不存在！请检查！",
                    objvUserCodePathEN.CodeTypeName,
                    objvUserCodePathEN.CodeTypeId,
                    objvUserCodePathEN.NewCodePath);
                throw new Exception(strMsg);
            }
        }
        public static void AccessIsExistPath(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
        {
            if (objUserCodePrjMainPathEN == null)
            {
                string strMsg = string.Format("用户:[{0}]的生成主目录没有建立！请检查！",
                  clsSysParaEN.strUserId);
                throw new Exception(strMsg);
            }
            if (objUserCodePrjMainPathEN.IsExistCodePath == false)
            {
                clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = clsvUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(objUserCodePrjMainPathEN.UserCodePrjMainPathId);
                string strMsg = string.Format("用户:[{0}]的针对项目:[{1}]的生成主目录:[{2}]不存在！请检查！",
                    clsSysParaEN.strUserId,
                    objvUserCodePrjMainPathEN.ApplicationTypeName,
                    objUserCodePrjMainPathEN.CodePath);
                throw new Exception(strMsg);
            }
        }


        
    }
}