

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
    ///		wucTabCheckResultB 的摘要说明。
    /// </summary>
    public partial class wucTabCheckResultB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 工程ID
        /// </summary>
        public string PrjId
        {
            get
            {
                if (ddlPrjId.SelectedValue == "0")
                    return "";
                return ddlPrjId.SelectedValue;
            }
            set
            {
                if (ddlPrjId.Items.Count > 0)
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
        }

        /// <summary>
        /// 表ID
        /// </summary>
        public string TabId
        {
            get
            {
                if (ddlTabId.SelectedValue == "0")
                    return "";
                return ddlTabId.SelectedValue;
            }
            set
            {
                if (ddlTabId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 字段ID
        /// </summary>
        public string FldId
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

        /// <summary>
        /// 错误等级Id
        /// </summary>
        public int ErrorLevelId
        {
            get
            {
                return int.Parse( txtErrorLevelId.Text.Trim());
            }
            set
            {
                txtErrorLevelId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string errorMsg
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

        /// <summary>
        /// 检查日期
        /// </summary>
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

        /// <summary>
        /// 检查人
        /// </summary>
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


        public void Clear()
        {
            ddlPrjId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtFldID.Text = "";
            txtErrorLevelId.Text = "";
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
            ddlPrjId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtFldID.Text = "";
            txtErrorLevelId.Text = "";
            txtErrorMsg.Text = "";
            txtCheckDate.Text = "";
            txtCheckUser.Text = "";
            txtMemo.Text = "";
        }
  
      
        public void SetDdl_PrjId()
        {
          clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_TabId()
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, clsPubVar.CurrSelPrjId);
        }
    }
}