
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewReferFilesEN
 表名:vViewReferFiles(00050466)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:42:04
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
 /// 表vViewReferFiles的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vViewReferFiles
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
public K_mId_vViewReferFiles(long lngmId)
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
 /// <returns>返回:[K_mId_vViewReferFiles]类型的对象</returns>
public static implicit operator K_mId_vViewReferFiles(long value)
{
return new K_mId_vViewReferFiles(value);
}
}
 /// <summary>
 /// v界面引用文件(vViewReferFiles)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewReferFilesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 17;
public static string[] _AttributeName = new string[] {"mId", "ViewId", "ViewName", "PrjId", "CodeTypeId", "CodeTypeName", "ReferFileId", "FileName", "ReferFileTypeId", "ReferFileTypeName", "FilePath", "InUse", "OrderNum", "IsTemplate", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrViewId;    //界面Id
protected string mstrViewName;    //界面名称
protected string mstrPrjId;    //工程Id
protected string mstrCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrReferFileId;    //引用文件Id
protected string mstrFileName;    //文件名
protected string mstrReferFileTypeId;    //引用文件类型Id
protected string mstrReferFileTypeName;    //引用文件类型名
protected string mstrFilePath;    //文件路径
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected bool mbolIsTemplate;    //是否模板
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvViewReferFilesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvViewReferFilesEN(long lngmId)
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
return _AttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convViewReferFiles.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convViewReferFiles.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convViewReferFiles.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convViewReferFiles.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convViewReferFiles.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  convViewReferFiles.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convViewReferFiles.ReferFileId)
{
return mstrReferFileId;
}
else if (strAttributeName  ==  convViewReferFiles.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convViewReferFiles.ReferFileTypeId)
{
return mstrReferFileTypeId;
}
else if (strAttributeName  ==  convViewReferFiles.ReferFileTypeName)
{
return mstrReferFileTypeName;
}
else if (strAttributeName  ==  convViewReferFiles.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  convViewReferFiles.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convViewReferFiles.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convViewReferFiles.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convViewReferFiles.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewReferFiles.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convViewReferFiles.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convViewReferFiles.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewReferFiles.mId);
}
else if (strAttributeName  ==  convViewReferFiles.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewReferFiles.ViewId);
}
else if (strAttributeName  ==  convViewReferFiles.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewReferFiles.ViewName);
}
else if (strAttributeName  ==  convViewReferFiles.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewReferFiles.PrjId);
}
else if (strAttributeName  ==  convViewReferFiles.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convViewReferFiles.CodeTypeId);
}
else if (strAttributeName  ==  convViewReferFiles.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convViewReferFiles.CodeTypeName);
}
else if (strAttributeName  ==  convViewReferFiles.ReferFileId)
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(convViewReferFiles.ReferFileId);
}
else if (strAttributeName  ==  convViewReferFiles.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewReferFiles.FileName);
}
else if (strAttributeName  ==  convViewReferFiles.ReferFileTypeId)
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(convViewReferFiles.ReferFileTypeId);
}
else if (strAttributeName  ==  convViewReferFiles.ReferFileTypeName)
{
mstrReferFileTypeName = value.ToString();
 AddUpdatedFld(convViewReferFiles.ReferFileTypeName);
}
else if (strAttributeName  ==  convViewReferFiles.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewReferFiles.FilePath);
}
else if (strAttributeName  ==  convViewReferFiles.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewReferFiles.InUse);
}
else if (strAttributeName  ==  convViewReferFiles.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewReferFiles.OrderNum);
}
else if (strAttributeName  ==  convViewReferFiles.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewReferFiles.IsTemplate);
}
else if (strAttributeName  ==  convViewReferFiles.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewReferFiles.UpdDate);
}
else if (strAttributeName  ==  convViewReferFiles.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewReferFiles.UpdUserId);
}
else if (strAttributeName  ==  convViewReferFiles.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewReferFiles.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewReferFiles.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convViewReferFiles.ViewId  ==  _AttributeName[intIndex])
{
return mstrViewId;
}
else if (convViewReferFiles.ViewName  ==  _AttributeName[intIndex])
{
return mstrViewName;
}
else if (convViewReferFiles.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convViewReferFiles.CodeTypeId  ==  _AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (convViewReferFiles.CodeTypeName  ==  _AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convViewReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
return mstrReferFileId;
}
else if (convViewReferFiles.FileName  ==  _AttributeName[intIndex])
{
return mstrFileName;
}
else if (convViewReferFiles.ReferFileTypeId  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeId;
}
else if (convViewReferFiles.ReferFileTypeName  ==  _AttributeName[intIndex])
{
return mstrReferFileTypeName;
}
else if (convViewReferFiles.FilePath  ==  _AttributeName[intIndex])
{
return mstrFilePath;
}
else if (convViewReferFiles.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convViewReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convViewReferFiles.IsTemplate  ==  _AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convViewReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convViewReferFiles.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convViewReferFiles.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewReferFiles.mId);
}
else if (convViewReferFiles.ViewId  ==  _AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convViewReferFiles.ViewId);
}
else if (convViewReferFiles.ViewName  ==  _AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convViewReferFiles.ViewName);
}
else if (convViewReferFiles.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convViewReferFiles.PrjId);
}
else if (convViewReferFiles.CodeTypeId  ==  _AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(convViewReferFiles.CodeTypeId);
}
else if (convViewReferFiles.CodeTypeName  ==  _AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convViewReferFiles.CodeTypeName);
}
else if (convViewReferFiles.ReferFileId  ==  _AttributeName[intIndex])
{
mstrReferFileId = value.ToString();
 AddUpdatedFld(convViewReferFiles.ReferFileId);
}
else if (convViewReferFiles.FileName  ==  _AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convViewReferFiles.FileName);
}
else if (convViewReferFiles.ReferFileTypeId  ==  _AttributeName[intIndex])
{
mstrReferFileTypeId = value.ToString();
 AddUpdatedFld(convViewReferFiles.ReferFileTypeId);
}
else if (convViewReferFiles.ReferFileTypeName  ==  _AttributeName[intIndex])
{
mstrReferFileTypeName = value.ToString();
 AddUpdatedFld(convViewReferFiles.ReferFileTypeName);
}
else if (convViewReferFiles.FilePath  ==  _AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(convViewReferFiles.FilePath);
}
else if (convViewReferFiles.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewReferFiles.InUse);
}
else if (convViewReferFiles.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewReferFiles.OrderNum);
}
else if (convViewReferFiles.IsTemplate  ==  _AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewReferFiles.IsTemplate);
}
else if (convViewReferFiles.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewReferFiles.UpdDate);
}
else if (convViewReferFiles.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewReferFiles.UpdUserId);
}
else if (convViewReferFiles.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewReferFiles.Memo);
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
 AddUpdatedFld(convViewReferFiles.mId);
}
}
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewReferFiles.ViewId);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewReferFiles.ViewName);
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
 AddUpdatedFld(convViewReferFiles.PrjId);
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
 AddUpdatedFld(convViewReferFiles.CodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewReferFiles.CodeTypeName);
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
 AddUpdatedFld(convViewReferFiles.ReferFileId);
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
 AddUpdatedFld(convViewReferFiles.FileName);
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
 AddUpdatedFld(convViewReferFiles.ReferFileTypeId);
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
 AddUpdatedFld(convViewReferFiles.ReferFileTypeName);
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
 AddUpdatedFld(convViewReferFiles.FilePath);
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
 AddUpdatedFld(convViewReferFiles.InUse);
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
 AddUpdatedFld(convViewReferFiles.OrderNum);
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
 AddUpdatedFld(convViewReferFiles.IsTemplate);
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
 AddUpdatedFld(convViewReferFiles.UpdDate);
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
 AddUpdatedFld(convViewReferFiles.UpdUserId);
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
 AddUpdatedFld(convViewReferFiles.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v界面引用文件(vViewReferFiles)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewReferFiles
{
public const string _CurrTabName = "vViewReferFiles"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "ViewId", "ViewName", "PrjId", "CodeTypeId", "CodeTypeName", "ReferFileId", "FileName", "ReferFileTypeId", "ReferFileTypeName", "FilePath", "InUse", "OrderNum", "IsTemplate", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面Id

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

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
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

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