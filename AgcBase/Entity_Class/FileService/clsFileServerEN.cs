
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileServerEN
 表名:FileServer(00050209)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:13
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件服务(FileService)
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
 /// 表FileServer的关键字(id_FileId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_FileId_FileServer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngid_FileId">表关键字</param>
public K_id_FileId_FileServer(long lngid_FileId)
{
if (IsValid(lngid_FileId)) Value = lngid_FileId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngid_FileId)
{
if (lngid_FileId == 0) return false;
if (lngid_FileId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_FileId_FileServer]类型的对象</returns>
public static implicit operator K_id_FileId_FileServer(long value)
{
return new K_id_FileId_FileServer(value);
}
}
 /// <summary>
 /// 文件服务(FileServer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFileServerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "FileServer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_FileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"id_FileId", "FileContent", "FileName", "IsFree", "FileSize", "FileType", "SaveDate", "LastWriteTime", "IdFtpResource", "id_ResourceType", "SaveMode", "ProjectName"};

protected long mlngid_FileId;    //文件流水号
protected byte[] mbytFileContent;    //文件内容
protected string mstrFileName;    //文件名
protected bool mbolIsFree;    //是否释放
protected long? mlngFileSize;    //文件大小
protected string mstrFileType;    //文件类型
protected string mstrSaveDate;    //保存日期
protected string mstrLastWriteTime;    //修改日期
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrid_ResourceType;    //资源类型流水号
protected string mstrSaveMode;    //文件存放方式
protected string mstrProjectName;    //项目名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFileServerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FileServer";
 lstKeyFldNames.Add("id_FileId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngid_FileId">关键字:文件流水号</param>
public clsFileServerEN(long lngid_FileId)
 {
 if (lngid_FileId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngid_FileId = lngid_FileId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FileServer";
 lstKeyFldNames.Add("id_FileId");
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
if (strAttributeName  ==  conFileServer.id_FileId)
{
return mlngid_FileId;
}
else if (strAttributeName  ==  conFileServer.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conFileServer.IsFree)
{
return mbolIsFree;
}
else if (strAttributeName  ==  conFileServer.FileSize)
{
return mlngFileSize;
}
else if (strAttributeName  ==  conFileServer.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  conFileServer.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  conFileServer.LastWriteTime)
{
return mstrLastWriteTime;
}
else if (strAttributeName  ==  conFileServer.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  conFileServer.id_ResourceType)
{
return mstrid_ResourceType;
}
else if (strAttributeName  ==  conFileServer.SaveMode)
{
return mstrSaveMode;
}
else if (strAttributeName  ==  conFileServer.ProjectName)
{
return mstrProjectName;
}
return null;
}
set
{
if (strAttributeName  ==  conFileServer.id_FileId)
{
mlngid_FileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileServer.id_FileId);
}
else if (strAttributeName  ==  conFileServer.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileServer.FileName);
}
else if (strAttributeName  ==  conFileServer.IsFree)
{
mbolIsFree = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileServer.IsFree);
}
else if (strAttributeName  ==  conFileServer.FileSize)
{
mlngFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileServer.FileSize);
}
else if (strAttributeName  ==  conFileServer.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileServer.FileType);
}
else if (strAttributeName  ==  conFileServer.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(conFileServer.SaveDate);
}
else if (strAttributeName  ==  conFileServer.LastWriteTime)
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(conFileServer.LastWriteTime);
}
else if (strAttributeName  ==  conFileServer.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFileServer.IdFtpResource);
}
else if (strAttributeName  ==  conFileServer.id_ResourceType)
{
mstrid_ResourceType = value.ToString();
 AddUpdatedFld(conFileServer.id_ResourceType);
}
else if (strAttributeName  ==  conFileServer.SaveMode)
{
mstrSaveMode = value.ToString();
 AddUpdatedFld(conFileServer.SaveMode);
}
else if (strAttributeName  ==  conFileServer.ProjectName)
{
mstrProjectName = value.ToString();
 AddUpdatedFld(conFileServer.ProjectName);
}
}
}
public object this[int intIndex]
{
get
{
if (conFileServer.id_FileId  ==  AttributeName[intIndex])
{
return mlngid_FileId;
}
else if (conFileServer.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conFileServer.IsFree  ==  AttributeName[intIndex])
{
return mbolIsFree;
}
else if (conFileServer.FileSize  ==  AttributeName[intIndex])
{
return mlngFileSize;
}
else if (conFileServer.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (conFileServer.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (conFileServer.LastWriteTime  ==  AttributeName[intIndex])
{
return mstrLastWriteTime;
}
else if (conFileServer.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (conFileServer.id_ResourceType  ==  AttributeName[intIndex])
{
return mstrid_ResourceType;
}
else if (conFileServer.SaveMode  ==  AttributeName[intIndex])
{
return mstrSaveMode;
}
else if (conFileServer.ProjectName  ==  AttributeName[intIndex])
{
return mstrProjectName;
}
return null;
}
set
{
if (conFileServer.id_FileId  ==  AttributeName[intIndex])
{
mlngid_FileId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileServer.id_FileId);
}
else if (conFileServer.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileServer.FileName);
}
else if (conFileServer.IsFree  ==  AttributeName[intIndex])
{
mbolIsFree = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileServer.IsFree);
}
else if (conFileServer.FileSize  ==  AttributeName[intIndex])
{
mlngFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileServer.FileSize);
}
else if (conFileServer.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileServer.FileType);
}
else if (conFileServer.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(conFileServer.SaveDate);
}
else if (conFileServer.LastWriteTime  ==  AttributeName[intIndex])
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(conFileServer.LastWriteTime);
}
else if (conFileServer.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFileServer.IdFtpResource);
}
else if (conFileServer.id_ResourceType  ==  AttributeName[intIndex])
{
mstrid_ResourceType = value.ToString();
 AddUpdatedFld(conFileServer.id_ResourceType);
}
else if (conFileServer.SaveMode  ==  AttributeName[intIndex])
{
mstrSaveMode = value.ToString();
 AddUpdatedFld(conFileServer.SaveMode);
}
else if (conFileServer.ProjectName  ==  AttributeName[intIndex])
{
mstrProjectName = value.ToString();
 AddUpdatedFld(conFileServer.ProjectName);
}
}
}

/// <summary>
/// 文件流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long id_FileId
{
get
{
return mlngid_FileId;
}
set
{
 mlngid_FileId = value;
//记录修改过的字段
 AddUpdatedFld(conFileServer.id_FileId);
}
}
/// <summary>
/// 文件内容(说明:;字段类型:image;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public byte[] FileContent
{
get
{
return mbytFileContent;
}
set
{
 mbytFileContent = value;
//记录修改过的字段
 AddUpdatedFld(conFileServer.FileContent);
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
 AddUpdatedFld(conFileServer.FileName);
}
}
/// <summary>
/// 是否释放(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsFree
{
get
{
return mbolIsFree;
}
set
{
 mbolIsFree = value;
//记录修改过的字段
 AddUpdatedFld(conFileServer.IsFree);
}
}
/// <summary>
/// 文件大小(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? FileSize
{
get
{
return mlngFileSize;
}
set
{
 mlngFileSize = value;
//记录修改过的字段
 AddUpdatedFld(conFileServer.FileSize);
}
}
/// <summary>
/// 文件类型(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileType
{
get
{
return mstrFileType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileType = value;
}
else
{
 mstrFileType = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileServer.FileType);
}
}
/// <summary>
/// 保存日期(说明:;字段类型:varchar;字段长度:25;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SaveDate
{
get
{
return mstrSaveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSaveDate = value;
}
else
{
 mstrSaveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileServer.SaveDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastWriteTime
{
get
{
return mstrLastWriteTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastWriteTime = value;
}
else
{
 mstrLastWriteTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileServer.LastWriteTime);
}
}
/// <summary>
/// FTP资源流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFtpResource
{
get
{
return mstrIdFtpResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFtpResource = value;
}
else
{
 mstrIdFtpResource = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileServer.IdFtpResource);
}
}
/// <summary>
/// 资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_ResourceType
{
get
{
return mstrid_ResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_ResourceType = value;
}
else
{
 mstrid_ResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileServer.id_ResourceType);
}
}
/// <summary>
/// 文件存放方式(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SaveMode
{
get
{
return mstrSaveMode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSaveMode = value;
}
else
{
 mstrSaveMode = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileServer.SaveMode);
}
}
/// <summary>
/// 项目名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProjectName
{
get
{
return mstrProjectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProjectName = value;
}
else
{
 mstrProjectName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileServer.ProjectName);
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
  return mlngid_FileId.ToString();
 }
 }
}
 /// <summary>
 /// 文件服务(FileServer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFileServer
{
public new const string _CurrTabName = "FileServer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_FileId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"id_FileId", "FileContent", "FileName", "IsFree", "FileSize", "FileType", "SaveDate", "LastWriteTime", "IdFtpResource", "id_ResourceType", "SaveMode", "ProjectName"};
//以下是属性变量


 /// <summary>
 /// 常量:"id_FileId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id_FileId = "id_FileId";    //文件流水号

 /// <summary>
 /// 常量:"FileContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileContent = "FileContent";    //文件内容

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"IsFree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsFree = "IsFree";    //是否释放

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"SaveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveDate = "SaveDate";    //保存日期

 /// <summary>
 /// 常量:"LastWriteTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastWriteTime = "LastWriteTime";    //修改日期

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"id_ResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id_ResourceType = "id_ResourceType";    //资源类型流水号

 /// <summary>
 /// 常量:"SaveMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveMode = "SaveMode";    //文件存放方式

 /// <summary>
 /// 常量:"ProjectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProjectName = "ProjectName";    //项目名称
}

}