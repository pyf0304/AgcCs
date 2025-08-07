
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AGC.Entity;
using AGC.frm;
using Agc_CsWin;
using AGC_CSWin;
using AGC4WApi;
using com.taishsoft.datetime;
using com.taishsoft.util;
using CommFunc4Win;

namespace AGC
{

    /// <summary>
    ///		frmUserCodePath_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmUserCodePath_QD_LV : System.Windows.Forms.Form, IBindListView
    {
        //clsUserCodePathEN objUserCodePathEN = null;
        private System.Data.DataTable objDTUserCodePath = null;
        private clsListViewSorter objvUserCodePathSorter;
        private int intLastSelectedvUserCodePathColumIndex;
        public frmUserCodePath_QD_LV()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvUserCodePathSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvUserCodePath.ListViewItemSorter = objvUserCodePathSorter;
            objvUserCodePathSorter.SortOrder = SortOrder.Ascending;
            objvUserCodePathSorter.SortColumn = 2;// convUserCodePath.OrderNum;
        }
        private void frmUserCodePath_QD_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            if (clsSysParaEN.strUserRoleId == "00050001" || clsSysParaEN.strUserRoleId == "00050006")
            {
                chkEditTemplate.Visible = true;
            }
            else
            {
                chkEditTemplate.Visible = false;

            }
            this.Text = string.Format("{0}-代码生成路径设置－列表", clsPubVar.objCurrSelProjectEN.PrjName);
            this.SetAllComboBox();
            cboPrjId.SelectedValue = clsPubVar.CurrSelPrjId;
            cboPrjId.Enabled = false;
            //cboUserId.SelectedValue = clsSysParaEN.strUserId;
            //cboUserId.Enabled = false;
            //try
            //{
            //    clsUserCodePathExWApi.CopyUserCodePathFromTemplate(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
            //}
            //catch (Exception objException)
            //{
            //    MessageBox.Show(objException.Message);
            //    return;
            //}
            BindLv_vUserCodePath();
            ShowUserCodePrjMainPath(Environment.MachineName);
            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            //this.BindCbo_UserId(this.cboUserId);
            clsProjectsWApi.BindCbo_PrjId(this.cboPrjId);
            
            clsCMProjectAppRelaExWApi.BindCbo_CmPrjIdAppByPrjIdEx(this.cboCmPrjAppId, clsPubVar.CurrSelPrjId);


            clsvUserCodePrjMainPathExWApi.BindCbo_UserCodePrjMainPathIdByUserIdEx(this.cboUserCodePrjMainPathId, clsSysParaEN.strUserId, clsPubVar.CurrSelPrjId);
            

            clsProgLangTypeExWApi.BindCbo_ProgLangTypeIdEx(this.cboProgLangTypeId);

            clsCodeTypeExWApi.BindCbo_CodeTypeIdEx(this.cboCodeTypeId);
            clsComboBox_Common.BindCbo_TrueAndFalse(cboIsGeneCode);
        }
        //public string UserId
        //{
        //    get
        //    {
        //        if (cboUserId.SelectedValue.ToString() == "0")
        //            return "";
        //        return cboUserId.SelectedValue.ToString();
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            cboUserId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            cboUserId.SelectedValue = value;
        //        }
        //    }
        //}

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

        public string CodeTypeId
        {
            get
            {
                if (cboCodeTypeId.SelectedValue.ToString() == "0")
                    return "";
                return cboCodeTypeId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboCodeTypeId.SelectedValue = "0";
                }
                else
                {
                    cboCodeTypeId.SelectedValue = value;
                }
            }
        }


        public void Clear()
        {
            //cboUserId.SelectedIndex = 0;
            cboPrjId.SelectedIndex = 0;
            cboCodeTypeId.SelectedIndex = 0;
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
            //cboUserId.SelectedIndex = 0;
            cboPrjId.SelectedIndex = 0;
            cboCodeTypeId.SelectedIndex = 0;
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

        public void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            List<clsUsersEN> arrObj = clsUsersWApi.GetObjLst("1=1");
            clsUsersEN objUsersEN;
            //初始化一个对象列表
            ArrayList UsersList = new ArrayList();
            //插入第0项。在第0项中插入"请选择..."，为了方便用户，与WEB方式类似。
            objUsersEN = new clsUsersEN();
            objUsersEN.UserId = "0";
            objUsersEN.UserName = "请选择...";
            UsersList.Add(objUsersEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsUsersEN objRow in arrObj)
            {
                UsersList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = UsersList;
            objComboBox.ValueMember = "UserId";
            objComboBox.DisplayMember = "UserName";
            objComboBox.SelectedIndex = 0;
        }

        //public void SetCbo_UserId()
        //{
        //    clsUsersWApi.BindCbo_UserId(cboUserId);
        //}
        public void SetCbo_PrjId()
        {
            clsProjectsWApi.BindCbo_PrjId(cboPrjId);
        }
        public void SetCbo_CodeTypeId(string strProgLangTypeId)
        {
            clsCodeTypeWApi.BindCbo_CodeTypeId(cboCodeTypeId, strProgLangTypeId);
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
        public string CombineUserCodePathCondion(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            //            string strWhereCond = String.Format(" 1=1 and {0}='{1}'", convUserCodePath.MachineName, Environment.MachineName);
            string strWhereCond = String.Format(" 1=1 ");
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。


            if ((clsSysParaEN.strUserRoleId == "00050001" || clsSysParaEN.strUserRoleId == "00050006") && chkEditTemplate.Checked == true)
            {
                strWhereCond += " And PrjId='0000'";
            }
            else
            {
                //if (this.cboUserId.SelectedValue.ToString() != "" && this.cboUserId.SelectedValue.ToString() != "0")
                //{
                //    strWhereCond += " And UserId='" + this.cboUserId.SelectedValue + "'";
                //}
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
            }
            if (this.cboCodeTypeId.SelectedValue.ToString() != "" && this.cboCodeTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And CodeTypeId='" + this.cboCodeTypeId.SelectedValue + "'";
            }
            if (this.cboUserCodePrjMainPathId.SelectedValue.ToString() != "" && this.cboUserCodePrjMainPathId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserCodePrjMainPathId='" + this.cboUserCodePrjMainPathId.SelectedValue + "'";
            }
            if (this.cboCmPrjAppId.SelectedValue != null && this.cboCmPrjAppId.SelectedValue.ToString() != "" && this.cboCmPrjAppId.SelectedValue.ToString() != "0")
            {
                strWhereCond += $" And {conUserCodePath.CMProjectAppRelaId}={this.cboCmPrjAppId.SelectedValue}";
            }
            if (this.cboProgLangTypeId.SelectedValue.ToString() != "" && this.cboProgLangTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ProgLangTypeId='" + this.cboProgLangTypeId.SelectedValue + "'";
            }

            if (cboIsGeneCode.SelectedIndex == 1)
            {
                strWhereCond += string.Format(" And {0}='1'", convUserCodePath.IsGeneCode);
            }
            else if (cboIsGeneCode.SelectedIndex == 2)
            {
                strWhereCond += string.Format(" And {0}='0'", convUserCodePath.IsGeneCode);
            }

            return strWhereCond;
        }

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineUserCodePrjMainPath_MachineCondition(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = String.Format(" 1=1 and {0}='{1}'", conUserCodePrjMainPath_MachineName.MachineName, Environment.MachineName);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。

            //if (this.cboUserId.SelectedValue.ToString() != "" && this.cboUserId.SelectedValue.ToString() != "0")
            //{
            //    strWhereCond += $" And {conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId} in (select {conUserCodePrjMainPath.UserCodePrjMainPathId} from {conUserCodePrjMainPath._CurrTabName} where {conUserCodePrjMainPath.UserId}='{this.cboUserId.SelectedValue}')";
            //}
            if (this.cboCmPrjAppId.SelectedValue != null && this.cboCmPrjAppId.SelectedValue.ToString() != "" && this.cboCmPrjAppId.SelectedValue.ToString() != "0")
            {
                strWhereCond += $" And {conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId} in (select {conUserCodePrjMainPath.UserCodePrjMainPathId} from {conUserCodePrjMainPath._CurrTabName} where {conUserCodePrjMainPath.CMProjectAppRelaId}={this.cboCmPrjAppId.SelectedValue})";
            }
            if (this.cboUserCodePrjMainPathId.SelectedValue.ToString() != "" && this.cboUserCodePrjMainPathId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserCodePrjMainPathId='" + this.cboUserCodePrjMainPathId.SelectedValue + "'";
            }
            if (this.cboProgLangTypeId.SelectedValue.ToString() != "" && this.cboProgLangTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ProgLangTypeId='" + this.cboProgLangTypeId.SelectedValue + "'";
            }
            return strWhereCond;
        }

        /// <summary>
        /// 函数功能：用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvUserCodePath.SelectedItems.Count >= 1)
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
            if (this.lvvUserCodePath.SelectedItems.Count >= 1)
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
        private void BindLv_vUserCodePath()
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。
            string strMachineName = Environment.MachineName;
            ListViewItem lvivUserCodePath;
            List<clsvUserCodePathEN> arrvUserCodePathObjList;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineUserCodePathCondion(false);	//  CombineUserCodePathCondion();
            strWhereCond += string.Format(" Order By {0}", convUserCodePath.OrderNum);
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvUserCodePathObjList = clsvUserCodePathWApi.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            this.lvvUserCodePath.Items.Clear();//清除原来所有Item
            this.lvvUserCodePath.Columns.Clear();//清除原来所有列头信息
            //this.lvvUserCodePath.Columns.Add("mId", 100, HorizontalAlignment.Left);
            //this.lvvUserCodePath.Columns.Add("用户Id", 50, HorizontalAlignment.Left);
            //this.lvvUserCodePath.Columns.Add("用户名", 65, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("语言", 50, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("应用类型", 120, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("CM工程", 120, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("表主类型", 80, HorizontalAlignment.Left);

            //            this.lvvUserCodePath.Columns.Add("主目录?", 70, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("序号", 40, HorizontalAlignment.Left);
            //this.lvvUserCodePath.Columns.Add("类型Id", 60, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("代码类型", 250, HorizontalAlignment.Left);
            //this.lvvUserCodePath.Columns.Add("简称", 130, HorizontalAlignment.Left);
            //this.lvvUserCodePath.Columns.Add("英文名", 150, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("生成?", 55, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("存在?", 55, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("代码路径", 230, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("工程路径", 150, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("工程文件名", 180, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("打开状态", 160, HorizontalAlignment.Left);

            //this.lvvUserCodePath.Columns.Add("备份代码路径", 300, HorizontalAlignment.Left);

            this.lvvUserCodePath.Columns.Add("后缀路径", 100, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("修改日期", 70, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("用户Id", 60, HorizontalAlignment.Left);
            if (clsPubVar.CurrSelPrjId == "0000")
            {
                this.lvvUserCodePath.Columns.Add("是否模板", 100, HorizontalAlignment.Left);
            }
            this.lvvUserCodePath.Columns.Add("说明", 100, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("部门ID", 100, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("部门名称", 100, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("工程ID", 100, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("工程名称", 100, HorizontalAlignment.Left);
            this.lvvUserCodePath.Columns.Add("用户状态名", 100, HorizontalAlignment.Left);
            this.lvvUserCodePath.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            bool bolIsHaveUpdate = false;
            int intCmPrjAppId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());

            foreach (clsvUserCodePathEN objvUserCodePathEN in arrvUserCodePathObjList)
            {
                clsvUserCodePathEN objvUserCodePathEN_p = objvUserCodePathEN;
                try
                {
                    clsvUserCodePathExWApi.GetRelaPath(ref objvUserCodePathEN_p, clsSysParaEN.strUserId, strMachineName, intCmPrjAppId);
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                    return;
                }
                bool bolIsExistCodePath = Directory.Exists(objvUserCodePathEN.NewCodePath);
                bool bolIsNeedUpdate = false;
                if (objvUserCodePathEN.IsExistCodePath != bolIsExistCodePath)
                {
                    bolIsNeedUpdate = true;
                }
                bool bolIsExistCodePathBak = Directory.Exists(objvUserCodePathEN_p.NewCodePathBackup);
                if (objvUserCodePathEN.IsExistCodePath != bolIsExistCodePath)
                {
                    bolIsNeedUpdate = true;
                }
                if (bolIsNeedUpdate)
                {
                    clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN(objvUserCodePathEN.mId);
                    objUserCodePathEN.IsExistCodePath = bolIsExistCodePath;
                    objUserCodePathEN.IsExistCodePathBackup = bolIsExistCodePathBak;
                    objUserCodePathEN.PrjId = clsPubVar.CurrSelPrjId;
                    objUserCodePathEN.sfUpdFldSetStr = objUserCodePathEN.getsfUpdFldSetStr();
                    objUserCodePathEN.Update();
                    bolIsHaveUpdate = true;
                }
                lvivUserCodePath = new ListViewItem();
                lvivUserCodePath.Tag = objvUserCodePathEN.mId;
                //lvivUserCodePath.Text = objvUserCodePathEN.UserId;
                lvivUserCodePath.Text = objvUserCodePathEN.ProgLangTypeSimName;
                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserId);
                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserName);
                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.ProgLangTypeName);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.ApplicationTypeSimName + "-" + objvUserCodePathEN.UserCodePrjMainPathId(clsSysParaEN.strUserId));
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CmPrjName);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.TabMainTypeName);

                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.IsUsePrjMainPath?"是":"否");
                clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaExWApi.GetObjByAppAndCodeType(objvUserCodePathEN.ApplicationTypeId, objvUserCodePathEN.CodeTypeId);
                if (objAppCodeTypeRelaEN != null)
                {
                    lvivUserCodePath.SubItems.Add(objAppCodeTypeRelaEN.OrderNum.ToString("00"));
                }
                else
                {
                    lvivUserCodePath.SubItems.Add("");
                }
                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.OrderNum.ToString("00"));
                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeId);
                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeName);
                lvivUserCodePath.SubItems.Add(string.Format("{0}{1}({2})", objvUserCodePathEN.CodeTypeId, objvUserCodePathEN.CodeTypeSimName, objvUserCodePathEN.CodeTypeENName));
                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeENName);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.IsGeneCode ? "是" : "否");
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.IsExistCodePath ? "是" : "否");
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodePath);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.ProjectPath);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.ProjectFileName);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.PrjFileStateName);

                //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodePathBackup);

                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.SuffixPath);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UpdDate);
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UpdUserId);
                if (clsPubVar.CurrSelPrjId == "0000")
                {
                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.IsTemplate ? "是模板" : "否");
                }
                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.Memo);

                lvivUserCodePath.SubItems.Add(objvUserCodePathEN.PrjId);

                this.lvvUserCodePath.Items.Add(lvivUserCodePath);
                if (chkDIskBackup.Checked == true)
                {

                    lvivUserCodePath = new ListViewItem();
                    lvivUserCodePath.Tag = "0";

                    //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.UserId);

                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.ProgLangTypeName);
                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.ApplicationTypeName + "-" + objvUserCodePathEN.UserCodePrjMainPathId(clsSysParaEN.strUserId));

                    //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.IsUsePrjMainPath ? "是" : "否");

                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.OrderNum.ToString());
                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeId);
                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeName);
                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodeTypeENName);
                    lvivUserCodePath.SubItems.Add(objvUserCodePathEN.IsExistCodePathBackup ? "是" : "否");
                    lvivUserCodePath.SubItems.Add("备份:" + objvUserCodePathEN.CodePathBackup);
                    //lvivUserCodePath.SubItems.Add(objvUserCodePathEN.CodePathBackup);

                    lvivUserCodePath.SubItems.Add("");
                    lvivUserCodePath.SubItems.Add("");
                    lvivUserCodePath.SubItems.Add("");
                    if (clsPubVar.CurrSelPrjId == "0000")
                    {
                        lvivUserCodePath.SubItems.Add(objvUserCodePathEN.IsTemplate ? "是模板" : "否");
                    }
                    lvivUserCodePath.SubItems.Add("");

                    lvivUserCodePath.SubItems.Add("");
                    lvivUserCodePath.SubItems.Add("");
                    lvivUserCodePath.SubItems.Add("");
                    lvivUserCodePath.SubItems.Add("");
                    lvivUserCodePath.SubItems.Add("");
                    this.lvvUserCodePath.Items.Add(lvivUserCodePath);
                }

            }
            if (bolIsHaveUpdate == true) BindLv_vUserCodePath();
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvUserCodePathObjList.Count.ToString();
        }

        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        private void ShowUserCodePrjMainPath(string strMachineName)
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；

            List<clsUserCodePrjMainPath_MachineNameEN> arrvUserCodePrjMainPath_MachineObjList;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineUserCodePrjMainPath_MachineCondition(false);	//  CombineUserCodePrjMainPathCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvUserCodePrjMainPath_MachineObjList = clsUserCodePrjMainPath_MachineNameWApi.GetObjLst(strWhereCond);
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //StringBuilder sbMsg = new StringBuilder();
            lblCodePrjMainPath.Text = "";

            lblCodePrjMainPath.AppendText("【主目录路径】\r\n");
            string strTemp = "";
            foreach (clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName in arrvUserCodePrjMainPath_MachineObjList)
            {
                //                lblCodePrjMainPath.AppendText("项目主目录:{0} ", objvUserCodePrjMainPathEN.IsUsePrjMainPath?"是": "否");
                //clsvUserCodePrjMainPathENEx objvUserCodePrjMainPathEx = clsvUserCodePrjMainPathExWApi.CopyToExByMachineName(objvUserCodePrjMainPathEN, strMachineName);

                strTemp = string.Format("{0} ",
                    objUserCodePrjMainPath_MachineName.ApplicationTypeName());
                lblCodePrjMainPath.AppendText(strTemp);
                //strTemp = string.Format("代码:{0} ", objvUserCodePrjMainPathEN.CodePath);
                //lblCodePrjMainPath.AppendText(strTemp);
                lblCodePrjMainPath.AppendText("代码:");
                int intStart = lblCodePrjMainPath.Text.Length;
                lblCodePrjMainPath.AppendText(objUserCodePrjMainPath_MachineName.CodePath);
                int intEnd = lblCodePrjMainPath.Text.Length;
                lblCodePrjMainPath.Select(intStart, intEnd - intStart);
                lblCodePrjMainPath.SelectionColor = Color.Blue;
                lblCodePrjMainPath.Select(intEnd, 0);
                lblCodePrjMainPath.SelectionColor = Color.Black;

                if (Directory.Exists(objUserCodePrjMainPath_MachineName.CodePath) == false)
                {
                    intStart = lblCodePrjMainPath.Text.Length;
                    lblCodePrjMainPath.AppendText("[不存在!] ");
                    intEnd = lblCodePrjMainPath.Text.Length;
                    lblCodePrjMainPath.Select(intStart, intEnd - intStart);
                    lblCodePrjMainPath.SelectionColor = Color.Red;
                    lblCodePrjMainPath.Select(intEnd, 0);
                    lblCodePrjMainPath.SelectionColor = Color.Black;
                }
                //strTemp = string.Format("备份:{0}", objvUserCodePrjMainPathEN.CodePathBackup);
                lblCodePrjMainPath.AppendText("备份:");
                intStart = lblCodePrjMainPath.Text.Length;
                lblCodePrjMainPath.AppendText(objUserCodePrjMainPath_MachineName.CodePathBackup);
                intEnd = lblCodePrjMainPath.Text.Length;
                lblCodePrjMainPath.Select(intStart, intEnd - intStart);
                lblCodePrjMainPath.SelectionColor = Color.BlueViolet;
                lblCodePrjMainPath.Select(intEnd, 0);
                lblCodePrjMainPath.SelectionColor = Color.Black;

                if (Directory.Exists(objUserCodePrjMainPath_MachineName.CodePathBackup) == false)
                {
                    intStart = lblCodePrjMainPath.Text.Length;
                    lblCodePrjMainPath.AppendText("[不存在!] ");
                    intEnd = lblCodePrjMainPath.Text.Length;
                    lblCodePrjMainPath.Select(intStart, intEnd - intStart);
                    lblCodePrjMainPath.SelectionColor = Color.Red;
                    lblCodePrjMainPath.Select(intEnd, 0);
                    lblCodePrjMainPath.SelectionColor = Color.Black;
                }
                lblCodePrjMainPath.AppendText("\r\n");

            }
            //lblCodePrjMainPath.Text = sbMsg.ToString();
        }

        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vUserCodePath();
            ShowUserCodePrjMainPath(Environment.MachineName);
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strmId = objDTUserCodePath.Rows[intCurrRow]["mId"].ToString();
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
            ListViewItem lviUserCodePath;
            lviUserCodePath = objListView.SelectedItems[0];
            string strUserCodePathId = lviUserCodePath.Tag.ToString();
            long lngmId = long.Parse(strUserCodePathId);
            return lngmId;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private long GetCurrKey(ListViewItem objListViewItem)
        {
            string strUserCodePathId = objListViewItem.Tag.ToString();
            long lngmId = long.Parse(strUserCodePathId);
            return lngmId;
        }
        private void lvvUserCodePath_Click(object sender, System.EventArgs e)
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
            UpdateUserCodePathRecord();
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            int intCmPrjAppId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());

            frmUserCodePath_UI frm = new frmUserCodePath_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.CMProjectAppRelaId = intCmPrjAppId;
            if (chkEditTemplate.Checked == true)
            {
                frm.OperatePrjId = "0000";
            }
            else
            {
                frm.OperatePrjId = clsPubVar.CurrSelPrjId;
            }
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteUserCodePathRecord();
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
            string strWhereCond = this.CombineUserCodePathCondion(true);
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsUserCodePathWApi.GetDataTable_UserCodePath(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "UserCodePath信息导出.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("UserName"); arrCnName.Add("用户名");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("CodeTypeId"); arrCnName.Add("代码类型Id");
            arrColName.Add("CodeTypeName"); arrCnName.Add("代码类型名");
            arrColName.Add("CodePath"); arrCnName.Add("代码路径");
            arrColName.Add("UserStateId"); arrCnName.Add("用户状态号");
            arrColName.Add("UserStateName"); arrCnName.Add("用户状态名");
            arrColName.Add("DepartmentId"); arrCnName.Add("部门ID");
            arrColName.Add("DepartmentName"); arrCnName.Add("部门名称");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
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
            string strWhereCond = this.CombineUserCodePathCondion(true);
            //	2、设置表列数据字段名，以及表列标题
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("UserName"); arrCnName.Add("用户名");
            arrColName.Add("PrjId"); arrCnName.Add("工程ID");
            arrColName.Add("PrjName"); arrCnName.Add("工程名称");
            arrColName.Add("CodeTypeId"); arrCnName.Add("代码类型Id");
            arrColName.Add("CodeTypeName"); arrCnName.Add("代码类型名");
            arrColName.Add("CodePath"); arrCnName.Add("代码路径");
            arrColName.Add("UserStateId"); arrCnName.Add("用户状态号");
            arrColName.Add("UserStateName"); arrCnName.Add("用户状态名");
            arrColName.Add("DepartmentId"); arrCnName.Add("部门ID");
            arrColName.Add("DepartmentName"); arrCnName.Add("部门名称");
            arrColName.Add("UpdDate"); arrCnName.Add("修改日期");
            arrColName.Add("UpdUserId"); arrCnName.Add("修改用户Id");
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
            frm1.strTableName = "vUserCodePath";
            frm1.strTableChineseName = "vUserCodePath";
            frm1.strViewName = "用户生成路径维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvUserCodePath_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvUserCodePathSorter.SortColumn)
            {

            }
            else
            {
                this.objvUserCodePathSorter.SortColumn = e.Column;
            }

            if (this.objvUserCodePathSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvUserCodePathSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvUserCodePathColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvUserCodePathColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text = this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvUserCodePathColumIndex = e.Column;
                }
            }
            else if (this.objvUserCodePathSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvUserCodePathSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvUserCodePathColumIndex == e.Column)
                {
                    this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvUserCodePathColumIndex = e.Column;
                }
                else
                {
                    this.lvvUserCodePath.Columns[e.Column].Text = this.lvvUserCodePath.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text = this.lvvUserCodePath.Columns[intLastSelectedvUserCodePathColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvUserCodePathColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvUserCodePath.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vUserCodePath();
        }
        ///生成修改记录准备过程代码 for C#
        private void UpdateUserCodePathRecord()
        {
            if (this.lvvUserCodePath.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            int intCmPrjAppId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());
            frmUserCodePath_UI frm = new frmUserCodePath_UI();
            string strKeyId = this.lvvUserCodePath.SelectedItems[0].Tag.ToString();
            frm.mId_key = long.Parse(strKeyId);
            frm.CMProjectAppRelaId = intCmPrjAppId;
            frm.iBindListView = this;
            frm.OperateType = "Update";
            if (chkEditTemplate.Checked == true)
            {
                frm.OperatePrjId = "0000";
            }
            else
            {
                frm.OperatePrjId = clsPubVar.CurrSelPrjId;
            }
            frm.ShowDialog();
        }
        ///删除记录过程代码for C#
        private void DeleteUserCodePathRecord()
        {
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvUserCodePath.SelectedItems)
                {
                    long lngmId = GetCurrKey(lvi);
                    if (lngmId == 0) continue;
                    if (clsUserCodePathWApi.DelRecord(lngmId) == 0)
                    {
                        MessageBox.Show("删除记录失败！");
                        BindLv_vUserCodePath();
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vUserCodePath();
            }
        }

        private void btnCopyRec_Click(object sender, EventArgs e)
        {
            if (this.lvvUserCodePath.SelectedItems.Count < 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择记录！");
                return;
            }
            int intCount = 0;
            foreach (ListViewItem objLVI in this.lvvUserCodePath.SelectedItems)
            {
                string strKeyId = objLVI.Tag.ToString();

                lblMsg.Text = "";
                //1、显示该关键字的数据让用户修改该关键字记录；

                long lngmId = long.Parse(strKeyId);
                try
                {
                    clsUserCodePathEN objUserCodePathEN = clsUserCodePathWApi.GetObjBymId(lngmId);
                    objUserCodePathEN.CodeTypeId = "0000";
                    clsUserCodePathWApi.AddNewRecord(objUserCodePathEN);
                    intCount++;
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                    return;
                }
            }
            if (intCount > 0)
            {
                BindLv_vUserCodePath();
            }
        }

        private void btnCopyTemplateSet_Click(object sender, EventArgs e)
        {
            if (cboCmPrjAppId.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个Cm工程应用类型！");
                cboCmPrjAppId.Focus();
                return;
            }

            long lngCMProjectAppRelaId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());
            string strMachineName = Environment.MachineName;

            string strUserCodePrjMainPathId_T = "";
            try
            {
                
                var objUserCodePrjMainPath = clsUserCodePrjMainPathExWApi.GetObjExByCMProjectAppRelaIdCache(lngCMProjectAppRelaId,
                    clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                //if (objUserCodePrjMainPath == null)
                //{
                //    return;
                //}
                strUserCodePrjMainPathId_T = objUserCodePrjMainPath.UserCodePrjMainPathId;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
            try
            {
                //int intCount = clsUserCodePathExWApi.CopyUserCodePathFromTemplate(clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, strUserCodePrjMainPathId_T);
                BindLv_vUserCodePath();
                string strMsg = string.Format("复制模板完成！共复制了：[{0}]条记录！", 0);
                MessageBox.Show(strMsg);
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
        }

        private void btnSetMainPath_Click(object sender, EventArgs e)
        {
            if (cboUserCodePrjMainPathId.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个主目录！");
                cboUserCodePrjMainPathId.Focus();
                return;
            }
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            string strCmPrjAppId = cboCmPrjAppId.SelectedValue.ToString();
            foreach (ListViewItem objLVI in lvvUserCodePath.SelectedItems)
            {
                long lngMid = GetCurrKey(objLVI);
                clsUserCodePathEN objUserCodePathEN = clsUserCodePathWApi.GetObjBymId(lngMid);
                objUserCodePathEN.CMProjectAppRelaId =long.Parse( strCmPrjAppId);
                objUserCodePathEN.UpdDate = strCurrDate;
                objUserCodePathEN.UpdUserId = clsSysParaEN.strUserId;
                try
                {
                    objUserCodePathEN.sfUpdFldSetStr = objUserCodePathEN.getsfUpdFldSetStr();
                    objUserCodePathEN.Update();
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                    return;
                }
            }
            BindLv_vUserCodePath();
        }

        private void cboProgLangTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProgLangTypeId.SelectedIndex <= 0)
            {
                if (chkEditTemplate.Checked == true)
                {
                    clsvUserCodePrjMainPathExWApi.BindCbo_UserCodePrjMainPathIdByUserIdEx(this.cboUserCodePrjMainPathId, clsSysParaEN.strUserId, "0000");
                }
                else
                {
                    clsvUserCodePrjMainPathExWApi.BindCbo_UserCodePrjMainPathIdByUserIdEx(this.cboUserCodePrjMainPathId, clsSysParaEN.strUserId, clsPubVar.CurrSelPrjId);
                }
                return;
            }
            string strProgLangTypeId = cboProgLangTypeId.SelectedValue.ToString();
            if (chkEditTemplate.Checked == true)
            {
                clsvUserCodePrjMainPathExWApi.BindCbo_UserCodePrjMainPathIdByUserIdEx(this.cboUserCodePrjMainPathId, clsSysParaEN.strUserId, "0000");
            }
            else
            {
                clsvUserCodePrjMainPathExWApi.BindCbo_UserCodePrjMainPathIdByUserIdEx(this.cboUserCodePrjMainPathId, clsSysParaEN.strUserId, clsPubVar.CurrSelPrjId);

            }

        }

        private void chkEditTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditTemplate.Checked == true)
            {
                clsvUserCodePrjMainPathExWApi.BindCbo_UserCodePrjMainPathIdByUserIdEx(this.cboUserCodePrjMainPathId, clsSysParaEN.strUserId, "0000");
            }
            else
            {
                clsvUserCodePrjMainPathExWApi.BindCbo_UserCodePrjMainPathIdByUserIdEx(this.cboUserCodePrjMainPathId, clsSysParaEN.strUserId, clsPubVar.CurrSelPrjId);
            }
        }

        private void lvvUserCodePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvvUserCodePath.SelectedItems.Count == 0) return;
            string strMachineName = Environment.MachineName;
            long lngMid = GetCurrKey(lvvUserCodePath.SelectedItems[0]);
            if (lngMid == 0)
            {
                int intCurrIndex = lvvUserCodePath.SelectedIndices[0];
                lngMid = GetCurrKey(lvvUserCodePath.Items[intCurrIndex - 1]);
                if (lngMid == 0)
                {
                    //                    MessageBox.Show();
                }
            }
            if (cboCmPrjAppId.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个Cm工程应用类型！");
                cboCmPrjAppId.Focus();
                return;
            }

            int intCmPrjAppId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());

            clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathWApi.GetObjBymId(lngMid);
            clsvUserCodePathExWApi.GetRelaPath(ref objvUserCodePathEN,clsSysParaEN.strUserId, strMachineName, intCmPrjAppId);
            bool bolIsExistDir = Directory.Exists(objvUserCodePathEN.NewCodePath);
            bool bolIsExistDirBak = Directory.Exists(objvUserCodePathEN.NewCodePathBackup);
            if (bolIsExistDir == false)
            {
                lblCodePath.Text = string.Format("生成目录:{0},不存在！", objvUserCodePathEN.NewCodePath);
                btnCreateDir.Visible = true;
                lblCodePath.ForeColor = Color.Red;
            }
            else
            {
                lblCodePath.Text = string.Format("生成目录:{0},存在！", objvUserCodePathEN.NewCodePath);
                btnCreateDir.Visible = false;
                lblCodePath.ForeColor = Color.Black;
            }
            if (bolIsExistDirBak == false)
            {
                lblCodePathBackup.Text = string.Format("备份目录:{0},不存在！", objvUserCodePathEN.NewCodePathBackup);
                btnCreateBakDir.Visible = true;
                lblCodePathBackup.ForeColor = Color.Red;
            }
            else
            {
                lblCodePathBackup.Text = string.Format("备份目录:{0},存在！", objvUserCodePathEN.NewCodePathBackup);
                btnCreateBakDir.Visible = false;
                lblCodePathBackup.ForeColor = Color.Black;
            }
        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            if (lvvUserCodePath.SelectedItems.Count == 0) return;

            if (cboCmPrjAppId.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个Cm工程应用类型！");
                cboCmPrjAppId.Focus();
                return;
            }

            int intCmPrjAppId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());

            string strMachineName = Environment.MachineName;
            long lngMid = GetCurrKey(lvvUserCodePath.SelectedItems[0]);
            clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathWApi.GetObjBymId(lngMid);
            clsvUserCodePathExWApi.GetRelaPath(ref objvUserCodePathEN, clsSysParaEN.strUserId, strMachineName, intCmPrjAppId);

            bool bolIsExistDir = Directory.Exists(objvUserCodePathEN.NewCodePath);
            if (bolIsExistDir == false)
            {
                if (objvUserCodePathEN.IsExistCodePathP == false)
                {
                    MessageBox.Show("该代码层的主目录不存在！请先去建立相关主目录。");
                    return;
                }
                Directory.CreateDirectory(objvUserCodePathEN.NewCodePath);
                MessageBox.Show("该代码层的目录建立成功！");
            }

        }

        private void btnCreateBakDir_Click(object sender, EventArgs e)
        {
            if (lvvUserCodePath.SelectedItems.Count == 0) return;
            string strMachineName = Environment.MachineName;
            if (cboCmPrjAppId.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个Cm工程应用类型！");
                cboCmPrjAppId.Focus();
                return;
            }

            int intCmPrjAppId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());

            long lngMid = GetCurrKey(lvvUserCodePath.SelectedItems[0]);
            clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathWApi.GetObjBymId(lngMid);
            clsvUserCodePathExWApi.GetRelaPath(ref objvUserCodePathEN, clsSysParaEN.strUserId, strMachineName, intCmPrjAppId);
            bool bolIsExistDir = Directory.Exists(objvUserCodePathEN.NewCodePathBackup);
            if (bolIsExistDir == false)
            {
                if (objvUserCodePathEN.IsExistCodePathBackupP == false)
                {
                    MessageBox.Show("该代码层的主备份目录不存在！请先去建立相关备份主目录。");
                    return;
                }
                Directory.CreateDirectory(objvUserCodePathEN.NewCodePath);
                MessageBox.Show("该代码层的备份目录建立成功！");
            }

        }

        private void btnSetIsGeneCode_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in this.lvvUserCodePath.SelectedItems)
            {
                long lngmId = GetCurrKey(lvi);
                if (lngmId == 0) continue;
                if (clsUserCodePathExWApi.SetIsGeneCode(lngmId) == false)
                {
                    MessageBox.Show("设置生成代码失败！");
                    BindLv_vUserCodePath();
                    return;
                }
            }
            MessageBox.Show("设置生成代码成功！");
            BindLv_vUserCodePath();
        }

        private void btnSetIsNotGeneCode_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in this.lvvUserCodePath.SelectedItems)
            {
                long lngmId = GetCurrKey(lvi);
                if (lngmId == 0) continue;
                if (clsUserCodePathExWApi.SetIsNotGeneCode(lngmId) == false)
                {
                    MessageBox.Show("设置不生成代码失败！");
                    BindLv_vUserCodePath();
                    return;
                }
            }
            MessageBox.Show("设置不生成代码成功！");
            BindLv_vUserCodePath();
        }

        private void btnCheckPrjFileState_Click(object sender, EventArgs e)
        {
            if (cboCmPrjAppId.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择一个Cm工程应用类型！");
                cboCmPrjAppId.Focus();
                return;
            }

            int intCmPrjAppId = int.Parse(cboCmPrjAppId.SelectedValue.ToString());

            List<clsvUserCodePathEN> arrvUserCodePathObjList;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineUserCodePathCondion(false);	//  CombineUserCodePathCondion();
            strWhereCond += string.Format(" Order By {0}", convUserCodePath.OrderNum);
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvUserCodePathObjList = clsvUserCodePathWApi.GetObjLst(strWhereCond);
            List<clsUserCodePathEN> arrUserCodePathObjLst = arrvUserCodePathObjList.Select(clsUserCodePathExWApi.CopyTo).ToList();
            try
            {
                foreach (clsUserCodePathEN objInFor in arrUserCodePathObjLst)
                {
                    objInFor.CheckPrjFileState(intCmPrjAppId,clsSysParaEN.strUserId, new myCheckPrjFileState());
                }
                BindLv_vUserCodePath();
            }
            catch (Exception objExceptoin)
            {
                lblMsg.Text = objExceptoin.Message;
                MessageBox.Show(objExceptoin.Message);
                return;
            }
        }

    }
}