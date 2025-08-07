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
using AGC.Entity;


using com.taishsoft.common;
using System.Text;
using AutoGCLib;


namespace AGC.Webform
{
	/// <summary>
	/// wfmExcelExportRegionFlds_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmExcelExportRegionFlds_QUDI : CommWebPageBase
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
				//2、显示无条件的表内容在DATAGRID中
				strSortExcelExportRegionFldsBy = "SeqNum Asc";

				BindDg_ExcelExportRegionFlds();
				
				tabEditExcelExportRegionFldsRegion.Visible = false;  //具体信息维护区域隐藏

				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
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
		private string SimpleFName  //单纯的文件名，不带目录名
		{
			get
			{
				string strSimpleFName;
				strSimpleFName = (string)ViewState["SimpleFName"];
				if (strSimpleFName==null) 
				{
					strSimpleFName = "";
				}
				return strSimpleFName;
			}
			set
			{
				string strSimpleFName = value;
				ViewState.Add("SimpleFName", strSimpleFName);
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


		//生成返回链接串的Session属性
		private string BackViewRegionLinkStr
		{
			get
			{
				string strBackViewRegionLinkStr;
				strBackViewRegionLinkStr = (string)Session["BackViewRegionLinkStr"];
				if (strBackViewRegionLinkStr==null) 
				{
					strBackViewRegionLinkStr = "";
				}
				return strBackViewRegionLinkStr;
			}
			set
			{
				string strBackViewRegionLinkStr = value;
				Session.Add("BackViewRegionLinkStr", strBackViewRegionLinkStr);
			}
		}
        private string RegionId
        {
            get
            {
                string lngRegionId;
                if (Session["RegionId"] == null)
                {
                    lngRegionId = "";
                }
                else
                {
                    string strRegionId = Session["RegionId"].ToString();
                    lngRegionId = strRegionId;
                }
                return lngRegionId;
            }
            set
            {
                string lngRegionId = value;
                Session.Add("RegionId", lngRegionId);
            }
        }



        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineExcelExportRegionFldsCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 and RegionId = " + RegionId;
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtColCaptionq.Text.Trim()!="")
			{
				strWhereCond += " And ColCaption like '%" + this.txtColCaptionq.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_ExcelExportRegionFlds()
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
			string strWhereCond = CombineExcelExportRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgExcelExportRegionFlds.PageSize);
			if (intPages==0) 
			{
				this.dgExcelExportRegionFlds.CurrentPageIndex = 0;
			}
			else if (this.dgExcelExportRegionFlds.CurrentPageIndex > intPages - 1) 
			{
				this.dgExcelExportRegionFlds.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortExcelExportRegionFldsBy;
			this.dgExcelExportRegionFlds.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgExcelExportRegionFlds.DataBind();

			
			//当前记录数
			this.lblExcelExportRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblExcelExportRegionFldsAllPages.Text = this.dgExcelExportRegionFlds.PageCount.ToString(); 
			//当前页序数
			this.lblExcelExportRegionFldsCurrentPage.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtExcelExportRegionFldsJump2Page.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgExcelExportRegionFlds.CurrentPageIndex==0) 
			{
				btnExcelExportRegionFldsPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnExcelExportRegionFldsPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgExcelExportRegionFlds.CurrentPageIndex==this.dgExcelExportRegionFlds.PageCount-1) 
			{ 
				btnExcelExportRegionFldsNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnExcelExportRegionFldsNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabExcelExportRegionFldsJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabExcelExportRegionFldsJumpPage.Visible = false; 
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
			this.dgExcelExportRegionFlds.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_ExcelExportRegionFlds();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgExcelExportRegionFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgExcelExportRegionFlds.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ExcelExportRegionFlds();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(long lngmId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (lngmId == 0) return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngmId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngmId);
            //4、获取类对象的所有属性；
            clsExcelExportRegionFldsBL .GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
			Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);
			DispEditExcelExportRegionFldsRegion();
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjExcelExportRegionFlds">表实体类对象</param>
		private void GetDataFromExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
			wucExcelExportRegionFlds1.Memo = pobjExcelExportRegionFlds.Memo;
			wucExcelExportRegionFlds1.SeqNum = pobjExcelExportRegionFlds.SeqNum;
			wucExcelExportRegionFlds1.ColCaption = pobjExcelExportRegionFlds.ColCaption;
			wucExcelExportRegionFlds1.FldId = pobjExcelExportRegionFlds.FldId;
			//clsvExcelExportRegionFldsEN objvExcelExportRegionFlds =  clsvExcelExportRegionFldsBL.GetFirstObj_S("RegionId = '" + RegionId + "' and TabFldId = " + pobjExcelExportRegionFlds.TabFldId);
			//wucExcelExportRegionFlds1.FldName = objvExcelExportRegionFlds.FldName;

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
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					AddExcelExportRegionFldsRecord();
					break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					AddExcelExportRegionFldsRecordSave();
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					objExcelExportRegionFlds = (clsExcelExportRegionFldsEN) Session["objExcelExportRegionFlds"];
					UpdateExcelExportRegionFldsRecordSave(objExcelExportRegionFlds);
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjExcelExportRegionFlds">数据传输的目的类对象</param>
		private void PutDataToExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
			pobjExcelExportRegionFlds.Memo = wucExcelExportRegionFlds1.Memo;
			pobjExcelExportRegionFlds.SeqNum = wucExcelExportRegionFlds1.SeqNum;
			pobjExcelExportRegionFlds.ColCaption = wucExcelExportRegionFlds1.ColCaption;
			pobjExcelExportRegionFlds.FldId = wucExcelExportRegionFlds1.FldId;
		}

		protected void dgExcelExportRegionFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortExcelExportRegionFldsBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgExcelExportRegionFlds.Columns.Count;i++)
				{
					strSortEx = this.dgExcelExportRegionFlds.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortExcelExportRegionFldsBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortExcelExportRegionFldsBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgExcelExportRegionFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngmId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngmId = long.Parse(e.Item.Cells[1].Text);
				switch(strCommandName)
				{
					case "Delete":
						DeleteExcelExportRegionFldsRecord(lngmId);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdateExcelExportRegionFldsRecord(lngmId);
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
					Set_DataGridAllChecked(dgExcelExportRegionFlds, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgExcelExportRegionFlds, false);
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
			DispPrjTabFldsInfo();
			
		}

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombineExcelExportRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = null;
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ExcelExportRegionFlds信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("TabName"); arrCnName.Add("表名");
			arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("DataTypeId"); arrCnName.Add("字段类型");
			arrColName.Add("FldLength"); arrCnName.Add("字段长度");
			arrColName.Add("Caption"); arrCnName.Add("标题");
			arrColName.Add("IsNull"); arrCnName.Add("是否可空");
			arrColName.Add("IsTabPrimary"); arrCnName.Add("是否作为表中主键");
			arrColName.Add("SequenceNumber"); arrCnName.Add("顺序号");
			arrColName.Add("IsParentObj"); arrCnName.Add("是否父对象");
			arrColName.Add("PrimaryTypeName"); arrCnName.Add("主键类型名");
			arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
			arrColName.Add("RegionId"); arrCnName.Add("区域Id");
			arrColName.Add("IsTabNullable"); arrCnName.Add("是否表中可空");
			arrColName.Add("SeqNum"); arrCnName.Add("列序号");
			arrColName.Add("ColCaption"); arrCnName.Add("列标题");
			arrColName.Add("TabFldId"); arrCnName.Add("表字段ID");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            try
            {
                objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgExcelExportRegionFlds, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg1.Text = "";
			clsExcelExportRegionFldsBL.DelExcelExportRegionFldss(arrmId);
			BindDg_ExcelExportRegionFlds();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgExcelExportRegionFlds);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg1.Text = "";
			//1、显示该关键字记录的内容在界面上；
			long lngmId;
			lngmId = long.Parse(strmId);
			ShowData(lngmId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "确认修改";	
		}
		

		//生成父对象的SESSION相关属性函数
		protected void btnExcelExportRegionFldsPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgExcelExportRegionFlds.CurrentPageIndex -=1; 
			this.BindDg_ExcelExportRegionFlds(); 
		}

		protected void btnExcelExportRegionFldsNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgExcelExportRegionFlds.CurrentPageIndex +=1; 
			this.BindDg_ExcelExportRegionFlds(); 
		}

		protected void btnExcelExportRegionFldsJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtExcelExportRegionFldsJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtExcelExportRegionFldsJump2Page.Text)>0 && 
				int.Parse(this.txtExcelExportRegionFldsJump2Page.Text)-1<this.dgExcelExportRegionFlds.PageCount) 
			{ 
				this.dgExcelExportRegionFlds.CurrentPageIndex=int.Parse(this.txtExcelExportRegionFldsJump2Page.Text)-1; 
			} 
			this.BindDg_ExcelExportRegionFlds();
		}

		///生成的插入记录准备过程代码for C#
		private void AddExcelExportRegionFldsRecord()
		{
			btnOKUpd.Text = "确认添加";

		}
		///插入记录存盘过程代码for C#
		private void AddExcelExportRegionFldsRecordSave()
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
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1、检查控件中输入数据类型是否正确
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//定义对象
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL .CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///插入记录存盘过程代码for C#
		private void AddExcelExportRegionFldsRecordSaveV5()
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
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1、检查控件中输入数据类型是否正确
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//定义对象
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///生成修改记录准备过程代码 for C#
		private void UpdateExcelExportRegionFldsRecord(long lngmId)
		{
			//操作步骤：（总共2步）
			//1、显示该关键字记录的内容在界面上；
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；

			//1、显示该关键字记录的内容在界面上；
			ShowData(lngmId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "确认修改";
			lblMsg.Text = "";
		}
		///修改存盘准备过程代码 for C#
		private void UpdateExcelExportRegionFldsRecordSave(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
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
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			DispExcelExportRegionFldsInfo();
		}
		///修改存盘准备过程代码 for C#
		private void UpdateExcelExportRegionFldsRecordSaveV5(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
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
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
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
			BindDg_ExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///删除记录过程代码for C#
		private void DeleteExcelExportRegionFldsRecord(long lngmId)
		{
			clsExcelExportRegionFldsBL.DelRecord(lngmId);
			BindDg_ExcelExportRegionFlds();
		}

		protected void btnCopyFldFromRelaTab_Click(object sender, System.EventArgs e)
		{
			//操作步骤：
			//1、获取当前区域ID的相关主表ID；
			//2、获取相关主表ID的字段ID的对象列表;
			//2、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			
			try
			{
                clsExcelExportRegionFldsBLEx.ImportRelaFlds(RegionId, clsPubVar.CurrCmPrjId, UserId);
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "导入区域字段列表不成功!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}

			BindDg_ExcelExportRegionFlds();
			///恢复<确认添加>变成<添加>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('与界面相关的主表字段信息复制成功！！')</script>");

		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			if (BackViewRegionLinkStr !="")
			{
				Response.Redirect(BackViewRegionLinkStr);
			}
		}

		protected void dgExcelExportRegionFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortExcelExportRegionFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortExcelExportRegionFldsBy = e.SortExpression + " Asc";
				BindDg_ExcelExportRegionFlds();
				return ;
			}
			//检查原来是升序
			intIndex = strSortExcelExportRegionFldsBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortExcelExportRegionFldsBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortExcelExportRegionFldsBy = e.SortExpression + " Desc";
			}
			BindDg_ExcelExportRegionFlds();

		}
		private void DispExcelExportRegionFldsInfo()
		{
			tabExcelExportRegionFldsDataGrid.Visible = true;
			tabExcelExportRegionFldsJumpPage.Visible = true;
			tabEditExcelExportRegionFldsRegion.Visible = false;
			
			tabExcelExportRegionPreview.Visible = true;
			tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{			
			tabEditExcelExportRegionFldsRegion.Visible = false;
			tabExcelExportRegionFldsDataGrid.Visible = false;
			tabExcelExportRegionFldsJumpPage.Visible = false;
			tabExcelExportRegionPreview.Visible = false;
			tabCode.Visible = false;
		}
		private void DispEditExcelExportRegionFldsRegion()
		{
			tabExcelExportRegionFldsDataGrid.Visible = false;
			tabExcelExportRegionFldsJumpPage.Visible = false;
			tabEditExcelExportRegionFldsRegion.Visible = true;

			tabExcelExportRegionPreview.Visible = false;
			tabCode.Visible = false;
		}


		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgExcelExportRegionFlds);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg1.Text = "";

			long lngmId;
			lngmId = long.Parse(strmId);
			try
			{
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_ExcelExportRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgExcelExportRegionFlds, 1, strmId);

		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgExcelExportRegionFlds);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg1.Text = "";

			long lngmId;
			lngmId = long.Parse(strmId);
			try
			{
				
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_ExcelExportRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgExcelExportRegionFlds, 1, strmId);

		}

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsExcelExportRegionFldsBLEx.ReOrder(RegionId);
			BindDg_ExcelExportRegionFlds();
		}

		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            string strViewId = clsCommonSession.ViewId;// clsViewRegionBL.GetObjByRegionId(RegionId).ViewId;
			//			tabQuery1.Visible = false;
			tabCode.Visible = true;
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            
            //生成相关代码
            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

            try
            {

                clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
                clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
				WebViewCode4Html autoGC5Cs_VWeb = new WebViewCode4Html(strViewId);
				objViewInfoENEx.FolderName = "D:\\FTP\\ClsFile\\" + UserId + "\\";
                objViewInfoENEx.CurrUserName = clsCommonSession.UserName;
                ShowCode(autoGC5Cs_VWeb.GeneCode(ref strRe_ClsName, ref strRe_FileNameWithModuleName));
                if (objViewInfoENEx.FileName != null)
				{
					txtFileName4GenCode.Text = objViewInfoENEx.FileName;
					SimpleFName = clsString.GetSimpleFName_S(objViewInfoENEx.FileName);
				}
				//显示相关控件
				///
				if (WebViewCode4Html.DispExcelExportRegionCtrl(phExcelExportRegion, objViewInfoENEx) == true)
				{
					
				};
			}
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		private string strSortExcelExportRegionFldsBy
		{
			get
			{
				string sstrSortExcelExportRegionFldsBy;
				sstrSortExcelExportRegionFldsBy = (string)ViewState["strSortExcelExportRegionFldsBy"];
				if (sstrSortExcelExportRegionFldsBy==null) 
				{
					sstrSortExcelExportRegionFldsBy = "";
				}
				return sstrSortExcelExportRegionFldsBy;
			}
			set
			{
				string sstrSortExcelExportRegionFldsBy = value;
				ViewState.Add("strSortExcelExportRegionFldsBy", sstrSortExcelExportRegionFldsBy);
			}
		}
        protected void lbDownLoadFile_Click(object sender, EventArgs e)
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
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            litCode.Text = sbJs.ToString();
        }
    }
}