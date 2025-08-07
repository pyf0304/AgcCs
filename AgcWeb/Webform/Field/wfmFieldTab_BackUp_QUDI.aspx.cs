using AGC.BusinessLogic;using AGC.FunClass;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;
///生成查询，修改，删除，添加记录的控制层代码
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmFieldTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmFieldTab_BackUp_QUDI :CommWebPageBase
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				lbDelFld.Attributes.Add("onclick", "return confirm('您真的要删除所选的记录吗？');");
				//1、为下拉框设置数据源，绑定列表数据
				wucFieldTab1.SetDdl_PrjId();
				wucFieldTab1.SetDdl_FldType();
				wucFieldTab1.SetDdl_IsNull();
//				wucFieldTab1.SetDdl_IsPrimaryKey();
				wucFieldTab1.SetDdl_CodeTab();

                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
				BindDdl_IsNull(ddlIsNullq);
				BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);
                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;

        
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId);
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);
				wucFieldTab1.SetDdl_FldStateId();
                clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);

				ddlFldStateIdq.SelectedValue = "01";

				strSortBy = "FldName Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_FieldTab();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucFieldTab1.SetKeyReadOnly(true);
				tabLayout.Visible = false;
			
				
				
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
		private string CombineCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}
			if (this.txtFldNameq.Text.Trim()!="")
			{
				strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim()+"%'";
			}
			if (this.ddlFldTypeq.SelectedValue!="" && this.ddlFldTypeq.SelectedValue!="0")
			{
				strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue+"'";
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
			if (this.txtAppliedScopeq.Text.Trim()!="")
			{
				strWhereCond += " and AppliedScope='" + this.txtAppliedScopeq.Text.Trim()+"'";
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
		private void BindDg_FieldTab()
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
            System.Data.DataTable objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgFieldTab.PageSize);
			if (intPages==0) 
			{
				this.dgFieldTab.CurrentPageIndex = 0;
			}
			else if (this.dgFieldTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgFieldTab.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;
			this.dgFieldTab.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgFieldTab.DataBind();
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
			this.dgFieldTab.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_FieldTab();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgFieldTab.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_FieldTab();
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
			wucFieldTab1.FldStateId = pobjFieldTab.FldStateId;

			///设置对象列表
            List<ObjStruct> arrLst = new List<ObjStruct>();
			StringBuilder strSQL = new StringBuilder();
			strSQL.Append("SELECT dbo.FldObjTab.ObjId, dbo.PrjObjects.ObjName");
			strSQL.Append(" FROM dbo.FldObjTab left OUTER JOIN");
			strSQL.Append(" dbo.PrjObjects ON dbo.FldObjTab.ObjId = dbo.PrjObjects.ObjId");
			strSQL.AppendFormat(" WHERE (dbo.FldObjTab.FldId = '{0}')", pobjFieldTab.FldId);
			DataTable objDT = clsGeneralTab2.GetDataTable(strSQL.ToString());
			ObjStruct objStruct;
			if (objDT !=null)
			{
				foreach(DataRow objRow in objDT.Rows)
				{
					objStruct.strObjId = objRow["ObjId"].ToString();
					objStruct.strObjName = objRow["ObjName"].ToString();
					arrLst.Add(objStruct);
				}
				wucFieldTab1.TabList = arrLst;
			}
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
	
			List<ObjStruct> arrObjStructLst;
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

                        arrObjStructLst = wucFieldTab1.TabList;
                        List<string> arrTarTabIdLst = new List<string>();
                        foreach (ObjStruct objTab in arrObjStructLst)
                        {
                            arrTarTabIdLst.Add(objTab.strObjId);
                        }
                        clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);
                                              
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindDg_FieldTab();
					wucFieldTab1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
					tabLayout.Visible = false;
					tabQuery.Visible = true;

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
					if (!wucFieldTab1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objFieldTabEN = (clsFieldTabEN) Session["objFieldTabEN"];
					if (clsFieldTabBLEx.IsCanDelUpd(objFieldTabEN.FldId) == false) 
					{
						strMsg = "该记录已核实或归档，不能修改!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "该记录已核实或归档，不能修改!";
						//return ;
					}
					else
					{
						PutDataToFieldTabClass(objFieldTabEN);		//把界面的值传到
						//3、检查传进去的对象属性是否合法
                        try
                        {
                            clsFieldTabBL.CheckPropertyNew(objFieldTabEN);
                        }
                        catch (Exception objException)
                        {
                            clsCommonJsFunc.Alert(this, objException.Message);
                            return;
                        }
						//4、把数据实体层的数据修改同步到数据库中
                        if (objFieldTabEN.UpdateRecordEx() == false) 
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
						

                            arrObjStructLst = wucFieldTab1.TabList;
                            List<string> arrTarTabIdLst = new List<string>();
                            foreach (ObjStruct objTab in arrObjStructLst)
                            {
                                arrTarTabIdLst.Add(objTab.strObjId);
                            }
                            clsPrjTabFldBLEx.EditPrjTabFld4FieldTab(objFieldTabEN.FldId, arrTarTabIdLst, clsCommonSession.UserId);
                                                       
						}
						//5、把修改后的内容显示在DATAGRID中
						BindDg_FieldTab();
						wucFieldTab1.Clear();//添空控件中的内容
					}
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
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
			//pobjFieldTab.IsNeedTransCode = wucFieldTab1.IsNeedTransCode;
			//pobjFieldTab.CodeTabId = wucFieldTab1.CodeTabId;
			//pobjFieldTab.CodeTabNameId = wucFieldTab1.CodeTabNameId;
			//pobjFieldTab.CodeTabCodeId = wucFieldTab1.CodeTabCodeId;
			pobjFieldTab.UpdDate = wucFieldTab1.UpdDate;
			pobjFieldTab.UpdUser = wucFieldTab1.UserId;

			pobjFieldTab.FldStateId = wucFieldTab1.FldStateId;
		}

		protected void dgFieldTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
				for(int i=0;i<this.dgFieldTab.Columns.Count;i++)
				{
					strSortEx = this.dgFieldTab.Columns[i].SortExpression;
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

		protected void dgFieldTab_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strFldID;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strFldID = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						if (clsFieldTabBLEx.IsCanDelUpd(strFldID) == false) return ;
						clsFieldTabBL.DelRecord(strFldID);
						BindDg_FieldTab();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						tabLayout.Visible = true;
						tabQuery.Visible = false;
						ShowData(strFldID);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucFieldTab1.SetKeyReadOnly(true);
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
					Set_DataGridAllChecked(dgFieldTab, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgFieldTab, false);
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

		protected void dgFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
//			System.Web.UI.WebControls.CheckBox chkIsNull, chkIsPrimaryKey;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 8;
				iNum[1] = 9;
				iNum[2] = 10;
				for (int i = 0; i<3; i++)
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
/// 导入Excel文件的字段
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
		{
//操作步骤：
//1、获取被选的记录列表
//2、调用逻辑层的函数备份被选字段
///
			ArrayList arrRec = clsCommForWebForm.Get_DgCheckedArr(dgFieldTab);
			if (clsFieldTabBLEx.BackupFldInfo(arrRec) == true)
			{
				lblMsg3.Text = "被选字段备份成功!";
			}
			else
			{
				lblMsg3.Text = "被选字段备份失败，请查原因!";
			}
			BindDg_FieldTab();
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

		
	
		protected void dgFieldTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_FieldTab();
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
			BindDg_FieldTab();

		}

		protected void lbDelFld_Click(object sender, System.EventArgs e)
		{
            ArrayList objArr = new ArrayList();
			objArr = clsCommForWebForm.Get_DgCheckedArr(this.dgFieldTab);
            List<string> objArr2 = clsArray.CopyArrayListToList_String(objArr);
            clsFieldTabBLEx.DelFieldTabEx(objArr2);
			BindDg_FieldTab();
//			Response.Write("<script>alert('所选字段已经删除！')</script>");
		}

		//protected void ddlObjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
		//{
		//	string strObjId = ddlObjIdq.SelectedValue;
  //          List<string> arrLst = new List<string>();
  //          arrLst = clsGeneralTab2.funGetFldValue("PrjTab", "TabName", "ObjId = '" + strObjId + "'");
		//	if (arrLst == null || arrLst.Count == 0)
		//		return ;
		//	lblRelaTab.Text = "相关表：" + arrLst[0].ToString();
		//}
		/// <summary>
		/// 将所选对象的所有字段，复制到相关表中，同时删除对象中没有的字段
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
		//{
		//	//操作步骤：
		//	//1、获取当前表ID的相关对象ID；
		//	//2、获取相关对象ID的字段ID的DataTable;
		//	//3、对该表进行循环，把字段信息插入到一个ArrayList
		//	//4、在插入过程中，要注意字段ID的重复，不能插入重复
		//	//			string strWhereCond;
		//	string strObjId;
		//	//1、获取当前表ID的相关对象ID；
		//	strObjId = ddlObjIdq.SelectedValue;
		//	if (strObjId == null || strObjId.Length ==0)
		//	{
		//		return ;
		//	}
  //          if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
		//	{
		//		Response.Write("<script>alert('与相关对象复制字段信息成功！！')</script>");
		//	}
		//	else
		//	{
		//		Response.Write("<script>alert('该对象不能与相关表同步，请检查对象属性；或者该对象没有相关的字段！！')</script>");
		//	}
		
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
    }
}