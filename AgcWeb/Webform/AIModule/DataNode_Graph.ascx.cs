
/*-- -- -- -- -- -- -- -- -- -- --
类名:DataNode_Graph
界面名:DataNode_QUDI(00050298)
生成代码版本:2020.07.21.1
生成日期:2020/07/23 02:06:30
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:AI模块
模块英文名:AIModule
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
    ///		DataNode_Graph 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class DataNode_Graph : System.Web.UI.UserControl
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
        /// 数据结点Id
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string DataNodeId
        {
            get
            {
                return txtDataNodeId.Text.Trim();
            }
            set
            {
                txtDataNodeId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 表
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 字段
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FldId
        {
            get
            {
                if (ddlFldId.SelectedValue == "0")
                    return "";
                return ddlFldId.SelectedValue;
            }
            set
            {
                if (ddlFldId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFldId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFldId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 结点名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string DataNodeName
        {
            get
            {
                return txtDataNodeName.Text.Trim();
            }
            set
            {
                txtDataNodeName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 结点类型
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string DataNodeTypeId
        {
            get
            {
                if (ddlDataNodeTypeId.SelectedValue == "0")
                    return "";
                return ddlDataNodeTypeId.SelectedValue;
            }
            set
            {
                if (ddlDataNodeTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDataNodeTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDataNodeTypeId.SelectedValue = value;
                    }
                }
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
            txtDataNodeId.ReadOnly = bolReadonly;
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            txtDataNodeId.Text = "";
            ddlTabId.SelectedIndex = 0;
            ddlFldId.SelectedIndex = 0;
            txtDataNodeName.Text = "";
            ddlDataNodeTypeId.SelectedIndex = 0;
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
            txtDataNodeId.Text = "";
            ddlTabId.SelectedIndex = 0;
            ddlFldId.SelectedIndex = 0;
            txtDataNodeName.Text = "";
            ddlDataNodeTypeId.SelectedIndex = 0;
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[PrjTab]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
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
        /// 为下拉框获取数据,从表:[FieldTab]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFldId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FldId, FldName from FieldTab ";
            clsSpecSQLforSql mySql = clsFieldTabBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FldId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFldId();
            objDDL.DataValueField = conFieldTab.FldId;
            objDDL.DataTextField = conFieldTab.FldName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[DataNodeType]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetDataNodeTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataNodeTypeId, DataNodeTypeName from DataNodeType ";
            clsSpecSQLforSql mySql = clsDataNodeTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_DataNodeTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDataNodeTypeId();
            objDDL.DataValueField = conDataNodeType.DataNodeTypeId;
            objDDL.DataTextField = conDataNodeType.DataNodeTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCacheNoPureClass(ddlTabId, strPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FldId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FldId(string strPrjId)
        {
            clsFieldTabBL.BindDdl_FldId(ddlFldId, strPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[DataNodeTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_DataNodeTypeId()
        {
            clsDataNodeTypeBL.BindDdl_DataNodeTypeId(ddlDataNodeTypeId);
        }

    }
}