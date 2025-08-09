
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersEN
 表名:vUsers(00050261)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:50
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
 /// 表vUsers的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_vUsers
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
public K_UserId_vUsers(string strUserId)
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
 /// <returns>返回:[K_UserId_vUsers]类型的对象</returns>
public static implicit operator K_UserId_vUsers(string value)
{
return new K_UserId_vUsers(value);
}
}
 /// <summary>
 /// v用于用户管理(vUsers)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUsersEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUsers"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 28;
public static string[] _AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "DepartmentTypeName", "UpDepartmentName", "UserStateId", "UserStateName", "EffectiveDate", "EffitiveBeginDate", "EffitiveEndDate", "Password", "IdentityID", "IdentityDesc", "Email", "IsGpUser", "RegisterPassword", "IsRegister", "RegisterDate", "IsAudit", "AuditUser", "AuditDate", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户Id
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门ID
protected string mstrDepartmentName;    //部门名称
protected string mstrDepartmentAbbrName;    //部门简称
protected string mstrDepartmentTypeId;    //部门类型Id
protected string mstrUpDepartmentId;    //上级部门Id
protected string mstrDepartmentTypeName;    //部门类型
protected string mstrUpDepartmentName;    //上级部门名
protected string mstrUserStateId;    //用户状态号
protected string mstrUserStateName;    //用户状态名
protected string mstrEffectiveDate;    //有效日期
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected string mstrPassword;    //口令
protected string mstrIdentityID;    //身份编号
protected string mstrIdentityDesc;    //身份描述
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
 public clsvUsersEN()
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
public clsvUsersEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:vUsers中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:vUsers中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convUsers.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUsers.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUsers.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convUsers.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convUsers.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  convUsers.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  convUsers.UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  convUsers.DepartmentTypeName)
{
return mstrDepartmentTypeName;
}
else if (strAttributeName  ==  convUsers.UpDepartmentName)
{
return mstrUpDepartmentName;
}
else if (strAttributeName  ==  convUsers.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convUsers.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convUsers.EffectiveDate)
{
return mstrEffectiveDate;
}
else if (strAttributeName  ==  convUsers.EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  convUsers.EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  convUsers.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  convUsers.IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  convUsers.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convUsers.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  convUsers.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  convUsers.RegisterPassword)
{
return mstrRegisterPassword;
}
else if (strAttributeName  ==  convUsers.IsRegister)
{
return mbolIsRegister;
}
else if (strAttributeName  ==  convUsers.RegisterDate)
{
return mstrRegisterDate;
}
else if (strAttributeName  ==  convUsers.IsAudit)
{
return mbolIsAudit;
}
else if (strAttributeName  ==  convUsers.AuditUser)
{
return mstrAuditUser;
}
else if (strAttributeName  ==  convUsers.AuditDate)
{
return mstrAuditDate;
}
else if (strAttributeName  ==  convUsers.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUsers.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convUsers.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convUsers.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsers.UserId);
}
else if (strAttributeName  ==  convUsers.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsers.UserName);
}
else if (strAttributeName  ==  convUsers.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convUsers.DepartmentId);
}
else if (strAttributeName  ==  convUsers.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convUsers.DepartmentName);
}
else if (strAttributeName  ==  convUsers.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convUsers.DepartmentAbbrName);
}
else if (strAttributeName  ==  convUsers.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convUsers.DepartmentTypeId);
}
else if (strAttributeName  ==  convUsers.UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convUsers.UpDepartmentId);
}
else if (strAttributeName  ==  convUsers.DepartmentTypeName)
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convUsers.DepartmentTypeName);
}
else if (strAttributeName  ==  convUsers.UpDepartmentName)
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convUsers.UpDepartmentName);
}
else if (strAttributeName  ==  convUsers.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUsers.UserStateId);
}
else if (strAttributeName  ==  convUsers.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUsers.UserStateName);
}
else if (strAttributeName  ==  convUsers.EffectiveDate)
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(convUsers.EffectiveDate);
}
else if (strAttributeName  ==  convUsers.EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(convUsers.EffitiveBeginDate);
}
else if (strAttributeName  ==  convUsers.EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(convUsers.EffitiveEndDate);
}
else if (strAttributeName  ==  convUsers.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(convUsers.Password);
}
else if (strAttributeName  ==  convUsers.IdentityID)
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(convUsers.IdentityID);
}
else if (strAttributeName  ==  convUsers.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convUsers.IdentityDesc);
}
else if (strAttributeName  ==  convUsers.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(convUsers.Email);
}
else if (strAttributeName  ==  convUsers.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsGpUser);
}
else if (strAttributeName  ==  convUsers.RegisterPassword)
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(convUsers.RegisterPassword);
}
else if (strAttributeName  ==  convUsers.IsRegister)
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsRegister);
}
else if (strAttributeName  ==  convUsers.RegisterDate)
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(convUsers.RegisterDate);
}
else if (strAttributeName  ==  convUsers.IsAudit)
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsAudit);
}
else if (strAttributeName  ==  convUsers.AuditUser)
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(convUsers.AuditUser);
}
else if (strAttributeName  ==  convUsers.AuditDate)
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(convUsers.AuditDate);
}
else if (strAttributeName  ==  convUsers.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUsers.UpdDate);
}
else if (strAttributeName  ==  convUsers.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUsers.UpdUser);
}
else if (strAttributeName  ==  convUsers.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUsers.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convUsers.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUsers.UserName  ==  _AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUsers.DepartmentId  ==  _AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convUsers.DepartmentName  ==  _AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convUsers.DepartmentAbbrName  ==  _AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (convUsers.DepartmentTypeId  ==  _AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (convUsers.UpDepartmentId  ==  _AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (convUsers.DepartmentTypeName  ==  _AttributeName[intIndex])
{
return mstrDepartmentTypeName;
}
else if (convUsers.UpDepartmentName  ==  _AttributeName[intIndex])
{
return mstrUpDepartmentName;
}
else if (convUsers.UserStateId  ==  _AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convUsers.UserStateName  ==  _AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convUsers.EffectiveDate  ==  _AttributeName[intIndex])
{
return mstrEffectiveDate;
}
else if (convUsers.EffitiveBeginDate  ==  _AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (convUsers.EffitiveEndDate  ==  _AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (convUsers.Password  ==  _AttributeName[intIndex])
{
return mstrPassword;
}
else if (convUsers.IdentityID  ==  _AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (convUsers.IdentityDesc  ==  _AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convUsers.Email  ==  _AttributeName[intIndex])
{
return mstrEmail;
}
else if (convUsers.IsGpUser  ==  _AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (convUsers.RegisterPassword  ==  _AttributeName[intIndex])
{
return mstrRegisterPassword;
}
else if (convUsers.IsRegister  ==  _AttributeName[intIndex])
{
return mbolIsRegister;
}
else if (convUsers.RegisterDate  ==  _AttributeName[intIndex])
{
return mstrRegisterDate;
}
else if (convUsers.IsAudit  ==  _AttributeName[intIndex])
{
return mbolIsAudit;
}
else if (convUsers.AuditUser  ==  _AttributeName[intIndex])
{
return mstrAuditUser;
}
else if (convUsers.AuditDate  ==  _AttributeName[intIndex])
{
return mstrAuditDate;
}
else if (convUsers.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUsers.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convUsers.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convUsers.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsers.UserId);
}
else if (convUsers.UserName  ==  _AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsers.UserName);
}
else if (convUsers.DepartmentId  ==  _AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convUsers.DepartmentId);
}
else if (convUsers.DepartmentName  ==  _AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convUsers.DepartmentName);
}
else if (convUsers.DepartmentAbbrName  ==  _AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(convUsers.DepartmentAbbrName);
}
else if (convUsers.DepartmentTypeId  ==  _AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(convUsers.DepartmentTypeId);
}
else if (convUsers.UpDepartmentId  ==  _AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(convUsers.UpDepartmentId);
}
else if (convUsers.DepartmentTypeName  ==  _AttributeName[intIndex])
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(convUsers.DepartmentTypeName);
}
else if (convUsers.UpDepartmentName  ==  _AttributeName[intIndex])
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(convUsers.UpDepartmentName);
}
else if (convUsers.UserStateId  ==  _AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUsers.UserStateId);
}
else if (convUsers.UserStateName  ==  _AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUsers.UserStateName);
}
else if (convUsers.EffectiveDate  ==  _AttributeName[intIndex])
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(convUsers.EffectiveDate);
}
else if (convUsers.EffitiveBeginDate  ==  _AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(convUsers.EffitiveBeginDate);
}
else if (convUsers.EffitiveEndDate  ==  _AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(convUsers.EffitiveEndDate);
}
else if (convUsers.Password  ==  _AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(convUsers.Password);
}
else if (convUsers.IdentityID  ==  _AttributeName[intIndex])
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(convUsers.IdentityID);
}
else if (convUsers.IdentityDesc  ==  _AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convUsers.IdentityDesc);
}
else if (convUsers.Email  ==  _AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(convUsers.Email);
}
else if (convUsers.IsGpUser  ==  _AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsGpUser);
}
else if (convUsers.RegisterPassword  ==  _AttributeName[intIndex])
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(convUsers.RegisterPassword);
}
else if (convUsers.IsRegister  ==  _AttributeName[intIndex])
{
mbolIsRegister = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsRegister);
}
else if (convUsers.RegisterDate  ==  _AttributeName[intIndex])
{
mstrRegisterDate = value.ToString();
 AddUpdatedFld(convUsers.RegisterDate);
}
else if (convUsers.IsAudit  ==  _AttributeName[intIndex])
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsers.IsAudit);
}
else if (convUsers.AuditUser  ==  _AttributeName[intIndex])
{
mstrAuditUser = value.ToString();
 AddUpdatedFld(convUsers.AuditUser);
}
else if (convUsers.AuditDate  ==  _AttributeName[intIndex])
{
mstrAuditDate = value.ToString();
 AddUpdatedFld(convUsers.AuditDate);
}
else if (convUsers.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUsers.UpdDate);
}
else if (convUsers.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convUsers.UpdUser);
}
else if (convUsers.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUsers.Memo);
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
 AddUpdatedFld(convUsers.UserId);
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
 AddUpdatedFld(convUsers.UserName);
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
 AddUpdatedFld(convUsers.DepartmentId);
}
}
/// <summary>
/// 部门名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.DepartmentName);
}
}
/// <summary>
/// 部门简称(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentAbbrName
{
get
{
return mstrDepartmentAbbrName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentAbbrName = value;
}
else
{
 mstrDepartmentAbbrName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.DepartmentAbbrName);
}
}
/// <summary>
/// 部门类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeId
{
get
{
return mstrDepartmentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeId = value;
}
else
{
 mstrDepartmentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.DepartmentTypeId);
}
}
/// <summary>
/// 上级部门Id(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpDepartmentId
{
get
{
return mstrUpDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpDepartmentId = value;
}
else
{
 mstrUpDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.UpDepartmentId);
}
}
/// <summary>
/// 部门类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeName
{
get
{
return mstrDepartmentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeName = value;
}
else
{
 mstrDepartmentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.DepartmentTypeName);
}
}
/// <summary>
/// 上级部门名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpDepartmentName
{
get
{
return mstrUpDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpDepartmentName = value;
}
else
{
 mstrUpDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.UpDepartmentName);
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
 AddUpdatedFld(convUsers.UserStateId);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.UserStateName);
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
 AddUpdatedFld(convUsers.EffectiveDate);
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
 AddUpdatedFld(convUsers.EffitiveBeginDate);
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
 AddUpdatedFld(convUsers.EffitiveEndDate);
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
 AddUpdatedFld(convUsers.Password);
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
 AddUpdatedFld(convUsers.IdentityID);
}
}
/// <summary>
/// 身份描述(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityDesc
{
get
{
return mstrIdentityDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityDesc = value;
}
else
{
 mstrIdentityDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsers.IdentityDesc);
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
 AddUpdatedFld(convUsers.Email);
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
 AddUpdatedFld(convUsers.IsGpUser);
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
 AddUpdatedFld(convUsers.RegisterPassword);
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
 AddUpdatedFld(convUsers.IsRegister);
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
 AddUpdatedFld(convUsers.RegisterDate);
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
 AddUpdatedFld(convUsers.IsAudit);
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
 AddUpdatedFld(convUsers.AuditUser);
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
 AddUpdatedFld(convUsers.AuditDate);
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
 AddUpdatedFld(convUsers.UpdDate);
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
 AddUpdatedFld(convUsers.UpdUser);
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
 AddUpdatedFld(convUsers.Memo);
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
}
 /// <summary>
 /// v用于用户管理(vUsers)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUsers
{
public const string _CurrTabName = "vUsers"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "DepartmentTypeName", "UpDepartmentName", "UserStateId", "UserStateName", "EffectiveDate", "EffitiveBeginDate", "EffitiveEndDate", "Password", "IdentityID", "IdentityDesc", "Email", "IsGpUser", "RegisterPassword", "IsRegister", "RegisterDate", "IsAudit", "AuditUser", "AuditDate", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentName = "DepartmentName";    //部门名称

 /// <summary>
 /// 常量:"DepartmentAbbrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentAbbrName = "DepartmentAbbrName";    //部门简称

 /// <summary>
 /// 常量:"DepartmentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeId = "DepartmentTypeId";    //部门类型Id

 /// <summary>
 /// 常量:"UpDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpDepartmentId = "UpDepartmentId";    //上级部门Id

 /// <summary>
 /// 常量:"DepartmentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeName = "DepartmentTypeName";    //部门类型

 /// <summary>
 /// 常量:"UpDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpDepartmentName = "UpDepartmentName";    //上级部门名

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态号

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

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
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityDesc = "IdentityDesc";    //身份描述

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