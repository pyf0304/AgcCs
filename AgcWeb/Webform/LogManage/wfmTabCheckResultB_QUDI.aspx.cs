
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/08/28
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：日志管理
///模块英文名：LogManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
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
    /// wfmTabCheckResultB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmTabCheckResultB_QUDI : CommWebPageBase
    {
        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmTabCheckResultB_QUDI.aspx";
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

                //1、为下拉框设置数据源，绑定列表数据
                wucTabCheckResultB1.SetDdl_PrjId();
                wucTabCheckResultB1.SetDdl_TabId();
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsTabCheckErrorTypeBL.BindDdl_TabCheckErrorTypeIdCache(ddlTabCheckErrorTypeId);

                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);
                clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseIdq, clsPubVar.CurrSelPrjId);
                ddlPrjDataBaseIdq.SelectedValue = objPrjDataBaseEN.PrjDataBaseId;
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                clsErrorLevelBL.BindDdl_ErrorLevelIdCache(ddlErrorLevelIdq);

                if (string.IsNullOrEmpty(seSqlDsTypeId) == false)
                {
                    ddlSqlDsTypeId.SelectedValue = seSqlDsTypeId;
                }


                if (string.IsNullOrEmpty(seErrorLevelId) == false)
                {
                    ddlErrorLevelIdq.SelectedValue = seErrorLevelId;
                }
                if (string.IsNullOrEmpty(seTabCheckErrorTypeId) == false)
                {
                    ddlTabCheckErrorTypeId.SelectedValue = seTabCheckErrorTypeId;
                }


                if (string.IsNullOrEmpty(vsSortTabCheckResultBy) == true)
                {
                    vsSortTabCheckResultBy = "TabName Asc";
                }
                //2、显示无条件的表内容在DATAGRID中
                BindGv_TabCheckResult();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                DispTabCheckResultListRegion();
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
            this.gvTabCheckResult.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_TabCheckResult();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvTabCheckResult_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvTabCheckResult.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_TabCheckResult();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsTabCheckResultEN objTabCheckResultEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddTabCheckResultRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddTabCheckResultRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objTabCheckResultEN = (clsTabCheckResultEN)Session["objTabCheckResultEN"];
                    UpdateTabCheckResultRecordSave(objTabCheckResultEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddTabCheckResultRecord();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
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
                    long lngmId = long.Parse(strKeys[0]);
                    clsTabCheckResultBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TabCheckResult();
        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvTabCheckResult, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateTabCheckResultRecord(lngmId);
        }
        protected void gvTabCheckResult_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortTabCheckResultBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortTabCheckResultBy = e.SortExpression + " Asc";
                BindGv_TabCheckResult();
                return;
            }
            //检查原来是升序
            intIndex = vsSortTabCheckResultBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortTabCheckResultBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortTabCheckResultBy = e.SortExpression + " Desc";
            }
            BindGv_TabCheckResult();
        }
        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string seSqlDsTypeId
        {
            get
            {
                string sqeSqlDsTypeId;
                sqeSqlDsTypeId = (string)Session["qeSqlDsTypeId"];
                if (sqeSqlDsTypeId == null)
                {
                    sqeSqlDsTypeId = "";
                }
                return sqeSqlDsTypeId;
            }
            set
            {
                string sqeSqlDsTypeId = value;
                Session.Add("qeSqlDsTypeId", sqeSqlDsTypeId);
            }
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。ddlTabCheckErrorTypeId
        /// </summary>
        protected string seErrorLevelId
        {
            get
            {
                string sqeErrorLevelId;
                sqeErrorLevelId = (string)Session["qeErrorLevelId"];
                if (sqeErrorLevelId == null)
                {
                    sqeErrorLevelId = "";
                }
                return sqeErrorLevelId;
            }
            set
            {
                string sqeErrorLevelId = value;
                Session.Add("qeErrorLevelId", sqeErrorLevelId);
            }
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string seTabCheckErrorTypeId
        {
            get
            {
                string sqeTabCheckErrorTypeId;
                sqeTabCheckErrorTypeId = (string)Session["TabCheckErrorTypeId"];
                if (sqeTabCheckErrorTypeId == null)
                {
                    sqeTabCheckErrorTypeId = "";
                }
                return sqeTabCheckErrorTypeId;
            }
            set
            {
                string sqeTabCheckErrorTypeId = value;
                Session.Add("TabCheckErrorTypeId", sqeTabCheckErrorTypeId);
            }
        }


        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string vsSortTabCheckResultBy
        {
            get
            {
                string sSortTabCheckResultBy;
                sSortTabCheckResultBy = (string)ViewState["SortTabCheckResultBy"];
                if (sSortTabCheckResultBy == null)
                {
                    sSortTabCheckResultBy = "";
                }
                return sSortTabCheckResultBy;
            }
            set
            {
                string sSortTabCheckResultBy = value;
                ViewState.Add("SortTabCheckResultBy", sSortTabCheckResultBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvTabCheckResult.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvTabCheckResult.PageCount)
                {
                    this.gvTabCheckResult.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_TabCheckResult();
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
                    PageSize4TabCheck = intPageSize.ToString();
                    BindGv_TabCheckResult();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvTabCheckResult_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvTabCheckResult, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvTabCheckResult, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvTabCheckResult_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (vsSortTabCheckResultBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvTabCheckResult.Columns.Count; i++)
                {
                    strSortEx = this.gvTabCheckResult.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortTabCheckResultBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortTabCheckResultBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvTabCheckResult_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvTabCheckResult.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteTabCheckResultRecord(lngmId);
        }
        ///
        protected void gvTabCheckResult_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvTabCheckResult.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateTabCheckResultRecord(lngmId);
        }
        ///删除记录过程代码for C#
        protected void gvTabCheckResult_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvTabCheckResult.PageIndex = e.NewPageIndex;
                this.BindGv_TabCheckResult();
            }
        }
        ///
        protected void btnCancelTabCheckResultEdit_Click(object sender, EventArgs e)
        {
            DispTabCheckResultListRegion();
        }

        protected void ddlPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPrjIdq.SelectedIndex > 0)
            {
                string strPrjId = ddlPrjIdq.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, strPrjId);
            }
        }

        protected void btnEditObjectAndTabFields_Click(object sender, EventArgs e)
        {
            JumpOtherPages("EditTabAndObjectFields");
        }

        protected void lbCheckAllTabField_Click(object sender, EventArgs e)
        {

       
            lblMsgList.Text = "";
            int intCount = 0;
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            try
            {
                clsLog objLog = new clsLog(@"D:\TaishSoft\",  "检查表日志");
                string strMsg = string.Format("检查开始时间：{0}", strCurrDate14);
                objLog.WriteDebugLog(strMsg);
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                intCount = clsTabCheckStatusBLEx.CheckAllTabField(clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsCommonSession.UserId);

                strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
                strMsg = string.Format("检查结束时间：{0}", strCurrDate14);
                objLog.WriteDebugLog(strMsg);
                objLog.WriteDebugLog("检查表字段完成！共计：" + intCount.ToString() + "个表。");
                clsCommonJsFunc.Alert(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
     
            }
            catch (Exception objException)
            {
                clsSysParaEN.spIsUseQueue4Task = false;
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
      
            } //显示生成代码区域

        }

        protected void lbSetNullableBySQL_Click(object sender, EventArgs e)
        {
            string strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvTabCheckResult);
            if (strMid == null || strMid.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            long lngMid = long.Parse(strMid);
            lblMsgList.Text = "";
            clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngMid);
            clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
            string strTabId = objTabCheckResultEN.TabId;
            List<string> arrTabIdLst = new List<string>();
            arrTabIdLst.Add(strTabId);
            //根据SQL表信息设置表字段的可空性
            clsProjectsEN objProjectsEN = new clsProjectsEN(clsPubVar.CurrSelPrjId);

            try
            {
                clsProjectsBL.GetProjects(ref objProjectsEN);
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                clsTabCheckStatusBLEx.SetPrjTabFldNullBySQLTab(strTabId, objProjectsEN, objPrjDataBaseEN.PrjDataBaseId, clsCommonSession.UserId);
                if (arrTabIdLst.Count == 0)
                {
                    lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                    return;
                }
                int intCount = 0;
                intCount = clsTabCheckStatusBLEx.CheckCheckedTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, arrTabIdLst);
                clsCommonJsFunc.Alert(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
                //显示生成代码区域
                BindGv_TabCheckResult();
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                lblMsgList.Text = ErrMessage;
                clsCommonJsFunc.Alert(this, ErrMessage);
                //clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void ddlFuncModuleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFuncModuleId.SelectedIndex > 0)
            {
                string strFuncModuleId = ddlFuncModuleId.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
            }
        }

        protected void btnSetTabWaitConsider_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
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
                    long lngmId = long.Parse(strKeys[0]);
                    clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngmId);
                    clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
                    clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objTabCheckResultEN.TabId);
                    objPrjTabEN.TabStateId = "04";
                    objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objPrjTabEN.UpdUserId = clsCommonSession.UserId;
                    clsPrjTabBL.UpdateBySql2(objPrjTabEN);
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TabCheckResult();

        }

        protected void lbCheckConsistency_Click(object sender, EventArgs e)
        {
            JumpOtherPages("CheckConsistency");
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

        protected void lbCheckAllTabField4Old_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";
            int intCount = 0;
            try
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);

                intCount = clsTabCheckStatusBLEx.CheckAllTabField(clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsCommonSession.UserId);

                clsCommonJsFunc.Alert(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //显示生成代码区域
        }

        protected void lbInitCheckAllTabField_Click(object sender, EventArgs e)
        {
            try
            {               
                clsTabCheckStatusBLEx.InitCheckAllTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                lblMsgList.Text = "";
                clsCommonJsFunc.Alert(this, "初始化完成！");
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //显示生成代码区域
        }

        protected void lbCheckCheckedTabField_Click(object sender, EventArgs e)
        {
            lblMsgList.Text = "";
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            List<string> arrTabIdLst = new List<string>();
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngmId = long.Parse(strKeys[0]);
                    clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngmId);
                    clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
                    if (arrTabIdLst.Contains(objTabCheckResultEN.TabId) == false)
                    {
                        arrTabIdLst.Add(objTabCheckResultEN.TabId);
                    }
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            if (arrTabIdLst.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            int intCount = 0;
            try
            {
     
                intCount = clsTabCheckStatusBLEx.CheckCheckedTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, arrTabIdLst);
                clsCommonJsFunc.Alert(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
            }
            catch (Exception objException)
            {
                lblMsgList.Text = objException.Message;
                clsCommonJsFunc.Alert(this, objException.Message);
            } //显示生成代码区域
            BindGv_TabCheckResult();
        }

        protected void btnCreateView4Sql_Click(object sender, EventArgs e)
        {

            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvTabCheckResult, "chkCheckRec", "mId");
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
                    string strMId = strKeys[0];
                    long lngMid = long.Parse(strMId);
                    clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngMid);
                    clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
                    if (string.IsNullOrEmpty(objTabCheckResultEN.TabId) == true)
                    {
                        continue;
                    }
                    string strCondition = string.Format("{0}='{1}'", conSqlView.RelaTabId, objTabCheckResultEN.TabId);
                    clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetFirstObj_S(strCondition);
                    if (objSqlViewEN == null)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId(objTabCheckResultEN.TabId);
                        string strMsg = string.Format("表名：{0}({1})没有相关的SqlView,请检查！", objPrjTab.TabName, objPrjTab.TabCnName);

                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    string strSqlViewId = objSqlViewEN.SqlViewId;



                    //进行尝试生成视图，看视图文本是否合法
                    clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, true);
                    //正式地生成视图
                    clsSqlViewBLEx.CreateView4Sql(strSqlViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId, clsPubVar.CurrPrjDataBaseId, false);
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }

            BindGv_TabCheckResult();
            clsCommonJsFunc.Alert(this, "在Sql中建立视图成功！");
        }

        protected void btnSetOrderNum4Refer_Click(object sender, EventArgs e)
        {
            try
            {
                //  clsSqlViewBLEx.SetOrderNum4Refer(clsPubVar.CurrSelPrjId);
                int intCount = clsPrjTabBLEx.SetOrderNum4Refer(clsPubVar.CurrSelPrjId);

                //BindGv_SqlView();
                clsCommonJsFunc.Alert(this, string.Format("设置引用序号成功！共设置了:{0}条记录。", intCount));
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonJsFunc.Alert(this, ErrMessage);
            }
        }

        protected void btnQueryReferedTabAndView_Click(object sender, EventArgs e)
        {
            if (ddlTabIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个表!");
                ddlTabIdq.Focus();
                return;
            }
            string strTabId = ddlTabIdq.SelectedValue;
            List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(strTabId, clsPubVar.CurrSelPrjId);
            if (arrTabId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "所选表没有相关父结点表！");
                return;
            }
            string strCondition = string.Format("{0} in ({1})",
                conTabCheckResult.TabId, clsArray.GetSqlInStrByArray(arrTabId, true));
            BindGv_TabCheckResult(strCondition);

        }

        protected void btnQueryViewReferThisTab_Click(object sender, EventArgs e)
        {
            if (ddlTabIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个表!");
                ddlTabIdq.Focus();
                return;
            }
            string strTabId = ddlTabIdq.SelectedValue;
            List<string> arrTabId = clsPrjTabBLEx.GetRelaSubNodeByTabId(strTabId, clsPubVar.CurrSelPrjId);
            if (arrTabId.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "所选表没有引用该表的相关视图！");
                return;
            }
            string strCondition = string.Format("{0} in ({1})",
                conTabCheckResult.TabId, clsArray.GetSqlInStrByArray(arrTabId, true));
            BindGv_TabCheckResult(strCondition);
        }

        protected void gvTabCheckResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public partial class wfmTabCheckResultB_QUDI : CommWebPageBase
    {
        protected void ShowData(long lngmId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsTabCheckResultBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + lngmId + "的不存在!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsTabCheckResultBL.GetTabCheckResult(ref objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            Session.Add("objTabCheckResultEN", objTabCheckResultEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromTabCheckResultClass(objTabCheckResultEN);
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
        protected string PageSize4TabCheck
        {
            get
            {
                string strPageSize;
                strPageSize = (string)Session["PageSize4TabCheck"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                Session.Add("PageSize4TabCheck", strPageSize);
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
        protected string CombineTabCheckResultCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And TabStateId='01' And  FuncModuleAgcId in (Select FuncModuleAgcId From DataBaseModuleRela where PrjId='{0}' And PrjDataBaseId='{1}' And IsVisible='1') ", clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " And PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlPrjDataBaseIdq.SelectedValue != "" && this.ddlPrjDataBaseIdq.SelectedValue != "0")
            {
                strWhereCond += " And PrjDataBaseId='" + this.ddlPrjDataBaseIdq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }
            if (this.ddlSqlDsTypeId.SelectedValue != "" && this.ddlSqlDsTypeId.SelectedValue != "0")
            {
                seSqlDsTypeId = this.ddlSqlDsTypeId.SelectedValue;
                strWhereCond += " And SqlDsTypeId='" + this.ddlSqlDsTypeId.SelectedValue + "'";
            }
            else
            {
                seSqlDsTypeId = "";
            }
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                strWhereCond += " And TabId='" + this.ddlTabIdq.SelectedValue + "'";
            }
            if (this.txtErrorMsgq.Text.Trim() != "")
            {
                strWhereCond += " And errorMsg like '%" + this.txtErrorMsgq.Text.Trim() + "%'";
            }
            if (this.ddlErrorLevelIdq.SelectedValue != "" && this.ddlErrorLevelIdq.SelectedValue != "0")
            {
                seErrorLevelId = ddlErrorLevelIdq.SelectedValue;
                strWhereCond += " And ErrorLevelId='" + this.ddlErrorLevelIdq.SelectedValue + "'";
            }
            else
            {
                seErrorLevelId = "";
            }

            if (this.ddlTabCheckErrorTypeId.SelectedValue != "" && this.ddlTabCheckErrorTypeId.SelectedValue != "0")
            {
                seTabCheckErrorTypeId = ddlTabCheckErrorTypeId.SelectedValue;
                strWhereCond += " And TabCheckErrorTypeId='" + this.ddlTabCheckErrorTypeId.SelectedValue + "'";
            }
            else
            {
                seTabCheckErrorTypeId = "";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_TabCheckResult(params string[] args)
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = "";
            if (args.Length == 0)
            {
                strWhereCond = CombineTabCheckResultCondition();
            }
            else if (args.Length == 1)
            {
                strWhereCond = args[0];
            }
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvTabCheckResultBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortTabCheckResultBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                                      ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize4TabCheck) == false)
            {
                int intPageSize = int.Parse(PageSize4TabCheck);
                gvTabCheckResult.PageSize = intPageSize;
            }
            else
            {
                PageSize4TabCheck = "10";
                gvTabCheckResult.PageSize = 10;
            }
            this.gvTabCheckResult.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvTabCheckResult.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvTabCheckResult.BottomPagerRow;
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
                lblAllPages.Text = this.gvTabCheckResult.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvTabCheckResult.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvTabCheckResult.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvTabCheckResult.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvTabCheckResult.PageIndex == this.gvTabCheckResult.PageCount - 1)
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
                //设置分页器中每页记录数的下拉框的值
                if (string.IsNullOrEmpty(PageSize4TabCheck) == false)
                {
                    ddlPagerRecCount.Text = PageSize4TabCheck;
                }
                else
                {
                    PageSize4TabCheck = "10";
                    ddlPagerRecCount.Text = PageSize4TabCheck;
                }
            }
            gvTabCheckResult.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjTabCheckResultEN">表实体类对象</param>
        protected void GetDataFromTabCheckResultClass(clsTabCheckResultEN pobjTabCheckResultEN)
        {
            wucTabCheckResultB1.PrjId = pobjTabCheckResultEN.PrjId;//    工程ID
            wucTabCheckResultB1.TabId = pobjTabCheckResultEN.TabId;//    表ID
            wucTabCheckResultB1.FldId = pobjTabCheckResultEN.FldId;//    字段ID
            wucTabCheckResultB1.ErrorLevelId = pobjTabCheckResultEN.ErrorLevelId;//    错误等级Id
            wucTabCheckResultB1.errorMsg = pobjTabCheckResultEN.ErrorMsg;//    错误信息
            wucTabCheckResultB1.CheckDate = pobjTabCheckResultEN.CheckDate;//    检查日期
            wucTabCheckResultB1.CheckUser = pobjTabCheckResultEN.CheckUser;//    检查人
            wucTabCheckResultB1.Memo = pobjTabCheckResultEN.Memo;//    说明
        }

        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjTabCheckResultEN">数据传输的目的类对象</param>
        protected void PutDataToTabCheckResultClass(clsTabCheckResultEN pobjTabCheckResultEN)
        {
            pobjTabCheckResultEN.PrjId = wucTabCheckResultB1.PrjId;//    工程ID
            pobjTabCheckResultEN.TabId = wucTabCheckResultB1.TabId;//    表ID
            pobjTabCheckResultEN.FldId = wucTabCheckResultB1.FldId;//    字段ID
            pobjTabCheckResultEN.ErrorLevelId = wucTabCheckResultB1.ErrorLevelId;//    错误等级Id
            pobjTabCheckResultEN.ErrorMsg = wucTabCheckResultB1.errorMsg;//    错误信息
            pobjTabCheckResultEN.CheckDate = wucTabCheckResultB1.CheckDate;//    检查日期
            pobjTabCheckResultEN.CheckUser = wucTabCheckResultB1.CheckUser;//    检查人
            pobjTabCheckResultEN.Memo = wucTabCheckResultB1.Memo;//    说明
        }


        public System.Data.DataTable GetErrorLevelId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ErrorLevelId, ErrorLevelName from ErrorLevel ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ErrorLevelId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetErrorLevelId();
            objDDL.DataValueField = "ErrorLevelId";
            objDDL.DataTextField = "ErrorLevelName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddTabCheckResultRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelTabCheckResultEdit.Text = "取消添加";

            DispEditTabCheckResultRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddTabCheckResultRecordSave()
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
            clsTabCheckResultEN objTabCheckResultEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsTabCheckResultEN objTabCheckResultEN;	//定义对象
            objTabCheckResultEN = new clsTabCheckResultEN();	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //6、把数据实体层的数据存贮到数据库中
                clsTabCheckResultBL.AddNewRecordBySql2(objTabCheckResultEN);
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
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTabCheckResultEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddTabCheckResultRecordSaveV5()
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
            clsTabCheckResultEN objTabCheckResultEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsTabCheckResultEN objTabCheckResultEN;	//定义对象
            objTabCheckResultEN = new clsTabCheckResultEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //6、把数据实体层的数据存贮到数据库中
                clsTabCheckResultBL.AddNewRecordBySql2(objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTabCheckResultEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateTabCheckResultRecord(long lngmId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            btnOKUpd.Text = "确认修改";
            btnCancelTabCheckResultEdit.Text = "取消修改";
            lblMsgEdit.Text = "";
            DispEditTabCheckResultRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateTabCheckResultRecordSave(clsTabCheckResultEN objTabCheckResultEN)
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
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //4、把数据实体层的数据存贮到数据库中
                clsTabCheckResultBL.UpdateBySql2(objTabCheckResultEN);
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
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTabCheckResultEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateTabCheckResultRecordSaveV5(clsTabCheckResultEN objTabCheckResultEN)
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
            if (!wucTabCheckResultB1.IsValid(ref strResult))
            {
                lblMsgEdit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsTabCheckResultBL.CheckPropertyNew(objTabCheckResultEN);
                //4、把数据实体层的数据存贮到数据库中
                clsTabCheckResultBL.UpdateBySql2(objTabCheckResultEN);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_TabCheckResult();
            DispTabCheckResultListRegion();
            wucTabCheckResultB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelTabCheckResultEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteTabCheckResultRecord(long lngmId)
        {
            try
            {
                clsTabCheckResultBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_TabCheckResult();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineTabCheckResultCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "TabCheckResult信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("FldId"); arrCnName.Add("字段ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("TabId"); arrCnName.Add("表ID");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("ErrorLevelId"); arrCnName.Add("错误等级Id");
            arrColName.Add("ErrorLevelName"); arrCnName.Add("错误等级名");
            arrColName.Add("errorMsg"); arrCnName.Add("错误信息");
            arrColName.Add("CheckDate"); arrCnName.Add("检查日期");
            arrColName.Add("CheckUser"); arrCnName.Add("检查人");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvTabCheckResultBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditTabCheckResultRegion()
        {
            divList.Visible = false;
            tabEditTabCheckResultRegion.Visible = true;
        }
        private void DispTabCheckResultListRegion()
        {
            divList.Visible = true;
            tabEditTabCheckResultRegion.Visible = false;
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
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":
                    string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);
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
            string strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvTabCheckResult);
            if (strMid == null || strMid.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            long lngMid = long.Parse(strMid);
            lblMsgList.Text = "";
            clsTabCheckResultEN objTabCheckResultEN = clsTabCheckResultBL.GetObjBymId(lngMid);
            if (objTabCheckResultEN == null)
            {
                clsCommonJsFunc.Alert(this, "没有选择相关记录！");
                return;
            }
            string strCurrPageName = "";
            switch (strPageName)
            {
                case "CheckConsistency":
                    strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

                    clsPubFun4Web.CheckConsistency(this, objTabCheckResultEN.TabId, strCurrPageName);
                    break;
                case "EditTabAndObjectFields":
                    strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

                    if (string.IsNullOrEmpty(objTabCheckResultEN.TabId) == false)
                    {
                        clsPubFun4Web.JumpToEditTabAndFields(this, objTabCheckResultEN.TabId, strCurrPageName);
                    }
                    else
                    {
                        lblMsgList.Text = "该错误没有相关AGC表，请重新选择记录！";
                        clsCommonJsFunc.Alert(this, "该错误没有相关AGC表，请重新选择记录！");
                    }

                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息
    }
}