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
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    public partial class wfmFunctionTemplateRelaB_I : System.Web.UI.Page
    {

        //public string id_Teacher
        //{
        //    get
        //    {
        //        return 1clsCommonSession.UserId;
        //    }
        //}
        //public string UserID
        //{
        //    get
        //    {
        //        return 1clsCommonSession.UserId;
        //    }
        //}
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
        private int Pager
        {
            get
            {
                return Convert.ToInt32(ViewState["Page"]);
            }
            set
            {
                ViewState["Page"] = value;
            }
        }
        private int lastPage
        {
            get
            {
                return Convert.ToInt32(ViewState["lastPage"]);
            }
            set
            {
                ViewState["lastPage"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //clsPubFun.RecordDebug4User("wfmAddFunctionTemplateRela", qsUserId);
                //clsCommonSession.PageName = "添加学生到教学班";

                //clsDropDownListBL.BindDdl_cc_CourseGroup(ddlFunctionTemplateIdq, UserID);

                // FunctionTemplateRela-Edit 教学班学生-编辑 
                //FunctionTemplateRela-Edit-Teacher 教学班学生-编辑-教师 

                //clsSchoolYearBL.BindDdl_SchoolYear(ddlSchoolYearq);
                ////ddlSchoolYearq.SelectedValue 1= clsSysParaEN.CurrYear;
                //clsSchoolTermBLEx.BindDdl_SchoolTerm(ddlSchoolTermq);
                ////ddlSchoolTermq.SelectedValue = clsSysParaEN.CurrTerm;

                //List<string> arrFunctionTemplateId = null;
                //vsarrFunctionTemplateId = arrFunctionTemplateId;
               

                clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeIdq);
                clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeIdq);
                clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeId);

                clsFunctionTemplateBL.BindDdl_FunctionTemplateIdCache(ddlFunctionTemplateIdq);
                clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeIDq);

                if (string.IsNullOrEmpty(qsFunctionTemplateId) == false)
                {
                    ddlFunctionTemplateIdq.SelectedValue = qsFunctionTemplateId;
                    ddlFunctionTemplateIdq.Enabled = false;
                }

                if (string.IsNullOrEmpty(seProgLangTypeId) == false)
                {
                    ddlProgLangTypeIdq.SelectedValue = seProgLangTypeId;
                }

                if (string.IsNullOrEmpty(seCodeTypeId) == false)
                {
                    ddlCodeTypeId.SelectedValue = seCodeTypeId;
                }
                //else if (arrFunctionTemplateId.Count >= 1)
                //{
                //    ddlFunctionTemplateIdq.SelectedValue = arrFunctionTemplateId[0];
                //}
                //BindDdl_id_AdminClass(ddlid_AdminClassq);
                //BindDdl_id_AdminClassType(ddlid_AdminClassTypeq);
                vsSortFunction4GeneCodeBy = string.Format("{0} Asc", conFunction4GeneCode.OrderNum);

                BindGv_Function4GeneCode();
            }
        }


        public System.Data.DataTable Getid_AdminClass()
        {
            //获取某学院所有专业信息
            string strSQL = "select id_AdminClass, AdminClassName from AdminClass ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_id_AdminClass(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = Getid_AdminClass();
            objDDL.DataValueField = "id_AdminClass";
            objDDL.DataTextField = "AdminClassName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public System.Data.DataTable Getid_AdminClassType()
        {
            //获取某学院所有专业信息
            string strSQL = "select id_AdminClassType, AdminClassTypeName from AdminClassType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_id_AdminClassType(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = Getid_AdminClassType();
            objDDL.DataValueField = "id_AdminClassType";
            objDDL.DataTextField = "AdminClassTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public string CombineFunction4GeneCodeCondition()
        {
            string strWhereCond = " 1=1 ";
            if (string.IsNullOrEmpty(qsFunctionTemplateId) == false)
            {
                strWhereCond += string.Format(" and FuncId4GC not in (select FuncId4GC From FunctionTemplateRela where FunctionTemplateId= '{0}' and CodeTypeId='{1}')",
                   qsFunctionTemplateId, qsCodeTypeId);
            }
            else if (ddlFunctionTemplateIdq.SelectedIndex > 0)
            {
                strWhereCond += string.Format(" and FuncId4GC not in (select FuncId4GC From FunctionTemplateRela where FunctionTemplateId= '{0}' and CodeTypeId='{1}')",
                    ddlFunctionTemplateIdq.SelectedValue, qsCodeTypeId);
            }

            try
            {
                if (this.txtFuncId4GCq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunction4GeneCode.FuncId4GC, this.txtFuncId4GCq.Text.Trim());
                }
                if (this.txtFuncNameq.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convFunction4GeneCode.FuncName, this.txtFuncNameq.Text.Trim());
                }
                if (this.ddlCodeTypeIdq.SelectedValue != "" && this.ddlCodeTypeIdq.SelectedValue != "0")
                {
                    seCodeTypeId = ddlCodeTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunctionTemplateRela.CodeTypeId, this.ddlCodeTypeIdq.SelectedValue);
                }
                else
                {
                    seCodeTypeId = "";
                }
                if (this.ddlProgLangTypeIdq.SelectedValue != "" && this.ddlProgLangTypeIdq.SelectedValue != "0")
                {
                    seProgLangTypeId = ddlProgLangTypeIdq.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunctionTemplateRela.ProgLangTypeId, this.ddlProgLangTypeIdq.SelectedValue);
                }
                else
                {
                    seProgLangTypeId = "";
                }
                if (this.ddlFuncTypeIDq.SelectedValue != ""
                 && this.ddlFuncTypeIDq.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", convFunctionTemplateRela.FuncTypeId,
                        this.ddlFuncTypeIDq.SelectedValue);
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI002666)在组合查询条件(CombineFunction4GeneCodeCondition)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView)
        /// </summary>
        protected void BindGv_Function4GeneCode()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            System.Data.DataTable objDT = null;
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineFunction4GeneCodeCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvFunction4GeneCodeBL.GetDataTable_vFunction4GeneCode(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortFunction4GeneCodeBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                                    ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvFunction4GeneCode.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvFunction4GeneCode.PageSize = 10;
            }
            this.gvFunction4GeneCode.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvFunction4GeneCode.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvFunction4GeneCode.BottomPagerRow;
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
                lblAllPages.Text = this.gvFunction4GeneCode.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvFunction4GeneCode.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvFunction4GeneCode.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvFunction4GeneCode.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvFunction4GeneCode.PageIndex == this.gvFunction4GeneCode.PageCount - 1)
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
            gvFunction4GeneCode.BottomPagerRow.Visible = true;
        }
   

        //protected void btnAdd_Click(object sender, EventArgs e)
        //{
        //    foreach (DataListItem dl in DataList1.Items)
        //    {
        //        CheckBox cb = (CheckBox)dl.FindControl("ckb1");
        //        if (cb.Checked)
        //        {
        //            Label lb = (Label)dl.FindControl("Label1");
        //            clscc_CourseStudentRelationEN obj = new clscc_CourseStudentRelationEN();
        //            obj.FuncId4GC = lb.Text;
        //            obj.CourseId = CourseId;
        //            clscc_CourseStudentRelationBL.AddNewRecordBySql2(obj);
        //        }
        //    }
        //}







        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvFunction4GeneCode, "chkCheckRec", "FuncId4GC");
            if (lstKeyValues.Count == 0)
            {
                clsCommonJsFunc.Alert(this, "没有选择记录，请选择一个有效的表记录!");
                return;
            }
            if (ddlCodeTypeId.SelectedIndex<=0)
            {
                clsCommonJsFunc.Alert(this, "请选择目标代码类型！");
                ddlCodeTypeId.Focus();
                return;
            }
            string strCodeTypeId = ddlCodeTypeId.SelectedValue;

            if (ddlFunctionTemplateIdq.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择目标模板！");
                ddlFunctionTemplateIdq.Focus();
                return;
            }
            string strFunctionTemplateId = ddlFunctionTemplateIdq.SelectedValue;
                //string strWhereCond = " 1=1 and TeacherID='" + getUserId + "'";
                //string Id_Teacher = clsTeacherInfoBL.GetFirstID_S(strWhereCond);

            foreach (string strKeyValue in lstKeyValues)
            {
                string[] strKeys = strKeyValue.Split(',');
                string strFuncId4GC = strKeys[0].ToString();
                var objFunction4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(strFuncId4GC);
                if (objFunction4GeneCode == null) continue;
                string strCondition = string.Format("{0}='{1}' and {2}='{3}' And {4}='{5}'",
                    conFunctionTemplateRela.FunctionTemplateId, qsFunctionTemplateId,
                    conFunctionTemplateRela.CodeTypeId, strCodeTypeId,
                    conFunctionTemplateRela.FuncId4GC, strFuncId4GC);
                if (!clsFunctionTemplateRelaBL.IsExistRecord(strCondition))
                {

                    clsFunctionTemplateRelaEN objcc_FunctionTemplateRela = new clsFunctionTemplateRelaEN();
                    objcc_FunctionTemplateRela.FunctionTemplateId = ddlFunctionTemplateIdq.SelectedValue;

                    objcc_FunctionTemplateRela.FuncId4GC = strFuncId4GC;
                    objcc_FunctionTemplateRela.CodeTypeId = strCodeTypeId;
                    objcc_FunctionTemplateRela.FuncCodeTypeId = objFunction4GeneCode.FuncCodeTypeId;
                    //objcc_FunctionTemplateRela.SchoolYear = ddlSchoolYearq.SelectedValue;
                    //objcc_FunctionTemplateRela.SchoolTerm = ddlSchoolTermq.SelectedValue;

                    objcc_FunctionTemplateRela.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objcc_FunctionTemplateRela.UpdUser = clsCommonSession.UserId;

                    clsFunctionTemplateRelaBL.AddNewRecordBySql2(objcc_FunctionTemplateRela);
                    
                    i++;

                }
                else
                {
                    //      clsCommonJsFunc.Alert(this, "编号为" + FuncId4GC + "的学生已添加！");
                }
            }

            clsCommonJsFunc.Alert(this, "添加成功" + i.ToString() + "个函数！");
            BindGv_Function4GeneCode();
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            string strPageName = string.Format("wfmFunctionTemplateRelaB_QUDI.aspx?FunctionName={0}&UserId={1}",
              qsFunctionName,
              getUserId);
            Response.Redirect(strPageName);
        }

        protected void gvFunction4GeneCode_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvFunction4GeneCode_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvFunction4GeneCode.PageIndex = e.NewPageIndex;
                this.BindGv_Function4GeneCode();
            }
        }


        protected string vsSortFunction4GeneCodeBy
        {
            get
            {
                string sSortFunction4GeneCodeBy;
                sSortFunction4GeneCodeBy = (string)ViewState["SortFunction4GeneCodeBy"];
                if (sSortFunction4GeneCodeBy == null)
                {
                    sSortFunction4GeneCodeBy = "";
                }
                return sSortFunction4GeneCodeBy;
            }
            set
            {
                string sSortFunction4GeneCodeBy = value;
                ViewState.Add("SortFunction4GeneCodeBy", sSortFunction4GeneCodeBy);
            }
        }

        protected void gvFunction4GeneCode_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = vsSortFunction4GeneCodeBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFunction4GeneCodeBy = e.SortExpression + " Asc";
                BindGv_Function4GeneCode();
                return;
            }
            ///检查原来是升序
            intIndex = vsSortFunction4GeneCodeBy.IndexOf(" Asc");
            if (intIndex == -1)		///如果原来不是升序就设置为升序
            {
                vsSortFunction4GeneCodeBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortFunction4GeneCodeBy = e.SortExpression + " Desc";
            }
            BindGv_Function4GeneCode();
        }

        protected void gvFunction4GeneCode_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvFunction4GeneCode, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvFunction4GeneCode, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvFunction4GeneCode.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvFunction4GeneCode.PageCount)
                {
                    this.gvFunction4GeneCode.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_Function4GeneCode();
            }

        }

        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsString.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize = intPageSize.ToString();
                    BindGv_Function4GeneCode();
                }
            }
        }

     
        /// <summary>
        /// 用户Id。例如：“pyf”, "lyl"等
        ///         
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsUserId
        {
            get
            {
                if (Request.QueryString["UserId"] != null)
                {
                    return Request.QueryString["UserId"].ToString().Trim();
                }
                return "";
            }
        }

        /// <summary>
        /// 当前教学班流水号。例如：“00000016”等
        ///         
        /// 作者：潘以锋
        /// 建立日期：2016-10-26
        /// </summary>
        public string qsFunctionTemplateId
        {
            get
            {
                if (Request.QueryString["FunctionTemplateId"] != null)
                {
                    return Request.QueryString["FunctionTemplateId"].ToString().Trim();
                }
                return "";
            }
        }

        public string qsCodeTypeId
        {
            get
            {
                if (Request.QueryString["CodeTypeId"] != null)
                {
                    return Request.QueryString["CodeTypeId"].ToString().Trim();
                }
                return "";
            }
        }
        /// <summary>
        /// 功能名称。例如：“视频资源库-显示”、“视频资源库-后台编辑”、“教学案例资源库-显示”、“教学案例资源库-后台编辑”等
        ///         根据不同的功能名称，可能调用不同的页面
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsFunctionName
        {
            get
            {
                if (Request.QueryString["FunctionName"] != null)
                {
                    return Request.QueryString["FunctionName"].ToString().Trim();
                }
                return "";
            }
        }
        /// <summary>
        /// 根据传递参数和选择参数决定的课程Id
        /// 功能：如果选择参数不为空，就返回选择参数课程Id，
        ///       否则就返回传递参数课程Id
        /// </summary>
        protected string getUserId
        {
            get
            {
                if (string.IsNullOrEmpty(clsCommonSession.UserId) == false) return clsCommonSession.UserId;
                if (string.IsNullOrEmpty(qsUserId) == false) return qsUserId;
                return "";
            }
        }
        /// <summary>
        /// 当前教师或者学生相关的教学班流水号列表
        /// </summary>
        protected List<string> vsarrFunctionTemplateId
        {
            get
            {
                List<string> arrFunctionTemplateId;
                arrFunctionTemplateId = (List<string>)ViewState["arrFunctionTemplateId"];

                return arrFunctionTemplateId;
            }
            set
            {
                List<string> arrFunctionTemplateId = value;
                ViewState.Add("arrFunctionTemplateId", arrFunctionTemplateId);
            }
        }

        protected void ddlFunctionTemplateId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGv_Function4GeneCode();
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            BindGv_Function4GeneCode();
        }

        /// <summary>
        /// 编程语言类型Id。ddlProgLangTypeId
        /// </summary>
        protected string seProgLangTypeId
        {
            get
            {
                string sProgLangTypeId;
                sProgLangTypeId = (string)Session["ProgLangTypeId"];
                if (sProgLangTypeId == null)
                {
                    sProgLangTypeId = "";
                }
                return sProgLangTypeId;
            }
            set
            {
                string sProgLangTypeId = value;
                Session.Add("ProgLangTypeId", sProgLangTypeId);
            }
        }

        /// <summary>
        /// 编程层类型Id。ddlCodeTypeId
        /// </summary>
        protected string seCodeTypeId
        {
            get
            {
                string sCodeTypeId;
                sCodeTypeId = (string)Session["CodeTypeId"];
                if (sCodeTypeId == null)
                {
                    sCodeTypeId = "";
                }
                return sCodeTypeId;
            }
            set
            {
                string sCodeTypeId = value;
                Session.Add("CodeTypeId", sCodeTypeId);
            }
        }
    }
}
