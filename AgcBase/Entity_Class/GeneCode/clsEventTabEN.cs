
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEventTabEN
 表名:EventTab(00050031)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:54
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
 /// 表EventTab的关键字(EventId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_EventId_EventTab
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngEventId">表关键字</param>
public K_EventId_EventTab(long lngEventId)
{
if (IsValid(lngEventId)) Value = lngEventId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngEventId)
{
if (lngEventId == 0) return false;
if (lngEventId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_EventId_EventTab]类型的对象</returns>
public static implicit operator K_EventId_EventTab(long value)
{
return new K_EventId_EventTab(value);
}
}
 /// <summary>
 /// 事件(EventTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsEventTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "EventTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "EventId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"EventId", "TabName", "ColName", "RecordId", "InitValue", "UpdateValue", "UpdDate", "UpdTime", "UpdNameId", "OpdType", "Memo"};

protected long mlngEventId;    //EventId
protected string mstrTabName;    //表名
protected string mstrColName;    //ColName
protected string mstrRecordId;    //RecordId
protected string mstrInitValue;    //初始值
protected string mstrUpdateValue;    //UpdateValue
protected string mstrUpdDate;    //修改日期
protected string mstrUpdTime;    //修改时间
protected string mstrUpdNameId;    //UpdNameId
protected string mstrOpdType;    //OpdType
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsEventTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EventId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "lngEventId">关键字:EventId</param>
public clsEventTabEN(long lngEventId)
 {
 if (lngEventId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngEventId = lngEventId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EventId");
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
if (strAttributeName  ==  conEventTab.EventId)
{
return mlngEventId;
}
else if (strAttributeName  ==  conEventTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conEventTab.ColName)
{
return mstrColName;
}
else if (strAttributeName  ==  conEventTab.RecordId)
{
return mstrRecordId;
}
else if (strAttributeName  ==  conEventTab.InitValue)
{
return mstrInitValue;
}
else if (strAttributeName  ==  conEventTab.UpdateValue)
{
return mstrUpdateValue;
}
else if (strAttributeName  ==  conEventTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conEventTab.UpdTime)
{
return mstrUpdTime;
}
else if (strAttributeName  ==  conEventTab.UpdNameId)
{
return mstrUpdNameId;
}
else if (strAttributeName  ==  conEventTab.OpdType)
{
return mstrOpdType;
}
else if (strAttributeName  ==  conEventTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conEventTab.EventId)
{
mlngEventId = TransNullToInt(value.ToString());
 AddUpdatedFld(conEventTab.EventId);
}
else if (strAttributeName  ==  conEventTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conEventTab.TabName);
}
else if (strAttributeName  ==  conEventTab.ColName)
{
mstrColName = value.ToString();
 AddUpdatedFld(conEventTab.ColName);
}
else if (strAttributeName  ==  conEventTab.RecordId)
{
mstrRecordId = value.ToString();
 AddUpdatedFld(conEventTab.RecordId);
}
else if (strAttributeName  ==  conEventTab.InitValue)
{
mstrInitValue = value.ToString();
 AddUpdatedFld(conEventTab.InitValue);
}
else if (strAttributeName  ==  conEventTab.UpdateValue)
{
mstrUpdateValue = value.ToString();
 AddUpdatedFld(conEventTab.UpdateValue);
}
else if (strAttributeName  ==  conEventTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEventTab.UpdDate);
}
else if (strAttributeName  ==  conEventTab.UpdTime)
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(conEventTab.UpdTime);
}
else if (strAttributeName  ==  conEventTab.UpdNameId)
{
mstrUpdNameId = value.ToString();
 AddUpdatedFld(conEventTab.UpdNameId);
}
else if (strAttributeName  ==  conEventTab.OpdType)
{
mstrOpdType = value.ToString();
 AddUpdatedFld(conEventTab.OpdType);
}
else if (strAttributeName  ==  conEventTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEventTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conEventTab.EventId  ==  _AttributeName[intIndex])
{
return mlngEventId;
}
else if (conEventTab.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (conEventTab.ColName  ==  _AttributeName[intIndex])
{
return mstrColName;
}
else if (conEventTab.RecordId  ==  _AttributeName[intIndex])
{
return mstrRecordId;
}
else if (conEventTab.InitValue  ==  _AttributeName[intIndex])
{
return mstrInitValue;
}
else if (conEventTab.UpdateValue  ==  _AttributeName[intIndex])
{
return mstrUpdateValue;
}
else if (conEventTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conEventTab.UpdTime  ==  _AttributeName[intIndex])
{
return mstrUpdTime;
}
else if (conEventTab.UpdNameId  ==  _AttributeName[intIndex])
{
return mstrUpdNameId;
}
else if (conEventTab.OpdType  ==  _AttributeName[intIndex])
{
return mstrOpdType;
}
else if (conEventTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conEventTab.EventId  ==  _AttributeName[intIndex])
{
mlngEventId = TransNullToInt(value.ToString());
 AddUpdatedFld(conEventTab.EventId);
}
else if (conEventTab.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conEventTab.TabName);
}
else if (conEventTab.ColName  ==  _AttributeName[intIndex])
{
mstrColName = value.ToString();
 AddUpdatedFld(conEventTab.ColName);
}
else if (conEventTab.RecordId  ==  _AttributeName[intIndex])
{
mstrRecordId = value.ToString();
 AddUpdatedFld(conEventTab.RecordId);
}
else if (conEventTab.InitValue  ==  _AttributeName[intIndex])
{
mstrInitValue = value.ToString();
 AddUpdatedFld(conEventTab.InitValue);
}
else if (conEventTab.UpdateValue  ==  _AttributeName[intIndex])
{
mstrUpdateValue = value.ToString();
 AddUpdatedFld(conEventTab.UpdateValue);
}
else if (conEventTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conEventTab.UpdDate);
}
else if (conEventTab.UpdTime  ==  _AttributeName[intIndex])
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(conEventTab.UpdTime);
}
else if (conEventTab.UpdNameId  ==  _AttributeName[intIndex])
{
mstrUpdNameId = value.ToString();
 AddUpdatedFld(conEventTab.UpdNameId);
}
else if (conEventTab.OpdType  ==  _AttributeName[intIndex])
{
mstrOpdType = value.ToString();
 AddUpdatedFld(conEventTab.OpdType);
}
else if (conEventTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conEventTab.Memo);
}
}
}

/// <summary>
/// EventId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long EventId
{
get
{
return mlngEventId;
}
set
{
 mlngEventId = value;
//记录修改过的字段
 AddUpdatedFld(conEventTab.EventId);
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
 AddUpdatedFld(conEventTab.TabName);
}
}
/// <summary>
/// ColName(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColName
{
get
{
return mstrColName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColName = value;
}
else
{
 mstrColName = value;
}
//记录修改过的字段
 AddUpdatedFld(conEventTab.ColName);
}
}
/// <summary>
/// RecordId(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecordId
{
get
{
return mstrRecordId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecordId = value;
}
else
{
 mstrRecordId = value;
}
//记录修改过的字段
 AddUpdatedFld(conEventTab.RecordId);
}
}
/// <summary>
/// 初始值(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InitValue
{
get
{
return mstrInitValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInitValue = value;
}
else
{
 mstrInitValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conEventTab.InitValue);
}
}
/// <summary>
/// UpdateValue(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdateValue
{
get
{
return mstrUpdateValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdateValue = value;
}
else
{
 mstrUpdateValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conEventTab.UpdateValue);
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
 AddUpdatedFld(conEventTab.UpdDate);
}
}
/// <summary>
/// 修改时间(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdTime
{
get
{
return mstrUpdTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdTime = value;
}
else
{
 mstrUpdTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conEventTab.UpdTime);
}
}
/// <summary>
/// UpdNameId(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdNameId
{
get
{
return mstrUpdNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdNameId = value;
}
else
{
 mstrUpdNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(conEventTab.UpdNameId);
}
}
/// <summary>
/// OpdType(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpdType
{
get
{
return mstrOpdType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpdType = value;
}
else
{
 mstrOpdType = value;
}
//记录修改过的字段
 AddUpdatedFld(conEventTab.OpdType);
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
 AddUpdatedFld(conEventTab.Memo);
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
  return mlngEventId.ToString();
 }
 }
}
 /// <summary>
 /// 事件(EventTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conEventTab
{
public const string _CurrTabName = "EventTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "EventId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"EventId", "TabName", "ColName", "RecordId", "InitValue", "UpdateValue", "UpdDate", "UpdTime", "UpdNameId", "OpdType", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"EventId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventId = "EventId";    //EventId

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"ColName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColName = "ColName";    //ColName

 /// <summary>
 /// 常量:"RecordId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecordId = "RecordId";    //RecordId

 /// <summary>
 /// 常量:"InitValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InitValue = "InitValue";    //初始值

 /// <summary>
 /// 常量:"UpdateValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdateValue = "UpdateValue";    //UpdateValue

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdTime = "UpdTime";    //修改时间

 /// <summary>
 /// 常量:"UpdNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdNameId = "UpdNameId";    //UpdNameId

 /// <summary>
 /// 常量:"OpdType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpdType = "OpdType";    //OpdType

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}