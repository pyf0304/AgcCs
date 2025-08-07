

namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.commdb;
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucExportExcelSetB 的摘要说明。
    /// </summary>
    public partial class wucExportExcelSetB_Sim : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
       

        /// <summary>
        /// 界面名称
        /// </summary>
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

        /// <summary>
        /// 表名
        /// </summary>
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

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID
        {
            get
            {
                return txtUserID.Text.Trim();
            }
            set
            {
                txtUserID.Text = value.ToString();
            }
        }
        /// <summary>
        /// 导出文件名
        /// </summary>
        public string ExportFileName
        {
            get
            {
                return txtExportFileName.Text.Trim();
            }
            set
            {
                txtExportFileName.Text = value.ToString();
            }
        }


        /// <summary>
        ///  是否默认用户
        /// </summary>
        public bool IsDefaultUser
        {
            set
            {
                lblIsDefaultUser.Text = value ? "默认用户" : "非默认用户";
            }
        }



        public void Clear()
        {
          
            txtViewName.Text = "";
            txtTabName.Text = "";
            txtUserID.Text = "";
          
            txtExportFileName.Text = "";
        
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
            txtTabName.Text = "";
            txtUserID.Text = "";
         
            txtExportFileName.Text = "";
       
        }
    }
}