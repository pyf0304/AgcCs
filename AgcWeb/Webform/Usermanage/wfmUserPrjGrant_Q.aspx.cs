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
	public partial class wfmUserPrjGrant_Q : CommWebPageBase
    {

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				// 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
				//wucStudent1.SetDdl_College();
				//1、为下拉框设置数据源，绑定列表数据
                clsUserRolesBL.BindDdl_RoleId(ddlRoleIdq);
                clsUserRolesBL.BindDdl_RoleId(ddlRoleId_New);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
				//2、显示无条件的表内容在DATAGRID中
				//				string strSortBy = " Asc";
				strSortUserPrjGrantBy = "UserName Asc";

				BindDg_UserPrjGrant();
			}
		}

		/// <summary>
		/// 专门用于存储当前界面中的私有变量，用户ID
		/// 利用属性过程和SESSION来存储界面中的私有变量，
		///		这是一个技巧，也是本公司的编程规划和方法，这时属性过程的第一个字母均用“p”
		/// </summary>
		private string UserId
		{
			get
			{
				string strUserId;
				strUserId = (string)Session["UserId"];
				if (strUserId==null) 
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
				if (pobjUser==null) 
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
				strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim()+"'";
			}
			if (this.txtUserNameq.Text.Trim()!="")
			{
				strWhereCond += " and UserName='" + this.txtUserNameq.Text.Trim()+"'";
			}
			if (this.ddlRoleIdq.SelectedValue!="" && this.ddlRoleIdq.SelectedValue!="0")
			{
				strWhereCond += " and RoleId='" + this.ddlRoleIdq.SelectedValue+"'";
			}
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}

			return strWhereCond;
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
			string strWhereCond = CombineCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
//			string strWhereCond = " 1=1 vUserPrjGrant.UserId='" + UserId +"'";
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
			objDV.Sort = strSortUserPrjGrantBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用

			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUserPrjGrant.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount1.Text= objDT.Rows.Count.ToString();
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
			this.dgUserPrjGrant.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_UserPrjGrant();
		}
	
		
		public System.Data.DataTable GetDepartmentId()
		{
			//获取某学院所有专业信息
			string strSQL = "select DepartmentId, DepartmentName from Departments ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetDepartmentId();
			objDDL.DataValueField="DepartmentId";
			objDDL.DataTextField="DepartmentName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
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
			int intIndex;
			if (strSortUserPrjGrantBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgUserPrjGrant.Columns.Count;i++)
				{
					strSortEx = this.dgUserPrjGrant.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortUserPrjGrantBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortUserPrjGrantBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
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

		protected void dgUserPrjGrant_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortUserPrjGrantBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortUserPrjGrantBy = e.SortExpression + " Asc";
				BindDg_UserPrjGrant();
				return ;
			}
			//检查原来是升序
			intIndex = strSortUserPrjGrantBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortUserPrjGrantBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortUserPrjGrantBy = e.SortExpression + " Desc";
			}
			BindDg_UserPrjGrant();

		}
		
		private string strSortUserPrjGrantBy
		{
			get
			{
				string sstrSortUserPrjGrantBy;
				sstrSortUserPrjGrantBy = (string)ViewState["strSortUserPrjGrantBy"];
				if (sstrSortUserPrjGrantBy==null) 
				{
					sstrSortUserPrjGrantBy = "";
				}
				return sstrSortUserPrjGrantBy;
			}
			set
			{
				string sstrSortUserPrjGrantBy = value;
				ViewState.Add("strSortUserPrjGrantBy", sstrSortUserPrjGrantBy);
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


