
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/14
///生成者：潘以锋
///工程名称：AGC_CSV7
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

namespace AGC_CSV7
{
    /// <summary>
    ///		frmViewInfo_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmViewInfo_QD_LV : System.Windows.Forms.Form, IBindListView
    {
        clsViewInfoEN objViewInfoEN = null;
        private System.Data.DataTable objDTViewInfo = null;
        private clsListViewSorter objvViewInfoSorter;
        private int intLastSelectedvViewInfoColumIndex;
        public frmViewInfo_QD_LV()
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
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseByPrjDataBaseId(clsPubVar.CurrPrjDataBaseId);

            this.Text = string.Format("界面代码生成20141003----工程：{0}({1})  数据库：{2}({3})", clsPubVar.objCurrSelProjectEN.PrjName, clsPubVar.objCurrSelProjectEN.PrjId,
                                objPrjDataBaseEN.PrjDataBaseName, objPrjDataBaseEN.PrjDataBaseId);

            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();

            string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            cboCharEncodingId.SelectedValue = strCharEncodingId;

            cboPrjId.SelectedValue = clsPubVar.CurrSelPrjId;
            cboPrjId.Enabled = false;
            cboApplicationTypeId.SelectedValue = clsApplicationTypeBLEx.DOTNETWEBAPP;
            BindLv_vViewInfo();
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
        

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            clsViewTypeCodeTabBL.BindCbo_ViewTypeCode(this.cboViewTypeCode);
            clsApplicationTypeBL.BindCbo_ApplicationTypeId(this.cboApplicationTypeId);
            clsFuncModuleBLEx.BindCbo_FuncModuleId(this.cboFuncModuleId, clsPubVar.CurrSelPrjId);
            clsProjectsBL.BindCbo_PrjId(this.cboPrjId);
            clsPrjTabBLEx.BindCbo_TabIdEx(this.cboMainTabId, clsPubVar.CurrSelPrjId);
            clsCharEncodingBL.BindCbo_CharEncodingId(cboCharEncodingId);
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

        public string ViewTypeCode
        {
            get
            {
                if (cboViewTypeCode.SelectedValue.ToString() == "0")
                    return "";
                return cboViewTypeCode.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboViewTypeCode.SelectedValue = "0";
                }
                else
                {
                    cboViewTypeCode.SelectedValue = value;
                }
            }
        }

        public string ApplicationTypeId
        {
            get
            {
                if (cboApplicationTypeId.SelectedValue.ToString() == "0")
                    return "";
                return cboApplicationTypeId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboApplicationTypeId.SelectedValue = "0";
                }
                else
                {
                    cboApplicationTypeId.SelectedValue = value;
                }
            }
        }

        public string FuncModuleId
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
            cboViewTypeCode.SelectedIndex = 0;
            cboApplicationTypeId.SelectedIndex = 0;
            cboFuncModuleId.SelectedIndex = 0;
            cboPrjId.SelectedIndex = 0;
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
            cboViewTypeCode.SelectedIndex = 0;
            cboApplicationTypeId.SelectedIndex = 0;
            cboFuncModuleId.SelectedIndex = 0;
            cboPrjId.SelectedIndex = 0;
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
        public System.Data.DataTable GetViewTypeCode()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_ViewTypeCode(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetViewTypeCode();
            clsViewTypeCodeTabEN objViewTypeCodeTabEN;
            //初始化一个对象列表
            ArrayList ViewTypeCodeTabList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
            objViewTypeCodeTabEN.ViewTypeCode = 0;
            objViewTypeCodeTabEN.ViewTypeName = "请选择...";
            ViewTypeCodeTabList.Add(objViewTypeCodeTabEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
                objViewTypeCodeTabEN.ViewTypeCode = int.Parse( objRow["ViewTypeCode"].ToString());
                objViewTypeCodeTabEN.ViewTypeName = objRow["ViewTypeName"].ToString();
                ViewTypeCodeTabList.Add(objViewTypeCodeTabEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = ViewTypeCodeTabList;
            objComboBox.ValueMember = "ViewTypeCode";
            objComboBox.DisplayMember = "ViewTypeName";
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
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetUserId();
            clsUsersEN objUsersEN;
            //初始化一个对象列表
            ArrayList UsersList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objUsersEN = new clsUsersEN();
            objUsersEN.UserId = "0";
            objUsersEN.UserName = "请选择...";
            UsersList.Add(objUsersEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objUsersEN = new clsUsersEN();
                objUsersEN.UserId = objRow["UserId"].ToString();
                objUsersEN.UserName = objRow["UserName"].ToString();
                UsersList.Add(objUsersEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = UsersList;
            objComboBox.ValueMember = "UserId";
            objComboBox.DisplayMember = "UserName";
            objComboBox.SelectedIndex = 0;
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
        public System.Data.DataTable GetDetailTabId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabId, TabName from PrjTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_DetailTabId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetDetailTabId();
            clsPrjTabEN objPrjTabEN;
            //初始化一个对象列表
            ArrayList PrjTabList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objPrjTabEN = new clsPrjTabEN();
            objPrjTabEN.TabId = "0";
            objPrjTabEN.TabName = "请选择...";
            PrjTabList.Add(objPrjTabEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjTabEN = new clsPrjTabEN();
                objPrjTabEN.TabId = objRow["TabId"].ToString();
                objPrjTabEN.TabName = objRow["TabName"].ToString();
                PrjTabList.Add(objPrjTabEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjTabList;
            objComboBox.ValueMember = "TabId";
            objComboBox.DisplayMember = "TabName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetViewGroupId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_ViewGroupId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetViewGroupId();
            clsViewGroupEN objViewGroupEN;
            //初始化一个对象列表
            ArrayList ViewGroupList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objViewGroupEN = new clsViewGroupEN();
            objViewGroupEN.ViewGroupId = "0";
            objViewGroupEN.ViewGroupName = "请选择...";
            ViewGroupList.Add(objViewGroupEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objViewGroupEN = new clsViewGroupEN();
                objViewGroupEN.ViewGroupId = objRow["ViewGroupId"].ToString();
                objViewGroupEN.ViewGroupName = objRow["ViewGroupName"].ToString();
                ViewGroupList.Add(objViewGroupEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = ViewGroupList;
            objComboBox.ValueMember = "ViewGroupId";
            objComboBox.DisplayMember = "ViewGroupName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetINRelaTabId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabId, TabName from PrjTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_INRelaTabId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetINRelaTabId();
            clsPrjTabEN objPrjTabEN;
            //初始化一个对象列表
            ArrayList PrjTabList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objPrjTabEN = new clsPrjTabEN();
            objPrjTabEN.TabId = "0";
            objPrjTabEN.TabName = "请选择...";
            PrjTabList.Add(objPrjTabEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjTabEN = new clsPrjTabEN();
                objPrjTabEN.TabId = objRow["TabId"].ToString();
                objPrjTabEN.TabName = objRow["TabName"].ToString();
                PrjTabList.Add(objPrjTabEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjTabList;
            objComboBox.ValueMember = "TabId";
            objComboBox.DisplayMember = "TabName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetINSQLDSTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select OUTSQLDSTypeId, SqlDsTypeName from SQLDSType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_INSQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetINSQLDSTypeId();
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
            objComboBox.ValueMember = "OUTSQLDSTypeId";
            objComboBox.DisplayMember = "SqlDsTypeName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetOUTRelaTabId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabId, TabName from PrjTab ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_OUTRelaTabId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetOUTRelaTabId();
            clsPrjTabEN objPrjTabEN;
            //初始化一个对象列表
            ArrayList PrjTabList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objPrjTabEN = new clsPrjTabEN();
            objPrjTabEN.TabId = "0";
            objPrjTabEN.TabName = "请选择...";
            PrjTabList.Add(objPrjTabEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjTabEN = new clsPrjTabEN();
                objPrjTabEN.TabId = objRow["TabId"].ToString();
                objPrjTabEN.TabName = objRow["TabName"].ToString();
                PrjTabList.Add(objPrjTabEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjTabList;
            objComboBox.ValueMember = "TabId";
            objComboBox.DisplayMember = "TabName";
            objComboBox.SelectedIndex = 0;
        }
        public System.Data.DataTable GetOUTSQLDSTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select SQLDSTypeId, SqlDsTypeName from SQLDSType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindCbo_OUTSQLDSTypeId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetOUTSQLDSTypeId();
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
        public void SetCbo_ViewTypeCode()
        {
            clsViewTypeCodeTabBL.BindCbo_ViewTypeCode(cboViewTypeCode);
        }
        public void SetCbo_ApplicationTypeId()
        {
            clsApplicationTypeBL.BindCbo_ApplicationTypeId(cboApplicationTypeId);
        }
        public void SetCbo_FuncModuleId()
        {
            clsFuncModuleBL.BindCbo_FuncModuleId(cboFuncModuleId);
        }
        public void SetCbo_PrjId()
        {
            clsProjectsBL.BindCbo_PrjId(cboPrjId);
        }
        public void SetCbo_MainTabId()
        {
            clsPrjTabBLEx.BindCbo_TabIdEx(cboMainTabId, clsPubVar.CurrSelPrjId);
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
        public string CombineViewInfoCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtViewName.Text.Trim() != "")
            {
                strWhereCond += " And ViewInfo.ViewName like '%" + this.txtViewName.Text.Trim() + "%'";
            }
            if (this.cboViewTypeCode.SelectedValue.ToString() != "" && this.cboViewTypeCode.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ViewInfo.ViewTypeCode='" + this.cboViewTypeCode.SelectedValue + "'";
            }
            if (this.cboApplicationTypeId.SelectedValue.ToString() != "" && this.cboApplicationTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ViewInfo.ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue + "'";
            }
            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ViewInfo.FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ViewInfo.PrjId='" + this.cboPrjId.SelectedValue + "'";
            }
            if (this.cboMainTabId.SelectedValue.ToString() != "" && this.cboMainTabId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ViewInfo.MainTabId='" + this.cboMainTabId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineViewInfoCondion(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" 1=1 ");
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithTabName == true)
            {
                if (this.txtViewName.Text.Trim() != "")
                {
                    strWhereCond += " And ViewInfo.ViewName like '%" + this.txtViewName.Text.Trim() + "%'";
                }
                if (this.cboViewTypeCode.SelectedValue.ToString() != "" && this.cboViewTypeCode.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ViewInfo.ViewTypeCode='" + this.cboViewTypeCode.SelectedValue + "'";
                }
                if (this.cboApplicationTypeId.SelectedValue.ToString() != "" && this.cboApplicationTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ViewInfo.ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue + "'";
                }
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ViewInfo.FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ViewInfo.PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboMainTabId.SelectedValue.ToString() != "" && this.cboMainTabId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ViewInfo.MainTabId='" + this.cboMainTabId.SelectedValue + "'";
                }
            }
            else
            {
                if (this.txtViewName.Text.Trim() != "")
                {
                    strWhereCond += " And ViewName like '%" + this.txtViewName.Text.Trim() + "%'";
                }
                if (this.cboViewTypeCode.SelectedValue.ToString() != "" && this.cboViewTypeCode.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ViewTypeCode='" + this.cboViewTypeCode.SelectedValue + "'";
                }
                if (this.cboApplicationTypeId.SelectedValue.ToString() != "" && this.cboApplicationTypeId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue + "'";
                }
                if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
                }
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
                if (this.cboMainTabId.SelectedValue.ToString() != "" && this.cboMainTabId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And MainTabId='" + this.cboMainTabId.SelectedValue + "'";
                }
            }
            return strWhereCond;
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineViewInfoCondion(string strTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtViewName.Text.Trim() != "")
            {
                strWhereCond += " And " + strTabName + ".ViewName like '%" + this.txtViewName.Text.Trim() + "%'";
            }
            if (this.cboViewTypeCode.SelectedValue.ToString() != "" && this.cboViewTypeCode.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".ViewTypeCode='" + this.cboViewTypeCode.SelectedValue + "'";
            }
            if (this.cboApplicationTypeId.SelectedValue.ToString() != "" && this.cboApplicationTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue + "'";
            }
            if (this.cboFuncModuleId.SelectedValue.ToString() != "" && this.cboFuncModuleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".FuncModuleId='" + this.cboFuncModuleId.SelectedValue + "'";
            }
            if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".PrjId='" + this.cboPrjId.SelectedValue + "'";
            }
            if (this.cboMainTabId.SelectedValue.ToString() != "" && this.cboMainTabId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".MainTabId='" + this.cboMainTabId.SelectedValue + "'";
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
       
        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vViewInfo()
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivViewInfo;
            List<clsvViewInfo4GeneCodeEN> arrvViewInfoObjList;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineViewInfoCondion(false);	//  CombineViewInfoCondion();
            //strWhereCond += "[Exclude]or [/Exclude]";
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvViewInfoObjList = clsvViewInfo4GeneCodeBLEx.GetvViewInfo4GeneCodeObjListByUserIdAndCondition(clsSysParaEN.strUserId, strWhereCond);
            //	3、设置ListView的列头信息
            this.lvvViewInfo.Items.Clear();//清除原来所有Item
            this.lvvViewInfo.Columns.Clear();//清除原来所有列头信息
            //this.lvvViewInfo.Columns.Add("界面ID", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("应用类型", 80, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("界面名称", 280, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("生成时间", 120, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("版本", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("界面类型", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("功能模块", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("界面主表", 150, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("主表关键字", 100, HorizontalAlignment.Left);
            //this.lvvViewInfo.Columns.Add("工程名称", 100, HorizontalAlignment.Left);
            this.lvvViewInfo.Columns.Add("区域数", 100, HorizontalAlignment.Left);

            this.lvvViewInfo.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvViewInfo4GeneCodeEN objvViewInfoEN in arrvViewInfoObjList)
            {
                lvivViewInfo = new ListViewItem();
                lvivViewInfo.Tag = objvViewInfoEN.ViewId;
                lvivViewInfo.Text = objvViewInfoEN.ApplicationTypeName.Substring(0, 5);
                //lvivViewInfo.SubItems.Add(objvViewInfoEN.ApplicationTypeName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.ViewName);

                lvivViewInfo.SubItems.Add(objvViewInfoEN.GeneCodeDate);

                lvivViewInfo.SubItems.Add(objvViewInfoEN.Version_GeneCode);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.UpdDate);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.ViewTypeName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.FuncModuleName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.MainTabName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.KeyForMainTab);

                //lvivViewInfo.SubItems.Add(objvViewInfoEN.PrjName);
                lvivViewInfo.SubItems.Add(objvViewInfoEN.RegionNum.ToString());

                this.lvvViewInfo.Items.Add(lvivViewInfo);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvViewInfoObjList.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vViewInfo();
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
            string strWhereCond = this.CombineViewInfoCondion(true);
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsViewInfoBL.GetDataTable_ViewInfo(strWhereCond);
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
            arrColName.Add("FuncModuleId"); arrCnName.Add("功能模块Id");
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
            string strWhereCond = this.CombineViewInfoCondion(true);
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
            arrColName.Add("FuncModuleId"); arrCnName.Add("功能模块Id");
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
                    if (clsViewInfoBL.DelRecord(strViewId) == false)
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

        private void btnCtlViewCode_Web_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
                return;
            }
            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            if (cboCharEncodingId.SelectedIndex <= 0)
            {
                lblMsg.Text = "请选择一个生成文件的字符编码!";
                MessageBox.Show(lblMsg.Text);
                return;
            }

            string strCharEncodingId = cboCharEncodingId.SelectedValue.ToString();
            //保存当前选择的字符编码
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            try
            {
                string strNetVersion = "Net2010";
                
                clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0005", "01", clsPubVar.CurrSelPrjId);

                strCodeText = clsViewInfoBLEx.GeneCtlViewCode(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName,
                     objUserCodePathEN.CodePath, "",
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);

            

                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《表控件View代码》完成！");
        }

        private void btnCtlControlCode_Web_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
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

            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0005", "01", clsPubVar.CurrSelPrjId);

            try
            {
                string strNetVersion = "Net2010";
                
                strCodeText = clsViewInfoBLEx.GeneCtlControlCode(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《表控件Control代码》完成！");

        }

        private void btnGenViewCode_Web_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
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

            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            try
            {
                string strNetVersion = "Net2010";
               
                clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0004", "01", clsPubVar.CurrSelPrjId);

                strCodeText = clsViewInfoBLEx.GeneViewCode(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName,
                     objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《界面View代码》完成！");

        }

        private void btnGenControlCode_Web_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
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

            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0004", "01", clsPubVar.CurrSelPrjId);

            try
            {
                string strNetVersion = "Net2010";
                
                strCodeText = clsViewInfoBLEx.GeneControlCode(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《界面View代码》完成！");

        }

        private void btnGenViewCode_Win_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
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

            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0006", "01", clsPubVar.CurrSelPrjId);

            try
            {
                string strNetVersion = "Net2010";
               
                strCodeText = clsViewInfoBLEx.GeneGenViewCode_Win(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName,
                     objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                     chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《Win界面代码》完成！");

        }
        private enumViewTypeCodeTab GetViewTypeCodeStr()
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
            enumViewTypeCodeTab strViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_ListView;// "0011";
            //if (rbViewTypeCode01.Checked == true)
            //{
            //    //单表的QUDI_LV,0008
            //    strViewTypeCode = enumViewTypeCodeTab.Table_QUDI_LV;// "0008";
            //}
            if (rbViewTypeCode02.Checked == true)
            {
                //单表组合界面_ListView,0011
                strViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_ListView;// "0011";
            }
            else if (rbViewTypeCode03.Checked == true)
            {
                //单表组合界面_GridView,0020
                strViewTypeCode = enumViewTypeCodeTab.Table_QD_InvokeUI_GridView;// "0020";
            }
            else if (rbViewTypeCode04.Checked == true)
            {
                //单表插入,0012
                strViewTypeCode = enumViewTypeCodeTab.Table_Insert;// "0012";
            }
            else if (rbViewTypeCode05.Checked == true)
            {
                //单表查询
                strViewTypeCode = enumViewTypeCodeTab.Table_Query;// "0008";
            }
            return strViewTypeCode;
        }

        private void btnGenViewDesignCode_Win_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
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

            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0006", "01", clsPubVar.CurrSelPrjId);

            try
            {
                string strNetVersion = "Net2010";
               
                strCodeText = clsViewInfoBLEx.GeneGenViewDesignCode_Win(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName,
                     objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                     chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《win界面设计代码》完成！");

        }

        private void btnGenViewCode_Sub_Win_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
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

            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0006", "01", clsPubVar.CurrSelPrjId);

            try
            {
                string strNetVersion = "Net2010";
               
                strCodeText = clsViewInfoBLEx.GeneGenViewCode_Sub_Win(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName,
                     objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                     chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《win子界面代码》完成！");

        }

        private void btnGenViewDesignCode_Sub_Win_Click(object sender, EventArgs e)
        {
            if (this.lvvViewInfo.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }

            string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
            string strViewId = strKeyId;
            if (strViewId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
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

            lblMsg.Text = "";
            string strFileName4GenCode = "";
            string strClsName = "";
            string strCodeText;
            string strCodePath = "";
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0006", "01", clsPubVar.CurrSelPrjId);

            try
            {
                string strNetVersion = "Net2010";
              
                strCodeText = clsViewInfoBLEx.GeneGenViewDesignCode_Sub_Win(strViewId, strNetVersion,
                    clsPubVar.objCurrSelProjectEN,
                      clsSysParaEN.strUserId,
                     clsSysParaEN.strUserName,
                     objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                     chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                   ref strFileName4GenCode, ref strClsName, ref strCodePath);
                txtCode.Text = strCodeText;
                txtFileName4GenCode.Text = strClsName;
                txtCodePath.Text = strCodePath;
                tabViewInfoListCode.SelectedIndex = 1;
            }
            catch (Exception objException)
            {
                lblMsg.Text = objException.Message;
                MessageBox.Show(objException.Message);
            }
            MessageBox.Show("生成《win子界面设计代码》完成！");

        }

        private void btnGeneAllViewCode_Win_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            List<string> arrViewIdLst = clsViewInfoBL.funGetFldValue("ViewId", string.Format("PrjId='{0}' And ApplicationTypeId='02'", clsPubVar.CurrSelPrjId));


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

            //保存当前选择的字符编码
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            string strClsName = "";
            string strFileName4GenCode = "";
            string strCodeText;
            string strCodePath = "";
            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0007", "01", clsPubVar.CurrSelPrjId);
            List<string> arrErrorLst = new List<string>();
            foreach (string strViewId in arrViewIdLst)
            {
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneCtlViewCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneCtlControlCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneViewCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneControlCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }

            }

            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成完成！共计：{0}个界面。\r\n", intCount);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());

        }

        private void btnGeneCheckedViewCode_Win_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            List<string> arrViewIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvViewInfo.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrViewIdLst.Add(strTabId);
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

            //保存当前选择的字符编码
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            string strClsName = "";
            string strFileName4GenCode = "";
            string strCodeText;
            string strCodePath = "";
            string strNetVersion = "Net2010";
           

            clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0006", "01", clsPubVar.CurrSelPrjId);
            List<string> arrErrorLst = new List<string>();
            foreach (string strViewId in arrViewIdLst)
            {
                //生成主界面代码

                try
                {
                    strCodeText = clsViewInfoBLEx.GeneGenViewCode_Win(strViewId, strNetVersion,
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName,
                        objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }
                //生成主界面设计代码
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneGenViewDesignCode_Win(strViewId, strNetVersion,
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName,
                        objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }
                //生成子界面代码
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneGenViewCode_Sub_Win(strViewId, strNetVersion,
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName,
                        objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }
                //生成子界面设计代码
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneGenViewDesignCode_Sub_Win(strViewId, strNetVersion,
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName,
                        objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        chkIsUseCtrl.Checked, GetViewTypeCodeStr(), strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Win_Click", objException.Message, clsSysParaEN.strUserId);
                }
            }
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成完成！共计：{0}个界面。\r\n", intCount);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());
        }

        private void btnGeneAllViewCode_Web_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            List<string> arrViewIdLst = clsViewInfoBL.funGetFldValue("ViewId", string.Format("PrjId='{0}' And ApplicationTypeId='02'", clsPubVar.CurrSelPrjId));


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

            //保存当前选择的字符编码
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);

            int intCount = 0;
            string strClsName = "";
            string strFileName4GenCode = "";
            string strCodeText;
            string strCodePath = "";
            List<string> arrErrorLst = new List<string>();
            foreach (string strViewId in arrViewIdLst)
            {
                clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0005", "01", clsPubVar.CurrSelPrjId);

                try
                {

                    strCodeText = clsViewInfoBLEx.GeneCtlViewCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneCtlControlCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }

                objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0004", "01", clsPubVar.CurrSelPrjId);

                try
                {
                    strCodeText = clsViewInfoBLEx.GeneViewCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneControlCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneAllViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }

            }
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成完成！共计：{0}个界面。\r\n", intCount);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());


        }

        private void btnGeneCheckedViewCode_Web_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            List<string> arrViewIdLst = new List<string>();
            foreach (ListViewItem lvi in this.lvvViewInfo.SelectedItems)
            {
                string strTabId = GetCurrKey(lvi);
                arrViewIdLst.Add(strTabId);
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

            //保存当前选择的字符编码
            clsPubFun.SaveCharEncodingId4PrjUser(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strCharEncodingId);


            int intCount = 0;
            string strClsName = "";
            string strFileName4GenCode = "";
            string strCodeText;
            string strCodePath = "";
            List<string> arrErrorLst = new List<string>();
            foreach (string strViewId in arrViewIdLst)
            {
                clsUserCodePathEN objUserCodePathEN = null;
                try
                {
                    objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0005", "01", clsPubVar.CurrSelPrjId);
                    if (Directory.Exists(objUserCodePathEN.CodePathBackup) == false)
                    {
                        Directory.CreateDirectory(objUserCodePathEN.CodePathBackup);
                    }
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                    return;
                }

                try
                {
                    strCodeText = clsViewInfoBLEx.GeneCtlViewCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneCtlControlCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }

               try
                {
                    objUserCodePathEN = clsUserCodePathBLEx.GetUserCodePathObjByCodeTypeId("0004", "01", clsPubVar.CurrSelPrjId);
                    if (Directory.Exists(objUserCodePathEN.CodePathBackup) == false)
                    {
                        Directory.CreateDirectory(objUserCodePathEN.CodePathBackup);
                    }
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                    return;
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneViewCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }
                try
                {
                    strCodeText = clsViewInfoBLEx.GeneControlCode(strViewId, "Net2010",
                        clsPubVar.objCurrSelProjectEN,
                        clsSysParaEN.strUserId,
                        clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup, strCharEncodingId,
                        ref strFileName4GenCode, ref strClsName, ref strCodePath);
                    intCount++;
                }
                catch (Exception objException)
                {
                    arrErrorLst.Add(objException.Message);
                    lblMsg.Text = objException.Message;
                    //MessageBox.Show(objException.Message);
                    ErrorInformationBL.AddInformation("frmViewInfo_QD_LV.aspx", "btnGeneCheckedViewCode_Web_Click", objException.Message, clsSysParaEN.strUserId);
                }
            }
            StringBuilder sbMsg = new StringBuilder();
            sbMsg.AppendFormat("生成完成！共计：{0}个界面。\r\n", intCount);
            foreach (string strMsg in arrErrorLst)
            {
                sbMsg.AppendFormat("{0}\r\n", strMsg);
            }
            MessageBox.Show(sbMsg.ToString());

        }

        private void cboApplicationTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboApplicationTypeId.SelectedIndex < 0) return;
            int strAppTypeId = int.Parse( cboApplicationTypeId.SelectedValue.ToString());
            if (strAppTypeId == clsApplicationTypeBLEx.DOTNETWEBAPP)
            {
                tabAppType.SelectedIndex = 0;
            }
            else if (strAppTypeId == clsApplicationTypeBLEx.WINDOWSAPP)
            {
                tabAppType.SelectedIndex = 1;
            }
            else if (strAppTypeId == clsApplicationTypeBLEx.JAVAWEBAPP)
            {
                tabAppType.SelectedIndex = 2;
            }

        }

    }
}