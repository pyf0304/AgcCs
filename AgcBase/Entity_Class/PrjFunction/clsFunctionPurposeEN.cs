
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionPurposeEN
 表名:FunctionPurpose(00050526)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:11
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
 /// 表FunctionPurpose的关键字(FuncPurposeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncPurposeId_FunctionPurpose
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncPurposeId">表关键字</param>
public K_FuncPurposeId_FunctionPurpose(string strFuncPurposeId)
{
if (IsValid(strFuncPurposeId)) Value = strFuncPurposeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncPurposeId)
{
if (string.IsNullOrEmpty(strFuncPurposeId) == true) return false;
if (strFuncPurposeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncPurposeId_FunctionPurpose]类型的对象</returns>
public static implicit operator K_FuncPurposeId_FunctionPurpose(string value)
{
return new K_FuncPurposeId_FunctionPurpose(value);
}
}
 /// <summary>
 /// 函数用途(FunctionPurpose)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionPurposeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionPurpose"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncPurposeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 4;
public static string[] _AttributeName = new string[] {"FuncPurposeId", "FuncPurposeName", "FuncPurposeENName", "Memo"};

protected string mstrFuncPurposeId;    //函数用途Id
protected string mstrFuncPurposeName;    //函数用途名
protected string mstrFuncPurposeENName;    //函数用途英文名
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunctionPurposeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncPurposeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncPurposeId">关键字:函数用途Id</param>
public clsFunctionPurposeEN(string strFuncPurposeId)
 {
strFuncPurposeId = strFuncPurposeId.Replace("'", "''");
if (strFuncPurposeId.Length > 2)
{
throw new Exception("在表:FunctionPurpose中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncPurposeId)  ==  true)
{
throw new Exception("在表:FunctionPurpose中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncPurposeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncPurposeId = strFuncPurposeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncPurposeId");
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
if (strAttributeName  ==  conFunctionPurpose.FuncPurposeId)
{
return mstrFuncPurposeId;
}
else if (strAttributeName  ==  conFunctionPurpose.FuncPurposeName)
{
return mstrFuncPurposeName;
}
else if (strAttributeName  ==  conFunctionPurpose.FuncPurposeENName)
{
return mstrFuncPurposeENName;
}
else if (strAttributeName  ==  conFunctionPurpose.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionPurpose.FuncPurposeId)
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(conFunctionPurpose.FuncPurposeId);
}
else if (strAttributeName  ==  conFunctionPurpose.FuncPurposeName)
{
mstrFuncPurposeName = value.ToString();
 AddUpdatedFld(conFunctionPurpose.FuncPurposeName);
}
else if (strAttributeName  ==  conFunctionPurpose.FuncPurposeENName)
{
mstrFuncPurposeENName = value.ToString();
 AddUpdatedFld(conFunctionPurpose.FuncPurposeENName);
}
else if (strAttributeName  ==  conFunctionPurpose.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionPurpose.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionPurpose.FuncPurposeId  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeId;
}
else if (conFunctionPurpose.FuncPurposeName  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeName;
}
else if (conFunctionPurpose.FuncPurposeENName  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeENName;
}
else if (conFunctionPurpose.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionPurpose.FuncPurposeId  ==  _AttributeName[intIndex])
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(conFunctionPurpose.FuncPurposeId);
}
else if (conFunctionPurpose.FuncPurposeName  ==  _AttributeName[intIndex])
{
mstrFuncPurposeName = value.ToString();
 AddUpdatedFld(conFunctionPurpose.FuncPurposeName);
}
else if (conFunctionPurpose.FuncPurposeENName  ==  _AttributeName[intIndex])
{
mstrFuncPurposeENName = value.ToString();
 AddUpdatedFld(conFunctionPurpose.FuncPurposeENName);
}
else if (conFunctionPurpose.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionPurpose.Memo);
}
}
}

/// <summary>
/// 函数用途Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncPurposeId
{
get
{
return mstrFuncPurposeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncPurposeId = value;
}
else
{
 mstrFuncPurposeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionPurpose.FuncPurposeId);
}
}
/// <summary>
/// 函数用途名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncPurposeName
{
get
{
return mstrFuncPurposeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncPurposeName = value;
}
else
{
 mstrFuncPurposeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionPurpose.FuncPurposeName);
}
}
/// <summary>
/// 函数用途英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncPurposeENName
{
get
{
return mstrFuncPurposeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncPurposeENName = value;
}
else
{
 mstrFuncPurposeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionPurpose.FuncPurposeENName);
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
 AddUpdatedFld(conFunctionPurpose.Memo);
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
  return mstrFuncPurposeId;
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
  return mstrFuncPurposeName;
 }
 }
}
 /// <summary>
 /// 函数用途(FunctionPurpose)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionPurpose
{
public const string _CurrTabName = "FunctionPurpose"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncPurposeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncPurposeId", "FuncPurposeName", "FuncPurposeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncPurposeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncPurposeId = "FuncPurposeId";    //函数用途Id

 /// <summary>
 /// 常量:"FuncPurposeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncPurposeName = "FuncPurposeName";    //函数用途名

 /// <summary>
 /// 常量:"FuncPurposeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncPurposeENName = "FuncPurposeENName";    //函数用途英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}