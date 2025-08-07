using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    partial class Vue_ViewScriptCSEx_TS4TypeScript : clsGeneCodeBase4View   
    {
        
        //private string objPrjTabENEx = "";

        //clsBiDimDistribute objBiDimDistribue4Qry = null;




        public Vue_ViewScriptCSEx_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScriptCSEx_TS4TypeScript(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScriptCSEx_TS4TypeScript( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }

        public string Gen_Vue_Ts_DdlBind4QueryRegion()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                            //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdl_TrueAndFalse(ddl{0}_q);",
                            //            objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            //string strDS_DataValueField;
                            //string strDS_DataTextField;
                            string strDsTabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsQryRegionFldsBLEx.Ds_PrjTab4Get(objQryRegionFldsEx);
                                strDsTabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDsTabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空,请检查!({2}).",
                                objViewInfoENEx.ViewName, "查询区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            //try
                            //{
                            //    strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                            //    objViewInfoENEx.ViewName, "查询区域", objException.Message, strDsTabName);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                            //        objViewInfoENEx.ViewName, "查询区域", strDsTabName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //try
                            //{
                            //    strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                            //    objViewInfoENEx.ViewName, "查询区域", objException.Message, strDsTabName, strDS_DataValueField);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                            //          objViewInfoENEx.ViewName, "查询区域", strDsTabName, strDS_DataValueField,
                            //          clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            //{
                            //    arrDdlKeyIdLst.Add(strDS_DataValueField);
                            //}
                            //else
                            //{
                            //    continue;
                            //}
                            switch (objQryRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///列表项串;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /** 绑定下拉框:ddl{0}的函数。", objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + " **/");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    split = objQryRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//为下拉框设置内容的样例,该下拉框的列表项是直接添加的");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"男\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"女\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///列表项数据源表;

                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + "* 为下拉框获取数据,从表:[{0}]中获取",
                                      strDsTabName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                                    strCodeForCs.Append("\r\n" + "* returns:获取主键字段、名称字段两列的所有记录记录的DataTable");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    //strCodeForCs.AppendFormat("\r\n" + "public static BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                    //  strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    //strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    //strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    //strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    //strCodeForCs.Append("\r\n" + "{");
                                    //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"下拉框：{{0}} 不存在!\", ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定下拉框(查询区)不成功,{0}.\",e);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg)");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + "*  为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                                    strCodeForCs.Append("\r\n" + "* returns:获取自定义的Sql串中两列的所有记录记录的DataTable");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /** 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @param objDDL\">需要绑定当前表的下拉框</param>");
                                    strCodeForCs.Append("\r\n" + " **/");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataValueField);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                            }
                        }
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

        public string Gen_Vue_Ts_SortColumn()
        {
            string strFuncName = $"SortColumn";
            CodeElement objCodeElement_Method = new CodeElement { Name = strFuncName, ElementType = CodeElementType.Method, Modifiers = "export abstract" };
            
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                string strFuncName_Temp = getBindGvFuncName();
                ///生成仅有变量;
                strCodeForCs.Append("\r\n" + "public async SortColumn(sortColumnKey: string, sortDirection: string) {");
                strFuncName = "SortColumn";
                strCodeForCs.Append("\r\n" + $"switch(sortColumnKey)");
                strCodeForCs.Append("\r\n" + "{");
                var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
                foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.OutFldId) == true) continue;
                    string strOutFldName = clsString.FstLcaseS(objDGRegionFldsENEx.OutFldName());
                    strCodeForCs.Append("\r\n" + $"case \"{clsString.FirstLcaseS(strOutFldName)}|Ex\":");
                    string strRelaTabId = clsDnPathBLEx.GetLeftJoinTabIdByDnPathId(
                        objDGRegionFldsENEx.TabId(),
                        objDGRegionFldsENEx.DnPathId(),
                        objDGRegionFldsENEx.PrjId);
                    List<(string, string)> arrOnCondition = clsDnPathBLEx.GetOnConditionByDnPathId(
                                            objDGRegionFldsENEx.DnPathId(),
                                            objDGRegionFldsENEx.PrjId);
                    if (arrOnCondition != null && arrOnCondition.Count > 0 && strRelaTabId != "")
                    {
                        strCodeForCs.Append("\r\n" + $"viewVarSet.sort{objViewInfoENEx.TabName}By = `{strOutFldName} ${{sortDirection}}|");
                        foreach (var objInFor in arrOnCondition)
                        {
                            //string strTabName = clsPrjTabBLEx.GetTabNameByTabIdCache(strRelaTabId, objDGRegionFldsENEx.PrjId);
                            //string strOnCoditionLst = string.Join(",", arrOnCondition);
                            strCodeForCs.Append($"({objInFor.Item1}){objInFor.Item2}|");
                        }
                        strCodeForCs.Append("`;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"viewVarSet.sort{objViewInfoENEx.TabName}By = Format('{{0}} {{1}}', sortColumnKey, sortDirection);");
                    }
                    strCodeForCs.Append("\r\n" + "break;");
                }

                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + $"viewVarSet.sort{objViewInfoENEx.TabName}By = Format('{{0}} {{1}}', sortColumnKey, sortDirection);");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"await {strFuncName_Temp}(this.listPara.listDiv);");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();

        }
        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.objCodeElement_Root = new CodeElement { Name = "Root", ElementType = CodeElementType.Root };
            this.objCodeElement_Imports = new CodeElement { Name = "imports", ElementType = CodeElementType.Import, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Imports);
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            string strFuncName = "";
            string strTemp = ""; ///临时变量;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
         

            objViewInfoENEx.WebFormName = ThisClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModule, objViewInfoENEx, objViewInfoENEx.TabName);

            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            this.objCodeElement_Class = new CodeElement { Name = ThisClsName, ElementType = CodeElementType.Class, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Class);
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));
                
                //strCodeForCs.AppendFormat("\r\n" + "import $ from \"jquery\";");
                strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");

                strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"@/viewsBase/{1}/{0}\";",
                        this.BaseClsName, objFuncModule.FuncModuleEnName4GC());
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"{this.BaseClsName}",
                    ElementType = CodeElementType.Import,
                    CodeContent = $"import {{ {this.BaseClsName} }} from \"@/viewsBase/{objFuncModule.FuncModuleEnName4GC()}/{this.BaseClsName}\";",
                    Modifiers = "import",
                    isPublic = true,
                    From = $"@/viewsBase/{objFuncModule.FuncModuleEnName4GC()}/{this.BaseClsName}",
                });


                var strRefEditObj = "";
                var strRefDetailObj = "";
                if (IsHasEditRegion == true) strRefEditObj = $", ref{ThisEditClsName}";
                if (IsHasDetailRegion == true) strRefDetailObj = $", ref{ThisDetailClsName}";

                strCodeForCs.Append("\r\n" + $"import {{ viewVarSet,divVarSet {strRefEditObj} {strRefDetailObj} }} from \"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"viewVarSet,divVarSet {strRefEditObj} {strRefDetailObj}",
                    ElementType = CodeElementType.Import,
                    CodeContent = $"import {{ viewVarSet,divVarSet {strRefEditObj} {strRefDetailObj} }} from \"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}\";",
                    Modifiers = "import",
                    isPublic = true,
                    From = $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}",
                });

                strCodeForCs.Append("\r\n" + " import { Format } from '@/ts/PubFun/clsString';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "Format",
                    ElementType = CodeElementType.Import,
                    CodeContent = "import { Format } from '@/ts/PubFun/clsString';",
                    Modifiers = "import",
                    isPublic = true,
                    From = "@/ts/PubFun/clsString"
                });


                var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;
                if (IsHasEditRegion == true)
                {
                    strCodeForCs.Append("\r\n" + $"import {ThisEditClsName}Ex from \"@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{ThisEditClsName}Ex\";");
                }
                if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
                {
                    strCodeForCs.Append("\r\n" + "import { GetCheckedKeyLstsInDivObj, GetFirstCheckedKeyLstInDivObj }   from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";");
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                    {
                        Name = "GetCheckedKeyLstsInDivObj, GetFirstCheckedKeyLstInDivObj",
                        ElementType = CodeElementType.Import,
                        CodeContent = "import { GetCheckedKeyLstsInDivObj, GetFirstCheckedKeyLstInDivObj } from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";",
                        Modifiers = "import",
                        isPublic = true,
                        From = "@/ts/PubFun/clsCommFunc4Ctrl.js"
                    });

                    //strCodeForCs.AppendFormat("\r\n" + "import {{ {0}_SplitKeyLst }} from \"@/ts/L3ForWApi/{1}/cls{0}WApi\";",
                    //    TabName_In4Edit,
                    //    thisEditTabProp_TS.FuncModuleEnName4GC);

                }
                else
                {
                    if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                    {
                        strCodeForCs.Append("\r\n" + "import { GetCheckedKeyIdsInDivObj, GetFirstCheckedKeyIdInDivObj }   from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";");
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                        {
                            Name = "GetCheckedKeyIdsInDivObj, GetFirstCheckedKeyIdInDivObj",
                            ElementType = CodeElementType.Import,
                            CodeContent = "import { GetCheckedKeyIdsInDivObj, GetFirstCheckedKeyIdInDivObj } from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";",
                            Modifiers = "import",
                            isPublic = true,
                            From = "@/ts/PubFun/clsCommFunc4Ctrl.js"
                        });
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "import { GetCheckedKeyIdsInDivObj }   from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";");
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                        {
                            Name = "GetCheckedKeyIdsInDivObj",
                            ElementType = CodeElementType.Import,
                            CodeContent = "import { GetCheckedKeyIdsInDivObj } from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";",
                            Modifiers = "import",
                            isPublic = true,
                            From = "@/ts/PubFun/clsCommFunc4Ctrl.js"
                        });
                    }
                }

                strCodeForCs.Append("\r\n" + "import { AccessBindGvDefault } from '@/ts/PubFun/clsErrMsgBLEx';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "AccessBindGvDefault",
                    ElementType = CodeElementType.Import,
                    CodeContent = "import { AccessBindGvDefault } from '@/ts/PubFun/clsErrMsgBLEx';",
                    Modifiers = "import",
                    isPublic = true,
                    From = "@/ts/PubFun/clsErrMsgBLEx"
                });

                //strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\";");
                strCodeForCs.Append("\r\n" + "import { IShowList } from \"@/ts/PubFun/IShowList\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "IShowList",
                    ElementType = CodeElementType.Import,
                    CodeContent = "import { IShowList } from \"@/ts/PubFun/IShowList\";",
                    Modifiers = "import",
                    isPublic = true,
                    From = "@/ts/PubFun/IShowList"
                });
                strCodeForCs.AppendFormat("\r\n /** {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export default class  {0} extends {1} implements IShowList", ThisClsName, this.BaseClsName);
                strCodeForCs.Append("\r\n" + "{");
                               
                StringBuilder sbFuncComment = new StringBuilder();
                sbFuncComment.AppendFormat("\r\n /**");
                sbFuncComment.AppendFormat("\r\n * 每页记录数,在扩展类可以修改");
                sbFuncComment.Append("\r\n" + " **/");
                strCodeForCs.Append(sbFuncComment);
                StringBuilder sbFuncCode = new StringBuilder();
                sbFuncCode.Append("\r\n" + "public get pageSize():number {");
                sbFuncCode.Append("\r\n" + "return 10;");
                sbFuncCode.Append("\r\n" + "}");
                strCodeForCs.Append(sbFuncCode);
                this.objCodeElement_Class.Children.Add(new CodeElement
                {
                    Name = "pageSize",
                    ElementType = CodeElementType.Property,
                    Modifiers = "public get",
                    ReturnType = "number",
                    DocumentationComment = sbFuncComment.ToString(),
                    CodeContent = sbFuncCode.ToString()

                });


                strCodeForCs.Append("\r\n" + "");
                sbFuncComment = new StringBuilder();
                sbFuncComment.Append("\r\n" + "/**");
                sbFuncComment.Append("\r\n" + "* 函数功能:初始设置，用来初始化一些变量值");
                sbFuncComment.Append("\r\n" + "**/");
                strCodeForCs.Append(sbFuncComment);
                sbFuncCode = new StringBuilder();
                sbFuncCode.Append("\r\n" + "public async InitVarSet(): Promise<void> {");
                sbFuncCode.Append("\r\n" + $"console.log('InitVarSet in {ThisClsName}');");
                sbFuncCode.Append("\r\n" + "}");
                strCodeForCs.Append(sbFuncCode);
                clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
                {
                    Name = "InitVarSet",
                    ElementType = CodeElementType.Method,
                    Modifiers = "public get",
                    ReturnType = "number",
                    DocumentationComment = sbFuncComment.ToString(),
                    CodeContent = sbFuncCode.ToString()

                });

                sbFuncComment = new StringBuilder();
                sbFuncComment.Append("\r\n" + "/** ");
                sbFuncComment.Append("\r\n" + "* 函数功能:初始化界面控件值，放在绑定下拉框之后");
                sbFuncComment.Append("\r\n" + "**/");
                strCodeForCs.Append(sbFuncComment);
                sbFuncCode = new StringBuilder();
                sbFuncCode.Append("\r\n" + "  public async InitCtlVar() : Promise<void> {");
                sbFuncCode.Append("\r\n" + $"console.log('InitCtlVar in {ThisClsName}');");
                sbFuncCode.Append("\r\n" + "}");
                strCodeForCs.Append(sbFuncCode);

                clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
                {
                    Name = "InitCtlVar",
                    ElementType = CodeElementType.Method,
                    Modifiers = "public get",
                    ReturnType = "number",
                    DocumentationComment = sbFuncComment.ToString(),
                    CodeContent = sbFuncCode.ToString()
                });

                string strFuncName_Temp = getBindGvFuncName();
                sbFuncCode = new StringBuilder();
                sbFuncCode.Append("\r\n" + "BindGv(strType: string, strPara: string) {");
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    sbFuncCode.AppendFormat("\r\n" + "alert(`该类没有绑定该函数：[this.BindGv_{0}]!${{strType}}${{strPara}}`);", objViewInfoENEx.TabName_Out);
                    sbFuncCode.Append("\r\n" + $"//{strFuncName_Temp}(divVarSet.refDivList);");
                }
                else
                {
                    sbFuncCode.AppendFormat("\r\n" + "console.log(strType + strPara);", objViewInfoENEx.TabName_Out);
                    sbFuncCode.Append("\r\n" + $"{strFuncName_Temp}(divVarSet.refDivList);");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append(sbFuncCode);

                clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
                {
                    Name = "BindGv",
                    ElementType = CodeElementType.Method,
                    Modifiers = "public get",
                    ReturnType = "void",
                    DocumentationComment = sbFuncComment.ToString(),
                    CodeContent = sbFuncCode.ToString()
                });

                sbFuncCode = new StringBuilder();
                sbFuncCode.Append("\r\n" + "BindGvCache(strType: string, strPara: string) {");
                sbFuncCode.Append("\r\n" + "console.log(\"strPara\", strPara);");

                sbFuncCode.Append("\r\n" + "switch(strType)");
                sbFuncCode.Append("\r\n" + "{");
                sbFuncCode.AppendFormat("\r\n" + "case \"{0}\":", objViewInfoENEx.TabName_Out);
           
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    sbFuncCode.Append("\r\n" + $"{strFuncName_Temp}(divVarSet.refDivList);");
                }
                else
                {
                    sbFuncCode.Append("\r\n" + $"alert('该类没有绑定该函数：[{strFuncName_Temp}]!');");
                    sbFuncCode.Append("\r\n" + $"//{strFuncName_Temp}(divVarSet.refDivList);");
                }
                sbFuncCode.Append("\r\n" + "break;");
                sbFuncCode.Append("\r\n" + "default:");
                sbFuncCode.Append("\r\n" + "AccessBindGvDefault(strType);");
                sbFuncCode.Append("\r\n" + "break;");

                sbFuncCode.Append("\r\n" + "}");
                sbFuncCode.Append("\r\n" + "}");
                strCodeForCs.Append(sbFuncCode);

                clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
                {
                    Name = "BindGvCache",
                    ElementType = CodeElementType.Method,
                    Modifiers = "public get",
                    ReturnType = "void",
                    DocumentationComment = sbFuncComment.ToString(),
                    CodeContent = sbFuncCode.ToString()
                });

                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
           clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

              
                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                strCodeForCs.Append( Gen_Vue_Ts_SortColumn());
                
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


        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>

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
                    strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                      strTitle);
                    strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    //如果有查询区域
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                        strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScriptCSEx_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(Vue_ViewScriptCSEx_TS4TypeScript);
            //    MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

            //    if (mt == null)
            //    {
            //        string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //    }
            //    else
            //    {
            //        //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
            //        if (mt.GetParameters().Length == 0)
            //        {
            //            strCode = (string)mt.Invoke(this, null);
            //        }
            //        else if (mt.GetParameters().Length == 1)
            //        {
            //            strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
            //        }
            //        //Console.WriteLine(str);
            //    }

            //    return strCode;
            //}
            //catch (Exception objException)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strMsg = "";
            //    if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
            //    {
            //        strMsg = objException.InnerException.Message;
            //    }
            //    else
            //    {
            //        strMsg = objException.Message;
            //    }
            //    sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
            //    throw new Exception(sbMessage.ToString());
            //}
        }
        public override void GetClsName()
        {

            //if (PrjTabEx_ListRegion.IsUseCache_TS())
            //{
            //    this.ClsName = string.Format("WApi{0}_QUDICacheEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WApi{0}_QUDICache", objViewInfoENEx.TabName);

            //    ThisClsName = this.ClsName;

            //}
            //else
            //{
            //    this.ClsName = string.Format("WApi{0}_QUDI_JSEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WApi{0}_QUDI_JS", objViewInfoENEx.TabName);
            //    ThisClsName = this.ClsName;
            //}
            this.ClsName = string.Format("{0}Ex", objViewInfoENEx.ViewName);
            this.BaseClsName = string.Format("{0}", objViewInfoENEx.ViewName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
     
        public string Gen_Vue_Ts_GeneEventFuncEx()
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

                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "public async {0}()",
                       x.ChangeEvent);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中重写该函数!');", ThisClsName);
                    strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "public  async {0}(){{;",
                       x.ClickEvent, ThisClsName);
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
        public string Gen_Vue_TS_btn_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            
            string strFuncName = $"btn_Click";
            
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            List<string> arrButtonName = arrFeatureRegionFldsObjLst.Select(x => x.ButtonName)
                .Select(x => x.Substring(3))
                .ToList();
            var arr = new List<string> { enumPrjFeature.DefaultFeature_0240, enumPrjFeature.SetFieldValue_0148 };
            List<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst_DefaultFeature = objViewInfoENEx.arrFeatureRegionFlds.Where(x => arr.Contains(x.FeatureId)).ToList();

            var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 按钮单击,用于调用Js函数中btnClick");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.AppendFormat("\r\n" + "public static btn_Click(strCommandName: string, strKeyId: string) {{");
            strFuncName = "btn_Click";
            //strCodeForCs.AppendFormat("\r\n" + "const objPage:{0} = new {0}();", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "let objPage: {0};", ThisClsName);
            
            strCodeForCs.Append("\r\n" + "let objPageEdit;");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.objPageCRUD == null)", this.BaseClsName);
            
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.objPageCRUD = new {1}();", this.BaseClsName, ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "objPage = <{0}> {0}.objPageCRUD;", ThisClsName, this.BaseClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objPage = <{0}> {0}.objPageCRUD;", ThisClsName, this.BaseClsName);
            strCodeForCs.Append("\r\n" + "}");

           
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01)   strCodeForCs.Append("\r\n" + "let strMsg = '';");

            //strCodeForCs.Append("\r\n" + "const strKeyId = clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
            string strKeyLstName = "arrKeyIds";
            if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
            {
                strKeyLstName = "arrKeyLsts";
                strCodeForCs.Append("\r\n" + $"const arrKeyLsts = GetCheckedKeyLstsInDivObj(divVarSet.refDivList);");
                //strCodeForCs.Append("\r\n" + "let objKeyLst;");
                strCodeForCs.Append("\r\n" + "let strKeyLst = \"\"; ");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                //if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01) 
                //    strCodeForCs.Append("\r\n" + $"strKeyId = GetFirstCheckedKeyIdInDivObj(divVarSet.refDivList);");
                //else strCodeForCs.Append("\r\n" + "console.log(strKeyId);");
            }
            strCodeForCs.Append("\r\n" + "switch (strCommandName)");
            strCodeForCs.Append("\r\n" + "{");

            arrFeatureRegionFldsObjLst_DefaultFeature.ForEach(x =>
            {
                string strCommandName = x.CommandName;
                strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":    //自定义功能:{1}", strCommandName, x.Text);
                if (string.IsNullOrEmpty(x.FuncName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objPage.{0}();", x.FuncName.Replace("()", ""));
                }
                strCodeForCs.Append("\r\n" + "break;");
            });

            strCodeForCs.Append("\r\n" + "case \"Query\":    //查询记录");
            strCodeForCs.Append("\r\n" + "objPage.btnQuery_Click();");
            strCodeForCs.Append("\r\n" + "break;");

            if (IsHasEditRegion == true)
            {
                strCodeForCs.Append("\r\n" + "case \"AddNewRecordWithMaxId\":    //添加记录使用最大关键字");
                strCodeForCs.Append("\r\n" + "case \"CreateWithMaxId\":    //添加记录使用最大关键字");
                strCodeForCs.Append("\r\n" + "case \"AddNewRecord\":            //添加记录");
                strCodeForCs.Append("\r\n" + "case \"Create\":            //添加记录");

                    strCodeForCs.Append("\r\n" + $"objPageEdit = new {ThisEditClsName}Ex('{ThisEditClsName}Ex', objPage);//初始化编辑类,设置当前类为编辑类的父类，编辑返回的类" );
                    strCodeForCs.AppendFormat("\r\n" + "console.log(objPageEdit);", ThisEditClsName);

                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyId);");
                strCodeForCs.Append("\r\n" + "break;");
                if (IsHasDetailRegion)
                {
                    strCodeForCs.Append("\r\n" + "case \"Detail\":            //详细信息");
                    strCodeForCs.Append("\r\n" + $"ref{ThisDetailClsName}.value.btn{TabName_Out4DetailRegion}_Detail_Click(strCommandName, strKeyId);");                 
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "case \"UpdateRecord\":            //修改记录");
                strCodeForCs.Append("\r\n" + "case \"Update\":            //修改记录");
                strCodeForCs.Append("\r\n" + $"objPageEdit = new {ThisEditClsName}Ex('{ThisEditClsName}Ex',objPage);//初始化编辑类,设置当前类为编辑类的父类，编辑返回的类");
                strCodeForCs.AppendFormat("\r\n" + "console.log(objPageEdit);", ThisEditClsName);
                string strGetFirstCheckedStr = clsPubFun4GC.Gen_GetFirstCheckedValue(this.objCodeElement_Imports, thisEditTabProp_TS, "修改", this, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + strGetFirstCheckedStr);
                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyLst);");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyId);");
                }
                strCodeForCs.Append("\r\n" + "break;");
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord_Gv())
                {
                    strCodeForCs.Append("\r\n" + "case \"UpdateRecordInTab\":            //修改记录InTab");
                    if (thisEditTabProp_TS.KeyFldCount > 1)
                    {
                        strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyLst);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyId);");
                    }
                    strCodeForCs.Append("\r\n" + "break;");
                }
            }
            if (objViewInfoENEx.objViewRegion_Feature.IsHaveCopyRecord())
            {
                strCodeForCs.Append("\r\n" + "case \"CopyRecord\":            //复制记录");
                strCodeForCs.Append("\r\n" + "case \"Clone\":            //复制记录");


                strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要复制的[${objPage.thisTabName}]记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnCopyRecord_Click();", arrButtonName.Contains("CopyRecord") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");
            }
            if (objViewInfoENEx.objViewRegion_Feature.IsHaveExportToFile())
            {
                strCodeForCs.Append("\r\n" + "case \"ExportExcel\":            //导出Excel");
                var objViewRegion_ExportExcel = objViewInfoENEx.objViewRegion_ExportExcel;
                var bolIsHasExcelExport = objViewRegion_ExportExcel != null && arrButtonName.Contains("ExportExcel");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnExportExcel_Click();", bolIsHasExcelExport ? "" : "//");

                strCodeForCs.Append("\r\n" + "//alert(\"导出Excel功能还没有开通!\");");
                //strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "break;");
            }
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.Append("\r\n" + "case \"DelRecord\":            //删除记录");
                strCodeForCs.Append("\r\n" + "case \"Delete\":            //删除记录");

                strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的[${objPage.thisTabName}]记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "objPage.btnDelRecord_Click();");
                strCodeForCs.Append("\r\n" + "break;");
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveDetailRecord_Gv())
                {
                    strCodeForCs.Append("\r\n" + "case \"DelRecordInTab\":   //删除记录InTab ");
                    if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "objKeyLst = {0}_SplitKeyLst(strKeyId);", TabName_In4Edit);
                        strCodeForCs.Append("\r\n" + "objPage.btnDelRecordInTab_Click(");
                        int intIndex = 0;
                        foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                        {
                            if (intIndex == 0)
                            {
                                strCodeForCs.AppendFormat("objKeyLst.{0}", objInFor.PropertyName(this.IsFstLcase));
                            }
                            else
                            {
                                strCodeForCs.AppendFormat(", objKeyLst.{0}", objInFor.PropertyName(this.IsFstLcase));
                            }
                            intIndex++;
                        }
                        strCodeForCs.Append(");");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "objPage.btnDelRecordInTab_Click(strKeyId);");
                    }
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveDelRecordBySign())
                {
                    strCodeForCs.Append("\r\n" + "case \"DelRecordBySign\":            //按标志删除记录");
                    strCodeForCs.Append("\r\n" + "case \"DeleteBySign\":            //按标志删除记录");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要按标志删除的[${objPage.thisTabName}]记录!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnDelRecordBySign_Click();", arrButtonName.Contains("DelRecordBySign") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"UnDelRecordBySign\":            //按标志恢复删除记录");
                    strCodeForCs.Append("\r\n" + "case \"UnDeleteBySign\":            //按标志恢复删除记录");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要恢复删除的[${objPage.thisTabName}]记录!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnUnDelRecordBySign_Click();",
                        arrButtonName.Contains("UnDelRecordBySign") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveAdjustOrderNum())
                {
                    strCodeForCs.Append("\r\n" + "case \"GoTop\":            //置顶记录");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要置顶的[${objPage.thisTabName}]记录!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnGoTop_Click();",
                        arrButtonName.Contains("GoTop") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"GoBottum\":            //移底记录");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要移底的[${objPage.thisTabName}]记录!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnGoBottum_Click();",
                        arrButtonName.Contains("GoBottum") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"UpMove\":            //上移记录");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要上移的[${objPage.thisTabName}]记录!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnUpMove_Click();",
                        arrButtonName.Contains("UpMove") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"DownMove\":            //下移记录");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要下移的[${objPage.thisTabName}]记录!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnDownMove_Click();",
                        arrButtonName.Contains("DownMove") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"ReOrder\":            //重序记录");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnReOrder_Click();",
                        arrButtonName.Contains("ReOrder") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "strMsg = `命令:${{strCommandName}}在函数({0}.btnClick)中没有被处理!`;", this.ClsName);
                strCodeForCs.Append("\r\n" + "console.error(strMsg)");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "break;");
            }

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            arrFeatureRegionFldsObjLst_DefaultFeature.ForEach(x =>
            {
                if (x.FeatureId == enumPrjFeature.DefaultFeature_0240)
                {
                    if (string.IsNullOrEmpty(x.FuncName) == false)
                    {
                        strCodeForCs.Append("\r\n /**");
                        strCodeForCs.AppendFormat("\r\n * 自定义功能:{0}", x.Text);
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n **/");
                        strCodeForCs.AppendFormat("\r\n" + "public {0}()", x.FuncName.Replace("()",""));
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "//自定义功能;");
                        strCodeForCs.Append("\r\n" + "};");
                    }
                }
            });
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }            
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_btn_ClickBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return new WA_ViewScriptCSEx_TS4TypeScript().Gen_WApi_TS_btn_Click(objvFunction4GeneCodeEN);
       
        }
public string getBindGvFuncName()
        {
            string strSuffix = "";
            string strFuncName_Temp = $"this.BindGv_{TabName_Out4ListRegion}";
            if (objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true) strSuffix = "Cache";
            if (this.IsUseFunc == true) strSuffix = "4Func";
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                strFuncName_Temp = $"this.BindGv_{TabName_Out4ListRegion}{strSuffix}";
            }
            else
            {
                strFuncName_Temp = $"this.BindGv_{TabName_Out4ListRegion}{strSuffix}";
            }
            return strFuncName_Temp;
        }
    }
}
