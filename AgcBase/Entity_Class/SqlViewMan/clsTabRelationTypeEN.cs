
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabRelationTypeEN
 表名:TabRelationType(00050087)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
 /// 表TabRelationType的关键字(TabRelationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabRelationTypeId_TabRelationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabRelationTypeId">表关键字</param>
public K_TabRelationTypeId_TabRelationType(string strTabRelationTypeId)
{
if (IsValid(strTabRelationTypeId)) Value = strTabRelationTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabRelationTypeId)
{
if (string.IsNullOrEmpty(strTabRelationTypeId) == true) return false;
if (strTabRelationTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabRelationTypeId_TabRelationType]类型的对象</returns>
public static implicit operator K_TabRelationTypeId_TabRelationType(string value)
{
return new K_TabRelationTypeId_TabRelationType(value);
}
}
 /// <summary>
 /// 表关表类型(TabRelationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabRelationTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabRelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabRelationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TabRelationTypeId", "TabRelationTypeName", "Memo"};

protected string mstrTabRelationTypeId;    //表关系类型Id
protected string mstrTabRelationTypeName;    //表关系类型名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTabRelationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TabRelationType";
 lstKeyFldNames.Add("TabRelationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTabRelationTypeId">关键字:表关系类型Id</param>
public clsTabRelationTypeEN(string strTabRelationTypeId)
 {
strTabRelationTypeId = strTabRelationTypeId.Replace("'", "''");
if (strTabRelationTypeId.Length > 2)
{
throw new Exception("在表:TabRelationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabRelationTypeId)  ==  true)
{
throw new Exception("在表:TabRelationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabRelationTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabRelationTypeId = strTabRelationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "TabRelationType";
 lstKeyFldNames.Add("TabRelationTypeId");
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
if (strAttributeName  ==  conTabRelationType.TabRelationTypeId)
{
return mstrTabRelationTypeId;
}
else if (strAttributeName  ==  conTabRelationType.TabRelationTypeName)
{
return mstrTabRelationTypeName;
}
else if (strAttributeName  ==  conTabRelationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabRelationType.TabRelationTypeId)
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(conTabRelationType.TabRelationTypeId);
}
else if (strAttributeName  ==  conTabRelationType.TabRelationTypeName)
{
mstrTabRelationTypeName = value.ToString();
 AddUpdatedFld(conTabRelationType.TabRelationTypeName);
}
else if (strAttributeName  ==  conTabRelationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabRelationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabRelationType.TabRelationTypeId  ==  AttributeName[intIndex])
{
return mstrTabRelationTypeId;
}
else if (conTabRelationType.TabRelationTypeName  ==  AttributeName[intIndex])
{
return mstrTabRelationTypeName;
}
else if (conTabRelationType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabRelationType.TabRelationTypeId  ==  AttributeName[intIndex])
{
mstrTabRelationTypeId = value.ToString();
 AddUpdatedFld(conTabRelationType.TabRelationTypeId);
}
else if (conTabRelationType.TabRelationTypeName  ==  AttributeName[intIndex])
{
mstrTabRelationTypeName = value.ToString();
 AddUpdatedFld(conTabRelationType.TabRelationTypeName);
}
else if (conTabRelationType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabRelationType.Memo);
}
}
}

/// <summary>
/// 表关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabRelationTypeId
{
get
{
return mstrTabRelationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabRelationTypeId = value;
}
else
{
 mstrTabRelationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelationType.TabRelationTypeId);
}
}
/// <summary>
/// 表关系类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabRelationTypeName
{
get
{
return mstrTabRelationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabRelationTypeName = value;
}
else
{
 mstrTabRelationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabRelationType.TabRelationTypeName);
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
 AddUpdatedFld(conTabRelationType.Memo);
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
  return mstrTabRelationTypeId;
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
  return mstrTabRelationTypeName;
 }
 }
}
 /// <summary>
 /// 表关表类型(TabRelationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabRelationType
{
public new const string _CurrTabName = "TabRelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabRelationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TabRelationTypeId", "TabRelationTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabRelationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationTypeId = "TabRelationTypeId";    //表关系类型Id

 /// <summary>
 /// 常量:"TabRelationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationTypeName = "TabRelationTypeName";    //表关系类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}