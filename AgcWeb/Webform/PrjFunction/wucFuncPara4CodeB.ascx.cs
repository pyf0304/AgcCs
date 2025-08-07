
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucFuncPara4CodeB
表名:FuncPara4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:50:47
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:Web界面层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
    using System;
    using System.Web.UI.WebControls;
    using AGC.BusinessLogic;
    using AGC.Entity;
    using AGC.FunClass;
    using BusinessLogicEx;
    using com.taishsoft.commdb;
    using com.taishsoft.datetime;

    /// <summary>
    ///		wucFuncPara4CodeB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucFuncPara4CodeB : System.Web.UI.UserControl
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
        /// FuncParaId4Code
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncParaId4Code
        {
            get
            {
                return txtFuncParaId4Code.Text.Trim();
            }
            set
            {
                txtFuncParaId4Code.Text = value.ToString();
            }
        }

        /// <summary>
        /// 参数名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ParaName
        {
            get
            {
                return txtParaName.Text.Trim();
            }
            set
            {
                txtParaName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 参数中文名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ParaCnName
        {
            get
            {
                return txtParaCnName.Text.Trim();
            }
            set
            {
                txtParaCnName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 函数Id4Code
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string FuncId4Code
        {
            get
            {
                if (ddlFuncId4Code.SelectedValue == "0")
                    return "";
                return ddlFuncId4Code.SelectedValue;
            }
            set
            {
                if (ddlFuncId4Code.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncId4Code.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncId4Code.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 数据类型Id
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string DataTypeId
        {
            get
            {
                if (ddlDataTypeId.SelectedValue == "0")
                    return "";
                return ddlDataTypeId.SelectedValue;
            }
            set
            {
                if (ddlDataTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDataTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlDataTypeId.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {

                            clsPubVar.objLog.WriteDebugLog(objException.Message);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 参数类型
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ParameterType
        {
            get
            {
                return txtParameterType.Text.Trim();
            }
            set
            {
                txtParameterType.Text = value.ToString();
            }
        }

        /// <summary>
        /// 参数类型全名
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ParameterTypeFullName
        {
            get
            {
                return txtParameterTypeFullName.Text.Trim();
            }
            set
            {
                txtParameterTypeFullName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否引用型参数
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsByRef
        {
            get
            {
                return chkIsByRef.Checked;
            }
            set
            {
                chkIsByRef.Checked = value;
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtFuncParaId4Code.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtFuncParaId4Code.Text = "";
            txtParaName.Text = "";
            txtParaCnName.Text = "";
            ddlFuncId4Code.SelectedIndex = 0;
            ddlDataTypeId.SelectedIndex = 0;
            txtParameterType.Text = "";
            txtParameterTypeFullName.Text = "";
            chkIsByRef.Checked = false;            
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
            txtFuncParaId4Code.Text = "";
            txtParaName.Text = "";
            txtParaCnName.Text = "";
            ddlFuncId4Code.SelectedIndex = 0;
            ddlDataTypeId.SelectedIndex = 0;
            txtParameterType.Text = "";
            txtParameterTypeFullName.Text = "";
            chkIsByRef.Checked = false;
            
            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Function4Code]中获取
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFuncId4Code()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncId4Code, FuncName4Code from Function4Code ";
            clsSpecSQLforSql mySql = clsFuncPara4CodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FuncId4Code(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncId4Code();
            objDDL.DataValueField = conFunction4Code.FuncId4Code;
            objDDL.DataTextField = conFunction4Code.FuncName4Code;
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
        public System.Data.DataTable GetDataTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataTypeId, DataTypeName from DataTypeAbbr ";
            clsSpecSQLforSql mySql = clsFuncPara4CodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_DataTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDataTypeId();
            objDDL.DataValueField = conDataTypeAbbr.DataTypeId;
            objDDL.DataTextField = conDataTypeAbbr.DataTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_FuncId4Code()
        {
            clsFunction4CodeBLEx.BindDdl_FuncId4CodeEx(ddlFuncId4Code);
        }
        public void SetDdl_DataTypeId()
        {
            clsDataTypeAbbrBL.BindDdl_DataTypeIdCache(ddlDataTypeId);
        }

        protected void ddlDataTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDataTypeId.SelectedIndex <= 0) return;
            string strDataTypeId = ddlDataTypeId.SelectedValue;
            switch (strDataTypeId)
            {
                case enumDataTypeAbbr.Object_29:
                case enumDataTypeAbbr.ObjectLst_30:
                case enumDataTypeAbbr.Array_31:
                    trParameterType.Visible = true;
                    trParameterTypeFullName.Visible = true;
                    break;
                default:
                    trParameterType.Visible = false;
                    trParameterTypeFullName.Visible = false;

                    break;
            }
        }
    }
}