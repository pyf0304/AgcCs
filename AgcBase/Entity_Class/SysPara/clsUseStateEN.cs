
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUseStateEN
 表名:UseState(00050192)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:00
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
 /// 表UseState的关键字(UseStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UseStateId_UseState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUseStateId">表关键字</param>
public K_UseStateId_UseState(string strUseStateId)
{
if (IsValid(strUseStateId)) Value = strUseStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strUseStateId)
{
if (string.IsNullOrEmpty(strUseStateId) == true) return false;
if (strUseStateId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UseStateId_UseState]类型的对象</returns>
public static implicit operator K_UseStateId_UseState(string value)
{
return new K_UseStateId_UseState(value);
}
}
 /// <summary>
 /// 使用状态(UseState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUseStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UseState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UseStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"UseStateId", "UseStateName", "UseStateENName", "Memo"};

protected string mstrUseStateId;    //使用状态Id
protected string mstrUseStateName;    //使用状态名称
protected string mstrUseStateENName;    //使用状态英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUseStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UseStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strUseStateId">关键字:使用状态Id</param>
public clsUseStateEN(string strUseStateId)
 {
strUseStateId = strUseStateId.Replace("'", "''");
if (strUseStateId.Length > 4)
{
throw new Exception("在表:UseState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUseStateId)  ==  true)
{
throw new Exception("在表:UseState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUseStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUseStateId = strUseStateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UseStateId");
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
if (strAttributeName  ==  conUseState.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  conUseState.UseStateName)
{
return mstrUseStateName;
}
else if (strAttributeName  ==  conUseState.UseStateENName)
{
return mstrUseStateENName;
}
else if (strAttributeName  ==  conUseState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUseState.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conUseState.UseStateId);
}
else if (strAttributeName  ==  conUseState.UseStateName)
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(conUseState.UseStateName);
}
else if (strAttributeName  ==  conUseState.UseStateENName)
{
mstrUseStateENName = value.ToString();
 AddUpdatedFld(conUseState.UseStateENName);
}
else if (strAttributeName  ==  conUseState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUseState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUseState.UseStateId  ==  _AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (conUseState.UseStateName  ==  _AttributeName[intIndex])
{
return mstrUseStateName;
}
else if (conUseState.UseStateENName  ==  _AttributeName[intIndex])
{
return mstrUseStateENName;
}
else if (conUseState.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUseState.UseStateId  ==  _AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conUseState.UseStateId);
}
else if (conUseState.UseStateName  ==  _AttributeName[intIndex])
{
mstrUseStateName = value.ToString();
 AddUpdatedFld(conUseState.UseStateName);
}
else if (conUseState.UseStateENName  ==  _AttributeName[intIndex])
{
mstrUseStateENName = value.ToString();
 AddUpdatedFld(conUseState.UseStateENName);
}
else if (conUseState.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUseState.Memo);
}
}
}

/// <summary>
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateId
{
get
{
return mstrUseStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateId = value;
}
else
{
 mstrUseStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUseState.UseStateId);
}
}
/// <summary>
/// 使用状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateName
{
get
{
return mstrUseStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateName = value;
}
else
{
 mstrUseStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUseState.UseStateName);
}
}
/// <summary>
/// 使用状态英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateENName
{
get
{
return mstrUseStateENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateENName = value;
}
else
{
 mstrUseStateENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUseState.UseStateENName);
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
 AddUpdatedFld(conUseState.Memo);
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
  return mstrUseStateId;
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
  return mstrUseStateName;
 }
 }
}
 /// <summary>
 /// 使用状态(UseState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUseState
{
public const string _CurrTabName = "UseState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UseStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"UseStateId", "UseStateName", "UseStateENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //使用状态Id

 /// <summary>
 /// 常量:"UseStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateName = "UseStateName";    //使用状态名称

 /// <summary>
 /// 常量:"UseStateENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateENName = "UseStateENName";    //使用状态英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}