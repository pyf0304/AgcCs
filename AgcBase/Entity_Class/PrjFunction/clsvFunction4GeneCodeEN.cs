
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCodeEN
 表名:vFunction4GeneCode(00050315)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:30
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
 /// 表vFunction4GeneCode的关键字(FuncId4GC)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId4GC_vFunction4GeneCode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncId4GC">表关键字</param>
public K_FuncId4GC_vFunction4GeneCode(string strFuncId4GC)
{
if (IsValid(strFuncId4GC)) Value = strFuncId4GC;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return false;
if (strFuncId4GC.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncId4GC_vFunction4GeneCode]类型的对象</returns>
public static implicit operator K_FuncId4GC_vFunction4GeneCode(string value)
{
return new K_FuncId4GC_vFunction4GeneCode(value);
}
}
 /// <summary>
 /// v函数4GeneCode(vFunction4GeneCode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFunction4GeneCodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFunction4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 42;
public static string[] _AttributeName = new string[] {"FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FuncCHName4Code", "FunctionSignatureSim", "FeatureId", "FeatureName", "FeatureDescription", "FeatureTypeName", "ProgLangTypeId", "ProgLangTypeName", "SqlDsTypeId", "SqlDsTypeName", "FuncGCTypeId", "FuncGCTypeName", "FuncGCTypeENName", "PrjId", "ReturnTypeId", "FuncTypeId", "FuncTypeName", "IsTemplate", "FunctionSignature", "FuncCode", "UserId", "OrderNum", "InUse", "CodeText", "UpdDate", "UpdUser", "Memo", "ParsedWords", "ParsedWordsExcluded", "WordVector", "IsFuncTemplate", "ReturnTypeName", "TemplateNum", "Order4FeatureNum", "FuncCodeTypeENName", "FuncCodeTypeId", "FuncCodeTypeName", "ProgLangTypeId4FuncCodeType"};

protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4Code;    //函数名4Code
protected string mstrFuncCHName4Code;    //函数中文名4Code
protected string mstrFunctionSignatureSim;    //函数签名_Sim
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureDescription;    //功能说明
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrFuncGCTypeId;    //函数生成代码类型Id
protected string mstrFuncGCTypeName;    //函数生成代码类型名
protected string mstrFuncGCTypeENName;    //函数生成代码类型英文名
protected string mstrPrjId;    //工程Id
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrFuncTypeId;    //函数类型Id
protected string mstrFuncTypeName;    //函数类型名
protected bool mbolIsTemplate;    //是否模板
protected string mstrFunctionSignature;    //函数签名
protected string mstrFuncCode;    //函数代码
protected string mstrUserId;    //用户Id
protected int mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrCodeText;    //代码文本
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrParsedWords;    //分析的词
protected string mstrParsedWordsExcluded;    //剔除后的词组
protected string mstrWordVector;    //词向量
protected bool mbolIsFuncTemplate;    //是否函数模板
protected string mstrReturnTypeName;    //返回类型名
protected int? mintTemplateNum;    //TemplateNum
protected int? mintOrder4FeatureNum;    //Order4FeatureNum
protected string mstrFuncCodeTypeENName;    //FuncCodeTypeENName
protected string mstrFuncCodeTypeId;    //函数代码类型Id
protected string mstrFuncCodeTypeName;    //FuncCodeTypeName
protected string mstrProgLangTypeId4FuncCodeType;    //ProgLangTypeId4FuncCodeType

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvFunction4GeneCodeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4GC");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncId4GC">关键字:函数ID</param>
public clsvFunction4GeneCodeEN(string strFuncId4GC)
 {
strFuncId4GC = strFuncId4GC.Replace("'", "''");
if (strFuncId4GC.Length > 10)
{
throw new Exception("在表:vFunction4GeneCode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId4GC)  ==  true)
{
throw new Exception("在表:vFunction4GeneCode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4GC);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncId4GC = strFuncId4GC;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncId4GC");
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
if (strAttributeName  ==  convFunction4GeneCode.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncName4Code)
{
return mstrFuncName4Code;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCHName4Code)
{
return mstrFuncCHName4Code;
}
else if (strAttributeName  ==  convFunction4GeneCode.FunctionSignatureSim)
{
return mstrFunctionSignatureSim;
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convFunction4GeneCode.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convFunction4GeneCode.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncGCTypeId)
{
return mstrFuncGCTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncGCTypeName)
{
return mstrFuncGCTypeName;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncGCTypeENName)
{
return mstrFuncGCTypeENName;
}
else if (strAttributeName  ==  convFunction4GeneCode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFunction4GeneCode.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncTypeName)
{
return mstrFuncTypeName;
}
else if (strAttributeName  ==  convFunction4GeneCode.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convFunction4GeneCode.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCode)
{
return mstrFuncCode;
}
else if (strAttributeName  ==  convFunction4GeneCode.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convFunction4GeneCode.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convFunction4GeneCode.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFunction4GeneCode.CodeText)
{
return mstrCodeText;
}
else if (strAttributeName  ==  convFunction4GeneCode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFunction4GeneCode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFunction4GeneCode.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFunction4GeneCode.ParsedWords)
{
return mstrParsedWords;
}
else if (strAttributeName  ==  convFunction4GeneCode.ParsedWordsExcluded)
{
return mstrParsedWordsExcluded;
}
else if (strAttributeName  ==  convFunction4GeneCode.WordVector)
{
return mstrWordVector;
}
else if (strAttributeName  ==  convFunction4GeneCode.IsFuncTemplate)
{
return mbolIsFuncTemplate;
}
else if (strAttributeName  ==  convFunction4GeneCode.ReturnTypeName)
{
return mstrReturnTypeName;
}
else if (strAttributeName  ==  convFunction4GeneCode.TemplateNum)
{
return mintTemplateNum;
}
else if (strAttributeName  ==  convFunction4GeneCode.Order4FeatureNum)
{
return mintOrder4FeatureNum;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCodeTypeENName)
{
return mstrFuncCodeTypeENName;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCodeTypeId)
{
return mstrFuncCodeTypeId;
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCodeTypeName)
{
return mstrFuncCodeTypeName;
}
else if (strAttributeName  ==  convFunction4GeneCode.ProgLangTypeId4FuncCodeType)
{
return mstrProgLangTypeId4FuncCodeType;
}
return null;
}
set
{
if (strAttributeName  ==  convFunction4GeneCode.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncId4GC);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncName);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncId4Code);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncName4Code)
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncName4Code);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCHName4Code)
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCHName4Code);
}
else if (strAttributeName  ==  convFunction4GeneCode.FunctionSignatureSim)
{
mstrFunctionSignatureSim = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FunctionSignatureSim);
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureId);
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureName);
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureDescription);
}
else if (strAttributeName  ==  convFunction4GeneCode.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureTypeName);
}
else if (strAttributeName  ==  convFunction4GeneCode.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeName);
}
else if (strAttributeName  ==  convFunction4GeneCode.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.SqlDsTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.SqlDsTypeName);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncGCTypeId)
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncGCTypeName)
{
mstrFuncGCTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeName);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncGCTypeENName)
{
mstrFuncGCTypeENName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeENName);
}
else if (strAttributeName  ==  convFunction4GeneCode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.PrjId);
}
else if (strAttributeName  ==  convFunction4GeneCode.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ReturnTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncTypeName)
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncTypeName);
}
else if (strAttributeName  ==  convFunction4GeneCode.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.IsTemplate);
}
else if (strAttributeName  ==  convFunction4GeneCode.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FunctionSignature);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCode)
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCode);
}
else if (strAttributeName  ==  convFunction4GeneCode.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.UserId);
}
else if (strAttributeName  ==  convFunction4GeneCode.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.OrderNum);
}
else if (strAttributeName  ==  convFunction4GeneCode.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.InUse);
}
else if (strAttributeName  ==  convFunction4GeneCode.CodeText)
{
mstrCodeText = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.CodeText);
}
else if (strAttributeName  ==  convFunction4GeneCode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.UpdDate);
}
else if (strAttributeName  ==  convFunction4GeneCode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.UpdUser);
}
else if (strAttributeName  ==  convFunction4GeneCode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.Memo);
}
else if (strAttributeName  ==  convFunction4GeneCode.ParsedWords)
{
mstrParsedWords = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ParsedWords);
}
else if (strAttributeName  ==  convFunction4GeneCode.ParsedWordsExcluded)
{
mstrParsedWordsExcluded = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ParsedWordsExcluded);
}
else if (strAttributeName  ==  convFunction4GeneCode.WordVector)
{
mstrWordVector = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.WordVector);
}
else if (strAttributeName  ==  convFunction4GeneCode.IsFuncTemplate)
{
mbolIsFuncTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.IsFuncTemplate);
}
else if (strAttributeName  ==  convFunction4GeneCode.ReturnTypeName)
{
mstrReturnTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ReturnTypeName);
}
else if (strAttributeName  ==  convFunction4GeneCode.TemplateNum)
{
mintTemplateNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.TemplateNum);
}
else if (strAttributeName  ==  convFunction4GeneCode.Order4FeatureNum)
{
mintOrder4FeatureNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.Order4FeatureNum);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCodeTypeENName)
{
mstrFuncCodeTypeENName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeENName);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCodeTypeId)
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeId);
}
else if (strAttributeName  ==  convFunction4GeneCode.FuncCodeTypeName)
{
mstrFuncCodeTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeName);
}
else if (strAttributeName  ==  convFunction4GeneCode.ProgLangTypeId4FuncCodeType)
{
mstrProgLangTypeId4FuncCodeType = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
}
}
}
public object this[int intIndex]
{
get
{
if (convFunction4GeneCode.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (convFunction4GeneCode.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (convFunction4GeneCode.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (convFunction4GeneCode.FuncName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncName4Code;
}
else if (convFunction4GeneCode.FuncCHName4Code  ==  _AttributeName[intIndex])
{
return mstrFuncCHName4Code;
}
else if (convFunction4GeneCode.FunctionSignatureSim  ==  _AttributeName[intIndex])
{
return mstrFunctionSignatureSim;
}
else if (convFunction4GeneCode.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convFunction4GeneCode.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convFunction4GeneCode.FeatureDescription  ==  _AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (convFunction4GeneCode.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convFunction4GeneCode.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convFunction4GeneCode.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convFunction4GeneCode.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convFunction4GeneCode.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convFunction4GeneCode.FuncGCTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeId;
}
else if (convFunction4GeneCode.FuncGCTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeName;
}
else if (convFunction4GeneCode.FuncGCTypeENName  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeENName;
}
else if (convFunction4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFunction4GeneCode.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (convFunction4GeneCode.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (convFunction4GeneCode.FuncTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncTypeName;
}
else if (convFunction4GeneCode.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convFunction4GeneCode.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convFunction4GeneCode.FuncCode  ==  _AttributeName[intIndex])
{
return mstrFuncCode;
}
else if (convFunction4GeneCode.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convFunction4GeneCode.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convFunction4GeneCode.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFunction4GeneCode.CodeText  ==  _AttributeName[intIndex])
{
return mstrCodeText;
}
else if (convFunction4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFunction4GeneCode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFunction4GeneCode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFunction4GeneCode.ParsedWords  ==  _AttributeName[intIndex])
{
return mstrParsedWords;
}
else if (convFunction4GeneCode.ParsedWordsExcluded  ==  _AttributeName[intIndex])
{
return mstrParsedWordsExcluded;
}
else if (convFunction4GeneCode.WordVector  ==  _AttributeName[intIndex])
{
return mstrWordVector;
}
else if (convFunction4GeneCode.IsFuncTemplate  ==  _AttributeName[intIndex])
{
return mbolIsFuncTemplate;
}
else if (convFunction4GeneCode.ReturnTypeName  ==  _AttributeName[intIndex])
{
return mstrReturnTypeName;
}
else if (convFunction4GeneCode.TemplateNum  ==  _AttributeName[intIndex])
{
return mintTemplateNum;
}
else if (convFunction4GeneCode.Order4FeatureNum  ==  _AttributeName[intIndex])
{
return mintOrder4FeatureNum;
}
else if (convFunction4GeneCode.FuncCodeTypeENName  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeENName;
}
else if (convFunction4GeneCode.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeId;
}
else if (convFunction4GeneCode.FuncCodeTypeName  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeName;
}
else if (convFunction4GeneCode.ProgLangTypeId4FuncCodeType  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId4FuncCodeType;
}
return null;
}
set
{
if (convFunction4GeneCode.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncId4GC);
}
else if (convFunction4GeneCode.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncName);
}
else if (convFunction4GeneCode.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncId4Code);
}
else if (convFunction4GeneCode.FuncName4Code  ==  _AttributeName[intIndex])
{
mstrFuncName4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncName4Code);
}
else if (convFunction4GeneCode.FuncCHName4Code  ==  _AttributeName[intIndex])
{
mstrFuncCHName4Code = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCHName4Code);
}
else if (convFunction4GeneCode.FunctionSignatureSim  ==  _AttributeName[intIndex])
{
mstrFunctionSignatureSim = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FunctionSignatureSim);
}
else if (convFunction4GeneCode.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureId);
}
else if (convFunction4GeneCode.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureName);
}
else if (convFunction4GeneCode.FeatureDescription  ==  _AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureDescription);
}
else if (convFunction4GeneCode.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FeatureTypeName);
}
else if (convFunction4GeneCode.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeId);
}
else if (convFunction4GeneCode.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeName);
}
else if (convFunction4GeneCode.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.SqlDsTypeId);
}
else if (convFunction4GeneCode.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.SqlDsTypeName);
}
else if (convFunction4GeneCode.FuncGCTypeId  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeId);
}
else if (convFunction4GeneCode.FuncGCTypeName  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeName);
}
else if (convFunction4GeneCode.FuncGCTypeENName  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeENName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeENName);
}
else if (convFunction4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.PrjId);
}
else if (convFunction4GeneCode.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ReturnTypeId);
}
else if (convFunction4GeneCode.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncTypeId);
}
else if (convFunction4GeneCode.FuncTypeName  ==  _AttributeName[intIndex])
{
mstrFuncTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncTypeName);
}
else if (convFunction4GeneCode.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.IsTemplate);
}
else if (convFunction4GeneCode.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FunctionSignature);
}
else if (convFunction4GeneCode.FuncCode  ==  _AttributeName[intIndex])
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCode);
}
else if (convFunction4GeneCode.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.UserId);
}
else if (convFunction4GeneCode.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.OrderNum);
}
else if (convFunction4GeneCode.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.InUse);
}
else if (convFunction4GeneCode.CodeText  ==  _AttributeName[intIndex])
{
mstrCodeText = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.CodeText);
}
else if (convFunction4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.UpdDate);
}
else if (convFunction4GeneCode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.UpdUser);
}
else if (convFunction4GeneCode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.Memo);
}
else if (convFunction4GeneCode.ParsedWords  ==  _AttributeName[intIndex])
{
mstrParsedWords = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ParsedWords);
}
else if (convFunction4GeneCode.ParsedWordsExcluded  ==  _AttributeName[intIndex])
{
mstrParsedWordsExcluded = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ParsedWordsExcluded);
}
else if (convFunction4GeneCode.WordVector  ==  _AttributeName[intIndex])
{
mstrWordVector = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.WordVector);
}
else if (convFunction4GeneCode.IsFuncTemplate  ==  _AttributeName[intIndex])
{
mbolIsFuncTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.IsFuncTemplate);
}
else if (convFunction4GeneCode.ReturnTypeName  ==  _AttributeName[intIndex])
{
mstrReturnTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ReturnTypeName);
}
else if (convFunction4GeneCode.TemplateNum  ==  _AttributeName[intIndex])
{
mintTemplateNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.TemplateNum);
}
else if (convFunction4GeneCode.Order4FeatureNum  ==  _AttributeName[intIndex])
{
mintOrder4FeatureNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convFunction4GeneCode.Order4FeatureNum);
}
else if (convFunction4GeneCode.FuncCodeTypeENName  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeENName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeENName);
}
else if (convFunction4GeneCode.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeId);
}
else if (convFunction4GeneCode.FuncCodeTypeName  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeName = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeName);
}
else if (convFunction4GeneCode.ProgLangTypeId4FuncCodeType  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId4FuncCodeType = value.ToString();
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
}
}
}

/// <summary>
/// 函数ID(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncId4GC
{
get
{
return mstrFuncId4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncId4GC = value;
}
else
{
 mstrFuncId4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FuncId4GC);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName
{
get
{
return mstrFuncName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName = value;
}
else
{
 mstrFuncName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FuncName);
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
 AddUpdatedFld(convFunction4GeneCode.FuncId4Code);
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
 AddUpdatedFld(convFunction4GeneCode.FuncName4Code);
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
 AddUpdatedFld(convFunction4GeneCode.FuncCHName4Code);
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
 AddUpdatedFld(convFunction4GeneCode.FunctionSignatureSim);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FeatureName);
}
}
/// <summary>
/// 功能说明(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureDescription
{
get
{
return mstrFeatureDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureDescription = value;
}
else
{
 mstrFeatureDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FeatureDescription);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FeatureTypeName);
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
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeName);
}
}
/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.SqlDsTypeId);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.SqlDsTypeName);
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
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeId);
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
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeName);
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
 AddUpdatedFld(convFunction4GeneCode.FuncGCTypeENName);
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
 AddUpdatedFld(convFunction4GeneCode.PrjId);
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
 AddUpdatedFld(convFunction4GeneCode.ReturnTypeId);
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
 AddUpdatedFld(convFunction4GeneCode.FuncTypeId);
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
 AddUpdatedFld(convFunction4GeneCode.FuncTypeName);
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
 AddUpdatedFld(convFunction4GeneCode.IsTemplate);
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
 AddUpdatedFld(convFunction4GeneCode.FunctionSignature);
}
}
/// <summary>
/// 函数代码(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCode
{
get
{
return mstrFuncCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCode = value;
}
else
{
 mstrFuncCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FuncCode);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.UserId);
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
 AddUpdatedFld(convFunction4GeneCode.OrderNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.InUse);
}
}
/// <summary>
/// 代码文本(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeText
{
get
{
return mstrCodeText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeText = value;
}
else
{
 mstrCodeText = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.CodeText);
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
 AddUpdatedFld(convFunction4GeneCode.UpdDate);
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
 AddUpdatedFld(convFunction4GeneCode.UpdUser);
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
 AddUpdatedFld(convFunction4GeneCode.Memo);
}
}
/// <summary>
/// 分析的词(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParsedWords
{
get
{
return mstrParsedWords;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParsedWords = value;
}
else
{
 mstrParsedWords = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.ParsedWords);
}
}
/// <summary>
/// 剔除后的词组(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParsedWordsExcluded
{
get
{
return mstrParsedWordsExcluded;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParsedWordsExcluded = value;
}
else
{
 mstrParsedWordsExcluded = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.ParsedWordsExcluded);
}
}
/// <summary>
/// 词向量(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WordVector
{
get
{
return mstrWordVector;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWordVector = value;
}
else
{
 mstrWordVector = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.WordVector);
}
}
/// <summary>
/// 是否函数模板(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsFuncTemplate
{
get
{
return mbolIsFuncTemplate;
}
set
{
 mbolIsFuncTemplate = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.IsFuncTemplate);
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
 AddUpdatedFld(convFunction4GeneCode.ReturnTypeName);
}
}
/// <summary>
/// TemplateNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TemplateNum
{
get
{
return mintTemplateNum;
}
set
{
 mintTemplateNum = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.TemplateNum);
}
}
/// <summary>
/// Order4FeatureNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Order4FeatureNum
{
get
{
return mintOrder4FeatureNum;
}
set
{
 mintOrder4FeatureNum = value;
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.Order4FeatureNum);
}
}
/// <summary>
/// FuncCodeTypeENName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeENName
{
get
{
return mstrFuncCodeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeENName = value;
}
else
{
 mstrFuncCodeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeENName);
}
}
/// <summary>
/// 函数代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeId
{
get
{
return mstrFuncCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeId = value;
}
else
{
 mstrFuncCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeId);
}
}
/// <summary>
/// FuncCodeTypeName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCodeTypeName
{
get
{
return mstrFuncCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCodeTypeName = value;
}
else
{
 mstrFuncCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.FuncCodeTypeName);
}
}
/// <summary>
/// ProgLangTypeId4FuncCodeType(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId4FuncCodeType
{
get
{
return mstrProgLangTypeId4FuncCodeType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId4FuncCodeType = value;
}
else
{
 mstrProgLangTypeId4FuncCodeType = value;
}
//记录修改过的字段
 AddUpdatedFld(convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
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
  return mstrFuncId4GC;
 }
 }
}
 /// <summary>
 /// v函数4GeneCode(vFunction4GeneCode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFunction4GeneCode
{
public const string _CurrTabName = "vFunction4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId4GC", "FuncName", "FuncId4Code", "FuncName4Code", "FuncCHName4Code", "FunctionSignatureSim", "FeatureId", "FeatureName", "FeatureDescription", "FeatureTypeName", "ProgLangTypeId", "ProgLangTypeName", "SqlDsTypeId", "SqlDsTypeName", "FuncGCTypeId", "FuncGCTypeName", "FuncGCTypeENName", "PrjId", "ReturnTypeId", "FuncTypeId", "FuncTypeName", "IsTemplate", "FunctionSignature", "FuncCode", "UserId", "OrderNum", "InUse", "CodeText", "UpdDate", "UpdUser", "Memo", "ParsedWords", "ParsedWordsExcluded", "WordVector", "IsFuncTemplate", "ReturnTypeName", "TemplateNum", "Order4FeatureNum", "FuncCodeTypeENName", "FuncCodeTypeId", "FuncCodeTypeName", "ProgLangTypeId4FuncCodeType"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncId4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncId4GC = "FuncId4GC";    //函数ID

 /// <summary>
 /// 常量:"FuncName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName = "FuncName";    //函数名

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
 /// 常量:"FunctionSignatureSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignatureSim = "FunctionSignatureSim";    //函数签名_Sim

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"FeatureDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureDescription = "FeatureDescription";    //功能说明

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

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
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"ReturnTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeId = "ReturnTypeId";    //返回类型ID

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
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"FunctionSignature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionSignature = "FunctionSignature";    //函数签名

 /// <summary>
 /// 常量:"FuncCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCode = "FuncCode";    //函数代码

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"CodeText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeText = "CodeText";    //代码文本

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
 /// 常量:"ParsedWords"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParsedWords = "ParsedWords";    //分析的词

 /// <summary>
 /// 常量:"ParsedWordsExcluded"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParsedWordsExcluded = "ParsedWordsExcluded";    //剔除后的词组

 /// <summary>
 /// 常量:"WordVector"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WordVector = "WordVector";    //词向量

 /// <summary>
 /// 常量:"IsFuncTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsFuncTemplate = "IsFuncTemplate";    //是否函数模板

 /// <summary>
 /// 常量:"ReturnTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnTypeName = "ReturnTypeName";    //返回类型名

 /// <summary>
 /// 常量:"TemplateNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TemplateNum = "TemplateNum";    //TemplateNum

 /// <summary>
 /// 常量:"Order4FeatureNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Order4FeatureNum = "Order4FeatureNum";    //Order4FeatureNum

 /// <summary>
 /// 常量:"FuncCodeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeENName = "FuncCodeTypeENName";    //FuncCodeTypeENName

 /// <summary>
 /// 常量:"FuncCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeId = "FuncCodeTypeId";    //函数代码类型Id

 /// <summary>
 /// 常量:"FuncCodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeName = "FuncCodeTypeName";    //FuncCodeTypeName

 /// <summary>
 /// 常量:"ProgLangTypeId4FuncCodeType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId4FuncCodeType = "ProgLangTypeId4FuncCodeType";    //ProgLangTypeId4FuncCodeType
}

}