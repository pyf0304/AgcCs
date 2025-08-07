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



using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmUsers_Q 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmUserPrjGrant : CommWebPageBase
    {
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
                // 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
                //wucStudent1.SetDdl_College();
                //1、为下拉框设置数据源，绑定列表数据
                clsDepartmentInfoBL.BindDdl_DepartmentIdCache(ddlDepartmentIdq);
                BindDdl_UserStateId(ddlUserStateIdq);
                clsUserRolesBL.BindDdl_RoleId(ddlRoleIdq);
                clsUserRolesBL.BindDdl_RoleId(ddlRoleId_New);
                //2、显示无条件的表内容在DATAGRID中
                //				string strSortBy = " Asc";
                BindDg_Users();
                tabProjects.Visible = false;
                tabUserPrj.Visible = false;

                BindDg_Projects();
                clsUserRolesBL.BindDdl_RoleId(ddlRoleId_e);
			}
		}
		

        //private clsUsersEN objUserBak
        //{
        //    get
        //    {
        //        clsUsersEN pobjUser;
        //        pobjUser = (clsUsersEN)Session["objUser"];
        //        if (pobjUser==null) 
        //        {
        //            pobjUser = null;
        //        }
        //        return pobjUser;
        //    }
        //    set
        //    {
        //        clsUsersEN pobjUser = value;
        //        Session.Add("objUser", pobjUser);
        //    }
        //}
		
		private string BackErrPageLinkStr
		{
			get
			{
				string strBackErrPageLinkStr;
				strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
				if (strBackErrPageLinkStr==null) 
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
				if (strErrMessage==null) 
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

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtUserIdq.Text.Trim()!="")
			{
				strWhereCond += " and UserId like '%" + this.txtUserIdq.Text.Trim()+"%'";
			}
			if (this.txtUserNameq.Text.Trim()!="")
			{
				strWhereCond += " and UserName like '%" + this.txtUserNameq.Text.Trim()+"%'";
			}
			if (this.ddlDepartmentIdq.SelectedValue!="" && this.ddlDepartmentIdq.SelectedValue!="0")
			{
				strWhereCond += " and DepartmentId='" + this.ddlDepartmentIdq.SelectedValue+"'";
			}
			if (this.ddlUserStateIdq.SelectedValue!="" && this.ddlUserStateIdq.SelectedValue!="0")
			{
				strWhereCond += " and UserStateId='" + this.ddlUserStateIdq.SelectedValue+"'";
			}
			if (this.ddlRoleIdq.SelectedValue!="" && this.ddlRoleIdq.SelectedValue!="0")
			{
				strWhereCond += " and RoleId='" + this.ddlRoleIdq.SelectedValue+"'";
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
			if (intPages==0) 
			{
				this.dgUsers.CurrentPageIndex = 0;
			}
			else if (this.dgUsers.CurrentPageIndex > intPages - 1) 
			{
				this.dgUsers.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			this.dgUsers.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUsers.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
		}

		private void BindDg_UserPrjGrant()
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
            string strWhereCond = "vUserPrjGrant.UserId='" + vsUserId + "'";
			//System.Data.DataTable objDT = clsUserPrjGrantBL.GetUserPrjGrantT(strWhereCond);
			System.Data.DataTable objDT = clsvUserPrjGrantBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgUserPrjGrant.PageSize);
			if (intPages==0) 
			{
				this.dgUserPrjGrant.CurrentPageIndex = 0;
			}
			else if (this.dgUserPrjGrant.CurrentPageIndex > intPages - 1) 
			{
				this.dgUserPrjGrant.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			this.dgUserPrjGrant.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUserPrjGrant.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount1.Text= objDT.Rows.Count.ToString();
		}


		private void BindDg_Projects()
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
            string strWhereCond = string.Format(" 1=1 And UseStateId='0001' And PrjId not in (Select PrjId From UserPrjGrant where UserId='{0}')", vsUserId);//CombineCondition();
			if (string.IsNullOrEmpty( txtPrjName.Text) == false)
            {
                strWhereCond += string.Format(" And {0} like '%{1}%'", conProjects.PrjName, txtPrjName.Text);
            }
            //	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsProjectsBL.GetDataTable_Projects(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgProjects.PageSize);
			if (intPages==0) 
			{
				this.dgProjects.CurrentPageIndex = 0;
			}
			else if (this.dgProjects.CurrentPageIndex > intPages - 1) 
			{
				this.dgProjects.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			this.dgProjects.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgProjects.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount2.Text= objDT.Rows.Count.ToString();
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
			if (intRecCount % intPageSize !=0) intPages ++;
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
			this.dgUsers.CurrentPageIndex=0;
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
			this.dgUsers.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_Users();
		}
		
		
		public System.Data.DataTable GetUserStateId()
		{
			//获取某学院所有专业信息
			string strSQL = "select UserStateId, UserStateName from UserState ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetUserStateId();
			objDDL.DataValueField="UserStateId";
			objDDL.DataTextField="UserStateName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		

		protected void dgUsers_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
		
		}

		protected void dgUsers_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			//						long lngMId;
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
				switch(strCommandName)
				{
					case "Select":
						vsUserId = strUserId;
						BindDg_UserPrjGrant();
                        BindDg_Projects();
						tabUsers.Visible = false;
						tabUserPrj.Visible = true;
						lblUserName.Text = "用户：" + clsUsersBL.GetObjByUserId(strUserId).UserName + " 授权的工程如下：";
						break;
					default:
						// Do nothing.
						break;
				}
			}
			//		
		}

		protected void dgUserPrjGrant_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
		
		}

		protected void dgUserPrjGrant_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
				switch(strCommandName)
				{
					case "Delete":
						clsUserPrjGrantBL.DelRecord(lngMId);
						BindDg_UserPrjGrant();
						break;
					case "Update":	//为用户设置新的角色
						SetNewRoleForUser(lngMId);
						break;

					default:
						// Do nothing.
						break;
				}
			}
		
		}
		private void SetNewRoleForUser(long lngMId)
		{
			string strNewRoleId = ddlRoleId_New.SelectedValue;
			if (strNewRoleId == "")
			{
				lblMsg2.Text = "新角色不能为空!";
			}
lblMsg2.Text = "";
//获取当前用户ID、当前工程ID
			try
			{
				clsUserPrjGrantEN objUserPrjGrant = clsUserPrjGrantBL.GetObjBymId(lngMId);
				objUserPrjGrant.RoleId = strNewRoleId;
                clsUserPrjGrantBL .UpdateBySql2(objUserPrjGrant);
				BindDg_UserPrjGrant();

			}
			catch(Exception objException)
			{
				if (objException.Message.Length<30)
				{
					lblMsg2.Text = objException.Message;
				}
				else
				{
					clsCommonSession.seErrMessage = objException.Message;
					clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
					clsPubFun4Web.AccessError(this, conCurrPageName);				
				}
			}
		}
		protected void dgUserPrjGrant_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgUserPrjGrant.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_UserPrjGrant();
		}
		
		private void Get_ObjectPrjArrylist(DataGrid objDg, ArrayList objArr)
		{
			if(objArr==null || objDg.Items.Count==0)
			{
				return;//判断DataGrid的记录是否为空或者队列的记录为空？
			}
			else 
			{
				objArr.Clear();//清空队列
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");//定义一个CheckBox将其等价于
					if(cb!=null && cb.Checked)					//DataGrid中的CheckBox
					{
						objArr.Add(di.Cells[1].Text);//将打勾的CheckBox所在记录的关键字放入队列
						cb.Checked = false;			//将CheckBox还原
					}
				}
		
			}
		
		}

		private void Add_ObjectPrjtoUserPrjGrant(ArrayList objArr)
		{
			if(objArr.Count==0)
			{
				return;
			}
			else
			{
				clsUserPrjGrantEN objUserPrjGrant;
				foreach(string PrjID in objArr)
				{
                    string strCondition = " UserPrjGrant.UserId='" + vsUserId + "'";
					strCondition += " and UserPrjGrant.PrjId='" + PrjID+"'";
					clsUserPrjGrantEN objUserPrjGrant1 = new clsUserPrjGrantEN();
                    if (!clsUserPrjGrantBL.IsExistRecord(strCondition))
                    {
						objUserPrjGrant=new clsUserPrjGrantEN();
						objUserPrjGrant.PrjId =PrjID;
                        objUserPrjGrant.UserId = vsUserId;
						objUserPrjGrant.RoleId= ddlRoleId_e.SelectedValue;
						//					objTabFld.TabId=this.TabId;
						//					objTabFld.FldId=FldId;
						//					objTabFld.IsPrimary=false;
						//					objTabFld.PrimaryTypeId="00";
						//objUserPrjGrant.MId = 0;
						objUserPrjGrant.mId = 0;
                        clsUserPrjGrantBL .AddNewRecordBySql2(objUserPrjGrant);
						//					objTabFld.AddNewRecord();
					}
				}
			}
			BindDg_UserPrjGrant();
		
		
		}

        protected void Btn_AddPrj_Click(object sender, System.EventArgs e)
		{
			string strProjectsId =GetFirstCheckedItemFromDg(this.dgProjects);
			if (strProjectsId == null || strProjectsId.Trim().Length == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			if(ddlRoleId_e.SelectedValue=="0")
			{  
				lblMsg1.Text= "没有选择用户角色,请选择用户角色!";
				return;
			}
			lblMsg1.Text="";
			ArrayList objArr=new ArrayList();//创建一个队列
			this.Get_ObjectPrjArrylist(this.dgProjects,objArr);//将获取的每个对象加入到队列中
			this.Add_ObjectPrjtoUserPrjGrant(objArr);//将队列的值（与其他值一起）放入数据库表中
            BindDg_UserPrjGrant();//重新绑定DataGrid
            BindDg_Projects();//重新绑定DataGrid

			Response.Write("<script>alert('所选字段添加成功！！')</script>");
		}

		protected void dgProjects_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgProjects.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_Projects();
		}

		protected void dgProjects_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		protected void Btn_AddNewPrj_Click(object sender, System.EventArgs e)
		{
			tabProjects.Visible = true;
		}

		protected void lbDispUserList_Click(object sender, System.EventArgs e)
		{
			tabUsers.Visible = true;
			tabUserPrj.Visible = false;
			tabProjects.Visible = false;
		}

		private string GetFirstCheckedItemFromDg(DataGrid objDg)
		{
			if(objDg.Items.Count==0)
			{
				return null;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox chkCheckRec=(CheckBox)di.FindControl("ckb1");
					if(chkCheckRec!=null && chkCheckRec.Checked)
					{
						return di.Cells[1].Text;
					}
				}
			}
			return "";
		}

        protected void btnQueryPrj_Click(object sender, EventArgs e)
        {
            BindDg_Projects();
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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


