
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
    using com.taishsoft.datetime;
    using AGC.Entity;

    /// <summary>
    ///		wucViewFeatureFlds 的摘要说明。
    /// </summary>
    public partial class wucViewFeatureFlds : System.Web.UI.UserControl
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible = false;

		}


        /// <summary>
        /// 字段Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
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
                if (ddlFldId.Items.Count > 0)
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
        }
        /// <summary>
        /// 字段类型Id
        /// (AGC.BusinessLogicEx.clsEditRegionFldsBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FieldTypeId
        {
            get
            {
                if (ddlFieldTypeId.SelectedValue == "0")
                    return "";
                return ddlFieldTypeId.SelectedValue;
            }
            set
            {
                if (ddlFieldTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFieldTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFieldTypeId.SelectedValue = value;
                        SetFldVisibilityByFieldTypeId(value);
                    }
                }
            }
        }

        public string ViewFeatureName
        {         
            set
            {
                lblViewFeatureName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 函数名
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FuncName
        {
            get
            {
                return txtFuncName.Text.Trim();
            }
            set
            {
                txtFuncName.Text = value.ToString();
            }
        }
        
        public string CtrlId
        {
            get
            {
                return txtCtrlId.Text.Trim();
            }
            set
            {
                txtCtrlId.Text = value.ToString();
            }
        }

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

    
		public int SeqNum
		{
			get
			{
                if (string.IsNullOrEmpty(txtSeqNum.Text)) return 0;
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
				return clsDateTime.getTodayDateTimeStr(1);
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
			txtTabFldId.Text = "0";
			
			
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
		
        protected void ddlFldId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFldId.SelectedIndex <= 0) return;
            if (string.IsNullOrEmpty(wucEditControl1.CtlTypeId)) return;
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(vsViewFeatureId);
            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFldsEN.FeatureId);

            string strFldId = ddlFldId.SelectedValue;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "设置字段值":
                    string strFuncName = string.Format("Set{0}", objFieldTab.FldName);
                    if (objFieldTab.DataTypeId == enumDataTypeAbbr.bit_03)
                    {
                        string strCondition = string.Format("{0}='{1}' ",
                            conViewFeatureFlds.ViewFeatureId, vsViewFeatureId,
                            conViewFeatureFlds.FuncName, strFuncName);
                        if (clsViewFeatureFldsBL.IsExistRecord(strCondition) == false)
                        {
                            txtFuncName.Text = strFuncName;
                        }
                        else
                        {
                            strFuncName = string.Format("SetNot{0}", objFieldTab.FldName);
                            txtFuncName.Text = strFuncName;
                        }
                    }
                    else
                    {
                        txtFuncName.Text = strFuncName;
                    }
                    txtCtrlId.Text = string.Format("{0}", clsCtlTypeBLEx.GetCtrlId(wucEditControl1.CtlTypeId, objFieldTab.FldName));
                    break;
                case "复制记录":

                    break;
                
                case "调整记录次序":
                case "移顶":
                case "上移":
                case "下移":
                case "移底":
                case "重序":
                    txtCtrlId.Text = string.Format("{0}_OrderNum", clsCtlTypeBLEx.GetCtrlId(wucEditControl1.CtlTypeId, objFieldTab.FldName));
                    break;
                default:
                    break;
            }
        }
        public void GetCtrlId()
        {            
            if (ddlFldId.SelectedIndex <= 0) return;
            if (string.IsNullOrEmpty(wucEditControl1.CtlTypeId)) return;
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(vsViewFeatureId);
            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFldsEN.FeatureId);

            string strFldId = ddlFldId.SelectedValue;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "设置字段值":
                   
                    txtCtrlId.Text = string.Format("{0}", clsCtlTypeBLEx.GetCtrlId(wucEditControl1.CtlTypeId, objFieldTab.FldName));
                    break;
                case "复制记录":

                    break;

                case "调整记录次序":
                case "移顶":
                case "上移":
                case "下移":
                case "移底":
                case "重序":
                    txtCtrlId.Text = string.Format("{0}_OrderNum", clsCtlTypeBLEx.GetCtrlId(wucEditControl1.CtlTypeId, objFieldTab.FldName));
                    break;
                default:
                    break;
            }
        }
        public string vsViewFeatureId
        {
            get
            {
                string sViewFeatureId;
                sViewFeatureId = (string)ViewState["ViewFeatureId"];
                if (sViewFeatureId == null)
                {
                    sViewFeatureId = "";
                }
                return sViewFeatureId;
            }
            set
            {
                string sViewFeatureId = value;
                ViewState.Add("ViewFeatureId", sViewFeatureId);
                SetCtrlPropByViewFeatureId(value);
            }
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[FldId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FldId(string strTabId)
        {
            clsFieldTabBLEx.BindDdl_FldIDByTabIdEx(ddlFldId, clsPubVar.CurrSelPrjId, strTabId);
        }
        public void SetDdl_FieldTypeId()
        {
            clsFieldTypeBL.BindDdl_FieldTypeIdCache(ddlFieldTypeId);
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

        public void SetVisible4ViewFeatureName(bool bolIsVisible)
        {
            trViewFeatureName.Visible = bolIsVisible;
        }
        protected void SetCtrlPropByViewFeatureId(string strViewFeatureId)
        {
            if (string.IsNullOrEmpty(strViewFeatureId)) return;
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);

            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFldsEN.FeatureId);
            //string strFldId = ddlFldId.SelectedValue;
            //clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "绑定下拉框":
                    //trDefaultValue.Visible = true;
                    trFuncName.Visible = false;
                    //trValueGivingModeId.Visible = true;
                    break;
                case "设置字段值":
                    //lblDefaultValue.Text = "缺省值";
                    trFuncName.Visible = false;
                    //trValueGivingModeId.Visible = true;
                    break;
                case "复制记录":
                    //lblDefaultValue.Text = "复制前缀";
                    //if (string.IsNullOrEmpty(DefaultValue))
                    //{
                    //    DefaultValue = "Copy_";
                    //}
                    //trFuncName.Visible = false;
                    //trValueGivingModeId.Visible = false;
                    //FieldTypeId = enumFieldType.AdditionalCopyField_15;
                    break;
                case "调整记录次序":
                    //DefaultValue = "";
                    //trDefaultValue.Visible = false;
                    FuncName = "";
                    trFuncName.Visible = false;

                    //trValueGivingModeId.Visible = false;

                    break;
                default:
                    break;
            }
        }

        protected void wucEditControl1_ctlTypeIdChanged(object sender, System.EventArgs e)
        {
            clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(vsViewFeatureId);
            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFldsEN.FeatureId);
            switch (wucEditControl1.CtlTypeId)
            {
                case enumCtlType.TextBox_16:
                case enumCtlType.DropDownList_06:
                    trCtrlId.Visible = true;
                    break;
            }
            string strFldId = ddlFldId.SelectedValue;
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
            switch (objPrjFeatureEN.FeatureName)
            {
                case "设置字段值":
                    string strFuncName = string.Format("Set{0}", objFieldTab.FldName);
                    if (objFieldTab.DataTypeId == enumDataTypeAbbr.bit_03)
                    {
                        string strCondition = string.Format("{0}='{1}' ",
                            conViewFeatureFlds.ViewFeatureId, vsViewFeatureId,
                            conViewFeatureFlds.FuncName, strFuncName);
                        if (clsViewFeatureFldsBL.IsExistRecord(strCondition) == false)
                        {
                            txtFuncName.Text = strFuncName;
                        }
                        else
                        {
                            strFuncName = string.Format("SetNot{0}", objFieldTab.FldName);
                            txtFuncName.Text = strFuncName;
                        }
                    }
                    else
                    {
                        txtFuncName.Text = strFuncName;
                    }
                    txtCtrlId.Text = string.Format("{0}", clsCtlTypeBLEx.GetCtrlId(wucEditControl1.CtlTypeId, objFieldTab.FldName));
                    break;
                case "复制记录":

                    break;

                case "调整记录次序":
                case "移顶":
                case "上移":
                case "下移":
                case "移底":
                case "重序":
                    txtCtrlId.Text = string.Format("{0}_OrderNum", clsCtlTypeBLEx.GetCtrlId(wucEditControl1.CtlTypeId, objFieldTab.FldName));
                    break;
                default:
                    break;
            }
        }

        public void SetFldVisibilityByFieldTypeId(string strFieldTypeId)
        {
            //trValueGivingModeId.Visible = true;
            trFuncName.Visible = false;
            trLabelCaption.Visible = false;
            trCtrlId.Visible = false;
//            trFuncName.Visible = true;
            switch (strFieldTypeId)
            {
                case enumFieldType.OrderNumField_09:
                    //trValueGivingModeId.Visible = false;
  //                  trFuncName.Visible = false;
                    break;
                case enumFieldType.ClassificationField_10:

                    break;
                    
                default:
                    switch (wucEditControl1.CtlTypeId)
                    {
                        case enumCtlType.TextBox_16:
                        case enumCtlType.DropDownList_06:
                            trCtrlId.Visible = true;
                            break;
                    }
                    break;
            }
        }
        public void SetDdl_VarId(string strPrjId)
        {
             wucEditControl1.SetDdl_VarId(strPrjId);
            //			BindDdl_DsTabId(ddlDsTabId);
        }

        protected void ddlFieldTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFieldTypeId.SelectedIndex <= 0) return;
            string strFieldTypeId = ddlFieldTypeId.SelectedValue;
            SetFldVisibilityByFieldTypeId(strFieldTypeId);
        }
    }
}