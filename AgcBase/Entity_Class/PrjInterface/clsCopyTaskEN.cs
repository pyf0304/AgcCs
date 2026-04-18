
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskEN
 表名:CopyTask(00050643)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:20:24
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
 /// 表CopyTask的关键字(TaskId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TaskId_CopyTask
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
public K_TaskId_CopyTask(long lngTaskId)
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
 /// <returns>返回:[K_TaskId_CopyTask]类型的对象</returns>
public static implicit operator K_TaskId_CopyTask(long value)
{
return new K_TaskId_CopyTask(value);
}
}
 /// <summary>
 /// CopyTask(CopyTask)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCopyTaskEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CopyTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TaskId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"TaskId", "SourcePrjId", "TargetPrjId", "SourceViewId", "TargetViewId", "ConflictStrategy", "Status", "CurrentStep", "ErrorMessage", "CreatedBy", "CreatedTime", "UpdatedTime", "TargetViewName"};

protected long mlngTaskId;    //TaskId
protected string mstrSourcePrjId;    //SourcePrjId
protected string mstrTargetPrjId;    //TargetPrjId
protected string mstrSourceViewId;    //SourceViewId
protected string mstrTargetViewId;    //TargetViewId
protected string mstrConflictStrategy;    //ConflictStrategy
protected string mstrStatus;    //Status
protected string mstrCurrentStep;    //CurrentStep
protected string mstrErrorMessage;    //错误信息
protected string mstrCreatedBy;    //CreatedBy
protected DateTime mdteCreatedTime;    //CreatedTime
protected DateTime mdteUpdatedTime;    //UpdatedTime
protected string mstrTargetViewName;    //TargetViewName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCopyTaskEN()
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
public clsCopyTaskEN(long lngTaskId)
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
if (strAttributeName  ==  conCopyTask.TaskId)
{
return mlngTaskId;
}
else if (strAttributeName  ==  conCopyTask.SourcePrjId)
{
return mstrSourcePrjId;
}
else if (strAttributeName  ==  conCopyTask.TargetPrjId)
{
return mstrTargetPrjId;
}
else if (strAttributeName  ==  conCopyTask.SourceViewId)
{
return mstrSourceViewId;
}
else if (strAttributeName  ==  conCopyTask.TargetViewId)
{
return mstrTargetViewId;
}
else if (strAttributeName  ==  conCopyTask.ConflictStrategy)
{
return mstrConflictStrategy;
}
else if (strAttributeName  ==  conCopyTask.Status)
{
return mstrStatus;
}
else if (strAttributeName  ==  conCopyTask.CurrentStep)
{
return mstrCurrentStep;
}
else if (strAttributeName  ==  conCopyTask.ErrorMessage)
{
return mstrErrorMessage;
}
else if (strAttributeName  ==  conCopyTask.CreatedBy)
{
return mstrCreatedBy;
}
else if (strAttributeName  ==  conCopyTask.CreatedTime)
{
return mdteCreatedTime;
}
else if (strAttributeName  ==  conCopyTask.UpdatedTime)
{
return mdteUpdatedTime;
}
else if (strAttributeName  ==  conCopyTask.TargetViewName)
{
return mstrTargetViewName;
}
return null;
}
set
{
if (strAttributeName  ==  conCopyTask.TaskId)
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTask.TaskId);
}
else if (strAttributeName  ==  conCopyTask.SourcePrjId)
{
mstrSourcePrjId = value.ToString();
 AddUpdatedFld(conCopyTask.SourcePrjId);
}
else if (strAttributeName  ==  conCopyTask.TargetPrjId)
{
mstrTargetPrjId = value.ToString();
 AddUpdatedFld(conCopyTask.TargetPrjId);
}
else if (strAttributeName  ==  conCopyTask.SourceViewId)
{
mstrSourceViewId = value.ToString();
 AddUpdatedFld(conCopyTask.SourceViewId);
}
else if (strAttributeName  ==  conCopyTask.TargetViewId)
{
mstrTargetViewId = value.ToString();
 AddUpdatedFld(conCopyTask.TargetViewId);
}
else if (strAttributeName  ==  conCopyTask.ConflictStrategy)
{
mstrConflictStrategy = value.ToString();
 AddUpdatedFld(conCopyTask.ConflictStrategy);
}
else if (strAttributeName  ==  conCopyTask.Status)
{
mstrStatus = value.ToString();
 AddUpdatedFld(conCopyTask.Status);
}
else if (strAttributeName  ==  conCopyTask.CurrentStep)
{
mstrCurrentStep = value.ToString();
 AddUpdatedFld(conCopyTask.CurrentStep);
}
else if (strAttributeName  ==  conCopyTask.ErrorMessage)
{
mstrErrorMessage = value.ToString();
 AddUpdatedFld(conCopyTask.ErrorMessage);
}
else if (strAttributeName  ==  conCopyTask.CreatedBy)
{
mstrCreatedBy = value.ToString();
 AddUpdatedFld(conCopyTask.CreatedBy);
}
else if (strAttributeName  ==  conCopyTask.CreatedTime)
{
mdteCreatedTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conCopyTask.CreatedTime);
}
else if (strAttributeName  ==  conCopyTask.UpdatedTime)
{
mdteUpdatedTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conCopyTask.UpdatedTime);
}
else if (strAttributeName  ==  conCopyTask.TargetViewName)
{
mstrTargetViewName = value.ToString();
 AddUpdatedFld(conCopyTask.TargetViewName);
}
}
}
public object this[int intIndex]
{
get
{
if (conCopyTask.TaskId  ==  _AttributeName[intIndex])
{
return mlngTaskId;
}
else if (conCopyTask.SourcePrjId  ==  _AttributeName[intIndex])
{
return mstrSourcePrjId;
}
else if (conCopyTask.TargetPrjId  ==  _AttributeName[intIndex])
{
return mstrTargetPrjId;
}
else if (conCopyTask.SourceViewId  ==  _AttributeName[intIndex])
{
return mstrSourceViewId;
}
else if (conCopyTask.TargetViewId  ==  _AttributeName[intIndex])
{
return mstrTargetViewId;
}
else if (conCopyTask.ConflictStrategy  ==  _AttributeName[intIndex])
{
return mstrConflictStrategy;
}
else if (conCopyTask.Status  ==  _AttributeName[intIndex])
{
return mstrStatus;
}
else if (conCopyTask.CurrentStep  ==  _AttributeName[intIndex])
{
return mstrCurrentStep;
}
else if (conCopyTask.ErrorMessage  ==  _AttributeName[intIndex])
{
return mstrErrorMessage;
}
else if (conCopyTask.CreatedBy  ==  _AttributeName[intIndex])
{
return mstrCreatedBy;
}
else if (conCopyTask.CreatedTime  ==  _AttributeName[intIndex])
{
return mdteCreatedTime;
}
else if (conCopyTask.UpdatedTime  ==  _AttributeName[intIndex])
{
return mdteUpdatedTime;
}
else if (conCopyTask.TargetViewName  ==  _AttributeName[intIndex])
{
return mstrTargetViewName;
}
return null;
}
set
{
if (conCopyTask.TaskId  ==  _AttributeName[intIndex])
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTask.TaskId);
}
else if (conCopyTask.SourcePrjId  ==  _AttributeName[intIndex])
{
mstrSourcePrjId = value.ToString();
 AddUpdatedFld(conCopyTask.SourcePrjId);
}
else if (conCopyTask.TargetPrjId  ==  _AttributeName[intIndex])
{
mstrTargetPrjId = value.ToString();
 AddUpdatedFld(conCopyTask.TargetPrjId);
}
else if (conCopyTask.SourceViewId  ==  _AttributeName[intIndex])
{
mstrSourceViewId = value.ToString();
 AddUpdatedFld(conCopyTask.SourceViewId);
}
else if (conCopyTask.TargetViewId  ==  _AttributeName[intIndex])
{
mstrTargetViewId = value.ToString();
 AddUpdatedFld(conCopyTask.TargetViewId);
}
else if (conCopyTask.ConflictStrategy  ==  _AttributeName[intIndex])
{
mstrConflictStrategy = value.ToString();
 AddUpdatedFld(conCopyTask.ConflictStrategy);
}
else if (conCopyTask.Status  ==  _AttributeName[intIndex])
{
mstrStatus = value.ToString();
 AddUpdatedFld(conCopyTask.Status);
}
else if (conCopyTask.CurrentStep  ==  _AttributeName[intIndex])
{
mstrCurrentStep = value.ToString();
 AddUpdatedFld(conCopyTask.CurrentStep);
}
else if (conCopyTask.ErrorMessage  ==  _AttributeName[intIndex])
{
mstrErrorMessage = value.ToString();
 AddUpdatedFld(conCopyTask.ErrorMessage);
}
else if (conCopyTask.CreatedBy  ==  _AttributeName[intIndex])
{
mstrCreatedBy = value.ToString();
 AddUpdatedFld(conCopyTask.CreatedBy);
}
else if (conCopyTask.CreatedTime  ==  _AttributeName[intIndex])
{
mdteCreatedTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conCopyTask.CreatedTime);
}
else if (conCopyTask.UpdatedTime  ==  _AttributeName[intIndex])
{
mdteUpdatedTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conCopyTask.UpdatedTime);
}
else if (conCopyTask.TargetViewName  ==  _AttributeName[intIndex])
{
mstrTargetViewName = value.ToString();
 AddUpdatedFld(conCopyTask.TargetViewName);
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
 AddUpdatedFld(conCopyTask.TaskId);
}
}
/// <summary>
/// SourcePrjId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourcePrjId
{
get
{
return mstrSourcePrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourcePrjId = value;
}
else
{
 mstrSourcePrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.SourcePrjId);
}
}
/// <summary>
/// TargetPrjId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetPrjId
{
get
{
return mstrTargetPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetPrjId = value;
}
else
{
 mstrTargetPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.TargetPrjId);
}
}
/// <summary>
/// SourceViewId(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceViewId
{
get
{
return mstrSourceViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceViewId = value;
}
else
{
 mstrSourceViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.SourceViewId);
}
}
/// <summary>
/// TargetViewId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetViewId
{
get
{
return mstrTargetViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetViewId = value;
}
else
{
 mstrTargetViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.TargetViewId);
}
}
/// <summary>
/// ConflictStrategy(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConflictStrategy
{
get
{
return mstrConflictStrategy;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConflictStrategy = value;
}
else
{
 mstrConflictStrategy = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.ConflictStrategy);
}
}
/// <summary>
/// Status(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Status
{
get
{
return mstrStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatus = value;
}
else
{
 mstrStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.Status);
}
}
/// <summary>
/// CurrentStep(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CurrentStep
{
get
{
return mstrCurrentStep;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCurrentStep = value;
}
else
{
 mstrCurrentStep = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.CurrentStep);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorMessage
{
get
{
return mstrErrorMessage;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorMessage = value;
}
else
{
 mstrErrorMessage = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.ErrorMessage);
}
}
/// <summary>
/// CreatedBy(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreatedBy
{
get
{
return mstrCreatedBy;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreatedBy = value;
}
else
{
 mstrCreatedBy = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.CreatedBy);
}
}
/// <summary>
/// CreatedTime(说明:;字段类型:datetime;字段长度:16;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreatedTime
{
get
{
return mdteCreatedTime;
}
set
{
 mdteCreatedTime = value;
//记录修改过的字段
 AddUpdatedFld(conCopyTask.CreatedTime);
}
}
/// <summary>
/// UpdatedTime(说明:;字段类型:datetime;字段长度:16;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime UpdatedTime
{
get
{
return mdteUpdatedTime;
}
set
{
 mdteUpdatedTime = value;
//记录修改过的字段
 AddUpdatedFld(conCopyTask.UpdatedTime);
}
}
/// <summary>
/// TargetViewName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetViewName
{
get
{
return mstrTargetViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetViewName = value;
}
else
{
 mstrTargetViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTask.TargetViewName);
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
 /// CopyTask(CopyTask)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCopyTask
{
public const string _CurrTabName = "CopyTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TaskId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TaskId", "SourcePrjId", "TargetPrjId", "SourceViewId", "TargetViewId", "ConflictStrategy", "Status", "CurrentStep", "ErrorMessage", "CreatedBy", "CreatedTime", "UpdatedTime", "TargetViewName"};
//以下是属性变量


 /// <summary>
 /// 常量:"TaskId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TaskId = "TaskId";    //TaskId

 /// <summary>
 /// 常量:"SourcePrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourcePrjId = "SourcePrjId";    //SourcePrjId

 /// <summary>
 /// 常量:"TargetPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetPrjId = "TargetPrjId";    //TargetPrjId

 /// <summary>
 /// 常量:"SourceViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceViewId = "SourceViewId";    //SourceViewId

 /// <summary>
 /// 常量:"TargetViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetViewId = "TargetViewId";    //TargetViewId

 /// <summary>
 /// 常量:"ConflictStrategy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConflictStrategy = "ConflictStrategy";    //ConflictStrategy

 /// <summary>
 /// 常量:"Status"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Status = "Status";    //Status

 /// <summary>
 /// 常量:"CurrentStep"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrentStep = "CurrentStep";    //CurrentStep

 /// <summary>
 /// 常量:"ErrorMessage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorMessage = "ErrorMessage";    //错误信息

 /// <summary>
 /// 常量:"CreatedBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedBy = "CreatedBy";    //CreatedBy

 /// <summary>
 /// 常量:"CreatedTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreatedTime = "CreatedTime";    //CreatedTime

 /// <summary>
 /// 常量:"UpdatedTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdatedTime = "UpdatedTime";    //UpdatedTime

 /// <summary>
 /// 常量:"TargetViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetViewName = "TargetViewName";    //TargetViewName
}

}