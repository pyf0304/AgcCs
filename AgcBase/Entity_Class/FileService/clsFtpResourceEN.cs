
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFtpResourceEN
 表名:FtpResource(00050210)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:22
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
 /// 表FtpResource的关键字(IdFtpResource)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdFtpResource_FtpResource
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdFtpResource">表关键字</param>
public K_IdFtpResource_FtpResource(string strIdFtpResource)
{
if (IsValid(strIdFtpResource)) Value = strIdFtpResource;
else
{
Value = null;
}
}
private static bool IsValid(string strIdFtpResource)
{
if (string.IsNullOrEmpty(strIdFtpResource) == true) return false;
if (strIdFtpResource.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdFtpResource_FtpResource]类型的对象</returns>
public static implicit operator K_IdFtpResource_FtpResource(string value)
{
return new K_IdFtpResource_FtpResource(value);
}
}
 /// <summary>
 /// FTP资源(FtpResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFtpResourceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "FtpResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdFtpResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"IdFtpResource", "FtpResourceID", "FileOriginalName", "ftpServerIP", "FileDirName", "FileRename", "FileType", "FileUpDate", "FileUpTime", "FileSize", "ResourceOwner", "Memo"};

protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrftpServerIP;    //ftp服务器地址
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileType;    //文件类型
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected long? mlngFileSize;    //文件大小
protected string mstrResourceOwner;    //创建者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFtpResourceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FtpResource";
 lstKeyFldNames.Add("IdFtpResource");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdFtpResource">关键字:FTP资源流水号</param>
public clsFtpResourceEN(string strIdFtpResource)
 {
strIdFtpResource = strIdFtpResource.Replace("'", "''");
if (strIdFtpResource.Length > 8)
{
throw new Exception("在表:FtpResource中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdFtpResource)  ==  true)
{
throw new Exception("在表:FtpResource中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdFtpResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdFtpResource = strIdFtpResource;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "FtpResource";
 lstKeyFldNames.Add("IdFtpResource");
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
if (strAttributeName  ==  conFtpResource.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  conFtpResource.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  conFtpResource.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  conFtpResource.ftpServerIP)
{
return mstrftpServerIP;
}
else if (strAttributeName  ==  conFtpResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  conFtpResource.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  conFtpResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  conFtpResource.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  conFtpResource.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  conFtpResource.FileSize)
{
return mlngFileSize;
}
else if (strAttributeName  ==  conFtpResource.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  conFtpResource.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFtpResource.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFtpResource.IdFtpResource);
}
else if (strAttributeName  ==  conFtpResource.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(conFtpResource.FtpResourceID);
}
else if (strAttributeName  ==  conFtpResource.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(conFtpResource.FileOriginalName);
}
else if (strAttributeName  ==  conFtpResource.ftpServerIP)
{
mstrftpServerIP = value.ToString();
 AddUpdatedFld(conFtpResource.ftpServerIP);
}
else if (strAttributeName  ==  conFtpResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFtpResource.FileDirName);
}
else if (strAttributeName  ==  conFtpResource.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(conFtpResource.FileRename);
}
else if (strAttributeName  ==  conFtpResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFtpResource.FileType);
}
else if (strAttributeName  ==  conFtpResource.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpDate);
}
else if (strAttributeName  ==  conFtpResource.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpTime);
}
else if (strAttributeName  ==  conFtpResource.FileSize)
{
mlngFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResource.FileSize);
}
else if (strAttributeName  ==  conFtpResource.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(conFtpResource.ResourceOwner);
}
else if (strAttributeName  ==  conFtpResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFtpResource.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFtpResource.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (conFtpResource.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (conFtpResource.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (conFtpResource.ftpServerIP  ==  AttributeName[intIndex])
{
return mstrftpServerIP;
}
else if (conFtpResource.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (conFtpResource.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (conFtpResource.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (conFtpResource.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (conFtpResource.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (conFtpResource.FileSize  ==  AttributeName[intIndex])
{
return mlngFileSize;
}
else if (conFtpResource.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (conFtpResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFtpResource.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFtpResource.IdFtpResource);
}
else if (conFtpResource.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(conFtpResource.FtpResourceID);
}
else if (conFtpResource.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(conFtpResource.FileOriginalName);
}
else if (conFtpResource.ftpServerIP  ==  AttributeName[intIndex])
{
mstrftpServerIP = value.ToString();
 AddUpdatedFld(conFtpResource.ftpServerIP);
}
else if (conFtpResource.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(conFtpResource.FileDirName);
}
else if (conFtpResource.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(conFtpResource.FileRename);
}
else if (conFtpResource.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(conFtpResource.FileType);
}
else if (conFtpResource.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpDate);
}
else if (conFtpResource.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(conFtpResource.FileUpTime);
}
else if (conFtpResource.FileSize  ==  AttributeName[intIndex])
{
mlngFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResource.FileSize);
}
else if (conFtpResource.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(conFtpResource.ResourceOwner);
}
else if (conFtpResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFtpResource.Memo);
}
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
 AddUpdatedFld(conFtpResource.IdFtpResource);
}
}
/// <summary>
/// FTP资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpResourceID
{
get
{
return mstrFtpResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpResourceID = value;
}
else
{
 mstrFtpResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResource.FtpResourceID);
}
}
/// <summary>
/// 文件原名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOriginalName
{
get
{
return mstrFileOriginalName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOriginalName = value;
}
else
{
 mstrFileOriginalName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResource.FileOriginalName);
}
}
/// <summary>
/// ftp服务器地址(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpServerIP
{
get
{
return mstrftpServerIP;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpServerIP = value;
}
else
{
 mstrftpServerIP = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResource.ftpServerIP);
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
 AddUpdatedFld(conFtpResource.FileDirName);
}
}
/// <summary>
/// 文件新名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileRename
{
get
{
return mstrFileRename;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileRename = value;
}
else
{
 mstrFileRename = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResource.FileRename);
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
 AddUpdatedFld(conFtpResource.FileType);
}
}
/// <summary>
/// 创建日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileUpDate
{
get
{
return mstrFileUpDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileUpDate = value;
}
else
{
 mstrFileUpDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResource.FileUpDate);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileUpTime
{
get
{
return mstrFileUpTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileUpTime = value;
}
else
{
 mstrFileUpTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResource.FileUpTime);
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
 AddUpdatedFld(conFtpResource.FileSize);
}
}
/// <summary>
/// 创建者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceOwner
{
get
{
return mstrResourceOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceOwner = value;
}
else
{
 mstrResourceOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResource.ResourceOwner);
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
 AddUpdatedFld(conFtpResource.Memo);
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
  return mstrIdFtpResource;
 }
 }
}
 /// <summary>
 /// FTP资源(FtpResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFtpResource
{
public new const string _CurrTabName = "FtpResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdFtpResource"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdFtpResource", "FtpResourceID", "FileOriginalName", "ftpServerIP", "FileDirName", "FileRename", "FileType", "FileUpDate", "FileUpTime", "FileSize", "ResourceOwner", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"FtpResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpResourceID = "FtpResourceID";    //FTP资源ID

 /// <summary>
 /// 常量:"FileOriginalName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginalName = "FileOriginalName";    //文件原名

 /// <summary>
 /// 常量:"ftpServerIP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpServerIP = "ftpServerIP";    //ftp服务器地址

 /// <summary>
 /// 常量:"FileDirName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileDirName = "FileDirName";    //文件目录名

 /// <summary>
 /// 常量:"FileRename"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileRename = "FileRename";    //文件新名

 /// <summary>
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"FileUpDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileUpDate = "FileUpDate";    //创建日期

 /// <summary>
 /// 常量:"FileUpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileUpTime = "FileUpTime";    //创建时间

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //创建者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}