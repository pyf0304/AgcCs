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
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
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
    partial class Vue_ViewScript_Edit_TS4Html : clsGeneCodeBase4View
    {
        private CodeElement objCodeElement_Methods = null;
        private List<string> arrFuncName_Setup = new List<string>();
        private string strJSPath = "";
        //clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public Vue_ViewScript_Edit_TS4Html()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //

            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_Edit_TS4Html(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;

            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_Edit_TS4Html(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;

            this.arrImportClass = new List<ImportClass>();
        }


        #endregion

        public string Gen_Vue_JS_mySubmit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * 提交编辑");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "Submit_{0}(strOp:string) {{  ", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "alert(`提交${ strOp }`);");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {0}Ex('{0}Ex', new {1}CRUDEx());", ThisClsName, objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "           objPage.btnSubmit_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "},");
            return strCodeForCs.ToString();
        }

        public string Gen_Edit_Methods_btnEdit_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  *按钮单击,用于调用Js函数中btnEdit_Click");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strFuncName = $"btn{objViewInfoENEx.TabName_In}_Edit_Click";
            strCodeForCs.AppendFormat("\r\n" + "btn{0}_Edit_Click(strCommandName:string, strKeyId:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "{0}Ex.btnEdit_Click(strCommandName, strKeyId);",
                 ThisClsName);


            strCodeForCs.Append("\r\n" + "},");
            objCodeElement_Methods.Children.Add(new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "export abstract"
            });

            return strCodeForCs.ToString();
        }


        public string BakGen_Vue_JS_Page_LoadBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  页面导入-在导入页面后运行的函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "window.onload = function() {");

            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", ThisClsName, objViewInfoENEx.TabName.ToLower());
            if (PrjTabEx_ListRegion.IsUseCache_TS())
            {
                strCodeForCs.AppendFormat("\r\n" + "objPage.PageLoadCache();",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "objPage.PageLoad();",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            }

            strCodeForCs.Append("\r\n" + "},");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_JS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * 显示对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "ShowDialog(strDialogName:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "            objPage_Edit.value = new {0}Ex();", ThisClsName);
            strCodeForCs.Append("\r\n" + "alert(\"显示对话框\" + strDialogName);");
            strCodeForCs.AppendFormat("\r\n" + " //$(strDialogName).modal('show');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "},");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_JS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * 隐藏对话框");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "HideDialog(strDialogName:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "alert(\"隐藏对话框\" + strDialogName);");
            strCodeForCs.AppendFormat("\r\n" + "      //$(strDialogName).modal('hide');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "},");
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
            if (objViewInfoENEx.objViewRegion_Edit == null || objViewInfoENEx.objViewRegion_Edit.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }

            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            string strFuncName = "";
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            this.objCodeElement_Root = new CodeElement { Name = "Root", ElementType = CodeElementType.Root };
            this.objCodeElement_Imports = new CodeElement { Name = "imports", ElementType = CodeElementType.Import, Modifiers = "export abstract" };
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);


            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                        objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.vue",
                objViewInfoENEx.FolderName, ThisClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            this.objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(this.objFuncModuleEN, objViewInfoENEx);

            try
            {
                if (string.IsNullOrEmpty(this.TabId_In4Edit) == false) this.GetViewPubVarLst(this.TabId_In4Edit);

                //0003:QUDI模式
                strCodeForCs.Append("\r\n" + Gen_Edit_Template_DefDiv4EditRegion(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_Edit_Script_DefDiv4EditRegion(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_Edit_Style_DefDiv4EditRegion(objCodeElement_Root));
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_JS_GetDdlDataBak()
        {


            List<string> arrCacheFldName = new List<string>();

            StringBuilder strCodeForCs = new StringBuilder();

            string strFuncName = "";
            try
            {
                List<string> arrTemp = new List<string>();
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);
                    strCodeForCs.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN[]>([]);");

                }
                arrTemp.RemoveRange(0, arrTemp.Count);
                //针对每一个表功能--下拉框
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);

                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);

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
                    strCodeForCs.AppendFormat("\r\n * ({0})-pyf", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.Append("\r\n * @param objDDL:需要绑定当前表的下拉框");
                    //生成与条件参数的函数说明
                    strCodeForCs.Append("\r\n" + objTabFeature4Ddl.FuncRemark);
                    strCodeForCs.Append("\r\n*/");

                    //strFuncName_Temp = string.Format("BindDdl_{0}InDivCache", strValueFieldName);

                    strCodeForCs.Append("\r\n" + $"async function getArr{objTabFeature4Ddl.TabName4GC}({strFuncPara})");

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
                    if (objEditRegionFld.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
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
                    if (objEditRegionFld.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                    {
                        strCodeForCs.Append("\r\n" + $"{objEditRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}.value = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"{objEditRegionFld.ObjFieldTab().PropertyName_TS(this.IsFstLcase)}.value = '0';");
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

        public string Gen_Edit_Setup_DefineFieldRefConst(CodeElement objCodeElement_Parent)
        {


            List<string> arrCacheFldName = new List<string>();

            StringBuilder strCodeForCs = new StringBuilder();

            string strFuncName = "";
            try
            {
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    StringBuilder sbConstContent = new StringBuilder();
                    if (objEditRegionFldsEx.InUse == false)
                    {
                        if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
                        {
                            //string str1 = "";

                        }
                        else if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
                        {
                            //string str2 = "";
                        }
                        else
                        {
                            continue;
                        }
                    }
                    strFuncName = objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase);
                    if (string.IsNullOrEmpty(objEditRegionFldsEx.TabFeatureId4Ddl) == false)
                    {
                        switch (objEditRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                sbConstContent.AppendFormat("\r\n" + "const {0} = ref('');", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                            case "number":
                                sbConstContent.AppendFormat("\r\n" + "const {0} = ref(0);", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                            case "boolean":
                                if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    sbConstContent.AppendFormat("\r\n" + "const {0} = ref(true)", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                }
                                else
                                {
                                    sbConstContent.AppendFormat("\r\n" + "const {0} = ref('0')", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                }
                                break;
                            default:
                                sbConstContent.AppendFormat("\r\n" + "const {0} = ref('');", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                        }

                        continue;
                    }
                    try
                    {
                        switch (objEditRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                sbConstContent.AppendFormat("\r\n" + "const {0} = ref('');", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                            case "number":
                                sbConstContent.AppendFormat("\r\n" + "const {0} = ref(0);", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                            case "boolean":

                                if (objEditRegionFldsEx.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    sbConstContent.AppendFormat("\r\n" + "const {0} = ref(true)", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                }
                                else
                                {
                                    sbConstContent.AppendFormat("\r\n" + "const {0} = ref('0')", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                }
                                break;
                            default:
                                sbConstContent.AppendFormat("\r\n" + "const {0} = ref('');", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                break;
                        }
                    }
                    catch (Exception objExceptionIn)
                    {
                        throw objExceptionIn;
                    }
                    strCodeForCs.Append(sbConstContent.ToString());
                    objCodeElement_Parent.Children.Add(new CodeElement
                    {
                        Name = strFuncName,
                        CodeContent = sbConstContent.ToString(),
                        ElementType = CodeElementType.RefConstant,
                        Modifiers = "export const"
                    });

                }

                //                List<string> arrTemp = new List<string>();
                //                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //                {
                //                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                //                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                //                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                //                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                //                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);
                //                    strFuncName = $"const arr{objTabFeature4Ddl.TabName4GC}";
                //StringBuilder sbConstContent = new StringBuilder();
                //                    sbConstContent.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN[]|null>([]);");
                //                    strCodeForCs.Append(sbConstContent.ToString());
                //                    objCodeElement_Methods.Children.Add(new CodeElement
                //                    {
                //                        Name = strFuncName,
                //                        CodeContent = sbConstContent.ToString(),
                //                        ElementType = CodeElementType.RefConstant,
                //                        Modifiers = "export const"
                //                    });

                //                }

            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成获取下拉框数据:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_Edit_Setup_DefineDdlDataVarName(CodeElement objCodeElement_Parent)
        {


            List<string> arrCacheFldName = new List<string>();

            StringBuilder strCodeForCs = new StringBuilder();

            string strFuncName = "";
            try
            {
                List<string> arrTemp = new List<string>();
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);
                    strFuncName = $"arr{objTabFeature4Ddl.TabName4GC}";
                    StringBuilder sbConstContent = new StringBuilder();
                    sbConstContent.Append("\r\n" + $"const arr{objTabFeature4Ddl.TabName4GC} = ref<cls{objTabFeature4Ddl.TabName4GC}EN[]|null>([]);");
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


        public string GenFeatureRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {


                ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                objASPDivENEx_Function.Class = "table table-bordered table-hover";
                objASPDivENEx_Function.Runat = "server";
                objASPDivENEx_Function.CtrlId = "divFunction";
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


                //IEnumerable<ASPButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsASPButtonBLEx.GetButton4MvcAjax);
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

                //Action<ASPButtonEx> AddToTd = (x) =>
                //{
                //    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                //    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
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
                    //ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
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
                    objLabel.Text = strTitle;
                    objDiv.arrSubAspControlLst2.Add(objLabel);
                    ASPLabelEx objLabel_ErrMsg = clsASPLabelBLEx.GetLabel4ErrMsg("lblMsg_List", true);
                    objDiv.arrSubAspControlLst2.Add(objLabel_ErrMsg);
                    objDiv.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
            }

            intZIndex += 1;
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
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///生成Button的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                  objButtonStyle.Width, objButtonStyle.Height);

                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //生成单击事件
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

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
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Edit_Html_Dialog4Popup()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n" + " <el-dialog v-model = \"dialogVisible\" :width=\"dialogWidth\" :show-close=\"false\" >", objViewInfoENEx.ViewCnName);

            strCodeForCs.Append("\r\n" + "<!--使用头部插槽来自定义对话框的标题-->");
            strCodeForCs.Append("\r\n" + "<template #header>");
            strCodeForCs.Append("\r\n" + "<div class=\"custom-header\">");
            strCodeForCs.Append("\r\n" + "<h3>{{ strTitle }}</ h3 >");
            strCodeForCs.Append("\r\n" + "<el-button @click = \"dialogVisible = false\" type = \"primary\" ><font-awesome-icon icon=\"times\" /></el-button>");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</template>");

            strCodeForCs.Append("\r\n" + "<div id = \"divEditLayout\" ref=\"refDivEdit\" class = \"tab_layout\"> ");

            //ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion(objViewInfoENEx.objMainPrjTab.TabName);

            Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrEditRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);

            //封装Td
            switch (objViewRegionEx.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0);
                    objTable.Width = objViewRegionEx.Width ?? 0;
                    objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objFormControl = clsASPDivBLEx.PackageByFormControl4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objFormControl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;

                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objFormInline.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objDivTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4EditRegion_H(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objUl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4EditRegion_V(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);
                    objUl2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs); ;
                    break;
            }

            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + "      <template #footer>");
            //       < a - button @click = "dialogVisible = false" > 关闭 </ a - button >
            //< a - button type = "primary" @click = "handleSave" > 保存 </ a - button >
            strCodeForCs.AppendFormat("\r\n" + " <el-button  id=\"btnCancel{0}\" @click = \"dialogVisible = false\">{{{{ strCancelButtonText }}}}</el-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + " <el-button  id=\"btnSubmit{0}\" type = \"primary\" @click=\"btnSubmit_Click\">{{{{ strSubmitButtonText }}}}</el-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </template>");
            strCodeForCs.Append("\r\n" + " </el-dialog>");

            return strCodeForCs.ToString();
        }

        public string Gen_Edit_Html_Dialog4Popup_Ant()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            StringBuilder strCodeForCs = new StringBuilder();
            //< a - modal v - model:visible = "dialogVisible" :width = "dialogWidth" :title = "strTitle" >
            strCodeForCs.AppendFormat("\r\n" + " <a-modal v-model:visible = \"dialogVisible\" :width=\"dialogWidth\" :title=\"strTitle\" >", objViewInfoENEx.ViewCnName);

            strCodeForCs.Append("\r\n" + "<!--使用头部插槽来自定义对话框的标题-->");
            strCodeForCs.Append("\r\n" + "<template #header>");
            strCodeForCs.Append("\r\n" + "<div class=\"custom-header\">");
            strCodeForCs.Append("\r\n" + "<h3>{{ strTitle }}</ h3 >");
            strCodeForCs.Append("\r\n" + "<a-button type = \"primary\" @click = \"dialogVisible = false\"  ><font-awesome-icon icon=\"times\" /></a-button>");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</template>");

            strCodeForCs.Append("\r\n" + "<div id = \"divEditLayout\" ref=\"refDivEdit\" class = \"tab_layout\"> ");

            //ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion(objViewInfoENEx.objMainPrjTab.TabName);

            Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrEditRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);

            //封装Td
            switch (objViewRegionEx.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0);
                    objTable.Width = objViewRegionEx.Width ?? 0;
                    objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objFormControl = clsASPDivBLEx.PackageByFormControl4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objFormControl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;

                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objFormInline.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objDivTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4EditRegion_H(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objUl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4EditRegion_V(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);
                    objUl2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs); ;
                    break;
            }

            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + "      <template #footer>");
            //       < a - button @click = "dialogVisible = false" > 关闭 </ a - button >
            //< a - button type = "primary" @click = "handleSave" > 保存 </ a - button >
            strCodeForCs.AppendFormat("\r\n" + " <a-button  id=\"btnCancel{0}\" @click = \"dialogVisible = false\">{{{{ strCancelButtonText }}}}</a-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + " <a-button  id=\"btnSubmit{0}\" type = \"primary\" @click=\"btn{0}_Edit_Click('Submit','')\">{{{{ strSubmitButtonText }}}}</a-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </template>");
            strCodeForCs.Append("\r\n" + " </a-modal>");

            return strCodeForCs.ToString();
        }


        public string Gen_Edit_Html_Dialog()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            StringBuilder strCodeForCs = new StringBuilder();

            //strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
            //    objViewInfoENEx.TabName_In);
            //strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal-content\" style=\"width: {0}px;\">", objViewRegionEx.Width + 35);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");

            //ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion(objViewInfoENEx.objMainPrjTab.TabName);

            Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrEditRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);

            //封装Td
            switch (objViewRegionEx.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0);
                    objTable.Width = objViewRegionEx.Width ?? 0;
                    objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
                case enumGCContainerType.FormControl_0002:
                    ASPDivEx objFormControl = clsASPDivBLEx.PackageByFormControl4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objFormControl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;

                case enumGCContainerType.FormInline_0003:
                    ASPDivEx objFormInline = clsASPDivBLEx.PackageByFormInline4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objFormInline.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.DivTable_0004:
                    ASPDivEx objDivTable = clsASPDivBLEx.PackageByDivTable4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objDivTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.HorizontalListLi_0005:
                    ASPUlEx objUl = clsASPUlBLEx.PackageByUl4EditRegion_H(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);

                    objUl.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                case enumGCContainerType.VerticalListLi_0006:
                    ASPUlEx objUl2 = clsASPUlBLEx.PackageByUl4EditRegion_V(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);
                    objUl2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    break;
                default:
                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewRegionEx.ColNum ?? 0);
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs); ;
                    break;
            }



            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnCancel{0}\" type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">关闭</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnSubmit{0}\" type=\"button\" class=\"btn btn-primary\" onclick=\"btn{0}_Edit_Click('Submit')\">添加</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            //strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            //strCodeForCs.Append("\r\n" + " </div>");
            //strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            //strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_ViewScript_Edit_TS4Html);
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
            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;
            objViewInfoENEx.ClsName = this.ClsName;
        }

        public string Gen_WebView_Vue_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 功能区 -->");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_Vue_Code4ListRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 列表层 -->");
            strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\" >");

            strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\" >");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\" >");
            strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</div>");
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_Vue_Code4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 编辑层 -->");
            strCodeForCs.Append("\r\n" + Gen_Edit_Html_Dialog());

            return strCodeForCs.ToString();
        }


        public string BakGen_Vue_Ts_BindDdl4EditRegionInDivBak()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " async function BindDdl4EditRegionInDiv()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");

                //针对每一个表功能--下拉框
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);

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

        public string Gen_Edit_Setup_BindDdl4EditRegionInDiv(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Method = new CodeElement { Name = "BindDdl4EditRegionInDiv", ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);

            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<ASPDropDownListEx> arrASPDropDownListObj_Edit
                = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003).ToList();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "async function BindDdl4EditRegionInDiv()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
                List<string> arrDataLst4Ddl = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {

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
                        Tuple<string, string> tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objInfor, arrCondFldId, objFuncParaLstAll);
                        string strFuncName4Ex = $"GetArr{objInfor.DsTabName}{strByCondition}";
                        if (string.IsNullOrEmpty(objTabFeature4Ddl.GetDdlDataFuncName4Ex) == false)
                        {
                            strFuncName4Ex = objTabFeature4Ddl.GetDdlDataFuncName4Ex;
                        }

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
                            if (arrDataLst4Ddl.Contains(objInfor.DsTabName))
                            {
                                continue;
                            }
                            else
                            {
                                arrDataLst4Ddl.Add(objInfor.DsTabName);
                                if (objTabFeature4Ddl.IsExtendedClass)
                                {
                                    objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}Ex_{strFuncName4Ex}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";
                                }
                                else
                                {
                                    objInfor.CodeText = "\r\n" + $"arr{objInfor.DsTabName}.value = await {objInfor.DsTabName}_{strFuncName4Ex}({strFuncParaLst_Additional});//{clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)}";
                                }
                            }
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl, true));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);

                    if (objInfor.objEditRegionFldsEN.ObjFieldTab_PC().IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + $"{objInfor.objEditRegionFldsEN.ObjFieldTab_PC().PropertyName_TS(this.IsFstLcase)}.value = 0;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"{objInfor.objEditRegionFldsEN.ObjFieldTab_PC().PropertyName_TS(this.IsFstLcase)}.value = '0';");
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
        public Tuple<string, string> Gen_WApi_Ts_DefineVar4Ddl4TabFeature(ASPDropDownListEx objInfor, List<string> arrCondFldId, FuncParaLst objFuncParaLstAll)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
            objFuncParaLst.AddParaByVar(objInfor.VarIdCond1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(objInfor.VarIdCond1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);

            objFuncParaLst.AddParaByVar(objInfor.VarIdCond2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(objInfor.VarIdCond2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            if (string.IsNullOrEmpty(objInfor.DsTabId) == false)
            {
                //var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                //var objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                //objFuncParaLst.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);
                //objFuncParaLstAll.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);

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
            strFuncParaLst_Additional = strFuncParaLst_Additional.Replace("_Cache", "");
            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strFuncParaLst_Additional);

            return tup;
        }


        public string Gen_Vue_Ts_PutDataToClassBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /** 函1数功能:把界面上的属性数据传到类对象中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">数据传输的目的类对象</param>",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " async function PutDataTo{0}Class(pobj{2}EN: cls{1}EN)",
                this.TabName_In4Edit4GC, this.TabName_In4Edit4GC, this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                //                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PutDataTo{0}Class.name;",
                //this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {

                    if (objEditRegionFldsEx.InUse == false)
                    {
                        if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
                        {
                            //string str1 = "";

                        }
                        else if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
                        {
                            //string str2 = "";
                        }
                        else
                        {
                            continue;
                        }
                    }

                    try
                    {
                        string strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);
                    }
                    catch (Exception objExceptionIn)
                    {
                        throw objExceptionIn;
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
            return strCodeForCs.ToString();
        }

        public string Gen_Edit_Setup_GetEditDataObj(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"GetEditData{this.TabName_In4Edit4GC}Obj";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);

            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:把界面上的属性数据传到类对象中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">数据传输的目的类对象</param>",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + $" async function {strFuncName}()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const pobj{this.TabName_In4Edit4GC}EN = new cls{this.TabName_In4Edit4GC}EN();");
                //                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PutDataTo{0}Class.name;",
                //this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {

                    if (objEditRegionFldsEx.InUse == false)
                    {
                        if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
                        {
                            //string str1 = "";

                        }
                        else if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
                        {
                            //string str2 = "";
                        }
                        else
                        {
                            continue;
                        }
                    }

                    try
                    {
                        string strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);
                    }
                    catch (Exception objExceptionIn)
                    {
                        throw objExceptionIn;
                    }
                }
                strCodeForCs.Append("\r\n" + $"return pobj{this.TabName_In4Edit4GC}EN;");
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


        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                string strDefaUserIdExpress = clsPubFun4GC.GetDefaUserIdExpress(objViewInfoENEx.PrjId);
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
                    this.TabName_In4Edit4GC,
                    objEditRegionFldsEx.FldName, strDefaUserIdExpress);
                var objGCVariable = clsGCVariableBLEx.GetObjByVarNameAndType("UserId", enumGCVariableType.localStorage_0003, objViewInfoENEx.PrjId);
                if (objGCVariable != null)
                {
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objGCVariable.FilePath, objGCVariable.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                }
            }
            else if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objViewInfoENEx.PrjId);
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
                    this.TabName_In4Edit4GC,
                    objEditRegionFldsEx.FldName, strCurrDateTimeExpress);
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsDateTime.js", "clsDateTime", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else
            {
                string strVarName = "";
                clsGCVariableEN objVar = null;
                switch (objEditRegionFldsEx.CtlTypeId)
                {
                    case enumCtlType.CheckBox_02:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value);",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.TextBox_16:
                        if (objEditRegionFldsEx.IsNumberType() == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(Number({2}.value));",
             this.TabName_In4Edit4GC,
             objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
             objEditRegionFldsEx.CtrlId);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value);",
             this.TabName_In4Edit4GC,
             objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
             objEditRegionFldsEx.CtrlId);
                        }
                        break;
                    case enumCtlType.TextArea_41:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value);",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.DropDownList_06:
                        if (objEditRegionFldsEx.ObjFieldTab().TypeScriptType() == "boolean")
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value == \"true\"?true:false);",
           this.TabName_In4Edit4GC,
           objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
           objEditRegionFldsEx.CtrlId);
                        }
                        else
                        {
                            if (objEditRegionFldsEx.IsNumberType())
                            {
                                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value);",
                 this.TabName_In4Edit4GC,
                 objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                 objEditRegionFldsEx.CtrlId);
                            }
                            else
                            {
                                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(Is0EqEmpty({2}.value));",
                 this.TabName_In4Edit4GC,
                 objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                 objEditRegionFldsEx.CtrlId);
                                ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "Is0EqEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


                            }
                        }
                        break;
                    case enumCtlType.DropDownList_Bool_18:
                        if (objEditRegionFldsEx.ObjFieldTab().TypeScriptType() == "boolean")
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value == \"true\"?true:false);",
           this.TabName_In4Edit4GC,
           objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
           objEditRegionFldsEx.CtrlId);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value);",
             this.TabName_In4Edit4GC,
             objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
             objEditRegionFldsEx.CtrlId);
                        }
                        break;
                    case enumCtlType.DefaultValue_36:
                        if (objEditRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.DefaultValue);
                        }
                        else if (objEditRegionFldsEx.ObjFieldTab().DataTypeId == enumDataTypeAbbr.bit_03)
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.DefaultValue);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(\"{2}\");",
        this.TabName_In4Edit4GC,
        objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.DefaultValue);
                        }

                        break;
                    case enumCtlType.ViewVariable_38:

                        objVar = clsGCVariableBL.GetObjByVarIdCache(objEditRegionFldsEx.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }


                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({3}.value);",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         ThisClsName, strVarName);
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        break;
                    case enumCtlType.GivenValue_35:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         thisCacheClassify4View.VarDef4Fld);
                        break;

                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2}.value);",
                this.TabName_In4Edit4GC,
                objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                objEditRegionFldsEx.CtrlId);
                        break;
                }
                if (objVar != null && string.IsNullOrEmpty(objVar.ClsName) == false)
                {
                    ImportClass objImportClass = AddImportClass("", objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                }
            }
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        public string Gen_Edit_Setup_Clear(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"Clear";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + " * 清除用户自定义控件中,所有控件的值");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "function Clear()");
                strCodeForCs.Append("\r\n" + "{");
                //                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
                //this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13) continue;
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14) continue;

                    if (objEditRegionFldsEx.InUse == false) continue;

                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DefaultValue_36) continue;
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.ViewVariable_38) continue;


                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }

                    try
                    {
                        //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        //{
                        //    OperateType = "set",
                        //    ControlType = objEditRegionFldsEx.CtlTypeName,
                        //    CtrlId = objEditRegionFldsEx.CtrlId,
                        //    PropertyName = objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                        //    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                        //                "Clear()"),
                        //    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                        //    ParentDivName = $"this.divEdit"
                        //});
                        if (this.objViewInfoENEx.objCodeType == null)
                        {
                            this.objViewInfoENEx.objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(this.objViewInfoENEx.CodeTypeId);
                        }
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeId)
                        {
                            case enumCtlType.Button_01:
                                break;
                            case enumCtlType.CheckBox_02:
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue == null || objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = false;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = \"{objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue}\";");
                                }
                                break;
                            case enumCtlType.CheckBoxList_03:
                                break;
                            case enumCtlType.DataGrid_04:
                                break;
                            case enumCtlType.DataList_05:
                                break;
                            case enumCtlType.DropDownList_06: ///如果控件是下拉框;
                                //strCodeForCs.AppendFormat("\r\n" + " ClearSelectValueByIdInDivObj(this.divEdit, \"{1}\");", ThisClsName, objEditRegionFldsEx.CtrlId);
                                //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "ClearSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                                if (objEditRegionFldsEx.IsNumberType())
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = 0;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = \"0\";");
                                }

                                break;
                            case enumCtlType.DropDownList_Bool_18: ///如果控件是下拉框;
                                //strCodeForCs.AppendFormat("\r\n" + " ClearSelectValueByIdInDivObj(this.divEdit, \"{1}\");", ThisClsName, objEditRegionFldsEx.CtrlId);
                                //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "ClearSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);
                                if (objEditRegionFldsEx.ObjFieldTab().TypeScriptType() == "boolean")
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = \"0\";");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = \"0\";");
                                }

                                break;
                            case enumCtlType.HyperLink_07:
                                break;
                            case enumCtlType.Image_08:
                                break;
                            case enumCtlType.ImageButton_09:
                                break;
                            case enumCtlType.Label_10:
                                break;
                            case enumCtlType.LinkButton_11:
                                break;
                            case enumCtlType.ListBox_12:
                                break;
                            case enumCtlType.Panel_13:
                                break;
                            case enumCtlType.RadioButton_14:
                                break;
                            case enumCtlType.RadioButtonList_15:
                                break;
                            case enumCtlType.TextBox_16: ///如果控件类型是文本框;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue == null || objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = {strInitValue};");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = \"{objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue}\";");
                                }
                                break;
                            default:
                                strCodeForCs.Append("\r\n" + $"{objEditRegionFldsEx.PropertyName(this.IsFstLcase)}.value = {strInitValue};");
                                break;
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("生成字段:{0}时出错!{1}(In {2})", objEditRegionFldsEx.FldName,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                    }
                }
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
        public string Gen_Edit_Setup_HandleSave(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"handleSave";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + " * 处理保存逻辑");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "const handleSave = () => {");
                strCodeForCs.Append("\r\n" + "// 在这里处理保存逻辑");
                strCodeForCs.Append("\r\n" + "dialogVisible.value = false;");
                strCodeForCs.Append("\r\n" + "};");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_Edit_Setup_HideDialog(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"hideDialog";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + " * 隐藏对话框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "const hideDialog = () => {");
                strCodeForCs.Append("\r\n" + "dialogVisible.value = false;");
                strCodeForCs.Append("\r\n" + "};");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_Edit_Setup_ShowDialog(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"showDialog";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + " * 显示对话框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");

                strCodeForCs.Append("\r\n" + $"const showDialog =async (pobjPage_Edit: {ThisEditClsName}Ex) => {{");
                //strCodeForCs.Append("\r\n" + "dialogVisible.value = true;");
                strCodeForCs.AppendFormat("\r\n" + "objPage_Edit.value = pobjPage_Edit;");


                strCodeForCs.Append("\r\n" + "// 执行打开对话框的操作");
                strCodeForCs.Append("\r\n" + "dialogVisible.value = true;");
                strCodeForCs.Append("\r\n" + "await BindDdl4EditRegionInDiv();");

                strCodeForCs.Append("\r\n" + "};");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Method.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_Edit_Setup_ShowDataFromObj(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"ShowDataFrom{this.TabName_In4Edit4GC}Obj";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:把类对象的属性内容显示到界面上");
                strCodeForCs.Append("\r\n * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                strCodeForCs.Append("\r\n * 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">表实体类对象</param>",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + $" async function {strFuncName}(pobj{this.TabName_In4Edit4GC}EN: cls{this.TabName_In4Edit4GC}EN )");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;", this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13) continue;
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14) continue;

                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DefaultValue_36) continue;

                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.ViewVariable_38) continue;


                    string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

                }
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
        public string Gen_Vue_Ts_GetDataFromClassBak()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:把类对象的属性内容显示到界面上");
                strCodeForCs.Append("\r\n * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                strCodeForCs.Append("\r\n * 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">表实体类对象</param>",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " async function GetDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                this.TabName_In4Edit4GC, this.TabName_In4Edit4GC, this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;", this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13) continue;
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14) continue;

                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DefaultValue_36) continue;

                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.ViewVariable_38) continue;


                    string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

                }
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


        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            switch (objEditRegionFldsEx.CtlTypeId)
            {
                case enumCtlType.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "{2}.value = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// {2}.value = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    if (objEditRegionFldsEx.ObjFieldTab().TypeScriptType() == "boolean")
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}EN.{2}.toString();",
                                    objEditRegionFldsEx.CtrlId,
                                    this.TabName_In4Edit4GC,
                                    objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    }
                    else
                    {
                        if (objEditRegionFldsEx.IsNumberType())
                        {
                            sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}EN.{2};",
                                     objEditRegionFldsEx.CtrlId,
                                     this.TabName_In4Edit4GC,
                                     objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n" + " {2}.value = IsNullOrEmptyEq0(pobj{1}EN.{2});",
                                        objEditRegionFldsEx.CtrlId,
                                        this.TabName_In4Edit4GC,
                                        objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                            ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmptyEq0", enumImportObjType.CustomFunc, strBaseUrl);

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                    }
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_Bool_18:
                    if (objEditRegionFldsEx.ObjFieldTab().TypeScriptType() == "boolean")
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}EN.{2}.toString();",
                                    objEditRegionFldsEx.CtrlId,
                                    this.TabName_In4Edit4GC,
                                    objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}EN.{2};",
                                    objEditRegionFldsEx.CtrlId,
                                    this.TabName_In4Edit4GC,
                                    objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    }
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
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
        public string Gen_Vue_ts_PubVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var strFuncName = "";
            strCodeForCs.Append("\r\n" + GeneViewPubVarInVue(strFuncName, this.objCodeElement_Root));

            return strCodeForCs.ToString();
        }
        //public string Gen_Vue_ts_DivVarDef()
        //{
        //    StringBuilder strCodeForCs = new StringBuilder();
        //    StringBuilder sbCode_Export = new StringBuilder();
        //    sbCode_Export.Append("const divVarSet = reactive({");
        //    sbCode_Export.Append("\r\n" + " refDivEdit,");

        //    strCodeForCs.Append("\r\n" + "const refDivEdit = ref ();");

        //    sbCode_Export.Append("});");
        //    sbCode_Export.Append("export { divVarSet };");
        //    strCodeForCs.Append("\r\n" + sbCode_Export.ToString());

        //    return strCodeForCs.ToString();
        //}
        public string Gen_Edit_Setup_btnSubmit_Click(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"btnSubmit_Click";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Method);
            ;
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n * 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "const btnSubmit_Click =  async ()=>");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = btnSubmit_Click.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (objPage_Edit.value == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert('编辑页面初始化不成功,请联系管理员!');");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "const strCommandText: string = strSubmitButtonText.value;");

                //clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
                //{
                //    OperateType = "get",
                //    ControlType = "button",
                //    CtrlId = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                //    RefVarName = "strSubmitButtonText",
                //    PropertyName = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                //    Comment = "获取按钮的标题",
                //    DataType = "string",
                //    ParentDivName = "",
                //    ThisClsName = ThisEditClsName,
                //};
                //arrPropertyDef4GC.Add(objPropertyDef4GC);

                strCodeForCs.Append("\r\n" + "try {");
                //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                //this.TabName_In4Edit4GC, this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "let returnBool = false;");

                StringBuilder sbDefVar = new StringBuilder();
                StringBuilder sbCodeNext = new StringBuilder();



                sbCodeNext.Append("\r\n" + "let strInfo = \"\";");
                sbCodeNext.Append("\r\n" + "let strMsg = \"\";");

                sbCodeNext.Append("\r\n" + "switch(strCommandText)");
                sbCodeNext.Append("\r\n" + "{");

                sbCodeNext.Append("\r\n" + "case \"添加\":");
                sbCodeNext.AppendFormat("\r\n" + "strSubmitButtonText.value = \"确认添加\";", this.TabName_In4Edit4GC);
                sbCodeNext.AppendFormat("\r\n" + "strCancelButtonText.value = \"取消添加\";", this.TabName_In4Edit4GC);

                sbCodeNext.AppendFormat("\r\n" + " await objPage_Edit.value.AddNewRecord();",
                this.TabName_In4Edit4GC);
                sbCodeNext.Append("\r\n" + "break;				");
                sbCodeNext.Append("\r\n" + "case \"确认添加\":");
                sbCodeNext.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                sbCodeNext.Append("\r\n" + "//就把逻辑层合并到控制层,");
                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    sbCodeNext.Append("\r\n" + "returnBool = await objPage_Edit.value.AddNewRecordSave();");
                    //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    ThisClsName);
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.Append("\r\n" + $"hideDialog();");
                    sbCodeNext.Append("\r\n" + "}");
                    //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    if (objKeyField.IsNumberType())
                    {
                        iShowList_BindGv(sbCodeNext, "keyId.value.toString()");
                    }
                    else
                    {
                        iShowList_BindGv(sbCodeNext, "keyId.value");
                    }
                    //sbCodeNext.Append("\r\n" + "}");

                    sbCodeNext.Append("\r\n" + "}");

                }
                else if (thisEditTabProp_TS.KeyFldCount == 1)
                {
                    sbCodeNext.Append("\r\n" + $"if (['02', '03', '06'].indexOf(cls{TabName_In4Edit}EN._PrimaryTypeId) > -1)");
                    sbCodeNext.Append("\r\n" + "{");
                    if (objKeyField.CsType != "string")
                    {
                        sbCodeNext.Append("\r\n" + "const returnKeyId = await objPage_Edit.value.AddNewRecordWithReturnKeySave();");
                        //sbCodeNext.Append("\r\n" + "//const returnKeyId: string = <string>jsonData;");
                        if (objKeyField.IsNumberType())
                        {
                            sbCodeNext.Append("\r\n" + "if (returnKeyId != 0)");
                        }
                        else
                        {
                            sbCodeNext.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false && returnKeyId != \"0\")");
                        }
                        sbCodeNext.Append("\r\n" + "{");
                        sbCodeNext.Append("\r\n" + $"hideDialog();");
                        sbCodeNext.AppendFormat("\r\n" + "if (objPage_Edit.value.iShowList != null) objPage_Edit.value.iShowList.BindGvCache(cls{0}EN._CurrTabName, \"\");", this.TabName_In4Edit4GC);

                        sbCodeNext.Append("\r\n" + "}");
                        //sbCodeNext.Append("\r\n" + "//});");

                    }
                    else
                    {
                        sbCodeNext.Append("\r\n" + "returnKeyId = await objPage_Edit.value.AddNewRecordWithMaxIdSave();");
                        //sbCodeNext.Append("\r\n" + "const returnKeyId: string = <string>jsonData;");
                        sbCodeNext.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        sbCodeNext.Append("\r\n" + "{");
                        sbCodeNext.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
                        //sbCodeNext.Append("\r\n" + "{");
                        //sbCodeNext.Append("\r\n" + $"hideDialog();", ThisClsName);
                        //sbCodeNext.Append("\r\n" + "}");
                        sbCodeNext.Append("\r\n" + $"hideDialog();");
                        //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()?"Cache":"");

                        iShowList_BindGv(sbCodeNext, "returnKeyId");

                        sbCodeNext.Append("\r\n" + "}");
                        //定义变量returnKeyId
                        sbDefVar.Append("\r\n" + "let returnKeyId = \"\";");

                        //sbCodeNext.Append("\r\n" + "});");
                    }

                    sbCodeNext.Append("\r\n" + "}");
                    sbCodeNext.Append("\r\n" + "else");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "returnBool = await objPage_Edit.value.AddNewRecordSave();",
                          this.TabName_In4Edit4GC);
                    //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    ThisClsName);
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.Append("\r\n" + $"hideDialog();");
                    sbCodeNext.Append("\r\n" + "}");
                    //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    if (objKeyField.IsNumberType())
                    {
                        iShowList_BindGv(sbCodeNext, "keyId.value.toString()");
                    }
                    else
                    {
                        iShowList_BindGv(sbCodeNext, "keyId.value");
                    }
                    sbCodeNext.Append("\r\n" + "}");
                    sbCodeNext.Append("\r\n" + "}");
                }
                sbCodeNext.Append("\r\n" + "break;");

                sbCodeNext.Append("\r\n" + "case \"确认修改\":");
                sbCodeNext.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                //sbCodeNext.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                //this.TabName_In4Edit4GC);
                sbCodeNext.AppendFormat("\r\n" + "returnBool = await objPage_Edit.value.UpdateRecordSave();",
                this.TabName_In4Edit4GC);
                //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                sbCodeNext.Append("\r\n" + "strInfo = returnBool ? \"修改成功!\" : \"修改不成功!\";");
                sbCodeNext.AppendFormat("\r\n" + "strInfo += \"(In {0}.btnSubmit_Click)\";",
                    ThisClsName);

                sbCodeNext.Append("\r\n" + "//显示信息框");
                sbCodeNext.Append("\r\n" + "//console.log(strInfo);");
                sbCodeNext.Append("\r\n" + "alert(strInfo);");

                sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                sbCodeNext.Append("\r\n" + "{");

                sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
     ThisClsName);
                sbCodeNext.Append("\r\n" + "{");
                sbCodeNext.Append("\r\n" + $"hideDialog();");
                sbCodeNext.Append("\r\n" + "}");
                //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");

                if (objKeyField.IsNumberType())
                {
                    iShowList_BindGv(sbCodeNext, "keyId.value.toString()");
                }
                else
                {
                    iShowList_BindGv(sbCodeNext, "keyId.value");
                }

                sbCodeNext.Append("\r\n" + "}");
                //sbCodeNext.Append("\r\n" + "});");
                sbCodeNext.Append("\r\n" + "break;");
                sbCodeNext.Append("\r\n" + "default:");
                sbCodeNext.Append("\r\n" + "strMsg = Format(\"strCommandText:{0}在switch中没有处理!(In btnSubmit_Click())\", strCommandText);");
                sbCodeNext.Append("\r\n" + "console.error(strMsg);");
                sbCodeNext.Append("\r\n" + "alert(strMsg);");
                sbCodeNext.Append("\r\n" + "break;");

                sbCodeNext.Append("\r\n" + "}");

                sbCodeNext.Append("\r\n" + "}");
                sbCodeNext.Append("\r\n" + "catch (e)");
                sbCodeNext.Append("\r\n" + "{");
                sbCodeNext.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0033)在保存记录时({3})时出错!请联系管理员!{0}.(in {1}.{2})\", e, objPage_Edit.value.className, strThisFuncName, strCommandText);");
                sbCodeNext.Append("\r\n" + "console.error(strMsg);");
                sbCodeNext.Append("\r\n" + "alert(strMsg);");
                sbCodeNext.Append("\r\n" + "}");

                strCodeForCs.Append(sbDefVar.ToString());
                strCodeForCs.Append(sbCodeNext.ToString());

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
        public void iShowList_BindGv(StringBuilder strCode, string strReturnVar)
        {
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                strCode.AppendFormat("\r\n" + "if (objPage_Edit.value.iShowList != null) objPage_Edit.value.iShowList.BindGvCache(cls{0}EN._CurrTabName, {1});",
                    this.TabName_In4Edit4GC, strReturnVar);
            }
            else
            {
                strCode.AppendFormat("\r\n" + "if (objPage_Edit.value.iShowList != null) objPage_Edit.value.iShowList.BindGv(cls{0}EN._CurrTabName, {1});",
                    this.TabName_In4Edit4GC, strReturnVar);
            }
        }



        public string Gen_Edit_Mothods_GeneEventFuncEx()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrEditRegionFlds_ChangeEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /* 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");
                    strCodeForCs.Append("\r\n" + $" async  {x.ChangeEvent} (e: Event)  ");
                    //arrFuncName_Setup.Add(x.ChangeEvent);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "console.log(e)");

                    //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", x.ChangeEvent);
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在事件函数中重写该函数!');", ThisClsName);
                    strCodeForCs.Append("\r\n" + "},");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrEditRegionFlds_ClickEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /* 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "const {0} =   async () => {{;",
                       x.ClickEvent, ThisClsName);
                    arrFuncName_Setup.Add(x.ClickEvent);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", x.ClickEvent);
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
        public string Gen_Edit_Template_DefDiv4EditRegion(CodeElement objCodeElement_Parent)
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            CodeElement objCodeElement_Template = new CodeElement { Name = "template", ElementType = CodeElementType.Template, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Template);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "<template>");

            //生成编辑区域代码-------------------------------


            intZIndex += 1;
            intCurrTop += 25;
            ///生成用于布局的表格代码;
            strCodeForCs.Append("\r\n" + "<!-- 编辑层 -->");
            var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(CmPrjId);
            switch (objViewInfoENEx.objViewRegion_Edit.PageDispModeId)
            {
                case enumPageDispMode.PopupBox_01:
                    if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.ElementPlus_02)
                    {
                        strCodeForCs.Append("\r\n" + Gen_Edit_Html_Dialog4Popup());
                    }
                    else if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.AntDesignVue_01)
                    {
                        strCodeForCs.Append("\r\n" + Gen_Edit_Html_Dialog4Popup_Ant());
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + Gen_Edit_Html_Dialog4Popup());
                    }
                    break;
                case enumPageDispMode.Below_03:
                case enumPageDispMode.FullPage_05:
                case enumPageDispMode.Left_04:
                case enumPageDispMode.Right_02:
                    strCodeForCs.Append("\r\n" + Gen_Edit_Html_Dialog());
                    break;
                default:
                    strCodeForCs.Append("\r\n" + Gen_Edit_Html_Dialog4Popup());
                    break;
            }
            intZIndex += 1;
            intCurrLeft = 460;

            strCodeForCs.Append("\r\n" + "</template>");
            objCodeElement_Template.CodeContent = strCodeForCs.ToString();

            return strCodeForCs.ToString();
        }
        public string Gen_Edit_Script_DefDiv4EditRegion(CodeElement objCodeElement_Parent)
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
                strCodeForCs.Append("\r\n" + "import { defineComponent, ref } from \"vue\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "defineComponent, ref",
                    From = "vue",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    CodeContent = "import { defineComponent, ref } from \"vue\";"
                });


                //strCodeForCs.Append("\r\n" + "import router from '@/router';");
                strCodeForCs.Append("\r\n" + "import { clsDateTime } from '@/ts/PubFun/clsDateTime';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "clsDateTime",
                    CodeContent = "import { clsDateTime } from '@/ts/PubFun/clsDateTime';",
                    From = "@/ts/PubFun/clsDateTime",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });

                //strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\"");

                strCodeForCs.AppendFormat("\r\n" + $"import {ThisClsName}Ex from \"@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisClsName}Ex\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"{ThisClsName}Ex",
                    CodeContent = $"import {ThisClsName}Ex from \"@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisClsName}Ex\";",
                    From = $"@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisClsName}Ex",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });


                strCodeForCs.Append("\r\n" + $"import {{ cls{this.TabName_In4Edit4GC}EN }} from \"@/ts/L0Entity/{this.objFuncModuleEN.FuncModuleEnName4GC()}/cls{this.TabName_In4Edit4GC}EN\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"cls" + this.TabName_In4Edit4GC + "EN",
                    CodeContent = $"import {{ cls{this.TabName_In4Edit4GC}EN }} from \"@/ts/L0Entity/{this.objFuncModuleEN.FuncModuleEnName4GC()}/cls{this.TabName_In4Edit4GC}EN\";",
                    From = $"@/ts/L0Entity/{this.objFuncModuleEN.FuncModuleEnName4GC()}/cls{this.TabName_In4Edit4GC}EN",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });


                List<string> arrTemp = new List<string>();
                string strIsHasAccessIs0 = "";
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;

                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);
                    if (this.TabName_In4Edit4GC == objTabFeature4Ddl.TabName4GC) continue;
                    strCodeForCs.Append("\r\n" + $"import {{ cls{objTabFeature4Ddl.TabName4GC}EN }} from \"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN\";");
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                    {
                        Name = $"cls{objTabFeature4Ddl.TabName4GC}EN",
                        CodeContent = $"import {{ cls{objTabFeature4Ddl.TabName4GC}EN }} from \"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN\";",
                        From = $"@/ts/L0Entity/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}EN",
                        ElementType = CodeElementType.Import,
                        Modifiers = "import"
                    });


                }
                arrTemp.RemoveRange(0, arrTemp.Count);
                //针对每一个表功能--下拉框
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);
                    string strByCondition = "";
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.ConditionFieldName) == false)
                        strByCondition = $"By{objTabFeature4Ddl.ConditionFieldName}";

                    var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objTabFeature4Ddl.TabId, objTabFeature4Ddl.PrjId);
                    string strFuncName4Ex = $"GetArr{objTabFeature4Ddl.TabName4GC}{strByCondition}";
                    if (string.IsNullOrEmpty(objTabFeature4Ddl.GetDdlDataFuncName4Ex) == false)
                    {
                        strFuncName4Ex = objTabFeature4Ddl.GetDdlDataFuncName4Ex;
                    }
                    if (objEditRegionFld.IsNumberType() == false)
                    {
                        strIsHasAccessIs0 = ",IsNullOrEmptyEq0,Is0EqEmpty";
                    }
                    if (objTabFeature4Ddl.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}Ex_{strFuncName4Ex} }} from \"@/ts/L3ForWApiEx/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}ExWApi\";");
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                        {
                            Name = $"{objTabFeature4Ddl.TabName4GC}Ex_{strFuncName4Ex}",
                            CodeContent = $"import {{ {objTabFeature4Ddl.TabName4GC}Ex_{strFuncName4Ex} }} from \"@/ts/L3ForWApiEx/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}ExWApi\";",
                            From = $"@/ts/L3ForWApiEx/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}ExWApi",
                            ElementType = CodeElementType.Import,
                            Modifiers = "import"
                        });

                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"import {{ {objTabFeature4Ddl.TabName4GC}_{strFuncName4Ex} }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";");
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                        {
                            Name = $"{objTabFeature4Ddl.TabName4GC}_{strFuncName4Ex}",
                            CodeContent = $"import {{ {objTabFeature4Ddl.TabName4GC}_{strFuncName4Ex} }} from \"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi\";",
                            From = $"@/ts/L3ForWApi/{objTabFeature4Ddl.FuncModuleEnName}/cls{objTabFeature4Ddl.TabName4GC}WApi",
                            ElementType = CodeElementType.Import,
                            Modifiers = "import"
                        });

                    }
                }

                //List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRela = clsViewIdGCVariableRelaBLEx.GetEditRegionViewVarLst(objViewInfoENEx.ViewId );
                string strEditRegionVarNames = clsViewIdGCVariableRelaBLEx.GetEditRegionViewVarNames(objViewInfoENEx.ViewId, this.PrjId);
                if (strEditRegionVarNames.Length > 0) strEditRegionVarNames = $",{strEditRegionVarNames}";
                strCodeForCs.Append("\r\n" + $"import {{ refDivEdit {strEditRegionVarNames} }} from '@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"refDivEdit {strEditRegionVarNames}",
                    CodeContent = $"import {{ refDivEdit {strEditRegionVarNames} }} from '@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}';",
                    From = $"@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });


                strCodeForCs.Append("\r\n" + "import { useUserStore } from '@/store/modulesShare/user';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "useUserStore",
                    CodeContent = "import { useUserStore } from '@/store/modulesShare/user';",
                    From = "@/store/modulesShare/user",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });


                strCodeForCs.Append("\r\n" + $"import {{ Format, IsNullOrEmpty {strIsHasAccessIs0} }}                from '@/ts/PubFun/clsString';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "Format, IsNullOrEmpty",
                    CodeContent = "import { Format, IsNullOrEmpty " + strIsHasAccessIs0 + "} from '@/ts/PubFun/clsString';",
                    From = "@/ts/PubFun/clsString",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });

                strCodeForCs.Append("\r\n" + $"import {{ {ThisEditClsName} }}                from '@/viewsBase/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisEditClsName}';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"{ThisEditClsName}",
                    CodeContent = $"import {{ {ThisEditClsName} }} from '@/viewsBase/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisEditClsName}';",
                    From = $"@/viewsBase/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisEditClsName}",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });

                strCodeForCs.Append("\r\n" + "import { enumPageDispMode }                from '@/ts/PubFun/enumPageDispMode';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "enumPageDispMode",
                    CodeContent = "import { enumPageDispMode } from '@/ts/PubFun/enumPageDispMode';",
                    From = "@/ts/PubFun/enumPageDispMode",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import"
                });

                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_PubVar());
                //strCodeForCs.Append("\r\n" + Gen_Vue_ts_DivVarDef());

                strCodeForCs.Append("\r\n" + "  export  default defineComponent({");
                strCodeForCs.Append("\r\n" + $"name: '{clsString.FirstUcaseS(ThisClsName.Replace("_", ""))}',");

                strCodeForCs.Append("\r\n" + Gen_Edit_Components_Define(objCodeElement_Script));
                strCodeForCs.Append("\r\n" + Gen_Edit_Setup_Define(objCodeElement_Script));

                strCodeForCs.Append("\r\n" + "        watch: {");
                strCodeForCs.Append("\r\n" + "            // 数据监听");
                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + "        mounted() {");
                strCodeForCs.Append("\r\n" + "            // el 被新创建的 vm.$el 替换,并挂载到实例上去之后调用该钩子。");
                //strCodeForCs.AppendFormat("\r\n" + "            var objPage = new {0}Ex();", ThisClsName);
                //strCodeForCs.Append("\r\n" + "            objPage.PageLoadCache();");

                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + Gen_Edit_Methods_Define(objCodeElement_Script));
                //strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "});");
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
        public string Gen_Edit_Style_DefDiv4EditRegion(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Style = new CodeElement { Name = "style", ElementType = CodeElementType.Style, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Style);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "<style scoped>");
            //strCodeForCs.Append("\r\n" + "@import \"../../../node_modules/bootstrap/dist/css/bootstrap.css\";");
            //strCodeForCs.Append("\r\n" + "@import \"../../../node_modules/bootstrap/dist/js/bootstrap.min.js\";");
            strCodeForCs.Append("\r\n" + ".custom-header {");
            strCodeForCs.Append("\r\n" + "display: flex;");
            strCodeForCs.Append("\r\n" + "justify-content: space-between;");
            strCodeForCs.Append("\r\n" + "align-items: center;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "</style>");

            objCodeElement_Style.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_Edit_Setup_Return(CodeElement objCodeElement_Parent)
        {
            string strFuncName = $"return";
            CodeElement objCodeElement_Setup = new CodeElement { Name = strFuncName, ElementType = CodeElementType.SetupReturn, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Setup);
            List<string> arrTemp = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;

                strCodeForCs.Append("\r\n" + "return {");

                strCodeForCs.Append("\r\n" + "refDivEdit,");
                strCodeForCs.Append("\r\n" + "strTitle,");
                strCodeForCs.Append("\r\n" + "dialogVisible,");
                strCodeForCs.Append("\r\n" + "dialogWidth,");
                strCodeForCs.Append("\r\n" + "showDialog,");
                strCodeForCs.Append("\r\n" + "handleSave,");
                strCodeForCs.Append("\r\n" + "hideDialog,");
                strCodeForCs.Append("\r\n" + "strSubmitButtonText,");
                strCodeForCs.Append("\r\n" + "strCancelButtonText,");

                strCodeForCs.Append("\r\n" + $" GetEditData{this.TabName_In4Edit4GC}Obj,");
                strCodeForCs.Append("\r\n" + $" ShowDataFrom{this.TabName_In4Edit4GC}Obj,");
                strCodeForCs.Append("\r\n" + $" Clear,");
                strCodeForCs.Append("\r\n" + $" btnSubmit_Click,");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.InUse == false)
                    {
                        if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
                        { }
                        else if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
                        { }
                        else
                        {
                            continue;
                        }
                    }

                    try
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0},", objEditRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    catch (Exception objExceptionIn)
                    {
                        throw objExceptionIn;
                    }

                }
                arrTemp.RemoveRange(0, arrTemp.Count);
                foreach (var objEditRegionFld in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFld.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    if (string.IsNullOrEmpty(objEditRegionFld.TabFeatureId4Ddl)) continue;
                    var objTabFeature4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objEditRegionFld.TabFeatureId4Ddl, this.PrjId, this.IsFstLcase, objViewInfoENEx.ViewId);
                    if (arrTemp.Contains(objTabFeature4Ddl.TabName4GC) == true) continue;
                    arrTemp.Add(objTabFeature4Ddl.TabName4GC);
                    strCodeForCs.Append("\r\n" + $"arr{objTabFeature4Ddl.TabName4GC},");
                }
                foreach (string strFuncName1 in arrFuncName_Setup)
                {
                    strCodeForCs.Append("\r\n" + $"{strFuncName1},");
                };
                //strCodeForCs.Append("\r\n" + "btnClick,");
                strCodeForCs.Append("\r\n" + "};");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            objCodeElement_Setup.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

        public string Gen_Edit_Setup_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Setup = new CodeElement { Name = "setup", ElementType = CodeElementType.Setup, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Setup);
            StringBuilder strCodeForCs = new StringBuilder();


            strCodeForCs.Append("\r\n" + "setup() {");
            strCodeForCs.Append("\r\n" + "const userStore = useUserStore();");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "userStore",
                CodeContent = "const userStore = useUserStore();",
                ElementType = CodeElementType.Constant,
                Modifiers = "const"
            });
            strCodeForCs.Append("\r\n" + $"const strTitle = ref ('{TabCnName_In4Edit}编辑');");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "strTitle",
                CodeContent = $"const strTitle = ref ('{TabCnName_In4Edit}编辑');",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.Append("\r\n" + "const strSubmitButtonText = ref ('添加');");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "strSubmitButtonText",
                CodeContent = "const strSubmitButtonText = ref ('添加');",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.Append("\r\n" + "const strCancelButtonText = ref ('取消');");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "strCancelButtonText",
                CodeContent = "const strCancelButtonText = ref ('取消');",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.Append("\r\n" + "const keyId = ref ('');");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "keyId",
                CodeContent = "const keyId = ref ('');",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.AppendFormat("\r\n" + $" const objPage_Edit = ref<{ThisEditClsName}Ex>();");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "objPage_Edit",
                CodeContent = $" const objPage_Edit = ref<{ThisEditClsName}Ex>();",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.Append("\r\n" + "const dialogVisible = ref (false);");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "dialogVisible",
                CodeContent = "const dialogVisible = ref (false);",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.Append("\r\n" + "const dialogWidth = ref ('800px'); // 设置对话框的宽度");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "dialogWidth",
                CodeContent = "const dialogWidth = ref ('800px'); // 设置对话框的宽度",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const"
            });
            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_DefineFieldRefConst(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_DefineDdlDataVarName(objCodeElement_Setup));

            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_BindDdl4EditRegionInDiv(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_GetEditDataObj(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_ShowDataFromObj(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_Clear(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_btnSubmit_Click(objCodeElement_Setup));

            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_ShowDialog(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_HandleSave(objCodeElement_Setup));

            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_HideDialog(objCodeElement_Setup));

            strCodeForCs.Append("\r\n" + Gen_Edit_Setup_Return(objCodeElement_Setup));

            strCodeForCs.Append("\r\n" + "},");

            objCodeElement_Setup.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_Edit_Components_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Components = new CodeElement { Name = "components", ElementType = CodeElementType.Components, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Components);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "        components: {");
            strCodeForCs.Append("\r\n" + "            // 组件注册");
            //strCodeForCs.AppendFormat("\r\n" + "{0}", objViewRegion_Edit.ClsName);
            strCodeForCs.Append("\r\n" + "        },");
            objCodeElement_Components.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_Edit_Methods_Define(CodeElement objCodeElement_Parent)
        {
            objCodeElement_Methods = new CodeElement { Name = "methods", ElementType = CodeElementType.Methods, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Methods);
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            string strTemp = "";
            strCodeForCs.Append("\r\n" + "        methods: {");
            strCodeForCs.Append("\r\n" + "            // 方法定义");

            strJSPath = string.Format("../js/{0}", this.objFuncModuleEN.FuncModuleEnName4GC());

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
            strCodeForCs.Append("\r\n" + Gen_Edit_Mothods_GeneEventFuncEx());
            strCodeForCs.Append("\r\n" + "        },");

            objCodeElement_Methods.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }

    }
}

