
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvFunctionsEN
 表名:WebSrvFunctions(00050342)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 表WebSrvFunctions的关键字(WebSrvFunctionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WebSrvFunctionId_WebSrvFunctions
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWebSrvFunctionId">表关键字</param>
public K_WebSrvFunctionId_WebSrvFunctions(string strWebSrvFunctionId)
{
if (IsValid(strWebSrvFunctionId)) Value = strWebSrvFunctionId;
else
{
Value = null;
}
}
private static bool IsValid(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true) return false;
if (strWebSrvFunctionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WebSrvFunctionId_WebSrvFunctions]类型的对象</returns>
public static implicit operator K_WebSrvFunctionId_WebSrvFunctions(string value)
{
return new K_WebSrvFunctionId_WebSrvFunctions(value);
}
}
 /// <summary>
 /// WebSrv函数(WebSrvFunctions)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsWebSrvFunctionsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "WebSrvFunctions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WebSrvFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 19;
public static string[] _AttributeName = new string[] {"WebSrvFunctionId", "WebSrvClassId", "FunctionName", "GetCustomAttributes", "FunctionSignature", "FuncTypeId", "ReturnType", "ReturnTypeFullName", "IsKnownType", "ReturnTypeId", "IsAsyncFunc", "SourceFunction", "IsGeneCode", "ReturnValueDescription", "FuncParaLst", "IsSysFunction", "UpdDate", "UpdUser", "Memo"};

protected string mstrWebSrvFunctionId;    //函数Id
protected string mstrWebSrvClassId;    //类Id
protected string mstrFunctionName;    //功能名称
protected int mintGetCustomAttributes;    //GetCustomAttributes
protected string mstrFunctionSignature;    //函数签名
protected string mstrFuncTypeId;    //函数类型Id
protected string mstrReturnType;    //返回类型
protected string mstrReturnTypeFullName;    //返回类型全名
protected bool mbolIsKnownType;    //是否已知类型
protected string mstrReturnTypeId;    //返回类型ID
protected bool mbolIsAsyncFunc;    //是否异步函数
protected string mstrSourceFunction;    //来源函数
protected bool mbolIsGeneCode;    //是否生成代码
protected string mstrReturnValueDescription;    //返回值说明
protected string mstrFuncParaLst;    //函数参数列表
protected bool mbolIsSysFunction;    //是否系统函数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsWebSrvFunctionsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvFunctionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strWebSrvFunctionId">关键字:函数Id</param>
public clsWebSrvFunctionsEN(string strWebSrvFunctionId)
 {
strWebSrvFunctionId = strWebSrvFunctionId.Replace("'", "''");
if (strWebSrvFunctionId.Length > 8)
{
throw new Exception("在表:WebSrvFunctions中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWebSrvFunctionId)  ==  true)
{
throw new Exception("在表:WebSrvFunctions中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWebSrvFunctionId = strWebSrvFunctionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvFunctionId");
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
if (strAttributeName  ==  conWebSrvFunctions.WebSrvFunctionId)
{
return mstrWebSrvFunctionId;
}
else if (strAttributeName  ==  conWebSrvFunctions.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  conWebSrvFunctions.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  conWebSrvFunctions.GetCustomAttributes)
{
return mintGetCustomAttributes;
}
else if (strAttributeName  ==  conWebSrvFunctions.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  conWebSrvFunctions.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnType)
{
return mstrReturnType;
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnTypeFullName)
{
return mstrReturnTypeFullName;
}
else if (strAttributeName  ==  conWebSrvFunctions.IsKnownType)
{
return mbolIsKnownType;
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  conWebSrvFunctions.IsAsyncFunc)
{
return mbolIsAsyncFunc;
}
else if (strAttributeName  ==  conWebSrvFunctions.SourceFunction)
{
return mstrSourceFunction;
}
else if (strAttributeName  ==  conWebSrvFunctions.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnValueDescription)
{
return mstrReturnValueDescription;
}
else if (strAttributeName  ==  conWebSrvFunctions.FuncParaLst)
{
return mstrFuncParaLst;
}
else if (strAttributeName  ==  conWebSrvFunctions.IsSysFunction)
{
return mbolIsSysFunction;
}
else if (strAttributeName  ==  conWebSrvFunctions.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conWebSrvFunctions.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conWebSrvFunctions.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conWebSrvFunctions.WebSrvFunctionId)
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.WebSrvFunctionId);
}
else if (strAttributeName  ==  conWebSrvFunctions.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.WebSrvClassId);
}
else if (strAttributeName  ==  conWebSrvFunctions.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FunctionName);
}
else if (strAttributeName  ==  conWebSrvFunctions.GetCustomAttributes)
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.GetCustomAttributes);
}
else if (strAttributeName  ==  conWebSrvFunctions.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FunctionSignature);
}
else if (strAttributeName  ==  conWebSrvFunctions.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FuncTypeId);
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnType)
{
mstrReturnType = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnType);
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnTypeFullName)
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnTypeFullName);
}
else if (strAttributeName  ==  conWebSrvFunctions.IsKnownType)
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsKnownType);
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnTypeId);
}
else if (strAttributeName  ==  conWebSrvFunctions.IsAsyncFunc)
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsAsyncFunc);
}
else if (strAttributeName  ==  conWebSrvFunctions.SourceFunction)
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.SourceFunction);
}
else if (strAttributeName  ==  conWebSrvFunctions.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsGeneCode);
}
else if (strAttributeName  ==  conWebSrvFunctions.ReturnValueDescription)
{
mstrReturnValueDescription = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnValueDescription);
}
else if (strAttributeName  ==  conWebSrvFunctions.FuncParaLst)
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FuncParaLst);
}
else if (strAttributeName  ==  conWebSrvFunctions.IsSysFunction)
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsSysFunction);
}
else if (strAttributeName  ==  conWebSrvFunctions.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.UpdDate);
}
else if (strAttributeName  ==  conWebSrvFunctions.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.UpdUser);
}
else if (strAttributeName  ==  conWebSrvFunctions.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conWebSrvFunctions.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
return mstrWebSrvFunctionId;
}
else if (conWebSrvFunctions.WebSrvClassId  ==  _AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (conWebSrvFunctions.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (conWebSrvFunctions.GetCustomAttributes  ==  _AttributeName[intIndex])
{
return mintGetCustomAttributes;
}
else if (conWebSrvFunctions.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (conWebSrvFunctions.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (conWebSrvFunctions.ReturnType  ==  _AttributeName[intIndex])
{
return mstrReturnType;
}
else if (conWebSrvFunctions.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
return mstrReturnTypeFullName;
}
else if (conWebSrvFunctions.IsKnownType  ==  _AttributeName[intIndex])
{
return mbolIsKnownType;
}
else if (conWebSrvFunctions.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (conWebSrvFunctions.IsAsyncFunc  ==  _AttributeName[intIndex])
{
return mbolIsAsyncFunc;
}
else if (conWebSrvFunctions.SourceFunction  ==  _AttributeName[intIndex])
{
return mstrSourceFunction;
}
else if (conWebSrvFunctions.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (conWebSrvFunctions.ReturnValueDescription  ==  _AttributeName[intIndex])
{
return mstrReturnValueDescription;
}
else if (conWebSrvFunctions.FuncParaLst  ==  _AttributeName[intIndex])
{
return mstrFuncParaLst;
}
else if (conWebSrvFunctions.IsSysFunction  ==  _AttributeName[intIndex])
{
return mbolIsSysFunction;
}
else if (conWebSrvFunctions.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conWebSrvFunctions.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conWebSrvFunctions.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conWebSrvFunctions.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.WebSrvFunctionId);
}
else if (conWebSrvFunctions.WebSrvClassId  ==  _AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.WebSrvClassId);
}
else if (conWebSrvFunctions.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FunctionName);
}
else if (conWebSrvFunctions.GetCustomAttributes  ==  _AttributeName[intIndex])
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.GetCustomAttributes);
}
else if (conWebSrvFunctions.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FunctionSignature);
}
else if (conWebSrvFunctions.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FuncTypeId);
}
else if (conWebSrvFunctions.ReturnType  ==  _AttributeName[intIndex])
{
mstrReturnType = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnType);
}
else if (conWebSrvFunctions.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnTypeFullName);
}
else if (conWebSrvFunctions.IsKnownType  ==  _AttributeName[intIndex])
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsKnownType);
}
else if (conWebSrvFunctions.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnTypeId);
}
else if (conWebSrvFunctions.IsAsyncFunc  ==  _AttributeName[intIndex])
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsAsyncFunc);
}
else if (conWebSrvFunctions.SourceFunction  ==  _AttributeName[intIndex])
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.SourceFunction);
}
else if (conWebSrvFunctions.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsGeneCode);
}
else if (conWebSrvFunctions.ReturnValueDescription  ==  _AttributeName[intIndex])
{
mstrReturnValueDescription = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.ReturnValueDescription);
}
else if (conWebSrvFunctions.FuncParaLst  ==  _AttributeName[intIndex])
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.FuncParaLst);
}
else if (conWebSrvFunctions.IsSysFunction  ==  _AttributeName[intIndex])
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(conWebSrvFunctions.IsSysFunction);
}
else if (conWebSrvFunctions.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.UpdDate);
}
else if (conWebSrvFunctions.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.UpdUser);
}
else if (conWebSrvFunctions.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conWebSrvFunctions.Memo);
}
}
}

/// <summary>
/// 函数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvFunctionId
{
get
{
return mstrWebSrvFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvFunctionId = value;
}
else
{
 mstrWebSrvFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.WebSrvFunctionId);
}
}
/// <summary>
/// 类Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvClassId
{
get
{
return mstrWebSrvClassId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvClassId = value;
}
else
{
 mstrWebSrvClassId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.WebSrvClassId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.FunctionName);
}
}
/// <summary>
/// GetCustomAttributes(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int GetCustomAttributes
{
get
{
return mintGetCustomAttributes;
}
set
{
 mintGetCustomAttributes = value;
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.GetCustomAttributes);
}
}
/// <summary>
/// 函数签名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionSignature
{
get
{
return mstrFunctionSignature;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionSignature = value;
}
else
{
 mstrFunctionSignature = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.FunctionSignature);
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
 AddUpdatedFld(conWebSrvFunctions.FuncTypeId);
}
}
/// <summary>
/// 返回类型(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnType
{
get
{
return mstrReturnType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnType = value;
}
else
{
 mstrReturnType = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.ReturnType);
}
}
/// <summary>
/// 返回类型全名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTypeFullName
{
get
{
return mstrReturnTypeFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTypeFullName = value;
}
else
{
 mstrReturnTypeFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.ReturnTypeFullName);
}
}
/// <summary>
/// 是否已知类型(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsKnownType
{
get
{
return mbolIsKnownType;
}
set
{
 mbolIsKnownType = value;
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.IsKnownType);
}
}
/// <summary>
/// 返回类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTypeId
{
get
{
return mstrReturnTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTypeId = value;
}
else
{
 mstrReturnTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.ReturnTypeId);
}
}
/// <summary>
/// 是否异步函数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAsyncFunc
{
get
{
return mbolIsAsyncFunc;
}
set
{
 mbolIsAsyncFunc = value;
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.IsAsyncFunc);
}
}
/// <summary>
/// 来源函数(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceFunction
{
get
{
return mstrSourceFunction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceFunction = value;
}
else
{
 mstrSourceFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.SourceFunction);
}
}
/// <summary>
/// 是否生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneCode
{
get
{
return mbolIsGeneCode;
}
set
{
 mbolIsGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.IsGeneCode);
}
}
/// <summary>
/// 返回值说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnValueDescription
{
get
{
return mstrReturnValueDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnValueDescription = value;
}
else
{
 mstrReturnValueDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.ReturnValueDescription);
}
}
/// <summary>
/// 函数参数列表(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncParaLst
{
get
{
return mstrFuncParaLst;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncParaLst = value;
}
else
{
 mstrFuncParaLst = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.FuncParaLst);
}
}
/// <summary>
/// 是否系统函数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSysFunction
{
get
{
return mbolIsSysFunction;
}
set
{
 mbolIsSysFunction = value;
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.IsSysFunction);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conWebSrvFunctions.UpdUser);
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
 AddUpdatedFld(conWebSrvFunctions.Memo);
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
  return mstrWebSrvFunctionId;
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
  return mstrFunctionName;
 }
 }
}
 /// <summary>
 /// WebSrv函数(WebSrvFunctions)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conWebSrvFunctions
{
public const string _CurrTabName = "WebSrvFunctions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WebSrvFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WebSrvFunctionId", "WebSrvClassId", "FunctionName", "GetCustomAttributes", "FunctionSignature", "FuncTypeId", "ReturnType", "ReturnTypeFullName", "IsKnownType", "ReturnTypeId", "IsAsyncFunc", "SourceFunction", "IsGeneCode", "ReturnValueDescription", "FuncParaLst", "IsSysFunction", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"WebSrvFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvFunctionId = "WebSrvFunctionId";    //函数Id

 /// <summary>
 /// 常量:"WebSrvClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvClassId = "WebSrvClassId";    //类Id

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //功能名称

 /// <summary>
 /// 常量:"GetCustomAttributes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetCustomAttributes = "GetCustomAttributes";    //GetCustomAttributes

 /// <summary>
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"FuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeId = "FuncTypeId";    //函数类型Id

 /// <summary>
 /// 常量:"ReturnType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnType = "ReturnType";    //返回类型

 /// <summary>
 /// 常量:"ReturnTypeFullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeFullName = "ReturnTypeFullName";    //返回类型全名

 /// <summary>
 /// 常量:"IsKnownType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsKnownType = "IsKnownType";    //是否已知类型

 /// <summary>
 /// 常量:"ReturnTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeId = "ReturnTypeId";    //返回类型ID

 /// <summary>
 /// 常量:"IsAsyncFunc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAsyncFunc = "IsAsyncFunc";    //是否异步函数

 /// <summary>
 /// 常量:"SourceFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceFunction = "SourceFunction";    //来源函数

 /// <summary>
 /// 常量:"IsGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneCode = "IsGeneCode";    //是否生成代码

 /// <summary>
 /// 常量:"ReturnValueDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnValueDescription = "ReturnValueDescription";    //返回值说明

 /// <summary>
 /// 常量:"FuncParaLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncParaLst = "FuncParaLst";    //函数参数列表

 /// <summary>
 /// 常量:"IsSysFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSysFunction = "IsSysFunction";    //是否系统函数

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}