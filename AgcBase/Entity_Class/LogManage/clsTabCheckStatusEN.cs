
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckStatusEN
 表名:TabCheckStatus(00050568)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表TabCheckStatus的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_TabCheckStatus
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
public K_mId_TabCheckStatus(long lngmId)
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
 /// <returns>返回:[K_mId_TabCheckStatus]类型的对象</returns>
public static implicit operator K_mId_TabCheckStatus(long value)
{
return new K_mId_TabCheckStatus(value);
}
}
 /// <summary>
 /// 表检查状态(TabCheckStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabCheckStatusEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabCheckStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjDataBaseId", "TabId", "IsNeedCheckTab", "ErrorLevelId", "ErrorMsg", "TabCheckErrorTypeId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrTabId;    //表ID
protected bool mbolIsNeedCheckTab;    //是否需要检查表字段
protected int mintErrorLevelId;    //错误等级Id
protected string mstrErrorMsg;    //错误信息
protected string mstrTabCheckErrorTypeId;    //表检查错误类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabCheckStatusEN()
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
public clsTabCheckStatusEN(long lngmId)
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
if (strAttributeName  ==  conTabCheckStatus.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conTabCheckStatus.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTabCheckStatus.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  conTabCheckStatus.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conTabCheckStatus.IsNeedCheckTab)
{
return mbolIsNeedCheckTab;
}
else if (strAttributeName  ==  conTabCheckStatus.ErrorLevelId)
{
return mintErrorLevelId;
}
else if (strAttributeName  ==  conTabCheckStatus.ErrorMsg)
{
return mstrErrorMsg;
}
else if (strAttributeName  ==  conTabCheckStatus.TabCheckErrorTypeId)
{
return mstrTabCheckErrorTypeId;
}
else if (strAttributeName  ==  conTabCheckStatus.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTabCheckStatus.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTabCheckStatus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabCheckStatus.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckStatus.mId);
}
else if (strAttributeName  ==  conTabCheckStatus.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.PrjId);
}
else if (strAttributeName  ==  conTabCheckStatus.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.PrjDataBaseId);
}
else if (strAttributeName  ==  conTabCheckStatus.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.TabId);
}
else if (strAttributeName  ==  conTabCheckStatus.IsNeedCheckTab)
{
mbolIsNeedCheckTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabCheckStatus.IsNeedCheckTab);
}
else if (strAttributeName  ==  conTabCheckStatus.ErrorLevelId)
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckStatus.ErrorLevelId);
}
else if (strAttributeName  ==  conTabCheckStatus.ErrorMsg)
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(conTabCheckStatus.ErrorMsg);
}
else if (strAttributeName  ==  conTabCheckStatus.TabCheckErrorTypeId)
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.TabCheckErrorTypeId);
}
else if (strAttributeName  ==  conTabCheckStatus.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabCheckStatus.UpdDate);
}
else if (strAttributeName  ==  conTabCheckStatus.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabCheckStatus.UpdUser);
}
else if (strAttributeName  ==  conTabCheckStatus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckStatus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabCheckStatus.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conTabCheckStatus.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTabCheckStatus.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (conTabCheckStatus.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conTabCheckStatus.IsNeedCheckTab  ==  _AttributeName[intIndex])
{
return mbolIsNeedCheckTab;
}
else if (conTabCheckStatus.ErrorLevelId  ==  _AttributeName[intIndex])
{
return mintErrorLevelId;
}
else if (conTabCheckStatus.ErrorMsg  ==  _AttributeName[intIndex])
{
return mstrErrorMsg;
}
else if (conTabCheckStatus.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
return mstrTabCheckErrorTypeId;
}
else if (conTabCheckStatus.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTabCheckStatus.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTabCheckStatus.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabCheckStatus.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckStatus.mId);
}
else if (conTabCheckStatus.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.PrjId);
}
else if (conTabCheckStatus.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.PrjDataBaseId);
}
else if (conTabCheckStatus.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.TabId);
}
else if (conTabCheckStatus.IsNeedCheckTab  ==  _AttributeName[intIndex])
{
mbolIsNeedCheckTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabCheckStatus.IsNeedCheckTab);
}
else if (conTabCheckStatus.ErrorLevelId  ==  _AttributeName[intIndex])
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckStatus.ErrorLevelId);
}
else if (conTabCheckStatus.ErrorMsg  ==  _AttributeName[intIndex])
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(conTabCheckStatus.ErrorMsg);
}
else if (conTabCheckStatus.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(conTabCheckStatus.TabCheckErrorTypeId);
}
else if (conTabCheckStatus.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabCheckStatus.UpdDate);
}
else if (conTabCheckStatus.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabCheckStatus.UpdUser);
}
else if (conTabCheckStatus.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckStatus.Memo);
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
 AddUpdatedFld(conTabCheckStatus.mId);
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
 AddUpdatedFld(conTabCheckStatus.PrjId);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseId
{
get
{
return mstrPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseId = value;
}
else
{
 mstrPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckStatus.PrjDataBaseId);
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
 AddUpdatedFld(conTabCheckStatus.TabId);
}
}
/// <summary>
/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedCheckTab
{
get
{
return mbolIsNeedCheckTab;
}
set
{
 mbolIsNeedCheckTab = value;
//记录修改过的字段
 AddUpdatedFld(conTabCheckStatus.IsNeedCheckTab);
}
}
/// <summary>
/// 错误等级Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ErrorLevelId
{
get
{
return mintErrorLevelId;
}
set
{
 mintErrorLevelId = value;
//记录修改过的字段
 AddUpdatedFld(conTabCheckStatus.ErrorLevelId);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:5000;是否可空:False)
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
 AddUpdatedFld(conTabCheckStatus.ErrorMsg);
}
}
/// <summary>
/// 表检查错误类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCheckErrorTypeId
{
get
{
return mstrTabCheckErrorTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCheckErrorTypeId = value;
}
else
{
 mstrTabCheckErrorTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckStatus.TabCheckErrorTypeId);
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
 AddUpdatedFld(conTabCheckStatus.UpdDate);
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
 AddUpdatedFld(conTabCheckStatus.UpdUser);
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
 AddUpdatedFld(conTabCheckStatus.Memo);
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
 /// 表检查状态(TabCheckStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabCheckStatus
{
public const string _CurrTabName = "TabCheckStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjDataBaseId", "TabId", "IsNeedCheckTab", "ErrorLevelId", "ErrorMsg", "TabCheckErrorTypeId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"PrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseId = "PrjDataBaseId";    //项目数据库Id

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"IsNeedCheckTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedCheckTab = "IsNeedCheckTab";    //是否需要检查表字段

 /// <summary>
 /// 常量:"ErrorLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorLevelId = "ErrorLevelId";    //错误等级Id

 /// <summary>
 /// 常量:"ErrorMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorMsg = "ErrorMsg";    //错误信息

 /// <summary>
 /// 常量:"TabCheckErrorTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCheckErrorTypeId = "TabCheckErrorTypeId";    //表检查错误类型Id

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