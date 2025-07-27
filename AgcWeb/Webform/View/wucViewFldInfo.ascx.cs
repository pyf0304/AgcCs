
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.BusinessLogicEx;
    using AGC.FunClass;

    /// <summary>
    ///		wucViewFldInfo 的摘要说明。
    /// </summary>
    public partial class wucViewFldInfo : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible=false;

		}

	

		public string FldId
		{
			get
			{
				return ddlFldID.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFldID.SelectedValue = "0";
				}
				else
				{
					ddlFldID.SelectedValue = value;
				}
			}
		}

		public string ViewId
		{
			get
			{
				return ddlViewId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlViewId.SelectedValue = "0";
				}
				else
				{
					ddlViewId.SelectedValue = value;
				}
			}
		}

		public string TabId
		{
			get
			{
				return ddlTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlTabId.SelectedValue = "0";
				}
				else
				{
					ddlTabId.SelectedValue = value;
				}
			}
		}

		public string CtlTypeId
		{
			get
			{
				return ddlCtlTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlCtlTypeId.SelectedValue = "0";
				}
				else
				{
					ddlCtlTypeId.SelectedValue = value;
				}
			}
		}

		public string DDLItemsOption
		{
			get
			{
				return ddlDDLItemsOption.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDDLItemsOption.SelectedValue = "0";
				}
				else
				{
					ddlDDLItemsOption.SelectedValue = value;
					ddlDDLItemsOption_SelectedIndexChanged(new object(), new System.EventArgs());
				}
			}
		}

		public string ItemsString
		{
			get
			{
				return txtItemsString.Text.Trim();
			}
			set
			{
				txtItemsString.Text = value.ToString();
			}
		}
		public string DsTabName
		{
			get
			{
				return ddlDsTabName.SelectedItem.Text;
			}
			set
			{
				if (value == "")
				{
					ddlDsTabName.SelectedValue = "0";
				}
				else
				{
//					ddlDsTabName.SelectedItem.Text = value;
					for (int i = 0; i<ddlDsTabName.Items.Count; i++)
					{
						if (ddlDsTabName.Items[i].Text == value)
						{
							ddlDsTabName.SelectedIndex = i;
							break;
						}
					}
					ddlDsTabName_SelectedIndexChanged(new object(), new System.EventArgs());
				}
			}
		}

		public string DsDataValueField
		{
			get
			{
				return ddlDsDataValueField.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataValueField.SelectedValue = "0";
				}
				else
				{
					foreach(System.Web.UI.WebControls.ListItem ss in ddlDsDataValueField.Items)
					{
						if (ss.Value == value)
						{
							ddlDsDataValueField.SelectedValue = value;
							break;
						}
					}
				}
			}
		}
		public string DsDataTextField
		{
			get
			{
				return ddlDsDataTextField.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataTextField.SelectedValue = "0";
				}
				else
				{
					foreach(System.Web.UI.WebControls.ListItem ss in ddlDsDataValueField.Items)
					{
						if (ss.Value == value)
						{
							ddlDsDataTextField.SelectedValue = value;
							break;
						}
					}
				}
			}
		}

		public string DsCondStr
		{
			get
			{
				return txtDsCondStr.Text.Trim();
			}
			set
			{
				txtDsCondStr.Text = value.ToString();
			}
		}

		public string DsSqlStr
		{
			get
			{
				return txtDsSqlStr.Text.Trim();
			}
			set
			{
				txtDsSqlStr.Text = value.ToString();
			}
		}

		public bool IsQuery
		{
			get
			{
				return chkIsQuery.Checked;
			}
			set
			{
				chkIsQuery.Checked = value;
			}
		}

		public bool IsDataGrid
		{
			get
			{
				return chkIsDataGrid.Checked;
			}
			set
			{
				chkIsDataGrid.Checked = value;
			}
		}

		public bool IsNeedSort
		{
			get
			{
				return chkIsNeedSort.Checked;
			}
			set
			{
				chkIsNeedSort.Checked = value;
			}
		}

		public string QueryOption
		{
			get
			{
				return ddlQueryOption.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlQueryOption.SelectedValue = "0";
				}
				else
				{
					ddlQueryOption.SelectedValue = value;
				}
			}
		}

		public bool IsCtlField
		{
			get
			{
				return chkIsCtlField.Checked;
			}
			set
			{
				chkIsCtlField.Checked = value;
			}
		}

		public string UpdDate
		{
			get
			{
				return txtUpdDate.Text.Trim();
			}
			set
			{
				txtUpdDate.Text = value.ToString();
			}
		}

		public string UserId
		{
			get
			{
				return txtUserId.Text.Trim();
			}
			set
			{
				txtUserId.Text = value.ToString();
			}
		}


		public void Clear()
		{
			ddlFldID.SelectedIndex = 0;
			ddlViewId.SelectedIndex = 0;
			ddlTabId.SelectedIndex = 0;
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDDLItemsOption.SelectedIndex = 0;
			txtItemsString.Text = "";
			ddlDsTabName.SelectedIndex = 0;
			ddlDsDataValueField.SelectedIndex = 0;
			ddlDsDataTextField.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			txtDsSqlStr.Text = "";
			chkIsQuery.Checked = false;
			chkIsDataGrid.Checked = false;
			chkIsNeedSort.Checked = false;
			ddlQueryOption.SelectedIndex = 0;
			chkIsCtlField.Checked = false;
			txtUpdDate.Text = "";
			txtUserId.Text = "";
		}
		/// <summary>
		/// 校验自定义控件中自子控件的类型数值是否是合法正确的。
		/// 一般规则：
		///		1、首先校验类型：整型、浮点型、日期型等，
		///			这些代码由自动生成代码帮助生成
		///		2、校验最值，即最大值和最小值等
		///			这些代码由自动生成代码帮助生成
		///		这些生成内容可以修改
		/// </summary>
		/// <returns></returns>
		public bool IsValid()
		{
			return true;
		}
		/// <summary>
		/// 设置该控件在插入状态下的缺省值
		/// 一般规则：
		///		1、如果是整型就默认为0；
		///		2、如果是浮点型不默认为0.0；
		///		3、如果是日期型就默认为当前的日期；
		///		4、如果是位(bit)型就默认为False;
		///		这些默认值可以再行修改
		/// </summary>
		public void SetDefaultValue()
		{
			ddlFldID.SelectedIndex = 0;
			ddlViewId.SelectedIndex = 0;
			ddlTabId.SelectedIndex = 0;
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDDLItemsOption.SelectedIndex = 0;
			txtItemsString.Text = "";
			ddlDsTabName.SelectedIndex = 0;
			ddlDsDataValueField.SelectedIndex = 0;
			ddlDsDataTextField.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			txtDsSqlStr.Text = "";
			chkIsQuery.Checked = false;
			chkIsDataGrid.Checked = false;
			chkIsNeedSort.Checked = false;
			ddlQueryOption.SelectedIndex = 0;
			chkIsCtlField.Checked = false;
			txtUpdDate.Text = "";
			txtUserId.Text = "";
		}
		/// <summary>
		/// 功能：获取当前日期的字符串
		/// 日期格式：
		///    日期的字符串的格式有三种：
		///		1、YYYYMMDD。	例如20050120
		///		2、YYYY-MM-DD	例如2005-01-20
		///		3、YYYY/MM/DD	例如2005/01/20
		/// </summary>
		/// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
		///							参数不同，函数返回值就不同，
		///							参见上面的日期格式
		///	</param>
		/// <returns>返回当前日期的字符串</returns>
		public string getTodayStr(int intFormat)
		{
			string strToday;
			string strYear, strMonth, strDay;
			int intYear, intMonth, intDay;
			intYear = System.DateTime.Today.Year;
			intMonth = System.DateTime.Today.Month;
			intDay = System.DateTime.Today.Day;
			strYear = intYear.ToString().Trim();
			if (intMonth>9) strMonth = intMonth.ToString().Trim();
			else strMonth = "0" + intMonth.ToString().Trim();
			if (intDay>9) strDay = intDay.ToString().Trim();
			else strDay = "0" + intDay.ToString().Trim();
			strToday = strYear + strMonth + strDay;
			switch(intFormat)
			{
				case 0:
					strToday = strYear + strMonth + strDay;
					break;
				case 1:
					strToday =strYear + "-" + strMonth + "-" + strDay;
					break;
				case 2:
					strToday =strYear + "/" + strMonth + "/" + strDay;
					break;
			}
			return strToday;
		}
		/// <summary>
		/// 功能：获取当前月的字符串
		/// 月的格式：
		///    月的字符串的格式有三种：
		///		1、YYYYMM。	例如200501
		///		2、YYYY-MM-DD	例如2005-01
		///		3、YYYY/MM/DD	例如2005/01
		/// </summary>
		/// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
		///							参数不同，函数返回值就不同，
		///							参见上面的月的格式
		///	</param>
		/// <returns>返回当前月的字符串</returns>
		public string getCurrMonth(int intFormat)
		{
			string strCurrMonth;
			string strYear, strMonth;
			int intYear, intMonth;
			intYear = System.DateTime.Today.Year;
			intMonth = System.DateTime.Today.Month;
			strYear = intYear.ToString().Trim();
			if (intMonth>9) strMonth = intMonth.ToString().Trim();
			else strMonth = "0" + intMonth.ToString().Trim();
			strCurrMonth = strYear + strMonth;
			switch(intFormat)
			{
				case 0:
					strCurrMonth = strYear + strMonth;
					break;
				case 1:
					strCurrMonth =strYear + "-" + strMonth;
					break;
				case 2:
					strCurrMonth =strYear + "/" + strMonth;
					break;
			}
			return strCurrMonth;
		}
		
	
		public System.Data.DataTable GetDDLItemsOption()
		{
			//获取某学院所有专业信息
			string strSQL = "select DdlItemsOptionId, DDLItemsOption from DDLItemsOption ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_DDLItemsOption(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetDDLItemsOption();
			objDDL.DataValueField="DdlItemsOptionId";
			objDDL.DataTextField="DDLItemsOption";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetQueryOption()
		{
			//获取某学院所有专业信息
			string strSQL = "select QueryOptionId, QueryOptionName from QueryOption ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_QueryOption(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetQueryOption();
			objDDL.DataValueField="QueryOptionId";
			objDDL.DataTextField="QueryOptionName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_FldID(string strPrjId)
		{
            clsFieldTabBLEx.BindDdl_FldIDEx(ddlFldID, strPrjId);
		}
		public void SetDdl_ViewId(string strPrjId)
        {
            clsViewInfoBLEx.BindDdl_ViewIdEx(ddlViewId, strPrjId);
		}
		public void SetDdl_TabId(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, strPrjId);
		}
		public void SetDdl_CtlTypeId(bool bolIsForApple)
		{
            clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId, bolIsForApple);
		}
		public void SetDdl_DDLItemsOption()
		{
			BindDdl_DDLItemsOption(ddlDDLItemsOption);
		}
		public void SetDdl_QueryOption()
		{
			BindDdl_QueryOption(ddlQueryOption);
		}
		public void SetDdl_DsTabName(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlDsTabName, strPrjId);
		}
		public void SetDdl_DsDataValueField(string strTabId)
		{
			clsDropDownList.BindDdl_DsDataValueField(ddlDsDataValueField, strTabId);
		}
		public void SetDdl_DsDataTextField(string strTabId)
		{
			clsDropDownList.BindDdl_DsDataTextField(ddlDsDataTextField, strTabId);
		}

		protected void ddlDsTabName_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetDdl_DsDataTextField(ddlDsTabName.SelectedValue);
			SetDdl_DsDataValueField(ddlDsTabName.SelectedValue);
		}

		protected void ddlDDLItemsOption_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlDDLItemsOption.SelectedValue == "02")//数据源表“02”
			{
				ddlDsTabName.Enabled = true;
				ddlDsDataTextField.Enabled = true;
				ddlDsDataValueField.Enabled = true;
                SetDdl_DsTabName(clsPubVar.CurrSelPrjId);
			}
		}
	}
}