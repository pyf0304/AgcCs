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
using com.taishsoft.commdb;
using CommFunc4WebForm;


using System.Collections.Generic;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.common;

namespace AGC
{
	/// <summary>
	/// wfmSysLog_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmSysLog_QD_AllUser : CommWebPageBase
    {

		
		//生成有关的变量定义代码
		private const string ViewId4Potence="00260203";		//界面编号


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
				clsOperationTypeBLEx.BindDdl_OpTypeId(ddlOpTypeIdq);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
				strSortSysLogBy = "mId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_SysLog();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				///   
				HideAdvanceQuery();
			}
		}

		//生成权限等级的属性
		private string  strPotenceLevel
		{
			get
			{
				string sPotenceLevel;
				sPotenceLevel = (string)ViewState["PotenceLevel"];
				if (sPotenceLevel==null) 
				{
					//					sPotenceLevel=new TzGeneralPlatformDll.MenuAndPotence(clsSysParaEN.ConfigFileName).Get_PotenceLevel(ViewId4Potence);
					sPotenceLevel = "9";
					ViewState.Add("PotenceLevel", sPotenceLevel);
				}
				return sPotenceLevel;
			}
		}


		
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
		///private clsUsersEN objUserBak
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
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineSysLogCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 and PrjId in (Select PrjId from   UserPrjGrant where UserId = '" + UserId + "') " ;
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtUserIdq.Text.Trim()!="")
			{
				strWhereCond += " And UserId like '%" + this.txtUserIdq.Text.Trim()+"%'";
			}
			if (this.txtUserNameq.Text.Trim()!="")
			{
				strWhereCond += " And UserName like '%" + this.txtUserNameq.Text.Trim()+"%'";
			}
			if (this.txtUserIpq.Text.Trim()!="")
			{
				strWhereCond += " And UserIp like '%" + this.txtUserIpq.Text.Trim()+"%'";
			}
			if (this.txtOpDateq.Text.Trim()!="")
			{
				strWhereCond += " And OperationDate like '%" + this.txtOpDateq.Text.Trim()+"%'";
			}
			if (this.txtOpTimeq.Text.Trim()!="")
			{
				strWhereCond += " And OperationTime like '%" + this.txtOpTimeq.Text.Trim()+"%'";
			}
			if (this.ddlOpTypeIdq.SelectedValue!="" && this.ddlOpTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And OpTypeId='" + this.ddlOpTypeIdq.SelectedValue+"'";
			}
			if (this.txtTableNameq.Text.Trim()!="")
			{
				strWhereCond += " And TableName like '%" + this.txtTableNameq.Text.Trim()+"%'";
			}
			if (this.txtTableKeyq.Text.Trim()!="")
			{
				strWhereCond += " And TableKey like '%" + this.txtTableKeyq.Text.Trim()+"%'";
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
		private void BindDg_SysLog()
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
			string strWhereCond = CombineSysLogCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvSysLogBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgSysLog.PageSize);
			if (intPages==0) 
			{
				this.dgSysLog.CurrentPageIndex = 0;
			}
			else if (this.dgSysLog.CurrentPageIndex > intPages - 1) 
			{
				this.dgSysLog.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortSysLogBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgSysLog.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgSysLog.DataBind();

			
			//当前记录数
			this.lblSysLogRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblSysLogAllPages.Text = this.dgSysLog.PageCount.ToString(); 
			//当前页序数
			this.lblSysLogCurrentPage.Text=(this.dgSysLog.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtSysLogJump2Page.Text=(this.dgSysLog.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgSysLog.CurrentPageIndex==0) 
			{
				btnSysLogPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnSysLogPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgSysLog.CurrentPageIndex==this.dgSysLog.PageCount-1) 
			{ 
				btnSysLogNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnSysLogNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabSysLogJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabSysLogJumpPage.Visible = false; 
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
			this.dgSysLog.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_SysLog();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgSysLog_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgSysLog.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_SysLog();
		}
		protected void dgSysLog_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortSysLogBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgSysLog.Columns.Count;i++)
				{
					strSortEx = this.dgSysLog.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortSysLogBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortSysLogBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgSysLog_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngmId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngmId = long.Parse(e.Item.Cells[0].Text);
				switch(strCommandName)
				{
					case "Delete":
						clsSysLogBL.DelRecord(lngmId);
						BindDg_SysLog();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.

					default:
						// Do nothing.
						break;
				}
			}
			if (e.Item.ItemType == ListItemType.Header)
			{
				System.Web.UI.WebControls.LinkButton lbSelAll;
				lbSelAll = (LinkButton)e.CommandSource;
				if (lbSelAll.CommandName != "lbSelAll")
				{
					return ;
				}
				if (lbSelAll.Text == "全选")
				{
					Set_DataGridAllChecked(dgSysLog, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgSysLog, false);
					lbSelAll.Text = "全选";
				}
			}		
		}
		private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
		{
			if(objDg.Items.Count==0 )
			{
				return;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("chkCheckRec");
					if(cb!=null )
					{
						cb.Checked=IsSelected;
					}
				}
			}
		}

		
		protected void dgSysLog_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortSysLogBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortSysLogBy = e.SortExpression + " Asc";
				BindDg_SysLog();
				return ;
			}
			//检查原来是升序
			intIndex = strSortSysLogBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortSysLogBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortSysLogBy = e.SortExpression + " Desc";
			}
			BindDg_SysLog();
		}

		private string strSortSysLogBy
		{
			get
			{
				string sSortSysLogBy;
				sSortSysLogBy = (string)ViewState["SortSysLogBy"];
				if (sSortSysLogBy==null) 
				{
					sSortSysLogBy = "";
				}
				return sSortSysLogBy;
			}
			set
			{
				string sSortSysLogBy = value;
				ViewState.Add("SortSysLogBy", sSortSysLogBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnSysLogPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgSysLog.CurrentPageIndex -=1; 
			this.BindDg_SysLog(); 
		}

		protected void btnSysLogNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgSysLog.CurrentPageIndex +=1; 
			this.BindDg_SysLog(); 
		}

		protected void btnSysLogJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtSysLogJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtSysLogJump2Page.Text)>0 && 
				int.Parse(this.txtSysLogJump2Page.Text)-1<this.dgSysLog.PageCount) 
			{ 
				this.dgSysLog.CurrentPageIndex=int.Parse(this.txtSysLogJump2Page.Text)-1; 
			} 
			this.BindDg_SysLog();
		}

		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
			this.lblMsg.Text="";
            List<string> arrPicId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgSysLog, "chkCheckRec");
			if (arrPicId == null || arrPicId.Count == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			//			lblMsg.Text = "";
			clsSysLogBL.DelSysLogs(arrPicId);
			BindDg_SysLog();

		}

		protected void lbAdvanceQuery_Click(object sender, System.EventArgs e)
		{
			DispAdvanceQuery();
		}
		private void DispAdvanceQuery()
		{
			divOperateInfo.Visible = true;
			divPrjTabInfo.Visible = true;
		}
		private void HideAdvanceQuery()
		{
			divOperateInfo.Visible = false;
			divPrjTabInfo.Visible = false;
		}

		protected void Linkbutton1_Click(object sender, System.EventArgs e)
		{
			HideAdvanceQuery();
		}

		protected void lbHideAdvanceQuery_Click(object sender, System.EventArgs e)
		{
			HideAdvanceQuery();
		}

        protected void btnSysLogNextPage_Click1(object sender, EventArgs e)
        {

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
    }
}