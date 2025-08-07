
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckLogEN
 表名:TabCheckLog(00050190)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表TabCheckLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_TabCheckLog
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
public K_mId_TabCheckLog(long lngmId)
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
 /// <returns>返回:[K_mId_TabCheckLog]类型的对象</returns>
public static implicit operator K_mId_TabCheckLog(long value)
{
return new K_mId_TabCheckLog(value);
}
}
 /// <summary>
 /// 表检查日志(TabCheckLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabCheckLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabCheckLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 8;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "SetDate", "SetUserId", "StartDate", "FinishDate", "CurrStatus", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrSetDate;    //设置日期
protected string mstrSetUserId;    //设置人
protected string mstrStartDate;    //开始日期
protected string mstrFinishDate;    //完成日期
protected string mstrCurrStatus;    //状态
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabCheckLogEN()
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
public clsTabCheckLogEN(long lngmId)
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
if (strAttributeName  ==  conTabCheckLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conTabCheckLog.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTabCheckLog.SetDate)
{
return mstrSetDate;
}
else if (strAttributeName  ==  conTabCheckLog.SetUserId)
{
return mstrSetUserId;
}
else if (strAttributeName  ==  conTabCheckLog.StartDate)
{
return mstrStartDate;
}
else if (strAttributeName  ==  conTabCheckLog.FinishDate)
{
return mstrFinishDate;
}
else if (strAttributeName  ==  conTabCheckLog.CurrStatus)
{
return mstrCurrStatus;
}
else if (strAttributeName  ==  conTabCheckLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabCheckLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckLog.mId);
}
else if (strAttributeName  ==  conTabCheckLog.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabCheckLog.PrjId);
}
else if (strAttributeName  ==  conTabCheckLog.SetDate)
{
mstrSetDate = value.ToString();
 AddUpdatedFld(conTabCheckLog.SetDate);
}
else if (strAttributeName  ==  conTabCheckLog.SetUserId)
{
mstrSetUserId = value.ToString();
 AddUpdatedFld(conTabCheckLog.SetUserId);
}
else if (strAttributeName  ==  conTabCheckLog.StartDate)
{
mstrStartDate = value.ToString();
 AddUpdatedFld(conTabCheckLog.StartDate);
}
else if (strAttributeName  ==  conTabCheckLog.FinishDate)
{
mstrFinishDate = value.ToString();
 AddUpdatedFld(conTabCheckLog.FinishDate);
}
else if (strAttributeName  ==  conTabCheckLog.CurrStatus)
{
mstrCurrStatus = value.ToString();
 AddUpdatedFld(conTabCheckLog.CurrStatus);
}
else if (strAttributeName  ==  conTabCheckLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabCheckLog.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conTabCheckLog.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTabCheckLog.SetDate  ==  _AttributeName[intIndex])
{
return mstrSetDate;
}
else if (conTabCheckLog.SetUserId  ==  _AttributeName[intIndex])
{
return mstrSetUserId;
}
else if (conTabCheckLog.StartDate  ==  _AttributeName[intIndex])
{
return mstrStartDate;
}
else if (conTabCheckLog.FinishDate  ==  _AttributeName[intIndex])
{
return mstrFinishDate;
}
else if (conTabCheckLog.CurrStatus  ==  _AttributeName[intIndex])
{
return mstrCurrStatus;
}
else if (conTabCheckLog.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabCheckLog.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckLog.mId);
}
else if (conTabCheckLog.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabCheckLog.PrjId);
}
else if (conTabCheckLog.SetDate  ==  _AttributeName[intIndex])
{
mstrSetDate = value.ToString();
 AddUpdatedFld(conTabCheckLog.SetDate);
}
else if (conTabCheckLog.SetUserId  ==  _AttributeName[intIndex])
{
mstrSetUserId = value.ToString();
 AddUpdatedFld(conTabCheckLog.SetUserId);
}
else if (conTabCheckLog.StartDate  ==  _AttributeName[intIndex])
{
mstrStartDate = value.ToString();
 AddUpdatedFld(conTabCheckLog.StartDate);
}
else if (conTabCheckLog.FinishDate  ==  _AttributeName[intIndex])
{
mstrFinishDate = value.ToString();
 AddUpdatedFld(conTabCheckLog.FinishDate);
}
else if (conTabCheckLog.CurrStatus  ==  _AttributeName[intIndex])
{
mstrCurrStatus = value.ToString();
 AddUpdatedFld(conTabCheckLog.CurrStatus);
}
else if (conTabCheckLog.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckLog.Memo);
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
 AddUpdatedFld(conTabCheckLog.mId);
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
 AddUpdatedFld(conTabCheckLog.PrjId);
}
}
/// <summary>
/// 设置日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SetDate
{
get
{
return mstrSetDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSetDate = value;
}
else
{
 mstrSetDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckLog.SetDate);
}
}
/// <summary>
/// 设置人(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SetUserId
{
get
{
return mstrSetUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSetUserId = value;
}
else
{
 mstrSetUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckLog.SetUserId);
}
}
/// <summary>
/// 开始日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StartDate
{
get
{
return mstrStartDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStartDate = value;
}
else
{
 mstrStartDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckLog.StartDate);
}
}
/// <summary>
/// 完成日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FinishDate
{
get
{
return mstrFinishDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFinishDate = value;
}
else
{
 mstrFinishDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckLog.FinishDate);
}
}
/// <summary>
/// 状态(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CurrStatus
{
get
{
return mstrCurrStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCurrStatus = value;
}
else
{
 mstrCurrStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckLog.CurrStatus);
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
 AddUpdatedFld(conTabCheckLog.Memo);
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
 /// 表检查日志(TabCheckLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabCheckLog
{
public const string _CurrTabName = "TabCheckLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "SetDate", "SetUserId", "StartDate", "FinishDate", "CurrStatus", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"SetDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SetDate = "SetDate";    //设置日期

 /// <summary>
 /// 常量:"SetUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SetUserId = "SetUserId";    //设置人

 /// <summary>
 /// 常量:"StartDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartDate = "StartDate";    //开始日期

 /// <summary>
 /// 常量:"FinishDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FinishDate = "FinishDate";    //完成日期

 /// <summary>
 /// 常量:"CurrStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrStatus = "CurrStatus";    //状态

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}