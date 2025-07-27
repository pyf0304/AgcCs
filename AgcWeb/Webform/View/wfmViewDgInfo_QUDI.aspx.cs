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


using AGC.BusinessLogicEx;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;


using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewDgInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmViewDgInfo_QUDI : CommWebPageBase
    {

		

		//生成有关的变量定义代码
		private const string strViewId="00260203";		//界面编号


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
				wucViewDgInfo1.SetDdl_SqlDsTypeId();
                wucViewDgInfo1.SetDdl_SqlDsId(clsPubVar.CurrSelPrjId);
				wucViewDgInfo1.SetDdl_DgStyleId();
				BindDdl_SqlDsTypeId(ddlSqlDsTypeIdq);
                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlSqlDsIdq, clsPubVar.CurrSelPrjId);
				BindDdl_DgStyleId(ddlDgStyleIdq);
				strSortViewDgInfoBy = "ViewDgID Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_ViewDgInfo();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucViewDgInfo1.SetKeyReadOnly(true);
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
					//					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(strViewId);
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


		
		private string ViewId
		{
			get
			{
				string strViewId;
				strViewId = (string)Session["ViewId"];
				if (strViewId==null) 
				{
					strViewId = "";
				}
				return strViewId;
			}
			set
			{
				string strViewId = value;
				Session.Add("ViewId", strViewId);
			}
		}
		private string DgStyleId
		{
			get
			{
				string strDgStyleId;
				strDgStyleId = (string)Session["DgStyleId"];
				if (strDgStyleId==null) 
				{
					strDgStyleId = "";
				}
				return strDgStyleId;
			}
			set
			{
				string strDgStyleId = value;
				Session.Add("DgStyleId", strDgStyleId);
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
			if (this.txtViewDgNameq.Text.Trim()!="")
			{
				strWhereCond += " And ViewDgInfo.ViewDgName like '%" + this.txtViewDgNameq.Text.Trim()+"%'";
			}
			if (this.ddlSqlDsTypeIdq.SelectedValue!="" && this.ddlSqlDsTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And ViewDgInfo.SqlDsTypeId='" + this.ddlSqlDsTypeIdq.SelectedValue+"'";
			}
			if (this.ddlSqlDsIdq.SelectedValue!="" && this.ddlSqlDsIdq.SelectedValue!="0")
			{
				strWhereCond += " And ViewDgInfo.SqlDsId='" + this.ddlSqlDsIdq.SelectedValue+"'";
			}
			if (this.ddlDgStyleIdq.SelectedValue!="" && this.ddlDgStyleIdq.SelectedValue!="0")
			{
				strWhereCond += " And ViewDgInfo.DgStyleId='" + this.ddlDgStyleIdq.SelectedValue+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_ViewDgInfo()
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
			System.Data.DataTable objDT = clsViewDgInfoBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewDgInfo.PageSize);
			if (intPages==0) 
			{
				this.dgViewDgInfo.CurrentPageIndex = 0;
			}
			else if (this.dgViewDgInfo.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewDgInfo.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewDgInfoBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgViewDgInfo.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewDgInfo.DataBind();

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
			this.dgViewDgInfo.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_ViewDgInfo();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewDgInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgViewDgInfo.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ViewDgInfo();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strViewDgID">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strViewDgID)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strViewDgID == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsViewDgInfoBL.IsExist(strViewDgID) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strViewDgID + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsViewDgInfoEN objViewDgInfo = new clsViewDgInfoEN(strViewDgID);
            //4、获取类对象的所有属性；
            clsViewDgInfoBL .GetViewDgInfo(ref objViewDgInfo);
			Session.Add("objViewDgInfo", objViewDgInfo);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromViewDgInfoClass(objViewDgInfo);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjViewDgInfo">表实体类对象</param>
		private void GetDataFromViewDgInfoClass(clsViewDgInfoEN pobjViewDgInfo)
		{
			wucViewDgInfo1.ViewDgID = pobjViewDgInfo.ViewDgID;
			wucViewDgInfo1.ViewDgName = pobjViewDgInfo.ViewDgName;
			wucViewDgInfo1.ViewId = pobjViewDgInfo.ViewId;
			wucViewDgInfo1.SqlDsTypeId = pobjViewDgInfo.SqlDsTypeId;
			wucViewDgInfo1.SqlDsId = pobjViewDgInfo.SqlDsId;
			wucViewDgInfo1.DgStyleId = pobjViewDgInfo.DgStyleId;
			wucViewDgInfo1.Width = pobjViewDgInfo.Width ?? 0;
			wucViewDgInfo1.Height = pobjViewDgInfo.Height ?? 0;
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
			clsViewDgInfoEN objViewDgInfo;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucViewDgInfo1.SetKeyReadOnly(false);
					btnOKUpd.Text = "确认添加";
					wucViewDgInfo1.ViewDgID = clsViewDgInfoBL.GetMaxStrIdByPrefix_S(ViewId);
					wucViewDgInfo1.ViewId = ViewId;
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
					if (!wucViewDgInfo1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsViewDgInfoEN objViewDgInfo;	//定义对象
					objViewDgInfo = new clsViewDgInfoEN(wucViewDgInfo1.ViewDgID);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					if (clsViewDgInfoBL.IsExist(wucViewDgInfo1.ViewDgID))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToViewDgInfoClass(objViewDgInfo);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
					
                    try
                    {
                        clsViewDgInfoBL .CheckPropertyNew(objViewDgInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
					if (clsViewDgInfoBL .AddNewRecordBySql2(objViewDgInfo) == false) 
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
					BindDg_ViewDgInfo();
					wucViewDgInfo1.Clear();		//清空控件中内容
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
					if (!wucViewDgInfo1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objViewDgInfo = (clsViewDgInfoEN) Session["objViewDgInfo"];
					PutDataToViewDgInfoClass(objViewDgInfo);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
					

                    try
                    {
                        clsViewDgInfoBL.CheckPropertyNew(objViewDgInfo);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsViewDgInfoBL .UpdateBySql2(objViewDgInfo) == false) 
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
					BindDg_ViewDgInfo();
					wucViewDgInfo1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjViewDgInfo">数据传输的目的类对象</param>
		private void PutDataToViewDgInfoClass(clsViewDgInfoEN pobjViewDgInfo)
		{
			pobjViewDgInfo.ViewDgID = wucViewDgInfo1.ViewDgID;
			pobjViewDgInfo.ViewDgName = wucViewDgInfo1.ViewDgName;
			pobjViewDgInfo.ViewId = wucViewDgInfo1.ViewId;
			pobjViewDgInfo.SqlDsTypeId = wucViewDgInfo1.SqlDsTypeId;
			pobjViewDgInfo.SqlDsId = wucViewDgInfo1.SqlDsId;
			pobjViewDgInfo.DgStyleId = wucViewDgInfo1.DgStyleId;
			pobjViewDgInfo.Width = wucViewDgInfo1.Width;
			pobjViewDgInfo.Height = wucViewDgInfo1.Height;
		}

		protected void dgViewDgInfo_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewDgInfoBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgViewDgInfo.Columns.Count;i++)
				{
					strSortEx = this.dgViewDgInfo.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewDgInfoBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortViewDgInfoBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgViewDgInfo_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strViewDgID;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strViewDgID = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsViewDgInfoBL.DelRecord(strViewDgID);
						BindDg_ViewDgInfo();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strViewDgID);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucViewDgInfo1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		
		public System.Data.DataTable GetSqlDsTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select SqlDsTypeId, SqlDsTypeName from SQLDSType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_SqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetSqlDsTypeId();
			objDDL.DataValueField="SqlDsTypeId";
			objDDL.DataTextField="SqlDsTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		public System.Data.DataTable GetDgStyleId()
		{
			//获取某学院所有专业信息
			string strSQL = "select DgStyleId, DgStyleName from DataGridStyle ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_DgStyleId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetDgStyleId();
			objDDL.DataValueField="DgStyleId";
			objDDL.DataTextField="DgStyleName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgViewDgInfo_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortViewDgInfoBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewDgInfoBy = e.SortExpression + " Asc";
				BindDg_ViewDgInfo();
				return ;
			}
			//检查原来是升序
			intIndex = strSortViewDgInfoBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortViewDgInfoBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortViewDgInfoBy = e.SortExpression + " Desc";
			}
			BindDg_ViewDgInfo();
		}

		private string strSortViewDgInfoBy
		{
			get
			{
				string sSortViewDgInfoBy;
				sSortViewDgInfoBy = (string)ViewState["SortViewDgInfoBy"];
				if (sSortViewDgInfoBy==null) 
				{
					sSortViewDgInfoBy = "";
				}
				return sSortViewDgInfoBy;
			}
			set
			{
				string sSortViewDgInfoBy = value;
				ViewState.Add("SortViewDgInfoBy", sSortViewDgInfoBy);
			}
		}


		protected void lbAddViewDgFld_Click(object sender, System.EventArgs e)
		{
//			tabQueryTabFld.Visible = true;
//			tabLayout.Visible = false;
//			tabFldList.Visible = false;
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
    }
}