
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucUsers
 界面名:wfmUsers_QUDI(00050114)
 生成代码版本:2019.11.08.1
 生成日期:2019/11/08 16:26:24
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理
 模块英文名:UserManage
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
 ///		wucUsers 的摘要说明。
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public partial class wucUsers : System.Web.UI.UserControl
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
 /// 用户ID
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string UserId
{
get
{
return txtUserId.Text.Trim();
}
set
{
txtUserId.Text = value.ToString();
}
}

 /// <summary>
 /// 用户名
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string UserName
{
get
{
return txtUserName.Text.Trim();
}
set
{
txtUserName.Text = value.ToString();
}
}

 /// <summary>
 /// 用户状态号
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string UserStateId
{
get
{
return txtUserStateId.Text.Trim();
}
set
{
txtUserStateId.Text = value.ToString();
}
}

 /// <summary>
 /// 部门ID
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string DepartmentId
{
get
{
if (ddlDepartmentId.SelectedValue  ==  "0")
return "";
return ddlDepartmentId.SelectedValue;
}
set
{
if (ddlDepartmentId.Items.Count>0)
{
if (value  ==  "")
{
ddlDepartmentId.SelectedValue = "0";
}
else
{
ddlDepartmentId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 权限等级
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public int qxdj
{
get
{
return int.Parse(txtqxdj.Text.Trim());
}
set
{
txtqxdj.Text = value.ToString();
}
}

 /// <summary>
 /// EffectiveDate
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string EffectiveDate
{
get
{
return txtEffectiveDate.Text.Trim();
}
set
{
txtEffectiveDate.Text = value.ToString();
}
}

 /// <summary>
 /// EffitiveBeginDate
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string EffitiveBeginDate
{
get
{
return txtEffitiveBeginDate.Text.Trim();
}
set
{
txtEffitiveBeginDate.Text = value.ToString();
}
}

 /// <summary>
 /// EffitiveEndDate
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string EffitiveEndDate
{
get
{
return txtEffitiveEndDate.Text.Trim();
}
set
{
txtEffitiveEndDate.Text = value.ToString();
}
}

 /// <summary>
 /// 口令
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string Password
{
get
{
return txtPassword.Text.Trim();
}
set
{
txtPassword.Text = value.ToString();
}
}

 /// <summary>
 /// 角色ID
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string RoleId
{
get
{
return txtRoleId.Text.Trim();
}
set
{
txtRoleId.Text = value.ToString();
}
}

 /// <summary>
 /// 身份编号
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string IdentityID
{
get
{
if (ddlIdentityID.SelectedValue  ==  "0")
return "";
return ddlIdentityID.SelectedValue;
}
set
{
if (ddlIdentityID.Items.Count>0)
{
if (value  ==  "")
{
ddlIdentityID.SelectedValue = "0";
}
else
{
ddlIdentityID.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 电子邮箱
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string Email
{
get
{
return txtEmail.Text.Trim();
}
set
{
txtEmail.Text = value.ToString();
}
}

 /// <summary>
 /// 是否平台用户
 /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public bool IsGpUser
{
get
{
return chkIsGpUser.Checked;
}
set
{
chkIsGpUser.Checked = value;
}
}

 /// <summary>
 /// 注册密码
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string RegisterPassword
{
get
{
return txtRegisterPassword.Text.Trim();
}
set
{
txtRegisterPassword.Text = value.ToString();
}
}

 /// <summary>
 /// 是否注册
 /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public bool IsRegister
{
get
{
return chkIsRegister.Checked;
}
set
{
chkIsRegister.Checked = value;
}
}

 /// <summary>
 /// 注册日期
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string RegisterDate
{
get
{
return txtRegisterDate.Text.Trim();
}
set
{
txtRegisterDate.Text = value.ToString();
}
}

 /// <summary>
 /// 是否审核
 /// (AGC.BusinessLogicEx.clsASPCheckBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public bool IsAudit
{
get
{
return chkIsAudit.Checked;
}
set
{
chkIsAudit.Checked = value;
}
}

 /// <summary>
 /// 审核人
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string AuditUser
{
get
{
return txtAuditUser.Text.Trim();
}
set
{
txtAuditUser.Text = value.ToString();
}
}

 /// <summary>
 /// 审核日期
 /// (AGC.BusinessLogicEx.clsASPTextBoxBLEx_Static:GC_DefFldProperty)
 /// </summary>
public string AuditDate
{
get
{
return txtAuditDate.Text.Trim();
}
set
{
txtAuditDate.Text = value.ToString();
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
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_SetKeyReadOnly)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public void SetKeyReadOnly(bool bolReadonly)
{
txtUserId.ReadOnly = bolReadonly;
}


/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WebCtlControlCode4CSharp:Gen_Wuc_CS_Clear)
/// </summary>	
public void Clear()
{
txtUserId.Text = "";
txtUserName.Text = "";
txtUserStateId.Text = "";
ddlDepartmentId.SelectedIndex = 0;
txtqxdj.Text = "0";
txtEffectiveDate.Text = "";
txtEffitiveBeginDate.Text = "";
txtEffitiveEndDate.Text = "";
txtPassword.Text = "";
txtRoleId.Text = "";
ddlIdentityID.SelectedIndex = 0;
txtEmail.Text = "";
chkIsGpUser.Checked = false;
txtRegisterPassword.Text = "";
chkIsRegister.Checked = false;
txtRegisterDate.Text = "";
chkIsAudit.Checked = false;
txtAuditUser.Text = "";
txtAuditDate.Text = "";
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
ComValid_qxdj.Validate();
if (!ComValid_qxdj.IsValid) return false;
if (clsString.IsNumeric(txtqxdj.Text)  ==  false)
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
txtUserId.Text = "";
txtUserName.Text = "";
txtUserStateId.Text = "";
ddlDepartmentId.SelectedIndex = 0;
txtqxdj.Text = "0";
txtEffectiveDate.Text = "";
txtEffitiveBeginDate.Text = "";
txtEffitiveEndDate.Text = "";
txtPassword.Text = "";
txtRoleId.Text = "";
ddlIdentityID.SelectedIndex = 0;
txtEmail.Text = "";
chkIsGpUser.Checked = false;
txtRegisterPassword.Text = "";
chkIsRegister.Checked = false;
txtRegisterDate.Text = "";
chkIsAudit.Checked = false;
txtAuditUser.Text = "";
txtAuditDate.Text = "";
txtMemo.Text = "";
}


/// <summary>
/// 为下拉框获取数据,从表:[DepartmentInfo]中获取
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetDepartmentId()
{
//获取某学院所有专业信息
string strSQL = "select DepartmentId, DepartmentName from DepartmentInfo ";
 clsSpecSQLforSql mySql = clsDepartmentInfoBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetDepartmentId();
objDDL.DataValueField = conDepartmentInfo.DepartmentId;
objDDL.DataTextField = conDepartmentInfo.DepartmentName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

/// <summary>
/// 为下拉框获取数据,从表:[UserIdentity]中获取
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetIdentityID()
{
//获取某学院所有专业信息
string strSQL = "select IdentityID, IdentityDesc from UserIdentity ";
 clsSpecSQLforSql mySql = clsUserIdentityBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_BindDdlFunc)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_IdentityID(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetIdentityID();
objDDL.DataValueField = conUserIdentity.IdentityID;
objDDL.DataTextField = conUserIdentity.IdentityDesc;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


/// <summary>
/// 设置绑定下拉框，针对字段:[DepartmentId]
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
/// </summary>
public void SetDdl_DepartmentId()
{clsDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentId);
}

/// <summary>
/// 设置绑定下拉框，针对字段:[IdentityID]
 /// (AGC.BusinessLogicEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl)
/// </summary>
public void SetDdl_IdentityID()
{clsUserIdentityBL.BindDdlIdentityID(ddlIdentityID);
}

}
}