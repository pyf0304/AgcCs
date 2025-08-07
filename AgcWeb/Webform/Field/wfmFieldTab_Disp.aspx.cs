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
using System.Text;
using com.taishsoft.commdb;
using CommFunc4WebForm;

using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;


using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmFieldTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmFieldTab_Disp : CommWebPageBase
    {

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				//1、为下拉框设置数据源，绑定列表数据
				wucFieldTab1.SetDdl_PrjId();
				wucFieldTab1.SetDdl_FldType();
				wucFieldTab1.SetDdl_IsNull();
//				wucFieldTab1.SetDdl_IsPrimaryKey();
				wucFieldTab1.SetDdl_CodeTab();
                wucFieldTab1.SetLB_TabId(clsPubVar.CurrSelPrjId);

				clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
				BindDdl_IsNull(ddlIsNullq);
				BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);

                //				clsDropDownList.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
                clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleIdq, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);

				ddlFldStateIdq.SelectedValue = "01";


				strSortBy = "FldName Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindGv_FieldTab();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucFieldTab1.SetKeyReadOnly(true);
				tabLayout.Visible = false;
				
				
			}
		}

        private string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
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
                if (strErrMessage == null)
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


        
      
		private clsUsersEN objUserBak
		{
			get
			{
				clsUsersEN pobjUser;
				pobjUser = (clsUsersEN)Session["objUser"];
				if (pobjUser==null) 
				{
					pobjUser = null;
                    string strErrMessage = "用户对象为空,可能不用时间超时,Session丢失,需要重新登录!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
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
		private string CombineFieldTabCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
            string strWhereCond = " 1=1 and PrjId='" + clsPubVar.CurrSelPrjId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtFldNameq.Text.Trim()!="")
			{
				strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim()+"%'";
			}
			if (this.ddlFldTypeq.SelectedValue!="" && this.ddlFldTypeq.SelectedValue!="0")
			{
				strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue+"'";
			}
			if (this.ddlObjIdq.SelectedValue!="" && this.ddlObjIdq.SelectedValue!="0")
			{
				strWhereCond += " and Fldid in (select fldid from FldObjTab where ObjId='" + this.ddlObjIdq.SelectedValue+"')";
			}
			if (this.ddlIsNullq.SelectedValue=="是")
			{
				strWhereCond += " and IsNull='1'";
			}
			else if (this.ddlIsNullq.SelectedValue=="否")
			{
				strWhereCond += " and IsNull='0'";
			}
			if (this.ddlIsPrimaryKeyq.SelectedValue=="是")
			{
				strWhereCond += " and IsPrimaryKey='1'" ;
			}
			else if (this.ddlIsPrimaryKeyq.SelectedValue=="否")
			{
				strWhereCond += " and IsPrimaryKey='0'" ;
			}
			if (this.ddlFldStateIdq.SelectedValue!="" && this.ddlFldStateIdq.SelectedValue!="0")
			{
				strWhereCond += " And FldStateId='" + this.ddlFldStateIdq.SelectedValue+"'";
			}

			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
        protected void BindGv_FieldTab()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineFieldTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortFieldTabBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            this.gvFieldTab.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvFieldTab.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvFieldTab.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvFieldTab.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvFieldTab.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvFieldTab.PageIndex == this.gvFieldTab.PageCount - 1)
                {
                     clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
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

		/// <summary>
		/// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//把DATAGRID的当前页索引设置为0，即第1页。
			//当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.gvFieldTab.PageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindGv_FieldTab();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strFldID">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strFldID)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strFldID == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsFieldTabBL.IsExist(strFldID) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strFldID + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldID);
			Session.Add("objFieldTabEN", objFieldTabEN);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromFieldTabClass(objFieldTabEN);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjFieldTab">表实体类对象</param>
		private void GetDataFromFieldTabClass(clsFieldTabEN pobjFieldTab)
		{
			wucFieldTab1.FldId = pobjFieldTab.FldId;
			wucFieldTab1.PrjId = pobjFieldTab.PrjId;
			wucFieldTab1.FldName = pobjFieldTab.FldName;
			wucFieldTab1.DataTypeId = pobjFieldTab.DataTypeId;
            wucFieldTab1.FldLength = pobjFieldTab.FldLength;
            wucFieldTab1.FldPrecision = pobjFieldTab.FldPrecision ?? 0;

			wucFieldTab1.Caption = pobjFieldTab.Caption;
			wucFieldTab1.FldInfo = pobjFieldTab.FldInfo;
			wucFieldTab1.IsNull = pobjFieldTab.IsNull;
			wucFieldTab1.IsPrimaryKey = pobjFieldTab.IsPrimaryKey;
			wucFieldTab1.MaxValue = pobjFieldTab.MaxValue;
			wucFieldTab1.MinValue = pobjFieldTab.MinValue;
			wucFieldTab1.DefaultValue = pobjFieldTab.DefaultValue;
            var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(pobjFieldTab.FldId, pobjFieldTab.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                wucFieldTab1.IsNeedTransCode = true;
                wucFieldTab1.CodeTabId = objFieldTab4CodeConv.CodeTabId;
                wucFieldTab1.CodeTabNameId = objFieldTab4CodeConv.CodeTabNameId;
                wucFieldTab1.CodeTabCodeId = objFieldTab4CodeConv.CodeTabCodeId;
            }
			///设置对象列表
            List<ObjStruct> arrLst = new List<ObjStruct>();
            string strCondition = string.Format("{0} = '{1}'", 
                convPrjTabFld.FldId,
                pobjFieldTab.FldId);

            List<clsvPrjTabFldEN> arrvPrjTabFldLst = clsvPrjTabFldBL.GetObjLst(strCondition);
			ObjStruct objStruct;
			if (arrvPrjTabFldLst.Count>0)
			{
				foreach(clsvPrjTabFldEN objvPrjTabFldEN in arrvPrjTabFldLst)
				{
					objStruct.strObjId = objvPrjTabFldEN.TabId;
					objStruct.strObjName = objvPrjTabFldEN.TabName;
					arrLst.Add(objStruct);
				}
				wucFieldTab1.TabList = arrLst;
			}
		}
        protected string GetFirstCheckedItemFromGv(GridView objGv)
        {
            if (objGv.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox chkCheckRec = (CheckBox)di.FindControl("chkCheckRec");
                    if (chkCheckRec != null && chkCheckRec.Checked)
                    {
                        return di.Cells[1].Text;
                    }
                }
            }
            return "";
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
			clsFieldTabEN objFieldTabEN;
			
            List<ObjStruct> arrLst;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucFieldTab1.SetKeyReadOnly(false);
                    wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
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
					if (!wucFieldTab1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsFieldTabEN objFieldTabEN;	//定义对象
					objFieldTabEN = new clsFieldTabEN(wucFieldTab1.FldId);	//初始化新对象
				
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					if (clsFieldTabBL.IsExist(objFieldTabEN.FldId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToFieldTabClass(objFieldTabEN);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
					if (objFieldTabEN.AddRecordEx() == false) 
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
						arrLst = wucFieldTab1.TabList;
						//foreach(ObjStruct strObjId in arrLst)
						//{
						//	objFldObjTab.ObjId = strObjId.strObjId;
						//	if (clsFldObjTabBL .AddNewRecordBySql2(objFldObjTab) == false) break;
						//}
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindGv_FieldTab();
					wucFieldTab1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
					tabLayout.Visible = false;
					tabQuery.Visible = true;

					break;
				case "关闭":
					tabLayout.Visible = false;
					tabQuery.Visible = true;
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjFieldTab">数据传输的目的类对象</param>
		private void PutDataToFieldTabClass(clsFieldTabEN pobjFieldTab)
		{
			pobjFieldTab.FldId = wucFieldTab1.FldId;
			pobjFieldTab.PrjId = wucFieldTab1.PrjId;
			pobjFieldTab.FldName = wucFieldTab1.FldName;
			pobjFieldTab.DataTypeId = wucFieldTab1.DataTypeId;
			pobjFieldTab.FldLength = wucFieldTab1.FldLength;
			pobjFieldTab.Caption = wucFieldTab1.Caption;
			pobjFieldTab.FldInfo = wucFieldTab1.FldInfo;
			pobjFieldTab.IsNull = wucFieldTab1.IsNull;
			pobjFieldTab.IsPrimaryKey = wucFieldTab1.IsPrimaryKey;
			pobjFieldTab.MaxValue = wucFieldTab1.MaxValue;
			pobjFieldTab.MinValue = wucFieldTab1.MinValue;
			pobjFieldTab.DefaultValue = wucFieldTab1.DefaultValue;
            //var objFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjByFldIdCache(pobjFieldTab.FldId, pobjFieldTab.PrjId);
            //if (objFieldTab4CodeConv != null)
            //{

            //    pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
            //    pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
            //    pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
            //    pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
            //}
			pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
			pobjFieldTab.UpdUser = wucFieldTab1.UserId;

        }

		protected void gvFieldTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
//				System.Web.UI.WebControls.LinkButton myDeleteButton;
//				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
//				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
			int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.gvFieldTab.Columns.Count;i++)
				{
					strSortEx = this.gvFieldTab.Columns[i].SortExpression;
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
		
		public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("请选择...","0");
			objDDL.Items.Add("是");
			objDDL.Items.Add("否");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//为下拉框设置内容的样例，该下拉框的列表项是直接添加的
			///objDDL.Items.Add("男");
			///objDDL.Items.Add("女");
		}
		public void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("请选择...","0");
			objDDL.Items.Add("是");
			objDDL.Items.Add("否");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//为下拉框设置内容的样例，该下拉框的列表项是直接添加的
			///objDDL.Items.Add("男");
			///objDDL.Items.Add("女");
		}

		/// <summary>
		/// 导入Excel文件的字段
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmImportFldInfoFromExcel.aspx");
		}

		protected void lbAddNewFld_Click(object sender, System.EventArgs e)
		{
			tabQuery.Visible = false;
			tabLayout.Visible = true;
			wucFieldTab1.SetKeyReadOnly(false);
            wucFieldTab1.PrjId = clsPubVar.CurrSelPrjId;
            
            wucFieldTab1.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(clsPubVar.CurrSelPrjId);
			btnOKUpd.Text = "确认添加";
		}

		protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmImportFldInfoFromSQL.aspx");
		
		}

		protected void lbDispFieldList_Click(object sender, System.EventArgs e)
		{
			tabQuery.Visible = true;
			tabLayout.Visible = false;
		}


		protected void gvFieldTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindGv_FieldTab();
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
			BindGv_FieldTab();

		}
        
        protected void gvFieldTab_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = vsSortFieldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
                BindGv_FieldTab();
                return;
            }
            //检查原来是升序
            intIndex = vsSortFieldTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                vsSortFieldTabBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                vsSortFieldTabBy = e.SortExpression + " Desc";
            }
            BindGv_FieldTab();
        }

		protected void btnExportExcel_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombineFieldTabCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "工程字段表信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("FldId"); arrCnName.Add("字段ID");
			arrColName.Add("FldName"); arrCnName.Add("字段名");
			arrColName.Add("Caption"); arrCnName.Add("标题");
			arrColName.Add("DataTypeName"); arrCnName.Add("字段类型");
			arrColName.Add("FldLength"); arrCnName.Add("字段长度");
			arrColName.Add("IsNull"); arrCnName.Add("是否可空");
			arrColName.Add("IsPrimaryKey"); arrCnName.Add("是否主键");
			arrColName.Add("IsIdentity"); arrCnName.Add("是否Identity");
			arrColName.Add("MaxValue"); arrCnName.Add("最大值");
			arrColName.Add("MinValue"); arrCnName.Add("最小值");
			arrColName.Add("DefaultValue"); arrCnName.Add("缺省值");
			arrColName.Add("PrjName"); arrCnName.Add("工程名称");
			arrColName.Add("CodeTab"); arrCnName.Add("代码表");
			arrColName.Add("CodeTabName"); arrCnName.Add("代码表_名称");
			arrColName.Add("CodeTabCode"); arrCnName.Add("代码表_代码");
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
			//			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
			///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			//Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End(); 
			return true;
		}

		protected void ddlFuncModuleId_q_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlFuncModuleIdq.SelectedIndex>0)
			{
				string strFuncModuleId = ddlFuncModuleIdq.SelectedValue;
            //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId, strFuncModuleId);
			}
		}
        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvFieldTab.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvFieldTab.PageCount)
                {
                    this.gvFieldTab.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_FieldTab();
            }
        }
        protected void gvFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];

                iNum[0] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsNull); //8;
                iNum[1] = clsCommForWebForm.GetIndexByDataField4GridView(gvFieldTab, convFieldTab.IsPrimaryKey); //9;
                for (int i = 0; i < 2; i++)
                {
                    if (e.Item.Cells[iNum[i]].Text == "True")
                    {
                        e.Item.Cells[iNum[i]].Text = "√";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Item.Cells[iNum[i]].Text = "×";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }
            }
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvFieldTab.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_FieldTab();
        }
        ///删除记录过程代码for C#
        protected void gvFieldTab_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvFieldTab.PageIndex = e.NewPageIndex;
                this.BindGv_FieldTab();
            }
        }
        ///删除记录过程代码for C#
        protected void gvFieldTab_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
                }
            }
            int intIndex;
            if (vsSortFieldTabBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvFieldTab.Columns.Count; i++)
                {
                    strSortEx = this.gvFieldTab.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = vsSortFieldTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = vsSortFieldTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }
        ///生成GridView行命令的事件代码
        protected void gvFieldTab_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "全选")
                    {
                        Set_GridViewAllChecked(gvFieldTab, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        Set_GridViewAllChecked(gvFieldTab, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }

        protected string vsSortFieldTabBy
        {
            get
            {
                string sSortFieldTabBy;
                sSortFieldTabBy = (string)ViewState["SortFieldTabBy"];
                if (sSortFieldTabBy == null)
                {
                    sSortFieldTabBy = "";
                }
                return sSortFieldTabBy;
            }
            set
            {
                string sSortFieldTabBy = value;
                ViewState.Add("SortFieldTabBy", sSortFieldTabBy);
            }
        }
        protected void Set_GridViewAllChecked(GridView objGv, bool IsSelected)
        {
            if (objGv.Rows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (GridViewRow di in objGv.Rows)
                {
                    CheckBox cb = (CheckBox)di.FindControl("chkCheckRec");
                    if (cb != null)
                    {
                        cb.Checked = IsSelected;
                    }
                }
            }
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            string strFldID = GetFirstCheckedItemFromGv(gvFieldTab);
            if (strFldID == null || strFldID.Trim().Length == 0)
            {
                lblMsgList.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsgList.Text = "";
            tabLayout.Visible = true;
            tabQuery.Visible = false;
            ShowData(strFldID);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            clsPubFun.SetButtonEnabled(btnOKUpd, true);
            wucFieldTab1.SetKeyReadOnly(true);
            btnOKUpd.Text = "关闭";
            lblMsg.Text = "";
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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
    }
}