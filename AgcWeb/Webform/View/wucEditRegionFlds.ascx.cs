
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
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
    using System.Text;

    /// <summary>
    ///		wucEditRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucEditRegionFlds : System.Web.UI.UserControl
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible = false;
            
        }
        public void SetDefaEventName(string strCtrlId)
        {
            string strDefaChangeEvent = string.Format("{0}_SelectedIndexChanged", strCtrlId);
            string strDefaClickEvent = string.Format("{0}_Clicked", strCtrlId);

            txtChangeEvent.Attributes.Add("DefaChangeEvent", strDefaChangeEvent);
            txtClickEvent.Attributes.Add("DefaClickEvent", strDefaClickEvent);
            txtChangeEvent.Attributes.Add("placeholder", "单击添加相关Change事件");
            txtClickEvent.Attributes.Add("placeholder", "单击添加相关Click事件");
            txtChangeEvent.Attributes.Add("autocomplete", "off");
            txtClickEvent.Attributes.Add("autocomplete", "off");

            StringBuilder sbScript = new StringBuilder();
            sbScript.AppendFormat("txtChangeEventName='{0}';", txtChangeEvent.ClientID);
            sbScript.AppendFormat("txtClickEventName='{0}';", txtClickEvent.ClientID);
            sbScript.AppendFormat("SetDefaEventName();", txtClickEvent.ClientID);
            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "SetDefaEventName", sbScript.ToString(), true);

        }
        /// <summary>
        /// Click事件
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ClickEvent
        {
            get
            {
                return txtClickEvent.Text.Trim();
            }
            set
            {
                txtClickEvent.Text = value.ToString();
            }
        }

        /// <summary>
        /// Change事件
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ChangeEvent
        {
            get
            {
                return txtChangeEvent.Text.Trim();
            }
            set
            {
                txtChangeEvent.Text = value.ToString();
            }
        }

        public string FldId
        {
            get
            {
                if (ddlFldId.SelectedValue == "0")
                    return "";
                return ddlFldId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlFldId.SelectedValue = "0";
                }
                else
                {
                    ddlFldId.SelectedValue = value;
                }
            }
        }
  //      public string FldName
		//{
		//	get
		//	{
		//		return lblFldName.Text;
		//	}
		//	set
		//	{
		//		lblFldName.Text = value.ToString();
		//	}
		//}

        public string CtlTypeId
        {
            get
            {
                return wucEditControl1.CtlTypeId;

            }
            set
            {
                wucEditControl1.CtlTypeId = value;

            }
        }
        public string CallTabFeatureId
        {
            get
            {
                return wucEditControl1.CallTabFeatureId;

            }
            set
            {
                wucEditControl1.CallTabFeatureId = value;

            }
        }
        public string DefaultValue
        {
            get
            {
                return wucEditControl1.DefaultValue;

            }
            set
            {
                wucEditControl1.DefaultValue = value;

            }
        }


        public string DdlItemsOptionId
		{
			get
			{

				return wucEditControl1.DdlItemsOptionId;
			}
			set
			{				
                    wucEditControl1.DdlItemsOptionId = value;					
			}
		}
        public string VarId
        {
            get
            {
                return wucEditControl1.VarId;
            }
            set
            {
                wucEditControl1.VarId = value.ToString();
            }
        }

        public string DsTabId
		{
			get
			{
				return wucEditControl1.DsTabId;
			}
			set
			{

                    wucEditControl1.DsTabId = value;
					
			}
		}

		public string DsDataValueFieldId
		{
			get
			{

				return wucEditControl1.DsDataValueFieldId;
			}
			set
			{
				
                    wucEditControl1.DsDataValueFieldId = value;
				
			}
		}

		public string DsDataTextFieldId
		{
			get
			{
		
				return wucEditControl1.DsDataTextFieldId;
			}
			set
            {
                wucEditControl1.DsDataTextFieldId = value;
            }
        }

        public string Ds_CondFieldId
        {
            get
            {

                return wucEditControl1.Ds_CondFieldId;
            }
            set
            {
                wucEditControl1.Ds_CondFieldId = value;
            }
        }

        public string Ds_SortFieldId
        {
            get
            {

                return wucEditControl1.Ds_SortFieldId;
            }
            set
            {
                wucEditControl1.Ds_SortFieldId = value;
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

        public string DsCondStr
		{
			get
			{
				return wucEditControl1.DsCondStr;
			}
			set
			{
                wucEditControl1.DsCondStr = value.ToString();
			}
		}

		public string DsSqlStr
		{
			get
			{
				return wucEditControl1.DsSqlStr;
			}
			set
			{
                wucEditControl1.DsSqlStr = value.ToString();
			}
		}

		public string ItemsString
		{
			get
			{
				return wucEditControl1.ItemsString;
			}
			set
			{
                wucEditControl1.ItemsString = value.ToString();
			}
		}
		public string InOutTypeId
		{
			get
			{
				if (ddlInOutTypeId.SelectedValue == "0")
					return "";
				return ddlInOutTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlInOutTypeId.SelectedValue = "0";
				}
				else
				{
					ddlInOutTypeId.SelectedValue = value;
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

        public int Width
        {
            get
            {
                return int.Parse(txtWidth.Text.Trim());
            }
            set
            {
                txtWidth.Text = value.ToString();
            }
        }
        public int ColSpan
        {
            get
            {
                return int.Parse(txtColSpan.Text.Trim());
            }
            set
            {
                txtColSpan.Text = value.ToString();
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
            wucEditControl1.Clear();
			ddlInOutTypeId.SelectedIndex = 0;
			txtSeqNum.Text = "0";
			txtUpdDate.Text = "";
			txtMemo.Text = "";
            txtChangeEvent.Text = "";
            txtClickEvent.Text = "";
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
            wucEditControl1.SetDefaultValue();
			ddlInOutTypeId.SelectedIndex = 0;
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
        
        public void SetDdl_CtlTypeId(bool bolIsForApple)
        {
            wucEditControl1.SetDdl_CtlTypeId(bolIsForApple);
        }

        

        public void SetDdl_DdlItemsOptionId()
		{
            wucEditControl1.SetDdl_DdlItemsOptionId();
		}
		public void SetDdl_DsTabId(string strPrjId)
		{
            wucEditControl1.SetDdl_DsTabId(strPrjId);
//			BindDdl_DsTabId(ddlDsTabId);
		}
		public void SetDdl_DsDataValueFieldId(string strTabId)
		{
            wucEditControl1.SetDdl_DsDataValueFieldId(strTabId);
		}
		public void SetDdl_DsDataTextFieldId(string strTabId)
		{
            wucEditControl1.SetDdl_DsDataTextFieldId(strTabId);
		}

	

	
		public void SetDdl_InOutTypeId()
		{
			clsDropDownList.BindDdl_InOutTypeId(ddlInOutTypeId);
		}
        public void SetDdl_VarId(string strPrjId)
        {
            wucEditControl1.SetDdl_VarId(strPrjId);
        }
        public void SetDdl_CallTabFeatureId(string strFldId, string strPrjId)
        {
            wucEditControl1.SetDdl_CallTabFeatureId(strFldId, strPrjId);
        }
        public void SetDdl_FldId(string strTabId)
        {
            clsFieldTabBLEx.BindDdl_FldIdByTabIdEx(ddlFldId, clsPubVar.CurrSelPrjId, strTabId);
        }
    }
}