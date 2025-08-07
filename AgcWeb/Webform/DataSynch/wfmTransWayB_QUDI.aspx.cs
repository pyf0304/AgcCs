
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


///----------------------
///生成代码版本：2013.04.17.1
///生成日期：2014/06/07
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：数据同步
///模块英文名：DataSynch
///注意：1、需要数据底层（PubDataBase.dll）的版本：2013.11.06.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2013.11.08.1
///========================

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.BusinessLogicEx;

namespace AGC.Webform
{
    /// <summary>
    /// wfmTransWayB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmTransWayB_QUDI : CommWebPageBase
    {

        //生成有关的变量定义代码
        /// <summary>
        /// 当前操作的界面功能名称
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
        /// 当前操作的导出表名称
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
        /// 通过QueryString传递过来的UserId参数。这里是样例，大家可以参考这个样例。
        /// 姓名：
        /// 日期：
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
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                vsViewName = "转换方式维护";
                vsTabName = "TransWay";
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
                strSortTransWayBy = "TransWayId Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_TransWay();
                //3、设置表控件中字控件的ReadOnly属性，
                // 使之只读，因为在修改功能中关键字是不能被修改的。
                wucTransWayB1.SetKeyReadOnly(true);
                DispTransWayListRegion();
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
            this.gvTransWay.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_TransWay();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvTransWay_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvTransWay.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_TransWay();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　 在这里是把值传到表控件中
        /// </summary>
        /// <param name="strTransWayId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        /// 具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsTransWayEN objTransWayEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddTransWayRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddTransWayRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objTransWayEN = (clsTransWayEN)Session["objTransWayEN"];
                    UpdateTransWayRecordSave(objTransWayEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddTransWayRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTransWay, "chkCheckRec", "TransWayId");
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
                    string strTransWayId = strKeys[0];
                    clsTransWayBL.DelRecord(strTransWayId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TransWay();
        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvTransWay, "TransWayId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            string strTransWayId = strKeys[0];
            UpdateTransWayRecord(strTransWayId);
        }

        /// <summary>
        ///设置当前用户的Excel导出字段
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
                sbMsg.AppendFormat("在系统中没有界面为'{0}'", vsViewName);
                sbMsg.AppendFormat("，表名='{0}'", vsTabName);
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请先导出一次Excel，再不行可与管理员联系！", clsCommonSession.UserId);
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
        protected void gvTransWay_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortTransWayBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortTransWayBy = e.SortExpression + " Asc";
                BindGv_TransWay();
                return;
            }
            //检查原来是升序
            intIndex = strSortTransWayBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortTransWayBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortTransWayBy = e.SortExpression + " Desc";
            }
            BindGv_TransWay();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortTransWayBy
        {
            get
            {
                string sSortTransWayBy;
                sSortTransWayBy = (string)ViewState["SortTransWayBy"];
                if (sSortTransWayBy == null)
                {
                    sSortTransWayBy = "";
                }
                return sSortTransWayBy;
            }
            set
            {
                string sSortTransWayBy = value;
                ViewState.Add("SortTransWayBy", sSortTransWayBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvTransWay.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvTransWay.PageCount)
                {
                    this.gvTransWay.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_TransWay();
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
                    BindGv_TransWay();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvTransWay_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvTransWay, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvTransWay, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvTransWay_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortTransWayBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvTransWay.Columns.Count; i++)
                {
                    strSortEx = this.gvTransWay.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortTransWayBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortTransWayBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvTransWay_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strTransWayId = gvTransWay.DataKeys[e.RowIndex]["TransWayId"].ToString();
            DeleteTransWayRecord(strTransWayId);
        }
        ///
        protected void gvTransWay_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strTransWayId = gvTransWay.DataKeys[e.RowIndex]["TransWayId"].ToString();
            UpdateTransWayRecord(strTransWayId);
        }
        ///删除记录过程代码for C#
        protected void gvTransWay_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvTransWay.PageIndex = e.NewPageIndex;
                this.BindGv_TransWay();
            }
        }
        ///
        protected void btnCancelTransWayEdit_Click(object sender, EventArgs e)
        {
            DispTransWayListRegion();
        }

    }
    public partial class wfmTransWayB_QUDI : CommWebPageBase
    {
        protected void ShowData(string strTransWayId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strTransWayId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsTransWayBL.IsExist(strTransWayId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strTransWayId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsTransWayEN objTransWayEN = new clsTransWayEN(strTransWayId);
            //4、获取类对象的所有属性；
            try
            {
                clsTransWayBL.GetTransWay(ref objTransWayEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objTransWayEN", objTransWayEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromTransWayClass(objTransWayEN);
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
        protected string CombineTransWayCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTransWayIdq.Text.Trim() != "")
            {
                strWhereCond += " And TransWayId like '%" + this.txtTransWayIdq.Text.Trim() + "%'";
            }
            if (this.txtTransWayNameq.Text.Trim() != "")
            {
                strWhereCond += " And TransWayName like '%" + this.txtTransWayNameq.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_TransWay()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineTransWayCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsTransWayBL.GetDataTable_TransWay(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortTransWayBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvTransWay.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvTransWay.PageSize = 10;
            }
            this.gvTransWay.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvTransWay.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvTransWay.BottomPagerRow;
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
                lblAllPages.Text = this.gvTransWay.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvTransWay.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvTransWay.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvTransWay.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvTransWay.PageIndex == this.gvTransWay.PageCount - 1)
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
            gvTransWay.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        /// 如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjTransWayEN">表实体类对象</param>
        protected void GetDataFromTransWayClass(clsTransWayEN pobjTransWayEN)
        {
            wucTransWayB1.TransWayId = pobjTransWayEN.TransWayId;// 转换方式ID
            wucTransWayB1.TransWayName = pobjTransWayEN.TransWayName;// 转换方式名称
            wucTransWayB1.Memo = pobjTransWayEN.Memo;// 说明
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjTransWayEN">数据传输的目的类对象</param>
        protected void PutDataToTransWayClass(clsTransWayEN pobjTransWayEN)
        {
            pobjTransWayEN.TransWayId = wucTransWayB1.TransWayId;// 转换方式ID
            pobjTransWayEN.TransWayName = wucTransWayB1.TransWayName;// 转换方式名称
            pobjTransWayEN.Memo = wucTransWayB1.Memo;// 说明
        }

        ///生成的插入记录准备过程代码for C#
        protected void AddTransWayRecord()
        {
            wucTransWayB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelTransWayEdit.Text = "取消添加";
            //wucTransWayB1.TransWayId = clsTransWay.GetMaxStrId("TransWay","TransWayId", 2, "");
            DispEditTransWayRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddTransWayRecordSave()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsTransWayEN objTransWayEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucTransWayB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsTransWayEN objTransWayEN;	//定义对象
            objTransWayEN = new clsTransWayEN(wucTransWayB1.TransWayId);	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsTransWayBL.IsExist(objTransWayEN.TransWayId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToTransWayClass(objTransWayEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsTransWayBL.CheckPropertyNew(objTransWayEN);
                //6、把数据实体层的数据存贮到数据库中
                clsTransWayBL.AddNewRecordBySql2(objTransWayEN);
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
            BindGv_TransWay();
            DispTransWayListRegion();
            wucTransWayB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTransWayEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddTransWayRecordSaveV5()
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
            clsTransWayEN objTransWayEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucTransWayB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsTransWayEN objTransWayEN;	//定义对象
            objTransWayEN = new clsTransWayEN(wucTransWayB1.TransWayId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsTransWayBL.IsExist(objTransWayEN.TransWayId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToTransWayClass(objTransWayEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsTransWayBL.CheckPropertyNew(objTransWayEN);
                //6、把数据实体层的数据存贮到数据库中
                clsTransWayBL.AddNewRecordBySql2(objTransWayEN);
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
            BindGv_TransWay();
            DispTransWayListRegion();
            wucTransWayB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTransWayEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateTransWayRecord(string strTransWayId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strTransWayId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucTransWayB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelTransWayEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditTransWayRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateTransWayRecordSave(clsTransWayEN objTransWayEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucTransWayB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToTransWayClass(objTransWayEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsTransWayBL.CheckPropertyNew(objTransWayEN);
                //4、把数据实体层的数据存贮到数据库中
                clsTransWayBL.UpdateBySql2(objTransWayEN);
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
            BindGv_TransWay();
            DispTransWayListRegion();
            wucTransWayB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTransWayEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateTransWayRecordSaveV5(clsTransWayEN objTransWayEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucTransWayB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToTransWayClass(objTransWayEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsTransWayBL.CheckPropertyNew(objTransWayEN);
                //4、把数据实体层的数据存贮到数据库中
                clsTransWayBL.UpdateBySql2(objTransWayEN);
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
            BindGv_TransWay();
            DispTransWayListRegion();
            wucTransWayB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTransWayEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteTransWayRecord(string strTransWayId)
        {
            try
            {
                clsTransWayBL.DelRecord(strTransWayId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TransWay();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineTransWayCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "TransWay信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("TransWayId"); arrCnName.Add("转换方式ID");
            arrColName.Add("TransWayName"); arrCnName.Add("转换方式名称");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;//当前界面
            objExportExcelSetENEx.TabName = vsTabName;//导出Excel所用的表或者视图
            objExportExcelSetENEx.ExportFileName = strFileName;//导出Excel的文件名
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;//当前用户Id
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//当前日期
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4Agc;//当前工程在生成代码系统中所用的工程Id，为了翻译字段名的中文名
            objExportExcelSetENEx.arrCnName = arrCnName;//中文字段名，也是Excel文件中的标题名
            objExportExcelSetENEx.arrColName = arrColName;//数据表的列名
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;//导出Excel的文件名
                arrCnName = objExportExcelSetENEx.arrCnName;//中文字段名，也是Excel文件中的标题名
                arrColName = objExportExcelSetENEx.arrColName;//数据表的列名
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版，复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsTransWayBL.GetDataTable_TransWay(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007，可以换下面一条语句。
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
        private void DispEditTransWayRegion()
        {
            divList.Visible = false;
            tabEditTransWayRegion.Visible = true;
        }
        private void DispTransWayListRegion()
        {
            divList.Visible = true;
            tabEditTransWayRegion.Visible = false;
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