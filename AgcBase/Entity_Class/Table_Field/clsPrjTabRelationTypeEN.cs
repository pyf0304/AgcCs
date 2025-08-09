
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabRelationTypeEN
 表名:PrjTabRelationType(00050607)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表PrjTabRelationType的关键字(PrjTabRelaTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjTabRelaTypeId_PrjTabRelationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjTabRelaTypeId">表关键字</param>
public K_PrjTabRelaTypeId_PrjTabRelationType(string strPrjTabRelaTypeId)
{
if (IsValid(strPrjTabRelaTypeId)) Value = strPrjTabRelaTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjTabRelaTypeId)
{
if (string.IsNullOrEmpty(strPrjTabRelaTypeId) == true) return false;
if (strPrjTabRelaTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjTabRelaTypeId_PrjTabRelationType]类型的对象</returns>
public static implicit operator K_PrjTabRelaTypeId_PrjTabRelationType(string value)
{
return new K_PrjTabRelaTypeId_PrjTabRelationType(value);
}
}
 /// <summary>
 /// 工程表关系类型(PrjTabRelationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjTabRelationTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjTabRelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjTabRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"PrjTabRelaTypeId", "TabRelationTypeName", "TabRelationTypeENName", "Memo"};

protected string mstrPrjTabRelaTypeId;    //表关系类型Id
protected string mstrTabRelationTypeName;    //表关系类型名
protected string mstrTabRelationTypeENName;    //表关系类型英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjTabRelationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjTabRelaTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjTabRelaTypeId">关键字:表关系类型Id</param>
public clsPrjTabRelationTypeEN(string strPrjTabRelaTypeId)
 {
strPrjTabRelaTypeId = strPrjTabRelaTypeId.Replace("'", "''");
if (strPrjTabRelaTypeId.Length > 2)
{
throw new Exception("在表:PrjTabRelationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjTabRelaTypeId)  ==  true)
{
throw new Exception("在表:PrjTabRelationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjTabRelaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjTabRelaTypeId = strPrjTabRelaTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjTabRelaTypeId");
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
if (strAttributeName  ==  conPrjTabRelationType.PrjTabRelaTypeId)
{
return mstrPrjTabRelaTypeId;
}
else if (strAttributeName  ==  conPrjTabRelationType.TabRelationTypeName)
{
return mstrTabRelationTypeName;
}
else if (strAttributeName  ==  conPrjTabRelationType.TabRelationTypeENName)
{
return mstrTabRelationTypeENName;
}
else if (strAttributeName  ==  conPrjTabRelationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjTabRelationType.PrjTabRelaTypeId)
{
mstrPrjTabRelaTypeId = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.PrjTabRelaTypeId);
}
else if (strAttributeName  ==  conPrjTabRelationType.TabRelationTypeName)
{
mstrTabRelationTypeName = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.TabRelationTypeName);
}
else if (strAttributeName  ==  conPrjTabRelationType.TabRelationTypeENName)
{
mstrTabRelationTypeENName = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.TabRelationTypeENName);
}
else if (strAttributeName  ==  conPrjTabRelationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjTabRelationType.PrjTabRelaTypeId  ==  _AttributeName[intIndex])
{
return mstrPrjTabRelaTypeId;
}
else if (conPrjTabRelationType.TabRelationTypeName  ==  _AttributeName[intIndex])
{
return mstrTabRelationTypeName;
}
else if (conPrjTabRelationType.TabRelationTypeENName  ==  _AttributeName[intIndex])
{
return mstrTabRelationTypeENName;
}
else if (conPrjTabRelationType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjTabRelationType.PrjTabRelaTypeId  ==  _AttributeName[intIndex])
{
mstrPrjTabRelaTypeId = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.PrjTabRelaTypeId);
}
else if (conPrjTabRelationType.TabRelationTypeName  ==  _AttributeName[intIndex])
{
mstrTabRelationTypeName = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.TabRelationTypeName);
}
else if (conPrjTabRelationType.TabRelationTypeENName  ==  _AttributeName[intIndex])
{
mstrTabRelationTypeENName = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.TabRelationTypeENName);
}
else if (conPrjTabRelationType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTabRelationType.Memo);
}
}
}

/// <summary>
/// 表关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjTabRelaTypeId
{
get
{
return mstrPrjTabRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjTabRelaTypeId = value;
}
else
{
 mstrPrjTabRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelationType.PrjTabRelaTypeId);
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
 AddUpdatedFld(conPrjTabRelationType.TabRelationTypeName);
}
}
/// <summary>
/// 表关系类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabRelationTypeENName
{
get
{
return mstrTabRelationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabRelationTypeENName = value;
}
else
{
 mstrTabRelationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTabRelationType.TabRelationTypeENName);
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
 AddUpdatedFld(conPrjTabRelationType.Memo);
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
  return mstrPrjTabRelaTypeId;
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
  return mstrTabRelationTypeName;
 }
 }
}
 /// <summary>
 /// 工程表关系类型(PrjTabRelationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjTabRelationType
{
public const string _CurrTabName = "PrjTabRelationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjTabRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"PrjTabRelaTypeId", "TabRelationTypeName", "TabRelationTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjTabRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjTabRelaTypeId = "PrjTabRelaTypeId";    //表关系类型Id

 /// <summary>
 /// 常量:"TabRelationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationTypeName = "TabRelationTypeName";    //表关系类型名

 /// <summary>
 /// 常量:"TabRelationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRelationTypeENName = "TabRelationTypeENName";    //表关系类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}