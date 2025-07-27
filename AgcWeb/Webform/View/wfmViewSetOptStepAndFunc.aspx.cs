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


using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmViewSetOptStepAndFunc : System.Web.UI.Page
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
			js += "</"+"script>\r\r\n";
            ClientScript.RegisterStartupScript(this.GetType(), "js", js);
//            this.RegisterStartupScript("js", js); 
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				///隐藏应该隐藏的控件内容
				///
				tabHidden.Visible = false;
                //if (clsCommForWebForm.SystemStatus=="DEBUG")
                //{
                //    PrjId = "0005";
                //    txtUserIdq.Text = "pyf";
                //    clsUsersEN objUsers = new clsUsersEN("pyf", true);
                //    objUser = objUsers;
                //}
				//1、为下拉框设置数据源，绑定列表数据
//				wucViewInfo1.SetDdl_ViewTypeCode();
                //				wucViewInfo1.SetDdl_FuncModuleId(clsPubVar.CurrSelPrjId);
                //				wucViewInfo1.SetDdl_MainTabId(clsPubVar.CurrSelPrjId);
                //				wucViewInfo1.SetDdl_DetailTabId(clsPubVar.CurrSelPrjId);
//				wucViewInfo1.SetDdl_PrjId();

                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

				BindDdl_ViewTypeCode(ddlViewTypeCodeq);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);

				//恢复上一次在此界面的状态
				if (seFuncModuleAgcId != "")
				{
					clsDropDownList.SetDdlValue(ddlFuncModuleIdq, seFuncModuleAgcId);
				}
				if (ViewTypeCode !="")
				{
					clsDropDownList.SetDdlValue(ddlViewTypeCodeq, ViewTypeCode);
				}
				txtViewNameq.Text = ViewName;
				//===============================

				strSortBy = "ViewName Asc";
				///设置当前登录用户的默认工程
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
				//2、显示无条件的表内容在DATAGRID中
				BindDg_ViewInfo();
				//3、设置表控件中字控件的ReadOnly属性，
			}
		}

		private string seFuncModuleAgcId
		{
			get
			{
				string strFuncModuleId;
				strFuncModuleId = (string)Session["FuncModuleAgcId4Qry"];
				if (strFuncModuleId==null) 
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
				if (intViewTypeCode==null) 
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
				if (strViewName==null) 
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
			if (this.txtViewNameq.Text.Trim()!="")
			{
				strWhereCond += " and ViewName like '" + this.txtViewNameq.Text.Trim()+"%'";
			}
			if (this.ddlViewTypeCodeq.SelectedValue!="" && this.ddlViewTypeCodeq.SelectedValue!="0")
			{
				strWhereCond += " and ViewTypeCode like '" + this.ddlViewTypeCodeq.SelectedValue+"%'";
			}
			if (this.ddlFuncModuleIdq.SelectedValue!="" && this.ddlFuncModuleIdq.SelectedValue!="0")
			{
				strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleIdq.SelectedValue+"'";
			}

			if (this.txtMainTabNameq.Text.Trim()!="")
			{
				strWhereCond += " and MainTabName like '" + this.txtMainTabNameq.Text.Trim()+"%'";
			}
			if (this.txtDetailTabNameq.Text.Trim()!="")
			{
				strWhereCond += " and DetailTabName like '" + this.txtDetailTabNameq.Text.Trim()+"%'";
			}
//			if (this.chkIsNeedSort_q._Checked==true)
//				strWhereCond += " and ViewInfo.IsNeedSort='1'";
//			else
//				strWhereCond += " and ViewInfo.IsNeedSort='0'";
//			if (this.chkIsNeedTransCode_q._Checked==true)
//				strWhereCond += " and ViewInfo.IsNeedTransCode='1'";
//			else
//				strWhereCond += " and ViewInfo.IsNeedTransCode='0'";
			if (this.txtUserIdq.Text.Trim()!="")
			{
				strWhereCond += " and UserId='" + this.txtUserIdq.Text.Trim()+"'";
			}
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
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
			if (intPages==0) 
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
			this.dgViewInfo.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewInfo.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
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
			this.dgViewInfo.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_ViewInfo();
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
		protected void dgViewInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgViewInfo.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ViewInfo();
		}
		
		
		public System.Data.DataTable GetViewTypeCode()
		{
			//获取某学院所有专业信息
			string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetViewTypeCode();
			objDDL.DataValueField="ViewTypeCode";
			objDDL.DataTextField="ViewTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}


		protected void dgViewInfo_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
//			System.Web.UI.WebControls.CheckBox chkIsSort, chkIsTransCode;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 11;
				iNum[1] = 12;
				for (int i = 0; i<2; i++)
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
			}
		}
		

		/// <summary>
		/// 功能：为界面添加操作流程
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnViewOptStep_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewOptSteps_QUDI.aspx");
		}	
		
		/// <summary>
		/// 功能：编辑界面的相关表
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnEditRelaTab_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewRelaTab_QUDI.aspx");
		}

		/// <summary>
		/// 功能：编辑界面的按钮操作步骤；
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnBtnOptStep_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewBtnOptSteps_QUDI.aspx");
		}
		/// <summary>
		/// 功能：编辑界面的字段信息，为界面添加、删除等维护字段信息。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnEditViewField_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewAddField.aspx");
		}
		/// <summary>
		/// 功能：本函数仅仅设置界面的字段信息，不添加、删除字段信息。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnSetViewFld_Click(object sender, System.EventArgs e)
		{
			string strViewId =(string) rd.Value;
			if (strViewId.Trim().Length == 0) 
			{
				lblMsg2.Text = "没有选择记录，请选择一个有效的界面记录!";
				return ;
			}
			lblMsg2.Text = "";
			Session.Add("ViewId",strViewId);
			Response.Redirect("wfmViewSetField.aspx");
		
		}

		protected void lbDispViewList_Click(object sender, System.EventArgs e)
		{
			tabQuery1.Visible = true;
            //tabLayout.Visible = false;
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
				return ;
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

		protected void dgViewInfo_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgViewInfo.Columns.Count;i++)
				{
					strSortEx = this.dgViewInfo.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}
	
		private string strSortBy
		{
			get
			{
				string sSortBy;
				sSortBy = (string)ViewState["SortBy"];
				if (sSortBy==null) 
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

	}
}