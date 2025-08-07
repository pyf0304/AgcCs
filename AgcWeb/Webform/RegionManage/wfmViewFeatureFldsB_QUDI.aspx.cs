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
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;


using com.taishsoft.common;
using System.Text;
using AutoGCLib;
using AGC.web.treeview;
using com.taishsoft.web.treeview;

namespace AGC.Webform
{
	/// <summary>
	/// wfmViewFeatureFlds_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmViewFeatureFldsB_QUDI : CommWebPageBase
    {

		//生成有关的变量定义代码
		private const string ViewId4Potence="00260203";		//界面编号

        /// <summary>
        /// 是否自动添加区域：（是：true, 否：false）
        /// </summary>
        private string qsAutoAddRegion
        {
            get
            {
                string strAutoAddRegion = Request.QueryString["AutoAddRegion"] ?? "".ToString();
                if ((strAutoAddRegion != null) && (strAutoAddRegion != ""))
                {
                    return strAutoAddRegion;//Request.QueryString["id"] ?? "";
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

				//1、为下拉框设置数据源，绑定列表数据
				wucViewFeatureFlds1.SetDdl_CtlTypeId(false);
                wucViewFeatureFlds1.SetDdl_FieldTypeId();
                wucViewFeatureFlds1.SetDdl_DdlItemsOptionId();
                wucViewFeatureFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
                clsViewFeatureFldsBLEx.BindDdl_FeatureIdExByViewId1(ddlFeatureId, clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                if (string.IsNullOrEmpty(clsCommonSession.ViewId) == false)
                {
                    //trHidden.Visible = false;
                    //clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldIdq, clsCommonSession.qsTabId);
                    //wucTabFeatureFldsB1.SetDdl_FldId(clsCommonSession.qsTabId);
                    //wucTabFeatureFldsB1.HiddenTrTabId();
                    BindTv_ViewRegion_PrjFeature();
                }

                //开始设置数据源类型：
                
				strSortViewFeatureFldsBy = "SeqNum Asc";
				//2、显示无条件的表内容在DATAGRID中
				///
				if (string.IsNullOrEmpty( clsCommonSession.ViewId )==true)
				{
					return ;
				}
				BindGv_vViewFeatureFlds();
				//BindDg_PrjTabFld();
				
				tabEditViewFeatureFldsRegion.Visible = false;  //具体信息维护区域隐藏

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
		
        
		private string SimpleFName
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
        /// <summary>
        /// 用于排序的分类字段
        /// </summary>
        private string vsViewFeatureId
        {
            get
            {
                string strViewFeatureId;
                strViewFeatureId = (string)ViewState["ViewFeatureId"];
                if (strViewFeatureId == null)
                {
                    strViewFeatureId = "";
                }
                return strViewFeatureId;
            }
            set
            {
                string strViewFeatureId = value;
                ViewState.Add("ViewFeatureId", strViewFeatureId);
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
		

		///生成组合查询条件的代码
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombinevViewFeatureFldsCondition()
		{
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'


            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(clsCommonSession.ViewId,clsPubVar.CurrCmPrjId);

           
            string strWhereCond = string.Format(" 1=1 and {0} in (Select {0} From {1} Where {2} = '{3}') ",
                conViewFeatureFlds.ViewFeatureId, 
                clsvFeatureRegionFldsEN._CurrTabName, 
                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            if (string.IsNullOrEmpty(vsViewFeatureId) == false)
            {
                strWhereCond += string.Format(" And {0}='{1}'",
                       conViewFeatureFlds.ViewFeatureId, vsViewFeatureId);
            }
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conViewFeatureFlds.InUse);
            }

            return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindGv_vViewFeatureFldsBak()
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
			string strWhereCond = CombinevViewFeatureFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvViewFeatureFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			//int intPages = CalcPages(objDT.Rows.Count, this.dgViewFeatureFlds.PageSize);
			//if (intPages==0) 
			//{
			//	this.dgViewFeatureFlds.CurrentPageIndex = 0;
			//}
			//else if (this.dgViewFeatureFlds.CurrentPageIndex > intPages - 1) 
			//{
			//	this.dgViewFeatureFlds.CurrentPageIndex = intPages - 1;
			//}
			////	4、设置DATAGRID的数据源(DataSource)；
			//DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortViewFeatureFldsBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			//this.dgViewFeatureFlds.DataSource=objDV;
			////	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			//this.dgViewFeatureFlds.DataBind();

			
			////当前记录数
			//this.lblViewFeatureFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			////当前页数
			//this.lblViewFeatureFldsAllPages.Text = this.dgViewFeatureFlds.PageCount.ToString(); 
			////当前页序数
			//this.lblViewFeatureFldsCurrentPage.Text=(this.dgViewFeatureFlds.CurrentPageIndex+1).ToString();
			////当前即将跳到的页序数
			//this.txtViewFeatureFldsJump2Page.Text=(this.dgViewFeatureFlds.CurrentPageIndex+1).ToString();
			////如果当前页序数为0，则<前一页>按钮无效
			//if(this.dgViewFeatureFlds.CurrentPageIndex==0) 
			//{
			//	btnViewFeatureFldsPrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	btnViewFeatureFldsPrevPage.Enabled=true; 
			//} 
			////如果当前页序数已为最后一页，则<前一页>按钮无效
			//if(this.dgViewFeatureFlds.CurrentPageIndex==this.dgViewFeatureFlds.PageCount-1) 
			//{ 
			//	btnViewFeatureFldsNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	btnViewFeatureFldsNextPage.Enabled=true; 
			//} 
			////7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabViewFeatureFldsJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabViewFeatureFldsJumpPage.Visible = false; 
			//}
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
            wucvViewFeatureFlds4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vViewFeatureFlds();
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
			if (clsViewFeatureFldsBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngmId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsViewFeatureFldsEN objViewFeatureFlds = new clsViewFeatureFldsEN(lngmId);
            //4、获取类对象的所有属性；
            clsViewFeatureFldsBL .GetViewFeatureFlds(ref objViewFeatureFlds);
			Session.Add("objViewFeatureFlds", objViewFeatureFlds);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromViewFeatureFldsClass(objViewFeatureFlds);
			DispEditViewFeatureFldsRegion();
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjViewFeatureFlds">表实体类对象</param>
		private void GetDataFromViewFeatureFldsClass(clsViewFeatureFldsEN pobjViewFeatureFlds)
		{
            vsViewFeatureId = pobjViewFeatureFlds.ViewFeatureId;
            clsvFeatureRegionFldsEN objFeatureRegionFlds = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(pobjViewFeatureFlds.ViewFeatureId);
            wucViewFeatureFlds1.vsViewFeatureId = pobjViewFeatureFlds.ViewFeatureId;
            wucViewFeatureFlds1.ViewFeatureName = string.Format("{0}({1})", objFeatureRegionFlds.FeatureName, objFeatureRegionFlds.RegionName);
            wucViewFeatureFlds1.SetDdl_FldId(objFeatureRegionFlds.ReleTabId);
            wucViewFeatureFlds1.FldId = pobjViewFeatureFlds.ReleFldId;
            wucViewFeatureFlds1.FieldTypeId = pobjViewFeatureFlds.FieldTypeId;


            wucViewFeatureFlds1.LabelCaption = pobjViewFeatureFlds.LabelCaption;

            wucViewFeatureFlds1.CtlTypeId = pobjViewFeatureFlds.CtlTypeId;
            wucViewFeatureFlds1.CtrlId = pobjViewFeatureFlds.CtrlId;

            wucViewFeatureFlds1.SeqNum = pobjViewFeatureFlds.OrderNum ?? 0;
			wucViewFeatureFlds1.Memo = pobjViewFeatureFlds.Memo;

            wucViewFeatureFlds1.DdlItemsOptionId = pobjViewFeatureFlds.DdlItemsOptionId;
            wucViewFeatureFlds1.DsTabId = pobjViewFeatureFlds.DsTabId;

            wucViewFeatureFlds1.DsCondStr = pobjViewFeatureFlds.DsCondStr;
            wucViewFeatureFlds1.DsSqlStr = pobjViewFeatureFlds.DsSqlStr;
            wucViewFeatureFlds1.ItemsString = pobjViewFeatureFlds.ItemsString;

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
			clsViewFeatureFldsEN objViewFeatureFlds;
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
					if (!wucViewFeatureFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsViewFeatureFldsEN objViewFeatureFlds;	//定义对象
					objViewFeatureFlds = new clsViewFeatureFldsEN();	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToViewFeatureFldsClass(objViewFeatureFlds);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsViewFeatureFldsBL.CheckPropertyNew(objViewFeatureFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//6、把数据实体层的数据存贮到数据库中
					if (clsViewFeatureFldsBL.AddNewRecordBySql2(objViewFeatureFlds) == false) 
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
					BindGv_vViewFeatureFlds();
					wucViewFeatureFlds1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
                    DispViewFeatureFldsInfo();
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
					if (!wucViewFeatureFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objViewFeatureFlds = (clsViewFeatureFldsEN) Session["objViewFeatureFlds"];
					PutDataToViewFeatureFldsClass(objViewFeatureFlds);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsViewFeatureFldsBL.CheckPropertyNew(objViewFeatureFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//4、把数据实体层的数据修改同步到数据库中
					if (clsViewFeatureFldsBL .UpdateBySql2(objViewFeatureFlds) == false) 
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
					BindGv_vViewFeatureFlds();
					wucViewFeatureFlds1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					
					DispViewFeatureFldsInfo();

					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjViewFeatureFlds">数据传输的目的类对象</param>
		private void PutDataToViewFeatureFldsClass(clsViewFeatureFldsEN pobjViewFeatureFlds)
		{
            pobjViewFeatureFlds.ViewFeatureId = vsViewFeatureId;
            pobjViewFeatureFlds.ReleFldId = wucViewFeatureFlds1.FldId;
            pobjViewFeatureFlds.FieldTypeId = wucViewFeatureFlds1.FieldTypeId;

            pobjViewFeatureFlds.LabelCaption = wucViewFeatureFlds1.LabelCaption;

            pobjViewFeatureFlds.CtlTypeId = wucViewFeatureFlds1.CtlTypeId;
            pobjViewFeatureFlds.CtrlId = wucViewFeatureFlds1.CtrlId;

            pobjViewFeatureFlds.OrderNum = wucViewFeatureFlds1.SeqNum;
            pobjViewFeatureFlds.InUse = true;

            pobjViewFeatureFlds.UpdDate = wucViewFeatureFlds1.UpdDate;
			pobjViewFeatureFlds.UpdUser = UserId;
			pobjViewFeatureFlds.Memo = wucViewFeatureFlds1.Memo;
            pobjViewFeatureFlds.DsTabId = wucViewFeatureFlds1.DsTabId;
            pobjViewFeatureFlds.DsCondStr = wucViewFeatureFlds1.DsCondStr;
            pobjViewFeatureFlds.DsSqlStr = wucViewFeatureFlds1.DsSqlStr;
            pobjViewFeatureFlds.ItemsString = wucViewFeatureFlds1.ItemsString;

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
		
		private bool SetCheckedItemForDg(DataGrid objDg, int intColIndex, string strValue)
		{
			if(objDg.Items.Count==0)
			{
				return false;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					if (di.Cells[intColIndex].Text == strValue)
					{
						CheckBox chkCheckRec=(CheckBox)di.FindControl("chkCheckRec");
					    chkCheckRec.Checked = true;
						return true;
					}
				}
			}
			return false;
		}
		
		//当前记录数
		protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
		{
            //DispPrjTabFldsInfo();
            DispEditViewFeatureFldsRegion();
            //BindDg_PrjTabFld();
            btnOKUpd.Text = "确认添加";
            if (string.IsNullOrEmpty(vsViewFeatureId) == true)
            {
                clsCommonJsFunc.Alert(this, "请在左边功能-表功能树中选中一个界面功能！");
                return;
            }
            clsvFeatureRegionFldsEN objFeatureRegionFlds = clsvFeatureRegionFldsBL.GetObjByViewFeatureId(vsViewFeatureId);
            wucViewFeatureFlds1.SetDdl_FldId(objFeatureRegionFlds.ReleTabId);
            wucViewFeatureFlds1.ViewFeatureName = string.Format("{0}({1})", objFeatureRegionFlds.FeatureName, objFeatureRegionFlds.RegionName);

        }

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombinevViewFeatureFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsViewFeatureFldsBL.GetDataTable_ViewFeatureFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ViewFeatureFlds信息导出.xls";
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
            List<long> lstMId = wucvViewFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsViewFeatureFldsBL.DelRecord(lngmId);
            }
            clsViewFeatureFldsBLEx.ReOrder(vsViewFeatureId);
			BindGv_vViewFeatureFlds();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			//1、显示该关键字记录的内容在界面上；
		
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
		
		private string strSortViewFeatureFldsBy
		{
			get
			{
				string sSortViewFeatureFldsBy;
				sSortViewFeatureFldsBy = (string)ViewState["SortViewFeatureFldsBy"];
				if (sSortViewFeatureFldsBy==null) 
				{
					sSortViewFeatureFldsBy = "";
				}
				return sSortViewFeatureFldsBy;
			}
			set
			{
				string sSortViewFeatureFldsBy = value;
				ViewState.Add("SortViewFeatureFldsBy", sSortViewFeatureFldsBy);
			}
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
            if (string.IsNullOrEmpty(vsViewFeatureId) == true)
            {
                //                clsCommonJsFunc.Alert(this, "与界面相关的功能不需要相关字段，请联系管理员！");
                clsCommonJsFunc.Alert(this, "请选择一个与界面相关功能, 如果下拉框没有相关功能，说明本界面没有添加需要字段的功能！");
                ddlFeatureId.Focus();
                return;
            }

            //clsViewFeatureFldsBLEx.ImportRelaFlds(clsCommonSession.ViewId, RegionId, vsFeatureId4Classify, clsPubVar.CurrCmPrjId, clsCommonSession.UserId);
            BindGv_vViewFeatureFlds();
			///恢复<确认添加>变成<添加>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('与界面相关的主表字段信息复制成功！！')</script>");
		}

	
		

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispViewFeatureFldsInfo();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewRegionLinkStr);
		}

		protected void rblSQLDSType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//BindDg_PrjTabFld();
		}

		private void DispViewFeatureFldsInfo()
		{
			tabViewFeatureFldsDataGrid.Visible = true;
			
			tabEditViewFeatureFldsRegion.Visible = false;
			
			tabEditRegionPreview.Visible = true;
			tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{
			
			tabEditViewFeatureFldsRegion.Visible = false;
			tabViewFeatureFldsDataGrid.Visible = false;
			
			tabEditRegionPreview.Visible = false;
			tabCode.Visible = false;
		}
		private void DispEditViewFeatureFldsRegion()
		{
			tabViewFeatureFldsDataGrid.Visible = false;
			
			tabEditViewFeatureFldsRegion.Visible = true;
			tabEditRegionPreview.Visible = false;
			tabCode.Visible = false;
		}

		protected void btnPreView_Click(object sender, System.EventArgs e)
		{
			string strMsg;			
			string strViewId = clsCommonSession.ViewId;
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
                if (WebViewCode4Html.DispEditRegionCtrl(phEditRegion, objViewInfoENEx) == true)
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

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

			try
			{
				clsViewFeatureFldsBLEx.AdjustOrderNum("DOWN", lngmId, vsViewFeatureId);
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
			BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);



        }

        protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			
			try
			{
				clsViewFeatureFldsBLEx.AdjustOrderNum("UP", lngmId, vsViewFeatureId);
				
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
			BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsViewFeatureFldsBLEx.AdjustOrderNum("FIRST", lngmId, vsViewFeatureId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvViewFeatureFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsViewFeatureFldsBLEx.AdjustOrderNum("LAST", lngmId, vsViewFeatureId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vViewFeatureFlds();
            wucvViewFeatureFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsViewFeatureFldsBLEx.ReOrder(vsViewFeatureId);
			BindGv_vViewFeatureFlds();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispViewFeatureFldsInfo();
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


        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvViewFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsViewFeatureFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                BindGv_vViewFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvViewFeatureFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsViewFeatureFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                BindGv_vViewFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void chkOnlyShowFldInUse_CheckedChanged(object sender, EventArgs e)
        {
            BindGv_vViewFeatureFlds();
        }
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewFeatureFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateViewFeatureFldsRecord(lngmId);
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateViewFeatureFldsRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            //btnCancelViewFeatureFldsEdit.Text = "取消修改";
            //lblMsgEdit.Text = "";
            DispEditViewFeatureFldsRegion();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvViewFeatureFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteViewFeatureFldsRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteViewFeatureFldsRecord(long lngmId)
        {
            try
            {
                clsViewFeatureFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                return;
            }
            BindGv_vViewFeatureFlds();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vViewFeatureFlds()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevViewFeatureFldsCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvViewFeatureFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convViewFeatureFlds.InUse));
                wucvViewFeatureFlds4Gv1.SetSortBy(string.Format("{0}", convViewFeatureFlds.OrderNum));

                wucvViewFeatureFlds4Gv1.BindGv_ViewFeatureFlds(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvViewFeatureFlds4Gv1.SetGvVisibility(convViewFeatureFlds.UpdDate, false);
                //wucvViewFeatureFlds4Gv1.SetGvVisibility(convViewFeatureFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }

        //protected void ddlFeatureId_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddlFeatureId.SelectedIndex <= 0) return;
        //    string strFeatureId = ddlFeatureId.SelectedValue;
        //    vsFeatureId4Classify = strFeatureId;
        //    BindGv_vViewFeatureFlds();
        //}
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

        private void BindTv_ViewRegion_PrjFeature()
        {
            string strViewId = clsCommonSession.ViewId;
            if (string.IsNullOrEmpty(strViewId) == true) return;
            wucTreeView4ViewFeature.tmTreeModel = TreeModel.ViewRegion_ViewFeature;
            //wucTreeView4TabFeature.DependsOn = "Table";
            wucTreeView4ViewFeature.ViewId = strViewId;
			//wucTreeView4TabFeature.IsUseJsEvent = true;
			wucTreeView4ViewFeature.PrjId = clsPubVar.CurrSelPrjId;// "0116";
			wucTreeView4ViewFeature.CmPrjId = clsPubVar.CurrCmPrjId;// "0116";

			wucTreeView4ViewFeature.BindTv();
            //wucTreeView4ViewFeature.Expand(1);
            //wucTreeView4TabFeature.afterSelect_Tz += wucTreeView4TabFeature_afterSelect_Tz;
            string strKeyId = vsKeyId;
            string strTypeName = vsTreeNodeType;
            //wucTreeView4TabFeature.CollapseAll();
            //            wucTreeView4TabFeature.SelectNodeEx(strTypeName, strKeyId);
            wucTreeView4ViewFeature.ExpandAll();

            //            wucTreeView4TabFeature.Nodes[1].Expand();
        }
        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }


        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }

        protected void wucTreeView4ViewFeature_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strKeyId = e.KeyId;
            string strTypeName = e.NodeType;
            string strMsg = string.Format("strKeyId={0}, strTypeName={1}", strKeyId, strTypeName);
            //wucTreeView4TabFeature.CollapseAll();
            wucTreeView4ViewFeature.SelectNode(strTypeName, strKeyId);
            List<string> arrCurrPathNodeKeyIdLst = wucTreeView4ViewFeature.GetCurrPathNodeKeyIdLst();
            wucTreeView4ViewFeature.SelectNodeEx(arrCurrPathNodeKeyIdLst);

            if (strTypeName == clsFeatureRegionFldsEN._CurrTabName)
            {
                string strRegionId = arrCurrPathNodeKeyIdLst[0];
                ddlFeatureIdq.SelectedValue = strKeyId;
                //string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                //    clsTabFeatureEN.con_ViewId, clsCommonSession.qsTabId,
                //    clsTabFeatureEN.con_FeatureId, strKeyId);

                vsViewFeatureId = strKeyId;
                wucViewFeatureFlds1.vsViewFeatureId = vsViewFeatureId;
                BindGv_vViewFeatureFlds();
                return;
            }
            if (strTypeName != clsTabFeatureEN._CurrTabName) return;
            //string strTabFeatureId = strKeyId;
            //vsTabFeatureId = strTabFeatureId;
            BindGv_vViewFeatureFlds();
        }
        protected void btnRefreshTv_Click(object sender, EventArgs e)
        {
            BindTv_ViewRegion_PrjFeature();
        }

        protected void btnDeleteTabFeature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsFeatureId) == true)
            {
                string strMsg = string.Format("请在树中选择一个界面功能.(In {0})", clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                clsTabFeatureBLEx.DelRecordEx(vsFeatureId, clsPubVar.CurrSelPrjId);
                BindTv_ViewRegion_PrjFeature();
                BindGv_vViewFeatureFlds();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在删除记录时出错！错误：{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }

        protected string vsFeatureId
        {
            get
            {
                string sFeatureId;
                sFeatureId = (string)ViewState["FeatureId"];
                if (sFeatureId == null)
                {
                    sFeatureId = "";
                }
                return sFeatureId;
            }
            set
            {
                string sFeatureId = value;
                ViewState.Add("FeatureId", sFeatureId);
            }
        }

        protected void btnCancelFeatureRegionFldsEdit_Click(object sender, EventArgs e)
        {
            DispViewFeatureFldsInfo();
        }
    }
}