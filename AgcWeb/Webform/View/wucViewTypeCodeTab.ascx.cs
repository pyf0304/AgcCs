
///

namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.common;
	using com.taishsoft.commdb;
	using AGC.BusinessLogicEx;
	/// <summary>
	///		wucViewTypeCodeTab 的摘要说明。
	/// </summary>
	public partial class wucViewTypeCodeTab : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面

		}
		public int ViewTypeCode
		{
			get
			{
				return int.Parse( txtViewTypeCode.Text.Trim());
			}
			set
			{
				txtViewTypeCode.Text = value.ToString();
			}
		}

		public string ViewTypeName
		{
			get
			{
				return txtViewTypeName.Text.Trim();
			}
			set
			{
				txtViewTypeName.Text = value.ToString();
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

		public string OptProcess
		{
			get
			{
				return txtOptProcess.Text.Trim();
			}
			set
			{
				txtOptProcess.Text = value.ToString();
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

		public int ApplicationTypeId
		{
			get
			{
				if (ddlApplicationTypeId.SelectedValue == "0")
					return 0;
                return int.Parse(ddlApplicationTypeId.SelectedValue.ToString());

            }
            set
			{
				if (value == 0)
				{
					ddlApplicationTypeId.SelectedValue = "0";
				}
				else
				{
                    try
                    {
                        ddlApplicationTypeId.SelectedValue = value.ToString();
                    }
                    catch(Exception objException)
                    {
						clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
					}
				}
			}
		}

		public bool IsHaveAdd
		{
			get
			{
				return chkIsHaveAdd.Checked;
			}
			set
			{
				chkIsHaveAdd.Checked = value;
			}
		}

		public bool IsHaveUpdate
		{
			get
			{
				return chkIsHaveUpdate.Checked;
			}
			set
			{
				chkIsHaveUpdate.Checked = value;
			}
		}

        public bool IsHaveExeAdd
        {
            get
            {
                return chkIsHaveExeAdd.Checked;
            }
            set
            {
                chkIsHaveExeAdd.Checked = value;
            }
        }

        public bool IsHaveExeUpdate
        {
            get
            {
                return chkIsHaveExeUpdate.Checked;
            }
            set
            {
                chkIsHaveExeUpdate.Checked = value;
            }
        }

		public bool IsHaveDel
		{
			get
			{
				return chkIsHaveDel.Checked;
			}
			set
			{
				chkIsHaveDel.Checked = value;
			}
		}

		public bool IsHaveQuery
		{
			get
			{
				return chkIsHaveQuery.Checked;
			}
			set
			{
				chkIsHaveQuery.Checked = value;
			}
		}

		public bool IsHaveExcelExport
		{
			get
			{
				return chkIsHaveExcelExport.Checked;
			}
			set
			{
				chkIsHaveExcelExport.Checked = value;
			}
		}

        public bool IsHaveSetExportExcel
        {
            get
            {
                return chkIsHaveSetExportExcel.Checked;
            }
            set
            {
                chkIsHaveSetExportExcel.Checked = value;
            }
        }
		public bool IsHaveDetail
		{
			get
			{
				return chkIsHaveDetail.Checked;
			}
			set
			{
				chkIsHaveDetail.Checked = value;
			}
		}

        public bool IsHaveMainView
        {
            get
            {
                return chkIsHaveMainView.Checked;
            }
            set
            {
                chkIsHaveMainView.Checked = value;
            }
        }
        public bool IsHaveSubView
        {
            get
            {
                return chkIsHaveSubView.Checked;
            }
            set
            {
                chkIsHaveSubView.Checked = value;
            }
        }

        /// <summary>
        /// 是否Web应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsWebApp
        {
            get
            {
                return chkIsWebApp.Checked;
            }
            set
            {
                chkIsWebApp.Checked = value;
            }
        }

        /// <summary>
        /// 是否Win应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsWinApp
        {
            get
            {
                return chkIsWinApp.Checked;
            }
            set
            {
                chkIsWinApp.Checked = value;
            }
        }

        /// <summary>
        /// 是否移动终端应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsMobileApp
        {
            get
            {
                return chkIsMobileApp.Checked;
            }
            set
            {
                chkIsMobileApp.Checked = value;
            }
        }

        public void SetKeyReadOnly(bool bolReadonly)
		{
			txtViewTypeCode.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtViewTypeCode.Text = "";
			txtViewTypeName.Text = "";
			txtViewFunction.Text = "";
			txtOptProcess.Text = "";
			txtViewDetail.Text = "";
			ddlApplicationTypeId.SelectedIndex = 0;
            chkIsHaveAdd.Checked = false;
            chkIsHaveUpdate.Checked = false;
            chkIsHaveExeAdd.Checked = false;
            chkIsHaveExeUpdate.Checked = false;
            chkIsHaveDel.Checked = false;
			chkIsHaveQuery.Checked = false;
			chkIsHaveExcelExport.Checked = false;
			chkIsHaveDetail.Checked = false;
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
			txtViewTypeCode.Text = "";
			txtViewTypeName.Text = "";
			txtViewFunction.Text = "";
			txtOptProcess.Text = "";
			txtViewDetail.Text = "";
			ddlApplicationTypeId.SelectedIndex = 0;
			chkIsHaveAdd.Checked = false;
			chkIsHaveUpdate.Checked = false;
            chkIsHaveExeAdd.Checked = false;
            chkIsHaveExeUpdate.Checked = false;
            chkIsHaveDel.Checked = false;
			chkIsHaveQuery.Checked = false;
			chkIsHaveExcelExport.Checked = false;
			chkIsHaveDetail.Checked = false;
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
		
		public void SetDdl_ApplicationTypeId()
		{
            clsDropDownList.BindDdl_ApplicationTypeId(ddlApplicationTypeId);
		}
	}
}