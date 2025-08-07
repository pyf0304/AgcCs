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
using System.Text;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;

using com.taishsoft.datetime;



//public class ObjStruct
//{
//    public string strObjId;
//    public string strObjName;
//}

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmFieldTab_ReplaceField : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
              

                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                vsSortFieldTabBy = "FldName Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_FieldTab();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                tabQuery.Visible = false;
                tabPrjTab.Visible = false;
            }
        }


        private clsUsersEN objUserBak
        {
            get
            {
                clsUsersEN pobjUser;
                pobjUser = (clsUsersEN)Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                    string strErrMessage = "用户对象为空,可能不用时间超时,Session丢失,需要重新登录!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }
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
        ///生成专门用于记录GridView中的每页记录数
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
        private string BackErrPageLinkStr
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
        private string ErrMessage
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
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineFieldTabCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And PrjId='{0}'", clsPubVar.CurrSelPrjId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。

            if (this.txtFldNameq.Text.Trim() != "")
            {
                strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim() + "%'";
            }
        
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                strWhereCond += " and Fldid in (select fldid from FldObjTab where ObjId='" + this.ddlTabIdq.SelectedValue + "')";
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
            this.gvFieldTab.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_FieldTab();
        }

       

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
                    BindGv_FieldTab();
                }
            }
        }
     


        private void DeleteRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                clsFieldTabBL.DelRecord(strFldId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FieldTab();

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


        public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }
        public void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            objDDL.Items.Add("是");
            objDDL.Items.Add("否");
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }

        protected void gvFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsNull); //8;
                iNum[1] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsPrimaryKey); //9;
                for (int i = 0; i < 2; i++)
                {
                    if (e.Item.Cells[iNum[i]].Text == "True")
                    {
                        e.Item.Cells[iNum[i]].Text = "√";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Item.Cells[iNum[i]].Text = "×";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }
            }
        }
        /// <summary>
        /// 导入Excel文件的字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("wfmImportFldInfoFromExcel.aspx");
        }


        protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("wfmImportFldInfoFromSQL.aspx");

        }

  
    

        protected void lbDelFld_Click(object sender, System.EventArgs e)
        {
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab);
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //删除记录;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in objArr)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
                    string strJournal = "执行了删除操作，删除表FieldTab! 字段名："
                        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                    
                    bool IsSuccesful = true;
                    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                        strUserIp,
                        strOperationType,
                        strTableName,
                        strTableKey,
                        strJournal,
                        clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录添加日志不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                string strObjId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex >= 1)
                {
                    foreach (string strFldId in objArr)
                    {
                        clsFieldTabBLEx.DelFieldTabBySp(strFldId, strObjId);
                    }
                    //string strMsg = "请选择一个合适的对象名!";
                    //clsCommonJsFunc.Alert(this, strMsg);
                    //return;
                }
                else
                {
                    foreach (string strFldId in objArr)
                    {
                        clsFieldTabBL.DelRecord(strFldId);
                    }
                }
                //clsFieldTabBLEx.DelFieldTabEx(objArr);

            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");
        }

        protected void ddlObjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string strObjId = ddlTabIdq.SelectedValue;
            List<string> arrLst = new List<string>();
            arrLst = clsGeneralTab2.funGetFldValue("PrjTab", "TabName", "ObjId = '" + strObjId + "'");
            if (arrLst == null || arrLst.Count == 0)
                return;
         
        }
        /// <summary>
        /// 将所选对象的所有字段，复制到相关表中，同时删除对象中没有的字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
        {
            //操作步骤：
            //1、获取当前表ID的相关对象ID；
            //2、获取相关对象ID的字段ID的DataTable;
            //3、对该表进行循环，把字段信息插入到一个ArrayList
            //4、在插入过程中，要注意字段ID的重复，不能插入重复
            //			string strWhereCond;
            string strObjId;
            //1、获取当前表ID的相关对象ID；
            strObjId = ddlTabIdq.SelectedValue;
            if (strObjId == null || strObjId.Length == 0)
            {
                return;
            }
            //if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
            //{
            //    Response.Write("<script>alert('与相关对象复制字段信息成功！！')</script>");
            //}
            //else
            //{
            //    Response.Write("<script>alert('该对象不能与相关表同步，请检查对象属性；或者该对象没有相关的字段！！')</script>");
            //}



        }

        protected void btnQueryForAdvanced_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvFieldTab.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_FieldTab();
        }
       


        protected void ddlFuncModuleId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ddlFuncModuleIdq.SelectedIndex > 0)
            {
                string strFuncModuleId = ddlFuncModuleIdq.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
            }
        }

        protected void lbDelFieldTabEx_Click(object sender, System.EventArgs e)
        {
            string strUserIp = Request.UserHostAddress;
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab);
            List<string> objArr2 = clsArray.CopyArrayListToList_String(objArr);
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
                string strOperationType = clsOperationTypeBLEx.DELETE_RECORD; //删除记录;
                string strTableName = "FieldTab";
                clsFieldTabEN objFieldTabEN = null;
                foreach (string strFldId in objArr)
                {
                    string strTableKey = strFldId;
                    objFieldTabEN = new clsFieldTabEN(strFldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    string strJournal = "执行了删除操作，删除表FieldTab! 字段名："
                        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";
                    
                    bool IsSuccesful = true;
                    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
                        strUserIp,
                        strOperationType,
                        strTableName,
                        strTableKey,
                        strJournal,
                        clsPubVar.CurrSelPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录添加日志不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            try
            {
                if (strUserIp == "127.0.0.1" || strUserIp == "59.78.151.114" || strUserIp == "59.78.151.116")
                {
                    clsFieldTabBLEx.DelFieldTabEx2(objArr2);
                }
                else
                {
                    clsCommonJsFunc.Alert(this, "删除该字段应该在特定的IP地址！不能在：" + strUserIp);
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");

        }

     
        protected void lbUpdate_Click(object sender, EventArgs e)
        {
            string strFldID = GetFirstCheckedItemFromGv(gvFieldTab);
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字记录的内容在界面上；
         
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
   
            DispEditFieldTabRegion();
        }
       
      
        private void DispFieldTabListRegion()
        {
            tabQuery.Visible = true;
          
        }
        private void DispEditFieldTabRegion()
        {
            tabQuery.Visible = false;
           
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvFieldTab.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_FieldTab();
        }
        ///删除记录过程代码for C#
        protected void gvFieldTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvFieldTab.PageIndex = e.NewPageIndex;
                this.BindGv_FieldTab();
            }
        }
        ///删除记录过程代码for C#
        protected void gvFieldTab_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortFieldTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvFieldTab.Columns.Count; i++)
                {
                    strSortEx = this.gvFieldTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortFieldTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortFieldTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvFieldTab_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strFldID;    // = gvFieldTab.Rows[e.RowIndex].Cells[1].Text.Trim();
            strFldID = gvFieldTab.DataKeys[e.RowIndex].Value.ToString();
            DeleteFieldTabRecord(strFldID);
        }
        ///
        protected void gvFieldTab_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strFldID;    // = gvFieldTab.Rows[e.RowIndex].Cells[1].Text.Trim();
            strFldID = gvFieldTab.DataKeys[e.RowIndex].Value.ToString();
     
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_FieldTab()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineFieldTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortFieldTabBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            //////设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvFieldTab.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvFieldTab.PageSize = 10;
            }
            this.gvFieldTab.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvFieldTab.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            if (pagerRow == null) return;
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
                lblAllPages.Text = this.gvFieldTab.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvFieldTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvFieldTab.PageIndex == this.gvFieldTab.PageCount - 1)
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
        }

        protected string vsSortFieldTabBy
        {
            get
            {
                string sSortFieldTabBy;
                sSortFieldTabBy = (string)ViewState["SortFieldTabBy"];
                if (sSortFieldTabBy == null)
                {
                    sSortFieldTabBy = "";
                }
                return sSortFieldTabBy;
            }
            set
            {
                string sSortFieldTabBy = value;
                ViewState.Add("SortFieldTabBy", sSortFieldTabBy);
            }
        }
        ///生成GridView行命令的事件代码
        protected void gvFieldTab_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        Set_GridViewAllChecked(gvFieldTab, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        Set_GridViewAllChecked(gvFieldTab, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
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
        protected string GetFirstCheckedItemFromGv(GridView objGv)
        {
            if (objGv.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                //foreach (GridViewRow di in objGv.Rows)
                //{
                //    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                //    if (chkCheckRec != null && chkCheckRec.Checked)
                //    {
                //        return di.Cells[1].Text;

                //    }
                //}
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                    if (chkCheckRec != null && chkCheckRec.Checked)
                    {
                        return objGv.DataKeys[iRow].Value.ToString();
                    }
                }
            }
            return "";
        }
        protected ArrayList GetAllCheckedItemFromGv1(System.Web.UI.WebControls.GridView objGv, string strChkName)
        {
            ArrayList arr = new ArrayList();
            if (objGv.Rows.Count == 0)
            {
                return arr;
            }
            else
            {
                int intRowNum = objGv.Rows.Count;
                for (int iRow = 0; iRow < intRowNum; iRow++)
                {
                    GridViewRow di = objGv.Rows[iRow];
                    CheckBox cb = (CheckBox)di.Cells[0].FindControl(strChkName);
                    if (cb != null && cb.Checked)
                    {
                        arr.Add(objGv.DataKeys[iRow].Value.ToString());
                    }
                }
                return arr;
            }
        }
        ///删除记录过程代码for C#
        protected void DeleteFieldTabRecord(string strFldId)
        {
            if (clsFieldTabBLEx.IsCanDelUpd(strFldId) == false) return;
            try
            {
                //判断是否有选中的对象ID
                string strObjId = ddlTabIdq.SelectedValue;
                if (ddlTabIdq.SelectedIndex < 1)
                {
                    string strMsg = "请选择一个合适的对象名!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                clsFieldTabBLEx.DelFieldTabBySp(strFldId, strObjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "删除记录不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_FieldTab();
        }
        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvFieldTab.PageCount)
                {
                    this.gvFieldTab.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_FieldTab();
            }
        }
        
        protected void gvFieldTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortFieldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
                BindGv_FieldTab();
                return;
            }
            //检查原来是升序
            intIndex = vsSortFieldTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortFieldTabBy = e.SortExpression + " Desc";
            }
            BindGv_FieldTab();
        }
        protected void lbCheckField_Click(object sender, EventArgs e)
        {
            CheckField();
            BindGv_FieldTab();
        }
        protected void lbCopyField_Click(object sender, EventArgs e)
        {
            //复制字段
            CopyField();
        }

        protected void btnExportExcel4Gv_Click(object sender, EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineFieldTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "FieldTab信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("FldId"); arrCnName.Add("字段ID");
            arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("Caption"); arrCnName.Add("标题");
            arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
            arrColName.Add("FldLength"); arrCnName.Add("字段长度");
            arrColName.Add("IsNull"); arrCnName.Add("是否可空");
            arrColName.Add("IsPrimaryKey"); arrCnName.Add("是否主键");
            arrColName.Add("IsIdentity"); arrCnName.Add("是否Identity");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("是否唯一");
            arrColName.Add("TabNum"); arrCnName.Add("表数");

            arrColName.Add("MaxValue"); arrCnName.Add("最大值");
            arrColName.Add("MinValue"); arrCnName.Add("最小值");
            arrColName.Add("DefaultValue"); arrCnName.Add("缺省值");
            arrColName.Add("FldName_G"); arrCnName.Add("字段名_国标");
            arrColName.Add("FldName_B"); arrCnName.Add("字段名_后备");
            arrColName.Add("IsNationStandard"); arrCnName.Add("是否国标");

            arrColName.Add("IsNeedTransCode"); arrCnName.Add("是否需要转换代码");
            arrColName.Add("CodeTab"); arrCnName.Add("代码表");
            arrColName.Add("CodeTabName"); arrCnName.Add("代码表_名称");
            arrColName.Add("CodeTabCode"); arrCnName.Add("代码表_代码");
            arrColName.Add("AppliedScope"); arrCnName.Add("应用范围");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("IsArchive"); arrCnName.Add("是否存档");
            arrColName.Add("OraDbType"); arrCnName.Add("Ora数据类型");
            arrColName.Add("FldBName_B"); arrCnName.Add("FldBName_B");
            arrColName.Add("FldInfo"); arrCnName.Add("字段信息");
            
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("IsChecked"); arrCnName.Add("是否核实");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
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

        protected void btnSetSourceField_Click(object sender, EventArgs e)
        {
            lbSetField.Text = "设置源字段信息";
            tabQuery.Visible = true;
        }

        protected void btnSetTargetField_Click(object sender, EventArgs e)
        {
            lbSetField.Text = "设置目录字段信息";
            tabQuery.Visible = true;
        }

        protected void lbSetField_Click(object sender, EventArgs e)
        {
            string strFldID = GetFirstCheckedItemFromGv(gvFieldTab);
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldID);
            clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
            StringBuilder sbFieldMsg = new StringBuilder();
            sbFieldMsg.AppendFormat("{0},{1}({2}),", objFieldTabEN.FldId, objFieldTabEN.FldName, objFieldTabEN.Caption);
            sbFieldMsg.AppendFormat("{0},{1}", clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache( objFieldTabEN.DataTypeId),
                                            objFieldTabEN.FldLength);
            if (lbSetField.Text == "设置源字段信息")
            {
                lblSourceField.Text = sbFieldMsg.ToString();
                hfSourceFieldId.Value = objFieldTabEN.FldId;
            }
            else
            {
                lblTargetField.Text = sbFieldMsg.ToString();
                hfTargetFieldId.Value = objFieldTabEN.FldId;
            }
            tabQuery.Visible = false;
        }

        protected void btnSumbitReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hfTargetFieldId.Value) == true)
            {
                clsCommonJsFunc.Alert(this, "目标字段没有设置！");
                lblTargetField.CssClass = "ErrMsg";
                return;
            }
            if (string.IsNullOrEmpty(hfSourceFieldId.Value) == true)
            {
                clsCommonJsFunc.Alert(this, "源字段没有设置！");
                lblSourceField.CssClass = "ErrMsg";
                return;
            } 
            try
            {
                DataTable objDT = clsPrjTabFldBLEx.GetvPrjTab4IncludeSouTarField(hfSourceFieldId.Value, hfTargetFieldId.Value);
                if (objDT != null)
                {
                    tabPrjTab.Visible = true;
                    gvPrjTab.DataSource = objDT;
                    gvPrjTab.DataBind();
                }
                else
                {
                    //clsFldObjTabBLEx.ReplaceField(clsPubVar.CurrSelPrjId, hfSourceFieldId.Value, hfTargetFieldId.Value, clsCommonSession.UserId);
                    clsPrjTabFldBLEx.ReplaceField(clsPubVar.CurrSelPrjId, hfSourceFieldId.Value, hfTargetFieldId.Value, clsCommonSession.UserId);
                    clsSqlViewFldBLEx.ReplaceField(clsPubVar.CurrSelPrjId, hfSourceFieldId.Value, hfTargetFieldId.Value);
                    clsCommonJsFunc.Alert(this, "替换字段工作完成！");
                }
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

    }
    public partial class wfmFieldTab_ReplaceField : CommWebPageBase
    {
        private void CheckField()
        {
            string strWhereCond = CombineFieldTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsFieldTabEN> arrFieldTabObjList = clsFieldTabBL.GetObjLst(strWhereCond);
            foreach (clsFieldTabEN objFieldTabEN in arrFieldTabObjList)
            {
                clsFieldTabBLEx.CheckFieldTab(objFieldTabEN.FldId, clsPubVar.CurrSelPrjId);
            }
        }
        /// <summary>
        /// 复制字段
        /// </summary>
        private void CopyField()
        {
            string strMsg;
            //判断是否有选中的对象ID
            string strObjId = ddlTabIdq.SelectedValue;
            if (ddlTabIdq.SelectedIndex < 1)
            {
                strMsg = "请选择一个合适的对象名!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            ArrayList objArr = new ArrayList();
            objArr = clsCommForWebForm.Get_GvCheckedArr(this.gvFieldTab);
            try
            {
                //添加日志
                string strUserId = clsCommonSession.UserId;
                //				string strUserIp = Request.UserHostAddress;
                //string strUserName = clsUsersBL.GetObjByUserId(UserId).UserName;
                foreach (string strFldId in objArr)
                {
                    clsFieldTabEN objFieldTabEN = new clsFieldTabEN(strFldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    //clsFieldTabBLEx.CopyField2Bak20170705(clsPubVar.CurrSelPrjId, strFldId,
                    //    objFieldTabEN.FldName + "_Copy", strObjId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "复制字段不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            BindGv_FieldTab();

            //			Response.Write("<script>alert('所选字段已经删除！')</script>");

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