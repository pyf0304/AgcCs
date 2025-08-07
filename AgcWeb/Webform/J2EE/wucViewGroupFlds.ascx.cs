
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

	/// <summary>
	///		wucViewGroupFlds 的摘要说明。
	/// </summary>
	public partial class wucViewGroupFlds : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面

		}
		public string ViewGroupId
		{
			get
			{
				if (ddlViewGroupId.SelectedValue == "0")
					return "";
				return ddlViewGroupId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlViewGroupId.SelectedValue = "0";
				}
				else
				{
					ddlViewGroupId.SelectedValue = value;
				}
			}
		}

		public long TabFldId
		{
			get
			{
				return long.Parse(txtTabFldId.Text.Trim());
			}
			set
			{
				txtTabFldId.Text = value.ToString();
			}
		}

		public string CtlTypeId
		{
			get
			{
				if (ddlCtlTypeId.SelectedValue == "0")
					return "";
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

		public string DdlItemsOptionId
		{
			get
			{
				if (ddlDdlItemsOptionId.SelectedValue == "0")
					return "";
				return ddlDdlItemsOptionId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDdlItemsOptionId.SelectedValue = "0";
				}
				else
				{
					ddlDdlItemsOptionId.SelectedValue = value;
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

		public string DsDataTextFieldId
		{
			get
			{
				if (ddlDsDataTextFieldId.SelectedValue == "0")
					return "";
				return ddlDsDataTextFieldId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataTextFieldId.SelectedValue = "0";
				}
				else
				{
					ddlDsDataTextFieldId.SelectedValue = value;
				}
			}
		}

		public string DsDataValueFieldId
		{
			get
			{
				if (ddlDsDataValueFieldId.SelectedValue == "0")
					return "";
				return ddlDsDataValueFieldId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsDataValueFieldId.SelectedValue = "0";
				}
				else
				{
					ddlDsDataValueFieldId.SelectedValue = value;
				}
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

		public string DsTabId
		{
			get
			{
				if (ddlDsTabId.SelectedValue == "0")
					return "";
				return ddlDsTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDsTabId.SelectedValue = "0";
				}
				else
				{
					ddlDsTabId.SelectedValue = value;
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

		public int SeqNum
		{
			get
			{
				return int.Parse(txtSeqNum.Text.Trim());
			}
			set
			{
				txtSeqNum.Text = value.ToString();
			}
		}

		public string Memo
		{
			get
			{
				return txtMemo.Text.Trim();
			}
			set
			{
				txtMemo.Text = value.ToString();
			}
		}


		public void Clear()
		{
			ddlViewGroupId.SelectedIndex = 0;
			txtTabFldId.Text = "0";
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDdlItemsOptionId.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			ddlDsDataTextFieldId.SelectedIndex = 0;
			ddlDsDataValueFieldId.SelectedIndex = 0;
			txtDsSqlStr.Text = "";
			ddlDsTabId.SelectedIndex = 0;
			txtItemsString.Text = "";
			txtSeqNum.Text = "0";
			txtMemo.Text = "";
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
		public bool IsValid(ref string strResult)
		{
			ComValid_SeqNum.Validate();
			if (!ComValid_SeqNum.IsValid) return false;
			if (IsNumeric(txtTabFldId.Text) == false)
			{
				strResult = "请输入正确的整型!";
				return false;
			}
			if (IsNumeric(txtSeqNum.Text) == false)
			{
				strResult = "请输入正确的整型!";
				return false;
			}
			return true;
		}
		/// <summary>
		/// 设置该控件在插入状态下的缺省值
		/// 一般规则：
		///		1、如果是整型就默认为0；
		///		2、如果是浮点型不默认为0.0；
		///		3、如果是日期型就默认为当前的日期；
		///		4、如果是位(bit)型就默认为false;
		///		这些默认值可以再行修改
		/// </summary>
		public void SetDefaultValue()
		{
			ddlViewGroupId.SelectedIndex = 0;
			txtTabFldId.Text = "0";
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDdlItemsOptionId.SelectedIndex = 0;
			txtDsCondStr.Text = "";
			ddlDsDataTextFieldId.SelectedIndex = 0;
			ddlDsDataValueFieldId.SelectedIndex = 0;
			txtDsSqlStr.Text = "";
			ddlDsTabId.SelectedIndex = 0;
			txtItemsString.Text = "";
			txtSeqNum.Text = "0";
			txtMemo.Text = "";
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
		/// <summary>
		/// 判断是否是数字
		/// </summary>
		/// <param name="strValue">需要判断的字符串</param>
		/// <returns>True/False</returns>
		public bool IsDigit(string strValue)
		{
			int intLen = strValue.Length;
			for(int i = 0; i<intLen; i++)
			{
				if (char.IsDigit(strValue, i) == false)
				{
					return false;
				}
			}
			return true;
		}
		/// <summary>
		/// 判断是否是浮点型数值
		/// </summary>
		/// <param name="strValue">需要判断的字符串</param>
		/// <returns>True/False</returns>
		public bool IsFloat(string strValue)
		{
			int intPointNum = 0;
			char [] arrChar = strValue.ToCharArray();
			int intLen = strValue.Length;
			for(int i = 0; i<intLen; i++)
			{
				if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
				{
				}
				else
				{
					return false;
				}
				if (arrChar[i] == '.') intPointNum++;
			}
			//检查总共有几个小数点，如果有多于1个小数点，就不正确
			if (intPointNum>1) return false;
			return true;
		}
		/// <summary>
		/// 判断是否是整型数值
		/// </summary>
		/// <param name="strValue">需要判断的字符串</param>
		/// <returns>True/False</returns>
		public bool IsNumeric(string strValue)
		{
			int intLen = strValue.Length;
			for(int i = 0; i<intLen; i++)
			{
				if (char.IsDigit(strValue, i) == false)
				{
					return false;
				}
			}
			return true;
		}
		
		public System.Data.DataTable GetViewGroupId()
		{
			//获取某学院所有专业信息
			string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetViewGroupId();
			objDDL.DataValueField="ViewGroupId";
			objDDL.DataTextField="ViewGroupName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
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
		public void SetDdl_ViewGroupId()
		{
			BindDdl_ViewGroupId(ddlViewGroupId);
		}
		public void SetDdl_CtlTypeId(bool bolIsForApple)
		{
            clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId, bolIsForApple);
		}

		public void SetDdl_DdlItemsOptionId()
		{
            clsDDLItemsOptionBL.BindDdl_DdlItemsOptionIdCache(ddlDdlItemsOptionId);
		}
		public void SetDdl_DsDataTextFieldId(string strPrjId)
		{
clsFieldTabBLEx.BindDdl_FldIDEx(ddlDsDataTextFieldId, strPrjId);
        }
        public void SetDdl_DsDataValueFieldId(string strPrjId)
        {
            clsFieldTabBLEx.BindDdl_FldIDEx(ddlDsDataValueFieldId, strPrjId);
		}
		public void SetDdl_DsTabId(string strPrjId)
		{
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlDsTabId, strPrjId);
		}
		public void SetDdl_UserId()
		{
            //BindDdl_UserId(ddlUserId);
		}
	}
}