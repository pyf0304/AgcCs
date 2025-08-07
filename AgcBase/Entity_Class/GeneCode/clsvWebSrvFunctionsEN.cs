
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFunctionsEN
 表名:vWebSrvFunctions(00050343)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:44:34
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
 /// 表vWebSrvFunctions的关键字(WebSrvFunctionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WebSrvFunctionId_vWebSrvFunctions
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
public K_WebSrvFunctionId_vWebSrvFunctions(string strWebSrvFunctionId)
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
 /// <returns>返回:[K_WebSrvFunctionId_vWebSrvFunctions]类型的对象</returns>
public static implicit operator K_WebSrvFunctionId_vWebSrvFunctions(string value)
{
return new K_WebSrvFunctionId_vWebSrvFunctions(value);
}
}
 /// <summary>
 /// vWebSrv函数(vWebSrvFunctions)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvWebSrvFunctionsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vWebSrvFunctions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WebSrvFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 32;
public static string[] _AttributeName = new string[] {"WebSrvFunctionId", "WebSrvClassId", "NameSpace", "WebSrvUrl", "FuncModuleAgcId", "PrjId", "FunctionName", "GetCustomAttributes", "FunctionSignature", "FuncTypeId", "FuncTypeName", "ReturnType", "ReturnTypeFullName", "IsKnownType", "ReturnTypeId", "DataTypeName", "DataTypeAbbr", "NetSysType", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "IsAsyncFunc", "SourceFunction", "IsGeneCode", "ReturnValueDescription", "FuncParaLst", "UpdDate", "UpdUser", "Memo", "ClsName"};

protected string mstrWebSrvFunctionId;    //函数Id
protected string mstrWebSrvClassId;    //类Id
protected string mstrNameSpace;    //域名
protected string mstrWebSrvUrl;    //WebSrv地址
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrPrjId;    //工程Id
protected string mstrFunctionName;    //功能名称
protected int mintGetCustomAttributes;    //GetCustomAttributes
protected string mstrFunctionSignature;    //函数签名
protected string mstrFuncTypeId;    //函数类型Id
protected string mstrFuncTypeName;    //函数类型名
protected string mstrReturnType;    //返回类型
protected string mstrReturnTypeFullName;    //返回类型全名
protected bool mbolIsKnownType;    //是否已知类型
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrDataTypeName;    //数据类型名称
protected string mstrDataTypeAbbr;    //数据类型缩写
protected string mstrNetSysType;    //NET系统类型
protected string mstrCsType;    //CS类型
protected string mstrJavaType;    //JAVA类型
protected string mstrJavaObjType;    //JAVA对象类型
protected string mstrSwiftType;    //SwiftType
protected bool mbolIsNeedQuote;    //是否需要引号
protected bool mbolIsAsyncFunc;    //是否异步函数
protected string mstrSourceFunction;    //来源函数
protected bool mbolIsGeneCode;    //是否生成代码
protected string mstrReturnValueDescription;    //返回值说明
protected string mstrFuncParaLst;    //函数参数列表
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvWebSrvFunctionsEN()
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
public clsvWebSrvFunctionsEN(string strWebSrvFunctionId)
 {
strWebSrvFunctionId = strWebSrvFunctionId.Replace("'", "''");
if (strWebSrvFunctionId.Length > 8)
{
throw new Exception("在表:vWebSrvFunctions中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWebSrvFunctionId)  ==  true)
{
throw new Exception("在表:vWebSrvFunctions中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convWebSrvFunctions.WebSrvFunctionId)
{
return mstrWebSrvFunctionId;
}
else if (strAttributeName  ==  convWebSrvFunctions.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  convWebSrvFunctions.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  convWebSrvFunctions.WebSrvUrl)
{
return mstrWebSrvUrl;
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convWebSrvFunctions.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convWebSrvFunctions.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  convWebSrvFunctions.GetCustomAttributes)
{
return mintGetCustomAttributes;
}
else if (strAttributeName  ==  convWebSrvFunctions.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncTypeName)
{
return mstrFuncTypeName;
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnType)
{
return mstrReturnType;
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnTypeFullName)
{
return mstrReturnTypeFullName;
}
else if (strAttributeName  ==  convWebSrvFunctions.IsKnownType)
{
return mbolIsKnownType;
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  convWebSrvFunctions.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convWebSrvFunctions.DataTypeAbbr)
{
return mstrDataTypeAbbr;
}
else if (strAttributeName  ==  convWebSrvFunctions.NetSysType)
{
return mstrNetSysType;
}
else if (strAttributeName  ==  convWebSrvFunctions.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  convWebSrvFunctions.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  convWebSrvFunctions.JavaObjType)
{
return mstrJavaObjType;
}
else if (strAttributeName  ==  convWebSrvFunctions.SwiftType)
{
return mstrSwiftType;
}
else if (strAttributeName  ==  convWebSrvFunctions.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  convWebSrvFunctions.IsAsyncFunc)
{
return mbolIsAsyncFunc;
}
else if (strAttributeName  ==  convWebSrvFunctions.SourceFunction)
{
return mstrSourceFunction;
}
else if (strAttributeName  ==  convWebSrvFunctions.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnValueDescription)
{
return mstrReturnValueDescription;
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncParaLst)
{
return mstrFuncParaLst;
}
else if (strAttributeName  ==  convWebSrvFunctions.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convWebSrvFunctions.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convWebSrvFunctions.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convWebSrvFunctions.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convWebSrvFunctions.WebSrvFunctionId)
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.WebSrvFunctionId);
}
else if (strAttributeName  ==  convWebSrvFunctions.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.WebSrvClassId);
}
else if (strAttributeName  ==  convWebSrvFunctions.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.NameSpace);
}
else if (strAttributeName  ==  convWebSrvFunctions.WebSrvUrl)
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.WebSrvUrl);
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncModuleAgcId);
}
else if (strAttributeName  ==  convWebSrvFunctions.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.PrjId);
}
else if (strAttributeName  ==  convWebSrvFunctions.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FunctionName);
}
else if (strAttributeName  ==  convWebSrvFunctions.GetCustomAttributes)
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.GetCustomAttributes);
}
else if (strAttributeName  ==  convWebSrvFunctions.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FunctionSignature);
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncTypeId);
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncTypeName)
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncTypeName);
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnType)
{
mstrReturnType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnType);
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnTypeFullName)
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnTypeFullName);
}
else if (strAttributeName  ==  convWebSrvFunctions.IsKnownType)
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsKnownType);
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnTypeId);
}
else if (strAttributeName  ==  convWebSrvFunctions.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.DataTypeName);
}
else if (strAttributeName  ==  convWebSrvFunctions.DataTypeAbbr)
{
mstrDataTypeAbbr = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.DataTypeAbbr);
}
else if (strAttributeName  ==  convWebSrvFunctions.NetSysType)
{
mstrNetSysType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.NetSysType);
}
else if (strAttributeName  ==  convWebSrvFunctions.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.CsType);
}
else if (strAttributeName  ==  convWebSrvFunctions.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.JavaType);
}
else if (strAttributeName  ==  convWebSrvFunctions.JavaObjType)
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.JavaObjType);
}
else if (strAttributeName  ==  convWebSrvFunctions.SwiftType)
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.SwiftType);
}
else if (strAttributeName  ==  convWebSrvFunctions.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsNeedQuote);
}
else if (strAttributeName  ==  convWebSrvFunctions.IsAsyncFunc)
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsAsyncFunc);
}
else if (strAttributeName  ==  convWebSrvFunctions.SourceFunction)
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.SourceFunction);
}
else if (strAttributeName  ==  convWebSrvFunctions.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsGeneCode);
}
else if (strAttributeName  ==  convWebSrvFunctions.ReturnValueDescription)
{
mstrReturnValueDescription = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnValueDescription);
}
else if (strAttributeName  ==  convWebSrvFunctions.FuncParaLst)
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncParaLst);
}
else if (strAttributeName  ==  convWebSrvFunctions.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.UpdDate);
}
else if (strAttributeName  ==  convWebSrvFunctions.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.UpdUser);
}
else if (strAttributeName  ==  convWebSrvFunctions.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.Memo);
}
else if (strAttributeName  ==  convWebSrvFunctions.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convWebSrvFunctions.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
return mstrWebSrvFunctionId;
}
else if (convWebSrvFunctions.WebSrvClassId  ==  _AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (convWebSrvFunctions.NameSpace  ==  _AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (convWebSrvFunctions.WebSrvUrl  ==  _AttributeName[intIndex])
{
return mstrWebSrvUrl;
}
else if (convWebSrvFunctions.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convWebSrvFunctions.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convWebSrvFunctions.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (convWebSrvFunctions.GetCustomAttributes  ==  _AttributeName[intIndex])
{
return mintGetCustomAttributes;
}
else if (convWebSrvFunctions.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convWebSrvFunctions.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (convWebSrvFunctions.FuncTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncTypeName;
}
else if (convWebSrvFunctions.ReturnType  ==  _AttributeName[intIndex])
{
return mstrReturnType;
}
else if (convWebSrvFunctions.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
return mstrReturnTypeFullName;
}
else if (convWebSrvFunctions.IsKnownType  ==  _AttributeName[intIndex])
{
return mbolIsKnownType;
}
else if (convWebSrvFunctions.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (convWebSrvFunctions.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convWebSrvFunctions.DataTypeAbbr  ==  _AttributeName[intIndex])
{
return mstrDataTypeAbbr;
}
else if (convWebSrvFunctions.NetSysType  ==  _AttributeName[intIndex])
{
return mstrNetSysType;
}
else if (convWebSrvFunctions.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (convWebSrvFunctions.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (convWebSrvFunctions.JavaObjType  ==  _AttributeName[intIndex])
{
return mstrJavaObjType;
}
else if (convWebSrvFunctions.SwiftType  ==  _AttributeName[intIndex])
{
return mstrSwiftType;
}
else if (convWebSrvFunctions.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (convWebSrvFunctions.IsAsyncFunc  ==  _AttributeName[intIndex])
{
return mbolIsAsyncFunc;
}
else if (convWebSrvFunctions.SourceFunction  ==  _AttributeName[intIndex])
{
return mstrSourceFunction;
}
else if (convWebSrvFunctions.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (convWebSrvFunctions.ReturnValueDescription  ==  _AttributeName[intIndex])
{
return mstrReturnValueDescription;
}
else if (convWebSrvFunctions.FuncParaLst  ==  _AttributeName[intIndex])
{
return mstrFuncParaLst;
}
else if (convWebSrvFunctions.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convWebSrvFunctions.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convWebSrvFunctions.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convWebSrvFunctions.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convWebSrvFunctions.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.WebSrvFunctionId);
}
else if (convWebSrvFunctions.WebSrvClassId  ==  _AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.WebSrvClassId);
}
else if (convWebSrvFunctions.NameSpace  ==  _AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.NameSpace);
}
else if (convWebSrvFunctions.WebSrvUrl  ==  _AttributeName[intIndex])
{
mstrWebSrvUrl = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.WebSrvUrl);
}
else if (convWebSrvFunctions.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncModuleAgcId);
}
else if (convWebSrvFunctions.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.PrjId);
}
else if (convWebSrvFunctions.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FunctionName);
}
else if (convWebSrvFunctions.GetCustomAttributes  ==  _AttributeName[intIndex])
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.GetCustomAttributes);
}
else if (convWebSrvFunctions.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FunctionSignature);
}
else if (convWebSrvFunctions.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncTypeId);
}
else if (convWebSrvFunctions.FuncTypeName  ==  _AttributeName[intIndex])
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncTypeName);
}
else if (convWebSrvFunctions.ReturnType  ==  _AttributeName[intIndex])
{
mstrReturnType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnType);
}
else if (convWebSrvFunctions.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnTypeFullName);
}
else if (convWebSrvFunctions.IsKnownType  ==  _AttributeName[intIndex])
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsKnownType);
}
else if (convWebSrvFunctions.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnTypeId);
}
else if (convWebSrvFunctions.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.DataTypeName);
}
else if (convWebSrvFunctions.DataTypeAbbr  ==  _AttributeName[intIndex])
{
mstrDataTypeAbbr = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.DataTypeAbbr);
}
else if (convWebSrvFunctions.NetSysType  ==  _AttributeName[intIndex])
{
mstrNetSysType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.NetSysType);
}
else if (convWebSrvFunctions.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.CsType);
}
else if (convWebSrvFunctions.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.JavaType);
}
else if (convWebSrvFunctions.JavaObjType  ==  _AttributeName[intIndex])
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.JavaObjType);
}
else if (convWebSrvFunctions.SwiftType  ==  _AttributeName[intIndex])
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.SwiftType);
}
else if (convWebSrvFunctions.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsNeedQuote);
}
else if (convWebSrvFunctions.IsAsyncFunc  ==  _AttributeName[intIndex])
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsAsyncFunc);
}
else if (convWebSrvFunctions.SourceFunction  ==  _AttributeName[intIndex])
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.SourceFunction);
}
else if (convWebSrvFunctions.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFunctions.IsGeneCode);
}
else if (convWebSrvFunctions.ReturnValueDescription  ==  _AttributeName[intIndex])
{
mstrReturnValueDescription = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ReturnValueDescription);
}
else if (convWebSrvFunctions.FuncParaLst  ==  _AttributeName[intIndex])
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.FuncParaLst);
}
else if (convWebSrvFunctions.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.UpdDate);
}
else if (convWebSrvFunctions.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.UpdUser);
}
else if (convWebSrvFunctions.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.Memo);
}
else if (convWebSrvFunctions.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvFunctions.ClsName);
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
 AddUpdatedFld(convWebSrvFunctions.WebSrvFunctionId);
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
 AddUpdatedFld(convWebSrvFunctions.WebSrvClassId);
}
}
/// <summary>
/// 域名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NameSpace
{
get
{
return mstrNameSpace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNameSpace = value;
}
else
{
 mstrNameSpace = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.NameSpace);
}
}
/// <summary>
/// WebSrv地址(说明:;字段类型:varchar;字段长度:300;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvUrl
{
get
{
return mstrWebSrvUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvUrl = value;
}
else
{
 mstrWebSrvUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.WebSrvUrl);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.FuncModuleAgcId);
}
}
/// <summary>
/// 工程Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.PrjId);
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
 AddUpdatedFld(convWebSrvFunctions.FunctionName);
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
 AddUpdatedFld(convWebSrvFunctions.GetCustomAttributes);
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
 AddUpdatedFld(convWebSrvFunctions.FunctionSignature);
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
 AddUpdatedFld(convWebSrvFunctions.FuncTypeId);
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
 AddUpdatedFld(convWebSrvFunctions.FuncTypeName);
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
 AddUpdatedFld(convWebSrvFunctions.ReturnType);
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
 AddUpdatedFld(convWebSrvFunctions.ReturnTypeFullName);
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
 AddUpdatedFld(convWebSrvFunctions.IsKnownType);
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
 AddUpdatedFld(convWebSrvFunctions.ReturnTypeId);
}
}
/// <summary>
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeName
{
get
{
return mstrDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeName = value;
}
else
{
 mstrDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.DataTypeName);
}
}
/// <summary>
/// 数据类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeAbbr
{
get
{
return mstrDataTypeAbbr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeAbbr = value;
}
else
{
 mstrDataTypeAbbr = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.DataTypeAbbr);
}
}
/// <summary>
/// NET系统类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NetSysType
{
get
{
return mstrNetSysType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNetSysType = value;
}
else
{
 mstrNetSysType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.NetSysType);
}
}
/// <summary>
/// CS类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CsType
{
get
{
return mstrCsType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCsType = value;
}
else
{
 mstrCsType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.CsType);
}
}
/// <summary>
/// JAVA类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaType
{
get
{
return mstrJavaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaType = value;
}
else
{
 mstrJavaType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.JavaType);
}
}
/// <summary>
/// JAVA对象类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JavaObjType
{
get
{
return mstrJavaObjType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJavaObjType = value;
}
else
{
 mstrJavaObjType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.JavaObjType);
}
}
/// <summary>
/// SwiftType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SwiftType
{
get
{
return mstrSwiftType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSwiftType = value;
}
else
{
 mstrSwiftType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.SwiftType);
}
}
/// <summary>
/// 是否需要引号(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedQuote
{
get
{
return mbolIsNeedQuote;
}
set
{
 mbolIsNeedQuote = value;
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.IsNeedQuote);
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
 AddUpdatedFld(convWebSrvFunctions.IsAsyncFunc);
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
 AddUpdatedFld(convWebSrvFunctions.SourceFunction);
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
 AddUpdatedFld(convWebSrvFunctions.IsGeneCode);
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
 AddUpdatedFld(convWebSrvFunctions.ReturnValueDescription);
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
 AddUpdatedFld(convWebSrvFunctions.FuncParaLst);
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
 AddUpdatedFld(convWebSrvFunctions.UpdDate);
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
 AddUpdatedFld(convWebSrvFunctions.UpdUser);
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
 AddUpdatedFld(convWebSrvFunctions.Memo);
}
}
/// <summary>
/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsName
{
get
{
return mstrClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsName = value;
}
else
{
 mstrClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFunctions.ClsName);
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
}
 /// <summary>
 /// vWebSrv函数(vWebSrvFunctions)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convWebSrvFunctions
{
public const string _CurrTabName = "vWebSrvFunctions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WebSrvFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WebSrvFunctionId", "WebSrvClassId", "NameSpace", "WebSrvUrl", "FuncModuleAgcId", "PrjId", "FunctionName", "GetCustomAttributes", "FunctionSignature", "FuncTypeId", "FuncTypeName", "ReturnType", "ReturnTypeFullName", "IsKnownType", "ReturnTypeId", "DataTypeName", "DataTypeAbbr", "NetSysType", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "IsAsyncFunc", "SourceFunction", "IsGeneCode", "ReturnValueDescription", "FuncParaLst", "UpdDate", "UpdUser", "Memo", "ClsName"};
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
 /// 常量:"NameSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NameSpace = "NameSpace";    //域名

 /// <summary>
 /// 常量:"WebSrvUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvUrl = "WebSrvUrl";    //WebSrv地址

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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
 /// 常量:"FuncTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeName = "FuncTypeName";    //函数类型名

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
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"DataTypeAbbr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeAbbr = "DataTypeAbbr";    //数据类型缩写

 /// <summary>
 /// 常量:"NetSysType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NetSysType = "NetSysType";    //NET系统类型

 /// <summary>
 /// 常量:"CsType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CsType = "CsType";    //CS类型

 /// <summary>
 /// 常量:"JavaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaType = "JavaType";    //JAVA类型

 /// <summary>
 /// 常量:"JavaObjType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JavaObjType = "JavaObjType";    //JAVA对象类型

 /// <summary>
 /// 常量:"SwiftType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SwiftType = "SwiftType";    //SwiftType

 /// <summary>
 /// 常量:"IsNeedQuote"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedQuote = "IsNeedQuote";    //是否需要引号

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

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}