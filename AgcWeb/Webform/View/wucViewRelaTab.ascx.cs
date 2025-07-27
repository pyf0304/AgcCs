
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucViewRelaTab
界面名:wfmViewRelaTab_QUDI(00050232)
生成代码版本:2019.06.20.1
生成日期:2019/06/21 00:27:43
生成者:
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:界面管理
模块英文名:PrjInterface
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
    using AGC.BusinessLogic;using AGC.FunClass;
    using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucViewRelaTab 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class wucViewRelaTab : System.Web.UI.UserControl
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
        /// 界面Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ViewId
        {
            get
            {
                if (ddlViewId.SelectedValue == "0")
                    return "";
                return ddlViewId.SelectedValue;
            }
            set
            {
                if (ddlViewId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlViewId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlViewId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 区域Id
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RegionId
        {
            get
            {
                if (ddlRegionId.SelectedValue == "0")
                    return "";
                return ddlRegionId.SelectedValue.ToString();
            }
            set
            {
                if (ddlRegionId.Items.Count > 0)
                {
                    if (string.IsNullOrEmpty( value ) == true)
                    {
                        ddlRegionId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRegionId.SelectedValue = value.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// INOUT类型ID
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string InOutTypeId
        {
            get
            {
                if (ddlInOutTypeId.SelectedValue == "0")
                    return "";
                return ddlInOutTypeId.SelectedValue;
            }
            set
            {
                if (ddlInOutTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlInOutTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlInOutTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 界面表类型码
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ViewTabTypeId
        {
            get
            {
                if (ddlViewTabTypeId.SelectedValue == "0")
                    return "";
                return ddlViewTabTypeId.SelectedValue;
            }
            set
            {
                if (ddlViewTabTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlViewTabTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlViewTabTypeId.SelectedValue = value;
                    }
                }
            }
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
        /// 表功能说明
        /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string TabFunction
        {
            get
            {
                return txtTabFunction.Text.Trim();
            }
            set
            {
                txtTabFunction.Text = value.ToString();
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
            ddlViewId.SelectedIndex = 0;
            ddlRegionId.SelectedIndex = 0;
            ddlInOutTypeId.SelectedIndex = 0;
            ddlViewTabTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtTabFunction.Text = "";
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
            ComValid_RegionId.Validate();
            if (!ComValid_RegionId.IsValid) return false;
            if (clsString.IsNumeric(ddlRegionId.Text) == false)
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
            ddlViewId.SelectedIndex = 0;
            ddlRegionId.SelectedIndex = 0;
            ddlInOutTypeId.SelectedIndex = 0;
            ddlViewTabTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
            txtTabFunction.Text = "";
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[ViewInfo]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetViewId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewId, ViewName from ViewInfo ";
            clsSpecSQLforSql mySql = clsViewInfoBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetViewId();
            objDDL.DataValueField = conViewInfo.ViewId;
            objDDL.DataTextField = conViewInfo.ViewName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[ViewRegion]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetRegionId()
        {
            //获取某学院所有专业信息
            string strSQL = "select RegionId, RegionName from ViewRegion ";
            clsSpecSQLforSql mySql = clsViewRegionBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_RegionId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetRegionId();
            objDDL.DataValueField = conViewRegion.RegionId;
            objDDL.DataTextField = conViewRegion.RegionName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[InOutType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetInOutTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select InOutTypeId, InOutTypeName from InOutType ";
            clsSpecSQLforSql mySql = clsInOutTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_InOutTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetInOutTypeId();
            objDDL.DataValueField = conInOutType.InOutTypeId;
            objDDL.DataTextField = conInOutType.InOutTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[ViewTabType]中获取
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetViewTabTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ViewTabTypeId, ViewTabTypeName from ViewTabType ";
            clsSpecSQLforSql mySql = clsViewTabTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ViewTabTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetViewTabTypeId();
            objDDL.DataValueField = conViewTabType.ViewTabTypeId;
            objDDL.DataTextField = conViewTabType.ViewTabTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
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
        /// 设置绑定下拉框，针对字段:[ViewId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ViewId(string strPrjId, string strCmPrjId)
        {
            clsViewInfoBL.BindDdl_ViewId(ddlViewId, strPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[RegionId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_RegionId(string strViewId)
        {
            clsViewRegionBLEx.BindDdl_RegionIdExCache(ddlRegionId, strViewId, clsPubVar.CurrSelPrjId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[InOutTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_InOutTypeId()
        {
            clsInOutTypeBL.BindDdl_InOutTypeIdCache(ddlInOutTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[ViewTabTypeId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ViewTabTypeId()
        {
            clsViewTabTypeBL.BindDdl_ViewTabTypeId(ddlViewTabTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[TabId]
        /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabId(string strPrjId)
        {
            clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabId, strPrjId);
        }
        public void HideTrViewId()
        {
            trViewId.Visible = false;
        }
    }
}