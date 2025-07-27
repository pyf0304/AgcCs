
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucQryRegionFldsB
 表名:QryRegionFlds
 生成代码版本:2018.05.02.1
 生成日期:2018/05/03 15:45:05
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理
 模块英文名:RegionManage
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
    using CommonTable.Entity;
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using AGC.BusinessLogicEx;


    /// <summary>
    ///		wucQryRegionFldsB 的摘要说明。
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucQryRegionFldsB : System.Web.UI.UserControl
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
 /// 区域Id
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public long RegionId
{
get
{
return long.Parse(txtRegionId.Text.Trim());
}
set
{
txtRegionId.Text = value.ToString();
}
}

 /// <summary>
 /// 表字段ID
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public long TabFldId
{
get
{
return long.Parse(txtTabFldId.Text.Trim());
}
set
{
txtTabFldId.Text = value.ToString();
}
}

 /// <summary>
 /// 控件类型号
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string CtlTypeId
{
get
{
if (ddlCtlTypeId.SelectedValue  ==  "0")
return "";
return ddlCtlTypeId.SelectedValue;
}
set
{
if (ddlCtlTypeId.Items.Count>0)
{
if (value  ==  "")
{
ddlCtlTypeId.SelectedValue = "0";
}
else
{
ddlCtlTypeId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 数据源表ID
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string DS_TabId
{
get
{
if (ddlDS_TabId.SelectedValue  ==  "0")
return "";
return ddlDS_TabId.SelectedValue;
}
set
{
if (ddlDS_TabId.Items.Count>0)
{
if (value  ==  "")
{
ddlDS_TabId.SelectedValue = "0";
}
else
{
ddlDS_TabId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 查询方式Id
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string QueryOptionId
{
get
{
if (ddlQueryOptionId.SelectedValue  ==  "0")
return "";
return ddlQueryOptionId.SelectedValue;
}
set
{
if (ddlQueryOptionId.Items.Count>0)
{
if (value  ==  "")
{
ddlQueryOptionId.SelectedValue = "0";
}
else
{
ddlQueryOptionId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 下拉框列表选项ID
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string DDLItemsOptionId
{
get
{
if (ddlDDLItemsOptionId.SelectedValue  ==  "0")
return "";
return ddlDDLItemsOptionId.SelectedValue;
}
set
{
if (ddlDDLItemsOptionId.Items.Count>0)
{
if (value  ==  "")
{
ddlDDLItemsOptionId.SelectedValue = "0";
}
else
{
ddlDDLItemsOptionId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 数据源SQL串
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string DS_SQLStr
{
get
{
return txtDS_SQLStr.Text.Trim();
}
set
{
txtDS_SQLStr.Text = value.ToString();
}
}

 /// <summary>
 /// 数据源文本字段Id
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string DS_DataTextFieldId
{
get
{
if (ddlDS_DataTextFieldId.SelectedValue  ==  "0")
return "";
return ddlDS_DataTextFieldId.SelectedValue;
}
set
{
if (ddlDS_DataTextFieldId.Items.Count>0)
{
if (value  ==  "")
{
ddlDS_DataTextFieldId.SelectedValue = "0";
}
else
{
ddlDS_DataTextFieldId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 数据源值字段Id
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string DS_DataValueFieldId
{
get
{
if (ddlDS_DataValueFieldId.SelectedValue  ==  "0")
return "";
return ddlDS_DataValueFieldId.SelectedValue;
}
set
{
if (ddlDS_DataValueFieldId.Items.Count>0)
{
if (value  ==  "")
{
ddlDS_DataValueFieldId.SelectedValue = "0";
}
else
{
ddlDS_DataValueFieldId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 列表项串
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string ItemsString
{
get
{
return txtItemsString.Text.Trim();
}
set
{
txtItemsString.Text = value.ToString();
}
}

 /// <summary>
 /// 数据源条件串
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public string DS_CondStr
{
get
{
return txtDS_CondStr.Text.Trim();
}
set
{
txtDS_CondStr.Text = value.ToString();
}
}

 /// <summary>
 /// 字段序号
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public int SeqNum
{
get
{
return int.Parse(txtSeqNum.Text.Trim());
}
set
{
txtSeqNum.Text = value.ToString();
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
if (ddlUserId.SelectedValue  ==  "0")
return "";
return ddlUserId.SelectedValue;
}
set
{
if (ddlUserId.Items.Count>0)
{
if (value  ==  "")
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
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
/// </summary>	
public void Clear()
{
txtRegionId.Text = "0";
txtTabFldId.Text = "0";
ddlCtlTypeId.SelectedIndex = 0;
ddlDS_TabId.SelectedIndex = 0;
ddlQueryOptionId.SelectedIndex = 0;
ddlDDLItemsOptionId.SelectedIndex = 0;
txtDS_SQLStr.Text = "";
ddlDS_DataTextFieldId.SelectedIndex = 0;
ddlDS_DataValueFieldId.SelectedIndex = 0;
txtItemsString.Text = "";
txtDS_CondStr.Text = "";
txtSeqNum.Text = "0";
ddlUserId.SelectedIndex = 0;
txtMemo.Text = "";
txtUpdDate.Text = "";
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
ComValid_RegionId.Validate();
if (!ComValid_RegionId.IsValid) return false;
ComValid_TabFldId.Validate();
if (!ComValid_TabFldId.IsValid) return false;
ComValid_SeqNum.Validate();
if (!ComValid_SeqNum.IsValid) return false;
if (clsString.IsNumeric(txtRegionId.Text)  ==  false)
{
strResult = "请输入正确的整型!";
return false;
}
if (clsString.IsNumeric(txtTabFldId.Text)  ==  false)
{
strResult = "请输入正确的整型!";
return false;
}
if (clsString.IsNumeric(txtSeqNum.Text)  ==  false)
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
 /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
 /// </summary>
public void SetDefaultValue()
{
txtRegionId.Text = "0";
txtTabFldId.Text = "0";
ddlCtlTypeId.SelectedIndex = 0;
ddlDS_TabId.SelectedIndex = 0;
ddlQueryOptionId.SelectedIndex = 0;
ddlDDLItemsOptionId.SelectedIndex = 0;
txtDS_SQLStr.Text = "";
ddlDS_DataTextFieldId.SelectedIndex = 0;
ddlDS_DataValueFieldId.SelectedIndex = 0;
txtItemsString.Text = "";
txtDS_CondStr.Text = "";
txtSeqNum.Text = "0";
ddlUserId.SelectedIndex = 0;
txtMemo.Text = "";
txtUpdDate.Text = "";
}
/// <summary>
/// 为下拉框获取数据,从表:[CtlTypeAbbr]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetCtlTypeId()
{
//获取某学院所有专业信息
string strSQL = "select CtlTypeId, CtlTypeName from CtlTypeAbbr ";
 clsSpecSQLforSql mySql = clsQryRegionFldsBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_CtlTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetCtlTypeId();
objDDL.DataValueField = clsCtlTypeAbbrEN.con_CtlTypeId;
objDDL.DataTextField = clsCtlTypeAbbrEN.con_CtlTypeName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[PrjTab]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetDS_TabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from PrjTab ";
 clsSpecSQLforSql mySql = clsQryRegionFldsBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_DS_TabId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetDS_TabId();
objDDL.DataValueField = clsPrjTabEN.con_TabId;
objDDL.DataTextField = clsPrjTabEN.con_TabName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[QueryOption]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetQueryOptionId()
{
//获取某学院所有专业信息
string strSQL = "select QueryOptionId, QueryOptionName from QueryOption ";
 clsSpecSQLforSql mySql = clsQryRegionFldsBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_QueryOptionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetQueryOptionId();
objDDL.DataValueField = clsQueryOptionEN.con_QueryOptionId;
objDDL.DataTextField = clsQueryOptionEN.con_QueryOptionName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[DDLItemsOption]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetDDLItemsOptionId()
{
//获取某学院所有专业信息
string strSQL = "select DDLItemsOptionId, DDLItemsOptionName from DDLItemsOption ";
 clsSpecSQLforSql mySql = clsQryRegionFldsBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_DDLItemsOptionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetDDLItemsOptionId();
objDDL.DataValueField = clsDDLItemsOptionEN.con_DDLItemsOptionId;
objDDL.DataTextField = clsDDLItemsOptionEN.con_DDLItemsOptionName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[FieldTab]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetDS_DataTextFieldId()
{
//获取某学院所有专业信息
string strSQL = "select FldId, FldName from FieldTab ";
 clsSpecSQLforSql mySql = clsQryRegionFldsBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_DS_DataTextFieldId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetDS_DataTextFieldId();
objDDL.DataValueField = clsFieldTabEN.con_FldId;
objDDL.DataTextField = clsFieldTabEN.con_FldName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[FieldTab]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetDS_DataValueFieldId()
{
//获取某学院所有专业信息
string strSQL = "select FldId, FldName from FieldTab ";
 clsSpecSQLforSql mySql = clsQryRegionFldsBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_DS_DataValueFieldId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetDS_DataValueFieldId();
objDDL.DataValueField = clsFieldTabEN.con_FldId;
objDDL.DataTextField = clsFieldTabEN.con_FldName;
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
 clsSpecSQLforSql mySql = clsQryRegionFldsBL.GetSpecSQLObj();
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
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetUserId();
objDDL.DataValueField = clsUsersEN.con_UserId;
objDDL.DataTextField = clsUsersEN.con_UserName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
public void SetDdl_CtlTypeId()
{
clsCtlTypeAbbrBL.BindDdl_CtlTypeId_Cache(ddlCtlTypeId);
}
public void SetDdl_DS_TabId(string strPrjId)
{
clsPrjTabBLEx.BindDdl_TabIdByPrjIdEx(ddlDS_TabId, strPrjId);
}
public void SetDdl_QueryOptionId()
{
clsQueryOptionBL.BindDdl_QueryOptionId_Cache(ddlQueryOptionId);
}
public void SetDdl_DDLItemsOptionId()
{
clsDDLItemsOptionBL.BindDdl_DDLItemsOptionId_Cache(ddlDDLItemsOptionId);
}
public void SetDdl_DS_DataTextFieldId(string strPrjId)
{
clsFieldTabBLEx.BindDdl_FldIDEx(ddlDS_DataTextFieldId, strPrjId);
}
public void SetDdl_DS_DataValueFieldId(string strPrjId)
{
clsFieldTabBLEx.BindDdl_FldIDEx(ddlDS_DataValueFieldId, strPrjId);
}
public void SetDdl_UserId()
{
clsUsersBL.BindDdl_UserId(ddlUserId);
}
}
}