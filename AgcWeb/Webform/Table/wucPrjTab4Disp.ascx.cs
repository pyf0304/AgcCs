
namespace AGC.Webform
{
    using System;
    //using SqlSv;

    using AGC.BusinessLogic;
    using AGC.BusinessLogicEx;
    /// <summary>
    ///		wucPrjTab4Disp 的摘要说明。
    /// </summary>
    public partial class wucPrjTab4Disp : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

            ///隐藏应该应该隐藏的控件内容
            tabHidden.Visible = false;


        }
        public string TabId
        {
            get
            {
                return txtTabId.Text.Trim();
            }
            set
            {
                txtTabId.Text = value.ToString();
            }
        }
        

        public string DataBaseName
        {
            get
            {
                return txtDataBaseName.Text.Trim();
            }
            set
            {
                txtDataBaseName.Text = value.ToString();
            }
        }
        public string Owner
        {
            get
            {
                return txtOwner.Text.Trim();
            }
            set
            {
                txtOwner.Text = value.ToString();
            }
        }
        public string TabName
        {
            get
            {
                return txtTabName.Text.Trim();
            }
            set
            {
                txtTabName.Text = value.ToString();
            }
        }
        public string TabCnName
        {
            get
            {
                return txtTabCnName.Text.Trim();
            }
            set
            {
                txtTabCnName.Text = value.ToString();
            }
        }

        //public string ObjId
        //{
        //    get
        //    {
        //        if (ddlObjId.SelectedValue == "0")
        //        {
        //            return "";
        //        }
        //        return ddlObjId.SelectedValue;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            ddlObjId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            bool bolIsHasValue = false;
        //            for (int i = 0; i < ddlObjId.Items.Count; i++)
        //            {
        //                ListItem liListItem = ddlObjId.Items[i];
        //                if (liListItem.Value == value)
        //                {
        //                    ddlObjId.SelectedIndex = i;
        //                    bolIsHasValue = true;
        //                    break;
        //                }
        //            }
        //            if (bolIsHasValue == false)
        //            {
        //                ddlObjId.SelectedValue = "0";
        //            }
        //            //ddlObjId.SelectedValue = value;
        //        }
        //    }
        //}
        public string FuncModuleAgcId
        {
            get
            {
                if (ddlFuncModuleId.SelectedValue == "0")
                {
                    return "";
                }
                return ddlFuncModuleId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlFuncModuleId.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlFuncModuleId.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string ss = objException.Message;
                    }
                    //if (ddlFuncModuleId.SelectedIndex > 0)
                    //{
                    //    string strFuncModuleId = ddlFuncModuleId.SelectedValue;
                    //    clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId, strFuncModuleId);
                    //}
                }
            }
        }

        public string CacheClassifyField
        {
            get
            {
                if (ddlCacheClassifyField.SelectedValue == "0")
                {
                    return "";
                }
                return ddlCacheClassifyField.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlCacheClassifyField.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlCacheClassifyField.SelectedValue = value;
                    }
                    catch (Exception objException)
                    {
                        string ss = objException.Message;
                    }
                    //if (ddlCacheClassifyField.SelectedIndex > 0)
                    //{
                    //    string strFuncModuleId = ddlCacheClassifyField.SelectedValue;
                    //    clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId, strFuncModuleId);
                    //}
                }
            }
        }


        public string ParentClass
        {
            get
            {
                return txtParentClass.Text.Trim();
            }
            set
            {
                txtParentClass.Text = value.ToString();
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

        public bool IsNationStandard
        {
            get
            {
                return chkIsNationStandard.Checked;
            }
            set
            {
                chkIsNationStandard.Checked = value;
            }
        }

        /// <summary>
        /// 工程表是否
        /// </summary>
        public bool IsReleToSqlTab
        {
            get
            {
                return chkIsReleToSqlTab.Checked;
            }
            set
            {
                chkIsReleToSqlTab.Checked = value;
            }
        }

        /// <summary>
        /// 是否支持Cache?
        /// </summary>
        public bool IsUseCache
        {
            get
            {
                return chkIsUseCache.Checked;
            }
            set
            {
                chkIsUseCache.Checked = value;
            }
        }
        //public bool IsNeedGeneIndexer
        //{
        //    get
        //    {
        //        return chkIsNeedGeneIndexer.Checked;
        //    }
        //    set
        //    {
        //        chkIsNeedGeneIndexer.Checked = value;
        //    }
        //}
        public string TabNameB
        {
            get
            {
                return txtTabNameB.Text.Trim();
            }
            set
            {
                txtTabNameB.Text = value.ToString();
            }
        }

        public bool IsArchive
        {
            get
            {
                return chkIsArchive.Checked;
            }
            set
            {
                chkIsArchive.Checked = value;
            }
        }

        public bool IsChecked
        {
            get
            {
                return chkIsChecked.Checked;
            }
            set
            {
                chkIsChecked.Checked = value;
            }
        }

        public string TabStateId
        {
            get
            {
                if (ddlTabStateId.SelectedValue == "0")
                    return "";
                return ddlTabStateId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlTabStateId.SelectedValue = "0";
                }
                else
                {
                    ddlTabStateId.SelectedValue = value;
                }
            }
        }
        /// <summary>
        /// 表类型Id
        /// </summary>
        public string TabTypeId
        {
            get
            {
                if (ddlTabTypeId.SelectedValue == "0")
                    return "";
                return ddlTabTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlTabTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlTabTypeId.SelectedValue = value;
                }
            }
        }
        public string SqlDsTypeId
        {
            get
            {
                return ddlSqlDsTypeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlSqlDsTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlSqlDsTypeId.SelectedValue = value;
                    if (value == "02")//如果SQL数据类型是“视图”
                    {
                        ShowRelaTab4View();
                    }
                    else
                    {
                        HideRelaTab4View();
                    }

                }
            }
        }
      
        public string RelaTabId4View
        {
            get
            {
                return ddlRelaTabId4View.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlRelaTabId4View.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlRelaTabId4View.SelectedValue = value;
                    }
                    catch(Exception objException)
                    {
                        string strSS = objException.Message;
                    }
                }
            }
        }

        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtTabId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtTabId.Text = "";
            txtDataBaseName.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            ddlFuncModuleId.SelectedIndex = 0;
            //ddlObjId.SelectedIndex = 0;
            txtMemo.Text = "";
            chkIsArchive.Checked = false;
            chkIsChecked.Checked = false;
            ddlTabStateId.SelectedIndex = 0;
            chkIsNationStandard.Checked = false;
            txtTabNameB.Text = "";

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
            txtTabId.Text = "";
            txtDataBaseName.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            ddlFuncModuleId.SelectedIndex = 0;
            //ddlObjId.SelectedIndex = 0;
            txtMemo.Text = "";
            chkIsArchive.Checked = false;
            chkIsChecked.Checked = false;
            ddlTabStateId.SelectedIndex = 0;
            chkIsNationStandard.Checked = false;
            txtTabNameB.Text = "";

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
        

        //public void SetDdl_ObjId(string strPrjId)
        //{
        //    clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, strPrjId);
        //}
        public void SetDdl_TabStateIdCache()
        {
            clsTabStateBL.BindDdl_TabStateIdCache(ddlTabStateId);
        }
        public void SetDdl_SqlDsTypeIdCache()
        {
            clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);
        }

        public void SetDdl_TabTypeIdCache()
        {
            clsTabTypeBL.BindDdl_TabTypeIdCache(ddlTabTypeId);
        }
        public void SetDdl_FuncModuleId(string strPrjId, string strCurrPrjDataBaseId)
        {
            clsFuncModule_AgcBLEx.BindDdl_FuncModuleId(ddlFuncModuleId, strPrjId, strCurrPrjDataBaseId);
        }

        public void SetDdl_RelaTabId4View(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlRelaTabId4View, strPrjId);
        }

        public void SetDdl_CacheClassifyField(string strTabId)
        {
            clsvPrjTabFldBLEx.BindDdl_FldIDByTabId(ddlCacheClassifyField, strTabId);
        }

        protected void ddlFuncModuleId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //if (ddlFuncModuleId.SelectedIndex > 0)
            //{
            //    string strFuncModuleId = ddlFuncModuleId.SelectedValue;
            //    //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjId, clsPubVar.CurrSelPrjId, strFuncModuleId);
            //}
        }

        //protected void ddlObjId_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    if (ddlObjId.SelectedIndex > 0 && txtTabCnName.Text == "")
        //    {
        //        string strObjId = ddlObjId.SelectedValue;
        //        txtTabCnName.Text = clsPrjObjectsBL.GetPrjObjectsByObjId(strObjId).ObjName;
        //    }
        //}

        /// <summary>
        /// 隐藏视图的相关表
        /// </summary>
        public void HideRelaTab4View()
        {
            lblRelaTabId4View.Visible = false;
            ddlRelaTabId4View.Visible = false;
        }

        /// <summary>
        /// 隐藏视图的相关表
        /// </summary>
        public void ShowRelaTab4View()
        {
            lblRelaTabId4View.Visible = true;
            ddlRelaTabId4View.Visible = true;
        }
    }
}