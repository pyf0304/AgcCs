
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using CommFunc4WebForm;


using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.datetime;

using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewGroupFlds_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmViewGroupFlds_QUDI : CommWebPageBase
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
				if (ViewGroupId != "")
				{
					lblViewGroupName.Text = clsViewGroupBL.GetObjByViewGroupId(ViewGroupId).ViewGroupName;
				}
				divJspRelaView.Visible = false;
				//1、为下拉框设置数据源，绑定列表数据
				wucViewGroupFlds1.SetDdl_ViewGroupId();
				wucViewGroupFlds1.SetDdl_CtlTypeId(false);
				wucViewGroupFlds1.SetDdl_DdlItemsOptionId();
				wucViewGroupFlds1.SetDdl_Ds_DataTextFieldId(clsPubVar.CurrSelPrjId);
				wucViewGroupFlds1.SetDdl_Ds_DataValueFieldId(clsPubVar.CurrSelPrjId);
				wucViewGroupFlds1.SetDdl_Ds_TabId(clsPubVar.CurrSelPrjId);
                clsCtlTypeAbbrBLEx.BindDdl_CtlTypeId_CacheEx(ddlCtlTypeId_q);
				strSortViewGroupFldsBy = "mId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_ViewGroupFlds();
				BindDg_ViewInfo();
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

		
		private string ViewGroupId
		{
			get
			{
				string strViewGroupId;
				strViewGroupId = (string)Session["ViewGroupId"];
				if (strViewGroupId==null) 
				{
					strViewGroupId = "";
				}
				return strViewGroupId;
			}
			set
			{
				string strViewGroupId = value;
				Session.Add("ViewGroupId", strViewGroupId);
			}
		}

		
		private string BackErrPageLinkStr
		{
			get
			{
				string strListViewRegion;
				strListViewRegion = (string)Session["ListViewRegion"];
				if (strListViewRegion==null) 
				{
					strListViewRegion = "";
				}
				return strListViewRegion;
			}
			set
			{
				string strListViewRegion = value;
				Session.Add("ListViewRegion", strListViewRegion);
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
		private string CombineViewGroupFldsCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 and ViewGroupId = '" + ViewGroupId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.ddlCtlTypeId_q.SelectedValue!="" && this.ddlCtlTypeId_q.SelectedValue!="0")
			{
				strWhereCond += " And ViewGroupFlds.CtlTypeId='" + this.ddlCtlTypeId_q.SelectedValue+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_ViewGroupFlds()
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
			string strWhereCond = CombineViewGroupFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvViewGroupFldsBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewGroupFlds.PageSize);
			if (intPages==0) 
			{
				this.dgViewGroupFlds.CurrentPageIndex = 0;
			}
			else if (this.dgViewGroupFlds.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewGroupFlds.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewGroupFldsBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgViewGroupFlds.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewGroupFlds.DataBind();

			
			//当前记录数
			this.lblViewGroupFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblViewGroupFldsAllPages.Text = this.dgViewGroupFlds.PageCount.ToString(); 
			//当前页序数
			this.lblViewGroupFldsCurrentPage.Text=(this.dgViewGroupFlds.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtViewGroupFldsJump2Page.Text=(this.dgViewGroupFlds.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgViewGroupFlds.CurrentPageIndex==0) 
			{
				btnViewGroupFldsPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnViewGroupFldsPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgViewGroupFlds.CurrentPageIndex==this.dgViewGroupFlds.PageCount-1) 
			{ 
				btnViewGroupFldsNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnViewGroupFldsNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabViewGroupFldsJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabViewGroupFldsJumpPage.Visible = false; 
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
			this.dgViewGroupFlds.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_ViewGroupFlds();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewGroupFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgViewGroupFlds.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ViewGroupFlds();
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
			if (clsViewGroupFldsBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngmId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsViewGroupFldsEN objViewGroupFlds = new clsViewGroupFldsEN(lngmId);
            //4、获取类对象的所有属性；
            clsViewGroupFldsBL .GetViewGroupFlds(ref objViewGroupFlds);
			Session.Add("objViewGroupFlds", objViewGroupFlds);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromViewGroupFldsClass(objViewGroupFlds);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjViewGroupFlds">表实体类对象</param>
		private void GetDataFromViewGroupFldsClass(clsViewGroupFldsEN pobjViewGroupFlds)
		{
			wucViewGroupFlds1.ViewGroupId = pobjViewGroupFlds.ViewGroupId;
			wucViewGroupFlds1.TabFldId = pobjViewGroupFlds.TabFldId;
			wucViewGroupFlds1.CtlTypeId = pobjViewGroupFlds.CtlTypeId;
			wucViewGroupFlds1.DdlItemsOptionId = pobjViewGroupFlds.DdlItemsOptionId;
			wucViewGroupFlds1.Ds_CondStr = pobjViewGroupFlds.Ds_CondStr;
			wucViewGroupFlds1.Ds_DataTextFieldId = pobjViewGroupFlds.Ds_DataTextFieldId;
			wucViewGroupFlds1.Ds_DataValueFieldId = pobjViewGroupFlds.Ds_DataValueFieldId;
			wucViewGroupFlds1.Ds_SQLStr = pobjViewGroupFlds.Ds_SQLStr;
			wucViewGroupFlds1.Ds_TabId = pobjViewGroupFlds.Ds_TabId;
			wucViewGroupFlds1.ItemsString = pobjViewGroupFlds.ItemsString;
			wucViewGroupFlds1.SeqNum = pobjViewGroupFlds.SeqNum;
			wucViewGroupFlds1.Memo = pobjViewGroupFlds.Memo;
		}
		/// <summary>
		/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
		///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			string strCommandText;
			clsViewGroupFldsEN objViewGroupFlds;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					btnOKUpd.Text = "确认添加";
					
					break;				
				case "确认添加":
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
					if (!wucViewGroupFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsViewGroupFldsEN objViewGroupFlds;	//定义对象
					objViewGroupFlds = new clsViewGroupFldsEN();	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToViewGroupFldsClass(objViewGroupFlds);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
				
                    try
                    {
                        clsViewGroupFldsBL .CheckPropertyNew(objViewGroupFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
					if (clsViewGroupFldsBL .AddNewRecordBySql2(objViewGroupFlds) == false) 
					{
						strMsg = "添加不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "添加记录不成功!";
					}
					else
					{
						strMsg = "添加记录成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "添加记录成功!";
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindDg_ViewGroupFlds();
					wucViewGroupFlds1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					//操作步骤：
					//1、检查控件中输入数据类型是否正确
					//2、把值从界面层传到逻辑层或数据实体层
					//3、检查传进去的对象属性是否合法
					//4、把数据实体层的数据存贮到数据库中
					//5、把修改后的内容显示在DATAGRID中
					//1、检查控件中输入数据类型是否正确
					if (!wucViewGroupFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objViewGroupFlds = (clsViewGroupFldsEN) Session["objViewGroupFlds"];
					PutDataToViewGroupFldsClass(objViewGroupFlds);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
					

                    try
                    {
                        clsViewGroupFldsBL.CheckPropertyNew(objViewGroupFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsViewGroupFldsBL .UpdateBySql2(objViewGroupFlds) == false) 
					{
						strMsg = "修改记录不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "修改记录不成功!";
					}
					else
					{
						strMsg = "修改记录成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "修改记录成功!";
					}
					//5、把修改后的内容显示在DATAGRID中
					BindDg_ViewGroupFlds();
					wucViewGroupFlds1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjViewGroupFlds">数据传输的目的类对象</param>
		private void PutDataToViewGroupFldsClass(clsViewGroupFldsEN pobjViewGroupFlds)
		{
			pobjViewGroupFlds.ViewGroupId = wucViewGroupFlds1.ViewGroupId;
			pobjViewGroupFlds.TabFldId = wucViewGroupFlds1.TabFldId;
			pobjViewGroupFlds.CtlTypeId = wucViewGroupFlds1.CtlTypeId;
			pobjViewGroupFlds.DdlItemsOptionId = wucViewGroupFlds1.DdlItemsOptionId;
			pobjViewGroupFlds.Ds_CondStr = wucViewGroupFlds1.Ds_CondStr;
			pobjViewGroupFlds.Ds_DataTextFieldId = wucViewGroupFlds1.Ds_DataTextFieldId;
			pobjViewGroupFlds.Ds_DataValueFieldId = wucViewGroupFlds1.Ds_DataValueFieldId;
			pobjViewGroupFlds.Ds_SQLStr = wucViewGroupFlds1.Ds_SQLStr;
			pobjViewGroupFlds.Ds_TabId = wucViewGroupFlds1.Ds_TabId;
			pobjViewGroupFlds.ItemsString = wucViewGroupFlds1.ItemsString;
			pobjViewGroupFlds.SeqNum = wucViewGroupFlds1.SeqNum;
			pobjViewGroupFlds.Memo = wucViewGroupFlds1.Memo;
		}

		protected void dgViewGroupFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewGroupFldsBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgViewGroupFlds.Columns.Count;i++)
				{
					strSortEx = this.dgViewGroupFlds.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewGroupFldsBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortViewGroupFldsBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgViewGroupFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
						clsViewGroupFldsBL.DelRecord(lngmId);
						BindDg_ViewGroupFlds();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(lngmId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
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
					Set_DataGridAllChecked(dgViewGroupFlds, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgViewGroupFlds, false);
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
			btnOKUpd.Text = "确认添加";

		}

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombineViewGroupFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsViewGroupFldsBL.GetDataTable_ViewGroupFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewGroupFlds信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("ViewGroupId"); arrCnName.Add("界面组ID");
			arrColName.Add("TabFldId"); arrCnName.Add("表字段ID");
			arrColName.Add("CtlTypeId"); arrCnName.Add("控件类型号");
			arrColName.Add("DdlItemsOptionId"); arrCnName.Add("下拉框列表选项ID");
			arrColName.Add("Ds_CondStr"); arrCnName.Add("数据源条件串");
			arrColName.Add("Ds_DataTextFieldId"); arrCnName.Add("数据源文本字段Id");
			arrColName.Add("Ds_DataValueFieldId"); arrCnName.Add("数据源值字段Id");
			arrColName.Add("Ds_SQLStr"); arrCnName.Add("数据源SQL串");
			arrColName.Add("Ds_TabId"); arrCnName.Add("数据源表ID");
			arrColName.Add("ItemsString"); arrCnName.Add("列表项串");
			arrColName.Add("SeqNum"); arrCnName.Add("字段序号");
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

		
		//当前记录数
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgViewGroupFlds, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			clsViewGroupFldsBL.DelViewGroupFldss(arrmId);
			BindDg_ViewGroupFlds();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewGroupFlds);
			long lngmId;
			lngmId = long.Parse(strmId);
			if (strmId == null || strmId.Trim().Length == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			ShowData(lngmId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "确认修改";	
		}
		
		public System.Data.DataTable GetViewGroupId()
		{
			//获取某学院所有专业信息
			string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetViewGroupId();
			objDDL.DataValueField="ViewGroupId";
			objDDL.DataTextField="ViewGroupName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		
		
		public System.Data.DataTable GetUserId()
		{
			//获取某学院所有专业信息
			string strSQL = "select UserId, UserName from Users ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetUserId();
			objDDL.DataValueField="UserId";
			objDDL.DataTextField="UserName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgViewGroupFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortViewGroupFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewGroupFldsBy = e.SortExpression + " Asc";
				BindDg_ViewGroupFlds();
				return ;
			}
			//检查原来是升序
			intIndex = strSortViewGroupFldsBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortViewGroupFldsBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortViewGroupFldsBy = e.SortExpression + " Desc";
			}
			BindDg_ViewGroupFlds();
		}

		private string strSortViewGroupFldsBy
		{
			get
			{
				string sSortViewGroupFldsBy;
				sSortViewGroupFldsBy = (string)ViewState["SortViewGroupFldsBy"];
				if (sSortViewGroupFldsBy==null) 
				{
					sSortViewGroupFldsBy = "";
				}
				return sSortViewGroupFldsBy;
			}
			set
			{
				string sSortViewGroupFldsBy = value;
				ViewState.Add("SortViewGroupFldsBy", sSortViewGroupFldsBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnViewGroupFldsPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewGroupFlds.CurrentPageIndex -=1; 
			this.BindDg_ViewGroupFlds(); 
		}

		protected void btnViewGroupFldsNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewGroupFlds.CurrentPageIndex +=1; 
			this.BindDg_ViewGroupFlds(); 
		}

		protected void btnViewGroupFldsJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtViewGroupFldsJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtViewGroupFldsJump2Page.Text)>0 && 
				int.Parse(this.txtViewGroupFldsJump2Page.Text)-1<this.dgViewGroupFlds.PageCount) 
			{ 
				this.dgViewGroupFlds.CurrentPageIndex=int.Parse(this.txtViewGroupFldsJump2Page.Text)-1; 
			} 
			this.BindDg_ViewGroupFlds();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackErrPageLinkStr);
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
			StringBuilder sbWhereCond = new StringBuilder();
			sbWhereCond.Append("RegionId in (");
			sbWhereCond.Append("select RegionId from viewregion where regiontypeid = '0003' ");
			sbWhereCond.AppendFormat("and viewid in (select viewid from viewinfo where viewgroupid = '{0}'))",
				ViewGroupId);
			//初始化添加界面编辑区域字段列表
			clsViewGroupFldsEN objViewGroupFlds = new clsViewGroupFldsEN();
            List<clsEditRegionFldsEN> arrEditRegionFldSet_AddorUpdate = 
				 clsEditRegionFldsBL.GetObjLst(sbWhereCond.ToString());
			foreach(clsEditRegionFldsEN objEditRegionFlds in arrEditRegionFldSet_AddorUpdate)
			{
				objViewGroupFlds.ViewGroupId = ViewGroupId;
				//objViewGroupFlds.FldId = objEditRegionFlds.FldId;
				objViewGroupFlds.CtlTypeId = objEditRegionFlds.CtlTypeId;
				objViewGroupFlds.DdlItemsOptionId = objEditRegionFlds.DdlItemsOptionId;
				objViewGroupFlds.Ds_CondStr = objEditRegionFlds.Ds_CondStr;
				objViewGroupFlds.Ds_DataTextFieldId = objEditRegionFlds.Ds_DataTextFieldId;
				objViewGroupFlds.Ds_DataValueFieldId = objEditRegionFlds.Ds_DataValueFieldId;
				objViewGroupFlds.Ds_SQLStr = objEditRegionFlds.Ds_SQLStr;
				objViewGroupFlds.Ds_TabId = objEditRegionFlds.Ds_TabId;
				objViewGroupFlds.ItemsString = objEditRegionFlds.ItemsString;
				objViewGroupFlds.SeqNum = objEditRegionFlds.SeqNum;
				objViewGroupFlds.Memo = objEditRegionFlds.Memo;
				objViewGroupFlds.UserId = UserId;
				objViewGroupFlds.UpdDate = clsDateTime.getTodayStr(0);
                if (clsViewGroupFldsBL.IsExistRecord("ViewGroupId = '" + ViewGroupId + "' and TabFldId = " + objViewGroupFlds.TabFldId + " and CtlTypeId = '" + objViewGroupFlds.CtlTypeId + "'") == false)
				{
                    clsViewGroupFldsBL .AddNewRecordBySql2(objViewGroupFlds);
				}
			}
			BindDg_ViewGroupFlds();
			Response.Write("<script>alert('与界面相关的编辑区域字段信息复制成功！！')</script>");

		}

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
			string strWhereCond = "ViewGroupId = '" + ViewGroupId + "'";
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvViewInfoBL.GetDataTable(strWhereCond);
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
			//			objDV.Sort = strSortBy;
			this.dgViewInfo.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewInfo.DataBind();
		}

		protected void btnAddRelaJspView_Click(object sender, System.EventArgs e)
		{
			divJspRelaView.Visible = true;
		}
		private void CopyCommInfoFromGroupToView(clsViewGroupEN objViewGroupEN, clsViewInfoEN objViewInfo)
		{
            objViewInfo.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
			objViewInfo.UserId = UserId;
            objViewInfo.PrjId = clsPubVar.CurrSelPrjId;
            objViewInfo.DataBaseName = new clsCommonSession().PrjDataBaseName;
			objViewInfo.FilePath = "webform/";
//			objViewInfo.ViewName = txtFileName_Add.Text;
//			objViewInfo.ViewCnName = getRelaTabCnName() + "添加";
//			objViewInfo.FileName = txtFileName_Add.Text + ".jsp";
//			objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
//			objViewInfo.ApplicationTypeId = clsApplicationTypeBLEx.JAVAWEBAPP;
			objViewInfo.ViewGroupId = objViewGroupEN.ViewGroupId;
//			objViewInfo.ViewTypeCode = clsViewTypeCodeTabBLEx.JAVA_ADD;
            objViewInfo.FuncModuleAgcId =  clsFuncModule_AgcBL.GetFirstID_S("PrjId = '" + clsPubVar.CurrSelPrjId + "'");
            objViewInfo.DataBaseName = new clsCommonSession().PrjDataBaseName;
			objViewInfo.MainTabId = getRelaTabId();
			objViewInfo.DetailTabId = "";
			objViewInfo.KeyForMainTab = "";
			objViewInfo.KeyForDetailTab = "";
			objViewInfo.IsNeedSort = true;
			objViewInfo.IsNeedTransCode = true;
			objViewInfo.ViewFunction = "";
			objViewInfo.ViewDetail = "";
			objViewInfo.OutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId;
			objViewInfo.OutRelaTabId = objViewGroupEN.OutRelaTabId;
			objViewInfo.InSqlDsTypeId = objViewGroupEN.InSqlDsTypeId;
			objViewInfo.InRelaTabId = objViewGroupEN.InRelaTabId;
		}
		protected void btnStartGene_Click(object sender, System.EventArgs e)
		{
			StringBuilder sbWhereCond = new StringBuilder();
			clsViewInfoEN objViewInfo = new clsViewInfoEN();
			clsViewGroupEN objViewGroupEN = clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
			//如果选择添加界面
			if (chkJsp_Add.Checked == true && txtFileName_Add.Text.Trim() != "")
			{
				//检查界面名称是否存在
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Add.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "在该界面组存在相同的<添加>界面名称!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Add.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "添加";
				objViewInfo.FileName = txtFileName_Add.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_ADD;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);
                ///添加区域及区域字段，该函数是ViewInfo的相关函数，
                ///有三个参数：1、视图ID(ViewId)
                ///				2、区域类型()
                ///				3、数据源类型ID
                ///				4、数据源表ID()
                ///		

                clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId,
                    clsRegionTypeENEx.EDITREGION,
                    objViewGroupEN.InSqlDsTypeId,
                    objViewGroupEN.InRelaTabId, clsCommonSession.UserId);

			}
			//修改界面
			if (chkJsp_Update.Checked == true && txtFileName_Update.Text.Trim() != "")
			{
				//检查界面名称是否存在
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Update.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "在该界面组存在相同的<修改>界面名称!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Update.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "修改";
				objViewInfo.FileName = txtFileName_Update.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_UPDATE;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);

				///添加区域及区域字段，该函数是ViewInfo的相关函数，
				///有三个参数：1、视图ID(ViewId)
				///				2、区域类型()
				///				3、数据源类型ID
				///				4、数据源表ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.EDITREGION, 
					objViewGroupEN.InSqlDsTypeId, 
					objViewGroupEN.InRelaTabId, clsCommonSession.UserId);

			}
			//详细信息界面
			if (chkJsp_Detail.Checked == true && txtFileName_Detail.Text.Trim() != "")
			{
				//检查界面名称是否存在
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Detail.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "在该界面组存在相同的<详细信息>界面名称!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Detail.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "详细信息";
				objViewInfo.FileName = txtFileName_Detail.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName;
                objViewInfo.ApplicationTypeId = (int) clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_DETAIL;
                clsViewInfoBL .AddNewRecordBySql2(objViewInfo);
				///添加区域及区域字段，该函数是ViewInfo的相关函数，
				///有三个参数：1、视图ID(ViewId)
				///				2、区域类型()
				///				3、数据源类型ID
				///				4、数据源表ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.DETAILREGION, 
					objViewGroupEN.OutSqlDsTypeId, 
					objViewGroupEN.OutRelaTabId, clsCommonSession.UserId);

			}
			//列表界面
			if (chkJsp_List.Checked == true && txtFileName_List.Text.Trim() != "")
			{
				//检查界面名称是否存在
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_List.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "在该界面组存在相同的<列表>界面名称!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_List.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "列表";
				objViewInfo.FileName = txtFileName_List.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_LIST;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);

				///添加区域及区域字段，该函数是ViewInfo的相关函数，
				///有三个参数：1、视图ID(ViewId)
				///				2、区域类型()
				///				3、数据源类型ID
				///				4、数据源表ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.DGREGION, 
					objViewGroupEN.OutSqlDsTypeId, 
					objViewGroupEN.OutRelaTabId, clsCommonSession.UserId);

			}
			//查询界面
			if (chkJsp_Query.Checked == true && txtFileName_Query.Text.Trim() != "")
			{
				//检查界面名称是否存在
				sbWhereCond = new StringBuilder();
				sbWhereCond.AppendFormat("ViewGroupId = '{0}' and ViewName = '{1}'",
					ViewGroupId,
					txtFileName_Query.Text);

				if (clsViewInfoBL.IsExistRecord(sbWhereCond.ToString()))
				{
					lblMsg2.Text = "在该界面组存在相同的<查询>界面名称!";
					return ;
				}
				CopyCommInfoFromGroupToView(objViewGroupEN, objViewInfo);
				objViewInfo.ViewName = txtFileName_Query.Text;
				objViewInfo.ViewCnName = getRelaTabCnName() + "查询";
				objViewInfo.FileName = txtFileName_Query.Text + ".jsp";
				objViewInfo.DefaMenuName = objViewInfo.ViewCnName; 
				objViewInfo.ApplicationTypeId = (int)clsApplicationTypeBLEx.JAVAWEBAPP;
				objViewInfo.ViewTypeCode = (int)clsViewTypeCodeTabBLEx.JAVA_QUERY;
				clsViewInfoBL .AddNewRecordBySql2(objViewInfo);
				///添加区域及区域字段，该函数是ViewInfo的相关函数，
				///有三个参数：1、视图ID(ViewId)
				///				2、区域类型()
				///				3、数据源类型ID
				///				4、数据源表ID()
				///		
				
				clsViewInfoBLEx.ImportRegionAndFlds(objViewInfo.ViewId, 
					clsRegionTypeENEx.QUERYREGION, 
					objViewGroupEN.InSqlDsTypeId, 
					objViewGroupEN.InRelaTabId, clsCommonSession.UserId);

			}
			BindDg_ViewInfo();
			divJspRelaView.Visible = false;
		}

		protected void chkJsp_Add_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Add.Checked == true)
			{
                string strRelaTabName = getRelaTabName();
                if (string.IsNullOrEmpty(strRelaTabName) == false)
                {
                    txtFileName_Add.Text = strRelaTabName + "_add";
                }
			}
		}
		private string getRelaTabName()
		{
			clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
            try
            {
                clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupENEx);;
            }
            catch (Exception objException)
            {
                lblMsg2.Text = objException.Message;
                return "";
            }
			if (objViewGroupENEx.objINPrjTab != null)
			{
				return objViewGroupENEx.objINPrjTab.TabName;
			}
			else
			{
				return objViewGroupENEx.objOUTPrjTab.TabName;
			}	
		}
		private string getRelaTabCnName()
		{
			clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
            clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupENEx);
			if (objViewGroupENEx.objINPrjTab != null)
			{
				return objViewGroupENEx.objINPrjTab.TabCnName;
			}
			else
			{
				return objViewGroupENEx.objOUTPrjTab.TabCnName;
			}	
		}
		private string getRelaTabId()
		{
            clsViewGroupENEx objViewGroupENEx = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
			clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupENEx);;
			if (objViewGroupENEx.objINPrjTab != null)
			{
				return objViewGroupENEx.objINPrjTab.TabId;
			}
			else
			{
				return objViewGroupENEx.objOUTPrjTab.TabId;
			}	
		}

		protected void chkJsp_Update_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Update.Checked == true)
			{
				txtFileName_Update.Text = getRelaTabName() + "_update";
			}
		
		}

		protected void chkJsp_Query_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Query.Checked == true)
			{
				txtFileName_Query.Text = getRelaTabName() + "_query";
			}
		}

		protected void chkJsp_Detail_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_Detail.Checked == true)
			{
				txtFileName_Detail.Text = getRelaTabName() + "_detail";
			}
		}

		protected void chkJsp_List_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJsp_List.Checked == true)
			{
				txtFileName_List.Text = getRelaTabName() + "_list";
			}
		}

		protected void btnCloseDiv_Click(object sender, System.EventArgs e)
		{
			divJspRelaView.Visible = false;
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