
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucCMFunctionB
表名:CMFunction
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:50:51
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using CommFunc4WebForm;
    using System.Collections.Generic;
    using BusinessLogicEx;
    using System.Text;
    
    using System.Linq;

    /// <summary>
    ///		wucCMFunctionB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucvCMFunction4GV : System.Web.UI.UserControl
    {
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }

        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            ////把GridView的当前页索引设置为0,即第1页。
            ////当单击查询时,首先显示的是表记录内容的第一部分内容。
            //this.gvCMFunction.PageIndex = 0;
            ////把表记录的内容显示在GridView中
            //BindGv_CMFunction();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// </summary>
        public void BindGv_CMFunction(string strWhereCond)
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            int intRecCount = 0;
            int intPageCount = 0;
            System.Data.DataTable objDT = null;
            try
            {
                vsWhereCond = strWhereCond;
                intRecCount = clsvCMFunctionBL.GetRecCountByCond(vsWhereCond);
                vsRecCount = intRecCount;
                intPageCount = GetPageCount(intRecCount, vsPageSize);
                vsPageCount = intPageCount;
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvCMFunctionBL.GetDataTableByPager(vsPageIndex, vsPageSize, strWhereCond, vsSortCMFunctionBy);
                objDT.Columns.Add("ClassName");
                foreach (DataRow objRow in objDT.Rows)
                {
                    objRow["ClassName"] = "";
                }
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WucL000001)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortCMFunctionBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                             ///设置GridView中每页的记录数
            if (vsPageSize > 0)
            {
                int intPageSize = vsPageSize;
                gvCMFunction.PageSize = intPageSize;
            }
            else
            {
                vsPageSize = 15;
                gvCMFunction.PageSize = vsPageSize;
            }
            this.gvCMFunction.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvCMFunction.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvCMFunction.BottomPagerRow;
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
                lblRecCount.Text = intRecCount.ToString();
                //当前页数
                lblAllPages.Text = intPageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = vsPageIndex.ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = vsPageIndex.ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (vsPageIndex == 1)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (vsPageIndex == intPageCount)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
                //设置分页器中每页记录数的下拉框的值
                if (vsPageSize > 0)
                {
                    ddlPagerRecCount.Text = vsPageSize.ToString();
                }
                else
                {
                    vsPageSize = 15;
                    ddlPagerRecCount.Text = vsPageSize.ToString();
                }
            }
            gvCMFunction.BottomPagerRow.Visible = true;
        }



        /// <summary>
        /// 事件函数:生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理:跳转到GridView的某一数。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvCMFunction.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvCMFunction.PageCount)
                {
                    this.gvCMFunction.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_CMFunction(vsWhereCond);
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
                    BindGv_CMFunction(vsWhereCond);
                }
            }
        }

        /// <summary>
        /// 事件函数:在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCommand)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvCMFunction_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvCMFunction, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvCMFunction, false);
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
        protected void gvCMFunction_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortCMFunctionBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvCMFunction.Columns.Count; i++)
                {
                    strSortEx = this.gvCMFunction.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortCMFunctionBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
                        intIndex = vsSortCMFunctionBy.IndexOf("Asc");
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
        protected void gvCMFunction_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView,使之内容更新,变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                gvCMFunction.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView,使之内容更新,变化到新的页
                this.BindGv_CMFunction(vsWhereCond);
            }
        }


        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
        /// </summary>
        public string PageSize
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

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsWhereCond
        {
            get
            {
                string sWhereCond;
                sWhereCond = (string)ViewState["WhereCond"];
                if (sWhereCond == null)
                {
                    sWhereCond = "";
                }
                return sWhereCond;
            }
            set
            {
                string sWhereCond = value;
                ViewState.Add("WhereCond", sWhereCond);
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
        protected void gvCMFunction_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortCMFunctionBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortCMFunctionBy = e.SortExpression + " Asc";
                BindGv_CMFunction(vsWhereCond);
                return;
            }
            //检查原来是升序
            intIndex = vsSortCMFunctionBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                vsSortCMFunctionBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                vsSortCMFunctionBy = e.SortExpression + " Desc";
            }
            BindGv_CMFunction(vsWhereCond);
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
        /// </summary>
        protected string vsSortCMFunctionBy
        {
            get
            {
                string sSortCMFunctionBy;
                sSortCMFunctionBy = (string)ViewState["SortCMFunctionBy"];
                if (sSortCMFunctionBy == null)
                {
                    sSortCMFunctionBy = "";
                }
                return sSortCMFunctionBy;
            }
            set
            {
                string sSortCMFunctionBy = value;
                ViewState.Add("SortCMFunctionBy", sSortCMFunctionBy);
            }
        }
        public void SetSortBy(string strSortBy)
        {
            vsSortCMFunctionBy = strSortBy;
        }
        #endregion 排序相关函数
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


        /// <summary>
        ///从列表中获取选择的第一个关键字
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetFirstCheckedKeyFromGv)
        /// </summary>/// <returns>返回选择的第一个关键字</returns>
        public string GetFirstCheckedKeyFromGv()
        {
            List<string> lstCmFunctionId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvCMFunction, conCMFunction.CmFunctionId);
            if (lstCmFunctionId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "(errid:WebI000015)没有选择记录,请选择有效的表记录!");
                return "";
            }

            //1、显示该关键字的数据让用户修改该关键字记录；
            string strCmFunctionId = lstCmFunctionId[0];
            return strCmFunctionId;
        }
        /// <summary>
        ///从列表中获取所有选择的关键字
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetAllCheckedKeysFromGv)
        /// </summary>/// <returns>返回所有选择的关键字列表</returns>
        public List<string> GetAllCheckedKeysFromGv()
        {
            List<string> lstCmFunctionId = clsCommForWebForm.GetAllCheckedItemFromGv(gvCMFunction, "chkCheckRec", conCMFunction.CmFunctionId);
            if (lstCmFunctionId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "(errid:WebI000016)没有选择记录,请选择有效的表记录!");
                return null;
            }
            return lstCmFunctionId;
        }
        public bool SetCheckedItemForGv(string strCmFunctionId)
        {
            clsCommForWebForm.SetCheckedItemForGv(gvCMFunction, 1, strCmFunctionId);
            return true;
        }
        public int PageIndex
        {
            set
            {
                this.gvCMFunction.PageIndex = value;
            }
        }
        public void SetVisible(bool bolVisible)
        {
            gvCMFunction.Visible = bolVisible;
        }
        /// <summary>
        /// 事件函数:在GridView中，进行行删除(RowDeleting)
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvCMFunction_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strCmFunctionId = gvCMFunction.DataKeys[e.RowIndex]["CmFunctionId"].ToString();
            DeleteCMFunctionRecord(strCmFunctionId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "strCmFunctionId">给定关键字</param>
        protected void DeleteCMFunctionRecord(string strCmFunctionId)
        {
            try
            {
                clsCMFunctionBL.DelRecord(strCmFunctionId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            string strWhereCond = vsWhereCond;
            BindGv_CMFunction(vsWhereCond);
        }

        ///
        protected void gvCMFunction_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strCmFunctionId = gvCMFunction.DataKeys[e.RowIndex]["CmFunctionId"].ToString();
            UpdateCMFunctionRecord(strCmFunctionId);
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateCMFunctionRecord(string strCmFunctionId)
        {
            ////操作步骤:(总共2步)
            ////1、显示该关键字记录的内容在界面上；
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；

            ////1、显示该关键字记录的内容在界面上；
            //ShowData(strCmFunctionId);
            ////2、清空提示信息的内容,同时使<确定修改>按钮可用；
            //btnOKUpd.Enabled = true;
            //wucCMFunctionB1.SetKeyReadOnly(true);
            //btnOKUpd.Text = "确认修改";
            //btnCancelCMFunctionEdit.Text = "取消修改";
            //lblMsgEdit.Text = "";
            //DispEditCMFunctionRegion();
        }
        /// <summary>
        /// 设置GridView可视性
        /// </summary>
        /// <param name="strColumnName">列名 or 字段名</param>
        /// <param name="bolIsVisible">是否可见</param>
        public void SetGvVisibility(string strColumnName, bool bolIsVisible)
        {
            clsCommForWebForm.SetGvVisibility(gvCMFunction, strColumnName, bolIsVisible);
        }

        /// <summary>
        /// ViewState属性:当前操作的导出表名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
        /// </summary>
        protected int vsApplicationTypeId
        {
            get
            {
                int sApplicationTypeId;
                sApplicationTypeId = (int)ViewState["ApplicationTypeId"];
                if (ViewState["ApplicationTypeId"] == null)
                {
                    sApplicationTypeId = 0;
                }
                return sApplicationTypeId;
            }
            set
            {
                int sApplicationTypeId = value;
                ViewState.Add("ApplicationTypeId", sApplicationTypeId);
            }
        }

        protected void gvCMFunction_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView drv = (DataRowView)e.Row.DataItem;
                //DataRow objDR = (DataRow)e.Row.DataItem ;

                clsvCMFunctionEN objCurr = clsvCMFunctionBL.GetObjByDataRow_S(drv);//.DataItem
                //if (string.IsNullOrEmpty(objCurr.CodeTypeId) == false)
                //{
                //    //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
                //    //e.Row.Attributes["class"] = "text-muted bg-info";
                //    //e.Row.CssClass = "text-muted bg-info";
                //    clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCurr.ProgLangTypeId);
                //    clsvwf_StepPointRelaEN objvwf_StepPointRela = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndTabKeyIdCache(clsPubVar.CurrWorkFlowId, objCurr.CodeTypeId);
                    //if (objvwf_StepPointRela != null)
                    //{
                    //    e.Row.Cells[intIndex4Key].Text = string.Format("{2}-{0}({1})", 
                    //        objCurr.CodeTypeName, objProgLangTypeEN.ProgLangTypeSimName, objvwf_StepPointRela.LevelNo);
                    //}
                    //else
                    //{
                    //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}({1})", objCurr.CodeTypeName, objProgLangTypeEN.ProgLangTypeSimName);
                    //}
                    //if (objCurr.ClsName.Contains(objCurr.TabName) == false)
                    //{
                    //    intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(gvCMFunction,
                    //       clsvCMFunctionEN.con_ClassName);
                    //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}({1})", objCurr.ClsName, objCurr.TabName);
                    //}
                //}
                //if (string.IsNullOrEmpty(objCurr.ReturnTypeNameCustom) == false)
                //{
                //    //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
                //    //e.Row.Attributes["class"] = "text-muted bg-info";
                //    //e.Row.CssClass = "text-muted bg-info";
                //    int intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(gvCMFunction,
                //       clsvCMFunctionEN.con_ReturnTypeName);
                //    e.Row.Cells[intIndex4Key].Text = string.Format("{0}", objCurr.ReturnTypeNameCustom);
                //}
                if (objCurr.ParaNum>0 && string.IsNullOrEmpty(objCurr.ProgLangTypeId) == false)
                {
                    //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
                    //e.Row.Attributes["class"] = "text-muted bg-info";
                    //e.Row.CssClass = "text-muted bg-info";
                    int intIndex4Key = clsCommForWebForm.GetIndexByDataField4GridView(gvCMFunction,
                       "FuncParaLst");
                    IEnumerable<clsCMFuncParaRelaEN> arrFuncParaRela = clsCMFuncParaRelaBLEx.GetObjListByCmFunctionIdCacheEx(objCurr.CmFunctionId, clsPubVar.CurrSelPrjId);
                    
                    if (arrFuncParaRela != null)
                    {
                        arrFuncParaRela = arrFuncParaRela.OrderBy(x=>x.OrderNum);
                        StringBuilder sbParaList = new StringBuilder();
                        foreach (clsCMFuncParaRelaEN objInFor in arrFuncParaRela)
                        {
                            clsCMFuncParaEN objCMFuncPara = clsCMFuncParaBL.GetObjByCmFuncParaIdCache(objInFor.CmFuncParaId);
                   
                            string strParameterType = objCMFuncPara.GetParaTypeName4CM(objCurr.ProgLangTypeId); 
                            switch (objCurr.ProgLangTypeId)
                            {
                                case enumProgLangType.CSharp_01:

                                    if (strParameterType == "Int32") strParameterType = "int";
                                    break;
                            }
                            sbParaList.AppendFormat("{0} {1}, ", strParameterType, objCMFuncPara.ParaName);

                        }
                        sbParaList.Remove(sbParaList.Length - 2, 2);
                        e.Row.Cells[intIndex4Key].Text = string.Format("{0}", sbParaList.ToString());
                    }
                }
            }
        }
       
        protected string seIsShowGCDiv
        {
            get
            {
                string sIsShowGCDiv;
                sIsShowGCDiv = (string)Session["IsShowGCDiv"];
                if (sIsShowGCDiv == null)
                {
                    sIsShowGCDiv = "";
                }
                return sIsShowGCDiv;
            }
            set
            {
                string sIsShowGCDiv = value;
                Session.Add("IsShowGCDiv", sIsShowGCDiv);
            }
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenPageSizeViewState)
        /// </summary>
        public int vsPageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                    return 15;
                }
                return int.Parse(strPageSize);
            }
            set
            {
                string strPageSize = value.ToString();
                ViewState.Add("PageSize", strPageSize);
            }
        }



        /// <summary>
        /// 设置GridView中的页序号
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageIndex)
        /// </summary>
        public int vsPageIndex
        {
            get
            {
                string strPageIndex;
                strPageIndex = (string)ViewState["PageIndex"];
                if (strPageIndex == null)
                {
                    strPageIndex = "";
                    return 1;
                }
                return int.Parse(strPageIndex);
            }
            set
            {
                string strPageIndex = value.ToString();
                ViewState.Add("PageIndex", strPageIndex);
            }
        }



        /// <summary>
        /// 设置GridView中的总页数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageCount)
        /// </summary>
        public int vsPageCount
        {
            get
            {
                string strPageCount;
                strPageCount = (string)ViewState["PageCount"];
                if (strPageCount == null)
                {
                    strPageCount = "";
                    return 1;
                }
                return int.Parse(strPageCount);
            }
            set
            {
                string strPageCount = value.ToString();
                ViewState.Add("PageCount", strPageCount);
            }
        }

        /// <summary>
        /// 设置GridView中的总页数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_RecCount)
        /// </summary>
        public int vsRecCount
        {
            get
            {
                string strRecCount;
                strRecCount = (string)ViewState["RecCount"];
                if (strRecCount == null)
                {
                    strRecCount = "";
                    return 1;
                }
                return int.Parse(strRecCount);
            }
            set
            {
                string strRecCount = value.ToString();
                ViewState.Add("RecCount", strRecCount);
            }
        }



        /// <summary>
        /// 函数功能:计算当前页数，根据记录数和每页记录数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenGetPageCount)
        /// </summary>
        /// <param name = "intRecCount">总记录数</param>
        /// <param name = "intPageSize">每页记录数</param>
        private int GetPageCount(int intRecCount, int intPageSize)
        {
            if (intRecCount == 0) return 0;
            int intPageCount = intRecCount / intPageSize;
            if (intRecCount % intPageSize == 0) return intPageCount;
            return intPageCount + 1;
        }


    }
}