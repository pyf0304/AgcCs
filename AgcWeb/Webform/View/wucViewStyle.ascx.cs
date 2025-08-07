

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
    using BusinessLogicEx;
    /// <summary>
    ///		wucViewStyleB 的摘要说明。
    /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucViewStyleB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 界面ID
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ViewId
        {
            get
            {
                return txtViewId.Text.Trim();
            }
            set
            {
                txtViewId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 标题类型Id
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string TitleStyleId
        {
            get
            {
                if (ddlTitleStyleId.SelectedValue == "0")
                    return "";
                return ddlTitleStyleId.SelectedValue;
            }
            set
            {
                if (ddlTitleStyleId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTitleStyleId.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlTitleStyleId.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {
                            string strSS = objException.Message;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// DG模式ID
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string DgStyleId
        {
            get
            {
                if (ddlDgStyleId.SelectedValue == "0")
                    return "";
                return ddlDgStyleId.SelectedValue;
            }
            set
            {
                if (ddlDgStyleId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDgStyleId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDgStyleId.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name="bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtViewId.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtViewId.Text = "";
            ddlTitleStyleId.SelectedIndex = 0;
            ddlDgStyleId.SelectedIndex = 0;
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
            txtViewId.Text = "";
            ddlTitleStyleId.SelectedIndex = 0;
            ddlDgStyleId.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表：[TitleStyle]中获取
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetTitleStyleId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TitleStyleId, TitleStyleName from TitleStyle ";
            clsSpecSQLforSql mySql = clsViewStyleBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name="objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_TitleStyleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTitleStyleId();
            objDDL.DataValueField = conTitleStyle.TitleStyleId;
            objDDL.DataTextField = conTitleStyle.TitleStyleName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表：[DataGridStyle]中获取
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetDgStyleId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DgStyleId, DgStyleName from DataGridStyle ";
            clsSpecSQLforSql mySql = clsViewStyleBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name="objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_DgStyleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDgStyleId();
            objDDL.DataValueField = conDataGridStyle.DgStyleId;
            objDDL.DataTextField = conDataGridStyle.DgStyleName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段：[TitleStyleId]
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_TitleStyleId(string strPrjId)
        {
            clsTitleStyleBLEx.BindDdl_TitleStyleId(ddlTitleStyleId, strPrjId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段：[DgStyleId]
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_DgStyleId()
        {
            clsDataGridStyleBL.BindDdl_DgStyleId(ddlDgStyleId);
        }
    }
}