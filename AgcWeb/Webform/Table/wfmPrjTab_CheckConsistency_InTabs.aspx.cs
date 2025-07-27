using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using CommFunc4WebForm;
using com.taishsoft.sql;


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AGC.Entity;



using com.taishsoft.datetime;
using com.taishsoft.common;
using AutoGCLib;


namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTabFld_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPrjTab_CheckConsistency_InTabs : CommWebPageBase
    {
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
        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (clsPubFun4BLEx.TestConnectString(clsPubVar.CurrPrjDataBaseId) == false)
            {
                if (string.IsNullOrEmpty(clsPubVar.CurrPrjDataBaseId) == true)
                {
                    clsCommonJsFunc.Alert(this, "PrjDataBaseId 为空,请设置一个合法的PrjDataBaseId(工程数据库号)!");
                    return;
                }
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsCommonJsFunc.Alert(this, string.Format("指向IP:{0}的数据库连接不可用，请检查！", objPrjDataBaseEN.IpAddress));
                return;
            }
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                InitParentPageInfo();
                clsPrjTabBLEx.InitdicPrjTabLst();
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
                InitParentPageInfo();
                               
                vsTabId = clsCommonSession.TabId;
                //if (string.IsNullOrEmpty(vsTabId) == true) return;
                clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetObjByTabIdEx(vsTabId);
                string strTabName = objPrjTabEN.TabName;
                string strTabCnName = objPrjTabEN.TabCnName;
                vsSqlDsTypeId = objPrjTabEN.SqlDsTypeId;
                if (objPrjTabEN.SqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    clsPubFun.SetButtonEnabled(btnGenNewTabInSQL, false);
                    btnGenNewTabInSQL.Visible = false;
                    btnCreateView4Sql.Visible = true;
                    btnCreateView4Sql1.Visible = true;
                    btnAnalysis.Visible = true;
                    btnImportSqlViewFromSqlServer.Visible = true;
                }
                else
                {
                    //clsPubFun.SetButtonEnabled(btnCheckSqlView, false);
                    clsPubFun.SetButtonEnabled(btnCheckSqlView0, false);

                    btnCheckSqlView.Visible = false;
                    btnCheckSqlView0.Visible = false;
                    btnCreateView4Sql.Visible = false;
                    btnCreateView4Sql1.Visible = false;
                    btnAnalysis.Visible = false;
                    btnImportSqlViewFromSqlServer.Visible = false;
                }
              
                try
                {
                    clsTabCheckStatusBLEx.CheckTabForeignKeyByTabName(objPrjTabEN.PrjId, clsPubVar.CurrPrjDataBaseId, strTabName, clsCommonSession.UserId);
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
                //1、为下拉框设置数据源，绑定列表数据
                strSortPrjTabFld_AgcBy = "FldName Asc";
                strSortPrjTabFld_SqlBy = "Column_Name Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_PrjTabFld_Agc();
                try
                {
                    BindGv_PrjTabFld_Sql();
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
                //检查一致性
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                ///   
                string strRoleId = clsCommonSession.RoleId;
                if (strRoleId == "00050001"
                    || strRoleId == "00050002" || strRoleId == "00050006")
                {
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnDelRec, false);
                    clsPubFun.SetButtonEnabled(btnDelField_Sql, false);
                }

            }
        }
        private string vsTabId
        {
            get
            {
                string strTabId;
                strTabId = (string)ViewState["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                ViewState.Add("TabId", strTabId);
            }
        }

        private string qsTabId
        {
            get
            {
                if (Request.QueryString["TabId"] != null)
                {
                    return Request.QueryString["TabId"].ToString().Trim();
                }
                return "";
            }
        }
        /// <summary>
        /// Sql数据类型Id
        /// </summary>
        private string vsSqlDsTypeId
        {
            get
            {
                string strSqlDsTypeId;
                strSqlDsTypeId = (string)ViewState["SqlDsTypeId"];
                if (strSqlDsTypeId == null)
                {
                    strSqlDsTypeId = "";
                }
                return strSqlDsTypeId;
            }
            set
            {
                string strSqlDsTypeId = value;
                ViewState.Add("SqlDsTypeId", strSqlDsTypeId);
            }
        }


        private string FldId
        {
            get
            {
                string strFldId;
                strFldId = (string)Session["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                Session.Add("FldId", strFldId);
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


        
        ///// <summary>
        ///// 登录的用户ID，用于检查用户权限
        ///// </summary>
        //protected string vsUserId
        //{
        //    get
        //    {
        //        string strUserId;
        //        strUserId = (string)ViewState["UserId"];
        //        if (strUserId == null)
        //        {
        //            strUserId = "";
        //        }
        //        return strUserId;
        //    }
        //    set
        //    {
        //        string strUserId = value;
        //        ViewState.Add("UserId", strUserId);
        //    }
        //}
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


        ///生成专门用于BINDgv中的跳页相关代码


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
        //生成返回链接串的Session属性
        protected string BackPageLinkStrFromUpdField
        {
            get
            {
                string strBackPageLinkStrFromUpdField;
                strBackPageLinkStrFromUpdField = (string)Session["BackPageLinkStrFromUpdField"];
                if (strBackPageLinkStrFromUpdField == null)
                {
                    strBackPageLinkStrFromUpdField = "";
                }
                return strBackPageLinkStrFromUpdField;
            }
            set
            {
                string strBackPageLinkStrFromUpdField = value;
                Session.Add("BackPageLinkStrFromUpdField", strBackPageLinkStrFromUpdField);
            }
        }


        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_PrjTabFld_Agc()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = string.Format("TabId='{0}' and {1}='0'", vsTabId, convPrjTabFld.IsForExtendClass);    // CombinePrjTabFldCondion();            
                                                                                                                        //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFld_AgcBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            this.gvPrjTabFld_Agc.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvPrjTabFld_Agc.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvPrjTabFld_Agc.BottomPagerRow;
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
            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvPrjTabFld_Agc.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvPrjTabFld_Agc.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvPrjTabFld_Agc.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvPrjTabFld_Agc.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvPrjTabFld_Agc.PageIndex == this.gvPrjTabFld_Agc.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
            }
        }

        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_PrjTabFld_Sql()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            //            string strWhereCond = "TabId='" + vsTabId + "'";    // CombinePrjTabFldCondition();
            string strTabName = clsPrjTabBLEx.GetObjByTabIdEx(getTabId).TabName;

            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                if (objPrjDataBase.DataBaseTypeId == "03") //ORACLE数据库
                {
                    //clsTablesEx objTables = new AGC.LogicEx.oracle.clsTablesEx();
                    //objTables.PrjId = clsPubVar.CurrSelPrjId;
                    //string strOwner = objPrjDataBase.DatabaseOwner;
                    //try
                    //{
                    //    objDT = objTables.GetColumns(strTabName, strOwner);
                    //}
                    //catch (Exception objException)
                    //{
                    //    clsGeneralTab.LogErrorS(objException, "wfmPrjTab_CheckConsistency");
                    //    lblMsgList.Text = objException.Message;
                    //    return;
                    //}
                }
                else
                {
                    //clsTablesBLEx objTables = new clsTablesBLEx();
                    //objTables.PrjDataBaseId = clsPubVar.CurrPrjDataBaseId;
                    //string strOwner = objPrjDataBase.DatabaseOwner;
                    try
                    {
                        objDT = clsTablesBLEx.GetColumns(strTabName, clsPubVar.CurrPrjDataBaseId);
                    }
                    catch (Exception objException)
                    {
                        clsGeneralTab.LogErrorS(objException, "wfmPrjTab_CheckConsistency");
                        StringBuilder sbMsg = new StringBuilder();
                        sbMsg.AppendFormat("在获取表字段（GetColumns）时出错！表名：{0},出错信息：{1}。", strTabName, objException.Message);

                        lblMsgList.Text = sbMsg.ToString();
                        return;
                    }
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            if (objDT.Rows.Count == 0)
            {
                //tabSQL.Visible = false;

                divNewTab.Visible = true;
            }
            else
            {

                divNewTab.Visible = false;
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFld_SqlBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            this.gvPrjTabFld_Sql.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvPrjTabFld_Sql.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvPrjTabFld_Sql.BottomPagerRow;
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
            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvPrjTabFld_Sql.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvPrjTabFld_Sql.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvPrjTabFld_Sql.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvPrjTabFld_Sql.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvPrjTabFld_Sql.PageIndex == this.gvPrjTabFld_Sql.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
            }
        }

        /// <summary>
        /// 功能：计算DataGrid的页数
        /// </summary>
        /// <param name="intRecCount">总共的记录数</param>
        /// <param name="intPageSize">每页的记录数</param>
        /// <returns>计算出来的页数</returns>
        protected int CalcPages(int intRecCount, int intPageSize)
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
            this.gvPrjTabFld_Agc.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_PrjTabFld_Agc();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvPrjTabFld_Agc.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_PrjTabFld_Agc();
        }

        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjTabFld_Sql_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvPrjTabFld_Sql.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_PrjTabFld_Sql();
        }

        ///生成GridView行命令的事件代码
        protected void gvPrjTabFld_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Agc, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Agc, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvPrjTabFld_Sql_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Sql, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld_Sql, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }



        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {


        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //	1、组合界面条件串；
            string strWhereCond = "TabId='" + vsTabId + "'";   // CombinePrjTabFldCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PrjTabFld信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("mId"); arrCnName.Add("mId");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("是否唯一");
            arrColName.Add("FieldTypeName"); arrCnName.Add("FieldTypeName");
            arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("DataTypeId"); arrCnName.Add("字段类型");
            arrColName.Add("FldLength"); arrCnName.Add("字段长度");
            arrColName.Add("Caption"); arrCnName.Add("标题");
            arrColName.Add("SequenceNumber"); arrCnName.Add("顺序号");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            arrColName.Add("ForeignTabName"); arrCnName.Add("ForeignTabName");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("主键类型名");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
            arrColName.Add("IsTabNullable"); arrCnName.Add("是否表中可空");
            arrColName.Add("DefaultValue"); arrCnName.Add("缺省值");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            DownLoadFile(strDownLoadFileName);
        }
        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        protected bool DownLoadFile(string strDownLoadFileName)
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

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
            if (arrmId == null || arrmId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsPrjTabFldBL.DelPrjTabFlds(arrmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjTabFld_Agc();
        }


        protected void gvPrjTabFld_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortPrjTabFld_AgcBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFld_AgcBy = e.SortExpression + " Asc";
                BindGv_PrjTabFld_Agc();
                return;
            }
            //检查原来是升序
            intIndex = strSortPrjTabFld_AgcBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortPrjTabFld_AgcBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortPrjTabFld_AgcBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTabFld_Agc();
        }

        protected void gvPrjTabFld_Sql_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortPrjTabFld_SqlBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFld_SqlBy = e.SortExpression + " Asc";
                BindGv_PrjTabFld_Sql();
                return;
            }
            //检查原来是升序
            intIndex = strSortPrjTabFld_SqlBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortPrjTabFld_SqlBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortPrjTabFld_SqlBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTabFld_Sql();
        }

        protected string strSortPrjTabFld_AgcBy
        {
            get
            {
                string sSortPrjTabFld_AgcBy;
                sSortPrjTabFld_AgcBy = (string)ViewState["SortPrjTabFld_AgcBy"];
                if (sSortPrjTabFld_AgcBy == null)
                {
                    sSortPrjTabFld_AgcBy = "";
                }
                return sSortPrjTabFld_AgcBy;
            }
            set
            {
                string sSortPrjTabFld_AgcBy = value;
                ViewState.Add("SortPrjTabFld_AgcBy", sSortPrjTabFld_AgcBy);
            }
        }
        protected string strSortPrjTabFld_SqlBy
        {
            get
            {
                string sSortPrjTabFld_SqlBy;
                sSortPrjTabFld_SqlBy = (string)ViewState["SortPrjTabFld_SqlBy"];
                if (sSortPrjTabFld_SqlBy == null)
                {
                    sSortPrjTabFld_SqlBy = "";
                }
                return sSortPrjTabFld_SqlBy;
            }
            set
            {
                string sSortPrjTabFld_SqlBy = value;
                ViewState.Add("SortPrjTabFld_SqlBy", sSortPrjTabFld_SqlBy);
            }
        }


        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPrjTabFld_Agc.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPrjTabFld_Agc.PageCount)
                {
                    this.gvPrjTabFld_Agc.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PrjTabFld_Agc();
            }
        }
        ///删除记录过程代码for C#
        protected void DeletePrjTabFldRecord(long lngmId)
        {
            try
            {
                clsPrjTabFldBLEx.DelRecordEx(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjTabFld_Agc();
        }
        ///删除记录过程代码for C#
        protected void gvPrjTabFld_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTabFld_Agc.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTabFld_Agc();
            }
        }
        ///删除记录过程代码for C#
        protected void gvPrjTabFld_Sql_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTabFld_Sql.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTabFld_Sql();
            }
        }

        ///删除记录过程代码for C#
        protected void gvPrjTabFld_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPrjTabFld_AgcBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTabFld_Agc.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTabFld_Agc.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFld_AgcBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortPrjTabFld_AgcBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///删除记录过程代码for C#
        protected void gvPrjTabFld_Sql_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPrjTabFld_SqlBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTabFld_Sql.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTabFld_Sql.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFld_SqlBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortPrjTabFld_SqlBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        protected void btnReCheckConSistency_Click(object sender, EventArgs e)
        {
            BindGv_PrjTabFld_Agc();
            BindGv_PrjTabFld_Sql();
            //检查一致性
            clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);
            clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabIdEx(vsTabId);
            objPrjTab.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTab.UpdUserId = clsCommonSession.UserId;
            if (string.IsNullOrEmpty(objPrjTab.RelaTabId4View) == true) objPrjTab.RelaTabId4View = null;
            clsPrjTabBL.UpdateBySql2(objPrjTab);
        }
        protected void lbReturn_Click(object sender, EventArgs e)
        {
            JumpOtherPages("wfmEditTabAndObjectFields.aspx");
            //if (clsCommonSession.ParentPage == "wfmEditTabAndObjectFields")
            //{
          
            //}

        }
        protected void btnAddNewField_Click(object sender, EventArgs e)
        {
            //操作步骤：
            //1、找到所选SQL数据字段，并生成相应的类对象
            //2、把类对象列表传递到表字段类中，并添加到相应的表
            ///
            try
            {
                //1、找到所选SQL数据字段，并生成相应的类对象
                ArrayList arrColumnsObjList = Get_GvCheckedObjArr(gvPrjTabFld_Sql);
                //2、把类对象列表传递到表字段类中，并添加到相应的表
                clsPrjTabFldBLEx.ImportFieldFromColumnObjList(vsTabId, arrColumnsObjList, clsCommonSession.UserId);

                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_Sql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);
                if (vsSqlDsTypeId == clsSQLDSTypeENEx.SQLVIEW)
                {
                    try
                    {
                        string strSqlViewId = "";
                        try
                        {
                            strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                        }
                        catch (Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(vsTabId, clsPubVar.CurrSelPrjId);
                            clsSqlViewBLEx.ImportSqlViewBySqlViewName(clsPubVar.CurrSelPrjId, objPrjTabEN.TabName, clsCommonSession.UserId);
                            strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                        }
                        clsSqlViewBLEx.ImportSqlViewFromSqlServer(clsPubVar.CurrSelPrjId, strSqlViewId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId);
                        clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
                        string strRelaTabId = vsTabId;
                        if (string.IsNullOrEmpty(strRelaTabId) == false)
                        {
                            clsTabCheckResultBLEx.DeleteErrorResult(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, strRelaTabId, "15", "", clsCommonSession.UserId);
                        }   
                    }
                    catch (Exception objException)
                    {
                        clsPubVar.objLog.WriteDebugLog(objException.Message);
                    }
                }
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(vsTabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);
                clsPrjTabBLEx.SetUpdDate(vsTabId);
                clsCommonJsFunc.Alert(this, "添加字段成功！");
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }
        private ArrayList Get_GvCheckedObjArr(System.Web.UI.WebControls.GridView objGv)
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
                    CheckBox cb = (CheckBox)di.Cells[0].FindControl("chkCheckRec");
                    if (cb != null && cb.Checked)
                    {
                        clsColumns objColumns = new clsColumns();
                        objColumns.Column_Name = objGv.DataKeys[iRow].Value.ToString();
                        objColumns.Type_Name = di.Cells[2].Text.ToString();
                        if (objColumns.Type_Name == "decimal")
                        {
                            objColumns.length = int.Parse(di.Cells[3].Text.ToString());
                            objColumns.PRECISION = int.Parse(di.Cells[4].Text.ToString());
                        }
                        else
                        {
                            objColumns.length = int.Parse(di.Cells[3].Text.ToString());
                        }

                        objColumns.Is_Nullable = di.Cells[5].Text.ToString();
                        arr.Add(objColumns);
                    }
                }
                return arr;
                //foreach (GridViewRow li in objGv.Rows)
                //{

                //    CheckBox cb = (CheckBox)li.Cells[0].FindControl("chkCheckRec");
                //    if (cb != null && cb.Checked)
                //    {
                //        arr.Add(li.Cells[1].Text);
                //    }
                //}
                //return arr;
            }
        }

        protected void btnGenNewTabInSQL_Click(object sender, EventArgs e)
        {


            lblMsgList.Text = "";
            string strTabId = vsTabId;
            if (strTabId == null || strTabId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }

            try
            {
                Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                if (myEncoding == null)
                {
                    string strMsg = string.Format("用户：{0}, 工程：{1}对应的编码为空！", clsCommonSession.UserId, clsPubVar.CurrSelPrjId);
                    throw new Exception(strMsg);
                }
                string strCharEncodingId = "";
                try
                {
                    strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在根据用户：{0}, 工程：{1}对应的编码Id时出错！[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
              

                bool bolIsSuccess = false;
                try
                {
                    bolIsSuccess = clsPrjTabBLEx_GeneCode.GenSQLCode4CreateTab(strTabId,                        clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在生成建表文本时出错：[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                //txtCode_Sim.Text = strCodeText_Sim;


                divNewTab.Visible = false;

                lblMsg2.Text = "新建表成功!";

                string strCondition_Del = string.Format("TabId ='{0}'", strTabId);
                try
                {
                    clsTabCheckResultBL.DelTabCheckResultsByCond(strCondition_Del);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在删除表检查结果出错：[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在新建表时出错：{0}({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                if (objException.Message.Length < 30)
                {
                    lblMsg2.Text = strMsg;
                    clsCommonJsFunc.Alert(this, strMsg);
                }
                else
                {
                    //clsCommonSession.seErrMessage = objException.Message;
                    //clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                    //clsPubFun4Web.AccessError(this, conCurrPageName);
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }

        }
        protected void btnSetFldProperty_Click(object sender, EventArgs e)
        {
            JumpOtherPages("FieldTab_U");
        }
        protected void btnAddFieldToSqlTable_Click(object sender, EventArgs e)
        {
            //操作步骤：
            //1、找到所选生成代码系统中数据字段，并生成相应的关键字列表
            //2、把所选的系统表字段，添加到相应的SQL表中
            ///
            try
            {
                //1、找到所选生成代码系统中数据字段，并生成相应的关键字列表
                List<string> arrTabFieldObjList = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
                //2、把所选的系统表字段，添加到相应的SQL表中
                clsPrjTabBLEx.AlterTab4AddField(arrTabFieldObjList, clsPubVar.CurrPrjDataBaseId);
            }
            catch (Exception objException)
            {
                string strMsg = "把所选的系统表字段，添加到相应的SQL表中有问题！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //3、重新检查两间之间的一致性
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_Sql();
            }
            catch (Exception objException)
            {
                string strMsg = "绑定GridView有问题！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = "检查生成代码中表字段与Sql数据库中表字段是否一致！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(vsTabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);

            }
            catch (Exception objException)
            {
                string strMsg = "根据数据库中相关表来检查生成代码中的表对象字段，例如主键和相关字段！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        protected void btnSynchFldInfo_Click(object sender, EventArgs e)
        {
            //把生成代码系统中的字段信息同步到SQL表字段中

            //操作步骤：
            //1、找到所选生成代码系统中数据字段，并生成相应的关键字列表
            //2、把所选的系统表字段，添加到相应的SQL表中
            ///
            try
            {
                //1、找到所选生成代码系统中数据字段，并生成相应的关键字列表
                List<string> arrTabFieldObjList = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
                //2、把所选的系统表字段，添加到相应的SQL表中
                clsPrjTabBLEx.AlterTab4UpdateField(arrTabFieldObjList, clsPubVar.CurrPrjDataBaseId);
            }
            catch (Exception objException)
            {
                string strMsg = "同步字段信息有问题！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //3、重新检查两间之间的一致性
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_Sql();
            }
            catch (Exception objException)
            {
                string strMsg = "绑定GridView有问题！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);

            }
            catch (Exception objException)
            {
                string strMsg = "检查生成代码中表字段与Sql数据库中表字段是否一致！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(vsTabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);

            }
            catch (Exception objException)
            {
                string strMsg = "根据数据库中相关表来检查生成代码中的表对象字段，例如主键和相关字段！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }
        protected void btnSynchFldInfoToAgc_Click(object sender, EventArgs e)
        {
            //操作步骤：
            //1、找到所选SQL数据字段，并生成相应的类对象
            //2、把类对象列表传递到表字段类中，并添加到相应的表
            //
            try
            {
                //1、找到所选SQL数据字段，并生成相应的类对象
                ArrayList arrColumnsObjList = Get_GvCheckedObjArr(gvPrjTabFld_Sql);
                //2、把类对象列表传递到表字段类中，并添加到相应的表
                clsPrjTabFldBLEx.SynchFieldFromColumnObjList(vsTabId, arrColumnsObjList);
                ///
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_Sql();

                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(vsTabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);
                clsPrjTabBLEx.SetUpdDate(vsTabId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
        }
        protected void btnDelRec_Click(object sender, EventArgs e)
        {
            //把生成代码系统中的字段信息同步到SQL表字段中

            //操作步骤：
            //1、找到所选生成代码系统中数据字段，并生成相应的关键字列表
            //2、把所选的系统表字段，添加到相应的SQL表中
            ///
            try
            {
                //1、找到所选生成代码系统中数据字段，并生成相应的关键字列表
                List<string> arrTabFieldObjList = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjTabFld_Agc, "chkCheckRec");
                //2、把所选的系统表字段，添加到相应的SQL表中
                foreach (string strMid in arrTabFieldObjList)
                {
                    long lngMid = long.Parse(strMid);
                    //从相关对象中删除该字段
                    clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMid);
                    //string strObjId = clsPrjTabBLEx.GetObjByTabIdEx(objPrjTabFld.TabId).ObjId;
                    //clsFldObjTabBLEx.DelObjFld(strObjId, objPrjTabFld.FldId);

                    clsPrjTabFldBLEx.DelRecordEx(lngMid);
                }
                //3、重新检查两间之间的一致性
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_Sql();
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(vsTabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);
                clsPrjTabBLEx.SetUpdDate(vsTabId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnDelField_Sql_Click(object sender, EventArgs e)
        {
            //操作步骤：
            //1、找到所选SQL数据字段，并生成相应的类对象
            //2、把类对象列表传递到表字段类中，并添加到相应的表
            ///
            try
            {
                //1、找到所选SQL数据字段，并生成相应的类对象
                ArrayList arrColumnsObjList = Get_GvCheckedObjArr(gvPrjTabFld_Sql);
                //2、删除表字段
                clsPrjTabBLEx.AlterTab4DropColumn(vsTabId, arrColumnsObjList, clsPubVar.CurrPrjDataBaseId);
            }
            catch (Exception objException)
            {
                string strMsg = "删除表字段有问题！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {       ///
                BindGv_PrjTabFld_Agc();
                BindGv_PrjTabFld_Sql();
            }
            catch (Exception objException)
            {
                string strMsg = "绑定GridView有问题！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsCheckConsistency.CheckConsistency(gvPrjTabFld_Agc, gvPrjTabFld_Sql, vsTabId, clsPubVar.CurrSelPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = "检查生成代码中表字段与Sql数据库中表字段是否一致！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(vsTabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId);

            }
            catch (Exception objException)
            {
                string strMsg = "根据数据库中相关表来检查生成代码中的表对象字段，例如主键和相关字段！" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnCheckSqlView_Click(object sender, EventArgs e)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBLEx.GetObjByTabIdEx(vsTabId);
            string strTabName = objPrjTabEN.TabName;
            if (objPrjTabEN.SqlDsTypeId != clsSQLDSTypeENEx.SQLVIEW) return;
            string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                    conSqlView.PrjId, clsPubVar.CurrSelPrjId,
                  conSqlView.RelaTabId, vsTabId);
            if (clsSqlViewBL.IsExistRecord(strCondition) == false)
            {
                clsSqlViewBLEx.ImportSqlViewBySqlViewName(clsPubVar.CurrSelPrjId, strTabName, clsCommonSession.UserId);
            }
            string strSqlViewId = clsSqlViewBL.GetFirstID_S(strCondition);
            //string strHtml = "../SqlViewMan/wfmSqlViewB_QUDI.aspx?SqlViewId=" + strSqlViewId;
            //Response.Redirect(strHtml);
            string strHtml = string.Format("OpenwfmSqlViewB_QUDI('{0}');", strSqlViewId);
            this.ClientScript.RegisterStartupScript(this.GetType(), "btnCheckSqlView_Click", strHtml, true);

            //编辑教学行为分析，弹出窗口来编辑EditTeachingActivityType

        }

        protected void btnCreateView4Sql_Click(object sender, EventArgs e)
        {

            try
            {
                string strCondition = string.Format("{0}='{1}'", conSqlView.RelaTabId, vsTabId);
                clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetFirstObj_S(strCondition);
                if (objSqlViewEN == null)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBLEx.GetObjByTabIdEx(vsTabId);
                    string strMsg = string.Format("表名：{0}({1})没有相关的SqlView,请检查！", objPrjTab.TabName, objPrjTab.TabCnName);

                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                string strSqlViewId = objSqlViewEN.SqlViewId;
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

            clsCommonJsFunc.Alert(this, "在Sql中建立视图成功！");
        }

        protected void btnImportSqlViewFromSqlServer_Click(object sender, EventArgs e)
        {
            try
            {
                string strSqlViewId = "";
                try
                {
                    strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                }
                catch (Exception objException)
                {

                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(vsTabId, clsPubVar.CurrSelPrjId);
                    clsSqlViewBLEx.ImportSqlViewBySqlViewName(clsPubVar.CurrSelPrjId, objPrjTabEN.TabName, clsCommonSession.UserId);
                    strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                }
                clsSqlViewBLEx.ImportSqlViewFromSqlServer(clsPubVar.CurrSelPrjId, strSqlViewId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId);
                clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);

                clsCommonJsFunc.Alert(this, "导入Sql视图并分析字段成功！");
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                string strSqlViewId = clsSqlViewBLEx.GetSqlViewIdByTabIdCache(clsPubVar.CurrSelPrjId, vsTabId);
                clsSqlViewBLEx.FieldAnalysis(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                clsSqlViewBLEx.GeneSqlView(strSqlViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
       
                string strRelaTabId = clsSqlViewBLEx.GetRelaTabIdBySqlViewIdCache(clsPubVar.CurrSelPrjId, strSqlViewId);
                if (string.IsNullOrEmpty(strRelaTabId) == false)
                {
                    clsTabCheckResultBLEx.DeleteErrorResult(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, strRelaTabId, "15", "", clsCommonSession.UserId);
                }
                clsCommonJsFunc.Alert(this, "分析字段成功！");
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void lbReturnPrjTabList_Click(object sender, EventArgs e)
        {
            //Response.Redirect(@"wfmPrjTab_QUDI3.aspx");
            ReturnParentPage();
        }
        protected string getTabId
        {
            get
            {
                if (string.IsNullOrEmpty(vsTabId) == false) return vsTabId;
                if (string.IsNullOrEmpty(qsTabId) == false) return qsTabId;
                if (string.IsNullOrEmpty(clsCommonSession.TabId) == false) return clsCommonSession.TabId;
                return "";
            }
            set
            {
                clsCommonSession.UserId4get = value;
            }
        }
        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            string strParentPage = qsParentPage;
            strParentPage = strParentPage.Replace("wfmEditTabAndObjectFields.aspx","").Replace("||","|");
            vsParentPage = PretreatmentParentPage(strParentPage);
            switch (vsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    break;
                case "wfmEditTabAndObjectFields.aspx":
                    //lbReturnPrjTabList.Text = "返回[表字段列表]";
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":
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
           // vsParentPage = PretreatmentParentPage(qsParentPage);
            switch (vsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                   
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
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (strPageName)
            {
                case "wfmEditTabAndObjectFields.aspx":
                    string strTabId = clsCommonSession.TabId;
                    if (string.IsNullOrEmpty(strTabId) == false)
                    {
                        clsPubFun4Web.JumpToEditTabAndFields(this, strTabId, strCurrPageName);                                            
                    }
                    break;
                case "FieldTab_U":
                    string strMid;
                    long lngMid;        //当前所选记录的关键字MId
                                        //1、获取当前所选中的字段ID。
                    strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld_Agc);
                    if (strMid.Trim().Length == 0)
                    {
                        lblMsgList.Text = "没有选择记录，请选择一个有效的字段记录!";
                        return;
                    }
                    lngMid = long.Parse(strMid);
                    string strFldId = clsPrjTabFldBL.GetObjBymId(lngMid).FldId;
                    FldId = strFldId;
                    BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToFieldTab_U(this, "", strFldId, strCurrPageName);
                    break;

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