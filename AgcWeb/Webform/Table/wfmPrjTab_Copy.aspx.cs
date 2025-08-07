///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using CommFunc4WebForm;


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;


using System.Collections.Generic;

using com.taishsoft.common;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPrjTab_Copy : CommWebPageBase
    {

        

        //生成有关的变量定义代码
        private const string ViewId4Potence = "00260203";		//界面编号


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
              clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                vsSortPrjTabBy = "TabId Asc";
                //2、显示无条件的表内容在DATAGRID中
                //BindGv_PrjTab();
            }
        }

        //生成错误信息的Session属性
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


        //生成权限等级的属性
        private string strPotenceLevel
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


        
        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
            }
        }

        ///private clsUsersEN objUserBak
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


        
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId == null)
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}
        private string ObjId
        {
            get
            {
                string strObjId;
                strObjId = (string)Session["ObjId"];
                if (strObjId == null)
                {
                    strObjId = "";
                }
                return strObjId;
            }
            set
            {
                string strObjId = value;
                Session.Add("ObjId", strObjId);
            }
        }

        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinePrjTabCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And TabName Not In (select TabName From PrjTab Where PrjId='{0}')", clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabIdq.Text.Trim() != "")
            {
                strWhereCond += " And vPrjTab.TabId like '%" + this.txtTabIdq.Text.Trim() + "%'";
            }
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " And vPrjTab.TabName like '%" + this.txtTabNameq.Text.Trim() + "%'";
            }
            if (this.txtTabCnNameq.Text.Trim() != "")
            {
                strWhereCond += " And vPrjTab.TabCnName like '%" + this.txtTabCnNameq.Text.Trim() + "%'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " And vPrjTab.PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.txtDataBaseNameq.Text.Trim() != "")
            {
                strWhereCond += " And vPrjTab.DataBaseName like '%" + this.txtDataBaseNameq.Text.Trim() + "%'";
            }
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }

            return strWhereCond;
        }

        /// <summary>
        /// 功能：计算DataGrid的页数
        /// </summary>
        /// <param name="intRecCount">总共的记录数</param>
        /// <param name="intPageSize">每页的记录数</param>
        /// <returns>计算出来的页数</returns>
        private int CalcPages(int intRecCount, int intPageSize)
        {
            int intPages;
            intPages = intRecCount / intPageSize;
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
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
            this.gvPrjTab.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_PrjTab();

        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvPrjTab.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_PrjTab();
        }
        protected void gvPrjTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (vsSortPrjTabBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTab.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortPrjTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortPrjTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
        {
            if (objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }
      
        
        //当前记录数
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinePrjTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsPrjTabBL.GetDataTable_PrjTab(strWhereCond);
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PrjTab信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(conPrjTab.TabId); arrCnName.Add("表ID");
            arrColName.Add(conPrjTab.TabName); arrCnName.Add("表名");
            arrColName.Add(conPrjTab.TabCnName); arrCnName.Add("表中文名");
            arrColName.Add(conPrjTab.PrjId); arrCnName.Add("工程ID");
            arrColName.Add(conPrjTab.DataBaseName); arrCnName.Add("数据库名");
            //arrColName.Add(conPrjTab.ObjId); arrCnName.Add("所属对象");
            arrColName.Add(conPrjTab.IsNeedTransCode); arrCnName.Add("是否需要转换代码");
            arrColName.Add(conPrjTab.IsArchive); arrCnName.Add("是否存档");
            arrColName.Add(conPrjTab.IsChecked); arrCnName.Add("是否核实");
            arrColName.Add(conPrjTab.TabStateId); arrCnName.Add("表状态ID");
            strFolderName = Server.MapPath("~") + "\\TempFiles\\";
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            DownLoadFile(strDownLoadFileName);
        }
        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }


     
        public System.Data.DataTable GetObjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ObjId, ObjName from PrjObjects ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ObjId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetObjId();
            objDDL.DataValueField = "ObjId";
            objDDL.DataTextField = "ObjName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
     
        
        protected void gvPrjTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortPrjTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
                BindGv_PrjTab();
                return;
            }
            //检查原来是升序
            intIndex = vsSortPrjTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortPrjTabBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTab();
        }

        private string vsSortPrjTabBy
        {
            get
            {
                string sSortPrjTabBy;
                sSortPrjTabBy = (string)ViewState["SortPrjTabBy"];
                if (sSortPrjTabBy == null)
                {
                    sSortPrjTabBy = "";
                }
                return sSortPrjTabBy;
            }
            set
            {
                string sSortPrjTabBy = value;
                ViewState.Add("SortPrjTabBy", sSortPrjTabBy);
            }
        }




        protected void btnCopyPrjTab_Click(object sender, System.EventArgs e)
        {
            //string strSouPrjId = ddlPrjIdq.SelectedValue;
            //if (strSouPrjId == "0")
            //{
            //    lblMsg.Text = "请选择一个源工程!";
            //    lblMsg.ForeColor = System.Drawing.Color.Red;
            //    return;
            //}
            string strTarPrjId = clsPubVar.CurrSelPrjId;
            List<string> arrSouTabId;
            arrSouTabId = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTab, "chkCheckRec");
            if (clsPrjTabBLEx.CopyPrjTab(strTarPrjId, arrSouTabId, UserId) == true)
            {
                lblMsg.Text = "复制源工程表对象列表成功!";
                lblMsg.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lblMsg.Text = "复制源工程表对象列表不成功!";
            }
            clsPrjTabFldBL.ReFreshCache(strTarPrjId);
            clsvPrjTabFldBL.ReFreshThisCache(strTarPrjId);

            clsCommonJsFunc.Alert(this, lblMsg.Text);
            BindGv_PrjTab();
        }

        protected void ddlPrjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string strPrjId = ddlPrjIdq.SelectedValue;
            if (ddlPrjIdq.SelectedIndex > 0)
            {
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleIdExCache(ddlFuncModuleId, strPrjId);
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, strPrjId);
            }
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_PrjTab()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            lblMsg.Text = "";
            //	1、组合界面条件串；
            string strWhereCond = CombinePrjTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortPrjTabBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            this.gvPrjTab.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvPrjTab.DataBind();
            if (objDT.Rows.Count == 0)
                return;
            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvPrjTab.BottomPagerRow;
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvPrjTab.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvPrjTab.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvPrjTab.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvPrjTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvPrjTab.PageIndex == this.gvPrjTab.PageCount - 1)
                {
                     clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
            }
        }
        ///删除记录过程代码for C#
        protected void gvPrjTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTab.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTab();
            }
        }
        ///删除记录过程代码for C#
        protected void gvPrjTab_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortPrjTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTab.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortPrjTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortPrjTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        protected void Set_GridViewAllChecked(GridView objGv, bool IsSelected)
        {
            if (objGv.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }
        protected ArrayList GetAllCheckedItemFromGv(System.Web.UI.WebControls.GridView objGv, string strChkName)
        {
            ArrayList arr = new ArrayList();
            if (objGv.Rows.Count == 0)
            {
                return arr;
            }
            else
            {
                foreach (GridViewRow li in objGv.Rows)
                {
                    CheckBox cb = (CheckBox)li.Cells[0].FindControl(strChkName);
                    if (cb != null && cb.Checked)
                    {
                        arr.Add(li.Cells[1].Text);
                    }
                }
                return arr;
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPrjTab.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPrjTab.PageCount)
                {
                    this.gvPrjTab.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PrjTab();
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvPrjTab_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        Set_GridViewAllChecked(gvPrjTab, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        Set_GridViewAllChecked(gvPrjTab, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        
        protected void gvPrjTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortPrjTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
                BindGv_PrjTab();
                return;
            }
            //检查原来是升序
            intIndex = vsSortPrjTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortPrjTabBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTab();
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