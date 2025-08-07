
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionEN
 表名:CMFunction(00050502)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表CMFunction的关键字(CmFunctionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmFunctionId_CMFunction
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmFunctionId">表关键字</param>
public K_CmFunctionId_CMFunction(string strCmFunctionId)
{
if (IsValid(strCmFunctionId)) Value = strCmFunctionId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return false;
if (strCmFunctionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmFunctionId_CMFunction]类型的对象</returns>
public static implicit operator K_CmFunctionId_CMFunction(string value)
{
return new K_CmFunctionId_CMFunction(value);
}
}
 /// <summary>
 /// CM函数(CMFunction)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMFunctionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 30;
public static string[] _AttributeName = new string[] {"CmFunctionId", "CmClassId", "FunctionName", "FuncContent", "KeyWords", "FuncParaLst", "FuncComments", "FunctionSignature", "FuncTypeId", "ReturnType", "ReturnTypeFullName", "IsKnownType", "ReturnTypeId", "IsAsyncFunc", "SourceFunction", "IsGeneCode", "ReturnValueDescription", "IsSysFunction", "GetCustomAttributes", "ClassNameLst", "UpdDate", "UpdUser", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};

protected string mstrCmFunctionId;    //函数Id
protected string mstrCmClassId;    //类Id
protected string mstrFunctionName;    //功能名称
protected string mstrFuncContent;    //函数内容
protected string mstrKeyWords;    //关键字
protected string mstrFuncParaLst;    //函数参数列表
protected string mstrFuncComments;    //函数注释
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
protected bool mbolIsSysFunction;    //是否系统函数
protected int? mintGetCustomAttributes;    //GetCustomAttributes
protected string mstrClassNameLst;    //类名列表
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected bool mbolIsSynchToServer;    //是否同步到Server
protected string mstrSynchToServerDate;    //同步到Server日期
protected string mstrSynchToServerUser;    //同步到Server用户
protected bool mbolIsSynchToClient;    //是否同步到Client
protected string mstrSynchToClientDate;    //同步到Client库日期
protected string mstrSynchToClientUser;    //同步到Client库用户
protected string mstrSynSource;    //同步来源

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMFunctionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFunctionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmFunctionId">关键字:函数Id</param>
public clsCMFunctionEN(string strCmFunctionId)
 {
strCmFunctionId = strCmFunctionId.Replace("'", "''");
if (strCmFunctionId.Length > 8)
{
throw new Exception("在表:CMFunction中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmFunctionId)  ==  true)
{
throw new Exception("在表:CMFunction中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmFunctionId = strCmFunctionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFunctionId");
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
if (strAttributeName  ==  conCMFunction.CmFunctionId)
{
return mstrCmFunctionId;
}
else if (strAttributeName  ==  conCMFunction.CmClassId)
{
return mstrCmClassId;
}
else if (strAttributeName  ==  conCMFunction.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  conCMFunction.FuncContent)
{
return mstrFuncContent;
}
else if (strAttributeName  ==  conCMFunction.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  conCMFunction.FuncParaLst)
{
return mstrFuncParaLst;
}
else if (strAttributeName  ==  conCMFunction.FuncComments)
{
return mstrFuncComments;
}
else if (strAttributeName  ==  conCMFunction.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  conCMFunction.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  conCMFunction.ReturnType)
{
return mstrReturnType;
}
else if (strAttributeName  ==  conCMFunction.ReturnTypeFullName)
{
return mstrReturnTypeFullName;
}
else if (strAttributeName  ==  conCMFunction.IsKnownType)
{
return mbolIsKnownType;
}
else if (strAttributeName  ==  conCMFunction.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  conCMFunction.IsAsyncFunc)
{
return mbolIsAsyncFunc;
}
else if (strAttributeName  ==  conCMFunction.SourceFunction)
{
return mstrSourceFunction;
}
else if (strAttributeName  ==  conCMFunction.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  conCMFunction.ReturnValueDescription)
{
return mstrReturnValueDescription;
}
else if (strAttributeName  ==  conCMFunction.IsSysFunction)
{
return mbolIsSysFunction;
}
else if (strAttributeName  ==  conCMFunction.GetCustomAttributes)
{
return mintGetCustomAttributes;
}
else if (strAttributeName  ==  conCMFunction.ClassNameLst)
{
return mstrClassNameLst;
}
else if (strAttributeName  ==  conCMFunction.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMFunction.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMFunction.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conCMFunction.IsSynchToServer)
{
return mbolIsSynchToServer;
}
else if (strAttributeName  ==  conCMFunction.SynchToServerDate)
{
return mstrSynchToServerDate;
}
else if (strAttributeName  ==  conCMFunction.SynchToServerUser)
{
return mstrSynchToServerUser;
}
else if (strAttributeName  ==  conCMFunction.IsSynchToClient)
{
return mbolIsSynchToClient;
}
else if (strAttributeName  ==  conCMFunction.SynchToClientDate)
{
return mstrSynchToClientDate;
}
else if (strAttributeName  ==  conCMFunction.SynchToClientUser)
{
return mstrSynchToClientUser;
}
else if (strAttributeName  ==  conCMFunction.SynSource)
{
return mstrSynSource;
}
return null;
}
set
{
if (strAttributeName  ==  conCMFunction.CmFunctionId)
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(conCMFunction.CmFunctionId);
}
else if (strAttributeName  ==  conCMFunction.CmClassId)
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(conCMFunction.CmClassId);
}
else if (strAttributeName  ==  conCMFunction.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conCMFunction.FunctionName);
}
else if (strAttributeName  ==  conCMFunction.FuncContent)
{
mstrFuncContent = value.ToString();
 AddUpdatedFld(conCMFunction.FuncContent);
}
else if (strAttributeName  ==  conCMFunction.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(conCMFunction.KeyWords);
}
else if (strAttributeName  ==  conCMFunction.FuncParaLst)
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(conCMFunction.FuncParaLst);
}
else if (strAttributeName  ==  conCMFunction.FuncComments)
{
mstrFuncComments = value.ToString();
 AddUpdatedFld(conCMFunction.FuncComments);
}
else if (strAttributeName  ==  conCMFunction.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conCMFunction.FunctionSignature);
}
else if (strAttributeName  ==  conCMFunction.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conCMFunction.FuncTypeId);
}
else if (strAttributeName  ==  conCMFunction.ReturnType)
{
mstrReturnType = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnType);
}
else if (strAttributeName  ==  conCMFunction.ReturnTypeFullName)
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnTypeFullName);
}
else if (strAttributeName  ==  conCMFunction.IsKnownType)
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsKnownType);
}
else if (strAttributeName  ==  conCMFunction.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnTypeId);
}
else if (strAttributeName  ==  conCMFunction.IsAsyncFunc)
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsAsyncFunc);
}
else if (strAttributeName  ==  conCMFunction.SourceFunction)
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(conCMFunction.SourceFunction);
}
else if (strAttributeName  ==  conCMFunction.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsGeneCode);
}
else if (strAttributeName  ==  conCMFunction.ReturnValueDescription)
{
mstrReturnValueDescription = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnValueDescription);
}
else if (strAttributeName  ==  conCMFunction.IsSysFunction)
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsSysFunction);
}
else if (strAttributeName  ==  conCMFunction.GetCustomAttributes)
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFunction.GetCustomAttributes);
}
else if (strAttributeName  ==  conCMFunction.ClassNameLst)
{
mstrClassNameLst = value.ToString();
 AddUpdatedFld(conCMFunction.ClassNameLst);
}
else if (strAttributeName  ==  conCMFunction.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFunction.UpdDate);
}
else if (strAttributeName  ==  conCMFunction.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFunction.UpdUser);
}
else if (strAttributeName  ==  conCMFunction.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFunction.Memo);
}
else if (strAttributeName  ==  conCMFunction.IsSynchToServer)
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsSynchToServer);
}
else if (strAttributeName  ==  conCMFunction.SynchToServerDate)
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToServerDate);
}
else if (strAttributeName  ==  conCMFunction.SynchToServerUser)
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToServerUser);
}
else if (strAttributeName  ==  conCMFunction.IsSynchToClient)
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsSynchToClient);
}
else if (strAttributeName  ==  conCMFunction.SynchToClientDate)
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToClientDate);
}
else if (strAttributeName  ==  conCMFunction.SynchToClientUser)
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToClientUser);
}
else if (strAttributeName  ==  conCMFunction.SynSource)
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMFunction.SynSource);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMFunction.CmFunctionId  ==  _AttributeName[intIndex])
{
return mstrCmFunctionId;
}
else if (conCMFunction.CmClassId  ==  _AttributeName[intIndex])
{
return mstrCmClassId;
}
else if (conCMFunction.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (conCMFunction.FuncContent  ==  _AttributeName[intIndex])
{
return mstrFuncContent;
}
else if (conCMFunction.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (conCMFunction.FuncParaLst  ==  _AttributeName[intIndex])
{
return mstrFuncParaLst;
}
else if (conCMFunction.FuncComments  ==  _AttributeName[intIndex])
{
return mstrFuncComments;
}
else if (conCMFunction.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (conCMFunction.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (conCMFunction.ReturnType  ==  _AttributeName[intIndex])
{
return mstrReturnType;
}
else if (conCMFunction.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
return mstrReturnTypeFullName;
}
else if (conCMFunction.IsKnownType  ==  _AttributeName[intIndex])
{
return mbolIsKnownType;
}
else if (conCMFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (conCMFunction.IsAsyncFunc  ==  _AttributeName[intIndex])
{
return mbolIsAsyncFunc;
}
else if (conCMFunction.SourceFunction  ==  _AttributeName[intIndex])
{
return mstrSourceFunction;
}
else if (conCMFunction.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (conCMFunction.ReturnValueDescription  ==  _AttributeName[intIndex])
{
return mstrReturnValueDescription;
}
else if (conCMFunction.IsSysFunction  ==  _AttributeName[intIndex])
{
return mbolIsSysFunction;
}
else if (conCMFunction.GetCustomAttributes  ==  _AttributeName[intIndex])
{
return mintGetCustomAttributes;
}
else if (conCMFunction.ClassNameLst  ==  _AttributeName[intIndex])
{
return mstrClassNameLst;
}
else if (conCMFunction.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMFunction.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMFunction.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conCMFunction.IsSynchToServer  ==  _AttributeName[intIndex])
{
return mbolIsSynchToServer;
}
else if (conCMFunction.SynchToServerDate  ==  _AttributeName[intIndex])
{
return mstrSynchToServerDate;
}
else if (conCMFunction.SynchToServerUser  ==  _AttributeName[intIndex])
{
return mstrSynchToServerUser;
}
else if (conCMFunction.IsSynchToClient  ==  _AttributeName[intIndex])
{
return mbolIsSynchToClient;
}
else if (conCMFunction.SynchToClientDate  ==  _AttributeName[intIndex])
{
return mstrSynchToClientDate;
}
else if (conCMFunction.SynchToClientUser  ==  _AttributeName[intIndex])
{
return mstrSynchToClientUser;
}
else if (conCMFunction.SynSource  ==  _AttributeName[intIndex])
{
return mstrSynSource;
}
return null;
}
set
{
if (conCMFunction.CmFunctionId  ==  _AttributeName[intIndex])
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(conCMFunction.CmFunctionId);
}
else if (conCMFunction.CmClassId  ==  _AttributeName[intIndex])
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(conCMFunction.CmClassId);
}
else if (conCMFunction.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conCMFunction.FunctionName);
}
else if (conCMFunction.FuncContent  ==  _AttributeName[intIndex])
{
mstrFuncContent = value.ToString();
 AddUpdatedFld(conCMFunction.FuncContent);
}
else if (conCMFunction.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(conCMFunction.KeyWords);
}
else if (conCMFunction.FuncParaLst  ==  _AttributeName[intIndex])
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(conCMFunction.FuncParaLst);
}
else if (conCMFunction.FuncComments  ==  _AttributeName[intIndex])
{
mstrFuncComments = value.ToString();
 AddUpdatedFld(conCMFunction.FuncComments);
}
else if (conCMFunction.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conCMFunction.FunctionSignature);
}
else if (conCMFunction.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conCMFunction.FuncTypeId);
}
else if (conCMFunction.ReturnType  ==  _AttributeName[intIndex])
{
mstrReturnType = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnType);
}
else if (conCMFunction.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnTypeFullName);
}
else if (conCMFunction.IsKnownType  ==  _AttributeName[intIndex])
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsKnownType);
}
else if (conCMFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnTypeId);
}
else if (conCMFunction.IsAsyncFunc  ==  _AttributeName[intIndex])
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsAsyncFunc);
}
else if (conCMFunction.SourceFunction  ==  _AttributeName[intIndex])
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(conCMFunction.SourceFunction);
}
else if (conCMFunction.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsGeneCode);
}
else if (conCMFunction.ReturnValueDescription  ==  _AttributeName[intIndex])
{
mstrReturnValueDescription = value.ToString();
 AddUpdatedFld(conCMFunction.ReturnValueDescription);
}
else if (conCMFunction.IsSysFunction  ==  _AttributeName[intIndex])
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsSysFunction);
}
else if (conCMFunction.GetCustomAttributes  ==  _AttributeName[intIndex])
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFunction.GetCustomAttributes);
}
else if (conCMFunction.ClassNameLst  ==  _AttributeName[intIndex])
{
mstrClassNameLst = value.ToString();
 AddUpdatedFld(conCMFunction.ClassNameLst);
}
else if (conCMFunction.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFunction.UpdDate);
}
else if (conCMFunction.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFunction.UpdUser);
}
else if (conCMFunction.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFunction.Memo);
}
else if (conCMFunction.IsSynchToServer  ==  _AttributeName[intIndex])
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsSynchToServer);
}
else if (conCMFunction.SynchToServerDate  ==  _AttributeName[intIndex])
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToServerDate);
}
else if (conCMFunction.SynchToServerUser  ==  _AttributeName[intIndex])
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToServerUser);
}
else if (conCMFunction.IsSynchToClient  ==  _AttributeName[intIndex])
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFunction.IsSynchToClient);
}
else if (conCMFunction.SynchToClientDate  ==  _AttributeName[intIndex])
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToClientDate);
}
else if (conCMFunction.SynchToClientUser  ==  _AttributeName[intIndex])
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMFunction.SynchToClientUser);
}
else if (conCMFunction.SynSource  ==  _AttributeName[intIndex])
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMFunction.SynSource);
}
}
}

/// <summary>
/// 函数Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFunctionId
{
get
{
return mstrCmFunctionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFunctionId = value;
}
else
{
 mstrCmFunctionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.CmFunctionId);
}
}
/// <summary>
/// 类Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmClassId
{
get
{
return mstrCmClassId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmClassId = value;
}
else
{
 mstrCmClassId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.CmClassId);
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
 AddUpdatedFld(conCMFunction.FunctionName);
}
}
/// <summary>
/// 函数内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncContent
{
get
{
return mstrFuncContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncContent = value;
}
else
{
 mstrFuncContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.FuncContent);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyWords
{
get
{
return mstrKeyWords;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyWords = value;
}
else
{
 mstrKeyWords = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.KeyWords);
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
 AddUpdatedFld(conCMFunction.FuncParaLst);
}
}
/// <summary>
/// 函数注释(说明:;字段类型:text;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncComments
{
get
{
return mstrFuncComments;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncComments = value;
}
else
{
 mstrFuncComments = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.FuncComments);
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
 AddUpdatedFld(conCMFunction.FunctionSignature);
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
 AddUpdatedFld(conCMFunction.FuncTypeId);
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
 AddUpdatedFld(conCMFunction.ReturnType);
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
 AddUpdatedFld(conCMFunction.ReturnTypeFullName);
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
 AddUpdatedFld(conCMFunction.IsKnownType);
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
 AddUpdatedFld(conCMFunction.ReturnTypeId);
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
 AddUpdatedFld(conCMFunction.IsAsyncFunc);
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
 AddUpdatedFld(conCMFunction.SourceFunction);
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
 AddUpdatedFld(conCMFunction.IsGeneCode);
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
 AddUpdatedFld(conCMFunction.ReturnValueDescription);
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
 AddUpdatedFld(conCMFunction.IsSysFunction);
}
}
/// <summary>
/// GetCustomAttributes(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? GetCustomAttributes
{
get
{
return mintGetCustomAttributes;
}
set
{
 mintGetCustomAttributes = value;
//记录修改过的字段
 AddUpdatedFld(conCMFunction.GetCustomAttributes);
}
}
/// <summary>
/// 类名列表(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassNameLst
{
get
{
return mstrClassNameLst;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassNameLst = value;
}
else
{
 mstrClassNameLst = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.ClassNameLst);
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
 AddUpdatedFld(conCMFunction.UpdDate);
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
 AddUpdatedFld(conCMFunction.UpdUser);
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
 AddUpdatedFld(conCMFunction.Memo);
}
}
/// <summary>
/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToServer
{
get
{
return mbolIsSynchToServer;
}
set
{
 mbolIsSynchToServer = value;
//记录修改过的字段
 AddUpdatedFld(conCMFunction.IsSynchToServer);
}
}
/// <summary>
/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerDate
{
get
{
return mstrSynchToServerDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerDate = value;
}
else
{
 mstrSynchToServerDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.SynchToServerDate);
}
}
/// <summary>
/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerUser
{
get
{
return mstrSynchToServerUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerUser = value;
}
else
{
 mstrSynchToServerUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.SynchToServerUser);
}
}
/// <summary>
/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToClient
{
get
{
return mbolIsSynchToClient;
}
set
{
 mbolIsSynchToClient = value;
//记录修改过的字段
 AddUpdatedFld(conCMFunction.IsSynchToClient);
}
}
/// <summary>
/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientDate
{
get
{
return mstrSynchToClientDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientDate = value;
}
else
{
 mstrSynchToClientDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.SynchToClientDate);
}
}
/// <summary>
/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientUser
{
get
{
return mstrSynchToClientUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientUser = value;
}
else
{
 mstrSynchToClientUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.SynchToClientUser);
}
}
/// <summary>
/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynSource
{
get
{
return mstrSynSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynSource = value;
}
else
{
 mstrSynSource = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFunction.SynSource);
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
  return mstrCmFunctionId;
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
 /// CM函数(CMFunction)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMFunction
{
public const string _CurrTabName = "CMFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmFunctionId", "CmClassId", "FunctionName", "FuncContent", "KeyWords", "FuncParaLst", "FuncComments", "FunctionSignature", "FuncTypeId", "ReturnType", "ReturnTypeFullName", "IsKnownType", "ReturnTypeId", "IsAsyncFunc", "SourceFunction", "IsGeneCode", "ReturnValueDescription", "IsSysFunction", "GetCustomAttributes", "ClassNameLst", "UpdDate", "UpdUser", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmFunctionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFunctionId = "CmFunctionId";    //函数Id

 /// <summary>
 /// 常量:"CmClassId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmClassId = "CmClassId";    //类Id

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //功能名称

 /// <summary>
 /// 常量:"FuncContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncContent = "FuncContent";    //函数内容

 /// <summary>
 /// 常量:"KeyWords"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWords = "KeyWords";    //关键字

 /// <summary>
 /// 常量:"FuncParaLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncParaLst = "FuncParaLst";    //函数参数列表

 /// <summary>
 /// 常量:"FuncComments"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncComments = "FuncComments";    //函数注释

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
 /// 常量:"IsSysFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSysFunction = "IsSysFunction";    //是否系统函数

 /// <summary>
 /// 常量:"GetCustomAttributes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetCustomAttributes = "GetCustomAttributes";    //GetCustomAttributes

 /// <summary>
 /// 常量:"ClassNameLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNameLst = "ClassNameLst";    //类名列表

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
 /// 常量:"IsSynchToServer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToServer = "IsSynchToServer";    //是否同步到Server

 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerDate = "SynchToServerDate";    //同步到Server日期

 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerUser = "SynchToServerUser";    //同步到Server用户

 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToClient = "IsSynchToClient";    //是否同步到Client

 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientDate = "SynchToClientDate";    //同步到Client库日期

 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientUser = "SynchToClientUser";    //同步到Client库用户

 /// <summary>
 /// 常量:"SynSource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynSource = "SynSource";    //同步来源
}

}