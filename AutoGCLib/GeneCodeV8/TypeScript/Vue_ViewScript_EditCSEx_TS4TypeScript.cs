using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using com.taishsoft.util;
using AgcCommBase;
using System.Reflection;
using System.Linq;
using AGC.PureClass;
using AGC.PureClassEx;
using CodeStruct;

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
    partial class Vue_ViewScript_EditCSEx_TS4TypeScript : clsGeneCodeBase4View
    {
        //private string objPrjTabENEx = "";


        public Vue_ViewScript_EditCSEx_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_EditCSEx_TS4TypeScript(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }

        public Vue_ViewScript_EditCSEx_TS4TypeScript( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }

        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {
            //List<ImportClass> arrImportClass = new List<ImportClass>();


            arrImportClass.Add(new ImportClass
            {
                ClsName =  string.Format("Format", this.TabName_In4Edit4GC),
                FilePath = string.Format("{0}/PubFun/clsString.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
 this.TabName_In4Edit4GC)
            });

         
            arrImportClass.Add(new ImportClass
            {
                ClsName =  string.Format("{0}", this.BaseClsName),
                FilePath = string.Format("@/viewsBase/{0}/{1}", objFuncModule.FuncModuleEnName4GC(), this.BaseClsName)
            });

         
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
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            //string strResult = "";
            this.objCodeElement_Root = new CodeElement { Name = "Root", ElementType = CodeElementType.Root };
            this.objCodeElement_Imports = new CodeElement { Name = "imports", ElementType = CodeElementType.Import, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Imports);

            this.objCodeElement_Class = new CodeElement { Name = ThisClsName, ElementType = CodeElementType.Class, Modifiers = "export abstract" };
            this.objCodeElement_Root.Children.Add(this.objCodeElement_Class);
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

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                //生成所有的函数
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


                strCodeForCs.AppendFormat("\r\n" + "//import $ from \"jquery\";");
                strCodeForCs.Append("\r\n" + "import { message } from '@/utils/myMessage';");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = "message",
                    ElementType = CodeElementType.Import,
                    CodeContent = "import { message } from '@/utils/myMessage';",
                    Modifiers = "import",
                    isPublic = true,
                    From = "@/utils/myMessage"
                });
                GetImportClassLst(objFuncModule);

                arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                foreach (var objInFor in arrImportClass)
                {
                    objInFor.ClsName = objInFor.ClsName;
                    objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                              .Replace("../../TS/", "@/ts/")
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



                strCodeForCs.AppendFormat("\r\n /* {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "export default class  {0} extends {1}", ThisClsName, this.BaseClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = objvFunction4GeneCodeEN.CodeText;
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
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
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScript_EditCSEx_TS4TypeScript));
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
            //    objViewInfoENEx.ClsName = this.ClsName;
            //}
            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = string.Format("{0}Ex", strClassName); ;

            this.BaseClsName = string.Format("{0}", strClassName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
    
        
        public string Gen_Vue_Ts_GeneEventFuncEx()
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
                    strCodeForCs.AppendFormat("\r\n" + "public async {0}()",
                       x.ChangeEvent);
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", x.ChangeEvent);
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中重写该函数!');", ThisClsName);
                    strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrEditRegionFlds_ClickEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /* 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "public  async {0}(){{;",
                       x.ClickEvent, ThisClsName);
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

        public string Gen_Vue_TS_btnEdit_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
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

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  按钮单击,用于调用Js函数中btnClick");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public static btnEdit_Click(strCommandName: string, strKeyId: string) {{", ThisClsName);
            strFuncName = $"btnEdit_Click";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnEdit_Click.name;",
          objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "const objPage = {0}.objPageEdit;", ThisBaseClsName);
            strCodeForCs.Append("\r\n" + $"const objPage: {ThisClsName} = <{ThisClsName}> (");
            strCodeForCs.Append("\r\n" + $"{ThisBaseClsName}.GetPageEditObj('{ThisClsName}')");
            strCodeForCs.Append("\r\n" + ");");
            strCodeForCs.Append("\r\n" + "if (objPage == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strMsg = `从预存编辑类获取关键字:[{ThisClsName}]的对象为空，请在调用编辑类(父类)的定义一下！`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "message.warning(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "if (objPage.divEdit.id == 'temp')");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "objPage.divEdit = divEdit;");
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "let strMsg = '';");
            if (thisEditTabProp_TS.KeyFldCount > 1)
            {
                strCodeForCs.Append("\r\n" + "let objKeyLst;");
                strCodeForCs.Append("\r\n" + "const strKeyLst = strKeyId;");

            }
            //strCodeForCs.AppendFormat("\r\n" + "const obj{0}:{0}Ex = new {0}Ex();", objViewInfoENEx.ViewName);
            //strCodeForCs.AppendFormat("\r\n" + "const objPage:{0} = new {0}(obj{1});", 
            //    ThisClsName, objViewInfoENEx.ViewName);
            strCodeForCs.Append("\r\n" + "switch (strCommandName)");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "case \"Submit\":            //提交");

            strCodeForCs.Append("\r\n" + "objPage.btnSubmit_Click();");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"CreateWithMaxId\":    //添加记录使用最大关键字");
            //strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnAddNewRecordWithMaxId_Click();", arrButtonName.Contains("CreateWithMaxId") ? "" : "//");
            //strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"AddNewRecord\":            //添加记录");
            strCodeForCs.Append("\r\n" + "case \"Create\":            //添加记录");

            strCodeForCs.Append("\r\n" + "objPage.btnAddNewRecord_Click();");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"UpdateRecord\":            //修改记录");
            strCodeForCs.Append("\r\n" + "case \"Update\":            //修改记录");
            strCodeForCs.Append("\r\n" + "case \"UpdateRecordInTab\":            //修改记录InTab");
            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty( strKeyId )== true)");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"请选择需要修改的记录!\";");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (strCommandName == \"UpdateRecordInTab\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "objPage.btnUpdateRecordInTab_Click(strKeyId);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + "objPage.btnUpdateRecord_Click(Number(strKeyId));");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "objPage.btnUpdateRecord_Click(strKeyId);");
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "objKeyLst = {0}_SplitKeyLst(strKeyLst);", TabName_In4Edit);
                ImportClass objImportClass = AddImportClass(TabId_In4Edit, TabName_In4Edit4GC, string.Format("SplitKeyLst", TabName_In4Edit), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (strCommandName == \"UpdateRecordInTab\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "objPage.btnUpdateRecordInTab_Click({0});", thisEditTabProp_TS.KeyPropNameLstStrWithKeyLst);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "objPage.btnUpdateRecord_Click({0});", thisEditTabProp_TS.KeyPropNameLstStrWithKeyLst);
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "strMsg =Format(\"命令:{0}, 关键字: {1}, 在函数({2}.{3})中没有被处理!\", strCommandName, strKeyId, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "break;");

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
        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objViewInfoENEx.PrjId);
        //}
    }
}
