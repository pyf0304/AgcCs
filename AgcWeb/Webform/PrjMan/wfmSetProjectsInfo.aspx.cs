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
//using SqlSv; 
using com.taishsoft.commdb;
using CommFunc4WebForm;

using com.taishsoft.common;

using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.datetime;
using System.Collections.Generic;

namespace AGC.Webform
{
	/// <summary>
	/// wfmProjects_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmSetProjectsInfo : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			clsUsersEN objUsers;
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				objUsers = (clsUsersEN)Session["objUser"];
				if (objUsers == null) 
				{
					ReturnLoginView();
					return ;
				}
				if (objUsers.RoleId != "0001")	//一般用户，那么仅仅显示当前用户的工程
				{
					txtUserIDq.Text = objUsers.UserId;
					txtUserIDq.ReadOnly = true;
				}
				//1、为下拉框设置数据源，绑定列表数据
				//2、显示无条件的表内容在DATAGRID中
				strSortBy = "PrjName Asc";
				BindDg_Projects();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucProjects1.SetKeyReadOnly(true);
				tabLayout.Visible = false;
			}
		}
		private void ReturnLoginView()
		{
			Session.Clear();
			string strMsg;
			strMsg = "对不起你的权限不够，请重新登录!";
			clsCommonJsFunc.Alert(this, strMsg);
			string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
			//			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
			//			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
			Response.Write(ss);
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
			//例如 1=1 and UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtPrjIdq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjId='" + this.txtPrjIdq.Text.Trim()+"'";
			}
			if (this.txtPrjNameq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjName like '%" + this.txtPrjNameq.Text.Trim()+"%'";
			}
			if (this.txtPrjDomainq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjDomain='" + this.txtPrjDomainq.Text.Trim()+"'";
			}
			if (this.txtPrjDataBaseNameq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.PrjDataBaseName='" + this.txtPrjDataBaseNameq.Text.Trim()+"'";
			}
			if (this.txtDataBaseUserIdq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.DataBaseUserId='" + this.txtDataBaseUserIdq.Text.Trim()+"'";
			}
			if (this.txtUserIDq.Text.Trim()!="")
			{
				strWhereCond += " and Projects.UserID='" + this.txtUserIDq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_Projects()
		{
			//操作步骤：(共5步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、设置DATAGRID的数据源(DataSource)；
			//	4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			//	5、设置记录数的状态，
			//		在本界面中是把状态显示在控件txtRecCount中。

			//	1、组合界面条件串；
			string strWhereCond = CombineCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvProjectsBL.GetDataTable(strWhereCond);
			//	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgProjects.PageSize);
			if (intPages==0) 
			{
				this.dgProjects.CurrentPageIndex = 0;
			}
			else if (this.dgProjects.CurrentPageIndex > intPages - 1) 
			{
				this.dgProjects.CurrentPageIndex = intPages - 1;
			}

			
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;
			this.dgProjects.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgProjects.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
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
			this.dgProjects.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_Projects();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgProjects_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgProjects.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_Projects();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strPrjId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strPrjId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strPrjId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsProjectsBL.IsExist(strPrjId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strPrjId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsProjectsEN objProjects = new clsProjectsEN(strPrjId);
			//4、获取类对象的所有属性；
			clsProjectsBL.GetProjects(ref objProjects);
			Session.Add("objProjects", objProjects);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromProjectsClass(objProjects);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjProjects">表实体类对象</param>
		private void GetDataFromProjectsClass(clsProjectsEN pobjProjects)
		{
			wucProjects1.PrjId = pobjProjects.PrjId;
			wucProjects1.PrjName = pobjProjects.PrjName;
			wucProjects1.PrjDomain = pobjProjects.PrjDomain;
            //wucProjects1.PrjDataBaseName = pobjProjects.PrjDataBaseName;
            //wucProjects1.DatabaseOwner = pobjProjects.DatabaseOwner;
            //wucProjects1.IpAddress = pobjProjects.IpAddress;
            //wucProjects1.DataBaseUserId = pobjProjects.DataBaseUserId;
            //wucProjects1.DataBasePwd = pobjProjects.DataBasePwd;
            //wucProjects1.ApplicationTypeId = pobjProjects.ApplicationTypeId;//    修改日期
            //wucProjects1.SoftStructureId = pobjProjects.SoftStructureId;//    用户ID
            //wucProjects1.PrjDataBaseId = pobjProjects.PrjDataBaseId;//    用户ID
            wucProjects1.Memo = pobjProjects.Memo;
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
			clsProjectsEN objProjects;
            string strResult = "";    

			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucProjects1.SetKeyReadOnly(false);
					wucProjects1.PrjId = clsProjectsBL.GetMaxStrId_S();
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
                    
					if (!wucProjects1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsProjectsEN objProjects;	//定义对象
					objProjects = new clsProjectsEN(wucProjects1.PrjId);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					if (clsProjectsBL.IsExist(objProjects.PrjId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToProjectsClass(objProjects);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsProjectsBL.CheckPropertyNew(objProjects);
                    }
                    catch(Exception objException)
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//6、把数据实体层的数据存贮到数据库中
					if (clsProjectsBL.AddNewRecordBySql2(objProjects) == false) 
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
					BindDg_Projects();
					wucProjects1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
					tabProjectsDg.Visible = true;
					tabLayout.Visible = false;
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
                    ///
                    
					if (!wucProjects1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objProjects = (clsProjectsEN) Session["objProjects"];
					PutDataToProjectsClass(objProjects);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsProjectsBL.CheckPropertyNew(objProjects);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsProjectsBL.UpdateBySql2(objProjects) == false) 
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
					BindDg_Projects();
					wucProjects1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					tabProjectsDg.Visible = true;
					tabLayout.Visible = false;

					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjProjects">数据传输的目的类对象</param>
		private void PutDataToProjectsClass(clsProjectsEN pobjProjects)
		{
			pobjProjects.PrjId = wucProjects1.PrjId;
			pobjProjects.PrjName = wucProjects1.PrjName;
			pobjProjects.PrjDomain = wucProjects1.PrjDomain;
            //pobjProjects.PrjDataBaseName = wucProjects1.PrjDataBaseName;
            //pobjProjects.DatabaseOwner = wucProjects1.DatabaseOwner;
            //pobjProjects.IpAddress = wucProjects1.IpAddress;
            //pobjProjects.DataBaseUserId = wucProjects1.DataBaseUserId;
            //if (wucProjects1.DataBasePwd.Length>0)
            //{
            //    pobjProjects.DataBasePwd = wucProjects1.DataBasePwd;
            //}
            pobjProjects.UpdDate = clsDateTime.getTodayStr(0);//    修改日期
            pobjProjects.UserId = clsCommonSession.UserId;//    用户ID
            //pobjProjects.ApplicationTypeId = wucProjects1.ApplicationTypeId;//    说明
            //pobjProjects.SoftStructureId = wucProjects1.SoftStructureId;//    说明
            //pobjProjects.PrjDataBaseId = wucProjects1.PrjDataBaseId;//    说明
            pobjProjects.Memo = wucProjects1.Memo;
		}

		protected void dgProjects_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
				for(int i=0;i<this.dgProjects.Columns.Count;i++)
				{
					strSortEx = this.dgProjects.Columns[i].SortExpression;
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

		protected void dgProjects_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strPrjId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strPrjId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsProjectsBL.DelRecord(strPrjId);
						BindDg_Projects();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strPrjId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucProjects1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						tabLayout.Visible = true;
						tabProjectsDg.Visible = false;
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}

		protected void dgProjects_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_Projects();
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
			BindDg_Projects();
		}

		protected void lbAddNewRec_Click(object sender, System.EventArgs e)
		{
			tabLayout.Visible = true;
			tabProjectsDg.Visible = false;
			btnOKUpd_Click(btnOKUpd, new System.EventArgs());
		}

		protected void lbDispPrjList_Click(object sender, System.EventArgs e)
		{
			tabProjectsDg.Visible = true;
			tabLayout.Visible = false;
		}

		protected void lbExportForTeachCircs_Click(object sender, System.EventArgs e)
		{
			
			//	1、组合界面条件串；
			string strWhereCond = CombineCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsProjectsBL.GetDataTable_Projects(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "Projects信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("PrjId"); arrCnName.Add("工程ID");
			arrColName.Add("PrjName"); arrCnName.Add("工程名称");
			arrColName.Add("PrjDomain"); arrCnName.Add("工程域名");
			arrColName.Add("PrjDataBaseName"); arrCnName.Add("主数据库");
			arrColName.Add("IpAddress"); arrCnName.Add("服务器");
			arrColName.Add("DataBaseUserId"); arrCnName.Add("数据库的用户ID");
			arrColName.Add("DataBasePwd"); arrCnName.Add("数据库的用户口令");
			arrColName.Add("UserId"); arrCnName.Add("用户ID");
			arrColName.Add("UpdDate"); arrCnName.Add("修改时间");
			arrColName.Add("Memo"); arrCnName.Add("说明");
			arrColName.Add("DatabaseOwner"); arrCnName.Add("数据库拥有者");
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

	}
}