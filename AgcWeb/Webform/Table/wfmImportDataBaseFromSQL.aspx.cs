///----------------------
///生成代码版本：6.0.0.0
///生成日期：2007/11/21
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：2.4.0.0
///========================
///生成查询修改记录的控制层代码


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
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.sql;
using CommFunc4WebForm;


using System.Text;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;

using com.taishsoft.syspara;
using System.Diagnostics;
using com.taishsoft.datetime;
using AgcCommBase;

namespace AGC.Webform
{
    /// <summary>
    /// wfmTables_Q 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmImportDataBaseFromSQL : CommWebPageBase
    {

        //定义从外面传来的ObjId(对象ID)
        private string SqlDsTypeId
        {
            get
            {
                string strSqlDsTypeId = Request.QueryString["SqlDsTypeId"] ?? "".ToString();
                if ((strSqlDsTypeId != null) && (strSqlDsTypeId != ""))
                {
                    return strSqlDsTypeId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

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

                // 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
                ///wucTables1.SetDdl_TabName();
                //1、为下拉框设置数据源，绑定列表数据
                //2、显示无条件的表内容在DATAGRID中
                strSortTablesBy = "Name Asc";
                BindGv_Tables();
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
            this.gvTables.PageIndex = 0;

            //把表记录的内容显示在DATAGRID中
            BindGv_Tables();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvTables_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvTables.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_Tables();
        }
        
        protected void gvTables_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortTablesBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortTablesBy = e.SortExpression + " Asc";
                BindGv_Tables();
                return;
            }
            //检查原来是升序
            intIndex = strSortTablesBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortTablesBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortTablesBy = e.SortExpression + " Desc";
            }
            BindGv_Tables();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortTablesBy
        {
            get
            {
                string sSortTablesBy;
                sSortTablesBy = (string)ViewState["SortTablesBy"];
                if (sSortTablesBy == null)
                {
                    sSortTablesBy = "";
                }
                return sSortTablesBy;
            }
            set
            {
                string sSortTablesBy = value;
                ViewState.Add("SortTablesBy", sSortTablesBy);
            }
        }


        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvTables.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvTables.PageCount)
                {
                    this.gvTables.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_Tables();
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
                    BindGv_Tables();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvTables_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvTables, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvTables, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvTables_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvTables.PageIndex = e.NewPageIndex;
                this.BindGv_Tables();
            }
        }
        protected void btnGO2_Click(object sender, System.EventArgs e)
        {
            bool bolResult = true;         
            List<string> arrTableList = clsCommForWebForm.GetAllCheckedFldValueFromGv(gvTables, 1, "chkCheckRec");
            List<string> arrTableSqlDsTypeList = clsCommForWebForm.GetAllCheckedFldValueFromGv(gvTables, 2, "chkCheckRec");
            var arrSqlTable = new List<stuSqlTable>();
            int intCount = arrTableList.Count;
            for (int i = 0; i < intCount; i++)
            {
                var objSqlTable = new stuSqlTable();
                
                string strTabName = arrTableList[i].ToString();
                string strSqlDsTypeId = arrTableSqlDsTypeList[i].ToString() == "U" ? "01" : "02";
                objSqlTable.TabName = strTabName;
                objSqlTable.SqlTypeId = strSqlDsTypeId;
                arrSqlTable.Add(objSqlTable);
            }

            try
            {
                bolResult = clsPrjTabBLEx.ImportSqlTab(arrSqlTable, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId);
            }
            catch (Exception objException)
            {
                lblMsgList.Text = "导入数据表(视图)失败--添加对象失败。" + objException.Message;
                return;
            }
            if (bolResult == false) lblMsgList.Text = "导入数据表(视图)失败--添加对象失败。";
            else lblMsgList.Text = "导入数据表(视图)成功！";

        }

        protected void btnImportAllTables_Click(object sender, System.EventArgs e)
        {
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);

            bool bolResult = true;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            string strWhereCond = CombineTablesCondition();
            //获取数据库中所有的表
            DataTable objDT = objSQL.getTableAndViewsByCond(strWhereCond);
            //移除已存在的表
            RemoveExistedTabFromDT(ref objDT);

            string strTabName;
            string strSqlDsTypeId;
            string strTabId;

            string strObjFunction;
            string strFldCaption;
            string strFldName;
            string strFldType;
            string strTabCnName, strTabMemo;
            string strIsNull;
            int intFldLength;
            int intFldPrecision;

            bool bolIsNull;
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);

            foreach (DataRow row in objDT.Rows)
            {
                string strFuncModuleId = "";
                strTabName = row["name"].ToString();
                string strxType = row["xtype"].ToString();
                //strxType = "U";
                if (strxType.Trim() == "U")
                {
                    strSqlDsTypeId = "01";
                }
                else
                {
                    strSqlDsTypeId = "02";
                }
             //   strSqlDsTypeId = strxType == "U" ? "01" : "02";
                strTabId = row["id"].ToString();
                strObjFunction = strTabName;
                if (strSqlDsTypeId == "02")// 是视图
                {
                    string strRelaTabName = clsPrjTabBLEx.GetReleTabNameByViewName(strTabName);
                    if (string.IsNullOrEmpty( strRelaTabName) == true)
                    {
                        string strMsg = string.Format("视图表名：[{0}]的相关表名为空，请检查！", strTabName);
                        throw new Exception(strMsg);
                    }
                    string strCondition = string.Format("TabName='{0}' And PrjId='{1}'", strRelaTabName, clsPubVar.CurrSelPrjId);

                    clsPrjTabEN objRelePrjTab = clsPrjTabBL.GetFirstObj_S(strCondition);
                    if (objRelePrjTab == null)
                    {
                        strFuncModuleId = "";
                    }
                    else
                    {
                        strFuncModuleId = objRelePrjTab.FuncModuleAgcId;
                    }
                }
                strTabCnName = strTabName;
                strTabMemo = strTabName;
                strTabId = clsPrjTabBLEx.AddRecord(clsPubVar.CurrSelPrjId, objPrjDataBase.DataBaseName,
                    strTabName,
                    strTabCnName,
                    strTabMemo, strSqlDsTypeId, strFuncModuleId, clsCommonSession.UserId);
                if (string.IsNullOrEmpty(strTabId) == true)
                {
                    return;
                }
                //4、再向该视图对象表中添加相关字段。
                List<clsColumns> arrColumnObjList = clsSqlObject.GetColumnObjList(strTabName,
                   strConnectString,
                   objPrjDataBase.DatabaseOwner);
                foreach (clsColumns objColumn in arrColumnObjList)
                {
                    strFldName = objColumn.Column_Name;
                    strFldCaption = strFldName;
                    strFldType = objColumn.Type_Name;
                    intFldLength = objColumn.length;
                    intFldPrecision = objColumn.PRECISION;
                    strIsNull = objColumn.Is_Nullable;

                    bolIsNull = strIsNull == "NO" ? false : true;

                    string strFldId = clsFieldTabBLEx.ImportFldToFieldTab(strFldName,
                            strFldCaption,
                            strFldType,
                            intFldLength,
                             intFldPrecision,
                            bolIsNull,
                            clsPubVar.CurrSelPrjId,
                            clsCommonSession.UserId);
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTabId, strFldId, clsCommonSession.UserId);
                }
                //6、在表字段中添加相关字段。
                strTabId = clsPrjTabBLEx.GetTabId(clsPubVar.CurrSelPrjId, strTabName);
                try
                {
                    //bolResult = clsPrjTabFldBLEx.Add_ObjectFldtoPrjTabFld(strTabId);
                    clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN(clsPubVar.CurrPrjDataBaseId);
                    clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
                    string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(objPrjDataBaseEN);
                    List<clsPKeys> arrPKeysLst = clsSqlObject.GetPKeyObjList(strConnectionString, strTabName, objPrjDataBaseEN.DatabaseOwner);

                    foreach (clsPKeys objPKeys in arrPKeysLst)
                    {
                        strFldName = objPKeys.COLUMN_NAME;
                        string strCondition = string.Format("TabId='{0}' And FldName='{1}'", strTabId, strFldName);
                        clsvPrjTabFldEN objvPrjTabFld_Key = clsvPrjTabFldBL.GetFirstObj_S(strCondition);
                        if (objvPrjTabFld_Key != null)
                        {

                            bool bolIsIdentityColumn = clsSqlObject.IsIdentityColumn(strConnectionString, strTabName, objPrjDataBaseEN.DatabaseOwner, strFldName);
                            clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN(objvPrjTabFld_Key.mId);
                            objPrjTabFldEN.FieldTypeId = "02";

                            if (bolIsIdentityColumn == true)
                            {
                                objPrjTabFldEN.PrimaryTypeId = "02";
                            }
                            else
                            {
                                objPrjTabFldEN.PrimaryTypeId = "01";
                            }

                            clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                        }
                    }
                }
                catch (Exception objException)
                {
                    lblMsgList.Text = "导入数据表(视图)失败。" + objException.Message;
                }
                if (bolResult == true)
                {
                    lblMsgList.Text = "导入数据表(视图)成功！";
                }

            }
            //操作步骤：
            //1、获取教务管理结构表中的所有记录MId,并对这些记录进行循环：
            //2、针对每条记录：
            //3、添加对象信息，在添加时需要检查是否重复；
            //4、再向该视图对象表中添加相关字段。
            //5、向表中添加该表记录；
            //6、在表字段中添加相关字段。
            ///
        }

        protected void gvTables_RowCreated(object sender, GridViewRowEventArgs e)
        {
            int intIndex;
            if (strSortTablesBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvTables.Columns.Count; i++)
                {
                    strSortEx = this.gvTables.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortTablesBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortTablesBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }

        }

    }
    /// <summary>
    /// wfmTables_Q 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmImportDataBaseFromSQL : CommWebPageBase
    {

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


        ///生成专门用于BINDgv中的跳页相关代码


        //生成错误信息的Session属性
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


        //生成错误信息的Session属性
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
        protected string CombineTablesCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " And Name like '" + this.txtTabNameq.Text.Trim() + "%'";
            }
            if (this.txtXtypeq.Text.Trim() != "")
            {
                strWhereCond += " And xtype = '" + this.txtXtypeq.Text.Trim() + "'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_Tables()
        {
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(clsPubVar.CurrPrjDataBaseId);
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            lblMsgList.Text = "";
            //	1、组合界面条件串；
            string strWhereCond = CombineTablesCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
                clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN(clsPubVar.CurrPrjDataBaseId);
                clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
                objDT = objSQL.getTableAndViewsByCond(strWhereCond);

                RemoveExistedTabFromDT(ref objDT);

                //objDT = clsTables.GetTables(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortTablesBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                              ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvTables.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvTables.PageSize = 10;
            }
            this.gvTables.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvTables.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvTables.BottomPagerRow;
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
                lblAllPages.Text = this.gvTables.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvTables.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvTables.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvTables.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvTables.PageIndex == this.gvTables.PageCount - 1)
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
            gvTables.BottomPagerRow.Visible = true;
        }

        /// <summary>
        /// 剔除DT中已存在的生成代码中的表名
        /// </summary>
        /// <param name="objDT"></param>
        /// <param name="strSqlDsTypeId"></param>
        /// <returns></returns>
        private bool RemoveExistedTabFromDT(ref DataTable objDT)
        {
            List<clsvPrjTabEN> arrPrjTabObjLst = null;

            arrPrjTabObjLst = clsvPrjTabBLEx.GetPrjTabViewObjLst(clsPubVar.CurrSelPrjId);

            //arrPrjTabObjLst = clsPrjTabBLEx.GetPrjViewObjLst(clsPubVar.CurrSelPrjId);

            foreach (clsvPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                string strTabName_S = objPrjTabEN.TabName.ToLower().Trim();
                foreach (DataRow objDR in objDT.Rows)
                {
                    string strTabName_T = objDR["name"].ToString().ToLower().Trim();
                    if (strTabName_S == strTabName_T)
                    {
                        objDT.Rows.Remove(objDR);
                        break;
                    }
                }
            }
            return true;
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