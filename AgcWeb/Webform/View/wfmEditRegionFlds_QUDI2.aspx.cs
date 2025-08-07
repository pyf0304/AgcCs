///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmEditRegionFlds_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmEditRegionFlds_QUDI2 : CommWebPageBase
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
				if (clsCommonSession.ApplicationTypeId == (int)enumApplicationType.IOSApp_6
               || clsCommonSession.ApplicationTypeId == (int)enumApplicationType.IOSApp_WA_22)
                {
                    wucEditRegionFlds1.SetDdl_CtlTypeId(true);
                }
                else
                {
                    wucEditRegionFlds1.SetDdl_CtlTypeId(false);
                }
                wucEditRegionFlds1.SetDdl_DdlItemsOptionId();
                wucEditRegionFlds1.SetDdl_DsTabId(clsPubVar.CurrSelPrjId);
				wucEditRegionFlds1.SetDdl_InOutTypeId();
                wucEditRegionFlds1.SetDdl_VarId(clsPubVar.CurrSelPrjId);

                clsPageDispModeBL.BindDdl_PageDispModeIdCache(ddlPageDispModeId);
                clsGCContainerTypeBL.BindDdl_ContainerTypeIdCache(ddlContainerTypeId);

                //开始设置数据源类型：
                
				strSortEditRegionFldsBy = "SeqNum Asc";
				//2、显示无条件的表内容在DATAGRID中
				///
				if (string.IsNullOrEmpty(seRegionId )== true)
				{
					return ;
				}
          
                clsvViewRegionEN objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(seRegionId, clsPubVar.CurrCmPrjId);
                wucEditRegionFlds1.SetDdl_FldId(objvViewRegion.TabId);

                vsIsDisp = objvViewRegion.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                vsInUse = objvViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);

                vsViewId = clsCommonSession.ViewId;
                txtColNum.Text = objvViewRegion.ColNum.ToString();
                ddlPageDispModeId.SelectedValue = objvViewRegion.PageDispModeId;
                ddlContainerTypeId.SelectedValue = objvViewRegion.ContainerTypeId;

                txtWidth.Text = objvViewRegion.Width.ToString(); 
                chkInUse.Checked = objvViewRegion.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                chkIsDisp.Checked = objvViewRegion.IsDispInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                if (string.IsNullOrEmpty( objvViewRegion.ClsName) == true)
                {
                    clsViewRegionBLEx.SetClassName(seRegionId, 0);
                    objvViewRegion = clsvViewRegionBL.GetObjByRegionIdCache(seRegionId, clsPubVar.CurrCmPrjId);
                }
                txtClassName.Text = objvViewRegion.ClsName;
                txtFileName.Text = objvViewRegion.FileName;

                vsApplicationTypeId = objvViewRegion.ApplicationTypeId ?? 0;
                clsViewInfoBLEx.BindDdl_ViewIdByTabIdEx(ddlViewId, clsPubVar.CurrSelPrjId, objvViewRegion.TabId, vsViewId);

                BindGv_vEditRegionFlds();
				//BindDg_PrjTabFld();
				
				//tabEditEditRegionFldsRegion.Visible = false;  //具体信息维护区域隐藏
                //wucGenViewCode1.vsRegionId = 17097;
                //wucGenViewCode1.ShowCodeTypeButton();
				//3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
            }
            ShowCodeTypeButton();
            try
            {
          
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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


        private string seRegionId
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
		private string CombinevEditRegionFldsCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 and RegionId = '" + seRegionId + "'";
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conEditRegionFlds.InUse);
            }

            return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindGv_vEditRegionFldsBak()
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
			string strWhereCond = CombinevEditRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvEditRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			//int intPages = CalcPages(objDT.Rows.Count, this.dgEditRegionFlds.PageSize);
			//if (intPages==0) 
			//{
			//	this.dgEditRegionFlds.CurrentPageIndex = 0;
			//}
			//else if (this.dgEditRegionFlds.CurrentPageIndex > intPages - 1) 
			//{
			//	this.dgEditRegionFlds.CurrentPageIndex = intPages - 1;
			//}
			////	4、设置DATAGRID的数据源(DataSource)；
			//DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortEditRegionFldsBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			//this.dgEditRegionFlds.DataSource=objDV;
			////	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			//this.dgEditRegionFlds.DataBind();

			
			////当前记录数
			//this.lblEditRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			////当前页数
			//this.lblEditRegionFldsAllPages.Text = this.dgEditRegionFlds.PageCount.ToString(); 
			////当前页序数
			//this.lblEditRegionFldsCurrentPage.Text=(this.dgEditRegionFlds.CurrentPageIndex+1).ToString();
			////当前即将跳到的页序数
			//this.txtEditRegionFldsJump2Page.Text=(this.dgEditRegionFlds.CurrentPageIndex+1).ToString();
			////如果当前页序数为0，则<前一页>按钮无效
			//if(this.dgEditRegionFlds.CurrentPageIndex==0) 
			//{
			//	btnEditRegionFldsPrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	btnEditRegionFldsPrevPage.Enabled=true; 
			//} 
			////如果当前页序数已为最后一页，则<前一页>按钮无效
			//if(this.dgEditRegionFlds.CurrentPageIndex==this.dgEditRegionFlds.PageCount-1) 
			//{ 
			//	btnEditRegionFldsNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	btnEditRegionFldsNextPage.Enabled=true; 
			//} 
			////7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabEditRegionFldsJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabEditRegionFldsJumpPage.Visible = false; 
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
            wucvEditRegionFlds4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vEditRegionFlds();
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
			if (clsEditRegionFldsBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngmId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsEditRegionFldsEN objEditRegionFlds = new clsEditRegionFldsEN(lngmId);
            //4、获取类对象的所有属性；
            clsEditRegionFldsBL .GetEditRegionFlds(ref objEditRegionFlds);
			Session.Add("objEditRegionFlds", objEditRegionFlds);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromEditRegionFldsClass(objEditRegionFlds);
			//DispEditEditRegionFldsRegion();
		}

        private void ShowData(string strCtrlId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            //if (lngmId == 0) return;        //如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；

            //if (clsEditRegionFldsBL.IsExist(lngmId) == false)       //检查该关键字的记录是否存在
            //{
            //    string ss = "关键字为：" + lngmId + "的不存在!";
            //    clsCommonJsFunc.Alert(this, ss);
            //    return;
            //}
            //3、用提供的关键字初始化一个类对象；
            string strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
            if (string.IsNullOrEmpty(strFldName) == true)
            {
                string strMsg = string.Format("根据[控件Id:{0}]获取字段名(FldName)不成功！", strCtrlId);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

            string strCondition = new clsvEditRegionFldsEN()
                .SetFldName(strFldName, "=")
                .SetRegionId(seRegionId, "=")
                .GetCombineCondition();
            long lngMid = clsvEditRegionFldsBL.GetFirstID_S(strCondition);
            if (lngMid == 0)
            {
                string strMsg = string.Format("根据条件[{0}]获取关键字不成功！", strCondition);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            clsEditRegionFldsEN objEditRegionFlds = new clsEditRegionFldsEN(lngMid);
            //4、获取类对象的所有属性；
            clsEditRegionFldsBL.GetEditRegionFlds(ref objEditRegionFlds);
            Session.Add("objEditRegionFlds", objEditRegionFlds);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromEditRegionFldsClass(objEditRegionFlds);
            //DispEditEditRegionFldsRegion();
        }

        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjEditRegionFlds">表实体类对象</param>
        private void GetDataFromEditRegionFldsClass(clsEditRegionFldsEN pobjEditRegionFlds)
		{
			wucEditRegionFlds1.FldId = pobjEditRegionFlds.FldId;


            clsvEditRegionFldsEN objvEditRegionFlds = clsvEditRegionFldsBL.GetFirstObj_S("RegionId = '" + seRegionId + "' and FldId = '" + pobjEditRegionFlds.FldId+"'");
            //         wucEditRegionFlds1.FldName = objvEditRegionFlds.FldName;
            wucEditRegionFlds1.LabelCaption = pobjEditRegionFlds.LabelCaption;

            wucEditRegionFlds1.CtlTypeId = pobjEditRegionFlds.CtlTypeId;
            if (pobjEditRegionFlds.CtlTypeId == enumCtlType.DropDownList_06)
            {
                wucEditRegionFlds1.SetDdl_CallTabFeatureId(pobjEditRegionFlds.FldId, pobjEditRegionFlds.PrjId);
                wucEditRegionFlds1.CallTabFeatureId = pobjEditRegionFlds.CallTabFeatureId;
            }
            wucEditRegionFlds1.VarId = pobjEditRegionFlds.VarId;
            wucEditRegionFlds1.DefaultValue = pobjEditRegionFlds.DefaultValue;

            wucEditRegionFlds1.DdlItemsOptionId = pobjEditRegionFlds.DdlItemsOptionId;
			wucEditRegionFlds1.DsTabId = pobjEditRegionFlds.DsTabId;

            wucEditRegionFlds1.DsCondStr = pobjEditRegionFlds.DsCondStr;
			wucEditRegionFlds1.DsSqlStr = pobjEditRegionFlds.DsSqlStr;
			wucEditRegionFlds1.ItemsString = pobjEditRegionFlds.ItemsString;
			wucEditRegionFlds1.InOutTypeId = pobjEditRegionFlds.InOutTypeId;
            wucEditRegionFlds1.SeqNum = pobjEditRegionFlds.SeqNum ?? 0;
            wucEditRegionFlds1.Width = pobjEditRegionFlds.Width ?? 0;
            wucEditRegionFlds1.ColSpan = pobjEditRegionFlds.ColSpan ?? 0;
            wucEditRegionFlds1.ClickEvent = pobjEditRegionFlds.ClickEvent;
            wucEditRegionFlds1.ChangeEvent = pobjEditRegionFlds.ChangeEvent;

            string strCtrlId = clsCtlTypeBLEx.GetCtrlId(pobjEditRegionFlds.CtlTypeId, objvEditRegionFlds.FldName);
            wucEditRegionFlds1.SetDefaEventName(strCtrlId);
            wucEditRegionFlds1.UpdDate = pobjEditRegionFlds.UpdDate;
			wucEditRegionFlds1.Memo = pobjEditRegionFlds.Memo;
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
			clsEditRegionFldsEN objEditRegionFlds;
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
					if (!wucEditRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsEditRegionFldsEN objEditRegionFlds;	//定义对象
					objEditRegionFlds = new clsEditRegionFldsEN();	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToEditRegionFldsClass(objEditRegionFlds);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//6、把数据实体层的数据存贮到数据库中
					if (clsEditRegionFldsBL.AddNewRecordBySql2(objEditRegionFlds) == false) 
					{
						strMsg = "添加不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "添加记录不成功!";
					}
					else
					{
                        clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "添加记录成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "添加记录成功!";
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindGv_vEditRegionFlds();
					wucEditRegionFlds1.Clear();		//清空控件中内容
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
					if (!wucEditRegionFlds1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objEditRegionFlds = (clsEditRegionFldsEN) Session["objEditRegionFlds"];
					PutDataToEditRegionFldsClass(objEditRegionFlds);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsEditRegionFldsBL.CheckPropertyNew(objEditRegionFlds);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

					//4、把数据实体层的数据修改同步到数据库中
					if (clsEditRegionFldsBL .UpdateBySql2(objEditRegionFlds) == false) 
					{
						strMsg = "修改记录不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "修改记录不成功!";
					}
					else
					{
                        clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                        strMsg = "修改记录成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "修改记录成功!";
                        hidCtrlId.Value = "";
					}
					//5、把修改后的内容显示在DATAGRID中
					BindGv_vEditRegionFlds();
					wucEditRegionFlds1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					
					DispEditRegionFldsInfo();

					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjEditRegionFlds">数据传输的目的类对象</param>
		private void PutDataToEditRegionFldsClass(clsEditRegionFldsEN pobjEditRegionFlds)
		{
			pobjEditRegionFlds.FldId = wucEditRegionFlds1.FldId;
            pobjEditRegionFlds.LabelCaption = wucEditRegionFlds1.LabelCaption;

            pobjEditRegionFlds.CtlTypeId = wucEditRegionFlds1.CtlTypeId;
            pobjEditRegionFlds.CallTabFeatureId = wucEditRegionFlds1.CallTabFeatureId;

            pobjEditRegionFlds.VarId = wucEditRegionFlds1.VarId;
            pobjEditRegionFlds.DefaultValue = wucEditRegionFlds1.DefaultValue;

            pobjEditRegionFlds.DdlItemsOptionId = wucEditRegionFlds1.DdlItemsOptionId;
			pobjEditRegionFlds.DsTabId = wucEditRegionFlds1.DsTabId;

            pobjEditRegionFlds.DsCondStr = wucEditRegionFlds1.DsCondStr;
			pobjEditRegionFlds.DsSqlStr = wucEditRegionFlds1.DsSqlStr;
			pobjEditRegionFlds.ItemsString = wucEditRegionFlds1.ItemsString;
			pobjEditRegionFlds.InOutTypeId = wucEditRegionFlds1.InOutTypeId;
            pobjEditRegionFlds.SeqNum = wucEditRegionFlds1.SeqNum;
            pobjEditRegionFlds.Width = wucEditRegionFlds1.Width;
            pobjEditRegionFlds.ColSpan = wucEditRegionFlds1.ColSpan;
            pobjEditRegionFlds.ClickEvent = wucEditRegionFlds1.ClickEvent;
            pobjEditRegionFlds.ChangeEvent = wucEditRegionFlds1.ChangeEvent;

            pobjEditRegionFlds.UpdDate = wucEditRegionFlds1.UpdDate;
			pobjEditRegionFlds.UpdUser = UserId;
			pobjEditRegionFlds.Memo = wucEditRegionFlds1.Memo;
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
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombinevEditRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsEditRegionFldsBL.GetDataTable_EditRegionFlds(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "EditRegionFlds信息导出.xls";
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
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsEditRegionFldsBL.DelRecord(lngmId);
            }
            clsEditRegionFldsBLEx.ReOrder(seRegionId);
            //clsViewRegionBLEx.SetFldCount(seRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
            if (string.IsNullOrEmpty( hidCtrlId.Value) == false)
            {
                lblMsg1.Text = "";
                //1、显示该关键字记录的内容在界面上；

                ShowData(hidCtrlId.Value);
                //2、清空提示信息的内容,同时使<确定修改>按钮可用；
                clsPubFun.SetButtonEnabled(btnOKUpd, true);
                btnOKUpd.Text = "确认修改";
                return;
            }
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
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
		
		private string strSortEditRegionFldsBy
		{
			get
			{
				string sSortEditRegionFldsBy;
				sSortEditRegionFldsBy = (string)ViewState["SortEditRegionFldsBy"];
				if (sSortEditRegionFldsBy==null) 
				{
					sSortEditRegionFldsBy = "";
				}
				return sSortEditRegionFldsBy;
			}
			set
			{
				string sSortEditRegionFldsBy = value;
				ViewState.Add("SortEditRegionFldsBy", sSortEditRegionFldsBy);
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
            //clsEditRegionFldsBLEx.
            clsEditRegionFldsBLEx.ImportRelaFlds(seRegionId, clsPubVar.CurrCmPrjId, UserId);
            //clsViewRegionBLEx.SetFldCount(seRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
			///恢复<确认添加>变成<添加>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('与界面相关的主表字段信息复制成功！！')</script>");
		}

		
		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispEditRegionFldsInfo();
		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(BackViewRegionLinkStr);
		}
        		
		private void DispEditRegionFldsInfo()
		{
			tabEditRegionFldsDataGrid.Visible = true;
		
		
		}
		private void DispPrjTabFldsInfo()
		{		
			//tabEditEditRegionFldsRegion.Visible = false;
			tabEditRegionFldsDataGrid.Visible = false;
			
	
			//tabCode.Visible = false;
		}
		private void DispEditEditRegionFldsRegionBak()
		{
			tabEditRegionFldsDataGrid.Visible = false;
			
			//tabEditEditRegionFldsRegion.Visible = true;
			
		}
        	
		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

			try
			{
				clsEditRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
			BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);



        }

        protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			
			try
			{
				clsEditRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
			BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsEditRegionFldsBLEx.AdjustSequenceNumber("FIRST", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvEditRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsEditRegionFldsBLEx.AdjustSequenceNumber("LAST", lngmId);
                clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
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
            BindGv_vEditRegionFlds();
            wucvEditRegionFlds4Gv1.SetCheckedItemForGv(lngmId);
        }

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsEditRegionFldsBLEx.ReOrder(seRegionId);
            clsEditRegionFldsBL.ReFreshCache(clsPubVar.CurrSelPrjId);
            clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispEditRegionFldsInfo();
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
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsEditRegionFldsBLEx.ReOrder(seRegionId);
                //clsViewRegionBLEx.SetFldCount(seRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
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
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsEditRegionFldsBLEx.ReOrder(seRegionId);
                //clsViewRegionBLEx.SetFldCount(seRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
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
            BindGv_vEditRegionFlds();
        }
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvEditRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateEditRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateEditRegionFldsRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            //btnCancelEditRegionFldsEdit.Text = "取消修改";
            //lblMsgEdit.Text = "";
            //DispEditEditRegionFldsRegion();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvEditRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteEditRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteEditRegionFldsRecord(long lngmId)
        {
            try
            {
                clsEditRegionFldsBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                return;
            }
            BindGv_vEditRegionFlds();
        }

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vEditRegionFlds()
        {
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevEditRegionFldsCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvEditRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convEditRegionFlds.InUse));
                wucvEditRegionFlds4Gv1.SetSortBy(string.Format("{0}", convEditRegionFlds.SeqNum));

                wucvEditRegionFlds4Gv1.BindGv_EditRegionFlds(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.TabName, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.CtlTypeName, true);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.LabelCaption, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.ColIndex, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.SeqNum, true);

                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.TabName, false);
                wucvEditRegionFlds4Gv1.SetGvVisibility("修改", false);
                wucvEditRegionFlds4Gv1.SetGvVisibility("删除", false);
                wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.InUse, false);

                //wucvEditRegionFlds4Gv1.SetGvVisibility(convEditRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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
            //litCode.Text = sbJs.ToString();
        }

        protected void btnCancelEditRegionFldsEdit_Click(object sender, EventArgs e)
        {
            DispEditRegionFldsInfo();
        }
                
        protected void btnSetColNum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtColNum.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入列数！");
                txtColNum.Focus();
                return;
            }
            int intColNum = int.Parse(txtColNum.Text);
            if (ddlPageDispModeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请输入页面显示模式！");
                ddlPageDispModeId.Focus();
                return;
            }
            string strPageDispModeId = ddlPageDispModeId.SelectedValue;
            if (ddlContainerTypeId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请输入控件容器类型！");
                ddlContainerTypeId.Focus();
                return;
            }
            string strContainerTypeId = ddlContainerTypeId.SelectedValue;



            if (string.IsNullOrEmpty(txtWidth.Text) == false)
            {
                try
                {
                    int intWidth = int.Parse(txtWidth.Text);
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(seRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                                    .SetColNum(intColNum)
                                .SetPageDispModeId(strPageDispModeId)
                                      .SetContainerTypeId(strContainerTypeId)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                        clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);

                }
            }
       
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetColSpan_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            if (string.IsNullOrEmpty(txtColSpan.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入跨列数！");
                txtColSpan.Focus();
                return;
            }
            int intColSpan = int.Parse(txtColSpan.Text);

            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetColSpan(lstMId, intColSpan, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；
                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetMultiLine_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void btnSetWidth_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvEditRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            if (string.IsNullOrEmpty(txtCtrlWidth.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入控件宽度！");
                txtColSpan.Focus();
            }
            int intWidth = int.Parse(txtCtrlWidth.Text);

            lblMsg1.Text = "";
            try
            {
                clsEditRegionFldsBLEx.SetWidth(lstMId, intWidth, clsCommonSession.UserId);
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                BindGv_vEditRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；
                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            //clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
            int intAppTypeId = clsCommonSession.ApplicationTypeId;

            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);


            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.EditRegion_0003)
                            .OrderBy(x => x.OrderNum).ToList();

            //添加与表-功能相关的函数

            int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)
                .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                .ToList();

            int intCount = 0;
            //string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View");
            //if (vsvViewRegion != null)
            //{
            //    arrObjLst_V2 = arrObjLst_V2.Where(x => x.RegionTypeId == vsvViewRegion.RegionTypeId).OrderBy(x => x.OrderNum);
            //}
            List<string> arrGroupName = arrObjLst_V2.Select(x => x.GroupName).Distinct().ToList();
            bool bolIsFirst = true;
            Label objLabel = null;
            foreach (string strGroupName in arrGroupName)
            {
                IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_Sel =
                    arrObjLst_V2.Where(x => x.GroupName == strGroupName);
                IEnumerable<string> arrCodeTypeId = arrObjLst_Sel.Select(x => x.CodeTypeId);
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel1 =
                   arrvFunction4GeneCodeObjLst.Where(x => arrCodeTypeId.Contains(x.FuncCodeTypeId));

                if (arrvFunction4GeneCodeObjLst_Sel1.Count() == 0)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(strGroupName) == false)
                {
                    if (bolIsFirst == false)
                    {
                        Label objLabel_Br = new Label();
                        objLabel_Br.Text = string.Format("<br/>", strGroupName);
                        //objLabel.AutoSize = true;
                        pnlCodeTypeLst.Controls.Add(objLabel_Br);
                    }
                    else
                    {
                        bolIsFirst = false;
                    }
                    objLabel = new Label();
                    objLabel.Text = string.Format("{0}: ", strGroupName);
                    //objLabel.AutoSize = true;
                    objLabel.ID = string.Format("lbl{0}", strGroupName);
                    //string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.CssClass = "text-secondary font-weight-bold";
                    objLabel.Attributes["Style"] = "margin-right:10px;margin-top:35px;left:0px;min-width:150px;";
                    pnlCodeTypeLst.Controls.Add(objLabel);
                }
                foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_V2)
                {
                    if (objInFor.GroupName != strGroupName) continue;
                    List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
                        arrvFunction4GeneCodeObjLst.Where(x => x.FuncCodeTypeId == objInFor.CodeTypeId).ToList();
           
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCode in arrvFunction4GeneCodeObjLst_Sel)
                    {
                        HtmlInputButton objHtmlInputButton = new HtmlInputButton();
                        objHtmlInputButton.ID = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);

                        objHtmlInputButton.Name = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);
                        objHtmlInputButton.Attributes["class"] = "btn btn-outline-primary btn-sm";
                        objHtmlInputButton.Value = string.Format("{0}-{1}({2})",
                            objInFor.CodeTypeName, objvFunction4GeneCode.FuncCHName4Code,
                            objInFor.ProgLangTypeName);

                        objHtmlInputButton.Attributes.Add("onclick", string.Format("GeneCode4Func('{0}','{1}','{2}','{3}')",
                            objInFor.CodeTypeId, clsCommonSession.ViewId, objvFunction4GeneCode.FuncId4GC, intAppTypeId));

                        //objButton.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;";

                        //objButton.Command += new CommandEventHandler(this.btnCodeType_Click);
                        pnlCodeTypeLst.Controls.Add(objHtmlInputButton);
                        intCount++;
                    }
                }

            }
            if (intCount == 0)
            {
                string strMsg = string.Format("应用:{0}({1})没有用于[View]相应的代码类型.(In {2})",
                    objvApplicationTypeEN.ApplicationTypeName, objvApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId, int intApplicationTypeId)
        {

            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

                //string strCodeText1 = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, clsPubConst.DataBaseType.MsSql, strTabId,
                //    strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
                //    ref strRe_FileNameWithModuleName);
                //string str
                var Re_objFunction4Code = new clsFunction4CodeEN();
                string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId, clsPubConst.DataBaseType.MsSql, strTabId,
               strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
               ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);

                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj(objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }

        protected void chkInUse_CheckedChanged(object sender, EventArgs e)
        {
           
            bool bolInUse = chkInUse.Checked;
            clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, seRegionId, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
            obj.SetInUse(bolInUse)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void btnSetClassName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入类名！");
                txtClassName.Focus();
            }
            if (string.IsNullOrEmpty(txtFileName.Text) == true)
            {
                clsCommonJsFunc.Alert(this, "请输入文件名！");
                txtFileName.Focus();
            }
            string strClassName = txtClassName.Text;
            string strFileName = txtFileName.Text;
            try
            {
                clsViewRegionEN obj = clsViewRegionBL.GetObjByRegionId(seRegionId);
            obj.SetClsName(strClassName)
                //.SetFileName(strFileName)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
                clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
                //wucViewRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }

        protected void txtClassName_TextChanged(object sender, EventArgs e)
        {
            
            int intApplicationTypeId = vsApplicationTypeId;
            switch (intApplicationTypeId)
            {
                case (int)enumApplicationType.WinApp_1:
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cs";

                    break;
                case (int)enumApplicationType.WebApp_2:

                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".aspx";

                    break;
                case (int)enumApplicationType.AndroidApp_5://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".xml";

                    break;
                case (int)enumApplicationType.WebApp_JS_RJ_28://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".html";

                    break;
                case (int)enumApplicationType.SpaAppInCore_TS_18://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".cshtml";

                    break;
                case (int)enumApplicationType.VueAppInCore_TS_30://                        enumApplicationType.AndroidApp_5
                    txtFileName.Text = txtClassName.Text.Trim().ToString() + ".vue";

                    break;
                default:
                    string strMsg = string.Format("应用:{0}在函数中没有被处理！", clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId));
                    clsCommonJsFunc.Alert(this, strMsg);
                    break;
            }
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        /// <summary>
        /// Sql数据类型Id， 参数：01：表；02:视图；
        /// </summary>
        public int vsApplicationTypeId
        {
            get
            {
                string strApplicationTypeId;
                strApplicationTypeId = (string)ViewState["ApplicationTypeId"];
                if (strApplicationTypeId == null)
                {
                    return 0;
                }
                return int.Parse( strApplicationTypeId);
            }
            set
            {
                string strApplicationTypeId = value.ToString();
                ViewState.Add("ApplicationTypeId", strApplicationTypeId);
            }
        }
        protected string vsViewId
        {
            get
            {
                string sViewId;
                sViewId = (string)ViewState["ViewId"];
                if (sViewId == null)
                {
                    sViewId = "";
                }
                return sViewId;
            }
            set
            {
                string sViewId = value;
                ViewState.Add("ViewId", sViewId);
            }
        }

        protected bool vsInUse
        {
            get
            {
                string sInUse;
                sInUse = (string)ViewState["InUse"];
                if (sInUse == null)
                {
                  return false;
                }
                return bool.Parse( sInUse);
            }
            set
            {
                string sInUse = value.ToString();
                ViewState.Add("InUse", sInUse);
            }
        }

        protected bool vsIsDisp
        {
            get
            {
                string sIsDisp;
                sIsDisp = (string)ViewState["IsDisp"];
                if (sIsDisp == null)
                {
                    return false;
                }
                return bool.Parse(sIsDisp);
            }
            set
            {
                string sIsDisp = value.ToString();
                ViewState.Add("IsDisp", sIsDisp);
            }
        }

        protected void btnCopyFromOtherView_Click(object sender, EventArgs e)
        {
            if (ddlViewId.SelectedIndex <= 0)
            {
                clsCommonJsFunc.Alert(this, "请选择一个要复制的页面！");
                ddlViewId.Focus();
                return;
            }
            string strViewId_S = ddlViewId.SelectedValue;
            List<clsViewRegionEN> arrViewRegionObjLst = clsViewRegionBLEx.GetObjLstByViewIdCache(strViewId_S, clsPubVar.CurrSelPrjId);
            List<string> arrRegionId = arrViewRegionObjLst
                .Where(x=>x.RegionTypeId == enumRegionType.EditRegion_0003)
                .Select(x => x.RegionId).ToList();
            if (arrRegionId.Count ==0)
            {
                var objViewInfoEN = clsViewInfoBL.GetObjByViewIdCache(strViewId_S, clsPubVar.CurrSelPrjId);
                clsCommonJsFunc.Alert(this, string.Format("被选界面：[{0}]没有编辑区！", objViewInfoEN.ViewName));
                ddlViewId.Focus();
                return;
            }
            clsEditRegionFldsBLEx.CopyTo1(arrRegionId[0], seRegionId, clsPubVar.CurrCmPrjId, clsCommonSession.UserId);
            BindGv_vEditRegionFlds();
        }
        protected void chkIsDisp_CheckedChanged(object sender, EventArgs e)
        {

            bool bolIsDisp = chkIsDisp.Checked;
            clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, seRegionId, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
            obj.SetIsDisp(bolIsDisp)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
            try
            {
                wucEditRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, chkInUse.Checked, chkIsDisp.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
    }
}