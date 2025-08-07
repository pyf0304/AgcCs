
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucPrjFunctionB
表名:PrjFunction
生成代码版本:2017.03.30.1
生成日期:2017/04/01
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// == == == == == == == == == == == == 
*/

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
    using AGC.BusinessLogic;
    using AGC.FunClass;
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucPrjFunctionB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucPrjFunctionB : System.Web.UI.UserControl
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
        /// 函数ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncId
        {
            get
            {
                return txtFuncId.Text.Trim();
            }
            set
            {
                txtFuncId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 函数名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncName
        {
            get
            {
                return txtFuncName.Text.Trim();
            }
            set
            {
                txtFuncName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 工程ID
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 是否模板
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 函数代码
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncCode
        {
            get
            {
                return txtFuncCode.Text.Trim();
            }
            set
            {
                txtFuncCode.Text = value.ToString();
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
        /// 修改日期
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return txtUpdDate.Text.Trim();
            }
            set
            {
                txtUpdDate.Text = value.ToString();
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
                return txtUpdUser.Text.Trim();
            }
            set
            {
                txtUpdUser.Text = value.ToString();
            }
        }

        /// <summary>
        /// 说明
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtFuncId.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtFuncId.Text = "";
            txtFuncName.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;
            chkIsTemplate.Checked = false;
            txtFuncCode.Text = "";
            ddlUserId.SelectedIndex = 0;
            txtUpdDate.Text = "";
            txtUpdUser.Text = "";
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
            txtFuncId.Text = "";
            txtFuncName.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlReturnTypeID.SelectedIndex = 0;
            ddlFuncTypeID.SelectedIndex = 0;
            chkIsTemplate.Checked = false;
            txtFuncCode.Text = "";
            ddlUserId.SelectedIndex = 0;
            txtUpdDate.Text = "";
            txtUpdUser.Text = "";
            txtMemo.Text = "";
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
            clsSpecSQLforSql mySql = clsPrjFunctionBL.GetSpecSQLObj();
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
            clsSpecSQLforSql mySql = clsPrjFunctionBL.GetSpecSQLObj();
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
            clsSpecSQLforSql mySql = clsPrjFunctionBL.GetSpecSQLObj();
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
        public void SetDdl_PrjId()
        {
            clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_ReturnTypeID()
        {
            clsDataTypeAbbrBL.BindDdl_DataTypeIdCache(ddlReturnTypeID);
        }
        public void SetDdl_FuncTypeID()
        {
            clsFunctionTypeBL.BindDdl_FuncTypeIdCache(ddlFuncTypeID);
        }
        public void SetDdl_UserId()
        {
            clsUsersBL.BindDdl_UserId(ddlUserId);
        }
    }
}