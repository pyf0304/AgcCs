

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
    using AGC.BusinessLogicEx;
    using AGC.BusinessLogic;using AGC.FunClass;

    /// <summary>
    ///		wucUserTabB 的摘要说明。
    /// </summary>
    public partial class wucUserTabB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// IdUser
        /// </summary>
        public string IdUser
        {
            get
            {
                return txtIdUser.Text.Trim();
            }
            set
            {
                txtIdUser.Text = value.ToString();
            }
        }

        /// <summary>
        /// 学院流水号
        /// </summary>
        public string DepartmentId
        {
            get
            {
                if (ddlDepartmentId.SelectedValue == "0")
                    return "";
                return ddlDepartmentId.SelectedValue;
            }
            set
            {
                if (ddlDepartmentId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDepartmentId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDepartmentId.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// 角色类型
        /// </summary>
        public string IdentityID
        {
            get
            {
                if (ddlIdentityID.SelectedValue == "0")
                    return "";
                return ddlIdentityID.SelectedValue;
            }
            set
            {
                if (ddlIdentityID.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlIdentityID.SelectedValue = "0";
                    }
                    else
                    {
                        ddlIdentityID.SelectedValue = value;
                    }
                }
            }
        }

       

        /// <summary>
        /// 登录名称
        /// </summary>
        public string UserId
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
        /// 用户姓名
        /// </summary>
        public string UserName
        {
            get
            {
                return txtUserName.Text.Trim();
            }
            set
            {
                txtUserName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 口令
        /// </summary>
        public string UserPwd
        {
            get
            {
                return txtUserPwd.Text.Trim();
            }
            set
            {
                txtUserPwd.Text = value.ToString();
            }
        }


        /// <summary>
        /// 是否审核
        /// </summary>
        public bool Audit
        {
            get
            {
                return chkAudit.Checked;
            }
            set
            {
                chkAudit.Checked = value;
            }
        }

        /// <summary>
        /// 操作人
        /// </summary>
        public string AuditUser
        {
            get
            {
                return txtAuditUser.Text.Trim();
            }
            set
            {
                txtAuditUser.Text = value.ToString();
            }
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string RegisterDate
        {
            get
            {
                return txtRegisterDate.Text.Trim();
            }
            set
            {
                txtRegisterDate.Text = value.ToString();
            }
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        public string AuditDate
        {
            get
            {
                return txtAuditDate.Text.Trim();
            }
            set
            {
                txtAuditDate.Text = value.ToString();
            }
        }

        /// <summary>
        /// 备注
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
            txtIdUser.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtIdUser.Text = "";

            ddlIdentityID.SelectedIndex = 0;
            ddlDepartmentId.SelectedIndex = 0;
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtUserPwd.Text = "";
            txtActive.Text = "";
            chkAudit.Checked = false;
            txtAuditUser.Text = "";
            txtRegisterDate.Text = "";
            txtAuditDate.Text = "";
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
            //ComValid_DepartmentId.Validate();
            //if (!ComValid_DepartmentId.IsValid) return false;
            //if (clsString.IsNumeric(ddlDepartmentId.Text) == false)
            //{
            //    strResult = "请输入正确的整型!";
            //    return false;
            ////}
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
            txtIdUser.Text = "";
    
            ddlIdentityID.SelectedIndex = 0;
            ddlDepartmentId.SelectedIndex = 0;
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtUserPwd.Text = "";
            txtActive.Text = "";
            chkAudit.Checked = false;
            txtAuditUser.Text = "";
            txtRegisterDate.Text = "";
            txtAuditDate.Text = "";
            txtMemo.Text = "";
        }
     
        public void SetDdl_IdentityID()
        {
            clsUserIdentityBL.BindDdlIdentityID(ddlIdentityID);
        }
        public void SetDdl_DepartmentId()
        {
            clsDepartmentInfoBLEx.BindDdl_DepartmentIdEx(ddlDepartmentId);
        }
    }
}