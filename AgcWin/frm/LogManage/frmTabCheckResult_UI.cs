
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
using AGC.Entity;
using com.taishsoft.util;
using CommFunc4Win;
using AGC_CSWin;
using AGC4WApi;

namespace AGC
{
    /// <summary>
    ///		frmTabCheckResult_UI 的摘要说明。
    /// </summary>
    public partial class frmTabCheckResult_UI : System.Windows.Forms.Form
    {
        clsTabCheckResultEN objTabCheckResultEN = null;
        private long mlngmId;		//用于传递关键字值的变量
        public string OperateType;
        public IBindListView iBindListView = null;
        public frmTabCheckResult_UI()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }
        private void frmTabCheckResult_UI_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();
            if (OperateType == "Update")
            {
                ShowData(mlngmId);
                btnOKUpd.Text = "确认修改";
            }
            else
            {
                AddTabCheckResultRecord();
            }

        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
             clsProjectsWApi.BindCbo_PrjId(this.cboPrjId);
            clsPrjTabWApi.BindCbo_TabId(this.cboTabId, clsSysParaEN_Local.CurrPrjId);
            clsErrorLevelWApi.BindCbo_ErrorLevelId(this.cboErrorLevelId);
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

        public string FldID
        {
            get
            {
                return txtFldID.Text.Trim();
            }
            set
            {
                txtFldID.Text = value.ToString();
            }
        }

        public int ErrorLevelId
        {
            get
            {
                if (cboErrorLevelId.SelectedValue.ToString() == "0")
                    return -1;
                return int.Parse( cboErrorLevelId.SelectedValue.ToString());
            }
            set
            {
                if (value == -1)
                {
                    cboErrorLevelId.SelectedValue = "0";
                }
                else
                {
                    cboErrorLevelId.SelectedValue = value;
                }
            }
        }

        public string ErrorMsg
        {
            get
            {
                return txtErrorMsg.Text.Trim();
            }
            set
            {
                txtErrorMsg.Text = value.ToString();
            }
        }

        public string CheckDate
        {
            get
            {
                return txtCheckDate.Text.Trim();
            }
            set
            {
                txtCheckDate.Text = value.ToString();
            }
        }

        public string CheckUser
        {
            get
            {
                return txtCheckUser.Text.Trim();
            }
            set
            {
                txtCheckUser.Text = value.ToString();
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
            cboPrjId.SelectedIndex = 0;
            cboTabId.SelectedIndex = 0;
            txtFldID.Text = "";
            cboErrorLevelId.SelectedIndex = 0;
            txtErrorMsg.Text = "";
            txtCheckDate.Text = "";
            txtCheckUser.Text = "";
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
            cboPrjId.SelectedIndex = 0;
            cboTabId.SelectedIndex = 0;
            txtFldID.Text = "";
            cboErrorLevelId.SelectedIndex = 0;
            txtErrorMsg.Text = "";
            txtCheckDate.Text = "";
            txtCheckUser.Text = "";
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
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(long lngmId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsTabCheckResultWApi.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + lngmId + "的不存在!";
                MessageBox.Show(ss);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            objTabCheckResultEN = clsTabCheckResultWApi.GetObjBymId(lngmId);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromTabCheckResultClass(objTabCheckResultEN);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        private void GetDataFromTabCheckResultClass(clsTabCheckResultEN pobjTabCheckResultEN)
        {
            ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
            ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
            this.PrjId = pobjTabCheckResultEN.PrjId;
            this.TabId = pobjTabCheckResultEN.TabId;
            this.FldID = pobjTabCheckResultEN.FldId;
            this.ErrorLevelId = pobjTabCheckResultEN.ErrorLevelId;
            this.ErrorMsg = pobjTabCheckResultEN.ErrorMsg;
            this.CheckDate = pobjTabCheckResultEN.CheckDate;
            this.CheckUser = pobjTabCheckResultEN.CheckUser;
            this.Memo = pobjTabCheckResultEN.Memo;
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
                    AddTabCheckResultRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddTabCheckResultRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    UpdateTabCheckResultRecordSave(objTabCheckResultEN);
                    break;
            }
        }
        private void PutDataToTabCheckResultClass(clsTabCheckResultEN pobjTabCheckResultEN)
        {
            pobjTabCheckResultEN.PrjId = this.PrjId;
            pobjTabCheckResultEN.TabId = this.TabId;
            pobjTabCheckResultEN.FldId = this.FldID;
            pobjTabCheckResultEN.ErrorLevelId = this.ErrorLevelId;
            pobjTabCheckResultEN.ErrorMsg = this.ErrorMsg;
            pobjTabCheckResultEN.CheckDate = this.CheckDate;
            pobjTabCheckResultEN.CheckUser = this.CheckUser;
            pobjTabCheckResultEN.Memo = this.Memo;
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        public long mId_key
        {
            get
            {
                return mlngmId;
            }
            set
            {
                mlngmId = value;
            }
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddTabCheckResultRecord()
        {
            btnOKUpd.Text = "确认添加";
            //this.mId = clsCommForWin.GetMaxStrId("TabCheckResult","mId", 8, "");
            //DispEditTabCheckResultRegion();
        }
        ///插入记录存盘过程代码for C#
        private void AddTabCheckResultRecordSave()
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
            //clsTabCheckResultEN objTabCheckResult;
            //1、检查控件中输入数据类型是否正确
            if (!this.IsValid(ref strResult))
            {
                lblMsg.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、初始化相关类对象
            objTabCheckResultEN = new clsTabCheckResultEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                //6、把数据实体层的数据存贮到数据库中
       objTabCheckResultEN.AddNewRecord();
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
        private void UpdateTabCheckResultRecordSave(clsTabCheckResultEN objTabCheckResultEN)
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
            PutDataToTabCheckResultClass(objTabCheckResultEN);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            try
            {                
                //6、把数据实体层的数据存贮到数据库中
                objTabCheckResultEN.Update();
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
    }
}