
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysLogEN
 表名:vSysLog(00050262)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vSysLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vSysLog
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
public K_mId_vSysLog(long lngmId)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vSysLog]类型的对象</returns>
public static implicit operator K_mId_vSysLog(long value)
{
return new K_mId_vSysLog(value);
}
}
 /// <summary>
 /// v系统日志(vSysLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"mId", "UserName", "LoginTime", "LoginDate", "PrjName", "TableName", "TableKey", "OpTypeName", "UserIp", "OpTypeId", "OpContent", "OpDate", "PrjId", "OpTime", "UserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserName;    //用户名
protected string mstrLoginTime;    //登陆时间
protected string mstrLoginDate;    //登陆日期
protected string mstrPrjName;    //工程名称
protected string mstrTableName;    //表名
protected string mstrTableKey;    //数据表关键字值
protected string mstrOpTypeName;    //操作类型名称
protected string mstrUserIp;    //用户IP
protected string mstrOpTypeId;    //操作类型Id
protected string mstrOpContent;    //操作内容
protected string mstrOpDate;    //操作日期
protected string mstrPrjId;    //工程ID
protected string mstrOpTime;    //操作时间
protected string mstrUserId;    //用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vSysLog";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvSysLogEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "vSysLog";
 lstKeyFldNames.Add("mId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convSysLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convSysLog.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convSysLog.LoginTime)
{
return mstrLoginTime;
}
else if (strAttributeName  ==  convSysLog.LoginDate)
{
return mstrLoginDate;
}
else if (strAttributeName  ==  convSysLog.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convSysLog.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  convSysLog.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  convSysLog.OpTypeName)
{
return mstrOpTypeName;
}
else if (strAttributeName  ==  convSysLog.UserIp)
{
return mstrUserIp;
}
else if (strAttributeName  ==  convSysLog.OpTypeId)
{
return mstrOpTypeId;
}
else if (strAttributeName  ==  convSysLog.OpContent)
{
return mstrOpContent;
}
else if (strAttributeName  ==  convSysLog.OpDate)
{
return mstrOpDate;
}
else if (strAttributeName  ==  convSysLog.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convSysLog.OpTime)
{
return mstrOpTime;
}
else if (strAttributeName  ==  convSysLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convSysLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convSysLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysLog.mId);
}
else if (strAttributeName  ==  convSysLog.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convSysLog.UserName);
}
else if (strAttributeName  ==  convSysLog.LoginTime)
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(convSysLog.LoginTime);
}
else if (strAttributeName  ==  convSysLog.LoginDate)
{
mstrLoginDate = value.ToString();
 AddUpdatedFld(convSysLog.LoginDate);
}
else if (strAttributeName  ==  convSysLog.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convSysLog.PrjName);
}
else if (strAttributeName  ==  convSysLog.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(convSysLog.TableName);
}
else if (strAttributeName  ==  convSysLog.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysLog.TableKey);
}
else if (strAttributeName  ==  convSysLog.OpTypeName)
{
mstrOpTypeName = value.ToString();
 AddUpdatedFld(convSysLog.OpTypeName);
}
else if (strAttributeName  ==  convSysLog.UserIp)
{
mstrUserIp = value.ToString();
 AddUpdatedFld(convSysLog.UserIp);
}
else if (strAttributeName  ==  convSysLog.OpTypeId)
{
mstrOpTypeId = value.ToString();
 AddUpdatedFld(convSysLog.OpTypeId);
}
else if (strAttributeName  ==  convSysLog.OpContent)
{
mstrOpContent = value.ToString();
 AddUpdatedFld(convSysLog.OpContent);
}
else if (strAttributeName  ==  convSysLog.OpDate)
{
mstrOpDate = value.ToString();
 AddUpdatedFld(convSysLog.OpDate);
}
else if (strAttributeName  ==  convSysLog.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSysLog.PrjId);
}
else if (strAttributeName  ==  convSysLog.OpTime)
{
mstrOpTime = value.ToString();
 AddUpdatedFld(convSysLog.OpTime);
}
else if (strAttributeName  ==  convSysLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSysLog.UserId);
}
else if (strAttributeName  ==  convSysLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convSysLog.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convSysLog.LoginTime  ==  AttributeName[intIndex])
{
return mstrLoginTime;
}
else if (convSysLog.LoginDate  ==  AttributeName[intIndex])
{
return mstrLoginDate;
}
else if (convSysLog.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convSysLog.TableName  ==  AttributeName[intIndex])
{
return mstrTableName;
}
else if (convSysLog.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (convSysLog.OpTypeName  ==  AttributeName[intIndex])
{
return mstrOpTypeName;
}
else if (convSysLog.UserIp  ==  AttributeName[intIndex])
{
return mstrUserIp;
}
else if (convSysLog.OpTypeId  ==  AttributeName[intIndex])
{
return mstrOpTypeId;
}
else if (convSysLog.OpContent  ==  AttributeName[intIndex])
{
return mstrOpContent;
}
else if (convSysLog.OpDate  ==  AttributeName[intIndex])
{
return mstrOpDate;
}
else if (convSysLog.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convSysLog.OpTime  ==  AttributeName[intIndex])
{
return mstrOpTime;
}
else if (convSysLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convSysLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convSysLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysLog.mId);
}
else if (convSysLog.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convSysLog.UserName);
}
else if (convSysLog.LoginTime  ==  AttributeName[intIndex])
{
mstrLoginTime = value.ToString();
 AddUpdatedFld(convSysLog.LoginTime);
}
else if (convSysLog.LoginDate  ==  AttributeName[intIndex])
{
mstrLoginDate = value.ToString();
 AddUpdatedFld(convSysLog.LoginDate);
}
else if (convSysLog.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convSysLog.PrjName);
}
else if (convSysLog.TableName  ==  AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(convSysLog.TableName);
}
else if (convSysLog.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysLog.TableKey);
}
else if (convSysLog.OpTypeName  ==  AttributeName[intIndex])
{
mstrOpTypeName = value.ToString();
 AddUpdatedFld(convSysLog.OpTypeName);
}
else if (convSysLog.UserIp  ==  AttributeName[intIndex])
{
mstrUserIp = value.ToString();
 AddUpdatedFld(convSysLog.UserIp);
}
else if (convSysLog.OpTypeId  ==  AttributeName[intIndex])
{
mstrOpTypeId = value.ToString();
 AddUpdatedFld(convSysLog.OpTypeId);
}
else if (convSysLog.OpContent  ==  AttributeName[intIndex])
{
mstrOpContent = value.ToString();
 AddUpdatedFld(convSysLog.OpContent);
}
else if (convSysLog.OpDate  ==  AttributeName[intIndex])
{
mstrOpDate = value.ToString();
 AddUpdatedFld(convSysLog.OpDate);
}
else if (convSysLog.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSysLog.PrjId);
}
else if (convSysLog.OpTime  ==  AttributeName[intIndex])
{
mstrOpTime = value.ToString();
 AddUpdatedFld(convSysLog.OpTime);
}
else if (convSysLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSysLog.UserId);
}
else if (convSysLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysLog.Memo);
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
 AddUpdatedFld(convSysLog.mId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysLog.UserName);
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
 AddUpdatedFld(convSysLog.LoginTime);
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
 AddUpdatedFld(convSysLog.LoginDate);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysLog.PrjName);
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
 AddUpdatedFld(convSysLog.TableName);
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
 AddUpdatedFld(convSysLog.TableKey);
}
}
/// <summary>
/// 操作类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpTypeName
{
get
{
return mstrOpTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpTypeName = value;
}
else
{
 mstrOpTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysLog.OpTypeName);
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
 AddUpdatedFld(convSysLog.UserIp);
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
 AddUpdatedFld(convSysLog.OpTypeId);
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
 AddUpdatedFld(convSysLog.OpContent);
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
 AddUpdatedFld(convSysLog.OpDate);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convSysLog.PrjId);
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
 AddUpdatedFld(convSysLog.OpTime);
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
 AddUpdatedFld(convSysLog.UserId);
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
 AddUpdatedFld(convSysLog.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
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
 /// v系统日志(vSysLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysLog
{
public new const string _CurrTabName = "vSysLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserName", "LoginTime", "LoginDate", "PrjName", "TableName", "TableKey", "OpTypeName", "UserIp", "OpTypeId", "OpContent", "OpDate", "PrjId", "OpTime", "UserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

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
 /// 常量:"OpTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpTypeName = "OpTypeName";    //操作类型名称

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
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"OpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpTime = "OpTime";    //操作时间

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