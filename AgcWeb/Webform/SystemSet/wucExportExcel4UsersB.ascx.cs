

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
    ///		wucExportExcel4UsersB 的摘要说明。
    /// </summary>
    public partial class wucExportExcel4UsersB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 导出Excel用户字段流水号
        /// </summary>
        public string IdExportExcel4Users
        {
            get
            {
                if (ddlIdExportExcel4Users.SelectedValue == "0")
                    return "";
                return ddlIdExportExcel4Users.SelectedValue;
            }
            set
            {
                if (ddlIdExportExcel4Users.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlIdExportExcel4Users.SelectedValue = "0";
                    }
                    else
                    {
                        ddlIdExportExcel4Users.SelectedValue = value;
                    }
                }
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
        /// 字段中文名称
        /// </summary>
        public string FieldCnName
        {
            get
            {
                return txtFieldCnName.Text.Trim();
            }
            set
            {
                txtFieldCnName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否导出
        /// </summary>
        public bool IsExport
        {
            get
            {
                return chkIsExport.Checked;
            }
            set
            {
                chkIsExport.Checked = value;
            }
        }

        /// <summary>
        /// 序号
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
            ddlIdExportExcel4Users.SelectedIndex = 0;
            txtFieldName.Text = "";
            txtFieldCnName.Text = "";
            chkIsExport.Checked = false;
            txtOrderNum.Text = "0";
          
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
        /// 一般规则：
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// </summary>
        public void SetDefaultValue()
        {
            ddlIdExportExcel4Users.SelectedIndex = 0;
            txtFieldName.Text = "";
            txtFieldCnName.Text = "";
            chkIsExport.Checked = false;
            txtOrderNum.Text = "0";
        
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetIdExportExcel4Users()
        {
            //获取某学院所有专业信息
            string strSQL = "select IdExportExcel4Users, ViewTabName from vExportExcelSet ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_IdExportExcel4Users(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetIdExportExcel4Users();
            objDDL.DataValueField = "IdExportExcel4Users";
            objDDL.DataTextField = "ViewTabName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_IdExportExcel4Users()
        {
            clsvExportExcelSetBL.BindDdl_IdExportExcel4Users(ddlIdExportExcel4Users);
        }
        public void SetFieldNameEnable(bool bolIsEnable)
        {
            txtFieldName.Enabled = bolIsEnable;
            txtOrderNum.Enabled = bolIsEnable;
            ddlIdExportExcel4Users.Enabled = bolIsEnable;
        }
    }
}