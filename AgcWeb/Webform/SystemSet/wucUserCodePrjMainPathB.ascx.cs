

namespace AGC.Webform
{
    using System.Web.UI.WebControls;
    using AGC.BusinessLogic;
    using AGC.Entity;
    using AGC.FunClass;
    using BusinessLogicEx;
    using com.taishsoft.commdb;
    using com.taishsoft.datetime;

    /// <summary>
    ///		wucUserCodePrjMainPathB 的摘要说明。
    /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucUserCodePrjMainPathB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 用户ID
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UserId
        {
            get
            {
                if (ddlUserId.SelectedValue == "0")
                    return "";
                return ddlUserId.SelectedValue;
            }
            set
            {
                if (ddlUserId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlUserId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlUserId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 工程ID
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 编程语言类型Id
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 代码路径
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CodePath
        {
            get
            {
                return txtCodePath.Text.Trim();
            }
            set
            {
                txtCodePath.Text = value.ToString();
            }
        }

        /// <summary>
        /// 备份代码路径
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CodePathBackup
        {
            get
            {
                return txtCodePathBackup.Text.Trim();
            }
            set
            {
                txtCodePathBackup.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否模板
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsTemplate
        {
            get
            {
                return chkIsTemplate.Checked;
            }
            set
            {
                chkIsTemplate.Checked = value;
            }
        }
        /// <summary>
        /// 是否模板
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsUsePrjMainPath
        {
            get
            {
                return chkIsUsePrjMainPath.Checked;
            }
            set
            {
                chkIsUsePrjMainPath.Checked = value;
            }
        }
        /// <summary>
        /// 修改日期
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 清除用户自定义控件中，所有控件的值
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
          
            ddlProgLangTypeId.SelectedIndex = 0;
            txtCodePath.Text = "";
            txtCodePathBackup.Text = "";
            chkIsUsePrjMainPath.Checked = false;
            chkIsTemplate.Checked = false;
           
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
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
          
            ddlProgLangTypeId.SelectedIndex = 0;
            txtCodePath.Text = "";
            txtCodePathBackup.Text = "";
            chkIsUsePrjMainPath.Checked = false;
            chkIsTemplate.Checked = false;
          
            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Users]中获取
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = clsUserCodePrjMainPathBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = conUsers.UserId;
            objDDL.DataTextField = conUsers.UserName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Projects]中获取
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjId, PrjName from Projects ";
            clsSpecSQLforSql mySql = clsUserCodePrjMainPathBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_PrjId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPrjId();
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[CodeType]中获取
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetCodeTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select CodeTypeId, CodeTypeName from CodeType ";
            clsSpecSQLforSql mySql = clsUserCodePrjMainPathBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_CodeTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetCodeTypeId();
            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ProgLangType]中获取
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetProgLangTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ProgLangTypeId, ProgLangTypeName from ProgLangType ";
            clsSpecSQLforSql mySql = clsProgLangTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ProgLangTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetProgLangTypeId();
            objDDL.DataValueField = conProgLangType.ProgLangTypeId;
            objDDL.DataTextField = conProgLangType.ProgLangTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[UserId]
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_UserId()
        {
            clsUsersBL.BindDdl_UserId(ddlUserId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[PrjId]
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_PrjId()
        {
            clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        
        /// <summary>
        /// 设置绑定下拉框，针对字段:[ProgLangTypeId]
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_ProgLangTypeId()
        {
            clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeId);
        }
    }
}