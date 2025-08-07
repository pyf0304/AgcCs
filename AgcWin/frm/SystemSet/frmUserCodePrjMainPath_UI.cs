

using AGC.Entity;
using Agc_CsWin;
using AGC_CSWin;
using AGC4WApi;
using com.taishsoft.util;
using System;
using System.Text;
using System.Windows.Forms;

namespace AGC
{
    /// <summary>
    ///		frmUserCodePrjMainPath_UI 的摘要说明。
    /// </summary>
    public partial class frmUserCodePrjMainPath_UI : System.Windows.Forms.Form
    {
        clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = null;
        clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName = null;

        private string mstrUserCodePrjMainPathId;		//用于传递关键字值的变量
        public string OperateType;
        public IBindListView iBindListView = null;
        public frmUserCodePrjMainPath_UI()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }
        private void frmUserCodePrjMainPath_UI_Load(object sender, System.EventArgs e)
        {

            this.Text = string.Format("{0}-代码生成主路径设置-维护", clsPubVar.objCurrSelProjectEN.PrjName);
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();

            cboPrjId.SelectedValue = clsPubVar.CurrSelPrjId;
            cboPrjId.Enabled = false;
            cboUserId.SelectedValue = clsSysParaEN.strUserId;
            cboUserId.Enabled = false;

            if (OperateType == "Update")
            {
                ShowData(mstrUserCodePrjMainPathId);
                btnOKUpd.Text = "确认修改";
                //chkIsUsePrjMainPath.Enabled = false;
            }
            else
            {
                AddUserCodePrjMainPathRecord();
            }

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            clsUsersWApi.BindCbo_UserId(this.cboUserId);
            clsProjectsWApi.BindCbo_PrjId(this.cboPrjId);
            //clsCMProjectExWApi.BindCbo_CmPrjIdEx(this.cboCmPrjAppId, clsPubVar.CurrSelPrjId);
            clsCMProjectAppRelaExWApi.BindCbo_CmPrjIdAppByPrjIdEx(this.cboCmPrjAppId, clsPubVar.CurrSelPrjId);

            //clsProgLangTypeExWApi.BindCbo_ProgLangTypeIdEx(cboProgLangTypeId);
            //clsApplicationTypeExWApi.BindCbo_ApplicationTypeIdEx(cboApplicationTypeId);
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
        public long CMProjectAppRelaId
        {
            get
            {
                if (cboCmPrjAppId.SelectedValue.ToString() == "0")
                    return 0;
                return long.Parse( cboCmPrjAppId.SelectedValue.ToString());
            }
            set
            {
                if (value == 0)
                {
                    cboCmPrjAppId.SelectedValue = "0";
                }
                else
                {
                    cboCmPrjAppId.SelectedValue = value;
                }
            }
        }
        public bool IsUsePrjMainPath
        {
            get
            {
                return chkIsUsePrjMainPath.Checked;
            }
            set
            {
                chkIsUsePrjMainPath.Checked = value;

            }
        }
        public bool InUse
        {
            get
            {
                return chkInUse.Checked;
            }
            set
            {
                chkInUse.Checked = value;

            }
        }

        //public int ApplicationTypeId
        //{
        //    get
        //    {
        //        if (cboApplicationTypeId.SelectedValue.ToString() == "0")
        //            return 0;
        //        return int.Parse(cboApplicationTypeId.SelectedValue.ToString());
        //    }
        //    set
        //    {
        //        if (value == 0)
        //        {
        //            cboApplicationTypeId.SelectedValue = "0";
        //        }
        //        else
        //        {
        //            cboApplicationTypeId.SelectedValue = value;
        //        }
        //    }
        //}
        public string CodePath
        {
            get
            {
                return txtCodePath.Text.Trim();
            }
            set
            {
                txtCodePath.Text = value.ToString();
            }
        }
        public string IncludeXmlPath
        {
            get
            {
                return txtIncludeXmlPath.Text.Trim();
            }
            set
            {
                txtIncludeXmlPath.Text = value.ToString();
            }
        }
        public string CodePathBackup
        {
            get
            {
                return txtCodePathBackup.Text.Trim();
            }
            set
            {
                txtCodePathBackup.Text = value.ToString();
            }
        }
        /// <summary>
        /// 日志路径
        /// </summary>
        public string LogPath
        {
            get
            {
                return txtLogPath.Text.Trim();
            }
            set
            {
                txtLogPath.Text = value.ToString();
            }
        }
        public string UpdDate
        {
            get
            {
                return SqlWApi.DateTime_GetDataBaseDateTime14();
            }
        }

        public string UpdUserId
        {
            get
            {
                return clsSysParaEN.strUserId;
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
            cboUserId.SelectedIndex = 0;
            cboPrjId.SelectedIndex = 0;
            chkIsUsePrjMainPath.Checked = false;
            txtCodePath.Text = "";

            txtMemo.Text = "";
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
            chkIsUsePrjMainPath.Checked = false;
            txtCodePath.Text = "";

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
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strUserCodePrjMainPathId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(string strUserCodePrjMainPathId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsUserCodePrjMainPathWApi.IsExist(strUserCodePrjMainPathId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strUserCodePrjMainPathId + "的不存在!";
                MessageBox.Show(ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            objUserCodePrjMainPathEN = clsUserCodePrjMainPathWApi.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
            objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLst(strUserCodePrjMainPathId, Environment.MachineName);

            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromUserCodePrjMainPathClass(objUserCodePrjMainPathEN);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        private void GetDataFromUserCodePrjMainPathClass(clsUserCodePrjMainPathEN pobjUserCodePrjMainPathEN)
        {
            ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
            ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
            this.UserId = pobjUserCodePrjMainPathEN.UserId;
            this.PrjId = pobjUserCodePrjMainPathEN.PrjId;
            this.CMProjectAppRelaId = pobjUserCodePrjMainPathEN.CMProjectAppRelaId;

            this.IsUsePrjMainPath = pobjUserCodePrjMainPathEN.IsUsePrjMainPath;
            this.InUse = pobjUserCodePrjMainPathEN.InUse;

            //this.ProgLangTypeId = pobjUserCodePrjMainPathEN.ProgLangTypeId;
            
            objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLstCache(pobjUserCodePrjMainPathEN.UserCodePrjMainPathId, Environment.MachineName, clsPubVar.CurrSelPrjId);
            if (objUserCodePrjMainPath_MachineName != null)
            {
                this.CodePath = objUserCodePrjMainPath_MachineName.CodePath;
                this.CodePathBackup = objUserCodePrjMainPath_MachineName.CodePathBackup;
                this.LogPath = objUserCodePrjMainPath_MachineName.LogPath;
            }
            this.IncludeXmlPath = pobjUserCodePrjMainPathEN.IncludeXmlPath;
            if (pobjUserCodePrjMainPathEN.Memo != null)            this.Memo = pobjUserCodePrjMainPathEN.Memo;
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            Button btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddUserCodePrjMainPathRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddUserCodePrjMainPathRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    if (objUserCodePrjMainPath_MachineName == null)
                    {
                        objUserCodePrjMainPath_MachineName = new clsUserCodePrjMainPath_MachineNameEN();
                    }
                    UpdateUserCodePrjMainPathRecordSave(objUserCodePrjMainPathEN, objUserCodePrjMainPath_MachineName);
                    break;
            }
        }
        private void PutDataToUserCodePrjMainPathClass(clsUserCodePrjMainPathEN pobjUserCodePrjMainPathEN)
        {
            //long lngCMProjectAppRelaId = clsCMProjectAppRelaExWApi.getCMProjectAppRelaId(this.CmPrjId, this.ApplicationTypeId, clsPubVar.CurrSelPrjId);

            pobjUserCodePrjMainPathEN.UserId = this.UserId;
            pobjUserCodePrjMainPathEN.PrjId = this.PrjId;
            
            pobjUserCodePrjMainPathEN.IsUsePrjMainPath = this.IsUsePrjMainPath;
            pobjUserCodePrjMainPathEN.InUse = this.InUse;

            //pobjUserCodePrjMainPathEN.ProgLangTypeId = this.ProgLangTypeId;
            pobjUserCodePrjMainPathEN.CMProjectAppRelaId = this.CMProjectAppRelaId;

            pobjUserCodePrjMainPathEN.IncludeXmlPath = this.IncludeXmlPath;

            pobjUserCodePrjMainPathEN.UpdDate = this.UpdDate;
            pobjUserCodePrjMainPathEN.UpdUserId = this.UpdUserId;
            pobjUserCodePrjMainPathEN.Memo = this.Memo;
        }

        private void PutDataToUserCodePrjMainPath_MachineClass(clsUserCodePrjMainPath_MachineNameEN pobjUserCodePrjMainPathEN)
        {

            pobjUserCodePrjMainPathEN.MachineName = Environment.MachineName;

            pobjUserCodePrjMainPathEN.CodePath = this.CodePath;
            pobjUserCodePrjMainPathEN.CodePathBackup = this.CodePathBackup;
            pobjUserCodePrjMainPathEN.LogPath = this.LogPath;
            pobjUserCodePrjMainPathEN.IncludeXmlPath = this.IncludeXmlPath;

            pobjUserCodePrjMainPathEN.UpdDate = this.UpdDate;
            pobjUserCodePrjMainPathEN.UpdUserId = this.UpdUserId;
            pobjUserCodePrjMainPathEN.Memo = this.Memo;
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        public string mstrUserCodePrjMainPathId_key
        {
            get
            {
                return mstrUserCodePrjMainPathId;
            }
            set
            {
                mstrUserCodePrjMainPathId = value;
            }
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddUserCodePrjMainPathRecord()
        {
            btnOKUpd.Text = "确认添加";
            //this.mId = clsCommForWin.GetMaxStrId("UserCodePrjMainPath","mId", 8, "");
            //DispEditUserCodePrjMainPathRegion();
        }
        ///插入记录存盘过程代码for C#
        private void AddUserCodePrjMainPathRecordSave()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //clsUserCodePrjMainPathEN objUserCodePrjMainPath;
            //1、检查控件中输入数据类型是否正确
            if (!this.IsValid(ref strResult))
            {
                lblMsg.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、初始化相关类对象
            objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUserCodePrjMainPathClass(objUserCodePrjMainPathEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsUserCodePrjMainPathWApi.CheckPropertyNew(objUserCodePrjMainPathEN);
                //6、把数据实体层的数据存贮到数据库中
                clsUserCodePrjMainPathWApi.AddNewRecord(objUserCodePrjMainPathEN);
            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                MessageBox.Show(strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "添加记录成功!";
            MessageBox.Show(strMsg);
            lblMsg.Text = "添加记录成功!";
            //7、恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            //8、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
            iBindListView.BindListView();
        }
        ///修改存盘准备过程代码 for C#
        private void UpdateUserCodePrjMainPathRecordSave(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!this.IsValid(ref strResult))
            {
                lblMsg.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUserCodePrjMainPathClass(objUserCodePrjMainPathEN);        //把界面的值传到
            PutDataToUserCodePrjMainPath_MachineClass(objUserCodePrjMainPath_MachineName);		//把界面的值传到
            objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId;
            objUserCodePrjMainPath_MachineName.PrjId = objUserCodePrjMainPathEN.PrjId;
            objUserCodePrjMainPath_MachineName.GcPathId = "";
            //3、检查传进去的对象属性是否合法
            try
            {

                if (objUserCodePrjMainPath_MachineName.CodePathBackup == objUserCodePrjMainPath_MachineName.CodePath)
                {
                    lblMsg.Text = "代码路径不能等于备份代码路径!";
                    MessageBox.Show("代码路径不能等于备份代码路径!");
                    return;
                }
                //6、把数据实体层的数据存贮到数据库中
                //clsUserCodePrjMainPathWApi.UpdateRecord(objUserCodePrjMainPathEN);
                objUserCodePrjMainPathEN.Update();

                //string strCondition = objUserCodePrjMainPath_MachineName.GetUniConditionStr_UserCodePrjMainPathIdMachineName();

                StringBuilder sbCondition = new StringBuilder();

                sbCondition.AppendFormat("1 = 1");
                sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
                sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineName.MachineName);
                string strCondition = sbCondition.ToString();
                if (clsUserCodePrjMainPath_MachineNameWApi.IsExistRecord(strCondition) == false)
                {
                    objUserCodePrjMainPath_MachineName.AddNewRecord();
                }
                else
                {
                    objUserCodePrjMainPath_MachineName.Update();
                }
                clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsUserCodePrjMainPathWApi.ReFreshCache(clsPubVar.CurrSelPrjId);
                clsPubVar.arrUserCodePrjMainPathENObjLst = null;
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                MessageBox.Show(strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "修改记录成功!";
            MessageBox.Show(strMsg);
            lblMsg.Text = "修改记录成功!";
            this.Close();
            //5、恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            //6、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。
            iBindListView.BindListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCodePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowserbackup_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCodePathBackup.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}