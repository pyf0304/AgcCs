
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckResultEN
 表名:TabCheckResult(00050188)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:50
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
 /// 表TabCheckResult的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_TabCheckResult
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
public K_mId_TabCheckResult(long lngmId)
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
 /// <returns>返回:[K_mId_TabCheckResult]类型的对象</returns>
public static implicit operator K_mId_TabCheckResult(long value)
{
return new K_mId_TabCheckResult(value);
}
}
 /// <summary>
 /// 表检查结果(TabCheckResult)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabCheckResultEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabCheckResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 11;
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjDataBaseId", "TabId", "FldId", "ErrorLevelId", "ErrorMsg", "TabCheckErrorTypeId", "CheckDate", "CheckUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrPrjId;    //工程Id
protected string mstrPrjDataBaseId;    //项目数据库Id
protected string mstrTabId;    //表ID
protected string mstrFldId;    //字段Id
protected int mintErrorLevelId;    //错误等级Id
protected string mstrErrorMsg;    //错误信息
protected string mstrTabCheckErrorTypeId;    //表检查错误类型Id
protected string mstrCheckDate;    //检查日期
protected string mstrCheckUser;    //检查人
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsTabCheckResultEN()
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
public clsTabCheckResultEN(long lngmId)
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
if (strAttributeName  ==  conTabCheckResult.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conTabCheckResult.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTabCheckResult.PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  conTabCheckResult.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conTabCheckResult.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  conTabCheckResult.ErrorLevelId)
{
return mintErrorLevelId;
}
else if (strAttributeName  ==  conTabCheckResult.ErrorMsg)
{
return mstrErrorMsg;
}
else if (strAttributeName  ==  conTabCheckResult.TabCheckErrorTypeId)
{
return mstrTabCheckErrorTypeId;
}
else if (strAttributeName  ==  conTabCheckResult.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  conTabCheckResult.CheckUser)
{
return mstrCheckUser;
}
else if (strAttributeName  ==  conTabCheckResult.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabCheckResult.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckResult.mId);
}
else if (strAttributeName  ==  conTabCheckResult.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabCheckResult.PrjId);
}
else if (strAttributeName  ==  conTabCheckResult.PrjDataBaseId)
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conTabCheckResult.PrjDataBaseId);
}
else if (strAttributeName  ==  conTabCheckResult.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabCheckResult.TabId);
}
else if (strAttributeName  ==  conTabCheckResult.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(conTabCheckResult.FldId);
}
else if (strAttributeName  ==  conTabCheckResult.ErrorLevelId)
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckResult.ErrorLevelId);
}
else if (strAttributeName  ==  conTabCheckResult.ErrorMsg)
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(conTabCheckResult.ErrorMsg);
}
else if (strAttributeName  ==  conTabCheckResult.TabCheckErrorTypeId)
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(conTabCheckResult.TabCheckErrorTypeId);
}
else if (strAttributeName  ==  conTabCheckResult.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conTabCheckResult.CheckDate);
}
else if (strAttributeName  ==  conTabCheckResult.CheckUser)
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(conTabCheckResult.CheckUser);
}
else if (strAttributeName  ==  conTabCheckResult.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckResult.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabCheckResult.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conTabCheckResult.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTabCheckResult.PrjDataBaseId  ==  _AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (conTabCheckResult.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conTabCheckResult.FldId  ==  _AttributeName[intIndex])
{
return mstrFldId;
}
else if (conTabCheckResult.ErrorLevelId  ==  _AttributeName[intIndex])
{
return mintErrorLevelId;
}
else if (conTabCheckResult.ErrorMsg  ==  _AttributeName[intIndex])
{
return mstrErrorMsg;
}
else if (conTabCheckResult.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
return mstrTabCheckErrorTypeId;
}
else if (conTabCheckResult.CheckDate  ==  _AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (conTabCheckResult.CheckUser  ==  _AttributeName[intIndex])
{
return mstrCheckUser;
}
else if (conTabCheckResult.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabCheckResult.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckResult.mId);
}
else if (conTabCheckResult.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabCheckResult.PrjId);
}
else if (conTabCheckResult.PrjDataBaseId  ==  _AttributeName[intIndex])
{
mstrPrjDataBaseId = value.ToString();
 AddUpdatedFld(conTabCheckResult.PrjDataBaseId);
}
else if (conTabCheckResult.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabCheckResult.TabId);
}
else if (conTabCheckResult.FldId  ==  _AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(conTabCheckResult.FldId);
}
else if (conTabCheckResult.ErrorLevelId  ==  _AttributeName[intIndex])
{
mintErrorLevelId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabCheckResult.ErrorLevelId);
}
else if (conTabCheckResult.ErrorMsg  ==  _AttributeName[intIndex])
{
mstrErrorMsg = value.ToString();
 AddUpdatedFld(conTabCheckResult.ErrorMsg);
}
else if (conTabCheckResult.TabCheckErrorTypeId  ==  _AttributeName[intIndex])
{
mstrTabCheckErrorTypeId = value.ToString();
 AddUpdatedFld(conTabCheckResult.TabCheckErrorTypeId);
}
else if (conTabCheckResult.CheckDate  ==  _AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conTabCheckResult.CheckDate);
}
else if (conTabCheckResult.CheckUser  ==  _AttributeName[intIndex])
{
mstrCheckUser = value.ToString();
 AddUpdatedFld(conTabCheckResult.CheckUser);
}
else if (conTabCheckResult.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabCheckResult.Memo);
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
 AddUpdatedFld(conTabCheckResult.mId);
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
 AddUpdatedFld(conTabCheckResult.PrjId);
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
 AddUpdatedFld(conTabCheckResult.PrjDataBaseId);
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
 AddUpdatedFld(conTabCheckResult.TabId);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckResult.FldId);
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
 AddUpdatedFld(conTabCheckResult.ErrorLevelId);
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
 AddUpdatedFld(conTabCheckResult.ErrorMsg);
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
 AddUpdatedFld(conTabCheckResult.TabCheckErrorTypeId);
}
}
/// <summary>
/// 检查日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDate
{
get
{
return mstrCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDate = value;
}
else
{
 mstrCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckResult.CheckDate);
}
}
/// <summary>
/// 检查人(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckUser
{
get
{
return mstrCheckUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckUser = value;
}
else
{
 mstrCheckUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabCheckResult.CheckUser);
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
 AddUpdatedFld(conTabCheckResult.Memo);
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
 /// 表检查结果(TabCheckResult)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabCheckResult
{
public const string _CurrTabName = "TabCheckResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "PrjId", "PrjDataBaseId", "TabId", "FldId", "ErrorLevelId", "ErrorMsg", "TabCheckErrorTypeId", "CheckDate", "CheckUser", "Memo"};
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
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

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
 /// 常量:"CheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDate = "CheckDate";    //检查日期

 /// <summary>
 /// 常量:"CheckUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckUser = "CheckUser";    //检查人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}