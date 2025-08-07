///生成查询，修改，删除，添加记录的控制层代码


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
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;



using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewRegion_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmViewRegion_QUDIBak : CommWebPageBase
    {
		//生成有关的变量定义代码
		private const string ViewId4Potence="00260203";		//界面编号
        /// <summary>
        /// 操作方式：（添加界面相关区域：AddViewRelaRegion, 修改：UpdRec）
        /// </summary>
        private string qsOperator
        {
            get
            {
                string strOperator = Request.QueryString["Operator"] ?? "".ToString();
                if ((strOperator != null) && (strOperator != ""))
                {
                    return strOperator;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }


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
				divViewRelaRegion.Visible = false;
				//1、为下拉框设置数据源，绑定列表数据
                wucViewRegion1.SetDdl_ViewId(clsPubVar.CurrSelPrjId);
				wucViewRegion1.SetDdl_RegionTypeId();
				wucViewRegion1.SetDdl_INOUTTypeId();
				wucViewRegion1.SetDdl_TabId(clsPubVar.CurrSelPrjId);
				wucDGRegion1.SetDdl_DGStyleId();

				strSortViewRegionBy = "RegionId Asc";
				//2、显示无条件的表内容在DATAGRID中
				clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewId_Cache(ViewId, clsPubVar.CurrSelPrjId);
				lblViewName.Text = objViewInfo.ViewCnName + "(" + objViewInfo.ViewName + ")";
//lblViewName.Text = new clsViewInfoEN(ViewId, true).ViewCnName + new clsViewInfoEN(ViewId, true).ViewName;
				BindDg_ViewRegion();
                HideAllRegion();

                if (qsOperator == "AddViewRelaRegion")
                {
                    divViewRelaRegion.Visible = true;
                }
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
		private string BackViewInfoLinkStr
		{
			get
			{
				string strBackViewInfoLinkStr;
				strBackViewInfoLinkStr = (string)Session["BackViewInfoLinkStr"];
				if (strBackViewInfoLinkStr==null) 
				{
					strBackViewInfoLinkStr = "";
				}
				return strBackViewInfoLinkStr;
			}
			set
			{
				string strBackViewInfoLinkStr = value;
				Session.Add("BackViewInfoLinkStr", strBackViewInfoLinkStr);
			}
		}
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
		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineViewRegionCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 and ViewId = '" + ViewId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_ViewRegion()
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
			string strWhereCond = CombineViewRegionCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvViewRegionBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgViewRegion.PageSize);
			if (intPages==0) 
			{
				this.dgViewRegion.CurrentPageIndex = 0;
			}
			else if (this.dgViewRegion.CurrentPageIndex > intPages - 1) 
			{
				this.dgViewRegion.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortViewRegionBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgViewRegion.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgViewRegion.DataBind();

			
			//当前记录数
			this.lblViewRegionRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblViewRegionAllPages.Text = this.dgViewRegion.PageCount.ToString(); 
			//当前页序数
			this.lblViewRegionCurrentPage.Text=(this.dgViewRegion.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtViewRegionJump2Page.Text=(this.dgViewRegion.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgViewRegion.CurrentPageIndex==0) 
			{
				btnViewRegionPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnViewRegionPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgViewRegion.CurrentPageIndex==this.dgViewRegion.PageCount-1) 
			{ 
				btnViewRegionNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnViewRegionNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabViewRegionJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabViewRegionJumpPage.Visible = false; 
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
			this.dgViewRegion.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_ViewRegion();
			DispViewRegionListRegion();
            HideAllRegion();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgViewRegion_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgViewRegion.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_ViewRegion();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="lngRegionId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string lngRegionId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (string.IsNullOrEmpty( lngRegionId )== true) return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsViewRegionBL.IsExist(lngRegionId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngRegionId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsViewRegionEN objViewRegionEN = new clsViewRegionEN(lngRegionId);
			//4、获取类对象的所有属性；
            clsViewRegionBL.GetViewRegion(ref objViewRegionEN);
			Session.Add("objViewRegionEN", objViewRegionEN);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromViewRegionClass(objViewRegionEN);
			if (objViewRegionEN.RegionTypeId == "0001")//区域类型：查询区域
			{
				//clsQueryRegionEN objQryRegion =  clsQueryRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
				//Session.Add("objQryRegion", objQryRegion);
				//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
				wucViewRegion1.ColNum = objViewRegionEN.ColNum;
				//wucViewRegion1.IsUseCtrl = objQryRegion.IsUseCtrl;
			}
			else if (objViewRegionEN.RegionTypeId == "0003")//区域类型：编辑区域
			{
				//clsEditRegionEN objEditRegion = clsEditRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
				//Session.Add("objEditRegion", objEditRegion);
				//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
				wucViewRegion1.ColNum = objViewRegionEN.ColNum;
				//wucViewRegion1.IsUseCtrl = objEditRegion.IsUseCtrl;
			}
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjViewRegion">表实体类对象</param>
		private void GetDataFromViewRegionClass(clsViewRegionEN pobjViewRegion)
		{
			wucViewRegion1.RegionName = pobjViewRegion.RegionName;
			//wucViewRegion1.ViewId = pobjViewRegion.ViewId;
			wucViewRegion1.RegionTypeId = pobjViewRegion.RegionTypeId;
			wucViewRegion1.RegionFunction = pobjViewRegion.RegionFunction;
		
			wucViewRegion1.INOUTTypeId = pobjViewRegion.INOUTTypeId;
			wucViewRegion1.TabId = pobjViewRegion.TabId;
			wucViewRegion1.Height = pobjViewRegion.Height;
			wucViewRegion1.Width = pobjViewRegion.Width;
			wucViewRegion1.Memo = pobjViewRegion.Memo;
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
			clsViewRegionEN objViewRegionEN;
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
					if (!wucViewRegion1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsViewRegionEN objViewRegionEN;	//定义对象
					objViewRegionEN = new clsViewRegionEN();	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToViewRegionClass(objViewRegionEN);      //把界面的值传到

                    var strCondition = new clsViewRegionEN()
                        .SetApplicationTypeId(objViewRegionEN.ApplicationTypeId, "=")
                        .SetPrjId(objViewRegionEN.PrjId, "=")
                        .SetRegionName(objViewRegionEN.RegionName, "=")
                        .GetCombineCondition();

                    if (clsViewRegionBL.IsExistRecord(strCondition) == true)
					{
						strMsg = "该界面中相同的区域名称已经存在，不能插入重复记录!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = strMsg;
						return ;
					}
					//5、检查传进去的对象属性是否合法
                    try
                    {
                         clsViewRegionBL.CheckPropertyNew(objViewRegionEN);
                    }
                    catch(Exception objException) 
					{
                        clsCommonJsFunc.Alert(this, objException.Message);
						return ; 
					}
					//6、把数据实体层的数据存贮到数据库中
					if (clsViewRegionBL.AddNewRecordBySql2(objViewRegionEN) == false) 
					{
						strMsg = "添加不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "添加记录不成功!";
					}
					else
					{
						objViewRegionEN.RegionId = clsViewRegionBL.GetFirstID_S(strCondition);
						//存储相关区域的具体代码
						if (objViewRegionEN.RegionTypeId == "0001")//区域类型：查询区域
						{
							//SaveQryRegionData("AddNewRecord", objViewRegionEN);
						}
						else if (objViewRegionEN.RegionTypeId == "0003")//区域类型：编辑区域
						{
							//SaveEditRegionData("AddNewRecord", objViewRegionEN);
						}
						//						strMsg = "添加记录成功!";
						//						clsCommonJsFunc.Alert(this, strMsg);
						//						lblMsg.Text = "添加记录成功!";
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindDg_ViewRegion();
					wucViewRegion1.Clear();		//清空控件中内容
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
					if (!wucViewRegion1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objViewRegionEN = (clsViewRegionEN) Session["objViewRegionEN"];
					PutDataToViewRegionClass(objViewRegionEN);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                         clsViewRegionBL.CheckPropertyNew(objViewRegionEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsViewRegionBL.UpdateBySql2(objViewRegionEN) == false) 
					{
						strMsg = "修改记录不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "修改记录不成功!";
					}
					else
					{
						//存储相关区域的具体代码
						//if (objViewRegionEN.RegionTypeId == "0001")//区域类型：查询区域
						//{
						//	if ( clsQueryRegionBL.IsExistRecord("RegionId = '" + objViewRegionEN.RegionId + "'")==true)
						//	{
						//		//SaveQryRegionData("Update", objViewRegionEN);
						//	}
						//	else
						//	{
						//		//SaveQryRegionData("AddNewRecord", objViewRegionEN);
						//	}
						//}
						//else if (objViewRegionEN.RegionTypeId == "0003")//区域类型：编辑区域
						//{
						//	if ( clsEditRegionBL.IsExistRecord("RegionId = '" + objViewRegionEN.RegionId + "'")==true)
						//	{
						//		//SaveEditRegionData("Update", objViewRegionEN);
						//	}
						//	else
						//	{
						//		//SaveEditRegionData("AddNewRecord", objViewRegionEN);
						//	}
						//}
						//						strMsg = "修改记录成功!";
						//						clsCommonJsFunc.Alert(this, strMsg);
						//						lblMsg.Text = "修改记录成功!";
					}
					//5、把修改后的内容显示在DATAGRID中
					BindDg_ViewRegion();
					wucViewRegion1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
                    HideAllRegion();	
					DispViewRegionListRegion();
					break;
				case "特殊属性确认修改":

					UpdateRegionRecordSave(RegionId);
					
					break;
			}
		}
		//private bool SaveQryRegionData(string strOpType, clsViewRegionEN objViewRegionEN)
		//{
		//	string strMsg;

		//	//if (strOpType == "AddNewRecord")
		//	//{
		//	//	clsQueryRegionEN objQryRegion = new clsQueryRegionEN(objViewRegionEN.RegionId);
		//	//	//objQryRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objQryRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;
  // //             try
  // //             {
  // //                  clsQueryRegionBL .CheckPropertyNew(objQryRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }
		//	//	//6、把数据实体层的数据存贮到数据库中
		//	//	if (clsQueryRegionBL .AddNewRecordBySql2(objQryRegion) == false) 
		//	//	{
		//	//		strMsg = "添加不成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "添加记录不成功!";
		//	//		return false; 
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "添加记录成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "添加记录成功!";
		//	//		return true; 
		//	//	}
		//	//}
		//	//else
		//	//{
		//	//	//2、把值从界面层传到逻辑层或数据实体层
		//	//	clsQueryRegionEN objQryRegion = (clsQueryRegionEN) Session["objQryRegion"];
		//	//	//objQryRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objQryRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;
		//	//	//3、检查传进去的对象属性是否合法
  // //             try
  // //             {
  // //                  clsQueryRegionBL .CheckPropertyNew(objQryRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }
  // //             //4、把数据实体层的数据修改同步到数据库中
		//	//	if (clsQueryRegionBL.UpdateBySql2(objQryRegion) == false) 
		//	//	{
		//	//		strMsg = "修改记录不成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "修改记录不成功!";
		//	//		return false;
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "修改记录成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "修改记录成功!";
		//	//		return true; 
		//	//	}

		//	//}
		//}
		/// <summary>
		/// 保存编辑区域的相关数据
		/// </summary>
		/// <param name="strOpType"></param>
		/// <param name="objViewRegionEN"></param>
		/// <returns></returns>
		//private bool SaveEditRegionData(string strOpType, clsViewRegionEN objViewRegionEN)
		//{
		//	string strMsg;

		//	//if (strOpType == "AddNewRecord")
		//	//{
		//	//	clsEditRegionEN objEditRegion = new clsEditRegionEN(objViewRegionEN.RegionId);
		//	//	//objEditRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objEditRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;

  // //             try
  // //             {
  // //                 clsEditRegionBL .CheckPropertyNew(objEditRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }

		//	//	//6、把数据实体层的数据存贮到数据库中
		//	//	if (clsEditRegionBL .AddNewRecordBySql2(objEditRegion) == false) 
		//	//	{
		//	//		strMsg = "添加不成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "添加记录不成功!";
		//	//		return false; 
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "添加记录成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "添加记录成功!";
		//	//		return true; 
		//	//	}
		//	//}
		//	//else
		//	//{
		//	//	//2、把值从界面层传到逻辑层或数据实体层
		//	//	clsEditRegionEN objEditRegion = (clsEditRegionEN) Session["objEditRegion"];
		//	//	//objEditRegion.ColNum = wucViewRegion1.ColNum;
		//	//	objEditRegion.IsUseCtrl = wucViewRegion1.IsUseCtrl;
		//	//	//3、检查传进去的对象属性是否合法
  // //             try
  // //             {
  // //                  clsEditRegionBL .CheckPropertyNew(objEditRegion);
  // //             }
  // //             catch (Exception objException)
  // //             {
  // //                 clsCommonJsFunc.Alert(this, objException.Message);
  // //                 return false;
  // //             }
		//	//	//4、把数据实体层的数据修改同步到数据库中
		//	//	if (clsEditRegionBL.UpdateBySql2(objEditRegion) == false) 
		//	//	{
		//	//		strMsg = "修改记录不成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "修改记录不成功!";
		//	//		return false;
		//	//	}
		//	//	else
		//	//	{
		//	//		strMsg = "修改记录成功!";
		//	//		clsCommonJsFunc.Alert(this, strMsg);
		//	//		lblMsg.Text = "修改记录成功!";
		//	//		return true; 
		//	//	}

		//	//}
		//}

		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjViewRegion">数据传输的目的类对象</param>
		private void PutDataToViewRegionClass(clsViewRegionEN pobjViewRegion)
		{
			pobjViewRegion.RegionName = wucViewRegion1.RegionName;
			pobjViewRegion.PrjId = clsPubVar.CurrSelPrjId;
			pobjViewRegion.RegionTypeId = wucViewRegion1.RegionTypeId;
			pobjViewRegion.RegionFunction = wucViewRegion1.RegionFunction;

			pobjViewRegion.INOUTTypeId = wucViewRegion1.INOUTTypeId;
			pobjViewRegion.TabId = wucViewRegion1.TabId;
			pobjViewRegion.Height = wucViewRegion1.Height;
			pobjViewRegion.Width = wucViewRegion1.Width;
            pobjViewRegion.ColNum = wucViewRegion1.ColNum;
			pobjViewRegion.Memo = wucViewRegion1.Memo;
		}

		protected void dgViewRegion_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortViewRegionBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgViewRegion.Columns.Count;i++)
				{
					strSortEx = this.dgViewRegion.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortViewRegionBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortViewRegionBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgViewRegion_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string lngRegionId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngRegionId = e.Item.Cells[1].Text;
				RegionId = lngRegionId;
				switch(strCommandName)
				{
					case "Delete":
						clsViewRegionBL.DelRecord(lngRegionId);
						BindDg_ViewRegion();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(lngRegionId);
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
					Set_DataGridAllChecked(dgViewRegion, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgViewRegion, false);
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
			wucViewRegion1.ViewId = ViewId;
			lblErrMsg.Text = "";
			HideViewRegionListRegion();
            HideAllRegion();
			tabEditViewRegionRegion.Visible = true;
			tabViewRegion.Visible = true;
		}

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombineViewRegionCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsViewRegionBL.GetDataTable_ViewRegion(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewRegion信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("RegionId"); arrCnName.Add("区域Id");
			arrColName.Add("RegionName"); arrCnName.Add("区域名称");
			arrColName.Add("ViewId"); arrCnName.Add("界面ID");
			arrColName.Add("RegionTypeId"); arrCnName.Add("区域类型Id");
			arrColName.Add("RegionFunction"); arrCnName.Add("区域功能");
			arrColName.Add("SQLDSTypeId"); arrCnName.Add("数据源类型");
			arrColName.Add("RelaTabId"); arrCnName.Add("相关表ID");
			arrColName.Add("Height"); arrCnName.Add("高度");
			arrColName.Add("Width"); arrCnName.Add("宽");
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
            List<string> arrRegionId = clsCommForWebForm. GetAllCheckedItemFromDg2(dgViewRegion, "chkCheckRec");
			if (arrRegionId == null || arrRegionId.Count == 0) 
			{
				lblErrMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblErrMsg.Text = "";
			//			string lngRegionId;
			//			lngRegionId = long.Parse(strRegionId);
			//			clsViewRegionBL.DelViewRegion(arrRegionId);
			clsViewRegionBLEx.DelViewRegionsEx(arrRegionId);
			BindDg_ViewRegion();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strRegionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewRegion);
			if (strRegionId == null || strRegionId.Trim().Length == 0) 
			{
				lblErrMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblErrMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			string lngRegionId;
			lngRegionId = strRegionId;

			ShowData(lngRegionId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "确认修改";	
			HideViewRegionListRegion();
			tabEditViewRegionRegion.Visible = true;
			tabViewRegion.Visible = true;
		}
		
		protected void dgViewRegion_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortViewRegionBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortViewRegionBy = e.SortExpression + " Asc";
				BindDg_ViewRegion();
				return ;
			}
			//检查原来是升序
			intIndex = strSortViewRegionBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortViewRegionBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortViewRegionBy = e.SortExpression + " Desc";
			}
			BindDg_ViewRegion();
		}

		private string strSortViewRegionBy
		{
			get
			{
				string sSortViewRegionBy;
				sSortViewRegionBy = (string)ViewState["SortViewRegionBy"];
				if (sSortViewRegionBy==null) 
				{
					sSortViewRegionBy = "";
				}
				return sSortViewRegionBy;
			}
			set
			{
				string sSortViewRegionBy = value;
				ViewState.Add("SortViewRegionBy", sSortViewRegionBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnViewRegionPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewRegion.CurrentPageIndex -=1; 
			this.BindDg_ViewRegion(); 
		}

		protected void btnViewRegionNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgViewRegion.CurrentPageIndex +=1; 
			this.BindDg_ViewRegion(); 
		}

		protected void btnViewRegionJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtViewRegionJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtViewRegionJump2Page.Text)>0 && 
				int.Parse(this.txtViewRegionJump2Page.Text)-1<this.dgViewRegion.PageCount) 
			{ 
				this.dgViewRegion.CurrentPageIndex=int.Parse(this.txtViewRegionJump2Page.Text)-1; 
			} 
			this.BindDg_ViewRegion();
		}

		protected void ddlSQLDSTypeId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		}
		//编辑区域字段
		protected void btnEditRegionFld_Click(object sender, System.EventArgs e)
		{
			string strRegionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewRegion);
			if (strRegionId == null || strRegionId.Trim().Length == 0) 
			{
				lblErrMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblErrMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			string lngRegionId;
			lngRegionId = strRegionId;

			BackViewRegionLinkStr = "../View/wfmViewRegion_QUDI.aspx";
			RegionId = lngRegionId;
			string strRegionTypeId = clsViewRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId).RegionTypeId;
			if (strRegionTypeId == "0001")		//查询区域
			{
				Response.Redirect("../View/wfmQryRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0002")	//列表区域
			{
				Response.Redirect("../View/wfmDGRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0003")		//编辑区域
			{
				Response.Redirect("../View/wfmEditRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0004")		//ListView区域
			{
				Response.Redirect("../View/wfmListViewRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == "0005")		//树形区域
			{
				Response.Redirect("../View/wfmEditRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == clsRegionTypeENEx.EXCELEXPORT_REGION)		//树形区域
			{
				Response.Redirect("../View/wfmExcelExportRegionFlds_QUDI.aspx");
			}
			else if (strRegionTypeId == clsRegionTypeENEx.DETAILREGION)		//树形区域
			{
				Response.Redirect("../View/wfmDetailRegionFlds_QUDI.aspx");
			}

		}

		protected void chkQueryRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkQueryRegion.Checked == true)
            {
                txtFileName_QueryRegion.Text = "查询区域";
            }
            else
            {
                txtFileName_QueryRegion.Text = "";
            }
		}

		protected void chkDGRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkDGRegion.Checked == true)
            {
                txtFileName_DGRegion.Text = "列表区域";
            }
            else
            {
                txtFileName_DGRegion.Text = "";
            }
		}

		//protected void chkListViewRegion_CheckedChanged(object sender, System.EventArgs e)
		//{
  //          if (chkListViewRegion.Checked == true)
  //          {
  //              txtFileName_ListViewRegion.Text = "ListView区域";
  //          }
  //          else
  //          {
  //              txtFileName_ListViewRegion.Text = "";
  //          }
		//}

		protected void chkEditRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkEditRegion.Checked == true)
            {
                txtFileName_EditRegion.Text = "编辑区域";
            }
            else
            {
                txtFileName_EditRegion.Text = "";
            }
		}

		protected void chkDetailRegion_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkDetailRegion.Checked == true)
			{
				txtFileName_DetailRegion.Text = "详细信息区域";
			}
		}

		protected void chkTreeViewRegion_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkTreeViewRegion.Checked == true)
            {
                txtFileName_TreeViewRegion.Text = "树区域";
            }
            else
            {
                txtFileName_TreeViewRegion.Text = "";
            }
		}

		protected void btnStartGene_Click(object sender, System.EventArgs e)
		{
			StringBuilder sbWhereCond = new StringBuilder();
			//如果选择查询区域
			try
			{
				if (chkQueryRegion.Checked == true && txtFileName_QueryRegion.Text.Trim() != "")
				{
					///添加区域及区域字段，该函数是ViewInfo的相关函数，
					///有三个参数：1、视图ID(ViewId)
					///				2、区域类型()
					///				3、数据源类型ID
					///				4、数据源表ID()
					///		
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //视图ID(ViewId)
						clsRegionTypeENEx.QUERYREGION,				//区域类型
                        clsCommonSession.UserId,
                                                txtFileName_QueryRegion.Text.Trim()								//区域名称

                        );
				}
				//如果选择列表区域
				if (chkDGRegion.Checked == true && txtFileName_DGRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //视图ID(ViewId)
						clsRegionTypeENEx.DGREGION,				//区域类型
                        clsCommonSession.UserId,
                                                txtFileName_DGRegion.Text.Trim()							//区域名称
                        );
				}
				////如果选择ListView区域
				//if (chkListViewRegion.Checked == true && txtFileName_ListViewRegion.Text.Trim() != "")
				//{
				//	clsViewInfoBLEx.ImportRegionAndFlds(ViewId, //视图ID(ViewId)
				//		clsRegionTypeENEx.LISTVIEWREGION,				//区域类型
				//		txtFileName_ListViewRegion.Text.Trim()								//区域名称
				//		);
				//}
				//如果选择编辑区域
				if (chkEditRegion.Checked == true && txtFileName_EditRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //视图ID(ViewId)
						clsRegionTypeENEx.EDITREGION,				//区域类型

                        clsCommonSession.UserId,
                                                txtFileName_EditRegion.Text.Trim()								//区域名称
                        );
				}
				//如果选择Excel导出区域
				if (chkExcelExportRegion.Checked == true && txtFileName_ExcelExportRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //视图ID(ViewId)
						clsRegionTypeENEx.EXCELEXPORT_REGION,				//区域类型

                        clsCommonSession.UserId,
                                                txtFileName_ExcelExportRegion.Text.Trim()								//区域名称
                        );
				}
				//如果选择详细信息区域
				if (chkDetailRegion.Checked == true && txtFileName_DetailRegion.Text.Trim() != "")
				{
					clsViewInfoBLEx.ImportRegionAndFlds1(ViewId, //视图ID(ViewId)
						clsRegionTypeENEx.DETAILREGION,				//区域类型
                        clsCommonSession.UserId,
                                                txtFileName_DetailRegion.Text.Trim()		//区域名称
                        );
				}
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindDg_ViewRegion();
			divViewRelaRegion.Visible = false;
		}

		protected void btnCloseDiv_Click(object sender, System.EventArgs e)
		{
			divViewRelaRegion.Visible = false;
		}

		protected void btnAddRelaJspView_Click(object sender, System.EventArgs e)
		{
			divViewRelaRegion.Visible = true;
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewInfoLinkStr);
		}

		protected void chkExcelExportRegion_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkExcelExportRegion.Checked == true)
			{
				txtFileName_ExcelExportRegion.Text = "Excel导出区域";
			}
		}

		protected void btnUpdSpecialProperty_Click(object sender, System.EventArgs e)
		{
			string strRegionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgViewRegion);
			if (strRegionId == null || strRegionId.Trim().Length == 0) 
			{
				lblErrMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblErrMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			string lngRegionId;
			lngRegionId = strRegionId;
			ShowSpecialData(lngRegionId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "特殊属性确认修改";	
			HideViewRegionListRegion();
		}
		private void HideAllRegion()
		{
			tabDGRegion.Visible = false;
			tabEditRegion.Visible = false;
			tabViewRegion.Visible = false;
			tabListViewRegion.Visible = false;
			tabQryRegion.Visible = false;
			tabEditViewRegionRegion.Visible = false;
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="lngRegionId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowSpecialData(string lngRegionId)
		{
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            HideAllRegion();
			tabEditViewRegionRegion.Visible = true;
			//1、检查关键字是否为空；
			if (string.IsNullOrEmpty( lngRegionId )== true) return ;		//如果关键字为空就返回退出
			RegionId = lngRegionId;
			clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
			switch(objViewRegionEN.RegionTypeId)
			{
				case clsRegionTypeENEx.EDITREGION:	//编辑区域
					tabEditRegion.Visible = true;
					//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
					//if (clsEditRegionBL.IsExist(lngRegionId) == false)		//检查该关键字的记录是否存在
					//{
					//	string ss = "关键字为：" + lngRegionId + "的不存在!";
					//	clsCommonJsFunc.Alert(this, ss);
					//	return ;
					//}
					////3、用提供的关键字初始化一个类对象；
					//clsEditRegionEN objEditRegion = new clsEditRegionEN(lngRegionId);
     //               //4、获取类对象的所有属性；
     //               clsEditRegionBL .GetEditRegion(ref objEditRegion);
					//Session.Add("objEditRegion", objEditRegion);
					////5、把该对象的所有属性显示在界面上，在这里显示在表控件中
					//GetDataFromEditRegionClass(objEditRegion);

					break;
				case clsRegionTypeENEx.QUERYREGION:	//查询区域
					tabQryRegion.Visible = true;
					//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
					//if (clsQueryRegionBL.IsExist(lngRegionId) == false)		//检查该关键字的记录是否存在
					//{
					//	string ss = "关键字为：" + lngRegionId + "的不存在!";
					//	clsCommonJsFunc.Alert(this, ss);
					//	return ;
					//}
					////3、用提供的关键字初始化一个类对象；
					//clsQueryRegionEN objQryRegion = new clsQueryRegionEN(lngRegionId);
     //               //4、获取类对象的所有属性；
     //               clsQueryRegionBL .GetQueryRegion(ref objQryRegion);
					//Session.Add("objQryRegion", objQryRegion);
					////5、把该对象的所有属性显示在界面上，在这里显示在表控件中
					//GetDataFromQueryRegionClass(objQryRegion);

					break;
				case clsRegionTypeENEx.DGREGION:		//列表区域
					tabDGRegion.Visible = true;
					//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
					//if (clsDGRegionBL.IsExist(lngRegionId) == false)		//检查该关键字的记录是否存在
					//{
					//	string ss = "关键字为：" + lngRegionId + "的不存在!";
					//	clsCommonJsFunc.Alert(this, ss);
					//	return ;
					//}
					////3、用提供的关键字初始化一个类对象；
					//clsDGRegionEN objDGRegion = new clsDGRegionEN(lngRegionId);
     //               //4、获取类对象的所有属性；
     //               clsDGRegionBL .GetDGRegion(ref objDGRegion);
					//Session.Add("objDGRegion", objDGRegion);
					////5、把该对象的所有属性显示在界面上，在这里显示在表控件中
					//wucDGRegion1.Clear();
					//GetDataFromDGRegionClass(objDGRegion);
					break;	
				//case clsRegionTypeENEx.LISTVIEWREGION:	//LISTVIEW区域
				//	tabListViewRegion.Visible = true;
				//	//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
				//	if (clsDGRegionBL.IsExist(lngRegionId) == false)		//检查该关键字的记录是否存在
				//	{
				//		string ss = "关键字为：" + lngRegionId + "的不存在!";
				//		clsCommonJsFunc.Alert(this, ss);
				//		return ;
				//	}
				//	//3、用提供的关键字初始化一个类对象；
				//	clsDGRegionEN objListViewRegionEN = new clsDGRegionEN(lngRegionId);
				//	//4、获取类对象的所有属性；
				//	clsDGRegionBL.GetListViewRegion(ref objListViewRegionEN);
				//	Session.Add("objListViewRegionEN", objListViewRegionEN);
				//	//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
				//	GetDataFromListViewRegionClass(objListViewRegionEN);

				//	break;
				case clsRegionTypeENEx.EXCELEXPORT_REGION:	//EXCEL导出区域
					//					//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
					//					if (clsExcelExportRegion.IsExist(lngRegionId) == false)		//检查该关键字的记录是否存在
					//					{
					//						string ss = "关键字为：" + lngRegionId + "的不存在!";
					//						clsCommonJsFunc.Alert(this, ss);
					//						return ;
					//					}
					//					//3、用提供的关键字初始化一个类对象；
					//					clsExcelExportRegion objExcelExportRegion = new clsExcelExportRegion(lngRegionId);
					//					//4、获取类对象的所有属性；
					//					objExcelExportRegion.GetListViewRegion();
					//					Session.Add("objExcelExportRegion", objExcelExportRegion);
					//					//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
					//					GetDataFromEXListViewRegionClass(objExcelExportRegion);

					break;
				case clsRegionTypeENEx.DETAILREGION:	//详细区域
					break;
				case clsRegionTypeENEx.TREEVIEWREGION:	//树区域
					break;

			}
		}
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjEditRegion">数据传输的目的类对象</param>
		private void PutDataToEditRegionClass(clsEditRegionEN pobjEditRegion)
		{
			//pobjEditRegion.ColNum = wucEditRegion1.ColNum;
			pobjEditRegion.IsUseCtrl = wucEditRegion1.IsUseCtrl;
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjEditRegion">表实体类对象</param>
		private void GetDataFromEditRegionClass(clsEditRegionEN pobjEditRegion)
		{
			//wucEditRegion1.ColNum = pobjEditRegion.ColNum;
			wucEditRegion1.IsUseCtrl = pobjEditRegion.IsUseCtrl;
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjDGRegion">表实体类对象</param>
		private void GetDataFromDGRegionClass(clsDGRegionEN pobjDGRegion)
		{
			wucDGRegion1.DGStyleId = pobjDGRegion.DGStyleId;
			wucDGRegion1.Runat = pobjDGRegion.Runat;
			wucDGRegion1.FontSize = pobjDGRegion.FontSize;
			wucDGRegion1.FontName = pobjDGRegion.FontName;
			wucDGRegion1.AllowPaging = pobjDGRegion.AllowPaging;
			wucDGRegion1.PageSize = pobjDGRegion.PageSize;
			wucDGRegion1.AutoGenerateColumns = pobjDGRegion.AutoGenerateColumns;
			wucDGRegion1.AllowSorting = pobjDGRegion.AllowSorting;
			wucDGRegion1.IsRadio = pobjDGRegion.IsRadio;
			wucDGRegion1.IsCheck = pobjDGRegion.IsCheck;
			wucDGRegion1.IsJumpPage = pobjDGRegion.IsJumpPage;
			wucDGRegion1.IsHaveUpdBtn = pobjDGRegion.IsHaveUpdBtn;
			wucDGRegion1.IsHaveDelBtn = pobjDGRegion.IsHaveDelBtn;
			wucDGRegion1.IsHaveDetailBtn = pobjDGRegion.IsHaveDetailBtn;
			wucDGRegion1.IsInTab = pobjDGRegion.IsInTab;
			wucDGRegion1.Style_Zindex = pobjDGRegion.Style_Zindex;
			wucDGRegion1.Style_Left = pobjDGRegion.Style_Left;
			wucDGRegion1.Style_Position = pobjDGRegion.Style_Position;
			wucDGRegion1.Style_Top = pobjDGRegion.Style_Top;
			wucDGRegion1.Width = pobjDGRegion.Width;
			wucDGRegion1.Height = pobjDGRegion.Height;
			wucDGRegion1.Style = pobjDGRegion.Style;
			wucDGRegion1.ViewDgName = pobjDGRegion.ViewDgName;
			wucDGRegion1.Memo = pobjDGRegion.Memo;
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjDGRegion">数据传输的目的类对象</param>
		private void PutDataToDGRegionClass(clsDGRegionEN pobjDGRegion)
		{
			pobjDGRegion.DGStyleId = wucDGRegion1.DGStyleId;
			pobjDGRegion.Runat = wucDGRegion1.Runat;
			pobjDGRegion.FontSize = wucDGRegion1.FontSize;
			pobjDGRegion.FontName = wucDGRegion1.FontName;
			pobjDGRegion.AllowPaging = wucDGRegion1.AllowPaging;
			pobjDGRegion.PageSize = wucDGRegion1.PageSize;
			pobjDGRegion.AutoGenerateColumns = wucDGRegion1.AutoGenerateColumns;
			pobjDGRegion.AllowSorting = wucDGRegion1.AllowSorting;
			pobjDGRegion.IsRadio = wucDGRegion1.IsRadio;
			pobjDGRegion.IsCheck = wucDGRegion1.IsCheck;
			pobjDGRegion.IsJumpPage = wucDGRegion1.IsJumpPage;
			pobjDGRegion.IsHaveUpdBtn = wucDGRegion1.IsHaveUpdBtn;
			pobjDGRegion.IsHaveDelBtn = wucDGRegion1.IsHaveDelBtn;
			pobjDGRegion.IsHaveDetailBtn = wucDGRegion1.IsHaveDetailBtn;
			pobjDGRegion.IsInTab = wucDGRegion1.IsInTab;
			pobjDGRegion.Style_Zindex = wucDGRegion1.Style_Zindex;
			pobjDGRegion.Style_Left = wucDGRegion1.Style_Left;
			pobjDGRegion.Style_Position = wucDGRegion1.Style_Position;
			pobjDGRegion.Style_Top = wucDGRegion1.Style_Top;
			pobjDGRegion.Width = wucDGRegion1.Width;
			pobjDGRegion.Height = wucDGRegion1.Height;
			pobjDGRegion.Style = wucDGRegion1.Style;
			pobjDGRegion.ViewDgName = wucDGRegion1.ViewDgName;
			pobjDGRegion.Memo = wucDGRegion1.Memo;
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjListViewRegion">数据传输的目的类对象</param>
		private void PutDataToListViewRegionClass(clsDGRegionEN pobjListViewRegion)
		{
			pobjListViewRegion.FontName = wucListViewRegion1.FontName;
			pobjListViewRegion.FontSize = wucListViewRegion1.FontSize;
			pobjListViewRegion.IsCheck = wucListViewRegion1.IsCheck;
			pobjListViewRegion.Memo = wucListViewRegion1.Memo;
			pobjListViewRegion.ColNum = wucListViewRegion1.ColNum;
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjListViewRegion">表实体类对象</param>
		private void GetDataFromListViewRegionClass(clsDGRegionEN pobjListViewRegion)
		{
			wucListViewRegion1.FontName = pobjListViewRegion.FontName;
			wucListViewRegion1.FontSize = pobjListViewRegion.FontSize;
			wucListViewRegion1.IsCheck = pobjListViewRegion.IsCheck;
			wucListViewRegion1.Memo = pobjListViewRegion.Memo;
			wucListViewRegion1.ColNum = pobjListViewRegion.ColNum;
		}
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjQueryRegion">表实体类对象</param>
		private void GetDataFromQueryRegionClass(clsQueryRegionEN pobjQueryRegion)
		{
			//wucQryRegion1.ColNum = pobjQueryRegion.ColNum;
			wucQryRegion1.IsUseCtrl = pobjQueryRegion.IsUseCtrl;
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjQueryRegion">数据传输的目的类对象</param>
		private void PutDataToQueryRegionClass(clsQueryRegionEN pobjQueryRegion)
		{
			//pobjQueryRegion.ColNum = wucQryRegion1.ColNum;
			pobjQueryRegion.IsUseCtrl = wucQryRegion1.IsUseCtrl;
		}

		///修改存盘准备过程代码 for C#
		private void UpdateDGRegionRecordSave(clsDGRegionEN objDGRegion)
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
			if (!wucDGRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToDGRegionClass(objDGRegion);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
                //clsDGRegionBL .CheckPropertyNew(objDGRegion);
                ////6、把数据实体层的数据存贮到数据库中
                //clsDGRegionBL.UpdateBySql2(objDGRegion);
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
//			BindDg_DGRegion();
			wucDGRegion1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
		}

		///修改存盘准备过程代码 for C#
		private void UpdateDGRegionRecordSaveV5(clsDGRegionEN objDGRegion)
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
			if (!wucDGRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToDGRegionClass(objDGRegion);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				//clsDGRegionBL .CheckPropertyNew(objDGRegion);
    //            //6、把数据实体层的数据存贮到数据库中
    //            clsDGRegionBL.UpdateBySql2(objDGRegion);
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
			//			BindDg_DGRegion();
			wucDGRegion1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///修改存盘准备过程代码 for C#
		private void UpdateEditRegionRecordSaveV5(clsEditRegionEN objEditRegion)
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
			if (!wucEditRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToEditRegionClass(objEditRegion);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				 //clsEditRegionBL .CheckPropertyNew(objEditRegion);
     //           //6、把数据实体层的数据存贮到数据库中
     //           clsEditRegionBL.UpdateBySql2(objEditRegion);
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
			//			BindDg_EditRegion();
			wucEditRegion1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///修改存盘准备过程代码 for C#
		private void UpdateListViewRegionRecordSaveV5(clsDGRegionEN objListViewRegionEN)
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
			if (!wucListViewRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToListViewRegionClass(objListViewRegionEN);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				// clsDGRegionBL.CheckPropertyNew(objListViewRegionEN);
				////6、把数据实体层的数据存贮到数据库中
    //             clsDGRegionBL.UpdateBySql2(objListViewRegionEN);
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
			//			BindDg_ListViewRegion();
			wucListViewRegion1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///修改存盘准备过程代码 for C#
		private void UpdateQueryRegionRecordSaveV5(clsQueryRegionEN objQueryRegion)
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
			if (!wucQryRegion1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToQueryRegionClass(objQueryRegion);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
                //clsQueryRegionBL .CheckPropertyNew(objQueryRegion);
                ////6、把数据实体层的数据存贮到数据库中
                //clsQueryRegionBL.UpdateBySql2(objQueryRegion);

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
			//			BindDg_QueryRegion();
			wucQryRegion1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
		}
		private void UpdateRegionRecordSave(string lngRegionId)
		{
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
			//1、检查关键字是否为空；
			if (string.IsNullOrEmpty( lngRegionId )== true) return ;		//如果关键字为空就返回退出
			clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId_Cache(lngRegionId, clsPubVar.CurrSelPrjId);
			switch(objViewRegionEN.RegionTypeId)
			{
				case clsRegionTypeENEx.EDITREGION:	//编辑区域
					//clsEditRegionEN objEditRegion = (clsEditRegionEN) Session["objEditRegion"];
					//UpdateEditRegionRecordSaveV5(objEditRegion);		

					break;
				case clsRegionTypeENEx.QUERYREGION:	//查询区域
					//clsQueryRegionEN objQryRegion = new clsQueryRegionEN(lngRegionId);
					//UpdateQueryRegionRecordSaveV5(objQryRegion);
					break;
				case clsRegionTypeENEx.DGREGION:		//列表区域
					//clsDGRegionEN objDGRegion = new clsDGRegionEN(lngRegionId);
					//UpdateDGRegionRecordSave(objDGRegion);
					break;	
				//case clsRegionTypeENEx.LISTVIEWREGION:	//LISTVIEW区域
				//	clsDGRegionEN objListViewRegionEN = new clsDGRegionEN(lngRegionId);
				//	UpdateListViewRegionRecordSaveV5(objListViewRegionEN);

				//	break;
				case clsRegionTypeENEx.EXCELEXPORT_REGION:	//EXCEL导出区域
					//					clsExcelExportRegion objExcelExportRegion = new clsExcelExportRegion(lngRegionId);
					
					break;
				case clsRegionTypeENEx.DETAILREGION:	//详细区域
					break;
				case clsRegionTypeENEx.TREEVIEWREGION:	//树区域
					break;
			}
            HideAllRegion();
			DispViewRegionListRegion();

		}

		protected void btnClear_Click(object sender, System.EventArgs e)
		{
            HideAllRegion();

			btnOKUpd.Text = "添加";
			DispViewRegionListRegion();
		}
		private void DispViewRegionListRegion()
		{
            HideAllRegion();
			tabViewRegionDataGrid.Visible = true;
			tabViewRegionJumpPage.Visible = true;
		}
		private void HideViewRegionListRegion()
		{
			tabViewRegionDataGrid.Visible = false;
			tabViewRegionJumpPage.Visible = false;
		}

		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			BackViewRegionLinkStr = Page.Request.Url.AbsolutePath;
			Response.Redirect("../View/wfmPreviewViewRegion.aspx?ParentPage=ViewRegion");
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！",
                        qsParentPage, clsStackTrace.GetCurrClassFunction()));
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