
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileResourceEN
 表名:FileResource(00050539)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
 /// 表FileResource的关键字(FileResourceID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FileResourceID_FileResource
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngFileResourceID">表关键字</param>
public K_FileResourceID_FileResource(long lngFileResourceID)
{
if (IsValid(lngFileResourceID)) Value = lngFileResourceID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngFileResourceID)
{
if (lngFileResourceID == 0) return false;
if (lngFileResourceID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FileResourceID_FileResource]类型的对象</returns>
public static implicit operator K_FileResourceID_FileResource(long value)
{
return new K_FileResourceID_FileResource(value);
}
}
 /// <summary>
 /// 文件资源(FileResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFileResourceEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"FileResourceID", "FileDirName", "FileName", "Extension", "TabId", "IsBelongsCurrCMPrj", "IsGeneCode", "IsCanDel", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "PrjId", "CmPrjId", "IpAddress", "IdFtpResource", "UpdDate", "UpdUser", "Memo"};

protected long mlngFileResourceID;    //FileResourceID
protected string mstrFileDirName;    //文件目录名
protected string mstrFileName;    //文件名
protected string mstrExtension;    //扩展名
protected string mstrTabId;    //表ID
protected bool mbolIsBelongsCurrCMPrj;    //是否属于当前项目
protected bool mbolIsGeneCode;    //是否生成代码
protected bool mbolIsCanDel;    //是否可删除
protected long? mlngFileLength;    //文件长度
protected string mstrFileType;    //文件类型
protected string mstrCreationTime;    //建立时间
protected string mstrLastWriteTime;    //修改日期
protected string mstrCheckDateTime;    //CheckDateTime
protected bool mbolInUse;    //是否在用
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrPrjId;    //工程Id
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrIpAddress;    //服务器
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsFileResourceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileResourceID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngFileResourceID">关键字:FileResourceID</param>
public clsFileResourceEN(long lngFileResourceID)
 {
 if (lngFileResourceID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngFileResourceID = lngFileResourceID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FileResourceID");
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
if (strAttributeName  ==  conFileResource.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  conFileResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  conFileResource.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conFileResource.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  conFileResource.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conFileResource.IsBelongsCurrCMPrj)
{
return mbolIsBelongsCurrCMPrj;
}
else if (strAttributeName  ==  conFileResource.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  conFileResource.IsCanDel)
{
return mbolIsCanDel;
}
else if (strAttributeName  ==  conFileResource.FileLength)
{
return mlngFileLength;
}
else if (strAttributeName  ==  conFileResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  conFileResource.CreationTime)
{
return mstrCreationTime;
}
else if (strAttributeName  ==  conFileResource.LastWriteTime)
{
return mstrLastWriteTime;
}
else if (strAttributeName  ==  conFileResource.CheckDateTime)
{
return mstrCheckDateTime;
}
else if (strAttributeName  ==  conFileResource.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conFileResource.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  conFileResource.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFileResource.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conFileResource.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conFileResource.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  conFileResource.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFileResource.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFileResource.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFileResource.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileResourceID);
}
else if (strAttributeName  ==  conFileResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFileResource.FileDirName);
}
else if (strAttributeName  ==  conFileResource.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileResource.FileName);
}
else if (strAttributeName  ==  conFileResource.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(conFileResource.Extension);
}
else if (strAttributeName  ==  conFileResource.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conFileResource.TabId);
}
else if (strAttributeName  ==  conFileResource.IsBelongsCurrCMPrj)
{
mbolIsBelongsCurrCMPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsBelongsCurrCMPrj);
}
else if (strAttributeName  ==  conFileResource.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsGeneCode);
}
else if (strAttributeName  ==  conFileResource.IsCanDel)
{
mbolIsCanDel = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsCanDel);
}
else if (strAttributeName  ==  conFileResource.FileLength)
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileLength);
}
else if (strAttributeName  ==  conFileResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileResource.FileType);
}
else if (strAttributeName  ==  conFileResource.CreationTime)
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(conFileResource.CreationTime);
}
else if (strAttributeName  ==  conFileResource.LastWriteTime)
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(conFileResource.LastWriteTime);
}
else if (strAttributeName  ==  conFileResource.CheckDateTime)
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(conFileResource.CheckDateTime);
}
else if (strAttributeName  ==  conFileResource.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.InUse);
}
else if (strAttributeName  ==  conFileResource.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsExistFile);
}
else if (strAttributeName  ==  conFileResource.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFileResource.PrjId);
}
else if (strAttributeName  ==  conFileResource.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conFileResource.CmPrjId);
}
else if (strAttributeName  ==  conFileResource.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conFileResource.IpAddress);
}
else if (strAttributeName  ==  conFileResource.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFileResource.IdFtpResource);
}
else if (strAttributeName  ==  conFileResource.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFileResource.UpdDate);
}
else if (strAttributeName  ==  conFileResource.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFileResource.UpdUser);
}
else if (strAttributeName  ==  conFileResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFileResource.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFileResource.FileResourceID  ==  _AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (conFileResource.FileDirName  ==  _AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (conFileResource.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (conFileResource.Extension  ==  _AttributeName[intIndex])
{
return mstrExtension;
}
else if (conFileResource.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conFileResource.IsBelongsCurrCMPrj  ==  _AttributeName[intIndex])
{
return mbolIsBelongsCurrCMPrj;
}
else if (conFileResource.IsGeneCode  ==  _AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (conFileResource.IsCanDel  ==  _AttributeName[intIndex])
{
return mbolIsCanDel;
}
else if (conFileResource.FileLength  ==  _AttributeName[intIndex])
{
return mlngFileLength;
}
else if (conFileResource.FileType  ==  _AttributeName[intIndex])
{
return mstrFileType;
}
else if (conFileResource.CreationTime  ==  _AttributeName[intIndex])
{
return mstrCreationTime;
}
else if (conFileResource.LastWriteTime  ==  _AttributeName[intIndex])
{
return mstrLastWriteTime;
}
else if (conFileResource.CheckDateTime  ==  _AttributeName[intIndex])
{
return mstrCheckDateTime;
}
else if (conFileResource.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conFileResource.IsExistFile  ==  _AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (conFileResource.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFileResource.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conFileResource.IpAddress  ==  _AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conFileResource.IdFtpResource  ==  _AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (conFileResource.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFileResource.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFileResource.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFileResource.FileResourceID  ==  _AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileResourceID);
}
else if (conFileResource.FileDirName  ==  _AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFileResource.FileDirName);
}
else if (conFileResource.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conFileResource.FileName);
}
else if (conFileResource.Extension  ==  _AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(conFileResource.Extension);
}
else if (conFileResource.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conFileResource.TabId);
}
else if (conFileResource.IsBelongsCurrCMPrj  ==  _AttributeName[intIndex])
{
mbolIsBelongsCurrCMPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsBelongsCurrCMPrj);
}
else if (conFileResource.IsGeneCode  ==  _AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsGeneCode);
}
else if (conFileResource.IsCanDel  ==  _AttributeName[intIndex])
{
mbolIsCanDel = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsCanDel);
}
else if (conFileResource.FileLength  ==  _AttributeName[intIndex])
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(conFileResource.FileLength);
}
else if (conFileResource.FileType  ==  _AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFileResource.FileType);
}
else if (conFileResource.CreationTime  ==  _AttributeName[intIndex])
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(conFileResource.CreationTime);
}
else if (conFileResource.LastWriteTime  ==  _AttributeName[intIndex])
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(conFileResource.LastWriteTime);
}
else if (conFileResource.CheckDateTime  ==  _AttributeName[intIndex])
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(conFileResource.CheckDateTime);
}
else if (conFileResource.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.InUse);
}
else if (conFileResource.IsExistFile  ==  _AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(conFileResource.IsExistFile);
}
else if (conFileResource.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFileResource.PrjId);
}
else if (conFileResource.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conFileResource.CmPrjId);
}
else if (conFileResource.IpAddress  ==  _AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conFileResource.IpAddress);
}
else if (conFileResource.IdFtpResource  ==  _AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFileResource.IdFtpResource);
}
else if (conFileResource.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFileResource.UpdDate);
}
else if (conFileResource.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFileResource.UpdUser);
}
else if (conFileResource.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFileResource.Memo);
}
}
}

/// <summary>
/// FileResourceID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FileResourceID
{
get
{
return mlngFileResourceID;
}
set
{
 mlngFileResourceID = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.FileResourceID);
}
}
/// <summary>
/// 文件目录名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileDirName
{
get
{
return mstrFileDirName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileDirName = value;
}
else
{
 mstrFileDirName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.FileDirName);
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
 AddUpdatedFld(conFileResource.FileName);
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
 AddUpdatedFld(conFileResource.Extension);
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
 AddUpdatedFld(conFileResource.TabId);
}
}
/// <summary>
/// 是否属于当前项目(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsBelongsCurrCMPrj
{
get
{
return mbolIsBelongsCurrCMPrj;
}
set
{
 mbolIsBelongsCurrCMPrj = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.IsBelongsCurrCMPrj);
}
}
/// <summary>
/// 是否生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneCode
{
get
{
return mbolIsGeneCode;
}
set
{
 mbolIsGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.IsGeneCode);
}
}
/// <summary>
/// 是否可删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCanDel
{
get
{
return mbolIsCanDel;
}
set
{
 mbolIsCanDel = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.IsCanDel);
}
}
/// <summary>
/// 文件长度(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? FileLength
{
get
{
return mlngFileLength;
}
set
{
 mlngFileLength = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.FileLength);
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
 AddUpdatedFld(conFileResource.FileType);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreationTime
{
get
{
return mstrCreationTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreationTime = value;
}
else
{
 mstrCreationTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.CreationTime);
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
 AddUpdatedFld(conFileResource.LastWriteTime);
}
}
/// <summary>
/// CheckDateTime(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDateTime
{
get
{
return mstrCheckDateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDateTime = value;
}
else
{
 mstrCheckDateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.CheckDateTime);
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
 AddUpdatedFld(conFileResource.InUse);
}
}
/// <summary>
/// 是否存在文件(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistFile
{
get
{
return mbolIsExistFile;
}
set
{
 mbolIsExistFile = value;
//记录修改过的字段
 AddUpdatedFld(conFileResource.IsExistFile);
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
 AddUpdatedFld(conFileResource.PrjId);
}
}
/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.CmPrjId);
}
}
/// <summary>
/// 服务器(说明:;字段类型:varchar;字段长度:25;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conFileResource.IpAddress);
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
 AddUpdatedFld(conFileResource.IdFtpResource);
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
 AddUpdatedFld(conFileResource.UpdDate);
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
 AddUpdatedFld(conFileResource.UpdUser);
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
 AddUpdatedFld(conFileResource.Memo);
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
  return mlngFileResourceID.ToString();
 }
 }
}
 /// <summary>
 /// 文件资源(FileResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFileResource
{
public const string _CurrTabName = "FileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FileResourceID", "FileDirName", "FileName", "Extension", "TabId", "IsBelongsCurrCMPrj", "IsGeneCode", "IsCanDel", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "PrjId", "CmPrjId", "IpAddress", "IdFtpResource", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FileResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileResourceID = "FileResourceID";    //FileResourceID

 /// <summary>
 /// 常量:"FileDirName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileDirName = "FileDirName";    //文件目录名

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"Extension"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Extension = "Extension";    //扩展名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"IsBelongsCurrCMPrj"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsBelongsCurrCMPrj = "IsBelongsCurrCMPrj";    //是否属于当前项目

 /// <summary>
 /// 常量:"IsGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneCode = "IsGeneCode";    //是否生成代码

 /// <summary>
 /// 常量:"IsCanDel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCanDel = "IsCanDel";    //是否可删除

 /// <summary>
 /// 常量:"FileLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileLength = "FileLength";    //文件长度

 /// <summary>
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"CreationTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreationTime = "CreationTime";    //建立时间

 /// <summary>
 /// 常量:"LastWriteTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastWriteTime = "LastWriteTime";    //修改日期

 /// <summary>
 /// 常量:"CheckDateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDateTime = "CheckDateTime";    //CheckDateTime

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //服务器

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

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
}

}