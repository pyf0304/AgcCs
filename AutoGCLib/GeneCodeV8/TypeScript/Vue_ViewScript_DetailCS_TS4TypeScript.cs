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
    partial class Vue_ViewScript_DetailCS_TS4TypeScript : WA_ViewScript_DetailCS_TS4TypeScript
    {


        //int intZIndex;      ///控件焦点序号
        //float intCurrLeft;  ///控件的左边空;
        //float intCurrTop;  ///控件的顶面空;
        #region 构造函数
        public Vue_ViewScript_DetailCS_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_DetailCS_TS4TypeScript(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_DetailCS_TS4TypeScript( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", ThisClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
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

        public string Gen_Vue_Ts_DdlBind4ViewFeatureInPage_Load()
        {
            return Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load();
        }


        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_Detail == null || objViewInfoENEx.objViewRegion_Detail.InUseInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            //让用户设置属性;
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse == null || objViewInfoENEx.arrDetailRegionFldSet4InUse.Count == 0)
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

            if (objViewInfoENEx.arrDetailRegionFldSet4InUse.Where(x => x.IsUseFunc() == true).Count() > 0)
            {
                this.bolIsUseFunc4Detail = true;
            }
            //strTabName_Out4Detail = clsPrjTabBL.GetNameByTabIdCache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
            //strTabId_Out4Detail = objViewInfoENEx.objViewRegion_Detail.TabId;

            var objPrjTab_DetailRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4DetailRegion, objViewInfoENEx.PrjId);

            objPrjTabEx_DetailRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_DetailRegion);
            objPrjTabEx_DetailRegion.GetObjAllInfoEx();

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

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, objViewInfoENEx.TabName);
            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //准备数据
                //获取界面所需要的公共变量

                this.GetViewPubVarLst(this.TabId_Out4DetailRegion);

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

                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/jquery/jquery.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/q/q.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/handlebars/handlebars.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as $ from \"jquery\";");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");
                
                GetImportClassLst(objFuncModuleEN);

                arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                foreach (var objInFor in arrImportClass)
                {
                    objInFor.ClsName = objInFor.ClsName;
                    objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                              .Replace("../../TS/", "@/ts/")
                              .Replace("../TS/", "@/ts/")
                                 .Replace("../../L0Entity/", "@/ts/L0Entity/")
                              .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                              .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/");
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
                        .Replace("../TS/", "@/ts/")
                           .Replace("../../L0Entity/", "@/ts/L0Entity/")
                              .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                              .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/"));
                }

                //strCodeForCs.Append("\r\n" + "import $ from \"jquery\";");


                strCodeForCs.AppendFormat("\r\n /* {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class  {0} ", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "public static D1etailObj: any;");
                //strCodeForCs.Append("\r\n" + "public divDetail: HTMLDivElement;");
                strCodeForCs.Append("\r\n" + "public static times4TestShowDialog = 0;");

                strCodeForCs.Append("\r\n" + "public opType = \"\";");
                strCodeForCs.Append("\r\n" + "public keyId = \"\";");
                if (objViewInfoENEx.objViewRegion_Detail.PageDispModeId == "") objViewInfoENEx.objViewRegion_Detail.PageDispModeId = "01";
                var objPageDispMode = clsPageDispModeBL.GetObjByPageDispModeIdCache(objViewInfoENEx.objViewRegion_Detail.PageDispModeId);
                if (objPageDispMode == null)
                {
                    string strMsg = string.Format("生成界面:[{0}]编辑区,页面显示模式为空,请重新设置!(In {1})",
                        objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                strCodeForCs.AppendFormat("\r\n" + "public static strPageDispModeId = \"{0}\";//{1}({2})",
             objPageDispMode.PageDispModeId, objPageDispMode.PageDispModeENName, objPageDispMode.PageDispModeName);



                //strCodeForCs.Append("\r\n" + GeneViewPubVar_TS(strFuncName));

                strCodeForCs.Append("\r\n" + "private iShowList: IShowList;");

                strCodeForCs.Append("\r\n" + "public mstrListDiv = \"divDataLst\";");
                strCodeForCs.Append("\r\n" + "public bolIsLoadDetailRegion = false;  //记录是否导入编辑区的变量");

                strCodeForCs.Append("\r\n" + "public divName4Detail = \"divDetail\";  //编辑区的Id");
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 获取当前组件的divEdit的层对象");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivDetail(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivDetail;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 获取当前组件的divEdit的层对象");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivLayout(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivDetail;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "constructor(objShowList: IShowList) {");
                strCodeForCs.Append("\r\n" + "this.iShowList = objShowList;");
    
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, $"divVarSet.refDivDetail", this, this.strBaseUrl);

                //strCodeForCs.Append("\r\n" + "}");
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


        public string Gen_Vue_Ts_SetKeyReadOnly()
        {
            return Gen_WApi_Ts_SetKeyReadOnly();
        }

        public string Gen_Vue_Ts_Clear()
        {
            return Gen_WApi_Ts_Clear();
        }


        public string Gen_Vue_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ShowTabObj(objvFunction4GeneCodeEN);
        }




        public string Gen_Vue_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_SelectRecord(objvFunction4GeneCodeEN);
        }


        public string Gen_Vue_Ts_DetailRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_DetailRecord(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_DetailRecord4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_DetailRecord4Func(objvFunction4GeneCodeEN);
        }

        //public string Gen_Vue_Ts_GetObjLst4DdlBind(clsViewInfoENEx objViewInfoENEx, string strTabName, string strValueFld, string strTextFld)
        //{
        //    return Gen_WApi_Ts_GetObjLst4DdlBind(objViewInfoENEx, strTabName, strValueFld, strTextFld);
        //}


        public string Gen_Vue_Ts_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnDetailRecordInTab_Click(objvFunction4GeneCodeEN);
        }


        public string Gen_Vue_Ts_btnDetailRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

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

            if (thisDetailTabProp_TS.KeyFldCount > 1) strFuncPara = thisDetailTabProp_TS.KeyVarDefineLstStr;

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + $"public async btnDetailRecord_Click({strFuncPara}) {{");
            strFuncName = $"btnDetailRecord_Click";

            strCodeForCs.Append("\r\n" + "this.opType = \"Detail\";");
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.Append("\r\n" + $"const bolIsSuccess = await this.ShowDialog_{TabName_Out4DetailRegion}('Detail');");
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
                    foreach (var objInFor in PrjTabEx_DetailRegion.arrKeyFldSet )
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

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
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
                    strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"需要显示详细信息记录的关键字为空,请检查!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            else if (objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
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

                //strCodeForCs.Append("\r\n" + $"const {objKeyField.PrivFuncName} = {strViewVarName}.value;");

                strCodeForCs.AppendFormat("\r\n" + $"const strKeyId = {strViewVarName}.value;");
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

            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadDetailRegion = true;  //", ThisClsName);
            string strSuffix4Func = "";//后缀4Func
            if (bolIsUseFunc4Detail == true) strSuffix4Func = "4Func";
            if (thisDetailTabProp_TS.KeyFldCount > 1)
            {
                    strCodeForCs.Append("\r\n" + $"this.DetailRecord{strSuffix4Func}({thisDetailTabProp_TS.KeyPrivVarNameLstStr} );");
            }
            else
            { 
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(lngKeyId);",
                     strSuffix4Func);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(strKeyId);",
                        strSuffix4Func);
                }
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



        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_GetDataFromClass(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_ShowDetailDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ShowDetailDataFromClass(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_GetFirstKey()
        {
            return Gen_WApi_Ts_GetFirstKey();
        }

        public string Gen_Vue_Ts_IndexPage()
        {
            return Gen_WApi_Ts_IndexPage();
        }


        /// <summary>
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Vue_Ts_DefDiv4DetailRegion()
        {
            return Gen_WApi_Ts_DefDiv4DetailRegion();
        }

        public string Gen_Vue_Ts_ShowData()
        {
            return Gen_WApi_Ts_ShowData();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScript_DetailCS_TS4TypeScript));

        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //ThisClsName = this.ClsName;
            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;

            objViewInfoENEx.ClsName = this.ClsName;
        }
        
        public string Gen_Vue_Ts_Code4DetailRegion()
        {
            return Gen_WApi_Ts_Code4DetailRegion();

        }

        public string Gen_Vue_Ts_AddDPV_Detail(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_AddDPV_Detail(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_TS_ShowDialogBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  显示对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public ShowDialog_{0}(strOp:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;",
       objViewInfoENEx.TabName_In, objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivDetail, \"div\", \"divDetailDialog_{objViewInfoENEx.TabName_In}\");");
            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivDetail, \"h4\", \"lblDialogTitle_{objViewInfoENEx.TabName_In}\");");

            //strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.AppendFormat("\r\n" + "           $('#lblDialogTitle_{0}').html('添加记录');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "//{0}Ex.GetMaxStrId('#txt{1}');",
                    ThisClsName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('修改记录');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#btnSubmit{0}').hide();", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('详细信息');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "ShowDialog('#divDetailDialog_{0}');", objViewInfoENEx.TabName_In);

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
            strCodeForCs.Append("\r\n  隐藏对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.HideDialog_{0}.name;",
       objViewInfoENEx.TabName_In, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.AppendFormat("\r\n" + $"CheckControlExist(divVarSet.refDivDetail), \"div\", \"divDetailDialog_{0}\");", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "HideDialog('#divDetailDialog_{0}');", objViewInfoENEx.TabName_In);

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
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 获取显示详细信息的div对象");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "public getDivName(): HTMLDivElement | null {");
            strCodeForCs.Append("\r\n" + "const strThisFuncName = this.getDivName.name;");

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId != enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if (divVarSet.refDivDetail != null) return divVarSet.refDivDetail;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisDetailClsName}.value.dialogVisible == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format('当前详细信息区的的对话框还没有打开，请检查！(in {0}.{1})',");
            strCodeForCs.Append("\r\n" + "this.constructor.name,");
            strCodeForCs.Append("\r\n" + "strThisFuncName,");
            strCodeForCs.Append("\r\n" + ");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + $"divVarSet.refDivDetail = ref{ThisDetailClsName}.value.$refs.refDivDetail;");
            strCodeForCs.Append("\r\n" + $"if (divVarSet.refDivDetail == null)");
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
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"当前详细信息区的层(div)对象为空，请检查！(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "} else {");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog = 0;");
            strCodeForCs.Append("\r\n" + "}");
                
            strCodeForCs.Append("\r\n" + $"return divVarSet.refDivDetail;");

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
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 显示对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async ShowDialog_{0}(strOp:string): Promise<boolean> {{", TabName_Out4DetailRegion);
            strFuncName = $"ShowDialog_{TabName_Out4DetailRegion}";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", TabName_Out4DetailRegion);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.strPageDispModeId == enumPageDispMode.PopupBox_01)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisDetailClsName}.value == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(");
            strCodeForCs.Append("\r\n" + "'当前详细信息区的DetailObj为空，请检查！(in {0}.{1})',");
            strCodeForCs.Append("\r\n" + "this.constructor.name,");
            strCodeForCs.Append("\r\n" + "strThisFuncName,");
            strCodeForCs.Append("\r\n" + ");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + $"await ref{ThisDetailClsName}.value.showDialog();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"divVarSet.refDivDetail = ref{ThisDetailClsName}.value.$refs.refDivDetail;");
            strCodeForCs.Append("\r\n" + $"if (divVarSet.refDivDetail == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"if ({ThisClsName}.times4TestShowDialog < 2)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog++;");
            strCodeForCs.Append("\r\n" + "setTimeout(() => {");
            strCodeForCs.Append("\r\n" + $"this.ShowDialog_{TabName_Out4DetailRegion}(strOp);");
            strCodeForCs.Append("\r\n" + "}, 100);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"当前详细信息区的层(div)对象为空，请检查！(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "} else {");
            strCodeForCs.Append("\r\n" + $"{ThisClsName}.times4TestShowDialog = 0;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "console.log(strOp);");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Detail\" ) {");
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"关闭\";", TabName_Out4DetailRegion);
            strCodeForCs.Append("\r\n" + "        }");
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
            strCodeForCs.Append("\r\n" + $" ref{ThisDetailClsName}.value.hideDialog();");
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

        public string Gen_Vue_Ts_ShowDetailDataFromClass4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ShowDetailDataFromClass4Func(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_FuncMap4Detail()
        {
            return Gen_WApi_Ts_FuncMap4Detail();
        }

        public string Gen_Vue_Ts_CopyToEx()
        {
            return Gen_WApi_Ts_CopyToEx();
        }
    }
}
