using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.common;
using CommFunc4WebForm;
///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AGC.Webform
{
    /// <summary>
    /// wfmViewTypeCodeTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmViewTypeCodeTab_QUDI : CommWebPageBase
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
				wucViewTypeCodeTab1.SetDdl_ApplicationTypeId();
                
                clsViewInfoBLEx.BindDdl_ApplicationTypeIdExCache(ddlApplicationTypeIdq, clsPubVar.CurrSelPrjId);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsWebq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsWinq);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlIsMobileAppq);
                strSortViewTypeCodeTabBy = "ViewTypeCode Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_ViewTypeCodeTab();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucViewTypeCodeTab1.SetKeyReadOnly(true);
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
					//					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
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


		


		//生成错误信息的Session属性
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


		//生成返回链接串的Session属性
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

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineViewTypeCodeTabCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond= string.Format(" 1=1 and {0} in (Select {0} From {1} where {2}='1')", 
                conApplicationType.ApplicationTypeId, conApplicationType._CurrTabName, conApplicationType.IsVisible);
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtViewTypeCodeq.Text.Trim()!="")
			{
				strWhereCond += " And ViewTypeCode like '%" + this.txtViewTypeCodeq.Text.Trim()+"%'";
			}
			if (this.txtViewTypeNameq.Text.Trim()!="")
			{
				strWhereCond += " And ViewTypeName like '%" + this.txtViewTypeNameq.Text.Trim()+"%'";
			}
			if (this.ddlApplicationTypeIdq.SelectedValue!="" && this.ddlApplicationTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And ApplicationTypeId='" + this.ddlApplicationTypeIdq.SelectedValue+"'";
			}
            if (this.ddlIsWebq.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWebApp);
            }
            else if (this.ddlIsWebq.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWebApp);
            }
            if (this.ddlIsWinq.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWinApp);
            }
            else if (this.ddlIsWinq.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWinApp);
            }
            if (this.ddlIsMobileAppq.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsMobileApp);
            }
            else if (this.ddlIsMobileAppq.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsMobileApp);
            }

            return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_ViewTypeCodeTab()
		{
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //	4、设置DATAGRID的数据源(DataSource)；
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            //clsCommForWebForm.SetGvVisibility(dgViewTypeCodeTab, strColumnName, bolIsVisible);
            //	1、组合界面条件串；
            string strWhereCond = CombineViewTypeCodeTabCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvViewTypeCodeTabBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewTypeCodeTab.PageSize);
			if (intPages==0) 
			{
				this.dgViewTypeCodeTab.CurrentPageIndex = 0;
			}
			else if (this.dgViewTypeCodeTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewTypeCodeTab.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewTypeCodeTabBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgViewTypeCodeTab.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewTypeCodeTab.DataBind();

			
			//当前记录数
			this.lblViewTypeCodeTabRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblViewTypeCodeTabAllPages.Text = this.dgViewTypeCodeTab.PageCount.ToString(); 
			//当前页序数
			this.lblViewTypeCodeTabCurrentPage.Text=(this.dgViewTypeCodeTab.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtViewTypeCodeTabJump2Page.Text=(this.dgViewTypeCodeTab.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgViewTypeCodeTab.CurrentPageIndex==0) 
			{
				btnViewTypeCodeTabPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnViewTypeCodeTabPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgViewTypeCodeTab.CurrentPageIndex==this.dgViewTypeCodeTab.PageCount-1) 
			{ 
				btnViewTypeCodeTabNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnViewTypeCodeTabNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabViewTypeCodeTabJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabViewTypeCodeTabJumpPage.Visible = false; 
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
			this.dgViewTypeCodeTab.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_ViewTypeCodeTab();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewTypeCodeTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgViewTypeCodeTab.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ViewTypeCodeTab();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="intViewTypeCode">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(int intViewTypeCode)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (intViewTypeCode == 0) return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsViewTypeCodeTabBL.IsExist(intViewTypeCode) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + intViewTypeCode + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsViewTypeCodeTabEN objViewTypeCodeTab = new clsViewTypeCodeTabEN(intViewTypeCode);
            //4、获取类对象的所有属性；
            clsViewTypeCodeTabBL .GetViewTypeCodeTab(ref objViewTypeCodeTab);
			Session.Add("objViewTypeCodeTab", objViewTypeCodeTab);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromViewTypeCodeTabClass(objViewTypeCodeTab);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjViewTypeCodeTab">表实体类对象</param>
		private void GetDataFromViewTypeCodeTabClass(clsViewTypeCodeTabEN pobjViewTypeCodeTab)
		{
			wucViewTypeCodeTab1.ViewTypeCode = pobjViewTypeCodeTab.ViewTypeCode;
			wucViewTypeCodeTab1.ViewTypeName = pobjViewTypeCodeTab.ViewTypeName;
			wucViewTypeCodeTab1.ViewFunction = pobjViewTypeCodeTab.ViewFunction;
			wucViewTypeCodeTab1.OptProcess = pobjViewTypeCodeTab.OptProcess;
			wucViewTypeCodeTab1.ViewDetail = pobjViewTypeCodeTab.ViewDetail;
			wucViewTypeCodeTab1.ApplicationTypeId = pobjViewTypeCodeTab.ApplicationTypeId;
            wucViewTypeCodeTab1.IsHaveAdd = pobjViewTypeCodeTab.IsHaveAdd;
            wucViewTypeCodeTab1.IsHaveUpdate = pobjViewTypeCodeTab.IsHaveUpdate;
            wucViewTypeCodeTab1.IsHaveExeAdd = pobjViewTypeCodeTab.IsHaveExeAdd;
            wucViewTypeCodeTab1.IsHaveExeUpdate = pobjViewTypeCodeTab.IsHaveExeUpdate;
            wucViewTypeCodeTab1.IsHaveDel = pobjViewTypeCodeTab.IsHaveDel;
			wucViewTypeCodeTab1.IsHaveQuery = pobjViewTypeCodeTab.IsHaveQuery;
            wucViewTypeCodeTab1.IsHaveExcelExport = pobjViewTypeCodeTab.IsHaveExcelExport;
            wucViewTypeCodeTab1.IsHaveSetExportExcel = pobjViewTypeCodeTab.IsHaveSetExportExcel;

            wucViewTypeCodeTab1.IsHaveDetail = pobjViewTypeCodeTab.IsHaveDetail;
            wucViewTypeCodeTab1.IsHaveMainView = pobjViewTypeCodeTab.IsHaveMainView;
            wucViewTypeCodeTab1.IsHaveSubView = pobjViewTypeCodeTab.IsHaveSubView;
            wucViewTypeCodeTab1.IsWebApp = pobjViewTypeCodeTab.IsWebApp;// 是否Web应用
            wucViewTypeCodeTab1.IsWinApp = pobjViewTypeCodeTab.IsWinApp;// 是否Win应用
            wucViewTypeCodeTab1.IsMobileApp = pobjViewTypeCodeTab.IsMobileApp;// 是否移动终端应用

        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
//			string strMsg;	//专门用于传递信息的变量
//			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			string strCommandText;
			clsViewTypeCodeTabEN objViewTypeCodeTab;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					AddViewTypeCodeTabRecord();
					break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					AddViewTypeCodeTabRecordSave();
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					objViewTypeCodeTab = (clsViewTypeCodeTabEN) Session["objViewTypeCodeTab"];
					UpdateViewTypeCodeTabRecordSave(objViewTypeCodeTab);
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjViewTypeCodeTab">数据传输的目的类对象</param>
		private void PutDataToViewTypeCodeTabClass(clsViewTypeCodeTabEN pobjViewTypeCodeTab)
		{
			pobjViewTypeCodeTab.ViewTypeCode = wucViewTypeCodeTab1.ViewTypeCode;
			pobjViewTypeCodeTab.ViewTypeName = wucViewTypeCodeTab1.ViewTypeName;
			pobjViewTypeCodeTab.ViewFunction = wucViewTypeCodeTab1.ViewFunction;
			pobjViewTypeCodeTab.OptProcess = wucViewTypeCodeTab1.OptProcess;
			pobjViewTypeCodeTab.ViewDetail = wucViewTypeCodeTab1.ViewDetail;
			pobjViewTypeCodeTab.ApplicationTypeId = wucViewTypeCodeTab1.ApplicationTypeId;
            pobjViewTypeCodeTab.IsHaveAdd = wucViewTypeCodeTab1.IsHaveAdd;
            pobjViewTypeCodeTab.IsHaveUpdate = wucViewTypeCodeTab1.IsHaveUpdate;
            pobjViewTypeCodeTab.IsHaveExeAdd = wucViewTypeCodeTab1.IsHaveExeAdd;
            pobjViewTypeCodeTab.IsHaveExeUpdate = wucViewTypeCodeTab1.IsHaveExeUpdate;
            pobjViewTypeCodeTab.IsHaveDel = wucViewTypeCodeTab1.IsHaveDel;
			pobjViewTypeCodeTab.IsHaveQuery = wucViewTypeCodeTab1.IsHaveQuery;
            pobjViewTypeCodeTab.IsHaveExcelExport = wucViewTypeCodeTab1.IsHaveExcelExport;
            pobjViewTypeCodeTab.IsHaveSetExportExcel = wucViewTypeCodeTab1.IsHaveSetExportExcel;

			pobjViewTypeCodeTab.IsHaveDetail = wucViewTypeCodeTab1.IsHaveDetail;
            pobjViewTypeCodeTab.IsHaveMainView = wucViewTypeCodeTab1.IsHaveMainView;
            pobjViewTypeCodeTab.IsHaveSubView = wucViewTypeCodeTab1.IsHaveSubView;

            pobjViewTypeCodeTab.IsWebApp = wucViewTypeCodeTab1.IsWebApp;// 是否Web应用
            pobjViewTypeCodeTab.IsWinApp = wucViewTypeCodeTab1.IsWinApp;// 是否Win应用
            pobjViewTypeCodeTab.IsMobileApp = wucViewTypeCodeTab1.IsMobileApp;// 是否移动终端应用


        }

        protected void dgViewTypeCodeTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewTypeCodeTabBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgViewTypeCodeTab.Columns.Count;i++)
				{
					strSortEx = this.dgViewTypeCodeTab.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewTypeCodeTabBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortViewTypeCodeTabBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgViewTypeCodeTab_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			int intViewTypeCode;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				intViewTypeCode = int.Parse( e.Item.Cells[1].Text);
				switch(strCommandName)
				{
					case "Delete":
						DeleteViewTypeCodeTabRecord(intViewTypeCode);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdateViewTypeCodeTabRecord(intViewTypeCode);
						break;

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
					Set_DataGridAllChecked(dgViewTypeCodeTab, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgViewTypeCodeTab, false);
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
		
		//当前记录数
		protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
		{
			AddViewTypeCodeTabRecord();
		}

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombineViewTypeCodeTabCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvViewTypeCodeTabBL.GetDataTable(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewTypeCodeTab信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("ViewTypeCode"); arrCnName.Add("界面类型码");
			arrColName.Add("ViewFunction"); arrCnName.Add("界面功能");
			arrColName.Add("ViewDetail"); arrCnName.Add("界面说明");
			arrColName.Add("ViewTypeName"); arrCnName.Add("界面类型名称");
			arrColName.Add("OptProcess"); arrCnName.Add("操作流程");
			arrColName.Add("ApplicationTypeName"); arrCnName.Add("应用程序类型名称");
			arrColName.Add("IsHaveAdd"); arrCnName.Add("是否有添加");
			arrColName.Add("IsHaveUpdate"); arrCnName.Add("是否有修改");
			arrColName.Add("IsHaveDel"); arrCnName.Add("是否有删除");
			arrColName.Add("IsHaveQuery"); arrCnName.Add("是否有查询");
			arrColName.Add("IsHaveDetail"); arrCnName.Add("是否有详细");
			arrColName.Add("IsHaveExcelExport"); arrCnName.Add("是否EXCEL导出");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
			GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
			DownLoadFile(strDownLoadFileName);
		}
		/// <summary>
		/// 功能：下载文件。从服务器下载文件到客户端浏览器
		/// </summary>
		/// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
		/// <returns></returns>
		private bool DownLoadFile(string strDownLoadFileName)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End();
			return true;
		}

		
		//当前记录数
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
			List<string> arrViewTypeCode =clsCommForWebForm. GetAllCheckedItemFromDg2(dgViewTypeCodeTab, "chkCheckRec");
			if (arrViewTypeCode == null || arrViewTypeCode.Count == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			clsViewTypeCodeTabBL.DelViewTypeCodeTabs(arrViewTypeCode);
			BindDg_ViewTypeCodeTab();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);

            if (string.IsNullOrEmpty(strViewTypeCode) == true) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
            int intViewTypeCode = int.Parse(strViewTypeCode);
            lblMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			//当前所选记录
			UpdateViewTypeCodeTabRecord(intViewTypeCode);
		}
		
		
		protected void dgViewTypeCodeTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortViewTypeCodeTabBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewTypeCodeTabBy = e.SortExpression + " Asc";
				BindDg_ViewTypeCodeTab();
				return ;
			}
			//检查原来是升序
			intIndex = strSortViewTypeCodeTabBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortViewTypeCodeTabBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortViewTypeCodeTabBy = e.SortExpression + " Desc";
			}
			BindDg_ViewTypeCodeTab();
		}

		private string strSortViewTypeCodeTabBy
		{
			get
			{
				string sSortViewTypeCodeTabBy;
				sSortViewTypeCodeTabBy = (string)ViewState["SortViewTypeCodeTabBy"];
				if (sSortViewTypeCodeTabBy==null) 
				{
					sSortViewTypeCodeTabBy = "";
				}
				return sSortViewTypeCodeTabBy;
			}
			set
			{
				string sSortViewTypeCodeTabBy = value;
				ViewState.Add("SortViewTypeCodeTabBy", sSortViewTypeCodeTabBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnViewTypeCodeTabPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewTypeCodeTab.CurrentPageIndex -=1; 
			this.BindDg_ViewTypeCodeTab(); 
		}

		protected void btnViewTypeCodeTabNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewTypeCodeTab.CurrentPageIndex +=1; 
			this.BindDg_ViewTypeCodeTab(); 
		}

		protected void btnViewTypeCodeTabJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtViewTypeCodeTabJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtViewTypeCodeTabJump2Page.Text)>0 && 
				int.Parse(this.txtViewTypeCodeTabJump2Page.Text)-1<this.dgViewTypeCodeTab.PageCount) 
			{ 
				this.dgViewTypeCodeTab.CurrentPageIndex=int.Parse(this.txtViewTypeCodeTabJump2Page.Text)-1; 
			} 
			this.BindDg_ViewTypeCodeTab();
		}

		///生成的插入记录准备过程代码for C#
		private void AddViewTypeCodeTabRecord()
		{
			wucViewTypeCodeTab1.SetKeyReadOnly(false);
			btnOKUpd.Text = "确认添加";
            //wucViewTypeCodeTab1.ViewTypeCode = clsViewTypeCodeTab.GetMaxStrId("ViewTypeCodeTab","ViewTypeCode", 4, "");
            DispEditViewTypeCodeTabRegion();
		}
		///插入记录存盘过程代码for C#
		private void AddViewTypeCodeTabRecordSave()
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			clsViewTypeCodeTabEN objViewTypeCodeTab;
			//1、检查控件中输入数据类型是否正确
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsViewTypeCodeTabEN objViewTypeCodeTab;	//定义对象
			objViewTypeCodeTab = new clsViewTypeCodeTabEN(wucViewTypeCodeTab1.ViewTypeCode);	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			if (clsViewTypeCodeTabBL.IsExist(wucViewTypeCodeTab1.ViewTypeCode))	//判断是否有相同的关键字
			{
				strMsg = "关键字字段已有相同的值";
				clsCommonJsFunc.Alert(this, strMsg);
				return;
			}
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
                clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6、把数据实体层的数据存贮到数据库中
                clsViewTypeCodeTabBL .AddNewRecordBySql2(objViewTypeCodeTab);
			}
			catch(Exception objException)
			{
				strMsg = "添加记录不成功!" + objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				return;
			}
			strMsg = "添加记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "添加记录成功!";
			//7、把新添的记录内容显示在DATAGRID中
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
			DispViewTypeCodeTabListRegion();
		}
		///插入记录存盘过程代码for C#
		private void AddViewTypeCodeTabRecordSaveV5()
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			clsViewTypeCodeTabEN objViewTypeCodeTab;
			//1、检查控件中输入数据类型是否正确
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsViewTypeCodeTabEN objViewTypeCodeTab;	//定义对象
			objViewTypeCodeTab = new clsViewTypeCodeTabEN(wucViewTypeCodeTab1.ViewTypeCode);	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			if (clsViewTypeCodeTabBL.IsExist(wucViewTypeCodeTab1.ViewTypeCode))	//判断是否有相同的关键字
			{
				strMsg = "关键字字段已有相同的值";
				clsCommonJsFunc.Alert(this, strMsg);
				return;
			}
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
				  clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6、把数据实体层的数据存贮到数据库中
                clsViewTypeCodeTabBL.AddNewRecordBySql2(objViewTypeCodeTab);
            }
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			strMsg = "添加记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "添加记录成功!";
			//7、把新添的记录内容显示在DATAGRID中
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
			DispViewTypeCodeTabListRegion();
		}
		///生成修改记录准备过程代码 for C#
		private void UpdateViewTypeCodeTabRecord(int intViewTypeCode)
		{
			//操作步骤：（总共2步）
			//1、显示该关键字记录的内容在界面上；
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；

			//1、显示该关键字记录的内容在界面上；
			ShowData(intViewTypeCode);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucViewTypeCodeTab1.SetKeyReadOnly(true);
			btnOKUpd.Text = "确认修改";
			lblMsg.Text = "";
			DispEditViewTypeCodeTabRegion();
		}
		///修改存盘准备过程代码 for C#
		private void UpdateViewTypeCodeTabRecordSave(clsViewTypeCodeTabEN objViewTypeCodeTab)
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、把值从界面层传到逻辑层或数据实体层
			//3、检查传进去的对象属性是否合法
			//4、把数据实体层的数据存贮到数据库中
			//5、把修改后的内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			//1、检查控件中输入数据类型是否正确
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				  clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6、把数据实体层的数据存贮到数据库中
                clsViewTypeCodeTabBL .UpdateBySql2(objViewTypeCodeTab);
			}
			catch(Exception objException)
			{
				strMsg = "修改记录不成功!" + objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				return ; 
			}
			strMsg = "修改记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "修改记录成功!";
			//5、把修改后的内容显示在DATAGRID中
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			DispViewTypeCodeTabListRegion();
		}
		///修改存盘准备过程代码 for C#
		private void UpdateViewTypeCodeTabRecordSaveV5(clsViewTypeCodeTabEN objViewTypeCodeTab)
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、把值从界面层传到逻辑层或数据实体层
			//3、检查传进去的对象属性是否合法
			//4、把数据实体层的数据存贮到数据库中
			//5、把修改后的内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			//1、检查控件中输入数据类型是否正确
			if (!wucViewTypeCodeTab1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToViewTypeCodeTabClass(objViewTypeCodeTab);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				  clsViewTypeCodeTabBL .CheckPropertyNew(objViewTypeCodeTab);
                //6、把数据实体层的数据存贮到数据库中
                clsViewTypeCodeTabBL .UpdateBySql2(objViewTypeCodeTab);
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			strMsg = "修改记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "修改记录成功!";
			//5、把修改后的内容显示在DATAGRID中
			BindDg_ViewTypeCodeTab();
			wucViewTypeCodeTab1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			DispViewTypeCodeTabListRegion();
		}
		///删除记录过程代码for C#
		private void DeleteViewTypeCodeTabRecord(int intViewTypeCode)
		{
			clsViewTypeCodeTabBL.DelRecord(intViewTypeCode);
			BindDg_ViewTypeCodeTab();
		}
		private void DispEditViewTypeCodeTabRegion()
		{
			tabViewTypeCodeTabDataGrid.Visible = false;
			tabEditViewTypeCodeTabRegion.Visible = true;
		}
		private void DispViewTypeCodeTabListRegion()
		{
			tabViewTypeCodeTabDataGrid.Visible = true;
			tabEditViewTypeCodeTabRegion.Visible = false;
		}
		
		//当前记录数
		protected void lbDispViewTypeCodeTabList_Click(object sender, System.EventArgs e)
		{
			DispViewTypeCodeTabListRegion();
		}

		protected void dgViewTypeCodeTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			//			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 7;
				iNum[1] = 8;
				iNum[2] = 9;
				iNum[3] = 10;
				iNum[4] = 11;
				iNum[5] = 12;
                iNum[6] = 13;
                iNum[7] = 14;
                iNum[8] = 15;

				for (int i = 0; i<9; i++)
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

        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);
            if (strViewTypeCode == null || strViewTypeCode.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            int intViewTypeCode = int.Parse(strViewTypeCode);

            try
            {
                clsViewTypeCodeTabBLEx.AdjustSequenceNumber("UP", intViewTypeCode);
            }
            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindDg_ViewTypeCodeTab();
            clsCommForWebForm.SetCheckedItemForDg(dgViewTypeCodeTab, 1, intViewTypeCode.ToString());

        }

        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            string strMsg;
            string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);
            if (strViewTypeCode == null || strViewTypeCode.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";

            int intViewTypeCode = int.Parse(strViewTypeCode);
            try
            {
                clsViewTypeCodeTabBLEx.AdjustSequenceNumber("DOWN", intViewTypeCode);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgList.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindDg_ViewTypeCodeTab();
            clsCommForWebForm.SetCheckedItemForDg(dgViewTypeCodeTab, 1, intViewTypeCode.ToString());

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsViewTypeCodeTabBLEx.ReOrder();
            BindDg_ViewTypeCodeTab();

        }


        protected void btnGoTop_Click(object sender, EventArgs e)
        {
            List<string> arrViewTypeCodeTabId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgViewTypeCodeTab, "chkCheckRec");
            if (arrViewTypeCodeTabId == null || arrViewTypeCodeTabId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";


                try
                {
                    clsViewTypeCodeTabBLEx.GoTop(arrViewTypeCodeTabId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindDg_ViewTypeCodeTab();
        }

        protected void btnGoBottum_Click(object sender, EventArgs e)
        {
            List<string> arrViewTypeCodeTabId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgViewTypeCodeTab, "chkCheckRec");
            if (arrViewTypeCodeTabId == null || arrViewTypeCodeTabId.Count == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                clsCommonJsFunc.Alert(this, lblMsgList.Text);
                return;
            }
            else
            {
                lblMsgList.Text = "";
                try
                {
                    clsViewTypeCodeTabBLEx.GoBottom(arrViewTypeCodeTabId);
                }
                catch (Exception objException)
                {
                    clsCommonSession.seErrMessage = objException.Message;
                    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
            }
            BindDg_ViewTypeCodeTab();
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

        protected void btnClone_Click(object sender, EventArgs e)
        {
            string strViewTypeCode = clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewTypeCodeTab);

            if (string.IsNullOrEmpty(strViewTypeCode) == true)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            int intViewTypeCode = int.Parse(strViewTypeCode);
            lblMsgList.Text = "";
            clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCode(intViewTypeCode);
            objViewTypeCodeTabEN.ViewTypeName = "Copy_" + objViewTypeCodeTabEN.ViewTypeName;

            try
            {
                clsViewTypeCodeTabBL.AddNewRecordBySql2(objViewTypeCodeTabEN);

            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }

            BindDg_ViewTypeCodeTab();
        }
    }
}