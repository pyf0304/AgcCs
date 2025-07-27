
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

namespace AGC.Webform
{
	/// <summary>
	/// wfmTitleStyle_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmTitleStyle_QUDI : System.Web.UI.Page
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				//1、为下拉框设置数据源，绑定列表数据
				wucTitleStyle1.SetDdl_TitleTypeId();
				BindDdl_TitleTypeId(ddlTitleTypeIdq);
                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
				strSortBy = "TitleStyleId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_TitleStyle();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucTitleStyle1.SetKeyReadOnly(true);
			}
		}

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
		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 and PrjId='" + clsPubVar.CurrSelPrjId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtTitleStyleNameq.Text.Trim()!="")
			{
				strWhereCond += " And TitleStyleName='" + this.txtTitleStyleNameq.Text.Trim()+"'";
			}
			if (this.ddlTitleTypeIdq.SelectedValue!="" && this.ddlTitleTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And TitleTypeId='" + this.ddlTitleTypeIdq.SelectedValue+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_TitleStyle()
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
			System.Data.DataTable objDT = clsvTitleStyleBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgTitleStyle.PageSize);
			if (intPages==0) 
			{
				this.dgTitleStyle.CurrentPageIndex = 0;
			}
			else if (this.dgTitleStyle.CurrentPageIndex > intPages - 1) 
			{
				this.dgTitleStyle.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgTitleStyle.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgTitleStyle.DataBind();

			
			//当前记录数
			this.lblTitleStyleRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblTitleStyleAllPages.Text = this.dgTitleStyle.PageCount.ToString(); 
			//当前页序数
			this.lblTitleStyleCurrentPage.Text=(this.dgTitleStyle.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtTitleStyleJump2Page.Text=(this.dgTitleStyle.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgTitleStyle.CurrentPageIndex==0) 
			{
				btnTitleStylePrevPage.Enabled=false; 
			}
			else 
			{ 
				btnTitleStylePrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgTitleStyle.CurrentPageIndex==this.dgTitleStyle.PageCount-1) 
			{ 
				btnTitleStyleNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnTitleStyleNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabTitleStyleJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabTitleStyleJumpPage.Visible = false; 
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
			this.dgTitleStyle.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_TitleStyle();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgTitleStyle_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgTitleStyle.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_TitleStyle();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strTitleStyleId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strTitleStyleId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strTitleStyleId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsTitleStyleBL.IsExist(strTitleStyleId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strTitleStyleId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsTitleStyleEN objTitleStyle = new clsTitleStyleEN(strTitleStyleId);
            //4、获取类对象的所有属性；
            clsTitleStyleBL .GetTitleStyle(ref objTitleStyle);
			Session.Add("objTitleStyle", objTitleStyle);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromTitleStyleClass(objTitleStyle);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjTitleStyle">表实体类对象</param>
		private void GetDataFromTitleStyleClass(clsTitleStyleEN pobjTitleStyle)
		{
			wucTitleStyle1.TitleStyleId = pobjTitleStyle.TitleStyleId;
			wucTitleStyle1.TitleStyleName = pobjTitleStyle.TitleStyleName;
			wucTitleStyle1.ImgFile = pobjTitleStyle.ImgFile;
			wucTitleStyle1.TabHeight = pobjTitleStyle.TabHeight;
			wucTitleStyle1.TabWidth = pobjTitleStyle.TabWidth;
			wucTitleStyle1.TitleTypeId = pobjTitleStyle.TitleTypeId;
			wucTitleStyle1.BackColor = pobjTitleStyle.BackColor;
			wucTitleStyle1.ForeColor = pobjTitleStyle.ForeColor;
			wucTitleStyle1.FontSize = pobjTitleStyle.FontSize;
			wucTitleStyle1.FontName = pobjTitleStyle.FontName;
			wucTitleStyle1.PrjId = pobjTitleStyle.PrjId;
			wucTitleStyle1.IsDefault = pobjTitleStyle.IsDefault;

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
			clsTitleStyleEN objTitleStyle;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucTitleStyle1.SetKeyReadOnly(false);
					btnOKUpd.Text = "确认添加";
                    wucTitleStyle1.TitleStyleId = clsTitleStyleBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
                    wucTitleStyle1.PrjId = clsPubVar.CurrSelPrjId;
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
					if (!wucTitleStyle1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsTitleStyleEN objTitleStyle;	//定义对象
					objTitleStyle = new clsTitleStyleEN(wucTitleStyle1.TitleStyleId);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					if (clsTitleStyleBL.IsExist(wucTitleStyle1.TitleStyleId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToTitleStyleClass(objTitleStyle);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsTitleStyleBL .CheckPropertyNew(objTitleStyle);
                    }
                    catch(Exception objException)
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//6、把数据实体层的数据存贮到数据库中
					if (clsTitleStyleBL .AddNewRecordBySql2(objTitleStyle) == false) 
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
					BindDg_TitleStyle();
					wucTitleStyle1.Clear();		//清空控件中内容
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
					if (!wucTitleStyle1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objTitleStyle = (clsTitleStyleEN) Session["objTitleStyle"];
					PutDataToTitleStyleClass(objTitleStyle);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsTitleStyleBL.CheckPropertyNew(objTitleStyle);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsTitleStyleBL .UpdateBySql2(objTitleStyle) == false) 
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
					BindDg_TitleStyle();
					wucTitleStyle1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjTitleStyle">数据传输的目的类对象</param>
		private void PutDataToTitleStyleClass(clsTitleStyleEN pobjTitleStyle)
		{
			pobjTitleStyle.TitleStyleId = wucTitleStyle1.TitleStyleId;
			pobjTitleStyle.TitleStyleName = wucTitleStyle1.TitleStyleName;
			pobjTitleStyle.ImgFile = wucTitleStyle1.ImgFile;
			pobjTitleStyle.TabHeight = wucTitleStyle1.TabHeight;
			pobjTitleStyle.TabWidth = wucTitleStyle1.TabWidth;
			pobjTitleStyle.TitleTypeId = wucTitleStyle1.TitleTypeId;
			pobjTitleStyle.BackColor = wucTitleStyle1.BackColor;
			pobjTitleStyle.ForeColor = wucTitleStyle1.ForeColor;
			pobjTitleStyle.FontSize = wucTitleStyle1.FontSize;
			pobjTitleStyle.FontName = wucTitleStyle1.FontName;
			pobjTitleStyle.PrjId = wucTitleStyle1.PrjId;
			pobjTitleStyle.IsDefault = wucTitleStyle1.IsDefault;
		}

		protected void dgTitleStyle_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgTitleStyle.Columns.Count;i++)
				{
					strSortEx = this.dgTitleStyle.Columns[i].SortExpression;
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

		protected void dgTitleStyle_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strTitleStyleId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strTitleStyleId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsTitleStyleBL.DelRecord(strTitleStyleId);
						BindDg_TitleStyle();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strTitleStyleId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucTitleStyle1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
		public System.Data.DataTable GetTitleTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select TitleTypeId, TitleTypeName from TitleType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_TitleTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetTitleTypeId();
			objDDL.DataValueField="TitleTypeId";
			objDDL.DataTextField="TitleTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgTitleStyle_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_TitleStyle();
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
			BindDg_TitleStyle();
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

		
		protected void btnTitleStylePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgTitleStyle.CurrentPageIndex -=1; 
			this.BindDg_TitleStyle(); 
		}

		protected void btnTitleStyleNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgTitleStyle.CurrentPageIndex +=1; 
			this.BindDg_TitleStyle(); 
		}

		protected void btnTitleStyleJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtTitleStyleJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtTitleStyleJump2Page.Text)>0 && 
				int.Parse(this.txtTitleStyleJump2Page.Text)-1<this.dgTitleStyle.PageCount) 
			{ 
				this.dgTitleStyle.CurrentPageIndex=int.Parse(this.txtTitleStyleJump2Page.Text)-1; 
			} 
			this.BindDg_TitleStyle();
		}

		protected void btnCopyTitleStyle_Click(object sender, System.EventArgs e)
		{
			if (ddlPrjId.SelectedValue == "0") return ;
            clsTitleStyleBLEx.CopyTitleStyle(clsPubVar.CurrSelPrjId, ddlPrjId.SelectedValue);
		}
	}
}