
///----------------------
///生成代码版本：2013.04.17.1
///生成日期：2014/05/18
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：Sql视图管理
///模块英文名：SqlViewMan
///注意：1、需要数据底层（PubDataBase.dll）的版本：2013.11.06.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2013.11.08.1
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
    /// wfmSqlViewB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmSqlViewB_QUDI : CommPageBase
    {
        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmSqlViewB_QUDI.aspx";
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

        /// <summary>
        /// 通过QueryString传递过来的SqlViewId参数。
        /// 姓名：潘以锋
        /// 日期：20140521
        /// </summary>
        private string qsSqlViewId
        {
            get
            {
                string strSqlViewId = Request.QueryString["SqlViewId"] ?? "".ToString();
                if ((strSqlViewId != null) && (strSqlViewId != ""))
                {
                    return strSqlViewId;
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
                InitParentPageInfo();
                vsViewName = "Sql视图维护";
                vsTabName = "vSqlView";
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

                vsViewName = "vSqlView";
                wucSetFieldVisibilityB_QU1.SetDdl_UserId();


                wucSetFieldVisibilityB_QU1.UserId = clsCommonSession.UserId;
                wucSetFieldVisibilityB_QU1.ViewName = vsViewName;
                wucSetFieldVisibilityB_QU1.myClickGetFldLstFromGridView += wucSetFieldVisibilityB_QU1_myClickGetFldLstFromGridView;

                if (string.IsNullOrEmpty(qsSqlViewId) == false)
                {
                    divQuery.Visible = false;
                }
                else
                {
                    divSqlViewFld.Visible = false;
                    clsTextResourceTypeBL.BindDdlTextResourceTypeId(ddlTextResourceTypeIdq);
                    clsPrjTabBLEx.BindDdl_TabIdBySqlDsTypeIdEx(ddlRelaTabIdq, clsPubVar.CurrSelPrjId, clsSQLDSTypeENEx.SQLVIEW);

                }
                //1、为下拉框设置数据源，绑定列表数据
                wucSqlViewB1.SetDdl_TextResourceTypeId();
                wucSqlViewB1.SetDdl_RelaTabId(clsPubVar.CurrSelPrjId, clsSQLDSTypeENEx.SQLVIEW);



                strSortSqlViewBy = "SqlViewId Asc";
                strSortSqlViewFldBy = "OrderNum Asc";
                strSortSqlViewRelaTabBy = "OrderNum Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_SqlView();
                if (string.IsNullOrEmpty(qsSqlViewId) == false)
                {
                    BindGv_SqlViewFld();
                    BindGv_SqlViewRelaTab();
                }
                //3、设置表控件中字控件的ReadOnly属性，
                // 使之只读，因为在修改功能中关键字是不能被修改的。
                wucSqlViewB1.SetKeyReadOnly(true);
                DispSqlViewListRegion();
                clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvSqlView, vsViewName, clsCommonSession.UserId);
                clsPubFun.js_Tz_HideDiv("divSetFieldVisibilityB_QU", this, 20);
            }
            if (vsDivIsVisible == true)
            {
                //clsPubFun.js_Tz_ShowDiv("divSetFieldVisibilityB_QU", this, 10);
            }
            else
            {
                clsPubFun.js_Tz_HideDiv("divSetFieldVisibilityB_QU", this, 10);
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
            this.gvSqlView.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvSqlView, vsViewName, clsCommonSession.UserId);
            BindGv_SqlView();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvSqlView_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvSqlView.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_SqlView();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　 在这里是把值传到表控件中
        /// </summary>
        /// <param name="strSqlViewId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        /// 具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsSqlViewEN objSqlViewEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddSqlViewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddSqlViewRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objSqlViewEN = (clsSqlViewEN)Session["objSqlViewEN"];
                    UpdateSqlViewRecordSave(objSqlViewEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddSqlViewRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSqlView, "chkCheckRec", "SqlViewId");
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
                    string strSqlViewId = strKeys[0];
                    clsSqlViewBLEx.DelRecordEx(strSqlViewId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_SqlView();
        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvSqlView, "SqlViewId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            string strSqlViewId = strKeys[0];
            UpdateSqlViewRecord(strSqlViewId);
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
        protected void gvSqlView_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortSqlViewBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortSqlViewBy = e.SortExpression + "# Asc";
                BindGv_SqlView();
                return;
            }
            //检查原来是升序
            intIndex = strSortSqlViewBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortSqlViewBy = e.SortExpression + "# Asc";
            }
            else			///否则设置为降序
            {
                strSortSqlViewBy = e.SortExpression + "# Desc";
            }
            BindGv_SqlView();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortSqlViewBy
        {
            get
            {
                string sSortSqlViewBy;
                sSortSqlViewBy = (string)ViewState["SortSqlViewBy"];
                if (sSortSqlViewBy == null)
                {
                    sSortSqlViewBy = "";
                }
                return sSortSqlViewBy;
            }
            set
            {
                string sSortSqlViewBy = value;
                ViewState.Add("SortSqlViewBy", sSortSqlViewBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvSqlView.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvSqlView.PageCount)
                {
                    this.gvSqlView.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_SqlView();
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
                    BindGv_SqlView();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvSqlView_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvSqlView, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvSqlView, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvSqlView_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortSqlViewBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvSqlView.Columns.Count; i++)
                {
                    strSortEx = this.gvSqlView.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortSqlViewBy.IndexOf(strSortEx + "#");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortSqlViewBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvSqlView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strSqlViewId = gvSqlView.DataKeys[e.RowIndex]["SqlViewId"].ToString();
            DeleteSqlViewRecord(strSqlViewId);
        }
        ///
        protected void gvSqlView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strSqlViewId = gvSqlView.DataKeys[e.RowIndex]["SqlViewId"].ToString();
            UpdateSqlViewRecord(strSqlViewId);
        }
        ///删除记录过程代码for C#
        protected void gvSqlView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvSqlView.PageIndex = e.NewPageIndex;
                this.BindGv_SqlView();
            }
        }
        ///
        protected void btnCancelSqlViewEdit_Click(object sender, EventArgs e)
        {
            DispSqlViewListRegion();
        }

        protected void btnImportSqlView_Click(object sender, EventArgs e)
        {
            try
            {
                clsSqlViewBLEx.ImportSqlView(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_SqlView();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
            clsCommonJsFunc.Alert(this, "导入视图成功！");

        }

        protected void btnImportSqlViewFromSqlServer_Click(object sender, EventArgs e)
        {
           
            StringBuilder sbMsg = new StringBuilder();
            int intRecordNum = 0;
            if (string.IsNullOrEmpty(qsSqlViewId) == false)
            {
                try
                {

                    string strSqlViewId = qsSqlViewId;
                    clsSqlViewBLEx.ImportSqlViewFromSqlServer(clsPubVar.CurrSelPrjId, strSqlViewId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId);

                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            else
            {
                List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSqlView, "chkCheckRec", "SqlViewId");
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
                        string strSqlViewId = strKeys[0];
                        try
                        {
                            clsSqlViewBLEx.ImportSqlViewFromSqlServer(clsPubVar.CurrSelPrjId, strSqlViewId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId);
                            intRecordNum++;
                        }
                        catch (Exception objException)
                        {
                            clsvSqlViewEN objSqlViewEN = clsvSqlViewBL.GetObjBySqlViewIdCache(strSqlViewId, clsPubVar.CurrSelPrjId);
                            sbMsg.AppendFormat("表：{0}出错！{1}\r\n", 
                                objSqlViewEN.SqlViewName, objException.Message);
                            //clsCommonJsFunc.Alert(this, objException.Message);
                            //return;
                            ErrorInformationBL.AddInformation("wfmSqlViewB_QUDI", "btnImportSqlViewFromSqlServer_Click", objException.Message, clsCommonSession.UserId);
                        }
                    }
                }
                catch (Exception objException)
                {

                    //clsCommonJsFunc.Alert(this, objException.Message);
                    //return;
                    ErrorInformationBL.AddInformation("wfmSqlViewB_QUDI", "btnImportSqlViewFromSqlServer_Click", objException.Message, clsCommonSession.UserId);
                }
            }
            BindGv_SqlView();
            string strMsg = string.Format("共成功:{0}条记录。错误信息：{1}", intRecordNum, sbMsg.ToString());
            clsCommonJsFunc.Alert(this, strMsg);

        }

        protected void btnAnalysis_Click(object sender, EventArgs e)
        {
            StringBuilder sbMsg = new StringBuilder();
            int intRecordNum = 0;
            if (string.IsNullOrEmpty(qsSqlViewId) == false)
            {

                try
                {

                    string strSqlViewId = qsSqlViewId;
                    clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
                    string strRelaTabId = clsSqlViewBLEx.GetRelaTabIdBySqlViewIdCache(clsPubVar.CurrSelPrjId, strSqlViewId);
                    if (string.IsNullOrEmpty(strRelaTabId) == false)
                    {
                        clsTabCheckResultBLEx.DeleteErrorResult(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, strRelaTabId, "15", "", clsCommonSession.UserId);
                    }

                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            else
            {
           
                List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSqlView, "chkCheckRec", "SqlViewId");
                if (lstKeyValues.Count == 0)
                {
                    lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                    return;
                }
                lblMsgList.Text = "";
                try
                {
                    clsvSqlViewEN objSqlViewEN = null;
                    foreach (string strKeyValue in lstKeyValues)
                    {
                        string[] strKeys = strKeyValue.Split(',');
                        string strSqlViewId = strKeys[0];
                        try
                        {
                            objSqlViewEN = clsvSqlViewBL.GetObjBySqlViewId(strSqlViewId);
                            clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                            clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);

                            string strRelaTabId = objSqlViewEN.RelaTabId;

                            clsTabCheckResultBLEx.DeleteErrorResult(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, strRelaTabId, "15", "", clsCommonSession.UserId);
                            intRecordNum++;
                        }
                        catch (Exception objException)
                        {

                            objSqlViewEN = clsvSqlViewBL.GetObjBySqlViewId(strSqlViewId);

                            sbMsg.AppendFormat("表：{0}出错！{1}\r\n", objSqlViewEN.SqlViewName, objException.Message);
                            //clsCommonJsFunc.Alert(this, objException.Message);
                            //return;
                            ErrorInformationBL.AddInformation("wfmSqlViewB_QUDI", "btnImportSqlViewFromSqlServer_Click", objException.Message, clsCommonSession.UserId);
                        }
                    }
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            BindGv_SqlView();
            BindGv_SqlViewFld();
            BindGv_SqlViewRelaTab();

            string strMsg = string.Format("共成功分析:{0}条记录。错误信息：{1}", intRecordNum, sbMsg.ToString());
            clsCommonJsFunc.Alert(this, strMsg);
        }

        protected void btnGeneViewText_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qsSqlViewId) == false)
            {
                try
                {

                    string strSqlViewId = qsSqlViewId;
                    clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);

                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            else
            {
                List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSqlView, "chkCheckRec", "SqlViewId");
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
                        string strSqlViewId = strKeys[0];
                        clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
                        clsTabCheckResultBLEx.DeleteErrorResult(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, strSqlViewId, "15", "", clsCommonSession.UserId);
                    }
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            BindGv_SqlView();
            clsCommonJsFunc.Alert(this, "生成Sql视图成功！");

        }

        protected void btnCreateView4Sql_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qsSqlViewId) == false)
            {
                try
                {

                    string strSqlViewId = qsSqlViewId;
                    //进行尝试生成视图，看视图文本是否合法
                    clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, true);
                    //正式地生成视图
                    clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, false);

                    clsCommonJsFunc.Alert(this, "在SQL中建立视图完成！");
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            else
            {
                List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSqlView, "chkCheckRec", "SqlViewId");
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
                        string strSqlViewId = strKeys[0];
                        //进行尝试生成视图，看视图文本是否合法
                        if (clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, true) == true)
                        {
                            //正式地生成视图
                            clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, false);
                        }
                    }
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
            }
            BindGv_SqlView();
            clsCommonJsFunc.Alert(this, "在Sql中建立视图成功！");

        }

        protected void chkShowSqlViewText_CheckedChanged(object sender, EventArgs e)
        {
            CheckShowSqlViewText();
        }
        private void CheckShowSqlViewText()
        {
            if (chkShowSqlViewText.Checked == true)
            {
                clsPubFun.SetGvVisibility(gvSqlView, "SqlViewText", true);
            }
            else
            {
                clsPubFun.SetGvVisibility(gvSqlView, "SqlViewText", false);
            }
        }

        protected void btnSetOrderNum4Refer_Click(object sender, EventArgs e)
        {
            try
            {
                //clsSqlViewBLEx.SetOrderNum4Refer(clsPubVar.CurrSelPrjId);
                clsPrjTabBLEx.SetOrderNum4Refer(clsPubVar.CurrSelPrjId);

                //BindGv_SqlView();
                clsCommonJsFunc.Alert(this, "设置引用序号成功！");
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
        }

        protected void btnRefresgCreateDate_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvSqlView, "chkCheckRec", "SqlViewId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    string strSqlViewId = strKeys[0];

                    clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetObjBySqlViewId(strSqlViewId);
                    objSqlViewEN.CreateDate = strCurrDate14;
                    objSqlViewEN.UpdUserId = clsCommonSession.UserId;

                    clsSqlViewBL.UpdateBySql2(objSqlViewEN);
                    clsLog4CreateView4SqlBLEx.AddLog4CreateView4Sql(objSqlViewEN.SqlViewId, clsPubVar.CurrPrjDataBaseId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            BindGv_SqlView();
            clsCommonJsFunc.Alert(this, "更新日期成功！");
        }
    }
    public partial class wfmSqlViewB_QUDI : CommPageBase
    {
        protected void ShowData(string strSqlViewId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strSqlViewId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsSqlViewBL.IsExist(strSqlViewId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strSqlViewId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsSqlViewEN objSqlViewEN = new clsSqlViewEN(strSqlViewId);
            //4、获取类对象的所有属性；
            try
            {
                clsSqlViewBL.GetSqlView(ref objSqlViewEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objSqlViewEN", objSqlViewEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromSqlViewClass(objSqlViewEN);
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
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineSqlViewCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            strWhereCond = string.Format("PrjId='{0}' And TabStateId='01' And  FuncModuleAgcId in (Select FuncModuleAgcId From DataBaseModuleRela where PrjId='{0}' And PrjDataBaseId='{1}' And IsVisible='1') ", clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);


            if (string.IsNullOrEmpty(qsSqlViewId) == false)
            {
                //strWhereCond += string.Format(" And SqlViewId='{0}' And UserId='{1}'", 
                //    qsSqlViewId,
                //    clsCommonSession.UserId);

                strWhereCond += string.Format(" And SqlViewId='{0}' ",
                    qsSqlViewId,
                    clsCommonSession.UserId);

            }
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtSqlViewNameq.Text.Trim() != "")
            {
                strWhereCond += " And SqlViewName like '%" + this.txtSqlViewNameq.Text.Trim() + "%'";
            }

            if (this.txtCreateViewDate.Text.Trim() != "")
            {
                strWhereCond += " And (CreateViewDate < '" + this.txtCreateViewDate.Text.Trim() + "' or CreateViewDate is null)";
            }
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " And TabName like '%" + this.txtTabNameq.Text.Trim() + "%'";
            }
            if (this.txtOrderNum4Refer.Text.Trim() != "")
            {
                strWhereCond += " And OrderNum4Refer = " + this.txtOrderNum4Refer.Text.Trim();
            }
            if (this.ddlTextResourceTypeIdq.SelectedValue != "" && this.ddlTextResourceTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And TextResourceTypeId='" + this.ddlTextResourceTypeIdq.SelectedValue + "'";
            }
            if (this.ddlRelaTabIdq.SelectedValue != "" && this.ddlRelaTabIdq.SelectedValue != "0")
            {
                strWhereCond += " And RelaTabId='" + this.ddlRelaTabIdq.SelectedValue + "'";
            }

            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_SqlView()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineSqlViewCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                //if (string.IsNullOrEmpty(qsSqlViewId) == true)
                //{
              //  strWhereCond += string.Format(" And PrjDataBaseId='{0}'", clsPubVar.CurrPrjDataBaseId);
                strWhereCond += "[exclude]or [/exclude]";
                //}
                objDT = clsvSqlViewBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            if (strSortSqlViewBy.IndexOf("#") > 0)
            {
                string strTemp = strSortSqlViewBy.Replace("#", "");
                objDV.Sort = strTemp;
            }
            else
            {
                objDV.Sort = strSortSqlViewBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            }
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvSqlView.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvSqlView.PageSize = 10;
            }
            this.gvSqlView.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvSqlView.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvSqlView.BottomPagerRow;
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
                lblAllPages.Text = this.gvSqlView.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvSqlView.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvSqlView.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvSqlView.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvSqlView.PageIndex == this.gvSqlView.PageCount - 1)
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
            gvSqlView.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        /// 如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjSqlViewEN">表实体类对象</param>
        protected void GetDataFromSqlViewClass(clsSqlViewEN pobjSqlViewEN)
        {
            wucSqlViewB1.SqlViewId = pobjSqlViewEN.SqlViewId;// Sql视图Id
           
            wucSqlViewB1.SqlViewText = pobjSqlViewEN.SqlViewText;// Sql视图文本内容
            wucSqlViewB1.TextResouce = pobjSqlViewEN.TextResouce;// 文本来源
            wucSqlViewB1.TextResourceTypeId = pobjSqlViewEN.TextResourceTypeId;// 文本来源类型Id
            wucSqlViewB1.RelaTabId = pobjSqlViewEN.RelaTabId;// 相关表Id

            wucSqlViewB1.Memo = pobjSqlViewEN.Memo;// 说明
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjSqlViewEN">数据传输的目的类对象</param>
        protected void PutDataToSqlViewClass(clsSqlViewEN pobjSqlViewEN)
        {
            pobjSqlViewEN.SqlViewId = wucSqlViewB1.SqlViewId;// Sql视图Id
          
            pobjSqlViewEN.SqlViewText = wucSqlViewB1.SqlViewText;// Sql视图文本内容
            pobjSqlViewEN.TextResouce = wucSqlViewB1.TextResouce;// 文本来源
            pobjSqlViewEN.TextResourceTypeId = wucSqlViewB1.TextResourceTypeId;// 文本来源类型Id
            pobjSqlViewEN.RelaTabId = wucSqlViewB1.RelaTabId;// 相关表Id
            pobjSqlViewEN.PrjId = clsPubVar.CurrSelPrjId;// 工程ID
            pobjSqlViewEN.UpdDate = wucSqlViewB1.UpdDate;// 修改日期
            pobjSqlViewEN.UpdUserId = wucSqlViewB1.UpdUserId;// 修改用户Id
            pobjSqlViewEN.Memo = wucSqlViewB1.Memo;// 说明
        }

        public System.Data.DataTable GetTextResourceTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TextResourceTypeId, TextResourceTypeName from TextResourceType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_TextResourceTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTextResourceTypeId();
            objDDL.DataValueField = "TextResourceTypeId";
            objDDL.DataTextField = "TextResourceTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        ///生成的插入记录准备过程代码for C#
        protected void AddSqlViewRecord()
        {
            wucSqlViewB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelSqlViewEdit.Text = "取消添加";
            wucSqlViewB1.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
            DispEditSqlViewRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddSqlViewRecordSave()
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
            clsSqlViewEN objSqlViewEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucSqlViewB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsSqlViewEN objSqlViewEN;	//定义对象
            objSqlViewEN = new clsSqlViewEN(wucSqlViewB1.SqlViewId);	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToSqlViewClass(objSqlViewEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsSqlViewBL.CheckPropertyNew(objSqlViewEN);
                //6、把数据实体层的数据存贮到数据库中
                clsSqlViewBL.AddNewRecordBySql2(objSqlViewEN);
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
            BindGv_SqlView();
            DispSqlViewListRegion();
            wucSqlViewB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSqlViewEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddSqlViewRecordSaveV5()
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
            clsSqlViewEN objSqlViewEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucSqlViewB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsSqlViewEN objSqlViewEN;	//定义对象
            objSqlViewEN = new clsSqlViewEN(wucSqlViewB1.SqlViewId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToSqlViewClass(objSqlViewEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsSqlViewBL.CheckPropertyNew(objSqlViewEN);
                //6、把数据实体层的数据存贮到数据库中
                clsSqlViewBL.AddNewRecordBySql2(objSqlViewEN);
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
            BindGv_SqlView();
            DispSqlViewListRegion();
            wucSqlViewB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSqlViewEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateSqlViewRecord(string strSqlViewId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strSqlViewId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucSqlViewB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelSqlViewEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditSqlViewRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateSqlViewRecordSave(clsSqlViewEN objSqlViewEN)
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
            if (!wucSqlViewB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToSqlViewClass(objSqlViewEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsSqlViewBL.CheckPropertyNew(objSqlViewEN);
                //4、把数据实体层的数据存贮到数据库中
                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
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
            BindGv_SqlView();
            DispSqlViewListRegion();
            wucSqlViewB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSqlViewEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateSqlViewRecordSaveV5(clsSqlViewEN objSqlViewEN)
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
            if (!wucSqlViewB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToSqlViewClass(objSqlViewEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsSqlViewBL.CheckPropertyNew(objSqlViewEN);
                //4、把数据实体层的数据存贮到数据库中
                clsSqlViewBL.UpdateBySql2(objSqlViewEN);
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
            BindGv_SqlView();
            DispSqlViewListRegion();
            wucSqlViewB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelSqlViewEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteSqlViewRecord(string strSqlViewId)
        {
            try
            {
                clsSqlViewBL.DelRecord(strSqlViewId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_SqlView();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineSqlViewCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "SqlView信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("SqlViewId"); arrCnName.Add("Sql视图Id");
            arrColName.Add("SqlViewName"); arrCnName.Add("数据视图名称");
            arrColName.Add("SqlViewENName"); arrCnName.Add("Sql视图英文详细名");
            arrColName.Add("SqlViewCNName"); arrCnName.Add("Sql视图中文名");
            arrColName.Add("SqlViewText"); arrCnName.Add("Sql视图文本内容");
            arrColName.Add("TextResouce"); arrCnName.Add("文本来源");
            arrColName.Add("TextResourceTypeId"); arrCnName.Add("文本来源类型Id");
            arrColName.Add("TextResourceTypeName"); arrCnName.Add("文本来源类型名");
            arrColName.Add("RelaTabId"); arrCnName.Add("相关表Id");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabEnName"); arrCnName.Add("表英文详细名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
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
                objDT = clsvSqlViewBL.GetDataTable(strWhereCond);
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
        private void DispEditSqlViewRegion()
        {
            divList.Visible = false;
            tabEditSqlViewRegion.Visible = true;
        }
        private void DispSqlViewListRegion()
        {
            divList.Visible = true;
            tabEditSqlViewRegion.Visible = false;
        }



        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_SqlViewFld()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineSqlViewFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvSqlViewFldBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortSqlViewFldBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                              ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvSqlViewFld.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvSqlViewFld.PageSize = 10;
            }
            this.gvSqlViewFld.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvSqlViewFld.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvSqlViewFld.BottomPagerRow;
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
                lblAllPages.Text = this.gvSqlViewFld.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvSqlViewFld.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvSqlViewFld.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvSqlViewFld.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvSqlViewFld.PageIndex == this.gvSqlViewFld.PageCount - 1)
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
            gvSqlViewFld.BottomPagerRow.Visible = true;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineSqlViewFldCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            strWhereCond += string.Format(" And PrjId='{0}'", clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (string.IsNullOrEmpty(qsSqlViewId) == false)
            {
                strWhereCond += string.Format(" And SqlViewId='{0}'", qsSqlViewId);
            }

            return strWhereCond;
        }


        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineSqlViewRelaTabCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            strWhereCond = string.Format("PrjId='{0}'", clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (string.IsNullOrEmpty(qsSqlViewId) == false)
            {
                strWhereCond += string.Format(" And SqlViewId='{0}'", qsSqlViewId);
            }


            return strWhereCond;
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortSqlViewRelaTabBy
        {
            get
            {
                string sSortSqlViewRelaTabBy;
                sSortSqlViewRelaTabBy = (string)ViewState["SortSqlViewRelaTabBy"];
                if (sSortSqlViewRelaTabBy == null)
                {
                    sSortSqlViewRelaTabBy = "";
                }
                return sSortSqlViewRelaTabBy;
            }
            set
            {
                string sSortSqlViewRelaTabBy = value;
                ViewState.Add("SortSqlViewRelaTabBy", sSortSqlViewRelaTabBy);
            }
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortSqlViewFldBy
        {
            get
            {
                string sSortSqlViewFldBy;
                sSortSqlViewFldBy = (string)ViewState["SortSqlViewFldBy"];
                if (sSortSqlViewFldBy == null)
                {
                    sSortSqlViewFldBy = "";
                }
                return sSortSqlViewFldBy;
            }
            set
            {
                string sSortSqlViewFldBy = value;
                ViewState.Add("SortSqlViewFldBy", sSortSqlViewFldBy);
            }
        }

        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_SqlViewRelaTab()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineSqlViewRelaTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvSqlViewRelaTabBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortSqlViewRelaTabBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                                  ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvSqlViewRelaTab.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvSqlViewRelaTab.PageSize = 10;
            }
            this.gvSqlViewRelaTab.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvSqlViewRelaTab.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvSqlViewRelaTab.BottomPagerRow;
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
                lblAllPages.Text = this.gvSqlViewRelaTab.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvSqlViewRelaTab.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvSqlViewRelaTab.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvSqlViewRelaTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvSqlViewRelaTab.PageIndex == this.gvSqlViewRelaTab.PageCount - 1)
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
            gvSqlViewRelaTab.BottomPagerRow.Visible = true;
        }


        ///生成GridView行命令的事件代码
        protected void gvSqlViewRelaTab_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvSqlViewRelaTab, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvSqlViewRelaTab, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvSqlViewRelaTab_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortSqlViewRelaTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvSqlViewRelaTab.Columns.Count; i++)
                {
                    strSortEx = this.gvSqlViewRelaTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortSqlViewRelaTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortSqlViewRelaTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvSqlViewRelaTab_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvSqlViewRelaTab.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);

        }
        ///
        protected void gvSqlViewRelaTab_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvSqlViewRelaTab.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);

        }
        ///删除记录过程代码for C#
        protected void gvSqlViewRelaTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvSqlViewRelaTab.PageIndex = e.NewPageIndex;
                this.BindGv_SqlViewRelaTab();
            }
        }

        protected void gvSqlViewRelaTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortSqlViewRelaTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortSqlViewRelaTabBy = e.SortExpression + " Asc";
                BindGv_SqlViewRelaTab();
                return;
            }
            //检查原来是升序
            intIndex = strSortSqlViewRelaTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortSqlViewRelaTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortSqlViewRelaTabBy = e.SortExpression + " Desc";
            }
            BindGv_SqlViewRelaTab();
        }

        ///生成GridView行命令的事件代码
        protected void gvSqlViewFld_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvSqlViewFld, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvSqlViewFld, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvSqlViewFld_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortSqlViewFldBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvSqlViewFld.Columns.Count; i++)
                {
                    strSortEx = this.gvSqlViewFld.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortSqlViewFldBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortSqlViewFldBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvSqlViewFld_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvSqlViewFld.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);

        }
        ///
        protected void gvSqlViewFld_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvSqlViewFld.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);

        }
        ///删除记录过程代码for C#
        protected void gvSqlViewFld_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvSqlViewFld.PageIndex = e.NewPageIndex;
                this.BindGv_SqlViewFld();
            }
        }

        protected void gvSqlViewFld_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortSqlViewFldBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortSqlViewFldBy = e.SortExpression + " Asc";
                BindGv_SqlViewFld();
                return;
            }
            //检查原来是升序
            intIndex = strSortSqlViewFldBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortSqlViewFldBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortSqlViewFldBy = e.SortExpression + " Desc";
            }
            BindGv_SqlViewFld();
        }


        protected void wucSetFieldVisibilityB_QU1_myClickSubmitSet(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            vsDivIsVisible = false;
            clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvSqlView, vsViewName, clsCommonSession.UserId);
            BindGv_SqlView();
            clsPubFun.js_Tz_HideDiv("divSetFieldVisibilityB_QU", this, 0);
        }

        protected void wucSetFieldVisibilityB_QU1_myClickGetFldLstFromGridView(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                clsSetFieldVisibilityBLEx.GetFldNameLstByGridView(gvSqlView, vsViewName, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
        }


        public override string FuncModuleAgcId
        {
            get
            {
                return "";
            }
        }
        public override void SetMenuTitle()
        {
            return;
        }

        #region 处理父页面信息以及跳转到其他页面
        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    //                lbReturnPrjTabList.Text = "返回[工程表列表]";
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
    }
}