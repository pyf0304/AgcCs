///生成与表相关的控件控制层代码
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.util;
using CommFunc4Win;
using AGC.Entity;
using System.Collections.Generic;
using AGC4WApi;

namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmUserPrjGrant_QD_LV : System.Windows.Forms.Form, IBindListView
    {
        //clsUserPrjGrantEN objUserPrjGrant = null;
        private System.Data.DataTable objDTUserPrjGrant = null;
        private clsListViewSorter objvUserPrjGrantSorter;
        private int intLastSelectedvUserPrjGrantColumIndex;
        public frmUserPrjGrant_QD_LV()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvUserPrjGrantSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvUserPrjGrant.ListViewItemSorter = objvUserPrjGrantSorter;
            objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmUserPrjGrant_QD_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            ///1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();
            BindLv_vUserPrjGrant();
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            clsUsersWApi.BindCbo_UserId(this.ddlUserId);
            clsProjectsWApi.BindCbo_PrjId(this.ddlPrjId);
            clsUserRolesWApi.BindCbo_RoleId(this.ddlRoleId);
        }
        public string UserId
        {
            get
            {
                if (ddlUserId.SelectedValue.ToString() == "0")
                    return "";
                return ddlUserId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    ddlUserId.SelectedValue = "0";
                }
                else
                {
                    ddlUserId.SelectedValue = value;
                }
            }
        }

        public string PrjId
        {
            get
            {
                if (ddlPrjId.SelectedValue.ToString() == "0")
                    return "";
                return ddlPrjId.SelectedValue.ToString();
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

        public string RoleId
        {
            get
            {
                if (ddlRoleId.SelectedValue.ToString() == "0")
                    return "";
                return ddlRoleId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    ddlRoleId.SelectedValue = "0";
                }
                else
                {
                    ddlRoleId.SelectedValue = value;
                }
            }
        }


        public void Clear()
        {
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            ddlRoleId.SelectedIndex = 0;
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
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            ddlRoleId.SelectedIndex = 0;
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
         public void SetCbo_UserId()
        {
            clsUsersWApi.BindCbo_UserId(ddlUserId);
        }
        public void SetCbo_PrjId()
        {
            clsProjectsWApi.BindCbo_PrjId(ddlPrjId);
        }
        public void SetCbo_RoleId()
        {
            clsUserRolesWApi.BindCbo_RoleId(ddlRoleId);
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
        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion()
        {
            ///使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            ///例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            ///如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserPrjGrant.UserId='" + this.ddlUserId.SelectedValue + "'";
            }
            if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserPrjGrant.PrjId='" + this.ddlPrjId.SelectedValue + "'";
            }
            if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserPrjGrant.RoleId='" + this.ddlRoleId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion(bool bolIsWithTabName)
        {
            ///使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            ///例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            ///如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (bolIsWithTabName == true)
            {
                if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserPrjGrant.UserId='" + this.ddlUserId.SelectedValue + "'";
                }
                if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserPrjGrant.PrjId='" + this.ddlPrjId.SelectedValue + "'";
                }
                if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserPrjGrant.RoleId='" + this.ddlRoleId.SelectedValue + "'";
                }
            }
            else
            {
                if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserId='" + this.ddlUserId.SelectedValue + "'";
                }
                if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.ddlPrjId.SelectedValue + "'";
                }
                if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And RoleId='" + this.ddlRoleId.SelectedValue + "'";
                }
            }
            return strWhereCond;
        }
        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion(string strTabName)
        {
            ///使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            ///例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            ///如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".UserId='" + this.ddlUserId.SelectedValue + "'";
            }
            if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".PrjId='" + this.ddlPrjId.SelectedValue + "'";
            }
            if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".RoleId='" + this.ddlRoleId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        /// <summary>
        /// 函数功能：用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvUserPrjGrant.SelectedItems.Count >= 1)
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
            if (this.lvvUserPrjGrant.SelectedItems.Count >= 1)
            {
                this.btnUpdate.Enabled = true;
            }
            else
            {
                this.btnUpdate.Enabled = false;
            }
        }
       
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void BindLv_vUserPrjGrant()
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            ListViewItem lvivUserPrjGrant;
            List<clsvUserPrjGrantEN> arrvUserPrjGrantObjList;
            ///	1、组合界面条件串；
            string strWhereCond = this.CombineUserPrjGrantCondion(false);	//  CombineUserPrjGrantCondion();
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrvUserPrjGrantObjList =  clsvUserPrjGrantWApi.GetObjLst(strWhereCond);
            ///	3、设置ListView的列头信息
            this.lvvUserPrjGrant.Items.Clear();//清除原来所有Item
            this.lvvUserPrjGrant.Columns.Clear();//清除原来所有列头信息
            this.lvvUserPrjGrant.Columns.Add("用户名", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("项目名称", 240, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("角色名称", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("访问数", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("部门名", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("用户状态名", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("操作者Id", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("操作日期", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("备注", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.View = View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvUserPrjGrantEN objvUserPrjGrant in arrvUserPrjGrantObjList)
            {
                lvivUserPrjGrant = new ListViewItem();
                lvivUserPrjGrant.Tag = objvUserPrjGrant.mId;
                lvivUserPrjGrant.Text = objvUserPrjGrant.UserName;
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.PrjName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.RoleName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.VisitedNum.ToString());
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.DepartmentName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.UserStateName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptId);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptDate);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.Memo);
                this.lvvUserPrjGrant.Items.Add(lvivUserPrjGrant);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvUserPrjGrantObjList.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vUserPrjGrant();
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strmId = objDTUserPrjGrant.Rows[intCurrRow]["mId"].ToString();
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
            ListViewItem lviUserPrjGrant;
            lviUserPrjGrant = objListView.SelectedItems[0];
            string strUserPrjGrantId = lviUserPrjGrant.Tag.ToString();
            long lngmId = long.Parse(strUserPrjGrantId);
            return lngmId;
        }

        /// <summary>
        /// 获取ListView中当前行的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListViewItem objListViewItem)
        {
            string strUserPrjGrantId = objListViewItem.Tag.ToString();
            long lngmId = long.Parse(strUserPrjGrantId);
            return lngmId;
        }
        private void lvvUserPrjGrant_Click(object sender, System.EventArgs e)
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
            UpdateUserPrjGrantRecord();
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteUserPrjGrantRecord();
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
            ///	1、组合界面条件串；
            string strWhereCond = this.CombineUserPrjGrantCondion(true);
            ///	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsUserPrjGrantWApi.GetDataTable_UserPrjGrantV(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "UserPrjGrant信息导出.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("UserName"); arrCnName.Add("用户名");
            arrColName.Add("PrjName"); arrCnName.Add("项目名称");
            arrColName.Add("RoleName"); arrCnName.Add("角色名称");
            arrColName.Add("DepartmentName"); arrCnName.Add("部门名");
            arrColName.Add("UserStateName"); arrCnName.Add("用户状态名");
            arrColName.Add("VisitedNum"); arrCnName.Add("访问数");
            arrColName.Add("OptDate"); arrCnName.Add("操作日期");
            arrColName.Add("OptId"); arrCnName.Add("操作者Id");
            arrColName.Add("Memo"); arrCnName.Add("备注");
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
            ///	1、组合界面条件串；
            string strWhereCond = this.CombineUserPrjGrantCondion(true);
            ///	2、设置表列数据字段名，以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("UserName"); arrCnName.Add("用户名");
            arrColName.Add("PrjName"); arrCnName.Add("项目名称");
            arrColName.Add("RoleName"); arrCnName.Add("角色名称");
            arrColName.Add("DepartmentName"); arrCnName.Add("部门名");
            arrColName.Add("UserStateName"); arrCnName.Add("用户状态名");
            arrColName.Add("VisitedNum"); arrCnName.Add("访问数");
            arrColName.Add("OptDate"); arrCnName.Add("操作日期");
            arrColName.Add("OptId"); arrCnName.Add("操作者Id");
            arrColName.Add("Memo"); arrCnName.Add("备注");
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
            frm1.strTableName = "vUserPrjGrant";
            frm1.strTableChineseName = "vUserPrjGrant";
            frm1.strViewName = "用户项目授权维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvUserPrjGrant_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvUserPrjGrantSorter.SortColumn)
            {

            }
            else
            {
                this.objvUserPrjGrantSorter.SortColumn = e.Column;
            }

            if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column)
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvUserPrjGrant.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vUserPrjGrant();
        }
        ///生成修改记录准备过程代码 for C#
        private void UpdateUserPrjGrantRecord()
        {
            if (this.lvvUserPrjGrant.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            string strKeyId = this.lvvUserPrjGrant.SelectedItems[0].Tag.ToString();
            frm.mId_key = long.Parse(strKeyId);
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        ///删除记录过程代码for C#
        private void DeleteUserPrjGrantRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvUserPrjGrant.SelectedItems)
                {
                    long lngmId = GetCurrKey(lvi);
                    if (clsUserPrjGrantWApi.DelRecord(lngmId) == 0)
                    {
                        MessageBox.Show("删除记录失败！");
                        BindLv_vUserPrjGrant();
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vUserPrjGrant();
            }
        }
    }
}