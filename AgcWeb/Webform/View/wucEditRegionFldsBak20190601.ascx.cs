
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Collections;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;
	using CommFunc4WebForm;
    using AGC.BusinessLogic;using AGC.FunClass;using CommonTable.BusinessLogic;using AGC.BusinessLogicEx;
	/// <summary>
	///		wucEditRegionFlds 的摘要说明。
	/// </summary>
	public partial class wucEditRegionFldsBak20190601 : System.Web.UI.UserControl
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible = false;

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
		public string FldName
		{
			get
			{
				return lblFldName.Text;
			}
			set
			{
				lblFldName.Text = value.ToString();
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

		public string DDLItemsOptionId
		{
			get
			{
				if (ddlDDLItemsOptionId.SelectedValue == "0")
					return "";
				return ddlDDLItemsOptionId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDDLItemsOptionId.SelectedValue = "0";
				}
				else
				{
					ddlDDLItemsOptionId.SelectedValue = value;
					ddlDDLItemsOptionId_SelectedIndexChanged(new object(), new System.EventArgs());
				}
			}
		}

		public string DS_TabId
		{
			get
			{
				if (ddlDS_TabId.SelectedValue == "0")
					return "";
				return ddlDS_TabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDS_TabId.SelectedValue = "0";
				}
				else
				{
					ddlDS_TabId.SelectedValue = value;
					ddlDS_TabId_SelectedIndexChanged(new object(), new System.EventArgs());
				}
			}
		}

		public string DS_DataValueFieldId
		{
			get
			{
				if (ddlDS_DataValueFieldId.SelectedValue == "0")
					return "";
				return ddlDS_DataValueFieldId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDS_DataValueFieldId.SelectedValue = "0";
				}
				else
				{
					ddlDS_DataValueFieldId.SelectedValue = value;
				}
			}
		}

		public string DS_DataTextFieldId
		{
			get
			{
				if (ddlDS_DataTextFieldId.SelectedValue == "0")
					return "";
				return ddlDS_DataTextFieldId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDS_DataTextFieldId.SelectedValue = "0";
				}
				else
				{
					ddlDS_DataTextFieldId.SelectedValue = value;
				}
			}
		}

        public string LabelCaption
        {
            get
            {
                return txtLabelCaption.Text.Trim();
            }
            set
            {
                txtLabelCaption.Text = value.ToString();
            }
        }

        public string DS_CondStr
		{
			get
			{
				return txtDS_CondStr.Text.Trim();
			}
			set
			{
				txtDS_CondStr.Text = value.ToString();
			}
		}

		public string DS_SQLStr
		{
			get
			{
				return txtDS_SQLStr.Text.Trim();
			}
			set
			{
				txtDS_SQLStr.Text = value.ToString();
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
		public string INOUTTypeId
		{
			get
			{
				if (ddlINOUTTypeId.SelectedValue == "0")
					return "";
				return ddlINOUTTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlINOUTTypeId.SelectedValue = "0";
				}
				else
				{
					ddlINOUTTypeId.SelectedValue = value;
				}
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
			txtTabFldId.Text = "0";
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDDLItemsOptionId.SelectedIndex = 0;
			ddlDS_TabId.SelectedIndex = 0;
			ddlDS_DataValueFieldId.SelectedIndex = 0;
			ddlDS_DataTextFieldId.SelectedIndex = 0;
			txtDS_CondStr.Text = "";
			txtDS_SQLStr.Text = "";
			txtItemsString.Text = "";
			ddlINOUTTypeId.SelectedIndex = 0;
			txtSeqNum.Text = "0";
			txtUpdDate.Text = "";
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
			txtTabFldId.Text = "0";
			ddlCtlTypeId.SelectedIndex = 0;
			ddlDDLItemsOptionId.SelectedIndex = 0;
			ddlDS_TabId.SelectedIndex = 0;
			ddlDS_DataValueFieldId.SelectedIndex = 0;
			ddlDS_DataTextFieldId.SelectedIndex = 0;
			txtDS_CondStr.Text = "";
			txtDS_SQLStr.Text = "";
			txtItemsString.Text = "";
			ddlINOUTTypeId.SelectedIndex = 0;
			txtSeqNum.Text = "0";
			txtUpdDate.Text = "";
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
		public void SetDdl_CtlTypeId()
		{
            clsDropDownList.BindDdl_CtlTypeId(ddlCtlTypeId);
		}
		public void SetDdl_DDLItemsOptionId()
		{
	clsDDLItemsOptionBL.		BindDdl_DDLItemsOptionId_Cache(ddlDDLItemsOptionId);
		}
		public void SetDdl_DS_TabId(string strPrjId)
		{
			clsPrjTabBLEx.BindDdl_TabIdEx_Cache(ddlDS_TabId, strPrjId);
//			BindDdl_DS_TabId(ddlDS_TabId);
		}
		public void SetDdl_DS_DataValueFieldId(string strTabId)
		{
			clsDropDownList.BindDdl_DS_DataPrjTabFld(ddlDS_DataValueFieldId, strTabId);
		}
		public void SetDdl_DS_DataTextFieldId(string strTabId)
		{
			clsDropDownList.BindDdl_DS_DataPrjTabFld(ddlDS_DataTextFieldId, strTabId);
		}

		protected void ddlDS_TabId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetDdl_DS_DataTextFieldId(ddlDS_TabId.SelectedValue);
			SetDdl_DS_DataValueFieldId(ddlDS_TabId.SelectedValue);
		}

		protected void ddlDDLItemsOptionId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ddlDDLItemsOptionId.SelectedValue == "02")//数据源表“02”
			{
				ddlDS_TabId.Enabled = true;
				ddlDS_DataTextFieldId.Enabled = true;
				ddlDS_DataValueFieldId.Enabled = true;
                SetDdl_DS_TabId(clsPubVar.CurrSelPrjId);
			}
		}
		public void SetDdl_INOUTTypeId()
		{
			clsDropDownList.BindDdl_INOUTTypeId(ddlINOUTTypeId);
		}

	}
}