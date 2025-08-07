

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
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucProgLevelTypeB 的摘要说明。
    /// </summary>
    public partial class wucProgLevelTypeB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 程序分层类型
        /// </summary>
        public string ProgLevelTypeId
        {
            get
            {
                return txtProgLevelTypeId.Text.Trim();
            }
            set
            {
                txtProgLevelTypeId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 程序分层类型名称
        /// </summary>
        public string ProgLevelTypeName
        {
            get
            {
                return txtProgLevelTypeName.Text.Trim();
            }
            set
            {
                txtProgLevelTypeName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 程序分层类型英文名称
        /// </summary>
        public string ProgLevelTypeENName
        {
            get
            {
                return txtProgLevelTypeENName.Text.Trim();
            }
            set
            {
                txtProgLevelTypeENName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 前缀
        /// </summary>
        public string Prefix
        {
            get
            {
                return txtPrefix.Text.Trim();
            }
            set
            {
                txtPrefix.Text = value.ToString();
            }
        }

        /// <summary>
        /// 修改日期
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(1);
            }           
        }

        /// <summary>
        /// 修改用户Id
        /// </summary>
        public string UpdUserId
        {
            get
            {
                return clsCommonSession.UserId;
            }
           
        }

        /// <summary>
        /// 说明
        /// </summary>
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


        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtProgLevelTypeId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtProgLevelTypeId.Text = "";
            txtProgLevelTypeName.Text = "";
            txtProgLevelTypeENName.Text = "";
            txtPrefix.Text = "";
       
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
            txtProgLevelTypeId.Text = "";
            txtProgLevelTypeName.Text = "";
            txtProgLevelTypeENName.Text = "";
            txtPrefix.Text = "";
         
            txtMemo.Text = "";
        }
    }
}