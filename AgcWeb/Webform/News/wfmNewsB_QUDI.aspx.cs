
///----------------------
///生成代码版本：2013.04.17.1
///生成日期：2013/05/30
///生成者：李玉龙
///工程名称：泰泽公司网页
///工程ID：0025
///模块中文名：泰泽教育
///模块英文名：tzedu
///注意：1、需要数据底层（PubDataBase.dll）的版本：2013.04.05.3
///       2、需要公共函数层（TzPubFunction.dll）的版本：2013.03.18.1
///========================
///生成查询，修改，删除，添加记录的控制层代码

///生成控制层的控件变量名列表
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
using AGC.BusinessLogic;

using com.taishsoft.datetime;
using AGC.FunClass;
using AGC.BusinessLogicEx;

namespace CompanyPage.Webform
{
    /// <summary>
    /// wfmNewsB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmNewsB_QUDI : System.Web.UI.Page
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

                vsViewName = "咨询表维护";
                vsTabName = "vNews";
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
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
                //clsCommonSession.UserId = "lyl";
                //clsCommonSession.UserName = "李玉龙";
                clsCommonSession.UserRightsId = "3";

                CheckLoginWorking();

                //1、为下拉框设置数据源，绑定列表数据
                wucNewsB1.SetDdl_NewsTypeId();
                BindDdl_NewsTypeId(ddlNewsTypeIdq);
                //strSortNewsBy = "NewsTitle Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_News();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                DispNewsListRegion();
            }
        }


        /// <summary>
        /// 权限管理
        /// </summary>
        protected void CheckLoginWorking()
        {
            if (clsCommonSession.UserId == "")
            {
                clsCommonSession.seErrMessage = "1";
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            else
            {
                //clsCommonSession clsCommonSession = new clsCommonSession();
                if (!string.IsNullOrEmpty(clsCommonSession.UserRightsId))
                {
                    //操作员
                    if (clsCommonSession.UserRightsId == "1")
                    {
                        this.btnDelete4Gv.Visible = false;
                        //this.btnSetExportExcel4User.Visible = false;
                        this.btnUpdate4Gv.Visible = false;
                        //this.delete.Visible = false;
                        //this.edit.Visible = false;
                        //this.tool.Visible = false;
                    }
                    //管理员
                    else if (clsCommonSession.UserRightsId == "2")
                    {
                        this.btnDelete4Gv.Visible = false;
                        //this.delete.Visible = false;
                    }
                    //超级管理员
                    else if (clsCommonSession.UserRightsId == "3")
                    {
                        
                    }
                }
              
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
            this.gvNews.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_News();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvNews_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvNews.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_News();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="intId_News">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsNewsEN objNewsEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddNewsRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddNewsRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objNewsEN = (clsNewsEN)Session["objNewsEN"];
                    UpdateNewsRecordSave(objNewsEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddNewsRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvNews, "chkCheckRec", "Id_News");
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
                    int intId_News = int.Parse(strKeys[0]);
                    clsNewsBL.DelRecord(intId_News);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_News();
        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvNews, "Id_News");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            int intId_News = int.Parse(strKeys[0]);
            UpdateNewsRecord(intId_News);
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
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请与管理员联系！", clsCommonSession.UserId);
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
            //            Response.Write(sbScript.ToString());
        }
        protected void gvNews_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortNewsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortNewsBy = e.SortExpression + " Asc";
                BindGv_News();
                return;
            }
            //检查原来是升序
            intIndex = strSortNewsBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortNewsBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortNewsBy = e.SortExpression + " Desc";
            }
            BindGv_News();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortNewsBy
        {
            get
            {
                string sSortNewsBy;
                sSortNewsBy = (string)ViewState["SortNewsBy"];
                if (sSortNewsBy == null)
                {
                    sSortNewsBy = "";
                }
                return sSortNewsBy;
            }
            set
            {
                string sSortNewsBy = value;
                ViewState.Add("SortNewsBy", sSortNewsBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvNews.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvNews.PageCount)
                {
                    this.gvNews.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_News();
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
                    BindGv_News();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvNews_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvNews, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvNews, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }

            if (e.CommandName == "ibtnTop")
            {
                GridViewRow drv = ((GridViewRow)(((ImageButton)(e.CommandSource)).Parent.Parent)); //此得出的值是表示那行被选中的索引值
                int intid_New = Convert.ToInt32(gvNews.DataKeys[drv.RowIndex].Value); //此获取的值为GridView中绑定数据库中的主键值
                clsNewsEN objNews = new clsNewsEN();
                objNews.Id_News = intid_New;
                clsNewsBL.GetNews(ref objNews);
                bool isTop = objNews.IsTop;

                if (isTop == true)
                {
                    clsNewsBL.UpdateBySql2(GetNewsEN((int)intid_New, false));
                }
                else
                {
                    clsNewsBL.UpdateBySql2(GetNewsEN((int)intid_New, true));
                }
                BindGv_News();
            }

        }


        private static clsNewsEN GetNewsEN(int intid_New, bool IsTop)
        {
            clsNewsEN objNews = new clsNewsEN();
            objNews.Id_News = intid_New;
            objNews.IsTop = IsTop;
            return objNews;
        }
        ///删除记录过程代码for C#
        protected void gvNews_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortNewsBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvNews.Columns.Count; i++)
                {
                    strSortEx = this.gvNews.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortNewsBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortNewsBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvNews_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strid_News = gvNews.DataKeys[e.RowIndex]["Id_News"].ToString();
            int intId_News = int.Parse(strid_News);
            DeleteNewsRecord(intId_News);
        }
        ///
        protected void gvNews_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strid_News = gvNews.DataKeys[e.RowIndex]["Id_News"].ToString();
            int intId_News = int.Parse(strid_News);
            UpdateNewsRecord(intId_News);
        }
        ///删除记录过程代码for C#
        protected void gvNews_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvNews.PageIndex = e.NewPageIndex;
                this.BindGv_News();
            }
        }
        ///
        protected void btnCancelNewsEdit_Click(object sender, EventArgs e)
        {
            DispNewsListRegion();
        }

    }
    public partial class wfmNewsB_QUDI : System.Web.UI.Page
    {
        protected void ShowData(int intId_News)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (intId_News == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsNewsBL.IsExist(intId_News) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + intId_News + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsNewsEN objNewsEN = new clsNewsEN(intId_News);
            //4、获取类对象的所有属性；
            try
            {
                clsNewsBL.GetNews(ref objNewsEN);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objNewsEN", objNewsEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromNewsClass(objNewsEN);
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


        //生成登录用户的用户名Session
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
        ///protected clsUsers objUser
        ///{
        ///get
        ///{
        ///clsUsers pobjUser;
        ///pobjUser = (clsUsers)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsers pobjUser = value;
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
        protected string CombineNewsCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtNewsTitleq.Text.Trim() != "")
            {
                strWhereCond += " And NewsTitle like '%" + this.txtNewsTitleq.Text.Trim() + "%'";
            }
            if (this.ddlNewsTypeIdq.SelectedValue != "" && this.ddlNewsTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And NewsTypeId='" + this.ddlNewsTypeIdq.SelectedValue + "'";
            }
            if (this.txtEditPeopleq.Text.Trim() != "")
            {
                strWhereCond += " And EditPeople like '%" + this.txtEditPeopleq.Text.Trim() + "%'";
            }
            if (this.txtEditTimeq.Text.Trim() != "")
            {
                strWhereCond += " And EditTime like '%" + this.txtEditTimeq.Text.Trim() + "%'";
            }
            strWhereCond += " order by IsTop desc,  EditTime desc";
            
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_News()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineNewsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvNewsBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortNewsBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvNews.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvNews.PageSize = 10;
            }
            this.gvNews.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvNews.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvNews.BottomPagerRow;
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
                lblAllPages.Text = this.gvNews.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvNews.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvNews.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvNews.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvNews.PageIndex == this.gvNews.PageCount - 1)
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
            gvNews.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjNewsEN">表实体类对象</param>
        protected void GetDataFromNewsClass(clsNewsEN pobjNewsEN)
        {
            wucNewsB1.NewsTitle = pobjNewsEN.NewsTitle;//    标题
            wucNewsB1.NewsTypeId = pobjNewsEN.NewsTypeId;//    资讯类型
            wucNewsB1.IsTop = pobjNewsEN.IsTop;//    是否置顶
            wucNewsB1.ImgPath = pobjNewsEN.ImgPath;//    图片路径
            wucNewsB1.NewsContent = pobjNewsEN.NewsContent;//    内容
            wucNewsB1.EditPeople = clsCommonSession.UserId;//    编辑人员
            wucNewsB1.EditTime = DateTime.Now.ToString("yyyy-MM-dd"); //    编辑时间
            wucNewsB1.Source = pobjNewsEN.Source;//    来源
            wucNewsB1.Views = pobjNewsEN.Views ?? 0;//    浏览量
            wucNewsB1.Memo = pobjNewsEN.Memo;//    备注
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjNewsEN">数据传输的目的类对象</param>
        protected void PutDataToNewsClass(clsNewsEN pobjNewsEN)
        {
            pobjNewsEN.NewsTitle = wucNewsB1.NewsTitle;//    标题
            pobjNewsEN.NewsTypeId = wucNewsB1.NewsTypeId;//    资讯类型
            pobjNewsEN.IsTop = wucNewsB1.IsTop;//    是否置顶
            pobjNewsEN.ImgPath = wucNewsB1.ImgPath;//    图片路径
            pobjNewsEN.NewsContent = wucNewsB1.NewsContent;//    内容
            pobjNewsEN.EditPeople = wucNewsB1.EditPeople;//    编辑人员
            pobjNewsEN.EditTime = wucNewsB1.EditTime;//    编辑时间
            pobjNewsEN.Source = wucNewsB1.Source;//    来源
            pobjNewsEN.Views = wucNewsB1.Views;//    浏览量
            pobjNewsEN.Memo = wucNewsB1.Memo;//    备注



            pobjNewsEN.Memo = wucNewsB1.Memo;//    备注
            pobjNewsEN.Memo += clsCommonSession.UserName;
            pobjNewsEN.Memo += DateTime.Now.ToString(); //    日期
        }

        public System.Data.DataTable GetNewsTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select NewsTypeId, NewsTypeName from NewsType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_NewsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetNewsTypeId();
            objDDL.DataValueField = "NewsTypeId";
            objDDL.DataTextField = "NewsTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddNewsRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelNewsEdit.Text = "取消添加";

            wucNewsB1.EditTime = DateTime.Now.ToString("yyyy-MM-dd");
            wucNewsB1.EditPeople = clsCommonSession.UserId;

            //string strMemo +=DateTime.Now.ToString();
            wucNewsB1.Memo = clsCommonSession.UserName;
            wucNewsB1.Memo += DateTime.Now.ToString(); //    备注

            DispEditNewsRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddNewsRecordSave()
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
            //string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsNewsEN objNewsEN;
            //1、检查控件中输入数据类型是否正确
          
            //2、定义对象并初始化对象
            //clsNewsEN objNewsEN;	//定义对象
            objNewsEN = new clsNewsEN();	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToNewsClass(objNewsEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //6、把数据实体层的数据存贮到数据库中
                clsNewsBL.AddNewRecordBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelNewsEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddNewsRecordSaveV5()
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

            clsNewsEN objNewsEN;
            //1、检查控件中输入数据类型是否正确
            
            //2、定义对象并初始化对象
            //clsNewsEN objNewsEN;	//定义对象
            objNewsEN = new clsNewsEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToNewsClass(objNewsEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //6、把数据实体层的数据存贮到数据库中
                clsNewsBL.AddNewRecordBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                ErrMessage = "添加记录不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "添加记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelNewsEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateNewsRecord(int intId_News)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(intId_News);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelNewsEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditNewsRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateNewsRecordSave(clsNewsEN objNewsEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            ///3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
           
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToNewsClass(objNewsEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //4、把数据实体层的数据存贮到数据库中
                clsNewsBL.UpdateBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelNewsEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateNewsRecordSaveV5(clsNewsEN objNewsEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToNewsClass(objNewsEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsNewsBL.CheckPropertyNew(objNewsEN);
                //4、把数据实体层的数据存贮到数据库中
                clsNewsBL.UpdateBySql2(objNewsEN);
            }
            catch (Exception objException)
            {
                ErrMessage = "修改记录不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "修改记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_News();
            DispNewsListRegion();
            wucNewsB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelNewsEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteNewsRecord(int intId_News)
        {
            try
            {
                clsNewsBL.DelRecord(intId_News);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_News();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineNewsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "News信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("NewsTitle"); arrCnName.Add("标题");
            arrColName.Add("NewsTypeName"); arrCnName.Add("资讯类型名称");
            arrColName.Add("ImgPath"); arrCnName.Add("图片路径");
            arrColName.Add("EditPeople"); arrCnName.Add("编辑人员");
            arrColName.Add("EditTime"); arrCnName.Add("编辑时间");
            arrColName.Add("NewsTypeId"); arrCnName.Add("资讯类型");
            arrColName.Add("NewsContent"); arrCnName.Add("内容");
            arrColName.Add("Source"); arrCnName.Add("来源");
            arrColName.Add("IsTop"); arrCnName.Add("是否置顶");
            arrColName.Add("Views"); arrCnName.Add("浏览量");
            arrColName.Add("Memo"); arrCnName.Add("备注");
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
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
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
                objDT = clsvNewsBL.GetDataTable(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007，可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditNewsRegion()
        {
            
            //add.Visible = false;
            //delete.Visible = false;
            //edit.Visible = false;
            //export.Visible = false;
            //tool.Visible = false;

            back.Visible = true;

            trSelect.Visible = false;
            trShow.Visible = false;
            trEdit.Visible = true;
        }
        private void DispNewsListRegion()
        {
            //add.Visible = true;
            //delete.Visible = true;
            //edit.Visible = true;
            //export.Visible = true;
            //tool.Visible = true;

            back.Visible = false;

            trSelect.Visible = true;
            trShow.Visible = true;
            trEdit.Visible = false;

            wucNewsB1.Clear();//添空控件中的内容
        }
    }
}