
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationTaskEN
 表名:UiFileRelationTask(00050655)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:49:53
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
 /// 表UiFileRelationTask的关键字(TaskId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TaskId_UiFileRelationTask
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngTaskId">表关键字</param>
public K_TaskId_UiFileRelationTask(long lngTaskId)
{
if (IsValid(lngTaskId)) Value = lngTaskId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngTaskId)
{
if (lngTaskId == 0) return false;
if (lngTaskId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TaskId_UiFileRelationTask]类型的对象</returns>
public static implicit operator K_TaskId_UiFileRelationTask(long value)
{
return new K_TaskId_UiFileRelationTask(value);
}
}
 /// <summary>
 /// UiFileRelationTask(UiFileRelationTask)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUiFileRelationTaskEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UiFileRelationTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TaskId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"TaskId", "PrjId", "EntryFilePath", "EntryFileName", "RootPath", "MaxDepth", "StatusId", "CreatedAt", "FinishedAt", "ErrorMsg", "RequestJson"};

protected long mlngTaskId;    //TaskId
protected string mstrPrjId;    //工程Id
protected string mstrEntryFilePath;    //EntryFilePath
protected string mstrEntryFileName;    //EntryFileName
protected string mstrRootPath;    //RootPath
protected int mintMaxDepth;    //MaxDepth
protected string mstrStatusId;    //StatusId
protected DateTime mdteCreatedAt;    //CreatedAt
protected DateTime mdteFinishedAt;    //FinishedAt
protected string mstrErrorMsg;    //ErrorMsg
protected string mstrRequestJson;    //RequestJson

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUiFileRelationTaskEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TaskId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngTaskId">关键字:TaskId</param>
public clsUiFileRelationTaskEN(long lngTaskId)
 {
 if (lngTaskId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngTaskId = lngTaskId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TaskId");
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
if (strAttributeName  ==  conUiFileRelationTask.TaskId)
{
return mlngTaskId;
}
else if (strAttributeName  ==  conUiFileRelationTask.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUiFileRelationTask.EntryFilePath)
{
return mstrEntryFilePath;
}
else if (strAttributeName  ==  conUiFileRelationTask.EntryFileName)
{
return mstrEntryFileName;
}
else if (strAttributeName  ==  conUiFileRelationTask.RootPath)
{
return mstrRootPath;
}
else if (strAttributeName  ==  conUiFileRelationTask.MaxDepth)
{
return mintMaxDepth;
}
else if (strAttributeName  ==  conUiFileRelationTask.StatusId)
{
return mstrStatusId;
}
else if (strAttributeName  ==  conUiFileRelationTask.CreatedAt)
{
return mdteCreatedAt;
}
else if (strAttributeName  ==  conUiFileRelationTask.FinishedAt)
{
return mdteFinishedAt;
}
else if (strAttributeName  ==  conUiFileRelationTask.ErrorMsg)
{
return mstrErrorMsg;
}
else if (strAttributeName  ==  conUiFileRelationTask.RequestJson)
{
return mstrRequestJson;
}
return null;
}
set
{
if (strAttributeName  ==  conUiFileRelationTask.TaskId)
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.TaskId);
}
else if (strAttributeName  ==  conUiFileRelationTask.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.PrjId);
}
else if (strAttributeName  ==  conUiFileRelationTask.EntryFilePath)
{
mstrEntryFilePath = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.EntryFilePath);
}
else if (strAttributeName  ==  conUiFileRelationTask.EntryFileName)
{
mstrEntryFileName = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.EntryFileName);
}
else if (strAttributeName  ==  conUiFileRelationTask.RootPath)
{
mstrRootPath = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.RootPath);
}
else if (strAttributeName  ==  conUiFileRelationTask.MaxDepth)
{
mintMaxDepth = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.MaxDepth);
}
else if (strAttributeName  ==  conUiFileRelationTask.StatusId)
{
mstrStatusId = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.StatusId);
}
else if (strAttributeName  ==  conUiFileRelationTask.CreatedAt)
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.CreatedAt);
}
else if (strAttributeName  ==  conUiFileRelationTask.FinishedAt)
{
mdteFinishedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.FinishedAt);
}
else if (strAttributeName  ==  conUiFileRelationTask.ErrorMsg)
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.ErrorMsg);
}
else if (strAttributeName  ==  conUiFileRelationTask.RequestJson)
{
mstrRequestJson = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.RequestJson);
}
}
}
public object this[int intIndex]
{
get
{
if (conUiFileRelationTask.TaskId  ==  _AttributeName[intIndex])
{
return mlngTaskId;
}
else if (conUiFileRelationTask.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUiFileRelationTask.EntryFilePath  ==  _AttributeName[intIndex])
{
return mstrEntryFilePath;
}
else if (conUiFileRelationTask.EntryFileName  ==  _AttributeName[intIndex])
{
return mstrEntryFileName;
}
else if (conUiFileRelationTask.RootPath  ==  _AttributeName[intIndex])
{
return mstrRootPath;
}
else if (conUiFileRelationTask.MaxDepth  ==  _AttributeName[intIndex])
{
return mintMaxDepth;
}
else if (conUiFileRelationTask.StatusId  ==  _AttributeName[intIndex])
{
return mstrStatusId;
}
else if (conUiFileRelationTask.CreatedAt  ==  _AttributeName[intIndex])
{
return mdteCreatedAt;
}
else if (conUiFileRelationTask.FinishedAt  ==  _AttributeName[intIndex])
{
return mdteFinishedAt;
}
else if (conUiFileRelationTask.ErrorMsg  ==  _AttributeName[intIndex])
{
return mstrErrorMsg;
}
else if (conUiFileRelationTask.RequestJson  ==  _AttributeName[intIndex])
{
return mstrRequestJson;
}
return null;
}
set
{
if (conUiFileRelationTask.TaskId  ==  _AttributeName[intIndex])
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.TaskId);
}
else if (conUiFileRelationTask.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.PrjId);
}
else if (conUiFileRelationTask.EntryFilePath  ==  _AttributeName[intIndex])
{
mstrEntryFilePath = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.EntryFilePath);
}
else if (conUiFileRelationTask.EntryFileName  ==  _AttributeName[intIndex])
{
mstrEntryFileName = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.EntryFileName);
}
else if (conUiFileRelationTask.RootPath  ==  _AttributeName[intIndex])
{
mstrRootPath = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.RootPath);
}
else if (conUiFileRelationTask.MaxDepth  ==  _AttributeName[intIndex])
{
mintMaxDepth = TransNullToInt(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.MaxDepth);
}
else if (conUiFileRelationTask.StatusId  ==  _AttributeName[intIndex])
{
mstrStatusId = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.StatusId);
}
else if (conUiFileRelationTask.CreatedAt  ==  _AttributeName[intIndex])
{
mdteCreatedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.CreatedAt);
}
else if (conUiFileRelationTask.FinishedAt  ==  _AttributeName[intIndex])
{
mdteFinishedAt = TransNullToDate(value.ToString());
 AddUpdatedFld(conUiFileRelationTask.FinishedAt);
}
else if (conUiFileRelationTask.ErrorMsg  ==  _AttributeName[intIndex])
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.ErrorMsg);
}
else if (conUiFileRelationTask.RequestJson  ==  _AttributeName[intIndex])
{
mstrRequestJson = value.ToString();
 AddUpdatedFld(conUiFileRelationTask.RequestJson);
}
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
 AddUpdatedFld(conUiFileRelationTask.TaskId);
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
 AddUpdatedFld(conUiFileRelationTask.PrjId);
}
}
/// <summary>
/// EntryFilePath(说明:;字段类型:nvarchar;字段长度:1000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EntryFilePath
{
get
{
return mstrEntryFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryFilePath = value;
}
else
{
 mstrEntryFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.EntryFilePath);
}
}
/// <summary>
/// EntryFileName(说明:;字段类型:nvarchar;字段长度:400;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EntryFileName
{
get
{
return mstrEntryFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryFileName = value;
}
else
{
 mstrEntryFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.EntryFileName);
}
}
/// <summary>
/// RootPath(说明:;字段类型:nvarchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RootPath
{
get
{
return mstrRootPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRootPath = value;
}
else
{
 mstrRootPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.RootPath);
}
}
/// <summary>
/// MaxDepth(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int MaxDepth
{
get
{
return mintMaxDepth;
}
set
{
 mintMaxDepth = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.MaxDepth);
}
}
/// <summary>
/// StatusId(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StatusId
{
get
{
return mstrStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatusId = value;
}
else
{
 mstrStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.StatusId);
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
 AddUpdatedFld(conUiFileRelationTask.CreatedAt);
}
}
/// <summary>
/// FinishedAt(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime FinishedAt
{
get
{
return mdteFinishedAt;
}
set
{
 mdteFinishedAt = value;
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.FinishedAt);
}
}
/// <summary>
/// ErrorMsg(说明:;字段类型:ntext;字段长度:2147483646;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorMsg
{
get
{
return mstrErrorMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorMsg = value;
}
else
{
 mstrErrorMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.ErrorMsg);
}
}
/// <summary>
/// RequestJson(说明:;字段类型:ntext;字段长度:2147483646;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequestJson
{
get
{
return mstrRequestJson;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequestJson = value;
}
else
{
 mstrRequestJson = value;
}
//记录修改过的字段
 AddUpdatedFld(conUiFileRelationTask.RequestJson);
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
  return mlngTaskId.ToString();
 }
 }
}
 /// <summary>
 /// UiFileRelationTask(UiFileRelationTask)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUiFileRelationTask
{
public const string _CurrTabName = "UiFileRelationTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TaskId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TaskId", "PrjId", "EntryFilePath", "EntryFileName", "RootPath", "MaxDepth", "StatusId", "CreatedAt", "FinishedAt", "ErrorMsg", "RequestJson"};
//以下是属性变量


 /// <summary>
 /// 常量:"TaskId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TaskId = "TaskId";    //TaskId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"EntryFilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryFilePath = "EntryFilePath";    //EntryFilePath

 /// <summary>
 /// 常量:"EntryFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryFileName = "EntryFileName";    //EntryFileName

 /// <summary>
 /// 常量:"RootPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RootPath = "RootPath";    //RootPath

 /// <summary>
 /// 常量:"MaxDepth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MaxDepth = "MaxDepth";    //MaxDepth

 /// <summary>
 /// 常量:"StatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StatusId = "StatusId";    //StatusId

 /// <summary>
 /// 常量:"CreatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedAt = "CreatedAt";    //CreatedAt

 /// <summary>
 /// 常量:"FinishedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FinishedAt = "FinishedAt";    //FinishedAt

 /// <summary>
 /// 常量:"ErrorMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorMsg = "ErrorMsg";    //ErrorMsg

 /// <summary>
 /// 常量:"RequestJson"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestJson = "RequestJson";    //RequestJson
}

}