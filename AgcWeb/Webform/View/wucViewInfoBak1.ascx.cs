
namespace AGC.Webform
{
    using AGC.BusinessLogic;using AGC.FunClass;
    using AGC.BusinessLogicEx;
    //using SqlSv;
    using com.taishsoft.commdb;
    using System.Web.UI.WebControls;

    /// <summary>
    ///		wucViewInfo 的摘要说明。
    /// </summary>
    public partial class wucViewInfoBak : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible = false;

		}
		public string ViewId
		{
			get
			{
				return txtViewId.Text.Trim();
			}
			set
			{
				txtViewId.Text = value.ToString();
			}
		}

		public string ViewName
		{
			get
			{
				return txtViewName.Text.Trim();
			}
			set
			{
				txtViewName.Text = value.ToString();
			}
		}

		public string ViewCnName
		{
			get
			{
				return txtViewCnName.Text.Trim();
			}
			set
			{
				txtViewCnName.Text = value.ToString();
			}
		}

		public string FileName
		{
			get
			{
				return txtFileName.Text.Trim();
			}
			set
			{
				txtFileName.Text = value.ToString();
			}
		}

		public string FilePath
		{
			get
			{
				return txtFilePath.Text.Trim();
			}
			set
			{
				txtFilePath.Text = value.ToString();
			}
		}

		public string DefaMenuName
		{
			get
			{
				return txtDefaMenuName.Text.Trim();
			}
			set
			{
				txtDefaMenuName.Text = value.ToString();
			}
		}

		public string FuncModuleAgcId
		{
			get
			{
				return ddlFuncModuleId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFuncModuleId.SelectedValue = "0";
				}
				else
				{
					ddlFuncModuleId.SelectedValue = value;
				}
			}
		}

		public string DataBaseName
		{
			get
			{
				return txtDataBaseName.Text.Trim();
			}
			set
			{
				txtDataBaseName.Text = value.ToString();
			}
		}
		public string MainTabId
		{
			get
			{
				return ddlMainTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlMainTabId.SelectedValue = "0";
				}
				else
				{
					ddlMainTabId.SelectedValue = value;
				}
			}
		}

		public string DetailTabId
		{
			get
			{
				return ddlDetailTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDetailTabId.SelectedValue = "0";
				}
				else
				{
					ddlDetailTabId.SelectedValue = value;
				}
			}
		}
		public string MainViewId
		{
			get
			{
				return ddlMainTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlMainTabId.SelectedValue = "0";
				}
				else
				{
					ddlMainTabId.SelectedValue = value;
				}
			}
		}
		public string MainTabType
		{
			get
			{
				if (rblMainTabType.Items[0].Selected == true)
					return "表";
				else
				return "视图";
			}
			set
			{
				if (value == "")
				{
					rblMainTabType.Items[0].Selected = true;
				}
				else
				{
					if (value == "表")
					{
						rblMainTabType.Items[0].Selected = true;
					}
					else
					{
						rblMainTabType.Items[1].Selected = true;
					}
				}
			}
		}

		public string DetailTabType
		{
			get
			{
				if (rblDetailTabType.Items[0].Selected == true)
					return "表";
				else
					return "视图";
			}
			set
			{
				if (value == "")
				{
					rblDetailTabType.Items[0].Selected = true;
				}
				else
				{
					if (value == "表")
					{
						rblDetailTabType.Items[0].Selected = true;
					}
					else
					{
						rblDetailTabType.Items[1].Selected = true;
					}
				}
			}
		}

		public string DetailViewId
		{
			get
			{
				return ddlDetailTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDetailTabId.SelectedValue = "0";
				}
				else
				{
					ddlDetailTabId.SelectedValue = value;
				}
			}
		}

		public string KeyForMainTab
		{
			get
			{
				return txtKeyForMainTab.Text.Trim();
			}
			set
			{
				txtKeyForMainTab.Text = value.ToString();
			}
		}

		public string KeyForDetailTab
		{
			get
			{
				return txtKeyForDetailTab.Text.Trim();
			}
			set
			{
				txtKeyForDetailTab.Text = value.ToString();
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

		public bool IsNeedTransCode
		{
			get
			{
				return chkIsNeedTransCode.Checked;
			}
			set
			{
				chkIsNeedTransCode.Checked = value;
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

		public string PrjId
		{
			get
			{
				return ddlPrjId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlPrjId.SelectedValue = "0";
				}
				else
				{
					ddlPrjId.SelectedValue = value;
				}
			}
		}

		public string ViewFunction
		{
			get
			{
				return txtViewFunction.Text.Trim();
			}
			set
			{
				txtViewFunction.Text = value.ToString();
			}
		}

		public string ViewDetail
		{
			get
			{
				return txtViewDetail.Text.Trim();
			}
			set
			{
				txtViewDetail.Text = value.ToString();
			}
		}


		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtViewId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtViewId.Text = "";
			txtViewName.Text = "";
			
			ddlFuncModuleId.SelectedIndex = 0;

			txtDataBaseName.Text = "";
			ddlMainTabId.SelectedIndex = 0;
			ddlDetailTabId.SelectedIndex = 0;
			txtKeyForMainTab.Text = "";
			txtKeyForDetailTab.Text = "";
			chkIsNeedSort.Checked = false;
			chkIsNeedTransCode.Checked = false;
			txtUserId.Text = "";
			ddlPrjId.SelectedIndex = 0;
			txtViewFunction.Text = "";
			txtViewDetail.Text = "";
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
			txtViewId.Text = "";
			txtViewName.Text = "";
			
			ddlFuncModuleId.SelectedIndex = 0;
			txtDataBaseName.Text = "";
			ddlMainTabId.SelectedIndex = 0;
			ddlDetailTabId.SelectedIndex = 0;
			txtKeyForMainTab.Text = "";
			txtKeyForDetailTab.Text = "";
			chkIsNeedSort.Checked = false;
			chkIsNeedTransCode.Checked = false;
			txtUserId.Text = "";
			ddlPrjId.SelectedIndex = 0;
			txtViewFunction.Text = "";
			txtViewDetail.Text = "";
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
		
	
		public void SetDdl_MainTabId(string strPrjId)
		{
		clsPrjTabBLEx.BindDdl_TabIdExCache(ddlMainTabId, strPrjId);
		}
		public void SetDdl_DetailTabId(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlDetailTabId, strPrjId);
		}

		public void SetDdl_PrjId()
		{
			clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
		}

		protected void txtViewName_TextChanged(object sender, System.EventArgs e)
		{
			txtFileName.Text = txtViewName.Text.Trim().ToString() + ".aspx";
		}

		protected void txtViewCnName_TextChanged(object sender, System.EventArgs e)
		{
			txtDefaMenuName.Text = txtViewCnName.Text;
			txtViewFunction.Text = txtViewCnName.Text;
		}
		public System.Data.DataTable GetFuncModuleId(string strPrjId)
		{
			//获取某学院所有专业信息
			string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc where PrjId = '" + strPrjId +"'";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetFuncModuleId(strPrjId);
			objDDL.DataValueField="FuncModuleAgcId";
			objDDL.DataTextField="FuncModuleName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_FuncModuleId(string strPrjId)
		{
			BindDdl_FuncModuleId(ddlFuncModuleId, strPrjId);
		}

		protected void rblMainTabType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (rblMainTabType.Items[0].Selected == true)
			{
				divMainTab.Visible = true;
				divMainView.Visible = false;
			}
			else
			{
				divMainTab.Visible = false;
				divMainView.Visible = true;
			}
		}
	}
}