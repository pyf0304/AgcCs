

using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace AGC.Webform
{
    /// <summary>
    /// wfmProjects_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmProjects_QUDI : CommWebPageBase
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

        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号
        //定义从外面传来的ObjId(对象ID)

        /// <summary>
        /// 当前需要操作的工程Id
        /// </summary>
        private string qsPrjId
        {
            get
            {
                string strPrjId = Request.QueryString["PrjId"] ?? "".ToString();
                if ((strPrjId != null) && (strPrjId != ""))
                {
                    return strPrjId;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 操作
        /// </summary>
        private string qsOperator
        {
            get
            {
                string strOperator = Request.QueryString["Operator"] ?? "".ToString();
                if ((strOperator != null) && (strOperator != ""))
                {
                    return strOperator;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                vsViewName = "工程表维护";
                vsTabName = "vProjects";
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
                wucProjects1.SetDdl_DataBaseTypeId();
                wucProjects1.SetDdl_ApplicationTypeId();
                wucProjects1.SetDdl_SoftStructureId();
          
                wucProjects1.SetDdl_UseStateId();

                clsUseStateBL.BindDdl_UseStateId(ddlUseStateId);
                ddlUseStateId.SelectedValue = "0001";
                strSortProjectsBy = "PrjId Asc";
                if (qsOperator == "SelectDataBase")
                {
                    DispEditProjectsRegion();
                    wucProjects1.SetDdl_PrjDataBaseId(clsPubVar.CurrSelPrjId);
                    UpdateProjectsRecord(clsPubVar.CurrSelPrjId);
                    tabQuery.Visible = false;
                    wucProjects1.SetState4SelectDataBase();
                }
                else
                {
                    wucProjects1.SetDdl_PrjDataBaseId();
                    //2、显示无条件的表内容在DATAGRID中
                    BindGv_Projects();
                    DispProjectsListRegion();
                }
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucProjects1.SetKeyReadOnly(true);
           
            }
        }
        protected override void OnPreRender(EventArgs e)
        {
            this.Page.RegisterRequiresViewStateEncryption();
            base.OnPreRender(e);
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
            this.gvProjects.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_Projects();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvProjects_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvProjects.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_Projects();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strPrjId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsProjectsEN objProjects;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddProjectsRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddProjectsRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objProjects = (clsProjectsEN)Session["objProjects"];
                    UpdateProjectsRecordSave(objProjects);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucProjects1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            lblMsgEdit.Text = "";
            wucProjects1.PrjId = clsProjectsBL.GetMaxStrId_S();
            wucProjects1.UseStateId = "0001";
            DispEditProjectsRegion();
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
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvProjects, "chkCheckRec");
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

                    clsProjectsBLEx.p_Del_Projects(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strPrjId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvProjects);
            if (strPrjId == null || strPrjId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdateProjectsRecord(strPrjId);
        }
        
        protected void gvProjects_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortProjectsBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortProjectsBy = e.SortExpression + " Asc";
                BindGv_Projects();
                return;
            }
            //检查原来是升序
            intIndex = strSortProjectsBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortProjectsBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortProjectsBy = e.SortExpression + " Desc";
            }
            BindGv_Projects();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortProjectsBy
        {
            get
            {
                string sSortProjectsBy;
                sSortProjectsBy = (string)ViewState["SortProjectsBy"];
                if (sSortProjectsBy == null)
                {
                    sSortProjectsBy = "";
                }
                return sSortProjectsBy;
            }
            set
            {
                string sSortProjectsBy = value;
                ViewState.Add("SortProjectsBy", sSortProjectsBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvProjects.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvProjects.PageCount)
                {
                    this.gvProjects.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_Projects();
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
                    BindGv_Projects();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvProjects_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvProjects, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvProjects, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvProjects_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortProjectsBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvProjects.Columns.Count; i++)
                {
                    strSortEx = this.gvProjects.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortProjectsBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortProjectsBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvProjects_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strPrjId = gvProjects.DataKeys[e.RowIndex].Value.ToString();
            DeleteProjectsRecord(strPrjId);
        }
        ///
        protected void gvProjects_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strPrjId = gvProjects.DataKeys[e.RowIndex].Value.ToString();
            UpdateProjectsRecord(strPrjId);
        }
        ///删除记录过程代码for C#
        protected void gvProjects_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvProjects.PageIndex = e.NewPageIndex;
                this.BindGv_Projects();
            }
        }
        ///
        protected void btnCancelProjectsEdit_Click(object sender, EventArgs e)
        {
            if (qsOperator == "SelectDataBase")
            {
                Response.Redirect("../wfmPortal.aspx");
            }
            DispProjectsListRegion();
        }

        protected void btnTestConnect_Click(object sender, EventArgs e)
        {


            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(wucProjects1.IpAddress,
                wucProjects1.PrjDataBaseName,
                wucProjects1.DataBaseUserId,
                wucProjects1.DataBasePwd);
            try
            {
                if (objSQL.TestConnect() == true)
                {
                    string strMsg = "测试连接成功!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return ;
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
            string strProjectsId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvProjects);
            if (strProjectsId == null || strProjectsId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //string strNewProjectsId = "";
            try
            {
                clsProjectsEN objProjectsEN_S = new clsProjectsEN(strProjectsId);
                clsProjectsBL.GetProjects(ref objProjectsEN_S);
                clsProjectsEN objProjectsEN_T = new clsProjectsEN();
                clsProjectsBL.CopyTo(objProjectsEN_S, objProjectsEN_T);
                objProjectsEN_T.PrjId = clsProjectsBL.GetMaxStrId_S();
                objProjectsEN_T.PrjName = "Copy_" + objProjectsEN_S.PrjName;
                clsProjectsBL.AddNewRecordBySql2(objProjectsEN_T);
                BindGv_Projects();
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "克隆表不成功!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnAutoSet_Click(object sender, EventArgs e)
        {
            List<clsProjectsEN> lstProjectsObj = clsProjectsBL.GetObjLst("UseStateId='0001'");
            List<clsPrjDataBaseEN> lstPrjDataBaseObj = clsPrjDataBaseBL.GetObjLst("UseStateId='0001'");
            int intCount = 0;
            foreach (clsProjectsEN objProjectsEN in lstProjectsObj)
            {
                bool bolIsSuccess = false;
                //string strPrjDataBaseId = "";
                foreach (clsPrjDataBaseEN objPrjDataBaseEN in lstPrjDataBaseObj)
                {
                    //if (objProjectsEN.PrjDataBaseName == objPrjDataBaseEN.DataBaseName
                    //    && objProjectsEN.IpAddress == objPrjDataBaseEN.IpAddress
                    //    && objProjectsEN.DataBaseUserId == objPrjDataBaseEN.DataBaseUserId)
                    //{
                    //    bolIsSuccess = true;
                    //    strPrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId;
                    //    intCount++;
                    //}
                }
                if (bolIsSuccess)
                {
                    //objProjectsEN.PrjDataBaseId = strPrjDataBaseId;
                    objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsProjectsBL.UpdateBySql2(objProjectsEN);
                }
            }
            clsCommonJsFunc.Alert(this, "适配完成！共计：" + intCount.ToString() + "个项目。");

        }

        protected void btnRefreshBuffer_Click(object sender, EventArgs e)
        {
            //clsPrjDataBaseBL.arrPrjDataBaseObjLst_Cache = null;
            //clsProjectsBL.arrProjectsObjLst_Cache = null;

        }

        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvProjects, "chkCheckRec");
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
                    clsProjectsBLEx.SetInUse(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<string> arrPrjId = clsCommForWebForm.GetAllCheckedItemFromGv(gvProjects, "chkCheckRec");
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
                    clsProjectsBLEx.SetNotInUse(strPrjId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }
    }
    public partial class wfmProjects_QUDI : CommWebPageBase
    {
        protected void ShowData(string strPrjId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strPrjId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsProjectsBL.IsExist(strPrjId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strPrjId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsProjectsEN objProjects = null;// new clsProjectsEN(strPrjId);
            //4、获取类对象的所有属性；
            try
            {
                objProjects = clsProjectsBL.GetObjByPrjId(strPrjId);
                if (objProjects == null)
                {
                    clsCommonJsFunc.Alert(this, string.Format("根据工程Id:{0}所获取的对象为空。", strPrjId));
                    return;
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }

            Session.Add("objProjects", objProjects);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromProjectsClass(objProjects);
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
        protected string CombineProjectsCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtPrjNameq.Text.Trim() != "")
            {
                strWhereCond += " And PrjName like '%" + this.txtPrjNameq.Text.Trim() + "%'";
            }
            if (this.txtPrjDomainq.Text.Trim() != "")
            {
                strWhereCond += " And PrjDomain like '%" + this.txtPrjDomainq.Text.Trim() + "%'";
            }
         
           
            if (this.ddlUseStateId.SelectedValue != "" && this.ddlUseStateId.SelectedValue != "0")
            {
                strWhereCond += " And UseStateId='" + this.ddlUseStateId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_Projects()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineProjectsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvProjectsBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortProjectsBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvProjects.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvProjects.PageSize = 10;
            }
            this.gvProjects.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvProjects.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvProjects.BottomPagerRow;
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
                lblAllPages.Text = this.gvProjects.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvProjects.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvProjects.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvProjects.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvProjects.PageIndex == this.gvProjects.PageCount - 1)
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
            gvProjects.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjProjects">表实体类对象</param>
        protected void GetDataFromProjectsClass(clsProjectsEN pobjProjects)
        {
            wucProjects1.PrjId = pobjProjects.PrjId;//    工程ID
            wucProjects1.PrjName = pobjProjects.PrjName;//    工程名称
            wucProjects1.PrjDomain = pobjProjects.PrjDomain;//    域/包名
            wucProjects1.JavaPackageName = pobjProjects.JavaPackageName;//    Java包名
            wucProjects1.IsoPrjName = pobjProjects.IsoPrjName;//    Java包名
            //wucProjects1.DataBaseTypeId = pobjProjects.DataBaseTypeId;//    数据库类型ID
            //wucProjects1.IpAddress = pobjProjects.IpAddress;//    服务器
            //wucProjects1.PrjDataBaseName = pobjProjects.PrjDataBaseName;//    主数据库
            //wucProjects1.DatabaseOwner = pobjProjects.objPrjDataBase.DatabaseOwner;//    数据库拥有者
            //wucProjects1.Sid = pobjProjects.Sid;//    Sid
            //wucProjects1.TableSpace = pobjProjects.TableSpace;//    表空间
            //wucProjects1.DataBaseUserId = pobjProjects.DataBaseUserId;//    数据库的用户ID
            //wucProjects1.DataBasePwd = pobjProjects.DataBasePwd;//    数据库的用户口令
            //wucProjects1.ApplicationTypeId = pobjProjects.ApplicationTypeId;//    修改日期
            //wucProjects1.SoftStructureId = pobjProjects.SoftStructureId;//    用户ID
            string strPrjDataBaseId_CurrUserId = clsUserDefaPrjDataBaseBLEx.GetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            if (string.IsNullOrEmpty(strPrjDataBaseId_CurrUserId) == true)
            {
                //wucProjects1.PrjDataBaseId = pobjProjects.PrjDataBaseId;//    用户ID
            }
            else
            {
                wucProjects1.PrjDataBaseId = strPrjDataBaseId_CurrUserId;
            }
            //wucProjects1.VirtualDirectory = pobjProjects.VirtualDirectory;//    虚拟目录
            //wucProjects1.PrjRootDirectory = pobjProjects.PrjRootDirectory;//    工程根目录
            wucProjects1.Memo = pobjProjects.Memo;//    说明
            wucProjects1.IsRelaDataBase = pobjProjects.IsRelaDataBase;//    是否关联到数据库
            wucProjects1.UseStateId = pobjProjects.UseStateId;//    使用状态
            wucProjects1.IsSupportMvc = pobjProjects.IsSupportMvc;//    是否支持Mvc           

        }

        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjProjects">数据传输的目的类对象</param>
        protected void PutDataToProjectsClass(clsProjectsEN pobjProjects)
        {
            pobjProjects.PrjId = wucProjects1.PrjId;//    工程ID
            pobjProjects.PrjName = wucProjects1.PrjName;//    工程名称
            pobjProjects.PrjDomain = wucProjects1.PrjDomain;//    域/包名
            pobjProjects.JavaPackageName = wucProjects1.JavaPackageName;//    Java包名
            pobjProjects.IsoPrjName = wucProjects1.IsoPrjName;//    Java包名
            //pobjProjects.DataBaseTypeId = wucProjects1.DataBaseTypeId;//    数据库类型ID
            //pobjProjects.IpAddress = wucProjects1.IpAddress;//    服务器
            //pobjProjects.PrjDataBaseName = wucProjects1.PrjDataBaseName;//    主数据库
            //pobjProjects.DatabaseOwner = wucProjects1.DatabaseOwner;//    数据库拥有者
            //pobjProjects.Sid = wucProjects1.Sid;//    Sid
            //pobjProjects.TableSpace = wucProjects1.TableSpace;//    表空间
            //pobjProjects.DataBaseUserId = wucProjects1.DataBaseUserId;//    数据库的用户ID
            //pobjProjects.DataBasePwd = wucProjects1.DataBasePwd;//    数据库的用户口令
            pobjProjects.UpdDate = clsDateTime.getTodayStr(0);//    修改日期
            pobjProjects.UserId =clsCommonSession.UserId;//    用户ID
            //pobjProjects.ApplicationTypeId = wucProjects1.ApplicationTypeId;//    说明
            //pobjProjects.SoftStructureId = wucProjects1.SoftStructureId;//    说明
            //pobjProjects.PrjDataBaseId = wucProjects1.PrjDataBaseId;//    说明
            pobjProjects.Memo = wucProjects1.Memo;//    说明
            //pobjProjects.VirtualDirectory = wucProjects1.VirtualDirectory;//    虚拟目录
            //pobjProjects.PrjRootDirectory = wucProjects1.PrjRootDirectory;//    工程根目录
            pobjProjects.IsRelaDataBase = wucProjects1.IsRelaDataBase;//    是否关联到数据库           
            pobjProjects.IsSupportMvc = wucProjects1.IsSupportMvc;//    是否支持Mvc           
            pobjProjects.UseStateId = wucProjects1.UseStateId;//    是否关联到数据库
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
        protected void AddProjectsRecord()
        {
            wucProjects1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelProjectsEdit.Text = "取消添加";
            wucProjects1.PrjId = clsProjectsBL.GetMaxStrId_S();
            wucProjects1.UseStateId = "0001";
        }
        ///插入记录存盘过程代码for C#
        protected bool AddProjectsRecordSave()
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
            clsProjectsEN objProjects;
            //1、检查控件中输入数据类型是否正确
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsProjectsEN objProjects;	//定义对象
            objProjects = new clsProjectsEN(wucProjects1.PrjId);	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsProjectsBL.IsExist(objProjects.PrjId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToProjectsClass(objProjects);		//把界面的值传到
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (objProjects.CheckUniqueness() == false)	//判断是否有相同的关键字
            {
                strMsg = string.Format("工程名：{0}已有相同的值，请重新换一个。", wucProjects1.PrjName);
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
          
            //5、检查传进去的对象属性是否合法
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //6、把数据实体层的数据存贮到数据库中
                clsProjectsBL.AddNewRecordBySql2(objProjects);
                //clsTitleStyleBLEx.CopyTitleStyle(objProjects.PrjId, "0005");
                string strCondition = string.Format("TitleStyleName='文字型' And PrjId='{0}'", objProjects.PrjId);
                clsTitleStyleEN objTitleStyle =  clsTitleStyleBL.GetFirstObj_S(strCondition);
                if (objTitleStyle != null)
                {
                    objTitleStyle.IsDefault = true;
                    clsTitleStyleBL .UpdateBySql2(objTitleStyle);
                }
                //if (objProjects.ApplicationTypeId == 2)
                //{
                //    clsFuncModule_AgcBLEx.CopyFuncModule("0001", objProjects.PrjId, clsCommonSession.UserId);
                //}
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
            BindGv_Projects();
            DispProjectsListRegion();
            wucProjects1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelProjectsEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddProjectsRecordSaveV5()
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
            clsProjectsEN objProjects;
            //1、检查控件中输入数据类型是否正确
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsProjectsEN objProjects;	//定义对象
            objProjects = new clsProjectsEN(wucProjects1.PrjId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsProjectsBL.IsExist(objProjects.PrjId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToProjectsClass(objProjects);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //6、把数据实体层的数据存贮到数据库中
                clsProjectsBL.AddNewRecordBySql2(objProjects);
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
            BindGv_Projects();
            DispProjectsListRegion();
            wucProjects1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelProjectsEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateProjectsRecord(string strPrjId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strPrjId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucProjects1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelProjectsEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditProjectsRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateProjectsRecordSave(clsProjectsEN objProjects)
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
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToProjectsClass(objProjects);		//把界面的值传到
            if (objProjects.CheckUniqueness() == false)	//判断是否有相同的关键字
            {
                strMsg = string.Format("工程名：{0}已有相同的值，请重新换一个。", wucProjects1.PrjName);
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //4、把数据实体层的数据存贮到数据库中
                clsProjectsBL.UpdateBySql2(objProjects);
                string strPrjDataBaseId_CurrUserId = wucProjects1.PrjDataBaseId;
                clsUserDefaPrjDataBaseBLEx.SetPrjDataBaseIdByPrjIdAndUserId(clsPubVar.CurrSelPrjId, clsCommonSession.UserId, strPrjDataBaseId_CurrUserId);
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

            if (qsOperator == "SelectDataBase")
            {
                Response.Redirect("~/Webform/wfmPortal.aspx");
            }
            else
            {
                lblMsgEdit.Text = "修改记录成功!";
                //5、把修改后的内容显示在DATAGRID中
                BindGv_Projects();
                DispProjectsListRegion();
                wucProjects1.Clear();//添空控件中的内容
                //恢复<确认修改>变成<添加>
                btnOKUpd.Text = "添加";
                btnCancelProjectsEdit.Text = "取消编辑";
            }
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateProjectsRecordSaveV5(clsProjectsEN objProjects)
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
            if (!wucProjects1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToProjectsClass(objProjects);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsProjectsBL.CheckPropertyNew(objProjects);
                //4、把数据实体层的数据存贮到数据库中
                clsProjectsBL.UpdateBySql2(objProjects);
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
            BindGv_Projects();
            DispProjectsListRegion();
            wucProjects1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelProjectsEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteProjectsRecord(string strPrjId)
        {
            try
            {
                clsProjectsBL.DelRecord(strPrjId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_Projects();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineProjectsCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "Projects信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("PrjDomain"); arrCnName.Add("域/包名");
            //arrColName.Add("IpAddress"); arrCnName.Add("服务器");
            //arrColName.Add("DataBaseTypeId"); arrCnName.Add("数据库类型ID");
            //arrColName.Add("DataBaseTypeName"); arrCnName.Add("数据库类型名");
            //arrColName.Add("PrjDataBaseName"); arrCnName.Add("主数据库");
            //arrColName.Add("DatabaseOwner"); arrCnName.Add("数据库拥有者");
            //arrColName.Add("Sid"); arrCnName.Add("Sid");
            //arrColName.Add("TableSpace"); arrCnName.Add("表空间");
            //arrColName.Add("DataBaseUserId"); arrCnName.Add("数据库的用户ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
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
                objDT = clsvProjectsBL.GetDataTable(strWhereCond);
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
        private void DispEditProjectsRegion()
        {
            tabProjectsGridView.Visible = false;
            tabEditProjectsRegion.Visible = true;
        }
        private void DispProjectsListRegion()
        {
            tabProjectsGridView.Visible = true;
            tabEditProjectsRegion.Visible = false;
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