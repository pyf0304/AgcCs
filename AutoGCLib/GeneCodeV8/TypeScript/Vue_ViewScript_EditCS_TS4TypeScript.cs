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
    partial class Vue_ViewScript_EditCS_TS4TypeScript : WA_ViewScript_EditCS_TS4TypeScript
    {
        #region 构造函数
        public Vue_ViewScript_EditCS_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_EditCS_TS4TypeScript(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_EditCS_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();

            this.arrImportClass = new List<ImportClass>();
        }
        ///// <summary>
        ///// 初始化页面设置
        ///// </summary>
        //public void InitPageSetup()
        //{
        //    intZIndex = 100;        ///控件焦点序号
        //    intCurrLeft = 10;  ///控件的左边空;
        //    intCurrTop = 10;
        //}

        #endregion

        public string Gen_Vue_Ts_Page_Load()
        {
            return Gen_WApi_Ts_Page_Load();

        }

        public string Gen_Vue_Ts_SetEventFunc()
        {
            return Gen_WApi_Ts_SetEventFunc();
        }

        public string Gen_Vue_Ts_GeneEventFunc()
        {
            return Gen_WApi_Ts_GeneEventFunc();

        }

        public string Gen_Vue_Ts_DdlBind()
        {
            return Gen_WApi_Ts_DdlBind();
        }

        public string Gen_Vue_Ts_BindDdl4EditRegion()
        {
            return Gen_WApi_Ts_BindDdl4EditRegion();
        }

        public string Gen_Vue_Ts_BindDdl4EditRegionInDiv()
        {
            return Gen_WApi_Ts_BindDdl4EditRegionInDiv();
        }

        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_Edit == null || objViewInfoENEx.objViewRegion_Edit.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
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
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Imports);

            this.objCodeElement_Class = new CodeElement { Name = ThisClsName, ElementType = CodeElementType.Class, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Class);

            //string strResult = "";

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
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            var objPrjTab_EditRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);


            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, TabName_In4Edit4GC);

            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //准备数据
                //获取界面所需要的公共变量

                this.GetViewPubVarLst(this.TabId_In4Edit);


                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                   clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);

                    objvFunction4GeneCodeEN.CodeText = strTemp;

                }


                strCodeForCs.AppendFormat("\r\n" + "import $ from \"jquery\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "jquery",
                    ElementType = CodeElementType.Import,
                    CodeContent = "import $ from \"jquery\";",
                    Modifiers = "import",
                    isPublic = true,
                    From = "jquery",
                });

                //strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");

                GetImportClassLst(objFuncModuleEN);
                strFuncName = "clsPubFun4GC.Gen_Vue_Ts_ControlProperty";
                StringBuilder sbPropertyDef = new StringBuilder();

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(sbPropertyDef, arrPropertyDef4GC, $"this.divEdit", this, this.strBaseUrl);


                arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                foreach (var objInFor in arrImportClass)
                {
                    objInFor.ClsName = objInFor.ClsName;
                    objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                              .Replace("../../TS/", "@/ts/")
                              .Replace("../../L0Entity/", "@/ts/L0Entity/")
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
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath.Replace(".js", "")
                        .Replace("../../TS/", "@/ts/")
                        .Replace("../TS/", "@/ts/"));
                }


                strCodeForCs.AppendFormat("\r\n /** {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class  {0} ", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "protected _className = \"Unknown\"; // 基类中的实际字段");
                strCodeForCs.Append("\r\n" + "// 定义虚拟属性");
                strCodeForCs.Append("\r\n" + "get className(): string {");
                strCodeForCs.Append("\r\n" + "return this._className;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "public static E1ditObj: any;");
                //strCodeForCs.Append("\r\n" + "public divEdit: HTMLDivElement;");
                strCodeForCs.Append("\r\n" + "public static times4TestShowDialog = 0;");

                var objPageDispMode = clsPageDispModeBL.GetObjByPageDispModeIdCache(objViewInfoENEx.objViewRegion_Edit.PageDispModeId);
                if (objPageDispMode == null)
                {
                    string strMsg = string.Format("生成界面:[{0}]编辑区,页面显示模式为空,请重新设置!(In {1})",
                        objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                strCodeForCs.Append("\r\n" + "public opType = \"\";");
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + "public keyId = 0;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "public keyId = \"\";");
                }

                strCodeForCs.Append("\r\n" + "public isShowMsg = true; //编辑记录时是否显示提示信息");
                strCodeForCs.Append("\r\n" + "public tag = \"\"; //编辑对象的标志，用于存放或者标志一些信息");

                strCodeForCs.AppendFormat("\r\n" + "public static strPageDispModeId = \"{0}\";//{1}({2})",
                    objPageDispMode.PageDispModeId, objPageDispMode.PageDispModeENName, objPageDispMode.PageDispModeName);

                strCodeForCs.AppendFormat("\r\n" + "public static objPageEdit: {0};", ThisClsName);
                strCodeForCs.AppendFormat("\r\n" + "public static objPageEdit2: {0};", ThisClsName);
                strCodeForCs.AppendFormat("\r\n" + "public static objPageEdit3: {0};", ThisClsName);

                //strCodeForCs.Append("\r\n" + GeneViewPubVar_TS(strFuncName));

                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");
                //strCodeForCs.AppendFormat("\r\n" + "public obj{0}: cls{0}EN;", TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "public iShowList: IShowList | null;");

                strCodeForCs.Append("\r\n" + "public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量");

                strCodeForCs.Append("\r\n" + "public divName4Edit = \"divEditLayout\";  //编辑区的Id");


                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 获取当前组件的divEdit的层对象");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivEdit(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivEdit;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 获取当前组件的divEdit的层对象");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivLayout(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivEdit;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "constructor(strClassName: string, objShowList: IShowList | null) {");
                strCodeForCs.Append("\r\n" + "this._className = strClassName;");
                strCodeForCs.Append("\r\n" + "this.iShowList = objShowList;");
                //strCodeForCs.Append("\r\n" + "const divTemp = document.createElement('div');");
                //strCodeForCs.Append("\r\n" + "divTemp.id = 'temp';");
                //strCodeForCs.Append("\r\n" + "this.divEdit = divTemp;");
                //strCodeForCs.AppendFormat("\r\n" + "{0}.objPageEdit = this;", ThisClsName);
                //strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = new cls{0}EN();", TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.SetPageEdit(this, 1) == true) return;");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.SetPageEdit(this, 2) == true) return;");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.SetPageEdit(this, 3) == true) return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"public static SetPageEdit(objDataLst: any, intIndex: number): boolean {{");
                strCodeForCs.Append("\r\n" + $"const strNewClassName = objDataLst.className;");
                strCodeForCs.Append("\r\n" + $"switch (intIndex)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"case 1:");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strNewClassName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"break;");
                strCodeForCs.Append("\r\n" + $"case 2:");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit2 == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit2 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit2.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strNewClassName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit2 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"break;");
                strCodeForCs.Append("\r\n" + $"case 3:");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit3 == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit3 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit3.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strNewClassName)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.objPageEdit3 = objDataLst;");
                strCodeForCs.Append("\r\n" + $"return true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"else return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"break;");
                strCodeForCs.Append("\r\n" + $"default:");
                strCodeForCs.Append("\r\n" + $"return false;");
                strCodeForCs.Append("\r\n" + $"// break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"public static GetPageEditObj(strClassName: string): any {{");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strClassName) return {ThisClsName}.objPageEdit;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit2 != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit2.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strClassName) return {ThisClsName}.objPageEdit2;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.objPageEdit3 != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const strClassNameOld = {ThisClsName}.objPageEdit3.className;");
                strCodeForCs.Append("\r\n" + $"if (strClassNameOld == strClassName) return {ThisClsName}.objPageEdit3;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"return null;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "");
                //生成所有的函数


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        //objvFunction4GeneCodeEN.CodeText = strTemp;
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }
                strFuncName = "clsPubFun4GC.Gen_Vue_Ts_ControlProperty";
                strCodeForCs.Append("\r\n" + sbPropertyDef.ToString());
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

        public void Gen_Vue_Ts_ControlProperty4One_NotInDiv(StringBuilder strCodeForCs, clsPropertyDef4GC x)
        {
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            string strIsStatic = "";
            if (x.IsStatic) strIsStatic = "static";
            switch (x.OperateType)
            {
                case "get":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "const str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            }
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":

                            if (x.DataType == "boolean")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                            }
                            else if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return Number(strValue);");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return 0;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return \"\";");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                    }
                    break;
                case "set":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value.toString());", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "Label":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                    }
                    break;

            }
            strCodeForCs.Append("\r\n" + "}");

        }

        public void Gen_Vue_Ts_ControlPropertyBak(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.ParentDivName) == true)
                {
                    Gen_Vue_Ts_ControlProperty4One_NotInDiv(strCodeForCs, x);
                    return;
                }
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.Append("\r\n" + $"const objDiv = $(`#$this.divEdit`);");

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + "return objDiv.find(strId).prop(\"checked\");");

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " var str{1} = objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "const str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                }
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "boolean")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return false;", x.CtrlId);
                                    //                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                }
                                else if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return 0;", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " const strValue = objDiv.find(strId).val();", x.CtrlId, x.PropertyName);
                                    strCodeForCs.Append("\r\n" + " return Number(strValue);");

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return \"\";", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                                }

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return Number(strValue);");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return strValue;");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return 0;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return \"\";");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                        }
                        break;
                    case "set":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.Append("\r\n" + $"const objDiv = $(`#$this.divEdit`);");


                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).attr(\"checked\", value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "Label":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                        }
                        break;

                }
                strCodeForCs.Append("\r\n" + "}");
            });
        }


        public string Gen_Vue_Ts_SetKeyReadOnly()
        {
            return Gen_WApi_Ts_SetKeyReadOnly();
        }

        public string Gen_Vue_Ts_Clear()
        {
            return "";
        }

        public string Gen_Vue_Ts_AddNewRecord()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //生成的插入记录准备过程代码for C#

                strCodeForCs.Append("\r\n /** 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async AddNewRecord()",
                TabName_In4Edit4GC);
                strFuncName = $"AddNewRecord";
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecord.name;",
TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                List<string> arrKey = new List<string>() { enumPrimaryType.Identity_02,
                enumPrimaryType.StringAutoAddPrimaryKey_03,
                enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06,
                enumPrimaryType.PrimaryKey_01 };

                if (arrKey.Contains(objKeyField.PrimaryTypeId) == false)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                    TabName_In4Edit4GC);
                    }
                }


                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    RefVarName = "strSubmitButtonText",
                    PropertyName = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    Comment = "设置确定按钮的标题(Used In AddNewRecord())",
                    DataType = "string",
                    ParentDivName = $"this.divEdit",
                    ThisClsName = ThisEditClsName,
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    RefVarName = "strCancelButtonText",
                    PropertyName = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    Comment = "设置取消按钮的标题(Used In AddNewRecord())",
                    DataType = "string",
                    ParentDivName = $"this.divEdit",
                    ThisClsName = ThisEditClsName,
                });

                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.Clear();");

                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = {0}GetMaxStrId_S();",
                TabName_In4Edit4GC, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);

                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdAsync)}();");

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                        TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + $"this.keyId = returnString;");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
                {

                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                                TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());

                    }

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                                TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + $"await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}(\"\");");
                    }
                    else
                    {
                        var strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(objViewInfoENEx.ViewId, objPrefixField.FldId, objViewInfoENEx.PrjId);
                        if (string.IsNullOrEmpty(strViewVarName) == true)
                        {
                            var strFldName = objPrefixField.FldName;
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName, objViewInfoENEx.ViewName);
                        }
                        ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}({strViewVarName}.value);");
                    }

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                        TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"this.keyId = returnString;");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                }
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

        public Tuple<string, bool> Gen_Vue_Ts_AddNewRecordWithMaxId_Body()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder sbTemp = new StringBuilder();
            bool bolIsUseFuncName = false;
            //获取最大值
            sbTemp.AppendFormat("\r\n" + "//this.{1} = await {0}_GetMaxStrIdAsync();",
            TabName_In4Edit4GC, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);

            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {

                sbTemp.Append("\r\n" + "try");
                sbTemp.Append("\r\n" + "{");
                sbTemp.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdAsync)}();");

                sbTemp.Append("\r\n" + "if (returnString == \"\")");
                sbTemp.Append("\r\n" + "{");
                sbTemp.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                    TabName_In4Edit4GC);

                sbTemp.Append("\r\n" + "//显示信息框");
                sbTemp.Append("\r\n" + "alert(strInfo);");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "else");
                sbTemp.Append("\r\n" + "{");

                sbTemp.Append("\r\n" + $"this.keyId = returnString;");

                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "catch(e)");
                sbTemp.Append("\r\n" + "{");
                sbTemp.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                bolIsUseFuncName = true;
                sbTemp.Append("\r\n" + "console.error(strMsg);");
                sbTemp.Append("\r\n" + "alert(strMsg);");
                sbTemp.Append("\r\n" + "}");

            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
            {

                if (objPrefixField == null)
                {
                    sbTemp.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                            TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());

                }

                sbTemp.Append("\r\n" + "try");
                sbTemp.Append("\r\n" + "{");
                if (objPrefixField == null)
                {
                    sbTemp.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                            TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());
                    sbTemp.Append("\r\n" + $"await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}(\"\");");
                }
                else
                {
                    var strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(objViewInfoENEx.ViewId, objPrefixField.FldId, objViewInfoENEx.PrjId);
                    if (string.IsNullOrEmpty(strViewVarName) == true)
                    {
                        var strFldName = objPrefixField.FldName;
                        clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName, objViewInfoENEx.ViewName);
                    }
                    ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    sbTemp.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}({strViewVarName}.value);");
                }

                sbTemp.Append("\r\n" + "if (returnString == \"\")");
                sbTemp.Append("\r\n" + "{");
                sbTemp.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                    TabName_In4Edit4GC);

                sbTemp.Append("\r\n" + "//显示信息框");
                sbTemp.Append("\r\n" + "alert(strInfo);");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "else");
                sbTemp.Append("\r\n" + "{");

                sbTemp.Append("\r\n" + $"this.keyId = returnString;");


                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "}");
                sbTemp.Append("\r\n" + "catch(e)");
                sbTemp.Append("\r\n" + "{");
                sbTemp.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
                bolIsUseFuncName = true;
                sbTemp.Append("\r\n" + "console.error(strMsg);");
                sbTemp.Append("\r\n" + "alert(strMsg);");
                sbTemp.Append("\r\n" + "}");

            }
            Tuple<string, bool> returnValue = Tuple.Create<string, bool>(sbTemp.ToString(), bolIsUseFuncName);
            return returnValue;
        }
        //生成插入记录准备过程代码
        public string Gen_Vue_Ts_AddNewRecordWithMaxId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            Tuple<string, bool> returnValue = Gen_Vue_Ts_AddNewRecordWithMaxId_Body();
            try
            {

                //生成的插入记录准备过程代码for C#

                strCodeForCs.Append("\r\n /** 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async AddNewRecordWithMaxId()",
                TabName_In4Edit4GC);
                strFuncName = $"AddNewRecordWithMaxId";
                strCodeForCs.Append("\r\n" + "{");
                if (returnValue.Item2 == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxId.name;", TabName_In4Edit4GC, objKeyField.FldName);
                }
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                        TabName_In4Edit4GC);
                    }
                }

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    RefVarName = "strSubmitButtonText",
                    PropertyName = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                    Comment = "设置确定按钮的标题(Used In AddNewRecordWithMaxId())",
                    DataType = "string",
                    ThisClsName = ThisEditClsName,
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    RefVarName = "strCancelButtonText",
                    PropertyName = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                    Comment = "设置取消按钮的标题(Used In AddNewRecordWithMaxId())",
                    DataType = "string",
                    ThisClsName = ThisEditClsName,
                });

                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.Clear();");
                strCodeForCs.Append("\r\n" + returnValue.Item1);
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


        public string Gen_Vue_Ts_btnOKUpd_Click()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n * 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async btnSubmit_Click()");
                strFuncName = $"btnSubmit_Click";

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnSubmit_Click.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strCommandText: string = this.btnSubmit{0};", this.TabName_In4Edit4GC);

                clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    RefVarName = "strSubmitButtonText",
                    PropertyName = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    Comment = "获取按钮的标题",
                    DataType = "string",
                    ParentDivName = "",
                    ThisClsName = ThisEditClsName,
                };
                arrPropertyDef4GC.Add(objPropertyDef4GC);

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
                sbCodeNext.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", this.TabName_In4Edit4GC);
                sbCodeNext.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", this.TabName_In4Edit4GC);

                sbCodeNext.AppendFormat("\r\n" + " await this.AddNewRecord();",
                this.TabName_In4Edit4GC);
                sbCodeNext.Append("\r\n" + "break;				");
                sbCodeNext.Append("\r\n" + "case \"确认添加\":");
                sbCodeNext.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                sbCodeNext.Append("\r\n" + "//就把逻辑层合并到控制层,");
                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    sbCodeNext.Append("\r\n" + "returnBool = await this.AddNewRecordSave();");
                    //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    ThisClsName);
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                    sbCodeNext.Append("\r\n" + "}");
                    //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    if (objKeyField.IsNumberType())
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId.toString()");
                    }
                    else
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId");
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
                        sbCodeNext.Append("\r\n" + "const returnKeyId = await this.AddNewRecordWithReturnKeySave();");
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
                        sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                        sbCodeNext.AppendFormat("\r\n" + "if (this.iShowList != null) this.iShowList.BindGvCache(cls{0}EN._CurrTabName, \"\");", this.TabName_In4Edit4GC);

                        sbCodeNext.Append("\r\n" + "}");
                        //sbCodeNext.Append("\r\n" + "//});");

                    }
                    else
                    {
                        sbCodeNext.Append("\r\n" + "returnKeyId = await this.AddNewRecordWithMaxIdSave();");
                        //sbCodeNext.Append("\r\n" + "const returnKeyId: string = <string>jsonData;");
                        sbCodeNext.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        sbCodeNext.Append("\r\n" + "{");
                        sbCodeNext.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
                        //sbCodeNext.Append("\r\n" + "{");
                        //sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();", ThisClsName);
                        //sbCodeNext.Append("\r\n" + "}");
                        sbCodeNext.Append("\r\n" + $"this.HideDialog_{TabName_In4Edit}();");
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
                    sbCodeNext.AppendFormat("\r\n" + "returnBool = await this.AddNewRecordSave();",
                          this.TabName_In4Edit4GC);
                    //sbCodeNext.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    sbCodeNext.Append("\r\n" + "if (returnBool == true)");
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    ThisClsName);
                    sbCodeNext.Append("\r\n" + "{");
                    sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                    sbCodeNext.Append("\r\n" + "}");
                    //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    if (objKeyField.IsNumberType())
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId.toString()");
                    }
                    else
                    {
                        iShowList_BindGv(sbCodeNext, "this.keyId");
                    }
                    sbCodeNext.Append("\r\n" + "}");
                    sbCodeNext.Append("\r\n" + "}");
                }
                sbCodeNext.Append("\r\n" + "break;");

                sbCodeNext.Append("\r\n" + "case \"确认修改\":");
                sbCodeNext.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                //sbCodeNext.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                //this.TabName_In4Edit4GC);
                sbCodeNext.AppendFormat("\r\n" + "returnBool = await this.UpdateRecordSave();",
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
                sbCodeNext.Append("\r\n" + $"ref{ThisEditClsName}.value.hideDialog();");
                sbCodeNext.Append("\r\n" + "}");
                //sbCodeNext.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");

                if (objKeyField.IsNumberType())
                {
                    iShowList_BindGv(sbCodeNext, "this.keyId.toString()");
                }
                else
                {
                    iShowList_BindGv(sbCodeNext, "this.keyId");
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
                sbCodeNext.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0033)在保存记录时({3})时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.className, strThisFuncName, strCommandText);");
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

        public string Gen_Vue_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ShowTabObj(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async UpdateRecord({0}):Promise<boolean> ",
                 thisEditTabProp_TS.KeyVarDefineLstStr);
            strFuncName = $"UpdateRecord";
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecord.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                RefVarName = "strSubmitButtonText",
                PropertyName = string.Format("btnSubmit{0}", TabName_In4Edit4GC),
                Comment = "设置确定按钮的标题(Used In UpdateRecord())",
                DataType = "string",
                ThisClsName = ThisEditClsName,
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                RefVarName = "strCancelButtonText",
                PropertyName = string.Format("btnCancel{0}", TabName_In4Edit4GC),
                Comment = "设置取消按钮的标题(Used In UpdateRecord())",
                DataType = "string",
                ThisClsName = ThisEditClsName,
            });

            if (objKeyField.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0};", objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0};", objKeyField.PrivFuncName);
            }


            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;


            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        //strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}EN = await {thisWA_F_InEdit(WA_F.GetObjByKeyId)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");
            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}EN == null)", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象为空.(in {0}.{1})\", this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");
            //strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = obj{0}EN;", TabName_In4Edit4GC);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
            //    TabName_In4Edit4GC,
            //    objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + $"await ref{ThisEditClsName}.value.ShowDataFrom{TabName_In4Edit4GC}Obj(obj{TabName_In4Edit4GC}EN);");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成UpdateRecord!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "return true;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"修改记录时，显示信息出错,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

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



        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_SetBindDdl()
        {
            return Gen_WApi_Ts_SetBindDdl();
        }


        public string Gen_Vue_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_SelectRecord(objvFunction4GeneCodeEN);
        }


        public string Gen_Vue_Ts_btnUpdateRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
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
            strCodeForCs.Append("\r\n" + $"public async btnUpdateRecord_Click({strFuncPara}) {{");
            strFuncName = $"btnUpdateRecord_Click";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecord_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

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
                    var strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(objViewInfoENEx.ViewId, objKeyField.FldId, objViewInfoENEx.PrjId);
                    if (string.IsNullOrEmpty(strViewVarName) == true)
                    {
                        var strFldName = objPrefixField.FldName;
                        clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName, objViewInfoENEx.ViewName);
                    }
                    ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


                    strCodeForCs.Append("\r\n" + $"const {objKeyField.PrivFuncName} = {strViewVarName}.value;");
                    if (objKeyField.IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + $"    if ({objKeyField.PrivFuncName} == 0)");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"    if ({objKeyField.PrivFuncName} == \"\")");
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录!\");");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            strCodeForCs.Append("\r\n" + "try {");

            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");

            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);

            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", ThisClsName);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + $"const lngKeyId =  {objKeyField.PrivFuncName};");

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     TabName_In4Edit4GC, TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const update = await this.UpdateRecord({objKeyField.PrivFuncName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord({0});",
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
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_Vue_Ts_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 在数据表里修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_Gv_0174 };
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
            if (thisEditTabProp_TS.KeyFldCount > 1) strFuncPara = thisEditTabProp_TS.KeyVarDefineLstStr;
            strCodeForCs.Append("\r\n" + $"public async btnUpdateRecordInTab_Click({strFuncPara}) {{");
            strFuncName = $"btnUpdateRecordInTab_Click";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecordInTab_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + $"    if ({objKeyField.PrivFuncName} == 0)");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"if (IsNullOrEmpty({objKeyField.PrivFuncName}) == true)");
                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

            }
            strCodeForCs.Append("\r\n" + "try {");

            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");

            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + $"const lngKeyId =  {objKeyField.PrivFuncName};");

                    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                     TabName_In4Edit4GC, TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"this.UpdateRecord({objKeyField.PrivFuncName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord({0});",
                    thisEditTabProp_TS.KeyPrivVarNameLstStr);
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

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
        /// 添加记录保存函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Vue_Ts_AddNewRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录,保存函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordSave(): Promise<boolean>{");
            strFuncName = $"AddNewRecordSave";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"
            //});

            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN;",
               this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"从界面获取数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {

                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "let returnBool = false;");

            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {
                strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.AddNewRecordAsync)}(obj{TabName_In4Edit4GC}EN);");
            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                //strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}EN.dnFuncMapId) == true)", this.TabName_In4Edit4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const returnKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.keyId = returnKeyId;");
                strCodeForCs.Append("\r\n" + "returnBool = true;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");

            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
            {
                //strCodeForCs.Append("\r\n" + "let returnBool = false;");
                //strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}EN.dnFuncMapId) == true)", this.TabName_In4Edit4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const returnKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "returnBool = true;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");

            }
            else
            {
                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    var arrTemp = thisEditTabProp_TS.PropertyNameLstrStr.Split(",".ToCharArray());
                    StringBuilder sbTemp = new StringBuilder();
                    foreach (string strInFor in arrTemp)
                    {
                        sbTemp.Append($"obj{TabName_In4Edit4GC}EN.{strInFor},");
                    }
                    strCodeForCs.Append("\r\n" + $"const bolIsExist = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({sbTemp.ToString()});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const bolIsExist = await {thisWA_F_InEdit(WA_F.IsExistAsync)}(obj{TabName_In4Edit4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)});");
                }
                strCodeForCs.Append("\r\n" + "if (bolIsExist == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"添加记录时,关键字：{{0}}已经存在!\", obj{0}EN.{1});",
                    this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.AddNewRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

            }

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "if (this.isShowMsg == true) alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录不成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


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


        public string Gen_Vue_Ts_CheckUniCondition4Add(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CheckUniCondition4Add(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_CheckUniCondition4Update(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CheckUniCondition4Update(objvFunction4GeneCodeEN);
        }

        /// <summary>
        /// 添加记录保存函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Vue_Ts_AddNewRecordWithMaxIdSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (thisEditTabProp_TS.KeyFldCount > 1) return "";

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录,由后台自动获取最大值的关键字。保存函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordWithMaxIdSave(): Promise<string>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"

            //});
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN;", this.TabName_In4Edit4GC);
            ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("cls{0}EN", this.TabName_In4Edit4GC), enumImportObjType.ENClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"从界面获取数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {

            }
            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add{strVersion}(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const responseKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.AppendFormat("\r\n" + "const returnKeyId: string = responseKeyId;",
                this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
            ImportClass objImportClass5 = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

            CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "if (this.isShowMsg == true) alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录不成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return responseKeyId;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return \"\";//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");


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


        public string Gen_Vue_Ts_AddNewRecordWithReturnKeySave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (thisEditTabProp_TS.KeyFldCount > 1) return "";

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录,由后台自动获取最大值的关键字。保存函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + "public async AddNewRecordWithReturnKeySave(): Promise<number>{");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async AddNewRecordWithReturnKeySave(): Promise<string>{");
            }
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithReturnKeySave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"

            //});
            strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN;", this.TabName_In4Edit4GC);
            ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("cls{0}EN", this.TabName_In4Edit4GC), enumImportObjType.ENClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"从界面获取数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {

            }
            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add{strVersion}(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + "return 0;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "return \"\";");
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const responseKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithReturnKeyAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.AppendFormat("\r\n" + "const returnKeyId: string = responseKeyId;",
                this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
            ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + $"obj{TabName_In4Edit4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)} = Number(returnKeyId);");

            }
            else
            {
                strCodeForCs.Append("\r\n" + $"obj{TabName_In4Edit4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)} = returnKeyId;");
            }
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "if (this.isShowMsg == true) alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录不成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + "return Number(responseKeyId);//一定要有一个返回值,否则会出错!");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "return responseKeyId;//一定要有一个返回值,否则会出错!");
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.Append("\r\n" + "return 0;//一定要有一个返回值,否则会出错!");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "return \"\";//一定要有一个返回值,否则会出错!");
            }
            strCodeForCs.Append("\r\n" + "}");


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

        public string Gen_Vue_Ts_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "btnAddNewRecord_Click";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecord_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "this.opType = \"Add\";");
            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");
            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);

            strCodeForCs.Append("\r\n" + $"if (['02', '03', '06'].indexOf(cls{TabName_In4Edit}EN._PrimaryTypeId) > -1)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "await this.AddNewRecordWithMaxId();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.AddNewRecord();",
            TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_Vue_Ts_btnAddNewRecordWithMaxId_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecordWithMaxId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecordWithMaxId_Click.name;",
TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "this.opType = \"AddWithMaxId\";");

            strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_In4Edit}(this.opType);");
            strCodeForCs.Append("\r\n" + $"if (bolIsSuccess == false) return;");

            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", ThisClsName);


            strCodeForCs.AppendFormat("\r\n" + "this.AddNewRecordWithMaxId();",
                TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

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


        public string Gen_Vue_Ts_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_GetMaxStrId(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_UpdateRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            strCodeForCs.Append("\r\n /** 修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async UpdateRecordSave(): Promise<boolean> {");
            strFuncName = $"UpdateRecordSave";

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecordSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + $"const obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");

            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(Number(this.keyId));",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.keyId);",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)",
                this.TabName_In4Edit4GC);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0 || obj{0}EN.{1} == undefined){{",
                this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"\" || obj{0}EN.{1} == undefined){{",
                        this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckProperty4Update)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Update(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.AppendFormat("\r\n" + $"if (bolIsExistCond{strVersion} == false)", objInFor.ConstraintName4GC());
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.UpdateRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs, PrjTabEx_EditRegion.KeyPropNameLstStrWithObjName_TS);
            Gene_DeleteKeyCache(strCodeForCs, PrjTabEx_EditRegion.KeyPropNameLstStrWithObjName_TS, "this.keyId");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"修改记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

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


        public string Gen_Vue_Ts_EditRecordExSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = null;
            var arrPrjConstraintSet = clsPrjConstraintBLEx.GetObjExLstByTabId(TabId_In4Edit, this.PrjId);
            foreach (clsPrjConstraintEN objInFor in arrPrjConstraintSet)
            {
                if (objInFor.InUse == false) continue;
                if (objInFor.ConstraintTypeId != enumConstraintType.Uniqueness_01) continue;
                arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

            }
            if (arrObjLst_Flds == null || arrObjLst_Flds.Count() == 0) return "";


            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 编辑记录，存在就修改，不存在就添加");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async EditRecordExSave(): Promise<boolean> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.EditRecordExSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + $"const obj{this.TabName_In4Edit4GC}EN = await ref{ThisEditClsName}.value.GetEditData{this.TabName_In4Edit4GC}Obj();");

            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(Number(this.keyId));",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.keyId);",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)",
                this.TabName_In4Edit4GC);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0 || obj{0}EN.{1} == undefined){{",
                this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"\" || obj{0}EN.{1} == undefined){{",
                        this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckProperty4Update)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Update(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.AppendFormat("\r\n" + $"if (bolIsExistCond{strVersion} == false)", objInFor.ConstraintName4GC());
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.EditRecordExAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs, PrjTabEx_EditRegion.KeyPropNameLstStrWithObjName_TS);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"修改记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
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
        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());



        public string Gen_Vue_Ts_PutDataToClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_PutDataToClass(objvFunction4GeneCodeEN);
        }
        public string Gen_Vue_Ts_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_GetDataFromClass(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_GetFirstKey()
        {
            return Gen_WApi_Ts_GetFirstKey();
        }


        /// <summary>
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Vue_Ts_DefDiv4EditRegion()
        {
            return Gen_WApi_Ts_DefDiv4EditRegion();
        }

        public string Gen_Vue_Ts_ShowData()
        {
            //string strBy = objKeyField.FldName;
            //if (thisEditTabProp_TS.KeyFldCount > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord()
|| objViewInfoENEx.objViewRegion_Feature.IsHaveDetailRecord())
                {
                    strCodeForCs.Append("\r\n /** 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n" + "* 在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n * @param {0}: 表记录的关键字,显示该表关键字的内容", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "  public async ShowData({0}) {{",
                        thisEditTabProp_TS.KeyVarDefineLstStr);
                    strFuncName = $"ShowData";
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowData.name;", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        //操作步骤:");
                    strCodeForCs.Append("\r\n" + "        //1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "        //4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.AppendFormat("\r\n" + "        let obj{0}EN = new cls{0}EN();",
                        this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        try {");

                    if (thisEditTabProp_TS.KeyFldCount > 1)
                    {
                        strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({objKeyField.PrivFuncName});");
                    }
                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                const strInfo = Format(\"关键字:[{{0}}] 的记录不存在!\", {0});",
                         objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "                //显示信息框");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    //strCodeForCs.Append("\r\n" + "            else {");
                    ////                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"关键字:[${strExam1TypeId}]的相关记录存在!\");");
                    ////                  strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    ////                strCodeForCs.Append("\r\n" + "                //显示信息框");
                    ////              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    //strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"检查相应关键字的记录存在不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");

                    strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}ENConst = await {thisWA_F_InEdit(WA_F.GetObjByKeyId)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");

                    strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}ENConst == null)", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        {");

                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象为空.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "            return;");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.AppendFormat("\r\n" + " obj{0}EN = obj{0}ENConst; ", this.TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");

                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");

                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.ShowDataFrom{this.TabName_In4Edit4GC}Obj(obj{this.TabName_In4Edit4GC}EN);");

                    strCodeForCs.Append("\r\n" + "}");
                }
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScript_EditCS_TS4TypeScript));
        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", TabName_In4Edit4GC);
            //ThisClsName = this.ClsName;
            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;

            objViewInfoENEx.ClsName = this.ClsName;
        }

        public string Gen_Vue_Ts_Code4EditRegion()
        {
            return Gen_WApi_Ts_Code4EditRegion();
        }

        public string Gen_Vue_Ts_AddDPV_Edit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strFuncName = "AddDPV_Edit";
            string strClassName = string.Format("WA_{0}_Edit", TabName_In4Edit4GC);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 在当前界面中,导入编辑区域");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async AddDPV_Edit(divName4Edit:string) {{",
                ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddDPV_Edit.name;",
TabName_In4Edit4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "CheckDivExist(divName4Edit);");
            //strCodeForCs.Append("\r\n" + "const objLst = document.getElementsByTagName(\"div\");");
            //strCodeForCs.Append("\r\n" + "const strStartName = \"divEditEdit\";");
            //strCodeForCs.AppendFormat("\r\n" + "let arrElement = WA_{0}_UT_JS.GetArray(objLst) ;", TabName_In4Edit4GC);

            //strCodeForCs.Append("\r\n" + "let arrDiv = arrElement ;");
            //strCodeForCs.Append("\r\n" + "let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            //strCodeForCs.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            //strCodeForCs.Append("\r\n" + "//var o = document.getElementById(\"div\") ;");
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"./{0}\";", strClassName);
            strCodeForCs.Append("\r\n" + "console.log(\"divName4Edit:(In AddDPV_Edit)\" + divName4Edit);");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Edit).html(data);");

            strCodeForCs.Append("\r\n" + "resolve(true);");
            strCodeForCs.AppendFormat("\r\n" + "//setTimeout(() => {{ clsEditObj.BindTab(); }}, 100);");
            strCodeForCs.AppendFormat("\r\n" + "//clsEditObj.BindTab();");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: (e:any) => {");
            strCodeForCs.Append("\r\n" + "console.error(e);");
            strCodeForCs.Append("\r\n" + "reject(e);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

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



        public string Gen_Vue_TS_ShowDialogBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 显示对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public ShowDialog_{0}(strOp:string) {{", TabName_In4Edit4GC);
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", TabName_In4Edit4GC);

            //strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "//检查相关控件是否存在");
            strCodeForCs.AppendFormat("\r\n" + $"CheckControlExist(this.divEdit, \"div\", \"divEditDialog_{0}\");", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + $"CheckControlExist(this.divEdit, \"h4\", \"lblDialogTitle_{0}\");", TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('修改记录');", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_Vue_TS_HideDialogBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 隐藏对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", TabName_In4Edit4GC);
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.HideDialog_{0}.name;", TabName_In4Edit4GC);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.AppendFormat("\r\n" + $"CheckControlExist(this.divEdit, \"div\", \"divEditDialog_{0}\");", TabName_In4Edit4GC);

            strCodeForCs.AppendFormat("\r\n" + "HideDialog('#divEditDialog_{0}');", TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "}");

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


        public string Gen_Vue_TS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "ShowDialog_" + TabName_In4Edit4GC;
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 显示对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async ShowDialog_{0}(strOp:string): Promise<boolean> {{", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", TabName_In4Edit4GC);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisEditClsName}.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(");
            strCodeForCs.Append("\r\n" + "'当前编辑区的EditObj为空，请检查！(in {0}.{1})',");
            strCodeForCs.Append("\r\n" + "this.className,");
            strCodeForCs.Append("\r\n" + "strThisFuncName,");
            strCodeForCs.Append("\r\n" + ");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + $"await ref{ThisEditClsName}.value.showDialog(this);");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + $"this.divEdit = ref{ThisEditClsName}.value.$refs.refDivEdit;");
            //strCodeForCs.Append("\r\n" + $"if (this.divEdit == null)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.times4TestShowDialog < 2)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog++;");
            //strCodeForCs.Append("\r\n" + "setTimeout(() => {");
            //strCodeForCs.Append("\r\n" + $"this.ShowDialog_{TabName_In4Edit4GC}(strOp);");
            //strCodeForCs.Append("\r\n" + "}, 100);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"当前编辑区的层(div)对象为空，请检查！(in {0}.{1})\", this.className, strThisFuncName);");
            //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            //strCodeForCs.Append("\r\n" + "return false;");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "return false;");
            //strCodeForCs.Append("\r\n" + "} else {");
            //strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog = 0;");
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "console.log(strOp);");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认修改\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消修改\";", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            //strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            //strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_Vue_TS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 隐藏对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", TabName_In4Edit4GC);
            strFuncName = $"HideDialog_{TabName_In4Edit4GC}";
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $" ref{ThisEditClsName}.value.hideDialog();");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

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



        public string Gen_Vue_TS_GetDivName(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "getDivName";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 获取编辑div对象");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "public getDivName(): HTMLDivElement | null {");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = this.getDivName.name;");

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId != enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if (this.divEdit != null) return this.divEdit;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisEditClsName}.value.dialogVisible == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format('当前编辑区的的对话框还没有打开，请检查！(in {0}.{1})',");
            strCodeForCs.Append("\r\n" + "this.className,");
            strCodeForCs.Append("\r\n" + "strThisFuncName,");
            strCodeForCs.Append("\r\n" + ");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + $"this.divEdit = ref{ThisEditClsName}.value.$refs.refDivEdit;");
            strCodeForCs.Append("\r\n" + $"if (this.divEdit == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.times4TestShowDialog < 2)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog++;");
            strCodeForCs.Append("\r\n" + "setTimeout(() => {");
            strCodeForCs.Append("\r\n" + $"this.getDivName();");
            strCodeForCs.Append("\r\n" + "}, 100);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"当前编辑区的层(div)对象为空，请检查！(in {0}.{1})\", this.className, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "} else {");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog = 0;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + $"return this.divEdit;");

            strCodeForCs.Append("\r\n" + "}");

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


        private void Gene_ReFreshCache(StringBuilder sbCode, string strParaStr)
        {
            //List<string> arrKeyPrivaryVarName = clsPubFun4GC.Gc_GetPrivaryVarNameLst(PrjTabEx_EditRegion.arrKeyFldSet);
            //string strKeyPrivaryVarName = string.Join(",", arrKeyPrivaryVarName);
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                sbCode.Append("\r\n" + $"const {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store = use{TabName_In4Edit4GC}Store();");

                sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({strParaStr});");
                ImportClass objImportClass = AddImportClass(TabId_In4Edit, clsString.FirstLcaseS(TabName_In4Edit4GC), $"use{TabName_In4Edit4GC}Store", enumImportObjType.StoreModule, $"@/store/modules{strIsShare}");

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else if (objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.Append("\r\n" + $"{this.TabName_In4Edit4GC}_ReFreshCache();");
                }
                else if (objViewInfoENEx.objCacheClassifyFld4View2_TS == null)
                {
                    if (thisCacheClassify4View.ViewVarName == "")
                    {
                        string strMsg = $"表:{this.TabName_In4Edit4GC}的界面分类变量名为空，请检查！";
                        throw new Exception(strMsg);
                    }
                    sbCode.Append("\r\n" + $"{this.TabName_In4Edit4GC}_ReFreshCache({thisCacheClassify4View.ViewVarName}.value);");
                    ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                }
                else
                {
                    sbCode.Append("\r\n" + $"{this.TabName_In4Edit4GC}_ReFreshCache({thisCacheClassify4View.ViewVarName}.value, {thisCacheClassify4View.ViewVarName2}.value);");
                    ImportClass objImportClass4 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                    ImportClass objImportClass5 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

                }
                ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("ReFreshCache", this.TabName_In4Edit4GC), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + $"//{this.TabName_In4Edit4GC}_ReFreshCache();");
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + $"//{this.TabName_In4Edit4GC}_ReFreshCache({thisCacheClassify4View.ViewVarName}.value);");
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + $"//{this.TabName_In4Edit4GC}_ReFreshCache({thisCacheClassify4View.ViewVarName}.value, {thisCacheClassify4View.ViewVarName2}.value);");
                }
            }

        }


        private void Gene_DeleteKeyCache(StringBuilder sbCode, string strParaStr, string strKeyPrivaryVarName = "")
        {
            //List<string> arrKeyPrivaryVarName = clsPubFun4GC.Gc_GetPrivaryVarNameLst(PrjTabEx_EditRegion.arrKeyFldSet);
            //string strKeyPrivaryVarName = string.Join(",", arrKeyPrivaryVarName);
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                sbCode.Append("\r\n" + $"const {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store = use{TabName_In4Edit4GC}Store();");

                sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({strParaStr});");
                ImportClass objImportClass = AddImportClass(TabId_In4Edit, clsString.FirstLcaseS(TabName_In4Edit4GC), $"use{TabName_In4Edit4GC}Store", enumImportObjType.StoreModule, $"@/store/modules{strIsShare}");

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else if (objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.Append("\r\n" + $"{this.TabName_In4Edit4GC}_DeleteKeyIdCache({strKeyPrivaryVarName});");
                }
                else if (objViewInfoENEx.objCacheClassifyFld4View2_TS == null)
                {
                    if (thisCacheClassify4View.ViewVarName == "")
                    {
                        string strMsg = $"表:{this.TabName_In4Edit4GC}的界面分类变量名为空，请检查！";
                        throw new Exception(strMsg);
                    }
                    sbCode.Append("\r\n" + $"{this.TabName_In4Edit4GC}_DeleteKeyIdCache({thisCacheClassify4View.ViewVarName}.value, {strKeyPrivaryVarName});");
                    ImportClass objImportClass2 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                }
                else
                {
                    sbCode.Append("\r\n" + $"{this.TabName_In4Edit4GC}_DeleteKeyIdCache({thisCacheClassify4View.ViewVarName}.value, {thisCacheClassify4View.ViewVarName2}.value,{strKeyPrivaryVarName});");
                    ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                    ImportClass objImportClass4 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);


                }
                ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"{this.TabName_In4Edit4GC}_DeleteKeyIdCache", enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


            }
            else
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + $"//{this.TabName_In4Edit4GC}_DeleteKeyIdCache({strKeyPrivaryVarName});");
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + $"//{this.TabName_In4Edit4GC}_DeleteKeyIdCache({thisCacheClassify4View.ViewVarName}.value,{strKeyPrivaryVarName});");
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + $"//{this.TabName_In4Edit4GC}_DeleteKeyIdCache({thisCacheClassify4View.ViewVarName}.value, {thisCacheClassify4View.ViewVarName2}.value,{strKeyPrivaryVarName});");
                }
            }

        }

    }
}
