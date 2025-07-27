
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
    using AGC.BusinessLogic;

    /// <summary>
    ///		wucViewRegion 的摘要说明。
    /// </summary>
    public partial class wucViewRegion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            tabHidden.Visible = false;

        }

        public string RegionName
        {
            get
            {
                return txtRegionName.Text.Trim();
            }
            set
            {
                txtRegionName.Text = value.ToString();
            }
        }

        public string ViewId
        {
            get
            {
                if (ddlViewId.SelectedValue == "0")
                    return "";
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

        public string RegionTypeId
        {
            get
            {
                if (ddlRegionTypeId.SelectedValue == "0")
                    return "";
                return ddlRegionTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlRegionTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlRegionTypeId.SelectedValue = value;
                }
            }
        }

        public string RegionFunction
        {
            get
            {
                return txtRegionFunction.Text.Trim();
            }
            set
            {
                txtRegionFunction.Text = value.ToString();
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

        public string TabId
        {
            get
            {
                if (ddlTabId.SelectedValue == "0")
                    return "";
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
                    try
                    {
                        ddlTabId.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string ss = objException.Message;
                    }
                }
            }
        }

        public int Height
        {
            get
            {
                return int.Parse(txtHeight.Text.Trim());
            }
            set
            {
                txtHeight.Text = value.ToString();
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
        public int ColNum
        {
            get
            {
                return int.Parse(txtColNum.Text.Trim());
            }
            set
            {
                txtColNum.Text = value.ToString();
            }
        }

        public bool IsUseCtrl
        {
            get
            {
                return chkIsUseCtrl.Checked;
            }
            set
            {
                chkIsUseCtrl.Checked = value;
            }
        }


        public void Clear()
        {
            txtRegionName.Text = "";
            ddlViewId.SelectedIndex = 0;
            ddlRegionTypeId.SelectedIndex = 0;
            txtRegionFunction.Text = "";
      
            ddlInOutTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtMemo.Text = "";
            txtColNum.Text = "0";
            chkIsUseCtrl.Checked = false;

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
            ComValid_Height.Validate();
            if (!ComValid_Height.IsValid) return false;
            ComValid_Width.Validate();
            if (!ComValid_Width.IsValid) return false;
            if (IsNumeric(txtHeight.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            if (IsNumeric(txtWidth.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            ComValid_ColNum.Validate();
            if (!ComValid_ColNum.IsValid) return false;
            if (IsNumeric(txtColNum.Text) == false)
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
            txtRegionName.Text = "";
            ddlViewId.SelectedIndex = 0;
            ddlRegionTypeId.SelectedIndex = 0;
            txtRegionFunction.Text = "";
   
            ddlInOutTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtMemo.Text = "";
            txtColNum.Text = "0";
            chkIsUseCtrl.Checked = false;

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
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
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
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
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
            for (int i = 0; i < intLen; i++)
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
            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
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
            if (intPointNum > 1) return false;
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
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }


     
       
        public void SetDdl_ViewId(string strPrjId)
        {
            clsViewInfoBLEx.  BindDdl_ViewIdEx(ddlViewId, strPrjId);
        }
        public void SetDdl_RegionTypeId()
        {
            clsDropDownList.BindDdl_RegionTypeId(ddlRegionTypeId);
        }
      
        public void SetDdl_InOutTypeId()
        {
            clsInOutTypeBL.BindDdl_InOutTypeIdCache(ddlInOutTypeId);
        }
        public void SetDdl_TabId(string strPrjId, string strCmPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdByCmPrjIdExCacheNoPureClass(ddlTabId, strPrjId, strCmPrjId);
        }

        protected void ddlInSqlDsTypeId_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (ddlInOutTypeId.SelectedIndex != 0)
            {
                string strInOutTypeId = ddlInOutTypeId.SelectedValue;

                if (strInOutTypeId == enumInOutType.IN_02)
                {
                    clsDropDownList.BindDdl_RelaTabId(ddlTabId, enumSQLDSType.SqlTab_01, clsPubVar.CurrSelPrjId);
                }
                else if (strInOutTypeId == enumInOutType.OUT_03)
                {
                    clsDropDownList.BindDdl_RelaTabId(ddlTabId, enumSQLDSType.SqlView_02, clsPubVar.CurrSelPrjId);
                }
            }
        }
    }
}