
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTypeEN
 表名:FunctionType(00050063)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:26
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
 /// 表FunctionType的关键字(FuncTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncTypeId_FunctionType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncTypeId">表关键字</param>
public K_FuncTypeId_FunctionType(string strFuncTypeId)
{
if (IsValid(strFuncTypeId)) Value = strFuncTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true) return false;
if (strFuncTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncTypeId_FunctionType]类型的对象</returns>
public static implicit operator K_FuncTypeId_FunctionType(string value)
{
return new K_FuncTypeId_FunctionType(value);
}
}
 /// <summary>
 /// 函数类型(FunctionType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 5;
public static string[] _AttributeName = new string[] {"FuncTypeId", "FuncTypeName", "FuncTypeENName", "CodeTypeId", "Memo"};

protected string mstrFuncTypeId;    //函数类型Id
protected string mstrFuncTypeName;    //函数类型名
protected string mstrFuncTypeENName;    //函数类型英文名
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunctionTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncTypeId">关键字:函数类型Id</param>
public clsFunctionTypeEN(string strFuncTypeId)
 {
strFuncTypeId = strFuncTypeId.Replace("'", "''");
if (strFuncTypeId.Length > 2)
{
throw new Exception("在表:FunctionType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncTypeId)  ==  true)
{
throw new Exception("在表:FunctionType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncTypeId = strFuncTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncTypeId");
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
if (strAttributeName  ==  conFunctionType.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  conFunctionType.FuncTypeName)
{
return mstrFuncTypeName;
}
else if (strAttributeName  ==  conFunctionType.FuncTypeENName)
{
return mstrFuncTypeENName;
}
else if (strAttributeName  ==  conFunctionType.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conFunctionType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionType.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conFunctionType.FuncTypeId);
}
else if (strAttributeName  ==  conFunctionType.FuncTypeName)
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(conFunctionType.FuncTypeName);
}
else if (strAttributeName  ==  conFunctionType.FuncTypeENName)
{
mstrFuncTypeENName = value.ToString();
 AddUpdatedFld(conFunctionType.FuncTypeENName);
}
else if (strAttributeName  ==  conFunctionType.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conFunctionType.CodeTypeId);
}
else if (strAttributeName  ==  conFunctionType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionType.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (conFunctionType.FuncTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncTypeName;
}
else if (conFunctionType.FuncTypeENName  ==  _AttributeName[intIndex])
{
return mstrFuncTypeENName;
}
else if (conFunctionType.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conFunctionType.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionType.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conFunctionType.FuncTypeId);
}
else if (conFunctionType.FuncTypeName  ==  _AttributeName[intIndex])
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(conFunctionType.FuncTypeName);
}
else if (conFunctionType.FuncTypeENName  ==  _AttributeName[intIndex])
{
mstrFuncTypeENName = value.ToString();
 AddUpdatedFld(conFunctionType.FuncTypeENName);
}
else if (conFunctionType.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conFunctionType.CodeTypeId);
}
else if (conFunctionType.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionType.Memo);
}
}
}

/// <summary>
/// 函数类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeId
{
get
{
return mstrFuncTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeId = value;
}
else
{
 mstrFuncTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionType.FuncTypeId);
}
}
/// <summary>
/// 函数类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeName
{
get
{
return mstrFuncTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeName = value;
}
else
{
 mstrFuncTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionType.FuncTypeName);
}
}
/// <summary>
/// 函数类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncTypeENName
{
get
{
return mstrFuncTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncTypeENName = value;
}
else
{
 mstrFuncTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionType.FuncTypeENName);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionType.CodeTypeId);
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
 AddUpdatedFld(conFunctionType.Memo);
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
  return mstrFuncTypeId;
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
  return mstrFuncTypeName;
 }
 }
}
 /// <summary>
 /// 函数类型(FunctionType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionType
{
public const string _CurrTabName = "FunctionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncTypeId", "FuncTypeName", "FuncTypeENName", "CodeTypeId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeId = "FuncTypeId";    //函数类型Id

 /// <summary>
 /// 常量:"FuncTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeName = "FuncTypeName";    //函数类型名

 /// <summary>
 /// 常量:"FuncTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeENName = "FuncTypeENName";    //函数类型英文名

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}