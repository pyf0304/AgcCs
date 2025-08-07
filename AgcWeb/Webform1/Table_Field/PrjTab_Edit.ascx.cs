
/*-- -- -- -- -- -- -- -- -- -- --
类名:PrjTab_Edit
界面名:PrjTab_QUDI(00050057)
生成代码版本:2020.08.03.1
生成日期:2020/08/04 05:40:52
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:Web用户控件后台(WebCtlControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//生成与表相关的控件控制层代码
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    using CommFunc4WebForm;
    using AGC.Entity;
    using AGC.BusinessLogic;
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		PrjTab_Edit 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class PrjTab_Edit : System.Web.UI.UserControl
    {

        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Page_Load)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }


        /// <summary>
        /// 表ID
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// 表中文名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// 数据源类型
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 表状态ID
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabStateId
        {
            get
            {
                if (ddlTabStateId.SelectedValue == "0")
                    return "";
                return ddlTabStateId.SelectedValue;
            }
            set
            {
                if (ddlTabStateId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabStateId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabStateId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 表名_后备
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabNameB
        {
            get
            {
                return txtTabNameB.Text.Trim();
            }
            set
            {
                txtTabNameB.Text = value.ToString();
            }
        }

        /// <summary>
        /// 功能模块
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FuncModuleAgcId
        {
            get
            {
                if (ddlFuncModuleAgcId.SelectedValue == "0")
                    return "";
                return ddlFuncModuleAgcId.SelectedValue;
            }
            set
            {
                if (ddlFuncModuleAgcId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncModuleAgcId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncModuleAgcId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 数据库名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string DataBaseName
        {
            get
            {
                return txtDataBaseName.Text.Trim();
            }
            set
            {
                txtDataBaseName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 拥有者
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string Owner
        {
            get
            {
                return txtOwner.Text.Trim();
            }
            set
            {
                txtOwner.Text = value.ToString();
            }
        }

        /// <summary>
        /// 说明
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtTabId.ReadOnly = bolReadonly;
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            txtTabId.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            ddlSqlDsTypeId.SelectedIndex = 0;
            ddlTabStateId.SelectedIndex = 0;
            txtTabNameB.Text = "";
            ddlFuncModuleAgcId.SelectedIndex = 0;
            txtDataBaseName.Text = "";
            txtOwner.Text = "";
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_IsValid)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetDefaultValue)
        /// </summary>
        public void SetDefaultValue()
        {
            txtTabId.Text = "";
            txtTabName.Text = "";
            txtTabCnName.Text = "";
            ddlSqlDsTypeId.SelectedIndex = 0;
            ddlTabStateId.SelectedIndex = 0;
            txtTabNameB.Text = "";
            ddlFuncModuleAgcId.SelectedIndex = 0;
            txtDataBaseName.Text = "";
            txtOwner.Text = "";
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[SQLDSType]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetSqlDsTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select SqlDsTypeId, SqlDsTypeName from SQLDSType ";
            clsSpecSQLforSql mySql = clsSQLDSTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_SqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetSqlDsTypeId();
            objDDL.DataValueField = conSQLDSType.SqlDsTypeId;
            objDDL.DataTextField = conSQLDSType.SqlDsTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[TabState]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetTabStateId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabStateId, TabStateName from TabState ";
            clsSpecSQLforSql mySql = clsTabStateBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_TabStateId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTabStateId();
            objDDL.DataValueField = conTabState.TabStateId;
            objDDL.DataTextField = conTabState.TabStateName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[FuncModule_Agc]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFuncModuleAgcId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
            clsSpecSQLforSql mySql = clsFuncModule_AgcBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FuncModuleAgcId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncModuleAgcId();
            objDDL.DataValueField = conFuncModule_Agc.FuncModuleAgcId;
            objDDL.DataTextField = conFuncModule_Agc.FuncModuleName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[SqlDsTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_SqlDsTypeId()
        {
            clsSQLDSTypeBL.BindDdl_SqlDsTypeId(ddlSqlDsTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabStateId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabStateId()
        {
            clsTabStateBL.BindDdl_TabStateId(ddlTabStateId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FuncModuleAgcId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FuncModuleAgcId(string strPrjId)
        {
            clsFuncModule_AgcBL.BindDdl_FuncModuleAgcId(ddlFuncModuleAgcId, strPrjId);
        }

    }
}