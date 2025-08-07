using AGC.BusinessLogic;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC.BusinessLogicEx
{
    public static class clsRegionFldsBLEx
    {

        /// <summary>
        /// 是否数字类型
        /// </summary>
        /// <param name="objPrjTabFldENEx"></param>
        /// <returns></returns>
        public static bool IsNumberType(this IRegionFlds objExcelExportRegionFlds)
        {
            switch (objExcelExportRegionFlds.ObjFieldTab().ObjDataTypeAbbr().CsType)
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

        public static string PrimaryTypeId(this IRegionFlds objDetailRegionFldsEx)
        {
            string strPrjId_p = objDetailRegionFldsEx.PrjId;
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objDetailRegionFldsEx.RegionId, objDetailRegionFldsEx.PrjId).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objDetailRegionFldsEx.FldId, strPrjId_p);
            if (objPrjTabFld == null) return "";
            return objPrjTabFld.PrimaryTypeId;
        }

        
        public static clsPrjTabEN ObjPrjTab(this IRegionFlds objDetailRegionFlds)
        {
            string strPrjId_p = objDetailRegionFlds.PrjId;
            string strTabId = objDetailRegionFlds.TabId();
            clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabIdCache(strTabId, strPrjId_p);
            return objPrjTab;
        }
        public static bool IsForExtendClass(this IRegionFlds objDetailRegionFlds)
        {
            string strPrjId_p = objDetailRegionFlds.PrjId;
            string strTabId = objDetailRegionFlds.TabId();
            clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objDetailRegionFlds.FldId, strPrjId_p);
            return objPrjTabFld.IsForExtendClass;
        }
        public static clsPrjTabFldEN ObjPrjTabFld(this IRegionFlds objDetailRegionFlds)
        {
            string strPrjId_p = objDetailRegionFlds.PrjId;
            string strTabId = objDetailRegionFlds.TabId();
            clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objDetailRegionFlds.FldId, strPrjId_p);
            return objPrjTabFld;
        }
        public static clsFieldTabEN ObjFieldTab(this IRegionFlds objRegionFlds)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objRegionFlds.FldId, objRegionFlds.PrjId);
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

        public static clsFieldTabEN ObjOutFieldTab(this IRegionFlds objRegionFlds)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objRegionFlds.OutFldId, objRegionFlds.PrjId);
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

        public static clsCtlTypeEN ObjCtlType(this IRegionFlds objRegionFlds)
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

        public static string CtrlId(this IRegionFlds objRegionFlds)
        {
            string strCtrlId;
                if (objRegionFlds.IsUseFunc() && string.IsNullOrEmpty(objRegionFlds.DataPropertyName()) == false)
                {
                    strCtrlId = objRegionFlds.ObjCtlType().CtlTypeAbbr + objRegionFlds.DataPropertyName() + "_q";
                }
                else
                {
                    strCtrlId = objRegionFlds.ObjCtlType().CtlTypeAbbr + objRegionFlds.ObjFieldTab().FldName + "_q";
                }
                return strCtrlId;
            
            
        }
        public static string PrjId(this IRegionFlds objRegionFlds)
        {
            //var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(objRegionFlds.PrjId);
            return objRegionFlds.PrjId;
        }

        public static long OutDataNodeId(this IRegionFlds objRegionFlds)
        {
            var objDataNode = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(objRegionFlds.TabId(), objRegionFlds.OutFldId, 1, objRegionFlds.PrjId);
            if (objDataNode == null) return 0;
            return objDataNode.DataNodeId;
        }
        public static string OutFldName(this IRegionFlds objRegionFlds)
        {
            string strFldName = clsFieldTabBL.GetFldNameByFldIdCache(objRegionFlds.OutFldId, objRegionFlds.PrjId);
            return strFldName;
        }

        public static string FldName(this IRegionFlds objRegionFlds)
        {
            string strFldName = clsFieldTabBL.GetFldNameByFldIdCache(objRegionFlds.FldId, objRegionFlds.PrjId);
            return strFldName;
        }

        public static clsViewRegionEN ObjViewRegion(this IRegionFlds objRegionFlds)
        {
            try
            {
                clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(objRegionFlds.RegionId, objRegionFlds.PrjId);
                return objViewRegion;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string TabId(this IRegionFlds objRegionFlds)
        {
            try
            {
                clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(objRegionFlds.RegionId, objRegionFlds.PrjId);
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
        public static string DnPathId(this IRegionFlds objRegionFlds)
        {
            try
            {
                string strTabId = objRegionFlds.TabId();
                if (strTabId == null) return null;
                string strPrjId = objRegionFlds.PrjId;
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objRegionFlds.OutFldId, strPrjId);
                if (objPrjTabFld != null) return objPrjTabFld.DnPathId;
                objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objRegionFlds.FldId, strPrjId);
                if (objPrjTabFld != null) return objPrjTabFld.DnPathId;
                return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool IsUseFunc(this IRegionFlds objRegionFlds)
        {
            try
            {
                if (string.IsNullOrEmpty(objRegionFlds.OutFldId)) return false;
                else return true;
                //return objRegionFlds.IsForExtendClass();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string DataPropertyName4GC(this IRegionFlds objRegionFlds)
        {
            try
            {
                string strTabId = objRegionFlds.TabId();
                if (strTabId == null) return null;
                string strPrjId = objRegionFlds.PrjId;
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objRegionFlds.OutFldId, strPrjId);
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


        public static string DataPropertyName(this IRegionFlds objRegionFlds)
        {
            try
            {
                string strTabId = objRegionFlds.TabId();
                if (strTabId == null) return null;
                string strPrjId = objRegionFlds.PrjId;
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objRegionFlds.OutFldId, strPrjId);
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
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objRegionFlds"></param>
        /// <returns></returns>
        public static string DataPropertyName_FstLcase(this IRegionFlds objRegionFlds, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objRegionFlds.DataPropertyName();
            }
            else
            {
                return clsString.FstLcaseS(objRegionFlds.DataPropertyName() ??"");
            }
        }
    }
}
