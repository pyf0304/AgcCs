
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFldStateEN
 表名:FldState(00050107)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表FldState的关键字(FldStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldStateId_FldState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFldStateId">表关键字</param>
public K_FldStateId_FldState(string strFldStateId)
{
if (IsValid(strFldStateId)) Value = strFldStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strFldStateId)
{
if (string.IsNullOrEmpty(strFldStateId) == true) return false;
if (strFldStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FldStateId_FldState]类型的对象</returns>
public static implicit operator K_FldStateId_FldState(string value)
{
return new K_FldStateId_FldState(value);
}
}
 /// <summary>
 /// 字段状态(FldState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFldStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FldState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 3;
public static string[] _AttributeName = new string[] {"FldStateId", "FldStateName", "Memo"};

protected string mstrFldStateId;    //字段状态Id
protected string mstrFldStateName;    //字段状态名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFldStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFldStateId">关键字:字段状态Id</param>
public clsFldStateEN(string strFldStateId)
 {
strFldStateId = strFldStateId.Replace("'", "''");
if (strFldStateId.Length > 2)
{
throw new Exception("在表:FldState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldStateId)  ==  true)
{
throw new Exception("在表:FldState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFldStateId = strFldStateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldStateId");
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
if (strAttributeName  ==  conFldState.FldStateId)
{
return mstrFldStateId;
}
else if (strAttributeName  ==  conFldState.FldStateName)
{
return mstrFldStateName;
}
else if (strAttributeName  ==  conFldState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFldState.FldStateId)
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(conFldState.FldStateId);
}
else if (strAttributeName  ==  conFldState.FldStateName)
{
mstrFldStateName = value.ToString();
 AddUpdatedFld(conFldState.FldStateName);
}
else if (strAttributeName  ==  conFldState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFldState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFldState.FldStateId  ==  _AttributeName[intIndex])
{
return mstrFldStateId;
}
else if (conFldState.FldStateName  ==  _AttributeName[intIndex])
{
return mstrFldStateName;
}
else if (conFldState.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFldState.FldStateId  ==  _AttributeName[intIndex])
{
mstrFldStateId = value.ToString();
 AddUpdatedFld(conFldState.FldStateId);
}
else if (conFldState.FldStateName  ==  _AttributeName[intIndex])
{
mstrFldStateName = value.ToString();
 AddUpdatedFld(conFldState.FldStateName);
}
else if (conFldState.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFldState.Memo);
}
}
}

/// <summary>
/// 字段状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldStateId
{
get
{
return mstrFldStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldStateId = value;
}
else
{
 mstrFldStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFldState.FldStateId);
}
}
/// <summary>
/// 字段状态名(说明:;字段类型:char;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldStateName
{
get
{
return mstrFldStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldStateName = value;
}
else
{
 mstrFldStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFldState.FldStateName);
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
 AddUpdatedFld(conFldState.Memo);
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
  return mstrFldStateId;
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
  return mstrFldStateName;
 }
 }
}
 /// <summary>
 /// 字段状态(FldState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFldState
{
public const string _CurrTabName = "FldState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FldStateId", "FldStateName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldStateId = "FldStateId";    //字段状态Id

 /// <summary>
 /// 常量:"FldStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldStateName = "FldStateName";    //字段状态名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}