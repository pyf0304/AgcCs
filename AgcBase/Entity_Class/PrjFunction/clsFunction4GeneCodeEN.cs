
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4GeneCodeEN
 表名:Function4GeneCode(00050311)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:44
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
 /// 表Function4GeneCode的关键字(FuncId4GC)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncId4GC_Function4GeneCode
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
public K_FuncId4GC_Function4GeneCode(string strFuncId4GC)
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
 /// <returns>返回:[K_FuncId4GC_Function4GeneCode]类型的对象</returns>
public static implicit operator K_FuncId4GC_Function4GeneCode(string value)
{
return new K_FuncId4GC_Function4GeneCode(value);
}
}
 /// <summary>
 /// 函数4GeneCode(Function4GeneCode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunction4GeneCodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Function4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 29;
public static string[] _AttributeName = new string[] {"FuncId4GC", "FuncName", "FuncId4Code", "FuncName4GC", "FuncCHName4GC", "FeatureId", "ProgLangTypeId", "FuncCodeTypeId", "SqlDsTypeId", "FuncGCTypeId", "PrjId", "ReturnTypeId", "FuncTypeId", "IsTemplate", "FunctionSignature", "FuncCode", "UserId", "OrderNum", "InUse", "PrimaryTypeIds", "CodeText", "UsedTimes", "UpdDate", "UpdUser", "Memo", "ParsedWords", "ParsedWordsExcluded", "WordVector", "IsFuncTemplate"};

protected string mstrFuncId4GC;    //函数ID
protected string mstrFuncName;    //函数名
protected string mstrFuncId4Code;    //函数Id4Code
protected string mstrFuncName4GC;    //函数名4生成代码
protected string mstrFuncCHName4GC;    //函数中文名4生成代码
protected string mstrFeatureId;    //功能Id
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrFuncCodeTypeId;    //函数代码类型Id
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrFuncGCTypeId;    //函数生成代码类型Id
protected string mstrPrjId;    //工程Id
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrFuncTypeId;    //函数类型Id
protected bool mbolIsTemplate;    //是否模板
protected string mstrFunctionSignature;    //函数签名
protected string mstrFuncCode;    //函数代码
protected string mstrUserId;    //用户Id
protected int mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrPrimaryTypeIds;    //主键类型s
protected string mstrCodeText;    //代码文本
protected int? mintUsedTimes;    //使用次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrParsedWords;    //分析的词
protected string mstrParsedWordsExcluded;    //剔除后的词组
protected string mstrWordVector;    //词向量
protected bool mbolIsFuncTemplate;    //是否函数模板

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFunction4GeneCodeEN()
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
public clsFunction4GeneCodeEN(string strFuncId4GC)
 {
strFuncId4GC = strFuncId4GC.Replace("'", "''");
if (strFuncId4GC.Length > 10)
{
throw new Exception("在表:Function4GeneCode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncId4GC)  ==  true)
{
throw new Exception("在表:Function4GeneCode中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conFunction4GeneCode.FuncId4GC)
{
return mstrFuncId4GC;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncName)
{
return mstrFuncName;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncId4Code)
{
return mstrFuncId4Code;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncName4GC)
{
return mstrFuncName4GC;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncCHName4GC)
{
return mstrFuncCHName4GC;
}
else if (strAttributeName  ==  conFunction4GeneCode.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  conFunction4GeneCode.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncCodeTypeId)
{
return mstrFuncCodeTypeId;
}
else if (strAttributeName  ==  conFunction4GeneCode.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncGCTypeId)
{
return mstrFuncGCTypeId;
}
else if (strAttributeName  ==  conFunction4GeneCode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFunction4GeneCode.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncTypeId)
{
return mstrFuncTypeId;
}
else if (strAttributeName  ==  conFunction4GeneCode.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conFunction4GeneCode.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncCode)
{
return mstrFuncCode;
}
else if (strAttributeName  ==  conFunction4GeneCode.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conFunction4GeneCode.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conFunction4GeneCode.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conFunction4GeneCode.PrimaryTypeIds)
{
return mstrPrimaryTypeIds;
}
else if (strAttributeName  ==  conFunction4GeneCode.CodeText)
{
return mstrCodeText;
}
else if (strAttributeName  ==  conFunction4GeneCode.UsedTimes)
{
return mintUsedTimes;
}
else if (strAttributeName  ==  conFunction4GeneCode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunction4GeneCode.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFunction4GeneCode.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conFunction4GeneCode.ParsedWords)
{
return mstrParsedWords;
}
else if (strAttributeName  ==  conFunction4GeneCode.ParsedWordsExcluded)
{
return mstrParsedWordsExcluded;
}
else if (strAttributeName  ==  conFunction4GeneCode.WordVector)
{
return mstrWordVector;
}
else if (strAttributeName  ==  conFunction4GeneCode.IsFuncTemplate)
{
return mbolIsFuncTemplate;
}
return null;
}
set
{
if (strAttributeName  ==  conFunction4GeneCode.FuncId4GC)
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncId4GC);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncName)
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncName);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncId4Code)
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncId4Code);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncName4GC)
{
mstrFuncName4GC = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncName4GC);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncCHName4GC)
{
mstrFuncCHName4GC = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncCHName4GC);
}
else if (strAttributeName  ==  conFunction4GeneCode.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FeatureId);
}
else if (strAttributeName  ==  conFunction4GeneCode.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ProgLangTypeId);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncCodeTypeId)
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncCodeTypeId);
}
else if (strAttributeName  ==  conFunction4GeneCode.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.SqlDsTypeId);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncGCTypeId)
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncGCTypeId);
}
else if (strAttributeName  ==  conFunction4GeneCode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.PrjId);
}
else if (strAttributeName  ==  conFunction4GeneCode.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ReturnTypeId);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncTypeId)
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncTypeId);
}
else if (strAttributeName  ==  conFunction4GeneCode.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.IsTemplate);
}
else if (strAttributeName  ==  conFunction4GeneCode.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FunctionSignature);
}
else if (strAttributeName  ==  conFunction4GeneCode.FuncCode)
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncCode);
}
else if (strAttributeName  ==  conFunction4GeneCode.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.UserId);
}
else if (strAttributeName  ==  conFunction4GeneCode.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.OrderNum);
}
else if (strAttributeName  ==  conFunction4GeneCode.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.InUse);
}
else if (strAttributeName  ==  conFunction4GeneCode.PrimaryTypeIds)
{
mstrPrimaryTypeIds = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.PrimaryTypeIds);
}
else if (strAttributeName  ==  conFunction4GeneCode.CodeText)
{
mstrCodeText = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.CodeText);
}
else if (strAttributeName  ==  conFunction4GeneCode.UsedTimes)
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.UsedTimes);
}
else if (strAttributeName  ==  conFunction4GeneCode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.UpdDate);
}
else if (strAttributeName  ==  conFunction4GeneCode.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.UpdUser);
}
else if (strAttributeName  ==  conFunction4GeneCode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.Memo);
}
else if (strAttributeName  ==  conFunction4GeneCode.ParsedWords)
{
mstrParsedWords = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ParsedWords);
}
else if (strAttributeName  ==  conFunction4GeneCode.ParsedWordsExcluded)
{
mstrParsedWordsExcluded = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ParsedWordsExcluded);
}
else if (strAttributeName  ==  conFunction4GeneCode.WordVector)
{
mstrWordVector = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.WordVector);
}
else if (strAttributeName  ==  conFunction4GeneCode.IsFuncTemplate)
{
mbolIsFuncTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.IsFuncTemplate);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunction4GeneCode.FuncId4GC  ==  _AttributeName[intIndex])
{
return mstrFuncId4GC;
}
else if (conFunction4GeneCode.FuncName  ==  _AttributeName[intIndex])
{
return mstrFuncName;
}
else if (conFunction4GeneCode.FuncId4Code  ==  _AttributeName[intIndex])
{
return mstrFuncId4Code;
}
else if (conFunction4GeneCode.FuncName4GC  ==  _AttributeName[intIndex])
{
return mstrFuncName4GC;
}
else if (conFunction4GeneCode.FuncCHName4GC  ==  _AttributeName[intIndex])
{
return mstrFuncCHName4GC;
}
else if (conFunction4GeneCode.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (conFunction4GeneCode.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (conFunction4GeneCode.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncCodeTypeId;
}
else if (conFunction4GeneCode.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (conFunction4GeneCode.FuncGCTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncGCTypeId;
}
else if (conFunction4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFunction4GeneCode.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (conFunction4GeneCode.FuncTypeId  ==  _AttributeName[intIndex])
{
return mstrFuncTypeId;
}
else if (conFunction4GeneCode.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conFunction4GeneCode.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (conFunction4GeneCode.FuncCode  ==  _AttributeName[intIndex])
{
return mstrFuncCode;
}
else if (conFunction4GeneCode.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conFunction4GeneCode.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conFunction4GeneCode.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conFunction4GeneCode.PrimaryTypeIds  ==  _AttributeName[intIndex])
{
return mstrPrimaryTypeIds;
}
else if (conFunction4GeneCode.CodeText  ==  _AttributeName[intIndex])
{
return mstrCodeText;
}
else if (conFunction4GeneCode.UsedTimes  ==  _AttributeName[intIndex])
{
return mintUsedTimes;
}
else if (conFunction4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunction4GeneCode.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFunction4GeneCode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conFunction4GeneCode.ParsedWords  ==  _AttributeName[intIndex])
{
return mstrParsedWords;
}
else if (conFunction4GeneCode.ParsedWordsExcluded  ==  _AttributeName[intIndex])
{
return mstrParsedWordsExcluded;
}
else if (conFunction4GeneCode.WordVector  ==  _AttributeName[intIndex])
{
return mstrWordVector;
}
else if (conFunction4GeneCode.IsFuncTemplate  ==  _AttributeName[intIndex])
{
return mbolIsFuncTemplate;
}
return null;
}
set
{
if (conFunction4GeneCode.FuncId4GC  ==  _AttributeName[intIndex])
{
mstrFuncId4GC = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncId4GC);
}
else if (conFunction4GeneCode.FuncName  ==  _AttributeName[intIndex])
{
mstrFuncName = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncName);
}
else if (conFunction4GeneCode.FuncId4Code  ==  _AttributeName[intIndex])
{
mstrFuncId4Code = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncId4Code);
}
else if (conFunction4GeneCode.FuncName4GC  ==  _AttributeName[intIndex])
{
mstrFuncName4GC = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncName4GC);
}
else if (conFunction4GeneCode.FuncCHName4GC  ==  _AttributeName[intIndex])
{
mstrFuncCHName4GC = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncCHName4GC);
}
else if (conFunction4GeneCode.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FeatureId);
}
else if (conFunction4GeneCode.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ProgLangTypeId);
}
else if (conFunction4GeneCode.FuncCodeTypeId  ==  _AttributeName[intIndex])
{
mstrFuncCodeTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncCodeTypeId);
}
else if (conFunction4GeneCode.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.SqlDsTypeId);
}
else if (conFunction4GeneCode.FuncGCTypeId  ==  _AttributeName[intIndex])
{
mstrFuncGCTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncGCTypeId);
}
else if (conFunction4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.PrjId);
}
else if (conFunction4GeneCode.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ReturnTypeId);
}
else if (conFunction4GeneCode.FuncTypeId  ==  _AttributeName[intIndex])
{
mstrFuncTypeId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncTypeId);
}
else if (conFunction4GeneCode.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.IsTemplate);
}
else if (conFunction4GeneCode.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FunctionSignature);
}
else if (conFunction4GeneCode.FuncCode  ==  _AttributeName[intIndex])
{
mstrFuncCode = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.FuncCode);
}
else if (conFunction4GeneCode.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.UserId);
}
else if (conFunction4GeneCode.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.OrderNum);
}
else if (conFunction4GeneCode.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.InUse);
}
else if (conFunction4GeneCode.PrimaryTypeIds  ==  _AttributeName[intIndex])
{
mstrPrimaryTypeIds = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.PrimaryTypeIds);
}
else if (conFunction4GeneCode.CodeText  ==  _AttributeName[intIndex])
{
mstrCodeText = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.CodeText);
}
else if (conFunction4GeneCode.UsedTimes  ==  _AttributeName[intIndex])
{
mintUsedTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.UsedTimes);
}
else if (conFunction4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.UpdDate);
}
else if (conFunction4GeneCode.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.UpdUser);
}
else if (conFunction4GeneCode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.Memo);
}
else if (conFunction4GeneCode.ParsedWords  ==  _AttributeName[intIndex])
{
mstrParsedWords = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ParsedWords);
}
else if (conFunction4GeneCode.ParsedWordsExcluded  ==  _AttributeName[intIndex])
{
mstrParsedWordsExcluded = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.ParsedWordsExcluded);
}
else if (conFunction4GeneCode.WordVector  ==  _AttributeName[intIndex])
{
mstrWordVector = value.ToString();
 AddUpdatedFld(conFunction4GeneCode.WordVector);
}
else if (conFunction4GeneCode.IsFuncTemplate  ==  _AttributeName[intIndex])
{
mbolIsFuncTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunction4GeneCode.IsFuncTemplate);
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
 AddUpdatedFld(conFunction4GeneCode.FuncId4GC);
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
 AddUpdatedFld(conFunction4GeneCode.FuncName);
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
 AddUpdatedFld(conFunction4GeneCode.FuncId4Code);
}
}
/// <summary>
/// 函数名4生成代码(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncName4GC
{
get
{
return mstrFuncName4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncName4GC = value;
}
else
{
 mstrFuncName4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4GeneCode.FuncName4GC);
}
}
/// <summary>
/// 函数中文名4生成代码(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncCHName4GC
{
get
{
return mstrFuncCHName4GC;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncCHName4GC = value;
}
else
{
 mstrFuncCHName4GC = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4GeneCode.FuncCHName4GC);
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
 AddUpdatedFld(conFunction4GeneCode.FeatureId);
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
 AddUpdatedFld(conFunction4GeneCode.ProgLangTypeId);
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
 AddUpdatedFld(conFunction4GeneCode.FuncCodeTypeId);
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
 AddUpdatedFld(conFunction4GeneCode.SqlDsTypeId);
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
 AddUpdatedFld(conFunction4GeneCode.FuncGCTypeId);
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
 AddUpdatedFld(conFunction4GeneCode.PrjId);
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
 AddUpdatedFld(conFunction4GeneCode.ReturnTypeId);
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
 AddUpdatedFld(conFunction4GeneCode.FuncTypeId);
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
 AddUpdatedFld(conFunction4GeneCode.IsTemplate);
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
 AddUpdatedFld(conFunction4GeneCode.FunctionSignature);
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
 AddUpdatedFld(conFunction4GeneCode.FuncCode);
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
 AddUpdatedFld(conFunction4GeneCode.UserId);
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
 AddUpdatedFld(conFunction4GeneCode.OrderNum);
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
 AddUpdatedFld(conFunction4GeneCode.InUse);
}
}
/// <summary>
/// 主键类型s(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeIds
{
get
{
return mstrPrimaryTypeIds;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeIds = value;
}
else
{
 mstrPrimaryTypeIds = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunction4GeneCode.PrimaryTypeIds);
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
 AddUpdatedFld(conFunction4GeneCode.CodeText);
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
 AddUpdatedFld(conFunction4GeneCode.UsedTimes);
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
 AddUpdatedFld(conFunction4GeneCode.UpdDate);
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
 AddUpdatedFld(conFunction4GeneCode.UpdUser);
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
 AddUpdatedFld(conFunction4GeneCode.Memo);
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
 AddUpdatedFld(conFunction4GeneCode.ParsedWords);
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
 AddUpdatedFld(conFunction4GeneCode.ParsedWordsExcluded);
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
 AddUpdatedFld(conFunction4GeneCode.WordVector);
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
 AddUpdatedFld(conFunction4GeneCode.IsFuncTemplate);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrFuncName;
 }
 }
}
 /// <summary>
 /// 函数4GeneCode(Function4GeneCode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunction4GeneCode
{
public const string _CurrTabName = "Function4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncId4GC"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FuncId4GC", "FuncName", "FuncId4Code", "FuncName4GC", "FuncCHName4GC", "FeatureId", "ProgLangTypeId", "FuncCodeTypeId", "SqlDsTypeId", "FuncGCTypeId", "PrjId", "ReturnTypeId", "FuncTypeId", "IsTemplate", "FunctionSignature", "FuncCode", "UserId", "OrderNum", "InUse", "PrimaryTypeIds", "CodeText", "UsedTimes", "UpdDate", "UpdUser", "Memo", "ParsedWords", "ParsedWordsExcluded", "WordVector", "IsFuncTemplate"};
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
 /// 常量:"FuncName4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncName4GC = "FuncName4GC";    //函数名4生成代码

 /// <summary>
 /// 常量:"FuncCHName4GC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCHName4GC = "FuncCHName4GC";    //函数中文名4生成代码

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"FuncCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCodeTypeId = "FuncCodeTypeId";    //函数代码类型Id

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"FuncGCTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncGCTypeId = "FuncGCTypeId";    //函数生成代码类型Id

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
 /// 常量:"PrimaryTypeIds"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeIds = "PrimaryTypeIds";    //主键类型s

 /// <summary>
 /// 常量:"CodeText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeText = "CodeText";    //代码文本

 /// <summary>
 /// 常量:"UsedTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UsedTimes = "UsedTimes";    //使用次数

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
}

}