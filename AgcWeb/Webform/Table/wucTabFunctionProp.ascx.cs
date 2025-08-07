
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucTabFunctionProp
界面名:wfmTabFunctionProp_QUDI(00050265)
生成代码版本:2019.11.16.1
生成日期:2019/11/19 12:23:54
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理
模块英文名:PrjFunction
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
    ///		wucTabFunctionProp 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucTabFunctionProp : System.Web.UI.UserControl
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
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabId
        {
            get
            {
                if (ddlTabId.SelectedValue == "0")
                    return "";
                return ddlTabId.SelectedValue;
            }
            set
            {
                if (ddlTabId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTabId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlTabId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 函数模板Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FunctionTemplateId
        {
            get
            {
                if (ddlFunctionTemplateId.SelectedValue == "0")
                    return "";
                return ddlFunctionTemplateId.SelectedValue;
            }
            set
            {
                if (ddlFunctionTemplateId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFunctionTemplateId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFunctionTemplateId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 代码类型Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 函数ID
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FuncId4GC
        {
            get
            {
                if (ddlFuncId4GC.SelectedValue == "0")
                    return "";
                return ddlFuncId4GC.SelectedValue;
            }
            set
            {
                if (ddlFuncId4GC.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncId4GC.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncId4GC.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 函数修饰语Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string MethodModifierId
        {
            get
            {
                if (ddlMethodModifierId.SelectedValue == "0")
                    return "";
                return ddlMethodModifierId.SelectedValue;
            }
            set
            {
                if (ddlMethodModifierId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlMethodModifierId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlMethodModifierId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 是否针对所有模板
        /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public bool IsForAllTemplate
        {
            get
            {
                return chkIsForAllTemplate.Checked;
            }
            set
            {
                chkIsForAllTemplate.Checked = value;
            }
        }

        /// <summary>
        /// 序号
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public int OrderNum
        {
            get
            {
                return int.Parse(txtOrderNum.Text.Trim());
            }
            set
            {
                txtOrderNum.Text = value.ToString();
            }
        }

        /// <summary>
        /// 说明
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
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
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            ddlTabId.SelectedIndex = 0;
            ddlFunctionTemplateId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
            ddlFuncId4GC.SelectedIndex = 0;
            ddlMethodModifierId.SelectedIndex = 0;
            chkIsForAllTemplate.Checked = false;
            txtOrderNum.Text = "0";
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
            ComValid_OrderNum.Validate();
            if (!ComValid_OrderNum.IsValid) return false;
            if (clsString.IsNumeric(txtOrderNum.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
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
            ddlTabId.SelectedIndex = 0;
            ddlFunctionTemplateId.SelectedIndex = 0;
            ddlCodeTypeId.SelectedIndex = 0;
            ddlFuncId4GC.SelectedIndex = 0;
            ddlMethodModifierId.SelectedIndex = 0;
            chkIsForAllTemplate.Checked = false;
            txtOrderNum.Text = "0";
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[PrjTab]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetTabId()
        {
            //获取某学院所有专业信息
            string strSQL = "select TabId, TabName from PrjTab ";
            clsSpecSQLforSql mySql = clsPrjTabBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetTabId();
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[FunctionTemplate]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFunctionTemplateId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FunctionTemplateId, FunctionTemplateName from FunctionTemplate ";
            clsSpecSQLforSql mySql = clsFunctionTemplateBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FunctionTemplateId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFunctionTemplateId();
            objDDL.DataValueField = conFunctionTemplate.FunctionTemplateId;
            objDDL.DataTextField = conFunctionTemplate.FunctionTemplateName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[CodeType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetCodeTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select CodeTypeId, CodeTypeName from CodeType ";
            clsSpecSQLforSql mySql = clsCodeTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// 为下拉框获取数据,从表:[Function4GeneCode]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFuncId4GC()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncId4GC, FuncName from Function4GeneCode ";
            clsSpecSQLforSql mySql = clsFunction4GeneCodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FuncId4GC(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncId4GC();
            objDDL.DataValueField = conFunction4GeneCode.FuncId4GC;
            objDDL.DataTextField = conFunction4GeneCode.FuncName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[MethodModifier]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetMethodModifierId()
        {
            //获取某学院所有专业信息
            string strSQL = "select MethodModifierId, MethodModifierName from MethodModifier ";
            clsSpecSQLforSql mySql = clsMethodModifierBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_MethodModifierId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetMethodModifierId();
            objDDL.DataValueField = conMethodModifier.MethodModifierId;
            objDDL.DataTextField = conMethodModifier.MethodModifierName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, strPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FunctionTemplateId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FunctionTemplateId()
        {
            clsFunctionTemplateBL.BindDdl_FunctionTemplateId(ddlFunctionTemplateId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[CodeTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_CodeTypeId(string strProgLangTypeId)
        {
            clsCodeTypeBL.BindDdl_CodeTypeId(ddlCodeTypeId, strProgLangTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FuncId4GC]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FuncId4GC()
        {
            //clsFunction4GeneCodeBL.BindDdl_FuncId4GC(ddlFuncId4GC);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[MethodModifierId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_MethodModifierId()
        {
            clsMethodModifierBL.BindDdl_MethodModifierId(ddlMethodModifierId);
        }

    }
}