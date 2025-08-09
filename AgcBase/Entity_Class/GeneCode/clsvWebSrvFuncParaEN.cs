
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFuncParaEN
 表名:vWebSrvFuncPara(00050348)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vWebSrvFuncPara的关键字(WebSrvFuncParaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WebSrvFuncParaId_vWebSrvFuncPara
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWebSrvFuncParaId">表关键字</param>
public K_WebSrvFuncParaId_vWebSrvFuncPara(string strWebSrvFuncParaId)
{
if (IsValid(strWebSrvFuncParaId)) Value = strWebSrvFuncParaId;
else
{
Value = null;
}
}
private static bool IsValid(string strWebSrvFuncParaId)
{
if (string.IsNullOrEmpty(strWebSrvFuncParaId) == true) return false;
if (strWebSrvFuncParaId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WebSrvFuncParaId_vWebSrvFuncPara]类型的对象</returns>
public static implicit operator K_WebSrvFuncParaId_vWebSrvFuncPara(string value)
{
return new K_WebSrvFuncParaId_vWebSrvFuncPara(value);
}
}
 /// <summary>
 /// vWebSrv函数参数(vWebSrvFuncPara)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvWebSrvFuncParaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vWebSrvFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WebSrvFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 29;
public static string[] _AttributeName = new string[] {"WebSrvFuncParaId", "WebSrvFunctionId", "WebSrvClassId", "FuncModuleAgcId", "PrjId", "FunctionName", "FunctionSignature", "IsAsyncFunc", "IsGeneCode", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterType", "ParameterTypeFullName", "IsByRef", "ParaName", "ParaCnName", "IsKnownType", "UpdDate", "UpdUser", "Memo", "ClsName"};

protected string mstrWebSrvFuncParaId;    //函数参数Id
protected string mstrWebSrvFunctionId;    //函数Id
protected string mstrWebSrvClassId;    //类Id
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrPrjId;    //工程Id
protected string mstrFunctionName;    //功能名称
protected string mstrFunctionSignature;    //函数签名
protected bool mbolIsAsyncFunc;    //是否异步函数
protected bool mbolIsGeneCode;    //是否生成代码
protected string mstrDataTypeId;    //数据类型Id
protected string mstrDataTypeName;    //数据类型名称
protected string mstrDataCnName;    //数据类型中文名称
protected string mstrCsType;    //CS类型
protected string mstrJavaType;    //JAVA类型
protected string mstrJavaObjType;    //JAVA对象类型
protected string mstrSwiftType;    //SwiftType
protected bool mbolIsNeedQuote;    //是否需要引号
protected string mstrOraDbType;    //Ora数据类型
protected string mstrMySqlType;    //MySqlType
protected string mstrParameterType;    //参数类型
protected string mstrParameterTypeFullName;    //参数类型全名
protected bool mbolIsByRef;    //是否引用型参数
protected string mstrParaName;    //参数名
protected string mstrParaCnName;    //参数中文名
protected bool mbolIsKnownType;    //是否已知类型
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvWebSrvFuncParaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvFuncParaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strWebSrvFuncParaId">关键字:函数参数Id</param>
public clsvWebSrvFuncParaEN(string strWebSrvFuncParaId)
 {
strWebSrvFuncParaId = strWebSrvFuncParaId.Replace("'", "''");
if (strWebSrvFuncParaId.Length > 8)
{
throw new Exception("在表:vWebSrvFuncPara中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWebSrvFuncParaId)  ==  true)
{
throw new Exception("在表:vWebSrvFuncPara中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWebSrvFuncParaId = strWebSrvFuncParaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WebSrvFuncParaId");
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
if (strAttributeName  ==  convWebSrvFuncPara.WebSrvFuncParaId)
{
return mstrWebSrvFuncParaId;
}
else if (strAttributeName  ==  convWebSrvFuncPara.WebSrvFunctionId)
{
return mstrWebSrvFunctionId;
}
else if (strAttributeName  ==  convWebSrvFuncPara.WebSrvClassId)
{
return mstrWebSrvClassId;
}
else if (strAttributeName  ==  convWebSrvFuncPara.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convWebSrvFuncPara.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convWebSrvFuncPara.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  convWebSrvFuncPara.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsAsyncFunc)
{
return mbolIsAsyncFunc;
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  convWebSrvFuncPara.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convWebSrvFuncPara.DataTypeName)
{
return mstrDataTypeName;
}
else if (strAttributeName  ==  convWebSrvFuncPara.DataCnName)
{
return mstrDataCnName;
}
else if (strAttributeName  ==  convWebSrvFuncPara.CsType)
{
return mstrCsType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.JavaType)
{
return mstrJavaType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.JavaObjType)
{
return mstrJavaObjType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.SwiftType)
{
return mstrSwiftType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsNeedQuote)
{
return mbolIsNeedQuote;
}
else if (strAttributeName  ==  convWebSrvFuncPara.OraDbType)
{
return mstrOraDbType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.MySqlType)
{
return mstrMySqlType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParameterType)
{
return mstrParameterType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParameterTypeFullName)
{
return mstrParameterTypeFullName;
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsByRef)
{
return mbolIsByRef;
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParaName)
{
return mstrParaName;
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParaCnName)
{
return mstrParaCnName;
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsKnownType)
{
return mbolIsKnownType;
}
else if (strAttributeName  ==  convWebSrvFuncPara.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convWebSrvFuncPara.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convWebSrvFuncPara.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convWebSrvFuncPara.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convWebSrvFuncPara.WebSrvFuncParaId)
{
mstrWebSrvFuncParaId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.WebSrvFuncParaId);
}
else if (strAttributeName  ==  convWebSrvFuncPara.WebSrvFunctionId)
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.WebSrvFunctionId);
}
else if (strAttributeName  ==  convWebSrvFuncPara.WebSrvClassId)
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.WebSrvClassId);
}
else if (strAttributeName  ==  convWebSrvFuncPara.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.FuncModuleAgcId);
}
else if (strAttributeName  ==  convWebSrvFuncPara.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.PrjId);
}
else if (strAttributeName  ==  convWebSrvFuncPara.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.FunctionName);
}
else if (strAttributeName  ==  convWebSrvFuncPara.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.FunctionSignature);
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsAsyncFunc)
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsAsyncFunc);
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsGeneCode);
}
else if (strAttributeName  ==  convWebSrvFuncPara.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.DataTypeId);
}
else if (strAttributeName  ==  convWebSrvFuncPara.DataTypeName)
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.DataTypeName);
}
else if (strAttributeName  ==  convWebSrvFuncPara.DataCnName)
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.DataCnName);
}
else if (strAttributeName  ==  convWebSrvFuncPara.CsType)
{
mstrCsType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.CsType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.JavaType)
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.JavaType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.JavaObjType)
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.JavaObjType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.SwiftType)
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.SwiftType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsNeedQuote)
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsNeedQuote);
}
else if (strAttributeName  ==  convWebSrvFuncPara.OraDbType)
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.OraDbType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.MySqlType)
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.MySqlType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParameterType)
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParameterType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParameterTypeFullName)
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParameterTypeFullName);
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsByRef)
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsByRef);
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParaName)
{
mstrParaName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParaName);
}
else if (strAttributeName  ==  convWebSrvFuncPara.ParaCnName)
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParaCnName);
}
else if (strAttributeName  ==  convWebSrvFuncPara.IsKnownType)
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsKnownType);
}
else if (strAttributeName  ==  convWebSrvFuncPara.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.UpdDate);
}
else if (strAttributeName  ==  convWebSrvFuncPara.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.UpdUser);
}
else if (strAttributeName  ==  convWebSrvFuncPara.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.Memo);
}
else if (strAttributeName  ==  convWebSrvFuncPara.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convWebSrvFuncPara.WebSrvFuncParaId  ==  _AttributeName[intIndex])
{
return mstrWebSrvFuncParaId;
}
else if (convWebSrvFuncPara.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
return mstrWebSrvFunctionId;
}
else if (convWebSrvFuncPara.WebSrvClassId  ==  _AttributeName[intIndex])
{
return mstrWebSrvClassId;
}
else if (convWebSrvFuncPara.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convWebSrvFuncPara.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convWebSrvFuncPara.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (convWebSrvFuncPara.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convWebSrvFuncPara.IsAsyncFunc  ==  _AttributeName[intIndex])
{
return mbolIsAsyncFunc;
}
else if (convWebSrvFuncPara.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (convWebSrvFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convWebSrvFuncPara.DataTypeName  ==  _AttributeName[intIndex])
{
return mstrDataTypeName;
}
else if (convWebSrvFuncPara.DataCnName  ==  _AttributeName[intIndex])
{
return mstrDataCnName;
}
else if (convWebSrvFuncPara.CsType  ==  _AttributeName[intIndex])
{
return mstrCsType;
}
else if (convWebSrvFuncPara.JavaType  ==  _AttributeName[intIndex])
{
return mstrJavaType;
}
else if (convWebSrvFuncPara.JavaObjType  ==  _AttributeName[intIndex])
{
return mstrJavaObjType;
}
else if (convWebSrvFuncPara.SwiftType  ==  _AttributeName[intIndex])
{
return mstrSwiftType;
}
else if (convWebSrvFuncPara.IsNeedQuote  ==  _AttributeName[intIndex])
{
return mbolIsNeedQuote;
}
else if (convWebSrvFuncPara.OraDbType  ==  _AttributeName[intIndex])
{
return mstrOraDbType;
}
else if (convWebSrvFuncPara.MySqlType  ==  _AttributeName[intIndex])
{
return mstrMySqlType;
}
else if (convWebSrvFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
return mstrParameterType;
}
else if (convWebSrvFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
return mstrParameterTypeFullName;
}
else if (convWebSrvFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
return mbolIsByRef;
}
else if (convWebSrvFuncPara.ParaName  ==  _AttributeName[intIndex])
{
return mstrParaName;
}
else if (convWebSrvFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
return mstrParaCnName;
}
else if (convWebSrvFuncPara.IsKnownType  ==  _AttributeName[intIndex])
{
return mbolIsKnownType;
}
else if (convWebSrvFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convWebSrvFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convWebSrvFuncPara.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convWebSrvFuncPara.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convWebSrvFuncPara.WebSrvFuncParaId  ==  _AttributeName[intIndex])
{
mstrWebSrvFuncParaId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.WebSrvFuncParaId);
}
else if (convWebSrvFuncPara.WebSrvFunctionId  ==  _AttributeName[intIndex])
{
mstrWebSrvFunctionId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.WebSrvFunctionId);
}
else if (convWebSrvFuncPara.WebSrvClassId  ==  _AttributeName[intIndex])
{
mstrWebSrvClassId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.WebSrvClassId);
}
else if (convWebSrvFuncPara.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.FuncModuleAgcId);
}
else if (convWebSrvFuncPara.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.PrjId);
}
else if (convWebSrvFuncPara.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.FunctionName);
}
else if (convWebSrvFuncPara.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.FunctionSignature);
}
else if (convWebSrvFuncPara.IsAsyncFunc  ==  _AttributeName[intIndex])
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsAsyncFunc);
}
else if (convWebSrvFuncPara.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsGeneCode);
}
else if (convWebSrvFuncPara.DataTypeId  ==  _AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.DataTypeId);
}
else if (convWebSrvFuncPara.DataTypeName  ==  _AttributeName[intIndex])
{
mstrDataTypeName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.DataTypeName);
}
else if (convWebSrvFuncPara.DataCnName  ==  _AttributeName[intIndex])
{
mstrDataCnName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.DataCnName);
}
else if (convWebSrvFuncPara.CsType  ==  _AttributeName[intIndex])
{
mstrCsType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.CsType);
}
else if (convWebSrvFuncPara.JavaType  ==  _AttributeName[intIndex])
{
mstrJavaType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.JavaType);
}
else if (convWebSrvFuncPara.JavaObjType  ==  _AttributeName[intIndex])
{
mstrJavaObjType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.JavaObjType);
}
else if (convWebSrvFuncPara.SwiftType  ==  _AttributeName[intIndex])
{
mstrSwiftType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.SwiftType);
}
else if (convWebSrvFuncPara.IsNeedQuote  ==  _AttributeName[intIndex])
{
mbolIsNeedQuote = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsNeedQuote);
}
else if (convWebSrvFuncPara.OraDbType  ==  _AttributeName[intIndex])
{
mstrOraDbType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.OraDbType);
}
else if (convWebSrvFuncPara.MySqlType  ==  _AttributeName[intIndex])
{
mstrMySqlType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.MySqlType);
}
else if (convWebSrvFuncPara.ParameterType  ==  _AttributeName[intIndex])
{
mstrParameterType = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParameterType);
}
else if (convWebSrvFuncPara.ParameterTypeFullName  ==  _AttributeName[intIndex])
{
mstrParameterTypeFullName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParameterTypeFullName);
}
else if (convWebSrvFuncPara.IsByRef  ==  _AttributeName[intIndex])
{
mbolIsByRef = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsByRef);
}
else if (convWebSrvFuncPara.ParaName  ==  _AttributeName[intIndex])
{
mstrParaName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParaName);
}
else if (convWebSrvFuncPara.ParaCnName  ==  _AttributeName[intIndex])
{
mstrParaCnName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ParaCnName);
}
else if (convWebSrvFuncPara.IsKnownType  ==  _AttributeName[intIndex])
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(convWebSrvFuncPara.IsKnownType);
}
else if (convWebSrvFuncPara.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.UpdDate);
}
else if (convWebSrvFuncPara.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.UpdUser);
}
else if (convWebSrvFuncPara.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.Memo);
}
else if (convWebSrvFuncPara.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convWebSrvFuncPara.ClsName);
}
}
}

/// <summary>
/// 函数参数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSrvFuncParaId
{
get
{
return mstrWebSrvFuncParaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSrvFuncParaId = value;
}
else
{
 mstrWebSrvFuncParaId = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.WebSrvFuncParaId);
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
 AddUpdatedFld(convWebSrvFuncPara.WebSrvFunctionId);
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
 AddUpdatedFld(convWebSrvFuncPara.WebSrvClassId);
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
 AddUpdatedFld(convWebSrvFuncPara.FuncModuleAgcId);
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
 AddUpdatedFld(convWebSrvFuncPara.PrjId);
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
 AddUpdatedFld(convWebSrvFuncPara.FunctionName);
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
 AddUpdatedFld(convWebSrvFuncPara.FunctionSignature);
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
 AddUpdatedFld(convWebSrvFuncPara.IsAsyncFunc);
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
 AddUpdatedFld(convWebSrvFuncPara.IsGeneCode);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.DataTypeId);
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
 AddUpdatedFld(convWebSrvFuncPara.DataTypeName);
}
}
/// <summary>
/// 数据类型中文名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataCnName
{
get
{
return mstrDataCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataCnName = value;
}
else
{
 mstrDataCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.DataCnName);
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
 AddUpdatedFld(convWebSrvFuncPara.CsType);
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
 AddUpdatedFld(convWebSrvFuncPara.JavaType);
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
 AddUpdatedFld(convWebSrvFuncPara.JavaObjType);
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
 AddUpdatedFld(convWebSrvFuncPara.SwiftType);
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
 AddUpdatedFld(convWebSrvFuncPara.IsNeedQuote);
}
}
/// <summary>
/// Ora数据类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OraDbType
{
get
{
return mstrOraDbType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOraDbType = value;
}
else
{
 mstrOraDbType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.OraDbType);
}
}
/// <summary>
/// MySqlType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MySqlType
{
get
{
return mstrMySqlType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMySqlType = value;
}
else
{
 mstrMySqlType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.MySqlType);
}
}
/// <summary>
/// 参数类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParameterType
{
get
{
return mstrParameterType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParameterType = value;
}
else
{
 mstrParameterType = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.ParameterType);
}
}
/// <summary>
/// 参数类型全名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParameterTypeFullName
{
get
{
return mstrParameterTypeFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParameterTypeFullName = value;
}
else
{
 mstrParameterTypeFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.ParameterTypeFullName);
}
}
/// <summary>
/// 是否引用型参数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsByRef
{
get
{
return mbolIsByRef;
}
set
{
 mbolIsByRef = value;
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.IsByRef);
}
}
/// <summary>
/// 参数名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaName
{
get
{
return mstrParaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaName = value;
}
else
{
 mstrParaName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.ParaName);
}
}
/// <summary>
/// 参数中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaCnName
{
get
{
return mstrParaCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaCnName = value;
}
else
{
 mstrParaCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convWebSrvFuncPara.ParaCnName);
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
 AddUpdatedFld(convWebSrvFuncPara.IsKnownType);
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
 AddUpdatedFld(convWebSrvFuncPara.UpdDate);
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
 AddUpdatedFld(convWebSrvFuncPara.UpdUser);
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
 AddUpdatedFld(convWebSrvFuncPara.Memo);
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
 AddUpdatedFld(convWebSrvFuncPara.ClsName);
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
  return mstrWebSrvFuncParaId;
 }
 }
}
 /// <summary>
 /// vWebSrv函数参数(vWebSrvFuncPara)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convWebSrvFuncPara
{
public const string _CurrTabName = "vWebSrvFuncPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WebSrvFuncParaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"WebSrvFuncParaId", "WebSrvFunctionId", "WebSrvClassId", "FuncModuleAgcId", "PrjId", "FunctionName", "FunctionSignature", "IsAsyncFunc", "IsGeneCode", "DataTypeId", "DataTypeName", "DataCnName", "CsType", "JavaType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "MySqlType", "ParameterType", "ParameterTypeFullName", "IsByRef", "ParaName", "ParaCnName", "IsKnownType", "UpdDate", "UpdUser", "Memo", "ClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"WebSrvFuncParaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSrvFuncParaId = "WebSrvFuncParaId";    //函数参数Id

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
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"IsAsyncFunc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAsyncFunc = "IsAsyncFunc";    //是否异步函数

 /// <summary>
 /// 常量:"IsGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneCode = "IsGeneCode";    //是否生成代码

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"DataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeName = "DataTypeName";    //数据类型名称

 /// <summary>
 /// 常量:"DataCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataCnName = "DataCnName";    //数据类型中文名称

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
 /// 常量:"OraDbType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OraDbType = "OraDbType";    //Ora数据类型

 /// <summary>
 /// 常量:"MySqlType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MySqlType = "MySqlType";    //MySqlType

 /// <summary>
 /// 常量:"ParameterType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterType = "ParameterType";    //参数类型

 /// <summary>
 /// 常量:"ParameterTypeFullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParameterTypeFullName = "ParameterTypeFullName";    //参数类型全名

 /// <summary>
 /// 常量:"IsByRef"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsByRef = "IsByRef";    //是否引用型参数

 /// <summary>
 /// 常量:"ParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaName = "ParaName";    //参数名

 /// <summary>
 /// 常量:"ParaCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaCnName = "ParaCnName";    //参数中文名

 /// <summary>
 /// 常量:"IsKnownType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsKnownType = "IsKnownType";    //是否已知类型

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