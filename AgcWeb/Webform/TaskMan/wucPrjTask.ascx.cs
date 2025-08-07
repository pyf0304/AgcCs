
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using AGC.BusinessLogicEx;
    using AGC.BusinessLogic;using AGC.FunClass;

    /// <summary>
    ///		wucPrjTask 的摘要说明。
    /// </summary>
    public partial class wucPrjTask : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面

		}
		public string PrjTaskId
		{
			get
			{
				return txtPrjTaskId.Text.Trim();
			}
			set
			{
				txtPrjTaskId.Text = value.ToString();
			}
		}

		public string TaskName
		{
			get
			{
				return txtTaskName.Text.Trim();
			}
			set
			{
				txtTaskName.Text = value.ToString();
			}
		}

		public string TaskDesc
		{
			get
			{
				return txtTaskDesc.Text.Trim();
			}
			set
			{
				txtTaskDesc.Text = value.ToString();
			}
		}

		public string Executor
		{
			get
			{
				if (ddlExecutor.SelectedValue == "0")
				{
					return "";
				}
				return ddlExecutor.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlExecutor.SelectedValue = "0";
				}
				else
				{
					ddlExecutor.SelectedValue = value;
				}
			}
		}

		public string DepartmentId
		{
			get
			{
				if (ddlDepartmentId.SelectedValue == "0")
				{
					return "";
				}
				return ddlDepartmentId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDepartmentId.SelectedValue = "0";
				}
				else
				{
					ddlDepartmentId.SelectedValue = value;
				}
			}
		}

	

		public string PlanBeginDate
		{
			get
			{
				if (txtPlanBeginDate.Text.Trim() == "")
					return "";
				System.DateTime dtDay;
				dtDay = System.DateTime.Parse(txtPlanBeginDate.Text.Trim());
				string strDay = getDateStr(dtDay, 0);
				return strDay;
			}
			set
			{
				if (value.Length<8)
					txtPlanBeginDate.Text = "";
				System.DateTime dtDate = TransDateStr(value);

				txtPlanBeginDate.Text = getDateStr(dtDate, 1);
			}
		}

		public string PlanEndDate
		{
			get
			{
				if (txtPlanEndDate.Text.Trim() == "")
					return "";
				System.DateTime dtDay;
				dtDay = System.DateTime.Parse(txtPlanEndDate.Text.Trim());
				string strDay = getDateStr(dtDay, 0);
				return strDay;
			}
			set
			{
				if (value.Length<8)
					txtPlanEndDate.Text = "";
				System.DateTime dtDate = TransDateStr(value);
				txtPlanEndDate.Text = getDateStr(dtDate, 1);
			}
		}

		public int PlanNeedHours
		{
			get
			{
				return int.Parse(txtPlanNeedHours.Text.Trim());
			}
			set
			{
				txtPlanNeedHours.Text = value.ToString();
			}
		}

		public string ViewId
		{
			get
			{
				if (ddlViewId.SelectedValue == "0")
				{
					return "";
				}
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

		public string PrjProcessId
		{
			get
			{
				if (ddlPrjProcessId.SelectedValue == "0")
				{
					return "";
				}
				return ddlPrjProcessId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlPrjProcessId.SelectedValue = "0";
				}
				else
				{
					ddlPrjProcessId.SelectedValue = value;
				}
			}
		}

		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtPrjTaskId.ReadOnly = bolReadonly;
		}
		public void SetRequireField(bool bolReadonly)
		{
			RequiredField_PlanNeedHours.Enabled = bolReadonly;
		}
		public void Clear()
		{
			txtPrjTaskId.Text = "";
			txtTaskName.Text = "";
			txtTaskDesc.Text = "";
			ddlExecutor.SelectedIndex = 0;
			ddlDepartmentId.SelectedIndex = 0;
			txtPlanBeginDate.Text = "";
			txtPlanEndDate.Text = "";
			txtPlanNeedHours.Text = "0";
			ddlViewId.SelectedIndex = 0;
			ddlPrjProcessId.SelectedIndex = 0;
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
			ComValid_PlanNeedHours.Validate();
			if (!ComValid_PlanNeedHours.IsValid) return false;
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
			txtPrjTaskId.Text = "";
			txtTaskName.Text = "";
			txtTaskDesc.Text = "";
			ddlExecutor.SelectedIndex = 0;
			ddlDepartmentId.SelectedIndex = 0;
			txtPlanBeginDate.Text = "";
			txtPlanEndDate.Text = "";
			txtPlanNeedHours.Text = "0";
			ddlViewId.SelectedIndex = 0;
			ddlPrjProcessId.SelectedIndex = 0;
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
		/// 功能：获取所给日期的字符串
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
		public string getDateStr(System.DateTime dtDay,  int intFormat)
		{
			string strToday;
			string strYear, strMonth, strDay;
			int intYear, intMonth, intDay;
			intYear = dtDay.Year;
			intMonth = dtDay.Month;
			intDay = dtDay.Day;
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
		/// 功能：获取所给日期的字符串
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
		public System.DateTime TransDateStr(string strDate)
		{
			string strTransDate;
			string strYear, strMonth, strDay;
			int intYear, intMonth, intDay;
			if (strDate.Length != 8)
				return System.DateTime.Today;
			strYear = strDate.Substring(0,4);
			intYear = int.Parse(strYear);
			strMonth = strDate.Substring(4,2);
			intMonth = int.Parse(strMonth);
			if (intMonth>12 || intMonth<1)
				return System.DateTime.Today;
			strDay = strDate.Substring(6,2);
			intDay = int.Parse(strDay);
			
			if (intDay>31 || intDay<1)
				return System.DateTime.Today;
			strTransDate =strYear + "-" + strMonth + "-" + strDay;
			System.DateTime dtDate = System.DateTime.Parse(strTransDate);
			return dtDate;
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
		
		public System.Data.DataTable GetExecutor()
		{
			//获取某学院所有专业信息
			string strSQL = "select UserId, UserName from Users ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_Executor(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetExecutor();
			objDDL.DataValueField="UserId";
			objDDL.DataTextField="UserName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
	
		
		public System.Data.DataTable GetPrjProcessId()
		{
			//获取某学院所有专业信息
			string strSQL = "select PrjProcessId, PrjProcessName from PrjProcess ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_PrjProcessId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetPrjProcessId();
			objDDL.DataValueField="PrjProcessId";
			objDDL.DataTextField="PrjProcessName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_Executor()
		{
			BindDdl_Executor(ddlExecutor);
		}
		public void SetDdl_DepartmentId()
		{
            clsDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentId);
		}
		public void SetDdl_ViewId(string strPrjId)
		{
	clsViewInfoBLEx.		BindDdl_ViewIdEx(ddlViewId, strPrjId);
		}
		public void SetDdl_PrjProcessId()
		{
			BindDdl_PrjProcessId(ddlPrjProcessId);
		}
	}
}