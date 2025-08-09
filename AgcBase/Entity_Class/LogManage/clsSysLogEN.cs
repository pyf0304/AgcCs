
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysLogEN
 表名:SysLog(00050129)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:09
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
 /// 表SysLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_SysLog
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
public K_mId_SysLog(long lngmId)
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
 /// <returns>返回:[K_mId_SysLog]类型的对象</returns>
public static implicit operator K_mId_SysLog(long value)
{
return new K_mId_SysLog(value);
}
}
 /// <summary>
 /// 系统日志(SysLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 13;
public static string[] _AttributeName = new string[] {"mId", "LoginTime", "LoginDate", "TableName", "TableKey", "UserIp", "OpTypeId", "OpContent", "OpDate", "OpTime", "PrjId", "UserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrLoginTime;    //登陆时间
protected string mstrLoginDate;    //登陆日期
protected string mstrTableName;    //表名
protected string mstrTableKey;    //数据表关键字值
protected string mstrUserIp;    //用户IP
protected string mstrOpTypeId;    //操作类型Id
protected string mstrOpContent;    //操作内容
protected string mstrOpDate;    //操作日期
protected string mstrOpTime;    //操作时间
protected string mstrPrjId;    //工程Id
protected string mstrUserId;    //用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsSysLogEN()
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
public clsSysLogEN(long lngmId)
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
if (strAttributeName  ==  conSysLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conSysLog.LoginTime)
{
return mstrLoginTime;
}
else if (strAttributeName  ==  conSysLog.LoginDate)
{
return mstrLoginDate;
}
else if (strAttributeName  ==  conSysLog.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  conSysLog.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  conSysLog.UserIp)
{
return mstrUserIp;
}
else if (strAttributeName  ==  conSysLog.OpTypeId)
{
return mstrOpTypeId;
}
else if (strAttributeName  ==  conSysLog.OpContent)
{
return mstrOpContent;
}
else if (strAttributeName  ==  conSysLog.OpDate)
{
return mstrOpDate;
}
else if (strAttributeName  ==  conSysLog.OpTime)
{
return mstrOpTime;
}
else if (strAttributeName  ==  conSysLog.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conSysLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conSysLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSysLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysLog.mId);
}
else if (strAttributeName  ==  conSysLog.LoginTime)
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conSysLog.LoginTime);
}
else if (strAttributeName  ==  conSysLog.LoginDate)
{
mstrLoginDate = value.ToString();
 AddUpdatedFld(conSysLog.LoginDate);
}
else if (strAttributeName  ==  conSysLog.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(conSysLog.TableName);
}
else if (strAttributeName  ==  conSysLog.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conSysLog.TableKey);
}
else if (strAttributeName  ==  conSysLog.UserIp)
{
mstrUserIp = value.ToString();
 AddUpdatedFld(conSysLog.UserIp);
}
else if (strAttributeName  ==  conSysLog.OpTypeId)
{
mstrOpTypeId = value.ToString();
 AddUpdatedFld(conSysLog.OpTypeId);
}
else if (strAttributeName  ==  conSysLog.OpContent)
{
mstrOpContent = value.ToString();
 AddUpdatedFld(conSysLog.OpContent);
}
else if (strAttributeName  ==  conSysLog.OpDate)
{
mstrOpDate = value.ToString();
 AddUpdatedFld(conSysLog.OpDate);
}
else if (strAttributeName  ==  conSysLog.OpTime)
{
mstrOpTime = value.ToString();
 AddUpdatedFld(conSysLog.OpTime);
}
else if (strAttributeName  ==  conSysLog.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSysLog.PrjId);
}
else if (strAttributeName  ==  conSysLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSysLog.UserId);
}
else if (strAttributeName  ==  conSysLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysLog.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conSysLog.LoginTime  ==  _AttributeName[intIndex])
{
return mstrLoginTime;
}
else if (conSysLog.LoginDate  ==  _AttributeName[intIndex])
{
return mstrLoginDate;
}
else if (conSysLog.TableName  ==  _AttributeName[intIndex])
{
return mstrTableName;
}
else if (conSysLog.TableKey  ==  _AttributeName[intIndex])
{
return mstrTableKey;
}
else if (conSysLog.UserIp  ==  _AttributeName[intIndex])
{
return mstrUserIp;
}
else if (conSysLog.OpTypeId  ==  _AttributeName[intIndex])
{
return mstrOpTypeId;
}
else if (conSysLog.OpContent  ==  _AttributeName[intIndex])
{
return mstrOpContent;
}
else if (conSysLog.OpDate  ==  _AttributeName[intIndex])
{
return mstrOpDate;
}
else if (conSysLog.OpTime  ==  _AttributeName[intIndex])
{
return mstrOpTime;
}
else if (conSysLog.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conSysLog.UserId  ==  _AttributeName[intIndex])
{
return mstrUserId;
}
else if (conSysLog.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSysLog.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysLog.mId);
}
else if (conSysLog.LoginTime  ==  _AttributeName[intIndex])
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(conSysLog.LoginTime);
}
else if (conSysLog.LoginDate  ==  _AttributeName[intIndex])
{
mstrLoginDate = value.ToString();
 AddUpdatedFld(conSysLog.LoginDate);
}
else if (conSysLog.TableName  ==  _AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(conSysLog.TableName);
}
else if (conSysLog.TableKey  ==  _AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conSysLog.TableKey);
}
else if (conSysLog.UserIp  ==  _AttributeName[intIndex])
{
mstrUserIp = value.ToString();
 AddUpdatedFld(conSysLog.UserIp);
}
else if (conSysLog.OpTypeId  ==  _AttributeName[intIndex])
{
mstrOpTypeId = value.ToString();
 AddUpdatedFld(conSysLog.OpTypeId);
}
else if (conSysLog.OpContent  ==  _AttributeName[intIndex])
{
mstrOpContent = value.ToString();
 AddUpdatedFld(conSysLog.OpContent);
}
else if (conSysLog.OpDate  ==  _AttributeName[intIndex])
{
mstrOpDate = value.ToString();
 AddUpdatedFld(conSysLog.OpDate);
}
else if (conSysLog.OpTime  ==  _AttributeName[intIndex])
{
mstrOpTime = value.ToString();
 AddUpdatedFld(conSysLog.OpTime);
}
else if (conSysLog.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conSysLog.PrjId);
}
else if (conSysLog.UserId  ==  _AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSysLog.UserId);
}
else if (conSysLog.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysLog.Memo);
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
 AddUpdatedFld(conSysLog.mId);
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
 AddUpdatedFld(conSysLog.LoginTime);
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
 AddUpdatedFld(conSysLog.LoginDate);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableName
{
get
{
return mstrTableName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableName = value;
}
else
{
 mstrTableName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysLog.TableName);
}
}
/// <summary>
/// 数据表关键字值(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableKey
{
get
{
return mstrTableKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableKey = value;
}
else
{
 mstrTableKey = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysLog.TableKey);
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
 AddUpdatedFld(conSysLog.UserIp);
}
}
/// <summary>
/// 操作类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpTypeId
{
get
{
return mstrOpTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpTypeId = value;
}
else
{
 mstrOpTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysLog.OpTypeId);
}
}
/// <summary>
/// 操作内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpContent
{
get
{
return mstrOpContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpContent = value;
}
else
{
 mstrOpContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysLog.OpContent);
}
}
/// <summary>
/// 操作日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpDate
{
get
{
return mstrOpDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpDate = value;
}
else
{
 mstrOpDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysLog.OpDate);
}
}
/// <summary>
/// 操作时间(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpTime
{
get
{
return mstrOpTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpTime = value;
}
else
{
 mstrOpTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysLog.OpTime);
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
 AddUpdatedFld(conSysLog.PrjId);
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
 AddUpdatedFld(conSysLog.UserId);
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
 AddUpdatedFld(conSysLog.Memo);
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
 /// 系统日志(SysLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysLog
{
public const string _CurrTabName = "SysLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "LoginTime", "LoginDate", "TableName", "TableKey", "UserIp", "OpTypeId", "OpContent", "OpDate", "OpTime", "PrjId", "UserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"TableName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableName = "TableName";    //表名

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //数据表关键字值

 /// <summary>
 /// 常量:"UserIp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserIp = "UserIp";    //用户IP

 /// <summary>
 /// 常量:"OpTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpTypeId = "OpTypeId";    //操作类型Id

 /// <summary>
 /// 常量:"OpContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpContent = "OpContent";    //操作内容

 /// <summary>
 /// 常量:"OpDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpDate = "OpDate";    //操作日期

 /// <summary>
 /// 常量:"OpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpTime = "OpTime";    //操作时间

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}