

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
    using AGC.BusinessLogic;using AGC.FunClass;

    /// <summary>
    ///		wucCodeTypeB 的摘要说明。
    /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucCodeTypeB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 代码类型Id
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CodeTypeId
        {
            get
            {
                return txtCodeTypeId.Text.Trim();
            }
            set
            {
                txtCodeTypeId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 代码类型名
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CodeTypeName
        {
            get
            {
                return txtCodeTypeName.Text.Trim();
            }
            set
            {
                txtCodeTypeName.Text = value.ToString();
            }
        }
        public string CodeTypeSimName
        {
            get
            {
                return txtCodeTypeSimName.Text.Trim();
            }
            set
            {
                txtCodeTypeSimName.Text = value.ToString();
            }
        }

        public string ClassNameFormat
        {
            get
            {
                return txtClassNameFormat.Text.Trim();
            }
            set
            {
                txtClassNameFormat.Text = value.ToString();
            }
        }
        public string GroupName
        {
            get
            {
                return txtGroupName.Text.Trim();
            }
            set
            {
                txtGroupName.Text = value.ToString();
            }
        }
        /// <summary>
        /// 代码类型英文名
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CodeTypeENName
        {
            get
            {
                return txtCodeTypeENName.Text.Trim();
            }
            set
            {
                txtCodeTypeENName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 前台Or后台
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FrontOrBack
        {
            get
            {
                return txtFrontOrBack.Text.Trim();
            }
            set
            {
                txtFrontOrBack.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否CSharp语言
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsCSharp
        {
            get
            {
                return chkIsCSharp.Checked;
            }
            set
            {
                chkIsCSharp.Checked = value;
            }
        }

        /// <summary>
        /// 是否Java语言
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsJava
        {
            get
            {
                return chkIsJava.Checked;
            }
            set
            {
                chkIsJava.Checked = value;
            }
        }

        /// <summary>
        /// 是否JavaScript语言
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsJavaScript
        {
            get
            {
                return chkIsJavaScript.Checked;
            }
            set
            {
                chkIsJavaScript.Checked = value;
            }
        }

        /// <summary>
        /// 是否SilverLight语言
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsSilverLight
        {
            get
            {
                return chkIsSilverLight.Checked;
            }
            set
            {
                chkIsSilverLight.Checked = value;
            }
        }

        /// <summary>
        /// 是否Swift语言
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsSwift
        {
            get
            {
                return chkIsSwift.Checked;
            }
            set
            {
                chkIsSwift.Checked = value;
            }
        }

        /// <summary>
        /// 是否Web应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsWeb
        {
            get
            {
                return chkIsWeb.Checked;
            }
            set
            {
                chkIsWeb.Checked = value;
            }
        }
        /// <summary>
        /// 是否AspMvc应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsAspMvc
        {
            get
            {
                return chkIsAspMvc.Checked;
            }
            set
            {
                chkIsAspMvc.Checked = value;
            }
        }
        /// <summary>
        /// 是否Web应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsPubApp4WinWeb
        {
            get
            {
                return chkIsPubApp4WinWeb.Checked;
            }
            set
            {
                chkIsPubApp4WinWeb.Checked = value;
            }
        }
        /// <summary>
        /// 是否Win应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsWin
        {
            get
            {
                return chkIsWin.Checked;
            }
            set
            {
                chkIsWin.Checked = value;
            }
        }

        /// <summary>
        /// 是否移动终端应用
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsMobileApp
        {
            get
            {
                return chkIsMobileApp.Checked;
            }
            set
            {
                chkIsMobileApp.Checked = value;
            }
        }

        /// <summary>
        /// 序号
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public int OrderNum
        {
            get
            {
                return int.Parse(txtOrderNum.Text.Trim());
            }
            set
            {
                txtOrderNum.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否默认覆盖
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsDefaultOverride
        {
            get
            {
                return chkIsDefaultOverride.Checked;
            }
            set
            {
                chkIsDefaultOverride.Checked = value;
            }
        }

        /// <summary>
        /// 是否用表名作为路径
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsDirByTabName
        {
            get
            {
                return chkIsDirByTabName.Checked;
            }
            set
            {
                chkIsDirByTabName.Checked = value;
            }
        }
        /// <summary>
        /// 修改日期
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return clsDateTime.getTodayDateTimeStr(1);
            }

        }

        /// <summary>
        /// 修改者
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UpdUser
        {
            get
            {
                return clsCommonSession.UserId;
            }

        }

        /// <summary>
        /// 说明
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtCodeTypeId.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtCodeTypeId.Text = "";
            txtCodeTypeName.Text = "";
            txtCodeTypeENName.Text = "";
            txtFrontOrBack.Text = "";
            chkIsCSharp.Checked = false;
            chkIsJava.Checked = false;
            chkIsJavaScript.Checked = false;
            chkIsSilverLight.Checked = false;
            chkIsSwift.Checked = false;
            chkIsWeb.Checked = false;
            chkIsWin.Checked = false;
            chkIsMobileApp.Checked = false;
            txtOrderNum.Text = "0";
            txtMemo.Text = "";
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            ComValid_OrderNum.Validate();
            if (!ComValid_OrderNum.IsValid) return false;
            if (clsString.IsNumeric(txtOrderNum.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            return true;
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDefaultValue()
        {
            txtCodeTypeId.Text = "";
            txtCodeTypeName.Text = "";
            txtCodeTypeENName.Text = "";
            txtFrontOrBack.Text = "";
            chkIsCSharp.Checked = false;
            chkIsJava.Checked = false;
            chkIsJavaScript.Checked = false;
            chkIsSilverLight.Checked = false;
            chkIsSwift.Checked = false;
            chkIsWeb.Checked = false;
            chkIsWin.Checked = false;
            chkIsMobileApp.Checked = false;
            txtOrderNum.Text = "0";
            txtMemo.Text = "";
        }

        public void SetDdl_ProgLangTypeId()
        {
            clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeId);
        }
    }
}