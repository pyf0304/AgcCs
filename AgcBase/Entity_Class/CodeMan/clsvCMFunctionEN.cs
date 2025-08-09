
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionEN
 表名:vCMFunction(00050507)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vCMFunction的关键字(CmFunctionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmFunctionId_vCMFunction
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
public K_CmFunctionId_vCMFunction(string strCmFunctionId)
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
 /// <returns>返回:[K_CmFunctionId_vCMFunction]类型的对象</returns>
public static implicit operator K_CmFunctionId_vCMFunction(string value)
{
return new K_CmFunctionId_vCMFunction(value);
}
}
 /// <summary>
 /// vCM函数(vCMFunction)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMFunctionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 29;
public static string[] _AttributeName = new string[] {"CmFunctionId", "CmClassId", "ApplicationTypeId", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "NameSpace", "ProjectPath", "FilePath", "FileName", "CodeTypeId", "UserId", "PrjId", "PrjName", "FunctionName", "FuncContent", "KeyWords", "FuncParaLst", "FuncComments", "FunctionSignature", "ReturnType", "IsKnownType", "ReturnTypeId", "ClassNameLst", "UpdDate", "UpdUser", "Memo", "ParaNum", "ClsName"};

protected string mstrCmFunctionId;    //函数Id
protected string mstrCmClassId;    //类Id
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrProgLangTypeSimName;    //编程语言类型简称
protected string mstrNameSpace;    //域名
protected string mstrProjectPath;    //工程路径
protected string mstrFilePath;    //文件路径
protected string mstrFileName;    //文件名
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected string mstrFunctionName;    //功能名称
protected string mstrFuncContent;    //函数内容
protected string mstrKeyWords;    //关键字
protected string mstrFuncParaLst;    //函数参数列表
protected string mstrFuncComments;    //函数注释
protected string mstrFunctionSignature;    //函数签名
protected string mstrReturnType;    //返回类型
protected bool mbolIsKnownType;    //是否已知类型
protected string mstrReturnTypeId;    //返回类型ID
protected string mstrClassNameLst;    //类名列表
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintParaNum;    //参数个数
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMFunctionEN()
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
public clsvCMFunctionEN(string strCmFunctionId)
 {
strCmFunctionId = strCmFunctionId.Replace("'", "''");
if (strCmFunctionId.Length > 8)
{
throw new Exception("在表:vCMFunction中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmFunctionId)  ==  true)
{
throw new Exception("在表:vCMFunction中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convCMFunction.CmFunctionId)
{
return mstrCmFunctionId;
}
else if (strAttributeName  ==  convCMFunction.CmClassId)
{
return mstrCmClassId;
}
else if (strAttributeName  ==  convCMFunction.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convCMFunction.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convCMFunction.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convCMFunction.ProgLangTypeSimName)
{
return mstrProgLangTypeSimName;
}
else if (strAttributeName  ==  convCMFunction.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  convCMFunction.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  convCMFunction.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convCMFunction.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convCMFunction.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convCMFunction.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCMFunction.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMFunction.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCMFunction.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  convCMFunction.FuncContent)
{
return mstrFuncContent;
}
else if (strAttributeName  ==  convCMFunction.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convCMFunction.FuncParaLst)
{
return mstrFuncParaLst;
}
else if (strAttributeName  ==  convCMFunction.FuncComments)
{
return mstrFuncComments;
}
else if (strAttributeName  ==  convCMFunction.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convCMFunction.ReturnType)
{
return mstrReturnType;
}
else if (strAttributeName  ==  convCMFunction.IsKnownType)
{
return mbolIsKnownType;
}
else if (strAttributeName  ==  convCMFunction.ReturnTypeId)
{
return mstrReturnTypeId;
}
else if (strAttributeName  ==  convCMFunction.ClassNameLst)
{
return mstrClassNameLst;
}
else if (strAttributeName  ==  convCMFunction.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMFunction.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMFunction.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCMFunction.ParaNum)
{
return mintParaNum;
}
else if (strAttributeName  ==  convCMFunction.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convCMFunction.CmFunctionId)
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(convCMFunction.CmFunctionId);
}
else if (strAttributeName  ==  convCMFunction.CmClassId)
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(convCMFunction.CmClassId);
}
else if (strAttributeName  ==  convCMFunction.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunction.ApplicationTypeId);
}
else if (strAttributeName  ==  convCMFunction.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCMFunction.ProgLangTypeId);
}
else if (strAttributeName  ==  convCMFunction.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCMFunction.ProgLangTypeName);
}
else if (strAttributeName  ==  convCMFunction.ProgLangTypeSimName)
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCMFunction.ProgLangTypeSimName);
}
else if (strAttributeName  ==  convCMFunction.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convCMFunction.NameSpace);
}
else if (strAttributeName  ==  convCMFunction.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMFunction.ProjectPath);
}
else if (strAttributeName  ==  convCMFunction.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convCMFunction.FilePath);
}
else if (strAttributeName  ==  convCMFunction.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCMFunction.FileName);
}
else if (strAttributeName  ==  convCMFunction.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCMFunction.CodeTypeId);
}
else if (strAttributeName  ==  convCMFunction.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMFunction.UserId);
}
else if (strAttributeName  ==  convCMFunction.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFunction.PrjId);
}
else if (strAttributeName  ==  convCMFunction.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMFunction.PrjName);
}
else if (strAttributeName  ==  convCMFunction.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convCMFunction.FunctionName);
}
else if (strAttributeName  ==  convCMFunction.FuncContent)
{
mstrFuncContent = value.ToString();
 AddUpdatedFld(convCMFunction.FuncContent);
}
else if (strAttributeName  ==  convCMFunction.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convCMFunction.KeyWords);
}
else if (strAttributeName  ==  convCMFunction.FuncParaLst)
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(convCMFunction.FuncParaLst);
}
else if (strAttributeName  ==  convCMFunction.FuncComments)
{
mstrFuncComments = value.ToString();
 AddUpdatedFld(convCMFunction.FuncComments);
}
else if (strAttributeName  ==  convCMFunction.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convCMFunction.FunctionSignature);
}
else if (strAttributeName  ==  convCMFunction.ReturnType)
{
mstrReturnType = value.ToString();
 AddUpdatedFld(convCMFunction.ReturnType);
}
else if (strAttributeName  ==  convCMFunction.IsKnownType)
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFunction.IsKnownType);
}
else if (strAttributeName  ==  convCMFunction.ReturnTypeId)
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convCMFunction.ReturnTypeId);
}
else if (strAttributeName  ==  convCMFunction.ClassNameLst)
{
mstrClassNameLst = value.ToString();
 AddUpdatedFld(convCMFunction.ClassNameLst);
}
else if (strAttributeName  ==  convCMFunction.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFunction.UpdDate);
}
else if (strAttributeName  ==  convCMFunction.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFunction.UpdUser);
}
else if (strAttributeName  ==  convCMFunction.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFunction.Memo);
}
else if (strAttributeName  ==  convCMFunction.ParaNum)
{
mintParaNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunction.ParaNum);
}
else if (strAttributeName  ==  convCMFunction.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convCMFunction.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMFunction.CmFunctionId  ==  _AttributeName[intIndex])
{
return mstrCmFunctionId;
}
else if (convCMFunction.CmClassId  ==  _AttributeName[intIndex])
{
return mstrCmClassId;
}
else if (convCMFunction.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convCMFunction.ProgLangTypeId  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convCMFunction.ProgLangTypeName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convCMFunction.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
return mstrProgLangTypeSimName;
}
else if (convCMFunction.NameSpace  ==  _AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (convCMFunction.ProjectPath  ==  _AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (convCMFunction.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convCMFunction.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (convCMFunction.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convCMFunction.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCMFunction.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMFunction.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCMFunction.FunctionName  ==  _AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (convCMFunction.FuncContent  ==  _AttributeName[intIndex])
{
return mstrFuncContent;
}
else if (convCMFunction.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convCMFunction.FuncParaLst  ==  _AttributeName[intIndex])
{
return mstrFuncParaLst;
}
else if (convCMFunction.FuncComments  ==  _AttributeName[intIndex])
{
return mstrFuncComments;
}
else if (convCMFunction.FunctionSignature  ==  _AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convCMFunction.ReturnType  ==  _AttributeName[intIndex])
{
return mstrReturnType;
}
else if (convCMFunction.IsKnownType  ==  _AttributeName[intIndex])
{
return mbolIsKnownType;
}
else if (convCMFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
return mstrReturnTypeId;
}
else if (convCMFunction.ClassNameLst  ==  _AttributeName[intIndex])
{
return mstrClassNameLst;
}
else if (convCMFunction.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMFunction.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMFunction.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCMFunction.ParaNum  ==  _AttributeName[intIndex])
{
return mintParaNum;
}
else if (convCMFunction.ClsName  ==  _AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convCMFunction.CmFunctionId  ==  _AttributeName[intIndex])
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(convCMFunction.CmFunctionId);
}
else if (convCMFunction.CmClassId  ==  _AttributeName[intIndex])
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(convCMFunction.CmClassId);
}
else if (convCMFunction.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunction.ApplicationTypeId);
}
else if (convCMFunction.ProgLangTypeId  ==  _AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCMFunction.ProgLangTypeId);
}
else if (convCMFunction.ProgLangTypeName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCMFunction.ProgLangTypeName);
}
else if (convCMFunction.ProgLangTypeSimName  ==  _AttributeName[intIndex])
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCMFunction.ProgLangTypeSimName);
}
else if (convCMFunction.NameSpace  ==  _AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convCMFunction.NameSpace);
}
else if (convCMFunction.ProjectPath  ==  _AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMFunction.ProjectPath);
}
else if (convCMFunction.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convCMFunction.FilePath);
}
else if (convCMFunction.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCMFunction.FileName);
}
else if (convCMFunction.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCMFunction.CodeTypeId);
}
else if (convCMFunction.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMFunction.UserId);
}
else if (convCMFunction.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFunction.PrjId);
}
else if (convCMFunction.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMFunction.PrjName);
}
else if (convCMFunction.FunctionName  ==  _AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convCMFunction.FunctionName);
}
else if (convCMFunction.FuncContent  ==  _AttributeName[intIndex])
{
mstrFuncContent = value.ToString();
 AddUpdatedFld(convCMFunction.FuncContent);
}
else if (convCMFunction.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convCMFunction.KeyWords);
}
else if (convCMFunction.FuncParaLst  ==  _AttributeName[intIndex])
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(convCMFunction.FuncParaLst);
}
else if (convCMFunction.FuncComments  ==  _AttributeName[intIndex])
{
mstrFuncComments = value.ToString();
 AddUpdatedFld(convCMFunction.FuncComments);
}
else if (convCMFunction.FunctionSignature  ==  _AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convCMFunction.FunctionSignature);
}
else if (convCMFunction.ReturnType  ==  _AttributeName[intIndex])
{
mstrReturnType = value.ToString();
 AddUpdatedFld(convCMFunction.ReturnType);
}
else if (convCMFunction.IsKnownType  ==  _AttributeName[intIndex])
{
mbolIsKnownType = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMFunction.IsKnownType);
}
else if (convCMFunction.ReturnTypeId  ==  _AttributeName[intIndex])
{
mstrReturnTypeId = value.ToString();
 AddUpdatedFld(convCMFunction.ReturnTypeId);
}
else if (convCMFunction.ClassNameLst  ==  _AttributeName[intIndex])
{
mstrClassNameLst = value.ToString();
 AddUpdatedFld(convCMFunction.ClassNameLst);
}
else if (convCMFunction.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFunction.UpdDate);
}
else if (convCMFunction.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFunction.UpdUser);
}
else if (convCMFunction.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFunction.Memo);
}
else if (convCMFunction.ParaNum  ==  _AttributeName[intIndex])
{
mintParaNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunction.ParaNum);
}
else if (convCMFunction.ClsName  ==  _AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convCMFunction.ClsName);
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
 AddUpdatedFld(convCMFunction.CmFunctionId);
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
 AddUpdatedFld(convCMFunction.CmClassId);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convCMFunction.ApplicationTypeId);
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
 AddUpdatedFld(convCMFunction.ProgLangTypeId);
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
 AddUpdatedFld(convCMFunction.ProgLangTypeName);
}
}
/// <summary>
/// 编程语言类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeSimName
{
get
{
return mstrProgLangTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeSimName = value;
}
else
{
 mstrProgLangTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFunction.ProgLangTypeSimName);
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
 AddUpdatedFld(convCMFunction.NameSpace);
}
}
/// <summary>
/// 工程路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProjectPath
{
get
{
return mstrProjectPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProjectPath = value;
}
else
{
 mstrProjectPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFunction.ProjectPath);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFunction.FilePath);
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFunction.FileName);
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
 AddUpdatedFld(convCMFunction.CodeTypeId);
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
 AddUpdatedFld(convCMFunction.UserId);
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
 AddUpdatedFld(convCMFunction.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFunction.PrjName);
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
 AddUpdatedFld(convCMFunction.FunctionName);
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
 AddUpdatedFld(convCMFunction.FuncContent);
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
 AddUpdatedFld(convCMFunction.KeyWords);
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
 AddUpdatedFld(convCMFunction.FuncParaLst);
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
 AddUpdatedFld(convCMFunction.FuncComments);
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
 AddUpdatedFld(convCMFunction.FunctionSignature);
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
 AddUpdatedFld(convCMFunction.ReturnType);
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
 AddUpdatedFld(convCMFunction.IsKnownType);
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
 AddUpdatedFld(convCMFunction.ReturnTypeId);
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
 AddUpdatedFld(convCMFunction.ClassNameLst);
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
 AddUpdatedFld(convCMFunction.UpdDate);
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
 AddUpdatedFld(convCMFunction.UpdUser);
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
 AddUpdatedFld(convCMFunction.Memo);
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
 AddUpdatedFld(convCMFunction.ParaNum);
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
 AddUpdatedFld(convCMFunction.ClsName);
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
  return mstrUserId;
 }
 }
}
 /// <summary>
 /// vCM函数(vCMFunction)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMFunction
{
public const string _CurrTabName = "vCMFunction"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmFunctionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmFunctionId", "CmClassId", "ApplicationTypeId", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "NameSpace", "ProjectPath", "FilePath", "FileName", "CodeTypeId", "UserId", "PrjId", "PrjName", "FunctionName", "FuncContent", "KeyWords", "FuncParaLst", "FuncComments", "FunctionSignature", "ReturnType", "IsKnownType", "ReturnTypeId", "ClassNameLst", "UpdDate", "UpdUser", "Memo", "ParaNum", "ClsName"};
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
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

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
 /// 常量:"ProgLangTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeSimName = "ProgLangTypeSimName";    //编程语言类型简称

 /// <summary>
 /// 常量:"NameSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NameSpace = "NameSpace";    //域名

 /// <summary>
 /// 常量:"ProjectPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProjectPath = "ProjectPath";    //工程路径

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

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
 /// 常量:"ReturnType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReturnType = "ReturnType";    //返回类型

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
 /// 常量:"ParaNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaNum = "ParaNum";    //参数个数

 /// <summary>
 /// 常量:"ClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsName = "ClsName";    //类名
}

}