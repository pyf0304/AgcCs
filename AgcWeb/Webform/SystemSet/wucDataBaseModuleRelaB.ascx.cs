

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
    ///		wucDataBaseModuleRelaB 的摘要说明。
    /// </summary>
    public partial class wucDataBaseModuleRelaB : System.Web.UI.UserControl
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
        /// 项目数据库Id
        /// </summary>
        public string PrjDataBaseId
        {
            get
            {
                if (ddlPrjDataBaseId.SelectedValue == "0")
                    return "";
                return ddlPrjDataBaseId.SelectedValue;
            }
            set
            {
                if (ddlPrjDataBaseId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPrjDataBaseId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPrjDataBaseId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 功能模块Id
        /// </summary>
        public string FuncModuleAgcId
        {
            get
            {
                if (ddlFuncModuleId.SelectedValue == "0")
                    return "";
                return ddlFuncModuleId.SelectedValue;
            }
            set
            {
                if (ddlFuncModuleId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncModuleId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncModuleId.SelectedValue = value;
                    }
                }
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
            //ddlPrjId.SelectedIndex = 0;
            ddlPrjDataBaseId.SelectedIndex = 0;
            ddlFuncModuleId.SelectedIndex = 0;
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
            //ddlPrjId.SelectedIndex = 0;
            ddlPrjDataBaseId.SelectedIndex = 0;
            ddlFuncModuleId.SelectedIndex = 0;
            chkIsVisible.Checked = false;
            txtMemo.Text = "";
        }
     
        public System.Data.DataTable GetPrjDataBaseId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjDataBaseId, PrjDataBaseName from PrjDataBase ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_PrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPrjDataBaseId();
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetFuncModuleId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncModuleId();
            objDDL.DataValueField = "FuncModuleAgcId";
            objDDL.DataTextField = "FuncModuleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetPrjIdEnabled(bool bolIsEnabled)
        {
            ddlPrjId.Enabled = bolIsEnabled;
        }
        public void SetDdl_PrjId()
        {
          clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_PrjDataBaseId(string strPrjId)
        {
            clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseId, strPrjId);
        }
        public void SetDdl_FuncModuleId(string strPrjId)
        {
            clsFuncModule_AgcBLEx.BindDdl_FuncModuleIdExCache(ddlFuncModuleId, strPrjId);
        }

        protected void ddlPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPrjId.SelectedIndex > 0)
            {
                string strPrjId = ddlPrjId.SelectedValue;
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleIdExCache(ddlFuncModuleId, strPrjId);
                clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseId, strPrjId);
            }
        }
    }
}