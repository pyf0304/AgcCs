using AGC.BusinessLogic;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsPubFun4BLEx
    {
        public static void SetCommFun4BL()
        {
            //---------A-----------//
            clsDataTypeAbbrBL.objCommFun4BL = new clsCommFun4BL4DataTypeAbbr();

            clsPrjFeatureBL.objCommFun4BL = new clsCommFun4BL4PrjFeature();
            clsFunctionTypeBL.objCommFun4BL = new clsCommFun4BL4FunctionType();
            clsFunctionTemplateRelaBL.objCommFun4BL = new clsCommFun4BL4FunctionTemplateRela();
            clsFunctionGroupBL.objCommFun4BL = new clsCommFun4BL4FunctionGroup();
            //clsPrjObjectsBL.objCommFun4BL = new clsCommFun4BL4PrjObjects();
            clsSqlViewBL.objCommFun4BL = new clsCommFun4BL4SqlView();

            clsDGRegionFldsBL.objCommFun4BL = new clsCommFun4BL4DGRegionFlds();
            clsEditRegionFldsBL.objCommFun4BL = new clsCommFun4BL4EditRegionFlds();
            clsExcelExportRegionFldsBL.objCommFun4BL = new clsCommFun4BL4ExcelExportRegionFlds();

            //---------F-----------//
            clsFeatureRegionFldsBL.objCommFun4BL = new clsCommFun4BL4FeatureRegionFlds();
            clsGCPathBL.objCommFun4BL = new clsCommFun4BL4GCPath();
            clsFieldTabBL.objCommFun4BL = new clsCommFun4BL4FieldTab();
            clsFunction4GeneCodeBL.objCommFun4BL = new clsCommFun4BL4Function4GeneCode();
            clsErrorLevelBL.objCommFun4BL = new clsCommFun4BL4ErrorLevel();
            clsApplicationTypeBL.objCommFun4BL = new clsCommFun4BL4ApplicationType();
            clsFieldTypeBL.objCommFun4BL = new clsCommFun4BL4FieldType();
            clsPrimaryTypeBL.objCommFun4BL = new clsCommFun4BL4PrimaryType();
            clsFuncModule_AgcBL.objCommFun4BL = new clsCommFun4BL4FuncModule_Agc();
            //---------P-----------//
            clsPrjTabBL.objCommFun4BL = new clsCommFun4BL4PrjTab();

            clsProjectsBL.objCommFun4BL = new clsCommFun4BL4Projects();
            clsUsersBL.objCommFun4BL = new clsCommFun4BL4Users();
            clsSQLDSTypeBL.objCommFun4BL = new clsCommFun4BL4SQLDSType();
            clsTabStateBL.objCommFun4BL = new clsCommFun4BL4TabState();
            clsTabTypeBL.objCommFun4BL = new clsCommFun4BL4TabType();
            clsPrjDataBaseBL.objCommFun4BL = new clsCommFun4BL4PrjDataBase();

            //---------T-----------//

            clsTabCheckErrorTypeBL.objCommFun4BL = new clsCommFun4BL4TabCheckErrorType();

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
            //---------V-----------//
            
            clsSoftStructureBL.objCommFun4BL = new clsCommFun4BL4SoftStructure();
            clsFldStateBL.objCommFun4BL = new clsCommFun4BL4FldState();
            clsErrorIdManageBL.objCommFun4BL = new clsCommFun4BL4ErrorIdManage();
            clsViewInfoBL.objCommFun4BL = new clsCommFun4BL4ViewInfo();
            clsViewGroupBL.objCommFun4BL = new clsCommFun4BL4ViewGroup();
            clsViewTypeCodeTabBL.objCommFun4BL = new clsCommFun4BL4ViewTypeCodeTab();
            clsCtlTypeBL.objCommFun4BL = new clsCommFun4BL4CtlType();
            clsDepartmentInfoBL.objCommFun4BL = new clsCommFun4BL4DepartmentInfo();
            //  clsProjectsBL.objCommFun4BL = new clsCommFun4BL4Projects();
            clsWebSrvClassBL.objCommFun4BL = new clsCommFun4BL4WebSrvClass();
            clsDict4GCBL.objCommFun4BL = new clsCommFun4BL4Dict4GC();
            clsDictType4GCBL.objCommFun4BL = new clsCommFun4BL4DictType4GC();
            clsDataBaseModuleRelaBL.objCommFun4BL = new clsCommFun4BL4DataBaseModuleRela();
            clsUserCodePathBL.objCommFun4BL = new clsCommFun4BL4UserCodePath();
            clsUserCodePrjMainPathBL.objCommFun4BL = new clsCommFun4BL4UserCodePrjMainPath();

            clsFuncPara4CodeBL.objCommFun4BL = new clsCommFun4BL4FuncPara4Code();
            clsFunction4CodeBL.objCommFun4BL = new clsCommFun4BL4Function4Code();
            clsUserStateBL.objCommFun4BL = new clsCommFun4BL4UserState();
            clsUserIdentityBL.objCommFun4BL = new clsCommFun4BL4UserIdentity();
            clsDepartmentTypeBL.objCommFun4BL = new clsCommFun4BL4DepartmentType();
            clsFuncGCTypeBL.objCommFun4BL = new clsCommFun4BL4FuncGCType();
            clsViewRegionBL.objCommFun4BL = new clsCommFun4BL4ViewRegion();
            //clsDGRegionBL.objCommFun4BL = new clsCommFun4BL4DGRegion();
            //clsEditRegionBL.objCommFun4BL = new clsCommFun4BL4EditRegion();
            //clsExcelExportRegionBL.objCommFun4BL = new clsCommFun4BL4ExcelExportRegion();
            //clsFeatureRegionBL.objCommFun4BL = new clsCommFun4BL4FeatureRegion();
            //clsQueryRegionBL.objCommFun4BL = new clsCommFun4BL4QueryRegion();
            //clsListViewRegionBL.objCommFun4BL = new clsCommFun4BL4ListViewRegion();

            clsQryRegionFldsBL.objCommFun4BL = new clsCommFun4BL4QryRegionFlds();
            //clsListViewRegionFldsBL.objCommFun4BL = new clsCommFun4BL4ListViewRegionFlds();
            clsFeatureFuncRelaBL.objCommFun4BL = new clsCommFun4BL4FeatureFuncRela();
            clsDataGridStyleBL.objCommFun4BL = new clsCommFun4BL4DataGridStyle();
            clsAppPageTypeBL.objCommFun4BL = new clsCommFun4BL4AppPageType();
            clsAppCodeTypeRelaBL.objCommFun4BL = new clsCommFun4BL4AppCodeTypeRela();
            clsFieldTab4RootFldBL.objCommFun4BL = new clsCommFun4BL4FieldTab4RootFld();
            clsCharEncodingBL.objCommFun4BL = new clsCommFun4BL4CharEncoding();
            clsFeatureButtonRelaBL.objCommFun4BL = new clsCommFun4BL4FeatureButtonRela();
            clsButtonTabBL.objCommFun4BL = new clsCommFun4BL4ButtonTab();
            clsValueGivingModeBL.objCommFun4BL = new clsCommFun4BL4ValueGivingMode();
            clsTabFeatureBL.objCommFun4BL = new clsCommFun4BL4TabFeature();
            clsRegionTypeBL.objCommFun4BL = new clsCommFun4BL4RegionType();
            clsInOutTypeBL.objCommFun4BL = new clsCommFun4BL4InOutType();
            clswf_WorkFlowBL.objCommFun4BL = new clsCommFun4BL4wf_WorkFlow();
            clswf_StepPointRelaBL.objCommFun4BL = new clsCommFun4BL4wf_StepPointRela();
            clswf_PointBL.objCommFun4BL = new clsCommFun4BL4wf_Point();
            clswf_ProcessBL.objCommFun4BL = new clsCommFun4BL4wf_Process();
            clswf_PointTypeBL.objCommFun4BL = new clsCommFun4BL4wf_PointType();
            clswf_ProjectsBL.objCommFun4BL = new clsCommFun4BL4wf_Projects();
            clswf_StepProcessRelaBL.objCommFun4BL = new clsCommFun4BL4wf_StepProcessRela();
            clsFuncAccessModeBL.objCommFun4BL = new clsCommFun4BL4FuncAccessMode();
            clsFuncParaRelaBL.objCommFun4BL = new clsCommFun4BL4FuncParaRela();
            clsSortTypeBL.objCommFun4BL = new clsCommFun4BL4SortType();
            clsConstraintTypeBL.objCommFun4BL = new clsCommFun4BL4ConstraintType();
            clsCMFuncParaRelaBL.objCommFun4BL = new clsCommFun4BL4CMFuncParaRela();
            clsCMFuncParaBL.objCommFun4BL = new clsCommFun4BL4CMFuncPara();
            clsCMFeatureTypeBL.objCommFun4BL = new clsCommFun4BL4CMFeatureType();
            clsFeatureFieldTypeRelaBL.objCommFun4BL = new clsCommFun4BL4FeatureFieldTypeRela();
            clsFunctionPurposeBL.objCommFun4BL = new clsCommFun4BL4FunctionPurpose();
            clsMethodModifierBL.objCommFun4BL = new clsCommFun4BL4MethodModifier();
            clsTabFeatureFldsBL.objCommFun4BL = new clsCommFun4BL4TabFeatureFlds();
            clsCMFeatureRequirementBL.objCommFun4BL = new clsCommFun4BL4CMFeatureRequirement();
            clsCMRequirementBL.objCommFun4BL = new clsCommFun4BL4CMRequirement();
            clsCMRequirementTypeBL.objCommFun4BL = new clsCommFun4BL4CMRequirementType();
            clsCMFeatureBL.objCommFun4BL = new clsCommFun4BL4CMFeature();
            clsUseStateBL.objCommFun4BL = new clsCommFun4BL4UseState();
            clsCMProjectBL.objCommFun4BL = new clsCommFun4BL4CMProject();
            clsPrjConstraintBL.objCommFun4BL = new clsCommFun4BL4PrjConstraint();
            clsTabFeatureBL.objCommFun4BL = new clsCommFun4BL4TabFeature();
            clsTabFunctionPropBL.objCommFun4BL = new clsCommFun4BL4TabFunctionProp();
            clsConstraintFieldsBL.objCommFun4BL = new clsCommFun4BL4ConstraintFields();
            clsSysDefaValNameBL.objCommFun4BL = new clsCommFun4BL4SysDefaValName();
            clsUserDefaValue_LocalBL.objCommFun4BL = new clsCommFun4BL4UserDefaValue_Local();
            clsViewStyleBL.objCommFun4BL = new clsCommFun4BL4ViewStyle();
            clsPrjFuncTemplateRelaBL.objCommFun4BL = new clsCommFun4BL4PrjFuncTemplateRela();
            clsViewTabTypeBL.objCommFun4BL = new clsCommFun4BL4ViewTabType();
            clsDDLItemsOptionBL.objCommFun4BL = new clsCommFun4BL4DDLItemsOption();
            clsDgFuncTypeBL.objCommFun4BL = new clsCommFun4BL4DgFuncType();

            clsQueryOptionBL.objCommFun4BL = new clsCommFun4BL4QueryOption();
            clsViewImplementationBL.objCommFun4BL = new clsCommFun4BL4ViewImplementation();
            clsButtonStyleBL.objCommFun4BL = new clsCommFun4BL4ButtonStyle();
            clsLabelStyleBL.objCommFun4BL = new clsCommFun4BL4LabelStyle();
            clsGenCtlStyleBL.objCommFun4BL = new clsCommFun4BL4GenCtlStyle();
            clsCheckStyleBL.objCommFun4BL = new clsCommFun4BL4CheckStyle();
            clsTitleStyleBL.objCommFun4BL = new clsCommFun4BL4TitleStyle();
            clsViewFeatureFldsBL.objCommFun4BL = new clsCommFun4BL4ViewFeatureFlds();
            clsPrjFileStateBL.objCommFun4BL = new clsCommFun4BL4PrjFileState();
            clsCMClassBL.objCommFun4BL = new clsCommFun4BL4CMClass();
            clsTabMainTypeBL.objCommFun4BL = new clsCommFun4BL4TabMainType();
            clsCacheModeBL.objCommFun4BL = new clsCommFun4BL4CacheMode();
            clsFileResourceBL.objCommFun4BL = new clsCommFun4BL4FileResource();
            //clsDetailRegionBL.objCommFun4BL = new clsCommFun4BL4DetailRegion();
            clsDetailRegionFldsBL.objCommFun4BL = new clsCommFun4BL4DetailRegionFlds();
            clsPageDispModeBL.objCommFun4BL = new clsCommFun4BL4PageDispMode();
            clsCMProjectFuncModuleBL.objCommFun4BL = new clsCommFun4BL4CMProjectFuncModule();
            clsViewMasterBL.objCommFun4BL = new clsCommFun4BL4ViewMaster();
            clsGCVariableBL.objCommFun4BL = new clsCommFun4BL4GCVariable();
            clsGCVariableTypeBL.objCommFun4BL = new clsCommFun4BL4GCVariableType();
            clsGCKeyIdGetModeBL.objCommFun4BL = new clsCommFun4BL4GCKeyIdGetMode();
            clsGCContainerTypeBL.objCommFun4BL = new clsCommFun4BL4GCContainerType();
            clsTabCheckStatusBL.objCommFun4BL = new clsCommFun4BL4TabCheckStatus();
            clsViewReferFilesBL.objCommFun4BL = new clsCommFun4BL4ViewReferFiles();
            clsSqlViewRelaTabBL.objCommFun4BL = new clsCommFun4BL4SqlViewRelaTab();
            clsDataNodeBL.objCommFun4BL = new clsCommFun4BL4DataNode();
            clsDnFuncMapBL.objCommFun4BL = new clsCommFun4BL4DnFuncMap();
            clsDnFunctionBL.objCommFun4BL = new clsCommFun4BL4DnFunction();
            clsReferFilesBL.objCommFun4BL = new clsCommFun4BL4ReferFiles();
            clsAssociationMappingBL.objCommFun4BL = new clsCommFun4BL4AssociationMapping();
            clsFuncMapModeBL.objCommFun4BL = new clsCommFun4BL4FuncMapMode();
            clsDataNodeTypeBL.objCommFun4BL = new clsCommFun4BL4DataNodeType();
            clsViewRegionRelaBL.objCommFun4BL = new clsCommFun4BL4ViewRegionRela();
            clsCmProjectPrjTabBL.objCommFun4BL = new clsCommFun4BL4CmProjectPrjTab();
            clsDataBaseTypeBL.objCommFun4BL = new clsCommFun4BL4DataBaseType();
            clsFieldTab4CodeConvBL.objCommFun4BL = new clsCommFun4BL4FieldTab4CodeConv();
        }

        /// <summary>
        /// 检查界面的DG类型是否为空!
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        public static void CheckDgStyleId4ViewInfo(string strDgStyleId)
        {
            if (string.IsNullOrEmpty(strDgStyleId) == true)
            {
                string strMsg = "界面的Dg类型为空,请重新《设置界面模式》,设置Dg类型!";
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 检查界面的标题类型是否为空!
        /// </summary>
        /// <param name = "strTitleStyleId"></param>
        public static void CheckTitleStyleId4ViewInfo(string strTitleStyleId)
        {
            if (string.IsNullOrEmpty(strTitleStyleId) == true || strTitleStyleId == "0")
            {
                string strMsg = "界面的标题类型为空,请重新《设置界面模式》,设置标题类型!";
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name = "objPrjTabFldENEx"></param>
        /// <param name = "ltLangType"></param>
        /// <returns></returns>
        public static bool CheckDataType(clsPrjTabFldENEx objPrjTabFldENEx, clsPubConst.LangType ltLangType)
        {
            //string PropStr == "");
            //string strFormat = "字段信息中，Java数据类型不能为空。({0})";
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType) == true)
                    {
                        string strMsg = string.Format("字段信息中，C#数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                          objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType) == true)
                    {
                        string strMsg = string.Format("字段信息中，C#数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                          objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                case clsPubConst.LangType.JAVA:
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType) == true)
                    {
                        string strMsg = string.Format("字段信息中，Java数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                           objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                case clsPubConst.LangType.Swift:
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType) == true)
                    {
                        string strMsg = string.Format("字段信息中，Swift数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                           objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                case clsPubConst.LangType.Swift3:
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType) == true)
                    {
                        string strMsg = string.Format("字段信息中，Swift3数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                           objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                case clsPubConst.LangType.Swift4:
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType) == true)
                    {
                        string strMsg = string.Format("字段信息中，Swift4数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                           objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                case clsPubConst.LangType.JavaScript:
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType) == true)
                    {
                        string strMsg = string.Format("字段信息中，Java数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                           objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                case clsPubConst.LangType.TypeScript:
                    if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType) == true)
                    {
                        string strMsg = string.Format("字段信息中，TypeScript数据类型不能为空。字段名:{1}({2}).({0})",
                          clsStackTrace.GetCurrClassFunctionByLevel(2),
                           objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                          objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                        throw new Exception(strMsg);
                    }
                    break;
                default:
                    string strMsg2 = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg2);

            }
            return true;
        }


        public static bool CheckSessionStorageVar(ISessionStorageVar objSessionStorageVar)
        {
            var strPrjId = objSessionStorageVar.PrjId;
            //var strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(objSessionStorageVar.CmPrjId);
            string strMsg = "";
            if (string.IsNullOrEmpty(objSessionStorageVar.VarId) == true)
            {
                strMsg = string.Format("控件:[{0}]中，变量id(VarId)不能为空.({1})",
                    objSessionStorageVar.LabelCaption,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(objSessionStorageVar.VarId);
            if (objGCVariable == null)
            {
                strMsg = string.Format("控件:[{0}]中，变量id(VarId)所对应的对象为空.({1})",
                    objSessionStorageVar.LabelCaption,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }

        public static bool CheckComboBox(IComboBox objComboBox, string strViewId, string strCmPrjId)
        {
            //var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(objComboBox.PrjId);
            var strPrjId = objComboBox.PrjId;
            if (objComboBox.DdlItemOptionId == enumDDLItemsOption.TrueAndFalseList_04)
            {
                return true;
            }
            //string PropStr == "");
            //string strFormat = "字段信息中，Java数据类型不能为空。({0})";
            string strMsg = "";
            if (string.IsNullOrEmpty(objComboBox.DsTabId) == true)
            {
                strMsg = string.Format("控件:[{0}]中，数据源表id（DsTabId）不能为空.({1})",
                    objComboBox.LabelCaption,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objComboBox.DsTabId, strPrjId);
            if (clsCmProjectPrjTabBLEx.IsExistRecord(strCmPrjId, objComboBox.DsTabId) == false)
            {
                strMsg = string.Format("控件:[{0}]中，数据源表:[{1}]不属于:[{2}]id不能为空.({3})",
                   objComboBox.LabelCaption, objPrjTab.TabName, strPrjId,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }

            if (string.IsNullOrEmpty(objComboBox.TabFeatureId4Ddl) == true)
            {
                strMsg = string.Format("控件:[{0}]中，数据源表的表功能为空！({1})",
                 objComboBox.LabelCaption,
               clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objComboBox.TabFeatureId4Ddl, strPrjId);
            if (objTabFeature.TabId != objComboBox.DsTabId)
            {
                strMsg = string.Format("控件:[{0}]中，数据源表:[{1}]中没有表功能:[{2}].({3})",
                   objComboBox.LabelCaption, objPrjTab.TabName, objTabFeature.TabFeatureName,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, strPrjId);
            var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
            if (arrTabFeatureFlds_Cond.Count >= 2)
            {
                string strFldName_Cond2 = arrTabFeatureFlds_Cond[1].FldName();
                if (string.IsNullOrEmpty(objComboBox.VarIdCond2) == true)
                {
                    strMsg = string.Format("控件:[{0}]中，数据源表:[{1}]的表功能:[{2}]没有变量2({3}).({4})",
                   objComboBox.LabelCaption, objPrjTab.TabName, objTabFeature.TabFeatureName,
                   strFldName_Cond2,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                    throw new Exception(strMsg);
                }
            }
            if (arrTabFeatureFlds_Cond.Count >= 1)
            {
                var objTabFeatureFlds = arrTabFeatureFlds_Cond[0];
                if (string.IsNullOrEmpty(objTabFeatureFlds.DefaultValue) == true)
                {
                    string strFldName_Cond1 = arrTabFeatureFlds_Cond[0].FldName();
                    if (string.IsNullOrEmpty(objComboBox.VarIdCond1) == true)
                    {
                        strMsg = string.Format("控件:[{0}]中，数据源表:[{1}]的表功能:[{2}]没有变量1({3}).({4})",
                       objComboBox.LabelCaption, objPrjTab.TabName, objTabFeature.TabFeatureName,
                       strFldName_Cond1,
                     clsStackTrace.GetCurrClassFunctionByLevel(2));
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (clsGCVariablePrjIdRelaBL.IsExist(objComboBox.VarIdCond1, strPrjId) == false)
                        {
                            strMsg = $"控件:[{objComboBox.LabelCaption}]中，数据源表:[{objPrjTab.TabName}]的表功能:[{objTabFeature.TabFeatureName}]变量1：{objComboBox.VarIdCond1}在工程:{strPrjId}中不存在，请检查 ！";
                            throw new Exception(strMsg);
                        }
                        if (clsViewIdGCVariableRelaBL.IsExist(objComboBox.VarIdCond1, strViewId) == false)
                        {
                            var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);

                            strMsg = $"控件:[{objComboBox.LabelCaption}]中，数据源表:[{objPrjTab.TabName}]的表功能:[{objTabFeature.TabFeatureName}]变量1：{objComboBox.VarIdCond1}在界面:{objViewInfo.ViewName}({strViewId})的变量表中不存在，请检查 ！";
                            throw new Exception(strMsg);
                        }
                        else
                        {
                            //    var objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLstCache(objComboBox.VarIdCond1, strViewId, strPrjId);
                            //    if (objViewIdGCVariableRela.RetrievalMethodId == enumRetrievalMethod.Undefined_01)
                            //    {
                            //        var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                            //        strMsg = $"控件:[{objComboBox.LabelCaption}]中，数据源表:[{objPrjTab.TabName}]的表功能:[{objTabFeature.TabFeatureName}]变量1：{objComboBox.VarIdCond1}在界面:{objViewInfo.ViewName}({strViewId})的变量表中获取方式为空，请检查 ！";
                            //        throw new Exception(strMsg);

                            //    }
                        }

                    }
                }
            }
            return true;
        }

        public static bool CheckDnPath_In(IDnPath iDnPath)
        {
            var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(iDnPath.PrjId);
            var strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(iDnPath.PrjId);
            //if (iDnPath.IsUseFunc == false)
            //{
            //    return true;
            //}

            //string PropStr == "");
            //string strFormat = "字段信息中，Java数据类型不能为空。({0})";
            string strMsg = "";
            if (string.IsNullOrEmpty(iDnPath.FldId) == true)
            {
                strMsg = string.Format("控件:[{0}]中，字段id不能为空.({1})",
                    iDnPath.Caption,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(iDnPath.FldId, strPrjId);

            if (string.IsNullOrEmpty(iDnPath.DnPathId) == true)
            {
                strMsg = string.Format("控件:[{0}]中，路径id不能为空.({1})",
                    iDnPath.Caption,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(iDnPath.DnPathId, iDnPath.PrjId);
            if (objDnPath == null)
            {
                strMsg = string.Format("控件:[{0}]中，路径id:[{1}]所对应的路径在当前Cm工程中不存在.({2})",
                    iDnPath.Caption, iDnPath.DnPathId,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objInDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.InDataNodeId, iDnPath.PrjId);
            if (objInDataNode == null)
            {
                var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(iDnPath.PrjId);
                strMsg = string.Format("路径:[{0}({1})]所对应的In结点Id:[{2}]路径在当前Cm工程:[{3}]中不存在.({4})",
                    objDnPath.DnPathName, iDnPath.DnPathId, objDnPath.InDataNodeId, objCmProject.CmPrjName, 
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            if (objInDataNode.FldId != iDnPath.FldId)
            {
                strMsg = string.Format("控件:[{0}]中，源字段:[{1}]和路径In结点的字段:[{2}]不相符.({3})",
                   iDnPath.Caption, objFieldTab.FldName, objInDataNode.ObjFieldTab().FldName,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }

            //if (string.IsNullOrEmpty(iDnPath.DataPropertyName) == true)
            //{
            //    strMsg = string.Format("控件:[{0}]中，属性名不能为空！({1})",
            //     iDnPath.Caption,
            //   clsStackTrace.GetCurrClassFunctionByLevel(2));
            //    throw new Exception(strMsg);
            //}
            
            return true;
        }

        public static bool CheckDnPath_Out(IDnPath iDnPath)
        {
            var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(iDnPath.PrjId);
            var strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(iDnPath.PrjId);
            //if (iDnPath.IsUseFunc == false)
            //{
            //    return true;
            //}

            //string PropStr == "");
            //string strFormat = "字段信息中，Java数据类型不能为空。({0})";
            string strMsg = "";
            if (string.IsNullOrEmpty(iDnPath.FldId) == true)
            {
                strMsg = string.Format("控件:[{0}]中，字段id不能为空.({1})",
                    iDnPath.Caption,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(iDnPath.FldId, strPrjId);

            if (string.IsNullOrEmpty(iDnPath.DnPathId) == true)
            {
                strMsg = string.Format("控件:[{0}]中，路径id不能为空.({1})",
                    iDnPath.Caption,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(iDnPath.DnPathId, iDnPath.PrjId);
            if (objDnPath == null)
            {
                strMsg = string.Format("控件:[{0}]中，路径id:[{1}]所对应的路径在当前Cm工程中不存在.({2})",
                    iDnPath.Caption, iDnPath.DnPathId,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objOutDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.OutDataNodeId, iDnPath.PrjId);

            if (objOutDataNode.FldId != iDnPath.FldId)
            {
                strMsg = string.Format("控件:[{0}]中，源字段:[{1}]和路径Out结点的字段:[{2}]不相符.({3})",
                   iDnPath.Caption, objFieldTab.FldName, objOutDataNode.ObjFieldTab().FldName,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }

            //if (string.IsNullOrEmpty(iDnPath.DataPropertyName) == true)
            //{
            //    strMsg = string.Format("控件:[{0}]中，属性名不能为空！({1})",
            //     iDnPath.Caption,
            //   clsStackTrace.GetCurrClassFunctionByLevel(2));
            //    throw new Exception(strMsg);
            //}

            return true;
        }


        /// <summary>
        /// 保存类内容到内容
        /// </summary>
        /// <param name="strClassFName">类文件名（全名）</param>
        /// <param name="strClassContent">类内容</param>
        /// <param name="strFolderName_Root">根文件目录名</param>
        /// <param name="strBackupFolderName">备份文件的目录</param>
        /// <returns></returns>
        public static bool SaveClassContentToFile(string strClassFName, string strClassContent, string strFolderName_Root, string strBackupFolderName, Encoding myEncoding)
        {
            strClassFName = strClassFName.Replace("/", "\\");
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
                string strMsg = string.Format("[建立目录成功！]为文件：{2}建立了目录：{0}({1})", 
                    strFolder, clsStackTrace.GetCurrClassFunctionByLevel(2),
                    strClassFName);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

            }
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("[建立目录不成功！]文件：{2}建立目录：{0}。({1})", 
                    strFolder,  clsStackTrace.GetCurrClassFunctionByLevel(2),
                  strClassFName);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);          
            }
            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    if (string.IsNullOrEmpty(strBackupFolderName) == false)
                    {
                        clsFile.FileBackup(strFindFileFullFile, strBackupFolderName);
                        File.Delete(strFindFileFullFile);
                    }
                    strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);

                }
            }
            try
            {
                clsFile.CreateFileByString(strClassFName, strClassContent, myEncoding);
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("[建立文件不成功！]文件：{0}时发生错误：{1}.({2})", strClassFName, objException.Message, clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 保存类内容到内容, 不需要备份原来的文件, 原文件不能被覆盖
        /// </summary>
        /// <param name="strClassFName">类文件名（全名）</param>
        /// <param name="strClassContent">类内容</param>
        /// <param name="strFolderName_Root">根文件目录名</param>
        /// <param name="myEncoding">生成文件的代码类型</param> 
        /// <returns></returns>
        public static Tuple<bool, string> SaveClassContentToFile_NoCover(string strClassFName, string strClassContent, string strFolderName_Root, clsCodeTypeEN objCodeTypeEN, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = "";
                    if (objCodeTypeEN != null)
                    {
                        strMsg = string.Format("\r\n[文件已经存在!]({2})",
                            strFindFileFullFile,
                            clsStackTrace.GetCurrClassFunctionByLevel(2), objCodeTypeEN.CodeTypeName);
                    }
                    else
                    {
                        strMsg = string.Format("\r\n[文件已经存在!]",
                            strFindFileFullFile,
                            clsStackTrace.GetCurrClassFunctionByLevel(2));
                    }
                    return Tuple.Create(false,strMsg);

                }
            }
            clsFile.CreateFileByString(strClassFName, strClassContent, myEncoding);
            return Tuple.Create(true, "");
        }

        public static Tuple<bool, string> SaveClassContentToFile_NoCover4View(string strClassFName, string strClassContent, clsCodeTypeEN objCodeTypeEN, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strClassFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
            string strFolderName_Root = strFolder;
            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(strFolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("\r\n[文件已经存在!]({2})",
                        strFindFileFullFile,
                        clsStackTrace.GetCurrClassFunctionByLevel(2), objCodeTypeEN.CodeTypeName);
                  return Tuple.Create(false, strMsg);
                }
            }
            clsFile.CreateFileByString(strClassFName, strClassContent, myEncoding);
            return Tuple.Create(true, "");
        }
        /// <summary>
        /// 写生成代码的日志文件
        /// </summary>
        /// <param name="strLogFName"></param>
        /// <param name="strLogContent"></param>
        /// <param name="myEncoding"></param>
        /// <returns></returns>
        public static bool WriteLogFile(string strLogFName, string strLogContent, Encoding myEncoding)
        {
            string strFolder = clsString.ParentDir_S(strLogFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }
                       
            clsFile.CreateFileByString(strLogFName, strLogContent, myEncoding);
            return true;
        }

        public static void SaveToFileBak()
        {
            //检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WinUserCtlCsFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WinUserCtlCsFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WinUserCtlCsFName, strCodeForCs.ToString(), myEncoding);
        }

        public static void ClearCache4GeneCode(string strPrjId)
        {
            clsUserCodePathBL.ReFreshCache(strPrjId);
            
        }

        /// <summary>
        /// 功能:测试数据库连接串是否可用(通)
        /// </summary>
        /// <param name = "strPrjDataBaseId">给定的工程数据库Id,代表着一个连接串</param>
        /// <returns>若该数据库中的连接可用，返回True, 否则返回False</returns>
        public static bool TestConnectString(string strPrjDataBaseId)
        {
            clsSpecSQLforSql objSQL = clsSQL_DataBaseBLEx.getSpecSQLByPrjDataBaseId(strPrjDataBaseId);
            try
            {
                return objSQL.TestConnect();
            }
            catch(Exception objException)
            {
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                return false;
            }
        }

        /// <summary>
        /// 功能:测试数据库连接串是否可用(通)
        /// </summary>
        /// <param name = "strConnectString">给定的连接串</param>
        /// <returns>若该连接串的连接可用，返回True, 否则返回False</returns>
        public static bool TestConnectString2(string strConnectString)
        {
            try
            {
                return clsSpecSQLforSql.TestConnect(strConnectString);
            }
            catch (Exception objException)
            {
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                return false;
            }
        }


        public static bool CheckDnPath_PrjTab(IDnPath iDnPath, string strPrjId, string strOpUser)
        {            
            //var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            //var strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
           
            if (iDnPath.IsForExtendClass == false)
            {
                return true;
            }

            //string PropStr == "");
            //string strFormat = "字段信息中，Java数据类型不能为空。({0})";
            string strMsg = "";
            if (string.IsNullOrEmpty(iDnPath.FldId) == true)
            {
                strMsg = string.Format("扩展字段Id不能为空.({0})",
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(iDnPath.FldId, strPrjId);
            if (string.IsNullOrEmpty(iDnPath.TabId) == true)
            {
                strMsg = string.Format("字段:[{0}({1})]中，TabId不能为空.({2})",
                    objFieldTab.FldName, iDnPath.FldId,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(iDnPath.TabId, strPrjId);

            if (string.IsNullOrEmpty(iDnPath.DnPathId) == true)
            {
                return true;
                //strMsg = string.Format("字段:[{0}({1})]中，路径id不能为空.({2})",
                //    objFieldTab.FldName, iDnPath.FldId,
                //  clsStackTrace.GetCurrClassFunctionByLevel(2));
                //throw new Exception(strMsg);
            }
        
            var objDnPath = clsDnPathBL.GetObjByDnPathId(iDnPath.DnPathId);
            if (objDnPath == null)
            {
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldId(iDnPath.TabId, iDnPath.FldId);
                objPrjTabFld.DnPathId = "";
                objPrjTabFld.ErrMsg = "";
                objPrjTabFld.Update();
                return true;
                //strMsg = string.Format("字段:[{0}({1})]中，路径id:[{2}]所对应的路径在当前Cm工程中不存在.({3})",
                //    objFieldTab.FldName, iDnPath.FldId, iDnPath.DnPathId,
                //  clsStackTrace.GetCurrClassFunctionByLevel(2));
                //throw new Exception(strMsg);
            }
            if (string.IsNullOrEmpty(objDnPath.ErrMsg) == false)
            {
                objDnPath.IsHasErr = false;
                objDnPath.ErrMsg = "";
                objDnPath.UpdUser = strOpUser;
                objDnPath.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objDnPath.Update();
            }
           
            clsDnPathBLEx.CheckDnPath(objDnPath, strOpUser);
            if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length>0)
            {                
                strMsg = string.Format("字段:[{0}({1})]中，路径有错:[{2}].({3})",
                   objFieldTab.FldName, iDnPath.FldId, objDnPath.ErrMsg,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objInDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.InDataNodeId, strPrjId);

            if (arrPrjTabFld.Count(x=>x.FldId == objInDataNode.FldId) != 1)
            {
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(iDnPath.TabId, strPrjId);

                strMsg = string.Format("字段:[{0}({1})]中，路径的In结点的字段:[{2}]在表:[{3}]中不存在.({4})",
                   objFieldTab.FldName, iDnPath.FldId, objInDataNode.ObjFieldTab().FldName,objPrjTab.TabName,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            var objOutDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.OutDataNodeId, strPrjId);
            if (objOutDataNode == null)
            {
                strMsg = string.Format("DataNodeId:[{0}]所对应的对象不存在.({1})",
                   objDnPath.OutDataNodeId, 
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            if (objFieldTab.FldId != objOutDataNode.FldId && objFieldTab.HomologousFldId != objOutDataNode.FldId)
            {
                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(iDnPath.TabId, strPrjId);

                strMsg = string.Format("字段:[{0}({1})]中，路径的Out结点的字段:[{2}]与不相符.({3})",
                   objFieldTab.FldName, iDnPath.FldId, objOutDataNode.ObjFieldTab().FldName,
                 clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }

            return true;
        }
        /// <summary>
        /// 生成与
        /// </summary>
        /// <param name="strVarName"></param>
        /// <param name="strTypeScriptType"></param>
        /// <param name="strDataTypeId"></param>
        /// <param name="strClassName"></param>
        /// <param name="strFuncName"></param>
        /// <param name="intFldLen"></param>
        /// <param name="bolIsCheckLength"></param>
        /// <param name="objImportClass"></param>
        /// <param name="strBaseUrl"></param>
        /// <returns></returns>
        public static string Gc_CheckVarEmpty_Ts(string strVarName, string strTypeScriptType, string strDataTypeId, string strClassName, string strFuncName, int intFldLen, bool bolIsCheckLength, IImportClass objImportClass, string strBaseUrl)
        {
            StringBuilder sbCheckEmpty = new StringBuilder();
            if (strTypeScriptType == "number")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if ({0} == 0)", strVarName);
                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空!(In {1}.{2})\");",
                    strVarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
            }
            else if (strTypeScriptType == "string")
            {
                sbCheckEmpty.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", strVarName);
                objImportClass.AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                sbCheckEmpty.Append("\r\n" + "{");
                sbCheckEmpty.AppendFormat("\r\n" + "  const strMsg = Format(\"参数:[{0}]不能为空!(In {1}.{2})\");",
                    strVarName, strClassName, strFuncName);
                sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                sbCheckEmpty.Append("\r\n" + " throw (strMsg);");
                sbCheckEmpty.Append("\r\n" + "}");
                if (bolIsCheckLength == true && strDataTypeId == enumDataTypeAbbr.char_04)
                {
                    sbCheckEmpty.AppendFormat("\r\n" + "if ({0}.length != {1})", strVarName, intFldLen);
                    sbCheckEmpty.Append("\r\n" + "{");
                    sbCheckEmpty.AppendFormat("\r\n" + "const strMsg = Format(\"缓存分类变量:[{0}]的长度:[{{0}}]不正确!({1}.{2})\", {0}.length);",
                        strVarName, strClassName, strFuncName);
                    sbCheckEmpty.Append("\r\n" + "console.error(strMsg);");
                    sbCheckEmpty.Append("\r\n" + "throw (strMsg);");
                    sbCheckEmpty.Append("\r\n" + "}");
                }
            }
            return sbCheckEmpty.ToString();
        }

    }
}
