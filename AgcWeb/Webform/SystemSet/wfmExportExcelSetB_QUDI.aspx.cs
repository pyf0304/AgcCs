
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2013/04/04
///生成者：潘以锋
///工程名称：教育高地
///工程ID：0042
///模块中文名：系统管理
///模块英文名：SysManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.23.1
///========================
///生成查询，修改，删除，添加记录的控制层代码


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
using CommFunc4WebForm;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;


namespace AGC.Webform
{
    /// <summary>
    /// wfmExportExcelSetB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmExportExcelSetB_QUDI : CommWebPageBase
    {

        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
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

                //1、为下拉框设置数据源，绑定列表数据
                strSortExportExcelSetBy = "IdExportExcel4Users Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_ExportExcelSet();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucExportExcelSetB1.SetKeyReadOnly(true);
                DispExportExcelSetListRegion();
            }
        }

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvExportExcelSet.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_ExportExcelSet();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvExportExcelSet_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvExportExcelSet.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_ExportExcelSet();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strIdExportExcel4Users">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsExportExcelSetEN objExportExcelSetEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddExportExcelSetRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddExportExcelSetRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objExportExcelSetEN = (clsExportExcelSetEN)Session["objExportExcelSetEN"];
                    UpdateExportExcelSetRecordSave(objExportExcelSetEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddExportExcelSetRecord();
        }

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        ///删除当前被选记录
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvExportExcelSet, "chkCheckRec", "IdExportExcel4Users");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    string strIdExportExcel4Users = strKeys[0];
                    clsExportExcelSetBL.DelRecord(strIdExportExcel4Users);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ExportExcelSet();
        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvExportExcelSet, "IdExportExcel4Users");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            string strIdExportExcel4Users = strKeys[0];
            UpdateExportExcelSetRecord(strIdExportExcel4Users);
        }
        protected void gvExportExcelSet_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortExportExcelSetBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortExportExcelSetBy = e.SortExpression + " Asc";
                BindGv_ExportExcelSet();
                return;
            }
            //检查原来是升序
            intIndex = strSortExportExcelSetBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortExportExcelSetBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortExportExcelSetBy = e.SortExpression + " Desc";
            }
            BindGv_ExportExcelSet();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortExportExcelSetBy
        {
            get
            {
                string sSortExportExcelSetBy;
                sSortExportExcelSetBy = (string)ViewState["SortExportExcelSetBy"];
                if (sSortExportExcelSetBy == null)
                {
                    sSortExportExcelSetBy = "";
                }
                return sSortExportExcelSetBy;
            }
            set
            {
                string sSortExportExcelSetBy = value;
                ViewState.Add("SortExportExcelSetBy", sSortExportExcelSetBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvExportExcelSet.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvExportExcelSet.PageCount)
                {
                    this.gvExportExcelSet.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_ExportExcelSet();
            }
        }


        ///生成的改变GridView中每页记录数的下拉框相关函数
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
                    BindGv_ExportExcelSet();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvExportExcelSet_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvExportExcelSet, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvExportExcelSet, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvExportExcelSet_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortExportExcelSetBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvExportExcelSet.Columns.Count; i++)
                {
                    strSortEx = this.gvExportExcelSet.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortExportExcelSetBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortExportExcelSetBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvExportExcelSet_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strIdExportExcel4Users = gvExportExcelSet.DataKeys[e.RowIndex]["IdExportExcel4Users"].ToString();
            DeleteExportExcelSetRecord(strIdExportExcel4Users);
        }
        ///
        protected void gvExportExcelSet_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strIdExportExcel4Users = gvExportExcelSet.DataKeys[e.RowIndex]["IdExportExcel4Users"].ToString();
            UpdateExportExcelSetRecord(strIdExportExcel4Users);
        }
        ///删除记录过程代码for C#
        protected void gvExportExcelSet_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvExportExcelSet.PageIndex = e.NewPageIndex;
                this.BindGv_ExportExcelSet();
            }
        }
        ///
        protected void btnCancelExportExcelSetEdit_Click(object sender, EventArgs e)
        {
            DispExportExcelSetListRegion();
        }

        protected void btnEditExportExcel4User_Click(object sender, EventArgs e)
        {
            string strIdExportExcel4Users = clsCommForWebForm.GetFirstCheckedItemFromGv(gvExportExcelSet);
            if (strIdExportExcel4Users == null || strIdExportExcel4Users.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            //if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            //{
            //    StringBuilder sbMsg = new StringBuilder();
            //    sbMsg.AppendFormat("在系统中没有界面为'{0}'", vsViewName);
            //    sbMsg.AppendFormat("，表名='{0}'", "vMicroteachAppraise");
            //    sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请先导出一次Excel，再不行可与管理员联系！", clsCommonSession.UserId);
            //    clsCommonJsFunc.Alert(this, sbMsg.ToString());
            //    return;
            //}

            StringBuilder sbScript = new StringBuilder();

            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");
            //http://59.78.147.4//avcon//login.php?userid=" + clsCommonSession.UserId + "&password=" + Password + 

            Response.Write(sbScript.ToString());

            //
            //Response.Redirect(string.Format("wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users));

        }

    }
    public partial class wfmExportExcelSetB_QUDI : CommWebPageBase
    {
        protected void ShowData(string strIdExportExcel4Users)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strIdExportExcel4Users == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsExportExcelSetBL.IsExist(strIdExportExcel4Users) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strIdExportExcel4Users + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN(strIdExportExcel4Users);
            //4、获取类对象的所有属性；
            try
            {
                clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objExportExcelSetEN", objExportExcelSetEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromExportExcelSetClass(objExportExcelSetEN);
        }

        //生成权限等级的属性
        protected string strPotenceLevel
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
        /// 登录的用户ID，用于检查用户权限
        /// </summary>
        protected string UserId
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




        /// <summary>
        /// 专门用于记录GridView中的每页记录数
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


        /// <summary>
        /// 错误信息的Session属性，该Session传递给显示出错页面，显示相应的错误内容。
        /// </summary>
        protected string ErrMessage
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


        //生成返回链接串的Session属性
        /// <summary>
        /// 返回链接串的Session属性，该Session用于告诉出错页面，哪一个页面是需要返回的页面。
        /// </summary>
        protected string BackErrPageLinkStr
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

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineExportExcelSetCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " And ViewName like '%" + this.txtViewNameq.Text.Trim() + "%'";
            }
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " And TabName like '%" + this.txtTabNameq.Text.Trim() + "%'";
            }
            if (this.txtUserIDq.Text.Trim() != "")
            {
                strWhereCond += " And UserID like '%" + this.txtUserIDq.Text.Trim() + "%'";
            }
            if (this.txtUserNameq.Text.Trim() != "")
            {
                strWhereCond += " And UserName like '%" + this.txtUserNameq.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_ExportExcelSet()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineExportExcelSetCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvExportExcelSetBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortExportExcelSetBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvExportExcelSet.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvExportExcelSet.PageSize = 10;
            }
            this.gvExportExcelSet.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvExportExcelSet.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvExportExcelSet.BottomPagerRow;
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
                lblAllPages.Text = this.gvExportExcelSet.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvExportExcelSet.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvExportExcelSet.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvExportExcelSet.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvExportExcelSet.PageIndex == this.gvExportExcelSet.PageCount - 1)
                {
                     clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
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
            gvExportExcelSet.BottomPagerRow.Visible = true;
        }


     
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjExportExcelSetEN">表实体类对象</param>
        protected void GetDataFromExportExcelSetClass(clsExportExcelSetEN pobjExportExcelSetEN)
        {
            wucExportExcelSetB1.IdExportExcel4Users = pobjExportExcelSetEN.IdExportExcel4Users;//    导出Excel用户字段流水号
            wucExportExcelSetB1.ViewName = pobjExportExcelSetEN.ViewName;//    界面名称
            wucExportExcelSetB1.TabName = pobjExportExcelSetEN.TabName;//    表名
            wucExportExcelSetB1.UserID = pobjExportExcelSetEN.UserId;//    用户ID
            wucExportExcelSetB1.IsDefaultUser = pobjExportExcelSetEN.IsDefaultUser;//    是否缺省用户
            wucExportExcelSetB1.ExportFileName = pobjExportExcelSetEN.ExportFileName;//    导出文件名

            wucExportExcelSetB1.Memo = pobjExportExcelSetEN.Memo;//    备注
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjExportExcelSetEN">数据传输的目的类对象</param>
        protected void PutDataToExportExcelSetClass(clsExportExcelSetEN pobjExportExcelSetEN)
        {
            pobjExportExcelSetEN.IdExportExcel4Users = wucExportExcelSetB1.IdExportExcel4Users;//    导出Excel用户字段流水号
            pobjExportExcelSetEN.ViewName = wucExportExcelSetB1.ViewName;//    界面名称
            pobjExportExcelSetEN.TabName = wucExportExcelSetB1.TabName;//    表名
            pobjExportExcelSetEN.UserId = wucExportExcelSetB1.UserID;//    用户ID
            pobjExportExcelSetEN.IsDefaultUser = wucExportExcelSetB1.IsDefaultUser;//    是否缺省用户
            pobjExportExcelSetEN.ExportFileName = wucExportExcelSetB1.ExportFileName;//    导出文件名
            pobjExportExcelSetEN.UpdDate = clsDateTime.getTodayStr(0);//    修改日期
            pobjExportExcelSetEN.UpdUserId = clsCommonSession.UserId;//    修改用户Id
            pobjExportExcelSetEN.Memo = wucExportExcelSetB1.Memo;//    备注
        }

        ///生成的插入记录准备过程代码for C#
        protected void AddExportExcelSetRecord()
        {
            wucExportExcelSetB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelExportExcelSetEdit.Text = "取消添加";
            //wucExportExcelSetB1.IdExportExcel4Users = clsExportExcelSet.GetMaxStrId("ExportExcelSet","IdExportExcel4Users", 8, "");
            DispEditExportExcelSetRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddExportExcelSetRecordSave()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            ///3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsExportExcelSetEN objExportExcelSetEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucExportExcelSetB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsExportExcelSetEN objExportExcelSetEN;	//定义对象
            objExportExcelSetEN = new clsExportExcelSetEN(wucExportExcelSetB1.IdExportExcel4Users);	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToExportExcelSetClass(objExportExcelSetEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsExportExcelSetBL.CheckPropertyNew(objExportExcelSetEN);
                //6、把数据实体层的数据存贮到数据库中
                clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetEN);
            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_ExportExcelSet();
            DispExportExcelSetListRegion();
            wucExportExcelSetB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelExportExcelSetEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddExportExcelSetRecordSaveV5()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsExportExcelSetEN objExportExcelSetEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucExportExcelSetB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsExportExcelSetEN objExportExcelSetEN;	//定义对象
            objExportExcelSetEN = new clsExportExcelSetEN(wucExportExcelSetB1.IdExportExcel4Users);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToExportExcelSetClass(objExportExcelSetEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsExportExcelSetBL.CheckPropertyNew(objExportExcelSetEN);
                //6、把数据实体层的数据存贮到数据库中
                clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_ExportExcelSet();
            DispExportExcelSetListRegion();
            wucExportExcelSetB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelExportExcelSetEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateExportExcelSetRecord(string strIdExportExcel4Users)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strIdExportExcel4Users);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucExportExcelSetB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelExportExcelSetEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditExportExcelSetRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateExportExcelSetRecordSave(clsExportExcelSetEN objExportExcelSetEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            ///3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucExportExcelSetB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToExportExcelSetClass(objExportExcelSetEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsExportExcelSetBL.CheckPropertyNew(objExportExcelSetEN);
                //4、把数据实体层的数据存贮到数据库中
                clsExportExcelSetBL.UpdateBySql2(objExportExcelSetEN);
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
            //5、把修改后的内容显示在DATAGRID中
            BindGv_ExportExcelSet();
            DispExportExcelSetListRegion();
            wucExportExcelSetB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelExportExcelSetEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateExportExcelSetRecordSaveV5(clsExportExcelSetEN objExportExcelSetEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucExportExcelSetB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToExportExcelSetClass(objExportExcelSetEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsExportExcelSetBL.CheckPropertyNew(objExportExcelSetEN);
                //4、把数据实体层的数据存贮到数据库中
                clsExportExcelSetBL.UpdateBySql2(objExportExcelSetEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_ExportExcelSet();
            DispExportExcelSetListRegion();
            wucExportExcelSetB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelExportExcelSetEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteExportExcelSetRecord(string strIdExportExcel4Users)
        {
            try
            {
                clsExportExcelSetBL.DelRecord(strIdExportExcel4Users);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_ExportExcelSet();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineExportExcelSetCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "ExportExcelSet信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("IdExportExcel4Users"); arrCnName.Add("导出Excel用户字段流水号");
            arrColName.Add("ViewName"); arrCnName.Add("界面名称");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("IsDefaultUser"); arrCnName.Add("是否缺省用户");
            arrColName.Add("UserID"); arrCnName.Add("用户ID");
            arrColName.Add("UserName"); arrCnName.Add("用户名");
            arrColName.Add("ExportFileName"); arrCnName.Add("导出文件名");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("Memo"); arrCnName.Add("备注");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvExportExcelSetBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditExportExcelSetRegion()
        {
            tabExportExcelSetGridView.Visible = false;
            tabEditExportExcelSetRegion.Visible = true;
        }
        private void DispExportExcelSetListRegion()
        {
            tabExportExcelSetGridView.Visible = true;
            tabEditExportExcelSetRegion.Visible = false;
        }
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