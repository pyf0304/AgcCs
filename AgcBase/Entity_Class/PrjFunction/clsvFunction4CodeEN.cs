
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4CodeEN
 表名:vFunction4Code(00050387)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:27
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
 /// 表vFunction4Code的关键字(FuncId4Code)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId4Code_vFunction4Code
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
public K_FuncId4Code_vFunction4Code(string strFuncId4Code)
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
 /// <returns>返回:[K_FuncId4Code_vFunction4Code]类型的对象</returns>
public static implicit operator K_FuncId4Code_vFunction4Code(string value)
{
return new K_FuncId4Code_vFunction4Code(value);
}
}
 /// <summary>
 /// v函数4Code(vFunction4Code)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunction4CodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunction4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 39;
public static string[] _AttributeName = new string[] {"FuncId4Code", "FuncName4Code", "FuncCHName4Code", "PrevFuncId", "RootFuncId", "ApplicationTypeId", "ApplicationTypeName", "FuncGCTypeId", "FuncGCTypeName", "FuncGCTypeENName", "FunctionSignature", "FunctionSignatureSim", "ReturnType", "ReturnTypeId", "ReturnTypeNameCustom", "CodeTypeId", "CodeTypeName", "ProgLangTypeId", "FuncAccessModeId", "FuncAccessModeName", "TabName", "TabId", "FuncPurposeId", "FuncPurposeName", "FuncTypeId", "FuncTypeName", "IsAsyncFunc", "IsSysFunction", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo", "ReturnTypeName", "TabName2", "Func4GCCount", "ParaNum", "FeatureCount", "ClsName"};

protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFuncCHName4Code;    //函数中文名4Code
protected string mstrPrevFuncId;    //前函数Id
protected string mstrRootFuncId;    //根函数Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrFuncGCTypeId;    //函数生成代码类型Id
protected string mstrFuncGCTypeName;    //函数生成代码类型名
protected string mstrFuncGCTypeENName;    //函数生成代码类型英文名
protected string mstrFunctionSignature;    //函数签名
protected string mstrFunctionSignatureSim;    //函数签名_Sim
protected string mstrReturnType;    //返回类型
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrReturnTypeNameCustom;    //定制返回类型名
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrFuncAccessModeId;    //函数操作模式Id
protected string mstrFuncAccessModeName;    //函数操作模式名
protected string mstrTabName;    //表名
protected string mstrTabId;    //表ID
protected string mstrFuncPurposeId;    //函数用途Id
protected string mstrFuncPurposeName;    //函数用途名
protected string mstrFuncTypeId;    //函数类型Id
protected string mstrFuncTypeName;    //函数类型名
protected bool mbolIsAsyncFunc;    //是否异步函数
protected bool mbolIsSysFunction;    //是否系统函数
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrReturnTypeName;    //返回类型名
protected string mstrTabName2;    //TabName2
protected int? mintFunc4GCCount;    //函数4GC数
protected int? mintParaNum;    //参数个数
protected int? mintFeatureCount;    //功能数
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunction4CodeEN()
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
public clsvFunction4CodeEN(string strFuncId4Code)
 {
strFuncId4Code = strFuncId4Code.Replace("'", "''");
if (strFuncId4Code.Length > 8)
{
throw new Exception("在表:vFunction4Code中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId4Code)  ==  true)
{
throw new Exception("在表:vFunction4Code中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convFunction4Code.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFunction4Code.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  convFunction4Code.FuncCHName4Code)
{
return mstrFuncCHName4Code;
}
else if (strAttributeName  ==  convFunction4Code.PrevFuncId)
{
return mstrPrevFuncId;
}
else if (strAttributeName  ==  convFunction4Code.RootFuncId)
{
return mstrRootFuncId;
}
else if (strAttributeName  ==  convFunction4Code.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convFunction4Code.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convFunction4Code.FuncGCTypeId)
{
return mstrFuncGCTypeId;
}
else if (strAttributeName  ==  convFunction4Code.FuncGCTypeName)
{
return mstrFuncGCTypeName;
}
else if (strAttributeName  ==  convFunction4Code.FuncGCTypeENName)
{
return mstrFuncGCTypeENName;
}
else if (strAttributeName  ==  convFunction4Code.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convFunction4Code.FunctionSignatureSim)
{
return mstrFunctionSignatureSim;
}
else if (strAttributeName  ==  convFunction4Code.ReturnType)
{
return mstrReturnType;
}
else if (strAttributeName  ==  convFunction4Code.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  convFunction4Code.ReturnTypeNameCustom)
{
return mstrReturnTypeNameCustom;
}
else if (strAttributeName  ==  convFunction4Code.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convFunction4Code.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convFunction4Code.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convFunction4Code.FuncAccessModeId)
{
return mstrFuncAccessModeId;
}
else if (strAttributeName  ==  convFunction4Code.FuncAccessModeName)
{
return mstrFuncAccessModeName;
}
else if (strAttributeName  ==  convFunction4Code.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convFunction4Code.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convFunction4Code.FuncPurposeId)
{
return mstrFuncPurposeId;
}
else if (strAttributeName  ==  convFunction4Code.FuncPurposeName)
{
return mstrFuncPurposeName;
}
else if (strAttributeName  ==  convFunction4Code.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  convFunction4Code.FuncTypeName)
{
return mstrFuncTypeName;
}
else if (strAttributeName  ==  convFunction4Code.IsAsyncFunc)
{
return mbolIsAsyncFunc;
}
else if (strAttributeName  ==  convFunction4Code.IsSysFunction)
{
return mbolIsSysFunction;
}
else if (strAttributeName  ==  convFunction4Code.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFunction4Code.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFunction4Code.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunction4Code.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunction4Code.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFunction4Code.ReturnTypeName)
{
return mstrReturnTypeName;
}
else if (strAttributeName  ==  convFunction4Code.TabName2)
{
return mstrTabName2;
}
else if (strAttributeName  ==  convFunction4Code.Func4GCCount)
{
return mintFunc4GCCount;
}
else if (strAttributeName  ==  convFunction4Code.ParaNum)
{
return mintParaNum;
}
else if (strAttributeName  ==  convFunction4Code.FeatureCount)
{
return mintFeatureCount;
}
else if (strAttributeName  ==  convFunction4Code.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convFunction4Code.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncId4Code);
}
else if (strAttributeName  ==  convFunction4Code.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncName4Code);
}
else if (strAttributeName  ==  convFunction4Code.FuncCHName4Code)
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncCHName4Code);
}
else if (strAttributeName  ==  convFunction4Code.PrevFuncId)
{
mstrPrevFuncId = value.ToString();
 AddUpdatedFld(convFunction4Code.PrevFuncId);
}
else if (strAttributeName  ==  convFunction4Code.RootFuncId)
{
mstrRootFuncId = value.ToString();
 AddUpdatedFld(convFunction4Code.RootFuncId);
}
else if (strAttributeName  ==  convFunction4Code.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.ApplicationTypeId);
}
else if (strAttributeName  ==  convFunction4Code.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.ApplicationTypeName);
}
else if (strAttributeName  ==  convFunction4Code.FuncGCTypeId)
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncGCTypeId);
}
else if (strAttributeName  ==  convFunction4Code.FuncGCTypeName)
{
mstrFuncGCTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncGCTypeName);
}
else if (strAttributeName  ==  convFunction4Code.FuncGCTypeENName)
{
mstrFuncGCTypeENName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncGCTypeENName);
}
else if (strAttributeName  ==  convFunction4Code.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFunction4Code.FunctionSignature);
}
else if (strAttributeName  ==  convFunction4Code.FunctionSignatureSim)
{
mstrFunctionSignatureSim = value.ToString();
 AddUpdatedFld(convFunction4Code.FunctionSignatureSim);
}
else if (strAttributeName  ==  convFunction4Code.ReturnType)
{
mstrReturnType = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnType);
}
else if (strAttributeName  ==  convFunction4Code.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnTypeId);
}
else if (strAttributeName  ==  convFunction4Code.ReturnTypeNameCustom)
{
mstrReturnTypeNameCustom = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnTypeNameCustom);
}
else if (strAttributeName  ==  convFunction4Code.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.CodeTypeId);
}
else if (strAttributeName  ==  convFunction4Code.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.CodeTypeName);
}
else if (strAttributeName  ==  convFunction4Code.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.ProgLangTypeId);
}
else if (strAttributeName  ==  convFunction4Code.FuncAccessModeId)
{
mstrFuncAccessModeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncAccessModeId);
}
else if (strAttributeName  ==  convFunction4Code.FuncAccessModeName)
{
mstrFuncAccessModeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncAccessModeName);
}
else if (strAttributeName  ==  convFunction4Code.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFunction4Code.TabName);
}
else if (strAttributeName  ==  convFunction4Code.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convFunction4Code.TabId);
}
else if (strAttributeName  ==  convFunction4Code.FuncPurposeId)
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncPurposeId);
}
else if (strAttributeName  ==  convFunction4Code.FuncPurposeName)
{
mstrFuncPurposeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncPurposeName);
}
else if (strAttributeName  ==  convFunction4Code.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncTypeId);
}
else if (strAttributeName  ==  convFunction4Code.FuncTypeName)
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncTypeName);
}
else if (strAttributeName  ==  convFunction4Code.IsAsyncFunc)
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4Code.IsAsyncFunc);
}
else if (strAttributeName  ==  convFunction4Code.IsSysFunction)
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4Code.IsSysFunction);
}
else if (strAttributeName  ==  convFunction4Code.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.OrderNum);
}
else if (strAttributeName  ==  convFunction4Code.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFunction4Code.PrjId);
}
else if (strAttributeName  ==  convFunction4Code.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunction4Code.UpdDate);
}
else if (strAttributeName  ==  convFunction4Code.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunction4Code.UpdUser);
}
else if (strAttributeName  ==  convFunction4Code.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunction4Code.Memo);
}
else if (strAttributeName  ==  convFunction4Code.ReturnTypeName)
{
mstrReturnTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnTypeName);
}
else if (strAttributeName  ==  convFunction4Code.TabName2)
{
mstrTabName2 = value.ToString();
 AddUpdatedFld(convFunction4Code.TabName2);
}
else if (strAttributeName  ==  convFunction4Code.Func4GCCount)
{
mintFunc4GCCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.Func4GCCount);
}
else if (strAttributeName  ==  convFunction4Code.ParaNum)
{
mintParaNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.ParaNum);
}
else if (strAttributeName  ==  convFunction4Code.FeatureCount)
{
mintFeatureCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.FeatureCount);
}
else if (strAttributeName  ==  convFunction4Code.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convFunction4Code.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunction4Code.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFunction4Code.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (convFunction4Code.FuncCHName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncCHName4Code;
}
else if (convFunction4Code.PrevFuncId  ==  _AttributeName[intIndex])
{
return mstrPrevFuncId;
}
else if (convFunction4Code.RootFuncId  ==  _AttributeName[intIndex])
{
return mstrRootFuncId;
}
else if (convFunction4Code.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convFunction4Code.ApplicationTypeName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convFunction4Code.FuncGCTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeId;
}
else if (convFunction4Code.FuncGCTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeName;
}
else if (convFunction4Code.FuncGCTypeENName  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeENName;
}
else if (convFunction4Code.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convFunction4Code.FunctionSignatureSim  ==  _AttributeName[intIndex])
{
return mstrFunctionSignatureSim;
}
else if (convFunction4Code.ReturnType  ==  _AttributeName[intIndex])
{
return mstrReturnType;
}
else if (convFunction4Code.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (convFunction4Code.ReturnTypeNameCustom  ==  _AttributeName[intIndex])
{
return mstrReturnTypeNameCustom;
}
else if (convFunction4Code.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convFunction4Code.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convFunction4Code.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convFunction4Code.FuncAccessModeId  ==  _AttributeName[intIndex])
{
return mstrFuncAccessModeId;
}
else if (convFunction4Code.FuncAccessModeName  ==  _AttributeName[intIndex])
{
return mstrFuncAccessModeName;
}
else if (convFunction4Code.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convFunction4Code.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convFunction4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeId;
}
else if (convFunction4Code.FuncPurposeName  ==  _AttributeName[intIndex])
{
return mstrFuncPurposeName;
}
else if (convFunction4Code.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (convFunction4Code.FuncTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncTypeName;
}
else if (convFunction4Code.IsAsyncFunc  ==  _AttributeName[intIndex])
{
return mbolIsAsyncFunc;
}
else if (convFunction4Code.IsSysFunction  ==  _AttributeName[intIndex])
{
return mbolIsSysFunction;
}
else if (convFunction4Code.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFunction4Code.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFunction4Code.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunction4Code.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunction4Code.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFunction4Code.ReturnTypeName  ==  _AttributeName[intIndex])
{
return mstrReturnTypeName;
}
else if (convFunction4Code.TabName2  ==  _AttributeName[intIndex])
{
return mstrTabName2;
}
else if (convFunction4Code.Func4GCCount  ==  _AttributeName[intIndex])
{
return mintFunc4GCCount;
}
else if (convFunction4Code.ParaNum  ==  _AttributeName[intIndex])
{
return mintParaNum;
}
else if (convFunction4Code.FeatureCount  ==  _AttributeName[intIndex])
{
return mintFeatureCount;
}
else if (convFunction4Code.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convFunction4Code.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncId4Code);
}
else if (convFunction4Code.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncName4Code);
}
else if (convFunction4Code.FuncCHName4Code  ==  _AttributeName[intIndex])
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncCHName4Code);
}
else if (convFunction4Code.PrevFuncId  ==  _AttributeName[intIndex])
{
mstrPrevFuncId = value.ToString();
 AddUpdatedFld(convFunction4Code.PrevFuncId);
}
else if (convFunction4Code.RootFuncId  ==  _AttributeName[intIndex])
{
mstrRootFuncId = value.ToString();
 AddUpdatedFld(convFunction4Code.RootFuncId);
}
else if (convFunction4Code.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.ApplicationTypeId);
}
else if (convFunction4Code.ApplicationTypeName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.ApplicationTypeName);
}
else if (convFunction4Code.FuncGCTypeId  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncGCTypeId);
}
else if (convFunction4Code.FuncGCTypeName  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncGCTypeName);
}
else if (convFunction4Code.FuncGCTypeENName  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeENName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncGCTypeENName);
}
else if (convFunction4Code.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFunction4Code.FunctionSignature);
}
else if (convFunction4Code.FunctionSignatureSim  ==  _AttributeName[intIndex])
{
mstrFunctionSignatureSim = value.ToString();
 AddUpdatedFld(convFunction4Code.FunctionSignatureSim);
}
else if (convFunction4Code.ReturnType  ==  _AttributeName[intIndex])
{
mstrReturnType = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnType);
}
else if (convFunction4Code.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnTypeId);
}
else if (convFunction4Code.ReturnTypeNameCustom  ==  _AttributeName[intIndex])
{
mstrReturnTypeNameCustom = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnTypeNameCustom);
}
else if (convFunction4Code.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.CodeTypeId);
}
else if (convFunction4Code.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.CodeTypeName);
}
else if (convFunction4Code.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.ProgLangTypeId);
}
else if (convFunction4Code.FuncAccessModeId  ==  _AttributeName[intIndex])
{
mstrFuncAccessModeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncAccessModeId);
}
else if (convFunction4Code.FuncAccessModeName  ==  _AttributeName[intIndex])
{
mstrFuncAccessModeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncAccessModeName);
}
else if (convFunction4Code.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFunction4Code.TabName);
}
else if (convFunction4Code.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convFunction4Code.TabId);
}
else if (convFunction4Code.FuncPurposeId  ==  _AttributeName[intIndex])
{
mstrFuncPurposeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncPurposeId);
}
else if (convFunction4Code.FuncPurposeName  ==  _AttributeName[intIndex])
{
mstrFuncPurposeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncPurposeName);
}
else if (convFunction4Code.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncTypeId);
}
else if (convFunction4Code.FuncTypeName  ==  _AttributeName[intIndex])
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.FuncTypeName);
}
else if (convFunction4Code.IsAsyncFunc  ==  _AttributeName[intIndex])
{
mbolIsAsyncFunc = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4Code.IsAsyncFunc);
}
else if (convFunction4Code.IsSysFunction  ==  _AttributeName[intIndex])
{
mbolIsSysFunction = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4Code.IsSysFunction);
}
else if (convFunction4Code.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.OrderNum);
}
else if (convFunction4Code.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFunction4Code.PrjId);
}
else if (convFunction4Code.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunction4Code.UpdDate);
}
else if (convFunction4Code.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunction4Code.UpdUser);
}
else if (convFunction4Code.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunction4Code.Memo);
}
else if (convFunction4Code.ReturnTypeName  ==  _AttributeName[intIndex])
{
mstrReturnTypeName = value.ToString();
 AddUpdatedFld(convFunction4Code.ReturnTypeName);
}
else if (convFunction4Code.TabName2  ==  _AttributeName[intIndex])
{
mstrTabName2 = value.ToString();
 AddUpdatedFld(convFunction4Code.TabName2);
}
else if (convFunction4Code.Func4GCCount  ==  _AttributeName[intIndex])
{
mintFunc4GCCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.Func4GCCount);
}
else if (convFunction4Code.ParaNum  ==  _AttributeName[intIndex])
{
mintParaNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.ParaNum);
}
else if (convFunction4Code.FeatureCount  ==  _AttributeName[intIndex])
{
mintFeatureCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4Code.FeatureCount);
}
else if (convFunction4Code.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convFunction4Code.ClsName);
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
 AddUpdatedFld(convFunction4Code.FuncId4Code);
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
 AddUpdatedFld(convFunction4Code.FuncName4Code);
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
 AddUpdatedFld(convFunction4Code.FuncCHName4Code);
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
 AddUpdatedFld(convFunction4Code.PrevFuncId);
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
 AddUpdatedFld(convFunction4Code.RootFuncId);
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
 AddUpdatedFld(convFunction4Code.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.ApplicationTypeName);
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
 AddUpdatedFld(convFunction4Code.FuncGCTypeId);
}
}
/// <summary>
/// 函数生成代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncGCTypeName
{
get
{
return mstrFuncGCTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncGCTypeName = value;
}
else
{
 mstrFuncGCTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.FuncGCTypeName);
}
}
/// <summary>
/// 函数生成代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncGCTypeENName
{
get
{
return mstrFuncGCTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncGCTypeENName = value;
}
else
{
 mstrFuncGCTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.FuncGCTypeENName);
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
 AddUpdatedFld(convFunction4Code.FunctionSignature);
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
 AddUpdatedFld(convFunction4Code.FunctionSignatureSim);
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
 AddUpdatedFld(convFunction4Code.ReturnType);
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
 AddUpdatedFld(convFunction4Code.ReturnTypeId);
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
 AddUpdatedFld(convFunction4Code.ReturnTypeNameCustom);
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
 AddUpdatedFld(convFunction4Code.CodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.CodeTypeName);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.ProgLangTypeId);
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
 AddUpdatedFld(convFunction4Code.FuncAccessModeId);
}
}
/// <summary>
/// 函数操作模式名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncAccessModeName
{
get
{
return mstrFuncAccessModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncAccessModeName = value;
}
else
{
 mstrFuncAccessModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.FuncAccessModeName);
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
 AddUpdatedFld(convFunction4Code.TabName);
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
 AddUpdatedFld(convFunction4Code.TabId);
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
 AddUpdatedFld(convFunction4Code.FuncPurposeId);
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
 AddUpdatedFld(convFunction4Code.FuncPurposeName);
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
 AddUpdatedFld(convFunction4Code.FuncTypeId);
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
 AddUpdatedFld(convFunction4Code.FuncTypeName);
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
 AddUpdatedFld(convFunction4Code.IsAsyncFunc);
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
 AddUpdatedFld(convFunction4Code.IsSysFunction);
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
 AddUpdatedFld(convFunction4Code.OrderNum);
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
 AddUpdatedFld(convFunction4Code.PrjId);
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
 AddUpdatedFld(convFunction4Code.UpdDate);
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
 AddUpdatedFld(convFunction4Code.UpdUser);
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
 AddUpdatedFld(convFunction4Code.Memo);
}
}
/// <summary>
/// 返回类型名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReturnTypeName
{
get
{
return mstrReturnTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReturnTypeName = value;
}
else
{
 mstrReturnTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.ReturnTypeName);
}
}
/// <summary>
/// TabName2(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName2
{
get
{
return mstrTabName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName2 = value;
}
else
{
 mstrTabName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.TabName2);
}
}
/// <summary>
/// 函数4GC数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Func4GCCount
{
get
{
return mintFunc4GCCount;
}
set
{
 mintFunc4GCCount = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.Func4GCCount);
}
}
/// <summary>
/// 参数个数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ParaNum
{
get
{
return mintParaNum;
}
set
{
 mintParaNum = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.ParaNum);
}
}
/// <summary>
/// 功能数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FeatureCount
{
get
{
return mintFeatureCount;
}
set
{
 mintFeatureCount = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4Code.FeatureCount);
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
 AddUpdatedFld(convFunction4Code.ClsName);
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
}
 /// <summary>
 /// v函数4Code(vFunction4Code)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunction4Code
{
public const string _CurrTabName = "vFunction4Code"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId4Code"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId4Code", "FuncName4Code", "FuncCHName4Code", "PrevFuncId", "RootFuncId", "ApplicationTypeId", "ApplicationTypeName", "FuncGCTypeId", "FuncGCTypeName", "FuncGCTypeENName", "FunctionSignature", "FunctionSignatureSim", "ReturnType", "ReturnTypeId", "ReturnTypeNameCustom", "CodeTypeId", "CodeTypeName", "ProgLangTypeId", "FuncAccessModeId", "FuncAccessModeName", "TabName", "TabId", "FuncPurposeId", "FuncPurposeName", "FuncTypeId", "FuncTypeName", "IsAsyncFunc", "IsSysFunction", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo", "ReturnTypeName", "TabName2", "Func4GCCount", "ParaNum", "FeatureCount", "ClsName"};
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
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"FuncGCTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeId = "FuncGCTypeId";    //函数生成代码类型Id

 /// <summary>
 /// 常量:"FuncGCTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeName = "FuncGCTypeName";    //函数生成代码类型名

 /// <summary>
 /// 常量:"FuncGCTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeENName = "FuncGCTypeENName";    //函数生成代码类型英文名

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
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"FuncAccessModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAccessModeId = "FuncAccessModeId";    //函数操作模式Id

 /// <summary>
 /// 常量:"FuncAccessModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncAccessModeName = "FuncAccessModeName";    //函数操作模式名

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
 /// 常量:"FuncPurposeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncPurposeName = "FuncPurposeName";    //函数用途名

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
 /// 常量:"ReturnTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeName = "ReturnTypeName";    //返回类型名

 /// <summary>
 /// 常量:"TabName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName2 = "TabName2";    //TabName2

 /// <summary>
 /// 常量:"Func4GCCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Func4GCCount = "Func4GCCount";    //函数4GC数

 /// <summary>
 /// 常量:"ParaNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaNum = "ParaNum";    //参数个数

 /// <summary>
 /// 常量:"FeatureCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureCount = "FeatureCount";    //功能数

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}