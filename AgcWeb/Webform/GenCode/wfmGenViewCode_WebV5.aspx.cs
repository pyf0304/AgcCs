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
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;


using System.Text;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using com.taishsoft.common;
using AutoGCLib;
using AgcCommBase;


namespace AGC.Webform
{
    /// <summary>
    /// wfmGenViewCode_WebV5 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmGenViewCode_WebV5 : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            string js = "";
            js += "<script>\r\r\n";
            js += "Function ld(){\r\r\n";
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
                vsLangType = clsPubConst.LangType.CSharp;
                vsDataBaseType = clsPubConst.DataBaseType.MsSql;
                tabHidden.Visible = false;
                if (clsCommForWebForm.SystemStatus == "DEBUG")
                {
                   
                }
                //1、为下拉框设置数据源，绑定列表数据
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                clsViewTypeCodeTabBLEx.BindDdl_ViewTypeCodeByAppIdCache(ddlViewTypeCodeq, clsApplicationTypeBLEx.DOTNETWEBAPP);
              clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq, clsPubVar.CurrSelPrjId);
                clsViewGroupBLEx.BindDdl_ViewGroupId(ddlViewGroupIdq, clsPubVar.CurrSelPrjId);

                ///设置当前登录用户的默认工程
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
                ddlApplicationTypeIdq.SelectedValue = clsApplicationTypeBLEx.DOTNETWEBAPP.ToString();
                ddlApplicationTypeIdq.Enabled = false;
                //恢复上一次在此界面的状态
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
                }
                if (ViewTypeCode != "")
                {
                    clsDropDownList.SetDdlValue(ddlViewTypeCodeq, ViewTypeCode);
                }
                txtViewNameq.Text = ViewName;
                //===============================


                //2、显示无条件的表内容在DATAGRID中
                strSortBy = "ViewName Asc";
                BindDg_ViewInfo();
                divGeneQueryCtl.Visible = false;
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

        private string BackGeneCode4WebV5LinkStr
        {
            get
            {
                string strBackGeneCode4WebV5LinkStr;
                strBackGeneCode4WebV5LinkStr = (string)Session["BackGeneCode4WebV5LinkStr"];
                if (strBackGeneCode4WebV5LinkStr == null)
                {
                    strBackGeneCode4WebV5LinkStr = "";
                }
                return strBackGeneCode4WebV5LinkStr;
            }
            set
            {
                string strBackGeneCode4WebV5LinkStr = value;
                Session.Add("BackGeneCode4WebV5LinkStr", strBackGeneCode4WebV5LinkStr);
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
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " and vViewInfo.ViewName like '" + this.txtViewNameq.Text.Trim() + "%'";
            }
            if (this.ddlViewTypeCodeq.SelectedValue != "" && this.ddlViewTypeCodeq.SelectedValue != "0")
            {
                strWhereCond += " and vViewInfo.ViewTypeCode='" + this.ddlViewTypeCodeq.SelectedValue + "'";
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
            ViewTypeCode = ddlViewTypeCodeq.SelectedValue;
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


        //protected void btnGenViewCode_Click(object sender, System.EventArgs e)
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
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewCode;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneViewCode(strViewId, rblNetVersion.SelectedValue,
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

        ////protected void btnGenControlCode_Click(object sender, System.EventArgs e)
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
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneControlCode(strViewId, rblNetVersion.SelectedValue,
        //        //    clsPubVar.objCurrSelProject, clsCommonSession.UserId,
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

        //protected void btnGenGeneLogicCode_Click(object sender, System.EventArgs e)
        //{

        //    Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
        //    tabQuery1.Visible = false;
        //    tabCode.Visible = true;
            
        //    string strViewId = (string)rd.Value;
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
           

        //    lblMsg2.Text = "";
        //    ///根据ViewId获取编辑主表的TabId

        //    try
        //    {
        //        clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId);
        //        string strTabId = objViewInfo.MainTabId;
        //        if (CheckTabFieldBySqlTab(strTabId) == false)
        //        {
        //            return;
        //        }
         
        //        //AutoGC5Cs_M autoGC5Cs_M = new AutoGC5Cs_M(strTabId, clsPubVar.CurrPrjDataBaseId);

        //        //autoGC5Cs_M.objPrjTabENEx.FolderName = "D:\\FTP\\ClsFile\\" + clsCommonSession.UserId + "\\";

        //        //autoGC5Cs_M.objPrjTabENEx.CurrUserName = clsCommonSession.UserName;
        //        //ShowCode(autoGC5Cs_M.A_GenGeneralLogicCode(myEncoding);
        //        //txtFileName4GenCode.Text = autoGC5Cs_M.objPrjTabENEx.FileName;
        //        //SimpleFName = clsString.GetSimpleFName_S(autoGC5Cs_M.objPrjTabENEx.FileName);
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }
        //}

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
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlViewCode(strViewId, rblNetVersion.SelectedValue,
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
    
       
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, "",
        //                       vsLangType, vsDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlControlCode(strViewId, rblNetVersion.SelectedValue,
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
            BackGeneCode4WebV5LinkStr = Page.Request.Url.AbsolutePath;
            Response.Redirect("../View/wfmPreviewViewRegion.aspx?ParentPage=GeneCode4WebV5");
        }

        protected void lbDispDivGeneQueryCtl_Click(object sender, System.EventArgs e)
        {
            divGeneQueryCtl.Visible = true;
        }

        protected void lbCloseDivQueryCtl_Click(object sender, System.EventArgs e)
        {
            divGeneQueryCtl.Visible = false;
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

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
            lblMsg2.Text = "";
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

        protected void btnCtlControlCode4Query_Click(object sender, EventArgs e)
        {

        }
        protected void ddlApplicationTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strApplicationTypeId = ddlApplicationTypeIdq.SelectedValue;
            if (strApplicationTypeId != null && strApplicationTypeId != "")
            {
                clsViewTypeCodeTabBLEx.BindDdl_ViewTypeCodeByAppIdCache(ddlViewTypeCodeq, int.Parse( strApplicationTypeId));
            }
        }
        protected void btnGeneCode_Click(object sender, EventArgs e)
        {
            string strViewId = (string)rd.Value;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            clsCommonSession.ViewId = strViewId;
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenViewCodeV6.aspx','aa'); </script>";
            Response.Write(c1);
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