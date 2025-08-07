using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


///----------------------
///生成代码版本：8.2.0.0
///生成日期：2009/06/13
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.01.02.2
///========================
///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjDataBase_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPrjDataBase_QUDI : CommWebPageBase
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
                wucPrjDataBase1.SetDdl_DataBaseTypeId();
                wucPrjDataBase1.SetDdl_UseStateId();
                
                BindDdl_DataBaseTypeId(ddlDataBaseTypeIdq);
                clsUseStateBL.BindDdl_UseStateId(ddlUseStateId);
                ddlUseStateId.SelectedValue = "0001";
                strSortPrjDataBaseBy = "PrjDataBaseId Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_PrjDataBase();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucPrjDataBase1.SetKeyReadOnly(true);
                DispPrjDataBaseListRegion();
                //clsCommonSession.UserId;
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
            this.gvPrjDataBase.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_PrjDataBase();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjDataBase_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvPrjDataBase.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_PrjDataBase();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strPrjDataBaseId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsPrjDataBaseEN objPrjDataBase;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddPrjDataBaseRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddPrjDataBaseRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objPrjDataBase = (clsPrjDataBaseEN)Session["objPrjDataBase"];
                    UpdatePrjDataBaseRecordSave(objPrjDataBase);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucPrjDataBase1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            lblMsgEdit.Text = "";
            wucPrjDataBase1.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
            DispEditPrjDataBaseRegion();
        }

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> arrPrjDataBaseId = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjDataBase, "chkCheckRec");
            if (arrPrjDataBaseId == null || arrPrjDataBaseId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsPrjDataBaseBL.DelPrjDataBases(arrPrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjDataBase();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strPrjDataBaseId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjDataBase);
            if (strPrjDataBaseId == null || strPrjDataBaseId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdatePrjDataBaseRecord(strPrjDataBaseId);
        }
        
        protected void gvPrjDataBase_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortPrjDataBaseBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjDataBaseBy = e.SortExpression + " Asc";
                BindGv_PrjDataBase();
                return;
            }
            //检查原来是升序
            intIndex = strSortPrjDataBaseBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortPrjDataBaseBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortPrjDataBaseBy = e.SortExpression + " Desc";
            }
            BindGv_PrjDataBase();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortPrjDataBaseBy
        {
            get
            {
                string sSortPrjDataBaseBy;
                sSortPrjDataBaseBy = (string)ViewState["SortPrjDataBaseBy"];
                if (sSortPrjDataBaseBy == null)
                {
                    sSortPrjDataBaseBy = "";
                }
                return sSortPrjDataBaseBy;
            }
            set
            {
                string sSortPrjDataBaseBy = value;
                ViewState.Add("SortPrjDataBaseBy", sSortPrjDataBaseBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPrjDataBase.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPrjDataBase.PageCount)
                {
                    this.gvPrjDataBase.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PrjDataBase();
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
                    BindGv_PrjDataBase();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvPrjDataBase_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjDataBase, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjDataBase, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvPrjDataBase_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPrjDataBaseBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjDataBase.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjDataBase.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjDataBaseBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortPrjDataBaseBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvPrjDataBase_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strPrjDataBaseId = gvPrjDataBase.DataKeys[e.RowIndex].Value.ToString();
            DeletePrjDataBaseRecord(strPrjDataBaseId);
        }
        ///
        protected void gvPrjDataBase_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strPrjDataBaseId = gvPrjDataBase.DataKeys[e.RowIndex].Value.ToString();
            UpdatePrjDataBaseRecord(strPrjDataBaseId);
        }
        ///删除记录过程代码for C#
        protected void gvPrjDataBase_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjDataBase.PageIndex = e.NewPageIndex;
                this.BindGv_PrjDataBase();
            }
        }
        ///
        protected void btnCancelPrjDataBaseEdit_Click(object sender, EventArgs e)
        {
            DispPrjDataBaseListRegion();
        }

        protected void btnTestConnect_Click(object sender, EventArgs e)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(wucPrjDataBase1.IpAddress,
                wucPrjDataBase1.DataBaseName,
                wucPrjDataBase1.DataBaseUserId,
                wucPrjDataBase1.DataBasePwd);
            try
            {
                if (objSQL.TestConnect() == true)
                {
                    string strMsg = "测试连接成功!";
                    clsCommonJsFunc.Alert(this,strMsg);
//                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCloneTab_Click(object sender, EventArgs e)
        {
            string strPrjDataBaseId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjDataBase);
            if (strPrjDataBaseId == null || strPrjDataBaseId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //string strNewPrjDataBaseId = "";
            try
            {
                clsPrjDataBaseEN objPrjDataBaseEN_S = new clsPrjDataBaseEN(strPrjDataBaseId);
                clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN_S);
                clsPrjDataBaseEN objPrjDataBaseEN_T = new clsPrjDataBaseEN();
                clsPrjDataBaseBL.CopyTo(objPrjDataBaseEN_S, objPrjDataBaseEN_T);
                objPrjDataBaseEN_T.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
                objPrjDataBaseEN_T.PrjDataBaseName = "Copy_" + objPrjDataBaseEN_S.PrjDataBaseName;
                clsPrjDataBaseBL.AddNewRecordBySql2(objPrjDataBaseEN_T);
                BindGv_PrjDataBase();
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "克隆表不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnRefreshBuffer_Click(object sender, EventArgs e)
        {
            //clsPrjDataBaseBL.arrPrjDataBaseObjLst_Cache = null;
            //clsProjectsBL.arrProjectsObjLst_Cache = null;
         
        }

        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjDataBase, "chkCheckRec");
            if (arrPrjId == null || arrPrjId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strPrjId in arrPrjId)
                {
                    clsPrjDataBaseBLEx.SetInUse(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjDataBase();
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvPrjDataBase, "chkCheckRec");
            if (arrPrjId == null || arrPrjId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                foreach (string strPrjId in arrPrjId)
                {
                    clsPrjDataBaseBLEx.SetNotInUse(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjDataBase();
        }
    }
    public partial class wfmPrjDataBase_QUDI : CommWebPageBase
    {
        protected void ShowData(string strPrjDataBaseId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strPrjDataBaseId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsPrjDataBaseBL.IsExist(strPrjDataBaseId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strPrjDataBaseId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsPrjDataBaseEN objPrjDataBase = new clsPrjDataBaseEN(strPrjDataBaseId);
            //4、获取类对象的所有属性；
            try
            {
                clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBase);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objPrjDataBase", objPrjDataBase);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromPrjDataBaseClass(objPrjDataBase);
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
        protected string CombinePrjDataBaseCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtPrjDataBaseNameq.Text.Trim() != "")
            {
                strWhereCond += " And PrjDataBaseName like '%" + this.txtPrjDataBaseNameq.Text.Trim() + "%'";
            }
            if (this.txtDataBaseNameq.Text.Trim() != "")
            {
                strWhereCond += " And DataBaseName like '%" + this.txtDataBaseNameq.Text.Trim() + "%'";
            }
            if (this.txtDatabaseOwnerq.Text.Trim() != "")
            {
                strWhereCond += " And DatabaseOwner like '%" + this.txtDatabaseOwnerq.Text.Trim() + "%'";
            }
            if (this.ddlDataBaseTypeIdq.SelectedValue != "" && this.ddlDataBaseTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And DataBaseTypeId='" + this.ddlDataBaseTypeIdq.SelectedValue + "'";
            }
            if (this.ddlUseStateId.SelectedValue != "" && this.ddlUseStateId.SelectedValue != "0")
            {
                strWhereCond += " And UseStateId='" + this.ddlUseStateId.SelectedValue + "'";
            }
            if (this.txtDataBaseUIdq.Text.Trim() != "")
            {
                strWhereCond += " And DataBaseUserId like '%" + this.txtDataBaseUIdq.Text.Trim() + "%'";
            }
            if (this.txtIpAddressq.Text.Trim() != "")
            {
                strWhereCond += " And IpAddress like '%" + this.txtIpAddressq.Text.Trim() + "%'";
            }
          
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_PrjDataBase()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombinePrjDataBaseCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvPrjDataBaseBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjDataBaseBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvPrjDataBase.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvPrjDataBase.PageSize = 10;
            }
            this.gvPrjDataBase.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvPrjDataBase.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvPrjDataBase.BottomPagerRow;
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
                lblAllPages.Text = this.gvPrjDataBase.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvPrjDataBase.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvPrjDataBase.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvPrjDataBase.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvPrjDataBase.PageIndex == this.gvPrjDataBase.PageCount - 1)
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
            gvPrjDataBase.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjPrjDataBase">表实体类对象</param>
        protected void GetDataFromPrjDataBaseClass(clsPrjDataBaseEN pobjPrjDataBase)
        {
            wucPrjDataBase1.PrjDataBaseId = pobjPrjDataBase.PrjDataBaseId;//    项目数据库Id
            wucPrjDataBase1.PrjDataBaseName = pobjPrjDataBase.PrjDataBaseName;//    项目数据库名
            wucPrjDataBase1.DataBaseName = pobjPrjDataBase.DataBaseName;//    数据库名
            wucPrjDataBase1.DatabaseOwner = pobjPrjDataBase.DatabaseOwner;//    数据库拥有者
            wucPrjDataBase1.DataBasePwd = pobjPrjDataBase.DataBasePwd;//    数据库的用户口令
            wucPrjDataBase1.DataBaseTypeId = pobjPrjDataBase.DataBaseTypeId;//    数据库类型ID
            wucPrjDataBase1.DataBaseUserId = pobjPrjDataBase.DataBaseUserId;//    数据库的用户ID
            wucPrjDataBase1.IpAddress = pobjPrjDataBase.IpAddress;//    服务器
            wucPrjDataBase1.Sid = pobjPrjDataBase.Sid;//    Sid
            wucPrjDataBase1.TableSpace = pobjPrjDataBase.TableSpace;//    表空间
            wucPrjDataBase1.UseStateId = pobjPrjDataBase.UseStateId;//    使用状态Id
            wucPrjDataBase1.Memo = pobjPrjDataBase.Memo;//    说明
        }
        
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjPrjDataBase">数据传输的目的类对象</param>
        protected void PutDataToPrjDataBaseClass(clsPrjDataBaseEN pobjPrjDataBase)
        {
            pobjPrjDataBase.PrjDataBaseId = wucPrjDataBase1.PrjDataBaseId;//    项目数据库Id
            pobjPrjDataBase.PrjDataBaseName = wucPrjDataBase1.PrjDataBaseName;//    项目数据库名
            pobjPrjDataBase.DataBaseName = wucPrjDataBase1.DataBaseName;//    数据库名
            pobjPrjDataBase.DatabaseOwner = wucPrjDataBase1.DatabaseOwner;//    数据库拥有者
            pobjPrjDataBase.DataBasePwd = wucPrjDataBase1.DataBasePwd;//    数据库的用户口令
            pobjPrjDataBase.DataBaseTypeId = wucPrjDataBase1.DataBaseTypeId;//    数据库类型ID
            pobjPrjDataBase.DataBaseUserId = wucPrjDataBase1.DataBaseUserId;//    数据库的用户ID
            pobjPrjDataBase.IpAddress = wucPrjDataBase1.IpAddress;//    服务器
            pobjPrjDataBase.Sid = wucPrjDataBase1.Sid;//    Sid
            pobjPrjDataBase.TableSpace = wucPrjDataBase1.TableSpace;//    表空间
            pobjPrjDataBase.UserId = clsCommonSession.UserId;//    用户ID
            pobjPrjDataBase.UpdDate = clsDateTime.getTodayStr(0);//    修改日期
            pobjPrjDataBase.Memo = wucPrjDataBase1.Memo;//    说明
            pobjPrjDataBase.UseStateId = wucPrjDataBase1.UseStateId;//    使用状态Id

        }

        
        public System.Data.DataTable GetDataBaseTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataBaseTypeId, DataBaseTypeName from DataBaseType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DataBaseTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDataBaseTypeId();
            objDDL.DataValueField = "DataBaseTypeId";
            objDDL.DataTextField = "DataBaseTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddPrjDataBaseRecord()
        {
            wucPrjDataBase1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelPrjDataBaseEdit.Text = "取消添加";
            wucPrjDataBase1.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddPrjDataBaseRecordSave()
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
            clsPrjDataBaseEN objPrjDataBase;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjDataBase1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsPrjDataBaseEN objPrjDataBase;	//定义对象
            objPrjDataBase = new clsPrjDataBaseEN(wucPrjDataBase1.PrjDataBaseId);	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjDataBaseBL.IsExist(wucPrjDataBase1.PrjDataBaseId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjDataBaseClass(objPrjDataBase);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsPrjDataBaseBL.CheckPropertyNew(objPrjDataBase);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjDataBaseBL.AddNewRecordBySql2(objPrjDataBase);
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
            BindGv_PrjDataBase();
            DispPrjDataBaseListRegion();
            wucPrjDataBase1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjDataBaseEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddPrjDataBaseRecordSaveV5()
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
            clsPrjDataBaseEN objPrjDataBase;
            //1、检查控件中输入数据类型是否正确
            if (!wucPrjDataBase1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsPrjDataBaseEN objPrjDataBase;	//定义对象
            objPrjDataBase = new clsPrjDataBaseEN(wucPrjDataBase1.PrjDataBaseId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsPrjDataBaseBL.IsExist(wucPrjDataBase1.PrjDataBaseId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjDataBaseClass(objPrjDataBase);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsPrjDataBaseBL.CheckPropertyNew(objPrjDataBase);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjDataBaseBL.AddNewRecordBySql2(objPrjDataBase);
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
            BindGv_PrjDataBase();
            DispPrjDataBaseListRegion();
            wucPrjDataBase1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjDataBaseEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdatePrjDataBaseRecord(string strPrjDataBaseId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strPrjDataBaseId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucPrjDataBase1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelPrjDataBaseEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditPrjDataBaseRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdatePrjDataBaseRecordSave(clsPrjDataBaseEN objPrjDataBase)
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
            if (!wucPrjDataBase1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjDataBaseClass(objPrjDataBase);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsPrjDataBaseBL.CheckPropertyNew(objPrjDataBase);
                //4、把数据实体层的数据存贮到数据库中
                clsPrjDataBaseBL.UpdateBySql2(objPrjDataBase);
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
            BindGv_PrjDataBase();
            DispPrjDataBaseListRegion();
            wucPrjDataBase1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjDataBaseEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdatePrjDataBaseRecordSaveV5(clsPrjDataBaseEN objPrjDataBase)
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
            if (!wucPrjDataBase1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToPrjDataBaseClass(objPrjDataBase);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsPrjDataBaseBL.CheckPropertyNew(objPrjDataBase);
                //4、把数据实体层的数据存贮到数据库中
                clsPrjDataBaseBL.UpdateBySql2(objPrjDataBase);
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
            BindGv_PrjDataBase();
            DispPrjDataBaseListRegion();
            wucPrjDataBase1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelPrjDataBaseEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeletePrjDataBaseRecord(string strPrjDataBaseId)
        {
            try
            {
                clsPrjDataBaseBL.DelRecord(strPrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjDataBase();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinePrjDataBaseCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "PrjDataBase信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convPrjDataBase.PrjDataBaseId); arrCnName.Add("项目数据库Id");
            arrColName.Add(convPrjDataBase.PrjDataBaseName); arrCnName.Add("项目数据库名");
            arrColName.Add(convPrjDataBase.DataBaseTypeName); arrCnName.Add("数据库类型名");
            arrColName.Add(convPrjDataBase.DataBaseTypeId); arrCnName.Add("数据库类型ID");
            arrColName.Add(convPrjDataBase.DataBaseName); arrCnName.Add("数据库名");
            arrColName.Add(convPrjDataBase.DatabaseOwner); arrCnName.Add("数据库拥有者");
            arrColName.Add(convPrjDataBase.DataBaseUserId); arrCnName.Add("数据库的用户ID");
            arrColName.Add(convPrjDataBase.IpAddress); arrCnName.Add("服务器");
            arrColName.Add(convPrjDataBase.TableSpace); arrCnName.Add("表空间");
            arrColName.Add(convPrjDataBase.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convPrjDataBase.Sid); arrCnName.Add("Sid");
            arrColName.Add(convPrjDataBase.UserId); arrCnName.Add("用户ID");
            arrColName.Add(convPrjDataBase.Memo); arrCnName.Add("说明");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvPrjDataBaseBL.GetDataTable(strWhereCond);
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
        private void DispEditPrjDataBaseRegion()
        {
            tabPrjDataBaseGridView.Visible = false;
            tabEditPrjDataBaseRegion.Visible = true;
        }
        private void DispPrjDataBaseListRegion()
        {
            tabPrjDataBaseGridView.Visible = true;
            tabEditPrjDataBaseRegion.Visible = false;
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