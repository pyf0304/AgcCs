
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFldOperationTypeEN
 表名:FldOperationType(00050278)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:08
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
 /// 表FldOperationType的关键字(FldOpTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldOpTypeId_FldOperationType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFldOpTypeId">表关键字</param>
public K_FldOpTypeId_FldOperationType(string strFldOpTypeId)
{
if (IsValid(strFldOpTypeId)) Value = strFldOpTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFldOpTypeId)
{
if (string.IsNullOrEmpty(strFldOpTypeId) == true) return false;
if (strFldOpTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FldOpTypeId_FldOperationType]类型的对象</returns>
public static implicit operator K_FldOpTypeId_FldOperationType(string value)
{
return new K_FldOpTypeId_FldOperationType(value);
}
}
 /// <summary>
 /// 字段操作类型(FldOperationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFldOperationTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FldOperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldOpTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"FldOpTypeId", "FldOpTypeName", "FldOpTypeENName", "Memo"};

protected string mstrFldOpTypeId;    //字段操作类型Id
protected string mstrFldOpTypeName;    //字段操作类型名称
protected string mstrFldOpTypeENName;    //字段操作类型英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFldOperationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldOpTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFldOpTypeId">关键字:字段操作类型Id</param>
public clsFldOperationTypeEN(string strFldOpTypeId)
 {
strFldOpTypeId = strFldOpTypeId.Replace("'", "''");
if (strFldOpTypeId.Length > 4)
{
throw new Exception("在表:FldOperationType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldOpTypeId)  ==  true)
{
throw new Exception("在表:FldOperationType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldOpTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFldOpTypeId = strFldOpTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldOpTypeId");
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
if (strAttributeName  ==  conFldOperationType.FldOpTypeId)
{
return mstrFldOpTypeId;
}
else if (strAttributeName  ==  conFldOperationType.FldOpTypeName)
{
return mstrFldOpTypeName;
}
else if (strAttributeName  ==  conFldOperationType.FldOpTypeENName)
{
return mstrFldOpTypeENName;
}
else if (strAttributeName  ==  conFldOperationType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFldOperationType.FldOpTypeId)
{
mstrFldOpTypeId = value.ToString();
 AddUpdatedFld(conFldOperationType.FldOpTypeId);
}
else if (strAttributeName  ==  conFldOperationType.FldOpTypeName)
{
mstrFldOpTypeName = value.ToString();
 AddUpdatedFld(conFldOperationType.FldOpTypeName);
}
else if (strAttributeName  ==  conFldOperationType.FldOpTypeENName)
{
mstrFldOpTypeENName = value.ToString();
 AddUpdatedFld(conFldOperationType.FldOpTypeENName);
}
else if (strAttributeName  ==  conFldOperationType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFldOperationType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFldOperationType.FldOpTypeId  ==  _AttributeName[intIndex])
{
return mstrFldOpTypeId;
}
else if (conFldOperationType.FldOpTypeName  ==  _AttributeName[intIndex])
{
return mstrFldOpTypeName;
}
else if (conFldOperationType.FldOpTypeENName  ==  _AttributeName[intIndex])
{
return mstrFldOpTypeENName;
}
else if (conFldOperationType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFldOperationType.FldOpTypeId  ==  _AttributeName[intIndex])
{
mstrFldOpTypeId = value.ToString();
 AddUpdatedFld(conFldOperationType.FldOpTypeId);
}
else if (conFldOperationType.FldOpTypeName  ==  _AttributeName[intIndex])
{
mstrFldOpTypeName = value.ToString();
 AddUpdatedFld(conFldOperationType.FldOpTypeName);
}
else if (conFldOperationType.FldOpTypeENName  ==  _AttributeName[intIndex])
{
mstrFldOpTypeENName = value.ToString();
 AddUpdatedFld(conFldOperationType.FldOpTypeENName);
}
else if (conFldOperationType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFldOperationType.Memo);
}
}
}

/// <summary>
/// 字段操作类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldOpTypeId
{
get
{
return mstrFldOpTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldOpTypeId = value;
}
else
{
 mstrFldOpTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFldOperationType.FldOpTypeId);
}
}
/// <summary>
/// 字段操作类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldOpTypeName
{
get
{
return mstrFldOpTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldOpTypeName = value;
}
else
{
 mstrFldOpTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFldOperationType.FldOpTypeName);
}
}
/// <summary>
/// 字段操作类型英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldOpTypeENName
{
get
{
return mstrFldOpTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldOpTypeENName = value;
}
else
{
 mstrFldOpTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFldOperationType.FldOpTypeENName);
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
 AddUpdatedFld(conFldOperationType.Memo);
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
  return mstrFldOpTypeId;
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
  return mstrFldOpTypeName;
 }
 }
}
 /// <summary>
 /// 字段操作类型(FldOperationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFldOperationType
{
public const string _CurrTabName = "FldOperationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldOpTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FldOpTypeId", "FldOpTypeName", "FldOpTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldOpTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldOpTypeId = "FldOpTypeId";    //字段操作类型Id

 /// <summary>
 /// 常量:"FldOpTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldOpTypeName = "FldOpTypeName";    //字段操作类型名称

 /// <summary>
 /// 常量:"FldOpTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldOpTypeENName = "FldOpTypeENName";    //字段操作类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}