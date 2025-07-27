using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(View of Mvc)
    /// </summary>
    public class Mvc_View_Edit4CSharp : clsGeneCodeBase4View
    {
        

        //		private objViewInfoENEx.FileName;		//生成的文件名；
        #region 构造函数
        public Mvc_View_Edit4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public Mvc_View_Edit4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_View_Edit4CSharp(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        #endregion
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///控件焦点序号
            intCurrLeft = 10;  ///控件的左边空;
            intCurrTop = 10;
        }






        public bool DispQryRegionCtrl()
        {

            return true;
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }


        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            this.objViewInfoENEx = objViewInfoENEx;
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = string.Format("{0}Edit", objViewInfoENEx.TabName_In);
            objViewInfoENEx.WebFormFName = string.Format("{0}.cshtml", objViewInfoENEx.WebFormName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                       clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                       objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            strCodeForCs.AppendFormat("\r\n" + "@using {0}.Entity", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@using {0}Mvc.HtmlHelpers", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@model {0}Mvc.Models.ViewModel4{1}", objProjectsENEx.PrjDomain, objMainPrjTab.TabName);
            strCodeForCs.Append("\r\n" + "@{");
            //strCodeForCs.Append("\r\n" + "    Layout = \"~/Views/Shared/TZ_Layout.cshtml\";");
            //strCodeForCs.AppendFormat("\r\n" + "    ViewBag.Title = \"{0}\";", objViewInfoENEx.ViewCnName);
            strCodeForCs.Append("\r\n" + "    string controller = ViewContext.RouteData.Route.GetRouteData(this.Context).Values[\"controller\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string action = ViewContext.RouteData.Values[\"action\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string btnSaveName = \"\";");
            strCodeForCs.Append("\r\n" + "    if (ViewBag.Operate == \"Add\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"确认添加\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else if (ViewBag.Operate == \"Update\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"确认修改\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "}");

            try
            {
                clsTzGCScript objTzGCScript = new clsTzGCScript(objViewInfoENEx);
                string strTemp = "";
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    try
                    {
                        if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                        {
                            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId4View(objvFunction4GeneCodeEN.FuncId4GC,
                                 objViewInfoENEx.ViewId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
                        }
                        else
                        {
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
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
              

        /// <summary>
        /// 功能:生成编辑区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegion()
        {

            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的编辑区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");

                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", \"@Model.{0}\")", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "            @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "                <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}编辑</h4>", objViewInfoENEx.TabCnName, objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-body\" style=\"width: 100%; float:left\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();

                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                </div>");

                strCodeForCs.Append("\r\n" + "                <div class=\"modal-footer\">");
                strCodeForCs.Append("\r\n" + "                      <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                      <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 功能:生成编辑区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegionAjax()
        {

            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的编辑区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "                <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}编辑</h4>", objViewInfoENEx.ViewCnName, objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                else
                {
                    //strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }
                       

        #region 生成单个控件的生成函数


        public string GenFunctionRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            int iDGHeight;      //DataGrid的高度

            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                iDGHeight = objViewInfoENEx.objViewRegion_List.Height ?? 0 + 50;
            
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  objViewInfoENEx.TabName, intCurrTop);

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true || objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    //strCodeForCs.AppendFormat("\r\n" + "<td>");
                    //添加层div
                    ASPHtmlTableEx objASPNETHtmlTableENEx = clsASPHtmlTableBLEx.GettabGridFunction();
                    ASPRowEx objASPNETRowENEx = clsASPRowBLEx.GetEmptyTr();
                    objASPNETHtmlTableENEx.arrSubAspControlLst2.Add(objASPNETRowENEx);

                    ASPColEx objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //列表标题
                    ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx);
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);


                    //iDG_Div_Left = 390;//第一个按钮的左为390
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                      || objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnDelete4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnUpdate4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);


                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnUpdate4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnDetail4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);


                    }
                    if (objViewInfoENEx.arrFeatureId.Contains("0142") == true)
                    {
                        //List<ASPButtonEx> arrAspNetButton4AdjustOrderNum = new List<ASPButtonEx>();
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnGoTop();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnUpMove();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnDownMove();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnGoBottum();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnReOrder();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //foreach (ASPButtonEx objInfor in arrAspNetButton4AdjustOrderNum)
                        //{
                        //    clsASPButtonBLEx.GeneCode(objInfor, strCodeForCs);

                        //}
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnExportExcel4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    }
                    if (objViewInfoENEx.IsNeedSetExportFld == true &&
                          objViewInfoENEx.objViewTypeCodeTab.IsHaveSetExportExcel == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnSetExportExcel4User();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);


                    }

                    //层结束
                    //strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    //strCodeForCs.Append("\r\n" + "</table>");
                    objASPNETHtmlTableENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                }
                //生成GridView的代码;


                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string Gen_Mvc_ButtonInForm(clsButtonStyleEN objButtonStyle, string strButtonId,
            string strButtonText, string strOnClick = "")
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///生成Button的代码;
                ///   <td>
                //    < input type = "submit" value = "查询" class="btn btn-default" />
                //</td>

                //<td>
                //    <a href = "javascript:void(0);" class="easyui-linkbutton" data-options="iconCls:'icon-clear' " onclick="resetSearch()">清空</a>
                //</td>
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<input id = \"{0}\"  type=\"submit\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                //strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                //  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                //  objButtonStyle.Width, objButtonStyle.Height);

                //生成运行模式是否在服务器运行
                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                //  objButtonStyle.Runat);

                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "value = \"{0}\" class = \"btn btn-default\" ", strButtonText);
                //生成单击事件
                if (string.IsNullOrEmpty(strOnClick) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);
                }
                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "/>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
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
        public string Gen_Mvc_CombineCtlWithFor(clsLabelStyleEN objLabelStyle, string strFldName, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId, string strDsTabId, string strDdlItemsOptionId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objLabelStyle.StyleZindex = intZIndex + 1;
                objLabelStyle.StyleLeft = (int)intCurrLeft;
                objLabelStyle.StyleTop = (int)intCurrTop;
                ///生成Label的代码;

                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.qryModel4{0}.{1}, htmlAttributes: new {2} @class = \"control -label col-md-4\", style = \"width:100px\" {3})",
                    objViewInfoENEx.TabName_Out, strFldName, "{", "}");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

                objGenCtlStyle.StyleZindex = intZIndex + 1;
                objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
                //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
                objGenCtlStyle.StyleTop = (int)intCurrTop;
                ///生成右边控件的代码;
                strCodeForCs.Append("\r\n" + "<td>");
                switch (strCtlTypeName)
                {
                    case "TextBox":
                        strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.qryModel4{0}.{1}, new {{ htmlAttributes = new {{ @class = \"easyui -textbox\" }} }})",
                            objViewInfoENEx.TabName_Out, strFldName);
                        break;
                    case "DropDownList":
                        if (strDdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.qryModel4{0}.{1}, ViewData[\"TrueAndFalseList\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName);
                        }
                        else
                        {
                            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strDsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.qryModel4{0}.{1}, ViewData[\"{2}List\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName, objPrjTab.TabName);
                        }
                        break;
                    default:
                        string strMsg = string.Format("控件名:{1}在Switch没有处理,请检查!({0})",
                          clsStackTrace.GetCurrClassFunction(), strCtlTypeName);
                        throw new Exception(strMsg);

                }


                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成组合控件时出错!错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        #endregion
       
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = "";
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    //strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //    //    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //strTemp = A_GeneFuncCode(objViewInfoENEx, strFuncName);
                //}

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_MvcView_CtlViewCodeforTab()
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;

            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            int intZIndex;
            //			int intCurrLeft;  ///控件的左边空;
            int intCurrTop;  ///控件的顶面空;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;


            try
            {
                ///生成插入记录的界面代码;

                intZIndex = 101;
                intCurrTop = 50;
                if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }
                strCodeForCs.Append("\r\n" + "<table class=\"col-md-12\">");
                //strCodeForCs.Append("\r\n" + "<tr>");
                //strCodeForCs.Append("\r\n" + "<td class=\"col-md-3\">");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "@Html.HiddenFor(model => model.{0})");
                    }
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                        && objEditRegionFldsEx.PrimaryTypeId()== enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        continue;
                    }
                    string strFldName = objEditRegionFldsEx.FldName;
                    string strCaption = objEditRegionFldsEx.LabelCaption;
                    //strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                    strCodeForCs.Append("\r\n" + "<tr>");
                    strCodeForCs.Append("\r\n" + "<td class=\"col-md-2\">");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                               strFldName, "{", "}");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\"  style=\"text-align:left\">");
                            strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                 strFldName, "{", "}");
                                                       

                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        case "DropDownList":
                            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsEx.DsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\"  style=\"text-align:left\">");
                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ @class = \"form-control\", id=\"{2}\", style = \"width:300px; \", onchange = \"{2}Selected()\" }})",
                                    strFldName, objPrjTabEN.TabName, objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "</td>");
                                strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\">");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ @class = \"form-control\", id=\"{2}\", style = \"width:300px; \", onchange = \"{2}Selected()\" }})",
                                    strFldName, objPrjTabEN.TabName, objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + "</td>");
                                strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\">");

                            }
                            else
                            {

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ @class = \"form-control\", id=\"{2}\", style = \"width:300px; \", onchange = \"{2}Selected()\" }})",
                                    strFldName, objPrjTabEN.TabName, objEditRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "</td>");
                                strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\">");

                                if (objEditRegionFldsEx.ObjFieldTabENEx.IsNull == false)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}不能为空!\", new {2} @class = \"text-danger\" {3})",
                                        strFldName, strCaption, "{", "}");
                          
                                }
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\">");

                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                    strFldName, "{", "}");

                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.TextBoxFor(model => model.{0}, new {1} @readonly = \"readonly\", @class = \"form-control\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + "</td>");
                                strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\">");
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");


                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                  strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + "</td>");
                                strCodeForCs.Append("\r\n" + "<td class=\"col-md-4\">");

                                if (objEditRegionFldsEx.ObjFieldTabENEx.IsNull == false)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}不能为空!\", new {2} @class = \"text-danger\" {3})",
                                    strFldName, strCaption, "{", "}");
                              
                                }
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");

                            break;
                    }
                    //strCodeForCs.Append("\r\n" + "                        </div>");
                    strCodeForCs.Append("\r\n" + "</tr>");


                    intZIndex += 1;
                    intCurrTop += 25;

                }
                strCodeForCs.Append("\r\n" + "  </table>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_View_Edit4CSharp);
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
            this.ClsName = string.Format("{0}Edit", objViewInfoENEx.TabName_In);
            objViewInfoENEx.ClsName = this.ClsName;
        }
       
    }
}
