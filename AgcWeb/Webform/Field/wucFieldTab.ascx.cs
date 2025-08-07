
namespace AGC.Webform
{
    using System;
    using System.Collections;
    using System.Data;
    using System.Drawing;
    using System.Configuration;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using System.Collections.Generic;
    using AGC.BusinessLogic;using AGC.FunClass;
    
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    using com.taishsoft.datetime;


    /// <summary>
    ///		wucFieldTab 的摘要说明。
    /// </summary>
    public partial class wucFieldTab : System.Web.UI.UserControl
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			tabHidden.Visible = false;

		}
        public UpdatePanelUpdateMode UpdateMode
        {
            get { return this.FieldTabUpdatePanel.UpdateMode; }
            set { this.FieldTabUpdatePanel.UpdateMode = value; }
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
        public List<ObjStruct> TabList
		{
			get
			{
                List<ObjStruct> arrLst = new List<ObjStruct>();
				int intLen = lstTabList.Items.Count;
				for ( int i = 0; i<intLen; i++)
				{
                    ObjStruct obj = new ObjStruct();
                    obj.strObjId = lstTabList.Items[i].Value;
                    obj.strObjName = lstTabList.Items[i].Text;

                    arrLst.Add(obj);
				}
				return arrLst;
			}
			set
			{
				ListItem li;
				lstTabList.Items.Clear();
				foreach ( ObjStruct objStruct in value)
				{
					li=new ListItem(objStruct.strObjName, objStruct.strObjId);
					lstTabList.Items.Add(li);
				}
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
                    }
                }
            }
        }

        public string HomologousFldId
        {
            get
            {
                if (ddlHomologousFldId.SelectedValue == "0")
                    return "";
                return ddlHomologousFldId.SelectedValue;
            }
            set
            {
                if (ddlHomologousFldId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlHomologousFldId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlHomologousFldId.SelectedValue = value;
                    }
                }
            }
        }
        public string DataTypeId
		{
			get
			{
				if (ddlFldType.SelectedValue == "0")
				{
					return "";
				}
				return ddlFldType.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFldType.SelectedValue = "0";
				}
				else
				{
					ddlFldType.SelectedValue = value;
				}
			}
		}
        /// <summary>
        /// 字段长度
        /// </summary>
		public int FldLength
		{
			get
			{
				return int.Parse(txtFldLength.Text.Trim());
			}
			set
			{
				txtFldLength.Text = value.ToString();
			}
		}
        /// <summary>
        /// 小位位数-FldPrecision
        /// </summary>
        public int FldPrecision
        {
            get
            {
                if (string.IsNullOrEmpty(txtFldPrecision.Text.Trim()) == true) return 0;
                return int.Parse(txtFldPrecision.Text.Trim());
            }
            set
            {
                txtFldPrecision.Text = value.ToString();
            }
        }
		public string Caption
		{
			get
			{
				return txtCaption.Text.Trim();
			}
			set
			{
				txtCaption.Text = value.ToString();
			}
		}

		public string FldInfo
		{
			get
			{
				return txtFldInfo.Text.Trim();
			}
			set
			{
				txtFldInfo.Text = value.ToString();
			}
		}

		public bool IsNull
		{
			get
			{
				if (ddlIsNull.SelectedItem.Text == "是")
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			set
			{
				if (value == true)
				{
					ddlIsNull.SelectedValue = "是";
				}
				else
				{
					ddlIsNull.SelectedValue = "否";
				}
			}
		}

		public bool IsPrimaryKey
		{
			get
			{
				return chkIsPrimaryKey.Checked;
			}
			set
			{
				chkIsPrimaryKey.Checked = value;
			}
		}
		public bool IsIdentity
		{
			get
			{
				return chkIsIdentity.Checked;
			}
			set
			{
				chkIsIdentity.Checked = value;
			}
		}
		
		public string FldStateId
		{
			get
			{
				if (ddlFldStateId.SelectedValue == "0")
					return "";
				return ddlFldStateId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlFldStateId.SelectedValue = "0";
				}
				else
				{
					ddlFldStateId.SelectedValue = value;
				}
			}
		}


		public string MaxValue
		{
			get
			{
				return txtMaxValue.Text.Trim();
			}
			set
			{
				txtMaxValue.Text = value.ToString();
			}
		}

		public string MinValue
		{
			get
			{
				return txtMinValue.Text.Trim();
			}
			set
			{
				txtMinValue.Text = value.ToString();
			}
		}

		public string DefaultValue
		{
			get
			{
				return txtDefaultValue.Text.Trim();
			}
			set
			{
				txtDefaultValue.Text = value.ToString();
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
				SetForIsNeedTransCode_CheckedChanged();
			}
		}

		public string CodeTabId
		{
			get
			{
				if (chkIsNeedTransCode.Checked == false)
					return "";
				if (ddlCodeTab.SelectedItem.Text =="请选择...")
				{
					return "";
				}
				return ddlCodeTab.SelectedValue;
			}
			set
			{
				if (value=="")
				{
					if (ddlCodeTab.Items.Count>0)
					{
						ddlCodeTab.SelectedIndex = 0;
					}
				}
				else
				{
                    try
                    {
                        ddlCodeTab.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string strSS = objException.Message;
                    }
				}
				SetForCodeTab_SelectedIndexChanged();
			}
		}
		public string CodeTabNameId
		{
			get
			{
				if (chkIsNeedTransCode.Checked == false)
					return "";
				return ddlCodeTabName.SelectedValue;
			}
			set
			{
				if (value != "")
				{
                    try
                    {
                        ddlCodeTabName.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
						clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);

					}
				}
				
			}
		}
		public string CodeTabCodeId
		{
			get
			{
				if (chkIsNeedTransCode.Checked == false)
					return "";
				return ddlCodeTabCode.SelectedValue;
			}
			set
			{
				if (value != "")
				{
                    try
                    {
                        ddlCodeTabCode.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
						clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);

					}
				}
			}
		}
		public string UpdDate
		{
			get
			{
				return clsDateTime.getTodayDateTimeStr(1);
			}
		}

		public string UserId
		{
			get
			{
				return clsCommonSession.UserId;
			}
		}
        
		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtFldID.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtFldID.Text = "";
            ddlPrjId.SelectedIndex = 0;
			txtFldName.Text = "";
			ddlFldType.SelectedIndex = 0;
			txtFldLength.Text = "0";
			txtCaption.Text = "";
			txtFldInfo.Text = "";
			ddlIsNull.SelectedIndex = 0;
//			ddlIsPrimaryKey.SelectedIndex = 0;
			txtMaxValue.Text = "";
			txtMinValue.Text = "";
			txtDefaultValue.Text = "";
			chkIsNeedTransCode.Checked = false;
			
			ddlCodeTab.Visible=false;
			ddlCodeTabName.Visible=false;
			ddlCodeTabCode.Visible=false;
			ddlCodeTab.SelectedIndex=0;
            if (ddlCodeTabName.Items.Count > 0)
            {
                ddlCodeTabName.SelectedIndex = 0;
            }
            if (ddlCodeTabCode.Items.Count > 0)
            {
                ddlCodeTabCode.SelectedIndex = 0;
            }
			
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
			ComValid_FldLength.Validate();
			if (!ComValid_FldLength.IsValid) return false;
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
			txtFldID.Text = "";
            ddlPrjId.SelectedIndex = 0;
			txtFldName.Text = "";
			ddlFldType.SelectedIndex = 0;
			txtFldLength.Text = "0";
			txtCaption.Text = "";
			txtFldInfo.Text = "";
			ddlIsNull.SelectedIndex = 0;
//			ddlIsPrimaryKey.SelectedIndex = 0;
			txtMaxValue.Text = "";
			txtMinValue.Text = "";
			txtDefaultValue.Text = "";
			chkIsNeedTransCode.Checked = false;
			ddlCodeTab.Visible=false;
			ddlCodeTabName.Visible=false;
			ddlCodeTabCode.Visible=false;
			ddlCodeTab.SelectedIndex=0;
			ddlCodeTabName.SelectedIndex=0;
			ddlCodeTabCode.SelectedIndex=0;
						
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
		
		
	
		public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("请选择...","0");
			objDDL.Items.Add("是");
			objDDL.Items.Add("否");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//为下拉框设置内容的样例，该下拉框的列表项是直接添加的
			///objDDL.Items.Add("男");
			///objDDL.Items.Add("女");
		}
		public void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("请选择...","0");
			objDDL.Items.Add("是");
			objDDL.Items.Add("否");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//为下拉框设置内容的样例，该下拉框的列表项是直接添加的
			///objDDL.Items.Add("男");
			///objDDL.Items.Add("女");
		}
		public void SetDdl_PrjId()
		{
            clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
		}
		public void SetDdl_FldType()
		{
           clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldType);
		}
		public void SetDdl_IsNull()
		{
			BindDdl_IsNull(ddlIsNull);
		}
		public void SetDdl_IsPrimaryKeyBak()
		{
//			BindDdl_IsPrimaryKey(ddlIsPrimaryKey);
		}
		public void BingDdl_DS_TabColumn(string strTabId, System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为下拉框专业设置内容	
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT =clsDropDownList.GetDsDataTextField(strTabId);
			if (objDT.Rows.Count >0 )
			{
				objDDL.DataValueField= conFieldTab.FldId;
				objDDL.DataTextField= conFieldTab.FldName;
				objDDL.DataSource = objDT;
				objDDL.DataBind();
			}
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;

		}

		private void SetForCodeTab_SelectedIndexChanged()
		{
			string strTabId = ddlCodeTab.SelectedValue;
			BingDdl_DS_TabColumn(strTabId, ddlCodeTabCode);
			BingDdl_DS_TabColumn(strTabId, ddlCodeTabName);
		}
        //private string strPrjId
        //{
        //    get
        //    {
        //        string pstrPrjId;
        //        pstrPrjId = (string)Session["P1rjId"];
        //        if (pstrPrjId==null) 
        //        {
        //            pstrPrjId = "";
        //        }
        //        return pstrPrjId;
        //    }
        //    set
        //    {
        //        string pstrPrjId = value;
        //        Session.Add("PrjId", pstrPrjId);
        //    }
        //}
		public void SetDdl_CodeTab()
		{
            //为代码转换表设置内容
            //为下拉框专业设置内容	
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlCodeTab, clsPubVar.CurrSelPrjId);
    

        }

        /// <summary>
        /// 为对象ID下拉框添加内容
        /// </summary>
        public void SetLB_TabId(string strPrjId)
		{
            //为下拉框专业设置内容	
            clsvPrjTab4DdlBLEx.BindLB_TabId(lstSouTabList, strPrjId);
        }


        private void SetForIsNeedTransCode_CheckedChanged()
		{
			if (chkIsNeedTransCode.Checked == true)
			{
				ddlCodeTab.Visible=true;
				ddlCodeTabName.Visible=true;
				ddlCodeTabCode.Visible=true;
				SetDdl_CodeTab();
			}
			else
			{
				ddlCodeTab.Visible=false;
				ddlCodeTabName.Visible=false;
				ddlCodeTabCode.Visible=false;
			}
		}

		protected void chkIsNeedTransCode_CheckedChanged(object sender, System.EventArgs e)
		{
			SetForIsNeedTransCode_CheckedChanged();
		}

		protected void ddlCodeTab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetForCodeTab_SelectedIndexChanged();
		}

		protected void lbAddObject_Click(object sender, System.EventArgs e)
		{
			
		}

		protected void lbDelObject_Click(object sender, System.EventArgs e)
		{
		
		}
		
		
		public void SetDdl_FldStateId()
		{
            clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateId);
		}

        protected void lbEditTab_Click(object sender, EventArgs e)
        {
            if (lstTabList.SelectedItem == null)
            {
                clsCommonJsFunc.Alert(this, "请选择一个表名！");
                lstTabList.Focus();
                return;
            }
            string strTabName = lstTabList.SelectedItem.Text;
            string strCondition = string.Format("TabName='{0}' And PrjId='{1}'", 
                strTabName, clsPubVar.CurrSelPrjId);
            string strTabId = clsPrjTabBL.GetFirstID_S(strCondition);
            //            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            //    clsPubFun4Web.JumpToEditTabAndObjectFields(this.Page, "", strObjId, "");
            clsPubFun4Web.JumpToEditTabAndFields(this.Page, strTabId, "");

        }

        protected void lbDelRelaTab_Click(object sender, EventArgs e)
        {
            lstTabList.Items.Remove(lstTabList.SelectedItem);
        }

        protected void lbAddRelaTab_Click(object sender, EventArgs e)
        {
            if (lstSouTabList.SelectedIndex > 0)
            {
                lstTabList.Items.Add(lstSouTabList.SelectedItem);
            }
        }
        public void SetDdl_FieldTypeId()
        {
            clsFieldTypeBL.BindDdl_FieldTypeIdCache(ddlFieldTypeId);
        }

        public void SetDdl_HomologousFldId(string strPrjId)
        {
            clsvFieldTab_SimBLEx.BindDdl_FldIdCacheEx(ddlHomologousFldId, strPrjId);
        }
    }
}