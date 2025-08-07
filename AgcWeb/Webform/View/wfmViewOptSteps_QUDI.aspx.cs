using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using CommFunc4WebForm;
///生成查询，修改，删除，添加记录的控制层代码
using System;
//using SqlSv; 


using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmViewOptSteps_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmViewOptSteps_QUDI : System.Web.UI.Page
	{
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
			ClientScript.RegisterStartupScript(this.GetType(),"js",js); 


			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				///隐藏应该隐藏的控件内容
				///显示界面提示信息：----------------------
				DispViewInfo(ViewId);
				///显示界面提示信息：======================
				//1、为下拉框设置数据源，绑定列表数据
				wucViewOptSteps1.SetDdl_ViewId(clsPubVar.CurrSelPrjId);
				//3、显示无条件的表内容在DATAGRID中
				BindDg_ViewOptSteps();
				//4、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				BindDg_ViewRelaTab();
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

		private void DispViewInfo(string strViewId)
		{
			//1、显示界面名称
			clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
		
			lblViewName.Text = objViewInfo.ViewName;
			//2、显示工程名称
			string strPrjId = objViewInfo.PrjId;
			clsProjectsEN objProjects = new clsProjectsEN(strPrjId);
			clsProjectsBL.GetProjects(ref objProjects);
			lblPrjName.Text = objProjects.PrjName;
			//4、显示界面功能
			lblViewFunction.Text = objViewInfo.ViewFunction;

		}
		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
			string strWhereCond=" 1=1 and ViewId = '" + ViewId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_ViewOptSteps()
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
			System.Data.DataTable objDT = clsViewOptStepsBLEx.GetViewOptStepsT(strWhereCond, "StepIndex");
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewOptSteps.PageSize);
			if (intPages==0) 
			{
				this.dgViewOptSteps.CurrentPageIndex = 0;
			}
			else if (this.dgViewOptSteps.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewOptSteps.CurrentPageIndex = intPages - 1;
			}

			//	4、设置DATAGRID的数据源(DataSource)；
			this.dgViewOptSteps.DataSource=objDT.DefaultView;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewOptSteps.DataBind();
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
			this.dgViewOptSteps.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_ViewOptSteps();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewOptSteps_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

//			if(Request.Form["RadioName"] != null) 
//			{ 
//				rd.Value =  Request.Form["RadioName"].ToString(); 
//			}

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgViewOptSteps.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ViewOptSteps();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="lngMId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(long lngMId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (lngMId == 0) return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsViewOptStepsBL.IsExist(lngMId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngMId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsViewOptStepsEN objViewOptSteps = new clsViewOptStepsEN(lngMId);
            //4、获取类对象的所有属性；
            clsViewOptStepsBL .GetViewOptSteps(ref objViewOptSteps);
			Session.Add("objViewOptSteps", objViewOptSteps);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromViewOptStepsClass(objViewOptSteps);
		}


		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjViewOptSteps">表实体类对象</param>
		private void GetDataFromViewOptStepsClass(clsViewOptStepsEN pobjViewOptSteps)
		{
			wucViewOptSteps1.ViewId = pobjViewOptSteps.ViewId;
			wucViewOptSteps1.StepIndex = pobjViewOptSteps.StepIndex;
			wucViewOptSteps1.StepName = pobjViewOptSteps.StepName;
			wucViewOptSteps1.StepDetail = pobjViewOptSteps.StepDetail;
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
			clsViewOptStepsEN objViewOptSteps;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					btnOKUpd.Text = "确认添加";
					wucViewOptSteps1.ViewId = ViewId;
					int intStepsNum =(clsViewOptStepsBL.GetRecCountByCond("ViewId='" + ViewId + "'"));
					wucViewOptSteps1.StepIndex = intStepsNum + 1;
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
					if (!wucViewOptSteps1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsViewOptStepsEN objViewOptSteps;	//定义对象
					objViewOptSteps = new clsViewOptStepsEN();	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToViewOptStepsClass(objViewOptSteps);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
				

                    try
                    {
                        clsViewOptStepsBL .CheckPropertyNew(objViewOptSteps);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
					if (clsViewOptStepsBL .AddNewRecordBySql2(objViewOptSteps) == false) 
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
					BindDg_ViewOptSteps();
					wucViewOptSteps1.Clear();		//清空控件中内容
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
					if (!wucViewOptSteps1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objViewOptSteps = (clsViewOptStepsEN) Session["objViewOptSteps"];
					PutDataToViewOptStepsClass(objViewOptSteps);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
					

                    try
                    {
                        clsViewOptStepsBL.CheckPropertyNew(objViewOptSteps);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsViewOptStepsBL .UpdateBySql2(objViewOptSteps) == false) 
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
					BindDg_ViewOptSteps();
					wucViewOptSteps1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjViewOptSteps">数据传输的目的类对象</param>
		private void PutDataToViewOptStepsClass(clsViewOptStepsEN pobjViewOptSteps)
		{
			pobjViewOptSteps.ViewId = wucViewOptSteps1.ViewId;
			pobjViewOptSteps.StepIndex = wucViewOptSteps1.StepIndex;
			pobjViewOptSteps.StepName = wucViewOptSteps1.StepName;
			pobjViewOptSteps.StepDetail = wucViewOptSteps1.StepDetail;
		}


		protected void dgViewOptSteps_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngMId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngMId = long.Parse(dgViewOptSteps.DataKeys[e.Item.ItemIndex].ToString());
				switch(strCommandName)
				{
					case "Delete":
						clsViewOptStepsBLEx.DelRecordEx(lngMId);
						BindDg_ViewOptSteps();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(lngMId);
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
		}
		

		protected void ibDown_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			int intStepIndex, intNextStepIndex;
			if(Request.Form["RadioName"] != null) 
			{ 
				rd.Value =  Request.Form["RadioName"].ToString(); 
				intStepIndex =int.Parse(rd.Value);
				bool bolIsSuccess = (new clsViewOptStepsBLEx().DownOrderByOne(ViewId, intStepIndex));
				if (bolIsSuccess == true)
				{
					
					intNextStepIndex = intStepIndex + 1;
					rd.Value = intNextStepIndex.ToString();

					///通过intNextStepIndex计算当前索引的页号P1
					///如果DATAGRID的当前页号小于P1就增加当前当前页号

					///通过intNextStepIndex计算当前索引的页号P1
					int intPages = CalcPages(intNextStepIndex, this.dgViewOptSteps.PageSize);
					///如果DATAGRID的当前页号小于P1就增加当前当前页号
					if (this.dgViewOptSteps.CurrentPageIndex < intPages-1 ) 
					{
						this.dgViewOptSteps.CurrentPageIndex = intPages-1;
					}
					BindDg_ViewOptSteps();
				}
			}

		}

		protected void ibUp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			int intStepIndex, intPrevStepIndex;
			if(Request.Form["RadioName"] != null) 
			{ 
				rd.Value =  Request.Form["RadioName"].ToString(); 
				intStepIndex =int.Parse(rd.Value);
				bool bolIsSuccess = (new clsViewOptStepsBLEx().UpOrderByOne(ViewId, intStepIndex));
				if (bolIsSuccess == true)
				{
					intPrevStepIndex = intStepIndex - 1;
					rd.Value = intPrevStepIndex.ToString();
					///通过intNextStepIndex计算当前索引的页号P1
					///如果DATAGRID的当前页号小于P1就增加当前当前页号

					///通过intNextStepIndex计算当前索引的页号P1
					int intPages = CalcPages(intPrevStepIndex, this.dgViewOptSteps.PageSize);
					///如果DATAGRID的当前页号小于P1就增加当前当前页号
					if (this.dgViewOptSteps.CurrentPageIndex > intPages-1 ) 
					{
						this.dgViewOptSteps.CurrentPageIndex = intPages-1;
					}
					BindDg_ViewOptSteps();
				}
			}
		}

		protected void dgViewOptSteps_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_ViewRelaTab()
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
			string strWhereCond = " ViewId='" + ViewId + "'";
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvViewRelaTabBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewRelaTab.PageSize);
			if (intPages==0) 
			{
				this.dgViewRelaTab.CurrentPageIndex = 0;
			}
			else if (this.dgViewRelaTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewRelaTab.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			this.dgViewRelaTab.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewRelaTab.DataBind();
		}

		protected void dgViewRelaTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgViewRelaTab.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ViewRelaTab();
		}

		protected void btnUpdStep_Click(object sender, System.EventArgs e)
		{
            List<string> arrLst = new List<string>();
			int intStepIndex;
			long lngIdForCurrStep;
			if(Request.Form["RadioName"] == null) 
			{ 
				return ;
			}
			rd.Value =  Request.Form["RadioName"].ToString(); 
			intStepIndex =int.Parse(rd.Value);
			//2、获取当前记录(本操作序号)的关键字(lngIdForCurrStep)；
			arrLst = clsViewOptStepsBL.GetFldValue("ViewOptSteps", "mId",  "ViewId='" + ViewId + "' and StepIndex=" + intStepIndex.ToString());
			lngIdForCurrStep =long.Parse(arrLst[0].ToString());
			ShowData(lngIdForCurrStep);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "确认修改";
			lblMsg.Text = "";

		}

		protected void btnDelStep_Click(object sender, System.EventArgs e)
		{
            List<string> arrLst = new List<string>();
			int intStepIndex;
			long lngIdForCurrStep;
			if(Request.Form["RadioName"] == null) 
			{ 
				return ;
			}
			rd.Value =  Request.Form["RadioName"].ToString(); 
			intStepIndex =int.Parse(rd.Value);
			//2、获取当前记录(本操作序号)的关键字(lngIdForCurrStep)；
			arrLst = clsViewOptStepsBL.GetFldValue("ViewOptSteps", "mId",  "ViewId='" + ViewId + "' and StepIndex=" + intStepIndex.ToString());
			lngIdForCurrStep =long.Parse(arrLst[0].ToString());
			clsViewOptStepsBLEx.DelRecordEx(lngIdForCurrStep);
			BindDg_ViewOptSteps();
		}

		protected void lbReturn_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmViewSetOptStepAndFunc.aspx");
		}

	}
}