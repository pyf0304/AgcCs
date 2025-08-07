
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFunction4GeneCodeB
表名:Function4GeneCode
生成代码版本:2017.03.27.1
生成日期:2017/03/28
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// == == == == == == == == == == == == 
*/

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
    ///		wucFunction4GeneCodeB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucFunction4GC4BatchUpdate : System.Web.UI.UserControl
    {
        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
       

        /// <summary>
        /// 函数名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string SourceStr
        {
            get
            {
                return txtSourceStr.Text.Trim();
            }
            set
            {
                txtSourceStr.Text = value.ToString();
            }
        }
        
        
       
        /// <summary>
        /// 函数签名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string AdditionalPrefix
        {
            get
            {
                return txtAdditionalPrefix.Text.Trim();
            }
            set
            {
                txtAdditionalPrefix.Text = value.ToString();
            }
        }


        /// <summary>
        /// 功能Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FeatureId
        {
            get
            {
                if (ddlFeatureId.SelectedValue == "0")
                    return "";
                return ddlFeatureId.SelectedValue;
            }
            set
            {
                if (ddlFeatureId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFeatureId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFeatureId.SelectedValue = value;
                    }
                }
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
        /// 程序分层类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string CodeTypeId
        {
            get
            {
                if (ddlCodeTypeId.SelectedValue == "0")
                    return "";
                return ddlCodeTypeId.SelectedValue;
            }
            set
            {
                if (ddlCodeTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlCodeTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlCodeTypeId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// 数据源类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string SqlDsTypeId
        {
            get
            {
                if (ddlSqlDsTypeId.SelectedValue == "0")
                    return "";
                return ddlSqlDsTypeId.SelectedValue;
            }
            set
            {
                if (ddlSqlDsTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlSqlDsTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlSqlDsTypeId.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// 返回类型ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ReturnTypeID
        {
            get
            {
                if (ddlReturnTypeID.SelectedValue == "0")
                    return "";
                return ddlReturnTypeID.SelectedValue;
            }
            set
            {
                if (ddlReturnTypeID.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlReturnTypeID.SelectedValue = "0";
                    }
                    else
                    {
                        ddlReturnTypeID.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 函数类型ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncTypeId
        {
            get
            {
                if (ddlFuncTypeID.SelectedValue == "0")
                    return "";
                return ddlFuncTypeID.SelectedValue;
            }
            set
            {
                if (ddlFuncTypeID.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncTypeID.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncTypeID.SelectedValue = value;
                    }
                }
            }
        }

        

        /// <summary>
        /// 函数代码
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string TargetStr
        {
            get
            {
                return txtTargetStr.Text.Trim();
            }
            set
            {
                txtTargetStr.Text = value.ToString();
            }
        }

        /// <summary>
        /// 用户ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UserId
        {
            get
            {              
                return clsCommonSession.UserId;
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
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {

            txtSourceStr.Text = "";
            txtTargetStr.Text = "";

            txtAdditionalPrefix.Text = "";
            ddlProgLangTypeId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
    
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;
           
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDefaultValue()
        {
            
            txtSourceStr.Text = "";
            txtTargetStr.Text = "";
            ddlProgLangTypeId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
            
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;
        
            
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ProgLangType]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetProgLangTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ProgLangTypeId, ProgLangTypeName from ProgLangType ";
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
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
        /// 为下拉框获取数据,从表:[Projects]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjId, PrjName from Projects ";
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
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
        /// 为下拉框获取数据,从表:[DataTypeAbbr]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetReturnTypeID()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataTypeId, DataTypeName from DataTypeAbbr ";
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ReturnTypeID(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetReturnTypeID();
            objDDL.DataValueField = conDataTypeAbbr.DataTypeId;
            objDDL.DataTextField = conDataTypeAbbr.DataTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
       
        /// <summary>
        /// 为下拉框获取数据,从表:[Users]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
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
        public void SetDdl_ProgLangTypeId()
        {
            clsProgLangTypeBL.BindDdl_ProgLangTypeIdCache(ddlProgLangTypeId);
        }
        public void SetDdl_CodeTypeId()
        {
            clsCodeTypeBLEx.BindDdl_CodeTypeIdWithLangTypeidEx(ddlCodeTypeId);
        }
     
        public void SetDdl_ReturnTypeID()
        {
            clsDataTypeAbbrBL.BindDdl_DataTypeIdCache(ddlReturnTypeID);
        }

    
        public void SetDdl_FuncTypeID()
        {
            clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeID);
        }
        public void SetDdl_SqlDsTypeId()
        {
            clsSQLDSTypeBL.BindDdl_SqlDsTypeIdCache(ddlSqlDsTypeId);
        }
        public void SetDdl_FeatureId()
        {
            clsPrjFeatureBLEx.BindDdl_FeatureIdExByOrderNum(ddlFeatureId);
        }
               
    }
}