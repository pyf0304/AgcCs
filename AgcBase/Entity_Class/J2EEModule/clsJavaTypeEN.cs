
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJavaTypeEN
 表名:JavaType(00050137)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:J2EE模块(J2EEModule)
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
 /// 表JavaType的关键字(JavaTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_JavaTypeId_JavaType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strJavaTypeId">表关键字</param>
public K_JavaTypeId_JavaType(string strJavaTypeId)
{
if (IsValid(strJavaTypeId)) Value = strJavaTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strJavaTypeId)
{
if (string.IsNullOrEmpty(strJavaTypeId) == true) return false;
if (strJavaTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_JavaTypeId_JavaType]类型的对象</returns>
public static implicit operator K_JavaTypeId_JavaType(string value)
{
return new K_JavaTypeId_JavaType(value);
}
}
 /// <summary>
 /// Java类型(JavaType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsJavaTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "JavaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "JavaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"JavaTypeId", "JavaTypeName", "Memo"};

protected string mstrJavaTypeId;    //Java类型Id
protected string mstrJavaTypeName;    //Java类型名称
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsJavaTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "JavaType";
 lstKeyFldNames.Add("JavaTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strJavaTypeId">关键字:Java类型Id</param>
public clsJavaTypeEN(string strJavaTypeId)
 {
strJavaTypeId = strJavaTypeId.Replace("'", "''");
if (strJavaTypeId.Length > 2)
{
throw new Exception("在表:JavaType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strJavaTypeId)  ==  true)
{
throw new Exception("在表:JavaType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strJavaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrJavaTypeId = strJavaTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "JavaType";
 lstKeyFldNames.Add("JavaTypeId");
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
if (strAttributeName  ==  conJavaType.JavaTypeId)
{
return mstrJavaTypeId;
}
else if (strAttributeName  ==  conJavaType.JavaTypeName)
{
return mstrJavaTypeName;
}
else if (strAttributeName  ==  conJavaType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conJavaType.JavaTypeId)
{
mstrJavaTypeId = value.ToString();
 AddUpdatedFld(conJavaType.JavaTypeId);
}
else if (strAttributeName  ==  conJavaType.JavaTypeName)
{
mstrJavaTypeName = value.ToString();
 AddUpdatedFld(conJavaType.JavaTypeName);
}
else if (strAttributeName  ==  conJavaType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJavaType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conJavaType.JavaTypeId  ==  AttributeName[intIndex])
{
return mstrJavaTypeId;
}
else if (conJavaType.JavaTypeName  ==  AttributeName[intIndex])
{
return mstrJavaTypeName;
}
else if (conJavaType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conJavaType.JavaTypeId  ==  AttributeName[intIndex])
{
mstrJavaTypeId = value.ToString();
 AddUpdatedFld(conJavaType.JavaTypeId);
}
else if (conJavaType.JavaTypeName  ==  AttributeName[intIndex])
{
mstrJavaTypeName = value.ToString();
 AddUpdatedFld(conJavaType.JavaTypeName);
}
else if (conJavaType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJavaType.Memo);
}
}
}

/// <summary>
/// Java类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaTypeId
{
get
{
return mstrJavaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaTypeId = value;
}
else
{
 mstrJavaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJavaType.JavaTypeId);
}
}
/// <summary>
/// Java类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaTypeName
{
get
{
return mstrJavaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaTypeName = value;
}
else
{
 mstrJavaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conJavaType.JavaTypeName);
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
 AddUpdatedFld(conJavaType.Memo);
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
  return mstrJavaTypeId;
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
  return mstrJavaTypeName;
 }
 }
}
 /// <summary>
 /// Java类型(JavaType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conJavaType
{
public new const string _CurrTabName = "JavaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "JavaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"JavaTypeId", "JavaTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"JavaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaTypeId = "JavaTypeId";    //Java类型Id

 /// <summary>
 /// 常量:"JavaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaTypeName = "JavaTypeName";    //Java类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}