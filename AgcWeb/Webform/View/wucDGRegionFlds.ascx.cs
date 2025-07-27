
namespace AGC.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using com.taishsoft.commdb;
    using AGC.BusinessLogic;
    using AGC.BusinessLogicEx;
    using AGC.Entity;
    using AGC.FunClass;
    using TzAdvancedLib;
    using CommFunc4WebForm;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///		wucDGRegionFlds 的摘要说明。
    /// </summary>
    public partial class wucDGRegionFlds : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			
            vsPrjId_Cache = clsPubVar.CurrSelPrjId;
            ddlFldId1.Enabled = true;
        }
		//public long TabFldId
		//{
		//	get
		//	{
		//		return long.Parse(txtTabFldId.Text.Trim());
		//	}
		//	set
		//	{
		//		txtTabFldId.Text = value.ToString();
		//	}
		//}

        public string FldId
        {
            get
            {
                if (ddlFldId1.SelectedValue == "0")
                    return "";
                return ddlFldId1.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlFldId1.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlFldId1.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string strSS = objException.Message;
                    }
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

        public string DataPropertyName
        {
            get
            {
                return txtDataPropertyName.Text;
            }
            set
            {
                txtDataPropertyName.Text = value.ToString();
            }
        }
        public string SortExpression
        {
            get
            {
                return txtSortExpression.Text;
            }
            set
            {
                txtSortExpression.Text = value.ToString();
            }
        }
        

        public string DataNodeId
        {
            get
            {
                if (ddlDataNodeId.SelectedValue == "0")
                    return "";
                return ddlDataNodeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlDataNodeId.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlDataNodeId.SelectedValue = value;
                    }
                    catch(Exception objException)
					{
						clsPubVar.objLog.WriteDebugLog(objException.Message);
						//string ss = "";
					}
                }
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

		public string ColCaption
		{
			get
			{
				return txtColCaption.Text.Trim();
			}
			set
			{
				txtColCaption.Text = value.ToString();
			}
		}

		public bool IsNeedSort
		{
			get
			{
				return chkIsNeedSort.Checked;
			}
			set
			{
				chkIsNeedSort.Checked = value;
			}
		}

		public bool IsTransToChkBox
		{
			get
			{
				return chkIsTransToChkBox.Checked;
			}
			set
			{
				chkIsTransToChkBox.Checked = value;
			}
		}

		public bool IsVisible
		{
			get
			{
				return chkIsVisible.Checked;
			}
			set
			{
				chkIsVisible.Checked = value;
			}
		}

		public bool IsFuncFld
		{
			get
			{
				return chkIsFuncFld.Checked;
			}
			set
			{
				chkIsFuncFld.Checked = value;
			}
		}

		public string DgFuncTypeId
		{
			get
			{
				if (ddlDgFuncTypeId.SelectedValue == "0")
					return "";
				return ddlDgFuncTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlDgFuncTypeId.SelectedValue = "0";
				}
				else
				{
					ddlDgFuncTypeId.SelectedValue = value;
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
		
			ddlCtlTypeId.SelectedIndex = 0;
			txtColCaption.Text = "";
			chkIsNeedSort.Checked = false;
			chkIsTransToChkBox.Checked = false;
			chkIsVisible.Checked = false;
			chkIsFuncFld.Checked = false;
			ddlDgFuncTypeId.SelectedIndex = 0;
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
			ddlCtlTypeId.SelectedIndex = 0;
			txtColCaption.Text = "";
			chkIsNeedSort.Checked = false;
			chkIsTransToChkBox.Checked = false;
			chkIsVisible.Checked = false;
			chkIsFuncFld.Checked = false;
			ddlDgFuncTypeId.SelectedIndex = 0;
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
	
		public void SetDdl_CtlTypeId(bool bolIsForApple)
		{
            clsCtlTypeBLEx.BindDdl_CtlTypeIdCacheEx(ddlCtlTypeId, bolIsForApple);
		}
		public void SetDdl_DgFuncTypeId()
		{
            clsDgFuncTypeBL. BindDdl_DgFuncTypeIdCache(ddlDgFuncTypeId);
		}

        protected void ddlFldId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddlFldId.SelectedIndex<=0)
            //{
            //    return;
            //}
            //string strFldId = ddlFldId.SelectedValue;

            //SetDdl_DataNodeId(strFldId);
        }
        public void SetDdl_DataNodeIdByTabId(string strTabId, string strCmPrjId)
        {          
            try
            {
                vsCmPrjId = strCmPrjId;
                clsDataNodeBLEx.BindDdl_ConnectedNodeV3(ddlDataNodeId, strTabId, strCmPrjId);          
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }
        public void SetDdl_FldId(string strTabId)
        {
            clsFieldTabBLEx.BindDdl_FldIdByTabIdEx(ddlFldId1, clsPubVar.CurrSelPrjId, strTabId);
        }
        /// <summary>
        /// Sql数据类型Id， 参数：01：表；02:视图；
        /// </summary>
        public string vsTabId
        {
            get
            {
                string strTabId;
                strTabId = (string)ViewState["TabId"];
                if (strTabId == null)
                {
                    return "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                ViewState.Add("TabId", strTabId);
            }
        }

        protected void ddlDataNodeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsCmPrjId) == true) return;

            string strDataNodeId = ddlDataNodeId.SelectedValue;
            if (string.IsNullOrEmpty(strDataNodeId) == true) return;


            List<clsDataNodeEN> arrConnectedNode = clsDataNodeBLEx.GetConnectedNode_Prev(strDataNodeId, vsCmPrjId);

            var objEndNode = clsDataNodeBL.GetObjByDataNodeIdCache(strDataNodeId, vsCmPrjId);
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objEndNode.TabId, objEndNode.PrjId);
            var arrFldId = arrPrjTabFld.Select(x=>x.FldId);
            arrConnectedNode = arrConnectedNode
                .Where(x => arrFldId.Contains( x.FldId))
                .OrderBy(x=>x.VersionNo)
                .ThenBy(x=>x.Depth)
                .ToList();

            //var arrFldId = arrPrjTabFld.Select(x => x.FldId);
            if (arrConnectedNode.Count == 0) return;
            var objDataNode_MinDepth = arrConnectedNode.First();
            try
            {
                ddlFldId1.SelectedValue = objDataNode_MinDepth.FldId;
            }
            catch(Exception objException)
            {
                string ss = objException.Message;
            }
            clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objEndNode.FldId, objEndNode.PrjId);
            //if (string.IsNullOrEmpty( txtDataPropertyName.Text) == true)
            //{
            txtDataPropertyName.Text = objFieldTab.FldName;
            txtSortExpression.Text = objFieldTab.FldName;
            txtColCaption.Text = objFieldTab.Caption;
            //}
            //txtStartNode.Text = objDataNode.DataNodeName;
            //txtStartNode.ToolTip = objDataNode.DataNodeId;
        }

        protected string vsPrjId_Cache
        {
            get
            {
                string sPrjId_Cache;
                sPrjId_Cache = (string)ViewState["PrjId_Cache"];
                if (sPrjId_Cache == null)
                {
                    sPrjId_Cache = "";
                }
                return sPrjId_Cache;
            }
            set
            {
                string sPrjId_Cache = value;
                ViewState.Add("PrjId_Cache", sPrjId_Cache);
            }
        }
        public string vsCmPrjId
        {
            get
            {
                string sCmPrjId;
                sCmPrjId = (string)ViewState["CmPrjId"];
                if (sCmPrjId == null)
                {
                    sCmPrjId = "";
                }
                return sCmPrjId;
            }
            set
            {
                string sCmPrjId = value;
                ViewState.Add("CmPrjId", sCmPrjId);
            }
        }
    }
}