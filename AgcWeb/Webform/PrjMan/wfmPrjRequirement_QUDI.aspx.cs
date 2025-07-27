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
using com.taishsoft.common;

using System.Collections.Generic;
using com.taishsoft.datetime;

using AGC.Entity;
using CommonTable.Entity;
using AGC.BusinessLogic;using AGC.FunClass;
using CommonTable.BusinessLogic;


namespace AGC
{
	/// <summary>
	/// wfmPrjRequirement_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmPrjRequirement_QUDI : CommWebPageBase
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
                wucPrjRequirement1.TabHidden();
				wucPrjRequirement1.SetDdl_PrjId();
				wucPrjRequirement1.SetDdl_UpReqId();
				wucPrjRequirement1.SetDdl_ReqTypeId();
				wucPrjRequirement1.SetDdl_FuncModuleId();
				BindDdl_UpReqId(ddlUpReqId_q);
				BindDdl_ReqTypeId(ddlReqTypeId_q);
				BindDdl_FuncModuleId(ddlFuncModuleId_q);

				

				strSortPrjRequirementBy = "ReqId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_PrjRequirement();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucPrjRequirement1.SetKeyReadOnly(true);
				tabEditPrjRequirementRegion.Visible=false;
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
		
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
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
		private string CombinePrjRequirementCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 and PrjId = '" + clsPubVar.CurrSelPrjId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtReqId_q.Text.Trim()!="")
			{
				strWhereCond += " And ReqId like '%" + this.txtReqId_q.Text.Trim()+"%'";
			}
			if (this.txtRequirement_q.Text.Trim()!="")
			{
				strWhereCond += " And Requirement like '%" + this.txtRequirement_q.Text.Trim()+"%'";
			}
			
			if (this.ddlUpReqId_q.SelectedValue!="" && this.ddlUpReqId_q.SelectedValue!="0")
			{
				strWhereCond += " And UpReqId='" + this.ddlUpReqId_q.SelectedValue+"'";
			}
			if (this.ddlReqTypeId_q.SelectedValue!="" && this.ddlReqTypeId_q.SelectedValue!="0")
			{
				strWhereCond += " And ReqTypeId='" + this.ddlReqTypeId_q.SelectedValue+"'";
			}
			if (this.ddlFuncModuleId_q.SelectedValue!="" && this.ddlFuncModuleId_q.SelectedValue!="0")
			{
				strWhereCond += " And FuncModuleAgcId='" + this.ddlFuncModuleId_q.SelectedValue+"'";
			}
			if (this.txtIsFinished_q.Text.Trim()!="")
			{
				strWhereCond += " And IsFinished like '%" + this.txtIsFinished_q.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_PrjRequirement()
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
			string strWhereCond = CombinePrjRequirementCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsPrjRequirementBL.GetDataTable_PrjRequirementV(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjRequirement.PageSize);
			if (intPages==0) 
			{
				this.dgPrjRequirement.CurrentPageIndex = 0;
			}
			else if (this.dgPrjRequirement.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjRequirement.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortPrjRequirementBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgPrjRequirement.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgPrjRequirement.DataBind();

			
			//当前记录数
			this.lblPrjRequirementRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblPrjRequirementAllPages.Text = this.dgPrjRequirement.PageCount.ToString(); 
			//当前页序数
			this.lblPrjRequirementCurrentPage.Text=(this.dgPrjRequirement.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtPrjRequirementJump2Page.Text=(this.dgPrjRequirement.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgPrjRequirement.CurrentPageIndex==0) 
			{
				btnPrjRequirementPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnPrjRequirementPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgPrjRequirement.CurrentPageIndex==this.dgPrjRequirement.PageCount-1) 
			{ 
				btnPrjRequirementNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnPrjRequirementNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabPrjRequirementJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabPrjRequirementJumpPage.Visible = false; 
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
			this.dgPrjRequirement.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_PrjRequirement();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgPrjRequirement_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgPrjRequirement.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_PrjRequirement();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strReqId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strReqId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strReqId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsPrjRequirementBL.IsExist(strReqId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strReqId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsPrjRequirementEN objPrjRequirement = new clsPrjRequirementEN(strReqId);
            //4、获取类对象的所有属性；
            clsPrjRequirementBL .GetPrjRequirement(ref objPrjRequirement);
			Session.Add("objPrjRequirement", objPrjRequirement);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromPrjRequirementClass(objPrjRequirement);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjPrjRequirement">表实体类对象</param>
		private void GetDataFromPrjRequirementClass(clsPrjRequirementEN pobjPrjRequirement)
		{
			wucPrjRequirement1.ReqId = pobjPrjRequirement.ReqId;
			wucPrjRequirement1.Requirement = pobjPrjRequirement.Requirement;
			wucPrjRequirement1.PrjId = pobjPrjRequirement.PrjId;
			wucPrjRequirement1.UpReqId = pobjPrjRequirement.UpReqId;
			wucPrjRequirement1.ReqTypeId = pobjPrjRequirement.ReqTypeId;
			wucPrjRequirement1.FuncModuleAgcId = pobjPrjRequirement.FuncModuleAgcId;
			wucPrjRequirement1.IsFinished = pobjPrjRequirement.IsFinished;
			wucPrjRequirement1.ReqContent = pobjPrjRequirement.ReqContent;
			wucPrjRequirement1.Memo = pobjPrjRequirement.Memo;
		}
		/// <summary>
		/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
		///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strCommandText;
			clsPrjRequirementEN objPrjRequirement;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					AddPrjRequirementRecord();
					break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					AddPrjRequirementRecordSave();
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					objPrjRequirement = (clsPrjRequirementEN) Session["objPrjRequirement"];
					UpdatePrjRequirementRecordSave(objPrjRequirement);
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjPrjRequirement">数据传输的目的类对象</param>
		private void PutDataToPrjRequirementClass(clsPrjRequirementEN pobjPrjRequirement)
		{
			pobjPrjRequirement.ReqId = wucPrjRequirement1.ReqId;
			pobjPrjRequirement.Requirement = wucPrjRequirement1.Requirement;
			pobjPrjRequirement.PrjId = wucPrjRequirement1.PrjId;
			pobjPrjRequirement.UpReqId = wucPrjRequirement1.UpReqId;
			pobjPrjRequirement.ReqTypeId = wucPrjRequirement1.ReqTypeId;
			pobjPrjRequirement.FuncModuleAgcId = wucPrjRequirement1.FuncModuleAgcId;
			pobjPrjRequirement.IsFinished = wucPrjRequirement1.IsFinished;
			pobjPrjRequirement.ReqContent = wucPrjRequirement1.ReqContent;
			pobjPrjRequirement.Memo = wucPrjRequirement1.Memo;
            pobjPrjRequirement.UserId= UserId;
			pobjPrjRequirement.UpdDate= clsDateTime.getTodayStr(0);
		}

		protected void dgPrjRequirement_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortPrjRequirementBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgPrjRequirement.Columns.Count;i++)
				{
					strSortEx = this.dgPrjRequirement.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortPrjRequirementBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortPrjRequirementBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgPrjRequirement_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strReqId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strReqId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						DeletePrjRequirementRecord(strReqId);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdatePrjRequirementRecord(strReqId);
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
					Set_DataGridAllChecked(dgPrjRequirement, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgPrjRequirement, false);
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
			tabEditPrjRequirementRegion.Visible=true;
			AddPrjRequirementRecord();
		}


		
		//当前记录数
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
            List<string> arrReqId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgPrjRequirement, "chkCheckRec");
			if (arrReqId == null || arrReqId.Count == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			clsPrjRequirementBL.DelPrjRequirements(arrReqId);
			BindDg_PrjRequirement();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strReqId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgPrjRequirement);
			if (strReqId == null || strReqId.Trim().Length == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			//当前所选记录
			UpdatePrjRequirementRecord(strReqId);
		}
	
		public System.Data.DataTable GetUpReqId()
		{
			//获取某学院所有专业信息
			string strSQL = "select ReqId, Requirement from PrjRequirement ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UpReqId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetUpReqId();
			objDDL.DataValueField="ReqId";
			objDDL.DataTextField="Requirement";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetReqTypeId()
		{
			//获取某学院所有专业信息
            string strSQL = "select RequirementTypeId, RequirementTypeName from RequirementType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ReqTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetReqTypeId();
			objDDL.DataValueField="RequirementTypeId";
            objDDL.DataTextField = "RequirementTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetFuncModuleId()
		{
			//获取某学院所有专业信息
			string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetFuncModuleId();
			objDDL.DataValueField="FuncModuleAgcId";
			objDDL.DataTextField="FuncModuleName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgPrjRequirement_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortPrjRequirementBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortPrjRequirementBy = e.SortExpression + " Asc";
				BindDg_PrjRequirement();
				return ;
			}
			//检查原来是升序
			intIndex = strSortPrjRequirementBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortPrjRequirementBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortPrjRequirementBy = e.SortExpression + " Desc";
			}
			BindDg_PrjRequirement();
		}

		private string strSortPrjRequirementBy
		{
			get
			{
				string sSortPrjRequirementBy;
				sSortPrjRequirementBy = (string)ViewState["SortPrjRequirementBy"];
				if (sSortPrjRequirementBy==null) 
				{
					sSortPrjRequirementBy = "";
				}
				return sSortPrjRequirementBy;
			}
			set
			{
				string sSortPrjRequirementBy = value;
				ViewState.Add("SortPrjRequirementBy", sSortPrjRequirementBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnPrjRequirementPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjRequirement.CurrentPageIndex -=1; 
			this.BindDg_PrjRequirement(); 
		}

		protected void btnPrjRequirementNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjRequirement.CurrentPageIndex +=1; 
			this.BindDg_PrjRequirement(); 
		}

		protected void btnPrjRequirementJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtPrjRequirementJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtPrjRequirementJump2Page.Text)>0 && 
				int.Parse(this.txtPrjRequirementJump2Page.Text)-1<this.dgPrjRequirement.PageCount) 
			{ 
				this.dgPrjRequirement.CurrentPageIndex=int.Parse(this.txtPrjRequirementJump2Page.Text)-1; 
			} 
			this.BindDg_PrjRequirement();
		}

		///生成的插入记录准备过程代码for C#
		private void AddPrjRequirementRecord()
		{
			wucPrjRequirement1.SetKeyReadOnly(false);
			btnOKUpd.Text = "确认添加";
			wucPrjRequirement1.SetDefaultValue();
            wucPrjRequirement1.ReqId = clsPrjRequirementBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
			wucPrjRequirement1.UserId = UserId;
            wucPrjRequirement1.PrjId = clsPubVar.CurrSelPrjId;
			DispEditPrjRequirementRegion();
		}
		///插入记录存盘过程代码for C#
		private void AddPrjRequirementRecordSave()
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
			clsPrjRequirementEN objPrjRequirement;
			//1、检查控件中输入数据类型是否正确
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsPrjRequirementEN objPrjRequirement;	//定义对象
			objPrjRequirement = new clsPrjRequirementEN();	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//if (clsPrjRequirementBL.IsExist())	//判断是否有相同的关键字
			//{
			//	strMsg = "关键字字段已有相同的值";
			//	clsCommonJsFunc.Alert(this, strMsg);
			//	return;
			//}
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToPrjRequirementClass(objPrjRequirement);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
                clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjRequirementBL .AddNewRecordBySql2(objPrjRequirement);
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
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
			DispPrjRequirementListRegion();
		}
		///插入记录存盘过程代码for C#
		private void AddPrjRequirementRecordSaveV5()
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
			clsPrjRequirementEN objPrjRequirement;
			//1、检查控件中输入数据类型是否正确
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsPrjRequirementEN objPrjRequirement;	//定义对象
			objPrjRequirement = new clsPrjRequirementEN();	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//if (clsPrjRequirementBL.IsExist())	//判断是否有相同的关键字
			//{
			//	strMsg = "关键字字段已有相同的值";
			//	clsCommonJsFunc.Alert(this, strMsg);
			//	return;
			//}
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToPrjRequirementClass(objPrjRequirement);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
				clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjRequirementBL.AddNewRecordBySql2(objPrjRequirement);
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
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
			DispPrjRequirementListRegion();
		}
		///生成修改记录准备过程代码 for C#
		private void UpdatePrjRequirementRecord(string strReqId)
		{
			//操作步骤：（总共2步）
			//1、显示该关键字记录的内容在界面上；
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；

			//1、显示该关键字记录的内容在界面上；
			ShowData(strReqId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucPrjRequirement1.SetKeyReadOnly(true);
			btnOKUpd.Text = "确认修改";
			lblMsg.Text = "";
			DispEditPrjRequirementRegion();
		}
		///修改存盘准备过程代码 for C#
		private void UpdatePrjRequirementRecordSave(clsPrjRequirementEN objPrjRequirement)
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
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToPrjRequirementClass(objPrjRequirement);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjRequirementBL .UpdateBySql2(objPrjRequirement);
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
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			DispPrjRequirementListRegion();
		}
		///修改存盘准备过程代码 for C#
		private void UpdatePrjRequirementRecordSaveV5(clsPrjRequirementEN objPrjRequirement)
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
			if (!wucPrjRequirement1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToPrjRequirementClass(objPrjRequirement);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				clsPrjRequirementBL .CheckPropertyNew(objPrjRequirement);
                //6、把数据实体层的数据存贮到数据库中
                clsPrjRequirementBL.UpdateBySql2(objPrjRequirement);
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
			BindDg_PrjRequirement();
			wucPrjRequirement1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			DispPrjRequirementListRegion();
		}
		///删除记录过程代码for C#
		private void DeletePrjRequirementRecord(string strReqId)
		{
			clsPrjRequirementBL.DelRecord(strReqId);
			BindDg_PrjRequirement();
		}
		private void DispEditPrjRequirementRegion()
		{
			tabPrjRequirementDataGrid.Visible = false;
			tabEditPrjRequirementRegion.Visible = true;
		}
		private void DispPrjRequirementListRegion()
		{
			tabPrjRequirementDataGrid.Visible = true;
			tabEditPrjRequirementRegion.Visible = false;
		}
		
		//当前记录数
		protected void lbDispPrjRequirementList_Click(object sender, System.EventArgs e)
		{
			DispPrjRequirementListRegion();
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