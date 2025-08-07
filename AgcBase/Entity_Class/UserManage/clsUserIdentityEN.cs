
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserIdentityEN
 表名:UserIdentity(00050307)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表UserIdentity的关键字(IdentityID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdentityID_UserIdentity
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdentityID">表关键字</param>
public K_IdentityID_UserIdentity(string strIdentityID)
{
if (IsValid(strIdentityID)) Value = strIdentityID;
else
{
Value = null;
}
}
private static bool IsValid(string strIdentityID)
{
if (string.IsNullOrEmpty(strIdentityID) == true) return false;
if (strIdentityID.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdentityID_UserIdentity]类型的对象</returns>
public static implicit operator K_IdentityID_UserIdentity(string value)
{
return new K_IdentityID_UserIdentity(value);
}
}
 /// <summary>
 /// 用户权限身份(UserIdentity)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserIdentityEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserIdentity"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdentityID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdentityID", "IdentityDesc", "Memo"};

protected string mstrIdentityID;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserIdentityEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "UserIdentity";
 lstKeyFldNames.Add("IdentityID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdentityID">关键字:身份编号</param>
public clsUserIdentityEN(string strIdentityID)
 {
strIdentityID = strIdentityID.Replace("'", "''");
if (strIdentityID.Length > 2)
{
throw new Exception("在表:UserIdentity中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdentityID)  ==  true)
{
throw new Exception("在表:UserIdentity中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdentityID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdentityID = strIdentityID;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "UserIdentity";
 lstKeyFldNames.Add("IdentityID");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conUserIdentity.IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  conUserIdentity.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  conUserIdentity.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserIdentity.IdentityID)
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(conUserIdentity.IdentityID);
}
else if (strAttributeName  ==  conUserIdentity.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(conUserIdentity.IdentityDesc);
}
else if (strAttributeName  ==  conUserIdentity.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserIdentity.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserIdentity.IdentityID  ==  AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (conUserIdentity.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (conUserIdentity.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserIdentity.IdentityID  ==  AttributeName[intIndex])
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(conUserIdentity.IdentityID);
}
else if (conUserIdentity.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(conUserIdentity.IdentityDesc);
}
else if (conUserIdentity.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserIdentity.Memo);
}
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
 AddUpdatedFld(conUserIdentity.IdentityID);
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
 AddUpdatedFld(conUserIdentity.IdentityDesc);
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
 AddUpdatedFld(conUserIdentity.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrIdentityID;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrIdentityDesc;
 }
 }
}
 /// <summary>
 /// 用户权限身份(UserIdentity)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserIdentity
{
public new const string _CurrTabName = "UserIdentity"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdentityID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdentityID", "IdentityDesc", "Memo"};
//以下是属性变量


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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}