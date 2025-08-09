
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLogEN
 表名:UserLog(00050130)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:12
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
 /// 表UserLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserLog
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
public K_mId_UserLog(long lngmId)
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
 /// <returns>返回:[K_mId_UserLog]类型的对象</returns>
public static implicit operator K_mId_UserLog(long value)
{
return new K_mId_UserLog(value);
}
}
 /// <summary>
 /// 用户日志(UserLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"mId", "UserId", "LoginTime", "LoginDate", "UserIp", "ObjectTable", "UsedValue", "UpdDate", "Memo", "IsDeleted", "OrderNum", "DeletedDate"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrLoginTime;    //登陆时间
protected string mstrLoginDate;    //登陆日期
protected string mstrUserIp;    //用户IP
protected string mstrObjectTable;    //对象表
protected string mstrUsedValue;    //使用值
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected bool mbolIsDeleted;    //是否删除
protected int mintOrderNum;    //序号
protected string mstrDeletedDate;    //删除日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsUserLogEN()
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
public clsUserLogEN(long lngmId)
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
if (strAttributeName  ==  conUserLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserLog.LoginTime)
{
return mstrLoginTime;
}
else if (strAttributeName  ==  conUserLog.LoginDate)
{
return mstrLoginDate;
}
else if (strAttributeName  ==  conUserLog.UserIp)
{
return mstrUserIp;
}
else if (strAttributeName  ==  conUserLog.ObjectTable)
{
return mstrObjectTable;
}
else if (strAttributeName  ==  conUserLog.UsedValue)
{
return mstrUsedValue;
}
else if (strAttributeName  ==  conUserLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conUserLog.IsDeleted)
{
return mbolIsDeleted;
}
else if (strAttributeName  ==  conUserLog.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conUserLog.DeletedDate)
{
return mstrDeletedDate;
}
return null;
}
set
{
if (strAttributeName  ==  conUserLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLog.mId);
}
else if (strAttributeName  ==  conUserLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserLog.UserId);
}
else if (strAttributeName  ==  conUserLog.LoginTime)
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conUserLog.LoginTime);
}
else if (strAttributeName  ==  conUserLog.LoginDate)
{
mstrLoginDate = value.ToString();
 AddUpdatedFld(conUserLog.LoginDate);
}
else if (strAttributeName  ==  conUserLog.UserIp)
{
mstrUserIp = value.ToString();
 AddUpdatedFld(conUserLog.UserIp);
}
else if (strAttributeName  ==  conUserLog.ObjectTable)
{
mstrObjectTable = value.ToString();
 AddUpdatedFld(conUserLog.ObjectTable);
}
else if (strAttributeName  ==  conUserLog.UsedValue)
{
mstrUsedValue = value.ToString();
 AddUpdatedFld(conUserLog.UsedValue);
}
else if (strAttributeName  ==  conUserLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserLog.UpdDate);
}
else if (strAttributeName  ==  conUserLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserLog.Memo);
}
else if (strAttributeName  ==  conUserLog.IsDeleted)
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserLog.IsDeleted);
}
else if (strAttributeName  ==  conUserLog.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLog.OrderNum);
}
else if (strAttributeName  ==  conUserLog.DeletedDate)
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conUserLog.DeletedDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserLog.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserLog.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserLog.LoginTime  ==  _AttributeName[intIndex])
{
return mstrLoginTime;
}
else if (conUserLog.LoginDate  ==  _AttributeName[intIndex])
{
return mstrLoginDate;
}
else if (conUserLog.UserIp  ==  _AttributeName[intIndex])
{
return mstrUserIp;
}
else if (conUserLog.ObjectTable  ==  _AttributeName[intIndex])
{
return mstrObjectTable;
}
else if (conUserLog.UsedValue  ==  _AttributeName[intIndex])
{
return mstrUsedValue;
}
else if (conUserLog.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserLog.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conUserLog.IsDeleted  ==  _AttributeName[intIndex])
{
return mbolIsDeleted;
}
else if (conUserLog.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conUserLog.DeletedDate  ==  _AttributeName[intIndex])
{
return mstrDeletedDate;
}
return null;
}
set
{
if (conUserLog.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLog.mId);
}
else if (conUserLog.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserLog.UserId);
}
else if (conUserLog.LoginTime  ==  _AttributeName[intIndex])
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conUserLog.LoginTime);
}
else if (conUserLog.LoginDate  ==  _AttributeName[intIndex])
{
mstrLoginDate = value.ToString();
 AddUpdatedFld(conUserLog.LoginDate);
}
else if (conUserLog.UserIp  ==  _AttributeName[intIndex])
{
mstrUserIp = value.ToString();
 AddUpdatedFld(conUserLog.UserIp);
}
else if (conUserLog.ObjectTable  ==  _AttributeName[intIndex])
{
mstrObjectTable = value.ToString();
 AddUpdatedFld(conUserLog.ObjectTable);
}
else if (conUserLog.UsedValue  ==  _AttributeName[intIndex])
{
mstrUsedValue = value.ToString();
 AddUpdatedFld(conUserLog.UsedValue);
}
else if (conUserLog.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserLog.UpdDate);
}
else if (conUserLog.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserLog.Memo);
}
else if (conUserLog.IsDeleted  ==  _AttributeName[intIndex])
{
mbolIsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserLog.IsDeleted);
}
else if (conUserLog.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserLog.OrderNum);
}
else if (conUserLog.DeletedDate  ==  _AttributeName[intIndex])
{
mstrDeletedDate = value.ToString();
 AddUpdatedFld(conUserLog.DeletedDate);
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
 AddUpdatedFld(conUserLog.mId);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog.UserId);
}
}
/// <summary>
/// 登陆时间(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LoginTime
{
get
{
return mstrLoginTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLoginTime = value;
}
else
{
 mstrLoginTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog.LoginTime);
}
}
/// <summary>
/// 登陆日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LoginDate
{
get
{
return mstrLoginDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLoginDate = value;
}
else
{
 mstrLoginDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog.LoginDate);
}
}
/// <summary>
/// 用户IP(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserIp
{
get
{
return mstrUserIp;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserIp = value;
}
else
{
 mstrUserIp = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog.UserIp);
}
}
/// <summary>
/// 对象表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectTable
{
get
{
return mstrObjectTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectTable = value;
}
else
{
 mstrObjectTable = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog.ObjectTable);
}
}
/// <summary>
/// 使用值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UsedValue
{
get
{
return mstrUsedValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUsedValue = value;
}
else
{
 mstrUsedValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog.UsedValue);
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
 AddUpdatedFld(conUserLog.UpdDate);
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
 AddUpdatedFld(conUserLog.Memo);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDeleted
{
get
{
return mbolIsDeleted;
}
set
{
 mbolIsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(conUserLog.IsDeleted);
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
 AddUpdatedFld(conUserLog.OrderNum);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DeletedDate
{
get
{
return mstrDeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDeletedDate = value;
}
else
{
 mstrDeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserLog.DeletedDate);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrUserId;
 }
 }
}
 /// <summary>
 /// 用户日志(UserLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserLog
{
public const string _CurrTabName = "UserLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "UserId", "LoginTime", "LoginDate", "UserIp", "ObjectTable", "UsedValue", "UpdDate", "Memo", "IsDeleted", "OrderNum", "DeletedDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"LoginTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginTime = "LoginTime";    //登陆时间

 /// <summary>
 /// 常量:"LoginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LoginDate = "LoginDate";    //登陆日期

 /// <summary>
 /// 常量:"UserIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserIp = "UserIp";    //用户IP

 /// <summary>
 /// 常量:"ObjectTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectTable = "ObjectTable";    //对象表

 /// <summary>
 /// 常量:"UsedValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UsedValue = "UsedValue";    //使用值

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDeleted = "IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DeletedDate = "DeletedDate";    //删除日期
}

}