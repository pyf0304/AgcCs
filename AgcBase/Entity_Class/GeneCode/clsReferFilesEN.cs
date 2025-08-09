
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsReferFilesEN
 表名:ReferFiles(00050460)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:31
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
 /// 表ReferFiles的关键字(ReferFileId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReferFileId_ReferFiles
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strReferFileId">表关键字</param>
public K_ReferFileId_ReferFiles(string strReferFileId)
{
if (IsValid(strReferFileId)) Value = strReferFileId;
else
{
Value = null;
}
}
private static bool IsValid(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true) return false;
if (strReferFileId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ReferFileId_ReferFiles]类型的对象</returns>
public static implicit operator K_ReferFileId_ReferFiles(string value)
{
return new K_ReferFileId_ReferFiles(value);
}
}
 /// <summary>
 /// 引用文件(ReferFiles)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsReferFilesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReferFileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"ReferFileId", "FileName", "ReferFileTypeId", "FilePath", "IsNeedDownLoad", "Version", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrReferFileId;    //引用文件Id
protected string mstrFileName;    //文件名
protected string mstrReferFileTypeId;    //引用文件类型Id
protected string mstrFilePath;    //文件路径
protected bool mbolIsNeedDownLoad;    //是否需要下载
protected string mstrVersion;    //版本
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsReferFilesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReferFileId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strReferFileId">关键字:引用文件Id</param>
public clsReferFilesEN(string strReferFileId)
 {
strReferFileId = strReferFileId.Replace("'", "''");
if (strReferFileId.Length > 8)
{
throw new Exception("在表:ReferFiles中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReferFileId)  ==  true)
{
throw new Exception("在表:ReferFiles中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReferFileId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrReferFileId = strReferFileId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReferFileId");
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
if (strAttributeName  ==  conReferFiles.ReferFileId)
{
return mstrReferFileId;
}
else if (strAttributeName  ==  conReferFiles.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conReferFiles.ReferFileTypeId)
{
return mstrReferFileTypeId;
}
else if (strAttributeName  ==  conReferFiles.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conReferFiles.IsNeedDownLoad)
{
return mbolIsNeedDownLoad;
}
else if (strAttributeName  ==  conReferFiles.Version)
{
return mstrVersion;
}
else if (strAttributeName  ==  conReferFiles.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conReferFiles.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conReferFiles.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conReferFiles.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conReferFiles.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conReferFiles.ReferFileId)
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(conReferFiles.ReferFileId);
}
else if (strAttributeName  ==  conReferFiles.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conReferFiles.FileName);
}
else if (strAttributeName  ==  conReferFiles.ReferFileTypeId)
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(conReferFiles.ReferFileTypeId);
}
else if (strAttributeName  ==  conReferFiles.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conReferFiles.FilePath);
}
else if (strAttributeName  ==  conReferFiles.IsNeedDownLoad)
{
mbolIsNeedDownLoad = TransNullToBool(value.ToString());
 AddUpdatedFld(conReferFiles.IsNeedDownLoad);
}
else if (strAttributeName  ==  conReferFiles.Version)
{
mstrVersion = value.ToString();
 AddUpdatedFld(conReferFiles.Version);
}
else if (strAttributeName  ==  conReferFiles.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conReferFiles.InUse);
}
else if (strAttributeName  ==  conReferFiles.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conReferFiles.OrderNum);
}
else if (strAttributeName  ==  conReferFiles.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conReferFiles.UpdDate);
}
else if (strAttributeName  ==  conReferFiles.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conReferFiles.UpdUserId);
}
else if (strAttributeName  ==  conReferFiles.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conReferFiles.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
return mstrReferFileId;
}
else if (conReferFiles.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (conReferFiles.ReferFileTypeId  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeId;
}
else if (conReferFiles.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conReferFiles.IsNeedDownLoad  ==  _AttributeName[intIndex])
{
return mbolIsNeedDownLoad;
}
else if (conReferFiles.Version  ==  _AttributeName[intIndex])
{
return mstrVersion;
}
else if (conReferFiles.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conReferFiles.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(conReferFiles.ReferFileId);
}
else if (conReferFiles.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conReferFiles.FileName);
}
else if (conReferFiles.ReferFileTypeId  ==  _AttributeName[intIndex])
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(conReferFiles.ReferFileTypeId);
}
else if (conReferFiles.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conReferFiles.FilePath);
}
else if (conReferFiles.IsNeedDownLoad  ==  _AttributeName[intIndex])
{
mbolIsNeedDownLoad = TransNullToBool(value.ToString());
 AddUpdatedFld(conReferFiles.IsNeedDownLoad);
}
else if (conReferFiles.Version  ==  _AttributeName[intIndex])
{
mstrVersion = value.ToString();
 AddUpdatedFld(conReferFiles.Version);
}
else if (conReferFiles.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conReferFiles.InUse);
}
else if (conReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conReferFiles.OrderNum);
}
else if (conReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conReferFiles.UpdDate);
}
else if (conReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conReferFiles.UpdUserId);
}
else if (conReferFiles.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conReferFiles.Memo);
}
}
}

/// <summary>
/// 引用文件Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReferFileId
{
get
{
return mstrReferFileId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReferFileId = value;
}
else
{
 mstrReferFileId = value;
}
//记录修改过的字段
 AddUpdatedFld(conReferFiles.ReferFileId);
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
 AddUpdatedFld(conReferFiles.FileName);
}
}
/// <summary>
/// 引用文件类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReferFileTypeId
{
get
{
return mstrReferFileTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReferFileTypeId = value;
}
else
{
 mstrReferFileTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conReferFiles.ReferFileTypeId);
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
 AddUpdatedFld(conReferFiles.FilePath);
}
}
/// <summary>
/// 是否需要下载(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedDownLoad
{
get
{
return mbolIsNeedDownLoad;
}
set
{
 mbolIsNeedDownLoad = value;
//记录修改过的字段
 AddUpdatedFld(conReferFiles.IsNeedDownLoad);
}
}
/// <summary>
/// 版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Version
{
get
{
return mstrVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersion = value;
}
else
{
 mstrVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(conReferFiles.Version);
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
 AddUpdatedFld(conReferFiles.InUse);
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
 AddUpdatedFld(conReferFiles.OrderNum);
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
 AddUpdatedFld(conReferFiles.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conReferFiles.UpdUserId);
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
 AddUpdatedFld(conReferFiles.Memo);
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
  return mstrReferFileId;
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
  return mstrFileName;
 }
 }
}
 /// <summary>
 /// 引用文件(ReferFiles)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conReferFiles
{
public const string _CurrTabName = "ReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReferFileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ReferFileId", "FileName", "ReferFileTypeId", "FilePath", "IsNeedDownLoad", "Version", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ReferFileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReferFileId = "ReferFileId";    //引用文件Id

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"ReferFileTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReferFileTypeId = "ReferFileTypeId";    //引用文件类型Id

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"IsNeedDownLoad"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedDownLoad = "IsNeedDownLoad";    //是否需要下载

 /// <summary>
 /// 常量:"Version"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Version = "Version";    //版本

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}