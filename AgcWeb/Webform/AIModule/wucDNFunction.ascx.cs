
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucDnFunction
 界面名:DnFunction_QUDI(00050300)
 生成代码版本:2020.08.04.1
 生成日期:2020/08/06 11:50:15
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
 ///		wucDnFunction 的摘要说明。
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public partial class wucDnFunction : System.Web.UI.UserControl
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
 /// DN函数Id
 /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string DnFunctionId
{
get
{
return txtDnFunctionId.Text.Trim();
}
set
{
txtDnFunctionId.Text = value.ToString();
}
}

 /// <summary>
 /// DN函数
 /// (AGC.PureClassEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string DnFunctionName
{
get
{
return txtDnFunctionName.Text.Trim();
}
set
{
txtDnFunctionName.Text = value.ToString();
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
if (ddlAssociationMappingId.SelectedValue  ==  "0")
return "";
return ddlAssociationMappingId.SelectedValue;
}
set
{
if (ddlAssociationMappingId.Items.Count>0)
{
if (value  ==  "")
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
txtDnFunctionId.ReadOnly = bolReadonly;
}


/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
/// </summary>	
public void Clear()
{
txtDnFunctionId.Text = "";
txtDnFunctionName.Text = "";
ddlAssociationMappingId.SelectedIndex = 0;
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
txtDnFunctionId.Text = "";
txtDnFunctionName.Text = "";
ddlAssociationMappingId.SelectedIndex = 0;
txtMemo.Text = "";
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
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetAssociationMappingId();
objDDL.DataValueField = conAssociationMapping.AssociationMappingId;
objDDL.DataTextField = conAssociationMapping.AssociationMappingName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


/// <summary>
/// 设置绑定下拉框，针对字段:[AssociationMappingId]
 /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
/// </summary>
public void SetDdl_AssociationMappingId()
{clsAssociationMappingBL.BindDdl_AssociationMappingId(ddlAssociationMappingId);
}

}
}