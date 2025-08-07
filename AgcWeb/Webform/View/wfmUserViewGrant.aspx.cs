///生成查询修改记录的控制层代码
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
using com.taishsoft.commdb;
using CommFunc4WebForm;

using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;

namespace AGC.Webform
{
    /// <summary>
    /// wfmUsers_Q 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmUserViewGrant : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
                //				PrjId = "0005";
                // 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
                //wucStudent1.SetDdl_College();
                //1、为下拉框设置数据源，绑定列表数据
                clsDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentIdq);
                BindDdl_UserStateId(ddlUserStateIdq);
                clsUserRolesBL.BindDdl_RoleId(ddlRoleIdq);
                //2、显示无条件的表内容在DATAGRID中
                //string strSortBy = " Asc";
                BindDg_Users();
                Table1.Visible = false;
                TableShow.Visible = false;

            }
        }

        /// <summary>
        /// 专门用于存储当前界面中的私有变量，用户ID
        /// 利用属性过程和SESSION来存储界面中的私有变量，
        ///		这是一个技巧，也是本公司的编程规划和方法，这时属性过程的第一个字母均用“p”
        /// </summary>
        private string pUserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["pUserId"];
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
                Session.Add("pUserId", strUserId);
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
            if (this.txtUserIdq.Text.Trim() != "")
            {
                strWhereCond += " and Users.UserId='" + this.txtUserIdq.Text.Trim() + "'";
            }
            if (this.txtUserNameq.Text.Trim() != "")
            {
                strWhereCond += " and Users.UserName='" + this.txtUserNameq.Text.Trim() + "'";
            }
            if (this.ddlDepartmentIdq.SelectedValue != "" && this.ddlDepartmentIdq.SelectedValue != "0")
            {
                strWhereCond += " and Users.DepartmentId='" + this.ddlDepartmentIdq.SelectedValue + "'";
            }
            if (this.ddlUserStateIdq.SelectedValue != "" && this.ddlUserStateIdq.SelectedValue != "0")
            {
                strWhereCond += " and Users.UserStateId='" + this.ddlUserStateIdq.SelectedValue + "'";
            }
            if (this.txtPassWordq.Text.Trim() != "")
            {
                strWhereCond += " and Users.PassWord='" + this.txtPassWordq.Text.Trim() + "'";
            }
            if (this.txtMemoq.Text.Trim() != "")
            {
                strWhereCond += " and Users.Memo='" + this.txtMemoq.Text.Trim() + "'";
            }
            if (this.txtqxdjq.Text.Trim() != "")
            {
                strWhereCond += " and Users.qxdj='" + this.txtqxdjq.Text.Trim() + "'";
            }
            if (this.ddlRoleIdq.SelectedValue != "" && this.ddlRoleIdq.SelectedValue != "0")
            {
                strWhereCond += " and Users.RoleId='" + this.ddlRoleIdq.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_Users()
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
            System.Data.DataTable objDT = clsvUsersBL.GetDataTable(strWhereCond);
            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgUsers.PageSize);
            if (intPages == 0)
            {
                this.dgUsers.CurrentPageIndex = 0;
            }
            else if (this.dgUsers.CurrentPageIndex > intPages - 1)
            {
                this.dgUsers.CurrentPageIndex = intPages - 1;
            }
            //	4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            this.dgUsers.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgUsers.DataBind();
            //	6、设置记录数的状态，
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
        }

        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_UserViewGrant()
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
            //string strWhereCond = CombineCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            string UserID = pUserId;
            string strWhereCond = " UserViewGrant.UserId='" + UserID + "'";
            System.Data.DataTable objDT = clsUserViewGrantBL.GetDataTable(strWhereCond);
            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //		3.1 首先计算页数；
            //		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgUserViewGrant.PageSize);
            if (intPages == 0)
            {
                this.dgUserViewGrant.CurrentPageIndex = 0;
            }
            else if (this.dgUserViewGrant.CurrentPageIndex > intPages - 1)
            {
                this.dgUserViewGrant.CurrentPageIndex = intPages - 1;
            }
            //	4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            this.dgUserViewGrant.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgUserViewGrant.DataBind();
            //	6、设置记录数的状态，
            this.txtRecCount1.Text = objDT.Rows.Count.ToString();
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
            string strWhereCond = " ViewInfo.PrjId='" + clsPubVar.CurrSelPrjId + "'";
            strWhereCond += " and ViewInfo.ViewId not in (Select UserViewGrant.ViewId from";
            strWhereCond += " UserViewGrant where UserViewGrant.PrjId ='" + clsPubVar.CurrSelPrjId + "'";
            strWhereCond += " and UserViewGrant.UserId ='" + pUserId + "'" + ")";

            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsViewInfoBL.GetDataTable_ViewInfo(strWhereCond);
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
            this.dgViewInfo.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgViewInfo.DataBind();
            //	6、设置记录数的状态，
            this.txtRecCount2.Text = objDT.Rows.Count.ToString();
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
            this.dgUsers.CurrentPageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindDg_Users();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgUsers_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgUsers.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_Users();
        }

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

        protected void dgUserViewGrant_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgUserViewGrant.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_UserViewGrant();
        }

        public System.Data.DataTable GetUserStateId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserStateId, UserStateName from UserState ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserStateId();
            objDDL.DataValueField = "UserStateId";
            objDDL.DataTextField = "UserStateName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        protected void dgUsers_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            //long lngMId;
            string strUserId;
            string strCommandName;

            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                //lngMId = long.Parse(e.Item.Cells[0].Text);
                strUserId = e.Item.Cells[0].Text;
                switch (strCommandName)
                {
                    case "Select":
                        pUserId = strUserId;
                        BindDg_UserViewGrant();
                        BindDg_ViewInfo();
                        TableShow.Visible = true;
                        Table1.Visible = false;
                        //dgUserViewGrant.Visible = true;
                        //Table2.Visible = true;

                        break;
                    //					case "Delete":
                    //						clsFldObjTabBL.DelRecord(lngMId);
                    //						BindDg_FldObjTab();
                    //						break;
                    //						// Add other cases here, if there are multiple ButtonColumns in 
                    //						// the DataGrid control.
                    //					case "Update":
                    //						//操作步骤：（总共2步）
                    //						//1、显示该关键字记录的内容在界面上；
                    //						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
                    //
                    //						//1、显示该关键字记录的内容在界面上；
                    //						ShowData(lngMId);
                    //						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
                    //						clsPubFun.SetButtonEnabled(btnOKUpd, true);
                    //						btnOKUpd.Text = "确认修改";
                    //						lblMsg.Text = "";
                    //						break;
                    //
                    default:
                        // Do nothing.
                        break;
                }
            }
        }

        private void Get_ObjectViewArrylist(DataGrid objDg, ArrayList objArr)
        {
            if (objArr == null || objDg.Items.Count == 0)
            {
                return;//判断DataGrid的记录是否为空或者队列的记录为空？
            }
            else
            {
                objArr.Clear();//清空队列
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("ckb1");//定义一个CheckBox将其等价于
                    if (cb != null && cb.Checked)                   //DataGrid中的CheckBox
                    {
                        objArr.Add(di.Cells[1].Text);//将打勾的CheckBox所在记录的关键字放入队列
                        cb.Checked = false;         //将CheckBox还原
                    }
                }

            }

        }

        private void Add_ObjectViewtoUserViewGrant(ArrayList objArr)
        {
            if (objArr.Count == 0)
            {
                return;
            }
            else
            {
                clsUserViewGrantEN objUserViewGrant;
                foreach (string ViewID in objArr)
                {
                    string strCondition = " UserViewGrant.UserId='" + pUserId + "'";
                    strCondition += " and UserViewGrant.ViewId='" + ViewID + "'";
                    if (!clsUserViewGrantBL.IsExistRecord(strCondition))
                    {
                        objUserViewGrant = new clsUserViewGrantEN();
                        objUserViewGrant.PrjId = clsPubVar.CurrSelPrjId;
                        objUserViewGrant.UserId = pUserId;
                        objUserViewGrant.ViewId = ViewID;
                        //objUserViewGrant.
                        //					objTabFld.TabId=this.TabId;
                        //					objTabFld.FldId=FldId;
                        //					objTabFld.IsPrimary=false;
                        //					objTabFld.PrimaryTypeId="00";
                        objUserViewGrant.mId = 0;
                        clsUserViewGrantBL.AddNewRecordBySql2(objUserViewGrant);
                        //					objTabFld.AddNewRecord();
                    }
                }
            }
            BindDg_UserViewGrant();


        }

        private void Btn_AddView_Click(object sender, System.EventArgs e)
        {
            ArrayList objArr = new ArrayList();//创建一个队列
            this.Get_ObjectViewArrylist(this.dgViewInfo, objArr);//将获取的每个对象加入到队列中
            this.Add_ObjectViewtoUserViewGrant(objArr);//将队列的值（与其他值一起）放入数据库表中
            BindDg_UserViewGrant();//重新绑定DataGrid
            BindDg_ViewInfo();
            Response.Write("<script>alert('所选字段添加成功！！')</script>");

        }

        protected void dgUserViewGrant_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
                myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex + 1).ToString() + " 行吗？');");
            }
        }

        protected void dgUserViewGrant_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            long lngMId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngMId = long.Parse(e.Item.Cells[0].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        clsUserViewGrantBL.DelRecord(lngMId);
                        BindDg_UserViewGrant();
                        BindDg_ViewInfo();
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    //					case "Update":
                    //						//操作步骤：（总共2步）
                    //						//1、显示该关键字记录的内容在界面上；
                    //						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
                    //
                    //						//1、显示该关键字记录的内容在界面上；
                    //						ShowData(lngMId);
                    //						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
                    //						clsPubFun.SetButtonEnabled(btnOKUpd, true);
                    //						wucUserPrjGrant1.SetKeyReadOnly(true);
                    //						btnOKUpd.Text = "确认修改";
                    //						lblMsg.Text = "";
                    //						break;

                    default:
                        // Do nothing.
                        break;
                }
            }
        }

        private void Btn_Add_Click(object sender, System.EventArgs e)
        {
            BindDg_ViewInfo();
            Table1.Visible = true;
        }
    }
}