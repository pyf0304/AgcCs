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
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPrjTab_Check : System.Web.UI.Page
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
            //this.RegisterStartupScript("js",js);
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);


            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                ///隐藏应该应该隐藏的控件内容

                //1、为下拉框设置数据源，绑定列表数据
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
                clsTabStateBL.BindDdl_TabStateIdCache(ddlTabStateIdq);

                //恢复上一次在此界面的状态
                if (seFuncModuleAgcId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleId, seFuncModuleAgcId);
                }
                if (ObjId != "")
                {
                    clsDropDownList.SetDdlValue(ddlObjIdq, ObjId);
                }
                txtTabNameq.Text = TabName;
                txtTabCnNameq.Text = TabCnName;
                //=====================================================

                ddlTabStateIdq.SelectedValue = "01";

                //2、显示无条件的表内容在DATAGRID中
                vsSortPrjTabBy = "TabName Asc";
                BindDg_PrjTab();
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

        private string ObjId
        {
            get
            {
                string strObjId;
                strObjId = (string)Session["ObjId"];
                if (strObjId == null)
                {
                    strObjId = "";
                }
                return strObjId;
            }
            set
            {
                string strObjId = value;
                Session.Add("ObjId", strObjId);
            }
        }

        private string TabName
        {
            get
            {
                string strTabName;
                strTabName = (string)Session["TabName"];
                if (strTabName == null)
                {
                    strTabName = "";
                }
                return strTabName;
            }
            set
            {
                string strTabName = value;
                Session.Add("TabName", strTabName);
            }
        }
        private string TabCnName
        {
            get
            {
                string strTabCnName;
                strTabCnName = (string)Session["TabCnName"];
                if (strTabCnName == null)
                {
                    strTabCnName = "";
                }
                return strTabCnName;
            }
            set
            {
                string strTabCnName = value;
                Session.Add("TabCnName", strTabCnName);
            }
        }

        private string UserId
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
        private string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}


        
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and PrjId= '" + clsPubVar.CurrSelPrjId + "'";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabCnNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabCnName like '" + this.txtTabCnNameq.Text.Trim() + "%'";
            }
            if (this.txtTabNameq.Text.Trim() != "")
            {
                strWhereCond += " and TabName like '" + this.txtTabNameq.Text.Trim() + "%'";
            }
            if (this.ddlObjIdq.SelectedValue != "" && this.ddlObjIdq.SelectedValue != "0")
            {
                strWhereCond += " and ObjId='" + this.ddlObjIdq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }
            if (this.ddlTabStateIdq.SelectedValue != "" && this.ddlTabStateIdq.SelectedValue != "0")
            {
                strWhereCond += " And TabStateId='" + this.ddlTabStateIdq.SelectedValue + "'";
            }

            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_PrjTab()
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
            System.Data.DataTable objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTab.PageSize);
            if (intPages == 0)
            {
                this.dgPrjTab.CurrentPageIndex = 0;
            }
            else if (this.dgPrjTab.CurrentPageIndex > intPages - 1)
            {
                this.dgPrjTab.CurrentPageIndex = intPages - 1;
            }
            //	4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortPrjTabBy;
            this.dgPrjTab.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgPrjTab.DataBind();
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
            this.dgPrjTab.CurrentPageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindDg_PrjTab();
            //保存这次查询条件，为下一次再来该界面服务
            seFuncModuleAgcId = ddlFuncModuleId.SelectedValue;
            ObjId = ddlObjIdq.SelectedValue;
            TabName = txtTabNameq.Text;
            TabCnName = txtTabCnNameq.Text;

        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgPrjTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgPrjTab.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_PrjTab();
        }


        /// <summary>
        /// 选择的表中添加字段。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbAddField_Click(object sender, System.EventArgs e)
        {
            string strTabId = (string)rd.Value;
            if (strTabId.Trim().Length == 0)
            {
                lblMsg2.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg2.Text = "";
            Session.Add("TabId", strTabId);
            string strFileFolder = Server.MapPath("~");

            clsPrjTabFldBLEx.ReNumber(strTabId);
            Response.Redirect("wfmPrjTabFld_QUDI.aspx");
        }


        protected void lbDispTabList_Click(object sender, System.EventArgs e)
        {
            tabQuery.Visible = true;
        }

        protected void dgPrjTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortPrjTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
                BindDg_PrjTab();
                return;
            }
            //检查原来是升序
            intIndex = vsSortPrjTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortPrjTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortPrjTabBy = e.SortExpression + " Desc";
            }
            BindDg_PrjTab();

        }

        protected void dgPrjTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (vsSortPrjTabBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.dgPrjTab.Columns.Count; i++)
                {
                    strSortEx = this.dgPrjTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortPrjTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortPrjTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        protected void lbSetChecked_Click(object sender, System.EventArgs e)
        {
            //操作步骤：
            //1、对DG进行循环
            //2、针对每一行中的<是否排序><是否查询>等字段的编辑结果进行存盘
            //3、在循环中初始化一个clsPrjTabEN对象，利用关键字MID
            //4、赋值；
            //5、存盘
            ///
            System.Web.UI.WebControls.CheckBox chkIsChecked;
            //			System.Web.UI.WebControls.CheckBox chkIsArchive;
            string strFldId;
            bool bolIsChecked;		//, bolIsArchive;
            clsPrjTabEN objPrjTabEN;
            int intDgNum, intIndex;
            DataGridItem item;
            //1、对DG进行循环
            intDgNum = dgPrjTab.Items.Count;
            for (intIndex = 0; intIndex < intDgNum; intIndex++)
            {
                item = dgPrjTab.Items[intIndex];
                strFldId = item.Cells[1].Text;
                //2、针对每一行中的<是否排序><是否查询>等字段的编辑结果进行存盘
                //3、在循环中初始化一个clsPrjTabEN对象，利用关键字MID
                objPrjTabEN = clsPrjTabBL.GetObjByTabId(strFldId);
                //4、赋值；

                chkIsChecked = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsChecked");
                bolIsChecked = chkIsChecked.Checked;

                //				chkIsArchive = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsArchive");
                //				bolIsArchive = chkIsArchive.Checked;

                objPrjTabEN.IsChecked = bolIsChecked;
                //				objPrjTabEN.IsArchive = bolIsArchive;
                //5、存盘
                if (clsPrjTabBL.UpdateBySql2(objPrjTabEN) == false)
                {
                    return;
                }
            }
            BindDg_PrjTab();
        }

        protected void dgPrjTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            System.Web.UI.WebControls.CheckBox chkIsChecked;	//, chkIsArchive;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 10;
                //				iNum[1] = 7;
                for (int i = 0; i < 1; i++)
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
                chkIsChecked = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsChecked");
                string strIsChecked = e.Item.Cells[8].Text;
                chkIsChecked.Checked = bool.Parse(strIsChecked);
                //
                //				chkIsArchive = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsArchive");
                //				string strIsArchive = e.Item.Cells[10].Text;
                //				chkIsArchive.Checked = bool.Parse(strIsArchive);
            }
        }

        private string vsSortPrjTabBy
        {
            get
            {
                string sSortPrjTabBy;
                sSortPrjTabBy = (string)ViewState["SortPrjTabBy"];
                if (sSortPrjTabBy == null)
                {
                    sSortPrjTabBy = "";
                }
                return sSortPrjTabBy;
            }
            set
            {
                string sSortPrjTabBy = value;
                ViewState.Add("SortPrjTabBy", sSortPrjTabBy);
            }
        }


    }
}