

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
    
    using com.taishsoft.datetime;

    /// <summary>
    ///		wucSqlViewB 的摘要说明。
    /// </summary>
    public partial class wucSqlViewB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// Sql视图Id
        /// </summary>
        public string SqlViewId
        {
            get
            {
                return txtSqlViewId.Text.Trim();
            }
            set
            {
                txtSqlViewId.Text = value.ToString();
            }
        }

       


        /// <summary>
        /// Sql视图文本内容
        /// </summary>
        public string SqlViewText
        {
            get
            {
                return txtSqlViewText.Text.Trim();
            }
            set
            {
                txtSqlViewText.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文本来源
        /// </summary>
        public string TextResouce
        {
            get
            {
                return txtTextResouce.Text.Trim();
            }
            set
            {
                txtTextResouce.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文本来源类型Id
        /// </summary>
        public string TextResourceTypeId
        {
            get
            {
                if (ddlTextResourceTypeId.SelectedValue == "0")
                    return "";
                return ddlTextResourceTypeId.SelectedValue;
            }
            set
            {
                if (ddlTextResourceTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTextResourceTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTextResourceTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 相关表Id
        /// </summary>
        public string RelaTabId
        {
            get
            {
                if (ddlRelaTabId.SelectedValue == "0")
                    return "";
                return ddlRelaTabId.SelectedValue;
            }
            set
            {
                if (ddlRelaTabId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlRelaTabId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRelaTabId.SelectedValue = value;
                    }
                }
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
            txtSqlViewId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtSqlViewId.Text = "";
           
            txtSqlViewText.Text = "";
            txtTextResouce.Text = "";
            ddlTextResourceTypeId.SelectedIndex = 0;
            ddlRelaTabId.SelectedIndex = 0;
        
         
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
            txtSqlViewId.Text = "";
         
            txtSqlViewText.Text = "";
            txtTextResouce.Text = "";
            ddlTextResourceTypeId.SelectedIndex = 0;
            ddlRelaTabId.SelectedIndex = 0;
       
         
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetTextResourceTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TextResourceTypeId, TextResourceTypeName from TextResourceType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_TextResourceTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTextResourceTypeId();
            objDDL.DataValueField = "TextResourceTypeId";
            objDDL.DataTextField = "TextResourceTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
      
        public void SetDdl_TextResourceTypeId()
        {
            clsTextResourceTypeBL.BindDdlTextResourceTypeId(ddlTextResourceTypeId);
        }
        public void SetDdl_RelaTabId(string strPrjId, string strSqlDsTypeId)
        {
            clsPrjTabBLEx.BindDdl_TabIdBySqlDsTypeIdEx(ddlRelaTabId, strPrjId, strSqlDsTypeId);
           
        }
      
    }
}