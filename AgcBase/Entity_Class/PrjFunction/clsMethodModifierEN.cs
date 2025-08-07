
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMethodModifierEN
 表名:MethodModifier(00050523)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表MethodModifier的关键字(MethodModifierId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MethodModifierId_MethodModifier
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMethodModifierId">表关键字</param>
public K_MethodModifierId_MethodModifier(string strMethodModifierId)
{
if (IsValid(strMethodModifierId)) Value = strMethodModifierId;
else
{
Value = null;
}
}
private static bool IsValid(string strMethodModifierId)
{
if (string.IsNullOrEmpty(strMethodModifierId) == true) return false;
if (strMethodModifierId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MethodModifierId_MethodModifier]类型的对象</returns>
public static implicit operator K_MethodModifierId_MethodModifier(string value)
{
return new K_MethodModifierId_MethodModifier(value);
}
}
 /// <summary>
 /// 函数修饰语(MethodModifier)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMethodModifierEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MethodModifier"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MethodModifierId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"MethodModifierId", "MethodModifierName", "OrderNum", "Memo"};

protected string mstrMethodModifierId;    //函数修饰语Id
protected string mstrMethodModifierName;    //函数修饰语名称
protected int mintOrderNum;    //序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsMethodModifierEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MethodModifierId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strMethodModifierId">关键字:函数修饰语Id</param>
public clsMethodModifierEN(string strMethodModifierId)
 {
strMethodModifierId = strMethodModifierId.Replace("'", "''");
if (strMethodModifierId.Length > 2)
{
throw new Exception("在表:MethodModifier中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMethodModifierId)  ==  true)
{
throw new Exception("在表:MethodModifier中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMethodModifierId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMethodModifierId = strMethodModifierId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MethodModifierId");
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
if (strAttributeName  ==  conMethodModifier.MethodModifierId)
{
return mstrMethodModifierId;
}
else if (strAttributeName  ==  conMethodModifier.MethodModifierName)
{
return mstrMethodModifierName;
}
else if (strAttributeName  ==  conMethodModifier.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conMethodModifier.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMethodModifier.MethodModifierId)
{
mstrMethodModifierId = value.ToString();
 AddUpdatedFld(conMethodModifier.MethodModifierId);
}
else if (strAttributeName  ==  conMethodModifier.MethodModifierName)
{
mstrMethodModifierName = value.ToString();
 AddUpdatedFld(conMethodModifier.MethodModifierName);
}
else if (strAttributeName  ==  conMethodModifier.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conMethodModifier.OrderNum);
}
else if (strAttributeName  ==  conMethodModifier.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMethodModifier.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMethodModifier.MethodModifierId  ==  _AttributeName[intIndex])
{
return mstrMethodModifierId;
}
else if (conMethodModifier.MethodModifierName  ==  _AttributeName[intIndex])
{
return mstrMethodModifierName;
}
else if (conMethodModifier.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conMethodModifier.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMethodModifier.MethodModifierId  ==  _AttributeName[intIndex])
{
mstrMethodModifierId = value.ToString();
 AddUpdatedFld(conMethodModifier.MethodModifierId);
}
else if (conMethodModifier.MethodModifierName  ==  _AttributeName[intIndex])
{
mstrMethodModifierName = value.ToString();
 AddUpdatedFld(conMethodModifier.MethodModifierName);
}
else if (conMethodModifier.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conMethodModifier.OrderNum);
}
else if (conMethodModifier.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMethodModifier.Memo);
}
}
}

/// <summary>
/// 函数修饰语Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MethodModifierId
{
get
{
return mstrMethodModifierId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMethodModifierId = value;
}
else
{
 mstrMethodModifierId = value;
}
//记录修改过的字段
 AddUpdatedFld(conMethodModifier.MethodModifierId);
}
}
/// <summary>
/// 函数修饰语名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MethodModifierName
{
get
{
return mstrMethodModifierName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMethodModifierName = value;
}
else
{
 mstrMethodModifierName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMethodModifier.MethodModifierName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conMethodModifier.OrderNum);
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
 AddUpdatedFld(conMethodModifier.Memo);
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
  return mstrMethodModifierId;
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
  return mstrMethodModifierName;
 }
 }
}
 /// <summary>
 /// 函数修饰语(MethodModifier)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMethodModifier
{
public const string _CurrTabName = "MethodModifier"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MethodModifierId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"MethodModifierId", "MethodModifierName", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MethodModifierId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MethodModifierId = "MethodModifierId";    //函数修饰语Id

 /// <summary>
 /// 常量:"MethodModifierName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MethodModifierName = "MethodModifierName";    //函数修饰语名称

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