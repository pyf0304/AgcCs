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


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AGC.Entity;



using com.taishsoft.common;
using System.Text;
using AutoGCLib;


namespace AGC.Webform
{
	/// <summary>
	/// wfmQryRegionFlds_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmQryRegionFlds_QUDI : CommWebPageBase
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
				wucQryRegionFlds1.SetDdl_CtlTypeId(false);
				wucQryRegionFlds1.SetDdl_DdlItemsOptionId();
                wucQryRegionFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
	
				wucQryRegionFlds1.SetDdl_QueryOptionId();
                clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeIdq);
                clsDDLItemsOptionBL.BindDdl_DdlItemsOptionIdCache(ddlDdlItemsOptionIdq);
                clsQueryOptionBL.BindDdl_QueryOptionIdCache(ddlQueryOptionIdq);
				strSortQryRegionFldsBy = "SeqNum Asc";
				//2、显示无条件的表内容在DATAGRID中
				///
				if (string.IsNullOrEmpty(RegionId )== true)
				{
					return ;
				}
				lblRegionName.Text = clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).RegionName;
				BindDg_QryRegionFlds();
				
				tabEditQryRegionFldsRegion.Visible = false;  //具体信息维护区域隐藏

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
				strSimpleFName = (string)Session["SimpleFName"];
				if (strSimpleFName==null) 
				{
					strSimpleFName = "";
				}
				return strSimpleFName;
			}
			set
			{
				string strSimpleFName = value;
				Session.Add("SimpleFName", strSimpleFName);
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
		

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineQryRegionFldsCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 and RegionId = '" + RegionId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.ddlCtlTypeIdq.SelectedValue!="" && this.ddlCtlTypeIdq.SelectedValue!="0")
			{
				strWhereCond += " And CtlTypeId='" + this.ddlCtlTypeIdq.SelectedValue+"'";
			}
			if (this.ddlDdlItemsOptionIdq.SelectedValue!="" && this.ddlDdlItemsOptionIdq.SelectedValue!="0")
			{
				strWhereCond += " And DdlItemsOptionId='" + this.ddlDdlItemsOptionIdq.SelectedValue+"'";
			}
			if (this.ddlQueryOptionIdq.SelectedValue!="" && this.ddlQueryOptionIdq.SelectedValue!="0")
			{
				strWhereCond += " And QryRegionFlds.QueryOptionId='" + this.ddlQueryOptionIdq.SelectedValue+"'";
			}

			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QryRegionFlds()
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
			string strWhereCond = CombineQryRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQryRegionFldsBL.GetDataTable(strWhereCond  + " order by SeqNum" );
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgQryRegionFlds.PageSize);
			if (intPages==0) 
			{
				this.dgQryRegionFlds.CurrentPageIndex = 0;
			}
			else if (this.dgQryRegionFlds.CurrentPageIndex > intPages - 1) 
			{
				this.dgQryRegionFlds.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortQryRegionFldsBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgQryRegionFlds.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgQryRegionFlds.DataBind();

			
			//当前记录数
			this.lblQryRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblQryRegionFldsAllPages.Text = this.dgQryRegionFlds.PageCount.ToString(); 
			//当前页序数
			this.lblQryRegionFldsCurrentPage.Text=(this.dgQryRegionFlds.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtQryRegionFldsJump2Page.Text=(this.dgQryRegionFlds.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgQryRegionFlds.CurrentPageIndex==0) 
			{
				btnQryRegionFldsPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnQryRegionFldsPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgQryRegionFlds.CurrentPageIndex==this.dgQryRegionFlds.PageCount-1) 
			{ 
				btnQryRegionFldsNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnQryRegionFldsNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabQryRegionFldsJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabQryRegionFldsJumpPage.Visible = false; 
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
			this.dgQryRegionFlds.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_QryRegionFlds();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgQryRegionFlds_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgQryRegionFlds.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QryRegionFlds();
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
			if (clsQryRegionFldsBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngmId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN(lngmId);
			//4、获取类对象的所有属性；
			clsQryRegionFldsBL.GetQryRegionFlds(ref objQryRegionFldsEN);
			Session.Add("objQryRegionFldsEN", objQryRegionFldsEN);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromQryRegionFldsClass(objQryRegionFldsEN);
			DispEditQryRegionFldsRegion();
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjQryRegionFlds">表实体类对象</param>
		private void GetDataFromQryRegionFldsClass(clsQryRegionFldsEN pobjQryRegionFlds)
		{
			wucQryRegionFlds1.FldId = pobjQryRegionFlds.FldId;
			
			//clsvQryRegionFldsEN objvQryRegionFlds = clsvQryRegionFldsBL.GetFirstObj_S("RegionId = '" + RegionId + "' and TabFldId = " + pobjQryRegionFlds.TabFldId);
			//wucQryRegionFlds1.FldName = objvQryRegionFlds.FldName;

			wucQryRegionFlds1.CtlTypeId = pobjQryRegionFlds.CtlTypeId;
			wucQryRegionFlds1.DdlItemsOptionId = pobjQryRegionFlds.DdlItemsOptionId;
			wucQryRegionFlds1.DsTabId = pobjQryRegionFlds.DsTabId;
			wucQryRegionFlds1.DsCondStr = pobjQryRegionFlds.DsCondStr;
			wucQryRegionFlds1.DsSqlStr = pobjQryRegionFlds.DsSqlStr;
			wucQryRegionFlds1.ItemsString = pobjQryRegionFlds.ItemsString;
			wucQryRegionFlds1.SeqNum = pobjQryRegionFlds.SeqNum ?? 0;
	
			wucQryRegionFlds1.Memo = pobjQryRegionFlds.Memo;
			wucQryRegionFlds1.QueryOptionId = pobjQryRegionFlds.QueryOptionId;
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
			clsQryRegionFldsEN objQryRegionFldsEN;
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
					if (!wucQryRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsQryRegionFldsEN objQryRegionFldsEN;	//定义对象
					objQryRegionFldsEN = new clsQryRegionFldsEN();	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToQryRegionFldsClass(objQryRegionFldsEN);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
                    if (clsQryRegionFldsBL.AddNewRecordBySql2(objQryRegionFldsEN) == false) 
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
					BindDg_QryRegionFlds();
					wucQryRegionFlds1.Clear();		//清空控件中内容
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
					if (!wucQryRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objQryRegionFldsEN = (clsQryRegionFldsEN) Session["objQryRegionFldsEN"];
					PutDataToQryRegionFldsClass(objQryRegionFldsEN);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
                    if (clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN) == false) 
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
					BindDg_QryRegionFlds();
					wucQryRegionFlds1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					DispQryRegionFldsInfo();
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjQryRegionFlds">数据传输的目的类对象</param>
		private void PutDataToQryRegionFldsClass(clsQryRegionFldsEN pobjQryRegionFlds)
		{
			pobjQryRegionFlds.FldId = wucQryRegionFlds1.FldId;
			pobjQryRegionFlds.CtlTypeId = wucQryRegionFlds1.CtlTypeId;
			pobjQryRegionFlds.DdlItemsOptionId = wucQryRegionFlds1.DdlItemsOptionId;
			pobjQryRegionFlds.DsTabId = wucQryRegionFlds1.DsTabId;
			pobjQryRegionFlds.DsCondStr = wucQryRegionFlds1.DsCondStr;
			pobjQryRegionFlds.DsSqlStr = wucQryRegionFlds1.DsSqlStr;
			pobjQryRegionFlds.ItemsString = wucQryRegionFlds1.ItemsString;
			pobjQryRegionFlds.SeqNum = wucQryRegionFlds1.SeqNum;
			pobjQryRegionFlds.UpdDate = wucQryRegionFlds1.UpdDate;
			pobjQryRegionFlds.UpdUser = wucQryRegionFlds1.UserId;
			pobjQryRegionFlds.Memo = wucQryRegionFlds1.Memo;
			pobjQryRegionFlds.QueryOptionId = wucQryRegionFlds1.QueryOptionId;

		}

		protected void dgQryRegionFlds_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortQryRegionFldsBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgQryRegionFlds.Columns.Count;i++)
				{
					strSortEx = this.dgQryRegionFlds.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortQryRegionFldsBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortQryRegionFldsBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgQryRegionFlds_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
						clsQryRegionFldsBL.DelRecord(lngmId);
						BindDg_QryRegionFlds();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						tabEditQryRegionFldsRegion.Visible = true;
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
					Set_DataGridAllChecked(dgQryRegionFlds, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgQryRegionFlds, false);
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
			
			
//			btnOKUpd.Text = "确认添加";

		}

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombineQryRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsQryRegionFldsBL.GetDataTable_QryRegionFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "QryRegionFlds信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("RegionId"); arrCnName.Add("区域Id");
			arrColName.Add("TabFldId"); arrCnName.Add("表字段ID");
			arrColName.Add("CtlTypeId"); arrCnName.Add("控件类型号");
			arrColName.Add("DdlItemsOptionId"); arrCnName.Add("下拉框列表选项ID");
			arrColName.Add("DsTabId"); arrCnName.Add("数据源表ID");
			arrColName.Add("DsDataValueFieldId"); arrCnName.Add("数据源值字段Id");
			arrColName.Add("DsDataTextFieldId"); arrCnName.Add("数据源文本字段Id");
			arrColName.Add("DsCondStr"); arrCnName.Add("数据源条件串");
			arrColName.Add("DsSqlStr"); arrCnName.Add("数据源SQL串");
			arrColName.Add("ItemsString"); arrCnName.Add("列表项串");
			arrColName.Add("SeqNum"); arrCnName.Add("字段序号");
			arrColName.Add("UpdDate"); arrCnName.Add("修改时间");
			arrColName.Add("UserId"); arrCnName.Add("用户ID");
			arrColName.Add("Memo"); arrCnName.Add("说明");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
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
            List<string> arrmId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgQryRegionFlds, "chkCheckRec");
			if (arrmId == null || arrmId.Count == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg1.Text = "";
			clsQryRegionFldsBL.DelQryRegionFldss(arrmId);
			BindDg_QryRegionFlds();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgQryRegionFlds);
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
		
		protected void dgQryRegionFlds_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortQryRegionFldsBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortQryRegionFldsBy = e.SortExpression + " Asc";
				BindDg_QryRegionFlds();
				return ;
			}
			//检查原来是升序
			intIndex = strSortQryRegionFldsBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortQryRegionFldsBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortQryRegionFldsBy = e.SortExpression + " Desc";
			}
			BindDg_QryRegionFlds();
		}

		private string strSortQryRegionFldsBy
		{
			get
			{
				string sSortQryRegionFldsBy;
				sSortQryRegionFldsBy = (string)ViewState["SortQryRegionFldsBy"];
				if (sSortQryRegionFldsBy==null) 
				{
					sSortQryRegionFldsBy = "";
				}
				return sSortQryRegionFldsBy;
			}
			set
			{
				string sSortQryRegionFldsBy = value;
				ViewState.Add("SortQryRegionFldsBy", sSortQryRegionFldsBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnQryRegionFldsPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgQryRegionFlds.CurrentPageIndex -=1; 
			this.BindDg_QryRegionFlds(); 
		}

		protected void btnQryRegionFldsNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgQryRegionFlds.CurrentPageIndex +=1; 
			this.BindDg_QryRegionFlds(); 
		}

		protected void btnQryRegionFldsJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtQryRegionFldsJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtQryRegionFldsJump2Page.Text)>0 && 
				int.Parse(this.txtQryRegionFldsJump2Page.Text)-1<this.dgQryRegionFlds.PageCount) 
			{ 
				this.dgQryRegionFlds.CurrentPageIndex=int.Parse(this.txtQryRegionFldsJump2Page.Text)-1; 
			} 
			this.BindDg_QryRegionFlds();
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
            clsQryRegionFldsBLEx.ImportRelaFlds(RegionId, clsPubVar.CurrCmPrjId, UserId);
			BindDg_QryRegionFlds();
			///恢复<确认添加>变成<添加>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('与界面相关的主表字段信息复制成功！！')</script>");
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispQryRegionFldsInfo();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewRegionLinkStr);
		}
		private void DispQryRegionFldsInfo()
		{
			tabQryRegionFldsDataGrid.Visible = true;
			tabQryRegionFldsJumpPage.Visible = true;
			tabEditQryRegionFldsRegion.Visible = false;
			
			tabQryRegionPreview.Visible = true;
			tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{
			
			tabEditQryRegionFldsRegion.Visible = false;
			tabQryRegionFldsDataGrid.Visible = false;
			tabQryRegionFldsJumpPage.Visible = false;
			tabQryRegionPreview.Visible = false;
			tabCode.Visible = false;
		}
		private void DispEditQryRegionFldsRegion()
		{
			tabQryRegionFldsDataGrid.Visible = false;
			tabQryRegionFldsJumpPage.Visible = false;
			tabEditQryRegionFldsRegion.Visible = true;
			
			tabQryRegionPreview.Visible = false;
			tabCode.Visible = false;
		}


		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            string strViewId = clsCommonSession.ViewId;// clsViewRegionBL.GetObjByRegionIdCache(RegionId, clsPubVar.CurrSelPrjId).ViewId;
			//			tabQuery1.Visible = false;
			tabCode.Visible = true;

            clsViewInfoENEx objViewInfoENEx = new clsViewInfoENEx(strViewId);
            clsViewInfoBLEx.GetViewInfoEx(ref objViewInfoENEx, clsPubVar.CurrSelPrjId);
			
            //生成相关代码
            Encoding myEncoding = clsPubFun.GetEncodingByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            string strRe_ClsName = "";
            string strRe_FileNameWithModuleName = "";
            try
            {
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
                if (WebViewCode4Html.DispQryRegionCtrl(phQryRegion, objViewInfoENEx) >= 0)
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

		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgQryRegionFlds);
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
				clsQryRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
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
			BindDg_QryRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgQryRegionFlds, 1, strmId);
		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strmId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgQryRegionFlds);
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
				clsQryRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../Webform/GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_QryRegionFlds();
			clsCommForWebForm.SetCheckedItemForDg(dgQryRegionFlds, 1, strmId);

		}

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsQryRegionFldsBLEx.ReOrder(RegionId);
			BindDg_QryRegionFlds();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispQryRegionFldsInfo();
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