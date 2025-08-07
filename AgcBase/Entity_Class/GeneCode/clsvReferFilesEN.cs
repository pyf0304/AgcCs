
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvReferFilesEN
 表名:vReferFiles(00050461)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:13
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
 /// 表vReferFiles的关键字(ReferFileId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReferFileId_vReferFiles
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
public K_ReferFileId_vReferFiles(string strReferFileId)
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
 /// <returns>返回:[K_ReferFileId_vReferFiles]类型的对象</returns>
public static implicit operator K_ReferFileId_vReferFiles(string value)
{
return new K_ReferFileId_vReferFiles(value);
}
}
 /// <summary>
 /// v引用文件(vReferFiles)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvReferFilesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReferFileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"ReferFileId", "FileName", "ReferFileTypeId", "ReferFileTypeName", "FilePath", "IsNeedDownLoad", "Version", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrReferFileId;    //引用文件Id
protected string mstrFileName;    //文件名
protected string mstrReferFileTypeId;    //引用文件类型Id
protected string mstrReferFileTypeName;    //引用文件类型名
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
 public clsvReferFilesEN()
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
public clsvReferFilesEN(string strReferFileId)
 {
strReferFileId = strReferFileId.Replace("'", "''");
if (strReferFileId.Length > 8)
{
throw new Exception("在表:vReferFiles中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReferFileId)  ==  true)
{
throw new Exception("在表:vReferFiles中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convReferFiles.ReferFileId)
{
return mstrReferFileId;
}
else if (strAttributeName  ==  convReferFiles.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convReferFiles.ReferFileTypeId)
{
return mstrReferFileTypeId;
}
else if (strAttributeName  ==  convReferFiles.ReferFileTypeName)
{
return mstrReferFileTypeName;
}
else if (strAttributeName  ==  convReferFiles.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convReferFiles.IsNeedDownLoad)
{
return mbolIsNeedDownLoad;
}
else if (strAttributeName  ==  convReferFiles.Version)
{
return mstrVersion;
}
else if (strAttributeName  ==  convReferFiles.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convReferFiles.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convReferFiles.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convReferFiles.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convReferFiles.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convReferFiles.ReferFileId)
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(convReferFiles.ReferFileId);
}
else if (strAttributeName  ==  convReferFiles.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convReferFiles.FileName);
}
else if (strAttributeName  ==  convReferFiles.ReferFileTypeId)
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(convReferFiles.ReferFileTypeId);
}
else if (strAttributeName  ==  convReferFiles.ReferFileTypeName)
{
mstrReferFileTypeName = value.ToString();
 AddUpdatedFld(convReferFiles.ReferFileTypeName);
}
else if (strAttributeName  ==  convReferFiles.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convReferFiles.FilePath);
}
else if (strAttributeName  ==  convReferFiles.IsNeedDownLoad)
{
mbolIsNeedDownLoad = TransNullToBool(value.ToString());
 AddUpdatedFld(convReferFiles.IsNeedDownLoad);
}
else if (strAttributeName  ==  convReferFiles.Version)
{
mstrVersion = value.ToString();
 AddUpdatedFld(convReferFiles.Version);
}
else if (strAttributeName  ==  convReferFiles.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convReferFiles.InUse);
}
else if (strAttributeName  ==  convReferFiles.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convReferFiles.OrderNum);
}
else if (strAttributeName  ==  convReferFiles.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convReferFiles.UpdDate);
}
else if (strAttributeName  ==  convReferFiles.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convReferFiles.UpdUserId);
}
else if (strAttributeName  ==  convReferFiles.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convReferFiles.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
return mstrReferFileId;
}
else if (convReferFiles.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (convReferFiles.ReferFileTypeId  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeId;
}
else if (convReferFiles.ReferFileTypeName  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeName;
}
else if (convReferFiles.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convReferFiles.IsNeedDownLoad  ==  _AttributeName[intIndex])
{
return mbolIsNeedDownLoad;
}
else if (convReferFiles.Version  ==  _AttributeName[intIndex])
{
return mstrVersion;
}
else if (convReferFiles.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convReferFiles.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(convReferFiles.ReferFileId);
}
else if (convReferFiles.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convReferFiles.FileName);
}
else if (convReferFiles.ReferFileTypeId  ==  _AttributeName[intIndex])
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(convReferFiles.ReferFileTypeId);
}
else if (convReferFiles.ReferFileTypeName  ==  _AttributeName[intIndex])
{
mstrReferFileTypeName = value.ToString();
 AddUpdatedFld(convReferFiles.ReferFileTypeName);
}
else if (convReferFiles.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convReferFiles.FilePath);
}
else if (convReferFiles.IsNeedDownLoad  ==  _AttributeName[intIndex])
{
mbolIsNeedDownLoad = TransNullToBool(value.ToString());
 AddUpdatedFld(convReferFiles.IsNeedDownLoad);
}
else if (convReferFiles.Version  ==  _AttributeName[intIndex])
{
mstrVersion = value.ToString();
 AddUpdatedFld(convReferFiles.Version);
}
else if (convReferFiles.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convReferFiles.InUse);
}
else if (convReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convReferFiles.OrderNum);
}
else if (convReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convReferFiles.UpdDate);
}
else if (convReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convReferFiles.UpdUserId);
}
else if (convReferFiles.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convReferFiles.Memo);
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
 AddUpdatedFld(convReferFiles.ReferFileId);
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
 AddUpdatedFld(convReferFiles.FileName);
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
 AddUpdatedFld(convReferFiles.ReferFileTypeId);
}
}
/// <summary>
/// 引用文件类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReferFileTypeName
{
get
{
return mstrReferFileTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReferFileTypeName = value;
}
else
{
 mstrReferFileTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convReferFiles.ReferFileTypeName);
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
 AddUpdatedFld(convReferFiles.FilePath);
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
 AddUpdatedFld(convReferFiles.IsNeedDownLoad);
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
 AddUpdatedFld(convReferFiles.Version);
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
 AddUpdatedFld(convReferFiles.InUse);
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
 AddUpdatedFld(convReferFiles.OrderNum);
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
 AddUpdatedFld(convReferFiles.UpdDate);
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
 AddUpdatedFld(convReferFiles.UpdUserId);
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
 AddUpdatedFld(convReferFiles.Memo);
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
}
 /// <summary>
 /// v引用文件(vReferFiles)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convReferFiles
{
public const string _CurrTabName = "vReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReferFileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ReferFileId", "FileName", "ReferFileTypeId", "ReferFileTypeName", "FilePath", "IsNeedDownLoad", "Version", "InUse", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"ReferFileTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReferFileTypeName = "ReferFileTypeName";    //引用文件类型名

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