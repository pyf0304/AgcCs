
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/14
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：项目界面管理
///模块英文名：PrjInterface
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
//生成与表相关的控件控制层代码
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AGC.Entity;
using Agc_CsWin;
using AGC_CSWin;
using AGC4WApi;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.util;
using CommFunc4Win;
using Newtonsoft.Json;

namespace AGC
{
    /// <summary>
    ///		frmViewInfo_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmViewInfo_GeneCode : System.Windows.Forms.Form, IBindListView
    {
        public CodeElement ceRootElement = null; // 用于存储代码生成的根节点
        private int _lastIndex = -1; // 用于记录上一次查找到的索引
        private bool bolIsBindData = false;
        private string strVersion = "";
        private string mstrCurrViewId = "";
        //private string mstrTypeParas = "";
        //private clsPubConst.LangType mltLangType = clsPubConst.LangType.CSharp;//语言类型
        private clsPubConst.DataBaseType mdbtDataBaseType = clsPubConst.DataBaseType.MsSql;//数据库类型

        //clsViewInfoEN objViewInfoEN = null;
        private System.Data.DataTable objDTViewInfo = null;
        private clsListViewSorter objvViewInfoSorter;
        private int intLastSelectedvViewInfoColumIndex;
        public frmViewInfo_GeneCode()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvViewInfoSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvViewInfo.ListViewItemSorter = objvViewInfoSorter;
            objvViewInfoSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmViewInfo_QD_Load(object sender, System.EventArgs e)
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);

            this.Text = string.Format("界面代码生成20250705----工程：{0}({1})  数据库：{2}({3})", clsPubVar.objCurrSelProjectEN.PrjName, clsPubVar.objCurrSelProjectEN.PrjId,
                                objPrjDataBaseEN.PrjDataBaseName, objPrjDataBaseEN.PrjDataBaseId);

            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();
            SetPrjStatus();
            //string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            int intAppTypeId = getAppTypeId();
            clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(intAppTypeId);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objApplicationTypeEN.ProgLangTypeId);
            string strCharEncodingId = objProgLangTypeEN.CharEncodingId;
            cboCharEncodingId.SelectedValue = strCharEncodingId;

            //cboPrjId.SelectedValue = clsPubVar.CurrSelPrjId;
            //cboPrjId.Enabled = false;
            //cboApplicationTypeId.SelectedValue = clsApplicationTypeExWApi.DOTNETWEBAPP;
            ShowCodeTypeButton();
            if (bolIsBindData == false)
            {
                BindLv_vViewInfo();
            }
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用


        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {

            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(this.cboCmPrjId, clsPubVar.CurrSelPrjId);

            //clsApplicationTypeWApi.BindCbo_ApplicationTypeId(this.cboApplicationTypeId);
            clsFuncModule_AgcExWApi.BindCbo_FuncModuleIdCache(this.cboFuncModuleId, clsPubVar.CurrSelPrjId);
            //clsProjectsWApi.BindCbo_PrjId(this.cboPrjId);
            
            clsCharEncodingExWApi.BindCbo_CharEncodingIdCache(cboCharEncodingId);
            clsComboBox_Common.BindCbo_TrueAndFalse(cboIsShare);
        }
        public string ViewName
        {
            get
            {
                return txtViewName.Text.Trim();
            }
            set
            {
                txtViewName.Text = value.ToString();
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

        public AGC4WApi.enumApplicationType ApplicationTypeId
        {
            get
            {
                return (AGC4WApi.enumApplicationType)getAppTypeId();
            }
            set
            {
                switch (value)
                {
                    case AGC4WApi.enumApplicationType.WinApp_1:
                        tabWinApp.Select();
                        break;
                    case AGC4WApi.enumApplicationType.WebApp_2:
                        tabWebApp.Select();
                        break;
                    //case AGC4WApi.enumApplicationType.JavaWeb_3:
                    //    tabJavaApp.Select();
                    //    break;
                    case AGC4WApi.enumApplicationType.AndroidApp_5:
                        tabAndroidApp.Select();
                        break;
                    case AGC4WApi.enumApplicationType.IOSApp_6:
                        tabIOSApp.Select();
                        break;

                }

            }
        }

        public string FuncModuleAgcId
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

        //public string PrjId
        //{
        //    get
        //    {
        //        if (cboPrjId.SelectedValue.ToString() == "0")
        //            return "";
        //        return cboPrjId.SelectedValue.ToString();
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            cboPrjId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            cboPrjId.SelectedValue = value;
        //        }
        //    }
        //}

        public string MainTabId
        {
            get
            {
                if (cboMainTabId.SelectedValue.ToString() == "0")
                    return "";
                return cboMainTabId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboMainTabId.SelectedValue = "0";
                }
                else
                {
                    cboMainTabId.SelectedValue = value;
                }
            }
        }


        public void Clear()
        {
            txtViewName.Text = "";
            cboCmPrjId.SelectedIndex = 0;
            cboFuncModuleId.SelectedIndex = 0;
            cboMainTabId.SelectedIndex = 0;
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
            txtViewName.Text = "";
            cboCmPrjId.SelectedIndex = 0;
            cboFuncModuleId.SelectedIndex = 0;
            cboMainTabId.SelectedIndex = 0;
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

        public void SetCbo_CmPrjId()
        {
            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(this.cboCmPrjId, clsPubVar.CurrSelPrjId);

        }
        //public void SetCbo_ApplicationTypeId()
        //{
        //    clsApplicationTypeWApi.BindCbo_ApplicationTypeId(cboApplicationTypeId);
        //}
        public void SetCbo_FuncModuleId(string strPrjId)
        {
            clsFuncModule_AgcWApi.BindCbo_FuncModuleAgcId(cboFuncModuleId, strPrjId);
        }
        //public void SetCbo_PrjId()
        //{
        //    clsProjectsWApi.BindCbo_PrjId(cboPrjId);
        //}
        public void SetCbo_MainTabId()
        {
            string strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            clsvPrjTab_SimExWApi.BindCbo_TabIdCacheEx(cboMainTabId, strCmPrjId);
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

        private int getAppTypeId()
        {
            string strAppID = tabAppType.SelectedTab.Tag.ToString();
            int intAppId = int.Parse(strAppID);
            return intAppId;

            //            string strTabID = tabAppType.SelectedTab.Name;

            //            switch (strTabID)
            //            {
            //                case "tabWebApp":
            //                    mltLangType = clsPubConst.LangType.CSharp;
            //                    return (int)enumApplicationType.WebApp_2;
            //                case "tabAspMvcApp":
            //                    mltLangType = clsPubConst.LangType.CSharp;
            //                    return (int)enumApplicationType.AspMvcApp_13;

            //                case "tabWinApp":
            //                    mltLangType = clsPubConst.LangType.CSharp;
            //                    return (int)enumApplicationType.WinApp_1;
            //                case "tabJavaApp":
            //                    mltLangType = clsPubConst.LangType.JAVA;
            //                    return (int)enumApplicationType.JavaWeb_3;
            //                case "tabAndroidApp":
            //                    mltLangType = clsPubConst.LangType.JAVA;
            //                    return (int)enumApplicationType.AndroidApp_5;
            //                case "tabIOSApp":
            //                    mltLangType = clsPubConst.LangType.Swift4;
            //                    return (int)enumApplicationType.IOSApp_6;
            //                default:
            //                    string strMsg = string.Format("Tab名称：{0}在函数{1}中没有被处理！", strTabID, clsStackTrace.GetCurrClassFunction());
            //                    MessageBox.Show(strMsg);
            //                    throw new Exception(strMsg);
            ////                    return (int)enumApplicationType.WebApp_2;
            //            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineViewInfoCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 ");
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            strWhereCond += " And PrjId='" + clsPubVar.CurrSelPrjId + "'";

            int intAppTypeId = getAppTypeId();
            strWhereCond += " And ApplicationTypeId=" + intAppTypeId.ToString();

            if (this.txtViewName.Text.Trim() != "")
            {
                strWhereCond += " And ViewName like '%" + this.txtViewName.Text.Trim() + "%'";
            }
            if (this.cboCmPrjId.SelectedValue != null && this.cboCmPrjId.SelectedValue.ToString() != "" && this.cboCmPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += string.Format(" And ViewId in (Select ViewId From {0} where CmPrjId='{1}')", conViewInfoCmPrjIdRela._CurrTabName, this.cboCmPrjId.SelectedValue);
            }

            if (cboIsShare.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0}='1'", conViewInfo.IsShare);
            }
            else if (cboIsShare.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0}='0'", conViewInfo.IsShare);
            }

            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And FuncModuleAgcId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboMainTabId.SelectedValue != null 
                && this.cboMainTabId.SelectedValue.ToString() != "" 
                && this.cboMainTabId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And MainTabId='" + this.cboMainTabId.SelectedValue + "'";
            }

            return strWhereCond;
        }

        /// <summary>
        /// 函数功能：用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvViewInfo.SelectedItems.Count >= 1)
            {
                this.btnDelRec.Enabled = true;
            }
            else
            {
                this.btnDelRec.Enabled = false;
            }
        }

        private void BindLv_vViewInfo()
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivViewInfo;
            List<clsvViewInfoEN> arrvViewInfoObjList;
            string strWhereCond = "";
            //	1、组合界面条件串；
            try
            {
                strWhereCond = this.CombineViewInfoCondion();    //  CombineViewInfoCondion();
            }
            catch (Exception objException)
            {
                Console.WriteLine(objException);
                return;
            }
            //strWhereCond += "[Exclude]or [/Exclude]";
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvViewInfoObjList = clsvViewInfoWApi.GetObjLst(strWhereCond);
            string strCondtion2 = string.Format("{0}='{1}' and {2}='{3}'", 
                conLog4CreateView4Sql.UserId, clsSysParaEN.strUserId, conLog4CreateView4Sql.PrjId, clsPubVar.CurrSelPrjId);
            List<clsLog4GeneViewCodeEN> arrLog4GeneViewCodeObjLst = clsLog4GeneViewCodeWApi.GetObjLst(strCondtion2);

            //	3、设置ListView的列头信息
            this.lvvViewInfo.Items.Clear();//清除原来所有Item
            this.lvvViewInfo.Columns.Clear();//清除原来所有列头信息
            //this.lvvViewInfo.Columns.Add("界面ID", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("应用类型", 80, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("界面名称", 280, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("生成时间", 120, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("需要生成?", 80, HorizontalAlignment.Left);

            this.lvvViewInfo.Columns.Add("版本", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("修改日期", 130, HorizontalAlignment.Left);
            
            this.lvvViewInfo.Columns.Add("功能模块", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("界面主表", 150, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("主表关键字", 100, HorizontalAlignment.Left);
            //this.lvvViewInfo.Columns.Add("工程名称", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("区域数", 100, HorizontalAlignment.Left);

            this.lvvViewInfo.View = View.Details;
            this.lvvViewInfo.BeginUpdate();

            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvViewInfoEN objvViewInfoEN in arrvViewInfoObjList)
            {
                lvivViewInfo = new ListViewItem();
                lvivViewInfo.Tag = objvViewInfoEN.ViewId;
                lvivViewInfo.Text = objvViewInfoEN.ApplicationTypeSimName;
                //lvivViewInfo.SubItems.Add(objvViewInfoEN.ApplicationTypeName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.ViewName);


                clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = clsLog4GeneViewCodeExWApi.GetObjByViewId(arrLog4GeneViewCodeObjLst, objvViewInfoEN.ViewId);
                if (objLog4GeneViewCodeEN != null)
                {
                    lvivViewInfo.SubItems.Add(GetShortDate(objLog4GeneViewCodeEN.GeneCodeDate));
                    if (objvViewInfoEN.UpdDate.CompareTo(objLog4GeneViewCodeEN.GeneCodeDate) > 0)
                    {
                        lvivViewInfo.SubItems.Add("需要");
                    }
                    else
                    {
                        lvivViewInfo.SubItems.Add("不");
                    }
                    lvivViewInfo.SubItems.Add(objLog4GeneViewCodeEN.VersionGeneCode);
                }
                else
                {
                    lvivViewInfo.SubItems.Add("");
                    lvivViewInfo.SubItems.Add("需要");

                    lvivViewInfo.SubItems.Add("");
                }
                string strUpdDate = objvViewInfoEN.UpdDate;
                if (objvViewInfoEN.UpdDate.Length > 16)
                {
                    strUpdDate = objvViewInfoEN.UpdDate.Substring(0, 16);
                }

                lvivViewInfo.SubItems.Add(strUpdDate);
                
                lvivViewInfo.SubItems.Add(objvViewInfoEN.FuncModuleName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.MainTabName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.KeyForMainTab);

                //lvivViewInfo.SubItems.Add(objvViewInfoEN.PrjName);
                //int intRegionNum =  clsViewRegionRelaExWApi.GetRegionNumByViewId(objvViewInfoEN.ViewId);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.RegionNum.ToString());

                this.lvvViewInfo.Items.Add(lvivViewInfo);
            }
            this.lvvViewInfo.EndUpdate();

            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvViewInfoObjList.Count.ToString();
        }

        private string GetShortDate(string strDate)
        {
            if (strDate.Length > 3 && strDate.Length < 15)
                return strDate.Substring(2);
            else if (strDate.Length > 15)
                return strDate.Substring(2, 14);
            else return strDate;
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vViewInfo();
            tabViewInfoListCode.SelectedIndex = 0;
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strViewId = objDTViewInfo.Rows[intCurrRow]["ViewId"].ToString();
            return strViewId;
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
            ListViewItem lviViewInfo;
            lviViewInfo = objListView.SelectedItems[0];
            string strViewInfoId = lviViewInfo.Tag.ToString();
            return strViewInfoId;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(ListViewItem objListViewItem)
        {
            string strViewInfoId = objListViewItem.Tag.ToString();
            return strViewInfoId;
        }
        private void lvvViewInfo_Click(object sender, System.EventArgs e)
        {
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用

        }


        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteViewInfoRecord();
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
            string strWhereCond = this.CombineViewInfoCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsViewInfoWApi.GetDataTable_ViewInfo(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "ViewInfo信息导出.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("ViewId"); arrCnName.Add("界面ID");
            arrColName.Add("ApplicationTypeName"); arrCnName.Add("应用程序类型名称");
            arrColName.Add("ViewGroupName"); arrCnName.Add("界面组名称");
            arrColName.Add("ViewName"); arrCnName.Add("界面名称");
            arrColName.Add("ViewCnName"); arrCnName.Add("视图中文名");
            arrColName.Add("ViewTypeName"); arrCnName.Add("界面类型名称");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("MainTabName"); arrCnName.Add("MainTabName");
            arrColName.Add("DetailTabName"); arrCnName.Add("DetailTabName");
            arrColName.Add("TitleStyleName"); arrCnName.Add("标题类型名");
            arrColName.Add("DGStyleName"); arrCnName.Add("DG模式名");
            arrColName.Add("ViewTypeCode"); arrCnName.Add("界面类型码");
            arrColName.Add("DataBaseName"); arrCnName.Add("数据库名");
            arrColName.Add("KeyForMainTab"); arrCnName.Add("主表关键字");
            arrColName.Add("KeyForDetailTab"); arrCnName.Add("明细表关键字");
            arrColName.Add("IsNeedSort"); arrCnName.Add("是否需要排序");
            arrColName.Add("IsNeedTransCode"); arrCnName.Add("是否需要转换代码");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("ViewFunction"); arrCnName.Add("界面功能");
            arrColName.Add("ViewDetail"); arrCnName.Add("界面说明");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("FuncModuleAgcId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FileName"); arrCnName.Add("文件名");
            arrColName.Add("FilePath"); arrCnName.Add("文件路径");
            arrColName.Add("DefaMenuName"); arrCnName.Add("缺省菜单名");
            arrColName.Add("MainTabId"); arrCnName.Add("主表ID");
            arrColName.Add("DetailTabId"); arrCnName.Add("明细表ID");
            arrColName.Add("ApplicationTypeId"); arrCnName.Add("应用程序类型ID");
            arrColName.Add("ViewGroupId"); arrCnName.Add("界面组ID");
            arrColName.Add("MainTabKeyFld"); arrCnName.Add("MainTabKeyFld");
            arrColName.Add("DetailTabKeyFld"); arrCnName.Add("DetailTabKeyFld");
            arrColName.Add("FuncModuleEnName"); arrCnName.Add("功能模块英文名称");
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
            objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
            MessageBox.Show("导出Excel成功!，文件存放在：" + strDownLoadFileName);
        }
        /// <summary>
        /// 导出EXCEL的函数, 导出EXCEL时可以选择列
        /// </summary>
        private void ExportExcel_SelColumns()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombineViewInfoCondion();
            //	2、设置表列数据字段名，以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("ViewId"); arrCnName.Add("界面ID");
            arrColName.Add("ApplicationTypeName"); arrCnName.Add("应用程序类型名称");
            arrColName.Add("ViewGroupName"); arrCnName.Add("界面组名称");
            arrColName.Add("ViewName"); arrCnName.Add("界面名称");
            arrColName.Add("ViewCnName"); arrCnName.Add("视图中文名");
            arrColName.Add("ViewTypeName"); arrCnName.Add("界面类型名称");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("MainTabName"); arrCnName.Add("MainTabName");
            arrColName.Add("DetailTabName"); arrCnName.Add("DetailTabName");
            arrColName.Add("TitleStyleName"); arrCnName.Add("标题类型名");
            arrColName.Add("DGStyleName"); arrCnName.Add("DG模式名");
            arrColName.Add("ViewTypeCode"); arrCnName.Add("界面类型码");
            arrColName.Add("DataBaseName"); arrCnName.Add("数据库名");
            arrColName.Add("KeyForMainTab"); arrCnName.Add("主表关键字");
            arrColName.Add("KeyForDetailTab"); arrCnName.Add("明细表关键字");
            arrColName.Add("IsNeedSort"); arrCnName.Add("是否需要排序");
            arrColName.Add("IsNeedTransCode"); arrCnName.Add("是否需要转换代码");
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("ViewFunction"); arrCnName.Add("界面功能");
            arrColName.Add("ViewDetail"); arrCnName.Add("界面说明");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("FuncModuleAgcId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FileName"); arrCnName.Add("文件名");
            arrColName.Add("FilePath"); arrCnName.Add("文件路径");
            arrColName.Add("DefaMenuName"); arrCnName.Add("缺省菜单名");
            arrColName.Add("MainTabId"); arrCnName.Add("主表ID");
            arrColName.Add("DetailTabId"); arrCnName.Add("明细表ID");
            arrColName.Add("ApplicationTypeId"); arrCnName.Add("应用程序类型ID");
            arrColName.Add("ViewGroupId"); arrCnName.Add("界面组ID");
            arrColName.Add("MainTabKeyFld"); arrCnName.Add("MainTabKeyFld");
            arrColName.Add("DetailTabKeyFld"); arrCnName.Add("DetailTabKeyFld");
            arrColName.Add("FuncModuleEnName"); arrCnName.Add("功能模块英文名称");
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
            frm1.strTableName = "vViewInfo";
            frm1.strTableChineseName = "vViewInfo";
            frm1.strViewName = "界面信息维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvViewInfo_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvViewInfoSorter.SortColumn)
            {

            }
            else
            {
                this.objvViewInfoSorter.SortColumn = e.Column;
            }

            if (this.objvViewInfoSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvViewInfoSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvViewInfoColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvViewInfoColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text = this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvViewInfoColumIndex = e.Column;
                }
            }
            else if (this.objvViewInfoSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvViewInfoSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvViewInfoColumIndex == e.Column)
                {
                    this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvViewInfoColumIndex = e.Column;
                }
                else
                {
                    this.lvvViewInfo.Columns[e.Column].Text = this.lvvViewInfo.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text = this.lvvViewInfo.Columns[intLastSelectedvViewInfoColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvViewInfoColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvViewInfo.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vViewInfo();
        }

        ///删除记录过程代码for C#
        private void DeleteViewInfoRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvViewInfo.SelectedItems)
                {
                    string strViewId = GetCurrKey(lvi);
                    if (clsViewInfoWApi.DelRecord(strViewId) == 0)
                    {
                        MessageBox.Show("删除记录失败！");
                        BindLv_vViewInfo();
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vViewInfo();
            }
        }

        private AGC4WApi.enumViewTypeCodeTab GetViewTypeCodeStr()
        {
            //int intMenuIndex = int.Parse(e.Item.Value);
            //switch (intMenuIndex)
            //{
            //    case 0://单表的QUDI_LV,0008
            //        new clsCommonSession().ViewTypeCode = "0008";
            //        break;
            //    case 1://单表组合界面_ListView,0011
            //        new clsCommonSession().ViewTypeCode = "0011";
            //        break;
            //    case 2://单表组合界面_GridView,0020
            //        new clsCommonSession().ViewTypeCode = "0020";
            //        break;
            //    case 3://单表插入,0012
            //        new clsCommonSession().ViewTypeCode = "0012";
            //        break;
            //    case 4://单表查询,
            //        new clsCommonSession().ViewTypeCode = "0008";
            //        break;
            //}
            AGC4WApi.enumViewTypeCodeTab strViewTypeCode = AGC4WApi.enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;// "0011";
            //if (rbViewTypeCode01.Checked == true)
            //{
            //    //单表的QUDI_LV,0008
            //    strViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_ListView;// "0008";
            //}
            if (rbViewTypeCode02.Checked == true)
            {
                //单表组合界面_ListView,0011
                strViewTypeCode = AGC4WApi.enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;// "0011";
            }
            else if (rbViewTypeCode03.Checked == true)
            {
                //单表组合界面_GridView,0020
                strViewTypeCode = AGC4WApi.enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20;// "0020";
            }
            else if (rbViewTypeCode04.Checked == true)
            {
                //单表插入,0012
                strViewTypeCode = AGC4WApi.enumViewTypeCodeTab.Table_Insert_1;// "0012";
            }
            else if (rbViewTypeCode05.Checked == true)
            {
                //单表查询
                strViewTypeCode = AGC4WApi.enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11;// "0008";
            }
            return strViewTypeCode;
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
        private void ShowCodeTypeButton(int intViewTypeCode = 0)
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
            var objProgLangType = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objApplicationTypeEN.ProgLangTypeId);
            string strCharEncodingId = objProgLangType.CharEncodingId;
            cboCharEncodingId.SelectedValue = strCharEncodingId;

            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaExWApi.GetObjExLstByApplicationTypeId(intAppTypeId);
            arrObjLst.ForEach(x =>
            {
                string strGroupName1 = x.GroupName;
                string[] arrGroupName = strGroupName1.Split(",".ToCharArray());
                x.GroupName = arrGroupName[0];
            });
            List<clsvAppCodeTypeRelaENEx> arrObjLst_Sel = null;
            if (intViewTypeCode > 0)
            {
                arrObjLst_Sel = arrObjLst.Where(x => x.ViewTypeCode == intViewTypeCode)
                    .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                    .ToList();
            }
            else
            {
                //clsViewTypeCodeTabExWApi.BindCbo_ViewTypeCodeByAppIdCache(cboCmPrjId, intAppTypeId);
                if (clsViewTypeCodeTabExWApi.arrViewTypeCodeTabObjLst == null)
                {
                    arrObjLst_Sel = arrObjLst
                        .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                        .ToList();
                }
                else if (clsViewTypeCodeTabExWApi.arrViewTypeCodeTabObjLst.Count == 1)
                {
                    arrObjLst_Sel = arrObjLst
                       .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                       .ToList();
                }
                else if (clsViewTypeCodeTabExWApi.arrViewTypeCodeTabObjLst.Count > 1)
                {
                    arrObjLst_Sel = arrObjLst.Where(x => x.ViewTypeCode == clsViewTypeCodeTabExWApi.arrViewTypeCodeTabObjLst[1].ViewTypeCode)
                        .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                        .ToList();
                }
            }


            int intCount = 0;
            string strGroupName = "";
            foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_Sel)
            {
                if (objInFor.DependsOn != "View") continue;

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
                    //if (string.IsNullOrEmpty(strGroupName) == false)
                    //{
                    //    objFLP.SetFlowBreak(objLabel, true);
                    //}
                    objFLP.Controls.Add(objLabel);
                    strGroupName = objInFor.GroupName;
                }

                // Create the ToolTip and associate with the Form container.
                ToolTip toolTip1 = new ToolTip();

                // Set up the delays for the ToolTip.
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;
                // Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = true;

                // Set up the ToolTip text for the Button and Checkbox.


                Button objButton = new Button();
                objButton.Text = string.Format("{0}({1})",
                    objInFor.CodeTypeSimName, objInFor.ProgLangTypeName);
                objButton.AutoSize = true;
                objButton.Name = string.Format("btn{0}", objInFor.CodeTypeId);
                objButton.Font = new Font("宋体", 10f, FontStyle.Regular);
                if (objInFor.IsInGroupGeneCode == false)
                {
                    objButton.ForeColor = Color.Gray;
                }
                string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName,
                    objInFor.CodeTypeId, objInFor.ProgLangTypeId);
                toolTip1.SetToolTip(objButton, strToolTip);

                objButton.Click += btnCodeType_Click;

                objFLP.SetFlowBreak(objButton, false);

                objFLP.Controls.Add(objButton);
                intCount++;
            }
            if (intCount == 0)
            {
                string strMsg = string.Format("应用:{0}({1})没有用于[View]相应的代码类型.",
                    objApplicationTypeEN.ApplicationTypeName, objApplicationTypeEN.ApplicationTypeId);
                MessageBox.Show(strMsg);
                return;
            }
            try
            {
                BindLv_vViewInfo();
                bolIsBindData = true;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
        }

        private List<string> GetSelectedViewId()
        {
            List<string> arrViewIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvViewInfo.SelectedItems)
            {
                string strViewId = GetCurrKey(lvi);
                arrViewIdLst.Add(strViewId);
            }
            if (arrViewIdLst.Count == 1)
            {
                mstrCurrViewId = arrViewIdLst[0];
            }
            if (arrViewIdLst.Count == 0)
            {
                if (string.IsNullOrEmpty(mstrCurrViewId) == false)
                {
                    arrViewIdLst.Add(mstrCurrViewId);
                }
                else
                {
                    lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                    MessageBox.Show(lblMsg.Text);
                    return null;
                }
            }
            return arrViewIdLst;
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
            string strMachineName = Environment.MachineName;

            Button objButton = sender as Button;
            string strCodeTypeId = objButton.Name.Substring(3);
            //           MessageBox.Show(strCodeTypeId);

            List<string> arrViewIdLst = GetSelectedViewId();
            if (arrViewIdLst == null)
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

            int intCount = 0;
            //string strCodeText = "";
            lblMsg.Text = "";

            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            clsvCodeType_SimEN objCodeTypeEN = clsvCodeType_SimWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WA_Access;
            string strTabId = "";
            clsGCResult objGCResult = null;
            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            string strClassFName = "";
            int intApplicationTypeId = getAppTypeId();
            if (cboCmPrjId.SelectedValue == null )
            {
                MessageBox.Show("请选择一个CM工程！");
                cboCmPrjId.Focus();
                return;
            }

            string strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            if (string.IsNullOrEmpty(strCmPrjId) == true || strCmPrjId == "0")
            {
                MessageBox.Show("请选择一个CM工程！");
                cboCmPrjId.Focus();
                return;
            }
            long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);
            string strUserCodePrjMainPathId = "";
            try
            {
                var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                strUserCodePrjMainPathId = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            string strIsShare = "";
            foreach (string strViewId in arrViewIdLst)
            {
                try
                {
                    clsvUserCodePathENEx objUserCodePathENEx = clsvUserCodePathExWApi.GetObjByClassName(lngCMProjectAppRelaId, strCodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                    clsPubFun.AccessIsExistPath(objUserCodePathENEx);

                    clsViewInfoEN objViewInfo = clsViewInfoWApi.GetObjByViewId(strViewId);
                    strIsShare = "";
                    if (objViewInfo.IsShare) strIsShare = "Share";

                    //strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, typeParas,
                    //    ltLangType, mdbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                    //  intApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
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
                        typeParas = ""
                    };

                    objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
                    if (objGCResult.errorId != 0)
                    {
                        if (objGCResult.errorMsg.IndexOf("不需要生成代码") >=0)
                        {
                            continue;
                        }
                        strMsg = string.Format("在生成界面:[{0}]的[{1}]类时， 出现错误:{2}，请检查！\r\n(In {3})",
                            objViewInfo.ViewName,
                            objCodeTypeEN.CodeTypeENName,
                            objGCResult.errorMsg,
                            clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    if (string.IsNullOrEmpty(objGCResult.codeText) == true && objGCResult.errorId == 0) continue;

                    if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                    {
                        strMsg = string.Format("在生成界面:[{0}]的[{1}]类时， 带模块名的文件名为空，请检查！({2})",
                            objViewInfo.ViewName,
                            objCodeTypeEN.CodeTypeENName, clsStackTrace.GetCurrClassFunction());
                        MessageBox.Show(strMsg);
                        return;
                    }
                    objGCResult.re_FileNameWithModuleName = InsertSuffixPath(objGCResult.re_FileNameWithModuleName, objUserCodePathENEx.SuffixPath);
                    if (objUserCodePathENEx.NewCodePath.IndexOf("viewsBase",StringComparison.CurrentCultureIgnoreCase) > -1)
                    {
                        strClassFName = $"{objUserCodePathENEx.NewCodePath}\\{objGCResult.re_FileNameWithModuleName}";
                    }
                    else
                    {
                     
                        if (objUserCodePathENEx.NewCodePath.EndsWith("\\")) objUserCodePathENEx.NewCodePath = objUserCodePathENEx.NewCodePath.TrimEnd('\\');
                        strClassFName = $"{objUserCodePathENEx.NewCodePath}{strIsShare}\\{objGCResult.re_FileNameWithModuleName}";
                    }
                    
                    if (objCodeTypeEN.IsDefaultOverride == true)
                    {
                        clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                            objUserCodePathENEx.NewCodePath,
                            objUserCodePathENEx.NewCodePathBackup, myEncoding);
                    }
                    else
                    {
                        //string strClassFName, string strClassContent, string strFolderName_Root, Encoding myEncoding)
                        var c = clsPubFun4WApi.SaveClassContentToFile_NoCover4View(objUserCodePathENEx.FolderName_Root, strClassFName, objGCResult.codeText, objCodeTypeEN,
                             myEncoding);
                    }

                    //clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0010", clsPubVar.CurrSelPrjId);

                    //strCodeText = clsPrjTabExWApi.GenWS_Access(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                    //    clsSysParaEN.strUserId,
                    //     clsSysParaEN.strUserName, objUserCodePathEN.NewCodePath, objUserCodePathEN.NewCodePathBackup,
                    //     strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            if (objGCResult == null)
            {
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
            tabViewInfoListCode.SelectedIndex = 1;//.TabPages[1].Focus();
            if (intCount != 1)
            {
                MessageBox.Show("生成界面完成！共计：" + intCount.ToString() + "个表。");
            }
            BindLv_vViewInfo();
            SetStatus();
        }

        private void tabAppType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCodeTypeButton();
            tabViewInfoListCode.SelectedIndex = 0;


            int intApplicationTypeId = getAppTypeId();
            clsCMProjectExWApi.BindCbo_CmPrjIdEx0(this.cboCmPrjId, clsPubVar.CurrSelPrjId, intApplicationTypeId, clsSysParaEN.strUserId);
            SetStatus();
        }


        /// <summary>
        /// 当前所选择的类型参数：可有：界面类型、类型其他参数等
        /// </summary>
        protected string typeParas
        {
            get
            {
                string strTypeParas = "";
                //if (cboAppPageTypeId.SelectedIndex > 0)
                //{
                //    string strAppPageTypeId = cboAppPageTypeId.SelectedValue.ToString();
                //    clsAppPageTypeEN objAppPageTypeEN = clsAppPageTypeWApi.GetObjByAppPageTypeId(strAppPageTypeId);
                //    strTypeParas = strTypeParas + string.Format("{0}|",
                //        objAppPageTypeEN.AppPageTypeENName);
                //    return strTypeParas;
                //}
                return strTypeParas;
            }
        }

        private void btnGeneCheckedViewCode_Click(object sender, EventArgs e)
        {
            string strMsg = "";
            strMsg = string.Format("strCurrIPAddressAndPort={0}, strCurrPrx={1}.(In {2})",
     clsSysPara4WebApi_Agc.strCurrIPAddressAndPort, clsSysPara4WebApi_Agc.strCurrPrx, clsStackTrace.GetCurrClassFunction());
            clsPubVar.objLog.WriteDebugLog(strMsg);

            if (clsPubFun.CheckWebApi() == false)
            {
                strMsg = string.Format("当前用于生成代码的WebApi不可用，请到菜单：[系统设置->WebService设置]中重新设置WebApi地址！");
                MessageBox.Show(strMsg);
                return;
            }
            string strMachineName = Environment.MachineName;

            lblMsg.Text = "";

            List<string> arrViewIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvViewInfo.SelectedItems)
            {
                string strViewId = GetCurrKey(lvi);
                arrViewIdLst.Add(strViewId);
            }

            if (arrViewIdLst.Count == 0)
            {
                lblMsg.Text = "当前工程中没有记录，请选择一个有效的工程!";
                return;
            }

            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }
            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();
            //string strCodeTypeId = "0000";
            //保存当前选择的字符编码
            //clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount_View = 0;
            int intCount_Tab = 0;
            //string strCodeText = "";
            int intApplicationTypeId = getAppTypeId();

            List<string> arrCMPrjId = clsCMProjectAppRelaExWApi.getCmPrjIdLstByAppTypeId(intApplicationTypeId, clsPubVar.CurrSelPrjId);


            var strCmPrjId = "";

            if (arrCMPrjId.Count > 1)
            {
                if (cboCmPrjId.SelectedIndex <= 0)
                {
                    MessageBox.Show("请选择一个CM工程！");
                    cboCmPrjId.Focus();
                    return;
                }
                strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            }
            else
            {
                if (cboCmPrjId.SelectedValue == null) strCmPrjId = "";
                else strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            }
            if (string.IsNullOrEmpty(strCmPrjId) == true || strCmPrjId == "0")
            {
                MessageBox.Show("请选择一个CM工程！");
                cboCmPrjId.Focus();
                return;
            }

            long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);

            //string strRe_ClsName = "";
            //string strRe_FileNameWithModuleName = "";
            Encoding myEncoding = clsString.GetEncodingObjByCharEncodingId(strCharEncodingId);
            //clsPubConst.ClassName cnClassName = clsPubConst.ClassName.EntityLayer;
            List<string> arrErrorLst = new List<string>();
            List<string> arrWarnningLst = new List<string>();

            List<clsvCodeType_SimEN> arrCodeTypeObjLst_View = clsCodeTypeExWApi.GetCodeTypeObjLstByApplicationType4Front4Web(intApplicationTypeId);
            List<string> arrTabId4Rela = new List<string>();
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            StringBuilder sbLog4GeneFile = new StringBuilder();
            sbLog4GeneFile.AppendFormat("生成日期：{0}(当前工程Id:{1}, 用户：{2})\r\n",
                strCurrDate, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = null;
            clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName = null;
            try
            {
                objUserCodePrjMainPathEN
                      = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName, clsPubVar.CurrSelPrjId);
                string strGCMainPathId = "";
                objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(objUserCodePrjMainPathEN.UserCodePrjMainPathId, Environment.MachineName, clsPubVar.CurrSelPrjId);
                if (objUserCodePrjMainPath_MachineName != null)
                {
                    strGCMainPathId = objUserCodePrjMainPath_MachineName.GcPathId;
                }
                if (string.IsNullOrEmpty(strGCMainPathId) == true)
                {
                    var objCmCMProjectAppRela = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(objUserCodePrjMainPathEN.CMProjectAppRelaId,
                        clsPubVar.CurrSelPrjId);
                    var objCMProject = clsCMProjectWApi.GetObjByCmPrjIdCache(objCmCMProjectAppRela.CmPrjId);
                    var objAppType = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(objCmCMProjectAppRela.ApplicationTypeId);
                    var strMsg1 = string.Format("生成主目录的GC路径为空，请检查！CM项目:{0},应用:{1},请联系管理员。",
                        objCMProject.CmPrjName, objAppType.ApplicationTypeName);
                    var strKeyId = clsGCPathExWApi.AddGCPath4Main(objUserCodePrjMainPath_MachineName.CodePath, objUserCodePrjMainPathEN.PrjId, objUserCodePrjMainPathEN.UserId);
                    if (string.IsNullOrEmpty(strKeyId) == false)
                    {
                        objUserCodePrjMainPath_MachineName.GcPathId = strKeyId;
                        objUserCodePrjMainPath_MachineName.Update();
                    }
                    //MessageBox.Show(strMsg);
                }
                //clsPubFun.AccessIsExistPath(objUserCodePrjMainPathEx);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            int intFileCount = 0;
            string strIsShare = "";
            foreach (string strViewId in arrViewIdLst)
            {
                clsViewInfoEN objViewInfoEN = clsViewInfoWApi.GetObjByViewIdCache(strViewId, clsPubVar.CurrSelPrjId);
                sbLog4GeneFile.AppendFormat("针对界面:{0}({1},{2})\r\n", objViewInfoEN.ViewId, objViewInfoEN.ViewName,
                    objViewInfoEN.ViewCnName);
                strIsShare = "";
                if (objViewInfoEN.IsShare) strIsShare = "Share";
                string strTabId = "";
                List<string> arrTabId4Ddl = clsViewInfoExWApi.getRelaTabId4Ddl(strViewId, strCmPrjId, objViewInfoEN.PrjId);
                if (arrTabId4Ddl.Count > 0)
                {
                    sbLog4GeneFile.AppendFormat("界面:{0}({1},{2})有下拉框绑定相关表如下(表数:{3}):\r\n",
                        objViewInfoEN.ViewId, objViewInfoEN.ViewName,
                      objViewInfoEN.ViewCnName,
                      arrTabId4Ddl.Count);
                }
                int intIndex = 1;
                foreach (string strTabId_in in arrTabId4Ddl)
                {
                    if (arrTabId4Rela.Contains(strTabId_in) == false)
                    {
                        arrTabId4Rela.Add(strTabId_in);
                    }
                    clsvPrjTab_SimEN objPrjTabEN = clsPrjTabExWApi.GetObjByTabId_CacheExBak(strTabId_in, clsPubVar.CurrSelPrjId);
                    sbLog4GeneFile.AppendFormat("{2}、表:{0}({1})\r\n",
                        objPrjTabEN.TabId, objPrjTabEN.TabName, intIndex);
                }
                List<string> arrTabId_InOut = clsViewInfoExWApi.getRelaTabId4InOut(strViewId, clsPubVar.CurrSelPrjId);
                if (arrTabId_InOut.Count > 0)
                {
                    sbLog4GeneFile.AppendFormat("界面:{0}({1},{2})有输入、输出相关表如下(表数:{3}):\r\n",
                        objViewInfoEN.ViewId, objViewInfoEN.ViewName,
                      objViewInfoEN.ViewCnName,
                      arrTabId_InOut.Count);
                }
                intIndex = 1;
                foreach (string strTabId_in in arrTabId_InOut)
                {
                    if (arrTabId4Rela.Contains(strTabId_in) == false)
                    {
                        arrTabId4Rela.Add(strTabId_in);
                    }
                    clsvPrjTab_SimEN objPrjTabEN = clsvPrjTab_SimWApi.GetObjByTabIdCache(strTabId_in, strCmPrjId);
                    sbLog4GeneFile.AppendFormat("{2}、表:{0}({1})\r\n",
                        objPrjTabEN.TabId, objPrjTabEN.TabName, intIndex);
                }
                clsvUserCodePathENEx objUserCodePathENEx = null;
                foreach (clsvCodeType_SimEN objCodeTypeEN in arrCodeTypeObjLst_View)
                {
                    try
                    {
                        if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeENName) == true) continue;
                        if (objCodeTypeEN.DependsOn != "View") continue;
                        clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                        clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

                        //cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                        objUserCodePathENEx = clsvUserCodePathExWApi.GetObjByClassName(objUserCodePrjMainPathEN.CMProjectAppRelaId, objCodeTypeEN.CodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                        clsPubFun.AccessIsExistPath(objUserCodePathENEx);
                        //if (objViewInfoEN.IsShare)
                        //{
                        //    objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("views", "viewsShare");
                        //    objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("views", "viewsShare");
                        //    objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("viewsShareShare", "viewsShare");
                        //    objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("viewsShareShare", "viewsShare");
                        //    objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("viewsShareBase", "viewsBase");
                        //    objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("viewsShareBase", "viewsBase");
                        //}
                        //else
                        //{
                        //    objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("viewsShare", "views");
                        //    objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("viewsShare", "views");
                        //    objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("viewsShareShare", "views");
                        //    objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("viewsShareShare", "views");
                        //    objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("viewsShareBase", "viewsBase");
                        //    objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("viewsShareBase", "viewsBase");
                        //}
                        //strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, mstrTypeParas,
                        //       ltLangType, mdbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                        //    intApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
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
                            cmPrjId = objUserCodePrjMainPathEN.CmPrjId(),
                            typeParas = ""
                        };

                        clsGCResult objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
                        strVersion = objGCResult.version;
                        intFileCount++;
                        intCount_View++;
                        objGCResult.re_FileNameWithModuleName = InsertSuffixPath(objGCResult.re_FileNameWithModuleName, objUserCodePathENEx.SuffixPath);
                        if (string.IsNullOrEmpty(objGCResult.codeText) == false)
                        {
                            string strClassFName = "";
                            if (objUserCodePathENEx.NewCodePath.IndexOf("viewsBase", StringComparison.CurrentCultureIgnoreCase) > -1)
                            {
                                strClassFName = $"{objUserCodePathENEx.NewCodePath}\\{objGCResult.re_FileNameWithModuleName}";
                            }
                            else
                            {
                                if (objUserCodePathENEx.NewCodePath.EndsWith("\\")) objUserCodePathENEx.NewCodePath = objUserCodePathENEx.NewCodePath.TrimEnd('\\');
                                strClassFName = $"{objUserCodePathENEx.NewCodePath}{strIsShare}\\{objGCResult.re_FileNameWithModuleName}";
                            }
                            if (string.IsNullOrEmpty(objGCResult.re_FileNameWithModuleName) == true)
                            {
                                //string ss = "";
                                strMsg = string.Format("错误：生成文件名为空。界面:[{0}({1})]的代码类型:[{2}]时.(In {3})",

                               objViewInfoEN.ViewName, objViewInfoEN.ViewId,
                               objCodeTypeEN.CodeTypeName,
                               clsStackTrace.GetCurrClassFunction());
                                arrErrorLst.Add(strMsg);
                            }
                            else
                            {
                                if (objCodeTypeEN.IsDefaultOverride == true)
                                {
                                    clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                                        objUserCodePathENEx.NewCodePath,
                                        objUserCodePathENEx.NewCodePathBackup, myEncoding);
                                }
                                else
                                {
                                    strClassFName = strClassFName.Replace("\\\\", "\\");
                                    var c = clsPubFun4WApi.SaveClassContentToFile_NoCover4View(objUserCodePathENEx.FolderName_Root, strClassFName, objGCResult.codeText, objCodeTypeEN,
                                        myEncoding);
                                    if (c.Item1 == false)
                                    {
                                        strMsg = string.Format("警告:保存不可覆盖的文件时, {1}. \r\n文件名:{0}. ", strClassFName, c.Item2);
                                        //intWarnningCount++;
                                        arrWarnningLst.Add(strMsg);
                                    }
                                    //sbLog4GeneFile.AppendFormat("源文件已存在，不能覆盖:{0}\\{1}.\r\n", objUserCodePathEN.NewCodePath, strRe_FileNameWithModuleName);
                                }
                            }
                        }
                    }
                    catch (Exception objException)
                    {
                        if (objException.Message.IndexOf("不需要生成文件。") >= 0)
                        {
                            continue;
                        }
                        arrErrorLst.Add(objException.Message);
                        strMsg = string.Format("错误：{0}生成界面:[{4}({5})]的代码类型:[{6}]时.({1}->{2}->{3})",
                              objException.Message,
                              clsStackTrace.GetCurrClassFunctionByLevel(3),
                              clsStackTrace.GetCurrClassFunctionByLevel(2),
                              clsStackTrace.GetCurrClassFunction(),
                              objViewInfoEN.ViewName, objViewInfoEN.ViewId,
                              objCodeTypeEN.CodeTypeName);

                        sbLog4GeneFile.AppendFormat("{0}\r\n", strMsg);
                        //lblMsg.Text = objException.Message;
                        //MessageBox.Show(objException.Message);
                        //ErrorInformationWApi.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                        //return;
                    }
                }
                try
                {
                    if (string.IsNullOrEmpty(strVersion)) strVersion = "null";
                    clsLog4GeneViewCodeExWApi.AddLog4GeneViewCode(strViewId, clsSysParaEN.strUserId, strVersion);
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                    return;
                }
            }
            arrTabId4Rela = arrTabId4Rela.Distinct().ToList();
            string strCondition2 = string.Format("{0}={1}", conFrontAndBack4AppType.AppTypeId4Front, intApplicationTypeId);
            List<clsFrontAndBack4AppTypeEN> arrFrontAndBack4AppTypeEN = clsFrontAndBack4AppTypeWApi.GetObjLst(strCondition2);
            foreach (clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN in arrFrontAndBack4AppTypeEN)
            {
                try
                {

                    long lngCMProjectAppRelaId4Back = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, objFrontAndBack4AppTypeEN.AppTypeId4Back, clsPubVar.CurrSelPrjId);

                    objUserCodePrjMainPathEN
                          = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId4Back, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                    //clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPathEN, strMachineName);
                    //clsPubFun.AccessIsExistPath(objUserCodePrjMainPathEx);
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                    return;
                }
                List<clsvCodeType_SimEN> arrCodeTypeObjList_table = clsCodeTypeExWApi.GetCodeTypeObjLstByApplicationType4Back(objFrontAndBack4AppTypeEN.AppTypeId4Back, enumTabMainTypeWA.DataTab_0001);

                foreach (string strTabId_In in arrTabId4Rela)
                {
                    clsvPrjTab_SimEN objPrjTabEN = clsvPrjTab_SimWApi.GetObjByTabIdCache(strTabId_In, clsPubVar.CmPrjId);
                    sbLog4GeneFile.AppendFormat("针对表:{0}({1})\r\n", objPrjTabEN.TabId, objPrjTabEN.TabName);

                    string strViewId = "";
                    clsvUserCodePathEN objUserCodePathEN = null;
                    foreach (clsvCodeType_SimEN objCodeTypeEN in arrCodeTypeObjList_table)
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeENName) == true) continue;
                            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeIdCache(objCodeTypeEN.ProgLangTypeId);
                            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

                            //cnClassName = clsPubConst.GetClassNameByString(objCodeTypeEN.CodeTypeENName);
                            objUserCodePathEN = clsvUserCodePathExWApi.GetObjByClassName(objUserCodePrjMainPathEN.CMProjectAppRelaId, objCodeTypeEN.CodeTypeId, clsPubVar.CurrSelPrjId, strCmPrjId, clsSysParaEN.strUserId, strMachineName);
                            if (objUserCodePathEN.IsGeneCode == false) continue;
                            clsPubFun.AccessIsExistPath(objUserCodePathEN);

                            //strCodeText = clsAutoGeneCodeWS.GeneCode(objCodeTypeEN.CodeTypeENName, mstrTypeParas,
                            //       ltLangType, mdbtDataBaseType, strTabId_In, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
                            //      intApplicationTypeId, clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);
                            clsGCPara objGCPara = new clsGCPara()
                            {
                                applicationTypeId = intApplicationTypeId,
                                codeTypeId = objCodeTypeEN.CodeTypeId,
                                dataBaseType = clsPubConst.GetDataBaseTypeStrByDataBaseType(mdbtDataBaseType),
                                tabId = strTabId_In,
                                viewId = strViewId,
                                gcUserId = clsSysParaEN.strUserId,
                                prjDataBaseId = clsPubVar.CurrPrjDataBaseId,
                                prjId = clsPubVar.CurrSelPrjId,
                                typeParas = ""
                            };

                            clsGCResult objGCResult = AutoGeneCodeWApi.GeneCode(objGCPara);
                            strVersion = objGCResult.version;
                            if (string.IsNullOrEmpty(objGCResult.codeText) == true) continue;
                            intFileCount++;
                            objGCResult.re_FileNameWithModuleName = InsertSuffixPath(objGCResult.re_FileNameWithModuleName, objUserCodePathEN.SuffixPath);

                            string strClassFName = string.Format("{0}\\{1}",
                                objUserCodePathEN.NewCodePath,
                                objGCResult.re_FileNameWithModuleName);
                            if (objCodeTypeEN.IsDefaultOverride == true)
                            {
                                clsPubFun4WApi.SaveClassContentToFile(strClassFName, objGCResult.codeText,
                                    objUserCodePathEN.NewCodePath,
                                    objUserCodePathEN.NewCodePathBackup, myEncoding);
                                sbLog4GeneFile.AppendFormat("覆盖:{0}\\{1}\r\n", objUserCodePathEN.NewCodePath, objGCResult.re_FileNameWithModuleName);
                            }
                            else
                            {
                                try
                                {
                                    var c = clsPubFun4WApi.SaveClassContentToFile_NoCover(strClassFName, objGCResult.codeText,
                                        objUserCodePathEN.NewCodePath, objCodeTypeEN, myEncoding);
                                    sbLog4GeneFile.AppendFormat("源文件不存在，不能覆盖:{0}\\{1}.\r\n", objUserCodePathEN.NewCodePath,
                                        objGCResult.re_FileNameWithModuleName);
                                }
                                catch (Exception objException)
                                {
                                    Console.WriteLine(objException);
                                    sbLog4GeneFile.AppendFormat("源文件已存在，不能覆盖:{0}\\{1}.\r\n", objUserCodePathEN.NewCodePath,
                                        objGCResult.re_FileNameWithModuleName);
                                }
                            }
                            intCount_Tab++;

                        }
                        catch (Exception objException)
                        {
                            if (objException.Message.IndexOf("不需要生成文件。") >= 0)
                            {
                                continue;
                            }
                            strMsg = string.Format("错误：{0}生成表:[{4}({5})]时.({1}->{2}->{3})",
                                objException.Message,
                                clsStackTrace.GetCurrClassFunctionByLevel(3),
                                clsStackTrace.GetCurrClassFunctionByLevel(2),
                                clsStackTrace.GetCurrClassFunction(),
                                objPrjTabEN.TabName, objPrjTabEN.TabId);
                            sbLog4GeneFile.AppendFormat("{0}.\r\n", strMsg);
                            arrErrorLst.Add(objException.Message);
                            //lblMsg.Text = objException.Message;
                            //MessageBox.Show(objException.Message);
                            //ErrorInformationWApi.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                            //return;
                        }
                    }
                    clsLog4GeneTabCodeExWApi.AddLog4GeneTabCode(strTabId_In, strCmPrjId, objFrontAndBack4AppTypeEN.AppTypeId4Back, clsSysParaEN.strUserId, strVersion);

                }
            }
            sbLog4GeneFile.AppendFormat("共计生成文件数:{0}(共计：{1}个界面文件, {2}个表文件)(界面数:{3}, 相关表数:{4}).\r\n",
                    intFileCount, intCount_View, intCount_Tab, arrViewIdLst.Count, arrTabId4Rela.Count);
            string strLogFName = string.Format("{0}\\{1}{2}.log",
                       objUserCodePrjMainPath_MachineName.CodePath,
                       objUserCodePrjMainPath_MachineName.LogPath,
                       strCurrDate);
            clsPubFun4WApi.WriteLogFile(strLogFName, sbLog4GeneFile.ToString(), myEncoding);

            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成界面完成！共计：{0}个界面, {1}个表。\r\n日志文件:[{2}]\r\n", intCount_View, intCount_Tab, strLogFName);
            foreach (string strMsg1 in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg1);
            }
            sbMsg.AppendLine(string.Format("\r\n \r\n警告日志信息:{0}条:", arrWarnningLst.Count));

            if (arrWarnningLst != null)
            {
                arrWarnningLst.ForEach(x => { sbMsg.AppendLine("\r\n" + x); });
            }
            MessageBox.Show(sbMsg.ToString());
            BindLv_vViewInfo();
        }

        private void cboViewTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (clsViewTypeCodeTabExWApi.bolIsSelectIndexAfterBindCbo == true)
            //{
            //    clsViewTypeCodeTabExWApi.bolIsSelectIndexAfterBindCbo = false;
            //    return;
            //}
            //if (cboCmPrjId.SelectedIndex <= 0) return;
            //int intViewTypeCode = int.Parse(cboCmPrjId.SelectedValue.ToString());
            //ShowCodeTypeButton(intViewTypeCode);
            //BindLv_vViewInfo();
       
        }

        private void cboCmPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCmPrjId.SelectedIndex == 0) return;

            if (cboCmPrjId.SelectedValue == null) return;
            string strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            clsvPrjTab_SimExWApi.BindCbo_TabIdCacheEx(this.cboMainTabId, strCmPrjId);
            SetStatus();
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
            if (cboCmPrjId.SelectedValue == null) return;
            string strMachineName = Environment.MachineName;
            int intApplicationTypeId = getAppTypeId();
            string strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(strCmPrjId, intApplicationTypeId, clsPubVar.CurrSelPrjId);
            //string strUserCodePrjMainPathId = "";
            string strCmPrjName = "";
            try
            {
                clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId);

                var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                strCmPrjName = clsCMProjectWApi.GetNameByCmPrjIdCache(objUserCodePrjMainPath.CmPrjId());
                clsUserCodePrjMainPathENEx objUserCodePrjMainPathEx = clsUserCodePrjMainPathExWApi.CopyToExByMachineName(objUserCodePrjMainPath, strMachineName, clsPubVar.CurrSelPrjId);
                if (objUserCodePrjMainPathEx.CodePath == "")
                {
                    string strAppName = clsApplicationTypeWApi.GetNameByApplicationTypeIdCache(objUserCodePrjMainPathEx.ApplicationTypeId());

                    string strErrMsg = $"Cm工程:{strCmPrjName}, 应用:{strAppName}在机器:{objUserCodePrjMainPathEx.MachineName}中生成代码路径为空，请检查！";
                    lblGcCodePath.Text = $"Cm工程:{strCmPrjName}的生成代码路径为空，请检查！";
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
                lblGcCodePath.Text = $"Cm工程:{strCmPrjName}的生成代码路径为空，请检查！";
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
            CodeElement objFindCodeElement = CodeAnalyzer.FindElementByName( this.ceRootElement, e.Node.Tag.ToString());
            if (objFindCodeElement == null) return;
            txtFuncCode.Text = objFindCodeElement.CodeContent;
            string strRefFuncName = objFindCodeElement.RefFuncName == null ? "" : objFindCodeElement.RefFuncName;
            if (objFindCodeElement.ElementType == CodeElementType.Import)
            {
                txtFuncCode.Text = txtFuncCode.Text + "\r\n" + $"引用函数: {strRefFuncName}";//请注意：此处的Import代码是自动生成的，可能需要手动修改。";
            }
        }
    }
}