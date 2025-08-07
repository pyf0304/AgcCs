
/*-- -- -- -- -- -- -- -- -- -- --
类名:wucViewRegion
界面名:wfmViewRegion_QUDI(00050304)
生成代码版本:2020.09.24.1
生成日期:2020/10/03 18:21:15
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.ddns.net,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
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
    ///		wucViewRegion 的摘要说明。
    /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
    /// </summary>
    public partial class ViewRegion : System.Web.UI.UserControl
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
        /// 区域Id
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RegionId
        {
            get
            {
                return txtRegionId.Text.Trim();
            }
            set
            {
                txtRegionId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 区域名称
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RegionName
        {
            get
            {
                return txtRegionName.Text.Trim();
            }
            set
            {
                txtRegionName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 应用类型
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public int ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeId.SelectedValue == "0")
                    return 0;
                return int.Parse(ddlApplicationTypeId.SelectedValue);
            }
            set
            {
                if (ddlApplicationTypeId.Items.Count > 0)
                {
                    if (value == 0)
                    {
                        ddlApplicationTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlApplicationTypeId.SelectedValue = value.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 区域类型
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RegionTypeId
        {
            get
            {
                if (ddlRegionTypeId.SelectedValue == "0")
                    return "";
                return ddlRegionTypeId.SelectedValue;
            }
            set
            {
                if (ddlRegionTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlRegionTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRegionTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 区域功能
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string RegionFunction
        {
            get
            {
                return txtRegionFunction.Text.Trim();
            }
            set
            {
                txtRegionFunction.Text = value.ToString();
            }
        }

        /// <summary>
        /// 类名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ClsName
        {
            get
            {
                return txtClassName.Text.Trim();
            }
            set
            {
                txtClassName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 文件名
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string FileName
        {
            get
            {
                return txtFileName.Text.Trim();
            }
            set
            {
                txtFileName.Text = value.ToString();
            }
        }

        /// <summary>
        /// 宽
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public int Width
        {
            get
            {
                return int.Parse(txtWidth.Text.Trim());
            }
            set
            {
                txtWidth.Text = value.ToString();
            }
        }

        /// <summary>
        /// 列数
        /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public int ColNum
        {
            get
            {
                return int.Parse(txtColNum.Text.Trim());
            }
            set
            {
                txtColNum.Text = value.ToString();
            }
        }

        /// <summary>
        /// 容器类型
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string ContainerTypeId
        {
            get
            {
                if (ddlContainerTypeId.SelectedValue == "0")
                    return "";
                return ddlContainerTypeId.SelectedValue;
            }
            set
            {
                if (ddlContainerTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlContainerTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlContainerTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 显示模式
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
        /// </summary>
        public string PageDispModeId
        {
            get
            {
                if (ddlPageDispModeId.SelectedValue == "0")
                    return "";
                return ddlPageDispModeId.SelectedValue;
            }
            set
            {
                if (ddlPageDispModeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPageDispModeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPageDispModeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 输入类型
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
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
        /// 输入表
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
            txtRegionId.ReadOnly = bolReadonly;
        }


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
        /// </summary>	
        public void Clear()
        {
            txtRegionId.Text = "";
            txtRegionName.Text = "";
            ddlApplicationTypeId.SelectedIndex = 0;
            ddlRegionTypeId.SelectedIndex = 0;
            txtRegionFunction.Text = "";
            txtClassName.Text = "";
            txtFileName.Text = "";
            txtWidth.Text = "0";
            txtColNum.Text = "0";
            ddlContainerTypeId.SelectedIndex = 0;
            ddlPageDispModeId.SelectedIndex = 0;
            ddlInOutTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
    
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

            ComValid_Width.Validate();
            if (!ComValid_Width.IsValid) return false;
            ComValid_ColNum.Validate();
            if (!ComValid_ColNum.IsValid) return false;
            if (clsString.IsNumeric(ddlApplicationTypeId.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            if (clsString.IsNumeric(txtWidth.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            if (clsString.IsNumeric(txtColNum.Text) == false)
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
            txtRegionId.Text = "";
            txtRegionName.Text = "";
            ddlApplicationTypeId.SelectedIndex = 0;
            ddlRegionTypeId.SelectedIndex = 0;
            txtRegionFunction.Text = "";
            txtClassName.Text = "";
            txtFileName.Text = "";
            txtWidth.Text = "0";
            txtColNum.Text = "0";
            ddlContainerTypeId.SelectedIndex = 0;
            ddlPageDispModeId.SelectedIndex = 0;
            ddlInOutTypeId.SelectedIndex = 0;
            ddlTabId.SelectedIndex = 0;
     
            txtMemo.Text = "";
        }


        /// <summary>
        /// 为下拉框获取数据,从表:[ApplicationType]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetApplicationTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ApplicationTypeId, ApplicationTypeName from ApplicationType ";
            clsSpecSQLforSql mySql = clsApplicationTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetApplicationTypeId();
            objDDL.DataValueField = conApplicationType.ApplicationTypeId;
            objDDL.DataTextField = conApplicationType.ApplicationTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[RegionType]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetRegionTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select RegionTypeId, RegionTypeName from RegionType ";
            clsSpecSQLforSql mySql = clsRegionTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_RegionTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetRegionTypeId();
            objDDL.DataValueField = conRegionType.RegionTypeId;
            objDDL.DataTextField = conRegionType.RegionTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[GCContainerType]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetContainerTypeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select ContainerTypeId, ContainerTypeName from GCContainerType ";
            clsSpecSQLforSql mySql = clsGCContainerTypeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_ContainerTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetContainerTypeId();
            objDDL.DataValueField = conGCContainerType.ContainerTypeId;
            objDDL.DataTextField = conGCContainerType.ContainerTypeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[PageDispMode]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetPageDispModeId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PageDispModeId, PageDispModeName from PageDispMode ";
            clsSpecSQLforSql mySql = clsPageDispModeBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_PageDispModeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPageDispModeId();
            objDDL.DataValueField = conPageDispMode.PageDispModeId;
            objDDL.DataTextField = conPageDispMode.PageDispModeName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[SQLDSType]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetInSqlDsTypeId()
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
        public void BindDdl_InSqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetInSqlDsTypeId();
            objDDL.DataValueField = conSQLDSType.SqlDsTypeId;
            objDDL.DataTextField = conSQLDSType.SqlDsTypeName;
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
        public System.Data.DataTable GetInRelaTabId()
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
        public void BindDdl_InRelaTabId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetInRelaTabId();
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 为下拉框获取数据,从表:[SQLDSType]中获取
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetOutSqlDsTypeId()
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
        public void BindDdl_OutSqlDsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetOutSqlDsTypeId();
            objDDL.DataValueField = conSQLDSType.SqlDsTypeId;
            objDDL.DataTextField = conSQLDSType.SqlDsTypeName;
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
        public System.Data.DataTable GetOutRelaTabId()
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
        public void BindDdl_OutRelaTabId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetOutRelaTabId();
            objDDL.DataValueField = conPrjTab.TabId;
            objDDL.DataTextField = conPrjTab.TabName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 设置绑定下拉框，针对字段:[ApplicationTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ApplicationTypeId()
        {
            clsApplicationTypeBL.BindDdl_ApplicationTypeId(ddlApplicationTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[RegionTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_RegionTypeId()
        {
            clsRegionTypeBL.BindDdl_RegionTypeId(ddlRegionTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[ContainerTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_ContainerTypeId()
        {
            clsGCContainerTypeBL.BindDdl_ContainerTypeId(ddlContainerTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[PageDispModeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_PageDispModeId()
        {
            clsPageDispModeBL.BindDdl_PageDispModeId(ddlPageDispModeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[InSqlDsTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_InOutTypeId()
        {
            clsInOutTypeBL.BindDdl_InOutTypeId(ddlInOutTypeId);
        }

        /// <summary>
        /// 设置绑定下拉框，针对字段:[InRelaTabId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
        /// </summary>
        public void SetDdl_TabId(string strPrjId)
        {
            clsPrjTabBL.BindDdl_TabId(ddlTabId, strPrjId);
        }

     

    }
}