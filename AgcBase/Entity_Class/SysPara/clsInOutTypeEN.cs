
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsInOutTypeEN
 表名:InOutType(00050135)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表InOutType的关键字(InOutTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_InOutTypeId_InOutType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strInOutTypeId">表关键字</param>
public K_InOutTypeId_InOutType(string strInOutTypeId)
{
if (IsValid(strInOutTypeId)) Value = strInOutTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strInOutTypeId)
{
if (string.IsNullOrEmpty(strInOutTypeId) == true) return false;
if (strInOutTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_InOutTypeId_InOutType]类型的对象</returns>
public static implicit operator K_InOutTypeId_InOutType(string value)
{
return new K_InOutTypeId_InOutType(value);
}
}
 /// <summary>
 /// InOut类型(InOutType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsInOutTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "InOutType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "InOutTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"InOutTypeId", "InOutTypeName", "InOutTypeENName", "Memo"};

protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrInOutTypeName;    //INOUT类型名称
protected string mstrInOutTypeENName;    //INOUT类型英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsInOutTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("InOutTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strInOutTypeId">关键字:INOUT类型ID</param>
public clsInOutTypeEN(string strInOutTypeId)
 {
strInOutTypeId = strInOutTypeId.Replace("'", "''");
if (strInOutTypeId.Length > 2)
{
throw new Exception("在表:InOutType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strInOutTypeId)  ==  true)
{
throw new Exception("在表:InOutType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strInOutTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrInOutTypeId = strInOutTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("InOutTypeId");
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
if (strAttributeName  ==  conInOutType.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  conInOutType.InOutTypeName)
{
return mstrInOutTypeName;
}
else if (strAttributeName  ==  conInOutType.InOutTypeENName)
{
return mstrInOutTypeENName;
}
else if (strAttributeName  ==  conInOutType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conInOutType.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conInOutType.InOutTypeId);
}
else if (strAttributeName  ==  conInOutType.InOutTypeName)
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(conInOutType.InOutTypeName);
}
else if (strAttributeName  ==  conInOutType.InOutTypeENName)
{
mstrInOutTypeENName = value.ToString();
 AddUpdatedFld(conInOutType.InOutTypeENName);
}
else if (strAttributeName  ==  conInOutType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conInOutType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conInOutType.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (conInOutType.InOutTypeName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeName;
}
else if (conInOutType.InOutTypeENName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeENName;
}
else if (conInOutType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conInOutType.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conInOutType.InOutTypeId);
}
else if (conInOutType.InOutTypeName  ==  _AttributeName[intIndex])
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(conInOutType.InOutTypeName);
}
else if (conInOutType.InOutTypeENName  ==  _AttributeName[intIndex])
{
mstrInOutTypeENName = value.ToString();
 AddUpdatedFld(conInOutType.InOutTypeENName);
}
else if (conInOutType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conInOutType.Memo);
}
}
}

/// <summary>
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeId
{
get
{
return mstrInOutTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeId = value;
}
else
{
 mstrInOutTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conInOutType.InOutTypeId);
}
}
/// <summary>
/// INOUT类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeName
{
get
{
return mstrInOutTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeName = value;
}
else
{
 mstrInOutTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conInOutType.InOutTypeName);
}
}
/// <summary>
/// INOUT类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeENName
{
get
{
return mstrInOutTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeENName = value;
}
else
{
 mstrInOutTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conInOutType.InOutTypeENName);
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
 AddUpdatedFld(conInOutType.Memo);
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
  return mstrInOutTypeId;
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
  return mstrInOutTypeName;
 }
 }
}
 /// <summary>
 /// InOut类型(InOutType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conInOutType
{
public const string _CurrTabName = "InOutType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "InOutTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"InOutTypeId", "InOutTypeName", "InOutTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //INOUT类型ID

 /// <summary>
 /// 常量:"InOutTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeName = "InOutTypeName";    //INOUT类型名称

 /// <summary>
 /// 常量:"InOutTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeENName = "InOutTypeENName";    //INOUT类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}