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

using com.taishsoft.common;
using com.taishsoft.datetime;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AGC.Entity;



namespace AGC.Webform
{
	/// <summary>
	/// wfmPrjTabFld_Q 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmPrjTabFld_Q : CommWebPageBase
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

                // 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
                //wucStudent1.SetDdl_College();
                //1、为下拉框设置数据源，绑定列表数据
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
				clsDropDownList.BindDdl_PrimaryTypeId(ddlPrimaryTypeIdq);
                clsFieldTypeBLEx.BindDdl_FieldTypeIdCache(ddlFldTypeq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlDataTypeq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlDataType);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
				ddlPrjIdq.Enabled = false;
				//2、显示无条件的表内容在DATAGRID中
                strSortPrjTabFldBy = "FuncModuleName,TabName,SequenceNumber Asc";
				BindDg_PrjTabFld();
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

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombinePrjTabFldCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
//			string strWhereCond=" 1=1 and PrjId = '" + PrjId + "'";
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.ddlTabIdq.SelectedValue!="" && this.ddlTabIdq.SelectedValue!="0")
			{
				strWhereCond += " And TabId='" + this.ddlTabIdq.SelectedValue+"'";
			}
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " And PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}
			if (this.ddlPrimaryTypeIdq.SelectedValue!="" && this.ddlPrimaryTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And PrimaryTypeId='" + this.ddlPrimaryTypeIdq.SelectedValue+"'";
			}
			if (this.txtFldNameq.Text.Trim()!="")
			{
				strWhereCond += " And FldName like '%" + this.txtFldNameq.Text.Trim()+"%'";
			}
            if (this.txtFldName_New.Text.Trim() != "")
            {
                strWhereCond += string.Format(" and tabid not in (select tabid from vPrjTabFld where FldName = '{0}') ", this.txtFldName_New.Text.Trim());
            }
            if (this.ddlFldTypeq.SelectedValue!="" && this.ddlFldTypeq.SelectedValue!="0")
			{
                strWhereCond += string.Format(" And {0}='{1}'", 
                    conPrjTabFld.FieldTypeId,
                    this.ddlFldTypeq.SelectedValue );
			}
            if (this.ddlDataTypeq.SelectedValue != "" && this.ddlDataTypeq.SelectedValue != "0")
            {
                strWhereCond += " And DataTypeId='" + this.ddlFldTypeq.SelectedValue + "'";
            }
            if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
            {
                strWhereCond += " and FuncModuleAgcId='" + this.ddlFuncModuleId.SelectedValue + "'";
            }

			return strWhereCond;
		}
         ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_PrjTabFld()
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
			string strWhereCond = CombinePrjTabFldCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTabFld1.PageSize);
			if (intPages==0) 
			{
				this.dgPrjTabFld1.CurrentPageIndex = 0;
			}
			else if (this.dgPrjTabFld1.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjTabFld1.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortPrjTabFldBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用

            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
            {
                int intPageSize = int.Parse(PageSize4PrjTab);
                dgPrjTabFld1.PageSize = intPageSize;
            }
            else
            {
                PageSize4PrjTab = "10";
                dgPrjTabFld1.PageSize = 10;
            }
            this.dgPrjTabFld1.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgPrjTabFld1.DataBind();

			
			//当前记录数
			this.lblPrjTabFldRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblPrjTabFldAllPages.Text = this.dgPrjTabFld1.PageCount.ToString(); 
			//当前页序数
			this.lblPrjTabFldCurrentPage.Text=(this.dgPrjTabFld1.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtPrjTabFldJump2Page.Text=(this.dgPrjTabFld1.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgPrjTabFld1.CurrentPageIndex==0) 
			{
				btnPrjTabFldPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnPrjTabFldPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgPrjTabFld1.CurrentPageIndex==this.dgPrjTabFld1.PageCount-1) 
			{ 
				btnPrjTabFldNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnPrjTabFldNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabPrjTabFldJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabPrjTabFldJumpPage.Visible = false; 
			}
            //设置分页器中每页记录数的下拉框的值
            if (string.IsNullOrEmpty(PageSize4PrjTab) == false)
            {
                ddlPagerRecCount.Text = PageSize4PrjTab;
            }
            else
            {
                PageSize4PrjTab = "10";
                ddlPagerRecCount.Text = PageSize4PrjTab;
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
			this.dgPrjTabFld1.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_PrjTabFld();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgPrjTabFld1.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_PrjTabFld();
		}

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombinePrjTabFldCondition();
            strWhereCond += string.Format(" Order By  {0}, {1}, {2}, TabName, SequenceNumber", 
                convPrjTabFld.SqlDsTypeName, convPrjTabFld.OrderNum4Refer,
                convPrjTabFld.FuncModuleName);
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "PrjTabFld信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
            arrColName.Add(convPrjTabFld.FuncModuleName); arrCnName.Add("模块");
            arrColName.Add(convPrjTabFld.TabName); arrCnName.Add("表名");
            arrColName.Add(convPrjTabFld.SqlDsTypeName); arrCnName.Add("Sql类型名");
            arrColName.Add(convPrjTabFld.OrderNum4Refer); arrCnName.Add("表引用序号");

            arrColName.Add(convPrjTabFld.SequenceNumber); arrCnName.Add("字段序号");
			arrColName.Add(convPrjTabFld.FldName); arrCnName.Add("字段名");
			arrColName.Add(convPrjTabFld.Caption); arrCnName.Add("标题");
			arrColName.Add(convPrjTabFld.DataTypeName); arrCnName.Add("类型");
			arrColName.Add(convPrjTabFld.FldLength); arrCnName.Add("字段长度");
			arrColName.Add(convPrjTabFld.IsTabNullable); arrCnName.Add("是否可空");
			arrColName.Add(convPrjTabFld.MinValue); arrCnName.Add("最小值");
			arrColName.Add(convPrjTabFld.MaxValue); arrCnName.Add("最大值");
			arrColName.Add(convPrjTabFld.DefaultValue); arrCnName.Add("缺省值");
			arrColName.Add(convPrjTabFld.IsTabUnique); arrCnName.Add("是否唯一");
			//arrColName.Add(convPrjTabFld.IsTabPrimary); arrCnName.Add("是否主键");
			arrColName.Add(convPrjTabFld.PrimaryTypeName); arrCnName.Add("主键类型");
			arrColName.Add(convPrjTabFld.FieldTypeName); arrCnName.Add("字段类型");
			arrColName.Add(convPrjTabFld.IsParentObj); arrCnName.Add("是否父对象");
			arrColName.Add(convPrjTabFld.IsTabForeignKey); arrCnName.Add("是否表外键");
			arrColName.Add(convPrjTabFld.ForeignTabName); arrCnName.Add("外键表名");
            arrColName.Add(convPrjTabFld.MemoInTab); arrCnName.Add("说明");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

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
	
		
		
		protected void dgPrjTabFld_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortPrjTabFldBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortPrjTabFldBy = e.SortExpression + " Asc";
				BindDg_PrjTabFld();
				return ;
			}
			//检查原来是升序
			intIndex = strSortPrjTabFldBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortPrjTabFldBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortPrjTabFldBy = e.SortExpression + " Desc";
			}
			BindDg_PrjTabFld();
		}

		private string strSortPrjTabFldBy
		{
			get
			{
				string sSortPrjTabFldBy;
				sSortPrjTabFldBy = (string)ViewState["SortPrjTabFldBy"];
				if (sSortPrjTabFldBy==null) 
				{
					sSortPrjTabFldBy = "";
				}
				return sSortPrjTabFldBy;
			}
			set
			{
				string sSortPrjTabFldBy = value;
				ViewState.Add("SortPrjTabFldBy", sSortPrjTabFldBy);
			}
		}
		protected void dgPrjTabFld_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			int intIndex;
			if (strSortPrjTabFldBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgPrjTabFld1.Columns.Count;i++)
				{
					strSortEx = this.dgPrjTabFld1.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortPrjTabFldBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortPrjTabFldBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnPrjTabFldPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjTabFld1.CurrentPageIndex -=1; 
			this.BindDg_PrjTabFld(); 
		}

		protected void btnPrjTabFldNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjTabFld1.CurrentPageIndex +=1; 
			this.BindDg_PrjTabFld(); 
		}

		protected void btnPrjTabFldJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtPrjTabFldJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtPrjTabFldJump2Page.Text)>0 && 
				int.Parse(this.txtPrjTabFldJump2Page.Text)-1<this.dgPrjTabFld1.PageCount) 
			{ 
				this.dgPrjTabFld1.CurrentPageIndex=int.Parse(this.txtPrjTabFldJump2Page.Text)-1; 
			} 
			this.BindDg_PrjTabFld();
		}

		protected void ddlFuncModuleId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlFuncModuleId.SelectedIndex>0)
			{
				string strFuncModuleId = ddlFuncModuleId.SelectedValue;
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
			}
		}
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize4PrjTab = intPageSize.ToString();
                    BindDg_PrjTabFld();
                }
            }
        }
        ///生成专门用于记录GridView中的每页记录数
        protected string PageSize4PrjTab
        {
            get
            {
                string strPageSize4PrjTab;
                strPageSize4PrjTab = (string)Session["PageSize4PrjTab"];
                if (strPageSize4PrjTab == null)
                {
                    strPageSize4PrjTab = "";
                }
                return strPageSize4PrjTab;
            }
            set
            {
                string strPageSize4PrjTab = value;
                Session.Add("PageSize4PrjTab", strPageSize4PrjTab);
            }
        }

        protected void btnAddFldNameToPrjTab_Click(object sender, EventArgs e)
        {
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
            //2、定义对象并初始化对象
            //ErrorInformationBL.AddInformation("AA", "BB", "AAA", "AA");
            string strMsg;
            string strFldId = "";
            string strCondition = "";
            lblMsg4AddRecord.Text = "";
            //clsFieldTabEN objFieldTabEN;

            List<clsFieldTabEN> arrFieldTabObjLst = null;
            if (string.IsNullOrEmpty(DataTypeId) == true)
            {
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' ",
                           clsPubVar.CurrSelPrjId, FldName);
                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count == 1)
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
                else if (arrFieldTabObjLst.Count > 1)
                {
                    strMsg = "请选择字段类型!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    ddlDataType.Visible = true;
                    lblFldType.Visible = true;
                    ddlDataType.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(strFldId) == true)
            {
                //检查是否存在相同字段名
                strCondition = string.Format("PrjId = '{0}' and FldName = '{1}' And DataTypeId='{2}'",
                              clsPubVar.CurrSelPrjId, FldName, DataTypeId);

                arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count > 0)    //判断是否有相同的关键字
                {
                    strFldId = arrFieldTabObjLst[0].FldId;
                }
            }
          List<  string> arrmIdLst = clsCommForWebForm.GetAllCheckedItemFromDg2(dgPrjTabFld1, "chkCheckRec");
            if (arrmIdLst.Count == 0)
            {
                lblMsg4AddRecord.Text = "没有选择表记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg4AddRecord.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            strCondition = string.Format("{0} in ({1})", conPrjTabFld.mId, clsArray.GetSqlInStrByArray( arrmIdLst, false));
            List<clsPrjTabFldEN> arrPrjTabFldLst = clsPrjTabFldBL.GetObjLst(strCondition);
            List<string> arrTabIdLst = new List<string>();
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldLst)
            {
                if (arrTabIdLst.Contains(objPrjTabFldEN.TabId) == false)
                {
                    arrTabIdLst.Add(objPrjTabFldEN.TabId);
                }
            }
            int intCount = 0;
            if (string.IsNullOrEmpty(strFldId) == false)
            {
                foreach (string strTabId in arrTabIdLst)
                {
                    clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTabId, strFldId, clsCommonSession.UserId);
                    intCount++;
                }
                BindDg_PrjTabFld();
                strMsg = string.Format("共添加了:[{0}]条记录！", intCount);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            

            //try
            //{
            //    //添加日志
            //    string strUserId = clsCommonSession.UserId;
            //    string strUserIp = Request.UserHostAddress;
            //    string strUserName = clsUsersBL.GetObjByUserId(clsCommonSession.UserId).UserName;
            //    string strOperationType = clsOperationTypeBLEx.ADD_RECORD; //删除记录;
            //    string strTableName = "FieldTab";
            //    string strTableKey = objFieldTabEN.FldId;
            //    string strJournal = "执行了添加操作，添加表FieldTab! 字段名："
            //        + objFieldTabEN.Caption + "(" + objFieldTabEN.FldName + ")";

            //    bool IsSuccesful = true;
            //    IsSuccesful = clsSysLogServerBLEx.AddSysLogInfo(strUserId,
            //        strUserIp,
            //        strOperationType,
            //        strTableName,
            //        strTableKey,
            //        strJournal,
            //        clsPubVar.CurrSelPrjId);
            //}
            //catch (Exception objException)
            //{
            //    clsCommonSession.seErrMessage = "添加记录的添加日志不成功!\r\n" + objException.Message;
            //    clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    clsPubFun4Web.AccessError(this, conCurrPageName);
            //}
        }



        public string FldName
        {
            get
            {
                return txtFldName_New.Text.Trim();
            }
            set
            {
                txtFldName_New.Text = value.ToString();
            }
        }


        public string DataTypeId
        {
            get
            {
                if (ddlDataType.SelectedValue == "0")
                {
                    return "";
                }
                return ddlDataType.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDataType.SelectedValue = "0";
                }
                else
                {
                    ddlDataType.SelectedValue = value;
                }
            }
        }

        protected void dgPrjTabFld_ItemCommand(object source, DataGridCommandEventArgs e)
        {                  
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "全选")
                    {
                        clsCommForWebForm.Set_AllDgCkecked(dgPrjTabFld1, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_AllDgCkecked(dgPrjTabFld1, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
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