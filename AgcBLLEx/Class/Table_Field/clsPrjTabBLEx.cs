using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.sql;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using TzAdvancedLib;

namespace AGC.BusinessLogicEx
{
    public static class clsPrjTabBLEx_Static
    {

        public static string TabName4GC(this clsPrjTabEN objPrjTabEx)
        {
            return objPrjTabEx.TabName;
        }


        public static string FunctionTemplateId(this clsPrjTabENEx objPrjTabEx, string strCmPrjId)
        {
            //var strCmPrjId = objPrjTabEx.CmPrjId;
            if (string.IsNullOrEmpty(strCmPrjId) == true)
            {
                string strMsg = string.Format("表:[{0}({1})]中没有设置Cm工程Id，请检查!(in {2})", objPrjTabEx.TabName, objPrjTabEx.TabId, clsStackTrace.GetCurrClassFunction());
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

        public static List<clsPrjConstraintEN> arrPrjConstraintSet(this clsPrjTabEN objPrjTab)
        {
            List<clsPrjConstraintEN> arrPrjConstraintCache = clsPrjConstraintBL.GetObjLstCache(objPrjTab.PrjId);
            var arrPrjConstraint_Sel = arrPrjConstraintCache.Where(x => x.TabId == objPrjTab.TabId).ToList();

            return arrPrjConstraint_Sel;
        }

        public static List<clsTabFeatureEN> arrTabFeatureSet(this clsPrjTabENEx objPrjTabEx)
        {
            List<clsTabFeatureEN> arrTabFeatureCache = clsTabFeatureBL.GetObjLstCache(objPrjTabEx.PrjId);
            var arrTabFeature_Sel = arrTabFeatureCache.Where(x => x.TabId == objPrjTabEx.TabId).ToList();

            return arrTabFeature_Sel;
        }

        public static int TabFldNum(this clsPrjTabENEx objPrjTabEx)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTabEx.TabId, objPrjTabEx.PrjId);
            return arrPrjTabFld.Count;
        }
        public static string PrimaryTypeId(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";

            return arrPrjTabFld_Sel[0].PrimaryTypeId;
        }
        public static string KeyFldId(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";

            return arrPrjTabFld_Sel[0].FldId;
        }
        public static clsPrjTabFldENEx ObjKeyField1(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return null;
            clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
            clsPrjTabFldBL.CopyTo(arrPrjTabFld_Sel[0], objPrjTabFldENEx);
            objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
            return objPrjTabFldENEx;
        }

        public static clsPrjTabFldEN CacheClassifyFldTS(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);

            var ObjCacheClassifyFld_TS = arrPrjTabFld.Find(x => x.FldId
           == objPrjTab.CacheClassifyFieldTS);
            return ObjCacheClassifyFld_TS;

        }

        public static clsPrjTabFldEN CacheClassifyFld2TS(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);

            var ObjCacheClassifyFld_TS = arrPrjTabFld.Find(x => x.FldId
           == objPrjTab.CacheClassifyField2TS);
            return ObjCacheClassifyFld_TS;

        }
        public static bool IsHasCacheClassifyFld2TS(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);

            var ObjCacheClassifyFld_TS = arrPrjTabFld.Find(x => x.FldId
           == objPrjTab.CacheClassifyField2TS);
            return ObjCacheClassifyFld_TS == null ? false : true;

        }

        public static bool IsHasCacheClassifyFldTS(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);

            var ObjCacheClassifyFld_TS = arrPrjTabFld.Find(x => x.FldId
           == objPrjTab.CacheClassifyFieldTS);
            return ObjCacheClassifyFld_TS == null ? false : true;

        }
        public static string KeyFldName(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(arrPrjTabFld_Sel[0].FldId, objPrjTab.PrjId);
            return objFieldTab.FldName;
        }

        public static string KeyFldName_Types(this clsPrjTabEN objPrjTab)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTab.TabId, objPrjTab.PrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            if (arrPrjTabFld_Sel.Count == 0) return "";
            string strKeyFldName_Types = "";
            foreach (var objInFor in arrPrjTabFld_Sel)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(arrPrjTabFld_Sel[0].FldId, objPrjTab.PrjId);
                var objPrimaryType = objInFor.ObjPrimaryType();
                strKeyFldName_Types += string.Format("{0}({1}),", objFieldTab.FldName, objPrimaryType.PrimaryTypeName);
            }
            strKeyFldName_Types = strKeyFldName_Types.TrimEnd(',');
            return strKeyFldName_Types;
        }

        public static int KeyFldNum(this clsPrjTabENEx objPrjTabEx)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objPrjTabEx.TabId, objPrjTabEx.PrjId);
            var arrPrjTabFld_Key = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            return arrPrjTabFld_Key.Count;
        }

        /// <summary>
        /// 获取对象扩展信息
        /// </summary>
        /// <param name="objUserCodePathEx"></param>
        /// <returns></returns>
        public static void GetObjExInfo(this clsPrjTabENEx objPrjTabEx, clsUserCodePathENEx objUserCodePathEx)
        {
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(objUserCodePathEx.CodeTypeId);
            objPrjTabEx.CodeTypeId = objUserCodePathEx.CodeTypeId;
            objPrjTabEx.ObjFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabEx.FuncModuleAgcId, objPrjTabEx.PrjId);
            objPrjTabEx.FileName = string.Format(objCodeTypeEN.FileNameFormat, objPrjTabEx.TabName);
            //this.ObjGCPrjRelaFile.PrjInnerCodePath = objUserCodePathEx.GetPrjInnerCodePath();
            objPrjTabEx.PrjInnerFileName = clsPrjTabBLEx.GetFileNameInPrj(objUserCodePathEx.PrjInnerCodePath,
                objPrjTabEx.ObjFuncModule.FuncModuleEnName, objPrjTabEx.FileName);

            //this.ObjGCPrjRelaFile.FullProjectPath = objUserCodePathEx.GetFullProjectPath(this.ObjUserCodePrjMainPath);
            objPrjTabEx.FullFileName = string.Format("{0}\\{1}\\{2}", objUserCodePathEx.NewCodePath,
                objPrjTabEx.ObjFuncModule.FuncModuleEnName, objPrjTabEx.FileName);
            objPrjTabEx.FullFileName = objPrjTabEx.FullFileName.Replace("\\/\\", "\\")
                              .Replace("/", "\\").Replace("\\\\", "\\");

            objPrjTabEx.SuffixPath = objUserCodePathEx.SuffixPath;
            objPrjTabEx.TabSpace = objPrjTabEx.DataBaseName;
            objPrjTabEx.objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabEx.PrjId);
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsPrjTabEN:objPrjTabENT</returns>
        public static clsPrjTabENEx CopyToEx(this clsPrjTabEN objPrjTabENS)
        {
            try
            {
                clsPrjTabENEx objPrjTabENT = new clsPrjTabENEx();
                clsPrjTabBL.CopyTo(objPrjTabENS, objPrjTabENT);
                return objPrjTabENT;
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
        /// <param name = "objPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsPrjTabEN:objPrjTabENT</returns>
        public static clsPrjTabEN CopyTo(this clsPrjTabENEx objPrjTabENS)
        {
            try
            {
                clsPrjTabEN objPrjTabENT = new clsPrjTabEN();
                clsPrjTabBL.CopyTo(objPrjTabENS, objPrjTabENT);
                return objPrjTabENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string ProgLangTypeId(this clsPrjTabENEx objPrjTabENEx)
        {
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
            if (objCodeType == null) return enumProgLangType.CSharp_01;
            return objCodeType.ProgLangTypeId;
        }
        public static bool IsUseCache_TS(this clsPrjTabEN objPrjTabEN)
        {
            if (objPrjTabEN == null) return false;
            List<string> arrCacheModeId = new List<string>() { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04,
             enumCacheMode.VueXStore_06, enumCacheMode.PiniaStore_07};
            if (arrCacheModeId.Contains(objPrjTabEN.CacheModeId) == true) return true;
            return false;
        }
        public static bool IsUseStorageCache_TS(this clsPrjTabEN objPrjTabEN)
        {
            if (objPrjTabEN == null) return false;
            List<string> arrCacheModeId = new List<string>() { enumCacheMode.localStorage_03, enumCacheMode.sessionStorage_04, };
            if (arrCacheModeId.Contains(objPrjTabEN.CacheModeId) == true) return true;
            return false;
        }
        public static bool IsUseStoreCache_TS(this clsPrjTabEN objPrjTabEN)
        {
            if (objPrjTabEN == null) return false;
            List<string> arrCacheModeId = new List<string>() { enumCacheMode.VueXStore_06, enumCacheMode.PiniaStore_07 };
            if (arrCacheModeId.Contains(objPrjTabEN.CacheModeId) == true) return true;
            return false;
        }


        public static bool GetObjAllInfoEx(this clsPrjTabENEx objPrjTabENEx)
        {
            objPrjTabENEx.arrPrjTabFldENExObjLst = clsPrjTabFldBLEx.GetObjExLstOrderBySequence(objPrjTabENEx.PrjId, objPrjTabENEx.TabId);

            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrPrjTabFldENExObjLst)
            {
                objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

                objPrjTabFldENEx.ObjFieldTabENEx.LangType = objPrjTabENEx.LangType;
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objPrjTabFldENEx.ObjFieldTabENEx.DataTypeId);
                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN = objDataTypeAbbrEN.CopyToEx();
                objPrjTabFldENEx.objFieldTypeEN = clsFieldTypeBL.GetObjByFieldTypeIdCache(objPrjTabFldENEx.FieldTypeId);
                objPrjTabFldENEx.objPrimaryTypeEN = clsPrimaryTypeBL.GetObjByPrimaryTypeIdCache(objPrjTabFldENEx.PrimaryTypeId);
            }

            objPrjTabENEx.TabSpace = objPrjTabENEx.DataBaseName;
            objPrjTabENEx.objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId);
            objPrjTabENEx.ObjFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);

            try
            {
                objPrjTabENEx.initFldSet();
                objPrjTabENEx.PrefixField = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FieldTypeId == enumFieldType.PrefixField_19);
                objPrjTabENEx.objCacheClassifyFld = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FldId == objPrjTabENEx.CacheClassifyField);
                objPrjTabENEx.objCacheClassifyFld2 = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FldId == objPrjTabENEx.CacheClassifyField2);

                objPrjTabENEx.ObjCacheClassifyFld_TS = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FldId
                == objPrjTabENEx.CacheClassifyFieldTS);
                objPrjTabENEx.ObjCacheClassifyFld2_TS = objPrjTabENEx.arrPrjTabFldENExObjLst.Find(x => x.FldId
                == objPrjTabENEx.CacheClassifyField2TS);

            }
            catch (Exception objException)
            {
                throw objException;
            }
            return true;
        }



        /// <summary>
        /// 初始化字段结合
        /// </summary>
        private static bool initFldSet(this clsPrjTabENEx objPrjTabENEx)
        {
            //步骤:
            //1、判断初始数据是否合法
            //2、把表中相关信息初始化到一个类对象中,
            //		然后存到集合中
            //3、

            objPrjTabENEx.arrFldSetAll = new List<clsPrjTabFldENEx>();
            objPrjTabENEx.arrFldSet = new List<clsPrjTabFldENEx>();
            objPrjTabENEx.arrFldSetEx = new List<clsPrjTabFldENEx>();
            objPrjTabENEx.arrKeyFldSet = new List<clsPrjTabFldENEx>();
            string strCondition = string.Format("{0}='{1}' and {2}='1'", conPrjConstraint.TabId, objPrjTabENEx.TabId, conPrjConstraint.InUse);

            IEnumerable<clsPrjConstraintEN> arrPrjConstraintCache = clsPrjConstraintBL.GetObjLstCache(objPrjTabENEx.PrjId);
            IEnumerable<clsPrjConstraintENEx> arrPrjConstraintExCache = arrPrjConstraintCache.Select(clsPrjConstraintBLEx.CopyToEx);

            //            objPrjTabENEx.arrPrjConstraintSet = clsPrjConstraintBLEx.GetObjExLst(strCondition);
            //objPrjTabENEx.arrPrjConstraintSet = arrPrjConstraintExCache.Where(x => x.TabId == objPrjTabENEx.TabId && x.InUse == true).ToList();
            //strCondition = string.Format("{0}='{1}' and {2}='1'", clsConstraintFieldsEN.con_TabId, objPrjTabENEx.TabId, clsConstraintFieldsEN.con_InUse);

            IEnumerable<clsConstraintFieldsEN> arrConstraintFieldsCache = clsConstraintFieldsBL.GetObjLstCache(objPrjTabENEx.PrjId);
            IEnumerable<clsConstraintFieldsENEx> arrConstraintFieldsExCache = arrConstraintFieldsCache.Select(clsConstraintFieldsBLEx.CopyToEx);


            //strCondition = string.Format("{0}='{1}'", conTabFunctionProp.TabId, objPrjTabENEx.TabId);
            IEnumerable<clsTabFunctionPropEN> arrTabFunctionPropCache = clsTabFunctionPropBL.GetObjLstCache(objPrjTabENEx.PrjId);

            //objPrjTabENEx.arrTabFunctionProp = clsTabFunctionPropBL.GetObjLst(strCondition);
            objPrjTabENEx.arrTabFunctionProp = arrTabFunctionPropCache.Where(x => x.TabId == objPrjTabENEx.TabId).ToList();

            //arrMId = clsPrjTabFldENEx.funGetFldValue2("PrjTabFld", "Mid", "TabId = '" + objViewInfoENEx.TabId + "'", "SequenceNumber");
            foreach (clsPrjTabFldENEx objPrjTabFldENEx in objPrjTabENEx.arrPrjTabFldENExObjLst)
            {
                objPrjTabENEx.arrFldSetAll.Add(objPrjTabFldENEx);
                if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "timestamp")
                {
                    if (objPrjTabFldENEx.IsForExtendClass == false)
                    {
                        objPrjTabENEx.arrFldSet.Add(objPrjTabFldENEx);
                    }
                    else
                    {
                        objPrjTabENEx.arrFldSetEx.Add(objPrjTabFldENEx);
                    }
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.KeyField_02)
                {
                    objPrjTabENEx.arrKeyFldSet.Add(objPrjTabFldENEx);
                }

                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.NameField_03)
                {
                    objPrjTabENEx.objNameField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.OrderNumField_09)
                {
                    objPrjTabENEx.objOrderNumField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.DelSignField_12)
                {
                    objPrjTabENEx.objDelSignField = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.ObjFieldTab4CodeConv() != null)
                {
                    objPrjTabENEx.IsNeedTransCode = true;
                }
                if (objPrjTabFldENEx.FieldTypeId == enumFieldType.NameField_03)
                {
                    objPrjTabENEx.objPrjTabFld4NameFld = objPrjTabFldENEx;
                }
                if (objPrjTabFldENEx.IsSortFld == true)
                {
                    objPrjTabENEx.objSortField = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
                }

            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                return false;
            }
            objPrjTabENEx.objKeyField0 = (clsPrjTabFldENEx)objPrjTabENEx.arrKeyFldSet[0];

            return true;
        }

        public static bool GetPrjTabFldENExObjLst(this clsPrjTabENEx objPrjTabENEx)
        {
            //string strCondition = string.Format("TabId = '{0}'", objPrjTabENEx.TabId);
            objPrjTabENEx.arrPrjTabFldENExObjLst = clsPrjTabFldBLEx.GetObjExLstOrderBySequence(objPrjTabENEx.PrjId, objPrjTabENEx.TabId);
            return true;
        }

    }

    public partial class clsPrjTabBLEx : clsPrjTabBL
    {
        public static List<string> arrTabNameLst_CommonTable = null;

        private string mstrWebSrvClassId = "";
        public clsPrjTabENEx objPrjTabENEx = null;
        /// <summary>
        /// 
        /// </summary>
        public clsWebSrvClassENEx objWebSrvClassENEx = null;

        public clsProjectsENEx objProjectsENEx = null;
        public clsFuncModule_AgcEN objFuncModuleEN = null;
        public clsPrjDataBaseEN objPrjDataBaseEN = null;

        private static Dictionary<string, clsPrjTabEN> dicPrjTabLst = null;// new Dictionary<string, clsPrjTabEN>();
        private static string mstrLastRecordDateTime = "";

        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        //protected static int intFindFailCount = 0;
        ///// <summary>
        ///// 从缓存中查找失败的次数
        ///// </summary>


        public clsPrjTabBLEx()
        {

        }
        public clsPrjTabBLEx(string strPrjId)
        {
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            objProjectsENEx = new clsProjectsENEx();
            clsProjectsBL.CopyTo(objProjectsEN, objProjectsENEx);
            // this.objProjectsENEx =(clsProjectsENEx) clsProjectsBL.GetObjByPrjIdCache(strPrjId);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strTabId"></param>
        /// <param name="strPrjDataBaseId"></param>
        /// <param name="strPrjId"></param>
        public clsPrjTabBLEx(string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            this.objPrjTabENEx = new clsPrjTabENEx(strTabId);
            clsPrjTabBL.CopyTo(objPrjTabEN, this.objPrjTabENEx);
            //this. objPrjTabENEx = new clsPrjTabENEx(strTabId);
            this.objPrjTabENEx.GetObjAllInfoEx();
            this.objPrjTabENEx.PrjDataBaseId = strPrjDataBaseId;
            //try
            //{
            //    this.objPrjTab4GCEN = clsPrjTab4GCBL.GetObjByTabId4GC(strTabId);
            //}
            //catch (Exception objException)
            //{
            //    this.objPrjTab4GCEN = new clsPrjTab4GCEN(strTabId);
            //    this.objPrjTab4GCEN.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            //    clsPrjTab4GCBL.AddNewRecordBySql2(this.objPrjTab4GCEN);
            //}
            //if (this.objPrjTab4GCEN == null)
            //{
            //    this.objPrjTab4GCEN = new clsPrjTab4GCEN(strTabId);
            //    this.objPrjTab4GCEN.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            //    clsPrjTab4GCBL.AddNewRecordBySql2(this.objPrjTab4GCEN);
            //}
            //clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            this.objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            if (this.objFuncModuleEN == null)
            {
                string strMsg = string.Format("表:[{0}({1})]的模块为空，请维护该表的模块。({2})",
                    this.objPrjTabENEx.TabName, this.objPrjTabENEx.TabCnName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId);
            this.objProjectsENEx = new clsProjectsENEx();
            clsProjectsBL.CopyTo(objProjectsEN, objProjectsENEx);
            this.objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strFunctionTemplateId = clsPrjFuncTemplateRelaBLEx.getFunctionTemplateIdByPrjId(objPrjTabENEx.PrjId);
            //objPrjTabENEx.FunctionTemplateId = strFunctionTemplateId;
        }


        public static void BindDdl_TabIdExCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strFuncModuleId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //            System.Data.DataTable objDT = GetTabId(strPrjId, strFuncModuleId);
            List<clsPrjTabEN> arrPrjTabObjLst = GetObjLstByFuncModuleIdCacheEx(strPrjId, strFuncModuleId);

            objDDL.DataValueField = "TabId";
            objDDL.DataTextField = "TabName";
            objDDL.DataSource = arrPrjTabObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static List<clsPrjTabEN> GetObjLstByFuncModuleIdCacheEx(string strPrjId, string strFuncModuleAgcId)
        {
            List<clsPrjTabEN> arrObjLstCache = clsPrjTabBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabEN> arrPrjTabObjLst_Sel1 =
                from objPrjTabEN in arrObjLstCache
                where objPrjTabEN.PrjId == strPrjId
                 && objPrjTabEN.FuncModuleAgcId == strFuncModuleAgcId

                select objPrjTabEN;


            List<clsPrjTabEN> arrPrjTabObjLst_Sel = new List<clsPrjTabEN>();
            foreach (clsPrjTabEN obj in arrPrjTabObjLst_Sel1)
            {
                arrPrjTabObjLst_Sel.Add(obj);
            }

            return arrPrjTabObjLst_Sel;
        }


        public static bool InitdicPrjTabLst()
        {
            dicPrjTabLst = new Dictionary<string, clsPrjTabEN>();
            return true;
        }
        /// <summary>
        /// 功能:移去错误信息
        /// </summary>
        /// <param name = "strPrjId">工程id</param>
        /// <returns>返回修改的记录数。</returns>
        public static int RemoveErrMsg(string strPrjId)
        {

            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPrjTabDA.GetSpecSQLObj();
            string strSQL;
            if (string.IsNullOrEmpty(strPrjId))
            {
                return 0;	//表示删除0条记录,实际上是不能该表的所有记录
            }
            else
            {
                strSQL = string.Format("Update PrjTab Set ErrMsg = '' where PrjId = '{0}'", strPrjId);
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }




        /// <summary>
        /// 获取给定表的关键字段名
        /// </summary>
        /// <param name = "strTabId">所给的表Id</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>获取的关键字段名</returns>
        public static bool IsExistTabKeyField(string strTabId, string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("TabId = '{0}' and FieldTypeId = '02'", strTabId);
            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBLEx.GetObjByTabIdAndFieldTypeIdCache(strTabId, "02", strPrjId);
            if (objPrjTabFldEN != null) return true;
            return false;
            //bool bolIsExist = clsPrjTabFldBL.IsExistRecord(sbCondition.ToString());
            //return bolIsExist;
        }

        /// <summary>
        /// 根据表名获取表对象
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strTabName">表名</param>
        /// <returns>获取的表对象</returns>
        public static clsPrjTabEN GetObjByTabNameB(string strPrjId, string strTabName)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}' and TabName = '{1}'", strPrjId, strTabName);
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetFirstObj_S(sbCondition.ToString());
            return objPrjTabEN;
        }


        public static bool IsExistFieldInTabField(string strFldName, List<clsvPrjTabFldEN> arrPrjTabFldObjList)
        {
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                string strFldNameB = objPrjTabFldEN.FldName;
                if (strFldNameB.Equals(strFldName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 检查表是否在通用表中
        /// </summary>
        /// <param name="strTabName">所给表名</param>
        /// <returns>是否存在？</returns>
        public static bool IsExistTabNameInCommonTable(string strTabName)
        {
            if (arrTabNameLst_CommonTable == null)
            {
                arrTabNameLst_CommonTable = clsPrjTabBL.GetFldValue(conPrjTab.TabName, "prjId='0170'");
            }
            if (arrTabNameLst_CommonTable.Contains(strTabName)) return true;
            return false;
        }


        /// <summary>
        /// 根据视图图获得相关表名称
        /// </summary>
        /// <param name = "strViewName">视图名称</param>
        /// <returns>相关表名称</returns>
        public static string GetReleTabNameByViewName(string strViewName)
        {
            if (strViewName.Substring(0, 1).Equals("v", StringComparison.InvariantCultureIgnoreCase) == false) return "";
            return strViewName.Substring(1);
        }
        /// <summary>
        /// 根据表名获取相关的视图表Id
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strTabName">表名</param>
        /// <returns>相关的视图表Id</returns>
        public static string GetRelaViewTabIdByTabName(string strPrjId, string strTabName)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            sbCondition.AppendFormat(" and (TabName = 'v{0}' or TabName = 'V{0}')", strTabName);
            string strTabId = clsPrjTabBL.GetFirstID_S(sbCondition.ToString());

            return strTabId;
        }

        /// <summary>
        /// 根据表Id获取相关的视图表Id
        /// </summary>
        /// <param name = "strTabName">表Id</param>
        /// <returns>相关的视图表Id</returns>
        public static string GetRelaViewTabIdByTabIdCache(string strTabId, string strPrjId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            var strTabName = string.Format("v{0}", objPrjTabEN.TabName);

            var objPrjTab_View = clsPrjTabBLEx.GetObjByTabNameExCache(strPrjId, strTabName);
            if (objPrjTab_View == null) return "";
            return objPrjTab_View.TabId;
        }
        /// <summary>
        /// 根据视图的表Id获取相关的主表Id
        /// </summary>
        /// <param name = "strViewTabId">表Id</param>
        /// <returns>相关的视图表Id</returns>
        public static string GetRelaTabIdByViewTabId(string strViewTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strViewTabId);

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", objPrjTabEN.PrjId);
            sbCondition.AppendFormat(" and (TabName = '{0}')", objPrjTabEN.TabName.Substring(1));
            string strTabId_View = clsPrjTabBL.GetFirstID_S(sbCondition.ToString());

            return strTabId_View;
        }
        /// <summary>
        /// 为视图设置默认主表
        /// 作者:潘以锋
        /// 日期:20141002
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns></returns>
        public static bool SetRelaDefaMainTabId4View(string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            sbCondition.Append(" and (SqlDsTypeId = '02')");
            List<clsPrjTabEN> arrPrjTabObjList = clsPrjTabBL.GetObjLst(sbCondition.ToString());
            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjList)
            {
                string strRelaTabId = clsPrjTabBLEx.GetRelaTabIdByViewTabId(objPrjTabEN.TabId);
                if (string.IsNullOrEmpty(strRelaTabId) == true) continue;
                objPrjTabEN.RelaTabId4View = strRelaTabId;
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }
            return true;
        }
        /// <summary>
        /// 根据表名获取相关的视图表Id
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strViewName">表名</param>
        /// <returns>相关的视图表Id</returns>
        public static string GetRelaTabIdByViewName(string strPrjId, string strViewName)
        {
            string strFirstChar = strViewName.Substring(0, 1);
            if (strFirstChar.Equals("v", StringComparison.InvariantCultureIgnoreCase) == false) return "";
            string strRelaTabName = strViewName.Substring(1);
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            //sbCondition.AppendFormat(" and TabName = '{0}'", strRelaTabName);
            //            string strTabId = clsPrjTabBL.GetFirstID_S(sbCondition.ToString());
            string strTabId = clsPrjTabBLEx.GetTabIdByTabNameExCache(strPrjId, strRelaTabName);

            return strTabId;
        }


        public static string ImportTableViewFromSQLByTabName(string strPrjId,
            string strPrjDataBaseId,
            string strTabName, string strSqlDsTypeId, string strUserId)
        {
            //clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(objPrjDataBaseEN);
            bool bolResult = true;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            string strTabId;

            string strObjName;

            string strObjFunction;
            string strFldCaption;
            string strFldName;
            string strFldType;
            string strTabCnName, strTabMemo;
            string strIsNull;
            int intFldLength;

            bool bolIsNull;

            string strFuncModuleId = "";

            strObjName = strTabName;
            strObjFunction = strTabName;
            if (strSqlDsTypeId == "02")// 是视图
            {
                string strRelaTabName = clsPrjTabBLEx.GetReleTabNameByViewName(strTabName);
                string strCondition = string.Format("TabName = '{0}' And PrjId = '{1}'", strRelaTabName, strPrjId);

                clsPrjTabEN objRelePrjTab = clsPrjTabBL.GetFirstObj_S(strCondition);
                strFuncModuleId = objRelePrjTab.FuncModuleAgcId;
            }
            //try
            //{
            //    bolResult = clsPrjObjectsBLEx.AddRecord(strPrjId, strUserId, strObjName, strObjFunction, strFuncModuleId);
            //}
            //catch (Exception objException)
            //{
            //    throw new Exception("导入数据表(视图)失败--添加对象失败。" + objException.Message);
            //}
            //if (bolResult == false)
            //{
            //    return false;
            //}
            //5、向表中添加该表记录；
            strTabCnName = strTabName;
            strTabMemo = strTabName;

            try
            {
                strTabId = clsPrjTabBLEx.AddRecord(strPrjId, objPrjDataBaseEN.DataBaseName,
                strTabName,
                strTabCnName,
                strTabMemo, strSqlDsTypeId, strFuncModuleId, strUserId);
            }
            catch (Exception objException)
            {
                throw new Exception("导入数据表(视图)失败--添加工程表失败。" + objException.Message);

            }
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                return strTabId;
            }

            //6、在表字段中添加相关字段。
            strTabId = clsPrjTabBLEx.GetTabId(strPrjId, strTabName);
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                clsProjectsEN objProjects = clsProjectsBL.GetObjByPrjId(strPrjId);

                sbMsg.AppendFormat("在工程:{0}({1})中没有表{2},请检查!",
                    objProjects.PrjName, objProjects.PrjId, strTabName);
                throw new Exception(sbMsg.ToString());

            }
            //4、再向该视图对象表中添加相关字段。
            List<clsColumns> arrColumnObjList = clsSqlObject.GetColumnObjList(strTabName,
                strConnectString,
                objPrjDataBaseEN.DatabaseOwner);
            foreach (clsColumns objColumn in arrColumnObjList)
            {
                strFldName = objColumn.Column_Name;
                strFldCaption = strFldName;
                strFldType = objColumn.Type_Name;
                intFldLength = objColumn.length;
                strIsNull = objColumn.Is_Nullable;
                bolIsNull = strIsNull == "NO" ? false : true;
                try
                {
                    string strFldId = clsFieldTabBLEx.ImportFldToFieldTab(strFldName,
                          strFldCaption,
                          strFldType,
                          intFldLength,
                          bolIsNull,
                          strPrjId);
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTabId, strFldId, strUserId);
                }
                catch (Exception objException)
                {
                    throw new Exception("导入数据表(视图)失败--添加字段列表失败。" + objException.Message);

                }
            }

            //try
            //{
            //    bolResult = clsPrjTabFldBLEx.Add_ObjectFldtoPrjTabFld(strTabId);
            //}
            //catch (Exception objException)
            //{
            //    throw new Exception("导入数据表(视图)失败。" + objException.Message);
            //}
            if (bolResult == true)
            {
                return strTabId;
            }

            //}

            //操作步骤:
            //1、获取教务管理结构表中的所有记录MId,并对这些记录进行循环:
            //2、针对每条记录:
            //3、添加对象信息,在添加时需要检查是否重复；
            //4、再向该视图对象表中添加相关字段。
            //5、向表中添加该表记录；
            //6、在表字段中添加相关字段。

            return strTabId;
        }

        /// <summary>
        /// 根据表名得到相应的表Id
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strTabName"></param>
        /// <returns></returns>
        public static string GetTabId(string strPrjId, string strTabName)
        {
            return clsPrjTabBL.GetFirstID_S("PrjId = '" + strPrjId + "' and TabName = '" + strTabName + "'");
        }
        public static string AddRecord(string strPrjId,
            string strDataBaseName,
            string strTabName,
            string strTabCnName,
            string strTabMemo,
            string strSqlDsTypeId,
            string strFuncModuleId,
            string strUserId)
        {
            if (IsExistSameTabName(strPrjId, strTabName) == true)
            {
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + strTabName + "' and PrjId = '" + strPrjId + "'");
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);

                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
                return strTabId;
            }
            string strRelaTabId4View = "";
            if (strSqlDsTypeId == "02")
            {
                strRelaTabId4View = clsPrjTabBLEx.GetRelaTabIdByViewName(strPrjId, strTabName);
            }
            clsPrjTabEN objPrjTabENEx = new clsPrjTabEN();
            objPrjTabENEx.TabId = clsGeneralTab.GetMaxStrId("PrjTab", "TabId", 8, strPrjId);
            objPrjTabENEx.TabName = strTabName;
            objPrjTabENEx.PrjId = strPrjId;
            objPrjTabENEx.DataBaseName = strDataBaseName;
            objPrjTabENEx.TabCnName = strTabCnName;

            objPrjTabENEx.IsNeedTransCode = false;
            objPrjTabENEx.TabStateId = "01";
            if (strSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
            {
                objPrjTabENEx.TabTypeId = "0001";
            }
            else
            {
                objPrjTabENEx.TabTypeId = "0006";
            }
            objPrjTabENEx.RelaTabId4View = strRelaTabId4View;
            objPrjTabENEx.Memo = strTabMemo;
            objPrjTabENEx.SqlDsTypeId = strSqlDsTypeId;
            objPrjTabENEx.FuncModuleAgcId = strFuncModuleId;
            objPrjTabENEx.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabENEx.UpdUserId = strUserId;
            objPrjTabENEx.IsReleToSqlTab = true;
            objPrjTabENEx.IsUseCache = true;
            objPrjTabENEx.TabMainTypeId = enumTabMainType.DataTab_0001;
            try
            {
                if (string.IsNullOrEmpty(objPrjTabENEx.RelaTabId4View)) objPrjTabENEx.RelaTabId4View = null;
                clsPrjTabBL.AddNewRecordBySql2(objPrjTabENEx);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("建表:{0}时出错！错误:{1}.(In {2})", strTabName, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return objPrjTabENEx.TabId;

        }
        public static bool IsExistSameTabName(string strPrjId, string strTabName)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{1}' and TabName = '{0}'", strTabName, strPrjId);
            return clsPrjTabBL.IsExistRecord(strCondition.ToString());
        }


        public static void BindCbo_TabIdEx(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("PrjId = '{0}' order by {1}", strPrjId, conPrjTab.TabName);
            List<clsPrjTabEN> arrObj = clsPrjTabBL.GetObjLst(strCondition);
            clsPrjTabEN objPrjTabEN;
            //初始化一个对象列表
            ArrayList PrjTabList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objPrjTabEN = new clsPrjTabEN();
            objPrjTabEN.TabId = "0";
            objPrjTabEN.TabName = "请选择...";
            PrjTabList.Add(objPrjTabEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsPrjTabEN objRow in arrObj)
            {
                PrjTabList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjTabList;
            objComboBox.ValueMember = "TabId";
            objComboBox.DisplayMember = "TabName";
            objComboBox.SelectedIndex = 0;
        }

        private string KeyWhereStr(bool isNeed_m)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                //'strTemp = objPrjTabENEx.arrKeyFldSet[i].ColumnName + " = \"" + Mark(objPrjTabENEx.arrKeyFldSet[i]) + "+ " + "m" + objField.ObjFieldTabENEx.PrivFuncName + Mark(objPrjTabENEx.arrKeyFldSet[i])
                if (i == 0)	//是否是第一次
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }
        private string Mark(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                return "\"\'\"";
            }
            else
            {
                return "\"\"";
            }

        }



        /// <summary>
        /// 设置修改时间
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>是否成功？</returns>
        public static bool SetUpdDate(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            if (string.IsNullOrEmpty(objPrjTabEN.RelaTabId4View) == true) objPrjTabEN.RelaTabId4View = null;
            return clsPrjTabBL.UpdateBySql2(objPrjTabEN);
        }

        public static System.Data.DataTable GetTabIdBySqlDsTypeId(string strPrjId, string strSqlDsTypeId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select TabId, TabName from PrjTab where PrjId = '{0}' And SqlDsTypeId = '{1}' order by TabName", strPrjId, strSqlDsTypeId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }

        public static string GetTabCnNameByTabIdCache(string strTabId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return "";
            //获取缓存中的对象列表
            clsPrjTabEN objPrjTab = GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTab == null) return "";
            return objPrjTab.TabCnName;
        }

        public static void BindDdl_TabIdBySqlDsTypeIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strSqlDsTypeId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTabIdBySqlDsTypeId(strPrjId, strSqlDsTypeId);
            objDDL.DataValueField = "TabId";
            objDDL.DataTextField = "TabName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_TabIdByPrjIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            string strCondition = string.Format("PrjId = '{0}' order by {1}", strPrjId, conPrjTab.TabName);
            System.Data.DataTable objDT = new clsPrjTabDA().GetDataTable_PrjTab(strCondition);
            objDDL.DataValueField = "TabId";
            objDDL.DataTextField = "TabName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_TabIdByRegionIdEx(System.Web.UI.WebControls.DropDownList objDDL, string lngRegionId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            string strCondition = string.Format("{0} = {1} order by {2}",
                convViewRelaTab.RegionId, lngRegionId, conPrjTab.TabName);
            System.Data.DataTable objDT = clsvViewRelaTabBL.GetDataTable(strCondition);
            objDDL.DataValueField = "TabId";
            objDDL.DataTextField = "TabName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_TabIdBySQLViewIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strSqlViewId)
        {
            string strCondition = string.Format("SqlViewId = '{0}'", strSqlViewId);
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = clsvSqlViewRelaTabBL.GetDataTable_vSqlViewRelaTab(strCondition);
            objDDL.DataValueField = "TabId";
            objDDL.DataTextField = "TabName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }



        ///// <summary>
        ///// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        ///// </summary>
        ///// <param name = "strPrjId">所给的关键字</param>
        ///// <returns>根据关键字获取的对象</returns>
        //public static List<clsPrjTabEN> GetObjLstByPrjIdCacheEx(string strPrjId)
        //{
        //    if (string.IsNullOrEmpty(strPrjId) == true) return null;
        //    //InitListCache();
        //    //string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
        //    List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache(strPrjId);

        //    arrPrjTabObjLstCache = arrPrjTabObjLstCache.OrderBy(x => x.TabId).ToList();
        //    return arrPrjTabObjLstCache;
        //}

        public static List<clsPrjTabEN> GetObjLstByCmPrjIdCacheEx(string strPrjId, string strCmPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true) return null;
            if (string.IsNullOrEmpty(strCmPrjId) == true) return null;
            List<string> arrTabId = clsCmProjectPrjTabBLEx.GetTabIdLstCache(strCmPrjId);
            //InitListCache();
            //string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
            List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache(strPrjId).Where(x => arrTabId.Contains(x.TabId)).ToList();

            arrPrjTabObjLstCache = arrPrjTabObjLstCache.OrderBy(x => x.TabId).ToList();
            return arrPrjTabObjLstCache;
        }

        public static List<clsPrjTabEN> GetObjLstByPrjIdEx(string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true) return null;
            List<clsPrjTabEN> arr = clsPrjTabBL.GetObjLst(string.Format("PrjId='{0}'", strPrjId));

            return arr;
        }
        static Func<clsPrjTabEN, clsPrjTabENEx> GetObjEx = (x) =>
         {
             clsPrjTabENEx objPrjTabEx = new clsPrjTabENEx();
             CopyTo(x, objPrjTabEx);
             return objPrjTabEx;
         };
        public static List<clsPrjTabENEx> GetObjExLstByPrjIdEx(string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true) return null;
            List<clsPrjTabEN> arr = clsPrjTabBL.GetObjLst(string.Format("PrjId='{0}'", strPrjId));
            List<clsPrjTabENEx> arrEx = arr.Select(GetObjEx).ToList();
            return arrEx;
        }


        public static clsPrjTabENEx GetObjExByTabIdCacheEx(string strTabId, string strPrjId)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strMsg = string.Format("表Id不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTab == null) return null;
            clsPrjTabENEx objPrjTabEx = objPrjTab.CopyToEx();
            return objPrjTabEx;

        }
        public static clsPrjTabENEx GetObjAllInfoEx(string strTabId, string strPrjId)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strMsg = string.Format("表Id不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTab == null) return null;
            clsPrjTabENEx objPrjTabEx = objPrjTab.CopyToEx();
            objPrjTabEx.IsAppliedInViewList = clsPrjTabBLEx.IsAppiedInViewList(strTabId, strPrjId);
            objPrjTabEx.GetObjAllInfoEx();
            return objPrjTabEx;
        }

        public static bool IsAppiedInViewList(string strTabId, string strPrjId)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strMsg = string.Format("表Id不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            var arr = clsViewRegionBLEx.GetObjLstByTabIdAndRegionTypeCache(strTabId, enumRegionType.ListRegion_0002, strPrjId);
            if (arr == null || arr.Count == 0) return false;
            return true;
        }
        public static bool IsAppiedInViewList4CmPrjId(string strTabId, string strCmPrjId)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strMsg = string.Format("表Id不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            var arr = clsViewRegionBLEx.GetObjLstByTabIdAndRegionType4CmPrjIdCache(strTabId, enumRegionType.ListRegion_0002, strCmPrjId);
            if (arr == null || arr.Count == 0) return false;
            return true;
        }
        public static CacheClassify GetCacheClassify_TSByObjEx(clsPrjTabENEx objPrjTabENEx)
        {
            CacheClassify obj = new CacheClassify
            {
                FldId = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.FldId : "",
                FldId2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.FldId : "",
                FldName = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.FldName : "",
                FldName2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.FldName : "",
                PriVarName = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName : "",
                PriVarName2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName : "",
                TypeScriptType = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                TypeScriptType2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                DataTypeId = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.DataTypeId : "",
                DataTypeId2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.DataTypeId : "",
                FldLength = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.FldLength : 0,
                FldLength2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.FldLength : 0,
                IsHasCacheClassfyFld = objPrjTabENEx.ObjCacheClassifyFld_TS == null ? false : true,
                IsHasCacheClassfyFld2 = objPrjTabENEx.ObjCacheClassifyFld2_TS == null ? false : true,
                IsNumberType = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.IsNumberType() : false,
                IsNumberType2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.IsNumberType() : false,
            };


            return obj;

        }


        /// <summary>
        /// 根据关键字获取对象在列表中的序号.
        /// </summary>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "arrPrjTabObjLst">对象列表</param>
        /// <returns>根据关键字获取的对象</returns>
        public static int GetIndexByTabId(string strTabId, List<clsPrjTabEN> arrPrjTabObjLst)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return -1;


            for (int intIndex = 0; intIndex < arrPrjTabObjLst.Count; intIndex++)
            {
                if (arrPrjTabObjLst[intIndex].TabId == strTabId)
                {
                    return intIndex;
                }
            }
            return -1;
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strTabName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetTabIdByTabNameExCache(string strPrjId, string strTabName)
        {

            //string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
            List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabEN> arrPrjTabObjLst_Sel1 =
                from objPrjTabEN in arrPrjTabObjLstCache
                where objPrjTabEN.TabName == strTabName
                select objPrjTabEN;
            List<clsPrjTabEN> arrPrjTabObjLst_Sel = new List<clsPrjTabEN>();
            foreach (clsPrjTabEN obj in arrPrjTabObjLst_Sel1)
            {
                arrPrjTabObjLst_Sel.Add(obj);
            }
            if (arrPrjTabObjLst_Sel.Count == 0)
            {
                return "";
            }
            string strMsg = string.Format("PrjId:[{0}] + TabName:[{1}]==>TabId:[{2}].({3})",
                strPrjId, strTabName,
                    arrPrjTabObjLst_Sel[0].TabId, clsStackTrace.GetCurrClassFunction());
            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            return arrPrjTabObjLst_Sel[0].TabId;

        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strTabName">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjTabEN GetObjByTabNameExCache(string strPrjId, string strTabName)
        {
            //InitListCache();
            //string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
            List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache(strPrjId);
            var arrPrjTabObjLst_Sel = arrPrjTabObjLstCache.Where(x => x.TabName.Equals(strTabName, StringComparison.InvariantCultureIgnoreCase) == true).ToList();
            if (arrPrjTabObjLst_Sel.Count == 0)
            {
                return null;
            }
            string strMsg = string.Format("PrjId:[{0}] + TabName:[{1}]==>TabId:[{2}].({3})",
                strPrjId, strTabName,
                    arrPrjTabObjLst_Sel[0].TabId, clsStackTrace.GetCurrClassFunction());
            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            return arrPrjTabObjLst_Sel[0];
        }



        /// <summary>
        /// 功能:把源工程的多个对象复制到新工程中,同时复制这些对象相关的字段。
        /// </summary>
        /// <param name = "strTarPrjId"></param>
        /// <param name = "arrSouTabId"></param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static bool CopyPrjTab(string strTarPrjId, List<string> arrSouTabId, string strUserId)
        {
            //操作步骤:
            //1、对源工程中的源对象列表进行遍历,然后针对其中的每个对象ID进行操作
            //2、根据<对象ID>获取所有属性
            //3、根据当前对象ID的属性<对象名>检查是否在目标工程中存在相同的<对象名>。
            //       如果存在相同的<对象名>就放弃该对象名,不需要复制。
            //4、把当前对象复制 到新工程中。
            //    4.1 在目标工程中新建一个对象
            //    4.2 把当前对象的属性都复制到新建的对象中
            //5、获取当前对象的相关字段列表；
            //6、对该表进行循环,把字段ID(源字段ID)插入到一个ArrayList
            //7、把这组源字段ID列表从源工程中复制到目标工程中,同时获取一组插入到目标工程中的字段ID列表
            //8、把获取的一组新字段ID列表与新对象ID建立关系
            //

            //1、对源工程中的源对象列表进行遍历,然后针对其中的每个对象ID进行操作
            foreach (string strSouTabId in arrSouTabId)
            {
                //2、根据<对象ID>获取所有属性
                CopyPrjTab(strTarPrjId, strSouTabId, strUserId);
            }
            return true;

        }

        /// <summary>
        /// 功能:把源工程的一个对象复制到新工程中,同时复制该对象相关的字段。
        /// </summary>
        /// <param name = "strSouPrjId">源工程ID</param>
        /// <param name = "strTarPrjId">目标工程ID</param>
        /// <param name = "strSouTabId">源表ID</param>
        /// <param name = "strUserId">strUserId</param>
        /// <returns>返回在目标工程中的新表ID</returns>
        public static string CopyPrjTab(string strSouPrjId,
            string strTarPrjId, string strSouTabId, string strUserId)
        {
            //操作步骤:
            //1、对源工程中的源表ID进行操作
            //2、根据<表ID>获取所有属性
            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //       如果存在相同的<表名>就放弃该表名,不需要复制。
            //4、复制源表的相关对象到新工程中。
            //5、把当前<工程表>复制 到新工程中。
            //    5.1 在目标工程中新建一个<工程表>记录
            //    5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //    5.3 当新建<工程表>记录添加到数据库中；
            //6、获取当前<工程表>记录的相关字段列表；
            //7、对该表进行循环,把字段ID(源字段ID)插入到一个ArrayList
            //8、把这组源字段ID列表从源工程中复制到目标工程中,同时获取一组插入到目标工程中的字段ID列表
            //9、把获取的一组新字段ID列表复制到<工程表字段>表中。
            //

            string strSouFldId, strTarFldId;    //源字段ID,目标字段ID
            System.Data.DataTable objDT_SouTabFld;      //, objDT_Tab;
            ArrayList arrTabFld = new ArrayList();
            //			ArrayList arrTarFldId;
            clsPrjTabEN objSouPrjTab = null;
            clsPrjTabEN objNewPrjTab = null;

            string strNewTabId = "";
            //1、对源工程中的源对象ID进行操作
            //2、根据<表ID>获取所有属性
            objSouPrjTab = clsPrjTabBL.GetObjByTabId(strSouTabId);

            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //       如果存在相同的<表名>就放弃该表名,不需要复制。
            if (clsPrjTabBL.IsExistRecord("PrjId = '" + strTarPrjId + "' and TabName = '" + objSouPrjTab.TabName + "'") == true)
            {
                strNewTabId = clsPrjTabBLEx.GetTabId(strTarPrjId, objSouPrjTab.TabName);
                return strNewTabId;
            }


            string strFuncModuleId_S = objSouPrjTab.FuncModuleAgcId;
            string strFuncModuleId_T = "";
            if (string.IsNullOrEmpty(strFuncModuleId_S) == false)
            {
                clsFuncModule_AgcEN objFuncModuleEN_S = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strFuncModuleId_S, strSouPrjId);
                string strCondition = string.Format("FuncModuleName = '{0}' And PrjId = '{1}' ",
                    objFuncModuleEN_S.FuncModuleName, strTarPrjId);
                clsFuncModule_AgcEN objFuncModuleEN_T = clsFuncModule_AgcBL.GetFirstObj_S(strCondition);
                if (objFuncModuleEN_T == null)
                {
                    clsFuncModule_AgcBL.CopyTo(objFuncModuleEN_S, objFuncModuleEN_T);
                    objFuncModuleEN_T.FuncModuleAgcId = clsFuncModule_AgcBLEx.GetMaxStrIdEx_S(strTarPrjId);
                    objFuncModuleEN_T.PrjId = strTarPrjId;
                    objFuncModuleEN_T.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objFuncModuleEN_T.UpdUser = strUserId;
                    objFuncModuleEN_T.Memo = "在复制表时生成模块名称!";
                    clsFuncModule_AgcBL.AddNewRecordBySql2(objFuncModuleEN_T);
                }
                strFuncModuleId_T = objFuncModuleEN_T.FuncModuleAgcId;
            }

            //4、复制源表的相关对象到新工程中。
            //5、把当前<工程表>复制 到新工程中。
            //    5.1 在目标工程中新建一个<工程表>记录
            strNewTabId = clsGeneralTab.GetMaxStrId("PrjTab", "TabId", 8, strTarPrjId);
            objNewPrjTab = new clsPrjTabEN(strNewTabId);
            //    5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //			objNewPrjTab.UserId = strUserId;
            objNewPrjTab.PrjId = strTarPrjId;
            objNewPrjTab.TabCnName = objSouPrjTab.TabCnName;
            //			objNewPrjTab.TabKeyFldName = objSouPrjTab.TabKeyFldName;//只读属性,不能修改
            objNewPrjTab.TabName = objSouPrjTab.TabName;

            objNewPrjTab.TabStateId = objSouPrjTab.TabStateId;
            //新数据表的数据库名,默认的数据库名使用目标工程相关的数据库名
            objNewPrjTab.DataBaseName = objSouPrjTab.DataBaseName;
            //			objNewPrjTab.TabName_Curr = objSouPrjTab.TabName_Curr;	//只读属性,不能修改
            objNewPrjTab.TabNameB = objSouPrjTab.TabNameB;
            objNewPrjTab.TabName = objSouPrjTab.TabName;
            objNewPrjTab.SqlDsTypeId = objSouPrjTab.SqlDsTypeId;
            objNewPrjTab.IsParaTab = objSouPrjTab.IsParaTab;
            objNewPrjTab.IsReleToSqlTab = objSouPrjTab.IsReleToSqlTab;
            objNewPrjTab.FuncModuleAgcId = strFuncModuleId_T;
            objNewPrjTab.Memo = objSouPrjTab.Memo;
            objNewPrjTab.IsUseCache = objSouPrjTab.IsUseCache;

            //    5.3 当新建<工程表>记录添加到数据库中；
            if (clsPrjTabBL.AddNewRecordBySql2(objNewPrjTab) == false)
            {
                return "";
            }
            else
            {
                //					strResult = "添加记录成功!";
            }

            //6、获取当前<工程表>记录的相关字段列表；
            objDT_SouTabFld = clsPrjTabFldBL.GetDataTable_PrjTabFld("TabId = '" + strSouTabId + "'");
            //7、对该表进行循环,把字段ID(源字段ID)依次进行处理,插入到目标工程中,

            foreach (DataRow objRow in objDT_SouTabFld.Rows)
            {
                strSouFldId = objRow["FldId"].ToString();
                //8、把源字段ID列表从源工程中复制到目标工程中,同时获取一个插入到目标工程中的字段ID
                strTarFldId = clsFieldTabBLEx.CopyField(strSouPrjId, strTarPrjId, strSouFldId, strUserId);
                //9、把获取的一个新字段ID列表添加到目标工程中的<工程表字段>表中。
                clsPrjTabFldBLEx.CopyPrjTabFld(strSouPrjId, strTarPrjId, strSouTabId, strNewTabId, strSouFldId, strTarFldId);
            }
            return strNewTabId;
        }

        /// <summary>
        /// 功能:把源工程的一个对象复制到新工程中,同时复制该对象相关的字段。
        /// </summary>
        /// <param name = "strSouTabId">源工程ID</param>
        /// <param name = "strTarPrjId">目标工程ID</param>
        /// <param name = "strUserId">源表ID</param>
        /// <returns>返回在目标工程中的新表ID</returns>
        public static string CopyPrjTab(string strTarPrjId, string strSouTabId, string strUserId)
        {
            //操作步骤:
            //1、对源工程中的源表ID进行操作
            //2、根据<表ID>获取所有属性
            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //       如果存在相同的<表名>就放弃该表名,不需要复制。
            //4、复制源表的相关对象到新工程中。
            //5、把当前<工程表>复制 到新工程中。
            //    5.1 在目标工程中新建一个<工程表>记录
            //    5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //    5.3 当新建<工程表>记录添加到数据库中；
            //6、获取当前<工程表>记录的相关字段列表；
            //7、对该表进行循环,把字段ID(源字段ID)插入到一个ArrayList
            //8、把这组源字段ID列表从源工程中复制到目标工程中,同时获取一组插入到目标工程中的字段ID列表
            //9、把获取的一组新字段ID列表复制到<工程表字段>表中。
            //

            string strSouFldId, strTarFldId;    //源字段ID,目标字段ID
            System.Data.DataTable objDT_SouTabFld;      //, objDT_Tab;
            ArrayList arrTabFld = new ArrayList();
            //			ArrayList arrTarFldId;
            clsPrjTabEN objSouPrjTab = null;
            clsPrjTabEN objNewPrjTab = null;

            string strNewTabId = "";
            //1、对源工程中的源对象ID进行操作
            //2、根据<表ID>获取所有属性
            objSouPrjTab = clsPrjTabBL.GetObjByTabId(strSouTabId);

            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //       如果存在相同的<表名>就放弃该表名,不需要复制。
            if (clsPrjTabBL.IsExistRecord("PrjId = '" + strTarPrjId + "' and TabName = '" + objSouPrjTab.TabName + "'") == true)
            {
                strNewTabId = clsPrjTabBLEx.GetTabId(strTarPrjId, objSouPrjTab.TabName);
                return strNewTabId;
            }
            //4、复制源表的相关对象到新工程中。


            string strFuncModuleId_S = objSouPrjTab.FuncModuleAgcId;
            string strFuncModuleId_T = "";
            if (string.IsNullOrEmpty(strFuncModuleId_S) == false)
            {
                clsFuncModule_AgcEN objFuncModuleEN_S = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strFuncModuleId_S, objSouPrjTab.PrjId);
                string strCondition = string.Format("FuncModuleName = '{0}' And PrjId = '{1}' ",
                    objFuncModuleEN_S.FuncModuleName, strTarPrjId);
                clsFuncModule_AgcEN objFuncModuleEN_T = clsFuncModule_AgcBL.GetFirstObj_S(strCondition);
                if (objFuncModuleEN_T == null)
                {
                    objFuncModuleEN_T = new clsFuncModule_AgcEN();
                    clsFuncModule_AgcBL.CopyTo(objFuncModuleEN_S, objFuncModuleEN_T);
                    objFuncModuleEN_T.FuncModuleAgcId = clsFuncModule_AgcBLEx.GetMaxStrIdEx_S(strTarPrjId);
                    objFuncModuleEN_T.PrjId = strTarPrjId;
                    objFuncModuleEN_T.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objFuncModuleEN_T.UpdUser = strUserId;
                    objFuncModuleEN_T.Memo = "在复制表时生成模块名称!";
                    clsFuncModule_AgcBL.AddNewRecordBySql2(objFuncModuleEN_T);
                }
                strFuncModuleId_T = objFuncModuleEN_T.FuncModuleAgcId;
            }

            //5、把当前<工程表>复制 到新工程中。
            //    5.1 在目标工程中新建一个<工程表>记录
            strNewTabId = clsGeneralTab.GetMaxStrId("PrjTab", "TabId", 8, strTarPrjId);
            objNewPrjTab = new clsPrjTabEN(strNewTabId);
            //    5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //			objNewPrjTab.UserId = strUserId;
            objNewPrjTab.PrjId = strTarPrjId;
            objNewPrjTab.TabCnName = objSouPrjTab.TabCnName;
            //			objNewPrjTab.TabKeyFldName = objSouPrjTab.TabKeyFldName;//只读属性,不能修改
            objNewPrjTab.TabName = objSouPrjTab.TabName;

            objNewPrjTab.TabStateId = objSouPrjTab.TabStateId;
            //新数据表的数据库名,默认的数据库名使用目标工程相关的数据库名
            objNewPrjTab.DataBaseName = objSouPrjTab.DataBaseName;
            //			objNewPrjTab.TabName_Curr = objSouPrjTab.TabName_Curr;	//只读属性,不能修改
            objNewPrjTab.TabNameB = objSouPrjTab.TabNameB;
            objNewPrjTab.TabName = objSouPrjTab.TabName;
            objNewPrjTab.SqlDsTypeId = objSouPrjTab.SqlDsTypeId;
            objNewPrjTab.IsReleToSqlTab = objSouPrjTab.IsReleToSqlTab;
            objNewPrjTab.TabTypeId = "0001";
            objNewPrjTab.TabMainTypeId = objSouPrjTab.TabMainTypeId;

            objNewPrjTab.FuncModuleAgcId = strFuncModuleId_T;

            objNewPrjTab.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            objNewPrjTab.UpdUserId = strUserId;
            objNewPrjTab.ParentClass = objSouPrjTab.ParentClass;
            objNewPrjTab.Memo = objSouPrjTab.Memo;
            objNewPrjTab.IsUseCache = objSouPrjTab.IsUseCache;

            //    5.3 当新建<工程表>记录添加到数据库中；
            if (clsPrjTabBL.AddNewRecordBySql2(objNewPrjTab) == false)
            {
                return "";
            }
            else
            {
                //					strResult = "添加记录成功!";
            }

            //6、获取当前<工程表>记录的相关字段列表；
            objDT_SouTabFld = clsPrjTabFldBL.GetDataTable_PrjTabFld("TabId = '" + strSouTabId + "'");
            //7、对该表进行循环,把字段ID(源字段ID)依次进行处理,插入到目标工程中,

            foreach (DataRow objRow in objDT_SouTabFld.Rows)
            {
                strSouFldId = objRow["FldId"].ToString();
                //8、把源字段ID列表从源工程中复制到目标工程中,同时获取一个插入到目标工程中的字段ID
                strTarFldId = clsFieldTabBLEx.CopyField(objSouPrjTab.PrjId, strTarPrjId, strSouFldId, strUserId);
                //9、把获取的一个新字段ID列表添加到目标工程中的<工程表字段>表中。
                if (string.IsNullOrEmpty(strTarFldId) == true)
                {
                    continue;
                }
                clsPrjTabFldBLEx.CopyPrjTabFld(objSouPrjTab.PrjId, strTarPrjId, strSouTabId, strNewTabId, strSouFldId, strTarFldId);
            }
            return strNewTabId;
        }
        /// <summary>
        /// 设置修改日期到最新
        /// </summary>
        /// <param name="strTabId"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public new static bool SetUpdDate(string strTabId, string strUserId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            objPrjTabEN.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            objPrjTabEN.UpdUserId = strUserId;

            if (string.IsNullOrEmpty(objPrjTabEN.RelaTabId4View)) objPrjTabEN.RelaTabId4View = null;
            clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            return true;
        }

        public static bool SetUpdDate(clsPrjTabEN objPrjTabEN, string strUserId)
        {
            objPrjTabEN.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            objPrjTabEN.UpdUserId = strUserId;
            clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            return true;
        }

        public static bool DelRecordEx(string strTabId)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            clsPrjTabFldBLEx.DelRecordEx(strTabId);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'", conViewRegion.TabId, strTabId);
            List<string> arrRegionIdObjList = clsViewRegionBL.GetPrimaryKeyID_S(sbCondition.ToString());
            if (arrRegionIdObjList != null)
            {
                clsViewRegionBLEx.DeleteByRegionIdsEx(arrRegionIdObjList);
            }
            //删除PrjTab本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from ViewGroup where InRelaTabId = " + "'" + strTabId + "'";
            strSQL = strSQL + "Delete from ViewGroup where OutRelaTabId = " + "'" + strTabId + "'";
            strSQL = strSQL + "Delete from EditRegionFlds where DsTabId = '" + strTabId + "'";
            strSQL = strSQL + "Delete from ViewRelaTab where TabId = '" + strTabId + "'";
            strSQL = strSQL + "Delete from SqlViewFld where SqlViewId in (Select SqlViewId From SqlView where RelaTabId = '" + strTabId + "')";
            strSQL = strSQL + "Delete from SqlViewRelaTab where SqlViewId in (Select SqlViewId From SqlView where RelaTabId = '" + strTabId + "')";
            strSQL = strSQL + "Delete from SqlView where RelaTabId = '" + strTabId + "'";
            strSQL = strSQL + "Delete from PrjTabFld where TabId = '" + strTabId + "'";
            strSQL = strSQL + $"Delete from {conTabFeature._CurrTabName} where {conTabFeature.TabId} = '{strTabId}'";

            strSQL = strSQL + "Delete from PrjTab where TabId = " + "'" + strTabId + "'";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// 功能:把同一个工程的一个表复制到新表中,同时复制相关对象,以及该对象相关的字段。
        /// </summary>
        /// <param name = "strSouPrjId">源工程Id</param>
        /// <param name = "strSouTabId">源表Id</param>
        /// <param name = "strUpdUserId">修改用户Id</param>
        /// <returns>返回在目标工程中的新表ID</returns>
        public static string CopyPrjTabInSameProject(string strSouPrjId, string strSouCmPrjId, string strSouTabId, string strUpdUserId)
        {
            //操作步骤:
            //1、对源工程中的源表ID进行操作
            //2、根据<表ID>获取所有属性
            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //       如果存在相同的<表名>就放弃该表名,不需要复制。
            //4、复制源表的相关对象到新工程中。
            //5、把当前<工程表>复制 到新工程中。
            //    5.1 在目标工程中新建一个<工程表>记录
            //    5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //    5.3 当新建<工程表>记录添加到数据库中；
            //6、获取当前<工程表>记录的相关字段列表；
            //7、对该表进行循环,把字段ID(源字段ID)插入到一个ArrayList
            //8、把这组源字段ID列表从源工程中复制到目标工程中,同时获取一组插入到目标工程中的字段ID列表
            //9、把获取的一组新字段ID列表复制到<工程表字段>表中。
            //

            string strSouFldId;
            //, strTarFldId;	//源字段ID,目标字段ID
            //System.Data.DataTable objDT_SouTabFld;		//, objDT_Tab;
            ArrayList arrTabFld = new ArrayList();
            //			ArrayList arrTarFldId;
            clsPrjTabEN objSouPrjTab = null;
            clsPrjTabEN objNewPrjTab = null;
            string strNewTabId = "";
            //1、对源工程中的源对象ID进行操作
            //2、根据<表ID>获取所有属性
            objSouPrjTab = clsPrjTabBL.GetObjByTabId(strSouTabId);
            if (objSouPrjTab == null)
            {
                string strMsg = string.Format("表Id:{0}的表不存在！", strSouTabId);
                throw new Exception(strMsg);
            }
            string strNewTabName = objSouPrjTab.TabName + "_Copy";
            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //       如果存在相同的<表名>就放弃该表名,不需要复制。
            if (clsPrjTabBL.IsExistRecord("PrjId = '" + strSouPrjId + "' and TabName = '" + strNewTabName + "'") == true)
            {
                strNewTabId = clsPrjTabBLEx.GetTabId(strSouPrjId, strNewTabName);
                return strNewTabId;
            }
            //4、复制源表的相关对象到新工程中。
            //5、把当前<工程表>复制 到新工程中。
            //    5.1 在目标工程中新建一个<工程表>记录
            strNewTabId = clsGeneralTab.GetMaxStrId("PrjTab", "TabId", 8, strSouPrjId);
            objNewPrjTab = new clsPrjTabEN(strNewTabId);
            //    5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //			objNewPrjTab.UserId = strUserId;
            objNewPrjTab.PrjId = strSouPrjId;
            objNewPrjTab.TabCnName = objSouPrjTab.TabCnName + "_Copy";
            //			objNewPrjTab.TabKeyFldName = objSouPrjTab.TabKeyFldName;//只读属性,不能修改
            objNewPrjTab.TabName = strNewTabName;
            objNewPrjTab.TabStateId = objSouPrjTab.TabStateId;
            //新数据表的数据库名,默认的数据库名使用目标工程相关的数据库名
            objNewPrjTab.DataBaseName = objSouPrjTab.DataBaseName;
            objNewPrjTab.Owner = objSouPrjTab.Owner;
            //			objNewPrjTab.TabName_Curr = objSouPrjTab.TabName_Curr;	//只读属性,不能修改
            objNewPrjTab.TabNameB = objSouPrjTab.TabNameB;
            objNewPrjTab.SqlDsTypeId = objSouPrjTab.SqlDsTypeId;
            objNewPrjTab.FuncModuleAgcId = objSouPrjTab.FuncModuleAgcId;
            objNewPrjTab.TabTypeId = objSouPrjTab.TabTypeId;
            objNewPrjTab.TabMainTypeId = objSouPrjTab.TabMainTypeId;

            objNewPrjTab.IsReleToSqlTab = objSouPrjTab.IsReleToSqlTab;
            objNewPrjTab.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            objNewPrjTab.UpdUserId = strUpdUserId;

            objNewPrjTab.ParentClass = objSouPrjTab.ParentClass;
            objNewPrjTab.Memo = objSouPrjTab.Memo;
            objNewPrjTab.IsUseCache = objSouPrjTab.IsUseCache;

            //    5.3 当新建<工程表>记录添加到数据库中；
            if (clsPrjTabBL.AddNewRecordBySql2(objNewPrjTab) == false)
            {
                return "";
            }
            else
            {

                var objCMProjectPrjTab = clsCmProjectPrjTabBLEx.GetObjByTabIdCache(strSouCmPrjId, strSouTabId);
                if (objCMProjectPrjTab != null)
                {
                    objCMProjectPrjTab.TabId = objNewPrjTab.TabId;
                    objCMProjectPrjTab.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
                    objCMProjectPrjTab.UpdUser = strUpdUserId;
                    objCMProjectPrjTab.AddNewRecord();
                }
                //					strResult = "添加记录成功!";
            }

            //6、获取当前<工程表>记录的相关字段列表；
            List<clsPrjTabFldEN> arrSouTabFldList = clsPrjTabFldBL.GetObjLst("TabId = '" + strSouTabId + "'");
            //7、对该表进行循环,把字段ID(源字段ID)依次进行处理,插入到目标工程中,
            foreach (clsPrjTabFldEN objSouPrjTabFld in arrSouTabFldList)
            {
                strSouFldId = objSouPrjTabFld.FldId;
                //9、把获取的一个新字段ID列表添加到目标工程中的<工程表字段>表中。             
                clsPrjTabFldEN objTarPrjTabFld;
                //1、获取源<工程表字段>记录。根据源<表ID>和源<字段ID>,并获取该记录的属性。
                //2、新建一个目标<工程表字段>对象;
                objTarPrjTabFld = new clsPrjTabFldEN();
                //3、设置目标<工程表字段>对象的相关属性；
                objTarPrjTabFld.PrjId = strSouPrjId;
                objTarPrjTabFld.TabId = strNewTabId;
                objTarPrjTabFld.FldId = strSouFldId;
                objTarPrjTabFld.IsParentObj = objSouPrjTabFld.IsParentObj;
                objTarPrjTabFld.IsTabForeignKey = objSouPrjTabFld.IsTabForeignKey;
                objTarPrjTabFld.IsTabNullable = objSouPrjTabFld.IsTabNullable;
                objTarPrjTabFld.IsGeneProp = objSouPrjTabFld.IsGeneProp;

                objTarPrjTabFld.IsTabUnique = objSouPrjTabFld.IsTabUnique;

                objTarPrjTabFld.PrimaryTypeId = objSouPrjTabFld.PrimaryTypeId;
                objTarPrjTabFld.MemoInTab = objSouPrjTabFld.MemoInTab;
                objTarPrjTabFld.SequenceNumber = objSouPrjTabFld.SequenceNumber;
                objTarPrjTabFld.FldOpTypeId = objSouPrjTabFld.FldOpTypeId;

                if (string.IsNullOrEmpty(objSouPrjTabFld.FieldTypeId) == true)
                {
                    objTarPrjTabFld.FieldTypeId = "01";
                }
                else
                {
                    objTarPrjTabFld.FieldTypeId = objSouPrjTabFld.FieldTypeId;
                }
                objTarPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objTarPrjTabFld.UpdUser = strUpdUserId;

                //			objTarPrjTabFld.TabKeyFldName = objSouPrjTabFld.TabKeyFldName;

                //4、把目标<工程表字段>对象插入到数据库表中；
                if (clsPrjTabFldBLEx.IsExistSameFldId(strNewTabId, strSouFldId) == false)   //判断是否有相同的关键字
                {
                    clsPrjTabFldBLEx.AddNewRecordBySql2(objTarPrjTabFld);
                }
            }
            return strNewTabId;
        }
        /// <summary>
        /// 修改表--添加字段
        /// </summary>
        /// <param name = "arrTabFieldObjList">字段对象列表</param>
        /// <returns>是否成功</returns>
        public static bool AlterTab4AddField(List<string> arrTabFieldObjList, string strPrjDataBaseId)
        {
            foreach (string strMid in arrTabFieldObjList)
            {
                long lngMid = long.Parse(strMid);
                AlterTab4AddField(lngMid, strPrjDataBaseId);
            }
            return true;
        }
        /// <summary>
        /// 修改表--添加字段(ORACLE)
        /// </summary>
        /// <param name = "arrTabFieldObjList">字段对象列表</param>
        /// <returns>是否成功</returns>
        public static bool AlterTab4AddFieldForOra(List<string> arrTabFieldKeyList, string strPrjDataBaseId)
        {
            foreach (string strMid in arrTabFieldKeyList)
            {
                long lngMid = long.Parse(strMid);
                AlterTab4AddFieldForOra(lngMid, strPrjDataBaseId);
            }
            return true;
        }
        /// <summary>
        /// 修改表--添加字段
        /// </summary>
        /// <param name = "lngTabFld">表字段的关键字</param>
        /// <returns>是否成功</returns>
        public static bool AlterTab4AddField(long lngmId, string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            clsvPrjTabFldEN objvPrjTabFld = clsvPrjTabFldBL.GetObjBymId(lngmId);

            StringBuilder sbMessage = new StringBuilder();
            clsvPrjTabEN objvPrjTab = clsvPrjTabBL.GetObjByTabId(objvPrjTabFld.TabId);
            clsProjectsEN objProjectsEx = clsProjectsBL.GetObjByPrjIdCache(objvPrjTabFld.PrjId);

            string strKeyFldId = objvPrjTab.KeyFldId();

            StringBuilder strAlterTabCode = new StringBuilder();

            string strDatabaseOwner;
            string strFieldType;
            //			string strFieldType0;
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度
            ArrayList arrFieldCodes = new ArrayList();

            //				strBuilder.Append("\r\n" +objvPrjTabFld.DefPrivateProperty());
            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] add \r\r\n",
               strDatabaseOwner,
               objvPrjTab.TabName
              );



            ///字段名
            strAlterTabCode.AppendFormat("\t{0}", objvPrjTabFld.FldName);

            //计算字段类型
            // 计算字段类型
            strFieldType = objvPrjTabFld.DataTypeName;
            strAlterTabCode.AppendFormat(" {0}", objvPrjTabFld.DataTypeName);

            //计算字段长度
            strFieldLength0 = objvPrjTabFld.FldLength.ToString();
            string strFldPrecision = objvPrjTabFld.FldPrecision.ToString();
            if (strFieldLength0 == string.Empty)
                strFieldLength = string.Empty;
            else if (strFieldType == "decimal" || strFieldType == "numeric")
            {
                strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
            }
            else
                strFieldLength = "(" + strFieldLength0 + ")";
            strFieldType = objvPrjTabFld.DataTypeName;
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(strFieldType) == false)
            {
                strFieldLength = string.Empty;
            }
            if (string.IsNullOrEmpty(strFieldLength) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strFieldLength);

            }
            //计算是否可空

            if (objvPrjTabFld.IsTabNullable == true)
            {
                strAlterTabCode.Append(" Null");
            }
            else
            {
                strAlterTabCode.Append(" not Null");
                //组合缺省值串
                if (string.IsNullOrEmpty(objvPrjTabFld.DefaultValue) == false)
                {
                    string strDefaultValueStr = CombineDefaultValueString(strFieldType, objvPrjTabFld.DefaultValue);
                    strAlterTabCode.AppendFormat(" {0}", strDefaultValueStr);
                }
            }
            //计算主键
            if (objvPrjTabFld.PrimaryTypeId == "02") //标识型主键identity
            {
                strPrimaryKey = " primary key identity";
            }
            else if (objvPrjTabFld.FieldTypeId == enumFieldType.KeyField_02)
            {
                strPrimaryKey = " primary key";
            }
            else
            {
                strPrimaryKey = "";
            }
            if (string.IsNullOrEmpty(strPrimaryKey) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strPrimaryKey);
            }
            //strAlterTabCode.Append("ON [PRIMARY] ");
            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());
        }

        public static bool AlterTab4AddField(clsPrjTabFldEN objPrjTabFld, string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            //clsvPrjTabFldEN objPrjTabFld = clsvPrjTabFldBL.GetObjBymId(lngTabFld);

            StringBuilder sbMessage = new StringBuilder();
            clsvPrjTabEN objvPrjTab = clsvPrjTabBL.GetObjByTabId(objPrjTabFld.TabId);
            clsProjectsEN objProjectsEx = clsProjectsBL.GetObjByPrjIdCache(objPrjTabFld.PrjId);

            string strKeyFldId = objvPrjTab.KeyFldId();

            StringBuilder strAlterTabCode = new StringBuilder();

            string strDatabaseOwner;
            string strFieldType;
            //			string strFieldType0;
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度
            ArrayList arrFieldCodes = new ArrayList();

            //				strBuilder.Append("\r\n" +objPrjTabFld.DefPrivateProperty());
            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] add \r\r\n",
               strDatabaseOwner,
               objvPrjTab.TabName
              );

            clsvFieldTabEN objvFieldTab = clsvFieldTabBLEx.GetObjByFldId(objPrjTabFld.FldId);

            //字段名
            strAlterTabCode.AppendFormat("\t{0}", objvFieldTab.FldName);

            //计算字段类型
            /// 计算字段类型
            strFieldType = objvFieldTab.DataTypeName;
            strAlterTabCode.AppendFormat(" {0}", objvFieldTab.DataTypeName);

            //计算字段长度
            strFieldLength0 = objvFieldTab.FldLength.ToString();
            string strFldPrecision = objvFieldTab.FldPrecision.ToString();
            if (strFieldLength0 == string.Empty)
                strFieldLength = string.Empty;
            else if (strFieldType == "decimal" || strFieldType == "numeric")
            {
                strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
            }
            else
                strFieldLength = "(" + strFieldLength0 + ")";
            strFieldType = objvFieldTab.DataTypeName;
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(strFieldType) == false)
            {
                strFieldLength = string.Empty;
            }
            if (string.IsNullOrEmpty(strFieldLength) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strFieldLength);

            }
            //计算是否可空

            if (objPrjTabFld.IsTabNullable == true)
            {
                strAlterTabCode.Append(" Null");
            }
            else
            {
                strAlterTabCode.Append(" not Null");
                //组合缺省值串
                string strDefaultValueStr = CombineDefaultValueString(strFieldType, objvFieldTab.DefaultValue);
                strAlterTabCode.AppendFormat(" {0}", strDefaultValueStr);
            }
            //计算主键
            if (objPrjTabFld.PrimaryTypeId == "02") //标识型主键identity
            {
                strPrimaryKey = " primary key identity";
            }
            else if (objPrjTabFld.FieldTypeId == enumFieldType.KeyField_02)
            {
                strPrimaryKey = " primary key";
            }
            else
            {
                strPrimaryKey = "";
            }
            if (string.IsNullOrEmpty(strPrimaryKey) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strPrimaryKey);
            }
            //strAlterTabCode.Append("ON [PRIMARY] ");
            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());
        }

        /// <summary>
        /// 修改表--添加字段(ORACLE)
        /// </summary>
        /// <param name = "lngTabFld">表字段关键字</param>
        /// <returns>是否成功</returns>
        public static bool AlterTab4AddFieldForOra(long lngTabFld, string strPrjDataBaseId)
        {
            clsvPrjTabFldEN objvPrjTabFld = clsvPrjTabFldBL.GetObjBymId(lngTabFld);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            StringBuilder sbMessage = new StringBuilder();
            clsvPrjTabEN objvPrjTab = clsvPrjTabBL.GetObjByTabId(objvPrjTabFld.TabId);
            clsProjectsEN objProjectsEx = clsProjectsBL.GetObjByPrjIdCache(objvPrjTabFld.PrjId);

            string strKeyFldId = objvPrjTab.KeyFldId();

            StringBuilder strAlterTabCode = new StringBuilder();

            string strDatabaseOwner;
            string strFieldType;
            //			string strFieldType0;
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度
            ArrayList arrFieldCodes = new ArrayList();

            //				strBuilder.Append("\r\n" +objvPrjTabFld.DefPrivateProperty());
            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table {1} add ",
               strDatabaseOwner,
               objvPrjTab.TabName
              );



            //字段名
            strAlterTabCode.AppendFormat("{0}", objvPrjTabFld.FldName);

            //计算字段类型
            strAlterTabCode.AppendFormat(" {0}", objvPrjTabFld.OraDbType);

            //计算字段长度
            strFieldLength0 = objvPrjTabFld.FldLength.ToString();
            if (strFieldLength0 == string.Empty)
                strFieldLength = string.Empty;
            else
                strFieldLength = "(" + strFieldLength0 + ")";
            strFieldType = objvPrjTabFld.OraDbType;
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(strFieldType) == false)
            {
                strFieldLength = string.Empty;
            }
            if (string.IsNullOrEmpty(strFieldLength) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strFieldLength);

            }
            //计算是否可空

            if (objvPrjTabFld.IsTabNullable == true)
            {
                strAlterTabCode.Append(" Null");
            }
            else
            {
                strAlterTabCode.Append(" not Null");
                //组合缺省值串
                string strDefaultValueStr = CombineDefaultValueString(strFieldType, objvPrjTabFld.DefaultValue);
                strAlterTabCode.AppendFormat(" {0}", strDefaultValueStr);
            }
            //计算主键
            if (objvPrjTabFld.PrimaryTypeId == "02") //标识型主键identity
            {
                strPrimaryKey = " primary key identity";
            }
            else if (objvPrjTabFld.FieldTypeId == enumFieldType.KeyField_02)
            {
                strPrimaryKey = " primary key";
            }
            else
            {
                strPrimaryKey = "";
            }
            if (string.IsNullOrEmpty(strPrimaryKey) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strPrimaryKey);
            }
            //strAlterTabCode.Append("ON [PRIMARY] ");

            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            com.taishsoft.commdbfororacle.clsSpecSQLforOra objSQL = new com.taishsoft.commdbfororacle.clsSpecSQLforOra(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());
        }

        public static bool AlterTab4UpdateField(List<string> arrTabFieldObjList, string strPrjDataBaseId)
        {
            foreach (string strMid in arrTabFieldObjList)
            {
                long lngMid = long.Parse(strMid);
                AlterTab4UpdateField(lngMid, strPrjDataBaseId);
            }
            return true;
        }

        public static bool AlterTab4UpdateFieldForOra(List<string> arrTabFieldObjList, string strPrjDataBaseId)
        {
            foreach (string strMid in arrTabFieldObjList)
            {
                long lngMid = long.Parse(strMid);
                AlterTab4UpdateFieldForOra(lngMid, strPrjDataBaseId);
            }
            return true;
        }
        /// <summary>
        /// 根据代码系统的字段信息修改Sql字段信息
        /// </summary>
        /// <param name="lngmId">表字段Id</param>
        /// <param name="strPrjDataBaseId">工程数据库Id</param>
        /// <returns></returns>
        public static bool AlterTab4UpdateField(long lngmId, string strPrjDataBaseId)
        {
            clsvPrjTabFldEN objvPrjTabFld = clsvPrjTabFldBL.GetObjBymId(lngmId);

            StringBuilder sbMessage = new StringBuilder();
            clsvPrjTabEN objvPrjTab = clsvPrjTabBL.GetObjByTabId(objvPrjTabFld.TabId);
            clsProjectsEN objProjectsEx = clsProjectsBL.GetObjByPrjIdCache(objvPrjTabFld.PrjId);

            string strKeyFldId = objvPrjTab.KeyFldId();

            StringBuilder strAlterTabCode = new StringBuilder();

            string strDatabaseOwner;
            string strFieldType;
            //			string strFieldType0;
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度
            ArrayList arrFieldCodes = new ArrayList();

            //				strBuilder.Append("\r\n" +objvPrjTabFld.DefPrivateProperty());
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] ALTER COLUMN \r\r\n",
               strDatabaseOwner,
               objvPrjTab.TabName
              );



            //字段名
            strAlterTabCode.AppendFormat("\t{0}", objvPrjTabFld.FldName);

            //计算字段类型
            strAlterTabCode.AppendFormat(" {0}", objvPrjTabFld.DataTypeName);
            strFieldType = objvPrjTabFld.DataTypeName;

            //计算字段长度
            strFieldLength0 = objvPrjTabFld.FldLength.ToString();
            string strFldPrecision = objvPrjTabFld.FldPrecision.ToString();
            if (strFieldLength0 == string.Empty)
            {
                strFieldLength = string.Empty;
            }
            else if (strFieldType == "decimal" || strFieldType == "numeric")
            {
                strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
            }
            else
            {
                strFieldLength = "(" + strFieldLength0 + ")";
            }


            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(strFieldType) == false)
            {
                strFieldLength = string.Empty;
            }
            if (string.IsNullOrEmpty(strFieldLength) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strFieldLength);

            }
            //计算是否可空

            if (objvPrjTabFld.IsTabNullable == true)
            {
                strAlterTabCode.Append(" Null");
            }
            else
            {
                strAlterTabCode.Append(" not Null");
                //组合缺省值串
                //string strDefaultValueStr = CombineDefaultValueString(strFieldType, objvPrjTabFld.DefaultValue);
                //strAlterTabCode.AppendFormat(" {0}", strDefaultValueStr);
            }
            //计算主键
            if (objvPrjTabFld.PrimaryTypeId == "02") //标识型主键identity
            {
                strPrimaryKey = " primary key identity";
            }
            else if (objvPrjTabFld.FieldTypeId == enumFieldType.KeyField_02)
            {
                strPrimaryKey = " primary key";
            }
            else
            {
                strPrimaryKey = "";
            }
            if (string.IsNullOrEmpty(strPrimaryKey) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strPrimaryKey);
            }
            //strAlterTabCode.Append("ON [PRIMARY] ");

            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());
        }

        public static bool AlterTab4UpdateFieldForOra(long lngTabFld, string strPrjDataBaseId)
        {
            clsvPrjTabFldEN objvPrjTabFld = clsvPrjTabFldBL.GetObjBymId(lngTabFld);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            StringBuilder sbMessage = new StringBuilder();
            clsvPrjTabEN objvPrjTab = clsvPrjTabBL.GetObjByTabId(objvPrjTabFld.TabId);
            clsProjectsEN objProjectsEx = clsProjectsBL.GetObjByPrjIdCache(objvPrjTabFld.PrjId);

            string strKeyFldId = objvPrjTab.KeyFldId();

            StringBuilder strAlterTabCode = new StringBuilder();

            string strDatabaseOwner;
            string strFieldType;
            //			string strFieldType0;
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度
            ArrayList arrFieldCodes = new ArrayList();

            //				strBuilder.Append("\r\n" +objvPrjTabFld.DefPrivateProperty());
            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table {1} modify( ",
               strDatabaseOwner,
               objvPrjTab.TabName
              );



            //字段名
            strAlterTabCode.AppendFormat("{0}", objvPrjTabFld.FldName);

            //计算字段类型
            strAlterTabCode.AppendFormat(" {0}", objvPrjTabFld.OraDbType);

            //计算字段长度
            strFieldLength0 = objvPrjTabFld.FldLength.ToString();
            if (strFieldLength0 == string.Empty)
                strFieldLength = string.Empty;
            else
                strFieldLength = "(" + strFieldLength0 + ")";
            strFieldType = objvPrjTabFld.DataTypeName;
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(strFieldType) == false)
            {
                strFieldLength = string.Empty;
            }
            if (string.IsNullOrEmpty(strFieldLength) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strFieldLength);

            }
            //计算是否可空

            //if (objvPrjTabFld.IsTabNullable  ==  true)
            //{
            //    strAlterTabCode.Append(" Null");
            //}
            //else
            //{
            //    strAlterTabCode.Append(" not Null");
            //    //组合缺省值串
            //    //string strDefaultValueStr = CombineDefaultValueString(strFieldType, objvPrjTabFld.DefaultValue);
            //    //strAlterTabCode.AppendFormat(" {0}", strDefaultValueStr);
            //}
            //计算主键
            if (objvPrjTabFld.PrimaryTypeId == "02") //标识型主键identity
            {
                strPrimaryKey = " primary key identity";
            }
            else if (objvPrjTabFld.FieldTypeId == enumFieldType.KeyField_02)
            {
                strPrimaryKey = " primary key";
            }
            else
            {
                strPrimaryKey = "";
            }
            if (string.IsNullOrEmpty(strPrimaryKey) == false)
            {
                strAlterTabCode.AppendFormat(" {0}", strPrimaryKey);
            }
            strAlterTabCode.Append(") ");

            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            com.taishsoft.commdbfororacle.clsSpecSQLforOra objSQL = new com.taishsoft.commdbfororacle.clsSpecSQLforOra(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());
        }

        /// <summary>
        /// 功能:删除Sql表中某些字段
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "arrTabFieldObjList">待删除的字段列表</param>
        /// <returns>是否成功?</returns>
        public static bool AlterTab4DropColumn(string strTabId, ArrayList arrTabFieldObjList, string strPrjDataBaseId)
        {
            clsvPrjTabEN objvPrjTab = clsvPrjTabBL.GetObjByTabId(strTabId);
            clsProjectsEN objProjectsEx = clsProjectsBL.GetObjByPrjIdCache(objvPrjTab.PrjId);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            StringBuilder strAlterTabCode = new StringBuilder();

            string strDatabaseOwner;

            //				strBuilder.Append("\r\n" +objvPrjTabFld.DefPrivateProperty());
            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] Drop COLUMN \r\r\n",
               strDatabaseOwner,
               objvPrjTab.TabName
              );


            bool bolIsFirstColumn = true;
            foreach (clsColumns objColumn in arrTabFieldObjList)
            {
                if (true == bolIsFirstColumn)
                {
                    //字段名
                    strAlterTabCode.AppendFormat("{0}", objColumn.Column_Name);
                    bolIsFirstColumn = false;
                }
                else
                {
                    //字段名
                    strAlterTabCode.AppendFormat("\t,{0}", objColumn.Column_Name);
                }
            }

            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());

        }

        /// <summary>
        /// 功能:删除Sql表中某些字段
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "strColumn_Name">字段列名</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>是否成功?</returns>
        public static bool AlterTab4DropColumn(string strTabId, string strColumn_Name, string strPrjDataBaseId)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId(strTabId);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            StringBuilder strAlterTabCode = new StringBuilder();

            List<string> arrConstraintName = clsTablesBLEx.GetConstraintNameLst4FldName(objPrjTab.TabName, strColumn_Name, strPrjDataBaseId);
            foreach (string strConstraintName in arrConstraintName)
            {
                AlterTab4DropConstraint(strTabId, strConstraintName, strPrjDataBaseId);
            }
            string strDatabaseOwner;

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] Drop COLUMN \r\r\n",
               strDatabaseOwner,
               objPrjTab.TabName
              );

            strAlterTabCode.AppendFormat("{0}", strColumn_Name);

            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());

        }

        /// <summary>
        /// 功能:删除Sql表中某些字段
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "strColumn_Name">字段列名</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>是否成功?</returns>
        public static bool AlterTab4DropConstraint(string strTabId, string strConstraint_Name, string strPrjDataBaseId)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId(strTabId);
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            StringBuilder strAlterTabCode = new StringBuilder();

            string strDatabaseOwner;

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;

            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strAlterTabCode.AppendFormat("Alter table [{0}].[{1}] Drop Constraint {2};\r\r\n",
               strDatabaseOwner,
               objPrjTab.TabName,
               strConstraint_Name
              );

            string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectionString);
            return objSQL.ExecSql(strAlterTabCode.ToString());

        }



        /// <summary>
        /// 组装SQL字段中的缺省值表达式
        /// </summary>
        /// <param name = "strFieldType">字段类型</param>
        /// <param name = "strDefaultValue">缺省值</param>
        /// <returns>缺省值表达式</returns>
        private static string CombineDefaultValueString(string strFieldType, string strDefaultValue)
        {
            string strDefaultValueStr = "";
            if (string.IsNullOrEmpty(strDefaultValue) == true) //系统设置缺省值为空
            {
                if (strFieldType == "varchar" || strFieldType == "char")
                {
                    strDefaultValueStr = "default ''";
                }
                else if (strFieldType == "bigint" || strFieldType == "int")
                {
                    strDefaultValueStr = "default 0";
                }
                else if (strFieldType == "float" || strFieldType == "bit")
                {
                    strDefaultValueStr = "default 0.0";
                }
                else if (strFieldType == "double")
                {
                    strDefaultValueStr = "default 0.0";

                }
                else if (strFieldType == "text")
                {
                    strDefaultValueStr = "default ''";
                }
                else if (strFieldType == "timestamp")
                {
                }
                else if (strFieldType == "smallint")
                {
                    strDefaultValueStr = "default 0";
                }
                else if (strFieldType == "tinyint")
                {
                    strDefaultValueStr = "default 0";
                }
                else if (strFieldType == "image")
                {
                }
                else if (strFieldType == "bigint identity")
                {
                    strDefaultValueStr = "";
                }
            }
            else   //系统设置缺省值不为空
            {
                if (strFieldType == "varchar" || strFieldType == "char")
                {
                    if (strDefaultValue.ToLower() == "space")
                    {
                        strDefaultValueStr = "default ''";
                    }
                    else
                    {
                        strDefaultValueStr = "default " + strDefaultValue;
                    }
                }
                else if (strFieldType == "bigint" || strFieldType == "int")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "float" || strFieldType == "bit")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "double")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "text")
                {
                    if (strDefaultValue.ToLower() == "space")
                    {
                        strDefaultValueStr = "default ''";
                    }
                    else
                    {
                        strDefaultValueStr = "default " + strDefaultValue;
                    }
                }
                else if (strFieldType == "timestamp")
                {
                }
                else if (strFieldType == "smallint")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "tinyint")
                {
                    strDefaultValueStr = "default " + strDefaultValue;
                }
                else if (strFieldType == "image")
                {
                }
                else if (strFieldType == "bigint identity")
                {
                    strDefaultValueStr = string.Empty;
                }
            }
            return strDefaultValueStr;
        }
        /// <summary>
        /// 生成可以建表的SQL语句
        /// </summary>
        /// <param name = "strTabId">提供的TabId</param>
        /// <returns>可以建表的SQL语句</returns>
        public static string GenSQLCode4CreateTab(string strTabId, string strPrjDataBaseId)
        {
            StringBuilder sbMessage = new StringBuilder();
            clsvPrjTabEN objvPrjTab = clsvPrjTabBL.GetObjByTabId(strTabId);
            clsPrjTabENEx objPrjTabENEx = new clsPrjTabENEx(strTabId);
            objPrjTabENEx.GetObjAllInfoEx();
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            List<clsvPrjTabFldEN> arrTabFldObjList = clsvPrjTabFldBL.GetObjLst("TabId = '" + strTabId + "'");

            if (arrTabFldObjList.Count == 0)
            {
                sbMessage.AppendFormat("当前表:{0}的字段数为0,无法生成通用逻辑层!", objvPrjTab.TabName);
                throw new Exception(sbMessage.ToString());
            }
            string strKeyFldId = objvPrjTab.KeyFldId();


            StringBuilder strCreateTabCode = new StringBuilder();

            string strDatabaseOwner;
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度

            ArrayList arrFieldCodes = new ArrayList();

            //定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrPrjTabFldENExObjLst)
            {
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

                //计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                //计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                //计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                //计算字段注释(即字段中文名称)
                strRemark0 = objField.ObjFieldTabENEx.Caption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/*" + strRemark0 + "*/";

                //计算是否可空

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                //计算主键

                if (objField.PrimaryTypeId == "02") //标识型主键identity
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objvPrjTab.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public static List<string> GetKeyValuesByTabId(string strTabId, string strCmPrjId, string strPrjDataBaseId)
        {

            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId(strTabId);
            List<clsPrjTabFldEN> arrPrjTabFld_Key = clsPrjTabFldBLEx.GetObjLstByTabIdAndFieldTypeIdCache(strTabId, enumFieldType.KeyField_02, objPrjTab.PrjId);
            List<clsPrjTabFldEN> arrPrjTabFld_UpdDate = clsPrjTabFldBLEx.GetObjLstByTabIdAndFieldTypeIdCache(strTabId, enumFieldType.Log_UpdDate_13, objPrjTab.PrjId);

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            List<clsvPrjTabFldEN> arrTabFldObjList = clsvPrjTabFldBL.GetObjLst("TabId = '" + strTabId + "'");

            if (arrPrjTabFld_Key.Count == 0)
            {
                string strMsg = string.Format("当前表:{0}的关键字段数为0,无法生成通用逻辑层!", objPrjTab.TabName);
                throw new Exception(strMsg);
            }
            List<string> arrKeyFldName = new List<string>();
            foreach (var objPrjTabFld in arrPrjTabFld_Key)
            {
                string strFldName = objPrjTabFld.ObjFieldTab().FldName;
                if (string.IsNullOrEmpty(strFldName)) continue;
                arrKeyFldName.Add(strFldName);
            }
            string strSortExpress = "";
            if (arrPrjTabFld_UpdDate.Count > 0)
            {
                strSortExpress = arrPrjTabFld_UpdDate[0].ObjFieldTab().FldName;
            }
            string strWhere = " 1=1 ";
            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
            {
                var objFieldTab_Ts = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);
                if (objFieldTab_Ts != null)
                {

                }
            }
            List<string> arrValue = clsTablesBLEx.GetKeyValuesByTabName(objPrjTab.TabName, arrKeyFldName, strWhere, strSortExpress, strPrjDataBaseId);

            return arrValue;

        }


        /// <summary>
        /// 设置视图的关键字段,根据视图的相关主表
        /// </summary>
        /// <param name = "strTabId">视图表的Id</param>
        /// <returns>是否成功？</returns>
        public static bool SetKeyFld4ViewByRelaTabId(string strViewTabId)
        {
            string strTabId = "";
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strViewTabId);
            strTabId = objPrjTabEN.RelaTabId4View;
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strTabId = clsPrjTabBLEx.GetRelaTabIdByViewTabId(strViewTabId);
            }
            if (string.IsNullOrEmpty(strTabId) == true) return true;
            List<clsPrjTabFldEN> arrKeyFldLst = clsPrjTabFldBLEx.GetPrimaryKeyObjLstByTabId(strTabId);
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrKeyFldLst)
            {
                objPrjTabFldEN.TabId = strViewTabId;
                string strCondition = string.Format("TabId = '{0}' And FldId = '{1}'", strViewTabId, objPrjTabFldEN.FldId);
                objPrjTabFldEN.UpdateWithCondition(strCondition);
            }
            return true;
        }

        /// <summary>
        /// 设置工程表的关键字段和主键信息
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strUpdUser">当前用户Id</param>
        /// <returns>是否成功？</returns>
        public static bool SetKeyFld4PrjTabByTabId(string strTabId, string strUpdUser)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return true;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);


            List<clsPrjTabFldEN> arrKeyFldLst = clsPrjTabFldBLEx.GetPrimaryKeyObjLstByTabId(strTabId);
            if (arrKeyFldLst.Count == 0) return true;
            string strKeyFldId = "";
            string strKeyFldName = "";
            string strPrimaryTypeId = "";
            //foreach (clsPrjTabFldEN objPrjTabFldEN in arrKeyFldLst)
            //{
            //    strKeyFldId += objPrjTabFldEN.FldId + ",";
            //    clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
            //    strKeyFldName += objFieldTab.FldName + ",";
            //    strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId;
            //}
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrKeyFldLst)
            {
                strKeyFldId += objPrjTabFldEN.FldId;
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                strKeyFldName += objFieldTab.FldName;
                strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId;
                break;
            }
            //strKeyFldId = strKeyFldId.Remove(strKeyFldId.Length - 1);
            //strKeyFldName = strKeyFldName.Remove(strKeyFldName.Length - 1);
            //objPrjTabEN.KeyFldId = strKeyFldId;
            //objPrjTabEN.KeyFldName = strKeyFldName;
            //objPrjTabEN.PrimaryTypeId = strPrimaryTypeId;
            //objPrjTabEN.PrimaryTypeName = clsPrimaryTypeBL.GetPrimaryTypeNameByPrimaryTypeIdCache(strPrimaryTypeId);
            objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabEN.UpdUserId = strUpdUser;
            if (string.IsNullOrEmpty(objPrjTabEN.RelaTabId4View) == true) objPrjTabEN.RelaTabId4View = null;
            return clsPrjTabBL.UpdateBySql2(objPrjTabEN);
        }

        /// <summary>
        /// 设置工程表使用Cache
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strUpdUser">当前用户Id</param>
        /// <returns>是否成功？</returns>
        public static bool SetIsUseCache(string strTabId, string strUpdUser)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return true;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            if (objPrjTabEN.IsUseCache == true) return false;
            objPrjTabEN.IsUseCache = true;
            objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabEN.UpdUserId = strUpdUser;
            return clsPrjTabBL.UpdateBySql2(objPrjTabEN);

        }

        public static bool SetIsShare(string strTabId, bool bolIsShare, string strUpdUser)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return true;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);

            objPrjTabEN.IsShare = bolIsShare;
            objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabEN.UpdUserId = strUpdUser;
            var arrViewInfo = clsViewInfoBL.GetObjLst($"{conViewInfo.MainTabId}='{strTabId}'");
            foreach (var objInFor in arrViewInfo)
            {
                objInFor.IsShare = bolIsShare;
                objInFor.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objInFor.UpdUserId = strUpdUser;
                clsViewInfoBL.UpdateBySql2(objInFor);
            }

            return clsPrjTabBL.UpdateBySql2(objPrjTabEN);

        }
        /// <summary>
        /// 设置工程表不使用Cache
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strUpdUser">当前用户Id</param>
        /// <returns>是否成功？</returns>
        public static bool SetIsNotUseCache(string strTabId, string strUpdUser)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return true;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            if (objPrjTabEN.IsUseCache == false) return false;

            objPrjTabEN.IsUseCache = false;
            objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabEN.UpdUserId = strUpdUser;
            return clsPrjTabBL.UpdateBySql2(objPrjTabEN);

        }

        /// <summary>
        /// 设置视图的所有字段的序号,根据视图的相关主表
        /// </summary>
        /// <param name = "strTabId">视图表的Id</param>
        /// <returns>是否成功？</returns>
        public static bool SetFldOrderNum4ViewByRelaTabId(string strViewTabId)
        {
            string strTabId = "";
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strViewTabId);
            strTabId = objPrjTabEN.RelaTabId4View;

            if (string.IsNullOrEmpty(strTabId) == true)
            {
                strTabId = clsPrjTabBLEx.GetRelaTabIdByViewTabId(strViewTabId);
            }
            if (strTabId == "0" || string.IsNullOrEmpty(strTabId) == true)
            {
                string strMsg = string.Format("视图表:{0}没有相关主表,请检查!", objPrjTabEN.TabName);
                throw new Exception(strMsg);
            }
            if (string.IsNullOrEmpty(strTabId) == true) return true;
            string strCondition4Tab = string.Format("TabId = '{0}' Order By SequenceNumber", strTabId);
            string strCondition4View = string.Format("TabId = '{0}' Order By SequenceNumber", strViewTabId);

            List<clsvPrjTabFldEN> arrvPrjTabFldObjList4Tab = clsvPrjTabFldBL.GetObjLst(strCondition4Tab);
            List<clsPrjTabFldEN> arrPrjTabFldObjList4View = clsPrjTabFldBL.GetObjLst(strCondition4View);

            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList4View)
            {
                clsvPrjTabFldEN objvPrjTabFldEN = clsPrjTabFldBLEx.GetvPrjTabFldENByFldId(arrvPrjTabFldObjList4Tab, objPrjTabFldEN.FldId);
                if (objvPrjTabFldEN != null)
                {
                    objPrjTabFldEN.SequenceNumber = objvPrjTabFldEN.SequenceNumber * 1000;
                }
                else
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("视图字段不能在表字段列表中找到的字段有:");
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(objPrjTabFldEN.FldId);
                    sbMsg.AppendFormat("{0}({1},{2}),", objFieldTabEN.FldName, objFieldTabEN.Caption, objFieldTabEN.FldId);
                    //clsLog_S.WriteDebugLog_S(sbMsg.ToString());
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(sbMsg.ToString());
                }

            }
            string strSqlViewId = clsSqlViewBL.GetFirstID_S("RelaTabId = '" + strViewTabId + "'");
            bool bolIsUseFieldAliases = false;
            if (string.IsNullOrEmpty(strSqlViewId) == false)
            {
                foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList4View)
                {
                    bolIsUseFieldAliases = false;
                    clsFieldTabEN objFieldTabEN = null;
                    if (objPrjTabFldEN.SequenceNumber >= 1000) continue;
                    try
                    {
                        string strCondition = string.Format("FldId = '{0}' And SqlViewId = '{1}'", objPrjTabFldEN.FldId, strSqlViewId);
                        clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBL.GetFirstObj_S(strCondition);
                        if (objvSqlViewFldEN == null)
                        {
                            objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                            if (objFieldTabEN == null)
                            {
                                continue;
                            }
                            strCondition = string.Format("FieldAliases = '{0}' And SqlViewId = '{1}'", objFieldTabEN.FldName, strSqlViewId);
                            objvSqlViewFldEN = clsvSqlViewFldBL.GetFirstObj_S(strCondition);
                            bolIsUseFieldAliases = true;
                        }
                        clsvPrjTabFldEN objvPrjTabFldEN4Key = GetRelevPrjTabFldByLstAndRelaText(arrvPrjTabFldObjList4Tab, objvSqlViewFldEN.TabRelationText);
                        clsPrjTabFldEN objPrjTabFldEN4Key = null;
                        if (objvPrjTabFldEN4Key != null)
                        {
                            objPrjTabFldEN4Key = clsPrjTabFldBLEx.GetObjByFldId(arrPrjTabFldObjList4View, objvPrjTabFldEN4Key.FldId);

                        }
                        else
                        {
                            objPrjTabFldEN.SequenceNumber = 100000;

                        }
                        string strCondition4PrjTabFld = "";
                        if (bolIsUseFieldAliases == false)
                        {
                            strCondition4PrjTabFld = string.Format("FldId = '{0}' And TabId = '{1}'", objvSqlViewFldEN.FldId, objvSqlViewFldEN.TabId);
                        }
                        else
                        {
                            strCondition4PrjTabFld = string.Format("FldName = '{0}' And TabId = '{1}'", objFieldTabEN.FldName, objvSqlViewFldEN.TabId);

                        }
                        clsvPrjTabFldEN objvPrjTabFldEN_Find = clsvPrjTabFldBL.GetFirstObj_S(strCondition4PrjTabFld);
                        if (objvPrjTabFldEN_Find != null)
                        {
                            //objvSqlViewFldEN.TabRelationText;
                            if (objPrjTabFldEN4Key == null)
                            {
                                objPrjTabFldEN.SequenceNumber = objvPrjTabFldEN_Find.SequenceNumber * 10;
                            }
                            else
                            {
                                objPrjTabFldEN.SequenceNumber = objPrjTabFldEN4Key.SequenceNumber + objvPrjTabFldEN_Find.SequenceNumber * 10;
                            }
                        }
                        else
                        {
                            objPrjTabFldEN.SequenceNumber = 100000;

                        }
                    }
                    catch (Exception objException)
                    {
                        clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                        continue;
                    }
                }
            }
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList4View)
            {
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
            }
            clsPrjTabFldBLEx.ReOrder(strViewTabId);
            return true;
        }


        public static clsvPrjTabFldEN GetRelevPrjTabFldByLstAndRelaText(List<clsvPrjTabFldEN> arrvPrjTabFldObjList4Tab, string strTabRelationText)
        {
            foreach (clsvPrjTabFldEN objvPrjTabFldEN in arrvPrjTabFldObjList4Tab)
            {
                string[] sstrFieldExpress = strTabRelationText.Split('=');
                foreach (string strFieldExpress in sstrFieldExpress)
                {
                    string strFieldName = "";
                    int intPos_Point = strFieldExpress.LastIndexOf(".");
                    if (intPos_Point >= 0)
                    {
                        strFieldName = strFieldExpress.Substring(intPos_Point + 1);
                    }
                    else
                    {
                        strFieldName = strFieldExpress;
                    }
                    strFieldName = strFieldName.Trim();
                    if (strFieldName.Equals(objvPrjTabFldEN.FldName, StringComparison.InvariantCultureIgnoreCase) == true)
                    {
                        return objvPrjTabFldEN;
                    }
                }
                //if (strTabRelationText.IndexOf(objvPrjTabFldEN.FldName) >=  0)
                //{
                //    return objvPrjTabFldEN;
                //}
            }
            return null;
        }
        public static bool p_Init_Log4GeneTabCode(string strPrjId, string strUserId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPrjTabDA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strPrjId);
            values.Add(strUserId);
            objSQL.ExecSP2("p_Init_Log4GeneTabCode", values);
            return true;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表对象</returns>
        public static clsPrjTabEN GetObjByTabIdEx(string strTabId)
        {
            if (dicPrjTabLst == null)
            {
                dicPrjTabLst = new Dictionary<string, clsPrjTabEN>();
            }
            string strCurrDateTime = clsDateTime.getTodayDateTimeStr(1);

            if (string.IsNullOrEmpty(mstrLastRecordDateTime) == false)
            {
                DateTime dtLast = clsDateTime.GetDateTimeByDateStr14(mstrLastRecordDateTime);
                DateTime dtNow = DateTime.Now;
                if (dtLast.AddMinutes(2) < dtNow)
                {
                    InitdicPrjTabLst();
                }
            }
            if (dicPrjTabLst.ContainsKey(strTabId) == true)
            {
                clsPrjTabEN objPrjTabEN1 = dicPrjTabLst[strTabId];
                return objPrjTabEN1;
            }
            if (string.IsNullOrEmpty(strTabId) == true)
            {
                string strMsg = string.Format("在表[PrjTab]中，关键字[strTabId]不能为空!");
                throw new Exception(strMsg);
            }
            clsPrjTabEN objPrjTabEN = new clsPrjTabDA().GetObjByTabId(strTabId);
            dicPrjTabLst.Add(strTabId, objPrjTabEN);
            mstrLastRecordDateTime = strCurrDateTime;
            return objPrjTabEN;
        }

        /// <summary>
        /// 获取给定表(视图)的相关子结点表
        /// </summary>
        /// <param name="strTabId">给定表Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>相关子结点表Id列表</returns>
        public static List<string> GetRelaSubNodeByTabId(string strTabId, string strPrjId)
        {
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLstCache(strPrjId);

            arrPrjTabObjLst = arrPrjTabObjLst.OrderBy(x => x.TabId).ToList();
            Graph g = new Graph();
            try
            {
                InitGraph(g, strPrjId, arrPrjTabObjLst, "ToDown");//正方向
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在初始化图时出错。strPrjId={0},arrPrjTabObjLst.Count={1}.({2}). 错误:{3}",
                    strPrjId, arrPrjTabObjLst.Count, clsStackTrace.GetCurrClassFunction(), objException.Message);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            //g.CalcDepth();
            //StringBuilder sbMsg = new StringBuilder();

            //sbMsg.Append("\n深度优先遍历");
            //listBox1.Items.Add("深度优先遍历");

            int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            List<Vertex> arrResult = g.GetAllSuccessorBFS(intIndex);
            List<string> arrTabIdLst = new List<string>();
            foreach (Vertex objVertex in arrResult)
            {
                if (objVertex == null) continue;
                //string[] sstrText = objVertex.Data.Split('-');
                //if (sstrText.Length != 2) continue;

                string strRelaTabId = objVertex.KeyId.ToString();
                if (strRelaTabId == strTabId) continue;
                arrTabIdLst.Add(strRelaTabId);
            }
            return arrTabIdLst;
            //sbMsg.Append("\n广度优先遍历");

            //List<Vertex> arrResult2 = g.GetAllSuccessorDFS(intIndex);
            //foreach (Vertex strResult in arrResult2)
            //{
            //    string[] sstrText = strResult.Data.Split('-');
            //    if (sstrText.Length != 2) continue;

            //    string strRelaTabId = sstrText[0];
            //    arrTabIdLst.Add(strRelaTabId);
            //}

        }


        /// <summary>
        /// 获取给定表(视图)为主表的相关子结点表
        /// </summary>
        /// <param name="strTabId">给定表Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>相关子结点表Id列表</returns>
        public static List<string> GetRelaViewTabIdLstByTabId(string strTabId, string strPrjId)
        {
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLstCache(strPrjId);
            arrPrjTabObjLst = arrPrjTabObjLst.Where(x => x.RelaTabId4View == strTabId).ToList();
            List<string> arrTabIdLst = arrPrjTabObjLst.Select(x => x.TabId).ToList();
            return arrTabIdLst;
        }

        /// <summary>
        /// 获取给定表(视图)的相关子结点表
        /// </summary>
        /// <param name="strTabId">给定表Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>相关子结点表Id列表</returns>
        public static List<string> GetRelaParentNodeByTabId(string strTabId, string strPrjId)
        {
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLstCache(strPrjId);

            arrPrjTabObjLst = arrPrjTabObjLst.Where(x => x.TabStateId == enumTabState.Normal_01).OrderBy(x => x.TabId).ToList();
            Graph g = new Graph();
            InitGraph(g, strPrjId, arrPrjTabObjLst, "ToUp");//反方向
                                                            //g.CalcDepth();
                                                            //StringBuilder sbMsg = new StringBuilder();

            //sbMsg.Append("\n深度优先遍历");
            //listBox1.Items.Add("深度优先遍历");

            int intIndex = clsPrjTabBLEx.GetIndexByTabId(strTabId, arrPrjTabObjLst);
            List<Vertex> arrResult = g.GetAllSuccessorBFS(intIndex);
            List<string> arrTabIdLst = new List<string>();
            foreach (Vertex objVertex in arrResult)
            {
                if (objVertex == null) continue;
                //string[] sstrText = objVertex.Data.Split('-');
                //if (sstrText.Length != 2) continue;

                string strRelaTabId = objVertex.KeyId.ToString();
                if (strRelaTabId == strTabId) continue;
                arrTabIdLst.Add(strRelaTabId);
            }
            return arrTabIdLst;
            //sbMsg.Append("\n广度优先遍历");

            //List<Vertex> arrResult2 = g.GetAllSuccessorDFS(intIndex);
            //foreach (Vertex strResult in arrResult2)
            //{
            //    string[] sstrText = strResult.Data.Split('-');
            //    if (sstrText.Length != 2) continue;

            //    string strRelaTabId = sstrText[0];
            //    arrTabIdLst.Add(strRelaTabId);
            //}

        }


        private static void InitGraph(Graph g, string strPrjId,
            List<clsPrjTabEN> arrPrjTabObjLst, string strDirect)
        {
            //string strCondition = string.Format("PrjId = '{0}' Order By {1}",
            //    strPrjId, conPrjTab.TabName);
            //string strCondition2 = string.Format("PrjId = '{0}'", strPrjId);

            List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabENObjLst = clsvSqlViewRelaTabBL.GetObjLstCache(strPrjId);

            //g.AddVertex("Tab-Root");

            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                //string strText = string.Format("{0}-{1}",
                //    objPrjTabEN.TabId, objPrjTabEN.TabName);
                g.AddVertex(objPrjTabEN.TabId, objPrjTabEN.TabName);
            }
            foreach (clsvSqlViewRelaTabEN objvSqlViewRelaTabEN in arrvSqlViewRelaTabENObjLst)
            {
                int intStart = clsPrjTabBLEx.GetIndexByTabId(objvSqlViewRelaTabEN.TabId, arrPrjTabObjLst);
                int intEnd = clsPrjTabBLEx.GetIndexByTabId(objvSqlViewRelaTabEN.RelaTabId4SqlView, arrPrjTabObjLst);
                if (intStart != -1 && intEnd != -1)
                {
                    if (strDirect == "ToUp")
                    {
                        g.AddEdge(intEnd, intStart);
                    }
                    else
                    {
                        g.AddEdge(intStart, intEnd);
                    }
                }
            }
            //g.AddVertex("Root");
            //g.AddVertex("Users");
            //g.AddVertex("Dept");
            //g.AddVertex("Student");
            //g.AddVertex("Teacher");


            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(0, 3);
            //g.AddEdge(0, 4);

            //g.AddEdge(1, 5);
            //g.AddEdge(1, 6);
            //g.AddEdge(1, 7);


        }
        /// <summary>
        /// 设置引用序号，0代表未被引用，1代表引用过其他，2代表引用过引用过其他视图的视图
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static int SetOrderNum4Refer(string strPrjId)
        {
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLstCache(strPrjId);

            arrPrjTabObjLst = arrPrjTabObjLst.OrderBy(x => x.TabId).ToList();

            Graph g = new Graph();
            InitGraph(g, strPrjId, arrPrjTabObjLst, "ToDown");//正方向
            g.CalcDepth();
            int intCount = 0;
            foreach (Vertex objVertex in g.Vertexes)
            {
                if (objVertex == null) continue;
                //string[] sstrText = objVertex.Data.Split('-');
                //if (sstrText.Length != 2) continue;

                string strRelaTabId = objVertex.KeyId.ToString();
                string strCondition = string.Format("{0}='{1}'", conPrjTab.TabId, strRelaTabId);
                clsPrjTabBL.SetFldValue(clsPrjTabEN._CurrTabName,
                    conPrjTab.OrderNum4Refer, objVertex.Depth, strCondition);
                intCount++;
            }
            return intCount;
        }
        /// <summary>
        /// 当前表名
        /// </summary>
        public string TabName
        {
            get
            {
                return objPrjTabENEx.TabName;
            }
        }

        /// <summary>
        /// 与WebService相关的类Id
        /// </summary>
        public string WebSrvClassId
        {
            get
            {
                return mstrWebSrvClassId;
            }

            set
            {
                mstrWebSrvClassId = value;
                GetWebSrvClassInfoByClassId();
            }
        }
        /// <summary>
        /// 根据类Id获取相关信息
        /// </summary>
        public void GetWebSrvClassInfoByClassId()
        {
            clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetObjByWebSrvClassId(mstrWebSrvClassId);
            this.objWebSrvClassENEx = new clsWebSrvClassENEx(mstrWebSrvClassId);
            clsWebSrvClassBL.CopyTo(objWebSrvClassEN, this.objWebSrvClassENEx);
            //this. objWebSrvClassENEx = new clsWebSrvClassENEx(strTabId);
            this.objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            if (this.objFuncModuleEN == null)
            {
                string strMsg = string.Format("WebService类:[{0}({1})]的模块为空，请维护该表的模块。({2})",
                    this.objWebSrvClassENEx.ClsName, this.objWebSrvClassENEx.WebSrvClassId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            this.objWebSrvClassENEx.ObjFuncModule = this.objFuncModuleEN;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId);
            this.objProjectsENEx = new clsProjectsENEx();
            clsProjectsBL.CopyTo(objProjectsEN, objProjectsENEx);
            this.objWebSrvClassENEx.objProjectsEN = objProjectsEN;
            this.objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst = clsWebSrvFunctionsBLEx.GetWebSrvFunctionsENExObjListByClassId(mstrWebSrvClassId);
        }

        public static bool SetSameModuleNameForViewRelaTab(string strTabId, string strPrjId)
        {
            var objPrjTab_V = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTab_V.SqlDsTypeId == enumSQLDSType.SqlTab_01) return true;
            if (string.IsNullOrEmpty(objPrjTab_V.RelaTabId4View) == true) return true;
            var objPrjTab = clsPrjTabBLEx.GetObjByTabIdCache(objPrjTab_V.RelaTabId4View, strPrjId);
            if (objPrjTab.FuncModuleAgcId == objPrjTab_V.FuncModuleAgcId) return true;
            bool bolResult = objPrjTab_V
                .SetFuncModuleAgcId(objPrjTab.FuncModuleAgcId)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                .Update();
            return bolResult;
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

        //    //string strPrjId4Ag1c = "0013";
        //    //string strTabName4Set = "PrjTab";
        //    //string strCondition4DataSyn = string.Format("PrjId='{0}' And TabName='{1}'", strPrjId4Agc, strTabName4Set);
        //    //string strTabId = clsPrjTabBL.GetFirstID_S(strCondition4DataSyn);

        //    //clsPrjTabEN objPrjTabEN = new clsPrjTabEN(strId_TransferCourses);
        //    ////objPrjTabEN.Id_TransferCourses
        //    //clsPrjTabBL.GetPrjTab(ref objPrjTabEN);
        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //    List<clsPrjTabEN> arrPrjTabENObjLst = clsPrjTabBL.GetObjLst(strCondition);

        //    foreach (clsPrjTabEN objPrjTabEN4Web in arrPrjTabENObjLst)
        //    {

        //        objPrjTabEN4Web.IsSynchToServer = true;
        //        objPrjTabEN4Web.SynchToServerDate = strCurrDate14;
        //        objPrjTabEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";
        //        //string strCondition2 = string.Format("id_Stu='{0}' And ScrTermSeq={1} And id_course='{2}' and id_scoretype='{3}'",
        //        // objPrjTabEN4Web.Id_TransferCourses,
        //        // objPrjTabEN4Web.ScrTermSeq,
        //        // objPrjTabEN4Web.id_Course,
        //        // objPrjTabEN4Web.id_ScoreType);
        //        try
        //        {
        //            clsPrjTabEN objPrjTabEN4Web2 = new clsPrjTabEN();
        //            clsPrjTabBL.CopyTo(objPrjTabEN4Web, objPrjTabEN4Web2);
        //            objPrjTabEN4Web2.SynSource = "Client";
        //            strCondition = objPrjTabEN4Web.GetUniquenessConditionString();
        //            clsPrjTabEN objPrjTab_Target = clsPrjTabBL.GetFirstObj_S(strCondition);

        //            if (objPrjTab_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objPrjTab_Target.UpdDate.CompareTo(objPrjTabEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objPrjTabEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                objPrjTabEN4Web2.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S(objPrjTabEN4Web2.PrjId);
        //                clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsPrjTabBL.UpdateBySql2(objPrjTabEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objPrjTabEN4Web.TabId,
        //                        objPrjTabEN4Web.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        /// <summary>
        /// 同步满足条件的学生信息到Web
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
        //    //string strTabName4Set = "PrjTab";
        //    //string strCondition4DataSyn = string.Format("PrjId='{0}' And TabName='{1}'", strPrjId4Agc, strTabName4Set);
        //    //string strTabId = clsPrjTabBL.GetFirstID_S(strCondition4DataSyn);

        //    //clsPrjTabEN objPrjTabEN = new clsPrjTabEN(strId_TransferCourses);
        //    ////objPrjTabEN.Id_TransferCourses
        //    //clsPrjTabBL.GetPrjTab(ref objPrjTabEN);
        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsPrjTabEN> arrPrjTabENObjLst = clsPrjTabBL.GetObjLst(strCondition);

        //    foreach (clsPrjTabEN objPrjTabEN4Main in arrPrjTabENObjLst)
        //    {

        //        objPrjTabEN4Main.IsSynchToClient = true;
        //        objPrjTabEN4Main.SynchToClientDate = strCurrDate14;
        //        objPrjTabEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        //string strCondition2 = string.Format("id_Stu='{0}' And ScrTermSeq={1} And id_course='{2}' and id_scoretype='{3}'",
        //        // objPrjTabEN4Web.Id_TransferCourses,
        //        // objPrjTabEN4Web.ScrTermSeq,
        //        // objPrjTabEN4Web.id_Course,
        //        // objPrjTabEN4Web.id_ScoreType);
        //        try
        //        {
        //            clsPrjTabEN objPrjTabEN4Main2 = new clsPrjTabEN();
        //            clsPrjTabBL.CopyTo(objPrjTabEN4Main, objPrjTabEN4Main2);
        //            objPrjTabEN4Main2.SynSource = "Server";
        //            strCondition = objPrjTabEN4Main.GetUniquenessConditionString();
        //            clsPrjTabEN objPrjTab_Target = clsPrjTabBL.GetFirstObj_S(strCondition);

        //            if (objPrjTab_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objPrjTab_Target.UpdDate.CompareTo(objPrjTabEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objPrjTabEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsPrjTabBL.UpdateBySql2(objPrjTabEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objPrjTabEN4Main.TabId,
        //                        objPrjTabEN4Main.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        //public static List<clsvPrjTabEN> arrPrjTabObjLst = null;// objPrjMenuEx.GetObjLst(strCondition.ToString() + " Order by TabName");
        //public static List<clsvPrjTabEN> arrPrjViewObjLst = null;// objPrjMenuEx.GetObjLst(strCondition.ToString() + " Order by TabName");
        //public static ArrayList arrPrjTabViewObjLst = null;// objPrjMenuEx.GetObjLst(strCondition.ToString() + " Order by TabName");


        //public bool IsExistSameTabName(string strPrjId, string strTabName)
        //{
        //    StringBuilder strCondition = new StringBuilder();
        //    strCondition.AppendFormat("PrjId = '{1}' and TabName = '{0}'", strTabName, strPrjId);
        //    return clsPrjTabBL. IsExistRecord(strCondition.ToString());
        //}
        /// <summary>
        /// 是否能够删除和修改
        /// </summary>
        /// <param name = "strFldId">字段ID</param>
        /// <returns></returns>
        public static bool IsCanDelUpd(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);

            bool bolIsArchive;
            if (objPrjTabEN == null)
            {
                return true;
            }

            bolIsArchive = objPrjTabEN.IsArchive;
            if (bolIsArchive == true) return false;
            bool bolIsChecked = objPrjTabEN.IsChecked;
            return !bolIsChecked;
        }
        public static bool AddRecordBak(string strPrjId, string strDataBaseName, string strObjId, string strTabName, string strTabCnName, string strTabMemo, string strSqlDsTypeId)
        {
            if (clsPrjTabBLEx.IsExistSameTabName(strPrjId, strTabName) == true)
            {
                string strTabId = clsPrjTabBL.GetFirstID_S("TabName = '" + strTabName + "' and PrjId = '" + strPrjId + "'");
                clsPrjTabEN objPrjTabEN1 = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
                //objPrjTabEN1.ObjId = strObjId;
                return clsPrjTabBL.UpdateBySql2(objPrjTabEN1);
            }
            clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
            objPrjTabEN.TabId = clsGeneralTab.GetMaxStrId("PrjTab", "TabId", 8, strPrjId);
            objPrjTabEN.TabName = strTabName;
            objPrjTabEN.PrjId = strPrjId;
            objPrjTabEN.DataBaseName = strDataBaseName;
            objPrjTabEN.TabCnName = strTabCnName;
            //objPrjTabEN.ObjId = strObjId;
            objPrjTabEN.IsNeedTransCode = false;
            objPrjTabEN.TabStateId = "01";

            objPrjTabEN.Memo = strTabMemo;
            objPrjTabEN.SqlDsTypeId = strSqlDsTypeId;
            objPrjTabEN.IsUseCache = true;

            return clsPrjTabBL.AddNewRecordBySql2(objPrjTabEN);
        }


        /// <summary>
        /// 根据对象ID获取表ID
        /// </summary>
        /// <param name = "strObjId">对象ID</param>
        /// <returns>获取表ID</returns>
        public static string GetTabIdByObjId(string strObjId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetFirstObj_S("ObjId = '" + strObjId + "'");
            if (objPrjTabEN == null)
                return "";
            return objPrjTabEN.TabId;
        }

        public static bool BackupPrjTabInfo(ArrayList arrRec)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            string strKeyList;
            if (arrRec.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < arrRec.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + arrRec[i].ToString() + "'";
                else strKeyList += "," + "'" + arrRec[i].ToString() + "'";
            }
            strSQL = "";
            //删除FieldTab本表中与当前对象有关的记录
            strSQL = strSQL + "Update PrjTab Set TabNameB = TabName where TabID in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }


        public static bool DelPrjTabFld(string strTabId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除PrjTab本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PrjTabFld where TabId = " + "'" + strTabId + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 删除工程表字段信息,以及他们的外键记录(包括界面区域中的所有字段)
        /// </summary>
        /// <returns></returns>
        public static bool DelPrjTabFld_Hard(string strTabId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除编辑区域中的相关表字段
            strSQL = strSQL + "Delete from EditRegionFlds where TabFldId in (Select mid from PrjTabfld where TabId = '" + strTabId + "')";
            //查询区域
            strSQL = strSQL + "Delete from QryRegionFlds where TabFldId in (Select mid from PrjTabfld where TabId = '" + strTabId + "')";

            //			DG区域
            strSQL = strSQL + "Delete from DGRegionFlds where TabFldId in (Select mid from PrjTabfld where TabId = '" + strTabId + "')";
            //				详细区域
            //			strSQL = strSQL + "Delete from DetailRegionFlds where TabFldId in (Select mid from PrjTabfld where TabId = '"+ strTabId+"')";
            //				LISTVIEW区域
            strSQL = strSQL + "Delete from ListViewRegionFlds where TabFldId in (Select mid from PrjTabfld where TabId = '" + strTabId + "')";
            //				EXCEL导出区域
            strSQL = strSQL + "Delete from ExcelExportRegionFlds where TabFldId in (Select mid from PrjTabfld where TabId = '" + strTabId + "')";
            //删除PrjTab本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from PrjTabFld where TabId = " + "'" + strTabId + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 获取给定表的关键字段名
        /// </summary>
        /// <param name = "strTabId">所给的表Id</param>
        /// <returns>获取的关键字段名</returns>
        public static string GetTabKeyFieldName(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("TabId = '{0}' and FieldTypeId = '02'", strTabId);
            clsvPrjTabFldEN objvPrjTabFld = clsvPrjTabFldBL.GetFirstObj_S(sbCondition.ToString());

            if (objvPrjTabFld == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("当前表:{0}的没有关键字段!", objPrjTabEN.TabName);
                throw new Exception(sbMessage.ToString());
            }
            else
            {
                return objvPrjTabFld.FldName;
            }
        }
        /// <summary>
        /// 获取给定表的关键字段名
        /// </summary>
        /// <param name = "strTabId">所给的表Id</param>
        /// <returns>获取的关键字段名</returns>
        public static string GetTabKeyFieldId(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("TabId = '{0}' and FieldTypeId = '02'", strTabId);
            clsvPrjTabFldEN objvPrjTabFld = clsvPrjTabFldBL.GetFirstObj_S(sbCondition.ToString());

            if (objvPrjTabFld == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("当前表:{0}的没有关键字段!", objPrjTabEN.TabName);
                throw new Exception(sbMessage.ToString());
            }
            else
            {
                return objvPrjTabFld.FldId;
            }
        }


        /// <summary>
        /// 功能:获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetPrjTabV4ErrMsg(string strWhereCond)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strWhereCond);
            }
            catch (Exception objException)
            {

                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPrjTabDA.GetSpecSQLObj();
            strSQL.Append("Select * ");
            strSQL.Append(" from vPrjTab4ErrMsg ");
            strSQL.Append(" where " + strWhereCond);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsPrjTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsPrjTabDAEx PrjTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsPrjTabDAEx();
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
        public static List<clsPrjTabENEx> GetObjExLst(string strCondition)
        {
            List<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLst(strCondition);
            List<clsPrjTabENEx> arrObjExLst = new List<clsPrjTabENEx>();
            foreach (clsPrjTabEN objInFor in arrObjLst)
            {
                clsPrjTabENEx objPrjTabENEx = new clsPrjTabENEx();
                clsPrjTabBL.CopyTo(objInFor, objPrjTabENEx);
                arrObjExLst.Add(objPrjTabENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsPrjTabENEx GetObjExByTabId(string strTabId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            clsPrjTabENEx objPrjTabENEx = new clsPrjTabENEx();
            clsPrjTabBL.CopyTo(objPrjTabEN, objPrjTabENEx);
            return objPrjTabENEx;
        }

        /// <summary>
        /// 获取在工程中的文件名
        /// </summary>
        /// <param name="strCodePath">在工程中的代码路径</param>
        /// <param name="strFuncModuleEnName">模块名</param>
        /// <param name="strFileName">文件名</param>
        /// <returns></returns>
        public static string GetFileNameInPrj(string strCodePath, string strFuncModuleEnName, string strFileName)
        {
            string strFileName_InPrj = string.Format("{0}/{1}/{2}", strCodePath, strFuncModuleEnName, strFileName);
            strFileName_InPrj = strFileName_InPrj.Replace("\\/\\", "\\")
                .Replace("/", "\\");
            if (strFileName_InPrj.Substring(0, 2) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(2);
            }
            if (strFileName_InPrj.Substring(0, 1) == "\\")
            {
                strFileName_InPrj = strFileName_InPrj.Substring(1);
            }
            return strFileName_InPrj;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程ID</param>
        public static void BindDdl_TabIdExCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conPrjTab.TabId); 
            IEnumerable<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLstCache(strPrjId)
                            .OrderBy(x => x.TabName);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_TabIdExCacheNoPureClass(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conPrjTab.TabId); 
            IEnumerable<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLstCache(strPrjId)
                            .Where(x => x.TabStateId == enumTabState.Normal_01 && x.TabTypeId != enumTabType.PureClass_0008)
                            .OrderBy(x => x.TabName);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_TabIdByCmPrjIdExCacheNoPureClass(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strCmPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conPrjTab.TabId); 
            IEnumerable<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLstCache(strPrjId)
                            .Where(x => x.TabStateId == enumTabState.Normal_01 && x.TabTypeId != enumTabType.PureClass_0008)
                            .OrderBy(x => x.TabName);
            List<string> arrTabId = clsCmProjectPrjTabBLEx.GetTabIdLstCache(strCmPrjId);
            arrObjLst = arrObjLst.Where(x => arrTabId.Contains(x.TabId) == true);
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_TabIdEx4QueryCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //            System.Data.DataTable objDT = GetTabId(strPrjId, strFuncModuleId);

            List<clsViewInfoEN> arrViewInfoObjLstCache = clsViewInfoBL.GetObjLstCache(strPrjId);// (strCondition).OrderBy(x => x.TabName).ToList();
            IEnumerable<string> arrMainTabId = arrViewInfoObjLstCache.Select(x => x.MainTabId);
            List<clsPrjTabEN> arrvPrjTab4DdlObjLstCache = clsPrjTabBL.GetObjLstCache(strPrjId);// (strCondition).OrderBy(x => x.TabName).ToList();
            IEnumerable<clsPrjTabEN> arrvPrjTab4DdlObjLst = arrvPrjTab4DdlObjLstCache
                .Where(x => arrMainTabId.Contains(x.TabId))
                .OrderBy(x => x.TabName);

            objDDL.DataValueField = "TabId";
            objDDL.DataTextField = "TabName";
            objDDL.DataSource = arrvPrjTab4DdlObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsPrjTabEN:objPrjTabENT</returns>
        public static clsPrjTabENEx CopyToEx(clsPrjTabEN objPrjTabENS)
        {
            try
            {
                clsPrjTabENEx objPrjTabENT = new clsPrjTabENEx();
                clsPrjTabBL.PrjTabDA.CopyTo(objPrjTabENS, objPrjTabENT);
                objPrjTabENT.SqlDsTypeName = clsSQLDSTypeBL.Func(conSQLDSType.SqlDsTypeId, conSQLDSType.SqlDsTypeName, objPrjTabENT.SqlDsTypeId);
                objPrjTabENT.TabStateName = clsTabStateBL.Func(conTabState.TabStateId, conTabState.TabStateName, objPrjTabENT.TabStateId);

                objPrjTabENT.FuncModuleName = clsFuncModule_AgcBL.Func(conFuncModule_Agc.FuncModuleAgcId, conFuncModule_Agc.FuncModuleName, objPrjTabENT.FuncModuleAgcId, objPrjTabENT.PrjId);

                objPrjTabENT.TabTypeName = clsTabTypeBL.Func(conTabType.TabTypeId, conTabType.TabTypeName, objPrjTabENT.TabTypeId);
                if (string.IsNullOrEmpty(objPrjTabENT.RelaTabId4View) == false)
                {
                    objPrjTabENT.RelaTabName4View = clsPrjTabBL.Func(conPrjTab.TabId, conPrjTab.TabName, objPrjTabENT.RelaTabId4View, objPrjTabENT.PrjId);
                }

                return objPrjTabENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件分页获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回分页对象列表</returns>
        public static List<clsPrjTabEN> GetObjLstByPagerEx(stuPagerPara objPagerPara)
        {
            return GetObjLstByPagerEx(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
        }
        /// <summary>
        /// 根据条件分页获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
        /// </summary>
        /// <param name = "intPageIndex">页序号</param>
        /// <param name = "intPageSize">页记录数</param>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>返回分页对象列表</returns>
        public static List<clsPrjTabEN> GetObjLstByPagerEx(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
        {
            List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>();
            System.Data.DataTable objDT;
            objDT = GetDataTableByPagerEx(intPageIndex, intPageSize, strWhereCond, strOrderBy);
            if (objDT.Rows.Count == 0)
            {
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
                try
                {
                    objPrjTabEN = clsPrjTabBL.GetObjByDataRow_S(objRow);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objPrjTabEN);
            }
            return arrObjLst;
        }


        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
        /// </summary>
        /// <param name = "intPageIndex">页序号</param>
        /// <param name = "intPageSize">页记录数</param>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableByPagerEx(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
        {

            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTableByPager)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL;
            //获取连接对象
            objSQL = clsPrjTabDA.GetSpecSQLObj();
            int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
            int intPos_Dot = strOrderBy.IndexOf('|');
            if (intPos_Dot > 0)
            {
                var IsAscOrDesc = "Asc";
                if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
                {
                    strOrderBy = strOrderBy.Replace(" Asc", "");
                    IsAscOrDesc = "Asc";
                }
                else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
                {
                    strOrderBy = strOrderBy.Replace(" Desc", "");
                    IsAscOrDesc = "Desc";
                }

                var arrPart = strOrderBy.Split('|');
                if (arrPart.Length != 3)
                {
                    throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
                        strOrderBy, clsStackTrace.GetCurrClassFunction()));
                }
                string strTabName = arrPart[0];
                string strNewOrderBy = arrPart[1];
                string strOnCondition = arrPart[2];
                strSQL = string.Format("Select Top {0} PrjTab.* from PrjTab Left Join {1} on {2} where {3} and PrjTab.TabId not in (Select top {5} PrjTab.TabId from PrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
                    intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
                try
                {
                    clsPubVar4BLEx.objLog4GC.WriteDebugLog(strSQL);
                }
                catch (Exception objEx)
                {
                    Console.WriteLine(objEx.ToString());
                }
            }
            else
            {
                if (string.IsNullOrEmpty(strOrderBy) == true)
                {
                    strSQL = string.Format("Select Top {0} * from PrjTab where {1} and TabId not in (Select top {2} TabId from PrjTab where {1}) ", intPageSize, strCondition, intTop_In);
                }
                else
                {
                    strSQL = string.Format("Select Top {0} * from PrjTab where {1} and TabId not in (Select top {3} TabId from PrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
                }
            }
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;

        }
        /// <summary>
        /// 用于函数参数的变量列表
        /// </summary>
        /// <returns></returns>
        public static string Cache_ParaVarDefLstStr(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = GetVarManageObj4Cache(objPrjTabENEx, strProgLangType);

            return objVarManage.ParaVarDefLstStr();
        }
        /// <summary>
        /// 用于函数参数的变量列表
        /// </summary>
        /// <returns></returns>
        public static string Cache_ParaVarLstStr(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = GetVarManageObj4Cache(objPrjTabENEx, strProgLangType);

            return objVarManage.ParaVarLstStr();
        }

        public static List<string> Cache_ParaVarLst(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = GetVarManageObj4Cache(objPrjTabENEx, strProgLangType);

            return objVarManage.ParaVarLst();
        }

        public static List<string> Cache_FldNameLst(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = GetVarManageObj4Cache(objPrjTabENEx, strProgLangType);

            return objVarManage.FldNameLst();
        }

        /// <summary>
        /// 用于函数参数的变量列表
        /// </summary>
        /// <returns></returns>
        public static string ParaVarDefLstStr(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = GetVarManageObj(objPrjTabENEx, strProgLangType);
            return objVarManage.ParaVarDefLstStr();
        }
        /// <summary>
        /// 用于函数参数的变量列表
        /// </summary>
        /// <returns></returns>
        public static string ParaVarLstStr(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = GetVarManageObj(objPrjTabENEx, strProgLangType);
            return objVarManage.ParaVarLstStr();
        }

        public static clsVarManage GetVarManageObj(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = new clsVarManage(strProgLangType);
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                objVarManage.AddVariable(new clsVariable(objInFor.PrivFuncName, objInFor.TypeScriptType, objInFor.FldName));
            }
            if (objPrjTabENEx.ObjCacheClassifyFld_TS != null)
            {
                objVarManage.AddVariable(new clsVariable(objPrjTabENEx.ObjCacheClassifyFld_TS.PrivFuncName, objPrjTabENEx.ObjCacheClassifyFld_TS.TypeScriptType, objPrjTabENEx.ObjCacheClassifyFld_TS.FldName));
            }
            if (objPrjTabENEx.ObjCacheClassifyFld2_TS != null)
            {
                objVarManage.AddVariable(new clsVariable(objPrjTabENEx.ObjCacheClassifyFld2_TS.PrivFuncName, objPrjTabENEx.ObjCacheClassifyFld2_TS.TypeScriptType, objPrjTabENEx.ObjCacheClassifyFld2_TS.FldName));
            }

            return objVarManage;
        }

        public static clsVarManage GetVarManageObj4Cache(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = new clsVarManage(strProgLangType);
            //foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            //{
            //    objVarManage.AddVariable(new clsVariable(objInFor.PrivFuncName, objInFor.TypeScriptType, objInFor.FldName));
            //}
            if (objPrjTabENEx.ObjCacheClassifyFld_TS != null)
            {
                objVarManage.AddVariable(new clsVariable(objPrjTabENEx.ObjCacheClassifyFld_TS.PrivFuncName, objPrjTabENEx.ObjCacheClassifyFld_TS.TypeScriptType, objPrjTabENEx.ObjCacheClassifyFld_TS.FldName));
            }
            if (objPrjTabENEx.ObjCacheClassifyFld2_TS != null)
            {
                objVarManage.AddVariable(new clsVariable(objPrjTabENEx.ObjCacheClassifyFld2_TS.PrivFuncName, objPrjTabENEx.ObjCacheClassifyFld2_TS.TypeScriptType, objPrjTabENEx.ObjCacheClassifyFld2_TS.FldName));
            }

            return objVarManage;
        }

        public static clsVarManage GetVarManageObj4Key(clsPrjTabENEx objPrjTabENEx, string strProgLangType)
        {
            var objVarManage = new clsVarManage(strProgLangType);
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                objVarManage.AddVariable(new clsVariable(objInFor.PrivFuncName, objInFor.TypeScriptType, objInFor.FldName));
            }

            return objVarManage;
        }

        public static string GetPrimaryTypeId(string strTabId, string strPrjId)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();

            if (arrPrjTabFld_Sel.Count == 0) return enumPrimaryType.NonPrimaryKey_00;
            if (arrPrjTabFld_Sel.Count == 1) return arrPrjTabFld_Sel[0].PrimaryTypeId;
            return enumPrimaryType.CompositePrimaryKey_07;
        }
        public static string GetPrimaryTypeHtmlInfo(string strTabId, string strPrjId)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();

            if (arrPrjTabFld_Sel.Count == 0) return "";
            var strKeyFldId = "";
            var strKeyFldName = "";
            var strPrimaryTypeId = "";

            foreach (var objPrjTabFld in arrPrjTabFld_Sel)
            {
                strKeyFldId += objPrjTabFld.FldId;
                var objFieldTab = clsvFieldTab_Sim2BL.GetObjByFldIdCache(objPrjTabFld.FldId, strPrjId);
                if (objFieldTab == null) continue;
                strKeyFldName += objFieldTab.FldName;
                strPrimaryTypeId = objPrjTabFld.PrimaryTypeId;
            }
            if (arrPrjTabFld_Sel.Count == 0) strPrimaryTypeId = enumPrimaryType.CompositePrimaryKey_07;
            var strPrimaryTypeName = "";
            var objPrimaryType = clsPrimaryTypeBL.GetObjByPrimaryTypeIdCache(strPrimaryTypeId);
            if (objPrimaryType == null) strPrimaryTypeName = "未知类型";
            else strPrimaryTypeName = objPrimaryType.PrimaryTypeName;
            var strReturn = string.Format("<span class='text-primary' title='主键类型'>{0}</span><br/><span class='text-info' title='主键字段名'>{1}</span>",
                strPrimaryTypeName, strKeyFldName);
            return strReturn;
        }


        public static string GetPrimaryTypeInfo0(string strTabId, string strPrjId)
        {
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            var arrPrjTabFld_Sel = arrPrjTabFld.Where(x => x.FieldTypeId == enumFieldType.KeyField_02).ToList();

            if (arrPrjTabFld_Sel.Count == 0) return "";
            var strKeyFldId = "";
            var strKeyFldName = "";
            var strPrimaryTypeId = "";

            foreach (var objPrjTabFld in arrPrjTabFld_Sel)
            {
                strKeyFldId += objPrjTabFld.FldId;
                var objFieldTab = clsvFieldTab_Sim2BL.GetObjByFldIdCache(objPrjTabFld.FldId, strPrjId);
                if (objFieldTab == null) continue;
                strKeyFldName += objFieldTab.FldName;
                strPrimaryTypeId = objPrjTabFld.PrimaryTypeId;
            }
            if (arrPrjTabFld_Sel.Count == 0) strPrimaryTypeId = enumPrimaryType.CompositePrimaryKey_07;
            var strPrimaryTypeName = "";
            var objPrimaryType = clsPrimaryTypeBL.GetObjByPrimaryTypeIdCache(strPrimaryTypeId);
            if (objPrimaryType == null) strPrimaryTypeName = "未知类型";
            else strPrimaryTypeName = objPrimaryType.PrimaryTypeName;
            var strReturn = string.Format("主键类型:{0},主键字段名:{1}",
                strPrimaryTypeName, strKeyFldName);
            return strReturn;
        }
        public static bool IsSessionStorage4Cache1(string strTabId, string strPrjId)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);

            if (string.IsNullOrEmpty(objPrjTab.ParaVar1TS) == false)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objPrjTab.ParaVar1TS);
                if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004
                    || objVar.VarTypeId == enumGCVariableType.localStorage_0003) return true;

            }
            return false;
        }

        public static bool IsSessionStorage4Cache2(string strTabId, string strPrjId)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);

            if (string.IsNullOrEmpty(objPrjTab.ParaVar2TS) == false)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objPrjTab.ParaVar2TS);
                if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004
                    || objVar.VarTypeId == enumGCVariableType.localStorage_0003) return true;

            }
            return false;
        }

        public static bool CheckTabFlds(string strTabId, string strPrjDataBaseId, string strCmPrjId, string strOpUserId, string strViewId = "")
        {
            var strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);

            List<clsErrMsgENEx> arrErrMsg = new List<clsErrMsgENEx>();
            if (string.IsNullOrEmpty(strViewId) == false)
            {
                if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, strPrjId);
                    string strVarIdId = objPrjTab.ParaVar1TS;
                    if (string.IsNullOrEmpty(strVarIdId) == true)
                    {
                        var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);

                        string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]没有相应的参数变量。与界面:{objViewInfo.ViewName}({strViewId})相关 ！";
                        objPrjTab.ErrMsg = strMsg;
                        objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objPrjTab.Update();
                        throw new Exception(strMsg);
                    }
                    var objGcVar = clsGCVariableBL.GetObjByVarIdCache(strVarIdId);
                    if (objGcVar == null)
                    {
                        var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]变量1：{objPrjTab.ParaVar1TS}在变量表不存在. 与界面:{objViewInfo.ViewName}({strViewId})相关，请检查 ！";
                        objPrjTab.ErrMsg = strMsg;
                        objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objPrjTab.Update();
                        throw new Exception(strMsg);
                    }
                    if (clsGCVariablePrjIdRelaBL.IsExist(strVarIdId, strPrjId) == false)
                    {
                        var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                        string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]变量1：{objGcVar.VarName}在工程Id:{strPrjId}不存在。与界面:{objViewInfo.ViewName}({strViewId})相关，请检查 ！";
                        objPrjTab.ErrMsg = strMsg;
                        objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objPrjTab.Update();
                        throw new Exception(strMsg);
                    }
                    if (clsViewIdGCVariableRelaBL.IsExist(strVarIdId, strViewId) == false)
                    {
                        var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);

                        string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]变量1：{objGcVar.VarName}在界面:{objViewInfo.ViewName}({strViewId})的变量表中不存在，请检查 ！";
                        //objPrjTab.ErrMsg = strMsg;
                        //objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        //objPrjTab.Update();
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        var objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarIdId, strViewId);
                        if (objViewIdGCVariableRela.RegionTypeNames.Contains("CacheField") == false)
                        {
                            var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
                            string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]变量1：{objGcVar.VarName}在界面:{objViewInfo.ViewName}({strViewId})的变量表中存在,但区域类型中没有[CacheField]，请检查 ！";
                            //objPrjTab.ErrMsg = strMsg;
                            //objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            //objPrjTab.Update();
                            throw new Exception(strMsg);
                        }
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, strPrjId);
                    string strVarIdId = objPrjTab.ParaVar1TS;
                    if (string.IsNullOrEmpty(strVarIdId) == true)
                    {

                        string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]没有相应的参数变量！";
                        objPrjTab.ErrMsg = strMsg;
                        objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objPrjTab.Update();
                        return false;
                    }
                    var objGcVar = clsGCVariableBL.GetObjByVarIdCache(strVarIdId);
                    if (objGcVar == null)
                    {

                        string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]变量1：{objPrjTab.ParaVar1TS}在变量表不存在 ！";
                        objPrjTab.ErrMsg = strMsg;
                        objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objPrjTab.Update();
                        return false;

                    }
                    if (clsGCVariablePrjIdRelaBL.IsExist(strVarIdId, strPrjId) == false)
                    {

                        string strMsg = $"数据表:[{objPrjTab.TabName}]的缓存分类字段:[{objFieldTab.FldName}]变量1：{objGcVar.VarName}在工程Id:{strPrjId}不存在。";
                        objPrjTab.ErrMsg = strMsg;
                        objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objPrjTab.Update();
                        return false;

                    }
                }

            }

            try
            {
                clsPrjTabBLEx.CheckTabExtendFld(strTabId, strPrjId);
            }
            catch (Exception ex) {
                string strMsg = ex.Message;
                objPrjTab.ErrMsg = strMsg;
                objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjTab.Update();
                return false;
            }

            if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId, strPrjId, strPrjDataBaseId) == false)
            {
                string strMsg = string.Format("(errorId:0002)检查表字段不成功!.({0})",
                            clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);

                throw new Exception("检查表字段不成功!");
                //return false;
            }
            var objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTabDetail(strTabId, objProjectsEN, strPrjDataBaseId, strOpUserId);

            var objErrMsg_Tab = clsPrjTabFldBLEx.CheckTabFlds(strTabId, strPrjId, strOpUserId);
            if (objErrMsg_Tab.ErrNum > 0) arrErrMsg.Add(objErrMsg_Tab);
            if (arrErrMsg.Count > 0)
            {
                objPrjTab.ErrMsg = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg);
                objPrjTab.Update();

            }
            else
            {
                //if (objPrjTab.ErrMsg != null && objPrjTab.ErrMsg.Length > 0)
                //{
                objPrjTab.ErrMsg = "";
                objPrjTab.Update();
                //}
            }

            return true;
        }
        /// <summary>
        /// 导入Sql中的数据表到代码系统
        /// </summary>
        /// <param name="arrSqlTable">所要导入数据表</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool ImportSqlTab(List<stuSqlTable> arrSqlTable, string strPrjId, string strPrjDataBaseId, string strUserId)
        {
            if (arrSqlTable.Count == 0) return false;
            //var objSqlTable_Fst = arrSqlTable[0];
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            //string strPrjId = objSqlTable_Fst.PrjId;
            //string strUserId = objSqlTable_Fst.UserId;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);

            bool bolResult = true;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            string strTabId;
            string strSqlDsTypeId;
            string strObjName;
            //string strObjId;
            string strObjFunction;
            string strFldCaption;
            string strFldName;
            string strFldType;
            string strTabCnName, strTabMemo;
            string strIsNull;
            int intFldLength;
            int intFldPrecision;
            bool bolIsNull;
            foreach (var objSqlTable in arrSqlTable)
            {
                string strFuncModuleId = "";
                string strTabName = objSqlTable.TabName;
                strSqlDsTypeId = objSqlTable.SqlTypeId;
                strObjName = strTabName;
                strObjFunction = strTabName;
                if (strSqlDsTypeId == "02")// 是视图
                {
                    string strRelaTabName = clsPrjTabBLEx.GetReleTabNameByViewName(strTabName);
                    string strCondition = string.Format("TabName='{0}' And PrjId='{1}'", strRelaTabName, strPrjId);

                    clsPrjTabEN objRelePrjTab = clsPrjTabBL.GetFirstObj_S(strCondition);
                    if (objRelePrjTab == null)
                    {
                        strFuncModuleId = null;
                    }
                    else
                    {
                        strFuncModuleId = objRelePrjTab.FuncModuleAgcId;
                    }
                }


                //5、向表中添加该表记录；
                strTabCnName = strTabName;
                strTabMemo = strTabName;
                strTabId = clsPrjTabBLEx.AddRecord(strPrjId,
                        objPrjDataBase.DataBaseName,
                    strTabName,
                    strTabCnName,
                    strTabMemo, strSqlDsTypeId, strFuncModuleId, strUserId);

                //4、再向该视图对象表中添加相关字段。
                List<clsColumns> arrColumnObjList = clsSqlObject.GetColumnObjList(strTabName,
                strConnectString,
                objPrjDataBase.DatabaseOwner);
                int intOrderNum = 1;
                foreach (clsColumns objColumn in arrColumnObjList)
                {
                    strFldName = objColumn.Column_Name;
                    strFldCaption = strFldName;
                    strFldType = objColumn.Type_Name;
                    if (strFldType == "bigint identity")
                    {
                        strFldType = "bigint";
                    }
                    intFldLength = objColumn.length;
                    intFldPrecision = objColumn.PRECISION;
                    strIsNull = objColumn.Is_Nullable;
                    bolIsNull = strIsNull == "NO" ? false : true;
                    try
                    {
                        string strFldId = clsFieldTabBLEx.ImportFldToFieldTab(strFldName,
                                       strFldCaption,
                                       strFldType,
                                       intFldLength,
                                       intFldPrecision,
                                       bolIsNull,
                                       strPrjId,
                                       strUserId);
                        clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTabId, strFldId, strUserId);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("(ErrId:Web02003)导入数据表(视图)失败--添加表字段列表失败。错误信息：{0}({1})",
                             objException.Message, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }
                }
                try
                {
                    if (strSqlDsTypeId == "02")
                    {
                        string strCondition = string.Format("PrjId='{0}' And {2} in (select {3} from PrjTab Where TabName = '{1}')",
                            strPrjId, strTabName,
                            conSqlView.RelaTabId, conPrjTab.TabId);
                        if (clsSqlViewBL.IsExistRecord(strCondition) == false)
                        {
                            try
                            {
                                clsSqlViewBLEx.ImportSqlViewBySqlViewName(strPrjId, strTabName, strUserId);
                                string strSqlViewId = clsSqlViewBL.GetFirstID_S(strCondition);

                                //导入视图文本从SqlServer
                                clsSqlViewBLEx.ImportSqlViewFromSqlServer(strPrjId, strSqlViewId, strUserId, strPrjDataBaseId);
                                clsSqlViewBLEx.FieldAnalysis(strSqlViewId, strPrjId, strUserId);
                                clsSqlViewBLEx.GeneSqlView(strSqlViewId, strPrjId, strPrjDataBaseId, strUserId);
                            }
                            catch (Exception objException)
                            {
                                string strMsg = string.Format("出错：{0}. 导入表名：{1}", objException.Message, strTabName);
                                //throw new Exception(strMsg);
                            }
                        }
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = "导入数据表(视图)失败--添加工程表失败。" + objException.Message;
                    throw new Exception(strMsg);
                }
                if (bolResult == false)
                {
                    return false;
                }
                //6、在表字段中添加相关字段。
                try
                {
                    //bolResult = clsPrjTabFldBLEx.Add_ObjectFldtoPrjTabFld(strTabId);
                    //根据SQL表信息设置表字段的可空性
                    clsTabCheckStatusBLEx.SetPrjTabFldNullBySQLTab(strTabId, objProjectsEN, objPrjDataBase.PrjDataBaseId, strUserId);

                    //根据SQL表信息关键字设置表字段的关键字段

                    List<clsPKeys> arrPKeysLst = clsSqlObject.GetPKeyObjList(strConnectString, strTabName, objPrjDataBase.DatabaseOwner);

                    foreach (clsPKeys objPKeys in arrPKeysLst)
                    {
                        strFldName = objPKeys.COLUMN_NAME;
                        string strCondition = string.Format("TabId='{0}' And FldName='{1}'", strTabId, strFldName);
                        clsvPrjTabFldEN objvPrjTabFld_Key = clsvPrjTabFldBL.GetFirstObj_S(strCondition);
                        if (objvPrjTabFld_Key != null)
                        {

                            bool bolIsIdentityColumn = clsSqlObject.IsIdentityColumn(strConnectString, strTabName, objPrjDataBase.DatabaseOwner, strFldName);
                            clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN(objvPrjTabFld_Key.mId);
                            objPrjTabFldEN.FieldTypeId = "02";
                            objPrjTabFldEN.PrjId = strPrjId;
                            objPrjTabFldEN.SequenceNumber = intOrderNum++;
                            if (bolIsIdentityColumn == true)
                            {
                                objPrjTabFldEN.PrimaryTypeId = "02";
                            }
                            else
                            {
                                objPrjTabFldEN.PrimaryTypeId = "01";
                            }

                            clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                        }
                    }

                }
                catch (Exception objException)
                {
                    string strMsg = "导入数据表(视图)失败。" + objException.Message;
                    throw new Exception(strMsg);
                }
            }
            return true;


            //操作步骤：
            //1、获取教务管理结构表中的所有记录MId,并对这些记录进行循环：
            //2、针对每条记录：
            //3、添加对象信息，在添加时需要检查是否重复；
            //4、再向该视图对象表中添加相关字段。
            //5、向表中添加该表记录；
            //6、在表字段中添加相关字段。
            ///
        }
        /// <summary>
        /// 获取某表的记录数
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="strCurrPrjDataBaseId">数据库的Id</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool GetTabRecNum(string strTabId, string strPrjDataBaseId)
        {

            clsPrjTabEN objPrjTabEN = null;
            try
            {

                objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
                if (objPrjTabEN.IsReleToSqlTab == false)
                {
                    objPrjTabEN.TabRecNum = -1;
                    objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objPrjTabEN.Update();
                    return true;
                }
                int intRecNum = clsTablesBLEx.GetRecNum4TabName(strPrjDataBaseId, objPrjTabEN.TabName);
                objPrjTabEN.TabRecNum = intRecNum;
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjTabEN.Update();
                return true;
            }
            catch (Exception objException)
            {
                var strMsg0 = string.Format("表:{0}计算表记录数不成功!错误：{1}", objPrjTabEN.TabName, objException.Message);
                throw new Exception(strMsg0);

            }
        }
        /// <summary>
        /// 检查表的扩展字段
        /// </summary>
        /// <param name="strTabId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool CheckTabExtendFld(string strTabId, string strPrjId)
        {
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);

            List<string> arrTabId4MapFunc = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            List<clsPrjTabFldEN> arrPrjTabFld_Sel = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            arrPrjTabFld_Sel = arrPrjTabFld_Sel.Where(x => x.IsForExtendClass == true).ToList();
            List<string> arrDataPropertyName = new List<string>();


            //Graph g1 = clsDataNodeBLEx.InitGraph(this.CmPrjId,);
            foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFld_Sel)
            {
                List<string> arrAddiFldId = new List<string>();
                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == true && objPrjTabFld.FieldTypeId != enumFieldType.DisplayUnit_20) continue;

                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, objPrjTabFld.PrjId);

                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == false)
                {
                    var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFld.DnPathId, strPrjId);
                    if (objDnPath == null) continue;
                    if (objDnPath.PrjId != objPrjTabFld.PrjId)
                    {
                        string strMsg = string.Format("在表:[{0}]中,扩展字段:[{1}]所引用的路径不正确!", objPrjTab.TabName, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }


                    long strOutDataNodeId = objDnPath.OutDataNodeId;
                    List<clsDnFuncMapEN> arrEdge = null;
                    try
                    {
                        arrEdge = clsDnFuncMapBLEx.GetObjLstByDnPath(objDnPath, strPrjId);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = $"转换函数中,表TabId={strTabId}({objPrjTab.TabName}),字段FldId=[{objPrjTabFld.FldId}]==>{8}在获取转换路径时,出错:{objException.Message}。 VersionNo=1,请检查!(In {clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    List<string> arrConstVar = new List<string>();
                    foreach (var objInFor in arrEdge)
                    {
                        if (objInFor == null) continue;
                        
                        var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                        var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                        var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                        var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);                                               

                        if (objInFor.FuncMapModeId != enumFuncMapMode.Table_01) continue;
                        var objPrjTab_Edge = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);

                        if (string.IsNullOrEmpty(objPrjTab_Edge.CacheClassifyFieldTS) == false)
                        {
                            arrAddiFldId.Add(objPrjTab_Edge.CacheClassifyFieldTS);
                        }
                        if (string.IsNullOrEmpty(objPrjTab_Edge.CacheClassifyField2TS) == false)
                        {
                            arrAddiFldId.Add(objPrjTab_Edge.CacheClassifyField2TS);
                        }
                    }
                }

                foreach (var strAddiFldId in arrAddiFldId)
                {
                    if (string.IsNullOrEmpty(strAddiFldId) == true) continue;
                    if (clsPrjTabFldBLEx.IsExistByTabIdAndFldIdCache(strTabId, strAddiFldId, strPrjId) == false)
                    {
                        var objAddiFieldTab = clsFieldTabBL.GetObjByFldIdCache(strAddiFldId, strPrjId);

                        string strMsg = $"表中扩展字段:[{objFieldTab.FldName}({objFieldTab.FldId})]的映射路径需要字段:[{objAddiFieldTab.FldName}({objAddiFieldTab.FldId})].";
                        throw new Exception(strMsg);
                    }
                }
            }
            return true;
        }
    }
}


