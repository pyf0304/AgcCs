

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
    ///		wucSetFieldVisibilityB 的摘要说明。
    /// </summary>
    public partial class wucSetFieldVisibilityBBak : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 学校流水号
        /// </summary>
        public string IdSchool
        {
            get
            {
                if (ddlIdSchool.SelectedValue == "0")
                    return "";
                return ddlIdSchool.SelectedValue;
            }
            set
            {
                if (ddlIdSchool.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlIdSchool.SelectedValue = "0";
                    }
                    else
                    {
                        ddlIdSchool.SelectedValue = value;
                    }
                }
            }
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
        /// 字段名
        /// </summary>
        public string FieldName
        {
            get
            {
                return txtFieldName.Text.Trim();
            }
            set
            {
                txtFieldName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 控件类型
        /// </summary>
        public string CtrlType
        {
            get
            {
                return txtCtrlType.Text.Trim();
            }
            set
            {
                txtCtrlType.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return chkIsVisible.Checked;
            }
            set
            {
                chkIsVisible.Checked = value;
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


        public void Clear()
        {
            ddlIdSchool.SelectedIndex = 0;
            txtViewName.Text = "";
            txtFieldName.Text = "";
            txtCtrlType.Text = "";
            chkIsVisible.Checked = false;
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
            ddlIdSchool.SelectedIndex = 0;
            txtViewName.Text = "";
            txtFieldName.Text = "";
            txtCtrlType.Text = "";
            chkIsVisible.Checked = false;
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetIdSchool()
        {
            //获取某学院所有专业信息
            string strSQL = "select IdSchool, SchoolName from XzSchool ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_IdSchool(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetIdSchool();
            objDDL.DataValueField = "IdSchool";
            objDDL.DataTextField = "SchoolName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_IdSchool()
        {
            clsXzSchoolBL.BindDdl_IdSchool(ddlIdSchool);
        }
        public void SetIdSchoolEnabledFalse()
        {
            ddlIdSchool.Enabled = false;
        }
    }
}