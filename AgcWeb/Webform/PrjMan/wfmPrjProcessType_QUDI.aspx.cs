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
using AGC.BusinessLogic;using AGC.FunClass;

namespace AGC.Webform
{
	/// <summary>
	/// wfmPrjProcessType_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmPrjProcessType_QUDI : System.Web.UI.Page
	{

		

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				//1、为下拉框设置数据源，绑定列表数据
				strSortPrjProcessTypeBy = "PrjProcessTypeId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_PrjProcessType();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucPrjProcessType1.SetKeyReadOnly(true);
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
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtPrjProcessTypeIdq.Text.Trim()!="")
			{
				strWhereCond += " And PrjProcessType.PrjProcessTypeId='" + this.txtPrjProcessTypeIdq.Text.Trim()+"'";
			}
			if (this.txtPrjProcessTypeNameq.Text.Trim()!="")
			{
				strWhereCond += " And PrjProcessType.PrjProcessTypeName='" + this.txtPrjProcessTypeNameq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_PrjProcessType()
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
			System.Data.DataTable objDT = clsPrjProcessTypeBL.GetDataTable_PrjProcessType(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjProcessType.PageSize);
			if (intPages==0) 
			{
				this.dgPrjProcessType.CurrentPageIndex = 0;
			}
			else if (this.dgPrjProcessType.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjProcessType.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortPrjProcessTypeBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgPrjProcessType.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgPrjProcessType.DataBind();

			
			//当前记录数
			this.lblPrjProcessTypeRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblPrjProcessTypeAllPages.Text = this.dgPrjProcessType.PageCount.ToString(); 
			//当前页序数
			this.lblPrjProcessTypeCurrentPage.Text=(this.dgPrjProcessType.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtPrjProcessTypeJump2Page.Text=(this.dgPrjProcessType.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgPrjProcessType.CurrentPageIndex==0) 
			{
				btnPrjProcessTypePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnPrjProcessTypePrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgPrjProcessType.CurrentPageIndex==this.dgPrjProcessType.PageCount-1) 
			{ 
				btnPrjProcessTypeNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnPrjProcessTypeNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabPrjProcessTypeJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabPrjProcessTypeJumpPage.Visible = false; 
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
			this.dgPrjProcessType.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_PrjProcessType();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgPrjProcessType_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgPrjProcessType.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_PrjProcessType();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strPrjProcessTypeId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strPrjProcessTypeId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strPrjProcessTypeId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsPrjProcessTypeBL.IsExist(strPrjProcessTypeId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strPrjProcessTypeId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsPrjProcessTypeEN objPrjProcessType = new clsPrjProcessTypeEN(strPrjProcessTypeId);
            //4、获取类对象的所有属性；
            clsPrjProcessTypeBL .GetPrjProcessType(ref objPrjProcessType);
			Session.Add("objPrjProcessType", objPrjProcessType);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromPrjProcessTypeClass(objPrjProcessType);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjPrjProcessType">表实体类对象</param>
		private void GetDataFromPrjProcessTypeClass(clsPrjProcessTypeEN pobjPrjProcessType)
		{
			wucPrjProcessType1.PrjProcessTypeId = pobjPrjProcessType.PrjProcessTypeId;
			wucPrjProcessType1.PrjProcessTypeName = pobjPrjProcessType.PrjProcessTypeName;
			wucPrjProcessType1.Memo = pobjPrjProcessType.Memo;
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
		
			string strCommandText;
			clsPrjProcessTypeEN objPrjProcessType;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucPrjProcessType1.SetKeyReadOnly(false);
					btnOKUpd.Text = "确认添加";
					wucPrjProcessType1.PrjProcessTypeId = clsPrjProcessTypeBL.GetMaxStrId_S();
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
					if (!wucPrjProcessType1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsPrjProcessTypeEN objPrjProcessType;	//定义对象
					objPrjProcessType = new clsPrjProcessTypeEN(wucPrjProcessType1.PrjProcessTypeId);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					if (clsPrjProcessTypeBL.IsExist(wucPrjProcessType1.PrjProcessTypeId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToPrjProcessTypeClass(objPrjProcessType);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsPrjProcessTypeBL .CheckPropertyNew(objPrjProcessType);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
					if (clsPrjProcessTypeBL .AddNewRecordBySql2(objPrjProcessType) == false) 
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
					BindDg_PrjProcessType();
					wucPrjProcessType1.Clear();		//清空控件中内容
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
					if (!wucPrjProcessType1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objPrjProcessType = (clsPrjProcessTypeEN) Session["objPrjProcessType"];
					PutDataToPrjProcessTypeClass(objPrjProcessType);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsPrjProcessTypeBL .CheckPropertyNew(objPrjProcessType);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsPrjProcessTypeBL .UpdateBySql2(objPrjProcessType) == false) 
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
					BindDg_PrjProcessType();
					wucPrjProcessType1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjPrjProcessType">数据传输的目的类对象</param>
		private void PutDataToPrjProcessTypeClass(clsPrjProcessTypeEN pobjPrjProcessType)
		{
			pobjPrjProcessType.PrjProcessTypeId = wucPrjProcessType1.PrjProcessTypeId;
			pobjPrjProcessType.PrjProcessTypeName = wucPrjProcessType1.PrjProcessTypeName;
			pobjPrjProcessType.Memo = wucPrjProcessType1.Memo;
		}

		protected void dgPrjProcessType_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortPrjProcessTypeBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgPrjProcessType.Columns.Count;i++)
				{
					strSortEx = this.dgPrjProcessType.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortPrjProcessTypeBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortPrjProcessTypeBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgPrjProcessType_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strPrjProcessTypeId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strPrjProcessTypeId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsPrjProcessTypeBL.DelRecord(strPrjProcessTypeId);
						BindDg_PrjProcessType();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strPrjProcessTypeId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucPrjProcessType1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
		
		protected void dgPrjProcessType_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortPrjProcessTypeBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortPrjProcessTypeBy = e.SortExpression + " Asc";
				BindDg_PrjProcessType();
				return ;
			}
			//检查原来是升序
			intIndex = strSortPrjProcessTypeBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortPrjProcessTypeBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortPrjProcessTypeBy = e.SortExpression + " Desc";
			}
			BindDg_PrjProcessType();
		}

		private string strSortPrjProcessTypeBy
		{
			get
			{
				string sSortPrjProcessTypeBy;
				sSortPrjProcessTypeBy = (string)ViewState["SortPrjProcessTypeBy"];
				if (sSortPrjProcessTypeBy==null) 
				{
					sSortPrjProcessTypeBy = "";
				}
				return sSortPrjProcessTypeBy;
			}
			set
			{
				string sSortPrjProcessTypeBy = value;
				ViewState.Add("SortPrjProcessTypeBy", sSortPrjProcessTypeBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnPrjProcessTypePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjProcessType.CurrentPageIndex -=1; 
			this.BindDg_PrjProcessType(); 
		}

		protected void btnPrjProcessTypeNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgPrjProcessType.CurrentPageIndex +=1; 
			this.BindDg_PrjProcessType(); 
		}

		protected void btnPrjProcessTypeJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtPrjProcessTypeJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtPrjProcessTypeJump2Page.Text)>0 && 
				int.Parse(this.txtPrjProcessTypeJump2Page.Text)-1<this.dgPrjProcessType.PageCount) 
			{ 
				this.dgPrjProcessType.CurrentPageIndex=int.Parse(this.txtPrjProcessTypeJump2Page.Text)-1; 
			} 
			this.BindDg_PrjProcessType();
		}


	}
}