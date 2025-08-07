
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
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
    using System.Text;
    using System.Collections.Generic;

    /// <summary>
    ///		wucPrjTabFld 的摘要说明。
    /// </summary>
    public partial class wucPrjTabFld : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible = false;
            SetScript();

        }

        private void SetScript()
        {
            StringBuilder sbJs = new StringBuilder();
            sbJs.Append("<script type=\"text/javascript\">");
            //sbJs.AppendFormat("strchkIsTabPrimary='{0}';", chkIsTabPrimary.ClientID);
            sbJs.AppendFormat("strddlFieldTypeId='{0}';", ddlFieldTypeId.ClientID);
            sbJs.Append("</script>");
            litScript.Text = sbJs.ToString();

        }
        public string FldId
		{
			get
			{
				return txtFldID.Text.Trim();
			}
			set
			{
				txtFldID.Text = value.ToString();
			}
		}
		public string FldName
		{
			get
			{
				return txtFldName.Text.Trim();
			}
			set
			{
				txtFldName.Text = value.ToString();
			}
		}

        public bool IsTabUnique
        {
            get
            {
                return chkIsTabUnique.Checked;
            }
            set
            {
                chkIsTabUnique.Checked = value;
            }
        }


		public bool IsTabNullable
		{
			get
			{
				return chkIsTabNullable.Checked;
			}
			set
			{
				chkIsTabNullable.Checked = value;
			}
		}

		public bool IsTabForeignKey
		{
			get
			{
				return chkIsTabForeignKey.Checked;
			}
			set
			{
				chkIsTabForeignKey.Checked = value;
			}
		}

		public bool IsParentObj
		{
			get
			{
				return chkIsParentObj.Checked;
			}
			set
			{
				chkIsParentObj.Checked = value;
			}
		}

		public string PrimaryTypeId
		{
			get
			{
				return ddlPrimaryTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlPrimaryTypeId.SelectedValue = "0";
				}
				else
				{
					ddlPrimaryTypeId.SelectedValue = value;
				}
			}
		}
        /// <summary>
        /// 字段类型Id
        /// </summary>
		public string FieldTypeId
		{
			get
			{
                List<string> arrKeyLst = new List<string>( Request.Form.AllKeys);
                string strDdl = arrKeyLst.Find(x => x.Contains("ddlFieldTypeId") && x.Contains("wucPrjTabFld"));
                if (string.IsNullOrEmpty(strDdl) == false)
                {
                    string strDdlValue = Request.Form[strDdl];
                    return strDdlValue;
                }
                if (ddlFieldTypeId.SelectedValue == "0") return enumFieldType.NormalField_01;
				return ddlFieldTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFieldTypeId.SelectedValue = "0";
				}
				else
				{
					ddlFieldTypeId.SelectedValue = value;
					
				}
                //if (ddlFieldTypeId.SelectedValue == "02")
                //{
                //	ddlFieldTypeId.Enabled = false;
                //}
                //else
                //{
                ddlFieldTypeId.Enabled = true;
                //}
            }
		}
        /// <summary>
        /// 字段操作类型Id
        /// </summary>
        public string FldOpTypeId
        {
            get
            {
                return ddlFldOpTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlFldOpTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlFldOpTypeId.SelectedValue = value;
                }
            }
        }
  
		public string ForeignKeyTabId
		{
			get
			{
				if (ddlForeignKeyTabId.SelectedValue == "0") return "";
				return ddlForeignKeyTabId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlForeignKeyTabId.SelectedValue = "0";
				}
				else
				{
                    try
                    {
                        ddlForeignKeyTabId.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string ss = objException.Message;
                    }
				}
			}
		}

        public string MemoInTab
		{
			get
			{
				return txtMemoInTab.Text.Trim();
			}
			set
			{
				txtMemoInTab.Text = value.ToString();
			}
		}


		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtFldID.ReadOnly = bolReadonly;
		}


		public void Clear()
		{
			txtFldID.Text = "";
			//chkIsTabPrimary.Checked = false;
			chkIsTabForeignKey.Checked = false;
			chkIsParentObj.Checked = false;
            chkIsTabUnique.Checked = false;
			ddlPrimaryTypeId.SelectedIndex = 0;
			ddlForeignKeyTabId.SelectedIndex = 0;
			txtMemoInTab.Text = "";
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
		///		4、如果是位(bit)型就默认为false;
		///		这些默认值可以再行修改
		/// </summary>
		public void SetDefaultValue()
		{
			txtFldID.Text = "";
			//chkIsTabPrimary.Checked = false;
			chkIsTabForeignKey.Checked = false;
			chkIsParentObj.Checked = false;
            chkIsTabUnique.Checked = false;
			ddlPrimaryTypeId.SelectedIndex = 0;
			ddlForeignKeyTabId.SelectedIndex = 0;
			txtMemoInTab.Text = "";
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
		
	
		//public System.Data.DataTable GetForeignKeyTabId(string strPrjId)
		//{
		//	//获取某学院所有专业信息
		//	string strSQL = "select TabId, TabName1 from PrjTab where PrjId = '" + strPrjId + "' order by TabName";
		//	clsSpecSQLforSql mySql=new clsSpecSQLforSql();
		//	System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
		//	return objDT;
		//}
		//public void BindDdl_ForeignKeyTabId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
		//{
		//	//为数据源于表的下拉框设置内容
		//	ListItem li=new ListItem("请选择...","0");
		//	System.Data.DataTable objDT = GetForeignKeyTabId(strPrjId);
		//	objDDL.DataValueField="TabId";
		//	objDDL.DataTextField="TabName";
		//	objDDL.DataSource = objDT;
		//	objDDL.DataBind();
		//	objDDL.Items.Insert(0, li);
		//	objDDL.SelectedIndex = 0;
		//}
		public void SetDdl_PrimaryTypeId()
		{
            clsDropDownList.BindDdl_PrimaryTypeId(ddlPrimaryTypeId);
		}
		public void SetDdl_ForeignKeyTabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlForeignKeyTabId, strPrjId);
        }
		public void SetDdl_FieldTypeId()
		{
            clsFieldTypeBL.BindDdl_FieldTypeIdCache(ddlFieldTypeId);
		}

        public void SetDdl_FldOpTypeId()
        {
            clsFldOperationTypeBL.BindDdl_FldOpTypeId(ddlFldOpTypeId);
        }

		protected void chkIsTabPrimary_CheckedChanged(object sender, System.EventArgs e)
		{
			//if (chkIsTabPrimary.Checked == true)
			//{
			//	ddlFieldTypeId.SelectedValue = "02";
			//	ddlFieldTypeId.Enabled = false;
			//}
			//else
			//{
			//	ddlFieldTypeId.SelectedValue = "01";
			//	ddlFieldTypeId.Enabled = true;
			//}
		}
	}
}