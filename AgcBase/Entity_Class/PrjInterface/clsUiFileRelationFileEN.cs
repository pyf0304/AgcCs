
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationFileEN
 表名:UiFileRelationFile(00050653)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:49:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 表UiFileRelationFile的关键字(FileId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FileId_UiFileRelationFile
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngFileId">表关键字</param>
public K_FileId_UiFileRelationFile(long lngFileId)
{
if (IsValid(lngFileId)) Value = lngFileId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngFileId)
{
if (lngFileId == 0) return false;
if (lngFileId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FileId_UiFileRelationFile]类型的对象</returns>
public static implicit operator K_FileId_UiFileRelationFile(long value)
{
return new K_FileId_UiFileRelationFile(value);
}
}
 /// <summary>
 /// UiFileRelationFile(UiFileRelationFile)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUiFileRelationFileEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UiFileRelationFile"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"FileId", "TaskId", "FilePath", "RelativePath", "FileName", "Extension", "FileKind", "FileHash", "IsEntry", "ParseStatus", "ParseMsg", "CreatedAt"};

protected long mlngFileId;    //FileId
protected long mlngTaskId;    //TaskId
protected string mstrFilePath;    //FilePath
protected string mstrRelativePath;    //RelativePath
protected string mstrFileName;    //FileName
protected string mstrExtension;    //扩展名
protected string mstrFileKind;    //FileKind
protected string mstrFileHash;    //FileHash
protected bool mbolIsEntry;    //IsEntry
protected string mstrParseStatus;    //ParseStatus
protected string mstrParseMsg;    //ParseMsg
protected DateTime mdteCreatedAt;    //CreatedAt

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUiFileRelationFileEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngFileId">关键字:FileId</param>
public clsUiFileRelationFileEN(long lngFileId)
 {
 if (lngFileId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngFileId = lngFileId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileId");
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
if (strAttributeName  ==  conUiFileRelationFile.FileId)
{
return mlngFileId;
}
else if (strAttributeName  ==  conUiFileRelationFile.TaskId)
{
return mlngTaskId;
}
else if (strAttributeName  ==  conUiFileRelationFile.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conUiFileRelationFile.RelativePath)
{
return mstrRelativePath;
}
else if (strAttributeName  ==  conUiFileRelationFile.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conUiFileRelationFile.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  conUiFileRelationFile.FileKind)
{
return mstrFileKind;
}
else if (strAttributeName  ==  conUiFileRelationFile.FileHash)
{
return mstrFileHash;
}
else if (strAttributeName  ==  conUiFileRelationFile.IsEntry)
{
return mbolIsEntry;
}
else if (strAttributeName  ==  conUiFileRelationFile.ParseStatus)
{
return mstrParseStatus;
}
else if (strAttributeName  ==  conUiFileRelationFile.ParseMsg)
{
return mstrParseMsg;
}
else if (strAttributeName  ==  conUiFileRelationFile.CreatedAt)
{
return mdteCreatedAt;
}
return null;
}
set
{
if (strAttributeName  ==  conUiFileRelationFile.FileId)
{
mlngFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.FileId);
}
else if (strAttributeName  ==  conUiFileRelationFile.TaskId)
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.TaskId);
}
else if (strAttributeName  ==  conUiFileRelationFile.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FilePath);
}
else if (strAttributeName  ==  conUiFileRelationFile.RelativePath)
{
mstrRelativePath = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.RelativePath);
}
else if (strAttributeName  ==  conUiFileRelationFile.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FileName);
}
else if (strAttributeName  ==  conUiFileRelationFile.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.Extension);
}
else if (strAttributeName  ==  conUiFileRelationFile.FileKind)
{
mstrFileKind = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FileKind);
}
else if (strAttributeName  ==  conUiFileRelationFile.FileHash)
{
mstrFileHash = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FileHash);
}
else if (strAttributeName  ==  conUiFileRelationFile.IsEntry)
{
mbolIsEntry = TransNullToBool(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.IsEntry);
}
else if (strAttributeName  ==  conUiFileRelationFile.ParseStatus)
{
mstrParseStatus = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.ParseStatus);
}
else if (strAttributeName  ==  conUiFileRelationFile.ParseMsg)
{
mstrParseMsg = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.ParseMsg);
}
else if (strAttributeName  ==  conUiFileRelationFile.CreatedAt)
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.CreatedAt);
}
}
}
public object this[int intIndex]
{
get
{
if (conUiFileRelationFile.FileId  ==  _AttributeName[intIndex])
{
return mlngFileId;
}
else if (conUiFileRelationFile.TaskId  ==  _AttributeName[intIndex])
{
return mlngTaskId;
}
else if (conUiFileRelationFile.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conUiFileRelationFile.RelativePath  ==  _AttributeName[intIndex])
{
return mstrRelativePath;
}
else if (conUiFileRelationFile.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (conUiFileRelationFile.Extension  ==  _AttributeName[intIndex])
{
return mstrExtension;
}
else if (conUiFileRelationFile.FileKind  ==  _AttributeName[intIndex])
{
return mstrFileKind;
}
else if (conUiFileRelationFile.FileHash  ==  _AttributeName[intIndex])
{
return mstrFileHash;
}
else if (conUiFileRelationFile.IsEntry  ==  _AttributeName[intIndex])
{
return mbolIsEntry;
}
else if (conUiFileRelationFile.ParseStatus  ==  _AttributeName[intIndex])
{
return mstrParseStatus;
}
else if (conUiFileRelationFile.ParseMsg  ==  _AttributeName[intIndex])
{
return mstrParseMsg;
}
else if (conUiFileRelationFile.CreatedAt  ==  _AttributeName[intIndex])
{
return mdteCreatedAt;
}
return null;
}
set
{
if (conUiFileRelationFile.FileId  ==  _AttributeName[intIndex])
{
mlngFileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.FileId);
}
else if (conUiFileRelationFile.TaskId  ==  _AttributeName[intIndex])
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.TaskId);
}
else if (conUiFileRelationFile.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FilePath);
}
else if (conUiFileRelationFile.RelativePath  ==  _AttributeName[intIndex])
{
mstrRelativePath = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.RelativePath);
}
else if (conUiFileRelationFile.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FileName);
}
else if (conUiFileRelationFile.Extension  ==  _AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.Extension);
}
else if (conUiFileRelationFile.FileKind  ==  _AttributeName[intIndex])
{
mstrFileKind = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FileKind);
}
else if (conUiFileRelationFile.FileHash  ==  _AttributeName[intIndex])
{
mstrFileHash = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.FileHash);
}
else if (conUiFileRelationFile.IsEntry  ==  _AttributeName[intIndex])
{
mbolIsEntry = TransNullToBool(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.IsEntry);
}
else if (conUiFileRelationFile.ParseStatus  ==  _AttributeName[intIndex])
{
mstrParseStatus = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.ParseStatus);
}
else if (conUiFileRelationFile.ParseMsg  ==  _AttributeName[intIndex])
{
mstrParseMsg = value.ToString();
 AddUpdatedFld(conUiFileRelationFile.ParseMsg);
}
else if (conUiFileRelationFile.CreatedAt  ==  _AttributeName[intIndex])
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationFile.CreatedAt);
}
}
}

/// <summary>
/// FileId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FileId
{
get
{
return mlngFileId;
}
set
{
 mlngFileId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.FileId);
}
}
/// <summary>
/// TaskId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long TaskId
{
get
{
return mlngTaskId;
}
set
{
 mlngTaskId = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.TaskId);
}
}
/// <summary>
/// FilePath(说明:;字段类型:nvarchar;字段长度:1000;是否可空:False)
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
 AddUpdatedFld(conUiFileRelationFile.FilePath);
}
}
/// <summary>
/// RelativePath(说明:;字段类型:nvarchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelativePath
{
get
{
return mstrRelativePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelativePath = value;
}
else
{
 mstrRelativePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.RelativePath);
}
}
/// <summary>
/// FileName(说明:;字段类型:nvarchar;字段长度:400;是否可空:False)
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
 AddUpdatedFld(conUiFileRelationFile.FileName);
}
}
/// <summary>
/// 扩展名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Extension
{
get
{
return mstrExtension;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExtension = value;
}
else
{
 mstrExtension = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.Extension);
}
}
/// <summary>
/// FileKind(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileKind
{
get
{
return mstrFileKind;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileKind = value;
}
else
{
 mstrFileKind = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.FileKind);
}
}
/// <summary>
/// FileHash(说明:;字段类型:varchar;字段长度:64;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileHash
{
get
{
return mstrFileHash;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileHash = value;
}
else
{
 mstrFileHash = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.FileHash);
}
}
/// <summary>
/// IsEntry(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsEntry
{
get
{
return mbolIsEntry;
}
set
{
 mbolIsEntry = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.IsEntry);
}
}
/// <summary>
/// ParseStatus(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParseStatus
{
get
{
return mstrParseStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParseStatus = value;
}
else
{
 mstrParseStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.ParseStatus);
}
}
/// <summary>
/// ParseMsg(说明:;字段类型:ntext;字段长度:2147483646;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParseMsg
{
get
{
return mstrParseMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParseMsg = value;
}
else
{
 mstrParseMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.ParseMsg);
}
}
/// <summary>
/// CreatedAt(说明:;字段类型:datetime;字段长度:16;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreatedAt
{
get
{
return mdteCreatedAt;
}
set
{
 mdteCreatedAt = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationFile.CreatedAt);
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
  return mlngFileId.ToString();
 }
 }
}
 /// <summary>
 /// UiFileRelationFile(UiFileRelationFile)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUiFileRelationFile
{
public const string _CurrTabName = "UiFileRelationFile"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FileId", "TaskId", "FilePath", "RelativePath", "FileName", "Extension", "FileKind", "FileHash", "IsEntry", "ParseStatus", "ParseMsg", "CreatedAt"};
//以下是属性变量


 /// <summary>
 /// 常量:"FileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileId = "FileId";    //FileId

 /// <summary>
 /// 常量:"TaskId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TaskId = "TaskId";    //TaskId

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //FilePath

 /// <summary>
 /// 常量:"RelativePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelativePath = "RelativePath";    //RelativePath

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //FileName

 /// <summary>
 /// 常量:"Extension"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Extension = "Extension";    //扩展名

 /// <summary>
 /// 常量:"FileKind"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileKind = "FileKind";    //FileKind

 /// <summary>
 /// 常量:"FileHash"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileHash = "FileHash";    //FileHash

 /// <summary>
 /// 常量:"IsEntry"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEntry = "IsEntry";    //IsEntry

 /// <summary>
 /// 常量:"ParseStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParseStatus = "ParseStatus";    //ParseStatus

 /// <summary>
 /// 常量:"ParseMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParseMsg = "ParseMsg";    //ParseMsg

 /// <summary>
 /// 常量:"CreatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedAt = "CreatedAt";    //CreatedAt
}

}