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


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;
using System.Collections.Generic;

using com.taishsoft.common;

namespace AGC.Webform
{
    /// <summary>
    /// wfmSetViewStyle 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmSetViewStyle : CommWebPageBase
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
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);
            //            this.RegisterStartupScript("js", js); 
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                ///隐藏应该隐藏的控件内容
                ///
                tabHidden.Visible = false;
                //if (clsCommForWebForm.SystemStatus == "DEBUG")
                //{
                //    PrjId = "0005";
                //    txtUserIdq.Text = "pyf";
                //    clsUsersEN objUsers = new clsUsersEN("pyf", true);
                //    objUser = objUsers;
                //}
                //1、为下拉框设置数据源，绑定列表数据
                wucViewStyle1.SetDdl_TitleStyleId(clsPubVar.CurrSelPrjId);
                wucViewStyle1.SetDdl_DgStyleId();
                
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeId, clsPubVar.CurrSelPrjId);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                //BindDdl_ViewTypeCode(ddlViewTypeCodeq);
              clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                ///设置当前登录用户的默认工程
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;

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
                //=====================================

                //2、显示无条件的表内容在DATAGRID中
                strSortViewStyleBy = "ViewName Asc";
                BindGv_ViewStyle();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                wucViewStyle1.SetKeyReadOnly(true);
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


        private string seUserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
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
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }

      
     

        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineViewStyleCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtViewNameq.Text.Trim() != "")
            {
                strWhereCond += " and ViewName like '" + this.txtViewNameq.Text.Trim() + "%'";
            }
            if (this.ddlViewTypeCodeq.SelectedValue != "" && this.ddlViewTypeCodeq.SelectedValue != "0")
            {
                strWhereCond += " and ViewTypeCode='" + this.ddlViewTypeCodeq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleIdq.SelectedValue != "" && this.ddlFuncModuleIdq.SelectedValue != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue + "'";
            }
            if (this.txtMainTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and MainTabName like '" + this.txtMainTabNameq.Text.Trim() + "%'";
            }
            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.ddlPrjIdq.SelectedValue != "" && this.ddlPrjIdq.SelectedValue != "0")
            {
                strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue + "'";
            }
            if (this.ddlApplicationTypeId.SelectedValue != "" && this.ddlApplicationTypeId.SelectedValue != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        protected void BindGv_ViewStyle()
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
                string strWhereCond = CombineViewStyleCondition();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvViewInfoBL.GetDataTable_vViewInfo(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "(errid:WebI001079)获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortViewStyleBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                             ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvViewStyle.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvViewStyle.PageSize = 10;
            }
            this.gvViewStyle.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvViewStyle.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvViewStyle.BottomPagerRow;
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
                lblAllPages.Text = this.gvViewStyle.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvViewStyle.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvViewStyle.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvViewStyle.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvViewStyle.PageIndex == this.gvViewStyle.PageCount - 1)
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
            gvViewStyle.BottomPagerRow.Visible = true;
        }
        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPageSizeViewState)
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
            this.gvViewStyle.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_ViewStyle();
            //保存这次查询条件，为下一次再来该界面服务
            seFuncModuleAgcId = ddlFuncModuleIdq.SelectedValue;
            ViewTypeCode = ddlViewTypeCodeq.SelectedValue;
            ViewName = txtViewNameq.Text;

        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
         protected void gvViewStyle_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvViewStyle.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_ViewStyle();
        }

        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strMsg;  //专门用于传递信息的变量
            string strResult = "";
            string strCommandText;
            clsViewStyleEN objViewStyleEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "确认设置":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    //操作步骤：
                    //1、检查控件中输入数据类型是否正确
                    //2、定义对象并初始化对象
                    //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    //4、把值从界面层传到逻辑层或数据实体层
                    //5、检查传进去的对象属性是否合法
                    //6、把数据实体层的数据存贮到数据库中
                    //7、把新添的记录内容显示在DATAGRID中
                    //1、检查控件中输入数据类型是否正确
                    ///
                    

                    if (!wucViewStyle1.IsValid(ref strResult))
                    {
                        lblMsg.Text = "控件中输入数据类型不正确请检查!";
                        return;
                    }
                    //2、把值从界面层传到逻辑层或数据实体层
                    objViewStyleEN = (clsViewStyleEN)Session["objViewStyleEN"];
                    if (objViewStyleEN == null)
                    {
                        objViewStyleEN = new clsViewStyleEN();
                    }
                    PutDataToViewStyleClass(objViewStyleEN);		//把界面的值传到
                    //3、检查传进去的对象属性是否合法
                    try
                    {
                        clsViewStyleBL.CheckPropertyNew(objViewStyleEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
				
                    //4、把数据实体层的数据修改同步到数据库中
                    if (clsViewStyleBL.IsExist(objViewStyleEN.ViewId) == false)
                    {
                        if (clsViewStyleBL.AddNewRecordBySql2(objViewStyleEN) == false)
                        {
                            strMsg = "修改记录不成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "修改记录不成功!";
                        }
                        else
                        {
                            strMsg = "修改记录成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "修改记录成功!";
                        }
                    }
                    else
                    {
                        if (clsViewStyleBL.UpdateBySql2(objViewStyleEN) == false)
                        {
                            strMsg = "修改记录不成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "修改记录不成功!";
                        }
                        else
                        {
                            strMsg = "修改记录成功!";
                            clsCommonJsFunc.Alert(this, strMsg);
                            lblMsg.Text = "修改记录成功!";
                        }
                    }
                    //5、把修改后的内容显示在DATAGRID中
                    BindGv_ViewStyle();
                    wucViewStyle1.Clear();//添空控件中的内容
                    //恢复<确认修改>变成<添加>
                    //tabLayout.Visible = false;
                    break;
            }
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
    

        protected void gvViewStyle_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 11;
                iNum[1] = 12;
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
                //				chkIsSort = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsSort");
                //				string strIsSort = e.Item.Cells[11].Text;
                //				chkIsSort.Checked = bool.Parse(strIsSort);
                //
                //				chkIsTransCode = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsTransCode");
                //				string strIsTransCode = e.Item.Cells[13].Text;
                //				chkIsTransCode.Checked = bool.Parse(strIsTransCode);

            }
        }


        protected void lbDispViewList_Click(object sender, System.EventArgs e)
        {
            tabQuery1.Visible = true;
            tabLayout.Visible = false;
        }


        protected void btnSetViewStyle_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvViewStyle, "ViewId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg2.Text = "(errid:WebI001087)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsg2.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            string strViewId = strKeys[0];
            if (strViewId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("ViewId", strViewId);

            ShowData(strViewId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucViewStyle1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认设置";
            lblMsg.Text = "";
            tabLayout.Visible = true;

        }

        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strDgStyleId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(string strViewId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            clsViewStyleEN objViewStyleEN = new clsViewStyleEN(strViewId);
            //1、检查关键字是否为空；
            if (strViewId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsViewStyleBL.IsExist(strViewId) == false)		//检查该关键字的记录是否存在
            {
                objViewStyleEN.DgStyleId = "0001";
                objViewStyleEN.TitleStyleId = "0001";
                clsViewStyleBL.AddNewRecordBySql2(objViewStyleEN);
            }
            else
            {
                //3、用提供的关键字初始化一个类对象；

                //4、获取类对象的所有属性；
                clsViewStyleBL.GetViewStyle(ref objViewStyleEN);
                Session.Add("objViewStyleEN", objViewStyleEN);
            }
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromViewStyleClass(objViewStyleEN);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjViewStyle">表实体类对象</param>
        private void GetDataFromViewStyleClass(clsViewStyleEN pobjViewStyle)
        {
            wucViewStyle1.ViewId = pobjViewStyle.ViewId;
            wucViewStyle1.TitleStyleId = pobjViewStyle.TitleStyleId;
            wucViewStyle1.DgStyleId = pobjViewStyle.DgStyleId;
        }
        
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjViewStyle">数据传输的目的类对象</param>
        private void PutDataToViewStyleClass(clsViewStyleEN pobjViewStyle)
        {
            pobjViewStyle.ViewId = wucViewStyle1.ViewId;
            pobjViewStyle.TitleStyleId = wucViewStyle1.TitleStyleId;
            pobjViewStyle.DgStyleId = wucViewStyle1.DgStyleId;
        }
        /// <summary>
        /// 事件函数：在GridView中，单击列头进行排序所发生的事件
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_Sorting)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvViewStyle_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortViewStyleBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortViewStyleBy = e.SortExpression + " Asc";
                BindGv_ViewStyle();
                return;
            }
            //检查原来是升序
            intIndex = strSortViewStyleBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                strSortViewStyleBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                strSortViewStyleBy = e.SortExpression + " Desc";
            }
            BindGv_ViewStyle();
        }
 
        protected void gvViewStyle_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortViewStyleBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvViewStyle.Columns.Count; i++)
                {
                    strSortEx = this.gvViewStyle.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortViewStyleBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortViewStyleBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        private string strSortViewStyleBy
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
      
        protected void ddlApplicationTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;
            if (strApplicationTypeId != null && strApplicationTypeId != "")
            {
                clsViewTypeCodeTabBLEx.BindDdl_ViewTypeCodeByAppIdCache(ddlViewTypeCodeq, int.Parse( strApplicationTypeId));
            }

        }

        #region 错误处理函数

     
     

        #endregion 错误处理函数




        /// <summary>
        /// 事件函数：生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理：跳转到GridView的某一数。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenJumpPage_RelaFunction)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvViewStyle.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvViewStyle.PageCount)
                {
                    this.gvViewStyle.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_ViewStyle();
            }
        }


        /// <summary>
        /// 事件函数：在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理：改变GridView的每页记录数。
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    BindGv_ViewStyle();
                }
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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