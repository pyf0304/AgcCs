
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserRolesEN
 表名:UserRoles(00050609)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
 /// 表UserRoles的关键字(RoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RoleId_UserRoles
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRoleId">表关键字</param>
public K_RoleId_UserRoles(string strRoleId)
{
if (IsValid(strRoleId)) Value = strRoleId;
else
{
Value = null;
}
}
private static bool IsValid(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return false;
if (strRoleId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RoleId_UserRoles]类型的对象</returns>
public static implicit operator K_RoleId_UserRoles(string value)
{
return new K_RoleId_UserRoles(value);
}
}
 /// <summary>
 /// 用户角色(UserRoles)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserRolesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserRoles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"RoleId", "RoleName", "PrjId", "IsInUse", "Memo"};

protected string mstrRoleId;    //角色ID
protected string mstrRoleName;    //角色名称
protected string mstrPrjId;    //工程Id
protected bool mbolIsInUse;    //IsInUse
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserRolesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strRoleId">关键字:角色ID</param>
public clsUserRolesEN(string strRoleId)
 {
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8)
{
throw new Exception("在表:UserRoles中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("在表:UserRoles中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRoleId = strRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
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
if (strAttributeName  ==  conUserRoles.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conUserRoles.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  conUserRoles.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserRoles.IsInUse)
{
return mbolIsInUse;
}
else if (strAttributeName  ==  conUserRoles.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserRoles.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUserRoles.RoleId);
}
else if (strAttributeName  ==  conUserRoles.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(conUserRoles.RoleName);
}
else if (strAttributeName  ==  conUserRoles.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserRoles.PrjId);
}
else if (strAttributeName  ==  conUserRoles.IsInUse)
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserRoles.IsInUse);
}
else if (strAttributeName  ==  conUserRoles.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserRoles.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserRoles.RoleId  ==  _AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conUserRoles.RoleName  ==  _AttributeName[intIndex])
{
return mstrRoleName;
}
else if (conUserRoles.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserRoles.IsInUse  ==  _AttributeName[intIndex])
{
return mbolIsInUse;
}
else if (conUserRoles.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserRoles.RoleId  ==  _AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUserRoles.RoleId);
}
else if (conUserRoles.RoleName  ==  _AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(conUserRoles.RoleName);
}
else if (conUserRoles.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserRoles.PrjId);
}
else if (conUserRoles.IsInUse  ==  _AttributeName[intIndex])
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserRoles.IsInUse);
}
else if (conUserRoles.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserRoles.Memo);
}
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
 AddUpdatedFld(conUserRoles.RoleId);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserRoles.RoleName);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserRoles.PrjId);
}
}
/// <summary>
/// IsInUse(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsInUse
{
get
{
return mbolIsInUse;
}
set
{
 mbolIsInUse = value;
//记录修改过的字段
 AddUpdatedFld(conUserRoles.IsInUse);
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
 AddUpdatedFld(conUserRoles.Memo);
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
  return mstrRoleId;
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
  return mstrRoleName;
 }
 }
}
 /// <summary>
 /// 用户角色(UserRoles)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserRoles
{
public const string _CurrTabName = "UserRoles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RoleId", "RoleName", "PrjId", "IsInUse", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色ID

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"IsInUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInUse = "IsInUse";    //IsInUse

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}