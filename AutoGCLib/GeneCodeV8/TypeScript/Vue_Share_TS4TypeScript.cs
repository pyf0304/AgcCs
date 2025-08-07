using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Configuration;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// </summary>
    partial class Vue_Share_TS4TypeScript : clsGeneCodeBase4View
    {
        enum EnumConditionType : int
        {
            Object_1 = 1,
            String_2 = 2
        }

        private bool bolIsNeedGeneReMapFunc = false;
        protected clsPrjTabENEx objPrjTabEx_ListRegion = null;
        protected List<clsPropertyDef4GC> arrPropertyDef4GC = null;

        //private string strTabName_Out4ListRegion = "";
        //private string strTabId_Out4ListRegion = "";
        private string strJSPath = "";
        private clsFuncModule_AgcEN objFuncModule = null;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public Vue_Share_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_Share_TS4TypeScript(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_Share_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
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







        public string Gen_Share_method_BindTabByList()
        {
            if (string.IsNullOrEmpty(TabName_Out4ListRegion) == true) return "";
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n * 通过List组件来绑定表数据");
            //生成与条件参数的函数说明            
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.Append("\r\n" + "export const BindTabByList = async(");
            string strFuncName = "BindTabByList";
            strCodeForCs.Append("\r\n" + $"arrObjLst: Array<cls{TabName_Out4ListRegion}ENEx>,");
            strCodeForCs.Append("\r\n" + "bolIsShowErrMsg: boolean,");
            strCodeForCs.Append("\r\n" + "): Promise<void> => {");
            strCodeForCs.Append("\r\n" + $"dataList{TabName_Out4ListRegion}.value = arrObjLst;");
            strCodeForCs.Append("\r\n" + "showErrorMessage.value = bolIsShowErrMsg;");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisListClsName}.value != null) ref{ThisListClsName}.value.selectAllChecked = false;");
            strCodeForCs.Append("\r\n" + "};");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Root, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_setup_ts_GetDdlData()
        {
            List<string> arrCacheFldName = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase);
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN[]>([]);");
                }
                //针对每一个表功能--下拉框
                foreach (var objQryRegionFld in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (string.IsNullOrEmpty(objQryRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId(objQryRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase);

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
                        objFuncParaLst.AddParaByCacheClassify(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09);
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

                    strCodeForCs.Append("\r\n" + $"obj0.{clsString.FstLcaseS(objTabFeature4Ddl.TextFieldName)} = '{strToolTipText}...';");

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
                    strCodeForCs.Append("\r\n" + $"{objQryRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q.value = '0';");
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


        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            string strFuncName = "";

            clsViewRegionEN objViewRegion_Edit = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            if (string.IsNullOrEmpty(TabId_Out4ListRegion) == false)
            {
                var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objViewInfoENEx.PrjId);
                //if (objPrjTab_ListRegion != null)
                //{
                //    strSqlDsTypeId4ListRegion = objPrjTab_ListRegion.SqlDsTypeId;
                //}

                objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
                objPrjTabEx_ListRegion.GetObjAllInfoEx();
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.ts",
                objViewInfoENEx.FolderName, ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objViewInfoENEx);
            this.objCodeElement_Root = new CodeElement { Name = "Root", ElementType = CodeElementType.Root };
            this.objCodeElement_Imports = new CodeElement { Name = "imports", ElementType = CodeElementType.Import, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Imports);

            try
            {
                //获取界面所需要的公共变量

                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                //if (string.IsNullOrEmpty(this.TabId_Out4ListRegion) == false) this.GetViewPubVarLst(this.TabId_Out4ListRegion);
                if (string.IsNullOrEmpty(this.TabId_Out4ListRegion) == false) this.GetViewIdVarRelaVarLst(objViewInfoENEx.ViewId);
                strCodeForCs.Append("\r\n" + Gen_Share_import_GeneCode());

                //strCodeForCs.Append("\r\n" + "import { reactive, ref } from 'vue';");
                //strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\"");
                ////strCodeForCs.Append("\r\n" + "import router from '@/router';");
                //strCodeForCs.Append("\r\n" + "import { clsDataColumn } from '@/ts/PubFun/clsDataColumn';");
                //strCodeForCs.Append("\r\n" + "import { ConditionCollection } from '@/ts/PubFun/ConditionCollection';");

                //strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}EN }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}EN\";");
                //strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}ENEx }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ENEx\";");
                if (objViewInfoENEx.arrQryRegionFldSet != null)
                {
                    var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
                    if (arrQryRegionFldSetEx.Count > 0)
                    {
                        bool bolIsAddintersectSets_Number = false;
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx_In in arrQryRegionFldSetEx)
                        {
                            string strIsShare = "";
                            if (objPrjTabEx_ListRegion.IsShare) strIsShare = "Share";

                            strCodeForCs.Append("\r\n" + $"import {{ {TabName_Out4ListRegion}Ex_FuncMapKey{objQryRegionFldsEx_In.DataPropertyName()} }} from '@/ts/L3ForWApiEx{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ExWApi';");
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                            {
                                ElementType = CodeElementType.Import,
                                Name = $"{TabName_Out4ListRegion}Ex_FuncMapKey{objQryRegionFldsEx_In.DataPropertyName()}",
                                From = $"@/ts/L3ForWApiEx{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ExWApi"
                            });
                            if (bolIsAddintersectSets_Number == false)
                            {
                                if (objQryRegionFldsEx_In.ObjFieldTab().IsNumberType() == true)
                                {
                                    strCodeForCs.Append("\r\n" + "import { intersectSets_Number } from '@/ts/PubFun/clsCommFunc4Ctrl';");
                                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                                    {
                                        ElementType = CodeElementType.Import,
                                        Name = "intersectSets_Number",
                                        From = "@/ts/PubFun/clsCommFunc4Ctrl"
                                    });
                                }
                                bolIsAddintersectSets_Number = true;
                            }
                        }

                        strCodeForCs.Append("\r\n" + "import { intersectSets } from '@/ts/PubFun/clsCommFunc4Ctrl';");
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                        {
                            ElementType = CodeElementType.Import,
                            Name = "intersectSets",
                            From = "@/ts/PubFun/clsCommFunc4Ctrl"
                        });
                    }
                }
              
                strCodeForCs.Append("\r\n" + Gen_Share_const_ViewVar());
                strCodeForCs.Append("\r\n" + Gen_Share_const_PubVar());
                strCodeForCs.Append("\r\n" + Gen_Share_const_ShareVar());
                strCodeForCs.Append("\r\n" + Gen_Share_const_DataListVarDef());
                strCodeForCs.Append("\r\n" + Gen_Share_const_QryVarDef());
                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_EditVarDef());
                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_DetailVarDef());
                strCodeForCs.Append("\r\n" + Gen_Share_const_FeatureVarDef());

                strCodeForCs.Append("\r\n" + Gen_Share_method_ExportFuncDef());
                strCodeForCs.Append("\r\n" + Gen_Share_method_DeleteKeyIdCache());

                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_DivVarDef());

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

                IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, enumViewImplementation.FunctionRegion_0001, objViewInfoENEx, "");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup)
                    .OrderBy(x => x.GroupName).ToList();


                //IEnumerable<VueButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsVueButtonBLEx.GetButton4MvcAjax);
                IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);


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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_Share_TS4TypeScript);
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
            this.ClsName = this.GetVueShareClsName();
            objViewInfoENEx.ClsName = this.ClsName;
        }


        public string Gen_Share_method_ExportFuncDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}Condition : ()=>Promise<string>; ");
            strCodeForCs.Append("\r\n" + Gen_Share_method_CombineCondition());

            //strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ListRegion4GC}ConditionObj: ()=> Promise<cls{TabName_Out4ListRegion4GC}EN>; ");
            strCodeForCs.Append("\r\n" + Gen_Share_method_CombineConditionObj());
            //strCodeForCs.Append("\r\n" + $"export let Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel: ()=>Promise<cls{TabName_Out4ExportExcel4GC}EN>; ");
            strCodeForCs.Append("\r\n" + Gen_Share_method_CombineConditionObj4ExportExcel());
            strCodeForCs.Append("\r\n" + Gen_Share_method_CombineConditionInFldValueLst_GeneFun());


            //strCodeForCs.Append("\r\n" + $"export let BindTabByList: (arrObjLst: Array<cls{TabName_Out4ListRegion4GC}ENEx>,    bolIsShowErrMsg: boolean,) => Promise<void>;");

            strCodeForCs.Append("\r\n" + Gen_Share_method_BindTabByList());

            return strCodeForCs.ToString();
        }

        public string Gen_Share_method_CombineConditionObj()
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
                strCodeForCs.AppendFormat("\r\n" + "export const Combine{0}ConditionObj=async (): Promise<ConditionCollection> =>", TabName_Out4ListRegion4GC);
                strFuncName = $"Combine{TabName_Out4ListRegion4GC}ConditionObj";
                ImportClass objImportClass = AddImportClass("", "/PubFun/ConditionCollection", "ConditionCollection", enumImportObjType.CustomFunc, this.strBaseUrl);

                

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new ConditionCollection();", TabName_Out4ListRegion4GC);
                if (objViewInfoENEx.arrQryRegionFldSet.Count == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ListRegion4GC);
                    strCodeForCs.Append("\r\n" + "};");
                    return strCodeForCs.ToString();
                }
                clsViewRegionEN objViewRegion_Qry = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                if (objViewRegion_Qry == null
                    || objViewRegion_Qry.InUseInViewInfo(objViewInfoENEx) == false ||
                    objViewRegion_Qry.IsDispInViewInfo(objViewInfoENEx) == false
                    )
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ListRegion4GC);
                    strCodeForCs.Append("\r\n" + "};");
                    return strCodeForCs.ToString();
                }


                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");


                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                //处理条件中的界面变量
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds_ViewVar = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                var arrQryRegionFldsEx = arrQryRegionFlds_ViewVar.Select(clsQryRegionFldsBLEx.CopyToEx);
                if (arrQryRegionFlds_ViewVar.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFldsEx)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        string strIsEx = "";
                        if (clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objInFor.FldId, this.PrjId) == true)
                        {
                            strIsEx = "Ex";
                        }
                        else if (string.IsNullOrEmpty(objInFor.OutFldId) == false &&
                            clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objInFor.OutFldId, this.PrjId) == true) strIsEx = "Ex";

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

                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                //处理没有使用函数转换的字段

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {

                    if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;
                    string strIsEx = "";
                    if (clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.FldId, this.PrjId) == true)
                    {
                        strIsEx = "Ex";
                    }
                    else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                        clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId, this.PrjId) == true) strIsEx = "Ex";

                    string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == 'true')",
                         objQryRegionFldsEx.PropertyName);
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");


                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                        case "DropDownList_Bool": ///如果控件是下拉框;

                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {

                                //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                strCodeForCs.Append("\r\n" + $"if ({objQryRegionFldsEx.PropertyName}.value == 'true')");
                                //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}); ");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + $"else if ({objQryRegionFldsEx.PropertyName}.value == 'false')");
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

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


                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");


                                        break;
                                    case "int":


                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        break;
                                    default:


                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
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
                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"like\");");

                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value), , );");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
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
                strCodeForCs.Append("\r\n" + Gen_Ts_CombineConditionInFldValueLst(EnumConditionType.Object_1));

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj", "在组合查询条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"在组合查询条件对象(Combine{ViewMainTabName4GC}ConditionObj)时出错!请联系管理员!{{0}}\", objException);");
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");

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
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Root, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Share_const_QryVarDef()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//查询区变量定义");

            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const qryVarSet = reactive({");
            List<string> arrCheck = new List<string>();
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (objQryRegionFldsEx.InUse == false) continue;
                if (objQryRegionFldsEx.IsUseFunc() == true && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false)
                {
                    if (arrCheck.Contains(objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)) == true) continue;
                    arrCheck.Add(objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                    if (string.IsNullOrEmpty(objQryRegionFldsEx.TabFeatureId4Ddl) == false)
                    {
                        switch (objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            case "number":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref(0);", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('0')", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                break;
                        }
                        sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)},");
                        continue;
                    }
                    else
                    {
                        try
                        {
                            switch (objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().ObjDataTypeAbbr().TypeScriptType)
                            {
                                case "string":
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    break;
                                case "number":
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref(0);", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    break;
                                case "boolean":
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('0')", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0} = ref('');", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    break;
                            }
                            sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)},");
                        }
                        catch (Exception objExceptionIn)
                        {
                            throw objExceptionIn;
                        }
                    }
                }
                else
                {
                    if (arrCheck.Contains(objQryRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)) == true) continue;
                    arrCheck.Add(objQryRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                    if (string.IsNullOrEmpty(objQryRegionFldsEx.TabFeatureId4Ddl) == false)
                    {
                        switch (objQryRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                            case "number":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref(0);", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('0')", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                        }
                        sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                        continue;
                    }
                    else
                    {
                        try
                        {
                            switch (objQryRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                            {
                                case "string":
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    break;
                                case "number":
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref(0);", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    break;
                                case "boolean":
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('0')", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "export const {0}_q = ref('');", objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    break;
                            }
                            sbCode_Export.Append("\r\n" + $" {objQryRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}_q,");
                        }
                        catch (Exception objExceptionIn)
                        {
                            throw objExceptionIn;
                        }
                    }
                }
            }


            sbCode_Export.Append("});");
            sbCode_Export.Append("\r\n" + "export { qryVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                ElementType = CodeElementType.ReactiveConstant,
                CodeContent = strCodeForCs.ToString(),
                Name = "qryVarSet"
            });


            return strCodeForCs.ToString();
        }


        public string Gen_Share_const_FeatureVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//功能区变量定义");

            StringBuilder sbCode_Export = new StringBuilder();
            sbCode_Export.Append("const featureVarSet = reactive({");
            List<string> arrCheck = new List<string>();
            foreach (clsViewFeatureFldsENEx objFeatureRegionFldsEx in objViewInfoENEx.arrViewFeatureFlds)
            {
                //if (objFeatureRegionFldsEx.InUse == false) continue;
                if (arrCheck.Contains(objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)) == true) continue;
                arrCheck.Add(objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                if (string.IsNullOrEmpty(objFeatureRegionFldsEx.TabFeatureId4Ddl) == false)
                {
                    switch (objFeatureRegionFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref(0);", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('0')", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)}_f,");
                    continue;
                }
                try
                {
                    switch (objFeatureRegionFldsEx.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType)
                    {
                        case "string":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "number":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref(0);", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        case "boolean":
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('0')", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "export const {0}_f = ref('');", objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase));
                            break;
                    }
                    sbCode_Export.Append("\r\n" + $" {objFeatureRegionFldsEx.ObjFieldTabENEx.PropertyName_TS(this.IsFstLcase)}_f,");
                }
                catch (Exception objExceptionIn)
                {
                    throw objExceptionIn;
                }
            }
            sbCode_Export.Append("});");
            sbCode_Export.Append("\r\n" + "export { featureVarSet };");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                ElementType = CodeElementType.ReactiveConstant,
                CodeContent = strCodeForCs.ToString(),
                Name = "featureVarSet"
            });


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_EditVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//编辑区变量定义");

            strCodeForCs.Append("\r\n" + "export const refEditObj = ref ();");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_ts_DetailVarDef()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//详细信息区变量定义");

            strCodeForCs.Append("\r\n" + "export const refDetailObj = ref ();");

            return strCodeForCs.ToString();
        }

        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());


        public string Gen_Vue_ts_FeatureVarDefBak()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strCacheClassifyFldName4View = "";
            string strCacheClassifyFldName4View2 = "";
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                strCacheClassifyFldName4View = thisCacheClassify4View.FldName;
            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                strCacheClassifyFldName4View2 = thisCacheClassify4View.FldName2;
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {


                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };

                //从界面功能字段中获取下拉框字段

                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();
                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {

                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;

                    clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var arrTabFeatureFldsEx = objTabFeature.arrTabFeatureFldsSetEx();
                    var arrTabFeatureFlds_Cond = arrTabFeatureFldsEx.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var arrCondFldId = objTabFeature.GetCondFldIdLst();
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

                    CacheClassify objCacheClassify_TS = null;
                    if (string.IsNullOrEmpty(objInfor.DsTabId) == false)
                    {
                        var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                        objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);
                    }


                    string strCtrlId = objInfor.CtrlId;
                    if (string.IsNullOrEmpty(strCtrlId) == true)
                    {
                        strCtrlId = string.Format("ddl{0}", objInfor.FldName);
                    }
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }

                    if (string.IsNullOrEmpty(objTabFeature.FuncNameJs) == true)
                    {
                        var tuple = clsTabFeatureBLEx.GetFuncName(objTabFeature);
                        objTabFeature.FuncNameJs = tuple.Item2;
                        //print(tuple.Item1);
                        //print(int.Parse(tuple.Item2));
                    }
                    objInfor.DivName = $"divVarSet.refDivList";


                    objInfor.CodeText = objInfor.GC_SetBindDdl4TabFeature4QueryEdit_TS(this.IsFstLcase, $"divVarSet.refDivFunction", objCacheClassify_TS, arrTabFeatureFldsEx, arrCondFldId, objFuncParaLstAll, "InFeature",
                      objViewInfoENEx.ViewId, this, this.strBaseUrl);
                    //}
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
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


        public string Gen_Share_const_DataListVarDef()
        {
            if (IsHasListRegion == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "export const showErrorMessage = ref (false);");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "showErrorMessage",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "export const showErrorMessage = ref (false);",
                isExported = true,
            });


            strCodeForCs.Append("\r\n" + $"export const dataList{TabName_Out4ListRegion} = ref<Array<cls{TabName_Out4ListRegion}ENEx>>([]);");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = $"dataList{TabName_Out4ListRegion}",
                ElementType = CodeElementType.RefConstant,
                CodeContent = $"export const dataList{TabName_Out4ListRegion} = ref<Array<cls{TabName_Out4ListRegion}ENEx>>([]);",
                isExported = true,
            });

            strCodeForCs.Append("\r\n" + "export const dataColumn = ref<Array<clsDataColumn>> ([]);");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "dataColumn",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "export const dataColumn = ref<Array<clsDataColumn>> ([]);",
                isExported = true,
            });


            strCodeForCs.Append("\r\n" + "export const emptyRecNumInfo = ref ('');");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "emptyRecNumInfo",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "export const emptyRecNumInfo = ref ('');",
                isExported = true,
            });


            // 缓存对象
            strCodeForCs.Append("\r\n" + $"export const {clsString.FstLcaseS(TabName_Out4ListRegion)}Cache: {{ [key: string]: cls{TabName_Out4ListRegion}ENEx }} = {{ }};");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = $"{clsString.FstLcaseS(TabName_Out4ListRegion)}Cache",
                ElementType = CodeElementType.Constant,
                CodeContent = $"export const {clsString.FstLcaseS(TabName_Out4ListRegion)}Cache: {{ [key: string]: cls{TabName_Out4ListRegion}ENEx }} = {{ }};",
                isExported = true,
            });


            strCodeForCs.Append("\r\n" + "export const isFuncMapCache: { [key: string]: boolean } = { };");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "isFuncMapCache",
                ElementType = CodeElementType.Constant,
                CodeContent = "export const isFuncMapCache: { [key: string]: boolean } = { };",
                isExported = true,
            });


            return strCodeForCs.ToString();
        }

        public string Gen_Share_const_PubVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var strFuncName = "";
            strCodeForCs.Append("\r\n" + GeneViewPubVarInVue(strFuncName, this.objCodeElement_Root));

            return strCodeForCs.ToString();
        }
        public string Gen_Share_const_ShareVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCode_Export = new StringBuilder();
            StringBuilder sbCode_ExportLst = new StringBuilder();

            sbCode_Export.Append("const divVarSet = reactive({");
            sbCode_Export.Append("\r\n" + " refDivLayout,");
            sbCode_Export.Append("\r\n" + "refDivQuery,");
            sbCode_Export.Append("\r\n" + "refDivFunction,");
            sbCode_Export.Append("\r\n" + "refDivList,");
            sbCode_Export.Append("\r\n" + "refDivEdit,");
            sbCode_Export.Append("\r\n" + "refDivDetail,");

            sbCode_ExportLst.Append("refDivLayout,");
            sbCode_ExportLst.Append("refDivQuery,");
            sbCode_ExportLst.Append("refDivFunction,");
            sbCode_ExportLst.Append("refDivList,");
            sbCode_ExportLst.Append("refDivEdit,");
            sbCode_ExportLst.Append("refDivDetail,");


            strCodeForCs.Append("\r\n" + "const refDivLayout = ref ();");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "refDivLayout",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "const refDivLayout = ref ();",
                isExported = true,
            });


            strCodeForCs.Append("\r\n" + "const refDivQuery = ref ();");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "refDivQuery",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "const refDivQuery = ref ();",
                isExported = true,
            });

            strCodeForCs.Append("\r\n" + "const refDivFunction = ref ();");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "refDivFunction",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "const refDivFunction = ref ();",
                isExported = true,
            });

            strCodeForCs.Append("\r\n" + "const refDivList = ref ();");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "refDivList",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "const refDivList = ref ();",
                isExported = true,
            });

            strCodeForCs.Append("\r\n" + "const refDivEdit = ref ();");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "refDivEdit",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "const refDivEdit = ref ();",
                isExported = true,
            });

            strCodeForCs.Append("\r\n" + "const refDivDetail = ref ();");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "refDivDetail",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "const refDivDetail = ref ();",
                isExported = true,
            });

            if (IsHasDetailRegion)
            {
                strCodeForCs.Append("\r\n" + $"const ref{ThisDetailClsName} = ref ();");
                sbCode_Export.Append("\r\n" + $"ref{ThisDetailClsName},");
                sbCode_ExportLst.Append("\r\n" + $"ref{ThisDetailClsName},");

            }
            if (IsHasEditRegion)
            {
                strCodeForCs.Append("\r\n" + $"const ref{ThisEditClsName} = ref ();");
                sbCode_Export.Append("\r\n" + $"ref{ThisEditClsName},");
                sbCode_ExportLst.Append("\r\n" + $"ref{ThisEditClsName},");

            }
            if (IsHasListRegion)
            {
                strCodeForCs.Append("\r\n" + $"const ref{ThisListClsName} = ref ();");
                sbCode_Export.Append("\r\n" + $"ref{ThisListClsName},");
                sbCode_ExportLst.Append("\r\n" + $"ref{ThisListClsName},");

            }
            sbCode_Export.Append("});");
            sbCode_Export.Append("\r\n" + $"export {{ divVarSet, {sbCode_ExportLst} }};");
            strCodeForCs.Append("\r\n" + sbCode_Export.ToString());
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "divVarSet",
                ElementType = CodeElementType.ReactiveConstant,
                CodeContent = sbCode_Export.ToString(),
                isExported = true,
            });


            return strCodeForCs.ToString();
        }
        public string Gen_Share_const_ViewVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "const ascOrDesc4SortFun = ref ('Asc');");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "ascOrDesc4SortFun",
                ElementType = CodeElementType.RefConstant,
                CodeContent = "const ascOrDesc4SortFun = ref ('Asc');",
                isExported = true,
            });

            strCodeForCs.Append("\r\n" + $"const sort{TabName_Out4ListRegion}By = ref ('');");
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = $"sort{TabName_Out4ListRegion}By",
                ElementType = CodeElementType.RefConstant,
                CodeContent = $"const sort{TabName_Out4ListRegion}By = ref ('');",
                isExported = true,
            });

            StringBuilder sbViewVarSet = new StringBuilder();
            sbViewVarSet.Append("\r\n" + "const viewVarSet = reactive({");
            sbViewVarSet.Append("\r\n" + "ascOrDesc4SortFun,");
            sbViewVarSet.Append("\r\n" + $"sort{TabName_Out4ListRegion}By,");
            sbViewVarSet.Append("\r\n" + "});");
            sbViewVarSet.Append("\r\n" + "export { viewVarSet };");
            strCodeForCs.Append("\r\n" + sbViewVarSet.ToString());
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "viewVarSet",
                ElementType = CodeElementType.ReactiveConstant,
                CodeContent = sbViewVarSet.ToString(),
                isExported = true,
            });


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
            this.objCodeElement_Root.Children.Add(new CodeElement
            {
                Name = "divVarSet",
                ElementType = CodeElementType.ReactiveConstant,
                CodeContent = sbCode_Export.ToString(),
                isExported = true,
            });

            return strCodeForCs.ToString();
        }

        private string Gen_Ts_CombineConditionInFldValueLst(EnumConditionType intConditionType)
        {
            bolIsNeedGeneReMapFunc = false;
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
                    try
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//处理针对扩展字段:[{0}]的查询", strFldName);
                        strCodeForCs.AppendFormat("\r\n" + "const arr{0} = await GetCondition_{0}Lst_In();", strFldName);
                        bolIsNeedGeneReMapFunc = true;
                        strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length > 0)", strFldName);
                        strCodeForCs.Append("\r\n" + "{");
                        if (intConditionType == EnumConditionType.String_2)
                        {
                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} in ({{1}})\", {strClsName_Fld}.con_{strFldName}, arr{strFldName}.join(','));");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{strFldName}, arr{strFldName}.join(','), \"in\");");
                        }
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    catch (Exception ex)
                    {
                        string strMsg = $"在生成In字段:[{strFldName}]时出错。{ex.Message}. ";
                        clsEntityBase.LogErrorS(ex, strMsg);
                        throw new Exception(strMsg);
                    }
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

        public string Gen_Share_method_CombineConditionInFldValueLst_GeneFun()
        {
            if (bolIsNeedGeneReMapFunc == false) return "";
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
            if (arrQryRegionFldSetEx.Count == 0) return "";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;
                var arrQryRegionFld_InFld = arrQryRegionFldSetEx.GroupBy(x => x.FldId).ToList();
                foreach (var arrInFld in arrQryRegionFld_InFld)
                {
                    string strFldId = arrInFld.Key;
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, objViewInfoENEx.PrjId);
                    string strReturnString = objFieldTab.TypeScriptType();
                    if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
                    {
                        strReturnString = "string";
                    }
                    strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.AppendFormat("\r\n * @returns 相关字段的关键字列表(Array<{0}>)", strReturnString);
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + " export async function GetCondition_{0}Lst_In(): Promise<Array<{1}>> ", objFieldTab.FldName, strReturnString);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                    strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}ENEx();", TabName_Out4ListRegion4GC);

                    string strClsName_Fld = string.Format("cls{0}ENEx", TabName_Out4ListRegion4GC);


                    strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                    strCodeForCs.AppendFormat("\r\n" + "let arr{0}Include: Array<{1}> = [];", objFieldTab.FldName, strReturnString);

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (var objQryRegionFldsEx in arrInFld)
                    {
                        string strIsEx = "";
                        if (clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.FldId, this.PrjId) == true)
                        {
                            strIsEx = "Ex";
                        }
                        else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                            clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId, this.PrjId) == true) strIsEx = "Ex";

                        if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                        {

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objQryRegionFldsEx.objCtlType.CtlTypeName,
                                CtrlId = objQryRegionFldsEx.CtrlId(),
                                PropertyName = objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase),
                                Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetConditionInFldValueLst()"),
                                DataType = objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().ObjDataTypeAbbr().TypeScriptType,
                                ParentDivName = $"divVarSet.refDivQuery"
                            });
                        }
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                        {

                            case "CheckBox":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == 'true')",
                             objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.DataPropertyName4GC()});");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, true, \"=\");");


                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.DataPropertyName()}, false, \"=\");");
                                strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///如果控件是下拉框;
                                if (objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().CsType() == "bool")
                                {

                                    //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.DataPropertyName(), objQryRegionFldsEx.CtrlId());

                                    strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
                                    
                                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, true, \"=\");");

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, false, \"=\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {
                                    if (objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                             objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    switch (objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().CsType())
                                    {
                                        case "string":

                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");


                                            break;
                                        case "int":

                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                            break;
                                        default:

                                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                            break;
                                    }
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "TextBox": ///如果控件类型是文本框;

                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                    && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                {
                                    objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                }
                                if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                {
                                    if (objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                            objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                            objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    if (objQryRegionFldsEx.ObjFieldTab4OutFldId_PC().ObjDataTypeAbbr().IsNeedQuote == true)
                                    {

                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    }
                                    else
                                    {

                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    }
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"like\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///范围查询;
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}.con_{objQryRegionFldsEx.DataPropertyName4GC()}, {objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase)}.value, \"=\");");
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

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
                    //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetConditionInFldValueLst", "在组合查询条件中关键字列表(GetConditionInFldValueLst)时出错!请联系管理员!", "生成代码");
                    //AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                    strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"在组合查询条件中关键字列表(GetConditionInFldValueLst)时出错!请联系管理员!{{0}}\", objException);",
                       ViewMainTabName4GC);
                    strCodeForCs.Append("\r\n" + "throw strMsg;");
                    strCodeForCs.Append("\r\n" + "}");
                    //    }

                    //}

                    strCodeForCs.AppendFormat("\r\n" + "return arr{0}Include;", objFieldTab.FldName);
                    strCodeForCs.Append("\r\n" + "}");

                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Root, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Share_method_CombineCondition()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";

            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;

                clsViewRegionEN objViewRegion_Qry = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);


                strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns 条件串(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export const  Combine{0}Condition = async():Promise<string> =>", TabName_Out4ListRegion4GC);
                strFuncName = $"Combine{TabName_Out4ListRegion4GC}Condition";
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");

                StringBuilder sbTemp = new StringBuilder();
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds_ViewVar = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));

                if (objViewInfoENEx.arrQryRegionFldSet.Count == 0)
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                    strCodeForCs.Append("\r\n" + "return strWhereCond;");
                    strCodeForCs.Append("\r\n" + "};");
                    return strCodeForCs.ToString();
                }
                if (objViewRegion_Qry == null
                    || objViewRegion_Qry.InUseInViewInfo(objViewInfoENEx) == false
                    || objViewRegion_Qry.IsDispInViewInfo(objViewInfoENEx) == false)
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                    strCodeForCs.Append("\r\n" + "return strWhereCond;");
                    strCodeForCs.Append("\r\n" + "};");
                    return strCodeForCs.ToString();
                }


                foreach (var objInFor in arrQryRegionFlds_ViewVar)
                {
                    if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                    string strVarName = "";
                    clsGCVariableEN objVar = null;
                    try
                    {
                        objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
                        {

                            if (objInFor.IsForExtendClass == true)
                            {
                                //string strMsg = $"在列表区表：{TabName_Out4ListRegion}中查询字段:{objInFor.ObjFieldTab().FldName}是扩展字段,不适合做查询字段,请检查!";
                                //throw new Exception(strMsg);
                                string strFldName_T;
                                string strPropertyName_T = "";

                                List<string> arrWhereConditionEx = new List<string>();
                                if (string.IsNullOrEmpty(objInFor.OutFldId) == false)
                                {
                                    strFldName_T = objInFor.OutFldName();
                                    strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                                    arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objInFor.DnPathId(), objInFor.QueryOptionId, objInFor.PrjId);

                                }
                                else if (clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objInFor.FldId, this.PrjId) == true)
                                {
                                    strFldName_T = objInFor.FldName();
                                    strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                                    arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objInFor.DnPathId(), objInFor.QueryOptionId, objInFor.PrjId);

                                }
                                else if (string.IsNullOrEmpty(objInFor.OutFldId) == false &&
                                    clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objInFor.OutFldId, this.PrjId) == true)
                                {
                                    strFldName_T = objInFor.OutFldName();
                                    strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                                    arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objInFor.DnPathId(), objInFor.QueryOptionId, objInFor.PrjId);

                                }

                                if (arrWhereConditionEx.Count == 0)
                                {
                                    sbTemp.Append("\r\n" + $"strWhereCond += Format(\" And 1 \", {strVarName}.value);");
                                }
                                else
                                {
                                    sbTemp.Append("\r\n" + $"strWhereCond += Format(\" And {arrWhereConditionEx[0]}\", {strVarName}.value);");
                                }

                            }
                            else
                            {
                                CheckQueryField(objInFor);
                                if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                                {
                                    sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {strVarName}.value);");
                                }
                                else
                                {
                                    sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {strVarName}.value);");
                                }
                            }
                        }
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            //AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                        }

                        else
                        {
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {strVarName}.value);");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {strVarName}.value);");
                            }
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = $"在生成变量:[{(objVar == null ? "" : objVar.VarName)}]时出错。{objException.Message}. ";

                        clsEntityBase.LogErrorS(objException, strMsg);
                        throw new Exception(strMsg);
                    }
                }


                if (sbTemp.Length > 0 || objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                }

                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                }
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.Append("\r\n" + sbTemp.ToString());


                ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("cls{0}EN", TabName_Out4ListRegion4GC), enumImportObjType.ENClass, this.strBaseUrl);
                
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;
                    string strFldName_T = "";
                    string strPropertyName_T = "";
                    bool bolIsFuncFldInList = false;
                    string strTabName4QryCond = "";
                    bolIsFuncFldInList = clsDGRegionFldsBLEx.IsFuncFld(objQryRegionFldsEx.FldId, objQryRegionFldsEx.TabId(), this.PrjId);
                    if (bolIsFuncFldInList == true) strTabName4QryCond = $"{TabName_Out4ListRegion}.";
                    try
                    {
                        strFldName_T = objQryRegionFldsEx.FldName();
                        strPropertyName_T = objQryRegionFldsEx.PropertyName;
                        string strFldName = objQryRegionFldsEx.FldName();
                        if (strFldName.IndexOf("Id_Stu") > -1)
                        {
                            strFldName = "";
                        }
                        //if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;

                        string strIsEx = "";
                        List<string> arrWhereConditionEx = new List<string>();
                        if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false)
                        {
                            strFldName_T = objQryRegionFldsEx.OutFldName();
                            strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                            arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objQryRegionFldsEx.DnPathId(), objQryRegionFldsEx.QueryOptionId, objQryRegionFldsEx.PrjId);
                            strIsEx = "Ex";
                        }
                        else if (clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.FldId, this.PrjId) == true)
                        {
                            strFldName_T = objQryRegionFldsEx.FldName();
                            strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                            arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objQryRegionFldsEx.DnPathId(), objQryRegionFldsEx.QueryOptionId, objQryRegionFldsEx.PrjId);

                            strIsEx = "Ex";
                        }
                        else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                            clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId, this.PrjId) == true)
                        {
                            strFldName_T = objQryRegionFldsEx.OutFldName();
                            strPropertyName_T = clsString.FirstLcaseS($"{strFldName_T}_q");
                            arrWhereConditionEx = clsDnPathBLEx.GetWhereConditionByDnPathId(objQryRegionFldsEx.DnPathId(), objQryRegionFldsEx.QueryOptionId, objQryRegionFldsEx.PrjId);

                            strIsEx = "Ex";
                        }


                        string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                        if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                        {
                        }
                        if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                        {

                            case "CheckBox":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == 'true')",
                             strPropertyName_T);
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///如果控件是下拉框;
                            case "DropDownList_Bool": ///如果控件是下拉框;

                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {

                                    //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    strCodeForCs.Append("\r\n" + $"if ({strPropertyName_T}.value == 'true')");
                                    //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}); ");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + $"else if ({strPropertyName_T}.value == 'false')");
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {
                                    //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != 0)",
                                             strPropertyName_T);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\" && {0}.value != \"0\")",
                                                strPropertyName_T);
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                    {
                                        case "string":

                                            if (strIsEx == "Ex")
                                            {
                                                if (arrWhereConditionEx.Count == 0)
                                                {
                                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And 1 \", {strPropertyName_T}.value);");
                                                }
                                                else
                                                {
                                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {arrWhereConditionEx[0]}\", {strPropertyName_T}.value);");
                                                }
                                            }
                                            else
                                            {
                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {strTabName4QryCond}{{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                            }
                                            break;
                                        case "int":

                                            if (strIsEx == "Ex")
                                            {
                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {arrWhereConditionEx[0]}\", {strPropertyName_T}.value);");
                                            }
                                            else
                                            {
                                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {strTabName4QryCond}{{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                            }
                                            break;
                                        default:


                                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
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
                                            strPropertyName_T);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")",
                            strPropertyName_T);
                                    }

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                    {
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {strTabName4QryCond}{{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                    }
                                    else
                                    {
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {strTabName4QryCond}{{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", strPropertyName_T);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    if (strIsEx == "Ex" && arrWhereConditionEx.Count > 0)
                                    {
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {arrWhereConditionEx[0]} \", {strPropertyName_T}.value);");
                                    }
                                    else
                                    {
                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value);");
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///范围查询;
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", strPropertyName_T);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value), , );");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", strPropertyName_T);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {strPropertyName_T}.value), , );");
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
                    catch (Exception ex)
                    {
                        string strMsg = $"在查询字段:[{strFldName_T}](属性:[{strPropertyName_T}])时出错。{ex.Message}.";
                        clsEntityBase.LogErrorS(ex, strMsg);
                        throw new Exception(strMsg);
                    }
                }
                //处理针对扩展字段的查询
                strCodeForCs.Append("\r\n" + Gen_Ts_CombineConditionInFldValueLst(EnumConditionType.String_2));


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameCondition", "在组合查询条件(CombineTabNameCondition)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"在组合查询条件(Combine{ViewMainTabName4GC}Condition)时出错!请联系管理员!{{0}}\", objException);");
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");



                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "};");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Root, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Share_method_CombineConditionObj4ExportExcel()
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
                strCodeForCs.Append("\r\n" + $"export const Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel = async ():Promise<ConditionCollection> => ");
                strFuncName = $"Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel";

                ImportClass objImportClass = AddImportClass("", "/PubFun/ConditionCollection", "ConditionCollection", enumImportObjType.CustomFunc, this.strBaseUrl);
                
                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");


                clsViewRegionEN objViewRegion_Qry = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new ConditionCollection();", TabName_Out4ExportExcel4GC);
                if (objViewInfoENEx.arrQryRegionFldSet.Count == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ListRegion4GC);
                    strCodeForCs.Append("\r\n" + "};");
                    return strCodeForCs.ToString();
                }


                if (objViewRegion_Qry == null
                    || objViewRegion_Qry.InUseInViewInfo(objViewInfoENEx) == false ||
                    objViewRegion_Qry.IsDispInViewInfo(objViewInfoENEx) == false
                    )
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ListRegion4GC);
                    strCodeForCs.Append("\r\n" + "};");
                    return strCodeForCs.ToString();
                }


                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");

                ImportClass objImportClass2 = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", TabName_Out4ExportExcel4GC), enumImportObjType.ENExClass, this.strBaseUrl);
                
                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds_ViewVar = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));


                foreach (var objInFor in arrQryRegionFlds_ViewVar)
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

                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue(cls{TabName_Out4ExportExcel4GC}EN.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue(cls{TabName_Out4ExportExcel4GC}EN.con_{objInFor.ObjFieldTab().FldName}, {strVarName}.value, \"=\");");
                    }
                    if (string.IsNullOrEmpty(objVar.ClsName) == false)
                    {
                        ImportClass objImportClass3 = AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);
                        
                        CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);


                    }
                }


                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //处理没有使用函数转换的字段
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {

                    if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;
                    string strIsEx = "";
                    if (clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.FldId, this.PrjId) == true)
                    {
                        strIsEx = "Ex";
                    }
                    else if (string.IsNullOrEmpty(objQryRegionFldsEx.OutFldId) == false &&
                        clsPrjTabFldBLEx.IsForExtendClassCache(TabId_Out4ListRegion, objQryRegionFldsEx.OutFldId, this.PrjId) == true) strIsEx = "Ex";

                    string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ExportExcel4GC);
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {

                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.value == 'true')",
                         objQryRegionFldsEx.PropertyName);
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");


                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                            strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {

                                //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                strCodeForCs.Append("\r\n" + $"if ({objQryRegionFldsEx.PropertyName}.value == 'true')");
                                //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '1'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}); ");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, true, \"=\");");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + $"else if ({objQryRegionFldsEx.PropertyName}.value == 'false')");
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '0'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName});");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, false, \"=\");");

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


                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ExportExcel4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");


                                        break;
                                    case "int":


                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                        break;
                                    default:


                                        strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                        strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
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
                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = {{1}}\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                    strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ( {0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"like\");");

                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value);");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ({0}.value != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                strCodeForCs.Append("\r\n" + $"strWhereCond += Format(\" And {{0}} = '{{1}}'\", {strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value), , );");
                                strCodeForCs.Append("\r\n" + $"obj{TabName_Out4ListRegion4GC}Cond.SetCondFldValue({strClsName_Fld}{strIsEx}.con_{objQryRegionFldsEx.FldName}, {objQryRegionFldsEx.PropertyName}.value, \"=\");");
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
                //处理针对扩展字段的查询
                strCodeForCs.Append("\r\n" + Gen_Ts_CombineConditionInFldValueLst(EnumConditionType.Object_1));


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                //  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj4ExportExcel", "在组合导出Excel条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                strCodeForCs.Append("\r\n" + $"const strMsg:string = Format(\"在组合导出Excel条件对象(Combine{ViewMainTabName4GC}ConditionObj4ExportExcel)时出错!请联系管理员!{{0}}\", objException);");
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");


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
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Root, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string GeneSetOperate(string strFldName, string strDataPropertyName, string strTabName, bool bolIsNumberType)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_{1} = await {2}Ex_FuncMapKey{1}(obj{2}Cond);",
                                 strFldName, strDataPropertyName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Include.length == 0)",
                strFldName, strDataPropertyName);
            strCodeForCs.Append("\r\n" + "{");
            if (bolIsNumberType == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = arr{0}_{1}.map(x=>x);",
strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = intersectSets_Number(arr{0}Include, arr{0}_{1}.map(x=>x)); ",
                    strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                ImportClass objImportClass4 = AddImportClass(TabId_Out4ListRegion, "/PubFun/clsCommFunc4Ctrl.js", "intersectSets_Number", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = arr{0}_{1}.map(x=>x.toString());",
                strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = intersectSets(arr{0}Include, arr{0}_{1}.map(x=>x.toString())); ",
                    strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                ImportClass objImportClass3 = AddImportClass(TabId_Out4ListRegion, "/PubFun/clsCommFunc4Ctrl.js", "intersectSets", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

            }
            ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", String.Format("FuncMapKey{0}", strDataPropertyName), enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            return strCodeForCs.ToString();
        }

        public string Gen_Share_method_DeleteKeyIdCache()
        {
            if (PrjTabEx_EditRegion == null) return "";
            string strFuncName = "";
            Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "DeleteKeyIdCache():void", "");
            Re_objFunction4Code.FuncCHName4Code = "刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.";

            string strIsShare = "";
            if (PrjTabEx_EditRegion.IsShare) strIsShare = "Share";

            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbCheckEmpty = new StringBuilder();

            StringBuilder sbFuncPara = new StringBuilder();

            //缓存分类字段作为函数参数的计划
            if (PrjTabEx_EditRegion.IsHasCacheClassifyFldTS() == false)
            {

            }
            else if (PrjTabEx_EditRegion.IsHasCacheClassifyFld2TS() == false)
            {

                sbFuncPara.Append($"{PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().PrivFuncName()}: {PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().TypeScriptType()}");
                Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + $"DeleteKeyIdCache({PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().PrivFuncName()}: {PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().TypeScriptType()}):void");
            }
            else
            {
                sbFuncPara.AppendFormat("{0}: {1}, {2}: {3}",
                PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().PrivFuncName1(),
                PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().TypeScriptType(),
                PrjTabEx_EditRegion.CacheClassifyFld2TS().ObjFieldTab().PrivFuncName1(),
                PrjTabEx_EditRegion.CacheClassifyFld2TS().ObjFieldTab().TypeScriptType());
            }
            string strFuncPara = sbFuncPara.ToString();


            string strTemp4Key = "";
            foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
            {
                string strPrivateVarName = objInFor.ObjFieldTab().PrivFuncName();
                if (strFuncPara.IndexOf(strPrivateVarName) > -1) continue;
                strTemp4Key += $" {strPrivateVarName}:{objInFor.TypeScriptType},";
            }

            strTemp4Key = strTemp4Key.Substring(0, strTemp4Key.Length - 1);
            string strFuncName_Temp = string.Format("{0}.ReFreshCache", TabName_In4Edit);

            if (PrjTabEx_EditRegion.IsHasCacheClassifyFldTS() == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + $"DeleteKeyIdCache({strTemp4Key}):void");
                strFuncName = $"{this.tabNameHead}DeleteKeyIdCache";
            }
            else if (PrjTabEx_EditRegion.IsHasCacheClassifyFld2TS() == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + $"DeleteKeyIdCache({strFuncPara}, {strTemp4Key}):void");
                strFuncName = $"{this.tabNameHead}DeleteKeyIdCache";

                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().PrivFuncName1(),
   PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().TypeScriptType(),
        PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().DataTypeId,
   this.ClsName, strFuncName_Temp,
   PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().FldLength,
   PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));
                Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + $"DeleteKeyIdCache({PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().PrivFuncName()}: {PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().TypeScriptType()}, {strTemp4Key}):void");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "export  function " + this.tabNameHead + "DeleteKeyIdCache({0}, {1}):void",
                 strFuncPara, strTemp4Key);
                strFuncName = $"{this.tabNameHead}DeleteKeyIdCache";
                var strTemp = clsPubFun4GC.Gc_CheckVarEmpty_Ts(PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().PrivFuncName1(),
   PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().TypeScriptType(),
   PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().DataTypeId,
this.ClsName, strFuncName_Temp,
   PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().FldLength,
   PrjTabEx_EditRegion.CacheClassifyFldTS().ObjFieldTab().DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl);

                sbCheckEmpty.Append("\r\n" + strTemp);
                sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(PrjTabEx_EditRegion.CacheClassifyFld2TS().ObjFieldTab().PrivFuncName1(),
   PrjTabEx_EditRegion.CacheClassifyFld2TS().ObjFieldTab().TypeScriptType(),
   PrjTabEx_EditRegion.CacheClassifyFld2TS().ObjFieldTab().DataTypeId,
   this.ClsName, strFuncName_Temp,
   PrjTabEx_EditRegion.CacheClassifyFld2TS().ObjFieldTab().FldLength,
   PrjTabEx_EditRegion.CacheClassifyFld2TS().ObjFieldTab().DataTypeId == enumDataTypeAbbr.char_04 ? true : false, this, this.strBaseUrl));

                Re_objFunction4Code.FuncName4Code = string.Format("export  function " + this.tabNameHead + "DeleteKeyIdCache({0},{1}):void",
                 strFuncPara, strTemp4Key);

            }
            strCodeForCs.Append("\r\n" + "{");
            //    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"DeleteKeyIdCache\";", ThisTabName4GC,
            //objKeyField.FldName);
            strCodeForCs.AppendLine(sbCheckEmpty.ToString());


            strCodeForCs.Append("\r\n" + clsPubFun4GC.Gc_IfVarNotEmpty_Ts(PrjTabEx_EditRegion.arrKeyFldSet, this, this.strBaseUrl));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"// 使用 delete 删除特定的键");
            strCodeForCs.Append("\r\n" + getCacheKey());
            strCodeForCs.Append("\r\n" + $"delete {clsString.FstLcaseS(TabName_Out4ListRegion)}Cache[cacheKey];");
            //AddImportClass("", $"@/views{strIsShare}/{this.objFuncModule.FuncModuleEnName}/{this.GetVueShareClsName()}", $"{clsString.FstLcaseS(TabName_In4Edit4GC)}Cache", enumImportObjType.CustomFunc, "");

            strCodeForCs.Append("\r\n" + $"return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Root, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string getCacheKey()
        {
            string strCacheKey = "const cacheKey = `";
            //strCodeForCs.Append("\r\n" + $"const cacheKey = `${{ obj.courseKnowledgeId}}_${{ obj.courseId}}`;");

            List<string> strCache_ParaVarNameLst = clsPrjTabBLEx.Cache_ParaVarLst(PrjTabEx_EditRegion, "TypeScript");
            foreach (var objInfo in PrjTabEx_EditRegion.arrKeyFldSet)
            {
                strCacheKey += $"${{ {objInfo.ObjFieldTab().PrivFuncName()} }}_";
            }
            foreach (var objInfo in strCache_ParaVarNameLst)
            {
                strCacheKey += $"${{ {objInfo} }}_";
            }
            strCacheKey = strCacheKey.Substring(0, strCacheKey.Length - 1);
            strCacheKey += "`;";
            return strCacheKey;
        }


        public string Gen_Share_import_GeneCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            strCodeForCs.Append("\r\n" + "import { reactive, ref } from 'vue';");
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
            {
                Name = "reactive, ref",
                ElementType = CodeElementType.Import,
                CodeContent = "import { reactive, ref } from 'vue';",
                Modifiers = "import",
                isPublic = true,
                From = "vue",
            });


            //strCodeForCs.Append("\r\n" + "import router from '@/router';");
            if (IsHasListRegion == true)
            {
                strCodeForCs.Append("\r\n" + "import { clsDataColumn } from '@/ts/PubFun/clsDataColumn';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "clsDataColumn",
                    ElementType = CodeElementType.Import,
                    CodeContent = "import { clsDataColumn } from '@/ts/PubFun/clsDataColumn';",
                    Modifiers = "import",
                    isPublic = true,
                    From = "@/ts/PubFun/clsDataColumn",
                });


                strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}ENEx }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ENEx\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"cls{TabName_Out4ListRegion}ENEx",
                    ElementType = CodeElementType.Import,
                    CodeContent = $"cls{TabName_Out4ListRegion}ENEx",
                    Modifiers = "import",
                    isPublic = true,
                    From = $"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}ENEx",
                });


            }
            strCodeForCs.Append("\r\n" + "import { ConditionCollection } from '@/ts/PubFun/ConditionCollection';");
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                Name = "ConditionCollection",
                ElementType = CodeElementType.Import,
                CodeContent = "import { ConditionCollection } from '@/ts/PubFun/ConditionCollection';",
                Modifiers = "import",
                isPublic = true,
                From = "@/ts/PubFun/ConditionCollection",
            });


            //strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4ListRegion}EN }} from \"@/ts/L0Entity/{objFuncModule.FuncModuleEnName4GC()}/cls{TabName_Out4ListRegion}EN\";");


            string strTemp2 = "";


            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            var arrFuncName_Setup_Import = new List<string>();
            strTemp2 = Gen_Share_method_DeleteKeyIdCache();
            strTemp2 = Gen_Share_method_CombineCondition();
            GetImportClassLst(objFuncModule, strIsShare);

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
                          .Replace("../../L0Entity/", "@/ts/L0Entity/")

                          .Replace("../../PubFun/", "@/ts/PubFun/")
                          .Replace("../../PubConfig/", "@/ts/PubConfig/")
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

            return strCodeForCs.ToString();
        }
        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule0, string strIsShare)
        {
            //List<ImportClass> arrImportClass = new List<ImportClass>();

            //   arrImportClass.Add(new ImportClass
            //   {
            //       ClsName = "divVarSet ,refDivLayout,refDivQuery,refDivFunction, refDivList",
            //       FilePath = string.Format($"@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
            //ViewMainTabName4GC)
            //   });
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "Format", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

        }

    }
}
