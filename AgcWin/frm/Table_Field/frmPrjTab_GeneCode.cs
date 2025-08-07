

using Agc.frm;
using AGC.Entity;
using AGC.frm;
using Agc_CsWin;
using AGC_CSWin;
using AGC4WApi;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.common;
using com.taishsoft.util;
using CommFunc4Win;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;



namespace AGC
{
    /// <summary>
    ///		frmPrjTab_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmPrjTab_GeneCode : System.Windows.Forms.Form, IBindListView
    {
        public CodeElement ceRootElement = null; // 用于存储代码生成的根节点
        private int _lastIndex = -1; // 用于记录上一次查找到的索引
        private bool bolIsInPageLoad = false;
        private bool bolIsBindData = false;
        List<TabPage> arrAllTagPage = new List<TabPage>();
        List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPath = null;
        private string strTimerMode = "PrjTab";
        private bool mbolIsBindGv = true;
        private bool mbolIsStartAccessCmPrjIdChangeEvent = false;
        private List<string> arrTabId_Lst;
        private List<clsPrjTabFldEN> arrPrjTabFld4ShowLst = null;
        //当前选中类为一个时所选的TabId
        private string mstrCurrTabId = "";
        private string mstrGCMainPathId = "";
        private string strCmPrjId = "";
        //private string strCodeTypeId = "";
        private int intApplicationTypeId = 0;
        clsGeneCode_Local objGeneCode_Local = null;
        //clsPrjTabEN objPrjTabEN = null;
        private System.Data.DataTable objDTPrjTab = null;
        private clsListViewSorter objvPrjTabSorter;
        private int intLastSelectedvPrjTabColumIndex;
        private clsPubConst.LangType mltLangType = clsPubConst.LangType.CSharp;//语言类型
        private clsPubConst.DataBaseType mdbtDataBaseType = clsPubConst.DataBaseType.MsSql;//数据库类型
        public frmPrjTab_GeneCode()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvPrjTabSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvPrjTab.ListViewItemSorter = objvPrjTabSorter;
            objvPrjTabSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmPrjTab_QD_Load(object sender, System.EventArgs e)
        {
            bolIsInPageLoad = true;
            //clsProjectsEN objProjectEN = clsProjectsWApi.GetObjByPrjId(clsPubVar.CurrSelPrjId);
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            try
            {
                clsPrjTabExWApi.p_Init_Log4GeneTabCode(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
                string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                    conUserCodePrjMainPath.PrjId, clsPubVar.CurrSelPrjId,
                    conUserCodePrjMainPath.UserId, clsSysParaEN.strUserId);
                arrUserCodePrjMainPath = clsUserCodePrjMainPathWApi.GetObjLstCache(clsPubVar.CurrSelPrjId)
                    .Where(x => x.UserId == clsSysParaEN.strUserId).ToList();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            this.Text = string.Format("项目表代码生成20250705----工程：{0}({1})  数据库：{2}({3})",
                                clsPubVar.objCurrSelProjectEN.PrjName, clsPubVar.objCurrSelProjectEN.PrjId,
                                objPrjDataBaseEN.PrjDataBaseName, objPrjDataBaseEN.PrjDataBaseId);
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();
            SetPrjStatus();
            foreach (TabPage objTabPage in tabAppType.TabPages)
            {

                string strTag = objTabPage.Tag.ToString();
                int intApplicationTypeId = int.Parse(strTag);
                clsApplicationTypeEN objApp = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(intApplicationTypeId);
                if (objApp.IsVisible == false)
                {
                    objTabPage.Visible = false;
                    objTabPage.Parent = null;
                }
                else
                {
                    arrAllTagPage.Add(objTabPage);
                }
            }
            DispClassNameButton();
            string strCharEncodingId = clsPubFun.GetCharEncodingIdByLangTypeId(enumProgLangTypeWA.CSharp_01);
            cboCharEncodingId.SelectedValue = strCharEncodingId;

            
            //if (chkDispAllErrMsg.Checked == true)
            //{
            //    BindLv_vPrjTab_WithErrMsg();
            //}
            //else
            //{
            //    BindLv_vPrjTab(false);
            //}

            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            ShowCodeTypeButton();
            ShowGCIncludeXML();
            mbolIsStartAccessCmPrjIdChangeEvent = true;
            cboCmPrjId_SelectedIndexChanged(null, null);
            cboTabStateId.SelectedIndex = 1;
            bolIsInPageLoad = false;
        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {

            //clsFuncModule_AgcExWApi.BindCbo_FuncModuleId(this.cboFuncModuleId, clsPubVar.CurrSelPrjId);
            clsFuncModule_AgcExWApi.BindCbo_FuncModuleIdCache(this.cboFuncModuleId, clsPubVar.CurrSelPrjId);
            clsSQLDSTypeExWApi.BindCbo_SqlDsTypeIdCache(this.cboSqlDsTypeId);
            clsTabStateExWApi.BindCbo_TabMainTypeIdCache(this.cboTabStateId);
            clsTabMainTypeExWApi.BindCbo_TabMainTypeIdCache(this.cboTabMainTypeId);
            clsCharEncodingExWApi.BindCbo_CharEncodingIdCache(cboCharEncodingId);
            //clsPrjFeatureExWApi.BindCbo_FeatureIdExByFeatureTypeId(cboFeatureId, enumPrjFeatureType.TabFeature_03);
            clsPrjFeatureExWApi.BindCbo_FeatureIdExByFeatureTypeIdCache(cboFeatureId, enumPrjFeatureTypeWA.TabFeature_03);
            clsAppPageTypeExWApi.BindCbo_AppPageTypeIdCache(cboAppPageTypeId);
            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(cboCmPrjId, clsPubVar.CurrSelPrjId);

            string strCmPrjId = clsUserDefaValue_LocalExWApi.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, "默认CM工程");
            if (string.IsNullOrEmpty(strCmPrjId) == false)
            {
                cboCmPrjId.SelectedValue = strCmPrjId;
            }
            else
            {
                cboCmPrjId.SelectedIndex = 1;
            }
            clsComboBox_Common.BindCbo_TrueAndFalse(cboIsUseCache);
            clsComboBox_Common.BindCbo_TrueAndFalse(cboIsShare);
            clsComboBox_Common.BindCbo_TrueAndFalse(cboIsAppliedViewList);

            cboAppPageTypeId.SelectedIndex = 1;
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

        public string ObjId
        {
            get
            {
                if (cboFuncModuleId.SelectedValue.ToString() == "0")
                    return "";
                return cboFuncModuleId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboFuncModuleId.SelectedValue = "0";
                }
                else
                {
                    cboFuncModuleId.SelectedValue = value;
                }
            }
        }

        public string SqlDsTypeId
        {
            get
            {
                if (cboSqlDsTypeId.SelectedValue.ToString() == "0")
                    return "";
                return cboSqlDsTypeId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboSqlDsTypeId.SelectedValue = "0";
                }
                else
                {
                    cboSqlDsTypeId.SelectedValue = value;
                }
            }
        }

        public string TabStateId
        {
            get
            {
                if (cboTabStateId.SelectedValue.ToString() == "0")
                    return "";
                return cboTabStateId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboTabStateId.SelectedValue = "0";
                }
                else
                {
                    cboTabStateId.SelectedValue = value;
                }
            }
        }


        public void Clear()
        {
            txtTabName.Text = "";
            cboFuncModuleId.SelectedIndex = 0;
            cboSqlDsTypeId.SelectedIndex = 0;
            cboTabStateId.SelectedIndex = 0;
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
            txtTabName.Text = "";

            cboFuncModuleId.SelectedIndex = 0;
            cboSqlDsTypeId.SelectedIndex = 0;
            cboTabStateId.SelectedIndex = 0;
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


        public void SetCbo_SqlDsTypeId()
        {
            clsSQLDSTypeWApi.BindCbo_SqlDsTypeId(cboSqlDsTypeId);
        }
        public void SetCbo_TabStateId()
        {
            clsTabStateWApi.BindCbo_TabStateId(cboTabStateId);
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
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombinePrjTabCondionBak()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And {0}='{1}'", conPrjTab.PrjId, clsPubVar.CurrSelPrjId);
            int intApplicationTypeId = getAppTypeId();
            if (intApplicationTypeId == (int)enumApplicationType.PubClass_23)
            {
                strWhereCond += string.Format(" And {0}='{1}'", conPrjTab.TabTypeId, enumTabTypeWA.PureClass_0008);
            }
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabName.Text.Trim() != "")
            {
                strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim() + "%'";
            }
            if (this.cboTabMainTypeId.SelectedValue.ToString() != "" && this.cboTabMainTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.TabMainTypeId='" + this.cboTabMainTypeId.SelectedValue + "'";
            }
            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            }
            if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.TabStateId='" + this.cboTabStateId.SelectedValue + "'";
            }

            if (this.cboFeatureId.SelectedValue.ToString() != "" && this.cboFeatureId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And PrjTab.{0} in (Select {1} from {2} where {3}='{4}')",
                    conPrjTab.TabId,
                    conTabFeature.TabId,
                    clsTabFeatureEN._CurrTabName,
                    conTabFeature.FeatureId,
                    cboFeatureId.SelectedValue.ToString()
                    );
            }
            return strWhereCond;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombinePrjTabCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And {0}='{1}'", conPrjTab.PrjId, clsPubVar.CurrSelPrjId);
            int intApplicationTypeId = getAppTypeId();
            List<int> arrAppTypeId = new List<int>() { (int)enumApplicationType.PubClass_23, (int)enumApplicationType.PubClass_TS_29 };
            if (arrAppTypeId.Contains(intApplicationTypeId))
            {
                strWhereCond += string.Format(" And {0}='{1}'", conPrjTab.TabTypeId, enumTabTypeWA.PureClass_0008);
            }
            else
            {
                strWhereCond += string.Format(" And {0}<>'{1}'", conPrjTab.TabTypeId, enumTabTypeWA.PureClass_0008);
            }
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            //        if (bolIsWithTabName == true)
            //        {
            //            if (this.cboCmPrjId.SelectedValue.ToString() != ""
            //&& this.cboCmPrjId.SelectedValue.ToString() != "0")
            //            {
            //                strWhereCond += string.Format(" And {0} in (Select {0} From {1} Where {2}='{3}')",
            //                    conPrjTab.TabId, conCmProjectPrjTab._CurrTabName, conCmProjectPrjTab.CmPrjId, this.cboCmPrjId.SelectedValue);
            //            }
            //            if (this.cboTabMainTypeId.SelectedValue.ToString() != "" && this.cboTabMainTypeId.SelectedValue.ToString() != "0")
            //            {
            //                strWhereCond += " And PrjTab.TabMainTypeId='" + this.cboTabMainTypeId.SelectedValue + "'";
            //            }
            //            if (this.txtTabName.Text.Trim() != "")
            //            {
            //                strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim() + "%'";
            //            }

            //            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            //            {
            //                strWhereCond += " And PrjTab.FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
            //            }
            //            if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            //            {
            //                strWhereCond += " And PrjTab.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            //            }
            //            if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
            //            {
            //                strWhereCond += " And PrjTab.TabStateId='" + this.cboTabStateId.SelectedValue + "'";
            //            }
            //        }
            //        else
            //        {
            if (cboIsUseCache.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0}='1'", convPrjTab.IsUseCache);
            }
            else if (cboIsUseCache.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0}='0'", convPrjTab.IsUseCache);
            }

            if (cboIsShare.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0}='1'", convPrjTab.IsShare);
            }
            else if (cboIsShare.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0}='0'", convPrjTab.IsShare);
            }


            if (this.cboCmPrjId.SelectedValue.ToString() != ""
                && this.cboCmPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} in (Select {0} From {1} Where {2}='{3}')",
                    conPrjTab.TabId, conCmProjectPrjTab._CurrTabName, conCmProjectPrjTab.CmPrjId, this.cboCmPrjId.SelectedValue);
            }
            if (this.cboTabMainTypeId.SelectedValue.ToString() != "" && this.cboTabMainTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And TabMainTypeId='" + this.cboTabMainTypeId.SelectedValue + "'";
            }
            if (this.txtTabName.Text.Trim() != "")
            {
                strWhereCond += " And TabName like '%" + this.txtTabName.Text.Trim() + "%'";
            }

            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            }
            if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And TabStateId='" + this.cboTabStateId.SelectedValue + "'";
            }
            if (this.cboFeatureId.SelectedValue.ToString() != "" && this.cboFeatureId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And {0} in (Select {1} from {2} where {3}='{4}')",
                    conPrjTab.TabId,
                    conTabFeature.TabId,
                    clsTabFeatureEN._CurrTabName,
                    conTabFeature.FeatureId,
                    cboFeatureId.SelectedValue.ToString()
                    );
            }

            //}
            return strWhereCond;
        }

        public string CombinePrjTabCondion4NoTimelyGeneCodeTabs(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " ('20' + UpdDate>GeneCodeDate or GeneCodeDate is null or IsNeedGene='1') ";
            strWhereCond += string.Format(" And {0}='{1}'", conPrjTab.PrjId, clsPubVar.CurrSelPrjId);
            int intApplicationTypeId = getAppTypeId();
            if (intApplicationTypeId == (int)enumApplicationType.PubClass_23)
            {
                strWhereCond += string.Format(" And {0}='{1}'", conPrjTab.TabTypeId, enumTabTypeWA.PureClass_0008);
            }
            else
            {
                strWhereCond += string.Format(" And {0}<>'{1}'", conPrjTab.TabTypeId, enumTabTypeWA.PureClass_0008);
            }
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithTabName == true)
            {
                if (this.txtTabName.Text.Trim() != "")
                {
                    strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim() + "%'";
                }

                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                }
                if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.TabStateId='" + this.cboTabStateId.SelectedValue + "'";
                }
            }
            else
            {
                if (this.txtTabName.Text.Trim() != "")
                {
                    strWhereCond += " And TabName like '%" + this.txtTabName.Text.Trim() + "%'";
                }

                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                }
                if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabStateId='" + this.cboTabStateId.SelectedValue + "'";
                }
            }
            return strWhereCond;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombinePrjTabCondionBak20200301(string strTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 And {0}='{1}'", conPrjTab.PrjId, clsPubVar.CurrSelPrjId);
            int intApplicationTypeId = getAppTypeId();
            if (intApplicationTypeId == (int)enumApplicationType.PubClass_23)
            {
                strWhereCond += string.Format(" And {0}='{1}'", conPrjTab.TabTypeId, enumTabTypeWA.PureClass_0008);
            }
            else
            {
                strWhereCond += string.Format(" And {0}<>'{1}'", conPrjTab.TabTypeId, enumTabTypeWA.PureClass_0008);
            }
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabName.Text.Trim() != "")
            {
                strWhereCond += " And " + strTabName + ".TabName like '%" + this.txtTabName.Text.Trim() + "%'";
            }

            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            }
            if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".TabStateId='" + this.cboTabStateId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        /// <summary>
        /// 函数功能：用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvPrjTab.SelectedItems.Count >= 1)
            {
                this.btnDelRec.Enabled = true;
            }
            else
            {
                this.btnDelRec.Enabled = false;
            }
        }


        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vPrjTab(bool bolIsDispTabs4TimelyGene)
        {
            if (cboCmPrjId.SelectedIndex == 0)
            {
                MessageBox.Show("请选择CM工程！");
                cboCmPrjId.Focus();
                return;
            }
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivPrjTab;
            
            List<clsvPrjTabENEx> arrvPrjTabExObjList;
            int intAppTypeId = getAppTypeId();
            string strCondtion2 = string.Format("{0}='{1}' and {2}={3} and {4}='{5}'",
                conLog4GeneTabCode.UserId, clsSysParaEN.strUserId,
                conLog4GeneTabCode.ApplicationTypeId, intAppTypeId, conLog4GeneTabCode.PrjId, clsPubVar.CurrSelPrjId);
            List<clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLst = clsLog4GeneTabCodeWApi.GetObjLst(strCondtion2);
            string strCmPrjId = "";
            if (cboCmPrjId.SelectedIndex > 0)
            {
                strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            }

            //	1、组合界面条件串；
            string strWhereCond = "";
            if (bolIsDispTabs4TimelyGene == true)
            {
                strWhereCond = this.CombinePrjTabCondion4NoTimelyGeneCodeTabs(false);
                strWhereCond += "[Exclude]or [/Exclude]";
            }
            else
            {
                strWhereCond = this.CombinePrjTabCondion();	//  CombinePrjTabCondion();
                //strWhereCond += "[Exclude]or [/Exclude]";
            }
            //	2、根据条件串获取该表满足条件的DataTable；
            try
            {

                List<clsvPrjTabEN> arrvPrjTabObjList = clsvPrjTabWApi.GetObjLst(strWhereCond);
                arrvPrjTabExObjList = arrvPrjTabObjList.Select(clsvPrjTabExWApi.CopyToEx).ToList();
                if (cboIsAppliedViewList.SelectedIndex > 0)
                {
                    foreach (clsvPrjTabENEx objvPrjTabENEx in arrvPrjTabExObjList)
                    {
                        bool bolIsAppliedInViewList = clsPrjTabExWApi.IsAppiedInViewList4CmPrjId(objvPrjTabENEx.TabId, CmPrjId);                                                                      
                        objvPrjTabENEx.IsAppliedInViewList = bolIsAppliedInViewList;
                    }
                    arrvPrjTabExObjList = arrvPrjTabExObjList.Where(x => x.IsAppliedInViewList == IsAppliedViewList).ToList();
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            //	3、设置ListView的列头信息
            this.lvvPrjTab.Items.Clear();//清除原来所有Item
            this.lvvPrjTab.Columns.Clear();//清除原来所有列头信息
            //this.lvvPrjTab.Columns.Add("表ID", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("表名", 330, HorizontalAlignment.Left);
            //this.lvvPrjTab.Columns.Add("表中文名", 120, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("功能模块", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("共享", 100, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("字段数", 60, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("修改日期", 110, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("生成日期", 110, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("生成?", 50, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("版本", 100, HorizontalAlignment.Left);

            //this.lvvPrjTab.Columns.Add("错误信息", 100, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("关键字段(类型)", 200, HorizontalAlignment.Left);
            //this.lvvPrjTab.Columns.Add("表状态", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("缓存?", 90, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("缓存字段1", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("Sql数据源名", 100, HorizontalAlignment.Left);

            //this.lvvPrjTab.Columns.Add("对象", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.View = View.Details;
            this.lvvPrjTab.BeginUpdate();
            var arrTabId = arrvPrjTabExObjList.Select(x => x.TabId).ToList();
            if (this.arrTabId_Lst == null || clsAggregate.TwoAggrDiff(arrTabId, this.arrTabId_Lst).Count != 0)
            {
                if (this.arrTabId_Lst == null) this.arrTabId_Lst = new List<string>();
                clsAggregate.UniteTwoAggr(ref this.arrTabId_Lst, arrTabId);
                this.arrPrjTabFld4ShowLst = clsPrjTabFldExWApi.GetObjLstByTabIdLst(this.arrTabId_Lst);
            }
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvPrjTabEN objvPrjTabEN in arrvPrjTabExObjList)
            {
               
                lvivPrjTab = new ListViewItem();
                lvivPrjTab.Tag = objvPrjTabEN.TabId;
                lvivPrjTab.Text = objvPrjTabEN.TabName;
                lvivPrjTab.Text = string.Format("{0}({1})", objvPrjTabEN.TabName, objvPrjTabEN.TabCnName);

                //lvivPrjTab.SubItems.Add(objvPrjTabEN.TabName);
                //lvivPrjTab.SubItems.Add(objvPrjTabEN.TabCnName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.FuncModuleName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.IsShare ? "是" : "否");

                if (objvPrjTabEN.IsShare == true)
                {
                    lvivPrjTab.ForeColor = Color.Green;
                    lvivPrjTab.Font = new Font(lvivPrjTab.Font, FontStyle.Bold);

                }

                lvivPrjTab.SubItems.Add(objvPrjTabEN.FldNum.ToString());
                lvivPrjTab.SubItems.Add(objvPrjTabEN.UpdDate);

                clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = arrLog4GeneTabCodeObjLst.Find(x => x.TabId == objvPrjTabEN.TabId && x.GcPathId == this.GCMainPathId);
                if (objLog4GeneTabCodeEN != null)
                {

                    lvivPrjTab.SubItems.Add(GetShortDate(objLog4GeneTabCodeEN.GeneCodeDate));
                    if (objvPrjTabEN.UpdDate.CompareTo(GetShortDate(objLog4GeneTabCodeEN.GeneCodeDate)) > 0)
                    {
                        lvivPrjTab.SubItems.Add("需要");
                    }
                    else
                    {
                        lvivPrjTab.SubItems.Add("不");
                    }
                    lvivPrjTab.SubItems.Add(GetShortDate(objLog4GeneTabCodeEN.VersionGeneCode));
                }
                else
                {


                    lvivPrjTab.SubItems.Add("");
                    lvivPrjTab.SubItems.Add("需要");

                    lvivPrjTab.SubItems.Add("");
                }
                lvivPrjTab.SubItems.Add(objvPrjTabEN.KeyFldName_Types(this.arrPrjTabFld4ShowLst));

                //lvivPrjTab.SubItems.Add(objvPrjTabEN.TabStateName);
                string strCache = "";
                string strCacheFldName = "";
                if (objvPrjTabEN.IsUseCache == true)
                {
                    strCache = "使用";
                    if (string.IsNullOrEmpty(objvPrjTabEN.CacheClassifyField) == false)
                    {
                        clsvFieldTab_SimEN objFieldTab = clsvFieldTab_SimWApi.GetObjByFldIdCache(objvPrjTabEN.CacheClassifyField, clsPubVar.CurrSelPrjId);
                        if (objFieldTab != null)
                        {
                            //strCache = objFieldTab.FldName;
                            strCacheFldName = objFieldTab.FldName;
                        }
                    }
                }
                else
                {
                    strCache = "不使用";
                }
                lvivPrjTab.SubItems.Add(strCache);
                lvivPrjTab.SubItems.Add(strCacheFldName);

                lvivPrjTab.SubItems.Add(objvPrjTabEN.SqlDsTypeName);

                this.lvvPrjTab.Items.Add(lvivPrjTab);
            }
            this.lvvPrjTab.EndUpdate();

            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvPrjTabExObjList.Count.ToString();
        }
        private string GetShortDate(string strDate)
        {
            if (strDate.Length > 3 && strDate.Length < 15)
                return strDate.Substring(2);
            else if (strDate.Length > 15)
                return strDate.Substring(2, 14);
            else return strDate;
        }


        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vPrjTab_WithErrMsg()
        {
            if (bolIsInPageLoad == true && bolIsBindData == true) return;

            if (cboCmPrjId.SelectedIndex == 0)
            {
                MessageBox.Show("请选择CM工程！");
                cboCmPrjId.Focus();
                return;
            }
            bolIsBindData = true;
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。
            int intAppTypeId = getAppTypeId();
            string strCondtion2 = string.Format("{0}='{1}' and {2}={3} and {4}='{5}'",
                conLog4GeneTabCode.UserId, clsSysParaEN.strUserId,
                conLog4GeneTabCode.ApplicationTypeId, intAppTypeId, conLog4GeneTabCode.PrjId, clsPubVar.CurrSelPrjId);
            List<clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLst = clsLog4GeneTabCodeWApi.GetObjLst(strCondtion2);
            List<clsvTabCheckStatus_SimEN> arrTabCheckStatus = clsvTabCheckStatus_SimWApi.GetObjLstCache(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId);
            arrTabCheckStatus = arrTabCheckStatus.Where(x => x.PrjDataBaseId == clsPubVar.CurrPrjDataBaseId).ToList();
            ListViewItem lvivPrjTab;
       
            List<clsvPrjTabENEx> arrvPrjTabExObjList;

            //	1、组合界面条件串；
            string strWhereCond = this.CombinePrjTabCondion();	//  CombinePrjTabCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            //strWhereCond += "[Exclude]or [/Exclude]";
            try
            {
                List<clsvPrjTabEN> arrvPrjTabObjList = clsvPrjTabWApi.GetObjLst(strWhereCond);
                arrvPrjTabExObjList = arrvPrjTabObjList.Select(clsvPrjTabExWApi.CopyToEx).ToList();
                if (cboIsAppliedViewList.SelectedIndex > 0)
                {
                    foreach (clsvPrjTabENEx objvPrjTabENEx in arrvPrjTabExObjList)
                    {
                        bool bolIsAppliedInViewList = clsPrjTabExWApi.IsAppiedInViewList4CmPrjId(objvPrjTabENEx.TabId, CmPrjId);
                        objvPrjTabENEx.IsAppliedInViewList = bolIsAppliedInViewList;
                    }
                    arrvPrjTabExObjList = arrvPrjTabExObjList.Where(x => x.IsAppliedInViewList == IsAppliedViewList).ToList();
                }
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            //	3、设置ListView的列头信息
            this.lvvPrjTab.Items.Clear();//清除原来所有Item
            this.lvvPrjTab.Columns.Clear();//清除原来所有列头信息
            this.lvvPrjTab.Columns.Add("表名", 330, HorizontalAlignment.Left);
            //this.lvvPrjTab.Columns.Add("表中文名", 120, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("功能模块", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("共享", 50, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("字段数", 60, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("修改日期", 110, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("生成日期", 110, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("生成?", 50, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("版本", 90, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("关键字段(类型)", 200, HorizontalAlignment.Left);
            //this.lvvPrjTab.Columns.Add("表状态", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("缓存?", 90, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("缓存字段1", 100, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("错误", 200, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("Sql数据源名", 100, HorizontalAlignment.Left);

            //this.lvvPrjTab.Columns.Add("对象", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.View = View.Details;
            this.lvvPrjTab.BeginUpdate();
            var arrTabId = arrvPrjTabExObjList.Select(x => x.TabId).ToList();
            if (this.arrTabId_Lst == null || clsAggregate.TwoAggrDiff(arrTabId, this.arrTabId_Lst).Count != 0)
            {
                if (this.arrTabId_Lst == null) this.arrTabId_Lst = new List<string>();
                clsAggregate.UniteTwoAggr(ref this.arrTabId_Lst, arrTabId);
                this.arrPrjTabFld4ShowLst = clsPrjTabFldExWApi.GetObjLstByTabIdLst(this.arrTabId_Lst);
            }
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvPrjTabEN objvPrjTabEN in arrvPrjTabExObjList)
            {
              
                    lvivPrjTab = new ListViewItem();
                lvivPrjTab.Tag = objvPrjTabEN.TabId;
                lvivPrjTab.Text = string.Format("{0}({1})", objvPrjTabEN.TabName, objvPrjTabEN.TabCnName);
                //lvivPrjTab.SubItems.Add(objvPrjTabEN.TabName);
                //lvivPrjTab.SubItems.Add(objvPrjTabEN.TabCnName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.FuncModuleName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.IsShare ? "是" : "否");
                if (objvPrjTabEN.IsShare == true)
                {
                    lvivPrjTab.ForeColor = Color.Green;

                    lvivPrjTab.Font = new Font(lvivPrjTab.Font, FontStyle.Bold);

                }
                lvivPrjTab.SubItems.Add(objvPrjTabEN.FldNum.ToString());
                lvivPrjTab.SubItems.Add(objvPrjTabEN.UpdDate);
                clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = arrLog4GeneTabCodeObjLst.Find(x => x.TabId == objvPrjTabEN.TabId && x.GcPathId == this.GCMainPathId);
                if (objLog4GeneTabCodeEN != null)
                {
                    lvivPrjTab.SubItems.Add(GetShortDate(objLog4GeneTabCodeEN.GeneCodeDate));
                    if (objvPrjTabEN.UpdDate.CompareTo(GetShortDate(objLog4GeneTabCodeEN.GeneCodeDate)) > 0)
                    {
                        lvivPrjTab.SubItems.Add("需要");
                    }
                    else
                    {
                        lvivPrjTab.SubItems.Add("不");
                    }
                    lvivPrjTab.SubItems.Add(GetShortDate(objLog4GeneTabCodeEN.VersionGeneCode));
                }
                else
                {
                    lvivPrjTab.SubItems.Add("");
                    lvivPrjTab.SubItems.Add("需要");

                    lvivPrjTab.SubItems.Add("");
                }
                //lvivPrjTab.SubItems.Add(objvPrjTabEN.ErrMsg);
                try
                {
                    string strKeyFldName_Types = objvPrjTabEN.KeyFldName_Types(this.arrPrjTabFld4ShowLst);

                    lvivPrjTab.SubItems.Add(strKeyFldName_Types);
                }
                catch (Exception objEx)
                {
                    MessageBox.Show(objEx.Message);
                    return;
                }
                //lvivPrjTab.SubItems.Add(objvPrjTabEN.TabStateName);
                //lvivPrjTab.SubItems.Add(objvPrjTabEN.ObjName);
                string strCache = "";
                string strCacheFldName = "";
                if (objvPrjTabEN.IsUseCache == true)
                {
                    strCache = "使用";
                    if (string.IsNullOrEmpty(objvPrjTabEN.CacheClassifyField) == false)
                    {
                        clsvFieldTab_SimEN objFieldTab = clsvFieldTab_SimWApi.GetObjByFldIdCache(objvPrjTabEN.CacheClassifyField, objvPrjTabEN.PrjId);
                        if (objFieldTab != null)
                        {
                            strCache = objFieldTab.FldName;
                            strCacheFldName = objFieldTab.FldName;
                        }
                    }
                    if (string.IsNullOrEmpty(objvPrjTabEN.CacheModeId) == false)
                    {
                        if (objvPrjTabEN.CacheModeId != "05")
                        {
                            var objCacheMode = clsCacheModeWApi.GetObjByCacheModeIdCache(objvPrjTabEN.CacheModeId);
                            strCache = string.Format("{0}({1})", objCacheMode.CacheModeName, strCache);
                        }
                    }

                }
                else
                {
                    strCache = "不使用";
                }
                lvivPrjTab.SubItems.Add(strCache);
                lvivPrjTab.SubItems.Add(strCacheFldName);

                var objTabCheckStatus = arrTabCheckStatus.Find(x => x.TabId == objvPrjTabEN.TabId);
                if (objTabCheckStatus == null)
                {
                    lvivPrjTab.SubItems.Add("无");
                }
                else
                {
                    if (objTabCheckStatus.ErrorLevelId <= 0)
                    {
                        lvivPrjTab.SubItems.Add("无");
                    }
                    else
                    {
                        var objErrorLevel = clsErrorLevelWApi.GetObjByErrorLevelIdCache(objTabCheckStatus.ErrorLevelId);
                        string strTemp = string.Format("{0}:{1}", objErrorLevel.ErrorLevelName, objTabCheckStatus.ErrorMsg);
                        lvivPrjTab.SubItems.Add(strTemp);
                    }
                }
                lvivPrjTab.SubItems.Add(objvPrjTabEN.SqlDsTypeName);

                this.lvvPrjTab.Items.Add(lvivPrjTab);
            }
            this.lvvPrjTab.EndUpdate();

            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvPrjTabExObjList.Count.ToString();
        }

        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            if (chkDispAllErrMsg.Checked == true)
            {
                BindLv_vPrjTab_WithErrMsg();
            }
            else
            {
                BindLv_vPrjTab(false);
            }
            tabControl1.SelectedIndex = 0;
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strTabId = objDTPrjTab.Rows[intCurrRow]["TabId"].ToString();
            return strTabId;
        }
        /// <summary>
        /// 获取ListView中当前行的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(ListView objListView)
        {
            if (objListView.SelectedItems.Count == 0)
            {
                return "";
            }
            ListViewItem lviPrjTab;
            lviPrjTab = objListView.SelectedItems[0];
            string strPrjTabId = lviPrjTab.Tag.ToString();
            return strPrjTabId;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(ListViewItem objListViewItem)
        {
            string strPrjTabId = objListViewItem.Tag.ToString();
            return strPrjTabId;
        }
        private void lvvPrjTab_Click(object sender, System.EventArgs e)
        {
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用

        }


        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeletePrjTabRecord();
        }
        private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            ExportExcel_SelColumns();	//新的导出EXCEL方式，用户可以选择导出字段列
            //ExportExcel();	//原来的方式导出EXCEL，用户不能选择导出字段列
        }
        /// <summary>
        /// 导出EXCEL的函数
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombinePrjTabCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            List<clsPrjTabEN> arrObjLst = clsPrjTabWApi.GetObjLst(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "PrjTab信息导出.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("TabId"); arrCnName.Add("表ID");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("FuncModuleAgcId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("ObjId"); arrCnName.Add("所属对象");
            arrColName.Add("ObjName"); arrCnName.Add("对象名称");
            arrColName.Add("TabStateId"); arrCnName.Add("表状态ID");
            arrColName.Add("TabStateName"); arrCnName.Add("表状态名称");
            arrColName.Add("FldNum"); arrCnName.Add("FldNum");
            arrColName.Add("KeyFldName"); arrCnName.Add("KeyFldName");
            arrColName.Add("PrimaryTypeId"); arrCnName.Add("主键类型ID");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("PrimaryTypeName");
            arrColName.Add("SqlDsTypeId"); arrCnName.Add("数据源类型");
            arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql数据源名");
            arrColName.Add("ErrMsg"); arrCnName.Add("错误信息");
            arrColName.Add("IsTabPrimary"); arrCnName.Add("是否作为表中主键");
            arrColName.Add("Owner"); arrCnName.Add("拥有者");
            arrColName.Add("RelaViewId"); arrCnName.Add("相关视图ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
            arrColName.Add("IsArchive"); arrCnName.Add("是否存档");
            arrColName.Add("IsChecked"); arrCnName.Add("是否核实");
            arrColName.Add("TabNameB"); arrCnName.Add("表名_后备");
            arrColName.Add("IsNationStandard"); arrCnName.Add("是否国标");
            arrColName.Add("IsParaTab"); arrCnName.Add("是否参数表");
            arrColName.Add("IsNeedTransCode"); arrCnName.Add("是否需要转换代码");
            arrColName.Add("FldID"); arrCnName.Add("字段ID");
            arrColName.Add("FuncModuleEnName"); arrCnName.Add("功能模块英文名称");
            arrColName.Add("DataBaseName"); arrCnName.Add("数据库名");
            arrColName.Add("DatabaseOwner"); arrCnName.Add("数据库拥有者");
            arrColName.Add("DataBaseUserId"); arrCnName.Add("数据库的用户ID");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            //strFolderName = Application.StartupPath + "\\TempFiles";
            //if (Directory.Exists(strFolderName) == false)
            //{
            //Directory.CreateDirectory(strFolderName);
            //}
            //strDownLoadFileName = strFolderName + "\\" + strFileName;
            System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();
            objSaveFileDialog.DefaultExt = "xls";
            objSaveFileDialog.Filter = "Excle文件(*.xls)|*.xls|所有文件(*.*)|*.*";
            objSaveFileDialog.ShowDialog();
            strDownLoadFileName = objSaveFileDialog.FileName;
            if (strDownLoadFileName == "")
            {
                return;
            }
            GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();
            //objExcel.GetExcelFromDataTableByArrAndArray(arrObjLst, arrColName, arrCnName, strDownLoadFileName);
            MessageBox.Show("导出Excel成功!，文件存放在：" + strDownLoadFileName);
        }
        /// <summary>
        /// 导出EXCEL的函数, 导出EXCEL时可以选择列
        /// </summary>
        private void ExportExcel_SelColumns()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombinePrjTabCondion();
            //	2、设置表列数据字段名，以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("TabId"); arrCnName.Add("表ID");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("FuncModuleAgcId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("ObjId"); arrCnName.Add("所属对象");
            arrColName.Add("ObjName"); arrCnName.Add("对象名称");
            arrColName.Add("TabStateId"); arrCnName.Add("表状态ID");
            arrColName.Add("TabStateName"); arrCnName.Add("表状态名称");
            arrColName.Add("FldNum"); arrCnName.Add("FldNum");
            arrColName.Add("KeyFldName"); arrCnName.Add("KeyFldName");
            arrColName.Add("PrimaryTypeId"); arrCnName.Add("主键类型ID");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("PrimaryTypeName");
            arrColName.Add("SqlDsTypeId"); arrCnName.Add("数据源类型");
            arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql数据源名");
            arrColName.Add("ErrMsg"); arrCnName.Add("错误信息");
            arrColName.Add("IsTabPrimary"); arrCnName.Add("是否作为表中主键");
            arrColName.Add("Owner"); arrCnName.Add("拥有者");
            arrColName.Add("RelaViewId"); arrCnName.Add("相关视图ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
            arrColName.Add("IsArchive"); arrCnName.Add("是否存档");
            arrColName.Add("IsChecked"); arrCnName.Add("是否核实");
            arrColName.Add("TabNameB"); arrCnName.Add("表名_后备");
            arrColName.Add("IsNationStandard"); arrCnName.Add("是否国标");
            arrColName.Add("IsParaTab"); arrCnName.Add("是否参数表");
            arrColName.Add("IsNeedTransCode"); arrCnName.Add("是否需要转换代码");
            arrColName.Add("FldID"); arrCnName.Add("字段ID");
            arrColName.Add("FuncModuleEnName"); arrCnName.Add("功能模块英文名称");
            arrColName.Add("DataBaseName"); arrCnName.Add("数据库名");
            arrColName.Add("DatabaseOwner"); arrCnName.Add("数据库拥有者");
            arrColName.Add("DataBaseUserId"); arrCnName.Add("数据库的用户ID");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            ArrayList arrExportExcelList = new ArrayList();
            clsExportField objExportField = null;
            int intColNum = arrColName.Count;
            for (int i = 0; i < intColNum; i++)
            {
                objExportField = new clsExportField();
                objExportField.FieldEnglishName = arrColName[i].ToString();
                objExportField.FieldChineseName = arrCnName[i].ToString();
                arrExportExcelList.Add(objExportField);
            }
            /// 3、调用公用的导出EXCEL的界面，选择列后再导出
            frmExportExcel frm1 = new frmExportExcel();
            frm1.arrExportExcelList = arrExportExcelList;
            frm1.strTableName = "vPrjTab";
            frm1.strTableChineseName = "vPrjTab";
            frm1.strViewName = "工程表维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvPrjTab_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvPrjTabSorter.SortColumn)
            {

            }
            else
            {
                this.objvPrjTabSorter.SortColumn = e.Column;
            }

            if (this.objvPrjTabSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvPrjTabSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvPrjTabColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvPrjTabColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text = this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvPrjTabColumIndex = e.Column;
                }
            }
            else if (this.objvPrjTabSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvPrjTabSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvPrjTabColumIndex == e.Column)
                {
                    this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvPrjTabColumIndex = e.Column;
                }
                else
                {
                    this.lvvPrjTab.Columns[e.Column].Text = this.lvvPrjTab.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text = this.lvvPrjTab.Columns[intLastSelectedvPrjTabColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvPrjTabColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvPrjTab.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vPrjTab(false);
        }

        ///删除记录过程代码for C#
        private void DeletePrjTabRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
                {
                    string strTabId = GetCurrKey(lvi);
                    if (clsPrjTabWApi.DelRecord(strTabId) == 0)
                    {
                        MessageBox.Show("删除记录失败！");
                        BindLv_vPrjTab(false);
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vPrjTab(false);
            }
        }


        private void txtFileName4GenCode_Click(object sender, EventArgs e)
        {
            txtFileName4GenCode.SelectAll();
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            txtCode.SelectAll();
        }

        private void btnAllTableThreeLayer_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            //string strFileName = "";
            List<string> arrTabIdLst = clsPrjTabWApi.GetFldValue("TabId", string.Format("PrjId='{0}' And TabStateId='01'", clsPubVar.CurrSelPrjId));

            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "当前工程中没有记录，请选择一个有效的工程!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);


            int intCount0 = 0;
            List<string> arrErrorLst = new List<string>();
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    //string strClsName = "";
                    //string strCodePath = "";
                    //clsUserCodePathEN objUserCodePathEN = null;
                    //string strCodeText = "";
                    //string strCodeText_Sim = "";

                    //if (rbMsSql.Checked == true)
                    //{
                    //    //生成新版-实体层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0001", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneEntityLayer(strTabId,
                    //       clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                    //       clsSysParaEN.strUserName,
                    //       objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //   strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);

                    //    // 生成新版-数据处理层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0002", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                    //    //生成新版-业务逻辑层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0003", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //         objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}
                    //else if (rbOracle.Checked == true)
                    //{
                    //    //生成新版-实体层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0001", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneEntityLayer(strTabId,
                    //       clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                    //       clsSysParaEN.strUserName,
                    //       objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //   strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);

                    //    // 生成新版-数据处理层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0002", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                    //    //生成新版-业务逻辑层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0003", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //         objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}
                    //else if (rbMySql.Checked == true)
                    //{
                    //    //生成新版-实体层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0001", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneEntityLayer(strTabId,
                    //       clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                    //       clsSysParaEN.strUserName,
                    //       objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);

                    //    // 生成新版-数据处理层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0002", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //          objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                    //    //生成新版-业务逻辑层
                    //    objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0003", "01", clsPubVar.CurrSelPrjId);
                    //    strCodeText = clsPrjTabExWApi.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //        clsSysParaEN.strUserId,
                    //         clsSysParaEN.strUserName,
                    //         objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //    strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    //}


                    //objUserCodePathEN = clsPubVar.GetObjByCodeTypeIdCache("0008");
                    //strCodeText = clsPrjTabExWApi.GeneClassExLayer(strTabId, clsPubVar.objCurrSelProjectEN,
                    //clsSysParaEN.strUserId,
                    // clsSysParaEN.strUserName,
                    // objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    // ref strClsName, ref strCodePath);
                    intCount0++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    //ErrorInformationWApi.AddInformation("wfmPrjTab_QUDI3.aspx", "lbAllTableThreeLayer_Click", objException.Message, clsSysParaEN.strUserId);
                    return;
                } //显示生成代码区域
            }
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成表完成！共计：{0}个表。\r\n", intCount0);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());
            BindLv_vPrjTab(false);


        }

        private void btnGeneAllCheckedTableThreeLayer_Click(object sender, EventArgs e)
        {
            string strMsg = string.Format("strCurrIPAddressAndPort={0}, strCurrPrx={1}.(In {2})",
          clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx, clsStackTrace.GetCurrClassFunction());
            clsPubVar.objLog.WriteDebugLog(strMsg);

            if (clsPubFun.CheckWebApi() == false)
            {
                strMsg = string.Format("当前用于生成代码的WebApi不可用，请到菜单：[系统设置->WebService设置]中重新设置WebApi地址！");
                MessageBox.Show(strMsg);
                return;
            }

            lblMsg.Text = "";
            List<string> arrTabIdLst = GetSelectedTabId();
            if (arrTabIdLst == null)
            {
                return;
            }
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            var strCmPrjId = cboCmPrjId.SelectedValue.ToString();

            if (string.IsNullOrEmpty(strCmPrjId) == true || strCmPrjId == "0")
            {
                MessageBox.Show("请选择一个CM工程！");
                cboCmPrjId.Focus();
                return;
            }

            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            objGeneCode_Local = new clsGeneCode_Local();
            Thread t1 = new Thread(new ParameterizedThreadStart(objGeneCode_Local.GeneAllCheckedTableThreeLayer));
            //Thread thread = new Thread(new ParameterizedThreadStart(message.ShowMessage));
            t1.IsBackground = true;
            string strTabMainTypeId = cboTabMainTypeId.SelectedValue.ToString();
            if (string.IsNullOrEmpty(strTabMainTypeId) == true)
            {
                lblMsg.Text = "请选择一个表主类型!";
                cboTabMainTypeId.Focus();
                MessageBox.Show(lblMsg.Text);
                return;
            }
            GeneCodeParameters myGeneCodeParameters = new GeneCodeParameters();
            myGeneCodeParameters.arrTabIdLst = arrTabIdLst;
            myGeneCodeParameters.strTabMainTypeId = strTabMainTypeId;
            myGeneCodeParameters.strCharEncodingId = strCharEncodingId;
            myGeneCodeParameters.bolIsIgnoreCommTable = chkIgnoreCommTable.Checked;
            myGeneCodeParameters.strTypeParas = typeParas;
            myGeneCodeParameters.mltLangType = mltLangType;
            myGeneCodeParameters.ApplicationTypeId = getAppTypeId();
            myGeneCodeParameters.mdbtDataBaseType = mdbtDataBaseType;
            myGeneCodeParameters.strCmPrjId = strCmPrjId;
            t1.Start(myGeneCodeParameters);
            strTimerMode = "PrjTab";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrTabIdLst.Count;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = arrTabIdLst.Count;

            timer1.Enabled = true;
            timer1.Start();
            //}
            //catch(Exception objException)
            //{
            //    MessageBox.Show(objException.Message);
            //}

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (strTimerMode == "IncludeTab")
            {
                progressBar1.Value = objGeneCode_Local.intCurrIndex;
                try
                {
                    progressBar2.Value = objGeneCode_Local.mintErrorNum;
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                }
                lblStatus.Text = string.Format("总表数:{0}，当前生成数:{1}, 占:{2}%",
                    objGeneCode_Local.intAllTabCount, objGeneCode_Local.intCurrIndex,
                    objGeneCode_Local.intCurrIndex * 1.0 / objGeneCode_Local.intAllTabCount * 100);
                lblErrNum.Text = string.Format("出错次数:{0}", objGeneCode_Local.arrErrorLst.Count);

                if (objGeneCode_Local.bolIsFinished == true)
                {
                    timer1.Enabled = false;


                    txtCodePath.Text = objGeneCode_Local.ClassFName;
                    //if (string.IsNullOrEmpty(objGeneCode_Local.strCodeText) == false)
                    //{
                    //    tabControl1.SelectedIndex = 1;
                    //}
                    if (objGeneCode_Local.intSuccessCount == objGeneCode_Local.intAllTabCount)
                    {
                        lblStatus.Text = string.Format("生成成功!");
                    }
                    else
                    {
                        lblStatus.Text = string.Format("生成部分成功!共生成：{0}文件.\r\n日志文件:[{1}].",
                            objGeneCode_Local.intSuccessCount, objGeneCode_Local.mstrLogFName);
                    }
                    StringBuilder sbMsg = new StringBuilder();
                    StringBuilder sbErrMsg = new StringBuilder();

                    sbMsg.AppendLine(string.Format("生成表完成！\r\n共生成：{0}个文件:", objGeneCode_Local.intGc_FileCount));
                    sbErrMsg.AppendLine(string.Format("生成表完成！\r\n共生成：{0}个文件:", objGeneCode_Local.intGc_FileCount));

                    if (objGeneCode_Local.arrAddFileName != null)
                    {
                        objGeneCode_Local.arrAddFileName.ForEach(x => { sbMsg.AppendLine(x); });
                    }

                    sbMsg.AppendLine(string.Format("共删除:{0}个文件:", objGeneCode_Local.intDeleteCount));
                    sbErrMsg.AppendLine(string.Format("共删除:{0}个文件:", objGeneCode_Local.intDeleteCount));

                    if (objGeneCode_Local.arrDeleteFileName != null)
                    {
                        objGeneCode_Local.arrDeleteFileName.ForEach(x => { sbMsg.AppendLine(x); });
                    }
                    sbMsg.AppendLine(string.Format("不需要生成:{0}个文件:", objGeneCode_Local.intNotNeedGC));
                    sbErrMsg.AppendLine(string.Format("不需要生成:{0}个文件:", objGeneCode_Local.intNotNeedGC));

                    if (objGeneCode_Local.arrNotNeedGC != null)
                    {
                        objGeneCode_Local.arrNotNeedGC.ForEach(x => { sbMsg.AppendLine(x); });
                    }

                    sbMsg.AppendLine(string.Format("警告日志信息:{0}条:", objGeneCode_Local.arrWarnningLst.Count));

                    if (objGeneCode_Local.arrWarnningLst != null)
                    {
                        objGeneCode_Local.arrWarnningLst.ForEach(x => { sbMsg.AppendLine("\r\n" + x); });
                    }


                    sbMsg.AppendLine(string.Format("错误信息:{0}条:", objGeneCode_Local.arrErrorLst.Count));
                    sbErrMsg.AppendLine(string.Format("错误信息:{0}条:", objGeneCode_Local.arrErrorLst.Count));

                    if (objGeneCode_Local.arrErrorLst != null)
                    {
                        objGeneCode_Local.arrErrorLst.ForEach(x => { sbMsg.AppendLine(x); });
                        objGeneCode_Local.arrErrorLst.ForEach(x => { sbErrMsg.AppendLine(x); });
                    }
                    sbMsg.AppendLine(string.Format("日志文件：{0};", objGeneCode_Local.mstrLogFName));
                    sbErrMsg.AppendLine(string.Format("日志文件：{0};", objGeneCode_Local.mstrLogFName));

                    sbMsg.AppendLine(string.Format("并且Build：{0}.", objGeneCode_Local.bolIsSuccessBuild ? "成功" : "不成功"));


                    sbErrMsg.AppendLine(string.Format("并且Build：{0}.", objGeneCode_Local.bolIsSuccessBuild ? "成功" : "不成功"));
                    BindLv_vPrjTab(false);
                    txtCode.Text = sbMsg.ToString();
                    tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
                    //if (objGeneCode_Local.intSuccessCount != 1)
                    //{
                    MessageBox.Show(sbErrMsg.ToString());
                    //}
                }
                else
                {
                    //lblStatus.Text = "传输过程中...";
                }

            }
            else
            {


                progressBar1.Value = objGeneCode_Local.intCurrIndex;
                try
                {
                    progressBar2.Value = objGeneCode_Local.mintErrorNum;
                }
                catch (Exception objException)
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                }
                lblStatus.Text = string.Format("总表数:{0}，当前生成数:{1}, 占:{2}%",
                    objGeneCode_Local.intAllTabCount, objGeneCode_Local.intCurrIndex,
                    objGeneCode_Local.intCurrIndex * 1.0 / objGeneCode_Local.intAllTabCount * 100);
                lblErrNum.Text = string.Format("出错次数:{0}", objGeneCode_Local.arrErrorLst.Count);

                if (objGeneCode_Local.bolIsFinished == true)
                {
                    timer1.Enabled = false;


                    txtCodePath.Text = objGeneCode_Local.ClassFName;
                    //if (string.IsNullOrEmpty(objGeneCode_Local.strCodeText) == false)
                    //{
                    //    tabControl1.SelectedIndex = 1;
                    //}
                    if (objGeneCode_Local.intSuccessCount == objGeneCode_Local.intAllTabCount)
                    {
                        lblStatus.Text = string.Format("生成成功!");
                    }
                    else
                    {
                        lblStatus.Text = string.Format("生成部分成功!共生成：{0}文件.\r\n日志文件:[{1}].",
                            objGeneCode_Local.intSuccessCount, objGeneCode_Local.mstrLogFName);
                    }
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("生成表完成！共生成：{0}个表。\r\n日志文件:[{1}].",
                        objGeneCode_Local.intSuccessCount, objGeneCode_Local.mstrLogFName);

                    sbMsg.AppendFormat(string.Format("\r\n \r\n错误信息:{0}条:", objGeneCode_Local.arrErrorLst.Count));

                    foreach (string strMsg in objGeneCode_Local.arrErrorLst)
                    {
                        sbMsg.AppendFormat("\r\n\r\n{0}", strMsg);
                    }
                    sbMsg.AppendFormat(string.Format("\r\n \r\n警告信息:{0}条:", objGeneCode_Local.arrWarnningLst.Count));

                    if (objGeneCode_Local.arrWarnningLst != null)
                    {
                        objGeneCode_Local.arrWarnningLst.ForEach(x => { sbMsg.AppendLine("\r\n\r\n" + x); });
                    }

                    BindLv_vPrjTab(false);
                    //if (objGeneCode_Local.intSuccessCount != 1)
                    //{
                    MessageBox.Show(sbMsg.ToString());
                    //}
                }
                else
                {
                    //lblStatus.Text = "传输过程中...";
                }
            }
        }

        private void chkDispAllErrMsg_CheckedChanged(object sender, EventArgs e)
        {
            //把表记录的内容显示在ListView中
            if (chkDispAllErrMsg.Checked == true)
            {
                BindLv_vPrjTab_WithErrMsg();
            }
            else
            {
                BindLv_vPrjTab(false);
            }
        }

        private void btnCheckAllTabField_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            int intCount = 0;

            try
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                intCount = clsProjectsExWApi.CheckAllTabField(clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsSysParaEN.strUserId);
                MessageBox.Show(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
                BindLv_vPrjTab(false);
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
                //ErrorInformationWApi.AddInformation("wfmPrjTab_QUDI3.aspx", "lbCheckAllTabField_Click", objException.Message, clsSysParaEN.strUserId);
            } //显示生成代码区域

        }

        private void btnCheckCheckedTabField_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            List<string> arrTabIdLst = GetSelectedTabId();
            if (arrTabIdLst == null)
            {
                return;
            }

            int intCount = 0;

            try
            {
                intCount = clsProjectsExWApi.CheckCheckedTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId, arrTabIdLst);
                MessageBox.Show(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
                //ErrorInformationWApi.AddInformation("wfmPrjTab_QUDI3.aspx", "lbCheckAllTabField_Click", objException.Message, clsSysParaEN.strUserId);
            } //显示生成代码区域


        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            //clsPubFun4WApi.ClearCache4GeneCode(clsPubVar.CurrSelPrjId);
            var bol1 = clsPubFun4WApi.ClearCache4GeneCode(clsPubVar.CurrSelPrjId);
            string strMsg = "";
            if (bol1 == true)
            {
                strMsg = string.Format("刷新WebApi后台数据成功！");
            }
            else
            {
                strMsg = string.Format("刷新WebApi后台数据不成功！");
            }
            MessageBox.Show(strMsg);
            ////clsFieldSet.arrFieldObjLst = null;
            ////clsFieldSet.arrFieldTabObjLst = null;
            //clsFieldTabExWApi.arrFieldTabENExObjLst4WinApp = null;
            //clsFieldTabExWApi.arrFieldTabENExObjLstOrderByFldId_Cache = null;
        }

        private void btnQueryNoTimelyGeneTabs_Click(object sender, EventArgs e)
        {
            BindLv_vPrjTab(true);
        }

        //private void rbDotNet_CheckedChanged(object sender, EventArgs e)
        //{
        //    GetLangTypeByRadioButton();
        //    DispClassNameButton();
        //}

        //private void rbJava_CheckedChanged(object sender, EventArgs e)
        //{
        //    GetLangTypeByRadioButton();
        //    DispClassNameButton();
        //}

        private void rbMsSql_CheckedChanged(object sender, EventArgs e)
        {
            GetDataBaseTypeByRadioButton();
        }

        //private void rbSwift_CheckedChanged(object sender, EventArgs e)
        //{
        //    GetLangTypeByRadioButton();
        //    DispClassNameButton();
        //}

        //private void rbJavaScript_CheckedChanged(object sender, EventArgs e)
        //{
        //    GetLangTypeByRadioButton();
        //    DispClassNameButton();
        //}

        //private void rbSilverLight_CheckedChanged(object sender, EventArgs e)
        //{
        //    GetLangTypeByRadioButton();
        //    DispClassNameButton();
        //}
        private void GetDataBaseTypeByRadioButton()
        {
            if (rbMsSql.Checked == true)
            {
                mdbtDataBaseType = clsPubConst.DataBaseType.MsSql;

            }
            else if (rbMySql.Checked == true)
            {
                mdbtDataBaseType = clsPubConst.DataBaseType.MySql;

            }
            else
            {
                mdbtDataBaseType = clsPubConst.DataBaseType.Oracle;

            }
        }
        //private void GetLangTypeByRadioButtonBak20180210()
        //{


        //    if (rbDotNet.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.CSharp;
        //    }
        //    else if (rbJava.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.JAVA;
        //    }
        //    else if (rbSwift.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.Swift;
        //    }
        //    else if (rbSilverLight.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.SilverLight;
        //    }
        //    else if (rbJavaScript.Checked == true)
        //    {
        //        mltLangType = clsPubConst.LangType.JavaScript;
        //    }

        //}

        private void GetLangTypeByRadioButton(string strProgLangTypeId)
        {
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeId(strProgLangTypeId);
            mltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
        }

        private void DispClassNameButton()
        {

            //List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeExWApi.GetCodeTypeObjLstByLangType4Back(mltLangType);
            //foreach (Control objControl in flpClassNameButtonList.Controls)
            //{
            //    objControl.Visible = false;
            //    string strTypeName = objControl.GetType().ToString();
            //    if (strTypeName.IndexOf("Button") > 0)
            //    {
            //        clsCodeTypeExWApi.IsCanVisible(arrCodeTypeObjList, objControl as Button);
            //    }
            //}
        }

        private void rbOracle_CheckedChanged(object sender, EventArgs e)
        {
            GetDataBaseTypeByRadioButton();
        }

        private void rbMySql_CheckedChanged(object sender, EventArgs e)
        {
            GetDataBaseTypeByRadioButton();
        }

        private void lvvPrjTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private List<string> GetSelectedTabId()
        {
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }
            if (arrTabIdLst.Count == 1)
            {
                mstrCurrTabId = arrTabIdLst[0];
            }
            if (arrTabIdLst.Count == 0)
            {
                if (string.IsNullOrEmpty(mstrCurrTabId) == false)
                {
                    arrTabIdLst.Add(mstrCurrTabId);
                }
                else
                {
                    lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                    MessageBox.Show(lblMsg.Text);
                    return null;
                }
            }
            return arrTabIdLst;
        }

        public string InsertSuffixPath(string strRe_FileNameWithModuleName, string strSuffixPath)
        {
            if (string.IsNullOrEmpty(strSuffixPath) == true) return strRe_FileNameWithModuleName;
            string[] strItems = strRe_FileNameWithModuleName.Split('\\');
            if (strItems.Length < 2)
            {
                string strMsg = string.Format("带模块文件信息：[{0}]经过折分，不能折成两部分，出错！({1})",
                    strRe_FileNameWithModuleName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strReturnValue = "";
            if (strSuffixPath.StartsWith("_"))
            {
                strReturnValue = string.Format("{0}{1}\\{2}", strItems[0], strSuffixPath, strItems[1]);
            }
            else
            {
                strReturnValue = string.Format("{0}\\{1}\\{2}", strItems[0], strSuffixPath, strItems[1]);
            }
            return strReturnValue;
        }
        private void rblProgLangTypeId_RadioItemSeleted(object sender, TzWinCtrlLib.TzRadioButtonList.SelectedEventArgs e)
        {
            //            MessageBox.Show(e.Value);
            string strCharEncodingId = clsPubFun.GetCharEncodingIdByLangTypeId(e.Value);
            cboCharEncodingId.SelectedValue = strCharEncodingId;
            GetLangTypeByRadioButton(e.Value);

            DispClassNameButton();
        }

        /// <summary>
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string typeParas
        {
            get
            {
                string strTypeParas = "";

                if (cboAppPageTypeId.SelectedIndex > 0)
                {
                    string strAppPageTypeId = cboAppPageTypeId.SelectedValue.ToString();
                    clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeWApi.GetObjByAppPageTypeIdCache(strAppPageTypeId);
                    strTypeParas = strTypeParas + string.Format("{0}|",
                        objAppPageTypeEN.AppPageTypeENName);
                    return strTypeParas;
                }
                return strTypeParas;
            }
        }

        public string GCMainPathId
        {
            get
            {
                if (string.IsNullOrEmpty(this.mstrGCMainPathId) == true)
                {
                    GetGCMainPathId();
                    return this.mstrGCMainPathId;
                }
                else return this.mstrGCMainPathId;
            }
            set => this.mstrGCMainPathId = value;
        }

        private FlowLayoutPanel getflowLayoutPanel()
        {
            TabPage objTabPage = tabAppType.SelectedTab;
            foreach (Control objInFor in objTabPage.Controls)
            {
                string CtrlTypeName = objInFor.GetType().ToString();
                if (objInFor.GetType().ToString() == "System.Windows.Forms.FlowLayoutPanel")
                {
                    return objInFor as FlowLayoutPanel;
                }
            }
            return null;
        }
        private int getAppTypeId()
        {
            if (tabAppType.SelectedTab == null) return 0;
            string strAppID = tabAppType.SelectedTab.Tag.ToString();
            int intAppId = int.Parse(strAppID);
            return intAppId;
            //switch (strTabID)
            //{
            //    case "tabWebApp":
            //        mltLangType = clsPubConst.LangType.CSharp;
            //        return (int)enumApplicationType.WebApp_2;
            //    case "tabAspMvcApp":
            //        mltLangType = clsPubConst.LangType.CSharp;
            //        return (int)enumApplicationType.AspMvcApp_13;

            //    case "tabWinApp":
            //        mltLangType = clsPubConst.LangType.CSharp;
            //        return (int)enumApplicationType.WinApp_1;
            //    case "tabJavaApp":
            //        mltLangType = clsPubConst.LangType.JAVA;
            //        return (int)enumApplicationType.JavaWeb_3;
            //    case "tabAndroidApp":
            //        mltLangType = clsPubConst.LangType.JAVA;
            //        return (int)enumApplicationType.AndroidApp_5;
            //    case "tabIOSApp":
            //        mltLangType = clsPubConst.LangType.Swift4;
            //        return (int)enumApplicationType.IOSApp_6;
            //    default:
            //        string strMsg = string.Format("Tab名称：{0}在函数{1}中没有被处理！", strTabID, clsStackTrace.GetCurrClassFunction());
            //        MessageBox.Show(strMsg);
            //        throw new Exception(strMsg);
            //        //                    return (int)enumApplicationType.WebApp_2;
            //}
        }



        private void btnBusinessLogic4Mvc_Click(object sender, EventArgs e)
        {
            List<string> arrTabIdLst = GetSelectedTabId();
            if (arrTabIdLst == null)
            {
                return;
            }
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            objGeneCode_Local = new clsGeneCode_Local();
            Thread t1 = new Thread(new ParameterizedThreadStart(objGeneCode_Local.GeneBusinessLogic4Mvc));
            //Thread thread = new Thread(new ParameterizedThreadStart(message.ShowMessage));
            t1.IsBackground = true;
            GeneCodeParameters myGeneCodeParameters = new GeneCodeParameters();
            myGeneCodeParameters.arrTabIdLst = arrTabIdLst;
            myGeneCodeParameters.strCharEncodingId = strCharEncodingId;
            myGeneCodeParameters.mltLangType = mltLangType;
            myGeneCodeParameters.ApplicationTypeId = getAppTypeId();
            myGeneCodeParameters.mdbtDataBaseType = mdbtDataBaseType;
            t1.Start(myGeneCodeParameters);
            strTimerMode = "PrjTab";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrTabIdLst.Count;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = arrTabIdLst.Count;

            timer1.Enabled = true;
            timer1.Start();
        }


        private void ShowCodeTypeButton(string strTabMainTypeId = "")
        {
            int intAppTypeId = getAppTypeId();
            FlowLayoutPanel objFLP = getflowLayoutPanel();
            if (objFLP == null)
            {
                MessageBox.Show("在当前Tab中没有找到相应的FlowLayoutPanel");
                return;
            }
            objFLP.Controls.Clear();
            clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(intAppTypeId);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objApplicationTypeEN.ProgLangTypeId);
            string strCharEncodingId = objProgLangType.CharEncodingId;
            cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);

            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaExWApi.GetObjExLstByApplicationTypeId(intAppTypeId);
            arrObjLst.ForEach(x =>
            {
                string strGroupName1 = x.GroupName;
                string[] arrGroupName = strGroupName1.Split(",".ToCharArray());
                x.GroupName = arrGroupName[0];
            });
            List<clsvAppCodeTypeRelaENEx> arrObjLst_Sel = null;
            if (string.IsNullOrEmpty(strTabMainTypeId) == false)
            {
                arrObjLst_Sel = arrObjLst.Where(x => x.TabMainTypeId == strTabMainTypeId)
                    .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                    .ToList();
            }
            else
            {
                clsTabMainTypeExWApi.BindCbo_TabMainTypeIdByAppIdCache(cboTabMainTypeId, intAppTypeId);
                if (clsTabMainTypeExWApi.arrTabMainTypeObjLst == null)
                {
                    arrObjLst_Sel = arrObjLst
                        .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                        .ToList();
                }
                else if (clsTabMainTypeExWApi.arrTabMainTypeObjLst.Count == 1)
                {
                    arrObjLst_Sel = arrObjLst
                       .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                       .ToList();
                }
                else if (clsTabMainTypeExWApi.arrTabMainTypeObjLst.Count > 1)
                {
                    arrObjLst_Sel = arrObjLst.Where(x => x.TabMainTypeId == clsTabMainTypeExWApi.arrTabMainTypeObjLst[1].TabMainTypeId)
                        .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                        .ToList();
                }
            }

            string strGroupName = "";
            foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_Sel)
            {
                if (objInFor.DependsOn != "Table" && objInFor.DependsOn != "PureClass") continue;

                if (objInFor.GroupName != strGroupName)
                {
                    if (string.IsNullOrEmpty(strGroupName) == false)
                    {
                        Label objLabel_BR = new Label();
                        objLabel_BR.Text = string.Format("", objInFor.GroupName);
                        objFLP.SetFlowBreak(objLabel_BR, true);
                        objFLP.Controls.Add(objLabel_BR);
                    }

                    Label objLabel = new Label();
                    objLabel.Text = string.Format("{0}", objInFor.GroupName);
                    //objLabel.AutoSize = true;
                    objLabel.Name = string.Format("lbl{0}", objInFor.CodeTypeId);
                    //string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.Font = new Font("宋体", 10.5f, FontStyle.Regular);//, FontStyle.Bold 
                    objLabel.ForeColor = Color.Blue;

                    objFLP.Controls.Add(objLabel);
                    strGroupName = objInFor.GroupName;
                }
                ToolTip toolTip1 = new ToolTip();

                // Set up the delays for the ToolTip.
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;
                // Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = true;

                Button objButton = new Button();
                objButton.Text = string.Format("{0}({1})",
                    objInFor.CodeTypeSimName, objInFor.ProgLangTypeName);
                objButton.AutoSize = true;
                objButton.Font = new Font("宋体", 10f, FontStyle.Regular);

                string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName,
                    objInFor.CodeTypeId, objInFor.ProgLangTypeId);
                toolTip1.SetToolTip(objButton, strToolTip);

                objButton.Name = string.Format("btn{0}", objInFor.CodeTypeId);
                objButton.Click += btnCodeType_Click;
                objFLP.Controls.Add(objButton);
            }
        }
        private void ShowGCIncludeXML()
        {
            int intAppTypeId = getAppTypeId();
            if (intAppTypeId == (int)enumApplicationType.AndroidApp_5 || intAppTypeId == (int)enumApplicationType.AndroidApp_WA_21)
            {
                cboAppPageTypeId.Visible = true;
                lblAppPageTypeId.Visible = true;
            }
            else
            {
                cboAppPageTypeId.Visible = false;
                lblAppPageTypeId.Visible = false;
            }
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = arrUserCodePrjMainPath.Find(x => x.ApplicationTypeId() == intAppTypeId);
            if (objUserCodePrjMainPathEN == null || string.IsNullOrEmpty(objUserCodePrjMainPathEN.IncludeXmlPath) == true)
            {
                btnGCByIncludeXmlFile.Visible = false;
            }
            else
            {
                btnGCByIncludeXmlFile.Visible = true;
            }
        }
        private void tabAppType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.intApplicationTypeId = getAppTypeId();
            if (intApplicationTypeId == 0) return;
            if (mbolIsBindGv == false) return;
            string strMachineName = Environment.MachineName;
            try
            {
                long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(this.strCmPrjId, this.intApplicationTypeId, clsPubVar.CurrSelPrjId);
                var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId,
                    clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                var objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(
                    objUserCodePrjMainPath.UserCodePrjMainPathId, Environment.MachineName, clsPubVar.CurrSelPrjId);
                if (objUserCodePrjMainPath_MachineName != null)
                {
                    this.GCMainPathId = objUserCodePrjMainPath_MachineName.GcPathId;
                }
                ShowCodeTypeButton();
                ShowGCIncludeXML();
                tabControl1.SelectedIndex = 0;
                if (chkDispAllErrMsg.Checked == true)
                {
                    BindLv_vPrjTab_WithErrMsg();
                }
                else
                {
                    BindLv_vPrjTab(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            SetStatus();
        }
        private void btnCodeType_Click(object sender, EventArgs e)
        {
            string strMsg = string.Format("strCurrIPAddressAndPort={0}, strCurrPrx={1}.(In {2})",
          clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx, clsStackTrace.GetCurrClassFunction());
            clsPubVar.objLog.WriteDebugLog(strMsg);

            if (clsPubFun.CheckWebApi() == false)
            {
                strMsg = string.Format("当前用于生成代码的WebApi不可用，请到菜单：[系统设置->WebService设置]中重新设置WebApi地址！");
                MessageBox.Show(strMsg);
                return;
            }

            Button objButton = sender as Button;
            string strCodeTypeId = objButton.Name.Substring(3);
            //           MessageBox.Show(strCodeTypeId);

            List<string> arrTabIdLst = GetSelectedTabId();
            if (arrTabIdLst == null)
            {
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            //int intErrorCount = 0;
            int intTabCount = 0;

            int intWarnningCount = 0;
            List<string> arrWarnningLst = new List<string>();
            List<string> arrErrorLst = new List<string>();
            //string strCodeText = "";
            lblMsg.Text = "";
            clsGCResult objGCResult = null;
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
            if (string.IsNullOrEmpty(clsSysParaEN.strUserId) == true)
            {
                strMsg = string.Format("当前用户(clsSysParaEN.strUserId)没有设置，请联系管理员！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WA_Access;
            string strViewId = "";
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strClassFName = "";
            int intApplicationTypeId = getAppTypeId();
            var strCmPrjId = cboCmPrjId.SelectedValue.ToString();

            if (string.IsNullOrEmpty(strCmPrjId) == true || strCmPrjId == "0")
            {
                MessageBox.Show("请选择一个CM工程！");
                cboCmPrjId.Focus();
                return;
            }
            string strMachineName = Environment.MachineName;
            long lngCMProjectAppRelaId = 0;
            try
            {

                lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                //var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                //strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            string strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {

                    if (clsvFunctionTemplateRelaExWApi.GetFunctionCountByTabId(strTabId, strPrjId, strCodeTypeId) == 0)
                    {
                        continue;
                    }
                    clsvUserCodePathEN objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathEN);
                    clsvPrjTab_SimEN objPrjTabEx = clsPrjTabExWApi.GetObjExByTabId_CacheEx(strTabId, strPrjId);
                    clsPubFun.SetIsShareCodePath(objUserCodePathEN, objPrjTabEx);

                    switch (objCodeTypeEN.SqlDsTypeId)
                    {
                        case enumSQLDSTypeWA.AllTab_00:
                            break;
                        case enumSQLDSTypeWA.SqlTab_01:
                            if (objPrjTabEx.SqlDsTypeId == enumSQLDSTypeWA.SqlView_02)
                            {
                                strMsg = string.Format("警告:生成代码类型:{0}(支持{1})不支持生成表名文件:{2}. ",
                                    objCodeTypeEN.CodeTypeName, clsSQLDSTypeWApi.GetNameBySqlDsTypeIdCache(objCodeTypeEN.SqlDsTypeId),
                                    objPrjTabEx.TabName);
                                intWarnningCount++;
                                arrWarnningLst.Add(strMsg);
                                continue;
                            }
                            break;
                        case enumSQLDSTypeWA.SqlView_02:
                            if (objPrjTabEx.SqlDsTypeId == enumSQLDSTypeWA.SqlTab_01)
                            {
                                strMsg = string.Format("警告:生成代码类型:{0}(支持{1})不支持生成表名文件:{2}. ",
    objCodeTypeEN.CodeTypeName, clsSQLDSTypeWApi.GetNameBySqlDsTypeIdCache(objCodeTypeEN.SqlDsTypeId),
    objPrjTabEx.TabName);
                                intWarnningCount++;
                                arrWarnningLst.Add(strMsg);
                                continue;
                            }
                            break;
                    }
                    //strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, typeParas,
                    //    ltLangType, mdbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //   intApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                    clsGCPara objGCPara = new clsGCPara()
                    {
                        applicationTypeId = intApplicationTypeId,
                        codeTypeId = objCodeTypeEN.CodeTypeId,
                        dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                        tabId = strTabId,
                        viewId = strViewId,
                        gcUserId = clsSysParaEN.strUserId,
                        prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                        prjId = clsPubVar.CurrSelPrjId,
                        cmPrjId = strCmPrjId,
                        typeParas = "",
                        isRecordLog = true
                    };
                    try
                    {
                        objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
                    }
                    catch (Exception objException)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabWApi.GetObjByTabId(strTabId);
                        strMsg = $"在生成表:{objPrjTab.TabName}({objPrjTab.TabId})的[{objCodeTypeEN.CodeTypeENName}]类时， 发生错误:{objException.Message}，请检查！(WebApiIP:{AGC4WApi.clsSysPara4WebApi_Agc.strCurrIPAddressAndPort}. In {clsStackTrace.GetCurrClassFunction()})";
                        MessageBox.Show(strMsg);
                        return;
                    }
                    if (objGCResult.errorId != 0)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabWApi.GetObjByTabId(strTabId);
                        strMsg = $"在生成表:{objPrjTab.TabName}({objPrjTab.TabId})的[{objCodeTypeEN.CodeTypeENName}]类时，{objGCResult.errorMsg}({clsStackTrace.GetCurrClassFunction()})";
                        MessageBox.Show(strMsg);
                        return;
                    }
                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabWApi.GetObjByTabId(strTabId);
                        strMsg = $"在生成表:{objPrjTab.TabName}({objPrjTab.TabId})的[{objCodeTypeEN.CodeTypeENName}]类时， 带模块名的文件名为空，请检查！({clsStackTrace.GetCurrClassFunction()})";
                        MessageBox.Show(strMsg);
                        return;
                    }
                    objGCResult.re_FileNameWithModuleName = InsertSuffixPath(objGCResult.re_FileNameWithModuleName, objUserCodePathEN.SuffixPath);

                    strClassFName = string.Format("{0}\\{1}",
                        objUserCodePathEN.NewCodePath,
                        objGCResult.re_FileNameWithModuleName);
                    if (objCodeTypeEN.IsDefaultOverride == true)
                    {
                        clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                            objUserCodePathEN.NewCodePath,
                            objUserCodePathEN.NewCodePathBackup, myEncoding);
                    }
                    else
                    {
                        var c = clsPubFun4WApi.SaveClassContentToFile_NoCover(strClassFName, objGCResult.codeText,
                        objUserCodePathEN.NewCodePath, objCodeTypeEN, myEncoding);
                        if (c.Item1 == false)
                        {
                            strMsg = string.Format("警告:保存不可覆盖的文件时,{1}. 文件名:{0}. ", strClassFName, c.Item2, clsStackTrace.GetCurrClassFunction());
                            intWarnningCount++;
                            arrWarnningLst.Add(strMsg);

                            continue;
                        }
                    }

                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0010", clsPubVar.CurrSelPrjId);

                    //strCodeText = clsPrjTabExWApi.GenWS_Access(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId,
                    //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    intTabCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            StringBuilder sbMsg = new StringBuilder();
            if (objGCResult == null)
            {
                sbMsg.AppendFormat("生成表完成！共计：{0}个表。", intTabCount.ToString());
                sbMsg.AppendLine(string.Format("警告信息:{0}条:", arrWarnningLst.Count));

                if (arrWarnningLst != null)
                {
                    arrWarnningLst.ForEach(x => { sbMsg.AppendLine("\r\n" + x); });
                }

                MessageBox.Show(sbMsg.ToString());
                return;
            }
            if (string.IsNullOrEmpty(objGCResult.codeElementJson) == false)
            {
                try
                {
                    //CodeElement root = BuildSampleCodeElement(); // 或用你的分析结果
                    CodeElement rootElement = JsonConvert.DeserializeObject<CodeElement>(objGCResult.codeElementJson);
                    LoadCodeTree(treeView1, rootElement);
                }
                catch { }
            }

            txtCode.Text = objGCResult.codeText;
            txtFileName4GenCode.Text = objGCResult.re_ClsName;
            txtCodePath.Text = strClassFName;
            tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();

            sbMsg.AppendFormat("生成表完成！共计：{0}个表.", intTabCount.ToString());

            sbMsg.AppendLine(string.Format("\r\n警告信息:{0}条:", arrWarnningLst.Count));

            if (arrWarnningLst != null)
            {
                arrWarnningLst.ForEach(x => { sbMsg.AppendLine("\r\n" + x); });
            }

            MessageBox.Show(sbMsg.ToString());

            BindLv_vPrjTab(false);
        }

        private void btnGCByIncludeXmlFile_Click(object sender, EventArgs e)
        {
            string strMachineName = Environment.MachineName;
            int intAppTypeId = getAppTypeId();// (int)enumApplicationType.PubApp4WinWeb_7;
            int intApplicationTypeId = intAppTypeId;// getAppTypeId();
            try
            {
                GeneCodeByIncludeXml(intApplicationTypeId, strMachineName);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("通过包含表Xml文件生成代码出错。{0}. (In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                MessageBox.Show(strMsg);
            }
        }
        private void GeneCodeByIncludeXml(int intApplicationTypeId, string strMachineName)
        {
            string strMsg = "";
            clsProjectsEN objProjects = clsProjectsWApi.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
            clsApplicationTypeEN objApplicationType = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(intApplicationTypeId);

            long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(clsPubVar.CmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN
               = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
            string strXmlPath = "";
            var objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(
                objUserCodePrjMainPathEN.UserCodePrjMainPathId, Environment.MachineName, clsPubVar.CurrSelPrjId);
            if (objUserCodePrjMainPath_MachineName != null)
            {
                strXmlPath = string.Format("{0}\\{1}", objUserCodePrjMainPath_MachineName.CodePath, objUserCodePrjMainPathEN.IncludeXmlPath);
                strXmlPath = strXmlPath.Replace("\\\\", "\\").Replace("\\\\", "\\");
            }
            if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.IncludeXmlPath) == true)
            {
                strMsg = string.Format("在工程:[{0}({1})]中， 应用:{2}没有设置包含表Xml文件路径，请检查！(In {3})",
                    objProjects.PrjName, objProjects.PrjId, objApplicationType.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (File.Exists(strXmlPath) == false)
            {
                strMsg = string.Format("在工程:[{0}({1})]中， 应用:{2}设置的包含表Xml文件路径:[{3}]，请检查！(In {4})",
                    objProjects.PrjName, objProjects.PrjId,
                    objApplicationType.ApplicationTypeName, strXmlPath, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsIncludeFile.XmlPath = strXmlPath;//  @"E:\ASPNETJX\SamplePrj2017\SamplePrjWin\IncludeFile.xml";
            string strBuildPrj = clsIncludeFile.GetBuildPrj();
            clsIncludeFile.SortTabNameLst();

            List<CompileTab> arrCompileTab = clsIncludeFile.getTabNameLst();
            StringBuilder sbTabName_NoExist = new StringBuilder();
            foreach (var item in arrCompileTab)
            {
                clsvPrjTab_SimEN objPrjTab = clsPrjTabExWApi.GetObjByTabNameExCache(clsPubVar.CurrSelPrjId, item.TabName);
                if (item.Operate == "Add")
                {
                    if (objPrjTab == null || objPrjTab.TabStateId != enumTabStateWA.Normal_01)
                    {
                        //strMsg = string.Format("表名:{0}在工程:[{1}({2})]中不存在！", item.TabName, objProjects.PrjName, objProjects.PrjId);
                        //throw new Exception(strMsg);
                        sbTabName_NoExist.AppendLine(item.TabName);
                    }
                }
            }
            if (sbTabName_NoExist.Length > 0)
            {
                strMsg = string.Format("表名:{0}在工程:[{1}({2})]中不存在！", sbTabName_NoExist.ToString(), objProjects.PrjName, objProjects.PrjId);
                throw new Exception(strMsg);
            }
            //获取

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();
            lblMsg.Text = "";

            objGeneCode_Local = new clsGeneCode_Local();
            Thread t1 = new Thread(new ParameterizedThreadStart(objGeneCode_Local.GC_IncludeTab));
            //Thread thread = new Thread(new ParameterizedThreadStart(message.ShowMessage));
            t1.IsBackground = true;
            GeneCodeParameters myGeneCodeParameters = new GeneCodeParameters();
            myGeneCodeParameters.arrCompileTab = arrCompileTab;
            myGeneCodeParameters.strCharEncodingId = strCharEncodingId;
            myGeneCodeParameters.bolIsIgnoreCommTable = chkIgnoreCommTable.Checked;
            myGeneCodeParameters.strTypeParas = typeParas;
            myGeneCodeParameters.mltLangType = mltLangType;
            myGeneCodeParameters.ApplicationTypeId = getAppTypeId();
            myGeneCodeParameters.mdbtDataBaseType = mdbtDataBaseType;
            myGeneCodeParameters.objUserCodePrjMainPathEN = objUserCodePrjMainPathEN;
            myGeneCodeParameters.strBuildPrj = strBuildPrj;
            strTimerMode = "IncludeTab";
            t1.Start(myGeneCodeParameters);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrCompileTab.Count;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = arrCompileTab.Count;

            timer1.Enabled = true;
            timer1.Start();

        }
        class MyMSProject : IMSProject
        {
            public IEnumerable<string> GetCompileFileLst(string strPrjFileName)
            {
                clsMSProject.ProjectPath = strPrjFileName;
                IEnumerable<string> arrCompileFileLst = clsMSProject.getCompileFileLst();
                return arrCompileFileLst;
            }
        }

        private void btnCodeManage_Click(object sender, EventArgs e)
        {
            string strMachineName = Environment.MachineName;
            try
            {
                var strCmPrjId = cboCmPrjId.SelectedValue.ToString();
                clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = null;
                try
                {

                    long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, getAppTypeId(), clsPubVar.CurrSelPrjId);

                    objUserCodePrjMainPathEN
                          = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId,
                          clsPubVar.CurrSelPrjId, Environment.MachineName, clsSysParaEN.strUserId);
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                    return;
                    //                throw new Exception("请设置应用类型Id!");
                }

                clsCMClassExWApi.ImportCode4PrjId(objUserCodePrjMainPathEN.UserCodePrjMainPathId, clsPubVar.CurrSelPrjId, strCmPrjId, strMachineName, clsSysParaEN_Local.strUserId, new MyMSProject(), new MyParseCsFile());
                MessageBox.Show("代码管理-分析文件完成！");
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void cboTabMainTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clsTabMainTypeExWApi.bolIsSelectIndexAfterBindCbo == true)
            {
                clsTabMainTypeExWApi.bolIsSelectIndexAfterBindCbo = false;
                return;
            }
            if (cboTabMainTypeId.SelectedIndex <= 0) return;
            string strTabMainTypeId = cboTabMainTypeId.SelectedValue.ToString();
            ShowCodeTypeButton(strTabMainTypeId);
            if (chkDispAllErrMsg.Checked == true)
            {
                BindLv_vPrjTab_WithErrMsg();
            }
            else
            {
                BindLv_vPrjTab(false);
            }
        }

        private void cboCmPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mbolIsStartAccessCmPrjIdChangeEvent == false) return;
            if (cboCmPrjId.SelectedIndex == 0)
            {
                strCmPrjId = "";
                GCMainPathId = "";
                return;
            }
            this.mbolIsBindGv = false;
            string strMachineName = Environment.MachineName;
            this.mstrGCMainPathId = "";
            strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            List<int> arrAppTypeId = clsCMProjectAppRelaExWApi.getAppTypeIdLstByCmPrjId(strCmPrjId, clsPubVar.CurrSelPrjId);

            if (arrAppTypeId.Count > 0)
            {
                //this.intApplicationTypeId = arrAppTypeId[0];
                foreach (TabPage objInFor in arrAllTagPage)
                {
                    int intTag = int.Parse(objInFor.Tag.ToString());
                    if (arrAppTypeId.Contains(intTag) == false)
                    {
                        //objInFor.vi..vi
                        //tabAppType.TabPages.Remove(objInFor);
                        objInFor.Parent = null;
                    }
                    else
                    {
                        objInFor.Parent = tabAppType;

                    }
                }
            }
            var arrStrAppId = arrAppTypeId.Select(x => x.ToString()).ToList();
            foreach (TabPage objInFor_Sub in tabAppType.TabPages)
            {
                if (arrStrAppId.IndexOf(objInFor_Sub.Tag.ToString()) > -1)
                {
                    objInFor_Sub.Select();
                    this.intApplicationTypeId = int.Parse(objInFor_Sub.Tag.ToString());
                    break;
                }
            }
            if (this.intApplicationTypeId == 0)
            {
                this.intApplicationTypeId = getAppTypeId();
            }
            if (intApplicationTypeId > 0)
            {
                try
                {

                    long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

                    var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                    var objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(objUserCodePrjMainPath.UserCodePrjMainPathId, Environment.MachineName, clsPubVar.CurrSelPrjId);

                    this.GCMainPathId = objUserCodePrjMainPath_MachineName == null ? "" : objUserCodePrjMainPath_MachineName.GcPathId;
                    if (string.IsNullOrEmpty(this.GCMainPathId) == true)
                    {
                        var objCMProject = clsCMProjectWApi.GetObjByCmPrjIdCache(objUserCodePrjMainPath.CmPrjId());
                        var objAppType = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(objUserCodePrjMainPath.ApplicationTypeId());
                        var strMsg = string.Format("生成主目录的GC路径为空，请检查！CM项目:{0},应用:{1},请联系管理员。",
                            objCMProject.CmPrjName, objAppType.ApplicationTypeName);
                        if (objUserCodePrjMainPath_MachineName != null)
                        {
                            var strKeyId = clsGCPathExWApi.AddGCPath4Main(objUserCodePrjMainPath_MachineName.CodePath, objUserCodePrjMainPath.PrjId, objUserCodePrjMainPath.UserId);
                            if (string.IsNullOrEmpty(strKeyId) == false)
                            {
                                objUserCodePrjMainPath_MachineName.GcPathId = strKeyId;
                                objUserCodePrjMainPath_MachineName.Update();
                            }
                        }
                        //MessageBox.Show(strMsg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex);
                }
            }
            SetStatus();
            this.mbolIsBindGv = true;
            tabAppType_SelectedIndexChanged(null, null);

            //btnQuery_Click(null, null);
        }
        private void GetGCMainPathId()
        {
            if (cboCmPrjId.SelectedIndex == 0)
            {
                strCmPrjId = "";
                GCMainPathId = "";
                MessageBox.Show("请选择一个CM项目！");
                cboCmPrjId.Focus();
                return;
            }
            string strMachineName = Environment.MachineName;
            strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            if (this.intApplicationTypeId == 0)
            {
                this.intApplicationTypeId = getAppTypeId();
            }
            try
            {

                long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);
                if (lngCMProjectAppRelaId == 0) return;
                var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId,
                    clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                var objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(objUserCodePrjMainPath.UserCodePrjMainPathId, Environment.MachineName, clsPubVar.CurrSelPrjId);
                if (objUserCodePrjMainPath_MachineName != null)
                {
                    this.GCMainPathId = objUserCodePrjMainPath_MachineName.GcPathId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.GCMainPathId = "";
            }
        }

        private void btnRemoveCurrCmPrjId_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            List<string> arrTabIdLst = GetSelectedTabId();
            if (arrTabIdLst == null)
            {
                return;
            }
            if (cboCmPrjId.SelectedIndex == 0)
            {
                MessageBox.Show("请选择CM工程！");
                cboCmPrjId.Focus();
                return;
            }
            string strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            int intCount = 0;

            try
            {
                foreach (string strTabId in arrTabIdLst)
                {
                    var intNum = clsCMProjectPrjTabExWApi.DelRela(strCmPrjId, strTabId);
                    intCount += intNum;
                }
                MessageBox.Show(this, "共删除：" + intCount.ToString() + "个表关系。");
                btnQuery_Click(null, null);
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
                //ErrorInformationWApi.AddInformation("wfmPrjTab_QUDI3.aspx", "lbCheckAllTabField_Click", objException.Message, clsSysParaEN.strUserId);
            } //显示生成代码区域

        }

        private void btnGeneAndUpdCheckedTable_Click(object sender, EventArgs e)
        {
            string strMsg = string.Format("strCurrIPAddressAndPort={0}, strCurrPrx={1}.(In {2})",
        clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx, clsStackTrace.GetCurrClassFunction());
            clsPubVar.objLog.WriteDebugLog(strMsg);

            if (clsPubFun.CheckWebApi() == false)
            {
                strMsg = string.Format("当前用于生成代码的WebApi不可用，请到菜单：[系统设置->WebService设置]中重新设置WebApi地址！");
                MessageBox.Show(strMsg);
                return;
            }

            lblMsg.Text = "";
            List<string> arrTabIdLst = GetSelectedTabId();
            if (arrTabIdLst == null)
            {
                return;
            }
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            var strCmPrjId = cboCmPrjId.SelectedValue.ToString();

            if (string.IsNullOrEmpty(strCmPrjId) == true || strCmPrjId == "0")
            {
                MessageBox.Show("请选择一个CM工程！");
                cboCmPrjId.Focus();
                return;
            }

            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

            objGeneCode_Local = new clsGeneCode_Local();
            Thread t1 = new Thread(new ParameterizedThreadStart(objGeneCode_Local.GeneAllCheckedTableThreeLayer));
            //Thread thread = new Thread(new ParameterizedThreadStart(message.ShowMessage));
            t1.IsBackground = true;
            string strTabMainTypeId = cboTabMainTypeId.SelectedValue.ToString();
            if (string.IsNullOrEmpty(strTabMainTypeId) == true)
            {
                lblMsg.Text = "请选择一个表主类型!";
                cboTabMainTypeId.Focus();
                MessageBox.Show(lblMsg.Text);
                return;
            }
            GeneCodeParameters myGeneCodeParameters = new GeneCodeParameters();
            myGeneCodeParameters.arrTabIdLst = arrTabIdLst;
            myGeneCodeParameters.strTabMainTypeId = strTabMainTypeId;
            myGeneCodeParameters.strCharEncodingId = strCharEncodingId;
            myGeneCodeParameters.bolIsIgnoreCommTable = chkIgnoreCommTable.Checked;
            myGeneCodeParameters.strTypeParas = typeParas;
            myGeneCodeParameters.mltLangType = mltLangType;
            myGeneCodeParameters.bolIsUpdCurr = true;
            myGeneCodeParameters.ApplicationTypeId = getAppTypeId();
            myGeneCodeParameters.mdbtDataBaseType = mdbtDataBaseType;
            myGeneCodeParameters.strCmPrjId = strCmPrjId;
            t1.Start(myGeneCodeParameters);
            strTimerMode = "PrjTab";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrTabIdLst.Count;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = arrTabIdLst.Count;

            timer1.Enabled = true;
            timer1.Start();
            //}
            //catch(Exception objException)
            //{
            //    MessageBox.Show(objException.Message);
            //}
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text; // 获取查找文本
            if (!string.IsNullOrEmpty(searchText))
            {
                int index = txtCode.Find(searchText, RichTextBoxFinds.None); // 查找文本

                if (index != -1)
                {
                    // 如果找到匹配的文本，则选中该文本并滚动到该位置
                    txtCode.Select(index, searchText.Length);
                    txtCode.ScrollToCaret(); // 滚动到匹配项
                    HighlightText(searchText);
                }
                else
                {
                    MessageBox.Show("Text not found!");
                }
            }
            else
            {
                MessageBox.Show("Please enter text to search.");
            }
        }
        private void HighlightText(string textToFind)
        {
            // 清除之前的高亮
            txtCode.SelectionStart = 0;
            txtCode.SelectionLength = 0;

            // 查找文本
            int index = txtCode.Text.IndexOf(textToFind);
            while (index != -1)
            {
                // 设置选中的文本的背景色和字体颜色
                txtCode.SelectionStart = index;
                txtCode.SelectionLength = textToFind.Length;
                txtCode.SelectionBackColor = Color.Yellow;  // 背景色
                txtCode.SelectionColor = Color.Red;         // 字体颜色

                // 继续查找下一个匹配
                index = txtCode.Text.IndexOf(textToFind, index + textToFind.Length);
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                // 查找下一个匹配项
                int index = txtCode.Find(searchText, txtCode.SelectionStart + txtCode.SelectionLength, RichTextBoxFinds.None);

                if (index != -1)
                {
                    txtCode.Select(index, searchText.Length);
                    txtCode.ScrollToCaret();
                }
                else
                {
                    MessageBox.Show("No more occurrences found.");
                }
            }
        }

        /// <summary>
        /// 查找上一个文本
        /// </summary>
        /// <param name="text">要查找的文本</param>

        private void btnFindPrevious_Click(object sender, EventArgs e)
        {

            string searchText = txtSearch.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("请输入要查找的内容！");
                return;
            }

            // 获取当前光标的位置
            int currentIndex = txtCode.SelectionStart;

            // 从当前光标位置向前查找
            int index = txtCode.Find(searchText, 0, currentIndex, RichTextBoxFinds.Reverse);

            if (index != -1)
            {
                // 找到文本，选中它
                txtCode.Select(index, searchText.Length);
                txtCode.SelectionBackColor = Color.Yellow; // 可选，给选中的文字加背景色
                _lastIndex = index; // 更新索引
            }
            else
            {
                MessageBox.Show("已到达文档开头，没有找到更多匹配项！");
            }
        }

        public void SetStatus()
        {
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = getAppTypeId();
            string strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);
            //string strUserCodePrjMainPathId = "";
            string strCmPrjName = "";
            if (string.IsNullOrEmpty(strCmPrjId) == false)
            {
                strCmPrjName = clsCMProjectWApi.GetCmPrjNameByCmPrjIdCache(strCmPrjId);
            }
            try
            {
                clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId);

                var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, clsPubVar.CurrSelPrjId);
                if (objUserCodePrjMainPathEx.CodePath == "")
                {
                    string strAppName = clsApplicationTypeWApi.GetNameByApplicationTypeIdCache(objUserCodePrjMainPathEx.ApplicationTypeId());
                    string strErrMsg = $"Cm工程:{strCmPrjName}, 应用:{strAppName}在机器:{objUserCodePrjMainPathEx.MachineName}中生成代码路径为空，请检查！";
                    lblGcCodePath.Text = $"Cm工程:[{strCmPrjName}]的生成代码路径为空，请检查！";
                    lblGcCodePath.ForeColor = Color.Red;
                    throw new Exception(strErrMsg);
                }
                string strCodePath_Temp = objUserCodePrjMainPathEx.CodePath.Replace("\\", "/");
                string strCodePath = $"生成主目录:{strCodePath_Temp}";
                lblGcCodePath.Text = strCodePath;
                //                statusStrip1.Items.Add(strCodePath);

            }
            catch (Exception objException)
            {
                lblGcCodePath.Text = $"Cm工程:[{strCmPrjName}]的生成代码路径为空，请检查！";
                lblGcCodePath.ForeColor = Color.Red;
                MessageBox.Show(objException.Message);
                return;
            }


            //statusStrip1.Items.Add("测试状态");
        }
        public void SetPrjStatus()
        {
            string strStatus = "";
            if (string.IsNullOrEmpty(clsPubVar.CurrPrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                strStatus = string.Format("工程：{0}({1}); 数据库：{2}({3}); 生成代码WebApi:{4} ",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    objPrjDataBaseEN.PrjDataBaseName,
                    objPrjDataBaseEN.PrjDataBaseId,
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }
            else
            {
                //string strWebServiceSet = clsPubFun.GetWebServiceSet();
                strStatus = string.Format("工程：{0}({1}); 数据库：{2}({3}); 生成代码WebApi:{4} ",
                    clsPubVar.objCurrSelProjectEN.PrjName,
                    clsPubVar.objCurrSelProjectEN.PrjId,
                    "无数据库",
                    "无数据库Id",
                    clsSysPara4WebApi_Agc.strCurrIPAddressAndPort);
            }
            lblPrjStatus.Text = strStatus;
            //            statusStrip1.Items.Add("测试状态");
        }
        public bool IsUseCache
        {
            get
            {
                if (cboIsUseCache.SelectedIndex == 1)
                {
                    return true;
                }
                else if (cboIsUseCache.SelectedIndex == 2)
                {
                    return false;
                }
                return false;
            }
        }

        public bool IsAppliedViewList
        {
            get
            {
                if (cboIsAppliedViewList.SelectedIndex == 1)
                {
                    return true;
                }
                else if (cboIsAppliedViewList.SelectedIndex == 2)
                {
                    return false;
                }
                return false;
            }
        }

        public string CmPrjId
        {
            get
            {
                if (cboCmPrjId.SelectedValue.ToString() == "0")
                    return "";
                return cboCmPrjId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboCmPrjId.SelectedValue = "0";
                }
                else
                {
                    cboCmPrjId.SelectedValue = value;
                }
            }
        }
        public void LoadCodeTree(TreeView treeView, CodeElement rootElement)
        {
            if (rootElement == null)
            {
                treeView.Nodes.Clear();
                return;
            }
            CodeAnalyzer.SortCodeElements(rootElement.Children, CodeAnalyzer.sortPriority);
            treeView.Nodes.Clear();
            var rootNode = CreateNodeFromElement(rootElement);
            this.ceRootElement = rootElement;
            treeView.Nodes.Add(rootNode);
            treeView.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Tag.ToString());
            CodeElement objFindCodeElement = CodeAnalyzer.FindElementByName(this.ceRootElement, e.Node.Tag.ToString());
            if (objFindCodeElement == null) return;
            txtFuncCode.Text = objFindCodeElement.CodeContent;
            string strRefFuncName = objFindCodeElement.RefFuncName == null ? "" : objFindCodeElement.RefFuncName;
            if (objFindCodeElement.ElementType == CodeElementType.Import)
            {
                txtFuncCode.Text = txtFuncCode.Text + "\r\n" + $"引用函数: {strRefFuncName}";//请注意：此处的Import代码是自动生成的，可能需要手动修改。";
            }
        }
        private TreeNode CreateNodeFromElement(CodeElement element)
        {
            // 示例节点内容格式
            string nodeText = $"{element.ElementType}: {element.Name}";
            if (!string.IsNullOrEmpty(element.ReturnType))
                nodeText += $" : {element.ReturnType}";

            var node = new TreeNode(nodeText);
            node.Tag = element.Name;
            foreach (var child in element.Children)
            {
                node.Nodes.Add(CreateNodeFromElement(child));
            }

            return node;
        }

    }
}