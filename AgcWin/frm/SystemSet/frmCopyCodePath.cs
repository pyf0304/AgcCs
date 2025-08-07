

using AGC.Entity;
using AGC_CSWin;
using AGC4WApi;
using com.taishsoft.common;
using com.taishsoft.util;
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/10/13
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：系统设置
///模块英文名：SystemSet
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
//生成与表相关的控件控制层代码
using System;
using System.Windows.Forms;

namespace AGC
{
    /// <summary>
    ///		frmCopyCodePath 的摘要说明。
    /// </summary>
    public partial class frmCopyCodePath : System.Windows.Forms.Form
    {

        private long mlngmId;		//用于传递关键字值的变量
        public string OperateType;
        public IGetValueFromDialog2 iGetValueFromDialog = null;
        private string mstrCodePathType;

        public frmCopyCodePath()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }
        private void frmCopyCodePath_Load(object sender, System.EventArgs e)
        {

            this.Text = string.Format("{0}-从现有代码生成路径中复制",
                clsPubVar.objCurrSelProjectEN.PrjName);

            //1、为下拉框设置数据源，绑定列表数据
            this.SetAllComboBox();



        }
        /// <summary>
        /// 下拉框的绑定函数
        /// </summary>
        private void SetAllComboBox()
        {
            switch (CodePathType)
            {
                case conUserCodePath.CodePath:
                    clsUserCodePathExWApi.BindCbo_DistinctCodePath(cboCodePath, CMProjectAppRelaId                  );
                    break;
                case conUserCodePath.CodePathBackup:
                    clsUserCodePathExWApi.BindCbo_DistinctCodePathBackup(cboCodePath, CMProjectAppRelaId);
                    break;
                default:
                    string strMsg = string.Format("代码路径类型：[{0}]在({1})中没有处理！",
                        CodePathType, clsStackTrace.GetCurrClassFunction());
                    MessageBox.Show(strMsg);
                    break;
            }
        }
        private long mstrCMProjectAppRelaId;
        public long CMProjectAppRelaId
        {
            get
            {
               
                return mstrCMProjectAppRelaId;
            }
            set
            {
                mstrCMProjectAppRelaId = value;

            }
        }

        public string CodePath
        {
            get
            {
                if (cboCodePath.SelectedValue.ToString() == "0")
                    return "";
                return cboCodePath.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    cboCodePath.SelectedValue = "0";
                }
                else
                {
                    cboCodePath.SelectedValue = value;
                }
            }
        }


        public void Clear()
        {
            cboCodePath.SelectedIndex = 0;
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
            cboCodePath.SelectedIndex = 0;

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
                case "确定":
                    string strValue = cboCodePath.SelectedValue.ToString();
                    iGetValueFromDialog.SetValue(CodePathType, strValue);
                    this.Close();
                    break;
            }
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
        /// <summary>
        /// 代码路径类型
        /// </summary>
        public string CodePathType
        {
            get
            {
                return mstrCodePathType;
            }

            set
            {
                mstrCodePathType = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}