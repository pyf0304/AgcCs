using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGC.BusinessLogic;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;

namespace AGC.PureClassEx
{
    public static class clsPrjTabFldBLExInPureClass
    {
        public static string GetVarName4ViewInP(this clsGCVariableEN objGCVariable)
        {
            switch (objGCVariable.VarTypeId)
            {
                case enumGCVariableType.sessionStorage_0004:
                    return $"{objGCVariable.VarName}_Session";
                case enumGCVariableType.localStorage_0003:
                    return $"{objGCVariable.VarName}_Local";
                case enumGCVariableType.GivingValue_0001:
                    return $"{objGCVariable.VarName}_Giving";
                case enumGCVariableType.DefaultValue_0002:
                    return $"{objGCVariable.VarName}_Default";
                case enumGCVariableType.QueryString_0005:
                    return $"{objGCVariable.VarName}_Query";
                case enumGCVariableType.StaticValuable_0006:
                    return $"{objGCVariable.VarName}_Static";
                case enumGCVariableType.CacheClassifyField_0007:
                    return $"{objGCVariable.VarName}_Cache";
                case enumGCVariableType.Function_0008:
                    return $"{objGCVariable.VarName}_Fun";
                default:
                    return $"{objGCVariable.VarName}";
            }
        }


        public static clsFieldTabEN ObjFieldTab_PC(this clsTabFeatureFldsEN objTabFeatureFlds)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objTabFeatureFlds.FldId, objTabFeatureFlds.PrjId);
                if (objFieldTab == null)
                {
                    string strMsg = string.Format("工程Id:[{0}], 字段Id:[{1}]查找的字段为空，请检查.({2})",
          objTabFeatureFlds.PrjId, objTabFeatureFlds.FldId, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表功能字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.      
        /// </summary>
        /// <param name = "strTabFeatureId">strTabFeatureId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsTabFeatureFldsEN> GetObjLstByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
        {
            //初始化列表缓存
            List<clsTabFeatureFldsEN> arrObjLstCache = clsTabFeatureFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsTabFeatureFldsEN> arrTabFeatureFldsObjLst_Sel = arrObjLstCache
                                    .Where(x => x.TabFeatureId == strTabFeatureId);

            return arrTabFeatureFldsObjLst_Sel.ToList();
        }

        public static List<clsTabFeatureFldsEN> arrTabFeatureFldsSet_PC(this clsTabFeatureEN objTabFeature)
        {
            var arrTabFeatureFlds = GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objTabFeature.PrjId).ToList();
            return arrTabFeatureFlds;
        }


        public static clsDataTypeAbbrEN ObjDataTypeAbbr_PC(this clsGCVariableEN objGCVariable)
        {
            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            return objDataTypeAbbr;
        }
        public static bool IsNumberType_PC(this clsGCVariableEN objGCVariable)
        {
            var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            switch (objDataTypeAbbrEN.CsType)
            {
                case "Int":
                case "int":
                case "long":
                case "float":
                case "short":
                case "double":
                    return true;
                default:
                    return false;
            }
        }
        public static bool IsBoolType_PC(this clsGCVariableEN objGCVariable)
        {
            var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objGCVariable.DataTypeId);
            switch (objDataTypeAbbrEN.CsType)
            {
                case "bool":
                case "boolean":
                    return true;
                default:
                    return false;
            }
        }
        public static string TabId_PC(this IRegionFlds objRegionFldsEN)
        {
            try
            {
                clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(objRegionFldsEN.RegionId, objRegionFldsEN.PrjId);
                if (objViewRegion == null) return null;
                return objViewRegion.TabId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string DnPathId_PC(this IRegionFlds objRegionFldsEN)
        {
            try
            {
                string strTabId = objRegionFldsEN.TabId_PC();
                if (strTabId == null) return null;

                string strPrjId = objRegionFldsEN.PrjId;

                var objPrjTabFld = GetObjByTabIdAndFldIdCache(strTabId, objRegionFldsEN.OutFldId, strPrjId);
                if (objPrjTabFld == null) return null;
                return objPrjTabFld.DnPathId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool IsUseFunc_PC(this IRegionFlds objRegionFldsEN)
        {
            try
            {
                if (string.IsNullOrEmpty(objRegionFldsEN.OutFldId)) return false;
                else return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string DataPropertyName_PC(this IRegionFlds objRegionFldsEN)
        {
            try
            {
                string strTabId = objRegionFldsEN.TabId_PC();
                if (strTabId == null) return null;

                string strPrjId = objRegionFldsEN.PrjId;

                var objPrjTabFld = GetObjByTabIdAndFldIdCache(strTabId, objRegionFldsEN.OutFldId, strPrjId);
                if (objPrjTabFld == null) return null;
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, strPrjId);
                if (objFieldTab == null) return null;
                return objFieldTab.FldName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

   
        public static List<clsPrjTabFldEN> GetObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
            from objPrjTabFldEN in arrObjLstCache
            where objPrjTabFldEN.TabId == strTabId
            select objPrjTabFldEN;
            List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = new List<clsPrjTabFldEN>();
            foreach (clsPrjTabFldEN obj in arrPrjTabFldObjLst_Sel1)
            {
                arrPrjTabFldObjLst_Sel.Add(obj);
            }
            //if (arrPrjTabFldObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrPrjTabFldObjLst_Sel;
        }

        public static string FieldTypeId(this clsEditRegionFldsEN objEditRegionFlds, string strPrjId)
        {
            //string strPrjId_p = clsCMProjectBL.GetObjByCmPrjIdCache(objEditRegionFlds.PrjId).PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strPrjId).TabId;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId);

            clsPrjTabFldEN objPrjTabFld = arrPrjTabFldObjList.Find(x => x.FldId == objEditRegionFlds.FldId);
            if (objPrjTabFld == null) return "";
            return objPrjTabFld.FieldTypeId;
        }

        public static bool IsLogUpdDateOrUpdUser(this clsEditRegionFldsEN objEditRegionFlds, string strPrjId)
        {
            //string strPrjId_p = objEditRegionFlds.PrjId).PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strPrjId).TabId;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId);

            clsPrjTabFldEN objPrjTabFld = arrPrjTabFldObjList.Find(x => x.FldId == objEditRegionFlds.FldId);
            if (objPrjTabFld == null) return false;
            if (objPrjTabFld.FieldTypeId == enumFieldType.KeyField_02 &&
                (objPrjTabFld.PrimaryTypeId == enumPrimaryType.Identity_02 ||
                objPrjTabFld.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03 ||
                objPrjTabFld.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06
                )) return true;
            if (objPrjTabFld.FieldTypeId == enumFieldType.Log_UpdDate_13) return true;
            if (objPrjTabFld.FieldTypeId == enumFieldType.Log_UpdUser_14) return true;
            return false;
    
        }

        public static bool IsKeyAndIdentity(this clsEditRegionFldsEN objEditRegionFlds, string strPrjId)
        {
            //string strPrjId_p = objEditRegionFlds.PrjId).PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strPrjId).TabId;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId);

            clsPrjTabFldEN objPrjTabFld = arrPrjTabFldObjList.Find(x => x.FldId == objEditRegionFlds.FldId);
            if (objPrjTabFld == null) return false;
            if (objPrjTabFld.FieldTypeId == enumFieldType.KeyField_02 &&
                (objPrjTabFld.PrimaryTypeId == enumPrimaryType.Identity_02 ||
                objPrjTabFld.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03 ||
                objPrjTabFld.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06
                )) return true;
            return false;

        }

        public static string FieldTypeId(this clsDetailRegionFldsEN objEditRegionFlds)
        {
            string strPrjId_p = objEditRegionFlds.PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strPrjId_p).TabId;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId_p);

            clsPrjTabFldEN objPrjTabFld = arrPrjTabFldObjList.Find(x => x.FldId == objEditRegionFlds.FldId);

            return objPrjTabFld.FieldTypeId;
        }

        public static bool IsLogUpdDateOrUpdUser(this clsDetailRegionFldsEN objEditRegionFlds, string strCmPrjId)
        {
            string strPrjId_p = objEditRegionFlds.PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strCmPrjId).TabId;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId_p);

            clsPrjTabFldEN objPrjTabFld = arrPrjTabFldObjList.Find(x => x.FldId == objEditRegionFlds.FldId);
            if (objPrjTabFld == null) return false;
            if (objPrjTabFld.FieldTypeId == enumFieldType.Log_UpdDate_13) return true;
            if (objPrjTabFld.FieldTypeId == enumFieldType.Log_UpdUser_14) return true;
            return false;

        }

        public static bool IsTabNullable(this clsEditRegionFldsEN objEditRegionFlds, string strPrjId)
        {
            //string strPrjId_p = clsCMProjectBL.GetObjByCmPrjIdCache(objEditRegionFlds.PrjId).PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strPrjId).TabId;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId);

            clsPrjTabFldEN objPrjTabFld = arrPrjTabFldObjList.Find(x => x.FldId == objEditRegionFlds.FldId);

            return objPrjTabFld.IsTabNullable;
        }
        public static string MemoInTab(this clsEditRegionFldsEN objEditRegionFlds, string strPrjId)
        {
            //string strPrjId_p = clsCMProjectBL.GetObjByCmPrjIdCache(objEditRegionFlds.PrjId).PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strPrjId).TabId;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId);

            clsPrjTabFldEN objPrjTabFld = arrPrjTabFldObjList.Find(x => x.FldId == objEditRegionFlds.FldId);

            return objPrjTabFld.MemoInTab;
        }

        public static clsPrjTabEN ObjPrjTab_PC(this clsEditRegionFldsEN objEditRegionFlds)
        {
            //string strPrjId_p = clsCMProjectBL.GetObjByCmPrjIdCache(objEditRegionFlds.PrjId).PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, objEditRegionFlds.PrjId).TabId;
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, objEditRegionFlds.PrjId);

            return objPrjTab;
        }

        public static clsPrjTabEN ObjPrjTab_PC(this clsDetailRegionFldsEN objEditRegionFlds)
        {
            string strPrjId_p = objEditRegionFlds.PrjId;
            var strTabId = clsViewRegionBL.GetObjByRegionIdCache(objEditRegionFlds.RegionId, strPrjId_p).TabId;
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId_p);

            return objPrjTab;
        }

        public static clsFieldTabEN ObjFieldTab_PC(this clsEditRegionFldsEN objEditRegionFlds)
        {
            string strPrjId_p = objEditRegionFlds.PrjId;
            clsFieldTabEN objPrjTabFld = clsFieldTabBL.GetObjByFldIdCache(objEditRegionFlds.FldId, strPrjId_p);
            return objPrjTabFld;
        }

        public static clsFieldTabEN ObjFieldTab_PC(this clsDetailRegionFldsEN objDetailRegionFlds)
        {
            string strPrjId_p = objDetailRegionFlds.PrjId;
            clsFieldTabEN objPrjTabFld = clsFieldTabBL.GetObjByFldIdCache(objDetailRegionFlds.FldId, strPrjId_p);
            return objPrjTabFld;
        }
        //public static clsPrjTabFldEN ObjPrjTabFld(this clsDetailRegionFldsEN objDetailRegionFlds)
        //{
        //    string strPrjId_p = clsCMProjectBL.GetObjByCmPrjIdCache(objDetailRegionFlds.PrjId).PrjId;
        //    clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjByFldIdCache(objDetailRegionFlds.FldId, strPrjId_p);
        //    return objPrjTabFld;
        //}

        public static clsFieldTabEN ObjFieldTab_PC(this clsFeatureRegionFldsEN objFeatureRegionFlds)
        {
            string strPrjId_p = objFeatureRegionFlds.PrjId;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objFeatureRegionFlds.ReleFldId, strPrjId_p);
            return objFieldTab;
        }

        public static clsFieldTabEN ObjFieldTab_PC(this clsvViewFeatureFldsEN objvViewFeatureFlds)
        {
            var strPrjId = objvViewFeatureFlds.PrjId;            
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objvViewFeatureFlds.ReleFldId, strPrjId);
            return objFieldTab;
        }

        public static clsFieldTabEN ObjFieldTab_PC(this clsPrjTabFldEN objPrjTabFld)
        {
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, objPrjTabFld.PrjId);
            return objFieldTab;
        }

        public static clsPrjTabEN ObjPrjTab_PC(this clsPrjTabFldEN objPrjTabFld)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabFld.TabId, objPrjTabFld.PrjId);
            return objPrjTab;
        }

        public static clsPrjTabEN ObjPrjTab_PC(this clsDGRegionFldsEN objDGRegionFlds)
        {
            string strPrjId_p = objDGRegionFlds.PrjId;
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(objDGRegionFlds.RegionId, strPrjId_p);
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewRegion.TabId, strPrjId_p);
            return objPrjTab;
        }
        public static clsPrjTabEN ObjPrjTab_PC(this clsQryRegionFldsEN objDGRegionFlds)
        {
            string strPrjId_p = objDGRegionFlds.PrjId;
            clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(objDGRegionFlds.RegionId, strPrjId_p);
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewRegion.TabId, strPrjId_p);
            return objPrjTab;
        }
        public static clsFieldTabEN ObjFieldTab_PC(this clsDGRegionFldsEN objDGRegionFlds)
        {
            string strPrjId_p = objDGRegionFlds.PrjId;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFlds.FldId, strPrjId_p);
            return objFieldTab;
        }
        public static clsFieldTabEN ObjFieldTab_PC(this clsQryRegionFldsEN objQryRegionFlds)
        {
            string strPrjId_p = objQryRegionFlds.PrjId;
            clsFieldTabEN objPrjTabFld = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFlds.FldId, strPrjId_p);
            return objPrjTabFld;
        }
        public static clsFieldTabEN ObjFieldTab4OutFldId_PC(this clsQryRegionFldsEN objQryRegionFlds)
        {
            string strPrjId_p = objQryRegionFlds.PrjId;
            clsFieldTabEN objPrjTabFld = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFlds.OutFldId, strPrjId_p);
            return objPrjTabFld;
        }
        public static clsFieldTabEN ObjFieldTab_PC(this clsExcelExportRegionFldsEN objExcelExportRegionFlds)
        {
            string strPrjId_p = objExcelExportRegionFlds.PrjId;
            var objPrjTabFld = clsFieldTabBL.GetObjByFldIdCache(objExcelExportRegionFlds.FldId, strPrjId_p);
            return objPrjTabFld;
        }

        public static clsCtlTypeEN ObjCtlTypeAbbr(this clsQryRegionFldsEN objQryRegionFlds)
        {
            clsCtlTypeEN objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(objQryRegionFlds.CtlTypeId);
            return objCtlTypeAbbr;
        }

        public static clsCtlTypeEN ObjCtlTypeAbbr(this clsEditRegionFldsEN objEditRegionFlds)
        {
            clsCtlTypeEN objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(objEditRegionFlds.CtlTypeId);
            return objCtlTypeAbbr;
        }

        public static clsCtlTypeEN ObjCtlTypeAbbr(this clsDetailRegionFldsEN objDetailRegionFlds)
        {
            clsCtlTypeEN objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(objDetailRegionFlds.CtlTypeId);
            return objCtlTypeAbbr;
        }

        public static clsCtlTypeEN ObjCtlTypeAbbr(this clsDGRegionFldsEN objDGRegionFlds)
        {
            clsCtlTypeEN objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(objDGRegionFlds.CtlTypeId);
            return objCtlTypeAbbr;
        }

        public static clsCtlTypeEN ObjCtlTypeAbbr(this clsvViewFeatureFldsEN objvViewFeatureFlds)
        {
            clsCtlTypeEN objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(objvViewFeatureFlds.CtlTypeId);
            return objCtlTypeAbbr;
        }


        public static clsDataTypeAbbrEN ObjDataTypeAbbr_PC(this clsFieldTabEN objFieldTab)
        {
            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
            return objDataTypeAbbr;
        }
        public static string CodeTabName(this clsFieldTabEN objFieldTab)
        {
            var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(objFieldTab.FldId, objFieldTab.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objFieldTab4CodeConv.CodeTabId, objFieldTab.PrjId);
                if (objPrjTab == null) return "";
                return objPrjTab.TabName;
            }
            else
            {
                return "";
            }
        }
        public static string CodeTab_Code(this clsFieldTabEN objFieldTab)
        {
            var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(objFieldTab.FldId, objFieldTab.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                clsFieldTabEN objFieldTab1 = clsFieldTabBL.GetObjByFldIdCache(objFieldTab4CodeConv.CodeTabCodeId, objFieldTab.PrjId);
                if (objFieldTab1 == null) return "";
                return objFieldTab1.FldName;
            }
            else                return "";
        }

        public static string CodeTab_Name(this clsFieldTabEN objFieldTab)
        {
            var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(objFieldTab.FldId, objFieldTab.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                clsFieldTabEN objFieldTab1 = clsFieldTabBL.GetObjByFldIdCache(objFieldTab4CodeConv.CodeTabNameId, objFieldTab.PrjId);
                if (objFieldTab1 == null) return "";
                return objFieldTab1.FldName;
            }
            else return "";
        }

        public static string DsTabName(this clsEditRegionFldsEN objEditRegionFlds)
        {
            string strPrjId_p = objEditRegionFlds.PrjId;
            if (string.IsNullOrEmpty(objEditRegionFlds.DsTabId)) return "";
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFlds.DsTabId, strPrjId_p);
            if (objPrjTab == null) return "";
            return objPrjTab.TabName;
        }
        public static string PrjId_PC(this IRegionFlds objRegionFlds)
        {
            //var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(objRegionFlds.PrjId);
            return objRegionFlds.PrjId;
        }
        public static clsFieldTabEN ObjFieldTab_PCEx(this IRegionFlds objRegionFlds)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objRegionFlds.FldId, objRegionFlds.PrjId_PC());
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsCtlTypeEN ObjCtlType_PC(this IRegionFlds objRegionFlds)
        {
            try
            {
                clsCtlTypeEN objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objRegionFlds.CtlTypeId);
                return objCtlType;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string CtrlId(this IRegionFlds objEditRegionFlds)
        {
            if (objEditRegionFlds == null) return "";
            if (objEditRegionFlds.ObjFieldTab_PCEx() == null) return "";
            string mstrCtrlId = objEditRegionFlds.ObjCtlType_PC().CtlTypeAbbr + objEditRegionFlds.ObjFieldTab_PCEx().FldName;
            return mstrCtrlId;
        }

        public static string CtrlId(this clsDetailRegionFldsENEx objDetailRegionFlds)
        {
            if (objDetailRegionFlds == null) return "";

            if (objDetailRegionFlds.ObjFieldTab_PC() == null) return "";
            string mstrCtrlId = objDetailRegionFlds.ObjCtlTypeAbbr().CtlTypeAbbr + objDetailRegionFlds.ObjFieldTab_PC().FldName;
            return mstrCtrlId;
        }

        public static string CtrlId(this clsQryRegionFldsENEx objQryRegionFlds)
        {
            string mstrCtrlId = "";
            if (objQryRegionFlds == null) return "";
            if (objQryRegionFlds.IsUseFunc_PC() && string.IsNullOrEmpty(objQryRegionFlds.DataPropertyName_PC()) == false)
            {
                mstrCtrlId = objQryRegionFlds.ObjCtlTypeAbbr().CtlTypeAbbr + objQryRegionFlds.DataPropertyName_PC() + "_q";
                return mstrCtrlId;
            }
            else
            {
                if (objQryRegionFlds.ObjFieldTab_PC() == null) return "";
                mstrCtrlId = objQryRegionFlds.ObjCtlTypeAbbr().CtlTypeAbbr + objQryRegionFlds.ObjFieldTab_PC().FldName + "_q";
                return mstrCtrlId;
            }
        }

        public static string FldName_PC(this IRegionFlds objEditRegionFlds)
        {
            if (objEditRegionFlds == null) return "";
            if (objEditRegionFlds.ObjFieldTab_PCEx() == null) return "";

            return objEditRegionFlds.ObjFieldTab_PCEx().FldName;
        }
        public static string DsTabName(this clsQryRegionFldsEN objQryRegionFlds)
        {
            string strPrjId_p = objQryRegionFlds.PrjId;
            if (string.IsNullOrEmpty(objQryRegionFlds.DsTabId)) return "";
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objQryRegionFlds.DsTabId, strPrjId_p);
            if (objPrjTab == null) return "";
            return objPrjTab.TabName;
        }
        //public static string DsTabName(this clsDGRegionFldsEN objDGRegionFlds)
        //{
        //    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objDGRegionFlds.D`S_TabId, objDGRegionFlds.PrjId);
        //    if (objPrjTab == null) return "";
        //    return objPrjTab.TabName;
        //}
        public static string ButtonValue(this clsDGRegionFldsEN objDGRegionFlds)
        {
            if (objDGRegionFlds.InUse == true)
            {
                return string.Format("D:{0}", objDGRegionFlds.HeaderText);
            }
            else
            {
                return string.Format("A:{0}", objDGRegionFlds.HeaderText);
            }

        }

        /// <summary>
        /// 私有函数变量名，前面不加“m”
        /// </summary>
        public static string PrivFuncName(this clsFieldTabEN objFieldTab)
        {
            return objFieldTab.ObjDataTypeAbbr_PC().DataTypeAbbr + objFieldTab.FldName;
        }

      

        public static clsPrjTabEN ObjOutRelaTab(this clsViewInfoEN objViewInfo)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.OutRelaTabId, objViewInfo.PrjId);
            return objPrjTab;
        }
        public static clsPrjTabEN ObjInRelaTab(this clsViewInfoEN objViewInfo)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.InRelaTabId, objViewInfo.PrjId);
            return objPrjTab;
        }
        public static clsPrjTabEN ObjMainPrjTab(this clsViewInfoEN objViewInfo)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfo.MainTabId, objViewInfo.PrjId);
            return objPrjTab;
        }

        public static clsPrjTabFldEN GetObjByTabIdAndFldIdCache(string strTabId, string strFldId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
                arrObjLstCache.Where(x => x.FldId == strFldId && x.TabId == strTabId);
            if (arrPrjTabFldObjLst_Sel.Count() == 0)
            {
                return null;
            }
            return arrPrjTabFldObjLst_Sel.First();
        }

    }
}
