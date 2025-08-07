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

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.Entity;

using AGC.BusinessLogicEx;

namespace AGC.Webform
{
	/// <summary>
	/// wfmPrjUserObjs_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmPrjUserObjs_QUDI : System.Web.UI.Page
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				//1、为下拉框设置数据源，绑定列表数据
				wucPrjUserObjs1.SetDdl_PrjId();
				clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
				//2、显示无条件的表内容在DATAGRID中
				BindDg_PrjUserObjs();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucPrjUserObjs1.SetKeyReadOnly(true);
			}
		}
		
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
			if (this.txtPrjUserObjIdq.Text.Trim()!="")
			{
				strWhereCond += " and PrjUserObjs.PrjUserObjId='" + this.txtPrjUserObjIdq.Text.Trim()+"'";
			}
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjUserObjs.PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}
			if (this.txtPrjUserObjNameq.Text.Trim()!="")
			{
				strWhereCond += " and PrjUserObjs.PrjUserObjName='" + this.txtPrjUserObjNameq.Text.Trim()+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_PrjUserObjs()
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
			System.Data.DataTable objDT = clsPrjUserObjsBL.GetDataTable(strWhereCond);
			//	3、设置DATAGRID的数据源(DataSource)；
			this.dgPrjUserObjs.DataSource=objDT.DefaultView;
			//	4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgPrjUserObjs.DataBind();
			//	5、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
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
			this.dgPrjUserObjs.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_PrjUserObjs();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgPrjUserObjs_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgPrjUserObjs.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_PrjUserObjs();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strPrjUserObjId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strPrjUserObjId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strPrjUserObjId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsPrjUserObjsBL.IsExist(strPrjUserObjId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strPrjUserObjId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsPrjUserObjsEN objPrjUserObjs = new clsPrjUserObjsEN(strPrjUserObjId);
            //4、获取类对象的所有属性；
            clsPrjUserObjsBL .GetPrjUserObjs(ref objPrjUserObjs);
			Session.Add("objPrjUserObjs", objPrjUserObjs);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromPrjUserObjsClass(objPrjUserObjs);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjPrjUserObjs">表实体类对象</param>
		private void GetDataFromPrjUserObjsClass(clsPrjUserObjsEN pobjPrjUserObjs)
		{
			wucPrjUserObjs1.PrjUserObjId = pobjPrjUserObjs.PrjUserObjId;
			wucPrjUserObjs1.PrjId = pobjPrjUserObjs.PrjId;
			wucPrjUserObjs1.PrjUserObjName = pobjPrjUserObjs.PrjUserObjName;
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
			clsPrjUserObjsEN objPrjUserObjs;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucPrjUserObjs1.SetKeyReadOnly(false);
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
					if (!wucPrjUserObjs1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsPrjUserObjsEN objPrjUserObjs;	//定义对象
					objPrjUserObjs = new clsPrjUserObjsEN(wucPrjUserObjs1.PrjUserObjId);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					if (clsPrjUserObjsBL.IsExist(wucPrjUserObjs1.PrjUserObjId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToPrjUserObjsClass(objPrjUserObjs);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsPrjUserObjsBL .CheckPropertyNew(objPrjUserObjs);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
					if (clsPrjUserObjsBL .AddNewRecordBySql2(objPrjUserObjs) == false) 
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
					BindDg_PrjUserObjs();
					wucPrjUserObjs1.Clear();		//清空控件中内容
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
					if (!wucPrjUserObjs1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objPrjUserObjs = (clsPrjUserObjsEN) Session["objPrjUserObjs"];
					PutDataToPrjUserObjsClass(objPrjUserObjs);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsPrjUserObjsBL.CheckPropertyNew(objPrjUserObjs);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsPrjUserObjsBL .UpdateBySql2(objPrjUserObjs) == false) 
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
					BindDg_PrjUserObjs();
					wucPrjUserObjs1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjPrjUserObjs">数据传输的目的类对象</param>
		private void PutDataToPrjUserObjsClass(clsPrjUserObjsEN pobjPrjUserObjs)
		{
			pobjPrjUserObjs.PrjUserObjId = wucPrjUserObjs1.PrjUserObjId;
			pobjPrjUserObjs.PrjId = wucPrjUserObjs1.PrjId;
			pobjPrjUserObjs.PrjUserObjName = wucPrjUserObjs1.PrjUserObjName;
		}

		protected void dgPrjUserObjs_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
		}

		protected void dgPrjUserObjs_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strPrjUserObjId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strPrjUserObjId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsPrjUserObjsBL.DelRecord(strPrjUserObjId);
						BindDg_PrjUserObjs();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strPrjUserObjId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucPrjUserObjs1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
	
	}
}