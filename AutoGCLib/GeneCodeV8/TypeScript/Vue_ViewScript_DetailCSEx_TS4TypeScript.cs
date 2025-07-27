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
    partial class Vue_ViewScript_DetailCSEx_TS4TypeScript : clsGeneCodeBase4View
    {

        //private string objPrjTabENEx = "";
        //clsBiDimDistribute objBiDimDistribue4Qry = null;
       
        public Vue_ViewScript_DetailCSEx_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScript_DetailCSEx_TS4TypeScript(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();

        }
        public Vue_ViewScript_DetailCSEx_TS4TypeScript( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base( strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
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

            //string strResult = "";
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

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/jquery/jquery.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/q/q.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/handlebars/handlebars.d.ts\" />");
                strCodeForCs.AppendFormat("\r\n" + "//import * as $ from \"jquery\";");
                strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");
                strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"@/viewsBase/{1}/{0}\";",
                    this.BaseClsName, objFuncModule.FuncModuleEnName4GC());
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"{this.BaseClsName}",
                    ElementType = CodeElementType.Import,
                    CodeContent = $"import {{ {this.BaseClsName} }} from \"@/viewsBase/{objFuncModule.FuncModuleEnName4GC()}/{this.BaseClsName};",
                    Modifiers = "import",
                    isPublic = true,
                    From = $"@/viewsBase/{objFuncModule.FuncModuleEnName4GC()}/{this.BaseClsName}",
                });

                strCodeForCs.Append("\r\n" + $"import {objViewInfoENEx.ViewName}Ex from \"@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{objViewInfoENEx.ViewName}Ex\";");
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, new CodeElement
                {
                    Name = $"{objViewInfoENEx.ViewName}Ex",
                    ElementType = CodeElementType.Import,
                    CodeContent = $"import {objViewInfoENEx.ViewName}Ex from \"@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{objViewInfoENEx.ViewName}Ex;",
                    Modifiers = "import",
                    isPublic = true,
                    From = $"@/views{strIsShare}/{objFuncModule.FuncModuleEnName4GC()}/{objViewInfoENEx.ViewName}Ex",
                });
              
                strCodeForCs.AppendFormat("\r\n /* {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "export default class  {0} extends {1}", ThisClsName, this.BaseClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");
                         
                strCodeForCs.Append("\r\n" + "");
                /////生成界面中PageLoad代码;
                //strCodeForCs.Append("\r\n" + "#region 页面启动函数");

                /////生成界面中PageLoad代码;
                //strTemp = GenPageLoadCode(false);
                //strCodeForCs.Append(strTemp);
                //strCodeForCs.Append("\r\n" + "#endregion 页面启动函数");
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
           clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, new VFunction4GeneCodeComparer());
                //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.FuncName4Code);

                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    //if (strFuncName.IndexOf("TS_ScriptCS") > 0)
                    //{
                    //string strFuncName4Code = objvFunction4GeneCodeEN.FuncName4Code;
                    //if (strFuncName4Code.Contains("AddNew") == true
                    //    || strFuncName4Code.Contains("Update") == true
                    //    || strFuncName4Code.Contains("GetObjByKey") == true)
                    //{
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    //string strSource = string.Format("ac{0}_UnitTest", objViewInfoENEx.TabName);
                    //string strTarget = string.Format("ac{0}_UTScript", objViewInfoENEx.TabName);

                    //strTemp = strTemp.Replace(strSource, strTarget);
                    //}
                    //else
                    //{
                    //    strTemp = "";
                    //}
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
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
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScript_DetailCSEx_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(Vue_ViewScript_DetailCSEx_TS4TypeScript);
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

            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
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


                var arrDetailRegionFlds_ChangeEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ChangeEvent.ForEach(x => {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /* 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");
                    strCodeForCs.AppendFormat("\r\n" + "public async {0}()",
                       x.ChangeEvent);
                    strFuncName = $"{x.ChangeEvent}";
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;",       x.ChangeEvent);
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中重写该函数!');", ThisClsName);
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
                });

                strCodeForCs.Append("\r\n" + "");

                var arrDetailRegionFlds_ClickEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ClickEvent.ForEach(x => {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /* 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "public  async {0}(){{;",
                       x.ClickEvent, ThisClsName);
                    strFuncName = $"{x.ClickEvent}";
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;",       x.ClickEvent);
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中重写该函数!');", ThisClsName);
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
                });

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            //clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            //{
            //    Name = strFuncName,
            //    CodeContent = strCodeForCs.ToString(),
            //    ElementType = CodeElementType.Method,
            //    Modifiers = "public async",
            //    ReturnType = "void",
            //});
            //if (strFuncName == "")
            //{
            //    string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_btnDetail_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            List<string> arrButtonName = arrFeatureRegionFldsObjLst.Select(x => x.ButtonName)
                .Select(x=>x.Substring(3))
                .ToList();
            var arr = new List<string>  { enumPrjFeature.DefaultFeature_0240, enumPrjFeature.SetFieldValue_0148 };
            List<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst_DefaultFeature = objViewInfoENEx.arrFeatureRegionFlds.Where(x=> arr.Contains( x.FeatureId)).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  按钮单击,用于调用Js函数中btnClick");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public static btnDetail_Click(strCommandName: string, strKeyId: string) {{", ThisClsName);
            strFuncName =$"btnDetail_Click";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetail_Click.name;",
        objViewInfoENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}:{0}Ex = new {0}Ex();", objViewInfoENEx.ViewName);
            strCodeForCs.AppendFormat("\r\n" + "const objPage:{0} = new {0}(obj{1});", 
                ThisClsName, objViewInfoENEx.ViewName);

            strCodeForCs.Append("\r\n" + "console.log(strKeyId, strThisFuncName, objPage);"); 
           strCodeForCs.Append("\r\n" + "let strMsg;");

           strCodeForCs.Append("\r\n" + "switch (strCommandName)");
            strCodeForCs.Append("\r\n" + "{");
                       
            strCodeForCs.Append("\r\n" + "case \"Detail\":    //详细信息");
            strCodeForCs.AppendFormat("\r\n" + "objPage.btnDetailRecord_Click(strKeyId);", arrButtonName.Contains("AddNewRecordWithMaxId") ? "" : "//");
            strCodeForCs.Append("\r\n" + "break;");
                        

            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = `命令:${{strCommandName}} 在函数({0}.btnClick)中没有被处理!`;", this.BaseClsName);
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

    }
}
