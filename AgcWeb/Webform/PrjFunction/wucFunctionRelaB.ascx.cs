
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFunctionRelaB
表名:FunctionRela
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
    using AGC.BusinessLogic;using AGC.FunClass;

    /// <summary>
    ///		wucFunctionRelaB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucFunctionRelaB : System.Web.UI.UserControl
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
        /// 函数AId
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncAId
        {
            get
            {
                if (ddlFuncAId.SelectedValue == "0")
                    return "";
                return ddlFuncAId.SelectedValue;
            }
            set
            {
                if (ddlFuncAId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncAId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncAId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 函数BId
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncBId
        {
            get
            {
                if (ddlFuncBId.SelectedValue == "0")
                    return "";
                return ddlFuncBId.SelectedValue;
            }
            set
            {
                if (ddlFuncBId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncBId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncBId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 函数关系类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FunctionRelaTypeId
        {
            get
            {
                if (ddlFunctionRelaTypeId.SelectedValue == "0")
                    return "";
                return ddlFunctionRelaTypeId.SelectedValue;
            }
            set
            {
                if (ddlFunctionRelaTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFunctionRelaTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFunctionRelaTypeId.SelectedValue = value;
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
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            ddlFuncAId.SelectedIndex = 0;
            ddlFuncBId.SelectedIndex = 0;
            ddlFunctionRelaTypeId.SelectedIndex = 0;         
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
            ddlFuncAId.SelectedIndex = 0;
            ddlFuncBId.SelectedIndex = 0;
            ddlFunctionRelaTypeId.SelectedIndex = 0;
          
            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Function4GeneCode]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFuncAId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncId4GC, FuncName from Function4GeneCode ";
            clsSpecSQLforSql mySql = clsFunctionRelaBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FuncAId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncAId();
            objDDL.DataValueField = conFunction4GeneCode.FuncId4GC;
            objDDL.DataTextField = conFunction4GeneCode.FuncName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Function4GeneCode]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFuncBId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncId4GC, FuncName from Function4GeneCode ";
            clsSpecSQLforSql mySql = clsFunctionRelaBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FuncBId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncBId();
            objDDL.DataValueField = conFunction4GeneCode.FuncId4GC;
            objDDL.DataTextField = conFunction4GeneCode.FuncName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[FunctionRelaType]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFunctionRelaTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FunctionRelaTypeId, FunctionRelaTypeName from FunctionRelaType ";
            clsSpecSQLforSql mySql = clsFunctionRelaBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FunctionRelaTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFunctionRelaTypeId();
            objDDL.DataValueField = conFunctionRelaType.FunctionRelaTypeId;
            objDDL.DataTextField = conFunctionRelaType.FunctionRelaTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_FuncAId()
        {
            //clsFunction4GeneCodeBL.BindDdl_FuncId4GC(ddlFuncAId);
        }
        public void SetDdl_FuncBId()
        {
            //clsFunction4GeneCodeBL.BindDdl_FuncId4GC(ddlFuncBId);
        }
        public void SetDdl_FunctionRelaTypeId()
        {
            clsFunctionRelaTypeBL.BindDdlFunctionRelaTypeIdCache(ddlFunctionRelaTypeId);
        }
    }
}