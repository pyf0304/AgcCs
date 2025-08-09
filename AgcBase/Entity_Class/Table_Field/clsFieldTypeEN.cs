
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTypeEN
 表名:FieldType(00050173)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:29
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
 /// 表FieldType的关键字(FieldTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FieldTypeId_FieldType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFieldTypeId">表关键字</param>
public K_FieldTypeId_FieldType(string strFieldTypeId)
{
if (IsValid(strFieldTypeId)) Value = strFieldTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFieldTypeId)
{
if (string.IsNullOrEmpty(strFieldTypeId) == true) return false;
if (strFieldTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FieldTypeId_FieldType]类型的对象</returns>
public static implicit operator K_FieldTypeId_FieldType(string value)
{
return new K_FieldTypeId_FieldType(value);
}
}
 /// <summary>
 /// 字段类型(FieldType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFieldTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FieldType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FieldTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"FieldTypeId", "FieldTypeName", "FieldTypeENName", "OrderNum", "Memo"};

protected string mstrFieldTypeId;    //字段类型Id
protected string mstrFieldTypeName;    //字段类型名
protected string mstrFieldTypeENName;    //字段类型英文名
protected int? mintOrderNum;    //序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFieldTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FieldTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFieldTypeId">关键字:字段类型Id</param>
public clsFieldTypeEN(string strFieldTypeId)
 {
strFieldTypeId = strFieldTypeId.Replace("'", "''");
if (strFieldTypeId.Length > 2)
{
throw new Exception("在表:FieldType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFieldTypeId)  ==  true)
{
throw new Exception("在表:FieldType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFieldTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFieldTypeId = strFieldTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FieldTypeId");
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
if (strAttributeName  ==  conFieldType.FieldTypeId)
{
return mstrFieldTypeId;
}
else if (strAttributeName  ==  conFieldType.FieldTypeName)
{
return mstrFieldTypeName;
}
else if (strAttributeName  ==  conFieldType.FieldTypeENName)
{
return mstrFieldTypeENName;
}
else if (strAttributeName  ==  conFieldType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conFieldType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFieldType.FieldTypeId)
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conFieldType.FieldTypeId);
}
else if (strAttributeName  ==  conFieldType.FieldTypeName)
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(conFieldType.FieldTypeName);
}
else if (strAttributeName  ==  conFieldType.FieldTypeENName)
{
mstrFieldTypeENName = value.ToString();
 AddUpdatedFld(conFieldType.FieldTypeENName);
}
else if (strAttributeName  ==  conFieldType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldType.OrderNum);
}
else if (strAttributeName  ==  conFieldType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFieldType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFieldType.FieldTypeId  ==  _AttributeName[intIndex])
{
return mstrFieldTypeId;
}
else if (conFieldType.FieldTypeName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeName;
}
else if (conFieldType.FieldTypeENName  ==  _AttributeName[intIndex])
{
return mstrFieldTypeENName;
}
else if (conFieldType.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conFieldType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFieldType.FieldTypeId  ==  _AttributeName[intIndex])
{
mstrFieldTypeId = value.ToString();
 AddUpdatedFld(conFieldType.FieldTypeId);
}
else if (conFieldType.FieldTypeName  ==  _AttributeName[intIndex])
{
mstrFieldTypeName = value.ToString();
 AddUpdatedFld(conFieldType.FieldTypeName);
}
else if (conFieldType.FieldTypeENName  ==  _AttributeName[intIndex])
{
mstrFieldTypeENName = value.ToString();
 AddUpdatedFld(conFieldType.FieldTypeENName);
}
else if (conFieldType.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFieldType.OrderNum);
}
else if (conFieldType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFieldType.Memo);
}
}
}

/// <summary>
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeId
{
get
{
return mstrFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeId = value;
}
else
{
 mstrFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldType.FieldTypeId);
}
}
/// <summary>
/// 字段类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeName
{
get
{
return mstrFieldTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeName = value;
}
else
{
 mstrFieldTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldType.FieldTypeName);
}
}
/// <summary>
/// 字段类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldTypeENName
{
get
{
return mstrFieldTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldTypeENName = value;
}
else
{
 mstrFieldTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFieldType.FieldTypeENName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conFieldType.OrderNum);
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
 AddUpdatedFld(conFieldType.Memo);
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
  return mstrFieldTypeId;
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
  return mstrFieldTypeName;
 }
 }
}
 /// <summary>
 /// 字段类型(FieldType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFieldType
{
public const string _CurrTabName = "FieldType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FieldTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FieldTypeId", "FieldTypeName", "FieldTypeENName", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeId = "FieldTypeId";    //字段类型Id

 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeName = "FieldTypeName";    //字段类型名

 /// <summary>
 /// 常量:"FieldTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldTypeENName = "FieldTypeENName";    //字段类型英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}