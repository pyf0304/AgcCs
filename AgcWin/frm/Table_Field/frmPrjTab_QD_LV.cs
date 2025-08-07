
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/13
///生成者：潘以锋
///工程名称：AGC_CSV7
///工程ID：0005
///模块中文名：字段、表维护
///模块英文名：Table_Field
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
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
using com.taishsoft.commdb;
using AGC_CSV7.Entity;
using AGC_CSV7.BusinessLogic;
using AGC_CSWin;
using System.Text;
using AGC_CSV7.BusinessLogicEx;
using AgcCommBase;

namespace AGC_CSV7
{
    /// <summary>
    ///		frmPrjTab_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmPrjTab_QD_LV : System.Windows.Forms.Form, IBindListView
    {
        clsPrjTabEN objPrjTabEN = null;
        private System.Data.DataTable objDTPrjTab = null;
        private clsListViewSorter objvPrjTabSorter;
        private int intLastSelectedvPrjTabColumIndex;
        private clsPubConst.LangType mltLangType = clsPubConst.LangType.CSharp;//语言类型
        private clsPubConst.DataBaseType mdbtDataBaseType = clsPubConst.DataBaseType.MsSql;//数据库类型
        public frmPrjTab_QD_LV()
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
            //clsProjectsEN objProjectEN = clsProjectsBL.GetProjectsByPrjId(clsPubVar.CurrSelPrjId);
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseByPrjDataBaseId(clsPubVar.CurrPrjDataBaseId);
            try
            {
                clsPrjTabBLEx.p_Init_Log4GeneTabCode(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            this.Text = string.Format("项目表代码生成20141003----工程：{0}({1})  数据库：{2}({3})", clsPubVar.objCurrSelProjectEN.PrjName, clsPubVar.objCurrSelProjectEN.PrjId,
                                objPrjDataBaseEN.PrjDataBaseName, objPrjDataBaseEN.PrjDataBaseId);
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();

            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            cboCharEncodingId.SelectedValue = strCharEncodingId;
            cboPrjId.SelectedValue = clsPubVar.CurrSelPrjId;
            cboPrjId.Enabled = false;
            cboTabStateId.SelectedIndex = 1;
            if (chkDispAllErrMsg.Checked == true)
            {
                BindLv_vPrjTab_WithErrMsg();
            }
            else
            {
                BindLv_vPrjTab(false);
            }

            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
         

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            this.BindCbo_PrjId(this.cboPrjId);
            clsFuncModuleBLEx.BindCbo_FuncModuleId(this.cboFuncModuleId, clsPubVar.CurrSelPrjId);
            this.BindCbo_SQLDSTypeId(this.cboSQLDSTypeId);
            this.BindCbo_TabStateId(this.cboTabStateId);
            clsCharEncodingBL.BindCbo_CharEncodingId(cboCharEncodingId);
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

        public string SQLDSTypeId
        {
            get
            {
                if (cboSQLDSTypeId.SelectedValue.ToString() == "0")
                    return "";
                return cboSQLDSTypeId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboSQLDSTypeId.SelectedValue = "0";
                }
                else
                {
                    cboSQLDSTypeId.SelectedValue = value;
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
            cboPrjId.SelectedIndex = 0;
            cboFuncModuleId.SelectedIndex = 0;
            cboSQLDSTypeId.SelectedIndex = 0;
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
            cboPrjId.SelectedIndex = 0;
            cboFuncModuleId.SelectedIndex = 0;
            cboSQLDSTypeId.SelectedIndex = 0;
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
        public System.Data.DataTable GetPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjId, PrjName from Projects ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_PrjId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetPrjId();
            clsProjectsEN objProjectsEN;
            //初始化一个对象列表
            ArrayList ProjectsList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objProjectsEN = new clsProjectsEN();
            objProjectsEN.PrjId = "0";
            objProjectsEN.PrjName = "请选择...";
            ProjectsList.Add(objProjectsEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objProjectsEN = new clsProjectsEN();
                objProjectsEN.PrjId = objRow["PrjId"].ToString();
                objProjectsEN.PrjName = objRow["PrjName"].ToString();
                ProjectsList.Add(objProjectsEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = ProjectsList;
            objComboBox.ValueMember = "PrjId";
            objComboBox.DisplayMember = "PrjName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetObjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ObjId, ObjName from PrjObjects ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_ObjId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetObjId();
            clsPrjObjectsEN objPrjObjectsEN;
            //初始化一个对象列表
            ArrayList PrjObjectsList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objPrjObjectsEN = new clsPrjObjectsEN();
            objPrjObjectsEN.ObjId = "0";
            objPrjObjectsEN.ObjName = "请选择...";
            PrjObjectsList.Add(objPrjObjectsEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjObjectsEN = new clsPrjObjectsEN();
                objPrjObjectsEN.ObjId = objRow["ObjId"].ToString();
                objPrjObjectsEN.ObjName = objRow["ObjName"].ToString();
                PrjObjectsList.Add(objPrjObjectsEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjObjectsList;
            objComboBox.ValueMember = "ObjId";
            objComboBox.DisplayMember = "ObjName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetSQLDSTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select SQLDSTypeId, SqlDsTypeName from SQLDSType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_SQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetSQLDSTypeId();
            clsSQLDSTypeEN objSQLDSTypeEN;
            //初始化一个对象列表
            ArrayList SQLDSTypeList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objSQLDSTypeEN = new clsSQLDSTypeEN();
            objSQLDSTypeEN.SQLDSTypeId = "0";
            objSQLDSTypeEN.SqlDsTypeName = "请选择...";
            SQLDSTypeList.Add(objSQLDSTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objSQLDSTypeEN = new clsSQLDSTypeEN();
                objSQLDSTypeEN.SQLDSTypeId = objRow["SQLDSTypeId"].ToString();
                objSQLDSTypeEN.SqlDsTypeName = objRow["SqlDsTypeName"].ToString();
                SQLDSTypeList.Add(objSQLDSTypeEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = SQLDSTypeList;
            objComboBox.ValueMember = "SQLDSTypeId";
            objComboBox.DisplayMember = "SqlDsTypeName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetTabStateId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabStateId, TabStateName from TabState ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_TabStateId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetTabStateId();
            clsTabStateEN objTabStateEN;
            //初始化一个对象列表
            ArrayList TabStateList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objTabStateEN = new clsTabStateEN();
            objTabStateEN.TabStateId = "0";
            objTabStateEN.TabStateName = "请选择...";
            TabStateList.Add(objTabStateEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objTabStateEN = new clsTabStateEN();
                objTabStateEN.TabStateId = objRow["TabStateId"].ToString();
                objTabStateEN.TabStateName = objRow["TabStateName"].ToString();
                TabStateList.Add(objTabStateEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = TabStateList;
            objComboBox.ValueMember = "TabStateId";
            objComboBox.DisplayMember = "TabStateName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetFuncModuleId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncModuleId, FuncModuleName from FuncModule ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_FuncModuleId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetFuncModuleId();
            clsFuncModuleEN objFuncModuleEN;
            //初始化一个对象列表
            ArrayList FuncModuleList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objFuncModuleEN = new clsFuncModuleEN();
            objFuncModuleEN.FuncModuleId = "0";
            objFuncModuleEN.FuncModuleName = "请选择...";
            FuncModuleList.Add(objFuncModuleEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objFuncModuleEN = new clsFuncModuleEN();
                objFuncModuleEN.FuncModuleId = objRow["FuncModuleId"].ToString();
                objFuncModuleEN.FuncModuleName = objRow["FuncModuleName"].ToString();
                FuncModuleList.Add(objFuncModuleEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = FuncModuleList;
            objComboBox.ValueMember = "FuncModuleId";
            objComboBox.DisplayMember = "FuncModuleName";
            objComboBox.SelectedIndex = 0;
        }
        public void SetCbo_PrjId()
        {
            clsProjectsBL.BindCbo_PrjId(cboPrjId);
        }
        public void SetCbo_ObjId()
        {
            clsPrjObjectsBL.BindCbo_ObjId(cboFuncModuleId);
        }
        public void SetCbo_SQLDSTypeId()
        {
            clsSQLDSTypeBL.BindCbo_SQLDSTypeId(cboSQLDSTypeId);
        }
        public void SetCbo_TabStateId()
        {
            clsTabStateBL.BindCbo_TabStateId(cboTabStateId);
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
        public string CombinePrjTabCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabName.Text.Trim() != "")
            {
                strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim() + "%'";
            }
            if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.PrjId='" + this.cboPrjId.SelectedValue + "'";
            }
            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboSQLDSTypeId.SelectedValue.ToString() != "" && this.cboSQLDSTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue + "'";
            }
            if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And PrjTab.TabStateId='" + this.cboTabStateId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombinePrjTabCondion(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1  ", clsSysParaEN.strUserId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithTabName == true)
            {
                if (this.txtTabName.Text.Trim() != "")
                {
                    strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim() + "%'";
                }
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboSQLDSTypeId.SelectedValue.ToString() != "" && this.cboSQLDSTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue + "'";
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
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboSQLDSTypeId.SelectedValue.ToString() != "" && this.cboSQLDSTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue + "'";
                }
                if (this.cboTabStateId.SelectedValue.ToString() != "" && this.cboTabStateId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And TabStateId='" + this.cboTabStateId.SelectedValue + "'";
                }
            }
            return strWhereCond;
        }

        public string CombinePrjTabCondion4NoTimelyGeneCodeTabs(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " ('20' + UpdDate>GeneCodeDate or GeneCodeDate is null) ";
            strWhereCond += string.Format("  and 1=1 ", clsSysParaEN.strUserId);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithTabName == true)
            {
                if (this.txtTabName.Text.Trim() != "")
                {
                    strWhereCond += " And PrjTab.TabName like '%" + this.txtTabName.Text.Trim() + "%'";
                }
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboSQLDSTypeId.SelectedValue.ToString() != "" && this.cboSQLDSTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjTab.SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue + "'";
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
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboSQLDSTypeId.SelectedValue.ToString() != "" && this.cboSQLDSTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue + "'";
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
        public string CombinePrjTabCondion(string strTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabName.Text.Trim() != "")
            {
                strWhereCond += " And " + strTabName + ".TabName like '%" + this.txtTabName.Text.Trim() + "%'";
            }
            if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".PrjId='" + this.cboPrjId.SelectedValue + "'";
            }
            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboSQLDSTypeId.SelectedValue.ToString() != "" && this.cboSQLDSTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".SQLDSTypeId='" + this.cboSQLDSTypeId.SelectedValue + "'";
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
        
        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vPrjTab(bool bolIsDispTabs4TimelyGene)
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivPrjTab;
            List<clsvPrjTab4GeneCodeEN> arrvPrjTabObjList;
            //	1、组合界面条件串；
            string strWhereCond = "";
            if (bolIsDispTabs4TimelyGene == true)
            {
                strWhereCond = this.CombinePrjTabCondion4NoTimelyGeneCodeTabs(false);
                strWhereCond += "[Exclude]or [/Exclude]";
            }
            else
            {
                strWhereCond = this.CombinePrjTabCondion(false);	//  CombinePrjTabCondion();
                //strWhereCond += "[Exclude]or [/Exclude]";
            }
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvPrjTabObjList = clsvPrjTab4GeneCodeBLEx.GetvPrjTab4GeneCodeObjListByUserIdAndCondition(clsSysParaEN.strUserId, strWhereCond);
            //	3、设置ListView的列头信息
            this.lvvPrjTab.Items.Clear();//清除原来所有Item
            this.lvvPrjTab.Columns.Clear();//清除原来所有列头信息
            //this.lvvPrjTab.Columns.Add("表ID", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("表名", 250, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("表中文名", 120, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("功能模块", 100, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("字段数", 60, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("生成日期", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("版本", 100, HorizontalAlignment.Left);

            //this.lvvPrjTab.Columns.Add("错误信息", 100, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("关键字段", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("主键类型", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("Sql数据源名", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("表状态", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("对象", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvPrjTab4GeneCodeEN objvPrjTabEN in arrvPrjTabObjList)
            {
                lvivPrjTab = new ListViewItem();
                lvivPrjTab.Tag = objvPrjTabEN.TabId;
                lvivPrjTab.Text = objvPrjTabEN.TabName;
                //lvivPrjTab.SubItems.Add(objvPrjTabEN.TabName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.TabCnName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.FuncModuleName);

                lvivPrjTab.SubItems.Add(objvPrjTabEN.FldNum.ToString());
                lvivPrjTab.SubItems.Add(objvPrjTabEN.UpdDate);
                lvivPrjTab.SubItems.Add(GetShortDate(objvPrjTabEN.GeneCodeDate));

                lvivPrjTab.SubItems.Add(objvPrjTabEN.Version_GeneCode);

                lvivPrjTab.SubItems.Add(objvPrjTabEN.KeyFldName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.PrimaryTypeName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.SqlDsTypeName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.TabStateName);
                lvivPrjTab.SubItems.Add(objvPrjTabEN.ObjName);

                this.lvvPrjTab.Items.Add(lvivPrjTab);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvPrjTabObjList.Count.ToString();
        }
        private string GetShortDate(string strDate)
        {
            if (strDate.Length > 3 && strDate.Length < 13)
                return strDate.Substring(2);
            else if (strDate.Length > 13)
                return strDate.Substring(2, 10);
            else return strDate;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vPrjTab_WithErrMsg()
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivPrjTab;
            List<clsvPrjTab4GeneCodeEN> arrvPrjTab4ErrMsgObjList;
            //	1、组合界面条件串；
            string strWhereCond = this.CombinePrjTabCondion(false);	//  CombinePrjTabCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            //strWhereCond += "[Exclude]or [/Exclude]";
            arrvPrjTab4ErrMsgObjList = clsvPrjTab4GeneCodeBLEx.GetvPrjTab4GeneCodeObjListByUserIdAndCondition(clsSysParaEN.strUserId, strWhereCond);
            //	3、设置ListView的列头信息
            this.lvvPrjTab.Items.Clear();//清除原来所有Item
            this.lvvPrjTab.Columns.Clear();//清除原来所有列头信息
            this.lvvPrjTab.Columns.Add("表名", 150, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("表中文名", 120, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("功能模块", 100, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("字段数", 60, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("生成日期", 100, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("版本", 90, HorizontalAlignment.Left);

            this.lvvPrjTab.Columns.Add("关键字段", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("主键类型", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("Sql数据源名", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("表状态", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.Columns.Add("对象", 100, HorizontalAlignment.Left);
            this.lvvPrjTab.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvPrjTab4GeneCodeEN objvPrjTab4ErrMsgEN in arrvPrjTab4ErrMsgObjList)
            {
                lvivPrjTab = new ListViewItem();
                lvivPrjTab.Tag = objvPrjTab4ErrMsgEN.TabId;
                lvivPrjTab.Text = objvPrjTab4ErrMsgEN.TabName;
                //lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.TabName);
                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.TabCnName);
                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.FuncModuleName);

                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.FldNum.ToString());
                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.UpdDate);
                lvivPrjTab.SubItems.Add(GetShortDate(objvPrjTab4ErrMsgEN.GeneCodeDate));
                lvivPrjTab.SubItems.Add(GetShortDate(objvPrjTab4ErrMsgEN.Version_GeneCode));

                //lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.ErrMsg);

                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.KeyFldName);
                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.PrimaryTypeName);
                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.SqlDsTypeName);
                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.TabStateName);
                lvivPrjTab.SubItems.Add(objvPrjTab4ErrMsgEN.ObjName);

                this.lvvPrjTab.Items.Add(lvivPrjTab);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvPrjTab4ErrMsgObjList.Count.ToString();
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
            string strWhereCond = this.CombinePrjTabCondion(true);
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsPrjTabBL.GetDataTable_PrjTab(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "PrjTab信息导出.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("TabId"); arrCnName.Add("表ID");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("FuncModuleId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("ObjId"); arrCnName.Add("所属对象");
            arrColName.Add("ObjName"); arrCnName.Add("对象名称");
            arrColName.Add("TabStateId"); arrCnName.Add("表状态ID");
            arrColName.Add("TabStateName"); arrCnName.Add("表状态名称");
            arrColName.Add("FldNum"); arrCnName.Add("FldNum");
            arrColName.Add("KeyFldName"); arrCnName.Add("KeyFldName");
            arrColName.Add("PrimaryTypeId"); arrCnName.Add("主键类型ID");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("PrimaryTypeName");
            arrColName.Add("SQLDSTypeId"); arrCnName.Add("数据源类型");
            arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql数据源名");
            arrColName.Add("ErrMsg"); arrCnName.Add("错误信息");
            arrColName.Add("IsTabPrimary"); arrCnName.Add("是否作为表中主键");
            arrColName.Add("Owner"); arrCnName.Add("拥有者");
            arrColName.Add("RelaViewId"); arrCnName.Add("相关视图ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
            arrColName.Add("IsArchive"); arrCnName.Add("是否存档");
            arrColName.Add("IsChecked"); arrCnName.Add("是否核实");
            arrColName.Add("TabName_B"); arrCnName.Add("表名_后备");
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
            objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
            MessageBox.Show("导出Excel成功!，文件存放在：" + strDownLoadFileName);
        }
        /// <summary>
        /// 导出EXCEL的函数, 导出EXCEL时可以选择列
        /// </summary>
        private void ExportExcel_SelColumns()
        {
            //	1、组合界面条件串；
            string strWhereCond = this.CombinePrjTabCondion(true);
            //	2、设置表列数据字段名，以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("TabId"); arrCnName.Add("表ID");
            arrColName.Add("TabName"); arrCnName.Add("表名");
            arrColName.Add("TabCnName"); arrCnName.Add("表中文名");
            arrColName.Add("FuncModuleId"); arrCnName.Add("功能模块Id");
            arrColName.Add("FuncModuleName"); arrCnName.Add("功能模块名称");
            arrColName.Add("ObjId"); arrCnName.Add("所属对象");
            arrColName.Add("ObjName"); arrCnName.Add("对象名称");
            arrColName.Add("TabStateId"); arrCnName.Add("表状态ID");
            arrColName.Add("TabStateName"); arrCnName.Add("表状态名称");
            arrColName.Add("FldNum"); arrCnName.Add("FldNum");
            arrColName.Add("KeyFldName"); arrCnName.Add("KeyFldName");
            arrColName.Add("PrimaryTypeId"); arrCnName.Add("主键类型ID");
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("PrimaryTypeName");
            arrColName.Add("SQLDSTypeId"); arrCnName.Add("数据源类型");
            arrColName.Add("SqlDsTypeName"); arrCnName.Add("Sql数据源名");
            arrColName.Add("ErrMsg"); arrCnName.Add("错误信息");
            arrColName.Add("IsTabPrimary"); arrCnName.Add("是否作为表中主键");
            arrColName.Add("Owner"); arrCnName.Add("拥有者");
            arrColName.Add("RelaViewId"); arrCnName.Add("相关视图ID");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
            arrColName.Add("IsArchive"); arrCnName.Add("是否存档");
            arrColName.Add("IsChecked"); arrCnName.Add("是否核实");
            arrColName.Add("TabName_B"); arrCnName.Add("表名_后备");
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
                    if (clsPrjTabBL.DelRecord(strTabId) == false)
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

        private void btnGeneEntityLayer_Click(object sender, EventArgs e)
        {
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }

            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
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
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            string strClsName = "";
            string strCodePath = "";
            string strCodeText = "";
            string strCodeText_Sim = "";
            lblMsg.Text = "";
            string strFileName = "";
            foreach (string strTabId in arrTabIdLst)
            {

                try
                {
                    clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0001", "01", clsPubVar.CurrSelPrjId);

                    if (rbMsSql.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                           clsSysParaEN.strUserId,
                            clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                             strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);
                    }
                    else if (rbOracle.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneEntityLayer_Ora(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                           clsSysParaEN.strUserId,
                            clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                             strCharEncodingId, ref strClsName, ref strCodePath, ref strFileName);
                    }
                    else if (rbMySql.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                           clsSysParaEN.strUserId,
                            clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                           strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);
                    }

                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;

                    MessageBox.Show(objException.Message);

                }
            }
            txtCode.Text = strCodeText;
            txtFileName4GenCode.Text = strClsName;
            txtCodePath.Text = strCodePath;
            tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
            MessageBox.Show("生成完成！共计：" + intCount.ToString() + "个表。");
            BindLv_vPrjTab(false);
        }



        private void txtFileName4GenCode_Click(object sender, EventArgs e)
        {
            txtFileName4GenCode.SelectAll();
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            txtCode.SelectAll();
        }

        private void lbGenDALCode_Click(object sender, EventArgs e)
        {


        }


        //private void btnGenGeneLogicCode_Click(object sender, EventArgs e)
        //{
        //    List<string> arrTabIdLst = new List<string>();
        //    foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
        //    {
        //        string strTabId = GetCurrKey(lvi);
        //        arrTabIdLst.Add(strTabId);
        //    }

        //    if (arrTabIdLst.Count == 0)
        //    {
        //        lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
        //        MessageBox.Show(lblMsg.Text);
        //        return;
        //    }
        //    if (cboCharEncodingId.SelectedIndex <= 0)
        //    {
        //        lblMsg.Text = "请选择一个生成文件的字符编码!";
        //        MessageBox.Show(lblMsg.Text);
        //        return;
        //    }
        //    string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

        //    //保存当前选择的字符编码
        //    clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

        //    int intCount = 0;
        //    string strClsName = "";
        //    string strCodePath = "";
        //    string strCodeText = "";
        //    lblMsg.Text = "";
        //    foreach (string strTabId in arrTabIdLst)
        //    {
        //        try
        //        {
        //            clsUserCodePathEN objUserCodePathEN = clsPubVar.GetUserCodePathObjByCodeTypeId("0007");

        //            strCodeText = clsPrjTabBLEx.GeneClassLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
        //                clsSysParaEN.strUserId,
        //                 clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
        //               ref strClsName, ref strCodePath);
        //            intCount++;
        //        }
        //        catch (Exception objException)
        //        {
        //            lblMsg.Text = objException.Message;
        //            MessageBox.Show(objException.Message);
        //        }
        //    }
        //    txtCode.Text = strCodeText;
        //    txtFileName4GenCode.Text = strClsName;
        //    txtCodePath.Text = strCodePath;
        //    tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
        //    MessageBox.Show("生成完成！共计：" + intCount.ToString() + "个表。");
        //    BindLv_vPrjTab(false);
        //}

        //private void btnGenGeneLogicCodeEx_Click(object sender, EventArgs e)
        //{
        //    List<string> arrTabIdLst = new List<string>();
        //    foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
        //    {
        //        string strTabId = GetCurrKey(lvi);
        //        arrTabIdLst.Add(strTabId);
        //    }


        //    if (arrTabIdLst.Count == 0)
        //    {
        //        lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
        //        MessageBox.Show(lblMsg.Text);
        //        return;
        //    }
        //    if (cboCharEncodingId.SelectedIndex <= 0)
        //    {
        //        lblMsg.Text = "请选择一个生成文件的字符编码!";
        //        MessageBox.Show(lblMsg.Text);
        //        return;
        //    }
        //    string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();

        //    //保存当前选择的字符编码
        //    clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

        //    int intCount = 0;
        //    string strClsName = "";
        //    string strCodePath = "";
        //    string strCodeText = "";
        //    lblMsg.Text = "";
        //    foreach (string strTabId in arrTabIdLst)
        //    {
        //        try
        //        {
        //            clsUserCodePathEN objUserCodePathEN = clsPubVar.GetUserCodePathObjByCodeTypeId("0008");


        //            strCodeText = clsPrjTabBLEx.GeneClassExLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
        //               clsSysParaEN.strUserId,
        //               clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
        //               strCharEncodingId,
        //               ref strClsName, ref strCodePath);

        //            intCount++;
        //        }
        //        catch (Exception objException)
        //        {
        //            lblMsg.Text = objException.Message;

        //            MessageBox.Show(objException.Message);

        //        }
        //    }
        //    txtCode.Text = strCodeText;
        //    txtFileName4GenCode.Text = strClsName;
        //    txtCodePath.Text = strCodePath;
        //    tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
        //    MessageBox.Show("生成完成！共计：" + intCount.ToString() + "个表。");
        //}

        private void btnGenDALCode_Click(object sender, EventArgs e)
        {
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }

            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
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
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);


            int intCount = 0;
            string strClsName = "";
            string strCodePath = "";
            string strCodeText = "";
            lblMsg.Text = "";
            foreach (string strTabId in arrTabIdLst)
            {

                try
                {
                    clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0002", "01", clsPubVar.CurrSelPrjId);

                    if (rbMsSql.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                           strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                    else if (rbOracle.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneDataLayer_Ora(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                           strCharEncodingId, ref strClsName, ref strCodePath);
                    }
                    else if (rbMySql.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                            strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;

                    MessageBox.Show(objException.Message);

                }
            }
            txtCode.Text = strCodeText;
            txtFileName4GenCode.Text = strClsName;
            txtCodePath.Text = strCodePath;
            tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
            MessageBox.Show("生成完成！共计：" + intCount.ToString() + "个表。");
            BindLv_vPrjTab(false);
        }

        private void btnBusinessLogicCode_Click(object sender, EventArgs e)
        {
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }

            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
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
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);


            int intCount = 0;
            string strClsName = "";
            string strCodePath = "";
            string strCodeText = "";
            lblMsg.Text = "";
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0003", "01", clsPubVar.CurrSelPrjId);
                    if (rbMsSql.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                               objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                            strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                    else if (rbOracle.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer_Ora(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                               objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                            strCharEncodingId, ref strClsName, ref strCodePath);
                    }
                    else if (rbMySql.Checked == true)
                    {
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                               objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                            strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }

                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;

                    MessageBox.Show(objException.Message);

                }

            }
            txtCode.Text = strCodeText;
            txtFileName4GenCode.Text = strClsName;
            txtCodePath.Text = strCodePath;
            tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
            MessageBox.Show("生成完成！共计：" + intCount.ToString() + "个表。");
        }

        private void btnAllTableThreeLayer_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            string strFileName = "";
            List<string> arrTabIdLst = clsPrjTabBL.funGetFldValue("TabId", string.Format("PrjId='{0}' And TabStateId='01'", clsPubVar.CurrSelPrjId));

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
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);


            int intCount = 0;
            List<string> arrErrorLst = new List<string>();
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    string strClsName = "";
                    string strCodePath = "";
                    clsUserCodePathEN objUserCodePathEN = null;
                    string strCodeText = "";
                    string strCodeText_Sim = "";

                    if (rbMsSql.Checked == true)
                    {
                        //生成新版-实体层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0001", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId,
                           clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                           clsSysParaEN.strUserName,
                           objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                       strCharEncodingId,  mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref  strFileName, ref strCodeText_Sim);

                        // 生成新版-数据处理层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0002", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                        //生成新版-业务逻辑层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0003", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                             objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                    else if (rbOracle.Checked == true)
                    {
                        //生成新版-实体层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0001", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId,
                           clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                           clsSysParaEN.strUserName,
                           objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                       strCharEncodingId, mltLangType,mdbtDataBaseType, ref strClsName, ref strCodePath, ref  strFileName, ref strCodeText_Sim);

                        // 生成新版-数据处理层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0002", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                        //生成新版-业务逻辑层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0003", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                             objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        strCharEncodingId,  mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                    else if (rbMySql.Checked == true)
                    {
                        //生成新版-实体层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0001", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId,
                           clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                           clsSysParaEN.strUserName,
                           objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId,  mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref  strFileName, ref strCodeText_Sim);

                        // 生成新版-数据处理层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0002", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);

                        //生成新版-业务逻辑层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0003", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                             objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                                                         

                    //objUserCodePathEN = clsPubVar.GetUserCodePathObjByCodeTypeId("0008");
                    //strCodeText = clsPrjTabBLEx.GeneClassExLayer(strTabId, clsPubVar.objCurrSelProjectEN,
                    //clsSysParaEN.strUserId,
                    // clsSysParaEN.strUserName,
                    // objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                    // ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("wfmPrjTab_QUDI3.aspx", "lbAllTableThreeLayer_Click", objException.Message, clsSysParaEN.strUserId);

                } //显示生成代码区域
            }
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成完成！共计：{0}个表。\r\n", intCount);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());
            BindLv_vPrjTab(false);


        }

        private void btnGeneAllCheckedTableThreeLayer_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }


            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
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
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);
            int intCount = 0;
            List<string> arrErrorLst = new List<string>();
            string strFileName = "";
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    string strClsName = "";
                    string strCodePath = "";
                    //生成新版-实体层
                    clsUserCodePathEN objUserCodePathEN = null;
                    string strCodeText = "";
                    string strCodeText_Sim = "";

                    if (rbMsSql.Checked == true)
                    {
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0001", "01", clsPubVar.CurrSelPrjId);

                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId,
                           clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                           clsSysParaEN.strUserName,
                           objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);


                        // 生成新版-数据处理层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0002", "01", clsPubVar.CurrSelPrjId);

                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);


                        //生成新版-业务逻辑层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0003", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                               objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                    else if (rbOracle.Checked == true)
                    {
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0001", "01", clsPubVar.CurrSelPrjId);

                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId,
                           clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                           clsSysParaEN.strUserName,
                           objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);


                        // 生成新版-数据处理层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0002", "01", clsPubVar.CurrSelPrjId);

                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);


                        //生成新版-业务逻辑层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0003", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                               objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                    else if (rbMySql.Checked == true)
                    {
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0001", "01", clsPubVar.CurrSelPrjId);

                        strCodeText = clsPrjTabBLEx.GeneEntityLayer(strTabId,
                           clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId,
                           clsSysParaEN.strUserName,
                                    objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                                 strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath, ref strFileName, ref strCodeText_Sim);


                        // 生成新版-数据处理层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0002", "01", clsPubVar.CurrSelPrjId);

                        strCodeText = clsPrjTabBLEx.GeneDataLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                              objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);


                        //生成新版-业务逻辑层
                        objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0003", "01", clsPubVar.CurrSelPrjId);
                        strCodeText = clsPrjTabBLEx.GeneLogicLayer(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                            clsSysParaEN.strUserId,
                             clsSysParaEN.strUserName,
                               objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    }
                                       
                    //objUserCodePathEN = clsPubVar.GetUserCodePathObjByCodeTypeId("0008");

                    //strCodeText = clsPrjTabBLEx.GeneClassExLayer(strTabId, clsPubVar.objCurrSelProjectEN,
                    //clsSysParaEN.strUserId,
                    // clsSysParaEN.strUserName,
                    // objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                    // ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("wfmPrjTab_QUDI3.aspx", "lbGeneAllCheckedTableThreeLayer0_Click", objException.Message, clsSysParaEN.strUserId);
                    //return;
                } //显示生成代码区域
            }
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成完成！共计：{0}个表。\r\n", intCount);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());
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
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseObjByPrjDataBaseId_Cache(clsPubVar.CurrPrjDataBaseId);
                intCount = clsProjectsBLEx.CheckAllTabField(clsPubVar.CurrSelPrjId, objPrjDataBaseEN.PrjDataBaseId, clsSysParaEN.strUserId);
                MessageBox.Show(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
                BindLv_vPrjTab(false);
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
                ErrorInformationBL.AddInformation("wfmPrjTab_QUDI3.aspx", "lbCheckAllTabField_Click", objException.Message, clsSysParaEN.strUserId);
            } //显示生成代码区域

        }

        private void btnCheckCheckedTabField_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }

            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                MessageBox.Show(lblMsg.Text);
                return;
            }

            int intCount = 0;

            try
            {
                intCount = clsProjectsBLEx.CheckCheckedTabField(clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsSysParaEN.strUserId, arrTabIdLst);
                MessageBox.Show(this, "检查表字段完成！共计：" + intCount.ToString() + "个表。");
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
                ErrorInformationBL.AddInformation("wfmPrjTab_QUDI3.aspx", "lbCheckAllTabField_Click", objException.Message, clsSysParaEN.strUserId);
            } //显示生成代码区域


        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            clsPubFun4BLEx.ClearCache4GeneCode();
            ////clsFieldSet.arrFieldObjLst = null;
            ////clsFieldSet.arrFieldTabObjLst = null;
            //clsFieldTabBLEx.arrFieldTabENExObjLst4WinApp = null;
            //clsFieldTabBLEx.arrFieldTabENExObjLstOrderByFldId_Cache = null;
        }

        private void btnGenWebServiceCode_Click(object sender, EventArgs e)
        {
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }

            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
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
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            string strClsName = "";
            string strCodePath = "";
            string strCodeText = "";
            lblMsg.Text = "";
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0009", "01", clsPubVar.CurrSelPrjId);

                    strCodeText = clsPrjTabBLEx.GenWebServiceCode(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                        clsSysParaEN.strUserId,
                         clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            txtCode.Text = strCodeText;
            txtFileName4GenCode.Text = strClsName;
            txtCodePath.Text = strCodePath;
            tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
            MessageBox.Show("生成完成！共计：" + intCount.ToString() + "个表。");
            BindLv_vPrjTab(false);

        }

        private void btnGenWebServiceTransCode_Click(object sender, EventArgs e)
        {
            List<string> arrTabIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvPrjTab.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrTabIdLst.Add(strTabId);
            }

            if (arrTabIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
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
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            string strClsName = "";
            string strCodePath = "";
            string strCodeText = "";
            lblMsg.Text = "";
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0010", "01", clsPubVar.CurrSelPrjId);

                    strCodeText = clsPrjTabBLEx.GenWebServiceTransCode(strTabId, clsPubVar.objCurrSelProjectEN, clsPubVar.CurrPrjDataBaseId,
                        clsSysParaEN.strUserId,
                         clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                         strCharEncodingId, mltLangType, mdbtDataBaseType, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                }
            }
            txtCode.Text = strCodeText;
            txtFileName4GenCode.Text = strClsName;
            txtCodePath.Text = strCodePath;
            tabControl1.SelectedIndex = 1;//.TabPages[1].Focus();
            MessageBox.Show("生成完成！共计：" + intCount.ToString() + "个表。");
            BindLv_vPrjTab(false);

        }

        private void btnQueryNoTimelyGeneTabs_Click(object sender, EventArgs e)
        {
            BindLv_vPrjTab(true);
        }

        private void rbDotNet_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDotNet.Checked == true)
            { 
                mltLangType = clsPubConst.LangType.CSharp;
            }          
        }

        private void rbJava_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJava.Checked == true)
            {
                mltLangType = clsPubConst.LangType.JAVA;
            }
        }

        private void rbMsSql_CheckedChanged(object sender, EventArgs e)
        {
            GetDataBaseTypeByRadioButton();
        }
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
        private void rbSwift_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSwift.Checked == true)
            {
                mltLangType = clsPubConst.LangType.Swift;
            }
        }

        private void rbJavaScript_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJavaScript.Checked == true)
            {
                mltLangType = clsPubConst.LangType.JavaScript;
            }
        }

        private void rbSilverLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSilverLight.Checked == true)
            {
                mltLangType = clsPubConst.LangType.SilverLight;
            }
        }
    }
}