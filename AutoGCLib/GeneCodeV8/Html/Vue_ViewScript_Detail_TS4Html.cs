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
using com.taishsoft.util;
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
    partial class Vue_ViewScript_Detail_TS4Html : clsGeneCodeBase4View
    {
        private CodeElement objCodeElement_Methods = null;
        private string strJSPath = "";
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public Vue_ViewScript_Detail_TS4Html()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public Vue_ViewScript_Detail_TS4Html(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Vue_ViewScript_Detail_TS4Html(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
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



        public string Gen_Vue_JS_Page_Load(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  页面导入-在导入页面后运行的函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "window.onload = function() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex\"], function({1}) {{",
       ThisClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
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
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_JS_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  查询记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnQuery_Click()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex\"], function({1}) {{",
                ThisClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnQuery_Click\");");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", ThisClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnQuery_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_JS_PrevPage(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function PrevPage()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = this.objPager.currPageIndex;");
            strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex) - 1;");
            strCodeForCs.Append("\r\n" + "//console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex\"], function({1}) {{",
                ThisClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);

            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", ThisClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_JS_NextPage(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function NextPage()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = this.objPager.currPageIndex;");
            strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex) + 1;");
            strCodeForCs.Append("\r\n" + "//console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex\"], function({1}) {{",
                ThisClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);

            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();",
                ThisClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_JS_JumpToPage(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function JumpToPage()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = $('#input_number').val();");
            strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "//console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex\"], function({1}) {{",
                ThisClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);

            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", ThisClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_JS_SortBy(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function SortBy(strFldName)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "//console.log(\"按：\" + strFldName + \"排序\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex\"], function({1}) {{",
                ThisClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);

            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", ThisClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.SortBy(strFldName);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_JS_ExpandDiv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "         function ExpandDiv(divName) {");
            strCodeForCs.Append("\r\n" + "//基于RequireJS来调用tzPubFun.ts中的函数OnlyShowDiv。");
            strCodeForCs.Append("\r\n" + "require([\"../js/TS/PubFun/tzPubFun\"], function (pubfun) {");
            strCodeForCs.Append("\r\n" + "      pubfun.OnlyShowDiv(divName, \"function\", \"content\");");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
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

        private string GetCode4FieldInPutDataToClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = $(\"#{2}\").val();",
            objViewInfoENEx.TabName,
            objDetailRegionFldsEx.FldName,
            objDetailRegionFldsEx.CtrlId);
            sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        private string GetCode4FieldInGetDataFromClassBak(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(pobj{1}EN.{2});",
                        objDetailRegionFldsEx.CtrlId,
                        objViewInfoENEx.TabName,
                        objDetailRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }


        private string GetCode4FieldInGetDataFromClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            string strDataProperty = "";
            string strTypeScriptType = objDetailRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType;
            if (objDetailRegionFldsEx.IsUseFunc() == true)
            {
                strDataProperty = objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase);
            }
            else
            {
                strDataProperty = objDetailRegionFldsEx.PropertyName(this.IsFstLcase);
            }
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlType.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "{2}.value = pobj{1}ENEx.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                this.TabName_Out4DetailRegion4GC,
                                strDataProperty);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// {2}.value = pobj{1}ENEx.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                this.TabName_Out4DetailRegion4GC,
                                strDataProperty);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    if (objDetailRegionFldsEx.ObjFieldTab().TypeScriptType() == "boolean")
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}ENEx.{2}.toString();",
                                    objDetailRegionFldsEx.CtrlId,
                                    this.TabName_Out4DetailRegion4GC,
                                    strDataProperty);
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = IsNullOrEmptyEq0(pobj{1}ENEx.{2});",
                                    objDetailRegionFldsEx.CtrlId,
                                    this.TabName_Out4DetailRegion4GC,
                                    strDataProperty);
                    }
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_Bool_18:
                    if (objDetailRegionFldsEx.ObjFieldTab().TypeScriptType() == "boolean")
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}ENEx.{2}.toString();",
                                    objDetailRegionFldsEx.CtrlId,
                                    this.TabName_Out4DetailRegion4GC,
                                    strDataProperty);
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}ENEx.{2};",
                                    objDetailRegionFldsEx.CtrlId,
                                    this.TabName_Out4DetailRegion4GC,
                                    strDataProperty);
                    }
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.Label_10:
                    if (strTypeScriptType == "boolean")                        //|| strTypeScriptType == "number")
                    {
                        //sbCodeForCs.AppendFormat("\r\n" + " SetLabelHtmlByIdInDivObj({0}, \"{1}\", value !== null ? value.toString() : '');", x.ParentDivName, x.CtrlId);
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}ENEx.{2} !== null ? pobj{1}ENEx.{2}.toString(): '';",
                              objDetailRegionFldsEx.CtrlId,
                              this.TabName_Out4DetailRegion4GC,
                              strDataProperty);
                    }
                    else
                    {
                        //strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}ENEx.{2};",
                               objDetailRegionFldsEx.CtrlId,
                               this.TabName_Out4DetailRegion4GC,
                               strDataProperty);
                    }
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    if (strTypeScriptType == "boolean")//                        || strTypeScriptType == "number")
                    {
                        //sbCodeForCs.AppendFormat("\r\n" + " SetLabelHtmlByIdInDivObj({0}, \"{1}\", value !== null ? value.toString() : '');", x.ParentDivName, x.CtrlId);
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}ENEx.{2} !== null ? pobj{1}ENEx.{2}.toString(): '';",
                              objDetailRegionFldsEx.CtrlId,
                              this.TabName_Out4DetailRegion4GC,
                              strDataProperty);
                    }
                    else
                    {
                        //strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                        sbCodeForCs.AppendFormat("\r\n" + " {2}.value = pobj{1}ENEx.{2};",
                               objDetailRegionFldsEx.CtrlId,
                               this.TabName_Out4DetailRegion4GC,
                               strDataProperty);
                    }
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }


            return sbCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            //让用户设置属性;
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse == null)
            {
                return "";
                //StringBuilder sbMessage = new StringBuilder();
                //string strViewName = objViewInfoENEx.ViewName;
                //sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有详细信息区域,或者详细信息区域没有字段。请检查!", strViewName);
                //throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中详细信息区域没有字段,请检查!", strViewName);
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
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("///生成查询、修改、删除、添加记录的界面代码(利用控件)");
                //strCodeForCs.AppendFormat("\r\n" + "<%@ Register TagPrefix = \"uc1\" TagName = \"wuc{0}B\" Src = \"wuc{1}B.ascx\" %>",
                //  objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "<%@ Register TagPrefix = \"uc2\" TagName = \"{0}\" Src = \"{0}.ascx\" %>",
                //    ClsName4WucTabName4Gv());
                //0003:QUDI模式
                strCodeForCs.Append("\r\n" + Gen_Detail_Template_DefDiv4EditRegion(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_Detail_Script_DefDiv4EditRegion(objCodeElement_Root));
                strCodeForCs.Append("\r\n" + Gen_Detail_Style_DefDiv4EditRegion(objCodeElement_Root));

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

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" class = \"div_query\"> ",
              objViewInfoENEx.TabName, intDivHeight);


            intCurrTop -= 30;//因为这是在层(div)中
            //int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            ///
            //bool bolIsTrEnd = true;
            IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            if (arrViewRegion.Count() == 0)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            string lngRegionId = arrViewRegion.First().RegionId;

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroup(lngRegionId, objViewInfoENEx, "Item1");
            //foreach(ASPControlGroupEx objInFor in arrControlGroups)
            //{

            //}
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
            objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


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
        public string Gen_Vue_Cs4Ts_DefDiv4DetailRegion4NotPopup()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);

            StringBuilder strCodeForCs = new StringBuilder();


            Func<clsDetailRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrDetailRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);

            //封装Td
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);
            var objViewRegion = objViewInfoENEx.objViewRegion_Detail;
            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
                    objTable.Width = objViewRegionEx.Width ?? 0;
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

                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
                    objTable2.Width = objViewRegionEx.Width ?? 0;
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
            }
            if (objViewRegionEx.ContainerTypeId == enumGCContainerType.TableContainer_0001)
            {

            }
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + "      <template #footer>");
            strCodeForCs.AppendFormat("\r\n" + " <el-button  id=\"btnCancel{0}\" @click = \"dialogVisible = false\">{{{{ strCancelButtonText }}}}</el-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </template>");
            strCodeForCs.Append("\r\n" + " </el-dialog>");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Cs4Ts_DefDiv4DetailRegion4NotPopup_Ant()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);

            StringBuilder strCodeForCs = new StringBuilder();


            Func<clsDetailRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrDetailRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);

            //封装Td
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);
            var objViewRegion = objViewInfoENEx.objViewRegion_Detail;
            switch (objViewRegion.ContainerTypeId)
            {
                case enumGCContainerType.TableContainer_0001:
                    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
                    objTable.Width = objViewRegionEx.Width ?? 0;
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

                    ASPHtmlTableEx objTable2 = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
                    objTable2.Width = objViewRegionEx.Width ?? 0;
                    objTable2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
            }
            if (objViewRegionEx.ContainerTypeId == enumGCContainerType.TableContainer_0001)
            {

            }
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + "      <template #footer>");
            strCodeForCs.AppendFormat("\r\n" + " <a-button  id=\"btnCancel{0}\" @click = \"dialogVisible = false\">{{{{ strCancelButtonText }}}}</a-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </template>");
            strCodeForCs.Append("\r\n" + " </a-modal>");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Vue_Cs4Ts_DefDiv4DetailRegion()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);

            StringBuilder strCodeForCs = new StringBuilder();


            Func<clsDetailRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrDetailRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);

            //封装Td
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
            objTable.Width = objViewRegionEx.Width ?? 0;
            //foreach (ASPControlEx objInFor in arrASPControlGroupObjLst)
            //{
            //    objTable.arrSubAspControlLst2.Add(objInFor);
            //}
            objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + "      <template #footer>");
            strCodeForCs.AppendFormat("\r\n" + " <el-button  id=\"btnCancel{0}\" @click = \"dialogVisible = false\">{{{{ strCancelButtonText }}}}</el-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </template>");
            strCodeForCs.Append("\r\n" + " </el-dialog>");


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Cs4Ts_DefDiv4DetailRegion_Ant()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);

            StringBuilder strCodeForCs = new StringBuilder();


            Func<clsDetailRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);

            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrDetailRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);

            //封装Td
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4DetailRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Detail.ColNum ?? 0);
            objTable.Width = objViewRegionEx.Width ?? 0;
            //foreach (ASPControlEx objInFor in arrASPControlGroupObjLst)
            //{
            //    objTable.arrSubAspControlLst2.Add(objInFor);
            //}
            objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + "      <template #footer>");
            strCodeForCs.AppendFormat("\r\n" + " <a-button  id=\"btnCancel{0}\" @click = \"dialogVisible = false\">{{{{ strCancelButtonText }}}}</a-button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </template>");
            strCodeForCs.Append("\r\n" + " </a-modal>");


            return strCodeForCs.ToString();
        }


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_ViewScript_Detail_TS4Html);
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
            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;
            objViewInfoENEx.ClsName = this.ClsName;
        }


        public string Gen_WebView_WA_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 功能区 -->");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4ListRegion()
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
        public string Gen_WebView_WA_Code4DetailRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 详细信息层 -->");
            strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion());

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "<!-- 查询层 -->");

            strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_JS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  显示对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "function ShowDialog(strDialogName) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "   require(['jquery', 'bootstrap'], function($) {");
            strCodeForCs.AppendFormat("\r\n" + " $(strDialogName).modal('show');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  });");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_JS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  隐藏对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "function HideDialog(strDialogName) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  require(['jquery', 'bootstrap'], function($) {");
            strCodeForCs.AppendFormat("\r\n" + "      $(strDialogName).modal('hide');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  });");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_JS_btnDetail_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  *按钮单击,用于调用Js函数中btnDetail_Click");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "btn{0}_Detail_Click(strCommandName:string, strKeyId:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "{0}Ex.btnDetail_Click(strCommandName, strKeyId);",
                 ThisClsName);
            strCodeForCs.Append("\r\n" + "},");


            return strCodeForCs.ToString();
        }

        public string Gen_Detail_setup_ShowDataFromObj(CodeElement objCodeElement_Parent)
        {
            
            string strFuncName = $"ShowDataFrom{this.TabName_Out4DetailRegion4GC}Obj";
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
                this.TabName_Out4DetailRegion4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " async function ShowDataFrom{0}Obj(pobj{2}ENEx: cls{1}ENEx )",
                this.TabName_Out4DetailRegion4GC, this.TabName_Out4DetailRegion4GC, this.TabName_Out4DetailRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;", this.TabName_Out4DetailRegion4GC, objKeyField.FldName);

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {

                    if (objDetailRegionFldsEx.CtlTypeId == enumCtlType.DefaultValue_36) continue;

                    if (objDetailRegionFldsEx.CtlTypeId == enumCtlType.ViewVariable_38) continue;


                    string strTemp = GetCode4FieldInGetDataFromClass(objDetailRegionFldsEx, objViewInfoENEx);
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

        public string Gen_Detail_Template_DefDiv4EditRegion(CodeElement objCodeElement_Parent)
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            CodeElement objCodeElement_Template = new CodeElement { Name = "template", ElementType = CodeElementType.Template, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Template);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "<template>");


            intZIndex = 101;
            intCurrLeft = 10;
            intCurrTop = 10;

            //用来定义正文的标签类型
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            //用来定义1号标题的标签类型
            clsLabelStyleEN objLabelStyle_T1 = clsLabelStyleBL.GetObjByLabelStyleIdCache("0003");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            //0003:QUDI模式
            var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(CmPrjId);
            if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.ElementPlus_02)
            {
                strCodeForCs.Append("\r\n" + " <el-dialog v-model = \"dialogVisible\" :width=\"dialogWidth\" :show-close=\"false\" >");
                strCodeForCs.Append("\r\n" + "<!--使用头部插槽来自定义对话框的标题-->");
                strCodeForCs.Append("\r\n" + "<template #header>");
                strCodeForCs.Append("\r\n" + "<div class=\"custom-header\">");
                strCodeForCs.Append("\r\n" + "<h3>{{ strTitle }}</h3 >");
                strCodeForCs.Append("\r\n" + "<el-button type = \"primary\" @click = \"dialogVisible = false\" ><font-awesome-icon icon=\"times\" /></el-button>");

                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</template>");

            }
            else if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.AntDesignVue_01)
            {
                strCodeForCs.AppendFormat("\r\n" + " <a-modal v-model:visible = \"dialogVisible\" :width=\"dialogWidth\" :title=\"strTitle\" >", objViewInfoENEx.ViewCnName);

                strCodeForCs.Append("\r\n" + "<!--使用头部插槽来自定义对话框的标题-->");
                strCodeForCs.Append("\r\n" + "<template #header>");
                strCodeForCs.Append("\r\n" + "<div class=\"custom-header\">");
                strCodeForCs.Append("\r\n" + "<h3>{{ strTitle }}</ h3 >");
                strCodeForCs.Append("\r\n" + "<a-button type = \"primary\" @click = \"dialogVisible = false\"  ><font-awesome-icon icon=\"times\" /></a-button>");

                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</template>");

            }
            else
            {
                strCodeForCs.Append("\r\n" + " <el-dialog v-model = \"dialogVisible\" :width=\"dialogWidth\" :show-close=\"false\" >");
                strCodeForCs.Append("\r\n" + "<!--使用头部插槽来自定义对话框的标题-->");
                strCodeForCs.Append("\r\n" + "<template #header>");
                strCodeForCs.Append("\r\n" + "<div class=\"custom-header\">");
                strCodeForCs.Append("\r\n" + "<h3>{{ strTitle }}</ h3 >");
                strCodeForCs.Append("\r\n" + "<el-button type = \"primary\" @click = \"dialogVisible = false\" ><font-awesome-icon icon=\"times\" /></el-button>");

                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</template>");


            }
            strCodeForCs.Append("\r\n" + "<div id = \"divDetailLayout\" ref=\"refDivDetail\" class = \"tab_layout\" ");
            strCodeForCs.Append("\r\n" + ">");

            //生成编辑区域代码-------------------------------

            ///生成用于布局的表格代码;
            strCodeForCs.Append("\r\n" + "<!-- 详细信息层 -->");
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true)
            {

                if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
                {
                    if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.ElementPlus_02)
                    {
                        strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion());
                    }
                    else if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.AntDesignVue_01)
                    {
                        strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion_Ant());
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion());
                    }
                }
                else
                {
                    if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.ElementPlus_02)
                    {
                        strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion4NotPopup());
                    }
                    else if (objCmProject.VueDesignSysId == enumVueCtrlDesignSys.AntDesignVue_01)
                    {
                        strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion4NotPopup_Ant());
                    }
                    else
                    { strCodeForCs.Append("\r\n" + Gen_Vue_Cs4Ts_DefDiv4DetailRegion4NotPopup()); }
                }
            }
            //生成编辑区域代码 == == == == == == == == == == == == == == 
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            strCodeForCs.Append("\r\n" + "</template>");
            objCodeElement_Template.CodeContent = strCodeForCs.ToString();

            return strCodeForCs.ToString();
        }
        public string Gen_Detail_Script_DefDiv4EditRegion(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Script = new CodeElement { Name = "script", ElementType = CodeElementType.Script, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Script);
            objCodeElement_Script.Children.Add(this.objCodeElement_Imports);
            string strFuncName = "";
            string strTemp = "";
            StringBuilder strCodeForCs = new StringBuilder();

            //生成编辑区域代码 == == == == == == == == == == == == == == 
            try
            {



                strCodeForCs.Append("\r\n" + "<script lang=\"ts\">");
                strCodeForCs.Append("\r\n" + "import { defineComponent, ref } from \"vue\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "defineComponent, ref",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    CodeContent = "import { defineComponent, ref } from \"vue\";",
                    From = "vue"
                });

                strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\"");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "Format",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    CodeContent = "import { Format } from \"@/ts/PubFun/clsString\";",
                    From = "@/ts/PubFun/clsString"
                });


                strCodeForCs.Append("\r\n" + $"import {ThisClsName}Ex from \"@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisClsName}Ex\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"{ThisClsName}Ex",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    CodeContent = $"import {ThisClsName}Ex from \"@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisClsName}Ex\";",
                    From = $"@/views{this.IsShareStr}/{this.objFuncModuleEN.FuncModuleEnName4GC()}/{ThisClsName}Ex"
                });

                strCodeForCs.Append("\r\n" + $"import {{ cls{TabName_Out4DetailRegion4GC}ENEx }} from \"@/ts/L0Entity/{this.objFuncModuleEN.FuncModuleEnName4GC()}/cls{TabName_Out4DetailRegion4GC}ENEx\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"cls{TabName_Out4DetailRegion4GC}ENEx",
                    ElementType = CodeElementType.Import,
                    Modifiers = "import",
                    CodeContent = $"import {{ cls{TabName_Out4DetailRegion4GC}ENEx }} from \"@/ts/L0Entity/{this.objFuncModuleEN.FuncModuleEnName4GC()}/cls{TabName_Out4DetailRegion4GC}ENEx\";",
                    From = $"@/ts/L0Entity/{this.objFuncModuleEN.FuncModuleEnName4GC()}/cls{TabName_Out4DetailRegion4GC}ENEx"
                });

                strCodeForCs.Append("\r\n" + "  export  default defineComponent({");

                strCodeForCs.Append("\r\n" + $"name: '{clsString.FirstUcaseS(ThisClsName.Replace("_", ""))}',");

       
                strCodeForCs.Append("\r\n" + Gen_Detail_Components_Define(objCodeElement_Script));
                strCodeForCs.Append("\r\n" + Gen_Detail_Setup_Define(objCodeElement_Script));

                strCodeForCs.Append("\r\n" + "        watch: {");
                strCodeForCs.Append("\r\n" + "            // 数据监听");
                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + "        mounted() {");
                strCodeForCs.Append("\r\n" + "            // el 被新创建的 vm.$el 替换,并挂载到实例上去之后调用该钩子。");
                //strCodeForCs.AppendFormat("\r\n" + "            var objPage = new {0}Ex();", ThisClsName);
                //strCodeForCs.Append("\r\n" + "            objPage.PageLoadCache();");

                strCodeForCs.Append("\r\n" + "        },");

                strCodeForCs.Append("\r\n" + Gen_Detail_Methods_Define(objCodeElement_Script));

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

                strCodeForCs.Append("\r\n" + "        },");
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
        public string Gen_Detail_Style_DefDiv4EditRegion(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Style = new CodeElement { Name = "style", ElementType = CodeElementType.Style, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Style);
            StringBuilder strCodeForCs = new StringBuilder();

            //strCodeForCs.Append("\r\n" + "<input id=\"hidCurrPageIndex\" type = \"hidden\" value = \"1\" />");
            //strCodeForCs.AppendFormat("\r\n" + "<input id=\"h1idSort{0}By\" type = \"hidden\" value = \"\" />", strTabName_Out4ListRegion);
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

        public string Gen_Detail_Setup_Define(CodeElement objCodeElement_Parent)
        {
            CodeElement objCodeElement_Setup = new CodeElement { Name = "setup", ElementType = CodeElementType.Setup, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Setup);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "setup() {");

            strCodeForCs.AppendFormat("\r\n" + "const strTitle = ref ('{0}详细信息');", TabCnName_Out4Detail);
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "strTitle",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const",
                CodeContent = $"const strTitle = ref ('{TabCnName_Out4Detail}详细信息');"
            });

            strCodeForCs.Append("\r\n" + "const refDivDetail = ref ();");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "refDivDetail",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const",
                CodeContent = "const refDivDetail = ref ();"
            });

            strCodeForCs.Append("\r\n" + "const strCancelButtonText = ref ('取消');");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "strCancelButtonText",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const",
                CodeContent = "const strCancelButtonText = ref ('取消');"
            });

            strCodeForCs.Append("\r\n" + "const dialogVisible = ref (false);");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "dialogVisible",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const",
                CodeContent = "const dialogVisible = ref (false);"
            });

            strCodeForCs.Append("\r\n" + "const dialogWidth = ref ('800px'); // 设置对话框的宽度");
            objCodeElement_Setup.Children.Add(new CodeElement
            {
                Name = "dialogWidth",
                ElementType = CodeElementType.RefConstant,
                Modifiers = "const",
                CodeContent = "const dialogWidth = ref ('800px'); // 设置对话框的宽度"
            });

            foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet)
            {

                if (objDetailRegionFldsEx.InUse == false)
                {
                    continue;
                }


                try
                {
                    if (objDetailRegionFldsEx.IsUseFunc() == true)
                    {
                        switch (objDetailRegionFldsEx.ObjOutFieldTab().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "const {0} = ref('');", objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase));
                                objCodeElement_Setup.Children.Add(new CodeElement
                                {
                                    Name = objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                    ElementType = CodeElementType.RefConstant,
                                    Modifiers = "const",
                                    CodeContent = $"const {objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase)} = ref('');"
                                });

                                break;
                            case "number":
                                strCodeForCs.AppendFormat("\r\n" + "const {0} = ref(0);", objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase));//  objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                objCodeElement_Setup.Children.Add(new CodeElement
                                {
                                    Name = objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                    ElementType = CodeElementType.RefConstant,
                                    Modifiers = "const",
                                    CodeContent = $"const {objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase)} = ref(0);"
                                });

                                break;
                            case "boolean":

                                if (objDetailRegionFldsEx.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const {0} = ref(true)", objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    objCodeElement_Setup.Children.Add(new CodeElement
                                    {
                                        Name = objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase),
                                        ElementType = CodeElementType.RefConstant,
                                        Modifiers = "const",
                                        CodeContent = $"const {objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)} = ref(true);"
                                    });

                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const {0} = ref('0')", objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    objCodeElement_Setup.Children.Add(new CodeElement
                                    {
                                        Name = objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase),
                                        ElementType = CodeElementType.RefConstant,
                                        Modifiers = "const",
                                        CodeContent = $"const {objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)} = ref('0');"
                                    });

                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "const {0} = ref('');", objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase));// objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                objCodeElement_Setup.Children.Add(new CodeElement
                                {
                                    Name = objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                    ElementType = CodeElementType.RefConstant,
                                    Modifiers = "const",
                                    CodeContent = $"const {objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase)} = ref('');"
                                });

                                break;
                        }
                    }
                    else
                    {

                        switch (objDetailRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType)
                        {
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "const {0} = ref('');", objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                                objCodeElement_Setup.Children.Add(new CodeElement
                                {
                                    Name = objDetailRegionFldsEx.PropertyName(this.IsFstLcase),
                                    ElementType = CodeElementType.RefConstant,
                                    Modifiers = "const",
                                    CodeContent = $"const {objDetailRegionFldsEx.PropertyName(this.IsFstLcase)} = ref('');"
                                });

                                break;
                            case "number":
                                strCodeForCs.AppendFormat("\r\n" + "const {0} = ref(0);", objDetailRegionFldsEx.PropertyName(this.IsFstLcase));//  objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                objCodeElement_Setup.Children.Add(new CodeElement
                                {
                                    Name = objDetailRegionFldsEx.PropertyName(this.IsFstLcase),
                                    ElementType = CodeElementType.RefConstant,
                                    Modifiers = "const",
                                    CodeContent = $"const {objDetailRegionFldsEx.PropertyName(this.IsFstLcase)} = ref(0);"
                                });

                                break;
                            case "boolean":

                                if (objDetailRegionFldsEx.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const {0} = ref(true)", objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    objCodeElement_Setup.Children.Add(new CodeElement
                                    {
                                        Name = objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase),
                                        ElementType = CodeElementType.RefConstant,
                                        Modifiers = "const",
                                        CodeContent = $"const {objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)} = ref(true);"
                                    });

                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const {0} = ref('0')", objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                    objCodeElement_Setup.Children.Add(new CodeElement
                                    {
                                        Name = objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase),
                                        ElementType = CodeElementType.RefConstant,
                                        Modifiers = "const",
                                        CodeContent = $"const {objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase)} = ref('0');"
                                    });

                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "const {0} = ref('');", objDetailRegionFldsEx.PropertyName(this.IsFstLcase));// objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                                objCodeElement_Setup.Children.Add(new CodeElement
                                {
                                    Name = objDetailRegionFldsEx.PropertyName(this.IsFstLcase),
                                    ElementType = CodeElementType.RefConstant,
                                    Modifiers = "const",
                                    CodeContent = $"const {objDetailRegionFldsEx.PropertyName(this.IsFstLcase)} = ref('');"
                                });

                                break;
                        }

                    }

                }
                catch (Exception objExceptionIn)
                {
                    throw objExceptionIn;
                }
            }

            strCodeForCs.Append("\r\n" + Gen_Detail_setup_ShowDataFromObj(objCodeElement_Setup));

       
            strCodeForCs.Append("\r\n" + Gen_Detail_Setup_ShowDialog(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Detail_Setup_HideDialog(objCodeElement_Setup));
            strCodeForCs.Append("\r\n" + Gen_Detail_Setup_Return(objCodeElement_Setup));

            strCodeForCs.Append("\r\n" + "},");

            objCodeElement_Setup.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }


        public string Gen_Detail_Components_Define(CodeElement objCodeElement_Parent)
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
        public string Gen_Detail_Methods_Define(CodeElement objCodeElement_Parent)
        {
            objCodeElement_Methods = new CodeElement { Name = "methods", ElementType = CodeElementType.Methods, Modifiers = "export abstract" };
            objCodeElement_Parent.Children.Add(objCodeElement_Methods);
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            strCodeForCs.Append("\r\n" + "        methods: {");
            strCodeForCs.Append("\r\n" + "            // 方法定义");
            strCodeForCs.Append("\r\n" + "btnClick(strCommandName:string, strKeyId:string) {");
            strCodeForCs.Append("\r\n" + "                alert(Format(\"{0}-{1}\", strCommandName, strKeyId));");

            strCodeForCs.Append("\r\n" + "},");


            objCodeElement_Methods.CodeContent = strCodeForCs.ToString();
            return strCodeForCs.ToString();
        }
        public string Gen_Detail_Setup_Return(CodeElement objCodeElement_Parent)
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
                strCodeForCs.Append("\r\n" + "strTitle,");
                strCodeForCs.Append("\r\n" + "refDivDetail,");
                strCodeForCs.Append("\r\n" + "dialogVisible,");
                strCodeForCs.Append("\r\n" + "dialogWidth,");
                strCodeForCs.Append("\r\n" + "showDialog,");
                strCodeForCs.Append("\r\n" + "hideDialog,");
                strCodeForCs.Append("\r\n" + "strCancelButtonText,");
                strCodeForCs.Append("\r\n" + "SetButtonText,");
                strCodeForCs.Append("\r\n" + "GetButtonText,");
                strCodeForCs.Append("\r\n" + $" ShowDataFrom{this.TabName_Out4DetailRegion4GC}Obj,");
                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet)
                {
                    if (objDetailRegionFldsEx.InUse == false)
                    {
                        continue;
                    }
                    try
                    {
                        if (objDetailRegionFldsEx.IsUseFunc() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0},", objDetailRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0},", objDetailRegionFldsEx.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                        }
                    }
                    catch (Exception objExceptionIn)
                    {
                        throw objExceptionIn;
                    }

                }
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
        public string Gen_Detail_Setup_HideDialog(CodeElement objCodeElement_Parent)
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
        public string Gen_Detail_Setup_ShowDialog(CodeElement objCodeElement_Parent)
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
                strCodeForCs.Append("\r\n" + "const showDialog = () => {");
                //strCodeForCs.Append("\r\n" + "dialogVisible.value = true;");
                strCodeForCs.Append("\r\n" + "return new Promise((resolve) => {");
                strCodeForCs.Append("\r\n" + "// 执行打开对话框的操作");
                strCodeForCs.Append("\r\n" + "dialogVisible.value = true;");
                strCodeForCs.Append("\r\n" + "resolve('对话框打开成功');");
                strCodeForCs.Append("\r\n" + "setTimeout(() => {");
                strCodeForCs.Append("\r\n" + "console.log('对话框已经显示!');");
                strCodeForCs.Append("\r\n" + "}, 1000);");
                strCodeForCs.Append("\r\n" + "});");

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

    }
}


