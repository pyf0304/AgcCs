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

using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

namespace AGC.Webform
{
	/// <summary>
	/// wfmFuncModule_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmSetModuleTabRela : System.Web.UI.Page
	{

		
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
                //1、为下拉框设置数据源，绑定列表数据
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);

				strSortBy = "FuncModuleAgcId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_FuncModule();
				BindDg_PrjTab4Sel();
				tabPrjTab4Sel.Visible = false;
				tabPrjTab.Visible = false;
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

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtFuncModuleNameq.Text.Trim()!="")
			{
				strWhereCond += " And FuncModuleName='" + this.txtFuncModuleNameq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_FuncModule()
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
			System.Data.DataTable objDT = clsvFuncModule_AgcBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgFuncModule.PageSize);
			if (intPages==0) 
			{
				this.dgFuncModule.CurrentPageIndex = 0;
			}
			else if (this.dgFuncModule.CurrentPageIndex > intPages - 1) 
			{
				this.dgFuncModule.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgFuncModule.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgFuncModule.DataBind();

			
			//当前记录数
			this.lblFuncModuleRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblFuncModuleAllPages.Text = this.dgFuncModule.PageCount.ToString(); 
			//当前页序数
			this.lblFuncModuleCurrentPage.Text=(this.dgFuncModule.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtFuncModuleJump2Page.Text=(this.dgFuncModule.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgFuncModule.CurrentPageIndex==0) 
			{
				btnFuncModulePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnFuncModulePrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgFuncModule.CurrentPageIndex==this.dgFuncModule.PageCount-1) 
			{ 
				btnFuncModuleNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnFuncModuleNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabFuncModuleJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabFuncModuleJumpPage.Visible = false; 
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
			this.dgFuncModule.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_FuncModule();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgFuncModule_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgFuncModule.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_FuncModule();
		}
		protected void dgFuncModule_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
//				System.Web.UI.WebControls.LinkButton myDeleteButton;
//				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
//				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
			int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgFuncModule.Columns.Count;i++)
				{
					strSortEx = this.dgFuncModule.Columns[i].SortExpression;
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

		protected void dgFuncModule_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strFuncModuleId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strFuncModuleId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsFuncModule_AgcBL.DelRecord(strFuncModuleId);
						BindDg_FuncModule();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
	
		
		protected void dgFuncModule_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_FuncModule();
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
			BindDg_FuncModule();
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

		
		protected void btnFuncModulePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgFuncModule.CurrentPageIndex -=1; 
			this.BindDg_FuncModule(); 
		}

		protected void btnFuncModuleNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgFuncModule.CurrentPageIndex +=1; 
			this.BindDg_FuncModule(); 
		}

		protected void btnFuncModuleJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtFuncModuleJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtFuncModuleJump2Page.Text)>0 && 
				int.Parse(this.txtFuncModuleJump2Page.Text)-1<this.dgFuncModule.PageCount) 
			{ 
				this.dgFuncModule.CurrentPageIndex=int.Parse(this.txtFuncModuleJump2Page.Text)-1; 
			} 
			this.BindDg_FuncModule();
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
			string strWhereCond = CombineCondition4PrjTab();
			//	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null; // clsModuleTabRelaEx.GetModuleTabRelaV(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTab.PageSize);
			if (intPages==0) 
			{
				this.dgPrjTab.CurrentPageIndex = 0;
			}
			else if (this.dgPrjTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjTab.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
//			objDV.Sort = strSortBy;
			this.dgPrjTab.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgPrjTab.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount4PrjTab.Text= objDT.Rows.Count.ToString();
		}

		protected void dgFuncModule_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tabFuncModuleDataGrid.Visible = false;
			seFuncModuleAgcId = dgFuncModule.SelectedItem.Cells[0].Text;
			string strFuncModuleName = dgFuncModule.SelectedItem.Cells[1].Text;
			divObjName.InnerText = "<" + strFuncModuleName + ">模块的所有表信息:";
			BindDg_PrjTab();
//			BindDg_FieldTab();
			tabPrjTab.Visible = true;
		}

		protected void lbAddFld_Click(object sender, System.EventArgs e)
		{
			tabPrjTab4Sel.Visible = true;
		}
		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondition4PrjTab()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
			string strWhereCond=" 1=1 and FuncModuleAgcId = '" + seFuncModuleAgcId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			return strWhereCond;
		}
		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondition4PrjTab4Sel()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtTabCnNameq.Text.Trim()!="")
			{
				strWhereCond += " and TabCnName like '" + this.txtTabCnNameq.Text.Trim()+"%'";
			}
			if (this.txtTabNameq.Text.Trim()!="")
			{
				strWhereCond += " and TabName like '" + this.txtTabNameq.Text.Trim()+"%'";
			}
			if (this.ddlObjIdq.SelectedValue!="" && this.ddlObjIdq.SelectedValue!="0")
			{
				strWhereCond += " and ObjId='" + this.ddlObjIdq.SelectedValue+"'";
			}
			return strWhereCond;
		}

		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_PrjTab4Sel()
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
			string strWhereCond = CombineCondition4PrjTab4Sel();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTab4Sel.PageSize);
			if (intPages==0) 
			{
				this.dgPrjTab.CurrentPageIndex = 0;
			}
			else if (this.dgPrjTab4Sel.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjTab4Sel.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			//			objDV.Sort = strSortBy;
			this.dgPrjTab4Sel.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgPrjTab4Sel.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount4Sel.Text= objDT.Rows.Count.ToString();
		}

		protected void btnQuery_PrjTab_Click(object sender, System.EventArgs e)
		{
			//把DATAGRID的当前页索引设置为0，即第1页。
			//当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.dgPrjTab4Sel.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_PrjTab4Sel();
		}

		protected void btnOKAdd_Click(object sender, System.EventArgs e)
		{
			string strWhereCond;
			string strTabId;
			System.Data.DataTable objDT;
			ArrayList objArr=new ArrayList();
			if (chkSelAll.Checked == true)
			{
				//	1、组合界面条件串；
				strWhereCond = CombineCondition4PrjTab4Sel();
				//	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvPrjTabBL.GetDataTable(strWhereCond);
				foreach(DataRow objRow in objDT.Rows)
				{
					strTabId = objRow["TabId"].ToString();
					objArr.Add(strTabId);
				}
			}
			else
			{
				this.Get_PrjTabArrylist(this.dgPrjTab4Sel,objArr);
			}
			this.Add_PrjTabtoModuleTabRela(objArr);
			BindDg_PrjTab();
			tabPrjTab4Sel.Visible = false;
			Response.Write("<script>alert('所选字段添加成功！！')</script>");

		}

		private void Add_PrjTabtoModuleTabRela(ArrayList objArr)
		{

			if(objArr.Count==0)
			{
				return;
			}
            //else
            //{
            //    if (FuncModuleAgcId.Length == 0) 
            //    {
            //        lblMsg.Text = "请选择合适的模块名";
            //        return ;
            //    }
            //    clsModuleTabRela objModuleTabRela;
            //    foreach(string strTabId in objArr)
            //    {
            //        objModuleTabRela=new clsModuleTabRela();
            //        //					objFldObjTab.TabId=this.TabId;
            //        objModuleTabRela.TabId=strTabId;
            //        objModuleTabRela.FuncModuleAgcId=FuncModuleAgcId;
            //        ///3.1、判断是否有相同的字段存在。					
            //        if (clsModuleTabRelaEx.IsExistSameTabId(FuncModuleAgcId, strTabId))	//判断是否有相同的关键字
            //        {
            //        }
            //        else
            //        {
            //            objModuleTabRela.AddNewRecord();
            //        }
            //    }
            //}
		}

		private void Get_PrjTabArrylist(DataGrid objDg, ArrayList objArr)
		{
			if(objArr==null || objDg.Items.Count==0)
			{
				return;
			}
			else 
			{
				objArr.Clear();
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");
					if(cb!=null && cb.Checked)
					{
						objArr.Add(di.Cells[1].Text);
					}
				}
			}
		}

		protected void dgPrjTab_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
                       
						BindDg_PrjTab();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.

					default:
						// Do nothing.
						break;
				}
			}

		}

		protected void lbDispObjList_Click(object sender, System.EventArgs e)
		{
			tabFuncModuleDataGrid.Visible = true;
		}

		protected void chkSelAll_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Set_DataGridAllChecked(this.dgPrjTab4Sel,this.chkSelAll);		
		}

		private void Set_DataGridAllChecked(DataGrid objDg,CheckBox objCkb)
		{
			if(objCkb==null || objDg.Items.Count==0 )
			{
				return;
			}
			else 
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("ckb1");
					if(cb!=null )
					{
						cb.Checked=objCkb.Checked;
					}
				}
			}
		}

		protected void dgPrjTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgPrjTab.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_PrjTab();

		}

		protected void dgPrjTab4Sel_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgPrjTab4Sel.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_PrjTab4Sel();
		}


	}
}