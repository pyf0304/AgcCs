using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
//using SqlSv; 
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;

///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmGenViewCode4Java 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmGenViewCode4Java : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            string js = "";
            js += "<script>\r\r\n";
            js += "function ld(){\r\r\n";
            js += "for(i=0;i<document.getElementsByName('RadioName').length;i++)\r\r\n";
            js += "if(document.getElementsByName('RadioName')[i].value==";
            js += "document.getElementById('" + rd.ClientID + "').value) ";
            js += "document.getElementsByName('RadioName')[i].checked=true\r\r\n";
            js += "}\r\r\n";
            js += "window.onload=ld\r\r\n";
            js += "</" + "script>\r\r\n";
            //			this.RegisterStartupScript("js",js);
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                ///隐藏应该隐藏的控件内容
                vsLangType = clsPubConst.LangType.JAVA;
                vsDataBaseType = clsPubConst.DataBaseType.MsSql;
                tabHidden.Visible = false;
                if (clsCommForWebForm.SystemStatus == "DEBUG")
                {
                    
                }
                //1、为下拉框设置数据源，绑定列表数据
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

              clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq, clsPubVar.CurrSelPrjId);
                clsViewGroupBLEx.BindDdl_ViewGroupId(ddlViewGroupIdq, clsPubVar.CurrSelPrjId);

                ///设置当前登录用户的默认工程
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                ddlApplicationTypeIdq.SelectedValue = clsApplicationTypeBLEx.JAVAWEBAPP.ToString();
                ddlApplicationTypeIdq.Enabled = false;

                //恢复上一次在此界面的状态
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
                }

                txtViewNameq.Text = ViewName;
                //===============================


                //2、显示无条件的表内容在DATAGRID中
                strSortBy = "ViewName Asc";
                BindDg_ViewInfo();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
            }
        }


        private string seFuncModuleAgcId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                Session.Add("FuncModuleAgcId4Qry", strFuncModuleId);
            }
        }

        private string ViewTypeCode
        {
            get
            {
                string intViewTypeCode;
                intViewTypeCode = (string)Session["ViewTypeCode"];
                if (intViewTypeCode == null)
                {
                    intViewTypeCode = "";
                }
                return intViewTypeCode;
            }
            set
            {
                string intViewTypeCode = value;
                Session.Add("ViewTypeCode", intViewTypeCode);
            }
        }

        private string ViewName
        {
            get
            {
                string strViewName;
                strViewName = (string)Session["ViewName"];
                if (strViewName == null)
                {
                    strViewName = "";
                }
                return strViewName;
            }
            set
            {
                string strViewName = value;
                Session.Add("ViewName", strViewName);
            }
        }
        private string ViewId
        {
            get
            {
                string strViewId;
                strViewId = (string)Session["ViewId"];
                if (strViewId == null)
                {
                    strViewId = "";
                }
                return strViewId;
            }
            set
            {
                string strViewId = value;
                Session.Add("ViewId", strViewId);
            }
        }


        private string SimpleFName
        {
            get
            {
                string strSimpleFName;
                strSimpleFName = (string)ViewState["SimpleFName"];
                if (strSimpleFName == null)
                {
                    strSimpleFName = "";
                }
                return strSimpleFName;
            }
            set
            {
                string strSimpleFName = value;
                ViewState.Add("SimpleFName", strSimpleFName);
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
        private string BackGeneCode4JavaLinkStr
        {
            get
            {
                string strBackGeneCode4JavaLinkStr;
                strBackGeneCode4JavaLinkStr = (string)Session["BackGeneCode4JavaLinkStr"];
                if (strBackGeneCode4JavaLinkStr == null)
                {
                    strBackGeneCode4JavaLinkStr = "";
                }
                return strBackGeneCode4JavaLinkStr;
            }
            set
            {
                string strBackGeneCode4JavaLinkStr = value;
                Session.Add("BackGeneCode4JavaLinkStr", strBackGeneCode4JavaLinkStr);
            }
        }


        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and ApplicationTypeId = '03'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " and vViewInfo.ViewName like '" + this.txtViewNameq.Text.Trim() + "%'";
            }

            if (this.ddlFuncModuleIdq.SelectedValue != "" && this.ddlFuncModuleIdq.SelectedValue != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue + "'";
            }

            if (this.txtMainTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and vViewInfo.MainTabName like '" + this.txtMainTabNameq.Text.Trim() + "%'";
            }
            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and vViewInfo.UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " and vViewInfo.PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlApplicationTypeIdq.SelectedValue != "" && this.ddlApplicationTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeIdq.SelectedValue + "'";
            }
            if (this.ddlViewGroupIdq.SelectedValue != "" && this.ddlViewGroupIdq.SelectedValue != "0")
            {
                strWhereCond += " And ViewGroupId='" + this.ddlViewGroupIdq.SelectedValue + "'";
            }

            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_ViewInfo()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //	4、设置DATAGRID的数据源(DataSource)；
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsViewInfoBLEx.GetViewInfoTEx(strWhereCond);
            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgViewInfo.PageSize);
            if (intPages == 0)
            {
                this.dgViewInfo.CurrentPageIndex = 0;
            }
            else if (this.dgViewInfo.CurrentPageIndex > intPages - 1)
            {
                this.dgViewInfo.CurrentPageIndex = intPages - 1;
            }
            //	4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortBy;
            this.dgViewInfo.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgViewInfo.DataBind();
            //	6、设置记录数的状态，
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
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
            this.dgViewInfo.CurrentPageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindDg_ViewInfo();
            //保存这次查询条件，为下一次再来该界面服务================
            seFuncModuleAgcId = ddlFuncModuleIdq.SelectedValue;
            
            ViewName = txtViewNameq.Text;
            //=====================================================
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgViewInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgViewInfo.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_ViewInfo();
        }


        
        public System.Data.DataTable GetViewTypeCode()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetViewTypeCode();
            objDDL.DataValueField = "ViewTypeCode";
            objDDL.DataTextField = "ViewTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
     

        protected void dgViewInfo_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
            //			if (e.Item.ItemType == ListItemType.Item ||
            //				e.Item.ItemType == ListItemType.SelectedItem ||
            //				e.Item.ItemType == ListItemType.AlternatingItem ||
            //				e.Item.ItemType == ListItemType.EditItem)
            //			{
            //				chkIsSort = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsSort");
            //				string strIsSort = e.Item.Cells[10].Text;
            //				chkIsSort.Checked = bool.Parse(strIsSort);
            //
            //				chkIsTransCode = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsTransCode");
            //				string strIsTransCode = e.Item.Cells[12].Text;
            //				chkIsTransCode.Checked = bool.Parse(strIsTransCode);
            //
            //			}
        }

        /// <summary>
        /// 功能：修改界面记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// 功能：删除界面记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            clsViewInfoBL.DelRecord(strViewId);
            BindDg_ViewInfo();
        }

        /// <summary>
        /// 功能：为界面添加操作流程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnViewOptStep_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewOptSteps_QUDI.aspx");
        }

        /// <summary>
        /// 功能：编辑界面的相关表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditRelaTab_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewRelaTab_QUDI.aspx");
        }

        /// <summary>
        /// 功能：编辑界面的按钮操作步骤；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBtnOptStep_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewBtnOptSteps_QUDI.aspx");
        }
        /// <summary>
        /// 功能：编辑界面的字段信息，为界面添加、删除等维护字段信息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditViewField_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewAddField.aspx");
        }
        /// <summary>
        /// 功能：本函数仅仅设置界面的字段信息，不添加、删除字段信息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSetViewFld_Click(object sender, System.EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);
            Response.Redirect("wfmViewSetField.aspx");

        }

        protected void lbDispViewList_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = true;
        }


        protected void btnGenViewCode_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = false;
            tabCode.Visible = true;

            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
                //AutoGC5J_VWeb autoGC4J_VWeb = new AutoGC5J_VWeb(strViewId);
                ////			if (autoGC4J_VWeb.ViewFldNum == 0)
                ////			{
                ////				ShowCode("界面中字段数为0，不能生成界面代码";
                ////				return ;
                ////
                ////			}
                //autoGC4J_VWeb.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC4J_VWeb.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC4J_VWeb.A_GenViewCode(objViewInfoENEx);
                //txtFileName4GenCode.Text = autoGC4J_VWeb.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC4J_VWeb.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenControlCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            //
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            //获取当前界面的界面组ID
            string strViewGroupId = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "所选界面没有相应的界面组信息!";
                return;
            }
            //检查界面组有没有相应的添加、修改、详细信息、列表界面，如果没有，就不能生成相应的Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//检查添加界面
            {
                ShowCode("界面组缺少相应的添加界面(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//检查修改界面
            {
                ShowCode("界面组缺少相应的修改界面(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//检查查询界面
            {
                ShowCode("界面组缺少相应的查询界面(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//检查详细信息界面
            {
                ShowCode("界面组缺少相应的详细信息界面(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//检查列表界面
            {
                ShowCode("界面组缺少相应的列表界面(table_list)!");
                return;
            }

            try
            {
                //AutoGC5J_CWeb autoGC5J_CWeb = new AutoGC5J_CWeb(strViewGroupId);
                ////			if (autoGC5J_CWeb.ViewFldNum == 0)
                ////			{
                ////				ShowCode("界面中字段数为0，不能生成界面代码";
                ////				return ;
                ////
                ////			}
                ////			if (autoGC5J_CWeb.TabKeyFldNum == 0)
                ////			{
                ////				ShowCode("界面相关表的表关键字段数为0，请检查界面的相关表是否有表关键字段!";
                ////				return ;
                ////			}

                //autoGC5J_CWeb.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_CWeb.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_CWeb.A_GenActionCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5J_CWeb.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_CWeb.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }

        protected void btnGenGeneLogicCode_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            //
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            ///根据ViewId获取编辑主表的TabId
            try
            {
                //clsViewInfoEN objViewInfo = clsViewInfoBL.G1etViewInfoByViewId(strViewId);
                //string strTabId = objViewInfo.MainTabId;
                //if (CheckTabFieldBySqlTab(strTabId) == false)
                //{
                //    return;
                //}
                //AutoGC4J_M autoGC4J_M = new AutoGC4J_M(strTabId);
                //autoGC4J_M.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC4J_M.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC4J_M.A_GenGeneralLogicCode(ref strResult);
                //txtFileName4GenCode.Text = autoGC4J_M.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC4J_M.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = true;
            tabCode.Visible = false;
        }

        //protected void btnCtlViewCode_Click(object sender, System.EventArgs e)
        //{
        //    tabQuery1.Visible = false;
        //    tabCode.Visible = true;

        //    string strViewId = (string)rd.Value;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebCtlViewCode;

        //    try
        //    {
        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       intApplicationTypeId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlViewCode(strViewId, "Net2010",
        //        //    clsPubVar.objCurrSelProject, 
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "",
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        //protected void btnCtlControlCode_Click(object sender, System.EventArgs e)
        //{


        //    string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
          
        //    tabQuery1.Visible = false;
        //    tabCode.Visible = true;

        //    string strViewId = (string)rd.Value;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg2.Text = "";
        //    string strFileName4GenCode = "";
        //    string strCodeText="";   
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

        //    try
        //    {
         
        //        strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlControlCode(strViewId, "Net2010",
        //        //    clsPubVar.objCurrSelProject, 
        //        //    clsCommonSession.UserId,
        //        //     clsCommonSession.UserName, "", "", strCharEncodingId, 
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        ShowCode(strCodeText);
        //        txtFileName4GenCode.Text = strRe_FileNameWithModuleName;
        //        SimpleFName = strRe_ClsName;
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

        protected void lbDownLoadFile_Click(object sender, System.EventArgs e)
        {

            string strFileName = clsCommonSession.UserId + "\\" + SimpleFName;
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("/ClsFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strFileContent, string strFileName)
        {
            //			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
            ///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
            Response.Clear();
            //			Response.AddHeader("Content-Disposition", "inline; filename=" + ); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(strFileName));
            //			Response.AddHeader("Content-Length", strFileContent.Length.ToString()); 
            Response.ContentType = "application/octet-stream";
            Response.Write(strFileContent);
            Response.Write("\r\r\n");
            Response.End();
            return true;
        }

        protected void btnPreView_Click(object sender, System.EventArgs e)
        {

            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            ViewId = strViewId;
            BackGeneCode4JavaLinkStr = Page.Request.Url.AbsolutePath;
            Response.Redirect("../View/wfmPreviewViewRegion.aspx?ParentPage=GeneCode4Java");
        }

        protected void btnGeneStrutsConfig_Click(object sender, System.EventArgs e)
        {

            tabQuery1.Visible = false;
            tabCode.Visible = true;

            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";

            string strViewGroupId =  clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "所选界面没有相应的界面组信息!";
                return;
            }
            //检查界面组有没有相应的添加、修改、详细信息、列表界面，如果没有，就不能生成相应的Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//检查添加界面
            {
                ShowCode("界面组缺少相应的添加界面(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//检查修改界面
            {
                ShowCode("界面组缺少相应的修改界面(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//检查查询界面
            {
                ShowCode("界面组缺少相应的查询界面(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//检查详细信息界面
            {
                ShowCode("界面组缺少相应的详细信息界面(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//检查列表界面
            {
                ShowCode("界面组缺少相应的列表界面(table_list)!");
                return;
            }

            try
            {

                //AutoGC5J_Manager autoGC5J_Manager = new AutoGC5J_Manager(strViewGroupId);

                //autoGC5J_Manager.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_Manager.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_Manager.A_GenStrutsConfigCode();
                //txtFileName4GenCode.Text = autoGC5J_Manager.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_Manager.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }


        }

        protected void btnLogicManagerCode_Click(object sender, System.EventArgs e)
        {

            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            //
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            //获取当前界面的界面组ID
            string strViewGroupId = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "所选界面没有相应的界面组信息!";
                return;
            }
            //检查界面组有没有相应的添加、修改、详细信息、列表界面，如果没有，就不能生成相应的Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//检查添加界面
            {
                ShowCode("界面组缺少相应的添加界面(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//检查修改界面
            {
                ShowCode("界面组缺少相应的修改界面(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//检查查询界面
            {
                ShowCode("界面组缺少相应的查询界面(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//检查详细信息界面
            {
                ShowCode("界面组缺少相应的详细信息界面(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//检查列表界面
            {
                ShowCode("界面组缺少相应的列表界面(table_list)!");
                return;
            }
            try
            {
                //AutoGC5J_Manager autoGC5J_Manager = new AutoGC5J_Manager(strViewGroupId);


                //autoGC5J_Manager.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_Manager.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_Manager.A_GenManagerCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5J_Manager.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_Manager.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnGenGeneExLogicCode_Click(object sender, System.EventArgs e)
        {


            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            ///根据ViewId获取编辑主表的TabId
            try
            {
                clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                string strTabId = objViewInfo.MainTabId;
                if (CheckTabFieldBySqlTab(strTabId) == false)
                {
                    return;
                }
              
                //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);
                //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5Cs_M.A_GenGeneralExLogicCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
        }

        protected void btnCtlViewCode4Query_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = false;
            tabCode.Visible = true;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
            if (objViewInfoENEx.ViewFldNum == 0)
            {
                ShowCode("界面中字段数为0，不能生成界面代码");
                return;

            }
            objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
            objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
            ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab4Query(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
            txtFileName4GenCode.Text = objViewInfoENEx.FileName;
            SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

        }


        protected void btnCtlViewCode_Disp_Click(object sender, System.EventArgs e)
        {

            tabQuery1.Visible = false;
            tabCode.Visible = true;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
            if (objViewInfoENEx.ViewFldNum == 0)
            {
                ShowCode("界面中字段数为0，不能生成界面代码");
                return;

            }
            objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
            objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
            ShowCode(autoGC5Cs_VWeb.A_GenCtlViewCodeforTab_Disp(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName));
            txtFileName4GenCode.Text = objViewInfoENEx.FileName;
            SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);

        }

        protected void dgViewInfo_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.dgViewInfo.Columns.Count; i++)
                {
                    strSortEx = this.dgViewInfo.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        protected void dgViewInfo_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortBy = e.SortExpression + " Asc";
                BindDg_ViewInfo();
                return;
            }
            //检查原来是升序
            intIndex = strSortBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortBy = e.SortExpression + " Desc";
            }
            BindDg_ViewInfo();
        }
        private string strSortBy
        {
            get
            {
                string sSortBy;
                sSortBy = (string)ViewState["SortBy"];
                if (sSortBy == null)
                {
                    sSortBy = "";
                }
                return sSortBy;
            }
            set
            {
                string sSortBy = value;
                ViewState.Add("SortBy", sSortBy);
            }
        }

        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            //			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
            ///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            //Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        protected void btnGenActionCode_Click(object sender, EventArgs e)
        {



            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            tabQuery1.Visible = false;
            tabCode.Visible = true;
        
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            //获取当前界面的界面组ID
            string strViewGroupId = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId).ViewGroupId;
            if (strViewGroupId == "")
            {
                lblMsg2.Text = "所选界面没有相应的界面组信息!";
                return;
            }
            //检查界面组有没有相应的添加、修改、详细信息、列表界面，如果没有，就不能生成相应的Manager
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0013'") == false)//检查添加界面
            {
                ShowCode("界面组缺少相应的添加界面(table_add)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0016'") == false)//检查修改界面
            {
                ShowCode("界面组缺少相应的修改界面(table_update)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0015'") == false)//检查查询界面
            {
                ShowCode("界面组缺少相应的查询界面(table_query)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0017'") == false)//检查详细信息界面
            {
                ShowCode("界面组缺少相应的详细信息界面(table_detail)!");
                return;
            }
            if (clsViewInfoBL.IsExistRecord("ViewTypeCode = '0014'") == false)//检查列表界面
            {
                ShowCode("界面组缺少相应的列表界面(table_list)!");
                return;
            }

            try
            {
                //AutoGC5J_CWeb autoGC5J_CWeb = new AutoGC5J_CWeb(strViewGroupId);
                ////			if (autoGC5J_CWeb.ViewFldNum == 0)
                ////			{
                ////				ShowCode("界面中字段数为0，不能生成界面代码";
                ////				return ;
                ////
                ////			}
                ////			if (autoGC5J_CWeb.TabKeyFldNum == 0)
                ////			{
                ////				ShowCode("界面相关表的表关键字段数为0，请检查界面的相关表是否有表关键字段!";
                ////				return ;
                ////			}

                //autoGC5J_CWeb.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";
                //autoGC5J_CWeb.CurrUserName = clsCommonSession.UserName;
                //ShowCode(autoGC5J_CWeb.A_GenActionCode(myEncoding);
                //txtFileName4GenCode.Text = autoGC5J_CWeb.FileName;
                //SimpleFName = clsString.GetSimpleFName_S(autoGC5J_CWeb.FileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }

        }
        protected void btnCtlControlCode4Query_Click(object sender, EventArgs e)
        {

        }


        private bool CheckTabFieldBySqlTab(string strTabId)
        {
            try
            {
                //判断是否可以删除
                if (clsTabCheckStatusBLEx.CheckPrjTabBySQLTab4OneTab(strTabId, 
                    clsPubVar.CurrSelPrjId,
                    clsPubVar.CurrPrjDataBaseId) == false)
                {
                    lblMsg2.Text = "检查表字段不成功!";
                    return false;
                }
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                clsCommonJsFunc.Alert(this.Page, objException.Message);
                return false;

            }
            return true;
        }

        /// <summary>
        /// 当前所选择的语言类型：分为： "C#.NET"; "Java";SqlOrOracle
        /// </summary>
        protected clsPubConst.LangType vsLangType
        {
            get
            {
                clsPubConst.LangType strLangType;
                if (ViewState["LangType"] == null)
                {
                    strLangType = clsPubConst.LangType.CSharp;//"C#.NET";
                    return strLangType;
                }
                strLangType = (clsPubConst.LangType)ViewState["LangType"];

                return strLangType;
            }
            set
            {
                clsPubConst.LangType strLangType = value;
                ViewState.Add("LangType", strLangType);
            }
        }
        /// <summary>
        /// 当前所选择的语言类型：分为："Ms Sql", "Oracle"; "MySql";
        /// </summary>
        protected clsPubConst.DataBaseType vsDataBaseType
        {
            get
            {
                clsPubConst.DataBaseType strDataBaseType;

                if (ViewState["DataBaseType"] == null)
                {
                    return clsPubConst.DataBaseType.MsSql;
                }
                strDataBaseType = (clsPubConst.DataBaseType)ViewState["DataBaseType"];
                return strDataBaseType;
            }
            set
            {
                clsPubConst.DataBaseType strDataBaseType = value;
                ViewState.Add("DataBaseType", strDataBaseType);
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
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
        }
    }
}