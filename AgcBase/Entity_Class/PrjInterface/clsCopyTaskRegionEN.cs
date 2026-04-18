
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskRegionEN
 表名:CopyTaskRegion(00050644)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:41:46
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
 /// 表CopyTaskRegion的关键字(RowId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RowId_CopyTaskRegion
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngRowId">表关键字</param>
public K_RowId_CopyTaskRegion(long lngRowId)
{
if (IsValid(lngRowId)) Value = lngRowId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngRowId)
{
if (lngRowId == 0) return false;
if (lngRowId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RowId_CopyTaskRegion]类型的对象</returns>
public static implicit operator K_RowId_CopyTaskRegion(long value)
{
return new K_RowId_CopyTaskRegion(value);
}
}
 /// <summary>
 /// CopyTaskRegion(CopyTaskRegion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCopyTaskRegionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CopyTaskRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 10;
public static string[] _AttributeName = new string[] {"RowId", "TaskId", "SourceRegionId", "SourceClsName", "TargetRegionId", "CopyStatus", "RelationStatus", "ErrorMessage", "StepOrder", "UpdatedTime"};

protected long mlngRowId;    //RowId
protected long mlngTaskId;    //TaskId
protected string mstrSourceRegionId;    //SourceRegionId
protected string mstrSourceClsName;    //SourceClsName
protected string mstrTargetRegionId;    //TargetRegionId
protected string mstrCopyStatus;    //CopyStatus
protected string mstrRelationStatus;    //RelationStatus
protected string mstrErrorMessage;    //错误信息
protected int mintStepOrder;    //StepOrder
protected DateTime mdteUpdatedTime;    //UpdatedTime

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCopyTaskRegionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RowId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngRowId">关键字:RowId</param>
public clsCopyTaskRegionEN(long lngRowId)
 {
 if (lngRowId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngRowId = lngRowId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RowId");
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
if (strAttributeName  ==  conCopyTaskRegion.RowId)
{
return mlngRowId;
}
else if (strAttributeName  ==  conCopyTaskRegion.TaskId)
{
return mlngTaskId;
}
else if (strAttributeName  ==  conCopyTaskRegion.SourceRegionId)
{
return mstrSourceRegionId;
}
else if (strAttributeName  ==  conCopyTaskRegion.SourceClsName)
{
return mstrSourceClsName;
}
else if (strAttributeName  ==  conCopyTaskRegion.TargetRegionId)
{
return mstrTargetRegionId;
}
else if (strAttributeName  ==  conCopyTaskRegion.CopyStatus)
{
return mstrCopyStatus;
}
else if (strAttributeName  ==  conCopyTaskRegion.RelationStatus)
{
return mstrRelationStatus;
}
else if (strAttributeName  ==  conCopyTaskRegion.ErrorMessage)
{
return mstrErrorMessage;
}
else if (strAttributeName  ==  conCopyTaskRegion.StepOrder)
{
return mintStepOrder;
}
else if (strAttributeName  ==  conCopyTaskRegion.UpdatedTime)
{
return mdteUpdatedTime;
}
return null;
}
set
{
if (strAttributeName  ==  conCopyTaskRegion.RowId)
{
mlngRowId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.RowId);
}
else if (strAttributeName  ==  conCopyTaskRegion.TaskId)
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.TaskId);
}
else if (strAttributeName  ==  conCopyTaskRegion.SourceRegionId)
{
mstrSourceRegionId = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.SourceRegionId);
}
else if (strAttributeName  ==  conCopyTaskRegion.SourceClsName)
{
mstrSourceClsName = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.SourceClsName);
}
else if (strAttributeName  ==  conCopyTaskRegion.TargetRegionId)
{
mstrTargetRegionId = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.TargetRegionId);
}
else if (strAttributeName  ==  conCopyTaskRegion.CopyStatus)
{
mstrCopyStatus = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.CopyStatus);
}
else if (strAttributeName  ==  conCopyTaskRegion.RelationStatus)
{
mstrRelationStatus = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.RelationStatus);
}
else if (strAttributeName  ==  conCopyTaskRegion.ErrorMessage)
{
mstrErrorMessage = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.ErrorMessage);
}
else if (strAttributeName  ==  conCopyTaskRegion.StepOrder)
{
mintStepOrder = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.StepOrder);
}
else if (strAttributeName  ==  conCopyTaskRegion.UpdatedTime)
{
mdteUpdatedTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.UpdatedTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conCopyTaskRegion.RowId  ==  _AttributeName[intIndex])
{
return mlngRowId;
}
else if (conCopyTaskRegion.TaskId  ==  _AttributeName[intIndex])
{
return mlngTaskId;
}
else if (conCopyTaskRegion.SourceRegionId  ==  _AttributeName[intIndex])
{
return mstrSourceRegionId;
}
else if (conCopyTaskRegion.SourceClsName  ==  _AttributeName[intIndex])
{
return mstrSourceClsName;
}
else if (conCopyTaskRegion.TargetRegionId  ==  _AttributeName[intIndex])
{
return mstrTargetRegionId;
}
else if (conCopyTaskRegion.CopyStatus  ==  _AttributeName[intIndex])
{
return mstrCopyStatus;
}
else if (conCopyTaskRegion.RelationStatus  ==  _AttributeName[intIndex])
{
return mstrRelationStatus;
}
else if (conCopyTaskRegion.ErrorMessage  ==  _AttributeName[intIndex])
{
return mstrErrorMessage;
}
else if (conCopyTaskRegion.StepOrder  ==  _AttributeName[intIndex])
{
return mintStepOrder;
}
else if (conCopyTaskRegion.UpdatedTime  ==  _AttributeName[intIndex])
{
return mdteUpdatedTime;
}
return null;
}
set
{
if (conCopyTaskRegion.RowId  ==  _AttributeName[intIndex])
{
mlngRowId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.RowId);
}
else if (conCopyTaskRegion.TaskId  ==  _AttributeName[intIndex])
{
mlngTaskId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.TaskId);
}
else if (conCopyTaskRegion.SourceRegionId  ==  _AttributeName[intIndex])
{
mstrSourceRegionId = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.SourceRegionId);
}
else if (conCopyTaskRegion.SourceClsName  ==  _AttributeName[intIndex])
{
mstrSourceClsName = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.SourceClsName);
}
else if (conCopyTaskRegion.TargetRegionId  ==  _AttributeName[intIndex])
{
mstrTargetRegionId = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.TargetRegionId);
}
else if (conCopyTaskRegion.CopyStatus  ==  _AttributeName[intIndex])
{
mstrCopyStatus = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.CopyStatus);
}
else if (conCopyTaskRegion.RelationStatus  ==  _AttributeName[intIndex])
{
mstrRelationStatus = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.RelationStatus);
}
else if (conCopyTaskRegion.ErrorMessage  ==  _AttributeName[intIndex])
{
mstrErrorMessage = value.ToString();
 AddUpdatedFld(conCopyTaskRegion.ErrorMessage);
}
else if (conCopyTaskRegion.StepOrder  ==  _AttributeName[intIndex])
{
mintStepOrder = TransNullToInt(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.StepOrder);
}
else if (conCopyTaskRegion.UpdatedTime  ==  _AttributeName[intIndex])
{
mdteUpdatedTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conCopyTaskRegion.UpdatedTime);
}
}
}

/// <summary>
/// RowId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long RowId
{
get
{
return mlngRowId;
}
set
{
 mlngRowId = value;
//记录修改过的字段
 AddUpdatedFld(conCopyTaskRegion.RowId);
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
 AddUpdatedFld(conCopyTaskRegion.TaskId);
}
}
/// <summary>
/// SourceRegionId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceRegionId
{
get
{
return mstrSourceRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceRegionId = value;
}
else
{
 mstrSourceRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTaskRegion.SourceRegionId);
}
}
/// <summary>
/// SourceClsName(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceClsName
{
get
{
return mstrSourceClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceClsName = value;
}
else
{
 mstrSourceClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTaskRegion.SourceClsName);
}
}
/// <summary>
/// TargetRegionId(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TargetRegionId
{
get
{
return mstrTargetRegionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTargetRegionId = value;
}
else
{
 mstrTargetRegionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTaskRegion.TargetRegionId);
}
}
/// <summary>
/// CopyStatus(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CopyStatus
{
get
{
return mstrCopyStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCopyStatus = value;
}
else
{
 mstrCopyStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTaskRegion.CopyStatus);
}
}
/// <summary>
/// RelationStatus(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelationStatus
{
get
{
return mstrRelationStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelationStatus = value;
}
else
{
 mstrRelationStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conCopyTaskRegion.RelationStatus);
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
 AddUpdatedFld(conCopyTaskRegion.ErrorMessage);
}
}
/// <summary>
/// StepOrder(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int StepOrder
{
get
{
return mintStepOrder;
}
set
{
 mintStepOrder = value;
//记录修改过的字段
 AddUpdatedFld(conCopyTaskRegion.StepOrder);
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
 AddUpdatedFld(conCopyTaskRegion.UpdatedTime);
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
  return mlngRowId.ToString();
 }
 }
}
 /// <summary>
 /// CopyTaskRegion(CopyTaskRegion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCopyTaskRegion
{
public const string _CurrTabName = "CopyTaskRegion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"RowId", "TaskId", "SourceRegionId", "SourceClsName", "TargetRegionId", "CopyStatus", "RelationStatus", "ErrorMessage", "StepOrder", "UpdatedTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"RowId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RowId = "RowId";    //RowId

 /// <summary>
 /// 常量:"TaskId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TaskId = "TaskId";    //TaskId

 /// <summary>
 /// 常量:"SourceRegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceRegionId = "SourceRegionId";    //SourceRegionId

 /// <summary>
 /// 常量:"SourceClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceClsName = "SourceClsName";    //SourceClsName

 /// <summary>
 /// 常量:"TargetRegionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TargetRegionId = "TargetRegionId";    //TargetRegionId

 /// <summary>
 /// 常量:"CopyStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CopyStatus = "CopyStatus";    //CopyStatus

 /// <summary>
 /// 常量:"RelationStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationStatus = "RelationStatus";    //RelationStatus

 /// <summary>
 /// 常量:"ErrorMessage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorMessage = "ErrorMessage";    //错误信息

 /// <summary>
 /// 常量:"StepOrder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StepOrder = "StepOrder";    //StepOrder

 /// <summary>
 /// 常量:"UpdatedTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdatedTime = "UpdatedTime";    //UpdatedTime
}

}