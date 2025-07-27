
namespace AGC
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucPrjPotence 的摘要说明。
    /// </summary>
    public partial class wucPrjPotence : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面

		}
		public string PotenceId
		{
			get
			{
				return PId.Text.Trim()+txtPotenceId.Text.Trim();
			}
			set
			{
//				txtPotenceId.Text = value.ToString();
				PId.Text = value.ToString().Trim().Substring(0,4);
				txtPotenceId.Text = value.ToString().Trim().Substring(4,4);
			}
		}

		public string PrjId
		{
			get
			{
				if (ddlPrjId.SelectedValue == "0")
					return "";
				return ddlPrjId.SelectedValue;
			}
			set
			{
				ddlPrjId.SelectedValue = value;
			}
		}

		public string FLM
		{
			get
			{
				if (ddlFLM.SelectedValue == "0")
					return "";
				return ddlFLM.SelectedValue;
			}
			set
			{
				ddlFLM.SelectedValue = value;
			}
		}

		public string PotenceName
		{
			get
			{
				return txtPotenceName.Text.Trim();
			}
			set
			{
				txtPotenceName.Text = value.ToString();
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

		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtPotenceId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			PId.Text = "";
			txtPotenceId.Text = "";
			ddlPrjId.SelectedIndex = 0;
			ddlFLM.SelectedIndex = 0;
			txtPotenceName.Text = "";
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
			txtPotenceId.Text = "";
			ddlPrjId.SelectedIndex = 0;
			ddlFLM.SelectedIndex = 0;
			txtPotenceName.Text = "";
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
	
		public System.Data.DataTable GetFLM(string prjid)
		{
			//获取某学院所有专业信息
			string strSQL = "select FLM, FLMC from PotenceFL where PrjId = '"+prjid+"' ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_FLM(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetFLM(PrjId);
			objDDL.DataValueField="FLM";
			objDDL.DataTextField="FLMC";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_PrjId()
		{
			clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
		}
		public void SetDdl_FLM()
		{
			BindDdl_FLM(ddlFLM);
		}

		protected void ddlPrjId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		   SetDdl_FLM();
			PId.Text=ddlPrjId.SelectedValue;
		}
	}
}