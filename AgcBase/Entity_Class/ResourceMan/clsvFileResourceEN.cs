
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFileResourceEN
 表名:vFileResource(00050540)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
 /// 表vFileResource的关键字(FileResourceID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FileResourceID_vFileResource
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
public K_FileResourceID_vFileResource(long lngFileResourceID)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FileResourceID_vFileResource]类型的对象</returns>
public static implicit operator K_FileResourceID_vFileResource(long value)
{
return new K_FileResourceID_vFileResource(value);
}
}
 /// <summary>
 /// v文件资源(vFileResource)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFileResourceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"FileResourceID", "FileDirName", "FileName", "Extension", "TabId", "TabName", "TabCnName", "TabStateId", "FuncModuleAgcId", "FuncModuleName", "IsBelongsCurrCMPrj", "IsGeneCode", "IsCanDel", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "PrjId", "PrjName", "CmPrjId", "CmPrjName", "IpAddress", "UpdDate", "UpdUser", "Memo"};

protected long mlngFileResourceID;    //FileResourceID
protected string mstrFileDirName;    //文件目录名
protected string mstrFileName;    //文件名
protected string mstrExtension;    //扩展名
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrTabStateId;    //表状态ID
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
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
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrCmPrjId;    //CM工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrIpAddress;    //服务器
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFileResourceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vFileResource";
 lstKeyFldNames.Add("FileResourceID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngFileResourceID">关键字:FileResourceID</param>
public clsvFileResourceEN(long lngFileResourceID)
 {
 if (lngFileResourceID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngFileResourceID = lngFileResourceID;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vFileResource";
 lstKeyFldNames.Add("FileResourceID");
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
if (strAttributeName  ==  convFileResource.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  convFileResource.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convFileResource.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convFileResource.Extension)
{
return mstrExtension;
}
else if (strAttributeName  ==  convFileResource.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convFileResource.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convFileResource.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convFileResource.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convFileResource.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convFileResource.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convFileResource.IsBelongsCurrCMPrj)
{
return mbolIsBelongsCurrCMPrj;
}
else if (strAttributeName  ==  convFileResource.IsGeneCode)
{
return mbolIsGeneCode;
}
else if (strAttributeName  ==  convFileResource.IsCanDel)
{
return mbolIsCanDel;
}
else if (strAttributeName  ==  convFileResource.FileLength)
{
return mlngFileLength;
}
else if (strAttributeName  ==  convFileResource.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convFileResource.CreationTime)
{
return mstrCreationTime;
}
else if (strAttributeName  ==  convFileResource.LastWriteTime)
{
return mstrLastWriteTime;
}
else if (strAttributeName  ==  convFileResource.CheckDateTime)
{
return mstrCheckDateTime;
}
else if (strAttributeName  ==  convFileResource.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convFileResource.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convFileResource.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFileResource.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convFileResource.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convFileResource.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convFileResource.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convFileResource.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFileResource.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFileResource.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFileResource.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileResourceID);
}
else if (strAttributeName  ==  convFileResource.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFileResource.FileDirName);
}
else if (strAttributeName  ==  convFileResource.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convFileResource.FileName);
}
else if (strAttributeName  ==  convFileResource.Extension)
{
mstrExtension = value.ToString();
 AddUpdatedFld(convFileResource.Extension);
}
else if (strAttributeName  ==  convFileResource.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convFileResource.TabId);
}
else if (strAttributeName  ==  convFileResource.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFileResource.TabName);
}
else if (strAttributeName  ==  convFileResource.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convFileResource.TabCnName);
}
else if (strAttributeName  ==  convFileResource.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convFileResource.TabStateId);
}
else if (strAttributeName  ==  convFileResource.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convFileResource.FuncModuleAgcId);
}
else if (strAttributeName  ==  convFileResource.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFileResource.FuncModuleName);
}
else if (strAttributeName  ==  convFileResource.IsBelongsCurrCMPrj)
{
mbolIsBelongsCurrCMPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsBelongsCurrCMPrj);
}
else if (strAttributeName  ==  convFileResource.IsGeneCode)
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsGeneCode);
}
else if (strAttributeName  ==  convFileResource.IsCanDel)
{
mbolIsCanDel = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsCanDel);
}
else if (strAttributeName  ==  convFileResource.FileLength)
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileLength);
}
else if (strAttributeName  ==  convFileResource.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFileResource.FileType);
}
else if (strAttributeName  ==  convFileResource.CreationTime)
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(convFileResource.CreationTime);
}
else if (strAttributeName  ==  convFileResource.LastWriteTime)
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(convFileResource.LastWriteTime);
}
else if (strAttributeName  ==  convFileResource.CheckDateTime)
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFileResource.CheckDateTime);
}
else if (strAttributeName  ==  convFileResource.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.InUse);
}
else if (strAttributeName  ==  convFileResource.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsExistFile);
}
else if (strAttributeName  ==  convFileResource.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFileResource.PrjId);
}
else if (strAttributeName  ==  convFileResource.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFileResource.PrjName);
}
else if (strAttributeName  ==  convFileResource.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convFileResource.CmPrjId);
}
else if (strAttributeName  ==  convFileResource.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convFileResource.CmPrjName);
}
else if (strAttributeName  ==  convFileResource.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convFileResource.IpAddress);
}
else if (strAttributeName  ==  convFileResource.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFileResource.UpdDate);
}
else if (strAttributeName  ==  convFileResource.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFileResource.UpdUser);
}
else if (strAttributeName  ==  convFileResource.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFileResource.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFileResource.FileResourceID  ==  AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (convFileResource.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convFileResource.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convFileResource.Extension  ==  AttributeName[intIndex])
{
return mstrExtension;
}
else if (convFileResource.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convFileResource.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (convFileResource.TabCnName  ==  AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convFileResource.TabStateId  ==  AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convFileResource.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convFileResource.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convFileResource.IsBelongsCurrCMPrj  ==  AttributeName[intIndex])
{
return mbolIsBelongsCurrCMPrj;
}
else if (convFileResource.IsGeneCode  ==  AttributeName[intIndex])
{
return mbolIsGeneCode;
}
else if (convFileResource.IsCanDel  ==  AttributeName[intIndex])
{
return mbolIsCanDel;
}
else if (convFileResource.FileLength  ==  AttributeName[intIndex])
{
return mlngFileLength;
}
else if (convFileResource.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convFileResource.CreationTime  ==  AttributeName[intIndex])
{
return mstrCreationTime;
}
else if (convFileResource.LastWriteTime  ==  AttributeName[intIndex])
{
return mstrLastWriteTime;
}
else if (convFileResource.CheckDateTime  ==  AttributeName[intIndex])
{
return mstrCheckDateTime;
}
else if (convFileResource.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convFileResource.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convFileResource.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFileResource.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convFileResource.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convFileResource.CmPrjName  ==  AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convFileResource.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convFileResource.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFileResource.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFileResource.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFileResource.FileResourceID  ==  AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileResourceID);
}
else if (convFileResource.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convFileResource.FileDirName);
}
else if (convFileResource.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convFileResource.FileName);
}
else if (convFileResource.Extension  ==  AttributeName[intIndex])
{
mstrExtension = value.ToString();
 AddUpdatedFld(convFileResource.Extension);
}
else if (convFileResource.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convFileResource.TabId);
}
else if (convFileResource.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convFileResource.TabName);
}
else if (convFileResource.TabCnName  ==  AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convFileResource.TabCnName);
}
else if (convFileResource.TabStateId  ==  AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convFileResource.TabStateId);
}
else if (convFileResource.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convFileResource.FuncModuleAgcId);
}
else if (convFileResource.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convFileResource.FuncModuleName);
}
else if (convFileResource.IsBelongsCurrCMPrj  ==  AttributeName[intIndex])
{
mbolIsBelongsCurrCMPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsBelongsCurrCMPrj);
}
else if (convFileResource.IsGeneCode  ==  AttributeName[intIndex])
{
mbolIsGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsGeneCode);
}
else if (convFileResource.IsCanDel  ==  AttributeName[intIndex])
{
mbolIsCanDel = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsCanDel);
}
else if (convFileResource.FileLength  ==  AttributeName[intIndex])
{
mlngFileLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFileResource.FileLength);
}
else if (convFileResource.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convFileResource.FileType);
}
else if (convFileResource.CreationTime  ==  AttributeName[intIndex])
{
mstrCreationTime = value.ToString();
 AddUpdatedFld(convFileResource.CreationTime);
}
else if (convFileResource.LastWriteTime  ==  AttributeName[intIndex])
{
mstrLastWriteTime = value.ToString();
 AddUpdatedFld(convFileResource.LastWriteTime);
}
else if (convFileResource.CheckDateTime  ==  AttributeName[intIndex])
{
mstrCheckDateTime = value.ToString();
 AddUpdatedFld(convFileResource.CheckDateTime);
}
else if (convFileResource.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.InUse);
}
else if (convFileResource.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convFileResource.IsExistFile);
}
else if (convFileResource.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFileResource.PrjId);
}
else if (convFileResource.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convFileResource.PrjName);
}
else if (convFileResource.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convFileResource.CmPrjId);
}
else if (convFileResource.CmPrjName  ==  AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convFileResource.CmPrjName);
}
else if (convFileResource.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convFileResource.IpAddress);
}
else if (convFileResource.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFileResource.UpdDate);
}
else if (convFileResource.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFileResource.UpdUser);
}
else if (convFileResource.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFileResource.Memo);
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
 AddUpdatedFld(convFileResource.FileResourceID);
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
 AddUpdatedFld(convFileResource.FileDirName);
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
 AddUpdatedFld(convFileResource.FileName);
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
 AddUpdatedFld(convFileResource.Extension);
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
 AddUpdatedFld(convFileResource.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFileResource.TabName);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFileResource.TabCnName);
}
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFileResource.TabStateId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFileResource.FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFileResource.FuncModuleName);
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
 AddUpdatedFld(convFileResource.IsBelongsCurrCMPrj);
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
 AddUpdatedFld(convFileResource.IsGeneCode);
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
 AddUpdatedFld(convFileResource.IsCanDel);
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
 AddUpdatedFld(convFileResource.FileLength);
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
 AddUpdatedFld(convFileResource.FileType);
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
 AddUpdatedFld(convFileResource.CreationTime);
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
 AddUpdatedFld(convFileResource.LastWriteTime);
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
 AddUpdatedFld(convFileResource.CheckDateTime);
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
 AddUpdatedFld(convFileResource.InUse);
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
 AddUpdatedFld(convFileResource.IsExistFile);
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
 AddUpdatedFld(convFileResource.PrjId);
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
 AddUpdatedFld(convFileResource.PrjName);
}
}
/// <summary>
/// CM工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
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
 AddUpdatedFld(convFileResource.CmPrjId);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFileResource.CmPrjName);
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
 AddUpdatedFld(convFileResource.IpAddress);
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
 AddUpdatedFld(convFileResource.UpdDate);
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
 AddUpdatedFld(convFileResource.UpdUser);
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
 AddUpdatedFld(convFileResource.Memo);
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
  return mlngFileResourceID.ToString();
 }
 }
}
 /// <summary>
 /// v文件资源(vFileResource)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFileResource
{
public new const string _CurrTabName = "vFileResource"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FileResourceID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FileResourceID", "FileDirName", "FileName", "Extension", "TabId", "TabName", "TabCnName", "TabStateId", "FuncModuleAgcId", "FuncModuleName", "IsBelongsCurrCMPrj", "IsGeneCode", "IsCanDel", "FileLength", "FileType", "CreationTime", "LastWriteTime", "CheckDateTime", "InUse", "IsExistFile", "PrjId", "PrjName", "CmPrjId", "CmPrjName", "IpAddress", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

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
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CM工程Id

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //服务器

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