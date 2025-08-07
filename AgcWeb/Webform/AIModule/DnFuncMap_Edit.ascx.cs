
/*-- -- -- -- -- -- -- -- -- -- --
类名:DnFuncMap_Edit
界面名:wfmDnFuncMap_QUDI(00050297)
生成代码版本:2020.07.21.1
生成日期:2020/07/22 17:11:12
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
    ///		DnFuncMap_Edit 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class DnFuncMap_Edit : System.Web.UI.UserControl
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
        /// In数据结点
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string InDataNodeId
        {
            get
            {
                if (ddlInDataNodeId.SelectedValue == "0")
                    return "";
                return ddlInDataNodeId.SelectedValue;
            }
            set
            {
                if (ddlInDataNodeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlInDataNodeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlInDataNodeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// Out数据结点
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string OutDataNodeId
        {
            get
            {
                if (ddlOutDataNodeId.SelectedValue == "0")
                    return "";
                return ddlOutDataNodeId.SelectedValue;
            }
            set
            {
                if (ddlOutDataNodeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlOutDataNodeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlOutDataNodeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 关系映射
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string AssociationMappingId
        {
            get
            {
                if (ddlAssociationMappingId.SelectedValue == "0")
                    return "";
                return ddlAssociationMappingId.SelectedValue;
            }
            set
            {
                if (ddlAssociationMappingId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlAssociationMappingId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlAssociationMappingId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 映射模式
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FuncMapModeId
        {
            get
            {
                if (ddlFuncMapModeId.SelectedValue == "0")
                    return "";
                return ddlFuncMapModeId.SelectedValue;
            }
            set
            {
                if (ddlFuncMapModeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncMapModeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncMapModeId.SelectedValue = value;
                    }
                }
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
        /// DN函数
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string DnFunctionId
        {
            get
            {
                if (ddlDnFunctionId.SelectedValue == "0")
                    return "";
                return ddlDnFunctionId.SelectedValue;
            }
            set
            {
                if (ddlDnFunctionId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDnFunctionId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDnFunctionId.SelectedValue = value;
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
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            ddlInDataNodeId.SelectedIndex = 0;
            ddlOutDataNodeId.SelectedIndex = 0;
            ddlAssociationMappingId.SelectedIndex = 0;
            ddlFuncMapModeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            ddlDnFunctionId.SelectedIndex = 0;
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
            ddlInDataNodeId.SelectedIndex = 0;
            ddlOutDataNodeId.SelectedIndex = 0;
            ddlAssociationMappingId.SelectedIndex = 0;
            ddlFuncMapModeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            ddlDnFunctionId.SelectedIndex = 0;
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[DataNode]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetInDataNodeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataNodeId, DataNodeName from DataNode ";
            clsSpecSQLforSql mySql = clsDataNodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_InDataNodeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetInDataNodeId();
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[DataNode]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetOutDataNodeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DataNodeId, DataNodeName from DataNode ";
            clsSpecSQLforSql mySql = clsDataNodeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_OutDataNodeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetOutDataNodeId();
            objDDL.DataValueField = conDataNode.DataNodeId;
            objDDL.DataTextField = conDataNode.DataNodeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[AssociationMapping]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetAssociationMappingId()
        {
            //获取某学院所有专业信息
            string strSQL = "select AssociationMappingId, AssociationMappingName from AssociationMapping ";
            clsSpecSQLforSql mySql = clsAssociationMappingBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_AssociationMappingId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetAssociationMappingId();
            objDDL.DataValueField = conAssociationMapping.AssociationMappingId;
            objDDL.DataTextField = conAssociationMapping.AssociationMappingName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[FuncMapMode]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetFuncMapModeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select FuncMapModeId, FuncMapModeName from FuncMapMode ";
            clsSpecSQLforSql mySql = clsFuncMapModeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_FuncMapModeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFuncMapModeId();
            objDDL.DataValueField = conFuncMapMode.FuncMapModeId;
            objDDL.DataTextField = conFuncMapMode.FuncMapModeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
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
        /// 为下拉框获取数据,从表:[DnFunction]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetDnFunctionId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DnFunctionId, DnFunctionName from DnFunction ";
            clsSpecSQLforSql mySql = clsDnFunctionBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_DnFunctionId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDnFunctionId();
            objDDL.DataValueField = conDnFunction.DnFunctionId;
            objDDL.DataTextField = conDnFunction.DnFunctionName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[InDataNodeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_InDataNodeId(string strCmPrjId)
        {
            clsDataNodeBLEx.BindDdl_DataNodeIdByPrjId(ddlInDataNodeId, strCmPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[OutDataNodeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_OutDataNodeId(string strCmPrjId)
        {
            clsDataNodeBLEx.BindDdl_DataNodeIdByPrjId(ddlOutDataNodeId, strCmPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[AssociationMappingId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_AssociationMappingId()
        {
            clsAssociationMappingBL.BindDdl_AssociationMappingId(ddlAssociationMappingId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[FuncMapModeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_FuncMapModeId()
        {
            clsFuncMapModeBL.BindDdl_FuncMapModeId(ddlFuncMapModeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabId(string strCmPrjId, string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdByCmPrjIdExCacheNoPureClass(ddlTabId, strPrjId, strCmPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[DnFunctionId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_DnFunctionId(string strPrjId)
        {
            clsDnFunctionBL.BindDdl_DnFunctionId(ddlDnFunctionId, strPrjId);
        }

    }
}