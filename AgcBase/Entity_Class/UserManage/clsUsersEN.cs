
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersEN
 表名:Users(00050001)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace AGC.Entity
{
 /// <summary>
 /// 表Users的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_Users
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserId">表关键字</param>
public K_UserId_Users(string strUserId)
{
if (IsValid(strUserId)) Value = strUserId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return false;
if (strUserId.Length > 18) return false;
if (strUserId.IndexOf(' ') >= 0) return false;
if (strUserId.IndexOf(')') >= 0) return false;
if (strUserId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserId_Users]类型的对象</returns>
public static implicit operator K_UserId_Users(string value)
{
return new K_UserId_Users(value);
}
}
 /// <summary>
 /// 用于用户管理(Users)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUsersEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "UserStateId", "RoleId", "qxdj", "EffectiveDate", "EffitiveBeginDate", "EffitiveEndDate", "Password", "IdentityID", "Email", "IsGpUser", "RegisterPassword", "IsRegister", "RegisterDate", "IsAudit", "AuditUser", "AuditDate", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门ID
protected string mstrUserStateId;    //用户状态号
protected string mstrRoleId;    //角色ID
protected int? mintqxdj;    //权限等级
protected string mstrEffectiveDate;    //有效日期
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected string mstrPassword;    //口令
protected string mstrIdentityID;    //身份编号
protected string mstrEmail;    //电子邮箱
protected bool mbolIsGpUser;    //是否平台用户
protected string mstrRegisterPassword;    //注册密码
protected bool mbolIsRegister;    //是否注册
protected string mstrRegisterDate;    //注册日期
protected bool mbolIsAudit;    //是否审核
protected string mstrAuditUser;    //审核人
protected string mstrAuditDate;    //审核日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUsersEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strUserId">关键字:用户Id</param>
public clsUsersEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:Users中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:Users中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserId = strUserId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
 }

public static int AttributeCount
{
get
{
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conUsers.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUsers.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  conUsers.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  conUsers.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  conUsers.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conUsers.qxdj)
{
return mintqxdj;
}
else if (strAttributeName  ==  conUsers.EffectiveDate)
{
return mstrEffectiveDate;
}
else if (strAttributeName  ==  conUsers.EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  conUsers.EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  conUsers.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  conUsers.IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  conUsers.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conUsers.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  conUsers.RegisterPassword)
{
return mstrRegisterPassword;
}
else if (strAttributeName  ==  conUsers.IsRegister)
{
return mbolIsRegister;
}
else if (strAttributeName  ==  conUsers.RegisterDate)
{
return mstrRegisterDate;
}
else if (strAttributeName  ==  conUsers.IsAudit)
{
return mbolIsAudit;
}
else if (strAttributeName  ==  conUsers.AuditUser)
{
return mstrAuditUser;
}
else if (strAttributeName  ==  conUsers.AuditDate)
{
return mstrAuditDate;
}
else if (strAttributeName  ==  conUsers.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUsers.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUsers.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUsers.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUsers.UserId);
}
else if (strAttributeName  ==  conUsers.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(conUsers.UserName);
}
else if (strAttributeName  ==  conUsers.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conUsers.DepartmentId);
}
else if (strAttributeName  ==  conUsers.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conUsers.UserStateId);
}
else if (strAttributeName  ==  conUsers.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUsers.RoleId);
}
else if (strAttributeName  ==  conUsers.qxdj)
{
mintqxdj = TransNullToInt(value.ToString());
 AddUpdatedFld(conUsers.qxdj);
}
else if (strAttributeName  ==  conUsers.EffectiveDate)
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(conUsers.EffectiveDate);
}
else if (strAttributeName  ==  conUsers.EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conUsers.EffitiveBeginDate);
}
else if (strAttributeName  ==  conUsers.EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conUsers.EffitiveEndDate);
}
else if (strAttributeName  ==  conUsers.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(conUsers.Password);
}
else if (strAttributeName  ==  conUsers.IdentityID)
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(conUsers.IdentityID);
}
else if (strAttributeName  ==  conUsers.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conUsers.Email);
}
else if (strAttributeName  ==  conUsers.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsGpUser);
}
else if (strAttributeName  ==  conUsers.RegisterPassword)
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(conUsers.RegisterPassword);
}
else if (strAttributeName  ==  conUsers.IsRegister)
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsRegister);
}
else if (strAttributeName  ==  conUsers.RegisterDate)
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(conUsers.RegisterDate);
}
else if (strAttributeName  ==  conUsers.IsAudit)
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsAudit);
}
else if (strAttributeName  ==  conUsers.AuditUser)
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(conUsers.AuditUser);
}
else if (strAttributeName  ==  conUsers.AuditDate)
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(conUsers.AuditDate);
}
else if (strAttributeName  ==  conUsers.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUsers.UpdDate);
}
else if (strAttributeName  ==  conUsers.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUsers.UpdUser);
}
else if (strAttributeName  ==  conUsers.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUsers.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUsers.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUsers.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (conUsers.DepartmentId  ==  _AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (conUsers.UserStateId  ==  _AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (conUsers.RoleId  ==  _AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conUsers.qxdj  ==  _AttributeName[intIndex])
{
return mintqxdj;
}
else if (conUsers.EffectiveDate  ==  _AttributeName[intIndex])
{
return mstrEffectiveDate;
}
else if (conUsers.EffitiveBeginDate  ==  _AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (conUsers.EffitiveEndDate  ==  _AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (conUsers.Password  ==  _AttributeName[intIndex])
{
return mstrPassword;
}
else if (conUsers.IdentityID  ==  _AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (conUsers.Email  ==  _AttributeName[intIndex])
{
return mstrEmail;
}
else if (conUsers.IsGpUser  ==  _AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (conUsers.RegisterPassword  ==  _AttributeName[intIndex])
{
return mstrRegisterPassword;
}
else if (conUsers.IsRegister  ==  _AttributeName[intIndex])
{
return mbolIsRegister;
}
else if (conUsers.RegisterDate  ==  _AttributeName[intIndex])
{
return mstrRegisterDate;
}
else if (conUsers.IsAudit  ==  _AttributeName[intIndex])
{
return mbolIsAudit;
}
else if (conUsers.AuditUser  ==  _AttributeName[intIndex])
{
return mstrAuditUser;
}
else if (conUsers.AuditDate  ==  _AttributeName[intIndex])
{
return mstrAuditDate;
}
else if (conUsers.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUsers.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUsers.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUsers.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUsers.UserId);
}
else if (conUsers.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(conUsers.UserName);
}
else if (conUsers.DepartmentId  ==  _AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conUsers.DepartmentId);
}
else if (conUsers.UserStateId  ==  _AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(conUsers.UserStateId);
}
else if (conUsers.RoleId  ==  _AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUsers.RoleId);
}
else if (conUsers.qxdj  ==  _AttributeName[intIndex])
{
mintqxdj = TransNullToInt(value.ToString());
 AddUpdatedFld(conUsers.qxdj);
}
else if (conUsers.EffectiveDate  ==  _AttributeName[intIndex])
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(conUsers.EffectiveDate);
}
else if (conUsers.EffitiveBeginDate  ==  _AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conUsers.EffitiveBeginDate);
}
else if (conUsers.EffitiveEndDate  ==  _AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conUsers.EffitiveEndDate);
}
else if (conUsers.Password  ==  _AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(conUsers.Password);
}
else if (conUsers.IdentityID  ==  _AttributeName[intIndex])
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(conUsers.IdentityID);
}
else if (conUsers.Email  ==  _AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conUsers.Email);
}
else if (conUsers.IsGpUser  ==  _AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsGpUser);
}
else if (conUsers.RegisterPassword  ==  _AttributeName[intIndex])
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(conUsers.RegisterPassword);
}
else if (conUsers.IsRegister  ==  _AttributeName[intIndex])
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsRegister);
}
else if (conUsers.RegisterDate  ==  _AttributeName[intIndex])
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(conUsers.RegisterDate);
}
else if (conUsers.IsAudit  ==  _AttributeName[intIndex])
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(conUsers.IsAudit);
}
else if (conUsers.AuditUser  ==  _AttributeName[intIndex])
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(conUsers.AuditUser);
}
else if (conUsers.AuditDate  ==  _AttributeName[intIndex])
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(conUsers.AuditDate);
}
else if (conUsers.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUsers.UpdDate);
}
else if (conUsers.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUsers.UpdUser);
}
else if (conUsers.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUsers.Memo);
}
}
}

/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.UserName);
}
}
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.DepartmentId);
}
}
/// <summary>
/// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.UserStateId);
}
}
/// <summary>
/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.RoleId);
}
}
/// <summary>
/// 权限等级(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? qxdj
{
get
{
return mintqxdj;
}
set
{
 mintqxdj = value;
//记录修改过的字段
 AddUpdatedFld(conUsers.qxdj);
}
}
/// <summary>
/// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffectiveDate
{
get
{
return mstrEffectiveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffectiveDate = value;
}
else
{
 mstrEffectiveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.EffectiveDate);
}
}
/// <summary>
/// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffitiveBeginDate
{
get
{
return mstrEffitiveBeginDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffitiveBeginDate = value;
}
else
{
 mstrEffitiveBeginDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.EffitiveBeginDate);
}
}
/// <summary>
/// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffitiveEndDate
{
get
{
return mstrEffitiveEndDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffitiveEndDate = value;
}
else
{
 mstrEffitiveEndDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.EffitiveEndDate);
}
}
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Password
{
get
{
return mstrPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPassword = value;
}
else
{
 mstrPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.Password);
}
}
/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityID
{
get
{
return mstrIdentityID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityID = value;
}
else
{
 mstrIdentityID = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.IdentityID);
}
}
/// <summary>
/// 电子邮箱(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Email
{
get
{
return mstrEmail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.Email);
}
}
/// <summary>
/// 是否平台用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGpUser
{
get
{
return mbolIsGpUser;
}
set
{
 mbolIsGpUser = value;
//记录修改过的字段
 AddUpdatedFld(conUsers.IsGpUser);
}
}
/// <summary>
/// 注册密码(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegisterPassword
{
get
{
return mstrRegisterPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegisterPassword = value;
}
else
{
 mstrRegisterPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.RegisterPassword);
}
}
/// <summary>
/// 是否注册(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRegister
{
get
{
return mbolIsRegister;
}
set
{
 mbolIsRegister = value;
//记录修改过的字段
 AddUpdatedFld(conUsers.IsRegister);
}
}
/// <summary>
/// 注册日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegisterDate
{
get
{
return mstrRegisterDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegisterDate = value;
}
else
{
 mstrRegisterDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.RegisterDate);
}
}
/// <summary>
/// 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAudit
{
get
{
return mbolIsAudit;
}
set
{
 mbolIsAudit = value;
//记录修改过的字段
 AddUpdatedFld(conUsers.IsAudit);
}
}
/// <summary>
/// 审核人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AuditUser
{
get
{
return mstrAuditUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuditUser = value;
}
else
{
 mstrAuditUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.AuditUser);
}
}
/// <summary>
/// 审核日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AuditDate
{
get
{
return mstrAuditDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuditDate = value;
}
else
{
 mstrAuditDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.AuditDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.UpdUser);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conUsers.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrUserId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrUserName;
 }
 }
}
 /// <summary>
 /// 用于用户管理(Users)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUsers
{
public const string _CurrTabName = "Users"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "UserStateId", "RoleId", "qxdj", "EffectiveDate", "EffitiveBeginDate", "EffitiveEndDate", "Password", "IdentityID", "Email", "IsGpUser", "RegisterPassword", "IsRegister", "RegisterDate", "IsAudit", "AuditUser", "AuditDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门ID

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态号

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色ID

 /// <summary>
 /// 常量:"qxdj"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string qxdj = "qxdj";    //权限等级

 /// <summary>
 /// 常量:"EffectiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffectiveDate = "EffectiveDate";    //有效日期

 /// <summary>
 /// 常量:"EffitiveBeginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffitiveBeginDate = "EffitiveBeginDate";    //有效开始日期

 /// <summary>
 /// 常量:"EffitiveEndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffitiveEndDate = "EffitiveEndDate";    //有效结束日期

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //口令

 /// <summary>
 /// 常量:"IdentityID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityID = "IdentityID";    //身份编号

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //电子邮箱

 /// <summary>
 /// 常量:"IsGpUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGpUser = "IsGpUser";    //是否平台用户

 /// <summary>
 /// 常量:"RegisterPassword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegisterPassword = "RegisterPassword";    //注册密码

 /// <summary>
 /// 常量:"IsRegister"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRegister = "IsRegister";    //是否注册

 /// <summary>
 /// 常量:"RegisterDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegisterDate = "RegisterDate";    //注册日期

 /// <summary>
 /// 常量:"IsAudit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAudit = "IsAudit";    //是否审核

 /// <summary>
 /// 常量:"AuditUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AuditUser = "AuditUser";    //审核人

 /// <summary>
 /// 常量:"AuditDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AuditDate = "AuditDate";    //审核日期

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}