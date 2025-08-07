

namespace AGC.Webform
{
    
    using AGC.BusinessLogic;using AGC.FunClass;
    using com.taishsoft.commdb;
    using com.taishsoft.datetime;
    using System.Web.UI.WebControls;

    /// <summary>
    ///		wucSqlDataSynB 的摘要说明。
    /// </summary>
    public partial class wucSqlDataSynB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            //trSqlData.Visible = false;
        }
        /// <summary>
        /// 表ID
        /// </summary>
        public string TabId
        {
            get
            {
                return txtTabId.Text.Trim();
            }
            set
            {
                txtTabId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 表名
        /// </summary>
        public string TabName
        {
            get
            {
                return txtTabName.Text.Trim();
            }
            set
            {
                txtTabName.Text = value.ToString();
            }
        }


        /// <summary>
        /// 主键类型ID
        /// </summary>
        public string PrimaryTypeId
        {
            get
            {
                if (ddlPrimaryTypeId.SelectedValue == "0")
                    return "";
                return ddlPrimaryTypeId.SelectedValue;
            }
            set
            {
                if (ddlPrimaryTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPrimaryTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPrimaryTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 表中文名
        /// </summary>
        public string TabCnName
        {
            get
            {
                return txtTabCnName.Text.Trim();
            }
            set
            {
                txtTabCnName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 目标表有效记录条件
        /// </summary>
        public string TargetTabCondition
        {
            get
            {
                return txtTargetTabCondition.Text.Trim();
            }
            set
            {
                txtTargetTabCondition.Text = value.ToString();
            }
        }

        /// <summary>
        /// 记录排他方式Id
        /// </summary>
        public string RecExclusiveWayId
        {
            get
            {
                if (ddlRecExclusiveWayId.SelectedValue == "0")
                    return "";
                return ddlRecExclusiveWayId.SelectedValue;
            }
            set
            {
                if (ddlRecExclusiveWayId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlRecExclusiveWayId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRecExclusiveWayId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 表英文详细名
        /// </summary>
        public string TabEnName
        {
            get
            {
                return txtTabEnName.Text.Trim();
            }
            set
            {
                txtTabEnName.Text = value.ToString();
            }
        }

        /// <summary>
        /// Sql表数据
        /// </summary>
        public string SqlData
        {
            get
            {
                return txtSqlData.Text.Trim();
            }
            set
            {
                txtSqlData.Text = value.ToString();
            }
        }

        /// <summary>
        /// Sql命令类型Id
        /// </summary>
        public string SqlCommandTypeId
        {
            get
            {
                if (ddlSqlCommandTypeId.SelectedValue == "0")
                    return "";
                return ddlSqlCommandTypeId.SelectedValue;
            }
            set
            {
                if (ddlSqlCommandTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlSqlCommandTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlSqlCommandTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// Sql命令内容
        /// </summary>
        public string SqlCommandText
        {
            get
            {
                return txtSqlCommandText.Text.Trim();
            }
            set
            {
                txtSqlCommandText.Text = value.ToString();
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
        /// 工程ID
        /// </summary>
        public string PrjId
        {
            get
            {

                return clsPubVar.CurrSelPrjId;
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
            txtTabId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtTabId.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            txtTabEnName.Text = "";
            txtSqlData.Text = "";
            ddlSqlCommandTypeId.SelectedIndex = 0;
            txtSqlCommandText.Text = "";
            txtTextResouce.Text = "";
            ddlTextResourceTypeId.SelectedIndex = 0;
    
         
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
            txtTabId.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            txtTabEnName.Text = "";
            txtSqlData.Text = "";
            ddlSqlCommandTypeId.SelectedIndex = 0;
            txtSqlCommandText.Text = "";
            txtTextResouce.Text = "";
            ddlTextResourceTypeId.SelectedIndex = 0;
          
        
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetSqlCommandTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select SqlCommandTypeId, SqlCommandTypeName from SqlCommandType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_SqlCommandTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetSqlCommandTypeId();
            objDDL.DataValueField = "SqlCommandTypeId";
            objDDL.DataTextField = "SqlCommandTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
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
     
        public void SetDdl_SqlCommandTypeId()
        {
            clsSqlCommandTypeBL.BindDdlSqlCommandTypeId(ddlSqlCommandTypeId);
        }
        public void SetDdl_TextResourceTypeId()
        {
            clsTextResourceTypeBL.BindDdlTextResourceTypeId(ddlTextResourceTypeId);
        }
        //public void SetDdl_PrjId()
        //{
        //  clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        //}


        public void SetDdl_RecExclusiveWayId()
        {
            clsRecExclusiveWayBL.BindDdlRecExclusiveWayId(ddlRecExclusiveWayId);
        }


        public void SetDdl_PrimaryTypeId()
        {
            clsPrimaryTypeBL.BindDdl_PrimaryTypeId(ddlPrimaryTypeId);
        }
    }
}