
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmWebSrvClassB_QUDI
表名:WebSrvClass
生成代码版本:2017.05.25.1
生成日期:2017/05/25 08:59:03
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;


using AGC.BusinessLogicEx;
using AgcCommBase;
using AutoGCLib;

namespace AGC.Webform
{
    /// <summary>
    /// wfmWebSrvClassB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCode)
    /// </summary>
    public partial class wfmWebSrvClassB_QUDI : System.Web.UI.Page
    {

        #region 页面启动函数
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            string strFunName = Request.Form["FunName"] != null ? Request.Form["FunName"] : "";
            string strLangType = Request.Form["hidLangType"] != null ? Request.Form["hidLangType"] : "";
            string strDataBaseType = Request.Form["hidDataBaseType"] != null ? Request.Form["hidDataBaseType"] : "";
            //根据传回来的值决定调用哪个函数
            switch (strFunName)
            {
                case "ChangeLangType":
                    ChangeLangType(strLangType); //调用该函数
                    lblLangTypeName.Text = strLangType;
                    break;
                case "ChangeDataBaseType":
                    ChangeDataBaseType(strDataBaseType); //调用该函数
                    lblDataBaseType.Text = strDataBaseType;
                    break;

                case "其他":
                    //调用其他函数

                    break;
                default:
                    //调用默认函数
                    //lblMsg.Text = "调用默认函数";
                    break;
            }
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "WebSrv类维护";
                vsTabName = string.Format("{0}", clsWebSrvClassEN._CurrTabName);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
                {
                    case "0":
                        Response.Redirect("../error.aspx");
                        break;
                    case "1":
                        Response.Redirect("../error.aspx");
                        break;
                    case "2":
                        Response.Redirect("../error.aspx");
                        break;
                    case "3":
                        Response.Redirect("../error.aspx");
                        break;
                    case "4":
                        Response.Redirect("../error.aspx");
                        break;
                    case "9":
                        break;
                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }

                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                clsAppPageTypeBL.BindDdl_AppPageTypeIdCache(ddlAppPageTypeId);
                ddlAppPageTypeId.SelectedIndex = 1;
                //1、为下拉框设置数据源,绑定列表数据
                vsSortWebSrvClassBy = string.Format("{0} Asc", conWebSrvClass.WebSrvClassId);
                //2、显示无条件的表内容在GridView中
                BindGv_WebSrvClass();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucWebSrvClassB1.SetKeyReadOnly(true);
                DispWebSrvClassListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsWebSrvClassBL.objCommFun4BL = new clsCommFun4BL4WebSrvClass();
            }
        }
        ///// <summary>
        ///// 显示生成代码区域
        ///// </summary>
        //private void DispGenCodeRegion()
        //{
        //    divList.Visible = false;
        //    //tabQueryCondition.Visible = false;

        //    //            divBaseOperate.Visible = false;
        //    tabCode.Visible = true;
        //}
        private void DispDiv4Operate(string strNetOrJava, string strSqlOrOracle)
        {
            //string strNetOrJava, strSqlOrOracle;
            //strNetOrJava = rblNetOrJava.SelectedValue;
            //strSqlOrOracle = rblSqlOrOracle.SelectedValue;
            List<Control> arrControls = clsPubFun.GetControl4Type(this, "ImageMap");
            foreach (Control ctrl in arrControls)
            {
                ctrl.Visible = false;
            }
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            //lbGeneDALCode.Visible = true;
            //lbGeneWebServiceCode.Visible = true;
            lbGeneController.Visible = true;
            lbGeneControllerInvokeWS.Visible = true;
            if (strNetOrJava == "DotNet")
            {
                imGeneCode_CSharp.Visible = true;
                vsLangType = clsPubConst.LangType.CSharp;
                lbGeneController.Visible = false;
                lbGeneControllerInvokeWS.Visible = false;
            }
            else if (strNetOrJava == "Java")
            {
                imGeneCode_Java.Visible = true;
                vsLangType = clsPubConst.LangType.JAVA;
                //lbGeneWebServiceCode.Visible = false;

            }
            else if (strNetOrJava == "Swift"
                || strNetOrJava == "Swift3"
                || strNetOrJava == "Swift4")
            {
                imGeneCode_Swift.Visible = true;
                //   vsLangType = clsPubConst.LangType.Swift;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            else if (strNetOrJava == "JavaScript")
            {
                imGeneCode_JavaScript.Visible = true;
                vsLangType = clsPubConst.LangType.JavaScript;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            else if (strNetOrJava == "SilverLight")
            {
                vsLangType = clsPubConst.LangType.SilverLight;
                //lbGeneDALCode.Visible = false;
                //lbGeneWebServiceCode.Visible = false;
            }
            try
            {
                clsUserDefaValue_LocalBLEx.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, "默认语言", vsLangType.ToString());
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        private void ChangeLangType(string strLangType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = strLangType;
            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = clsPubConst.GetDataBaseTypeStrByDataBaseType(vsDataBaseType);
            //vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }

        private void ChangeDataBaseType(string strDataBaseType)
        {
            string strNetOrJava, strSqlOrOracle;
            strNetOrJava = clsPubConst.GetLangTypeStringByLangType(vsLangType);
            //            vsLangType = clsPubConst.GetLangTypeByString(strLangType);
            strSqlOrOracle = strDataBaseType;
            vsDataBaseType = clsPubConst.GetDataBaseTypeByString(strSqlOrOracle);
            DispDiv4Operate(strNetOrJava, strSqlOrOracle);
        }

        #endregion 页面启动函数


        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            this.gvWebSrvClass.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_WebSrvClass();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// </summary>
        protected void BindGv_WebSrvClass()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            System.Data.DataTable objDT = null;
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineWebSrvClassCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvWebSrvClassBL.GetDataTable_vWebSrvClass(strWhereCond);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002928)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortWebSrvClassBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                              ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvWebSrvClass.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvWebSrvClass.PageSize = 10;
            }
            this.gvWebSrvClass.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvWebSrvClass.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvWebSrvClass.BottomPagerRow;
            if (pagerRow == null)
            {
                return;
            }
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvWebSrvClass.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvWebSrvClass.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvWebSrvClass.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvWebSrvClass.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvWebSrvClass.PageIndex == this.gvWebSrvClass.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
                //设置分页器中每页记录数的下拉框的值
                if (string.IsNullOrEmpty(PageSize) == false)
                {
                    ddlPagerRecCount.Text = PageSize;
                }
                else
                {
                    PageSize = "10";
                    ddlPagerRecCount.Text = PageSize;
                }
            }
            gvWebSrvClass.BottomPagerRow.Visible = true;
        }



        /// <summary>
        /// 事件函数:生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理:跳转到GridView的某一数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvWebSrvClass.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvWebSrvClass.PageCount)
                {
                    this.gvWebSrvClass.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_WebSrvClass();
            }
        }


        /// <summary>
        /// 事件函数:在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理:改变GridView的每页记录数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize = intPageSize.ToString();
                    BindGv_WebSrvClass();
                }
            }
        }

        /// <summary>
        /// 事件函数:在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCommand)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvClass_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "全选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvWebSrvClass, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvWebSrvClass, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        /// <summary>
        /// 事件函数:在GridView中，当GeidView行建立时发生的事件，在这里主要处理:数据行中处理删除时显示提示信息，还有在列头显示排序标志。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCreated)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvClass_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
                }
            }
            int intIndex;
            if (vsSortWebSrvClassBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvWebSrvClass.Columns.Count; i++)
                {
                    strSortEx = this.gvWebSrvClass.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortWebSrvClassBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
                        intIndex = vsSortWebSrvClassBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序,而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_PageIndexChanging)
        /// </summary>
        /// <param name = "source"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvClass_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView,使之内容更新,变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                gvWebSrvClass.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView,使之内容更新,变化到新的页
                this.BindGv_WebSrvClass();
            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineWebSrvClassCondition()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = string.Format(" PrjId = '{0}' ", clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {
                if (this.txtWebSrvClassIdq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conWebSrvClass.WebSrvClassId, this.txtWebSrvClassIdq.Text.Trim());
                }
                if (this.txtClassNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conWebSrvClass.ClsName, this.txtClassNameq.Text.Trim());
                }
                if (this.txtNameSpaceq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conWebSrvClass.NameSpace, this.txtNameSpaceq.Text.Trim());
                }
                if (this.txtWebSrvUrlq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conWebSrvClass.WebSrvUrl, this.txtWebSrvUrlq.Text.Trim());
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI002929)在组合查询条件(CombineWebSrvClassCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }

        #endregion 查询相关函数


        #region 排序相关函数
        /// <summary>
        /// 事件函数:在GridView中，单击列头进行排序所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvClass_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortWebSrvClassBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortWebSrvClassBy = e.SortExpression + " Asc";
                BindGv_WebSrvClass();
                return;
            }
            //检查原来是升序
            intIndex = vsSortWebSrvClassBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortWebSrvClassBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortWebSrvClassBy = e.SortExpression + " Desc";
            }
            BindGv_WebSrvClass();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortWebSrvClassBy
        {
            get
            {
                string sSortWebSrvClassBy;
                sSortWebSrvClassBy = (string)ViewState["SortWebSrvClassBy"];
                if (sSortWebSrvClassBy == null)
                {
                    sSortWebSrvClassBy = "";
                }
                return sSortWebSrvClassBy;
            }
            set
            {
                string sSortWebSrvClassBy = value;
                ViewState.Add("SortWebSrvClassBy", sSortWebSrvClassBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddWebSrvClassRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddWebSrvClassRecord()
        {
            wucWebSrvClassB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelWebSrvClassEdit.Text = "取消添加";
            //wucWebSrvClassB1.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
            DispEditWebSrvClassRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddWebSrvClassRecordSave()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsWebSrvClassEN objWebSrvClassEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvClassB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002930)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsWebSrvClassEN objWebSrvClassEN;	//定义对象
            objWebSrvClassEN = new clsWebSrvClassEN(wucWebSrvClassB1.WebSrvClassId);    //初始化新对象
                                                                                        //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId))   //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002931)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvClassClass(objWebSrvClassEN);        //把界面的值传到
                                                                //5.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvClassBL.CheckPropertyNew(objWebSrvClassEN);
                //6、把数据实体层的数据存贮到数据库中
                clsWebSrvClassBL.AddNewRecordBySql2(objWebSrvClassEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI002932)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_WebSrvClass();
            DispWebSrvClassListRegion();
            wucWebSrvClassB1.Clear();       //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvClassEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddWebSrvClassRecordSaveV5()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsWebSrvClassEN objWebSrvClassEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvClassB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002933)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsWebSrvClassEN objWebSrvClassEN;	//定义对象
            objWebSrvClassEN = new clsWebSrvClassEN(wucWebSrvClassB1.WebSrvClassId);    //初始化新对象
                                                                                        //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId))   //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI002934)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvClassClass(objWebSrvClassEN);        //把界面的值传到
                                                                //5.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvClassBL.CheckPropertyNew(objWebSrvClassEN);
                //6、把数据实体层的数据存贮到数据库中
                clsWebSrvClassBL.AddNewRecordBySql2(objWebSrvClassEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI002935)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_WebSrvClass();
            DispWebSrvClassListRegion();
            wucWebSrvClassB1.Clear();       //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvClassEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvClassId = lstWebSrvClassId[0];
            UpdateWebSrvClassRecord(strWebSrvClassId);
        }
        ///
        protected void gvWebSrvClass_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strWebSrvClassId = gvWebSrvClass.DataKeys[e.RowIndex]["WebSrvClassId"].ToString();
            UpdateWebSrvClassRecord(strWebSrvClassId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strWebSrvClassId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strWebSrvClassId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strWebSrvClassId == "") return;     //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsWebSrvClassBL.IsExist(strWebSrvClassId) == false)        //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI002937)在表[WebSrvClass]中,关键字为:[strWebSrvClassId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN(strWebSrvClassId);
            //4、获取类对象的所有属性；
            try
            {
                clsWebSrvClassBL.GetWebSrvClass(ref objWebSrvClassEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objWebSrvClassEN", objWebSrvClassEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromWebSrvClassClass(objWebSrvClassEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjWebSrvClassEN">表实体类对象</param>
        protected void GetDataFromWebSrvClassClass(clsWebSrvClassEN pobjWebSrvClassEN)
        {
            wucWebSrvClassB1.WebSrvClassId = pobjWebSrvClassEN.WebSrvClassId;// 类Id
            wucWebSrvClassB1.ClsName = pobjWebSrvClassEN.ClsName;// 类名
            wucWebSrvClassB1.NameSpace = pobjWebSrvClassEN.NameSpace;// 域名
            wucWebSrvClassB1.WebSrvUrl = pobjWebSrvClassEN.WebSrvUrl;// WebSrv地址
            wucWebSrvClassB1.UpdDate = pobjWebSrvClassEN.UpdDate;// 修改日期
            wucWebSrvClassB1.UpdUser = pobjWebSrvClassEN.UpdUser;// 修改者
            wucWebSrvClassB1.Memo = pobjWebSrvClassEN.Memo;// 说明
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateWebSrvClassRecord(string strWebSrvClassId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strWebSrvClassId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucWebSrvClassB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelWebSrvClassEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditWebSrvClassRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objWebSrvClassEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateWebSrvClassRecordSave(clsWebSrvClassEN objWebSrvClassEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvClassB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002938)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvClassClass(objWebSrvClassEN);        //把界面的值传到
                                                                //3.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvClassBL.CheckPropertyNew(objWebSrvClassEN);
                //4、把数据实体层的数据存贮到数据库中
                clsWebSrvClassBL.UpdateBySql2(objWebSrvClassEN);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_WebSrvClass();
            DispWebSrvClassListRegion();
            wucWebSrvClassB1.Clear();//添空控件中的内容
                                     //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvClassEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_WebSrvClass{0}'", objWebSrvClassEN.WebSrvClassId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objWebSrvClassEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateWebSrvClassRecordSaveV5(clsWebSrvClassEN objWebSrvClassEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucWebSrvClassB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI002939)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToWebSrvClassClass(objWebSrvClassEN);        //把界面的值传到
                                                                //3.1、检查传进去的对象属性是否合法
            try
            {
                clsWebSrvClassBL.CheckPropertyNew(objWebSrvClassEN);
                //4、把数据实体层的数据存贮到数据库中
                clsWebSrvClassBL.UpdateBySql2(objWebSrvClassEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "修改记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_WebSrvClass();
            DispWebSrvClassListRegion();
            wucWebSrvClassB1.Clear();//添空控件中的内容
                                     //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelWebSrvClassEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_WebSrvClass{0}'", objWebSrvClassEN.WebSrvClassId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsWebSrvClassEN objWebSrvClassEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddWebSrvClassRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddWebSrvClassRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objWebSrvClassEN = (clsWebSrvClassEN)Session["objWebSrvClassEN"];
                    UpdateWebSrvClassRecordSave(objWebSrvClassEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelWebSrvClassEdit_Click(object sender, EventArgs e)
        {
            DispWebSrvClassListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjWebSrvClassEN">数据传输的目的类对象</param>
        protected void PutDataToWebSrvClassClass(clsWebSrvClassEN pobjWebSrvClassEN)
        {
            pobjWebSrvClassEN.WebSrvClassId = wucWebSrvClassB1.WebSrvClassId;// 类Id
            pobjWebSrvClassEN.ClsName = wucWebSrvClassB1.ClsName;// 类名
            pobjWebSrvClassEN.NameSpace = wucWebSrvClassB1.NameSpace;// 域名
            pobjWebSrvClassEN.WebSrvUrl = wucWebSrvClassB1.WebSrvUrl;// WebSrv地址
            pobjWebSrvClassEN.UpdDate = wucWebSrvClassB1.UpdDate;// 修改日期
            pobjWebSrvClassEN.UpdUser = wucWebSrvClassB1.UpdUser;// 修改者
            pobjWebSrvClassEN.Memo = wucWebSrvClassB1.Memo;// 说明
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetAllCheckedItemFromGv(gvWebSrvClass, "chkCheckRec", "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002940)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strWebSrvClassId in lstWebSrvClassId)
                {
                    clsWebSrvClassBL.DelRecord(strWebSrvClassId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_WebSrvClass();
        }
        /// <summary>
        /// 事件函数:在GridView中，进行行删除(RowDeleting)
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvWebSrvClass_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strWebSrvClassId = gvWebSrvClass.DataKeys[e.RowIndex]["WebSrvClassId"].ToString();
            DeleteWebSrvClassRecord(strWebSrvClassId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strWebSrvClassId">给定关键字</param>
        protected void DeleteWebSrvClassRecord(string strWebSrvClassId)
        {
            try
            {
                clsWebSrvClassBL.DelRecord(strWebSrvClassId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_WebSrvClass();
        }
        #endregion 删除相关函数


        #region 导出函数

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }


        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[WebSrvClass]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineWebSrvClassCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "WebSrvClass信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(conWebSrvClass.WebSrvClassId); arrCnName.Add("类Id");
            arrColName.Add(conWebSrvClass.ClsName); arrCnName.Add("类名");
            arrColName.Add(conWebSrvClass.NameSpace); arrCnName.Add("域名");
            arrColName.Add(conWebSrvClass.WebSrvUrl); arrCnName.Add("WebSrv地址");
            arrColName.Add(conWebSrvClass.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(conWebSrvClass.UpdUser); arrCnName.Add("修改者");
            arrColName.Add(conWebSrvClass.Memo); arrCnName.Add("说明");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsWebSrvClassBL.GetDataTable_WebSrvClass(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditWebSrvClassRegion()
        {
            divList.Visible = false;
            tabEditWebSrvClassRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListAndEditRegion)
        /// </summary>
        private void DispWebSrvClassListRegion()
        {
            divList.Visible = true;
            tabEditWebSrvClassRegion.Visible = false;
            divCode.Visible = false;
        }
        #endregion 布局控制函数


        #region 错误处理函数

        /// <summary>
        /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
        /// </summary>
        protected string seErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                Session.Add("ErrMessage", strErrMessage);
            }
        }


        /// <summary>
        /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
        /// </summary>
        protected string seBackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }

        #endregion 错误处理函数


        #region 权限处理函数

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }
        /// <summary>
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected string vsTabName
        {
            get
            {
                string sTabName;
                sTabName = (string)ViewState["TabName"];
                if (sTabName == null)
                {
                    sTabName = "";
                }
                return sTabName;
            }
            set
            {
                string sTabName = value;
                ViewState.Add("TabName", sTabName);
            }
        }
        /// <summary>
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 与权限相关的界面编号
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
        /// </summary>
        protected string vsPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }
        /// <summary>
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string vsTypeParas
        {
            get
            {
                string strTypeParas = "";
                if (ViewState["TypeParas"] == null)
                {
                    if (ddlAppPageTypeId.SelectedIndex > 0)
                    {
                        string strAppPageTypeId = ddlAppPageTypeId.SelectedValue;
                        clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeBL.GetObjByAppPageTypeIdCache(strAppPageTypeId);
                        strTypeParas = strTypeParas + string.Format("{0}|",
                            objAppPageTypeEN.AppPageTypeENName);
                        return strTypeParas;
                    }
                }
                strTypeParas = (string)ViewState["TypeParas"];

                return strTypeParas;
            }
            set
            {
                string strTypeParas = value;
                ViewState.Add("TypeParas", strTypeParas);
            }
        }


        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenLoginUserSession)
        /// </summary>
        protected string seUserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }
        ///protected clsUsersEN objUser
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser == null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}



        #endregion 权限处理函数

        protected void btnEditRelaFunc_Click(object sender, EventArgs e)
        {

            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            clsPubFun4Web.JumpToWebSrvFunctionsB_QUDI(this, "WebSrvClassB_QUDI", lstWebSrvClassId[0]);
        }

        protected void btnSetFuncModule_Click(object sender, EventArgs e)
        {
            List<string> arrWebSrvClassId = clsCommForWebForm.GetAllCheckedItemFromGv(gvWebSrvClass, "chkCheckRec");
            if (arrWebSrvClassId == null || arrWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }

            if (ddlFuncModuleId.SelectedIndex <= 0)
            {
                lblMsgList.Text = "没有选择模块名称，请选择一个有效的模块名称!";

                ddlFuncModuleId.Focus();
                return;
            }
            string strFuncModuleId = ddlFuncModuleId.SelectedValue;
            lblMsgList.Text = "";
            foreach (string strWebSrvClassId in arrWebSrvClassId)
            {
                clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetObjByWebSrvClassId(strWebSrvClassId);
                objWebSrvClassEN.FuncModuleAgcId = strFuncModuleId;
                clsWebSrvClassBL.UpdateBySql2(objWebSrvClassEN);

            }
            BindGv_WebSrvClass();

        }

        /// <summary>
        /// 当前所选择的语言类型：分为： "C#.NET"; "Java";SqlOrOracle
        /// </summary>
        protected clsPubConst.LangType vsLangType
        {
            get
            {
                clsPubConst.LangType strLangType;
                if (ViewState["LangType"] == null)
                {
                    strLangType = clsPubConst.LangType.CSharp;//"C#.NET";
                    return strLangType;
                }
                strLangType = (clsPubConst.LangType)ViewState["LangType"];

                return strLangType;
            }
            set
            {
                clsPubConst.LangType strLangType = value;
                ViewState.Add("LangType", strLangType);
            }
        }


        /// <summary>
        /// 当前所选择的语言类型：分为："Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
            }
        }

        /// <summary>
        /// 显示生成代码区域
        /// </summary>
        private void DispGenCodeRegion()
        {
            divList.Visible = false;
            //tabQueryCondition.Visible = false;
            //            divBaseOperate.Visible = false;
            tabCode.Visible = true;
            divCode.Visible = true;
        }
        protected void GenController()
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvClassId = lstWebSrvClassId[0];
           
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppController;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, vsTypeParas, vsLangType, vsDataBaseType,
                    strWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

             
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }
        protected void lbGeneController_Click(object sender, EventArgs e)
        {
            GenController();

        }
        protected void GenController4UTScriptCS()
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvClassId = lstWebSrvClassId[0];
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScriptCS;
                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, vsTypeParas, vsLangType, vsDataBaseType,
                    strWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }

        protected void GenController4UTScript()
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvClassId = lstWebSrvClassId[0];
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUTScript;
                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, vsTypeParas, vsLangType, vsDataBaseType, 
                    strWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }

        protected void GenController4UnitTest()
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvClassId = lstWebSrvClassId[0];
            try
            {
                //string strViewId = "";
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.AppViewUnitTest;
                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, vsTypeParas, vsLangType, vsDataBaseType,
                    strWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);

            }
        }
        protected void lbGeneController4UnitTest_Click(object sender, EventArgs e)
        {
            GenController4UnitTest();

        }
        protected void GenControllerInvokeWS()
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvClassId = lstWebSrvClassId[0];

           
            try
            {
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_AccessHigh;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, vsTypeParas, vsLangType, vsDataBaseType,
                    strWebSrvClassId,
                    clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);


                //string strCodeText = clsWebSrvFunctionsBLEx_GeneCode.GenControllerInvokeWS(strTabId,
                //    clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "",
                //     strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }

        }
        protected void lbGeneControllerInvokeWS_Click(object sender, EventArgs e)
        {
            GenControllerInvokeWS();
        }
        protected void lbGeneWebServiceTransCode_Click(object sender, EventArgs e)
        {
            GenWebServiceTransCode();
        }
        protected void GenWebServiceTransCode()
        {
            List<string> lstWebSrvClassId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvWebSrvClass, "WebSrvClassId");
            if (lstWebSrvClassId.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI002936)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strWebSrvClassId = lstWebSrvClassId[0];
            try
            {
                string strRe_ClsName = "";
                string strRe_FileNameWithModuleName = "";
                clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WS_Access;

                string strCodeText = AutoGC.GeneCode4SelfCreateWs(cnClassName, vsTypeParas,
                    vsLangType, vsDataBaseType, strWebSrvClassId,
                    clsPubVar.CurrSelPrjId,
                    clsPubVar.CurrPrjDataBaseId,
                    clsCommonSession.UserId, ref strRe_ClsName,
                    ref strRe_FileNameWithModuleName);

                //string strCodeText = clsWebSrvFunctionsBLEx_GeneCode.GenWebServiceTransCode(strTabId,
                //    clsPubVar.objCurrSelProject, clsPubVar.CurrPrjDataBaseId,
                //    clsCommonSession.UserId,
                //     clsCommonSession.UserName, "", "",
                //    strCharEncodingId, vsLangType, vsDataBaseType, ref strClsName, ref strCodePath);
                ShowCode(strCodeText);
                txtFileName4GenCode.Text = strRe_ClsName;
                //显示生成代码区域
                DispGenCodeRegion();
            }
            catch (Exception objException)
            {
                //lblErrMsg4AGC.Text = objException.Message;
                ShowCode( objException.Message);
                clsCommonJsFunc.Alert(this, objException.Message);
            }

        }
        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
            switch (e.PostBackValue)
            {
                case "Entity":
                    //GeneEntityLayer();
                    break;
                case "DAL":
                    //GenDALCode();
                    break;

                case "DALEx":
                    //GenDALExCode();
                    break;
                case "Business":
                    //BusinessLogicCode();
                    break;
                case "BusinessEx":
                    //GeneBusinessLogicExCode();
                    break;
                case "CommFun4BL":
                    //GeneCommFun4BL();
                    break;
                case "WebService":
                    //GeneWebServiceCode();
                    break;

                case "WS_Access":
                    GenWebServiceTransCode();
                    break;
                case "WS_AccessHigh":
                    GenControllerInvokeWS();
                    break;
                case "AppController":
                    GenController();
                    break;
                case "AppViewUnitTest":
                    GenController4UnitTest();
                    break;
                case "AppViewUTScript":
                    GenController4UTScript();
                    break;
                case "AppViewUTScriptCS":
                    GenController4UTScriptCS();
                    break;
                case "Dict_PageName_Dir":
                    //GeneDict_PageName_Dir();
                    break;

                default:
                    clsCommonJsFunc.Alert(this, e.PostBackValue);
                    break;
            }
        }

        protected void lbDispTabList_Click(object sender, EventArgs e)
        {
            DispWebSrvClassListRegion();
        }
        protected void ddlAppPageTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
        }
    }
}