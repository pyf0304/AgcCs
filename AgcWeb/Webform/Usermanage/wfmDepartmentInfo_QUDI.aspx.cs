
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;

///----------------------
///生成代码版本：6.3.0.0
///生成日期：2008/07/20
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：7.1.0.0
///========================

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmDepartmentInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmDepartmentInfo_QUDI : CommWebPageBase
    {

        ///生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            //clsPubVar.CheckUserSession();

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                ///生成权限有关判断权限的代码
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

                if (clsSysParaEN.strUserType == "Hospital")
                {
                    gvDepartmentInfo.Columns[7].Visible = false;
                    gvDepartmentInfo.Columns[8].Visible = false;
                    gvDepartmentInfo.Columns[9].Visible = false;
                    gvDepartmentInfo.Columns[10].Visible = false;
                    lblSubjectTypeIdq.Visible = false;
                    ddlSubjectTypeIdq.Visible = false;
                }

                //1、为下拉框设置数据源，绑定列表数据
                wucDepartmentInfo1.SetDdl_UpDepartmentId();
                wucDepartmentInfo1.SetDdl_DepartmentTypeId();
                //wucDepartmentInfo1.SetDdl_SubjectTypeId();
                BindDdl_UpDepartmentId(ddlUpDepartmentIdq);
                BindDdl_DepartmentTypeId(ddlDepartmentTypeIdq);
                BindDdl_SubjectTypeId(ddlSubjectTypeIdq);
                clsDropDownList.BindDdl_TrueOrFalse(ddlInUse);
                strSortDepartmentInfoBy = "OrderNum Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_DepartmentInfo();
                //3、设置表控件中字控件的ReadOnly属性，
                ///   使之只读，因为在修改功能中关键字是不能被修改的。
                wucDepartmentInfo1.SetKeyReadOnly(true);
                DispDepartmentInfoListRegion();
            }
        }

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            ///把DATAGRID的当前页索引设置为0，即第1页。
            ///当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvDepartmentInfo.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_DepartmentInfo();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvDepartmentInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvDepartmentInfo.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_DepartmentInfo();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strDepartmentId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsDepartmentInfoEN objDepartmentInfo;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddDepartmentInfoRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddDepartmentInfoRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objDepartmentInfo = (clsDepartmentInfoEN)Session["objDepartmentInfo"];
                    UpdateDepartmentInfoRecordSave(objDepartmentInfo);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucDepartmentInfo1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            lblMsgEdit.Text = "";
            //wucDepartmentInfo1.DepartmentId = clsCommForWebForm.G1etMaxStrId("DepartmentInfo","DepartmentId", 6, "");
            DispEditDepartmentInfoRegion();
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
            List<string>  arrDepartmentId = clsCommForWebForm.GetAllCheckedItemFromGv(gvDepartmentInfo, "chkCheckRec");
            if (arrDepartmentId == null || arrDepartmentId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsDepartmentInfoBL.DelDepartmentInfos(arrDepartmentId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DepartmentInfo();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strDepartmentId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvDepartmentInfo);
            if (strDepartmentId == null || strDepartmentId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdateDepartmentInfoRecord(strDepartmentId);
        }
        
        protected void gvDepartmentInfo_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortDepartmentInfoBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortDepartmentInfoBy = e.SortExpression + " Asc";
                BindGv_DepartmentInfo();
                return;
            }
            ///检查原来是升序
            intIndex = strSortDepartmentInfoBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortDepartmentInfoBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortDepartmentInfoBy = e.SortExpression + " Desc";
            }
            BindGv_DepartmentInfo();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortDepartmentInfoBy
        {
            get
            {
                string sSortDepartmentInfoBy;
                sSortDepartmentInfoBy = (string)ViewState["SortDepartmentInfoBy"];
                if (sSortDepartmentInfoBy == null)
                {
                    sSortDepartmentInfoBy = "";
                }
                return sSortDepartmentInfoBy;
            }
            set
            {
                string sSortDepartmentInfoBy = value;
                ViewState.Add("SortDepartmentInfoBy", sSortDepartmentInfoBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvDepartmentInfo.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvDepartmentInfo.PageCount)
                {
                    this.gvDepartmentInfo.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_DepartmentInfo();
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
                    BindGv_DepartmentInfo();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvDepartmentInfo_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvDepartmentInfo, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvDepartmentInfo, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvDepartmentInfo_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortDepartmentInfoBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvDepartmentInfo.Columns.Count; i++)
                {
                    strSortEx = this.gvDepartmentInfo.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortDepartmentInfoBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortDepartmentInfoBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvDepartmentInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strDepartmentId = gvDepartmentInfo.DataKeys[e.RowIndex].Value.ToString();
            DeleteDepartmentInfoRecord(strDepartmentId);
        }
        ///
        protected void gvDepartmentInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strDepartmentId = gvDepartmentInfo.DataKeys[e.RowIndex].Value.ToString();
            UpdateDepartmentInfoRecord(strDepartmentId);
        }
        ///删除记录过程代码for C#
        protected void gvDepartmentInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvDepartmentInfo.PageIndex = e.NewPageIndex;
                this.BindGv_DepartmentInfo();
            }
        }
        ///
        protected void btnCancelDepartmentInfoEdit_Click(object sender, EventArgs e)
        {
            DispDepartmentInfoListRegion();
        }

        protected void btnUpMove_Click(object sender, EventArgs e)
        {
            string strMsg;
            string strDepartmentId =clsCommForWebForm. GetFirstCheckedItemFromGv(gvDepartmentInfo);
            if (strDepartmentId == null || strDepartmentId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsDepartmentInfoBLEx.AdjustSequenceNumber("UP", strDepartmentId);

            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				ErrMessage = objException.Message;
                //				BackLinkStr = Page.Request.Url.AbsolutePath;	//"/AGC_CSV4/Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DepartmentInfo();
            clsCommForWebForm.SetCheckedItemForGv(gvDepartmentInfo, 2, strDepartmentId);
        }
        protected void btnDownMove_Click(object sender, EventArgs e)
        {
            string strMsg;
            string strDepartmentId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvDepartmentInfo);
            if (strDepartmentId == null || strDepartmentId.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            try
            {
                clsDepartmentInfoBLEx.AdjustSequenceNumber("DOWN", strDepartmentId);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				ErrMessage = objException.Message;
                //				BackLinkStr = Page.Request.Url.AbsolutePath;	//"/AGC_CSV4/Webform/GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DepartmentInfo();
            clsCommForWebForm.SetCheckedItemForGv(gvDepartmentInfo, 2, strDepartmentId);
        }
        protected void btnReOrder_Click(object sender, EventArgs e)
        {
            clsDepartmentInfoBLEx.ReOrder();
            BindGv_DepartmentInfo();
        }
       
        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<string> arrid_DepartmentInfo = clsCommForWebForm.GetAllCheckedItemFromGv(gvDepartmentInfo, "chkCheckRec");
            if (arrid_DepartmentInfo == null || arrid_DepartmentInfo.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";


                try
                {
                    clsDepartmentInfoBLEx.GoTop(arrid_DepartmentInfo);
                }
                catch (Exception objException)
                {
                    ErrMessage = objException.Message;
                    BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_DepartmentInfo();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<string> arrid_DepartmentInfo = clsCommForWebForm.GetAllCheckedItemFromGv(gvDepartmentInfo, "chkCheckRec");
            if (arrid_DepartmentInfo == null || arrid_DepartmentInfo.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";
                try
                {
                    clsDepartmentInfoBLEx.GoBottom(arrid_DepartmentInfo);
                }
                catch (Exception objException)
                {
                    ErrMessage = objException.Message;
                    BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindGv_DepartmentInfo();
        }

        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<string> arrDepartmentIds = clsCommForWebForm.GetAllCheckedItemFromGv(gvDepartmentInfo, "chkCheckRec");
            if (arrDepartmentIds.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字记录的内容在界面上；
            ///当前所选记录
            ///

            clsDepartmentInfoBLEx.SetInUse(arrDepartmentIds);
            BindGv_DepartmentInfo();
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<string> arrDepartmentIds = clsCommForWebForm.GetAllCheckedItemFromGv(gvDepartmentInfo, "chkCheckRec");
            if (arrDepartmentIds.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字记录的内容在界面上；
            ///当前所选记录
            ///

            clsDepartmentInfoBLEx.SetNotInUse(arrDepartmentIds);
            BindGv_DepartmentInfo();
        }
    }
    public partial class wfmDepartmentInfo_QUDI : CommWebPageBase
    {
        protected void ShowData(string strDepartmentId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strDepartmentId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsDepartmentInfoBL.IsExist(strDepartmentId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strDepartmentId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsDepartmentInfoEN objDepartmentInfo = null;
            //4、获取类对象的所有属性；
            try
            {
                objDepartmentInfo = clsDepartmentInfoBL.GetObjByDepartmentId(strDepartmentId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objDepartmentInfo", objDepartmentInfo);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromDepartmentInfoClass(objDepartmentInfo);
        }

        ///生成权限等级的属性
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
        ///protected clsQxUsersEN objUser
        ///{
        ///get
        ///{
        ///clsQxUsersEN pobjUser;
        ///pobjUser = (clsQxUsersEN)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsQxUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}


        ///生成专门用于BINDgv中的跳页相关代码
        /// <summary>
        /// 所属部门号
        /// </summary>
        protected string UpDepartmentId
        {
            get
            {
                string strUpDepartmentId;
                strUpDepartmentId = (string)Session["UpDepartmentId"];
                if (strUpDepartmentId == null)
                {
                    strUpDepartmentId = "";
                }
                return strUpDepartmentId;
            }
            set
            {
                string strUpDepartmentId = value;
                Session.Add("UpDepartmentId", strUpDepartmentId);
            }
        }


        ///生成错误信息的Session属性
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


        ///生成错误信息的Session属性
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


        ///生成返回链接串的Session属性
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
        protected string CombineDepartmentInfoCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtDepartmentIdq.Text.Trim() != "")
            {
                strWhereCond += " And DepartmentId like '%" + this.txtDepartmentIdq.Text.Trim() + "%'";
            }
            if (this.txtDepartmentNameq.Text.Trim() != "")
            {
                strWhereCond += " And DepartmentName like '%" + this.txtDepartmentNameq.Text.Trim() + "%'";
            }
            if (this.ddlUpDepartmentIdq.SelectedValue != "" && this.ddlUpDepartmentIdq.SelectedValue != "0")
            {
                strWhereCond += " And UpDepartmentId='" + this.ddlUpDepartmentIdq.SelectedValue + "'";
            }
            if (this.ddlDepartmentTypeIdq.SelectedValue != "" && this.ddlDepartmentTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And DepartmentTypeId='" + this.ddlDepartmentTypeIdq.SelectedValue + "'";
            }
            if (this.ddlSubjectTypeIdq.SelectedValue != "" && this.ddlSubjectTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And SubjectTypeId='" + this.ddlSubjectTypeIdq.SelectedValue + "'";
            }
            if (this.ddlInUse.SelectedIndex == 1)
            {
                strWhereCond += " And InUse='1'";
            }
            else if (this.ddlInUse.SelectedIndex == 2)
            {
                strWhereCond += " And InUse='0'";
            }

            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_DepartmentInfo()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //4、设置GridView的数据源(DataSource)；
            //5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombineDepartmentInfoCondition();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvDepartmentInfoBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortDepartmentInfoBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvDepartmentInfo.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvDepartmentInfo.PageSize = 10;
            }
            this.gvDepartmentInfo.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvDepartmentInfo.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvDepartmentInfo.BottomPagerRow;
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
                lblAllPages.Text = this.gvDepartmentInfo.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvDepartmentInfo.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvDepartmentInfo.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvDepartmentInfo.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvDepartmentInfo.PageIndex == this.gvDepartmentInfo.PageCount - 1)
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
            gvDepartmentInfo.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjDepartmentInfo">表实体类对象</param>
        protected void GetDataFromDepartmentInfoClass(clsDepartmentInfoEN pobjDepartmentInfo)
        {
            wucDepartmentInfo1.DepartmentId = pobjDepartmentInfo.DepartmentId;//    部门Id
            wucDepartmentInfo1.DepartmentName = pobjDepartmentInfo.DepartmentName;//    部门名
            wucDepartmentInfo1.DepartmentAbbrName = pobjDepartmentInfo.DepartmentAbbrName;//    名称缩写
            wucDepartmentInfo1.OrderNum = pobjDepartmentInfo.OrderNum ?? 0;//    排序号
            wucDepartmentInfo1.UpDepartmentId = pobjDepartmentInfo.UpDepartmentId;//    所属部门号
            wucDepartmentInfo1.DepartmentTypeId = pobjDepartmentInfo.DepartmentTypeId;//    部门类型ID
            //wucDepartmentInfo1.SubjectTypeId = pobjDepartmentInfo.SubjectTypeId;//    学科类型ID
            //wucDepartmentInfo1.IsExam = pobjDepartmentInfo.IsExam;//    是否参与考核
            //wucDepartmentInfo1.DepartmentId4Card = pobjDepartmentInfo.DepartmentId4Card;//    一卡通部门ID
            //wucDepartmentInfo1.IsAcademy = pobjDepartmentInfo.IsAcademy;//    是否学院
            wucDepartmentInfo1.InUse = pobjDepartmentInfo.InUse;//    是否学院
            wucDepartmentInfo1.Memo = pobjDepartmentInfo.Memo;//    备注
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjDepartmentInfo">数据传输的目的类对象</param>
        protected void PutDataToDepartmentInfoClass(clsDepartmentInfoEN pobjDepartmentInfo)
        {
            pobjDepartmentInfo.DepartmentId = wucDepartmentInfo1.DepartmentId;//    部门Id
            pobjDepartmentInfo.DepartmentName = wucDepartmentInfo1.DepartmentName;//    部门名
            pobjDepartmentInfo.DepartmentAbbrName = wucDepartmentInfo1.DepartmentAbbrName;//    名称缩写
            pobjDepartmentInfo.OrderNum = wucDepartmentInfo1.OrderNum;//    排序号
            pobjDepartmentInfo.UpDepartmentId = wucDepartmentInfo1.UpDepartmentId;//    所属部门号
            pobjDepartmentInfo.DepartmentTypeId = wucDepartmentInfo1.DepartmentTypeId;//    部门类型ID
            //pobjDepartmentInfo.SubjectTypeId = wucDepartmentInfo1.SubjectTypeId;//    学科类型ID
            //pobjDepartmentInfo.IsExam = wucDepartmentInfo1.IsExam;//    是否参与考核
            //pobjDepartmentInfo.DepartmentId4Card = wucDepartmentInfo1.DepartmentId4Card;//    一卡通部门ID
            //pobjDepartmentInfo.IsAcademy = wucDepartmentInfo1.IsAcademy;//    是否学院
            pobjDepartmentInfo.InUse = wucDepartmentInfo1.InUse;//    是否学院

            pobjDepartmentInfo.Memo = wucDepartmentInfo1.Memo;//    备注
        }

        public void BindDdl_UpDepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='1'", conDepartmentInfo.InUse);
            System.Data.DataTable objDT = clsDepartmentInfoBL.GetDataTable_DepartmentInfo(strCondition);

            objDDL.DataValueField = "DepartmentId";
            objDDL.DataTextField = "DepartmentName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void BindDdl_DepartmentTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = clsDepartmentTypeBL.GetDataTable_DepartmentType("1=1");
            objDDL.DataValueField = "DepartmentTypeId";
            objDDL.DataTextField = "DepartmentTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetSubjectTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select SubjectTypeId, SubjectTypeName from SubjectType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_SubjectTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetSubjectTypeId();
            objDDL.DataValueField = "SubjectTypeId";
            objDDL.DataTextField = "SubjectTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddDepartmentInfoRecord()
        {
            wucDepartmentInfo1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelDepartmentInfoEdit.Text = "取消添加";
            //wucDepartmentInfo1.DepartmentId = clsCommForWebForm.G1etMaxStrId("DepartmentInfo","DepartmentId", 6, "");
        }
        ///插入记录存盘过程代码for C#
        protected bool AddDepartmentInfoRecordSave()
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
            clsDepartmentInfoEN objDepartmentInfo;
            //1、检查控件中输入数据类型是否正确
            if (!wucDepartmentInfo1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsDepartmentInfoEN objDepartmentInfo;	//定义对象
            objDepartmentInfo = new clsDepartmentInfoEN(wucDepartmentInfo1.DepartmentId);	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsDepartmentInfoBL.IsExist(objDepartmentInfo.DepartmentId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToDepartmentInfoClass(objDepartmentInfo);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsDepartmentInfoBL.CheckPropertyNew(objDepartmentInfo);
                //6、把数据实体层的数据存贮到数据库中
                clsDepartmentInfoBL.AddNewRecordBySql2(objDepartmentInfo);
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
            BindGv_DepartmentInfo();
            DispDepartmentInfoListRegion();
            wucDepartmentInfo1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDepartmentInfoEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddDepartmentInfoRecordSaveV5()
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
            clsDepartmentInfoEN objDepartmentInfo;
            //1、检查控件中输入数据类型是否正确
            if (!wucDepartmentInfo1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsDepartmentInfoEN objDepartmentInfo;	//定义对象
            objDepartmentInfo = new clsDepartmentInfoEN(wucDepartmentInfo1.DepartmentId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsDepartmentInfoBL.IsExist(objDepartmentInfo.DepartmentId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToDepartmentInfoClass(objDepartmentInfo);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsDepartmentInfoBL.CheckPropertyNew(objDepartmentInfo);
                //6、把数据实体层的数据存贮到数据库中
                clsDepartmentInfoBL.AddNewRecordBySql2(objDepartmentInfo);
            }
            catch (Exception objException)
            {
                ErrMessage = "添加记录不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_DepartmentInfo();
            DispDepartmentInfoListRegion();
            wucDepartmentInfo1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDepartmentInfoEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateDepartmentInfoRecord(string strDepartmentId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strDepartmentId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucDepartmentInfo1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelDepartmentInfoEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditDepartmentInfoRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateDepartmentInfoRecordSave(clsDepartmentInfoEN objDepartmentInfo)
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
            if (!wucDepartmentInfo1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToDepartmentInfoClass(objDepartmentInfo);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                //4、把数据实体层的数据存贮到数据库中
                clsDepartmentInfoBL.UpdateBySql2(objDepartmentInfo);
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
            BindGv_DepartmentInfo();
            DispDepartmentInfoListRegion();
            wucDepartmentInfo1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDepartmentInfoEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateDepartmentInfoRecordSaveV5(clsDepartmentInfoEN objDepartmentInfo)
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
            if (!wucDepartmentInfo1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToDepartmentInfoClass(objDepartmentInfo);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsDepartmentInfoBL.CheckPropertyNew(objDepartmentInfo);
                //4、把数据实体层的数据存贮到数据库中
                clsDepartmentInfoBL.UpdateBySql2(objDepartmentInfo);
            }
            catch (Exception objException)
            {
                ErrMessage = "修改记录不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_DepartmentInfo();
            DispDepartmentInfoListRegion();
            wucDepartmentInfo1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDepartmentInfoEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteDepartmentInfoRecord(string strDepartmentId)
        {
            try
            {
                clsDepartmentInfoBL.DelRecord(strDepartmentId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_DepartmentInfo();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //1、组合界面条件串；
            string strWhereCond = CombineDepartmentInfoCondition();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            string strFileName = "DepartmentInfo信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convDepartmentInfo.DepartmentId); arrCnName.Add("部门Id");
            arrColName.Add(convDepartmentInfo.DepartmentName); arrCnName.Add("部门名");
            arrColName.Add(convDepartmentInfo.OrderNum); arrCnName.Add("排序号");
            arrColName.Add(convDepartmentInfo.DepartmentTypeName); arrCnName.Add("部门类型名");
            arrColName.Add(convDepartmentInfo.DepartmentAbbrName); arrCnName.Add("名称缩写");
            arrColName.Add(convDepartmentInfo.UpDepartmentName); arrCnName.Add("UpDepartmentName");
            //arrColName.Add(convDepartmentInfo.SubjectTypeName); arrCnName.Add("SubjectTypeName");
            //arrColName.Add(convDepartmentInfo.IsExam); arrCnName.Add("是否参与考核");
            //arrColName.Add(convDepartmentInfo.IsAcademy); arrCnName.Add("是否学院");
            //arrColName.Add(convDepartmentInfo.DepartmentId4Card); arrCnName.Add("一卡通部门ID");
            arrColName.Add(convDepartmentInfo.Memo); arrCnName.Add("备注");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                //2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvDepartmentInfoBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditDepartmentInfoRegion()
        {
            tabDepartmentInfoGridView.Visible = false;
            tabEditDepartmentInfoRegion.Visible = true;
        }
        private void DispDepartmentInfoListRegion()
        {
            tabDepartmentInfoGridView.Visible = true;
            tabEditDepartmentInfoRegion.Visible = false;
        }
        /// <summary>
        /// 根据传递参数和选择参数决定的用户工程Id
        /// 功能：如果选择参数不为空，就返回选择参数用户工程Id，
        ///       否则就返回传递参数用户工程Id
        /// </summary>
        //protected string getUserPrjId
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(clsCommonSession.UserPrjId4get) == false) return clsCommonSession.UserPrjId4get;
        //        if (string.IsNullOrEmpty(qsUserPrjId) == false) return qsUserPrjId;
        //        return "";
        //    }
        //    set
        //    {
        //        clsCommonSession.UserPrjId4get = value;
        //    }
        //}

        /// <summary>
        /// 用户选择的工程Id。例如：“0150”等
        /// 作者：潘以锋
        /// 建立日期：2016-07-01
        /// </summary>
        public string qsUserPrjId
        {
            get
            {
                if (Request.QueryString["UserPrjId"] != null)
                {
                    return Request.QueryString["UserPrjId"].ToString().Trim();
                }
                return "";
            }
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