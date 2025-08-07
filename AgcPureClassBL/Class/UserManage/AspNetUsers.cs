
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:AspNetUsers
 表名:AspNetUsers(00050420)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:58
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.PureClass
{
 /// <summary>
 /// AspNetUsers(AspNetUsers)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class AspNetUsers 
{
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"Id", "AccessFailedCount", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEndDateUtc", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName"};
//以下是属性变量

/// <summary>
/// Id(说明:;字段类型:nvarchar;字段长度:256;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string Id
{
get
{
return mstrId;
}
set
{
if (value  ==  "")
{
 mstrId = value;
}
else
{
 mstrId = value;
}
}
}
/// <summary>
/// AccessFailedCount(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public int AccessFailedCount
{
get
{
return mintAccessFailedCount;
}
set
{
 mintAccessFailedCount = value;
}
}
/// <summary>
/// Email(说明:;字段类型:nvarchar;字段长度:512;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
}
}
/// <summary>
/// EmailConfirmed(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool EmailConfirmed
{
get
{
return mbolEmailConfirmed;
}
set
{
 mbolEmailConfirmed = value;
}
}
/// <summary>
/// LockoutEnabled(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool LockoutEnabled
{
get
{
return mbolLockoutEnabled;
}
set
{
 mbolLockoutEnabled = value;
}
}
/// <summary>
/// LockoutEndDateUtc(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public DateTime LockoutEndDateUtc
{
get
{
return mdteLockoutEndDateUtc;
}
set
{
 mdteLockoutEndDateUtc = value;
}
}
/// <summary>
/// PasswordHash(说明:;字段类型:ntext;字段长度:2147483646;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string PasswordHash
{
get
{
return mstrPasswordHash;
}
set
{
if (value  ==  "")
{
 mstrPasswordHash = value;
}
else
{
 mstrPasswordHash = value;
}
}
}
/// <summary>
/// PhoneNumber(说明:;字段类型:ntext;字段长度:2147483646;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string PhoneNumber
{
get
{
return mstrPhoneNumber;
}
set
{
if (value  ==  "")
{
 mstrPhoneNumber = value;
}
else
{
 mstrPhoneNumber = value;
}
}
}
/// <summary>
/// PhoneNumberConfirmed(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool PhoneNumberConfirmed
{
get
{
return mbolPhoneNumberConfirmed;
}
set
{
 mbolPhoneNumberConfirmed = value;
}
}
/// <summary>
/// SecurityStamp(说明:;字段类型:ntext;字段长度:2147483646;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string SecurityStamp
{
get
{
return mstrSecurityStamp;
}
set
{
if (value  ==  "")
{
 mstrSecurityStamp = value;
}
else
{
 mstrSecurityStamp = value;
}
}
}
/// <summary>
/// TwoFactorEnabled(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public bool TwoFactorEnabled
{
get
{
return mbolTwoFactorEnabled;
}
set
{
 mbolTwoFactorEnabled = value;
}
}
/// <summary>
/// UserId(说明:;字段类型:nvarchar;字段长度:256;是否可空:True)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
}
}
/// <summary>
/// UserName(说明:;字段类型:nvarchar;字段长度:512;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
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
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
}
}

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
/// <summary>
/// 类索引器(Indexer)函数,字符串参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_Id)
{
return mstrId;
}
else if (strAttributeName  ==  con_AccessFailedCount)
{
return mintAccessFailedCount;
}
else if (strAttributeName  ==  con_Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  con_EmailConfirmed)
{
return mbolEmailConfirmed;
}
else if (strAttributeName  ==  con_LockoutEnabled)
{
return mbolLockoutEnabled;
}
else if (strAttributeName  ==  con_LockoutEndDateUtc)
{
return mdteLockoutEndDateUtc;
}
else if (strAttributeName  ==  con_PasswordHash)
{
return mstrPasswordHash;
}
else if (strAttributeName  ==  con_PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  con_PhoneNumberConfirmed)
{
return mbolPhoneNumberConfirmed;
}
else if (strAttributeName  ==  con_SecurityStamp)
{
return mstrSecurityStamp;
}
else if (strAttributeName  ==  con_TwoFactorEnabled)
{
return mbolTwoFactorEnabled;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  con_Id)
{
mstrId = value.ToString();
}
else if (strAttributeName  ==  con_AccessFailedCount)
{
mintAccessFailedCount = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (strAttributeName  ==  con_Email)
{
mstrEmail = value.ToString();
}
else if (strAttributeName  ==  con_EmailConfirmed)
{
mbolEmailConfirmed = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_LockoutEnabled)
{
mbolLockoutEnabled = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_LockoutEndDateUtc)
{
mdteLockoutEndDateUtc = clsEntityBase2.TransNullToDate_S(value.ToString());
}
else if (strAttributeName  ==  con_PasswordHash)
{
mstrPasswordHash = value.ToString();
}
else if (strAttributeName  ==  con_PhoneNumber)
{
mstrPhoneNumber = value.ToString();
}
else if (strAttributeName  ==  con_PhoneNumberConfirmed)
{
mbolPhoneNumberConfirmed = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_SecurityStamp)
{
mstrSecurityStamp = value.ToString();
}
else if (strAttributeName  ==  con_TwoFactorEnabled)
{
mbolTwoFactorEnabled = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
}
else if (strAttributeName  ==  con_UserName)
{
mstrUserName = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[int intIndex]
{
get
{
if (con_Id  ==  AttributeName[intIndex])
{
return mstrId;
}
else if (con_AccessFailedCount  ==  AttributeName[intIndex])
{
return mintAccessFailedCount;
}
else if (con_Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (con_EmailConfirmed  ==  AttributeName[intIndex])
{
return mbolEmailConfirmed;
}
else if (con_LockoutEnabled  ==  AttributeName[intIndex])
{
return mbolLockoutEnabled;
}
else if (con_LockoutEndDateUtc  ==  AttributeName[intIndex])
{
return mdteLockoutEndDateUtc;
}
else if (con_PasswordHash  ==  AttributeName[intIndex])
{
return mstrPasswordHash;
}
else if (con_PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (con_PhoneNumberConfirmed  ==  AttributeName[intIndex])
{
return mbolPhoneNumberConfirmed;
}
else if (con_SecurityStamp  ==  AttributeName[intIndex])
{
return mstrSecurityStamp;
}
else if (con_TwoFactorEnabled  ==  AttributeName[intIndex])
{
return mbolTwoFactorEnabled;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (con_Id  ==  AttributeName[intIndex])
{
mstrId = value.ToString();
}
else if (con_AccessFailedCount  ==  AttributeName[intIndex])
{
mintAccessFailedCount = clsEntityBase2.TransNullToInt_S(value.ToString());
}
else if (con_Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
}
else if (con_EmailConfirmed  ==  AttributeName[intIndex])
{
mbolEmailConfirmed = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_LockoutEnabled  ==  AttributeName[intIndex])
{
mbolLockoutEnabled = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_LockoutEndDateUtc  ==  AttributeName[intIndex])
{
mdteLockoutEndDateUtc = clsEntityBase2.TransNullToDate_S(value.ToString());
}
else if (con_PasswordHash  ==  AttributeName[intIndex])
{
mstrPasswordHash = value.ToString();
}
else if (con_PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
}
else if (con_PhoneNumberConfirmed  ==  AttributeName[intIndex])
{
mbolPhoneNumberConfirmed = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_SecurityStamp  ==  AttributeName[intIndex])
{
mstrSecurityStamp = value.ToString();
}
else if (con_TwoFactorEnabled  ==  AttributeName[intIndex])
{
mbolTwoFactorEnabled = clsEntityBase2.TransNullToBool_S(value.ToString());
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
}
else if (con_UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public AspNetUsers()
 {
 }


 /// <summary>
 /// 常量:"Id"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Id = "Id";    //Id

 /// <summary>
 /// 常量:"AccessFailedCount"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AccessFailedCount = "AccessFailedCount";    //AccessFailedCount

 /// <summary>
 /// 常量:"Email"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Email = "Email";    //Email

 /// <summary>
 /// 常量:"EmailConfirmed"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EmailConfirmed = "EmailConfirmed";    //EmailConfirmed

 /// <summary>
 /// 常量:"LockoutEnabled"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LockoutEnabled = "LockoutEnabled";    //LockoutEnabled

 /// <summary>
 /// 常量:"LockoutEndDateUtc"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LockoutEndDateUtc = "LockoutEndDateUtc";    //LockoutEndDateUtc

 /// <summary>
 /// 常量:"PasswordHash"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PasswordHash = "PasswordHash";    //PasswordHash

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PhoneNumber = "PhoneNumber";    //PhoneNumber

 /// <summary>
 /// 常量:"PhoneNumberConfirmed"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PhoneNumberConfirmed = "PhoneNumberConfirmed";    //PhoneNumberConfirmed

 /// <summary>
 /// 常量:"SecurityStamp"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SecurityStamp = "SecurityStamp";    //SecurityStamp

 /// <summary>
 /// 常量:"TwoFactorEnabled"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TwoFactorEnabled = "TwoFactorEnabled";    //TwoFactorEnabled

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //UserId

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserName = "UserName";    //UserName

protected string mstrId;    //Id
protected int mintAccessFailedCount;    //AccessFailedCount
protected string mstrEmail;    //Email
protected bool mbolEmailConfirmed;    //EmailConfirmed
protected bool mbolLockoutEnabled;    //LockoutEnabled
protected DateTime mdteLockoutEndDateUtc;    //LockoutEndDateUtc
protected string mstrPasswordHash;    //PasswordHash
protected string mstrPhoneNumber;    //PhoneNumber
protected bool mbolPhoneNumberConfirmed;    //PhoneNumberConfirmed
protected string mstrSecurityStamp;    //SecurityStamp
protected bool mbolTwoFactorEnabled;    //TwoFactorEnabled
protected string mstrUserId;    //UserId
protected string mstrUserName;    //UserName
}
}