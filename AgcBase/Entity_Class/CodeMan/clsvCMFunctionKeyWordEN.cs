
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionKeyWordEN
 表名:vCMFunctionKeyWord(00050516)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vCMFunctionKeyWord的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCMFunctionKeyWord
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vCMFunctionKeyWord(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vCMFunctionKeyWord]类型的对象</returns>
public static implicit operator K_mId_vCMFunctionKeyWord(long value)
{
return new K_mId_vCMFunctionKeyWord(value);
}
}
 /// <summary>
 /// vCM函数关键字(vCMFunctionKeyWord)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMFunctionKeyWordEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMFunctionKeyWord"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 25;
public static string[] AttributeName = new string[] {"mId", "CmFunctionId", "CmClassId", "ApplicationTypeId", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "NameSpace", "ProjectPath", "FilePath", "FileName", "CodeTypeId", "UserId", "PrjId", "PrjName", "FunctionName", "FuncContent", "FuncParaLst", "FuncComments", "FunctionSignature", "Keyword", "UpdDate", "UpdUser", "Memo", "ClsName"};

protected long mlngmId;    //mId
protected string mstrCmFunctionId;    //函数Id
protected string mstrCmClassId;    //类Id
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeName;    //编程语言类型名
protected string mstrProgLangTypeSimName;    //编程语言类型简称
protected string mstrNameSpace;    //域名
protected string mstrProjectPath;    //工程路径
protected string mstrFilePath;    //文件路径
protected string mstrFileName;    //文件名
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrFunctionName;    //功能名称
protected string mstrFuncContent;    //函数内容
protected string mstrFuncParaLst;    //函数参数列表
protected string mstrFuncComments;    //函数注释
protected string mstrFunctionSignature;    //函数签名
protected string mstrKeyword;    //关键字
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrClsName;    //类名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCMFunctionKeyWordEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvCMFunctionKeyWordEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convCMFunctionKeyWord.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.CmFunctionId)
{
return mstrCmFunctionId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.CmClassId)
{
return mstrCmClassId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProgLangTypeSimName)
{
return mstrProgLangTypeSimName;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.NameSpace)
{
return mstrNameSpace;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProjectPath)
{
return mstrProjectPath;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FuncContent)
{
return mstrFuncContent;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FuncParaLst)
{
return mstrFuncParaLst;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FuncComments)
{
return mstrFuncComments;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FunctionSignature)
{
return mstrFunctionSignature;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ClsName)
{
return mstrClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convCMFunctionKeyWord.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunctionKeyWord.mId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.CmFunctionId)
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.CmFunctionId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.CmClassId)
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.CmClassId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunctionKeyWord.ApplicationTypeId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeName);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProgLangTypeSimName)
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeSimName);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.NameSpace)
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.NameSpace);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ProjectPath)
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProjectPath);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FilePath);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FileName);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.CodeTypeId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.UserId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.PrjId);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.PrjName);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FunctionName);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FuncContent)
{
mstrFuncContent = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FuncContent);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FuncParaLst)
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FuncParaLst);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FuncComments)
{
mstrFuncComments = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FuncComments);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.FunctionSignature)
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FunctionSignature);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.Keyword);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.UpdDate);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.UpdUser);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.Memo);
}
else if (strAttributeName  ==  convCMFunctionKeyWord.ClsName)
{
mstrClsName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMFunctionKeyWord.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convCMFunctionKeyWord.CmFunctionId  ==  AttributeName[intIndex])
{
return mstrCmFunctionId;
}
else if (convCMFunctionKeyWord.CmClassId  ==  AttributeName[intIndex])
{
return mstrCmClassId;
}
else if (convCMFunctionKeyWord.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convCMFunctionKeyWord.ProgLangTypeId  ==  AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (convCMFunctionKeyWord.ProgLangTypeName  ==  AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
else if (convCMFunctionKeyWord.ProgLangTypeSimName  ==  AttributeName[intIndex])
{
return mstrProgLangTypeSimName;
}
else if (convCMFunctionKeyWord.NameSpace  ==  AttributeName[intIndex])
{
return mstrNameSpace;
}
else if (convCMFunctionKeyWord.ProjectPath  ==  AttributeName[intIndex])
{
return mstrProjectPath;
}
else if (convCMFunctionKeyWord.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convCMFunctionKeyWord.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convCMFunctionKeyWord.CodeTypeId  ==  AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convCMFunctionKeyWord.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCMFunctionKeyWord.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMFunctionKeyWord.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCMFunctionKeyWord.FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (convCMFunctionKeyWord.FuncContent  ==  AttributeName[intIndex])
{
return mstrFuncContent;
}
else if (convCMFunctionKeyWord.FuncParaLst  ==  AttributeName[intIndex])
{
return mstrFuncParaLst;
}
else if (convCMFunctionKeyWord.FuncComments  ==  AttributeName[intIndex])
{
return mstrFuncComments;
}
else if (convCMFunctionKeyWord.FunctionSignature  ==  AttributeName[intIndex])
{
return mstrFunctionSignature;
}
else if (convCMFunctionKeyWord.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convCMFunctionKeyWord.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMFunctionKeyWord.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMFunctionKeyWord.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCMFunctionKeyWord.ClsName  ==  AttributeName[intIndex])
{
return mstrClsName;
}
return null;
}
set
{
if (convCMFunctionKeyWord.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunctionKeyWord.mId);
}
else if (convCMFunctionKeyWord.CmFunctionId  ==  AttributeName[intIndex])
{
mstrCmFunctionId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.CmFunctionId);
}
else if (convCMFunctionKeyWord.CmClassId  ==  AttributeName[intIndex])
{
mstrCmClassId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.CmClassId);
}
else if (convCMFunctionKeyWord.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFunctionKeyWord.ApplicationTypeId);
}
else if (convCMFunctionKeyWord.ProgLangTypeId  ==  AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeId);
}
else if (convCMFunctionKeyWord.ProgLangTypeName  ==  AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeName);
}
else if (convCMFunctionKeyWord.ProgLangTypeSimName  ==  AttributeName[intIndex])
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeSimName);
}
else if (convCMFunctionKeyWord.NameSpace  ==  AttributeName[intIndex])
{
mstrNameSpace = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.NameSpace);
}
else if (convCMFunctionKeyWord.ProjectPath  ==  AttributeName[intIndex])
{
mstrProjectPath = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ProjectPath);
}
else if (convCMFunctionKeyWord.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FilePath);
}
else if (convCMFunctionKeyWord.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FileName);
}
else if (convCMFunctionKeyWord.CodeTypeId  ==  AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.CodeTypeId);
}
else if (convCMFunctionKeyWord.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.UserId);
}
else if (convCMFunctionKeyWord.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.PrjId);
}
else if (convCMFunctionKeyWord.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.PrjName);
}
else if (convCMFunctionKeyWord.FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FunctionName);
}
else if (convCMFunctionKeyWord.FuncContent  ==  AttributeName[intIndex])
{
mstrFuncContent = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FuncContent);
}
else if (convCMFunctionKeyWord.FuncParaLst  ==  AttributeName[intIndex])
{
mstrFuncParaLst = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FuncParaLst);
}
else if (convCMFunctionKeyWord.FuncComments  ==  AttributeName[intIndex])
{
mstrFuncComments = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FuncComments);
}
else if (convCMFunctionKeyWord.FunctionSignature  ==  AttributeName[intIndex])
{
mstrFunctionSignature = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.FunctionSignature);
}
else if (convCMFunctionKeyWord.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.Keyword);
}
else if (convCMFunctionKeyWord.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.UpdDate);
}
else if (convCMFunctionKeyWord.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.UpdUser);
}
else if (convCMFunctionKeyWord.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.Memo);
}
else if (convCMFunctionKeyWord.ClsName  ==  AttributeName[intIndex])
{
mstrClsName = value.ToString();
 AddUpdatedFld(convCMFunctionKeyWord.ClsName);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convCMFunctionKeyWord.mId);
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
 AddUpdatedFld(convCMFunctionKeyWord.CmFunctionId);
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
 AddUpdatedFld(convCMFunctionKeyWord.CmClassId);
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
 AddUpdatedFld(convCMFunctionKeyWord.ApplicationTypeId);
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
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeId);
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
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeName);
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
 AddUpdatedFld(convCMFunctionKeyWord.ProgLangTypeSimName);
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
 AddUpdatedFld(convCMFunctionKeyWord.NameSpace);
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
 AddUpdatedFld(convCMFunctionKeyWord.ProjectPath);
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
 AddUpdatedFld(convCMFunctionKeyWord.FilePath);
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
 AddUpdatedFld(convCMFunctionKeyWord.FileName);
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
 AddUpdatedFld(convCMFunctionKeyWord.CodeTypeId);
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
 AddUpdatedFld(convCMFunctionKeyWord.UserId);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convCMFunctionKeyWord.PrjId);
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
 AddUpdatedFld(convCMFunctionKeyWord.PrjName);
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
 AddUpdatedFld(convCMFunctionKeyWord.FunctionName);
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
 AddUpdatedFld(convCMFunctionKeyWord.FuncContent);
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
 AddUpdatedFld(convCMFunctionKeyWord.FuncParaLst);
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
 AddUpdatedFld(convCMFunctionKeyWord.FuncComments);
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
 AddUpdatedFld(convCMFunctionKeyWord.FunctionSignature);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFunctionKeyWord.Keyword);
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
 AddUpdatedFld(convCMFunctionKeyWord.UpdDate);
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
 AddUpdatedFld(convCMFunctionKeyWord.UpdUser);
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
 AddUpdatedFld(convCMFunctionKeyWord.Memo);
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
 AddUpdatedFld(convCMFunctionKeyWord.ClsName);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mlngmId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
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
 /// vCM函数关键字(vCMFunctionKeyWord)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMFunctionKeyWord
{
public const string _CurrTabName = "vCMFunctionKeyWord"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CmFunctionId", "CmClassId", "ApplicationTypeId", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "NameSpace", "ProjectPath", "FilePath", "FileName", "CodeTypeId", "UserId", "PrjId", "PrjName", "FunctionName", "FuncContent", "FuncParaLst", "FuncComments", "FunctionSignature", "Keyword", "UpdDate", "UpdUser", "Memo", "ClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 public const string PrjId = "PrjId";    //工程ID

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
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

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