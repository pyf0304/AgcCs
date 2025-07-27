
///----------------------
///生成代码版本：2012.10.19.1
///生成日期：2012/10/21
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：日志管理
///模块英文名：LogManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.20.1
///========================
//生成与表相关的控件控制层代码
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.util;
using CommFunc4Win;
using AGC.Entity;

using AGC_CSWin;



using AGC4WApi;


namespace AGC
{
    /// <summary>
    ///		frmTabCheckResult_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmTabCheckResult_QD_LV : System.Windows.Forms.Form, IBindListView
    {
        //clsTabCheckResultEN objTabCheckResultEN = null;
        private System.Data.DataTable objDTTabCheckResult = null;
        private clsListViewSorter objvTabCheckResultSorter;
        private int intLastSelectedvTabCheckResultColumIndex;
        public frmTabCheckResult_QD_LV()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvTabCheckResultSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvTabCheckResult.ListViewItemSorter = objvTabCheckResultSorter;
            objvTabCheckResultSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmTabCheckResult_QD_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();
            cboPrjId.SelectedValue = clsPubVar.CurrSelPrjId;
            cboPrjId.Enabled = false;
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            cboPrjDataBaseId.SelectedValue = objPrjDataBaseEN.PrjDataBaseId;
            cboErrorLevelId.SelectedValue = "0004";
            BindLv_vTabCheckResult();
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            clsProjectsWApi.BindCbo_PrjId(this.cboPrjId);
            //clsPrjTabExWApi.BindCbo_TabIdEx(this.cboTabId, clsPubVar.CurrSelPrjId);
            clsErrorLevelWApi.BindCbo_ErrorLevelId(this.cboErrorLevelId);
            clsSQLDSTypeWApi.BindCbo_SqlDsTypeId(this.cboSqlDsTypeId);
            clsPrjDataBaseExWApi.BindCbo_PrjDataBaseIdEx(cboPrjDataBaseId, clsPubVar.CurrSelPrjId);
     
        }
        public string PrjId
        {
            get
            {
                if (cboPrjId.SelectedValue.ToString() == "0")
                    return "";
                return cboPrjId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboPrjId.SelectedValue = "0";
                }
                else
                {
                    cboPrjId.SelectedValue = value;
                }
            }
        }

        public string TabId
        {
            get
            {
                if (cboTabId.SelectedValue.ToString() == "0")
                    return "";
                return cboTabId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboTabId.SelectedValue = "0";
                }
                else
                {
                    cboTabId.SelectedValue = value;
                }
            }
        }

        public string ErrorLevelId
        {
            get
            {
                if (cboErrorLevelId.SelectedValue.ToString() == "0")
                    return "";
                return cboErrorLevelId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboErrorLevelId.SelectedValue = "0";
                }
                else
                {
                    cboErrorLevelId.SelectedValue = value;
                }
            }
        }


        public void Clear()
        {
            cboPrjId.SelectedIndex = 0;
            cboTabId.SelectedIndex = 0;
            cboErrorLevelId.SelectedIndex = 0;
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
            cboPrjId.SelectedIndex = 0;
            cboTabId.SelectedIndex = 0;
            cboErrorLevelId.SelectedIndex = 0;
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
    
        public void SetCbo_PrjId()
        {
            clsProjectsWApi.BindCbo_PrjId(cboPrjId);
        }
        public void SetCbo_TabId()
        {
            clsPrjTabWApi.BindCbo_TabId(cboTabId, clsPubVar.CurrSelPrjId);
        }
        public void SetCbo_ErrorLevelId()
        {
            clsErrorLevelWApi.BindCbo_ErrorLevelId(cboErrorLevelId);
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
        public string CombineTabCheckResultCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And TabCheckResult.PrjId='" + this.cboPrjId.SelectedValue + "'";
            }

            if (this.cboPrjDataBaseId.SelectedValue.ToString() != "" && this.cboPrjDataBaseId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And TabCheckResult.PrjDataBaseId='" + this.cboPrjDataBaseId.SelectedValue + "'";
            }
            if (this.cboTabId.SelectedValue.ToString() != "" && this.cboTabId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And TabCheckResult.TabId='" + this.cboTabId.SelectedValue + "'";
            }
            if (this.cboErrorLevelId.SelectedValue.ToString() != "" && this.cboErrorLevelId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And TabCheckResult.ErrorLevelId='" + this.cboErrorLevelId.SelectedValue + "'";
            }
            if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And TabCheckResult.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineTabCheckResultCondion(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 and {0}='{1}' and {2}='{3}'", 
                conTabCheckResult.PrjId, clsPubVar.CurrSelPrjId,
                conTabCheckResult.PrjDataBaseId, clsPubVar.CurrPrjDataBaseId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithTabName == true)
            {
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabCheckResult.PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboPrjDataBaseId.SelectedValue.ToString() != "" && this.cboPrjDataBaseId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabCheckResult.PrjDataBaseId='" + this.cboPrjDataBaseId.SelectedValue + "'";
                }
                if (this.cboTabId.SelectedValue.ToString() != "" && this.cboTabId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabCheckResult.TabId='" + this.cboTabId.SelectedValue + "'";
                }
                if (this.cboErrorLevelId.SelectedValue.ToString() != "" && this.cboErrorLevelId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabCheckResult.ErrorLevelId='" + this.cboErrorLevelId.SelectedValue + "'";
                }
                if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabCheckResult.SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                }
            }
            else
            {
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboPrjDataBaseId.SelectedValue.ToString() != "" && this.cboPrjDataBaseId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjDataBaseId='" + this.cboPrjDataBaseId.SelectedValue + "'";
                }
                if (this.cboTabId.SelectedValue.ToString() != "" && this.cboTabId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabId='" + this.cboTabId.SelectedValue + "'";
                }
                if (this.cboErrorLevelId.SelectedValue.ToString() != "" && this.cboErrorLevelId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ErrorLevelId='" + this.cboErrorLevelId.SelectedValue + "'";
                }
                if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
                }
            }
            return strWhereCond;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineTabCheckResultCondion(string strTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".PrjId='" + this.cboPrjId.SelectedValue + "'";
            }
            if (this.cboPrjDataBaseId.SelectedValue.ToString() != "" && this.cboPrjDataBaseId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".PrjDataBaseId='" + this.cboPrjDataBaseId.SelectedValue + "'";
            }
            if (this.cboTabId.SelectedValue.ToString() != "" && this.cboTabId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".TabId='" + this.cboTabId.SelectedValue + "'";
            }
            if (this.cboErrorLevelId.SelectedValue.ToString() != "" && this.cboErrorLevelId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".ErrorLevelId='" + this.cboErrorLevelId.SelectedValue + "'";
            }
            if (this.cboSqlDsTypeId.SelectedValue.ToString() != "" && this.cboSqlDsTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".SqlDsTypeId='" + this.cboSqlDsTypeId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        /// <summary>
        /// 函数功能：用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvTabCheckResult.SelectedItems.Count >= 1)
            {
                this.btnDelRec.Enabled = true;
            }
            else
            {
                this.btnDelRec.Enabled = false;
            }
        }
        /// <summary>
        /// 函数功能：用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
        /// </summary>
        private void JudgebtnUpdate()
        {

        }
       
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vTabCheckResult()
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivTabCheckResult;
            List<clsvTabCheckResultEN> arrvTabCheckResultObjList;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineTabCheckResultCondion(false);	//  CombineTabCheckResultCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvTabCheckResultObjList = clsvTabCheckResultWApi.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            this.lvvTabCheckResult.Items.Clear();//清除原来所有Item
            this.lvvTabCheckResult.Columns.Clear();//清除原来所有列头信息
            this.lvvTabCheckResult.Columns.Add("mId", 50, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("数据库", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("表名", 260, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("字段名", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("错误等级名", 80, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("错误信息", 350, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("检查日期", 80, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("检查人", 50, HorizontalAlignment.Left);
      
            this.lvvTabCheckResult.Columns.Add("Sql数据源名", 100, HorizontalAlignment.Left);

            this.lvvTabCheckResult.Columns.Add("工程ID", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("工程名称", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("字段ID", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("表ID", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("表中文名", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.Columns.Add("错误等级Id", 100, HorizontalAlignment.Left);
            this.lvvTabCheckResult.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvTabCheckResultEN objvTabCheckResultEN in arrvTabCheckResultObjList)
            {
                lvivTabCheckResult = new ListViewItem();
                lvivTabCheckResult.Tag = objvTabCheckResultEN.mId;
                lvivTabCheckResult.Text = objvTabCheckResultEN.mId.ToString();
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.PrjDataBaseName);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.TabName);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.FldName);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.ErrorLevelName);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.ErrorMsg);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.CheckDate);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.CheckUser);
            
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.SqlDsTypeName);
           
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.PrjId);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.PrjName);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.FldId);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.TabId);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.TabCnName);
                lvivTabCheckResult.SubItems.Add(objvTabCheckResultEN.ErrorLevelId.ToString());
                this.lvvTabCheckResult.Items.Add(lvivTabCheckResult);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvTabCheckResultObjList.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vTabCheckResult();
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strmId = objDTTabCheckResult.Rows[intCurrRow]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            return lngmId;
        }
        /// <summary>
        /// 获取ListView中当前行的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListView objListView)
        {
            if (objListView.SelectedItems.Count == 0)
            {
                return 0;
            }
            ListViewItem lviTabCheckResult;
            lviTabCheckResult = objListView.SelectedItems[0];
            string strTabCheckResultId = lviTabCheckResult.Tag.ToString();
            long lngmId = long.Parse(strTabCheckResultId);
            return lngmId;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListViewItem objListViewItem)
        {
            string strTabCheckResultId = objListViewItem.Tag.ToString();
            long lngmId = long.Parse(strTabCheckResultId);
            return lngmId;
        }
        private void lvvTabCheckResult_Click(object sender, System.EventArgs e)
        {
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateTabCheckResultRecord();
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmTabCheckResult_UI frm = new frmTabCheckResult_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteTabCheckResultRecord();
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
            string strWhereCond = this.CombineTabCheckResultCondion(true);
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsTabCheckResultWApi.GetDataTable_TabCheckResult(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "TabCheckResult信息导出.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("FldID"); arrCnName.Add("字段ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("TabId"); arrCnName.Add("表ID");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("ErrorLevelId"); arrCnName.Add("错误等级Id");
            arrColName.Add("ErrorLevelName"); arrCnName.Add("错误等级名");
            arrColName.Add("ErrorMsg"); arrCnName.Add("错误信息");
            arrColName.Add("CheckDate"); arrCnName.Add("检查日期");
            arrColName.Add("CheckUser"); arrCnName.Add("检查人");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            arrColName.Add("SqlDsTypeId"); arrCnName.Add("数据源类型");
            arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql数据源名");
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
            string strWhereCond = this.CombineTabCheckResultCondion(true);
            //	2、设置表列数据字段名，以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("FldID"); arrCnName.Add("字段ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("TabId"); arrCnName.Add("表ID");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("ErrorLevelId"); arrCnName.Add("错误等级Id");
            arrColName.Add("ErrorLevelName"); arrCnName.Add("错误等级名");
            arrColName.Add("ErrorMsg"); arrCnName.Add("错误信息");
            arrColName.Add("CheckDate"); arrCnName.Add("检查日期");
            arrColName.Add("CheckUser"); arrCnName.Add("检查人");
            arrColName.Add("Memo"); arrCnName.Add("说明");
            arrColName.Add("SqlDsTypeId"); arrCnName.Add("数据源类型");
            arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql数据源名");
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
            frm1.strTableName = "vTabCheckResult";
            frm1.strTableChineseName = "vTabCheckResult";
            frm1.strViewName = "表检查结果维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvTabCheckResult_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvTabCheckResultSorter.SortColumn)
            {

            }
            else
            {
                this.objvTabCheckResultSorter.SortColumn = e.Column;
            }

            if (this.objvTabCheckResultSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvTabCheckResultSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvTabCheckResultColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvTabCheckResult.Columns[e.Column].Text = this.lvvTabCheckResult.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvTabCheckResultColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvTabCheckResult.Columns[e.Column].Text = this.lvvTabCheckResult.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvTabCheckResult.Columns[intLastSelectedvTabCheckResultColumIndex].Text = this.lvvTabCheckResult.Columns[intLastSelectedvTabCheckResultColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvTabCheckResultColumIndex = e.Column;
                }
            }
            else if (this.objvTabCheckResultSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvTabCheckResultSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvTabCheckResultColumIndex == e.Column)
                {
                    this.lvvTabCheckResult.Columns[e.Column].Text = this.lvvTabCheckResult.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvTabCheckResultColumIndex = e.Column;
                }
                else
                {
                    this.lvvTabCheckResult.Columns[e.Column].Text = this.lvvTabCheckResult.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvTabCheckResult.Columns[intLastSelectedvTabCheckResultColumIndex].Text = this.lvvTabCheckResult.Columns[intLastSelectedvTabCheckResultColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvTabCheckResultColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvTabCheckResult.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vTabCheckResult();
        }
        ///生成修改记录准备过程代码 for C#
        private void UpdateTabCheckResultRecord()
        {
            if (this.lvvTabCheckResult.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            frmTabCheckResult_UI frm = new frmTabCheckResult_UI();
            string strKeyId = this.lvvTabCheckResult.SelectedItems[0].Tag.ToString();
            frm.mId_key = long.Parse(strKeyId);
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        ///删除记录过程代码for C#
        private void DeleteTabCheckResultRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvTabCheckResult.SelectedItems)
                {
                    long lngmId = GetCurrKey(lvi);
                    if (clsTabCheckResultWApi.DelRecord(lngmId) == 0)
                    {
                        MessageBox.Show("删除记录失败！");
                        BindLv_vTabCheckResult();
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vTabCheckResult();
            }
        }

        private void btnSetNullableBySQL_Click(object sender, EventArgs e)
        {

            if (this.lvvTabCheckResult.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            string strKeyId = this.lvvTabCheckResult.SelectedItems[0].Tag.ToString();
            long lngMid = long.Parse(strKeyId);
            lblMsg.Text = "";
            clsTabCheckResultEN objTabCheckResultEN = clsTabCheckResultWApi.GetObjBymId(lngMid);
            string strTabId = objTabCheckResultEN.TabId;
            List<string> arrTabIdLst = new List<string>();
            arrTabIdLst.Add(strTabId);
            //根据SQL表信息设置表字段的可空性
            clsProjectsEN objProjectsEN = new clsProjectsEN(clsPubVar.CurrSelPrjId);
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            try
            {
                //objProjectsEN = clsProjectsWApi.GetObjByPrjId(clsPubVar.CurrSelPrjId);
                clsPrjTabExWApi.SetPrjTabFldNullBySQLTab(strTabId, clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsSysParaEN.strUserId);
                if (arrTabIdLst.Count == 0)
                {
                    lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                    return;
                }
                int intCount = 0;
                intCount = clsProjectsExWApi.CheckCheckedTabField(clsPubVar.CurrSelPrjId,clsPubVar.CurrSelPrjId,  clsSysParaEN.strUserId, arrTabIdLst);
                //显示生成代码区域
                BindLv_vTabCheckResult();
                MessageBox.Show("检查表字段完成！共计：" + intCount.ToString() + "个表。");
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                //MessageBox.Show(objException.Message);
                //ErrorInformationWApi.AddInformation("frmTabCheckResult_QD_LV.cs", "btnSetNullableBySQL_Click", objException.Message, clsSysParaEN.strUserId);
            }
        }

        private void btnCheckAllTabField_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            int intCount = 0;
            try
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseWApi.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
                intCount = clsProjectsExWApi.CheckAllTabField(clsPubVar.CurrSelPrjId, 
                    objPrjDataBaseEN.PrjDataBaseId, 
                    clsSysParaEN.strUserId);
                MessageBox.Show(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
                //ErrorInformationWApi.AddInformation("frmTabCheckResult_QD_LV", "lbCheckAllTabField_Click", objException.Message, clsSysParaEN.strUserId);
            } //显示生成代码区域
        
        }

    }
}