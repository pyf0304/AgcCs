
///----------------------
///生成代码版本:2016.06.03.1
///生成日期:2016/06/05
///生成者:潘以锋
///工程名称:AGC
///工程ID:0005
///模块中文名:项目界面管理
///模块英文名:PrjInterface
///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.05.23.01
///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.05.23.01
///========================



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


namespace AGC.Webform
{
    /// <summary>
    /// wfmViewStyleB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// </summary>
    public partial class wfmViewStyleB_QUDI : CommWebPageBase
    {

        #region 页面启动函数
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "界面模式维护";
                vsTabName = string.Format("{0}", clsvViewInfoEN._CurrTabName);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
                {
                    case "0":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "1":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "2":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "3":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "4":
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                    case "9":
                        break;
                    default:
                        clsPubFun4Web.AccessError(this, conCurrPageName);
                        break;
                }

                //1、为下拉框设置数据源,绑定列表数据
                wucViewStyleB1.SetDdl_TitleStyleId(clsPubVar.CurrSelPrjId);
                wucViewStyleB1.SetDdl_DgStyleId();
                clsTitleStyleBL.BindDdl_TitleStyleId(ddlTitleStyleIdq);
                clsDataGridStyleBL.BindDdl_DgStyleId(ddlDgStyleIdq);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleAgcIdEx(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId);
                strSortViewStyleBy = string.Format("{0} Asc", conViewStyle.ViewId);
                //2、显示无条件的表内容在GridView中
                BindGv_ViewStyle();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucViewStyleB1.SetKeyReadOnly(true);
                DispViewStyleListRegion();
            }
        }

        #endregion 页面启动函数


        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            this.gvViewStyle.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_ViewStyle();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenBindGridView)
        /// </summary>
        protected void BindGv_ViewStyle()
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
                string strWhereCond = CombineViewStyleCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvViewInfoBL.GetDataTable_vViewInfo(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "(errid:WebI001079)获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortViewStyleBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                             ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvViewStyle.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvViewStyle.PageSize = 10;
            }
            this.gvViewStyle.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvViewStyle.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvViewStyle.BottomPagerRow;
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
                lblAllPages.Text = this.gvViewStyle.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvViewStyle.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvViewStyle.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvViewStyle.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvViewStyle.PageIndex == this.gvViewStyle.PageCount - 1)
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
            gvViewStyle.BottomPagerRow.Visible = true;
        }



        /// <summary>
        /// 事件函数：生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理：跳转到GridView的某一数。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvViewStyle.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvViewStyle.PageCount)
                {
                    this.gvViewStyle.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_ViewStyle();
            }
        }


        /// <summary>
        /// 事件函数：在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理：改变GridView的每页记录数。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    BindGv_ViewStyle();
                }
            }
        }

        /// <summary>
        /// 事件函数：在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理：在列头显示单击全选按钮时全选GridView的所有行。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_RowCommand)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvViewStyle_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvViewStyle, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvViewStyle, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        /// <summary>
        /// 事件函数：在GridView中，当GeidView行建立时发生的事件，在这里主要处理：数据行中处理删除时显示提示信息，还有在列头显示排序标志。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_RowCreated)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvViewStyle_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortViewStyleBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvViewStyle.Columns.Count; i++)
                {
                    strSortEx = this.gvViewStyle.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortViewStyleBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
                        intIndex = strSortViewStyleBy.IndexOf("Asc");
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
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_PageIndexChanging)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvViewStyle_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView,使之内容更新,变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                gvViewStyle.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView,使之内容更新,变化到新的页
                this.BindGv_ViewStyle();
            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineViewStyleCondition()
        {
            //使条件串的初值为"1=1",以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string .Format(" {0}='{1}' ", convViewInfo.PrjId, clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {
                if (this.ddlTitleStyleIdq.SelectedValue != "" && this.ddlTitleStyleIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0}='{1}'", convViewInfo.TitleStyleId, this.ddlTitleStyleIdq.SelectedValue);
                }
                if (this.ddlDgStyleIdq.SelectedValue != "" && this.ddlDgStyleIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0}='{1}'", convViewInfo.DgStyleId, this.ddlDgStyleIdq.SelectedValue);
                }
                if (this.txtViewNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convViewInfo.ViewName, this.txtViewNameq.Text.Trim());
                }
                if (this.ddlFuncModuleIdq.SelectedValue != "" && this.ddlFuncModuleIdq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0}='{1}'", convViewInfo.FuncModuleAgcId, this.ddlFuncModuleIdq.SelectedValue);
                }
                if (this.txtMainTabNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convViewInfo.MainTabName, this.txtMainTabNameq.Text.Trim());
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI001080)在组合查询条件(CombineViewStyleCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPageSizeViewState)
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
        /// 事件函数：在GridView中，单击列头进行排序所发生的事件
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_Sorting)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvViewStyle_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortViewStyleBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortViewStyleBy = e.SortExpression + " Asc";
                BindGv_ViewStyle();
                return;
            }
            //检查原来是升序
            intIndex = strSortViewStyleBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                strSortViewStyleBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                strSortViewStyleBy = e.SortExpression + " Desc";
            }
            BindGv_ViewStyle();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_Sorting)
        /// </summary>
        protected string strSortViewStyleBy
        {
            get
            {
                string sSortViewStyleBy;
                sSortViewStyleBy = (string)ViewState["SortViewStyleBy"];
                if (sSortViewStyleBy == null)
                {
                    sSortViewStyleBy = "";
                }
                return sSortViewStyleBy;
            }
            set
            {
                string sSortViewStyleBy = value;
                ViewState.Add("SortViewStyleBy", sSortViewStyleBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddViewStyleRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenAddRecordCode)
        /// </summary>
        protected void AddViewStyleRecord()
        {
            wucViewStyleB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelViewStyleEdit.Text = "取消添加";
            //wucViewStyleB1.ViewId = clsViewStyleBL.GetMaxStrId_S();
            DispEditViewStyleRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddViewStyleRecordSave()
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
            clsViewStyleEN objViewStyleEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucViewStyleB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI001081)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsViewStyleEN objViewStyleEN;	//定义对象
            objViewStyleEN = new clsViewStyleEN(wucViewStyleB1.ViewId); //初始化新对象
                                                                        //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsViewStyleBL.IsExist(objViewStyleEN.ViewId))  //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI001082)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToViewStyleClass(objViewStyleEN);        //把界面的值传到
                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsViewStyleBL.CheckPropertyNew(objViewStyleEN);
                //6、把数据实体层的数据存贮到数据库中
                clsViewStyleBL.AddNewRecordBySql2(objViewStyleEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI001083)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_ViewStyle();
            DispViewStyleListRegion();
            wucViewStyleB1.Clear();     //清空控件中内容
                                        ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelViewStyleEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddViewStyleRecordSaveV5()
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
            clsViewStyleEN objViewStyleEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucViewStyleB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI001084)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsViewStyleEN objViewStyleEN;	//定义对象
            objViewStyleEN = new clsViewStyleEN(wucViewStyleB1.ViewId); //初始化新对象
                                                                        //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsViewStyleBL.IsExist(objViewStyleEN.ViewId))  //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI001085)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToViewStyleClass(objViewStyleEN);        //把界面的值传到
                                                            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsViewStyleBL.CheckPropertyNew(objViewStyleEN);
                //6、把数据实体层的数据存贮到数据库中
                clsViewStyleBL.AddNewRecordBySql2(objViewStyleEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "(errid:WebI001086)添加记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_ViewStyle();
            DispViewStyleListRegion();
            wucViewStyleB1.Clear();     //清空控件中内容
                                        ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelViewStyleEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnUpdate4Gv_Click)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvViewStyle, "ViewId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI001087)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            string strViewId = strKeys[0];
            UpdateViewStyleRecord(strViewId);
        }
        ///
        protected void gvViewStyle_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strViewId = gvViewStyle.DataKeys[e.RowIndex]["ViewId"].ToString();
            UpdateViewStyleRecord(strViewId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　     在这里是把值传到表控件中
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenShowDataCode)
        /// </summary>
        /// <param name="strViewId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strViewId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strViewId == "") return;        //如果关键字为空就返回退出
                                                //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsViewStyleBL.IsExist(strViewId) == false)     //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI001088)在表[ViewStyle]中,关键字为:[strViewId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsViewStyleEN objViewStyleEN = new clsViewStyleEN(strViewId);
            //4、获取类对象的所有属性；
            try
            {
                objViewStyleEN =  clsViewStyleBL.GetObjByViewId(strViewId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objViewStyleEN", objViewStyleEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromViewStyleClass(objViewStyleEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenGetDataFromClass)
        /// </summary>
        /// <param name="pobjViewStyleEN">表实体类对象</param>
        protected void GetDataFromViewStyleClass(clsViewStyleEN pobjViewStyleEN)
        {
            wucViewStyleB1.ViewId = pobjViewStyleEN.ViewId;// 界面ID
            wucViewStyleB1.TitleStyleId = pobjViewStyleEN.TitleStyleId;// 标题类型Id
            wucViewStyleB1.DgStyleId = pobjViewStyleEN.DgStyleId;// DG模式ID
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateViewStyleRecord(string strViewId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strViewId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucViewStyleB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelViewStyleEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditViewStyleRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name="objViewStyleEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateViewStyleRecordSave(clsViewStyleEN objViewStyleEN)
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
            if (!wucViewStyleB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI001089)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToViewStyleClass(objViewStyleEN);        //把界面的值传到
                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsViewStyleBL.CheckPropertyNew(objViewStyleEN);
                //4、把数据实体层的数据存贮到数据库中
                clsViewStyleBL.UpdateBySql2(objViewStyleEN);
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
            BindGv_ViewStyle();
            DispViewStyleListRegion();
            wucViewStyleB1.Clear();//添空控件中的内容
                                   //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelViewStyleEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href='#A_ViewStyle{0}'", objViewStyleEN.ViewId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name="objViewStyleEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateViewStyleRecordSaveV5(clsViewStyleEN objViewStyleEN)
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
            if (!wucViewStyleB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "(errid:WebI001090)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToViewStyleClass(objViewStyleEN);        //把界面的值传到
                                                            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsViewStyleBL.CheckPropertyNew(objViewStyleEN);
                //4、把数据实体层的数据存贮到数据库中
                clsViewStyleBL.UpdateBySql2(objViewStyleEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_ViewStyle();
            DispViewStyleListRegion();
            wucViewStyleB1.Clear();//添空控件中的内容
                                   //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelViewStyleEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href='#A_ViewStyle{0}'", objViewStyleEN.ViewId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsViewStyleEN objViewStyleEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddViewStyleRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddViewStyleRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objViewStyleEN = (clsViewStyleEN)Session["objViewStyleEN"];
                    UpdateViewStyleRecordSave(objViewStyleEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数：取消编辑状态，退回到列表状态
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelViewStyleEdit_Click(object sender, EventArgs e)
        {
            DispViewStyleListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPutDataToClass)
        /// </summary>
        /// <param name="pobjViewStyleEN">数据传输的目的类对象</param>
        protected void PutDataToViewStyleClass(clsViewStyleEN pobjViewStyleEN)
        {
            pobjViewStyleEN.ViewId = wucViewStyleB1.ViewId;// 界面ID
            pobjViewStyleEN.TitleStyleId = wucViewStyleB1.TitleStyleId;// 标题类型Id
            pobjViewStyleEN.DgStyleId = wucViewStyleB1.DgStyleId;// DG模式ID
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnDelete4Gv_Click)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvViewStyle, "chkCheckRec", "ViewId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "(errid:WebI001091)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    string strViewId = strKeys[0];
                    clsViewStyleBL.DelRecord(strViewId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ViewStyle();
        }
        /// <summary>
        /// 事件函数：在GridView中，进行行删除(RowDeleting)
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvViewStyle_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strViewId = gvViewStyle.DataKeys[e.RowIndex]["ViewId"].ToString();
            DeleteViewStyleRecord(strViewId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDeleteRecordCode)
        /// </summary>
        /// <param name="strViewId">给定关键字</param>
        protected void DeleteViewStyleRecord(string strViewId)
        {
            try
            {
                clsViewStyleBL.DelRecord(strViewId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ViewStyle();
        }
        #endregion 删除相关函数


        #region 导出函数

        /// <summary>
        /// 事件函数：把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        ///设置当前用户的Excel导出字段
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnSetExportExcel4User_Click)
        /// </summary>
        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", vsViewName);//当前界面
            sbCondition.AppendFormat(" And TabName='{0}'", vsTabName);//当前导出的使用的表
            sbCondition.AppendFormat(" And UserId='{0}'", clsCommonSession.UserId);//当前用户
                                                                                   //根据条件获取Excel设置Id
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("(errid:WinI000125)在系统中没有界面为[{0}]", vsViewName);
                sbMsg.AppendFormat(",表名='{0}'", vsTabName);
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置,请先导出一次Excel,再不行可与管理员联系!", clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }
            //弹出导出Excel字段界面进行设置
            StringBuilder sbScript = new StringBuilder();
            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "导出Excel字段设置", sbScript.ToString());
            // Response.Write(sbScript.ToString());
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vViewStyle]表中获取记录集,最终导出到Excel
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineViewStyleCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ViewStyle信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convViewInfo.ViewId); arrCnName.Add("界面ID");
            arrColName.Add(convViewInfo.TitleStyleId); arrCnName.Add("标题类型Id");
            arrColName.Add(convViewInfo.TitleStyleName); arrCnName.Add("标题类型名");
            arrColName.Add(convViewInfo.DgStyleId); arrCnName.Add("DG模式ID");
            arrColName.Add(convViewInfo.DgStyleName); arrCnName.Add("DG模式名");
            arrColName.Add(convViewInfo.ViewName); arrCnName.Add("界面名称");
            //arrColName.Add(convViewInfo.ViewTypeCode); arrCnName.Add("界面类型码");
            //arrColName.Add(convViewInfo.ViewTypeName); arrCnName.Add("界面类型名称");
            arrColName.Add(convViewInfo.ApplicationTypeId); arrCnName.Add("应用程序类型ID");
            arrColName.Add(convViewInfo.ApplicationTypeSimName); arrCnName.Add("应用程序类型名称");
            arrColName.Add(convViewInfo.FuncModuleAgcId); arrCnName.Add("功能模块Id");
            arrColName.Add(convViewInfo.FuncModuleName); arrCnName.Add("功能模块名称");
            arrColName.Add(convViewInfo.FuncModuleEnName); arrCnName.Add("功能模块英文名称");
            arrColName.Add(convViewInfo.DataBaseName); arrCnName.Add("数据库名");
            arrColName.Add(convViewInfo.KeyForMainTab); arrCnName.Add("主表关键字");
            arrColName.Add(convViewInfo.KeyForDetailTab); arrCnName.Add("明细表关键字");
            arrColName.Add(convViewInfo.IsNeedSort); arrCnName.Add("是否需要排序");
            arrColName.Add(convViewInfo.IsNeedTransCode); arrCnName.Add("是否需要转换代码");
            arrColName.Add(convViewInfo.UserId); arrCnName.Add("用户ID");
            arrColName.Add(convViewInfo.PrjId); arrCnName.Add("工程ID");
            arrColName.Add(convViewInfo.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convViewInfo.ViewFunction); arrCnName.Add("界面功能");
            arrColName.Add(convViewInfo.ViewDetail); arrCnName.Add("界面说明");
            arrColName.Add(convViewInfo.DefaMenuName); arrCnName.Add("缺省菜单名");
            arrColName.Add(convViewInfo.DetailTabId); arrCnName.Add("明细表ID");
            arrColName.Add(convViewInfo.FileName); arrCnName.Add("文件名");
            arrColName.Add(convViewInfo.FilePath); arrCnName.Add("文件路径");
            arrColName.Add(convViewInfo.MainTabId); arrCnName.Add("主表ID");
            arrColName.Add(convViewInfo.ViewCnName); arrCnName.Add("视图中文名");
            arrColName.Add(convViewInfo.ViewGroupId); arrCnName.Add("界面组ID");
            arrColName.Add(convViewInfo.ViewGroupName); arrCnName.Add("界面组名称");
            arrColName.Add(convViewInfo.InSqlDsTypeId); arrCnName.Add("输入数据源类型");
            arrColName.Add(convViewInfo.OutSqlDsTypeId); arrCnName.Add("输出数据源类型");
            arrColName.Add(convViewInfo.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convViewInfo.GeneCodeDate); arrCnName.Add("生成代码日期");
            //arrColName.Add(convViewInfo.RegionNum); arrCnName.Add("RegionNum");
            arrColName.Add(convViewInfo.MainTabName); arrCnName.Add("MainTabName");
            arrColName.Add(convViewInfo.DetailTabName); arrCnName.Add("DetailTabName");
            arrColName.Add(convViewInfo.MainTabKeyFld); arrCnName.Add("MainTabKeyFld");
            arrColName.Add(convViewInfo.DetailTabKeyFld); arrCnName.Add("DetailTabKeyFld");
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;//当前界面
            objExportExcelSetENEx.TabName = vsTabName;//导出Excel所用的表或者视图
            objExportExcelSetENEx.ExportFileName = strFileName;//导出Excel的文件名
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;//当前用户Id
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//当前日期
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4Agc;//当前工程在生成代码系统中所用的工程Id,为了翻译字段名的中文名
            objExportExcelSetENEx.arrCnName = arrCnName;//中文字段名,也是Excel文件中的标题名
            objExportExcelSetENEx.arrColName = arrColName;//数据表的列名
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;//导出Excel的文件名
                arrCnName = objExportExcelSetENEx.arrCnName;//中文字段名,也是Excel文件中的标题名
                arrColName = objExportExcelSetENEx.arrColName;//数据表的列名
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
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
                objDT = clsvViewStyleBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditViewStyleRegion()
        {
            divList.Visible = false;
            tabEditViewStyleRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDispListAndEditRegion)
        /// </summary>
        private void DispViewStyleListRegion()
        {
            divList.Visible = true;
            tabEditViewStyleRegion.Visible = false;
        }
        #endregion 布局控制函数


        #region 权限处理函数

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
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
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
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
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
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
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceLevelProperty)
        /// </summary>
        protected string vsPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenLoginUserSession)
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
        ///if (pobjUser==null) 
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
        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    
                    
                    //{
                    
                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":

                            clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}