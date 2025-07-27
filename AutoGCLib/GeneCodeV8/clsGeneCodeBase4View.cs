using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.sql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{



    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    public abstract partial class clsGeneCodeBase4View : clsGCBase
    {
        public CodeElement objCodeElement_Root = null;
        protected CodeElement objCodeElement_Class = null;
        protected CodeElement objCodeElement_Imports = null;
        private string strTabName_Out4ListRegion;
        private string strTabName_Out4ListRegion4GC;
        private string strTabId_Out4ListRegion;

        private string strTabName_In4Edit;
        private string strTabName_In4Edit4GC;
        private string strTabCnName_In4Edit4GC;

        private string strTabCnName_In4Edit;
        private string strTabId_In4Edit;
        private string strViewMainTabName4GC;
        private string strViewMainTabId4GC;


        private string strTabName_Out4DetailRegion;
        private string strTabName_Out4DetailRegion4GC;
        private string strTabId_Out4DetailRegion;
        private string strTabCnName_Out4Detail;

        private string strTabName_Out4ExportExcel;

        private string strTabName_Out4ExportExcel4GC;
        private string strTabId_Out4ExportExcel;


        private clsPrjTabENEx objPrjTabEx_EditRegion = null;
        private clsPrjTabENEx objPrjTabEx_DetailRegion = null;
        private clsPrjTabENEx objPrjTabEx_ExcelExportRegion = null;
        private clsPrjTabENEx objPrjTabEx_ListRegion = null;

        private clsPrjTabENEx objPrjTabEx_View = null;

        //protected clsPrjTabENEx objPrjTabEx_EditRegion = null;

        
        protected clsPrjTabFldENEx objPrefixField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objPrefixField;
                }
                return mobjPrefixField;
            }
        }

        public TabProp thisDetailTabProp_TS
        {
            get
            {
                if (objDetailTabProp_TS == null)
                {
                    List<string> arrTempMath = new List<string>();
                    List<string> arrTemp = new List<string>();
                    foreach (var objInFor in PrjTabEx_DetailRegion.arrKeyFldSet)
                    {
                        arrTemp.Add(objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    string strTemp = clsArray.GetSqlInStrByArray(arrTemp, false);
                    string strTempMatch = clsArray.GetSqlInStrByArray(arrTempMath, false);
                    TabProp obj = new TabProp
                    {
                        TabId = PrjTabEx_ListRegion.TabId,
                        TabName = PrjTabEx_DetailRegion.TabName,
                        KeyFldCount = PrjTabEx_DetailRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_DetailRegion.KeyFldId(),
                        FldName = PrjTabEx_DetailRegion.KeyFldName(),
                        FldName_FstLCase = clsString.FstLcaseS(PrjTabEx_DetailRegion.KeyFldName()),
                        KeyFldNameLstStr = PrjTabEx_DetailRegion.KeyFldNameLstStr,
                        PropertyNameLstrStr = strTemp,
                        KeyVarDefineLstStr = PrjTabEx_DetailRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_DetailRegion.KeyPrivFuncFldNameLstStr_TS,
                        PropertyNamePrivVarNameLstrStr = strTempMatch,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_DetailRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_DetailRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_EditRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_DetailRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objDetailTabProp_TS = obj;
                }
                return objDetailTabProp_TS;
            }
        }

        public override string thisPrjId
        {
            get
            {

                return objViewInfoENEx.PrjId;
            }
        }

        public TabProp thisViewTabProp_TS
        {
            get
            {
                if (objViewTabProp_TS == null)
                {
                  
                    TabProp obj = new TabProp
                    {
                        TabId = PrjTabEx_ListRegion.TabId,
                        TabName = PrjTabEx_DetailRegion.TabName,
                        KeyFldCount = PrjTabEx_ExcelExportRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_ExcelExportRegion.KeyFldId(),
                        FldName = PrjTabEx_ExcelExportRegion.KeyFldName(),
                        FldName_FstLCase = clsString.FstLcaseS(PrjTabEx_ExcelExportRegion.KeyFldName()),
                        KeyFldNameLstStr = PrjTabEx_ExcelExportRegion.KeyFldNameLstStr,
                        KeyVarDefineLstStr = PrjTabEx_ExcelExportRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_ExcelExportRegion.KeyPrivFuncFldNameLstStr_TS,
                        //PropertyNamePrivVarNameLstrStr = strTempMatch,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_ExcelExportRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_ExcelExportRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_ExcelExportRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_ExcelExportRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objExcelExportTabProp_TS = obj;
                }
                return objExcelExportTabProp_TS;
            }
        }

        public TabProp thisExcelExportTabProp_TS
        {
            get
            {
                if (objExcelExportTabProp_TS == null)
                {
                    List<string> arrTemp = new List<string>();
                    List<string> arrTempMath = new List<string>();

                    foreach (var objInFor in PrjTabEx_ExcelExportRegion.arrKeyFldSet)
                    {
                        string strMatch = $"{objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}:{objInFor.ObjFieldTab().PrivFuncName()}";
                        arrTempMath.Add(strMatch);
                        arrTemp.Add(objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    string strTemp = clsArray.GetSqlInStrByArray(arrTemp, false);
                    string strTempMatch = clsArray.GetSqlInStrByArray(arrTempMath, false);
                    TabProp obj = new TabProp
                    {
                        TabId = PrjTabEx_ListRegion.TabId,
                        TabName = PrjTabEx_DetailRegion.TabName,
                        KeyFldCount = PrjTabEx_DetailRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_ExcelExportRegion.KeyFldId(),
                        FldName = PrjTabEx_ExcelExportRegion.KeyFldName(),
                        FldName_FstLCase = clsString.FstLcaseS(PrjTabEx_DetailRegion.KeyFldName()),
                        KeyFldNameLstStr = PrjTabEx_ExcelExportRegion.KeyFldNameLstStr,
                        KeyVarDefineLstStr = PrjTabEx_ExcelExportRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_ExcelExportRegion.KeyPrivFuncFldNameLstStr_TS,
                        PropertyNamePrivVarNameLstrStr = strTempMatch,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_ExcelExportRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_ExcelExportRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_ExcelExportRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_ExcelExportRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objExcelExportTabProp_TS = obj;
                }
                return objExcelExportTabProp_TS;
            }
        }

        public TabProp thisListTabProp_TS
        {
            get
            {
                if (objListTabProp_TS == null)
                {
                    List<string> arrTemp = new List<string>();
                    List<string> arrTempMath = new List<string>();

                    foreach (var objInFor in PrjTabEx_ListRegion.arrKeyFldSet)
                    {
                        string strMatch = $"{objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}:{objInFor.ObjFieldTab().PrivFuncName()}";
                        arrTempMath.Add(strMatch);
                        arrTemp.Add(objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    string strTemp = clsArray.GetSqlInStrByArray(arrTemp, false);
                    string strTempMatch = clsArray.GetSqlInStrByArray(arrTempMath, false);
                    TabProp obj = new TabProp
                    {
                        TabId = PrjTabEx_ListRegion.TabId,
                        TabName = PrjTabEx_ListRegion.TabName,
                        KeyFldCount = PrjTabEx_ListRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_ListRegion.KeyFldId(),
                        FldName = PrjTabEx_ListRegion.KeyFldName(),
                        FldName_FstLCase = clsString.FstLcaseS(PrjTabEx_ListRegion.KeyFldName()),
                        KeyFldNameLstStr = PrjTabEx_ListRegion.KeyFldNameLstStr,
                        KeyVarDefineLstStr = PrjTabEx_ListRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS,
                        PropertyNamePrivVarNameLstrStr = strTempMatch,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_ListRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_ListRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_ListRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_ListRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objListTabProp_TS = obj;
                }
                return objListTabProp_TS;
            }
        }


        public TabProp thisEditTabProp_TS
        {
            get
            {
                if (objEditTabProp_TS == null)
                {
                    List<string> arrTemp = new List<string>();
                    List<string> arrTempMath = new List<string>();

                    foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                    {
                        string strMatch = $"{objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}:{objInFor.ObjFieldTab().PrivFuncName()}";
                        arrTempMath.Add(strMatch);
                        arrTemp.Add(objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    string strTemp = clsArray.GetSqlInStrByArray(arrTemp, false);
                    string strTempMatch = clsArray.GetSqlInStrByArray(arrTempMath, false);
                    TabProp obj = new TabProp
                    {
                        TabId = PrjTabEx_ListRegion.TabId,
                        TabName = PrjTabEx_EditRegion.TabName,
                        KeyFldCount = PrjTabEx_EditRegion.arrKeyFldSet.Count,
                        FldId = PrjTabEx_EditRegion.KeyFldId(),
                        FldName = PrjTabEx_EditRegion.KeyFldName(),
                        FldName_FstLCase = clsString.FstLcaseS(PrjTabEx_EditRegion.KeyFldName()),
                        KeyFldNameLstStr = PrjTabEx_EditRegion.KeyFldNameLstStr,
                        PropertyNameLstrStr = strTemp,
                        KeyVarDefineLstStr = PrjTabEx_EditRegion.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = PrjTabEx_EditRegion.KeyPrivFuncFldNameLstStr_TS,
                        PropertyNamePrivVarNameLstrStr = strTempMatch,
                        KeyPropNameLstStrWithKeyLst = PrjTabEx_EditRegion.KeyPropNameLstStrWithKeyLst_TS,
                        ByInFuncName = PrjTabEx_EditRegion.arrKeyFldSet.Count == 1 ? PrjTabEx_EditRegion.KeyFldName() : "KeyLst",
                        FuncModuleEnName4GC = PrjTabEx_EditRegion.ObjFuncModule.FuncModuleEnName4GC(),
                    };
                    objEditTabProp_TS = obj;
                }
                return objEditTabProp_TS;
            }
        }


        public CacheClassify thisCacheClassify_List_TS
        {
            get
            {
                if (objCacheClassify_List_TS == null)
                {
                    CacheClassify obj = new CacheClassify();

                    obj.FldId = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld_TS.FldId : "";
                    obj.FldId2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS.FldId : "";
                    obj.FldName = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld_TS.FldName : "";
                    obj.FldName2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS.FldName : "";
                    obj.PriVarName = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.PriVarName2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.TypeScriptType = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.TypeScriptType2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.CsType = PrjTabEx_ListRegion.objCacheClassifyFld != null ? PrjTabEx_ListRegion.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.CsType2 = PrjTabEx_ListRegion.objCacheClassifyFld2 != null ? PrjTabEx_ListRegion.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.DataTypeId = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.DataTypeId2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.FldLength = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.FldLength2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.IsHasCacheClassfyFld = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS == null ? false : true;
                    obj.IsHasCacheClassfyFld2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS == null ? false : true;
                    obj.IsNumberType = PrjTabEx_ListRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld_TS.IsNumberType() : false;
                    obj.IsNumberType2 = PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ListRegion.ObjCacheClassifyFld2_TS.IsNumberType() : false;

                    objCacheClassify_List_TS = obj;
                }
                return objCacheClassify_List_TS;
            }
        }

        public CacheClassify thisCacheClassify_ExportExcel_TS
        {
            get
            {
                if (PrjTabEx_ExcelExportRegion == null) return null;
                if (objCacheClassify_ExportExcel_TS == null)
                {
                    CacheClassify obj = new CacheClassify();

                    obj.FldId = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS.FldId : "";
                    obj.FldId2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS.FldId : "";
                    obj.FldName = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS.FldName : "";
                    obj.FldName2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS.FldName : "";
                    obj.PriVarName = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.PriVarName2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.TypeScriptType = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.TypeScriptType2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.CsType = PrjTabEx_ExcelExportRegion.objCacheClassifyFld != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.CsType2 = PrjTabEx_ExcelExportRegion.objCacheClassifyFld2 != null ? PrjTabEx_ExcelExportRegion.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "";
                    obj.DataTypeId = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.DataTypeId2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.FldLength = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.FldLength2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.IsHasCacheClassfyFld = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS == null ? false : true;
                    obj.IsHasCacheClassfyFld2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS == null ? false : true;
                    obj.IsNumberType = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld_TS.IsNumberType() : false;
                    obj.IsNumberType2 = PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS != null ? PrjTabEx_ExcelExportRegion.ObjCacheClassifyFld2_TS.IsNumberType() : false;

                    objCacheClassify_ExportExcel_TS = obj;
                }
                return objCacheClassify_ExportExcel_TS;
            }
        }

        public CacheClassify4View thisCacheClassify4View
        {
            get
            {
                if (myCacheClassify4View != null) return myCacheClassify4View;
                try
                {
                    CacheClassify4View obj = new CacheClassify4View();

                    obj.FldId = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.FldId : "";
                    obj.FldId2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.FldId : "";
                    obj.FldName = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.FldName : "";
                    obj.FldName2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.FldName : "";
                    obj.VarDef4Fld = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? string.Format("{0}.{1}Cache", ThisClsName, objViewInfoENEx.objCacheClassifyFld4View_TS.FldName) : "";
                    obj.VarDef4Fld2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? string.Format("{0}.{1}Cache", ThisClsName, objViewInfoENEx.objCacheClassifyFld4View2_TS.FldName) : "";

                    obj.PriVarName = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.PriVarName2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.PrivFuncName : "";
                    obj.TypeScriptType = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.TypeScriptType2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "";
                    obj.DataTypeId = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.DataTypeId2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.DataTypeId : "";
                    obj.FldLength = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.FldLength2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.ObjFieldTabENEx.FldLength : 0;
                    obj.IsHasCacheClassfyFld = objViewInfoENEx.objCacheClassifyFld4View_TS == null ? false : true;
                    obj.IsHasCacheClassfyFld2 = objViewInfoENEx.objCacheClassifyFld4View2_TS == null ? false : true;
                    obj.IsNumberType = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.IsNumberType() : false;
                    obj.IsNumberType2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.IsNumberType() : false;
                    obj.IsForExtendClass = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? objViewInfoENEx.objCacheClassifyFld4View_TS.IsForExtendClass : false;
                    obj.IsForExtendClass2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? objViewInfoENEx.objCacheClassifyFld4View2_TS.IsForExtendClass : false;
                    obj.ViewVarName = objViewInfoENEx.objCacheClassifyFld4View_TS != null ? clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(obj.IsHasCacheClassfyFld,
                        objViewInfoENEx.ViewId, obj.FldId, objViewInfoENEx.PrjId) : "";
                    obj.ViewVarName2 = objViewInfoENEx.objCacheClassifyFld4View2_TS != null ? clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(obj.IsHasCacheClassfyFld2,
                                            objViewInfoENEx.ViewId, obj.FldId2, objViewInfoENEx.PrjId) : "";

                    myCacheClassify4View = obj;
                    return myCacheClassify4View;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                    //return null;
                }

            }
        }

        //public clsPrjTabFldENEx thisCacheClassifyFld4View
        //{
        //    get
        //    {
        //        if (thisCacheClassify4View.IsHasCacheClassfyFld == true) return objViewInfoENEx.objCacheClassifyFld4View_TS;
        //        return null;
        //    }

        //}
        //public clsPrjTabFldENEx thisCacheClassifyFld4View2
        //{
        //    get
        //    {
        //        if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true) return objViewInfoENEx.objCacheClassifyFld4View2_TS;
        //        return null;
        //    }
        //}

        public clsPrjTabENEx PrjTabEx_ExcelExportRegion
        {
            get
            {
                if (objPrjTabEx_ExcelExportRegion != null) return objPrjTabEx_ExcelExportRegion;
                if (objViewInfoENEx.objViewRegion_ExportExcel != null)
                {
                    var objPrjTab_ExcelExportRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_ExcelExportRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ExcelExportRegion);
                    objPrjTabEx_ExcelExportRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_ExcelExportRegion;
            }
        }
        public clsPrjTabENEx PrjTabEx_ListRegion
        {
            get
            {
                if (objPrjTabEx_ListRegion != null) return objPrjTabEx_ListRegion;
                if (objViewInfoENEx.objViewRegion_List != null)
                {
                    var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
                    objPrjTabEx_ListRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_ListRegion;
            }
        }


        public clsPrjTabENEx PrjTabEx_DetailRegion
        {
            get
            {
                if (objPrjTabEx_DetailRegion != null) return objPrjTabEx_DetailRegion;
                if (objViewInfoENEx.objViewRegion_Detail != null)
                {
                    var objPrjTab_DetailRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_DetailRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_DetailRegion);
                    objPrjTabEx_DetailRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_DetailRegion;
            }
        }

        public clsPrjTabENEx PrjTabEx_View
        {
            get
            {
                if (objPrjTabEx_View != null) return objPrjTabEx_View;
                if (objViewInfoENEx.MainTabId != null)
                {
                    var objPrjTab_View = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                    objPrjTabEx_View = clsPrjTabBLEx.CopyToEx(objPrjTab_View);
                    objPrjTabEx_View.GetObjAllInfoEx();
                }
                return objPrjTabEx_View;
            }
        }

        public clsPrjTabENEx PrjTabEx_EditRegion
        {
            get
            {
                if (objPrjTabEx_EditRegion != null) return objPrjTabEx_EditRegion;
                if (objViewInfoENEx.objViewRegion_Edit != null)
                {

                    var objPrjTab_EditRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);

                    objPrjTabEx_EditRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_EditRegion);
                    objPrjTabEx_EditRegion.GetObjAllInfoEx();
                }
                if (objPrjTabEx_EditRegion == null && TabId_In4Edit.Length>0)
                {
                    var objPrjTab_EditRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_In4Edit, objViewInfoENEx.PrjId);

                    objPrjTabEx_EditRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_EditRegion);
                    objPrjTabEx_EditRegion.GetObjAllInfoEx();
                }
                return objPrjTabEx_EditRegion;
            }
        }
        public string ThisClsName
        {
            get
            {
                return objViewInfoENEx.ClsName;
            }
        }
        public string ThisBaseClsName
        {
            get
            {
                string str = objViewInfoENEx.ClsName;

                if (str.EndsWith("Ex"))
                {
                    str = str.Substring(0, str.Length - 2);
                }
                return str;
            }
        }


        public string ThisEditClsName
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                return objViewInfoENEx.objViewRegion_Edit.ClsName;
            }
        }
        public string ThisDetailClsName
        {
            get
            {
                return objViewInfoENEx.objViewRegion_Detail.ClsName;
            }
        }

        public string ThisListClsName
        {
            get
            {
                return objViewInfoENEx.objViewRegion_List.ClsName;
            }
        }

        public bool IsHasDetailRegion
        {
            get
            {
                clsViewRegionEN objViewRegion_Detail = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
                if (objViewRegion_Detail != null && objViewRegion_Detail.InUseInViewInfo(objViewInfoENEx) == true) return true;
                else return false;
            }
        }
        public bool IsHasListRegion
        {
            get
            {
                clsViewRegionEN objViewRegion_List = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
                if (objViewRegion_List != null && objViewRegion_List.InUseInViewInfo(objViewInfoENEx) == true) return true;
                else return false;
            }
        }
        public bool IsHasEditRegion
        {
            get
            {
                clsViewRegionEN objViewRegion_Edit = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
                if (objViewRegion_Edit != null && objViewRegion_Edit.InUseInViewInfo(objViewInfoENEx) == true) return true;
                else return false;
            }
        }
        public string TabName_Out4ExportExcel
        {
            get
            {
                if (strTabName_Out4ExportExcel == null)
                {
                    strTabName_Out4ExportExcel = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);

                }
                return strTabName_Out4ExportExcel;
            }
        }
        public string TabName_Out4ExportExcel4GC
        {
            get
            {
                if (strTabName_Out4ExportExcel4GC == null)
                {
                    strTabName_Out4ExportExcel4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);

                }
                return strTabName_Out4ExportExcel4GC;
            }
        }
        public string TabId_Out4ExportExcel
        {
            get
            {
                if (strTabId_Out4ExportExcel == null)
                {
                    strTabId_Out4ExportExcel = objViewInfoENEx.objViewRegion_ExportExcel.TabId;
                }
                return strTabId_Out4ExportExcel;
            }
        }
        public string tabNameHead
        {
            get
            {
                if (strTabNameHead == null)
                {
                    strTabNameHead = string.Format("{0}_", this.PrjTabEx_EditRegion.TabName);
                }
                return strTabNameHead;

            }
        }

        public string TabName_In4Edit4GC
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                if (strTabName_In4Edit4GC == null)
                {
                    strTabName_In4Edit4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_In4Edit4GC;
            }
        }
        public string TabCnName_In4Edit4GC
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                if (strTabCnName_In4Edit4GC == null)
                {
                    strTabCnName_In4Edit4GC = clsPrjTabBLEx.GetTabCnNameByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);
                }
                return strTabCnName_In4Edit4GC;
            }
        }
        public string TabName_In4Edit
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                if (strTabName_In4Edit == null)
                {
                    strTabName_In4Edit = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_In4Edit;
            }
        }
        public string TabCnName_In4Edit
        {
            get
            {
                if (strTabCnName_In4Edit == null)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);

                    strTabCnName_In4Edit = objPrjTab.TabCnName;
                }
                return strTabCnName_In4Edit;
            }
        }
        public string TabCnName_Out4Detail
        {
            get
            {
                if (strTabCnName_Out4Detail == null)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);

                    strTabCnName_Out4Detail = objPrjTab.TabCnName;
                }
                return strTabCnName_Out4Detail;
            }
        }
        public string TabId_In4Edit
        {
            get
            {
                if (objViewInfoENEx.objViewRegion_Edit == null) return "";
                if (strTabId_In4Edit == null)
                {
                    strTabId_In4Edit = objViewInfoENEx.objViewRegion_Edit.TabId;
                }
                return strTabId_In4Edit;
            }
        }
        public string ViewMainTabName4GC
        {
            get
            {
                if (strViewMainTabName4GC == null)
                {
                    strViewMainTabName4GC = objViewInfoENEx.TabName;
                }
                return strViewMainTabName4GC;
            }
        }

        public string ViewMainTabId4GC
        {
            get
            {
                if (strViewMainTabId4GC == null)
                {
                    strViewMainTabId4GC = objViewInfoENEx.MainTabId;
                }
                return strViewMainTabId4GC;
            }
        }

        public string TabName_Out4ListRegion
        {
            get
            {
                if (strTabName_Out4ListRegion == null)
                {
                    if (objViewInfoENEx.objViewRegion_List == null) return "";
                    strTabName_Out4ListRegion = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4ListRegion;
            }
        }
        public string TabName_Out4ListRegion4GC
        {
            get
            {
                if (strTabName_Out4ListRegion4GC == null)
                {
                    if (objViewInfoENEx.objViewRegion_List == null) return "";
                    strTabName_Out4ListRegion4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4ListRegion4GC;
            }
        }
        public string TabId_Out4ListRegion
        {
            get
            {
                if (strTabId_Out4ListRegion == null)
                {
                    if (objViewInfoENEx.objViewRegion_List == null) return "";
                    strTabId_Out4ListRegion = objViewInfoENEx.objViewRegion_List.TabId;
                }
                return strTabId_Out4ListRegion;
            }
        }
        public string TabName_Out4DetailRegion4GC
        {
            get
            {
                if (strTabName_Out4DetailRegion4GC == null)
                {
                    strTabName_Out4DetailRegion4GC = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4DetailRegion4GC;
            }
        }



        public bool IsUseFunc
        {
            get
            {
                bool bolIsUseFunc0 = false;
                if (strIsUseFunc == null)
                {
                    if (objViewInfoENEx.arrDGRegionFldSet != null && objViewInfoENEx.arrDGRegionFldSet.Where(x => x.IsUseFunc() == true).Count() > 0)
                    {
                        bolIsUseFunc0 = true;
                        strIsUseFunc = "true";
                    }
                    else
                    {
                        bolIsUseFunc0 = false;
                        strIsUseFunc = "false";
                    }
                }
                else
                {
                    bolIsUseFunc0 = bool.Parse(strIsUseFunc);
                }
                return bolIsUseFunc0;
            }
        }
        public bool IsUseFunc4ExcelExport
        {
            get
            {
                bool bolIsUseFunc4ExcelExport = false;
                if (strIsUseFunc4ExcelExport == null)
                {
                    if (objViewInfoENEx.arrExcelExportRegionFldSet == null)
                    {
                        bolIsUseFunc4ExcelExport = false;
                        strIsUseFunc4ExcelExport = "false";
                        return bolIsUseFunc4ExcelExport;
                    }
                    if (objViewInfoENEx.arrExcelExportRegionFldSet.Where(x => x.IsUseFunc() == true).Count() > 0)
                    {
                        bolIsUseFunc4ExcelExport = true;
                        strIsUseFunc4ExcelExport = "true";
                    }
                    else
                    {
                        bolIsUseFunc4ExcelExport = false;
                        strIsUseFunc4ExcelExport = "false";
                    }
                }
                else
                {
                    bolIsUseFunc4ExcelExport = bool.Parse(strIsUseFunc4ExcelExport);
                }
                return bolIsUseFunc4ExcelExport;
            }
        }


        public string TabName_Out4DetailRegion
        {
            get
            {
                if (strTabName_Out4DetailRegion == null)
                {
                    strTabName_Out4DetailRegion = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
                }
                return strTabName_Out4DetailRegion;
            }
        }
        public string TabId_Out4DetailRegion
        {
            get
            {
                if (strTabId_Out4DetailRegion == null)
                {
                    strTabId_Out4DetailRegion = objViewInfoENEx.objViewRegion_Detail.TabId;
                }
                return strTabId_Out4DetailRegion;
            }
        }


        /// <summary>
        /// 关键字段对象
        /// </summary>
        protected clsPrjTabFldENEx objKeyField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainTabKeyField;
                }
                return mobjKeyField;
            }
            set
            {
                mobjKeyField = value;
            }
        }

        public string PrjId
        {
            get
            {
                return objViewInfoENEx.PrjId;

            }
        }
        public string ViewId
        {
            get
            {
                return objViewInfoENEx.ViewId;

            }
        }

        public string ViewName
        {
            get
            {
                return objViewInfoENEx.ViewName;

            }
        }
        /// <summary>
        /// 关键字段的字段名
        /// </summary>
        protected string FldName4Key
        {
            get
            {
                return objKeyField.FldName;
            }
        }
        protected string IsShareStr
        {
            get
            {
                string strIsShare = "";
                if (objViewInfoENEx.IsShare) strIsShare = "Share";
                return strIsShare;
            }
        }


        /// <summary>
        /// 序号字段对象
        /// </summary>
        public clsPrjTabFldENEx objOrderNumField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainOrderNumField;
                }
                return mobjOrderNumField;
            }
            set => mobjOrderNumField = value;
        }

        /// <summary>
        /// 默认排序字段对象
        /// </summary>
        public clsFieldTabENEx objSortField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objSortField_Out;
                }
                return mobjSortField;
            }
            set => mobjSortField = value;
        }


        /// <summary>
        /// 删除标志字段对象
        /// </summary>
        public clsPrjTabFldENEx objDelSignField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainDelSignField;
                }
                return mobjDelSignField;
            }
            set => mobjDelSignField = value;
        }
        
        /// <summary>
        /// 名称字段对象
        /// </summary>
        public clsPrjTabFldENEx objNameField
        {
            get
            {
                if (objViewInfoENEx != null)
                {
                    return objViewInfoENEx.objMainNameField;
                }
                return mobjNameField;
            }
            set => mobjNameField = value;
        }


        public clsPrjTabEN objMainPrjTab
        {
            get
            {
                return objViewInfoENEx.objMainPrjTab;
            }
        }

        public clsProjectsENEx objProjectsENEx
        {
            get
            {
                if (mobjProjectsENEx == null)
                {
                    if (objViewInfoENEx != null)
                    {
                        mobjProjectsENEx = objViewInfoENEx.objProjectsEN.CopyToEx();
                        return mobjProjectsENEx;
                    }
                    return null;
                }
                else
                {
                    return mobjProjectsENEx;
                }
            }
            set => mobjProjectsENEx = value;
        }

        public string CurrUserName
        {
            set
            {
                if (mobjViewInfoENEx != null)
                {
                    mobjViewInfoENEx.CurrUserName = value;
                }
            }

        }


        private clsViewInfoENEx mobjViewInfoENEx = null;


        private string mstrWebSrvClassId = "";

        #region 构造函数

        public clsGeneCodeBase4View()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            arrJsFunction = new List<JsFunction>();
            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();
        }
        public clsGeneCodeBase4View(string strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            arrJsFunction = new List<JsFunction>();
            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();
        }
        public clsGeneCodeBase4View(string strViewId, string strPrjDataBaseId, string strPrjId)
        {
            arrJsFunction = new List<JsFunction>();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            // 
            // TODO: 在此处添加构造函数逻辑
            //

            arrDdlKeyIdLst = new List<string>();
            GetPrjViewInfo(strViewId, strPrjDataBaseId, strPrjId);
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyFieldTS).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View_TS = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyFieldTS).First();
                if (objViewInfoENEx.objMainPrjTab.CacheModeId != enumCacheMode.localStorage_03 && objViewInfoENEx.objMainPrjTab.CacheModeId != enumCacheMode.sessionStorage_04)
                {
                    objViewInfoENEx.objCacheClassifyFld4View_TS = null;
                }
            }
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField2TS).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View2_TS = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField2TS).First();
            }


            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();

        }

        


        public bool GetPrjViewInfo(string strViewId, string strPrjDataBaseId, string strPrjId)
        {
            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            try
            {
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, this.IsFstLcase, strPrjId);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            this.objViewInfoENEx = objViewInfoENEx;

            if (string.IsNullOrEmpty(strPrjDataBaseId) == false)
            {
                objViewInfoENEx.PrjDataBaseId = strPrjDataBaseId;
            }

            //objViewInfoENEx.LangType = ltLangType;
            //objViewInfoENEx.CodeTypeId = clsCodeTypeBLEx.GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);

            //this.mobjKeyField = objPrjTabENEx.objKeyField0;
            this.GetClsName();
            return true;
        }


        #endregion

        //public string FileName
        //{
        //    get
        //    {
        //        return objPrjTabENEx.FileName;
        //    }
        //    set
        //    {
        //        objPrjTabENEx.FileName = value;
        //    }
        //}
        //public bool IsHaveImageField
        //{
        //    get
        //    {
        //        return objPrjTabENEx.IsHaveImageField; // '文件目录名
        //    }
        //    set
        //    {
        //        objPrjTabENEx.IsHaveImageField = value;
        //    }
        //}

        //public string ImageFieldName
        //{
        //    get
        //    {
        //        return objPrjTabENEx.ImageFieldName; // '文件目录名
        //    }
        //    set
        //    {
        //        objPrjTabENEx.ImageFieldName = value;
        //    }
        //}

        //public string FolderName
        //{
        //    get
        //    {
        //        return objPrjTabENEx.FolderName; // '文件目录名
        //    }
        //    set
        //    {
        //        objPrjTabENEx.FolderName = value;
        //    }
        //}
        //public string GetCodeTabName(string strTabId)
        //{
        //    return clsPrjTabBL.GetTabNameByTabIdCache(strTabId);
        //}

        public clsViewInfoENEx objViewInfoENEx { get => mobjViewInfoENEx; set => mobjViewInfoENEx = value; }

        public string GenDdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse
                    .Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj
                    = arrERF4DropDownLst.Select(GetDdlObj2);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    //strCodeForCs.Append("\r\n" + objInfor.GC_BindDdlFunc());

                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Controller_Java_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "fill_parent";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + " <Button android:id=\"@+id/btn{0}\"", 
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            //strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.AppendFormat("\r\n" + "android:onClick = \"btn{0}_Click\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            //strCodeForCs.Append("\r\n" + "        />");            

            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            AndroidButtonEx objAndroidButtonENEx = new AndroidButtonEx();
            objAndroidButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objAndroidButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objAndroidButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objAndroidButtonENEx.layout_width = "fill_parent";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";

            //objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            //objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objAndroidButtonENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + " <Button android:id=\"@+id/btn{0}\"", 
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "        android:layout_width=\"fill_parent\"");
            //strCodeForCs.Append("\r\n" + "        android:layout_height=\"wrap_content\"");
            //strCodeForCs.AppendFormat("\r\n" + "        android:text=\"{0}\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.AppendFormat("\r\n" + "android:onClick = \"btn{0}_Click\"",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strCodeForCs.Append("\r\n" + "android:textSize=\"12sp\"");
            //strCodeForCs.Append("\r\n" + "android:minHeight=\"35dp\"");
            //strCodeForCs.Append("\r\n" + "        />");            

            return strCodeForCs.ToString();
        }


        public clsEditRegionFldsENEx getEditRegionKeyFld()
        {
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.FldName
                     == objKeyField.ObjFieldTabENEx.FldName)
                {
                    return objEditRegionFldsEx;
                }
            }
            return null;
        }

        public string GetClsNameByRegionTypeId(string strRegionTypeId)
        {
            clsViewRegionENEx obj = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == strRegionTypeId);
            if (obj != null && string.IsNullOrEmpty(obj.ClsName) == false)
            {
                return string.Format("{0}", obj.ClsName);
            }
            else
            {
                return "类名不存在,请计算国界面区域的类名或者联系管理员!";
            }
        }
        public bool IsNumberType4Key
        {
            get
            {
                return clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN);
            }
        }

        public string KeyFldName
        {
            get
            {
                return objKeyField.FldName;
            }
        }
        public override void GetClsName()
        {
            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }


        public static clsGeneCodeBase4View GetClassByName(string strClassName)
        {
            Type expType = Type.GetType(strClassName);
            if (expType == null)
            {
                string strMsg = string.Format("类型:{0}不存在,请检查!", strClassName);
                throw new Exception(strMsg);
            }
            //使用Type对象也可以实例化一个对象同样调用上面方法
            clsGeneCodeBase4View objGeneCodeBase = (clsGeneCodeBase4View)Activator.CreateInstance(expType);
            return objGeneCodeBase;
        }


        public static clsGeneCodeBase4View GetClassByName(string strClassName, string strViewId, string strPrjDataBaseId, string strPrjId)
        {
            Type expType = Type.GetType(strClassName);
            if (expType == null)
            {
                string strMsg = string.Format("类型:{0}不存在,请检查!", strClassName);
                throw new Exception(strMsg);
            }
            //使用Type对象也可以实例化一个对象同样调用上面方法
            clsGeneCodeBase4View objGeneCodeBase = null;
            try
            {
                objGeneCodeBase = (clsGeneCodeBase4View)Activator.CreateInstance(expType, strViewId, strPrjDataBaseId, strPrjId);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return objGeneCodeBase;
        }

    }
}
