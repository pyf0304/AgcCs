
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4CodeEN
 表名:Function4Code(00050386)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:48
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
 /// 表Function4Code的关键字(FuncId4Code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId4Code_Function4Code
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncId4Code">表关键字</param>
public K_FuncId4Code_Function4Code(string strFuncId4Code)
{
if (IsValid(strFuncId4Code)) Value = strFuncId4Code;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return false;
if (strFuncId4Code.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncId4Code_Function4Code]类型的对象</returns>
public static implicit operator K_FuncId4Code_Function4Code(string value)
{
return new K_FuncId4Code_Function4Code(value);
}
}
 /// <summary>
 /// 函数4Code(Function4Code)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunction4CodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Function4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 31;
public static string[] _AttributeName = new string[] {"FuncId4Code", "FuncName4Code", "FuncCHName4Code", "PrevFuncId", "RootFuncId", "ApplicationTypeId", "FuncGCTypeId", "FunctionSignature", "FunctionSignatureSim", "ReturnType", "ClsName", "ReturnTypeFullName", "ReturnTypeId", "ReturnTypeNameCustom", "CodeTypeId", "FuncAccessModeId", "TabName", "TabId", "FuncPurposeId", "FuncTypeId", "GetCustomAttributes", "SourceFunction", "IsAsyncFunc", "IsSysFunction", "OrderNum", "PrjId", "IsTemplate", "UpdDate", "UpdUser", "Memo", "UsedTimes"};

protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFuncCHName4Code;    //函数中文名4Code
protected string mstrPrevFuncId;    //前函数Id
protected string mstrRootFuncId;    //根函数Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrFuncGCTypeId;    //函数生成代码类型Id
protected string mstrFunctionSignature;    //函数签名
protected string mstrFunctionSignatureSim;    //函数签名_Sim
protected string mstrReturnType;    //返回类型
protected string mstrClsName;    //类名
protected string mstrReturnTypeFullName;    //返回类型全名
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrReturnTypeNameCustom;    //定制返回类型名
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrFuncAccessModeId;    //函数操作模式Id
protected string mstrTabName;    //表名
protected string mstrTabId;    //表ID
protected string mstrFuncPurposeId;    //函数用途Id
protected string mstrFuncTypeId;    //函数类型Id
protected int mintGetCustomAttributes;    //GetCustomAttributes
protected string mstrSourceFunction;    //来源函数
protected bool mbolIsAsyncFunc;    //是否异步函数
protected bool mbolIsSysFunction;    //是否系统函数
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected bool mbolIsTemplate;    //是否模板
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintUsedTimes;    //使用次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunction4CodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4Code");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncId4Code">关键字:函数Id4Code</param>
public clsFunction4CodeEN(string strFuncId4Code)
 {
strFuncId4Code = strFuncId4Code.Replace("'", "''");
if (strFuncId4Code.Length > 8)
{
throw new Exception("在表:Function4Code中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId4Code)  ==  true)
{
throw new Exception("在表:Function4Code中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4Code);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncId4Code = strFuncId4Code;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4Code");
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
if (strAttributeName  ==  conFunction4Code.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  conFunction4Code.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  conFunction4Code.FuncCHName4Code)
{
return mstrFuncCHName4Code;
}
else if (strAttributeName  ==  conFunction4Code.PrevFuncId)
{
return mstrPrevFuncId;
}
else if (strAttributeName  ==  conFunction4Code.RootFuncId)
{
return mstrRootFuncId;
}
else if (strAttributeName  ==  conFunction4Code.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conFunction4Code.FuncGCTypeId)
{
return mstrFuncGCTypeId;
}
else if (strAttributeName  ==  conFunction4Code.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  conFunction4Code.FunctionSignatureSim)
{
return mstrFunctionSignatureSim;
}
else if (strAttributeName  ==  conFunction4Code.ReturnType)
{
return mstrReturnType;
}
else if (strAttributeName  ==  conFunction4Code.ClsName)
{
return mstrClsName;
}
else if (strAttributeName  ==  conFunction4Code.ReturnTypeFullName)
{
return mstrReturnTypeFullName;
}
else if (strAttributeName  ==  conFunction4Code.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  conFunction4Code.ReturnTypeNameCustom)
{
return mstrReturnTypeNameCustom;
}
else if (strAttributeName  ==  conFunction4Code.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conFunction4Code.FuncAccessModeId)
{
return mstrFuncAccessModeId;
}
else if (strAttributeName  ==  conFunction4Code.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conFunction4Code.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conFunction4Code.FuncPurposeId)
{
return mstrFuncPurposeId;
}
else if (strAttributeName  ==  conFunction4Code.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  conFunction4Code.GetCustomAttributes)
{
return mintGetCustomAttributes;
}
else if (strAttributeName  ==  conFunction4Code.SourceFunction)
{
return mstrSourceFunction;
}
else if (strAttributeName  ==  conFunction4Code.IsAsyncFunc)
{
return mbolIsAsyncFunc;
}
else if (strAttributeName  ==  conFunction4Code.IsSysFunction)
{
return mbolIsSysFunction;
}
else if (strAttributeName  ==  conFunction4Code.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conFunction4Code.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFunction4Code.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conFunction4Code.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunction4Code.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunction4Code.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conFunction4Code.UsedTimes)
{
return mintUsedTimes;
}
return null;
}
set
{
if (strAttributeName  ==  conFunction4Code.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncId4Code);
}
else if (strAttributeName  ==  conFunction4Code.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncName4Code);
}
else if (strAttributeName  ==  conFunction4Code.FuncCHName4Code)
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncCHName4Code);
}
else if (strAttributeName  ==  conFunction4Code.PrevFuncId)
{
mstrPrevFuncId = value.ToString();
 AddUpdatedFld(conFunction4Code.PrevFuncId);
}
else if (strAttributeName  ==  conFunction4Code.RootFuncId)
{
mstrRootFuncId = value.ToString();
 AddUpdatedFld(conFunction4Code.RootFuncId);
}
else if (strAttributeName  ==  conFunction4Code.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.ApplicationTypeId);
}
else if (strAttributeName  ==  conFunction4Code.FuncGCTypeId)
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncGCTypeId);
}
else if (strAttributeName  ==  conFunction4Code.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conFunction4Code.FunctionSignature);
}
else if (strAttributeName  ==  conFunction4Code.FunctionSignatureSim)
{
mstrFunctionSignatureSim = value.ToString();
 AddUpdatedFld(conFunction4Code.FunctionSignatureSim);
}
else if (strAttributeName  ==  conFunction4Code.ReturnType)
{
mstrReturnType = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnType);
}
else if (strAttributeName  ==  conFunction4Code.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(conFunction4Code.ClsName);
}
else if (strAttributeName  ==  conFunction4Code.ReturnTypeFullName)
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnTypeFullName);
}
else if (strAttributeName  ==  conFunction4Code.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnTypeId);
}
else if (strAttributeName  ==  conFunction4Code.ReturnTypeNameCustom)
{
mstrReturnTypeNameCustom = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnTypeNameCustom);
}
else if (strAttributeName  ==  conFunction4Code.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.CodeTypeId);
}
else if (strAttributeName  ==  conFunction4Code.FuncAccessModeId)
{
mstrFuncAccessModeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncAccessModeId);
}
else if (strAttributeName  ==  conFunction4Code.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conFunction4Code.TabName);
}
else if (strAttributeName  ==  conFunction4Code.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conFunction4Code.TabId);
}
else if (strAttributeName  ==  conFunction4Code.FuncPurposeId)
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncPurposeId);
}
else if (strAttributeName  ==  conFunction4Code.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncTypeId);
}
else if (strAttributeName  ==  conFunction4Code.GetCustomAttributes)
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.GetCustomAttributes);
}
else if (strAttributeName  ==  conFunction4Code.SourceFunction)
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(conFunction4Code.SourceFunction);
}
else if (strAttributeName  ==  conFunction4Code.IsAsyncFunc)
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4Code.IsAsyncFunc);
}
else if (strAttributeName  ==  conFunction4Code.IsSysFunction)
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4Code.IsSysFunction);
}
else if (strAttributeName  ==  conFunction4Code.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.OrderNum);
}
else if (strAttributeName  ==  conFunction4Code.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFunction4Code.PrjId);
}
else if (strAttributeName  ==  conFunction4Code.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4Code.IsTemplate);
}
else if (strAttributeName  ==  conFunction4Code.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunction4Code.UpdDate);
}
else if (strAttributeName  ==  conFunction4Code.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunction4Code.UpdUser);
}
else if (strAttributeName  ==  conFunction4Code.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunction4Code.Memo);
}
else if (strAttributeName  ==  conFunction4Code.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.UsedTimes);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunction4Code.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (conFunction4Code.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (conFunction4Code.FuncCHName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncCHName4Code;
}
else if (conFunction4Code.PrevFuncId  ==  _AttributeName[intIndex])
{
return mstrPrevFuncId;
}
else if (conFunction4Code.RootFuncId  ==  _AttributeName[intIndex])
{
return mstrRootFuncId;
}
else if (conFunction4Code.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conFunction4Code.FuncGCTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeId;
}
else if (conFunction4Code.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (conFunction4Code.FunctionSignatureSim  ==  _AttributeName[intIndex])
{
return mstrFunctionSignatureSim;
}
else if (conFunction4Code.ReturnType  ==  _AttributeName[intIndex])
{
return mstrReturnType;
}
else if (conFunction4Code.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
else if (conFunction4Code.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
return mstrReturnTypeFullName;
}
else if (conFunction4Code.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (conFunction4Code.ReturnTypeNameCustom  ==  _AttributeName[intIndex])
{
return mstrReturnTypeNameCustom;
}
else if (conFunction4Code.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conFunction4Code.FuncAccessModeId  ==  _AttributeName[intIndex])
{
return mstrFuncAccessModeId;
}
else if (conFunction4Code.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (conFunction4Code.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conFunction4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeId;
}
else if (conFunction4Code.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (conFunction4Code.GetCustomAttributes  ==  _AttributeName[intIndex])
{
return mintGetCustomAttributes;
}
else if (conFunction4Code.SourceFunction  ==  _AttributeName[intIndex])
{
return mstrSourceFunction;
}
else if (conFunction4Code.IsAsyncFunc  ==  _AttributeName[intIndex])
{
return mbolIsAsyncFunc;
}
else if (conFunction4Code.IsSysFunction  ==  _AttributeName[intIndex])
{
return mbolIsSysFunction;
}
else if (conFunction4Code.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conFunction4Code.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFunction4Code.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conFunction4Code.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunction4Code.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunction4Code.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conFunction4Code.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
return null;
}
set
{
if (conFunction4Code.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncId4Code);
}
else if (conFunction4Code.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncName4Code);
}
else if (conFunction4Code.FuncCHName4Code  ==  _AttributeName[intIndex])
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncCHName4Code);
}
else if (conFunction4Code.PrevFuncId  ==  _AttributeName[intIndex])
{
mstrPrevFuncId = value.ToString();
 AddUpdatedFld(conFunction4Code.PrevFuncId);
}
else if (conFunction4Code.RootFuncId  ==  _AttributeName[intIndex])
{
mstrRootFuncId = value.ToString();
 AddUpdatedFld(conFunction4Code.RootFuncId);
}
else if (conFunction4Code.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.ApplicationTypeId);
}
else if (conFunction4Code.FuncGCTypeId  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncGCTypeId);
}
else if (conFunction4Code.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conFunction4Code.FunctionSignature);
}
else if (conFunction4Code.FunctionSignatureSim  ==  _AttributeName[intIndex])
{
mstrFunctionSignatureSim = value.ToString();
 AddUpdatedFld(conFunction4Code.FunctionSignatureSim);
}
else if (conFunction4Code.ReturnType  ==  _AttributeName[intIndex])
{
mstrReturnType = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnType);
}
else if (conFunction4Code.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(conFunction4Code.ClsName);
}
else if (conFunction4Code.ReturnTypeFullName  ==  _AttributeName[intIndex])
{
mstrReturnTypeFullName = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnTypeFullName);
}
else if (conFunction4Code.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnTypeId);
}
else if (conFunction4Code.ReturnTypeNameCustom  ==  _AttributeName[intIndex])
{
mstrReturnTypeNameCustom = value.ToString();
 AddUpdatedFld(conFunction4Code.ReturnTypeNameCustom);
}
else if (conFunction4Code.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.CodeTypeId);
}
else if (conFunction4Code.FuncAccessModeId  ==  _AttributeName[intIndex])
{
mstrFuncAccessModeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncAccessModeId);
}
else if (conFunction4Code.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conFunction4Code.TabName);
}
else if (conFunction4Code.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conFunction4Code.TabId);
}
else if (conFunction4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncPurposeId);
}
else if (conFunction4Code.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conFunction4Code.FuncTypeId);
}
else if (conFunction4Code.GetCustomAttributes  ==  _AttributeName[intIndex])
{
mintGetCustomAttributes = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.GetCustomAttributes);
}
else if (conFunction4Code.SourceFunction  ==  _AttributeName[intIndex])
{
mstrSourceFunction = value.ToString();
 AddUpdatedFld(conFunction4Code.SourceFunction);
}
else if (conFunction4Code.IsAsyncFunc  ==  _AttributeName[intIndex])
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4Code.IsAsyncFunc);
}
else if (conFunction4Code.IsSysFunction  ==  _AttributeName[intIndex])
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4Code.IsSysFunction);
}
else if (conFunction4Code.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.OrderNum);
}
else if (conFunction4Code.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFunction4Code.PrjId);
}
else if (conFunction4Code.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4Code.IsTemplate);
}
else if (conFunction4Code.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunction4Code.UpdDate);
}
else if (conFunction4Code.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunction4Code.UpdUser);
}
else if (conFunction4Code.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunction4Code.Memo);
}
else if (conFunction4Code.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4Code.UsedTimes);
}
}
}

/// <summary>
/// 函数Id4Code(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4Code
{
get
{
return mstrFuncId4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4Code = value;
}
else
{
 mstrFuncId4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.FuncId4Code);
}
}
/// <summary>
/// 函数名4Code(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4Code
{
get
{
return mstrFuncName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4Code = value;
}
else
{
 mstrFuncName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.FuncName4Code);
}
}
/// <summary>
/// 函数中文名4Code(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCHName4Code
{
get
{
return mstrFuncCHName4Code;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCHName4Code = value;
}
else
{
 mstrFuncCHName4Code = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.FuncCHName4Code);
}
}
/// <summary>
/// 前函数Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrevFuncId
{
get
{
return mstrPrevFuncId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrevFuncId = value;
}
else
{
 mstrPrevFuncId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.PrevFuncId);
}
}
/// <summary>
/// 根函数Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RootFuncId
{
get
{
return mstrRootFuncId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRootFuncId = value;
}
else
{
 mstrRootFuncId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.RootFuncId);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.ApplicationTypeId);
}
}
/// <summary>
/// 函数生成代码类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncGCTypeId
{
get
{
return mstrFuncGCTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncGCTypeId = value;
}
else
{
 mstrFuncGCTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.FuncGCTypeId);
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
 AddUpdatedFld(conFunction4Code.FunctionSignature);
}
}
/// <summary>
/// 函数签名_Sim(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionSignatureSim
{
get
{
return mstrFunctionSignatureSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionSignatureSim = value;
}
else
{
 mstrFunctionSignatureSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.FunctionSignatureSim);
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
 AddUpdatedFld(conFunction4Code.ReturnType);
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
 AddUpdatedFld(conFunction4Code.ClsName);
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
 AddUpdatedFld(conFunction4Code.ReturnTypeFullName);
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
 AddUpdatedFld(conFunction4Code.ReturnTypeId);
}
}
/// <summary>
/// 定制返回类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTypeNameCustom
{
get
{
return mstrReturnTypeNameCustom;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTypeNameCustom = value;
}
else
{
 mstrReturnTypeNameCustom = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.ReturnTypeNameCustom);
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
 AddUpdatedFld(conFunction4Code.CodeTypeId);
}
}
/// <summary>
/// 函数操作模式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAccessModeId
{
get
{
return mstrFuncAccessModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAccessModeId = value;
}
else
{
 mstrFuncAccessModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.FuncAccessModeId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.TabName);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.TabId);
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
 AddUpdatedFld(conFunction4Code.FuncPurposeId);
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
 AddUpdatedFld(conFunction4Code.FuncTypeId);
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
 AddUpdatedFld(conFunction4Code.GetCustomAttributes);
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
 AddUpdatedFld(conFunction4Code.SourceFunction);
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
 AddUpdatedFld(conFunction4Code.IsAsyncFunc);
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
 AddUpdatedFld(conFunction4Code.IsSysFunction);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.OrderNum);
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
 AddUpdatedFld(conFunction4Code.PrjId);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.IsTemplate);
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
 AddUpdatedFld(conFunction4Code.UpdDate);
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
 AddUpdatedFld(conFunction4Code.UpdUser);
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
 AddUpdatedFld(conFunction4Code.Memo);
}
}
/// <summary>
/// 使用次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? UsedTimes
{
get
{
return mintUsedTimes;
}
set
{
 mintUsedTimes = value;
//记录修改过的字段
 AddUpdatedFld(conFunction4Code.UsedTimes);
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
  return mstrFuncId4Code;
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
  return mstrFuncName4Code;
 }
 }
}
 /// <summary>
 /// 函数4Code(Function4Code)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunction4Code
{
public const string _CurrTabName = "Function4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId4Code", "FuncName4Code", "FuncCHName4Code", "PrevFuncId", "RootFuncId", "ApplicationTypeId", "FuncGCTypeId", "FunctionSignature", "FunctionSignatureSim", "ReturnType", "ClsName", "ReturnTypeFullName", "ReturnTypeId", "ReturnTypeNameCustom", "CodeTypeId", "FuncAccessModeId", "TabName", "TabId", "FuncPurposeId", "FuncTypeId", "GetCustomAttributes", "SourceFunction", "IsAsyncFunc", "IsSysFunction", "OrderNum", "PrjId", "IsTemplate", "UpdDate", "UpdUser", "Memo", "UsedTimes"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncId4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4Code = "FuncId4Code";    //函数Id4Code

 /// <summary>
 /// 常量:"FuncName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4Code = "FuncName4Code";    //函数名4Code

 /// <summary>
 /// 常量:"FuncCHName4Code"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCHName4Code = "FuncCHName4Code";    //函数中文名4Code

 /// <summary>
 /// 常量:"PrevFuncId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrevFuncId = "PrevFuncId";    //前函数Id

 /// <summary>
 /// 常量:"RootFuncId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RootFuncId = "RootFuncId";    //根函数Id

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"FuncGCTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeId = "FuncGCTypeId";    //函数生成代码类型Id

 /// <summary>
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"FunctionSignatureSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignatureSim = "FunctionSignatureSim";    //函数签名_Sim

 /// <summary>
 /// 常量:"ReturnType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnType = "ReturnType";    //返回类型

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名

 /// <summary>
 /// 常量:"ReturnTypeFullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeFullName = "ReturnTypeFullName";    //返回类型全名

 /// <summary>
 /// 常量:"ReturnTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeId = "ReturnTypeId";    //返回类型ID

 /// <summary>
 /// 常量:"ReturnTypeNameCustom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeNameCustom = "ReturnTypeNameCustom";    //定制返回类型名

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"FuncAccessModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAccessModeId = "FuncAccessModeId";    //函数操作模式Id

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FuncPurposeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncPurposeId = "FuncPurposeId";    //函数用途Id

 /// <summary>
 /// 常量:"FuncTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncTypeId = "FuncTypeId";    //函数类型Id

 /// <summary>
 /// 常量:"GetCustomAttributes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetCustomAttributes = "GetCustomAttributes";    //GetCustomAttributes

 /// <summary>
 /// 常量:"SourceFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceFunction = "SourceFunction";    //来源函数

 /// <summary>
 /// 常量:"IsAsyncFunc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAsyncFunc = "IsAsyncFunc";    //是否异步函数

 /// <summary>
 /// 常量:"IsSysFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSysFunction = "IsSysFunction";    //是否系统函数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

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
 /// 常量:"UsedTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UsedTimes = "UsedTimes";    //使用次数
}

}