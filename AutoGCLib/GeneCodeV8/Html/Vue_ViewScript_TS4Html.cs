using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Drawing.Printing;
using System.Web.UI.WebControls;
using Agc.PureClass;
using System.Reflection.Emit;
using Microsoft.SqlServer.Server;
using System.Data.Common;
using CodeStruct;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// </summary>
    partial class Vue_ViewScript_TS4Html : clsGeneCodeBase4View
    {
        private CodeElement objCodeElement_Methods = null;
        
        private List<string> arrFuncName_Setup = new List<string>();
        private List<string> arrFuncName_Import = new List<string>();

        List<string> arrTabName4GC_DefVar4Ddl = null;// new List<string>();
        protected bool bolIsUseFunc4Detail = false;
        //private string strTabName_Out4ListRegion = "";
        //private string strTabId_Out4ListRegion = "";
        private string strJSPath = "";
        private clsFuncModule_AgcEN objFuncModule = null;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        protected string strFuncName4BindGv = "";
        #region 构造函数
        public Vue_ViewScript_TS4Html()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_TS4Html(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_TS4Html(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///控件焦点序号
            intCurrLeft = 10;  ///控件的左边空;
            intCurrTop = 10;
        }

        #endregion







        public string Gen_setup_fun_ts_BindTabByList()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * 通过List组件来绑定表数据");
            //生成与条件参数的函数说明            
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + "BindTabByList = async(");
            strCodeForCs.Append("\r\n" + $"arrObjLst: Array<cls{TabName_Out4ListRegion}ENEx>,");
            strCodeForCs.Append("\r\n" + "bolIsShowErrMsg: boolean,");
            strCodeForCs.Append("\r\n" + "): Promise<void> => {");
            strCodeForCs.Append("\r\n" + $"dataList{TabName_Out4ListRegion}.value = arrObjLst;");
            strCodeForCs.Append("\r\n" + "showErrorMessage.value = bolIsShowErrMsg;");
            strCodeForCs.Append("\r\n" + "};");
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_setup_GetDdlDataBak(CodeElement objCodeElement_Parent)
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            if (arrTabName4GC_DefVar4Ddl == null) arrTabName4GC_DefVar4Ddl = new List<string>();
            try
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTabName4GC_DefVar4Ddl.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC_DefVar4Ddl.Add(objTabFeature4Ddl.TabName4GC);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]>([]);");
                }
                arrTabName4GC_DefVar4Ddl.RemoveRange(0, arrTabName4GC_DefVar4Ddl.Count);
                //针对每一个表功能--下拉框
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTabName4GC_DefVar4Ddl.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC_DefVar4Ddl.Add(objTabFeature4Ddl.TabName4GC);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    List<string> arrCondFldId = objTabFeature4Ddl.GetCondFldIdLst();
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature4Ddl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    CacheClassify objCacheClassify_TS = null;
                    clsPrjTabENEx objPrjTabENEx_Ddl = null;
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.TabId) == false)
                    {
                        objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                        objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                        //objFuncParaLst.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                        //objFuncParaLstAll.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                        objFuncParaLst.AddParaByTabFeature(objTabFeature4Ddl, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                        objFuncParaLst.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);
                    }


                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();


                    //第0步:把控件中下拉框ComboBox转换成ComboBox
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }


                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * 获取绑定下拉框的数据");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:需要绑定当前表的下拉框");
                    //生成与条件参数的函数说明
                    strCodeForCs.Append("\r\n" + objTabFeature4Ddl.FuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"async function getArr{objTabFeature4Ddl.TabName4GC}({strFuncPara})");
                    //strCodeForCs.Append("\r\n" + $"async function getArr{objTabFeature4Ddl.TabName4GC}()");
                    strCodeForCs.Append("\r\n" + "{");

                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                    {
                        string strConditionStr = objTabFeature4Ddl.ConditionStr;
                        strCodeForCs.Append("\r\n" + strConditionStr);
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst2} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstAsync(strCondition);");
                    }
                    else
                    {
                        if (objCacheClassify_TS.IsHasCacheClassfyFld == false)
                        {
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache();");
                        }
                        else if (objCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                        {
                            string strPrivFuncName = objCacheClassify_TS.PriVarName;
                            arrCacheFldName.Add(objCacheClassify_TS.FldName);
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache({strPrivFuncName});");

                        }
                        else
                        {
                            string strPrivFuncName = objCacheClassify_TS.PriVarName;
                            string strPrivFuncName2 = objCacheClassify_TS.PriVarName2;
                            arrCacheFldName.Add(objCacheClassify_TS.FldName);
                            arrCacheFldName.Add(objCacheClassify_TS.FldName2);

                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache({objCacheClassify_TS.PriVarName}, {objCacheClassify_TS.PriVarName2});");

                        }
                    }
                    strCodeForCs.Append("\r\n" + "if (arrObjLstSel == null) return;");
                    if (objTabFeature4Ddl.IsForExtendClassFld == true)
                    {
                        //                        strCodeForCs.Append("\r\n" + $"let arrObjExLstSel = arrObjLstSel.map({objTabFeature4Ddl.TabName4GC}{strIsExtendedClassFld}_CopyToEx);");
                        strCodeForCs.Append("\r\n" + $"let arrObjExLstSel = arrObjLstSel.map({objTabFeature4Ddl.TabName4GC}{strIsExtendedClassFld}_CopyToEx);");
                        ImportClass objImportClass = AddImportClass(objTabFeature4Ddl.TabId, objTabFeature4Ddl.TabName4GC + "Ex", "CopyToEx", enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                        

                    }
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.value.length = 0;");
                    strCodeForCs.Append("\r\n" + $"const obj0 = new cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}();");
                    if (objQryRegionFld.IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = '0';");
                    }
                    string strToolTipText = $"{objTabFeature4Ddl.ToolTipText ?? ""}...".Replace("......", "...");
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ToolTipText) == true)
                    {
                        strToolTipText = $"选{clsString.FstLcaseS(objTabFeature4Ddl.TabCnName4GC)}...";
                    }

                    strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.TextFieldName)} = '{objTabFeature4Ddl.ToolTipText}';");

                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.value.push(obj0);");
                    //生成过滤条件语句
                    //string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == true)
                    {
                        strCodeForCs.Append(objTabFeature4Ddl.FilterCondition);
                    }
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.SortStr) == false)
                    {
                        strCodeForCs.Append("\r\n" + $"arrObj{strIsExtendedClassFld}LstSel = arrObj{strIsExtendedClassFld}LstSel.sort({objTabFeature4Ddl.SortStr});");
                    }

                    strCodeForCs.Append("\r\n" + $"arrObj{strIsExtendedClassFld}LstSel.forEach(x => arr{objTabFeature4Ddl.TabName4GC}.value.push(x));");
                    if (objQryRegionFld.IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + $"{objQryRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q.value = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"{objQryRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q.value = '0';");
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }

            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成获取下拉框数据:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_DefineDdlDataVarName(CodeElement objCodeElement_Parent)
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            if (arrTabName4GC_DefVar4Ddl == null) arrTabName4GC_DefVar4Ddl = new List<string>();
            try
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_06 &&
    objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_Bool_18) continue;
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTabName4GC_DefVar4Ddl.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC_DefVar4Ddl.Add(objTabFeature4Ddl.TabName4GC);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strFuncName = $"arr{objTabFeature4Ddl.TabName4GC}";
                    StringBuilder sbConstContent = new StringBuilder();
                    sbConstContent.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]|null>([]);");
                    strCodeForCs.Append(sbConstContent.ToString());
                    objCodeElement_Parent.Children.Add(new CodeElement
                    {
                        Name = strFuncName,
                        CodeContent = sbConstContent.ToString(),
                        ElementType = CodeElementType.RefConstant,
                        Modifiers = "export const"
                    });

                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成获取下拉框数据:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_GetDdlData4FeatureRegionBak()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                foreach (var objViewFeatureFlds in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (string.IsNullOrEmpty(objViewFeatureFlds.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objViewFeatureFlds.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]>([]);");
                }
                //针对每一个表功能--下拉框
                foreach (var objViewFeatureFlds in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (string.IsNullOrEmpty(objViewFeatureFlds.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objViewFeatureFlds.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);

                    List<string> arrCondFldId = objTabFeature4Ddl.GetCondFldIdLst();
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature4Ddl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    CacheClassify objCacheClassify_TS = null;
                    clsPrjTabENEx objPrjTabENEx_Ddl = null;
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.TabId) == false)
                    {
                        objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                        objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                        //objFuncParaLst.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                        //objFuncParaLstAll.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
                        objFuncParaLst.AddParaByTabFeature(objTabFeature4Ddl, arrFieldLst_Cond, enumProgLangType.TypeScript_09);
                        objFuncParaLst.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);
                    }


                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para();


                    //第0步:把控件中下拉框ComboBox转换成ComboBox
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }


                    strCodeForCs.Append("\r\n/**");
                    strCodeForCs.Append("\r\n * 获取绑定下拉框的数据");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:需要绑定当前表的下拉框");
                    //生成与条件参数的函数说明
                    strCodeForCs.Append("\r\n" + objTabFeature4Ddl.FuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"async function getArr{objTabFeature4Ddl.TabName4GC}({strFuncPara})");
                    //strCodeForCs.Append("\r\n" + $"async function getArr{objTabFeature4Ddl.TabName4GC}()");
                    strCodeForCs.Append("\r\n" + "{");

                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                    {
                        string strConditionStr = objTabFeature4Ddl.ConditionStr;
                        strCodeForCs.Append("\r\n" + strConditionStr);
                        strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst2} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstAsync(strCondition);");
                    }
                    else
                    {
                        if (objCacheClassify_TS.IsHasCacheClassfyFld == false)
                        {
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache();");
                        }
                        else if (objCacheClassify_TS.IsHasCacheClassfyFld2 == false)
                        {
                            string strPrivFuncName = objCacheClassify_TS.PriVarName;
                            arrCacheFldName.Add(objCacheClassify_TS.FldName);
                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache({strPrivFuncName});");

                        }
                        else
                        {
                            string strPrivFuncName = objCacheClassify_TS.PriVarName;
                            string strPrivFuncName2 = objCacheClassify_TS.PriVarName2;
                            arrCacheFldName.Add(objCacheClassify_TS.FldName);
                            arrCacheFldName.Add(objCacheClassify_TS.FldName2);

                            strCodeForCs.Append("\r\n" + $"{objTabFeature4Ddl.LetOrConst} arrObjLstSel = await {objTabFeature4Ddl.TabName4GC}_GetObjLstCache({objCacheClassify_TS.PriVarName}, {objCacheClassify_TS.PriVarName2});");

                        }
                    }
                    strCodeForCs.Append("\r\n" + "if (arrObjLstSel == null) return;");
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.value.length = 0;");
                    strCodeForCs.Append("\r\n" + $"const obj0 = new cls{objTabFeature4Ddl.TabName4GC}EN();");
                    strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.ValueFieldName)} = '0';");
                    string strToolTipText = $"{objTabFeature4Ddl.ToolTipText ?? ""}...".Replace("......", "...");
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ToolTipText) == true)
                    {
                        strToolTipText = $"选{clsString.FstLcaseS(objTabFeature4Ddl.TabCnName4GC)}...";
                    }
                    strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.TextFieldName)} = '{strToolTipText}';");


                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC}.value.push(obj0);");
                    //生成过滤条件语句
                    //string strFilterCondition = objFuncParaLst.GeneFilterCondition();
                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == true)
                    {
                        strCodeForCs.Append(objTabFeature4Ddl.FilterCondition);
                    }
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.SortStr) == false)
                    {
                        strCodeForCs.Append("\r\n" + $"arrObjLstSel = arrObjLstSel.sort({objTabFeature4Ddl.SortStr});");
                    }

                    strCodeForCs.Append("\r\n" + $"arrObjLstSel.forEach(x => arr{objTabFeature4Ddl.TabName4GC}.value.push(x));");
                    strCodeForCs.Append("\r\n" + $"{objViewFeatureFlds.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)}_f.value = '0';");
                    strCodeForCs.Append("\r\n" + "}");
                }

            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成获取下拉框数据:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_setup_DefineDdlDataVarName4FeatureRegion(CodeElement objCodeElement_Parent)
        {
            List<string> arrCacheFldName = new List<string>();
            if (arrTabName4GC_DefVar4Ddl == null) arrTabName4GC_DefVar4Ddl = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                foreach (var objViewFeatureFlds in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (string.IsNullOrEmpty(objViewFeatureFlds.TabFeatureId4Ddl)) continue;

                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objViewFeatureFlds.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTabName4GC_DefVar4Ddl.Contains(objTabFeature4Ddl.TabName4GC)) continue;
                    arrTabName4GC_DefVar4Ddl.Add(objTabFeature4Ddl.TabName4GC);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";

                    strFuncName = $"arr{objTabFeature4Ddl.TabName4GC}";
                    StringBuilder sbConstContent = new StringBuilder();
                    sbConstContent.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}[]|null>([]);");

                    strCodeForCs.Append(sbConstContent.ToString());
                    objCodeElement_Parent.Children.Add(new CodeElement
                    {
                        Name = strFuncName,
                        CodeContent = sbConstContent.ToString(),
                        ElementType = CodeElementType.RefConstant,
                        Modifiers = "export const"
                    });

                }

            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成获取下拉框数据:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = $('#txt{1}{2}').val();",
                                objDataTypeAbbrEN.TypeScriptType,
                                objFuncPara4CodeEN.ParaName,
                                objvFunction4GeneCodeEN.OrderNum);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                case enumDataTypeAbbr.int_09:
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.TypeScriptType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //if (objSelfDefDataTypeEN_Para != null)
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objSelfDefDataTypeEN_Para.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //else
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objDataTypeAbbrEN.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }

        }


        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = $(\"#{2}\").val();",
            objViewInfoENEx.TabName,
            objEditRegionFldsEx.FldName,
            objEditRegionFldsEx.CtrlId);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(pobj{1}EN.{2});",
                        objEditRegionFldsEx.CtrlId,
                        objViewInfoENEx.TabName,
                        objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.objCodeElement_Root = new CodeElement { Name = "Root", ElementType = CodeElementType.Root };
            this.objCodeElement_Imports = new CodeElement { Name = "imports", ElementType = CodeElementType.Import, Modifiers = "export abstract" };
            string strFuncName = "";
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse != null && objViewInfoENEx.arrDetailRegionFldSet4InUse.Where(x => x.IsUseFunc() == true).Count() > 0)
            {
                this.bolIsUseFunc4Detail = true;
            }
            clsViewRegionEN objViewRegion_Edit = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.vue",
                objViewInfoENEx.FolderName, ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objViewInfoENEx);

            if (this.IsUseFunc)
            {
                strFuncName4BindGv = string.Format("BindGv_{0}4Func", TabName_Out4ListRegion4GC);
            }
            else
            {
                if (PrjTabEx_ListRegion.IsUseStorageCache_TS())
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}Cache", TabName_Out4ListRegion4GC);
                }
                else
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}", TabName_Out4ListRegion4GC);
                }
            }

            try
            {
                //获取界面所需要的公共变量

                if (string.IsNullOrEmpty(this.TabId_Out4ListRegion) == false) this.GetViewPubVarLst(this.TabId_Out4ListRegion);
                strCodeForCs.Append("\r\n" + Gen_CRUD_Template_DefDiv4CRUD(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_CRUD_Script_DefDiv4CRUD(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_CRUD_Style_DefDiv4CRUD(objCodeElement_Root));
                

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
        public string GenFeatureRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            //foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            //{
            //    if (objDGRegionFldsEx.IsNeedSort)
            //    {
            //        //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
            //    }
            //}
            try
            {


                ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                objASPDivENEx_Function.Class = "table table-bordered table-hover";
                objASPDivENEx_Function.Runat = "server";
                objASPDivENEx_Function.CtrlId = "divFunction";
                objASPDivENEx_Function.Ref = "refDivFunction";

                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
                if (objViewInfoENEx.arrFeatureRegionFlds == null)
                {
                    string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion
                    .Where(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (arrViewRegion.Count() == 0)
                {
                    string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                lngRegionId = arrViewRegion.First().RegionId;

                List<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, enumViewImplementation.FunctionRegion_0001, objViewInfoENEx, "");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup)
                    .OrderBy(x => x.GroupName).ToList();


                //IEnumerable<VueButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsVueButtonBLEx.GetButton4MvcAjax);
                List<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);


                //添加层div
                ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
                objASPUlENEx.Class = "nav";
                objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

                ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item";
                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //列表标题
                ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx, true);
                objASPLiENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                //Action<VueButtonEx> AddToTd = (x) =>
                //{
                //    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                //    VueButtonEx objASPNETButtonENEx = clsVueButtonBLEx.GetbtnAddNewRec4Gv();
                //    objASPNETColENEx.arrSubAspControlLst2.Add(x);
                //    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                //};
                //< li class="nav-item">

                Action<ASPButtonEx> AddToLi = (x) =>
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(x);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                };

                foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New)
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    //VueButtonEx objASPNETButtonENEx = clsVueButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                }

                objASPDivENEx_Function.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                //生成GridView的代码;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
            strCodeForCs.Append("\r\n" + "<script language = \"javascript\">");
            strCodeForCs.Append("\r\n" + "<!--");
            strCodeForCs.Append("\r\n" + "function radioClick()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "for (i = 0; i<document.Form1.RadioName.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName[i].checked == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//-->");
            strCodeForCs.Append("\r\n" + "</script>");

            intZIndex += 1;
            return strCodeForCs.ToString();


        }

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在界面:{0}中,没有设置标题类型,请检查!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)标题模式Id:[{0}]没有相应的对象,请检查!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
                throw new Exception(strMsg);
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabTitle\" style = \"z-index: 102; left: 8px; position: absolute; top: 1px\" cellspacing = \"1\" ");
                    strCodeForCs.AppendFormat("\r\n" + "cellpadding = \"1\" width = \"100%\" bgColor = \"{0}\" border = \"0\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    strCodeForCs.AppendFormat("\r\n" + "<td bgColor = \"{0}\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblViewTile\" runat = \"server\" Font-Size = \"Small\" Font-Names = \"宋体\" ForeColor = \"{1}\" Font-Bold = \"True\">{0}</asp:Label>",
                      strTitle, objTitleStyle.ForeColor);
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    strCodeForCs.AppendFormat("\r\n" + "</table>");
                    break;
                case "02":

                    break;
                case "03":
                    ASPDivEx objDiv = new ASPDivEx();
                    objDiv.Style = "position: relative; width: 648px; height: 37px; left: 0px; top: 0px;";
                    ASPLabelEx objLabel = new ASPLabelEx();
                    objLabel.CtrlId = "lblViewTitle";
                    objLabel.Class = "h5";
                    //objLabel.Is4PureHtml = true;
                    objLabel.Text = "{{{{ strTitle }}}}";// strTitle;
                    objDiv.arrSubAspControlLst2.Add(objLabel);
                    ASPLabelEx objLabel_ErrMsg = clsASPLabelBLEx.GetLabel4ErrMsg("lblMsg_List", true);
                    objDiv.arrSubAspControlLst2.Add(objLabel_ErrMsg);
                    objDiv.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    //strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                    //  strTitle);
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    ////如果有查询区域
                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                    //    strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    //}
                    //strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //用来定义正文的标签类型
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" ref = \"refDivQuery\" class = \"div_query\"> ",
              objViewInfoENEx.TabName, intDivHeight);


            intCurrTop -= 30;//因为这是在层(div)中
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;

            IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            if (arrViewRegion.Count() == 0)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            clsViewRegionENEx objViewRegion = arrViewRegion.First();
            string lngRegionId = objViewRegion.RegionId;

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroup(lngRegionId, objViewInfoENEx, "Item1");



            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:

                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
                    objTable.Width = objViewRegion.Width ?? 0;
                    objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objDiv_FormControl = clsASPDivBLEx.PackageByFormControl4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDiv_FormControl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objFormInline.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4QueryRegion(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objDivTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4QueryRegion_H(arrControlGroups, objViewRegion.ColNum ?? 0);

                    objUl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4QueryRegion_V(arrControlGroups, objViewRegion.ColNum ?? 0);
                    objUl2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
                    objTable2.Width = objViewRegion.Width ?? 0;
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
            }



            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objCheckStyle.StyleZindex = intZIndex + 1;
                objCheckStyle.StyleLeft = (int)intCurrLeft;
                objCheckStyle.StyleTop = (int)intCurrTop;

                ///生成CheckBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.StyleZindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成{组合控件},即左边的标签,和右边的输入条件的控件
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtlNoPosition(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成右边控件的代码;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Vue_Cs4Ts_DefDiv4DetailRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divDetailDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\" style=\"width: 800px;\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");

            Func<clsDetailRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrDetailRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);
            var objViewRegion = objViewInfoENEx.objViewRegion_Detail;
            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
                    objTable.Width = objViewRegion.Width ?? 0;
                    objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objDiv_FormControl = clsASPDivBLEx.PackageByFormControl4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objDiv_FormControl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objFormInline.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objDivTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4DetailRegion_H(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);

                    objUl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4DetailRegion_V(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);
                    objUl2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewRegion.ColNum ?? 0);
                    objTable2.Width = objViewRegion.Width ?? 0;
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
            }



            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnCancel{0}\" type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">关闭</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnOKUpd_{0}\" type=\"button\" class=\"btn btn-primary\" @click=\"Submit_{0}()\">添加</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_ViewScript_TS4Html);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}", objViewInfoENEx.ViewName);
            objViewInfoENEx.ClsName = this.ClsName;
        }

        public string Gen_WebView_Vue_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!--功能区-->");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_Vue_Code4ListRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!--列表层-->");
            strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\" >");

            //strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\" >");

            //strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + $"<{ThisListClsName}Com");
            strCodeForCs.Append("\r\n" + $"ref = \"ref{ThisListClsName}\"");
            strCodeForCs.Append("\r\n" + $":items = \"dataLst{TabName_Out4ListRegion}\"");
            strCodeForCs.Append("\r\n" + ":show-error-message = \"showErrorMessage\"");
            strCodeForCs.Append("\r\n" + ":empty-rec-num-info = \"emptyRecNumInfo\"");
            strCodeForCs.Append("\r\n" + "@on-edit-tab-relainfo = \"EditTabRelaInfo\"");
            strCodeForCs.Append("\r\n" + "@on-sort-column = \"SortColumn\"");
            strCodeForCs.Append("\r\n" + $"></{ThisListClsName}Com>");
            strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\" >");
            //strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</div>");
            return strCodeForCs.ToString();
        }

        public string Gen_WebView_Vue_Code4DetailRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!--详细信息层-->");
            strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion());

            return strCodeForCs.ToString();
        }

        public string Gen_WebView_Vue_Code4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!--查询层-->");

            strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
            return strCodeForCs.ToString();
        }
        private void GeneCode4ListRegion(StringBuilder strCodeForCs)
        {
            var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
            {
                strCodeForCs.Append("\r\n" + "<!--列表层-->");
                var objDivEx_List = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_List.CtrlId = "divList";
                objDivEx_List.Ref = "refDivList";
                objDivEx_List.Class = "div_List";
                var objDivEx_DataLst = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_DataLst.CtrlId = "divDataLst";
                objDivEx_DataLst.Class = "div_List";

                var objDivEx_Pager = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_Pager.CtrlId = "divPager";
                objDivEx_Pager.Class = "pager";
                objDivEx_Pager.Value = "1";

                var objHiddenEx = clsASPHiddenFieldBLEx.GetEmptyHiddenField();
                objHiddenEx.CtrlId = string.Format("hidSort{0}By", TabName_Out4ListRegion);
                //objHiddenEx.Class = "pager";
                objHiddenEx.Value = "";

                //          < JxTeachingPlan_ListCom
                //  :items = "dataList"
                //  :show - error - message = "showErrorMessage"
                //  :empty - rec - num - info = "emptyRecNumInfo"
                //  @on - edit - tab - relainfo = "EditTabRelaInfo"
                //  @on - sort - column = "SortColumn"
                //></ JxTeachingPlan_ListCom >

                var myComp = new VueComponentEx();
                myComp.Props = new List<clsVueProp>();
                myComp.Events = new List<clsVueEvent>();

                myComp.ComponentName = $"{ThisListClsName}Com";
                myComp.RefName = $"ref{ThisListClsName}";

                myComp.Props.Add(new clsVueProp("items", $"dataList{TabName_Out4ListRegion}"));
                myComp.Props.Add(new clsVueProp("show-error-message", $"showErrorMessage"));
                myComp.Props.Add(new clsVueProp("empty-rec-num-info", $"emptyRecNumInfo"));
                myComp.Props.Add(new clsVueProp("data-column", $"dataColumn"));
                myComp.Events.Add(new clsVueEvent("on-edit-tab-relainfo", $"EditTabRelaInfo"));
                myComp.Events.Add(new clsVueEvent("on-sort-column", $"SortColumn"));


                var objCode = new ASPCodeEx();
                //objCode.codeText = "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")";
                objDivEx_Pager.arrSubAspControlLst2.Add(objCode);
                objDivEx_List.arrSubAspControlLst2.Add(myComp);
                objDivEx_List.arrSubAspControlLst2.Add(objDivEx_Pager);
                objDivEx_List.arrSubAspControlLst2.Add(objHiddenEx);
                objDivEx_List.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);// clsASPDivBLEx.gene

            }
        }
        private void GeneCode4EditRegion(StringBuilder strCodeForCs)
        {
            var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;

            if (IsHasEditRegion == true)
            {
                //生成编辑区域代码-------------------------------

                strCodeForCs.Append("\r\n" + "<!--编辑层-->");

                strCodeForCs.AppendFormat("\r\n" + "<{0}Com ref='ref{0}'></{0}Com>", ThisEditClsName);


            }


        }

        private ASPDivEx GetDiv4ListRegion()
        {
            var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
            {
                var objDivEx_List = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_List.Comment = "<!--列表层-->";
                objDivEx_List.CtrlId = "divList";
                objDivEx_List.Class = "div_List";
                var objDivEx_DataLst = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_DataLst.CtrlId = "divDataLst";
                objDivEx_DataLst.Class = "div_List";

                var objDivEx_Pager = clsASPDivBLEx.GetEmptyDiv();
                objDivEx_Pager.CtrlId = "divPager";
                objDivEx_Pager.Class = "pager";
                objDivEx_Pager.Value = "1";

                var objCode = new ASPCodeEx();
                //objCode.codeText = "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")";
                objDivEx_Pager.arrSubAspControlLst2.Add(objCode);
                objDivEx_List.arrSubAspControlLst2.Add(objDivEx_DataLst);
                objDivEx_List.arrSubAspControlLst2.Add(objDivEx_Pager);
                return objDivEx_List;

            }
            return null;
        }


        private ASPDivEx GetDiv4EditRegion()
        {
            var objDivEx_Edit = clsASPDivBLEx.GetEmptyDiv();
            objDivEx_Edit.Comment = "<!--编辑层-->";
            var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;

            if (IsHasEditRegion == true)
            {
                //生成编辑区域代码-------------------------------

                objDivEx_Edit.CtrlId = "divEdit";
                objDivEx_Edit.Value = "1";
                return objDivEx_Edit;
            }
            return null;

        }

        public string Gen_CRUD_setup_BindDdl4QryRegionInDivBak()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " async function BindDdl4QryRegionInDiv()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");

                //针对每一个表功能--下拉框
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);

                    //第0步:把控件中下拉框ComboBox转换成ComboBox
                    if (objTabFeature4Ddl.IsHasErr)
                    {
                        throw new Exception(objTabFeature4Ddl.ErrMsg_Ddl);
                    }

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"getArr{objTabFeature4Ddl.TabName4GC}();");

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_BindDdl4QryRegion(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"BindDdl4QryRegion";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            //string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<ASPDropDownListEx> arrASPDropDownListObj_Query
                = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001).ToList();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "async function BindDdl4QryRegion()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
                List<string> arrDsTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    if (arrDsTabName.Contains(objInfor.DsTabName) == true) continue;
                    arrDsTabName.Add(objInfor.DsTabName);
                    List<string> arrCondFldId;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        if (objInfor.CsType == "bool")
                        {
                            //objInfor.CodeText = "\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivQuery, \"{objInfor.CtrlId}\");";
                            //AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalseInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                        }
                        continue;
                    }
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objTabFeature, this.IsFstLcase, PrjTabEx_ListRegion, objViewInfoENEx.ViewId);
                    string strByCondition = "";
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                        strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";

                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    List<clsTabFeatureFldsENEx> arrTabFeatureFldsEx_Cond = arrTabFeatureFlds_Cond.Select(x => x.CopyToEx()).ToList();
                    //objFuncParaLstAll.AddParaByTabFeature(objTabFeature, arrTabFeatureFldsEx_Cond, enumProgLangType.TypeScript_09);

                    arrCondFldId = objTabFeature.GetCondFldIdLst();
                    if (arrTabFeatureFlds_Cond.Count == 0)
                    {
                        objInfor.VarIdCond1 = "";
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond1 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond2 = "";
                    }

                    try
                    {
                        Tuple<string, string> tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objCodeElement_Parent, objInfor, arrCondFldId, objFuncParaLstAll);

                        string strVar4Cond = tup.Item1;
                        string strFuncParaLst_Additional = tup.Item2;//函数参数变量列表

                        if (objInfor.CsType == "bool")
                        {
                            //objInfor.CodeText = string.Format("\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivQuery, \"{0}\");",
                            //         objInfor.CtrlId);
                            //AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalseInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                        }
                        else
                        {
                            if (objTabFeature4Ddl.IsExtendedClass)
                            {
                                objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}Ex_{objTabFeature4Ddl.GetDdlDataFuncName4Ex}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";
                            }
                            else
                            {
                                strFuncName = $"GetArr{objInfor.DsTabName}{strByCondition}";
                                if (string.IsNullOrEmpty(objTabFeature4Ddl.GetDdlDataFuncName4Ex) == false)
                                {
                                    strFuncName = objTabFeature4Ddl.GetDdlDataFuncName4Ex;
                                }
                                objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}_{strFuncName}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";
                            }
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl, true));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
                    //if (objInfor.objQryRegionFldsEN.CtlTypeId != enumCtlType.DropDownList_06 && objInfor.objQryRegionFldsEN.CtlTypeId != enumCtlType.DropDownList_Bool_18) continue;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, this.PrjId);
                    if (string.IsNullOrEmpty(objInfor.objQryRegionFldsEN.OutFldId) == false)
                    {
                        if (objInfor.objQryRegionFldsEN.ObjFieldTab4OutFldId_PC().IsNumberType() == true)
                        {
                            strCodeForCs.Append("\r\n" + $"{objInfor.objQryRegionFldsEN.ObjFieldTab4OutFldId_PC().PropertyName_TS(this.IsFstLcase)}_q.value = 0;");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"{objInfor.objQryRegionFldsEN.ObjFieldTab4OutFldId_PC().PropertyName_TS(this.IsFstLcase)}_q.value = '0';");
                        }
                    }
                    else
                    {
                        if (objInfor.objQryRegionFldsEN.ObjFieldTab_PC().IsNumberType() == true)
                        {
                            strCodeForCs.Append("\r\n" + $"{objInfor.objQryRegionFldsEN.ObjFieldTab_PC().PropertyName_TS(this.IsFstLcase)}_q.value = 0;");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"{objInfor.objQryRegionFldsEN.ObjFieldTab_PC().PropertyName_TS(this.IsFstLcase)}_q.value = '0';");
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public Tuple<string, string> Gen_WApi_Ts_DefineVar4Ddl4TabFeature(CodeElement objCodeElement_Parent, ASPDropDownListEx objInfor, List<string> arrCondFldId, FuncParaLst objFuncParaLstAll)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
            var strVarId_T1 = clsViewIdGCVariableRelaBLEx.GetCommonOriginVarId(objViewInfoENEx.ViewId, objInfor.VarIdCond1, objViewInfoENEx.PrjId);
            objFuncParaLst.AddParaByVar(strVarId_T1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(strVarId_T1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            var strVarId_T2 = clsViewIdGCVariableRelaBLEx.GetCommonOriginVarId(objViewInfoENEx.ViewId, objInfor.VarIdCond2, objViewInfoENEx.PrjId);

            objFuncParaLst.AddParaByVar(strVarId_T2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(strVarId_T2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            if (string.IsNullOrEmpty(objInfor.DsTabId) == false)
            {
                var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                var objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                objFuncParaLst.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);
                objFuncParaLstAll.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);

            }


            string strFuncParaLst_Additional = objFuncParaLst.GetCondFldLst();

            if (objFuncParaLst.GetLst != null)
            {
                foreach (var objInFor in objFuncParaLst.GetLst)
                {
                    if (string.IsNullOrEmpty(objInFor.FilePath) == true) continue;
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objInFor.FilePath, objInFor.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);

                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                    if (objInFor.VarTypeId == tsVarType.tsCache)
                    {
                        clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objInFor.FldLen, objInFor.VarName, this.ClsName);

                    }
                }
            }

            string strVar4Cond = "";

            objInfor.CodeText = strCodeForCs.ToString();
            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strFuncParaLst_Additional);

            return tup;
        }



        public string Gen_Vue_ts_ExportFuncDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}Condition : ()=>Promise<string>; ");
            strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}ConditionObj: ()=> Promise<cls{TabName_Out4ListRegion4GC}EN>; ");
            strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel: ()=>Promise<cls{TabName_Out4ExportExcel4GC}EN>; ");
            strCodeForCs.Append("\r\n" + $"export let BindTabByList: (arrObjLst: Array<cls{TabName_Out4ListRegion4GC}ENEx>,    bolIsShowErrMsg: boolean,) => Promise<void>;");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_ts_QryVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const qryVarSet = reactive({");
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (objQryRegionFldsEx.InUse == false) continue;
                if (string.IsNullOrEmpty(objQryRegionFldsEx.TabFeatureId4Ddl) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref('0');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                    continue;
                }
                try
                {
                    switch (objQryRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref(0);", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref(true)", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                }
                catch (Exception objExceptionIn)
                {
                    throw objExceptionIn;
                }
            }
            sbCode_Export.Append("});");
            sbCode_Export.Append("export { qryVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_setup_var_ts_DataListVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "const showErrorMessage = ref (false);");
            strCodeForCs.Append("\r\n" + $"const dataList{TabName_Out4ListRegion} = ref<Array<cls{TabName_Out4ListRegion}ENEx>>([]);");
            strCodeForCs.Append("\r\n" + "const emptyRecNumInfo = ref ('');");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_PubVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var strFuncName = "";
            strCodeForCs.Append("\r\n" + GeneViewPubVarInVue(strFuncName, this.objCodeElement_Root));

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_ViewVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + $"const objPageCRUD = ref<{objViewInfoENEx.TabName}CRUD>();");
            strCodeForCs.Append("\r\n" + "const ascOrDesc4SortFun = ref ('Asc');");
            strCodeForCs.Append("\r\n" + $"const sort{TabName_Out4ListRegion}By = ref ('');");
            strCodeForCs.Append("\r\n" + "const viewVarSet = reactive({");
            strCodeForCs.Append("\r\n" + "objPageCRUD,");
            strCodeForCs.Append("\r\n" + "ascOrDesc4SortFun,");
            strCodeForCs.Append("\r\n" + $"sort{TabName_Out4ListRegion}By,");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "export { viewVarSet };");

            return strCodeForCs.ToString();
        }
        public string Gen_Vue_ts_DivVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const divVarSet = reactive({");
            sbCode_Export.Append("\r\n" + " refDivLayout,");
            sbCode_Export.Append("\r\n" + "refDivQuery,");
            sbCode_Export.Append("\r\n" + "refDivFunction,");
            sbCode_Export.Append("\r\n" + "refDivList,");

            strCodeForCs.Append("\r\n" + "const refDivLayout = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivQuery = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivFunction = ref ();");
            strCodeForCs.Append("\r\n" + "const refDivList = ref ();");
            if (IsHasDetailRegion)
            {
                strCodeForCs.AppendFormat("\r\n" + "const ref{0} = ref ();", ThisDetailClsName);
                sbCode_Export.Append("\r\n" + $"ref{ThisDetailClsName},");
            }

            sbCode_Export.Append("});");
            sbCode_Export.Append("export { divVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

            return strCodeForCs.ToString();
        }
        public string Gen_vue_ts_setup_fun_CombineConditionObj(CodeElement objCodeElement_Parent)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns 条件串(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " Combine{0}ConditionObj=async (): Promise<cls{0}EN> =>", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                }
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", TabName_Out4ListRegion4GC);
                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                var arrQryRegionFldsEx = arrQryRegionFlds.Select(clsQryRegionFldsBLEx.CopyToEx);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFldsEx)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                        if (objInFor.IsUseFunc() && string.IsNullOrEmpty(objInFor.DataPropertyName()) == false) continue;
                        if (objInFor.IsForExtendClass() == true) continue;
                        string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004 || objVar.VarTypeId == enumGCVariableType.localStorage_0003)
                        {
                            CheckQueryField(objInFor);

                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({4}.con_{1}, {3}, \"=\");",
                             TabName_Out4ListRegion4GC,
                             objInFor.ObjFieldTab().FldName,
                             ThisClsName,
                             strVarName, strClsName_Fld);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({4}.con_{1}, {2}.{3}, \"=\");",
                                TabName_Out4ListRegion4GC,
                                objInFor.ObjFieldTab().FldName,
                                ThisClsName,
                                strVarName, strClsName_Fld);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                if (objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                {

                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName, strClsName_Fld);


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName, strClsName_Fld);

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///如果控件是下拉框;
                                case "DropDownList_Bool": ///如果控件是下拉框;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);

                                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName, strClsName_Fld);


                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///如果控件类型是文本框;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {2}.con_{0}, {1}.value);",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"like\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///范围查询;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;
                                case "HyperLink":
                                    break;
                                case "Image":
                                    break;
                                case "ImageButton":
                                    break;
                                case "Label":
                                    break;
                                case "Link1Button":
                                    break;
                                case "ListBox":
                                    break;
                                case "Panel":
                                    break;
                                case "RadioButton":
                                    break;
                                case "RadioButtonList":
                                    break;
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                                case "sessionStorage":
                                    break;
                                case "CacheClassifyField":
                                    break;
                                case "ViewVariable":
                                    break;
                                default:
                                    var strMsg = string.Format("(errorId:018)控件类型：{0}在相应函数中没有被处理!({1})", objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //处理针对扩展字段的查询
                        strCodeForCs.Append("\r\n" + Gen_Ts_CombineConditionInFldValueLst());

                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj", "在组合查询条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"在组合查询条件对象(Combine{ViewMainTabName4GC}ConditionObj)时出错!请联系管理员!{{0}}\", objException);");
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }

                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ListRegion4GC);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "};");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        private string Gen_Ts_CombineConditionInFldValueLst()
        {
            var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
            if (arrQryRegionFldSetEx.Count == 0) return "";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                ///生成仅有变量;
                var arrQryRegionFld_InFld = arrQryRegionFldSetEx.GroupBy(x => x.FldId).ToList();
                foreach (var arrInFld in arrQryRegionFld_InFld)
                {
                    string strFldId = arrInFld.Key;
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, objViewInfoENEx.PrjId);
                    string strFldName = objFieldTab.FldName;

                    strCodeForCs.AppendFormat("\r\n" + "//处理针对扩展字段:[{0}]的查询", strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0} = await this.GetCondition_{0}Lst_In();", strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length > 0)", strFldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} in ({{1}})\", {0}.con_{1}, arr{1}.join(','));",
                        strClsName_Fld, strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({1}.con_{2}, arr{2}.join(','), \"in\");",
                        TabName_Out4ListRegion4GC, strClsName_Fld, strFldName);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_vue_ts_setup_fun_CombineCondition(CodeElement objCodeElement_Parent)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;

                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);


                strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns 条件串(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "  Combine{0}Condition = async():Promise<string> =>", TabName_Out4ListRegion4GC);
                strFuncName = $" public async Combine{TabName_Out4ListRegion4GC}Condition():Promise<string> ";
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");

                StringBuilder sbTemp = new StringBuilder();
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
                        {
                            CheckQueryField(objInFor);

                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {strVarName});");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {strVarName});");
                            }
                        }
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                        }

                        else
                        {
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {ThisClsName}.{strVarName});");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {ThisClsName}.{strVarName});");
                            }
                        }
                    }
                }

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    if (sbTemp.Length > 0)
                    {
                        strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                    }
                }
                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                }
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.Append("\r\n" + sbTemp.ToString());

                if (objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                {
                    ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("cls{0}EN", TabName_Out4ListRegion4GC), enumImportObjType.ENClass, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");

                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                            {
                            }
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///如果控件是下拉框;
                                case "DropDownList_Bool": ///如果控件是下拉框;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        ImportClass objImportClass3 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                                        CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(this.divQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///如果控件类型是文本框;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {2}.con_{0}, {1}.value);",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///范围查询;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;
                                case "HyperLink":
                                    break;
                                case "Image":
                                    break;
                                case "ImageButton":
                                    break;
                                case "Label":
                                    break;
                                case "Link1Button":
                                    break;
                                case "ListBox":
                                    break;
                                case "Panel":
                                    break;
                                case "RadioButton":
                                    break;
                                case "RadioButtonList":
                                    break;
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                                case "sessionStorage":
                                    break;
                                case "CacheClassifyField":
                                    break;
                                case "ViewVariable":
                                    break;
                                default:
                                    var strMsg = string.Format("(errorId:018)控件类型：{0}在相应函数中没有被处理!({1})", objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameCondition", "在组合查询条件(CombineTabNameCondition)时出错!请联系管理员!", "生成代码");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"在组合查询条件(Combine{ViewMainTabName4GC}Condition)时出错!请联系管理员!{{0}}\", objException);");
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }


                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "};");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_All(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Setup = new CodeElement { Name = "setup", ElementType = CodeElementType.Setup, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Setup);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "setup() {");
            string strTemp = clsViewIdGCVariableRelaBLEx.GetGC_InitVarValue(objViewInfoENEx.ViewId, this, "", this.PrjId);
            if (strTemp.IndexOf("userStore.") > -1)
            {
                strCodeForCs.Append("\r\n" + " const userStore = useUserStore();");
                objCodeElement_Setup.Children.Add(new CodeElement
                {
                    Name = "userStore",
                    CodeContent = "const userStore = useUserStore();",
                    ElementType = CodeElementType.Constant,
                    Modifiers = "const"
                });
            }
            strCodeForCs.Append("\r\n" + strTemp);
            strCodeForCs.AppendFormat("\r\n" + " const objPage = ref<{0}Ex>();", ThisClsName);
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "objPage",
                CodeContent = $"  const objPage = ref<{ThisClsName}Ex>();",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            if (objViewInfoENEx.objViewRegion_Edit != null)
            {
                strCodeForCs.AppendFormat("\r\n" + $" const objPage_Edit = ref<{ThisEditClsName}Ex>();");
                objCodeElement_Setup.Children.Add(new CodeElement
                {
                    Name = "objPage_Edit",
                    CodeContent = $" const objPage_Edit = ref<{ThisEditClsName}Ex>();",
                    ElementType = CodeElementType.RefConstant,
                    Modifiers = "const"
                });
            }

            if (objViewInfoENEx.objViewRegion_Detail != null)
            {
                strCodeForCs.AppendFormat("\r\n" + $" const objPage_Detail = ref<{ThisDetailClsName}Ex>();");
                objCodeElement_Setup.Children.Add(new CodeElement
                {
                    Name = "objPage_Detail",
                    CodeContent = $" const objPage_Detail = ref<{ThisDetailClsName}Ex>();",
                    ElementType = CodeElementType.RefConstant,
                    Modifiers = "const"
                });
            }

            strCodeForCs.AppendFormat("\r\n" + $" const opType = ref('');");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "opType",
                CodeContent = $" const opType = ref('');",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.AppendFormat("\r\n" + $" const thisConstructorName = '{clsString.FirstUcaseS(ThisClsName)}';");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "thisConstructorName",
                CodeContent = $" const thisConstructorName = '{clsString.FirstUcaseS(ThisClsName)}';",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });


            //strCodeForCs.Append("\r\n" + Gen_Vue_setup_var_ts_DataListVarDef());
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                strCodeForCs.Append("\r\n" + Gen_CRUD_setup_DefineDdlDataVarName(objCodeElement_Setup));
            }
            strCodeForCs.Append("\r\n" + Gen_CRUD_setup_DefineDdlDataVarName4FeatureRegion(objCodeElement_Setup));

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }

            foreach (var objFeature in arrFeatureRegionFldsObjLst)
            {
                switch (objFeature.FeatureId)
                {
                    case enumPrjFeature.AddNewRecord_0136:
                    case enumPrjFeature.AddNewRecordWithMaxId_0183:
                        if (objViewInfoENEx.objViewRegion_Edit == null) break;
                        if (arrFuncName_Setup.Contains("btnCreate_Click")) continue;
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnCreate_Click(objCodeElement_Setup));
                        arrFuncName_Setup.Add("btnCreate_Click");
                        break;
                    case enumPrjFeature.UpdateRecord_0137:
                    case enumPrjFeature.UpdateRecord_Gv_0174:
                        if (objViewInfoENEx.objViewRegion_Edit == null) break;
                        if (arrFuncName_Setup.Contains("btnUpdate_Click")) continue;
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnUpdate_Click(objCodeElement_Setup));
                        arrFuncName_Setup.Add("btnUpdate_Click");
                        break;
                    case enumPrjFeature.DetailRecord_0239:
                        if (objViewInfoENEx.objViewRegion_Detail == null) break;
                        if (arrFuncName_Setup.Contains("btnDetail_Click")) continue;
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnDetail_Click(objCodeElement_Setup));
                        arrFuncName_Setup.Add("btnDetail_Click");
                        break;


                    case enumPrjFeature.DelRecord_0138:
                    case enumPrjFeature.DelRecord_Gv_0175:
                        if (arrFuncName_Setup.Contains("btnDelete_Click")) continue;

                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_ThisTabName(objCodeElement_Setup));
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnDelete_Click(objCodeElement_Setup));
                        arrFuncName_Setup.Add("btnDelete_Click");
                        break;
                    case enumPrjFeature.Query_0139:
                        if (arrFuncName_Setup.Contains("btnQuery_Click")) continue;
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnQuery_Click(objCodeElement_Setup));
                        arrFuncName_Setup.Add("btnQuery_Click");
                        break;
                    case enumPrjFeature.CopyRecord_0141:
                        if (arrFuncName_Setup.Contains("btnClone_Click")) continue;
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnCopyRecord_Click(objCodeElement_Setup));
                        arrFuncName_Setup.Add("btnClone_Click");
                        break;
                    case enumPrjFeature.SetFieldValue_0148:

                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnSetFldValue_Click(objCodeElement_Setup, false));
                        //arrFuncName_Setup.Add("btnClone_Click");
                        break;
                    case enumPrjFeature.ExportToFile_0143:
                        if (arrFuncName_Setup.Contains("btnExportExcel_Click")) continue;
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnExportExcel_Click(objCodeElement_Setup));
                        if (objViewInfoENEx.objViewRegion_ExportExcel != null)
                        {
                            arrFuncName_Setup.Add("btnExportExcel_Click");
                        }
                        break;

                    case enumPrjFeature.AdjustOrderNum_1196:
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnUpMove_Click(objCodeElement_Setup));
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnDownMove_Click(objCodeElement_Setup));
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnGoTop_Click(objCodeElement_Setup));
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnGoBottum_Click(objCodeElement_Setup));
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_btnReOrder_Click(objCodeElement_Setup));


                        arrFuncName_Setup.Add("btnUpMove_Click");
                        arrFuncName_Setup.Add("btnDownMove_Click");
                        arrFuncName_Setup.Add("btnGoTop_Click");
                        arrFuncName_Setup.Add("btnGoBottum_Click");
                        arrFuncName_Setup.Add("btnReOrder_Click");

                        break;
                    case enumPrjFeature.DefaultFeature_0240:
                        strCodeForCs.Append("\r\n" + Gen_CRUD_setup_SelfDefine_Click(objFeature));
                        string strFuncName = $"{objFeature.ButtonName}_Click";
                        arrFuncName_Setup.Add(strFuncName);
                        break;
                    default:
                        var objPrjF = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeature.FeatureId);
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                clsStackTrace.GetCurrClassFunction(), objPrjF.FeatureName);
                        throw new Exception(strMsg);
                }
            }


            //strCodeForCs.Append("\r\n" + Gen_Vue_setup_fun_ts_BindTabByList());
            strCodeForCs.Append("\r\n" + Gen_CRUD_setup_BindDdl4QryRegion(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_CRUD_setup_BindDdl4FeatureRegion(objCodeElement_Setup));

            strCodeForCs.AppendFormat("\r\n" + "const strTitle = ref ('{0}维护');", objViewInfoENEx.TabCnName);
            //strCodeForCs.AppendFormat("\r\n" + "const ref{0} = ref ();", ThisEditClsName);

            
            strCodeForCs.Append("\r\n" + Gen_CRUD_Setup_onMounted(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_CRUD_Setup_GetPropValue(objCodeElement_Setup));
            //strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineConditionObj());
            //strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineCondition());
            //strCodeForCs.Append("\r\n" + Gen_vue_ts_setup_fun_CombineConditionObj4ExportExcel());

            strCodeForCs.Append("\r\n" + Gen_CRUD_Setup_btn_Click(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_CRUD_Setup_Return(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + "},");

            objCodeElement_Setup.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_method_All(CodeElement objCodeElement_Parent)
        {
            objCodeElement_Methods = new CodeElement { Name = "methods", ElementType = CodeElementType.Methods, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Methods);
            string strFuncName = "";
            string strTemp = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "        methods: {");
            strCodeForCs.Append("\r\n" + Gen_CRUD_method_EditTabRelaInfo(objCodeElement_Methods));
            strCodeForCs.Append("\r\n" + Gen_CRUD_method_SortColumn(objCodeElement_Methods));
            strCodeForCs.Append("\r\n" + Gen_CRUD_method_GeneEventFuncEx(objCodeElement_Methods));

            strCodeForCs.Append("\r\n" + "            // 方法定义");

            //strCodeForCs.Append("\r\n" + "            /**");
            //strCodeForCs.Append("\r\n" + "             * 页面导入-在导入页面后运行的函数");
            //strCodeForCs.Append("\r\n" + "            **/");
            //strCodeForCs.Append("\r\n" + "            myonload() {");
            //strCodeForCs.AppendFormat("\r\n" + "                const objPage = new {0}Ex();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "                objPage.PageLoadCache();");
            //strCodeForCs.Append("\r\n" + "  },");

            strJSPath = string.Format("../js/{0}", objFuncModule.FuncModuleEnName4GC());

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS =
                clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx_JS(objViewInfoENEx);


            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_JS)
            {
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }
            }

            strCodeForCs.Append("\r\n" + "},");

            return strCodeForCs.ToString();

        }
        public string Gen_vue_ts_setup_fun_CombineConditionObj4ExportExcel(CodeElement objCodeElement_Parent)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;


                strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns 条件串(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + $" Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel = async ():Promise<cls{TabName_Out4ExportExcel4GC}EN> => ");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                }

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}ENEx();", TabName_Out4ExportExcel4GC);
                ImportClass objImportClass = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", TabName_Out4ExportExcel4GC), enumImportObjType.ENExClass, this.strBaseUrl);
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38, };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        if (objInFor.IsForExtendClass()) continue;
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004 || objVar.VarTypeId == enumGCVariableType.localStorage_0003)
                        {
                            CheckQueryField(objInFor);

                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {3}, \"=\");",
                             TabName_Out4ExportExcel4GC,
                             objInFor.ObjFieldTab().FldName,
                             ThisClsName,
                             strVarName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}, \"=\");",
                                TabName_Out4ExportExcel4GC,
                                objInFor.ObjFieldTab().FldName,
                                ThisClsName,
                                strVarName);
                        }
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            ImportClass objImportClass4 = AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                            CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                if (objViewInfoENEx.arrQryRegionFldSet.Count() > 0)
                {
                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;
                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ExportExcel4GC);
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName, strClsName_Fld);


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName, strClsName_Fld);

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///如果控件是下拉框;
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        ImportClass objImportClass5 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                                        CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld,
                                              "{", "}");
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName, strClsName_Fld);


                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///如果控件类型是文本框;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, {1}.value);",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {2}.con_{0}, {1}.value);",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"like\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///范围查询;
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value);",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, {1}.value), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}N.con_{1}, {2}.value, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;
                                case "HyperLink":
                                    break;
                                case "Image":
                                    break;
                                case "ImageButton":
                                    break;
                                case "Label":
                                    break;
                                case "Link1Button":
                                    break;
                                case "ListBox":
                                    break;
                                case "Panel":
                                    break;
                                case "RadioButton":
                                    break;
                                case "RadioButtonList":
                                    break;
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                            }
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj4ExportExcel", "在组合导出Excel条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"在组合导出Excel条件对象(Combine{ViewMainTabName4GC}ConditionObj4ExportExcel)时出错!请联系管理员!{{0}}\", objException);");
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ExportExcel4GC);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ExportExcel4GC);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_method_EditTabRelaInfo(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"EditTabRelaInfo";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数:编辑表的相关信息");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "async EditTabRelaInfo(data: any) {");
                strCodeForCs.Append("\r\n" + "console.log('data:', data);");
                strCodeForCs.Append("\r\n" + $"router.push({{ name: 'edit{TabName_Out4ListRegion}', params: {{ courseId: data.courseId }} }});");
                strCodeForCs.Append("\r\n" + "},");

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_method_SortColumn(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"SortColumn";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数:根据表列进行排序");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "async SortColumn(data: any) {");
                strCodeForCs.Append("\r\n" + "console.log('data:', data);");
                strCodeForCs.Append("\r\n" + $"const objPage = new {ThisClsName}Ex();");
                strCodeForCs.Append("\r\n" + "objPage.SortColumn(data.sortColumnKey, data.sortDirection);");
                strCodeForCs.Append("\r\n" + "},");

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string Gen_CRUD_setup_BindDdl4FeatureRegion(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"BindDdl4FeatureRegion";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            //string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
            IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
            List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();


            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为功能区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "async function BindDdl4FeatureRegion()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4QueryRegion.name;",
                //ViewMainTabName4GC, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    List<string> arrCondFldId;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        if (objInfor.CsType == "bool")
                        {
                            //objInfor.CodeText = "\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivFunction, \"{objInfor.CtrlId}\");";
                        }

                        continue;
                    }

                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objTabFeature, this.IsFstLcase, PrjTabEx_EditRegion, objViewInfoENEx.ViewId);
                    string strByCondition = "";
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                        strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";


                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    arrCondFldId = objTabFeature.GetCondFldIdLst();
                    if (arrTabFeatureFlds_Cond.Count == 0)
                    {
                        objInfor.VarIdCond1 = "";
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond1 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond2 = "";
                    }

                    try
                    {
                        Tuple<string, string> tup;
                        //if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                        //{
                        //    //tup = this.Gen_WApi_Ts_DefineVar4Ddl(objInfor, objVarManage);
                        //}
                        //else
                        //{
                        tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objCodeElement_Parent, objInfor, arrCondFldId, objFuncParaLstAll);
                        //}
                        //
                        string strVar4Cond = tup.Item1;
                        string strFuncParaLst_Additional = tup.Item2;//函数参数变量列表

                        if (objInfor.CsType == "bool")
                        {
                            //objInfor.CodeText = string.Format("\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivFunction, \"{0}\");",
                            //         objInfor.CtrlId);
                        }
                        else
                        {
                            if (objTabFeature4Ddl.IsExtendedClass)
                            {
                                objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}Ex_{objTabFeature4Ddl.GetDdlDataFuncName4Ex}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";

                            }
                            else
                            {
                                strFuncName = $"GetArr{objInfor.DsTabName}{strByCondition}";
                                if (string.IsNullOrEmpty(objTabFeature4Ddl.GetDdlDataFuncName4Ex) == false)
                                {
                                    strFuncName = objTabFeature4Ddl.GetDdlDataFuncName4Ex;
                                }
                                objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}_{strFuncName}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";
                            }
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl, true));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);

                    if (objInfor.objViewFeatureFldsEN.ObjFieldTab1().IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + $"{objInfor.objViewFeatureFldsEN.ObjFieldTab1().PropertyName_TS(this.IsFstLcase)}_f.value = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"{objInfor.objViewFeatureFldsEN.ObjFieldTab1().PropertyName_TS(this.IsFstLcase)}_f.value = '0';");
                    }
                }


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule0, string strIsShare)
        {
            //List<ImportClass> arrImportClass = new List<ImportClass>();

            arrImportClass.Add(new ImportClass
            {
                ClsName = "divVarSet ,refDivLayout,refDivQuery,refDivFunction, refDivList",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
         ViewMainTabName4GC)
            });
            if (IsHasEditRegion)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"ref{ThisEditClsName}",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
                     ViewMainTabName4GC)
                });
            }
            if (IsHasDetailRegion)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"ref{ThisDetailClsName}",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
                     ViewMainTabName4GC)
                });
            }
            if (IsHasListRegion)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"ref{ThisListClsName}",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
                     ViewMainTabName4GC)
                });
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("cls{0}EN", ViewMainTabName4GC),
                FilePath = string.Format("@/ts/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                 ViewMainTabName4GC)
            });

            if (objViewInfoENEx.objViewRegion_Edit != null)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("cls{0}EN", TabName_In4Edit4GC),
                    FilePath = string.Format("@/ts/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                TabName_In4Edit4GC)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"{ThisEditClsName}Ex",
                    IsDefaultCls = true,
                    FilePath = $"@/views{strIsShare}/{objFuncModule0.FuncModuleEnName4GC()}/{ThisEditClsName}Ex.js"
                });
            }
            if (objViewInfoENEx.objViewRegion_Detail != null)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("cls{0}EN", TabName_Out4DetailRegion),
                    FilePath = string.Format("@/ts/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                TabName_In4Edit4GC)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"{ThisDetailClsName}Ex",
                    IsDefaultCls = true,
                    FilePath = $"@/views{strIsShare}/{objFuncModule0.FuncModuleEnName4GC()}/{ThisDetailClsName}Ex.js"
                });
            }

            //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
            //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetFirstCheckedKeyIdInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsString.js", "Format", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            //     arrImportClass.Add(new ImportClass
            //     {
            //         ClsName = "viewVarSet",
            //         FilePath = string.Format($"@/views/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
            //ViewMainTabName4GC)
            //     });

            string strAllVarNames = clsViewIdGCVariableRelaBLEx.GetAllViewVarNames(objViewInfoENEx.ViewId, this.PrjId);
            //if (strAllVarNames.Length > 2) strAllVarNames += ",";
            string strClsNames = "";
            if (strAllVarNames.Length == 0)
            {
                strClsNames = $" showErrorMessage, dataList{TabName_Out4ListRegion}, emptyRecNumInfo,dataColumn";
            }
            else
            {
                strClsNames = $" showErrorMessage, dataList{TabName_Out4ListRegion}, emptyRecNumInfo,dataColumn, {strAllVarNames}";
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName = strClsNames,
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
       ViewMainTabName4GC)
            });

            StringBuilder sbClassName = new StringBuilder();
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.InUse == false) continue;
                    if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId))
                    {
                        sbClassName.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    else
                    {
                        sbClassName.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().PropertyName_TS(this.IsFstLcase));
                    }
                }
            }
            foreach (clsViewFeatureFldsENEx objViewFeatureFldsEx in objViewInfoENEx.arrViewFeatureFlds)
            {
                //if (objQryRegionFldsEx.InUse == false) continue;
                if (objViewFeatureFldsEx.FieldTypeId == enumFieldType.OrderNumField_09) continue;
                sbClassName.AppendFormat("\r\n" + "{0}_f,", objViewFeatureFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName = sbClassName.ToString(),
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
       ViewMainTabName4GC)
            });

            ImportClass objImportClass3 = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "confirmDel", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);


        }

        public string Gen_CRUD_import_All(CodeElement objCodeElement_Parent)
        {
            //CodeElement objCodeElement_Import = new CodeElement { Name = "import", ElementType = CodeElementType.Import, Modifiers = "export abstract" };
            //clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            StringBuilder strCodeForCs = new StringBuilder();
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            strCodeForCs.AppendFormat("\r\n" + "//import $ from \"jquery\";");

            strCodeForCs.Append("\r\n" + "import 'jquery/dist/jquery.min.js';");
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
            {
                Name = "jquery/dist/jquery.min.js",
                CodeContent = "import 'jquery/dist/jquery.min.js';",
                ElementType = CodeElementType.Import,
                Modifiers = "import",
                From = "jquery/dist/jquery.min.js"
            });
            strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/js/bootstrap.min.js';");
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
            {
                Name = "bootstrap/dist/js/bootstrap.min.js",
                CodeContent = "import 'bootstrap/dist/js/bootstrap.min.js';;",
                ElementType = CodeElementType.Import,
                Modifiers = "import",
                From= "bootstrap/dist/js/bootstrap.min.js"
            });
            strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/css/bootstrap.css';");
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
            {
                Name = "bootstrap/dist/css/bootstrap.css",
                CodeContent = "import 'bootstrap/dist/css/bootstrap.css';",
                ElementType = CodeElementType.Import,
                Modifiers = "import",
                From= "bootstrap/dist/css/bootstrap.css"
            });
            strCodeForCs.Append("\r\n" + "import { defineComponent, onMounted, ref } from 'vue';");
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
            {
                Name = "defineComponent, onMounted, ref",
                CodeContent = "import { defineComponent, onMounted, ref } from 'vue';",
                ElementType = CodeElementType.Import,
                From = "vue",
                Modifiers = "import"
            });
            if (clsViewIdGCVariableRelaBLEx.IsNeedUseRoute(objViewInfoENEx.ViewId, this.PrjId))
            {
                strCodeForCs.Append("\r\n" + "import { useRoute } from 'vue-router';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "useRoute",
                    CodeContent = "import { useRoute } from 'vue-router';",
                    ElementType = CodeElementType.Import,
                    From = "vue-router",
                    Modifiers = "import"
                });
            }

            if (objViewInfoENEx.objViewRegion_ExportExcel != null)
            {
                strCodeForCs.Append("\r\n" + "import * as XLSX from 'xlsx';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "XLSX",
                    CodeContent = "import * as XLSX from 'xlsx';",
                    ElementType = CodeElementType.Import,
                    From = "xlsx",
                    Modifiers = "import"
                });
                strCodeForCs.Append("\r\n" + "import { ExportExcelData } from '@/ts/PubFun/ExportExcelData';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "ExportExcelData",
                    CodeContent = "import { ExportExcelData } from '@/ts/PubFun/ExportExcelData';",
                    ElementType = CodeElementType.Import,
                    From = "@/ts/PubFun/ExportExcelData",
                    Modifiers = "import"
                });
            }
            strCodeForCs.Append("\r\n" + "import router from '@/router';");
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
            {
                Name = "router",
                CodeContent = "import router from '@/router';",
                ElementType = CodeElementType.Import,
                From = "@/router",
                Modifiers = "import"
            });
            string strTemp = clsViewIdGCVariableRelaBLEx.GetGC_InitVarValue(objViewInfoENEx.ViewId, this, "@/ts/", this.PrjId);
            string strTemp2 = "";


            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            var arrFuncName_Setup_Import = new List<string>();

            foreach (var objFeature in arrFeatureRegionFldsObjLst)
            {
                switch (objFeature.FeatureId)
                {
                    case enumPrjFeature.AddNewRecord_0136:
                    case enumPrjFeature.AddNewRecordWithMaxId_0183:
                        strTemp2 = Gen_CRUD_setup_btnCreate_Click(this.objCodeElement_Imports);
                        arrFuncName_Setup_Import.Add("btnCreate_Click");
                        break;
                    case enumPrjFeature.UpdateRecord_0137:
                    case enumPrjFeature.UpdateRecord_Gv_0174:
                        if (arrFuncName_Setup_Import.Contains("btnUpdate_Click")) continue;
                        strTemp2 = Gen_CRUD_setup_btnUpdate_Click(this.objCodeElement_Imports);
                        arrFuncName_Setup_Import.Add("btnUpdate_Click");
                        break;
                    case enumPrjFeature.DetailRecord_0239:
                        if (arrFuncName_Setup_Import.Contains("btnUpdate_Click")) continue;
                        strTemp2 = Gen_CRUD_setup_btnUpdate_Click(this.objCodeElement_Imports);
                        arrFuncName_Setup_Import.Add("btnUpdate_Click");
                        break;
                    case enumPrjFeature.DelRecord_0138:
                    case enumPrjFeature.DelRecord_Gv_0175:
                        if (arrFuncName_Setup_Import.Contains("btnDelete_Click")) continue;

                        strTemp2 = Gen_CRUD_setup_ThisTabName(this.objCodeElement_Imports);
                        strTemp2 = Gen_CRUD_setup_btnDelete_Click(this.objCodeElement_Imports);
                        arrFuncName_Setup_Import.Add("btnDelete_Click");
                        break;
                    case enumPrjFeature.Query_0139:
                        strTemp2 = Gen_CRUD_setup_btnQuery_Click(this.objCodeElement_Imports);
                        arrFuncName_Setup_Import.Add("btnQuery_Click");
                        break;
                    case enumPrjFeature.CopyRecord_0141:
                        strTemp2 = Gen_CRUD_setup_btnCopyRecord_Click(this.objCodeElement_Imports);
                        arrFuncName_Setup_Import.Add("btnClone_Click");
                        break;

                    case enumPrjFeature.SetFieldValue_0148:
                        strTemp2 = Gen_CRUD_setup_btnSetFldValue_Click(this.objCodeElement_Imports,true);
                        //arrFuncName_Setup_Import.Add("btnClone_Click");
                        break;
                    case enumPrjFeature.ExportToFile_0143:
                        strTemp2 = Gen_CRUD_setup_btnExportExcel_Click(this.objCodeElement_Imports);
                        if (objViewInfoENEx.objViewRegion_ExportExcel != null)
                        {
                            arrFuncName_Setup_Import.Add("btnExportExcel_Click");
                        }
                        break;

                    case enumPrjFeature.AdjustOrderNum_1196:
                        strTemp2 = Gen_CRUD_setup_btnUpMove_Click(this.objCodeElement_Imports);
                        strTemp2 = Gen_CRUD_setup_btnDownMove_Click(this.objCodeElement_Imports);
                        strTemp2 = Gen_CRUD_setup_btnGoTop_Click(this.objCodeElement_Imports);
                        strTemp2 = Gen_CRUD_setup_btnGoBottum_Click(this.objCodeElement_Imports);
                        strTemp2 = Gen_CRUD_setup_btnReOrder_Click(this.objCodeElement_Imports);
                        arrFuncName_Setup_Import.Add("btnUpMove_Click");
                        arrFuncName_Setup_Import.Add("btnUpMove_Click");
                        arrFuncName_Setup_Import.Add("btnGoTop_Click");
                        arrFuncName_Setup_Import.Add("btnGoBottum_Click");
                        arrFuncName_Setup_Import.Add("btnReOrder_Click");

                        break;
                    case enumPrjFeature.DefaultFeature_0240:
                        break;
                    default:
                        var objPrjF = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeature.FeatureId);
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                clsStackTrace.GetCurrClassFunction(), objPrjF.FeatureName);
                        throw new Exception(strMsg);


                }
            }

            GetImportClassLst(objFuncModuleEN, strIsShare);

            arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            foreach (var objInFor in arrImportClass)
            {
                if (objInFor.ClsName == "clsEN")
                {
                    string strMsg = $"导入的类名为clsEN，不正确，请检查！";
                    throw new Exception(strMsg);
                }
                objInFor.ClsName = objInFor.ClsName;
                objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                          .Replace("../../TS/", "@/ts/")
                          .Replace("../../PubFun/", "@/ts/PubFun/")
                          .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                          .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                          .Replace("../TS/", "@/ts/");
            }
            var arrImportClass_RemoveDup = clsPubFun4GC.ImportClass_RemoveDup(arrImportClass);
            foreach (var objInFor in arrImportClass_RemoveDup)
            {
                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objInFor);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            }
            foreach (var objInFor in arrImportClass_RemoveDup)
            {
                if (objInFor.IsDefaultCls)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {0} from \"{1}\";",
                   objInFor.ClsName,
                     objInFor.FilePath.Replace(".js", "")
                           .Replace("../../TS/", "@/ts/")
                           .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                           .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                           .Replace("../TS/", "@/ts/"));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath.Replace(".js", "")
                              .Replace("../../TS/", "@/ts/")
                              .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                              .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                              .Replace("../TS/", "@/ts/"));
                }
            }

            //strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\"");

            //strCodeForCs.Append("\r\n" + $"import {{ cls{objViewInfoENEx.TabName}EN }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{objViewInfoENEx.TabName}EN\";");
            //strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}ENEx }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ENEx\";");

            strCodeForCs.Append("\r\n" + $"import {ThisClsName}Ex from \"@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{ThisClsName}Ex\";");
            //strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"@/viewsBase/{1}Share/{0}\";", ThisClsName, objFuncModule.FuncModuleEnName4GC());
            if (IsHasEditRegion) strCodeForCs.Append("\r\n" + $"import {ThisEditClsName}Com from '@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{ThisEditClsName}.vue';");
            if (IsHasDetailRegion) strCodeForCs.Append("\r\n" + $"import {ThisDetailClsName}Com from '@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{ThisDetailClsName}.vue';");
            if (IsHasListRegion) strCodeForCs.Append("\r\n" + $"import {ThisListClsName}Com from '@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{ThisListClsName}.vue';");



            bool bolIsNeedBindTrueAndFalse = false;
            List<string> arrTabFeatureId4Add = new List<string>();
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_06 &&
                    objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_Bool_18) continue;

                    if (objQryRegionFld.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                    {
                        bolIsNeedBindTrueAndFalse = true;
                    }
                    if (objQryRegionFld.CtlTypeId == enumCtlType.DropDownList_06 && objQryRegionFld.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                    {
                        bolIsNeedBindTrueAndFalse = true;
                    }

                    if (arrTabFeatureId4Add.Contains(objQryRegionFld.TabFeatureId4Ddl) == true) continue;
                    arrTabFeatureId4Add.Add(objQryRegionFld.TabFeatureId4Ddl);
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    var strIsExtendedClassFld = objTabFeature4Ddl.IsForExtendClassFld ? "Ex" : "";
                    if (ViewMainTabName4GC == objTabFeature4Ddl.TabName4GC && strIsExtendedClassFld == "")
                    {

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(objTabFeature4Ddl.TabName4GC) == true)
                        {
                            string strMsg = $"下拉框:{objQryRegionFld.CtrlId()}, 字段名:{objQryRegionFld.FldName}) 的相关下拉框表名为空，请检查！";
                            throw new Exception(strMsg);
                        }
                        strCodeForCs.Append("\r\n" + $"import {{ cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld} }} from \"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN{strIsExtendedClassFld}\";");
                    }
                }
            }
            if (bolIsNeedBindTrueAndFalse)
            {
                //strCodeForCs.Append("\r\n" + "import {BindDdl_TrueAndFalseInDivObj} from '@/ts/PubFun/clsCommFunc4Web';");
            }
            foreach (var objViewFeatureFlds in objViewInfoENEx.arrViewFeatureFlds)
            {
                if (objViewFeatureFlds.CtlTypeId != enumCtlType.DropDownList_06 &&
    objViewFeatureFlds.CtlTypeId != enumCtlType.DropDownList_Bool_18) continue;
                if (arrTabFeatureId4Add.Contains(objViewFeatureFlds.TabFeatureId4Ddl) == true) continue;
                arrTabFeatureId4Add.Add(objViewFeatureFlds.TabFeatureId4Ddl);
                if (string.IsNullOrEmpty(objViewFeatureFlds.TabFeatureId4Ddl)) continue;
                var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objViewFeatureFlds.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                if (ViewMainTabName4GC != objTabFeature4Ddl.TabName4GC)
                {
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.TabName4GC) == true)
                    {
                        string strMsg = $"下拉框:{objViewFeatureFlds.CtrlId}, 字段名:{objViewFeatureFlds.FldName}) 的相关下拉框表名为空，请检查！";
                        throw new Exception(strMsg);
                    }
                    strCodeForCs.Append("\r\n" + $"import {{ cls{objTabFeature4Ddl.TabName4GC}EN }} from \"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN\";");
                }

            }
            arrTabFeatureId4Add.RemoveRange(0, arrTabFeatureId4Add.Count);
            if (objViewInfoENEx.arrQryRegionFldSet != null)
            {
                //针对每一个表功能--下拉框
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_06 &&
                        objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_Bool_18) continue;
                    if (arrTabFeatureId4Add.Contains(objQryRegionFld.TabFeatureId4Ddl) == true) continue;
                    arrTabFeatureId4Add.Add(objQryRegionFld.TabFeatureId4Ddl);
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                    if (objTabFeature4Ddl.IsExtendedClass == true)
                    {
                        string strIsShare2 = "";
                        if (objPrjTabENEx_Ddl.IsShare == true) strIsShare2 = "Share";
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}Ex_{objTabFeature4Ddl.GetDdlDataFuncName4Ex} }} from \"@/ts/L3ForWApiEx{strIsShare2}/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}ExWApi\";");
                    }
                    else
                    {

                        string strByCondition = "";
                        if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                            strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";
                        if (string.IsNullOrEmpty(objTabFeature4Ddl.TabName4GC) == true)
                        {
                            string strMsg = $"下拉框:{objQryRegionFld.CtrlId()}, 字段名:{objQryRegionFld.FldName}(Out字段：{objQryRegionFld.OutFldName()}) 的相关下拉框表名为空，请检查！";
                            throw new Exception(strMsg);
                        }
                        string strFuncName = "";
                        if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                        {
                            strFuncName = $"GetArr{objTabFeature4Ddl.TabName4GC}{strByCondition}";
                        }
                        else
                        {
                            strFuncName = $"GetArr{objTabFeature4Ddl.TabName4GC}{strByCondition}";
                        }
                        if (string.IsNullOrEmpty(objTabFeature4Ddl.GetDdlDataFuncName4Ex) == false)
                        {
                            strFuncName = objTabFeature4Ddl.GetDdlDataFuncName4Ex;
                        }
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_{strFuncName} }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");

                    }
                }

            }
            //针对每一个表功能--下拉框
            foreach (var objQryRegionFld in objViewInfoENEx.arrViewFeatureFlds)
            {
                if (arrTabFeatureId4Add.Contains(objQryRegionFld.TabFeatureId4Ddl) == true) continue;
                arrTabFeatureId4Add.Add(objQryRegionFld.TabFeatureId4Ddl);
                if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                string strByCondition = "";
                if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                    strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";
                if (objTabFeature4Ddl.IsExtendedClass == true)
                {
                    string strIsShare2 = "";
                    if (objPrjTabENEx_Ddl.IsShare == true) strIsShare2 = "Share";
                    strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}Ex_{objTabFeature4Ddl.GetDdlDataFuncName4Ex} }} from \"@/ts/L3ForWApiEx{strIsShare2}/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}ExWApi\";");

                }
                else
                {
                    if (objPrjTabENEx_Ddl.IsUseCache_TS() == false)
                    {
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetArr{objTabFeature4Ddl.TabName4GC}{strByCondition} }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_GetArr{objTabFeature4Ddl.TabName4GC}{strByCondition} }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                    }
                }
            }

            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_setup_btnQuery_Click(CodeElement objCodeElement_Parent)
        {
            if (strFuncName4BindGv == "") return "";
            string strFuncName = $"btnQuery_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "const btnQuery_Click =  async () => ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnQuery_Click.name;",
            //ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = 1;");
            strCodeForCs.Append("\r\n" + "objPage.value.SetCurrPageIndex(1);");

            strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(refDivList.value);");

            strCodeForCs.Append("\r\n" + "}");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_btnExportExcel_Click(CodeElement objCodeElement_Parent)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";

            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = $"exportToExcel";
            CodeElement objCodeElement_Method0 = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method0);
            StringBuilder sbExportToExcel = new StringBuilder();
            sbExportToExcel.Append("\r\n" + "const exportToExcel = (");
            sbExportToExcel.Append("\r\n" + "arrData: Array<Record<string, any>>,");
            sbExportToExcel.Append("\r\n" + "strSheetName: string,");
            sbExportToExcel.Append("\r\n" + "strFileName: string,");
            sbExportToExcel.Append("\r\n" + ") => {");
            sbExportToExcel.Append("\r\n" + "try");
            sbExportToExcel.Append("\r\n" + "{");
            sbExportToExcel.Append("\r\n" + "// Convert object list to worksheet");
            sbExportToExcel.Append("\r\n" + "const worksheet = XLSX.utils.json_to_sheet(arrData);");
            sbExportToExcel.Append("\r\n" + "// Create a new workbook and append the worksheet");
            sbExportToExcel.Append("\r\n" + "const workbook = XLSX.utils.book_new();");
            sbExportToExcel.Append("\r\n" + "XLSX.utils.book_append_sheet(workbook, worksheet, strSheetName);");
            sbExportToExcel.Append("\r\n" + "// Export the workbook to an Excel file");
            sbExportToExcel.Append("\r\n" + "XLSX.writeFile(workbook, strFileName);");
            sbExportToExcel.Append("\r\n" + "alert('导出成功！');");
            sbExportToExcel.Append("\r\n" + "}");
            sbExportToExcel.Append("\r\n" + "catch (error)");
            sbExportToExcel.Append("\r\n" + "{");
            sbExportToExcel.Append("\r\n" + "console.error('导出失败:', error);");
            sbExportToExcel.Append("\r\n" + "alert('导出失败，请检查控制台日志！');");
            sbExportToExcel.Append("\r\n" + "}");
            sbExportToExcel.Append("\r\n" + "};");
            objCodeElement_Method0.CodeContent = sbExportToExcel.ToString();
            strCodeForCs.Append(sbExportToExcel.ToString());
            strFuncName = $"btnExportExcel_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder sbbtnExportExcel_Click = new StringBuilder();
            sbbtnExportExcel_Click.Append("\r\n /** 根据条件获取相应的对象列表");
            sbbtnExportExcel_Click.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            sbbtnExportExcel_Click.Append("\r\n" + " **/");
            sbbtnExportExcel_Click.AppendFormat("\r\n" + "const btnExportExcel_Click =  async ()=> ",
                TabName_Out4ListRegion4GC);
            sbbtnExportExcel_Click.Append("\r\n" + "{");
            sbbtnExportExcel_Click.Append("\r\n" + "if (objPage.value == null)");
            sbbtnExportExcel_Click.Append("\r\n" + "{");
            sbbtnExportExcel_Click.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
            sbbtnExportExcel_Click.Append("\r\n" + "return;");
            sbbtnExportExcel_Click.Append("\r\n" + "}");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = tnExportExcel_Click.name;",
            //ViewMainTabName4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            string strFuncName_Temp = "";
            if (this.IsUseFunc4ExcelExport == true && PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS() == true)
            {
                strFuncName_Temp = $"ExportExcel_{TabName_Out4ExportExcel4GC}4Func";
            }
            else if (PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS() == true)
            {
                strFuncName_Temp = $"ExportExcel_{TabName_Out4ExportExcel4GC}Cache";

            }
            else if (this.IsUseFunc4ExcelExport == true)
            {
                strFuncName_Temp = $"ExportExcel_{TabName_Out4ExportExcel4GC}4Func";
            }
            else
            {
                strFuncName_Temp = $"ExportExcel_{TabName_Out4ExportExcel4GC}";
            }
            sbbtnExportExcel_Click.Append("\r\n" + $"const objExportExcelData: ExportExcelData = await objPage.value.{strFuncName_Temp}();");
            sbbtnExportExcel_Click.Append("\r\n" + "if (objExportExcelData.sheetName == '')");
            sbbtnExportExcel_Click.Append("\r\n" + "{");
            sbbtnExportExcel_Click.Append("\r\n" + " alert('获取导出数据出错,请检查!');");
            sbbtnExportExcel_Click.Append("\r\n" + " return;");
            sbbtnExportExcel_Click.Append("\r\n" + " }");
            sbbtnExportExcel_Click.Append("\r\n" + "exportToExcel(objExportExcelData.arrObjLst, objExportExcelData.sheetName, objExportExcelData.fileName);");
            sbbtnExportExcel_Click.Append("\r\n" + "}");
            objCodeElement_Method.CodeContent = sbbtnExportExcel_Click.ToString();
            strCodeForCs.Append(sbbtnExportExcel_Click.ToString());
            return strCodeForCs.ToString();
        }


        public string Gen_CRUD_setup_btnGoBottum_Click(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"btnGoBottum_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 置底");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");

                strCodeForCs.Append("\r\n" + "const btnGoBottum_Click = async () =>");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnGoBottum_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (objPage.value.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");
                            
                            CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnGoBottum_Click()"),
                            //    DataType = "string",
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要置底的${thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoBottomAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoBottomAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(objCodeElement_Parent, strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `置底出错。错误:${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);
                 
                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);
                //strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_setup_btnReOrder_Click(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"btnReOrder_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);

            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 重序");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");

                strCodeForCs.Append("\r\n" + "const btnReOrder_Click = async () =>");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnReOrder_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (objPage.value.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass7 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");
                            CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);
                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            //    DataType = "string",
                            //    IsStatic = false,
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "set",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            //    DataType = "string",
                            //    IsStatic = false,
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");

                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.ReOrderAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.ReOrderAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(objCodeElement_Parent, strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `重序出错。错误:${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_btnGoTop_Click(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"btnGoTop_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            StringBuilder strCodeForCs = new StringBuilder();
            //string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /** 置顶");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");

                strCodeForCs.Append("\r\n" + "const btnGoTop_Click = async () =>");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnGoTop_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (objPage.value.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " const str{0}:string =$('#{1}').val();",
                        //  objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass9 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");
                            CodeElement objCodeElement_Import9 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass9);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import9);
                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                            //                "btnGoTop_Click()"),
                            //    DataType = "string",
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要置顶的${thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                           objInFor.FldName.ToLower(),
                           objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoTopAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoTopAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(objCodeElement_Parent, strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `置顶出错。错误:${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");
                ImportClass objImportClass6 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                //strCodeForCs.Append("\r\n" + "}");
                ImportClass objImportClass5 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_btnUpMove_Click(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"btnUpMove_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 上移");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");

                strCodeForCs.Append("\r\n" + "const btnUpMove_Click = async () =>");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnUpMove_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (objPage.value.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " const str{0}:string =$('#{1}').val();",
                        //    objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");
                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass4 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");
                            CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);
                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                            //                "btnUpMove_Click()"),
                            //    DataType = "string",
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要上移的${thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.UpMoveAsync)}(objOrderByData);");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.UpMoveAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(objCodeElement_Parent, strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `上移记录出错。错误:${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                ImportClass objImportClass7 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        protected bool Gene_ReFreshCache(CodeElement objCodeElement_Parent, StringBuilder sbCode)
        {
            //if (PrjTabEx_ListRegion.IsUseStorageCache_TS()== false)
            //{
            //    return;
            //}
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                sbCode.Append("\r\n" + $"const {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store = use{TabName_In4Edit4GC}Store();");

                sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({PrjTabEx_EditRegion.KeyPrivFuncFldNameLstStr});");
                ImportClass objImportClass = AddImportClass(TabId_In4Edit, clsString.FirstLcaseS(TabName_In4Edit4GC), $"use{TabName_In4Edit4GC}Store", enumImportObjType.StoreModule, $"@/store/modules{strIsShare}");
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
            }
            else if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    if (string.IsNullOrEmpty(thisCacheClassify4View.ViewVarName))
                    {
                        string strMsg = $"界面变量为空，请检查！（字段名:[{thisCacheClassify4View.FldName}]) in ({clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                    ImportClass objImportClass5 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);
                }
                else
                {
                    if (string.IsNullOrEmpty(thisCacheClassify4View.ViewVarName))
                    {
                        string strMsg = $"界面变量为空，请检查！（字段名:[{thisCacheClassify4View.FldName}]) in ({clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}, {2});", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                    ImportClass objImportClass6 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");
                    CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);
                    ImportClass objImportClass8 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");
                    CodeElement objCodeElement_Import8 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass8);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import8);
                }
                ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("ReFreshCache", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
            }
            else
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    if (string.IsNullOrEmpty(thisCacheClassify4View.ViewVarName))
                    {
                        string strMsg = $"界面变量为空，请检查！（字段名:[{thisCacheClassify4View.FldName}]) in ({clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    if (string.IsNullOrEmpty(thisCacheClassify4View.ViewVarName))
                    {
                        string strMsg = $"界面变量为空，请检查！（字段名:[{thisCacheClassify4View.FldName}]) in ({clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value, {2}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
                return false;
            }
            return true;
        }
        public string Gen_CRUD_setup_btnCopyRecord_Click(CodeElement objCodeElement_Parent)
        {
            if (strFuncName4BindGv == "") return "";
            if (PrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                return "//多关键字,不支持复制功能!";
            }
            string strFuncName = $"btnClone_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "const btnClone_Click = async () =>");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnClone_Click.name;",
        ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(`请选择需要克隆的${thisTabName}记录!`);");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "await objPage.value.CopyRecord(arrKeyIds);");

            strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `复制记录不成功,${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_SelfDefine_Click(clsFeatureRegionFldsENEx objFeatureRegionFldsENEx)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 自定义功能函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            string strFuncName = $"{objFeatureRegionFldsENEx.ButtonName}_Click";
            strCodeForCs.Append("\r\n" + $"const {strFuncName} = async () =>");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strThisFuncName = {strFuncName}.name;");

            strCodeForCs.Append("\r\n" + $"const strMsg = `函数:[{strFuncName}]还末定义.(in ${{thisConstructorName}}.${{strThisFuncName}}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_CRUD_setup_btnSetFldValue_Click(CodeElement objCodeElement_Parent, bool bolIsForImport)
        {
            if (strFuncName4BindGv == "") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    string strFuncName_SetFld = $"{objInFor.ButtonName}_Click";
                    if (bolIsForImport == true)
                    {
                        if (arrFuncName_Import.Contains(strFuncName_SetFld)) continue;
                        arrFuncName_Import.Add(strFuncName_SetFld);
                    }
                    else
                    {
                        if (arrFuncName_Setup.Contains(strFuncName_SetFld)) continue;
                        arrFuncName_Setup.Add(strFuncName_SetFld);
                    }
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());
                    StringBuilder sbFuncComment = new StringBuilder();
                    StringBuilder sbFuncCode = new StringBuilder();
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    sbFuncComment.AppendFormat("\r\n /** 设置字段值-{0}", objFieldTabEN.FldName);
                    sbFuncComment.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    sbFuncComment.Append("\r\n **/");
                    strCodeForCs.Append("\r\n" + sbFuncComment.ToString());

                    sbFuncCode.Append("\r\n" + $"const {strFuncName_SetFld} = async () =>");
                    sbFuncCode.Append("\r\n" + "{");
                    sbFuncCode.AppendFormat("\r\n" + "const strThisFuncName = {0}_Click.name;", objInFor.ButtonName);
                    sbFuncCode.Append("\r\n" + "if (objPage.value == null)");
                    sbFuncCode.Append("\r\n" + "{");
                    sbFuncCode.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
                    sbFuncCode.Append("\r\n" + "return;");
                    sbFuncCode.Append("\r\n" + "}");
                    sbFuncCode.Append("\r\n" + "try");
                    sbFuncCode.Append("\r\n" + "{");
                    sbFuncCode.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                    sbFuncCode.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    sbFuncCode.Append("\r\n" + "{");
                    sbFuncCode.Append("\r\n" + $"alert(`请选择需要设置{objInFor.ObjFieldTabENEx.Caption}的${{thisTabName}}记录!`);");
                    sbFuncCode.Append("\r\n" + "return \"\";");
                    sbFuncCode.Append("\r\n" + "}");

                    clsViewFeatureFldsENEx objViewFeatureFlds = null;
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                    }
                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
        && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }

                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        ASPControlEx objASPControlENEx = clsASPControlBLEx.GetControl_Asp(objViewFeatureFlds);

                        string strCtrlId = objASPControlENEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "Number":
                                sbFuncCode.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);
                                sbFuncCode.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                sbFuncCode.Append("\r\n" + "{");
                                sbFuncCode.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                sbFuncCode.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                sbFuncCode.Append("\r\n" + "//console.trace();");
                                sbFuncCode.Append("\r\n" + "alert(strMsg);");
                                sbFuncCode.Append("\r\n" + "return;");
                                sbFuncCode.Append("\r\n" + "}");
                                sbFuncCode.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                sbFuncCode.AppendFormat("\r\n" + "const {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                if (objViewFeatureFlds.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    sbFuncCode.Append("\r\n" + $"const {objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName} = GetCheckBoxValueInDivObj(divVarSet.refDivFunction, '{strCtrlId}');");
                                    ImportClass objImportClass3 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckBoxValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);
                                }
                                else
                                {
                                    sbFuncCode.Append("\r\n" + $"const {objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName} = {objViewFeatureFlds.ObjFieldTab1().PropertyName_TS(this.IsFstLcase)}_f.value == 'true' ? true : false;");
                      //              strCodeForCs.AppendFormat("\r\n" + "const {0}: boolean = $(\"#{1}\").prop(\"checked\");",
                      //objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                      //strCtrlId);
                                }
                                sbFuncCode.AppendFormat("\r\n" + "//console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                break;
                            default:
                                sbFuncCode.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                ImportClass objImportClass4 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                                CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);
                                sbFuncCode.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                sbFuncCode.Append("\r\n" + "{");
                                sbFuncCode.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                sbFuncCode.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                sbFuncCode.Append("\r\n" + "//console.trace();");
                                sbFuncCode.Append("\r\n" + "alert(strMsg);");
                                sbFuncCode.Append("\r\n" + "return;");
                                sbFuncCode.Append("\r\n" + "}");
                                sbFuncCode.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        sbFuncCode.Append("\r\n" + "//console.log('arrKeyIds=');");
                        sbFuncCode.Append("\r\n" + "//console.log(arrKeyIds);");
                        if (objViewFeatureFlds.ObjFieldTabENEx.IsNumberType())
                        {
                            sbFuncCode.AppendFormat("\r\n" + "const {0} = Number(str{2});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                        sbFuncCode.AppendFormat("\r\n" + "await objPage.value.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        sbFuncCode.Append("\r\n" + "//console.log('arrKeyIds=');");
                        sbFuncCode.Append("\r\n" + "//console.log(arrKeyIds);");
                        sbFuncCode.AppendFormat("\r\n" + "await objPage.value.{0}(arrKeyIds);", strFuncName);
                    }

                    sbFuncCode.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

                    sbFuncCode.Append("\r\n" + "}");
                    sbFuncCode.Append("\r\n" + "catch(e)");
                    sbFuncCode.Append("\r\n" + "{");
                    sbFuncCode.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${thisConstructorName}.${strThisFuncName}`;");

                    sbFuncCode.Append("\r\n" + "console.error(strMsg);");

                    sbFuncCode.Append("\r\n" + "alert(strMsg);");

                    sbFuncCode.Append("\r\n" + "}");
                    sbFuncCode.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + sbFuncCode.ToString());
                    if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(new CodeElement
                    {
                        Name = strFuncName_SetFld,
                        CodeContent = sbFuncCode.ToString(),
                        DocumentationComment = sbFuncComment.ToString(),
                        ElementType = CodeElementType.Method,
                        Modifiers = "export const"
                    });
                }//                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_ThisTabName(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"thisTabName";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * 获取当前界面的主表名");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "const thisTabName=()=>{");
            strCodeForCs.Append("\r\n" + $"return cls{objViewInfoENEx.TabName}EN._CurrTabName;");
            strCodeForCs.Append("\r\n" + "}");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_btnDelete_Click(CodeElement objCodeElement_Parent)
        {

            if (PrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//由于当前主表:[${PrjTabEx_View.TabName}]是视图,不需要生成删除功能函数[btnDelete_Click];";
            string strFuncName = $"btnDelete_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 删除记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.Append("\r\n" + "const btnDelete_Click = async () =>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnDelete_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_ListRegion.arrKeyFldSet.Count == 1)
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(arrKeyIds.length) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

                strCodeForCs.AppendFormat("\r\n" + "await objPage.value.DelMultiRecord(arrKeyIds);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyLsts = GetCheckedKeyLstsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyLstsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                strCodeForCs.Append("\r\n" + "if (arrKeyLsts.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(arrKeyLsts.length) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

                strCodeForCs.AppendFormat("\r\n" + "await objPage.value.DelMultiRecord_KeyLst(arrKeyLsts);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }
            strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `删除${thisTabName}记录不成功. ${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_btnDelRecordInTab_Click()
        {
            if (PrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//由于当前主表:[${PrjTabEx_View.TabName}]是视图,不需要生成删除功能函数[btnDelRecordInTab_Click];";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * 在数据表里删除记录");
            foreach (var objInFor in PrjTabEx_ListRegion.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n * \"{0}\": 表关键字", objInFor.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (PrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {

                strCodeForCs.Append("\r\n" + $"const btnDelRecordInTab_Click = async ({PrjTabEx_ListRegion.KeyVarDefineLstStr_TS}) =>");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnDelRecordInTab_Click.name;",
           ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (var objInFor in PrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType() == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if (IsNullOrEmpty({0}) == true)", objInFor.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if ({0} == 0)", objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${thisTabName}记录!`);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "if (confirmDel(0) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
                strCodeForCs.AppendFormat("\r\n" + "await objPage.value.DelRecord({0});", PrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS);
            }
            else
            {

                strCodeForCs.Append("\r\n" + $"const btnDelRecordInTab_Click = async (strKeyId:string) =>");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnDelRecordInTab_Click.name;",
                    ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(0) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "await objPage.value.DelRecord(lngKeyId);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await objPage.value.DelRecord(strKeyId);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
                }
            }
            strCodeForCs.Append("\r\n" + $" await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `删除${thisTabName}记录不成功. ${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_setup_btnCreate_Click(CodeElement objCodeElement_Parent)
        {
            if (objViewInfoENEx.objViewRegion_Edit == null) return "";

            string strFuncName = $"btnCreate_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.Append("\r\n" + $"const btnCreate_Click = async () =>");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnCreate_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"objPage_Edit.value = new {ThisEditClsName}Ex('{ThisEditClsName}Ex', objPage.value);");
            strCodeForCs.Append("\r\n" + "if (objPage_Edit.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('编辑页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "opType.value = \"Add\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await objPage_Edit.value.ShowDialog_{TabName_In4Edit}(opType.value);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");
            //strCodeForCs.AppendFormat("\r\n" + "await objPage.value.BindDdl4EditRegionInDiv();", ThisClsName);

            strCodeForCs.Append("\r\n" + $"if (['02', '03', '06'].indexOf(cls{TabName_In4Edit}EN._PrimaryTypeId) > -1)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "await objPage_Edit.value.AddNewRecordWithMaxId();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await objPage_Edit.value.AddNewRecord();",
            TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, objPage_Edit.value.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_setup_btnUpdate_Click(CodeElement objCodeElement_Parent)
        {
            if (objViewInfoENEx.objViewRegion_Edit == null) return "";
            string strFuncName = $"btnUpdate_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);

            List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
            var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

            string strFuncPara = "";
            if (thisEditTabProp_TS.KeyFldCount >= 1) strFuncPara = thisEditTabProp_TS.KeyVarDefineLstStr;
            else strFuncPara = thisEditTabProp_TS.KeyVarDefineLstStr;
            if (objFeatureRegionFlds_Update == null)
            {
                if (strFuncPara == "") strFuncPara = "strKeyId: string";
            }
            else if (objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strFuncPara = "";

            }
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.Append("\r\n" + $"const btnUpdate_Click = async () =>");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnUpdate_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"objPage_Edit.value = new {ThisEditClsName}Ex('{ThisEditClsName}Ex', objPage.value);");
            strCodeForCs.Append("\r\n" + "if (objPage_Edit.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('编辑页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            string strGetFirstCheckedValue = clsPubFun4GC.Gen_GetFirstCheckedValue(this.objCodeElement_Imports, objEditTabProp_TS, "修改", this, this.strBaseUrl);
            strCodeForCs.Append("\r\n" + strGetFirstCheckedValue);
            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objFeatureRegionFlds_Update == null
                    || string.IsNullOrEmpty(objFeatureRegionFlds_Update.KeyIdGetModeId)
                    || objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
                {
                    if (objKeyField.IsNumberType())
                    {
                        strCodeForCs.Append("\r\n" + $"if ({objKeyField.PrivFuncName} == 0)");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"if (IsNullOrEmpty({objKeyField.PrivFuncName}) == true)");
                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"修改记录的关键字为空,请检查!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKeyId = {0}.{1}Static;", this.ClsName, objKeyField.FldName);
                    if (objKeyField.IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录!\");");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            strCodeForCs.Append("\r\n" + "try {");

            strCodeForCs.Append("\r\n" + "opType.value = \"Update\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await objPage_Edit.value.ShowDialog_{TabName_In4Edit}(opType.value);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");

            //strCodeForCs.AppendFormat("\r\n" + "await objPage.value.BindDdl4EditRegionInDiv();", ThisClsName);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + $"const lngKeyId =  {objKeyField.PrivFuncName};");

                    strCodeForCs.AppendFormat("\r\n" + "const update = await objPage_Edit.value.UpdateRecord(lngKeyId);",
                     TabName_In4Edit4GC, TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const update = await objPage_Edit.value.UpdateRecord({objKeyField.PrivFuncName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const update = await objPage_Edit.value.UpdateRecord({0});",
                    thisEditTabProp_TS.KeyPrivVarNameLstStr);
            }
            strCodeForCs.Append("\r\n" + "if (update == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"在修改记录时,显示记录数据不成功!\");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})\", e, objPage_Edit.value.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_setup_btnDetail_Click(CodeElement objCodeElement_Parent)
        {

            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            string strFuncName = $"btnDetail_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);

            var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);

            string strFuncPara = "strKeyId: string";

            if (objFeatureRegionFlds_Detail == null)
            {
                strFuncPara = "strKeyId: string";
            }
            else if (objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strFuncPara = "";
            }

            if (thisEditTabProp_TS.KeyFldCount > 1) strFuncPara = thisEditTabProp_TS.KeyVarDefineLstStr;

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + $"const btnDetail_Click = async  () => {{");

            strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"objPage_Detail.value = new {ThisDetailClsName}Ex(objPage.value);");
            strCodeForCs.Append("\r\n" + "if (objPage_Detail.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert('编辑页面初始化不成功,请联系管理员!');");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            string strGetFirstCheckedValue = clsPubFun4GC.Gen_GetFirstCheckedValue(this.objCodeElement_Imports, objEditTabProp_TS, "详细信息", this, this.strBaseUrl);
            strCodeForCs.Append("\r\n" + strGetFirstCheckedValue);

            strCodeForCs.Append("\r\n" + "opType.value = \"Detail\";");
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await objPage_Detail.value.ShowDialog_{TabName_Out4DetailRegion}('Detail');");
                strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");
            }


            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidOpType_d",
            //    PropertyName = "OpType_d",
            //    Comment = "设置操作类型：Add||Update||Detail",
            //    DataType = "string"
            //});
            if (objFeatureRegionFlds_Detail == null
                || string.IsNullOrEmpty(objFeatureRegionFlds_Detail.KeyIdGetModeId)
                || objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
            {
                if (thisDetailTabProp_TS.KeyFldCount > 1)
                {
                    foreach (var objInFor in PrjTabEx_DetailRegion.arrKeyFldSet)
                    {
                        if (objInFor.IsNumberType() == true)
                        {
                            strCodeForCs.Append("\r\n" + $"if ({objInFor.PrivFuncName}== 0)");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"if (IsNullOrEmpty({objInFor.PrivFuncName}) == true)");
                        }
                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);
                        CodeElement objCodeElement_Import  = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "const strMsg = \"需要显示详细信息记录的关键字为空,请检查!\";");
                        strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                        strCodeForCs.Append("\r\n" + "alert(strMsg);");

                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                else
                {
                    //strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                    //AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                    //strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "const strMsg = \"需要显示详细信息记录的关键字为空,请检查!\";");
                    //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    //strCodeForCs.Append("\r\n" + "alert(strMsg);");

                    //strCodeForCs.Append("\r\n" + "}");
                }
            }
            else if (objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKeyId = {0}.{1}Static;", this.ClsName, objKeyField.FldName);
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"在显示详细信息时,界面静态关键字为空!(In btnDetailRecord_Click)\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "//const conBindDdl = await this.BindDdl4DetailRegion();", ThisClsName);

            //strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadDetailRegion = true;  //", ThisClsName);
            string strSuffix4Func = "";//后缀4Func
            if (bolIsUseFunc4Detail == true) strSuffix4Func = "4Func";
            if (thisDetailTabProp_TS.KeyFldCount > 1)
            {
                strCodeForCs.Append("\r\n" + $"objPage_Detail.value.DetailRecord{strSuffix4Func}({thisDetailTabProp_TS.KeyPrivVarNameLstStr} );");
            }
            else
            {

                strCodeForCs.Append("\r\n" + $"objPage_Detail.value.DetailRecord{strSuffix4Func}({objKeyField.PrivFuncName});");

            }
            strCodeForCs.Append("\r\n" + "}");
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_CRUD_method_GeneEventFuncEx(CodeElement objCodeElement_Parent)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrQryRegionFlds_ChangeEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strFuncName = x.ChangeEvent;
                    CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.EventHandler, Modifiers = "export abstract" };
                    objCodeElement_Parent.Children.Add(objCodeElement_Method);

                    StringBuilder sbEvent = new StringBuilder();
                    StringBuilder sbEventComment = new StringBuilder();
                    sbEventComment.Append("\r\n /** 函数功能:系统生成的Change事件函数");
                    sbEventComment.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    sbEventComment.Append("\r\n" + " **/");
                    sbEvent.Append("\r\n" + $"async {x.ChangeEvent} (e: Event)");

                    sbEvent.Append("\r\n" + "{");
                    sbEvent.Append("\r\n" + "console.log(e)");
                    sbEvent.AppendFormat("\r\n" + "alert('请在当前函数中重写该函数!');", ThisClsName);
                    sbEvent.Append("\r\n" + "},");
                    strCodeForCs.Append("\r\n" + sbEventComment.ToString());
                    strCodeForCs.Append("\r\n" + sbEvent.ToString());
                    objCodeElement_Method.CodeContent = sbEvent.ToString();
                    objCodeElement_Method.DocumentationComment= sbEvent.ToString();

                });

                strCodeForCs.Append("\r\n" + "");

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.Append("\r\n" + $"async  {x.ClickEvent} (e: Event) {{");
                    arrFuncName_Setup.Add(x.ClickEvent);
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中重写该函数!');", ThisClsName);
                    strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_CRUD_setup_btnDownMove_Click(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"btnDownMove_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            if (objCodeElement_Parent.ElementType != CodeElementType.Import) objCodeElement_Parent.Children.Add(objCodeElement_Method);
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 下移");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "const btnDownMove_Click =  async() =>");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnDownMove_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (objPage.value == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert('页面初始化不成功,请联系管理员!');");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (objPage.value.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {this.ClsName}.{objInFor.VarName}Static;");
                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass2 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");
                            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);
                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            //{
                            //    OperateType = "get",
                            //    ControlType = objInFor.CtlTypeName,
                            //    CtrlId = objInFor.CtrlId,
                            //    PropertyName = objInFor.CtrlId.Substring(3),
                            //    Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                            //                "btnDownMove_Click()"),
                            //    DataType = "string",
                            //    ParentDivName = $"divVarSet.refDivFunction"
                            //});
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);
                strCodeForCs.Append("\r\n" + "    if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要下移的${thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.DownMoveAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.DownMoveAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(objCodeElement_Parent, strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `下移记录出错。错误:${e}.(in ${thisConstructorName}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + $"await objPage.value.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                ImportClass objImportClass1 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);
                CodeElement objCodeElement_Import1 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass1);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import1);
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_Template_DefDiv4CRUD(CodeElement objCodeElement_Parent)
        {
            clsViewRegionEN objViewRegion_Edit = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            CodeElement objCodeElement_Template = new CodeElement { Name = "template", ElementType = CodeElementType.Template, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Template);
            StringBuilder strCodeForCs = new StringBuilder();
            
            strCodeForCs.Append("\r\n" + "<template>");
            strCodeForCs.Append("\r\n" + "<div id = \"divLayout\" ref=\"refDivLayout\" class = \"div_layout\"> ");

            strCodeForCs.Append("\r\n" + "<!--标题层-->");
            strCodeForCs.AppendFormat("\r\n" + GenViewTitle(string.Format("{0}", objViewInfoENEx.ViewCnName), objViewInfoENEx));

            //生成查询区域代码-------------------------------
            if (objViewInfoENEx.objViewRegion_Query != null)
            {
                intZIndex += 1;
                intCurrTop += 25;
                intCurrLeft = 10;

                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
                {
                    ///生成专门用于查询的界面控件的代码;
                    strCodeForCs.Append("\r\n" + "<!--查询层-->");
                    strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
                    intCurrTop += 40;
                }

                //生成GridView的代码;

                //				objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() = true;
                //				objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() = true;

                objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
                {
                    strCodeForCs.Append("\r\n" + "<!--功能区-->");
                    strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));
                }
                if (objViewRegion_Edit != null)
                {
                    ASPDivEx objDiv_Row;
                    ASPDivEx objDiv_List;
                    ASPDivEx objDiv_Edit;
                    switch (objViewRegion_Edit.PageDispModeId)
                    {
                        case enumPageDispMode.PopupBox_01:
                            GeneCode4ListRegion(strCodeForCs);
                            GeneCode4EditRegion(strCodeForCs);
                            break;
                        case enumPageDispMode.Right_02:
                            objDiv_Row = clsASPDivBLEx.GetEmptyDiv();
                            objDiv_Row.Class = "row";
                            objDiv_List = GetDiv4ListRegion();
                            objDiv_Edit = GetDiv4EditRegion();
                            objDiv_List.Class += " col-9";
                            objDiv_Edit.Class += " col-3";
                            objDiv_Row.arrSubAspControlLst2.Add(objDiv_List);
                            objDiv_Row.arrSubAspControlLst2.Add(objDiv_Edit);
                            objDiv_Row.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                            break;
                        case enumPageDispMode.Left_04:
                            objDiv_Row = clsASPDivBLEx.GetEmptyDiv();
                            objDiv_Row.Class = "row";
                            objDiv_List = GetDiv4ListRegion();
                            objDiv_Edit = GetDiv4EditRegion();
                            objDiv_List.Class += " col-9";
                            objDiv_Edit.Class += " col-3";
                            objDiv_Row.arrSubAspControlLst2.Add(objDiv_Edit);
                            objDiv_Row.arrSubAspControlLst2.Add(objDiv_List);
                            objDiv_Row.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                            break;
                        case enumPageDispMode.Below_03:
                            GeneCode4ListRegion(strCodeForCs);
                            GeneCode4EditRegion(strCodeForCs);
                            break;
                        default:
                            GeneCode4ListRegion(strCodeForCs);
                            GeneCode4EditRegion(strCodeForCs);
                            break;
                    }
                }
                else
                {
                    GeneCode4ListRegion(strCodeForCs);
                }
                //strCodeForCs.Append("\r\n" + GenGridViewNew(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

                if (objViewInfoENEx.objViewRegion_List != null && objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    strCodeForCs.Append("\r\n" + "<INPUT id = \"rd\" style = \"z-index: 109; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px\" type = \"hidden\" size = \"1\" name = \"rd\" runat = \"server\"> ");
                    strCodeForCs.Append("\r\n" + "<INPUT style = \"display: none; z-index: 110; left: 8px; position: absolute; top: 1px\" type = \"radio\" CHECKED name = \"RadioName\">");
                }


            }
            //生成查询区域代码 == == == == == == == == == == == == == == == 

            if (IsHasDetailRegion)
            {
                //生成编辑区域代码-------------------------------

                ///生成用于布局的表格代码;
                strCodeForCs.Append("\r\n" + "<!--详细信息层-->");

                strCodeForCs.AppendFormat("\r\n" + "<{0}Com ref='ref{0}'></{0}Com>", ThisDetailClsName);
                //strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4EditRegion());
            }

            //生成编辑区域代码 == == == == == == == == == == == == == == 

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</template>");
            objCodeElement_Template.CodeContent = strCodeForCs.ToString();

            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_Script_DefDiv4CRUD(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Script = new CodeElement { Name = "script", ElementType = CodeElementType.Script, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Script);


            objCodeElement_Script.Children.Add(this.objCodeElement_Imports);


            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            //生成编辑区域代码 == == == == == == == == == == == == == == 
            try
            {

                strCodeForCs.Append("\r\n" + "<script lang=\"ts\">");
                //strCodeForCs.Append("\r\n" + "import \"~/lib/xlsx.core.min\" ");
                //strCodeForCs.Append("\r\n" + "import \"~/lib/xlsx.full.min\" ");
                //strCodeForCs.Append("\r\n" + "import $ from \"jquery\";");

                objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

                strCodeForCs.Append("\r\n" + Gen_CRUD_import_All(objCodeElement_Script));

                strCodeForCs.Append("\r\n" + "      export  default defineComponent({");

                strCodeForCs.Append("\r\n" + $"name: '{clsString.FirstUcaseS(ThisClsName)}',");


                strCodeForCs.Append("\r\n" + Gen_CRUD_Components_All(objCodeElement_Script));

                strCodeForCs.Append("\r\n" + Gen_CRUD_setup_All(objCodeElement_Script));
                strCodeForCs.Append("\r\n" + "        watch: {");
                strCodeForCs.Append("\r\n" + "            // 数据监听");
                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + "        mounted() {");

                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + Gen_CRUD_method_All(objCodeElement_Script));

                strCodeForCs.Append("\r\n" + "    });");
                strCodeForCs.Append("\r\n" + "</script>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            objCodeElement_Script.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_Style_DefDiv4CRUD(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Style = new CodeElement { Name = "style", ElementType = CodeElementType.Style, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Style);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "<style scoped>");
            //strCodeForCs.Append("\r\n" + "@import \"../../../node_modules/bootstrap/dist/css/bootstrap.css\";");
            //strCodeForCs.Append("\r\n" + "@import \"../../../node_modules/bootstrap/dist/js/bootstrap.min.js\";");
            strCodeForCs.Append("\r\n" + "</style>");

            objCodeElement_Style.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_CRUD_Setup_Return(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"return";
            CodeElement objCodeElement_SetupReturn = new CodeElement { Name = strFuncName, ElementType = CodeElementType.SetupReturn, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_SetupReturn);
            List<string> arrTemp = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n" + "return {");
                strCodeForCs.Append("\r\n" + "showErrorMessage,");
                strCodeForCs.Append("\r\n" + $"dataList{TabName_Out4ListRegion},");
                strCodeForCs.Append("\r\n" + "emptyRecNumInfo,");
                strCodeForCs.Append("\r\n" + "dataColumn,");

                strCodeForCs.Append("\r\n" + "strTitle,");
                strCodeForCs.Append("\r\n" + "btn_Click,");

                strCodeForCs.Append("\r\n" + "...divVarSet,");
                strCodeForCs.Append("\r\n" + "refDivLayout,\r\n        refDivQuery,\r\n        refDivFunction,\r\n        refDivList,\r\n        ");
                if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "ref{0},", ThisEditClsName);
                if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "ref{0},", ThisDetailClsName);
                if (IsHasListRegion) strCodeForCs.AppendFormat("\r\n" + "ref{0},", ThisListClsName);
                if (objViewInfoENEx.arrQryRegionFldSet != null)
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFldsEx.InUse == false) continue;
                        if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().PropertyName_TS(this.IsFstLcase));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0}_q,", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                        }
                    }
                }
                foreach (clsViewFeatureFldsENEx objViewFeatureFldsEx in objViewInfoENEx.arrViewFeatureFlds)
                {
                    //if (objQryRegionFldsEx.InUse == false) continue;
                    if (objViewFeatureFldsEx.FieldTypeId == enumFieldType.OrderNumField_09) continue;
                    strCodeForCs.AppendFormat("\r\n" + "{0}_f,", objViewFeatureFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                }
                var arrTabName4GC = new List<string>();
                if (objViewInfoENEx.arrQryRegionFldSet != null)
                {
                    foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        if (objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_06 &&
                      objQryRegionFld.CtlTypeId != enumCtlType.DropDownList_Bool_18) continue;

                        if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                        var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                        if (arrTabName4GC.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                        arrTabName4GC.Add(objTabFeature4Ddl.TabName4GC);
                        strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC},");
                    }
                }
                //arrTabName4GC.RemoveRange(0, arrTabName4GC.Count);
                foreach (var objViewFeatureFldsEx in objViewInfoENEx.arrViewFeatureFlds)
                {
                    if (string.IsNullOrEmpty(objViewFeatureFldsEx.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objViewFeatureFldsEx.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTabName4GC.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTabName4GC.Add(objTabFeature4Ddl.TabName4GC);
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC},");
                }
                foreach (string objForIn in arrFuncName_Setup)
                {
                    strCodeForCs.Append("\r\n" + $"{objForIn},");
                };
                strCodeForCs.Append("\r\n" + "};");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_SetupReturn.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_Setup_btn_Click(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"btn_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            List<string> arrTemp = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n" + "function btn_Click(strCommandName: string, strKeyId: string) {");
                //alert(Format("命令:{0}, 关键字:{1}.", strCommandName, strKeyId));
                strCodeForCs.Append("\r\n" + "switch (strCommandName)");
                strCodeForCs.Append("\r\n" + "{");
                if (IsHasDetailRegion)
                {
                    strCodeForCs.Append("\r\n" + "case 'Detail':");
                    //strCodeForCs.AppendFormat("\r\n" + "{0}.DetailObj = ref{1};", ThisClsName, ThisDetailClsName);
                    //strCodeForCs.AppendFormat("\r\n" + "{0}.DetailObj = ref{0};", ThisDetailClsName);
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (IsHasEditRegion)
                {
                    strCodeForCs.Append("\r\n" + "case 'Create':");
                    strCodeForCs.Append("\r\n" + "case 'AddNewRecordWithMaxId':");
                    strCodeForCs.Append("\r\n" + "case 'CreateWithMaxId':");
                    strCodeForCs.Append("\r\n" + "case 'Update':");
                    strCodeForCs.Append("\r\n" + "case 'UpdateRecord':");
                    strCodeForCs.Append("\r\n" + "case 'UpdateRecordInTab':");

                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}Ex.btn_Click(strCommandName, strKeyId);", ThisClsName);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_Setup_GetPropValue(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"GetPropValue";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            List<string> arrTemp = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n" + "function GetPropValue(strPropName: string): string {");
                strCodeForCs.Append("\r\n" + "switch (strPropName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case 'strTitle':");
                strCodeForCs.Append("\r\n" + "return strTitle.value;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "return '';");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_CRUD_Setup_onMounted(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"onMounted";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.OnMounted, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            List<string> arrTemp = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n" + "onMounted(async () => {");

                strCodeForCs.Append("\r\n" + "await BindDdl4QryRegion();");
                strCodeForCs.Append("\r\n" + "await BindDdl4FeatureRegion();");

                strCodeForCs.Append("\r\n" + $"{ThisClsName}Ex.vuebtn_Click = btn_Click;");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}Ex.GetPropValue = GetPropValue;");

                strCodeForCs.AppendFormat("\r\n" + "objPage.value = new {0}Ex();", ThisClsName);
                //strCodeForCs.Append("\r\n" + $"objPage.divLayout = refDivLayout.value;");
                //strCodeForCs.Append("\r\n" + $"objPage.divQuery = refDivQuery.value;");
                //strCodeForCs.Append("\r\n" + $"objPage.divFunction = refDivFunction.value;");
                //strCodeForCs.Append("\r\n" + $"objPage.divList = refDivList.value;");
                strCodeForCs.Append("\r\n" + "await objPage.value.PageLoadCache();");
                strCodeForCs.Append("\r\n" + "});");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_CRUD_Components_All(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"components";
            CodeElement objCodeElement_Components = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Components, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Components);
            List<string> arrTemp = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n" + "        components: {");
                strCodeForCs.Append("\r\n" + "            // 组件注册");
                if (IsHasEditRegion) strCodeForCs.AppendFormat("\r\n" + "{0}Com,", ThisEditClsName);
                if (IsHasDetailRegion) strCodeForCs.AppendFormat("\r\n" + "{0}Com,", ThisDetailClsName);
                if (IsHasListRegion) strCodeForCs.AppendFormat("\r\n" + " {0}Com,", ThisListClsName);

                strCodeForCs.Append("\r\n" + "        },");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Components.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
    }
}
