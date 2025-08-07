
using AGC.Entity;
using AGC_CSWin;
using AGC4WApi;
using com.taishsoft.util;
using CommFunc4Win;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AGC
{
    /// <summary>
    ///		frmUserCodePrjMainPath_QD_LV 的摘要说明。
    /// </summary>
    public partial class frmUserCodePrjMainPath_QD_LV_Machine : System.Windows.Forms.Form, IBindListView
    {
        //clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = null;
        private System.Data.DataTable objDTUserCodePrjMainPath = null;
        private clsListViewSorter objvUserCodePrjMainPathSorter;
        private int intLastSelectedvUserCodePrjMainPathColumIndex;
        public frmUserCodePrjMainPath_QD_LV_Machine()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化
            objvUserCodePrjMainPathSorter = new clsListViewSorter();
            //为ListViewItemSorter指定排序类
            this.lvvUserCodePrjMainPath.ListViewItemSorter = objvUserCodePrjMainPathSorter;
            objvUserCodePrjMainPathSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmUserCodePrjMainPath_QD_Load(object sender, System.EventArgs e)
        {
            string strMachineName = Environment.MachineName;
            lblMachineName.Text = string.Format("机器名:{0}", strMachineName);
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            string strCmPrjId = clsUserDefaValue_LocalExWApi.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, "默认CM工程");
            if (string.IsNullOrEmpty(strCmPrjId) == true)
            {
                var arrCMProject = clsCMProjectExWApi.GetObjLstByPrjIdExCache(clsPubVar.CurrSelPrjId);
                if (arrCMProject.Count == 0)
                {
                    var objProject = clsProjectsWApi.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
                    MessageBox.Show("项目:[{0}]没有建立相应的CM工程！", objProject.PrjName);
                    return;
                }
                strCmPrjId = arrCMProject[0].CmPrjId;
                clsUserDefaValue_LocalExWApi.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, "默认CM工程", strCmPrjId);
            }
            

            this.Text = string.Format("{0}-代码生成主路径设置(本机)－列表", clsPubVar.objCurrSelProjectEN.PrjName);
            this.SetAllComboBox();
            cboPrjId.SelectedValue = clsPubVar.CurrSelPrjId;
            cboPrjId.Enabled = false;
            cboUserId.SelectedValue = clsSysParaEN.strUserId;
            cboUserId.Enabled = false;
            //try
            //{
            //    clsUserCodePrjMainPathExWApi.CopyUserCodePrjMainPathFromTemplate(clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
            //}
            //catch (Exception objException)
            //{
            //    MessageBox.Show(objException.Message);
            //    return;
            //}
            BindLv_vUserCodePrjMainPath();

            this.JudgebtnDelRec(); //用来判断删除按钮是否可用
            this.JudgebtnUpdate(); //用来判断修改按钮是否可用

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            clsUsersWApi.BindCbo_UserId(this.cboUserId);
            clsProjectsWApi.BindCbo_PrjId(this.cboPrjId);
            clsProgLangTypeExWApi.BindCbo_ProgLangTypeIdEx(this.cboProgLangTypeId);
            clsApplicationTypeExWApi.BindCbo_ApplicationTypeIdEx(this.cboApplicationTypeId);
            clsCMProjectExWApi.BindCbo_CmPrjIdCacheEx(this.cboCmPrjId, clsPubVar.CurrSelPrjId);

            //clsCodeTypeExWApi.BindCbo_CodeTypeIdEx(this.cboCodeTypeId);
        }
        public string UserId
        {
            get
            {
                if (cboUserId.SelectedValue.ToString() == "0")
                    return "";
                return cboUserId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboUserId.SelectedValue = "0";
                }
                else
                {
                    cboUserId.SelectedValue = value;
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

        //public string CodeTypeId
        //{
        //    get
        //    {
        //        if (cboCodeTypeId.SelectedValue.ToString() == "0")
        //            return "";
        //        return cboCodeTypeId.SelectedValue.ToString();
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            cboCodeTypeId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            cboCodeTypeId.SelectedValue = value;
        //        }
        //    }
        //}


        public void Clear()
        {
            cboUserId.SelectedIndex = 0;
            cboPrjId.SelectedIndex = 0;
            //cboCodeTypeId.SelectedIndex = 0;
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
            cboUserId.SelectedIndex = 0;
            cboPrjId.SelectedIndex = 0;
            //cboCodeTypeId.SelectedIndex = 0;
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
            clsUsersWApi.BindCbo_UserId(cboUserId);
        }
        public void SetCbo_PrjId()
        {
            clsProjectsWApi.BindCbo_PrjId(cboPrjId);
        }
        //public void SetCbo_CodeTypeId()
        //{
        //    clsCodeTypeWApi.BindCbo_CodeTypeId(cboCodeTypeId);
        //}
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
        public string CombineUserCodePrjMainPathCondion(bool bolIsWithTabName)
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'

            string strWhereCond = string.Format(" 1=1 and {0}='1' ", convUserCodePrjMainPath.AppIsVisible);
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。


            if ((clsSysParaEN.strUserRoleId == "00050001" || clsSysParaEN.strUserRoleId == "00050006") && chkEditTemplate.Checked == true)
            {
                strWhereCond += " And PrjId='0000'";
            }
            else
            {
                if (this.cboUserId.SelectedValue.ToString() != "" && this.cboUserId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserId='" + this.cboUserId.SelectedValue + "'";
                }
                if (this.cboPrjId.SelectedValue.ToString() != "" && this.cboPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.cboPrjId.SelectedValue + "'";
                }
            }
            //if (this.cboCodeTypeId.SelectedValue.ToString() != "" && this.cboCodeTypeId.SelectedValue.ToString() != "0")
            //{
            //    strWhereCond += " And CodeTypeId='" + this.cboCodeTypeId.SelectedValue + "'";
            //}
            if (this.cboProgLangTypeId.SelectedValue.ToString() != "" && this.cboProgLangTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ProgLangTypeId='" + this.cboProgLangTypeId.SelectedValue + "'";
            }
            if (this.cboApplicationTypeId.SelectedValue.ToString() != "" && this.cboApplicationTypeId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And ApplicationTypeId='" + this.cboApplicationTypeId.SelectedValue + "'";
            }
            if (this.cboCmPrjId.SelectedValue.ToString() != "" && this.cboCmPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And CmPrjId='" + this.cboCmPrjId.SelectedValue + "'";
            }
            strWhereCond += string.Format(" order by {0}", convUserCodePrjMainPath.AppOrderNum);
            return strWhereCond;
        }

        /// <summary>
        /// 函数功能：用来判断删除按钮是否可用。
        ///			 如果在LISTVIEW中选中记录就显示删除按钮，否则就不显示
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvUserCodePrjMainPath.SelectedItems.Count >= 1)
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
            if (this.lvvUserCodePrjMainPath.SelectedItems.Count >= 1)
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
        private void BindLv_vUserCodePrjMainPath()
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。
            string strMachineName = Environment.MachineName;
            //var strCmPrjId = cboCmPrjId.SelectedValue.ToString();
            //if (string.IsNullOrEmpty(strCmPrjId) == true || strCmPrjId == "0")
            //{
            //    MessageBox.Show("请选择一个CM工程！");
            //    cboCmPrjId.Focus();
            //    return;
            //}
            ListViewItem lvivUserCodePrjMainPath;
            List<clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjList;
            //	1、组合界面条件串；
            string strWhereCond = this.CombineUserCodePrjMainPathCondion(false);	//  CombineUserCodePrjMainPathCondion();
            //strWhereCond += string.Format(" Order By {0}", clsvUserCodePrjMainPathEN.con_OrderNum);
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvUserCodePrjMainPathObjList = clsvUserCodePrjMainPathWApi.GetObjLst(strWhereCond);
            if (arrvUserCodePrjMainPathObjList.Count == 0)
            {
                string strCmPrjId = clsUserDefaValue_LocalExWApi.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, "默认CM工程");
                if (string.IsNullOrEmpty(strCmPrjId) == true)
                {
                    var arrCMProject = clsCMProjectExWApi.GetObjLstByPrjIdExCache(clsPubVar.CurrSelPrjId);
                    if (arrCMProject.Count == 0)
                    {
                        var objProject = clsProjectsWApi.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
                        MessageBox.Show("项目:[{0}]没有建立相应的CM工程！", objProject.PrjName);
                        return;
                    }
                    strCmPrjId = arrCMProject[0].CmPrjId;
                    clsUserDefaValue_LocalExWApi.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, "默认CM工程", strCmPrjId);
                }
                //clsUserCodePrjMainPathExWApi.CopyUserCodePrjMainPathFromTemplate(clsSysParaEN.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
            }
            
            //	3、设置ListView的列头信息
            this.lvvUserCodePrjMainPath.Items.Clear();//清除原来所有Item
            this.lvvUserCodePrjMainPath.Columns.Clear();//清除原来所有列头信息
            //this.lvvUserCodePrjMainPath.Columns.Add("UserCodePrjMainPathId", 100, HorizontalAlignment.Left);
            //this.lvvUserCodePrjMainPath.Columns.Add("用户", 100, HorizontalAlignment.Left);
            //this.lvvUserCodePrjMainPath.Columns.Add("用户名", 70, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("序号", 40, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("应用类型", 120, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("CM工程", 120, HorizontalAlignment.Left);

            //this.lvvUserCodePrjMainPath.Columns.Add("主路径", 60, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("在用?", 55, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("存在?", 55, HorizontalAlignment.Left);
           
            this.lvvUserCodePrjMainPath.Columns.Add("代码路径", 400, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("包含表Xml文件路径", 250, HorizontalAlignment.Left);
            //this.lvvUserCodePrjMainPath.Columns.Add("备份代码路径", 300, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("日志路径", 280, HorizontalAlignment.Left);

            this.lvvUserCodePrjMainPath.Columns.Add("修改日期", 100, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("修改用户Id", 100, HorizontalAlignment.Left);
            if (clsPubVar.CurrSelPrjId == "0000")
            {
                this.lvvUserCodePrjMainPath.Columns.Add("是否模板", 100, HorizontalAlignment.Left);
            }
            this.lvvUserCodePrjMainPath.Columns.Add("说明", 100, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("部门ID", 100, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("部门名称", 100, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("工程ID", 100, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("工程名称", 100, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.Columns.Add("用户状态名", 100, HorizontalAlignment.Left);
            this.lvvUserCodePrjMainPath.View = View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //bool bolIsHaveUpdate = false;
            bool bolIsExistCodePath = false;
            bool bolIsExistCodePathBackup = false;
            foreach (clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN in arrvUserCodePrjMainPathObjList)
            {
                string strCodePath = "";
                string strLogPath = "";
                string strCodePathBackup = "";
                var objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(objvUserCodePrjMainPathEN.UserCodePrjMainPathId, Environment.MachineName, clsPubVar.CurrSelPrjId);
                if (objUserCodePrjMainPath_MachineName != null)
                {
                    strCodePath = objUserCodePrjMainPath_MachineName.CodePath;
                    strLogPath = objUserCodePrjMainPath_MachineName.LogPath;
                    bolIsExistCodePath = Directory.Exists(objUserCodePrjMainPath_MachineName.CodePath);
                    //bool bolIsNeedUpdate = false;
                    //if (objvUserCodePrjMainPathEN.IsExistCodePath != bolIsExistCodePath)
                    //{
                    //    bolIsNeedUpdate = true;
                    //}
                    bolIsExistCodePathBackup = Directory.Exists(objUserCodePrjMainPath_MachineName.CodePathBackup);
                    //if (objvUserCodePrjMainPathEN.IsExistCodePath != bolIsExistCodePath)
                    //{
                    //    bolIsNeedUpdate = true;
                    //}
                    //if (bolIsNeedUpdate)
                    //{
                    //    objUserCodePrjMainPath_MachineName.IsExistCodePath = bolIsExistCodePath;
                    //    objUserCodePrjMainPath_MachineName.IsExistCodePathBackup = bolIsExistCodePathBak;
                    //    //objUserCodePrjMainPath_MachineName.Update();
                    //    //bolIsHaveUpdate = true;
                    //}
                }
                lvivUserCodePrjMainPath = new ListViewItem();
                lvivUserCodePrjMainPath.Tag = objvUserCodePrjMainPathEN.UserCodePrjMainPathId;
                //lvivUserCodePrjMainPath.Text = string.Format("{0}-{1}", objvUserCodePrjMainPathEN.UserId, objvUserCodePrjMainPathEN.UserName);
                lvivUserCodePrjMainPath.Text = objvUserCodePrjMainPathEN.AppOrderNum.ToString();
                //lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.UserId);
                //lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.OrderNum.ToString("00"));
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.ApplicationTypeSimName);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.CmPrjName);
                //ListViewItem.ListViewSubItem objLVI = new ListViewItem.ListViewSubItem();
                //if (objvUserCodePrjMainPathEN.IsUsePrjMainPath == true)
                //{
                //    objLVI.Text = "是";
                //    objLVI.ForeColor = Color.Red;
                //}
                //else
                //{
                //    objLVI.Text = "否";
                //    objLVI.ForeColor = Color.Blue;
                //}
                //lvivUserCodePrjMainPath.SubItems.Add(objLVI);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.InUse ? "是" : "否");
                lvivUserCodePrjMainPath.SubItems.Add(bolIsExistCodePath ? "是" : "否");
                lvivUserCodePrjMainPath.SubItems.Add(strCodePath);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.IncludeXmlPath);
                //lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.CodePathBackup);
                lvivUserCodePrjMainPath.SubItems.Add(strLogPath);

                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.UpdDate);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.UpdUserId);
                if (clsPubVar.CurrSelPrjId == "0000")
                {
                    lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.IsTemplate ? "是模板" : "否");
                }
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.Memo);

                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.DepartmentId);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.DepartmentName);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.UserStateName);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.PrjId);
                lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.PrjName);
                this.lvvUserCodePrjMainPath.Items.Add(lvivUserCodePrjMainPath);

                if (chkDIskBackup.Checked == true)
                {
                    lvivUserCodePrjMainPath = new ListViewItem();
                    lvivUserCodePrjMainPath.Tag = objvUserCodePrjMainPathEN.UserCodePrjMainPathId;
                    lvivUserCodePrjMainPath.Text = objvUserCodePrjMainPathEN.UserId;
                    //lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.UserId);
                    lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.UserName);
                    lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.AppOrderNum.ToString());

                    lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.ApplicationTypeName);

                    //lvivUserCodePrjMainPath.SubItems.Add(objLVI);
                    lvivUserCodePrjMainPath.SubItems.Add(bolIsExistCodePathBackup?"是":"否");
                    lvivUserCodePrjMainPath.SubItems.Add("备份：" + strCodePathBackup);
                    //lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.CodePathBackup);

                    lvivUserCodePrjMainPath.SubItems.Add("");
                    lvivUserCodePrjMainPath.SubItems.Add("");
                    if (clsPubVar.CurrSelPrjId == "0000")
                    {
                        lvivUserCodePrjMainPath.SubItems.Add(objvUserCodePrjMainPathEN.IsTemplate ? "是模板" : "否");
                    }
                    lvivUserCodePrjMainPath.SubItems.Add("");

                    lvivUserCodePrjMainPath.SubItems.Add("");
                    lvivUserCodePrjMainPath.SubItems.Add("");
                    lvivUserCodePrjMainPath.SubItems.Add("");
                    lvivUserCodePrjMainPath.SubItems.Add("");
                    lvivUserCodePrjMainPath.SubItems.Add("");
                    this.lvvUserCodePrjMainPath.Items.Add(lvivUserCodePrjMainPath);
                }

            }
            //if (bolIsHaveUpdate == true) BindLv_vUserCodePrjMainPath();
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            this.lblRecNum.Text = "记录数：" + arrvUserCodePrjMainPathObjList.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把表记录的内容显示在ListView中
            BindLv_vUserCodePrjMainPath();
        }
        /// <summary>
        /// 获取DataGrid中当前行的主键值
        /// </summary>
        /// <param name="objDataGrid">所单击的DataGrid</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strmId = objDTUserCodePrjMainPath.Rows[intCurrRow]["UserCodePrjMainPathId"].ToString();
            string strUserCodePrjMainPathId = strmId;
            return strUserCodePrjMainPathId;
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
            ListViewItem lviUserCodePrjMainPath;
            lviUserCodePrjMainPath = objListView.SelectedItems[0];
            string strUserCodePrjMainPathId = lviUserCodePrjMainPath.Tag.ToString();
            return strUserCodePrjMainPathId;
        }
        /// <summary>
        /// 获取ListView所给项的主键值
        /// </summary>
        /// <param name="objListView">所单击的ListView项</param>
        /// <returns>当前行的主键值</returns>
        private string GetCurrKey(ListViewItem objListViewItem)
        {
            string strUserCodePrjMainPathId = objListViewItem.Tag.ToString();

            return strUserCodePrjMainPathId;
        }
        private void lvvUserCodePrjMainPath_Click(object sender, System.EventArgs e)
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
            UpdateUserCodePrjMainPathRecord();
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmUserCodePrjMainPath_UI frm = new frmUserCodePrjMainPath_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteUserCodePrjMainPathRecord();
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
            string strWhereCond = this.CombineUserCodePrjMainPathCondion(true);
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsUserCodePrjMainPathWApi.GetDataTable_UserCodePrjMainPath(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "UserCodePrjMainPath信息导出.xls";
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
            string strWhereCond = this.CombineUserCodePrjMainPathCondion(true);
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
            frm1.strTableName = "vUserCodePrjMainPath";
            frm1.strTableChineseName = "vUserCodePrjMainPath";
            frm1.strViewName = "用户生成路径维护";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// 函数功能：LISTVIEW的列单击事件函数
        /// </summary>
        private void lvvUserCodePrjMainPath_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvUserCodePrjMainPathSorter.SortColumn)
            {

            }
            else
            {
                this.objvUserCodePrjMainPathSorter.SortColumn = e.Column;
            }

            if (this.objvUserCodePrjMainPathSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvUserCodePrjMainPathSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvUserCodePrjMainPathColumIndex == e.Column) //看是否重复点击一列
                {
                    this.lvvUserCodePrjMainPath.Columns[e.Column].Text = this.lvvUserCodePrjMainPath.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    intLastSelectedvUserCodePrjMainPathColumIndex = e.Column;
                }
                else //如果点击另外一列了，那么前面点击的一列三角去掉
                {
                    this.lvvUserCodePrjMainPath.Columns[e.Column].Text = this.lvvUserCodePrjMainPath.Columns[e.Column].Text.Trim('▲', '▼') + "▼";
                    this.lvvUserCodePrjMainPath.Columns[intLastSelectedvUserCodePrjMainPathColumIndex].Text = this.lvvUserCodePrjMainPath.Columns[intLastSelectedvUserCodePrjMainPathColumIndex].Text.Trim('▼', '▲');
                    intLastSelectedvUserCodePrjMainPathColumIndex = e.Column;
                }
            }
            else if (this.objvUserCodePrjMainPathSorter.SortOrder == SortOrder.Descending) // ▲ ▼
            {
                this.objvUserCodePrjMainPathSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvUserCodePrjMainPathColumIndex == e.Column)
                {
                    this.lvvUserCodePrjMainPath.Columns[e.Column].Text = this.lvvUserCodePrjMainPath.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    intLastSelectedvUserCodePrjMainPathColumIndex = e.Column;
                }
                else
                {
                    this.lvvUserCodePrjMainPath.Columns[e.Column].Text = this.lvvUserCodePrjMainPath.Columns[e.Column].Text.Trim('▲', '▼') + "▲";
                    this.lvvUserCodePrjMainPath.Columns[intLastSelectedvUserCodePrjMainPathColumIndex].Text = this.lvvUserCodePrjMainPath.Columns[intLastSelectedvUserCodePrjMainPathColumIndex].Text.Trim('▲', '▼');
                    intLastSelectedvUserCodePrjMainPathColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvUserCodePrjMainPath.Sort();
        }

        /// <summary>
        /// 实现接口函数，通过子窗体调用，来实现本窗体(父窗体)的LISTVIEW重新绑定功能
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vUserCodePrjMainPath();
        }
        ///生成修改记录准备过程代码 for C#
        private void UpdateUserCodePrjMainPathRecord()
        {
            if (this.lvvUserCodePrjMainPath.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            frmUserCodePrjMainPath_UI frm = new frmUserCodePrjMainPath_UI();
            string strKeyId = this.lvvUserCodePrjMainPath.SelectedItems[0].Tag.ToString();
            frm.mstrUserCodePrjMainPathId_key = strKeyId;
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        ///删除记录过程代码for C#
        private void DeleteUserCodePrjMainPathRecord()
        {
            string strCmPrjId = this.cboCmPrjId.SelectedValue.ToString();
            if (string.IsNullOrEmpty(strCmPrjId) == true || strCmPrjId == "0")
            {                
                MessageBox.Show("请选择一条Cm工程！");
                cboCmPrjId.Focus();
                return;
            }
            DialogResult result;
            result = MessageBox.Show("你真的要删除该记录吗？", "确认删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvUserCodePrjMainPath.SelectedItems)
                {
                    string strUserCodePrjMainPathId = GetCurrKey(lvi);
                    try
                    {
                        if (clsUserCodePrjMainPathExWApi.DelRecordEx(strUserCodePrjMainPathId, strCmPrjId) == false)
                        {
                            MessageBox.Show("删除记录失败！");
                            BindLv_vUserCodePrjMainPath();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("删除记录失败！{0}", ex.Message));
                        return;
                    }
                }
                MessageBox.Show("删除记录成功！");
                BindLv_vUserCodePrjMainPath();
            }
        }

        private void btnCopyRec_Click(object sender, EventArgs e)
        {
            if (this.lvvUserCodePrjMainPath.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            string strKeyId = this.lvvUserCodePrjMainPath.SelectedItems[0].Tag.ToString();

            lblMsg.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            string strUserCodePrjMainPathId = strKeyId;
            try
            {
                clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                objUserCodePrjMainPathEN.CMProjectAppRelaId = 0;
                objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathWApi.GetMaxStrId();
                objUserCodePrjMainPathEN.AddNewRecord();
                BindLv_vUserCodePrjMainPath();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnCopyTemplateSet_Click(object sender, EventArgs e)
        {
            string strMachineName = Environment.MachineName;
            try
            {
                string strCmPrjId = clsUserDefaValue_LocalExWApi.getUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, "默认CM工程");
                if (string.IsNullOrEmpty(strCmPrjId) == true)
                {
                    var arrCMProject = clsCMProjectExWApi.GetObjLstByPrjIdExCache(clsPubVar.CurrSelPrjId);
                    if (arrCMProject.Count == 0)
                    {
                        var objProject = clsProjectsWApi.GetObjByPrjIdCache(clsPubVar.CurrSelPrjId);
                        MessageBox.Show("项目:[{0}]没有建立相应的CM工程！", objProject.PrjName);
                        return;
                    }
                    strCmPrjId = arrCMProject[0].CmPrjId;
                    clsUserDefaValue_LocalExWApi.setUserDefaValue(clsPubVar.CurrPrjId, clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId, "默认CM工程", strCmPrjId);
                }
                int intCount = clsUserCodePrjMainPathExWApi.CopyUserCodePrjMainPathFromTemplateBak(clsPubVar.CurrSelPrjId, strMachineName, clsSysParaEN.strUserId);
                BindLv_vUserCodePrjMainPath();
                string strMsg = string.Format("复制模板完成！共复制了：[{0}]条记录！", intCount);
                MessageBox.Show(strMsg);

            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
                return;
            }
        }

        private void btnCopyFromOtherPC_Click(object sender, EventArgs e)
        {
            if (this.lvvUserCodePrjMainPath.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("请选择一条记录！");
                return;
            }
            string strKeyId = this.lvvUserCodePrjMainPath.SelectedItems[0].Tag.ToString();

            lblMsg.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；

            string strUserCodePrjMainPathId = strKeyId;
            try
            {
                //clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                //objUserCodePrjMainPathEN.CmPrjId = "";

                var arrUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameExWApi.GetObjLstByUserCodePrjMainPathId(strUserCodePrjMainPathId);
                if (arrUserCodePrjMainPath_MachineName.Count == 0)
                {
                    string strMsg = string.Format("当前用户主路径没有相应PC数据。");
                    MessageBox.Show(strMsg);
                    return;
                }
                var objUserCodePrjMainPath_MachineName = arrUserCodePrjMainPath_MachineName[0];
                objUserCodePrjMainPath_MachineName.MachineName = Environment.MachineName;
                
                objUserCodePrjMainPath_MachineName.AddNewRecord();
                BindLv_vUserCodePrjMainPath();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
    }
}