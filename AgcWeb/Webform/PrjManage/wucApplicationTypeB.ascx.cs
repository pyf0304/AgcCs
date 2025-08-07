

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
    ///		wucApplicationTypeB 的摘要说明。
    /// </summary>
    public partial class wucApplicationTypeB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 应用程序类型ID
        /// </summary>
        public int ApplicationTypeId
        {
            get
            {
                return int.Parse( txtApplicationTypeId.Text.Trim());
            }
            set
            {
                txtApplicationTypeId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 应用程序类型名称
        /// </summary>
        public string ApplicationTypeName
        {
            get
            {
                return txtApplicationTypeName.Text.Trim();
            }
            set
            {
                txtApplicationTypeName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 应用程序类型英文名称
        /// </summary>
        public string ApplicationTypeENName
        {
            get
            {
                return txtApplicationTypeENName.Text.Trim();
            }
            set
            {
                txtApplicationTypeENName.Text = value.ToString();
            }
        }
        /// <summary>
        /// 编程语言类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ProgLangTypeId
        {
            get
            {
                if (ddlProgLangTypeId.SelectedValue == "0")
                    return "";
                return ddlProgLangTypeId.SelectedValue;
            }
            set
            {
                if (ddlProgLangTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlProgLangTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlProgLangTypeId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// 编程语言类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ProgLangTypeId2
        {
            get
            {
                if (ddlProgLangTypeId2.SelectedValue == "0")
                    return "";
                return ddlProgLangTypeId2.SelectedValue;
            }
            set
            {
                if (ddlProgLangTypeId2.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlProgLangTypeId2.SelectedValue = "0";
                    }
                    else
                    {
                        ddlProgLangTypeId2.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 编程语言类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ProgLangTypeId3
        {
            get
            {
                if (ddlProgLangTypeId3.SelectedValue == "0")
                    return "";
                return ddlProgLangTypeId3.SelectedValue;
            }
            set
            {
                if (ddlProgLangTypeId3.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlProgLangTypeId3.SelectedValue = "0";
                    }
                    else
                    {
                        ddlProgLangTypeId3.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// 编程语言类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ProgLangTypeId4
        {
            get
            {
                if (ddlProgLangTypeId4.SelectedValue == "0")
                    return "";
                return ddlProgLangTypeId4.SelectedValue;
            }
            set
            {
                if (ddlProgLangTypeId4.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlProgLangTypeId4.SelectedValue = "0";
                    }
                    else
                    {
                        ddlProgLangTypeId4.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 编程语言类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsVible
        {
            get
            {
                return chkIsVible.Checked;
            }
            set
            {
                chkIsVible.Checked = value;
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
            txtApplicationTypeId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtApplicationTypeId.Text = "";
            txtApplicationTypeName.Text = "";
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
            txtApplicationTypeId.Text = "";
            txtApplicationTypeName.Text = "";
            txtMemo.Text = "";
        }
        public void SetDdl_ProgLangTypeId()
        {
            clsProgLangTypeBLEx.BindDdl_ProgLangTypeIdExCache(ddlProgLangTypeId);
        }

        public void SetDdl_ProgLangTypeId2()
        {
            clsProgLangTypeBLEx.BindDdl_ProgLangTypeIdExCache(ddlProgLangTypeId2);
        }
        public void SetDdl_ProgLangTypeId3()
        {
            clsProgLangTypeBLEx.BindDdl_ProgLangTypeIdExCache(ddlProgLangTypeId3);
        }
        public void SetDdl_ProgLangTypeId4()
        {
            clsProgLangTypeBLEx.BindDdl_ProgLangTypeIdExCache(ddlProgLangTypeId4);
        }
     
    }
}