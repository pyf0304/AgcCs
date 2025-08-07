
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataSynConfigEN
 表名:DataSynConfig(00050346)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// 表DataSynConfig的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_DataSynConfig
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
public K_mId_DataSynConfig(long lngmId)
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
 /// <returns>返回:[K_mId_DataSynConfig]类型的对象</returns>
public static implicit operator K_mId_DataSynConfig(long value)
{
return new K_mId_DataSynConfig(value);
}
}
 /// <summary>
 /// 同步配置(DataSynConfig)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataSynConfigEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "DataSynConfig"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"mId", "TabName", "IsSynch", "SynCondition", "SynCondition4Web", "SynchCycle", "SynchDate", "SynchTime", "SenderUser", "SenderPwd", "smtp", "Receiver", "lastMailDate", "lastExecuteDate", "SynchStartTime", "SynchEndTime", "OrderNum", "Memo"};

protected long mlngmId;    //mId
protected string mstrTabName;    //表名
protected bool mbolIsSynch;    //是否同步
protected string mstrSynCondition;    //同步条件
protected string mstrSynCondition4Web;    //同步条件4Web
protected string mstrSynchCycle;    //同步周期
protected string mstrSynchDate;    //同步日期
protected string mstrSynchTime;    //同步时间
protected string mstrSenderUser;    //发送邮件用户
protected string mstrSenderPwd;    //发送邮件口令
protected string mstrsmtp;    //发送邮件服务器
protected string mstrReceiver;    //接收者
protected string mstrlastMailDate;    //最后发邮件日期
protected string mstrlastExecuteDate;    //最后执行日期
protected string mstrSynchStartTime;    //同步开始时间
protected string mstrSynchEndTime;    //同步结束时间
protected int mintOrderNum;    //序号
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDataSynConfigEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DataSynConfig";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsDataSynConfigEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "DataSynConfig";
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
if (strAttributeName  ==  conDataSynConfig.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conDataSynConfig.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conDataSynConfig.IsSynch)
{
return mbolIsSynch;
}
else if (strAttributeName  ==  conDataSynConfig.SynCondition)
{
return mstrSynCondition;
}
else if (strAttributeName  ==  conDataSynConfig.SynCondition4Web)
{
return mstrSynCondition4Web;
}
else if (strAttributeName  ==  conDataSynConfig.SynchCycle)
{
return mstrSynchCycle;
}
else if (strAttributeName  ==  conDataSynConfig.SynchDate)
{
return mstrSynchDate;
}
else if (strAttributeName  ==  conDataSynConfig.SynchTime)
{
return mstrSynchTime;
}
else if (strAttributeName  ==  conDataSynConfig.SenderUser)
{
return mstrSenderUser;
}
else if (strAttributeName  ==  conDataSynConfig.SenderPwd)
{
return mstrSenderPwd;
}
else if (strAttributeName  ==  conDataSynConfig.smtp)
{
return mstrsmtp;
}
else if (strAttributeName  ==  conDataSynConfig.Receiver)
{
return mstrReceiver;
}
else if (strAttributeName  ==  conDataSynConfig.lastMailDate)
{
return mstrlastMailDate;
}
else if (strAttributeName  ==  conDataSynConfig.lastExecuteDate)
{
return mstrlastExecuteDate;
}
else if (strAttributeName  ==  conDataSynConfig.SynchStartTime)
{
return mstrSynchStartTime;
}
else if (strAttributeName  ==  conDataSynConfig.SynchEndTime)
{
return mstrSynchEndTime;
}
else if (strAttributeName  ==  conDataSynConfig.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conDataSynConfig.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDataSynConfig.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataSynConfig.mId);
}
else if (strAttributeName  ==  conDataSynConfig.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conDataSynConfig.TabName);
}
else if (strAttributeName  ==  conDataSynConfig.IsSynch)
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataSynConfig.IsSynch);
}
else if (strAttributeName  ==  conDataSynConfig.SynCondition)
{
mstrSynCondition = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynCondition);
}
else if (strAttributeName  ==  conDataSynConfig.SynCondition4Web)
{
mstrSynCondition4Web = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynCondition4Web);
}
else if (strAttributeName  ==  conDataSynConfig.SynchCycle)
{
mstrSynchCycle = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchCycle);
}
else if (strAttributeName  ==  conDataSynConfig.SynchDate)
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchDate);
}
else if (strAttributeName  ==  conDataSynConfig.SynchTime)
{
mstrSynchTime = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchTime);
}
else if (strAttributeName  ==  conDataSynConfig.SenderUser)
{
mstrSenderUser = value.ToString();
 AddUpdatedFld(conDataSynConfig.SenderUser);
}
else if (strAttributeName  ==  conDataSynConfig.SenderPwd)
{
mstrSenderPwd = value.ToString();
 AddUpdatedFld(conDataSynConfig.SenderPwd);
}
else if (strAttributeName  ==  conDataSynConfig.smtp)
{
mstrsmtp = value.ToString();
 AddUpdatedFld(conDataSynConfig.smtp);
}
else if (strAttributeName  ==  conDataSynConfig.Receiver)
{
mstrReceiver = value.ToString();
 AddUpdatedFld(conDataSynConfig.Receiver);
}
else if (strAttributeName  ==  conDataSynConfig.lastMailDate)
{
mstrlastMailDate = value.ToString();
 AddUpdatedFld(conDataSynConfig.lastMailDate);
}
else if (strAttributeName  ==  conDataSynConfig.lastExecuteDate)
{
mstrlastExecuteDate = value.ToString();
 AddUpdatedFld(conDataSynConfig.lastExecuteDate);
}
else if (strAttributeName  ==  conDataSynConfig.SynchStartTime)
{
mstrSynchStartTime = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchStartTime);
}
else if (strAttributeName  ==  conDataSynConfig.SynchEndTime)
{
mstrSynchEndTime = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchEndTime);
}
else if (strAttributeName  ==  conDataSynConfig.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataSynConfig.OrderNum);
}
else if (strAttributeName  ==  conDataSynConfig.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataSynConfig.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDataSynConfig.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conDataSynConfig.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (conDataSynConfig.IsSynch  ==  AttributeName[intIndex])
{
return mbolIsSynch;
}
else if (conDataSynConfig.SynCondition  ==  AttributeName[intIndex])
{
return mstrSynCondition;
}
else if (conDataSynConfig.SynCondition4Web  ==  AttributeName[intIndex])
{
return mstrSynCondition4Web;
}
else if (conDataSynConfig.SynchCycle  ==  AttributeName[intIndex])
{
return mstrSynchCycle;
}
else if (conDataSynConfig.SynchDate  ==  AttributeName[intIndex])
{
return mstrSynchDate;
}
else if (conDataSynConfig.SynchTime  ==  AttributeName[intIndex])
{
return mstrSynchTime;
}
else if (conDataSynConfig.SenderUser  ==  AttributeName[intIndex])
{
return mstrSenderUser;
}
else if (conDataSynConfig.SenderPwd  ==  AttributeName[intIndex])
{
return mstrSenderPwd;
}
else if (conDataSynConfig.smtp  ==  AttributeName[intIndex])
{
return mstrsmtp;
}
else if (conDataSynConfig.Receiver  ==  AttributeName[intIndex])
{
return mstrReceiver;
}
else if (conDataSynConfig.lastMailDate  ==  AttributeName[intIndex])
{
return mstrlastMailDate;
}
else if (conDataSynConfig.lastExecuteDate  ==  AttributeName[intIndex])
{
return mstrlastExecuteDate;
}
else if (conDataSynConfig.SynchStartTime  ==  AttributeName[intIndex])
{
return mstrSynchStartTime;
}
else if (conDataSynConfig.SynchEndTime  ==  AttributeName[intIndex])
{
return mstrSynchEndTime;
}
else if (conDataSynConfig.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conDataSynConfig.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDataSynConfig.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataSynConfig.mId);
}
else if (conDataSynConfig.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conDataSynConfig.TabName);
}
else if (conDataSynConfig.IsSynch  ==  AttributeName[intIndex])
{
mbolIsSynch = TransNullToBool(value.ToString());
 AddUpdatedFld(conDataSynConfig.IsSynch);
}
else if (conDataSynConfig.SynCondition  ==  AttributeName[intIndex])
{
mstrSynCondition = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynCondition);
}
else if (conDataSynConfig.SynCondition4Web  ==  AttributeName[intIndex])
{
mstrSynCondition4Web = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynCondition4Web);
}
else if (conDataSynConfig.SynchCycle  ==  AttributeName[intIndex])
{
mstrSynchCycle = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchCycle);
}
else if (conDataSynConfig.SynchDate  ==  AttributeName[intIndex])
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchDate);
}
else if (conDataSynConfig.SynchTime  ==  AttributeName[intIndex])
{
mstrSynchTime = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchTime);
}
else if (conDataSynConfig.SenderUser  ==  AttributeName[intIndex])
{
mstrSenderUser = value.ToString();
 AddUpdatedFld(conDataSynConfig.SenderUser);
}
else if (conDataSynConfig.SenderPwd  ==  AttributeName[intIndex])
{
mstrSenderPwd = value.ToString();
 AddUpdatedFld(conDataSynConfig.SenderPwd);
}
else if (conDataSynConfig.smtp  ==  AttributeName[intIndex])
{
mstrsmtp = value.ToString();
 AddUpdatedFld(conDataSynConfig.smtp);
}
else if (conDataSynConfig.Receiver  ==  AttributeName[intIndex])
{
mstrReceiver = value.ToString();
 AddUpdatedFld(conDataSynConfig.Receiver);
}
else if (conDataSynConfig.lastMailDate  ==  AttributeName[intIndex])
{
mstrlastMailDate = value.ToString();
 AddUpdatedFld(conDataSynConfig.lastMailDate);
}
else if (conDataSynConfig.lastExecuteDate  ==  AttributeName[intIndex])
{
mstrlastExecuteDate = value.ToString();
 AddUpdatedFld(conDataSynConfig.lastExecuteDate);
}
else if (conDataSynConfig.SynchStartTime  ==  AttributeName[intIndex])
{
mstrSynchStartTime = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchStartTime);
}
else if (conDataSynConfig.SynchEndTime  ==  AttributeName[intIndex])
{
mstrSynchEndTime = value.ToString();
 AddUpdatedFld(conDataSynConfig.SynchEndTime);
}
else if (conDataSynConfig.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDataSynConfig.OrderNum);
}
else if (conDataSynConfig.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDataSynConfig.Memo);
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
 AddUpdatedFld(conDataSynConfig.mId);
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
 AddUpdatedFld(conDataSynConfig.TabName);
}
}
/// <summary>
/// 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynch
{
get
{
return mbolIsSynch;
}
set
{
 mbolIsSynch = value;
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.IsSynch);
}
}
/// <summary>
/// 同步条件(说明:;字段类型:varchar;字段长度:5000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynCondition
{
get
{
return mstrSynCondition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynCondition = value;
}
else
{
 mstrSynCondition = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SynCondition);
}
}
/// <summary>
/// 同步条件4Web(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynCondition4Web
{
get
{
return mstrSynCondition4Web;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynCondition4Web = value;
}
else
{
 mstrSynCondition4Web = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SynCondition4Web);
}
}
/// <summary>
/// 同步周期(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchCycle
{
get
{
return mstrSynchCycle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchCycle = value;
}
else
{
 mstrSynchCycle = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SynchCycle);
}
}
/// <summary>
/// 同步日期(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchDate
{
get
{
return mstrSynchDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchDate = value;
}
else
{
 mstrSynchDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SynchDate);
}
}
/// <summary>
/// 同步时间(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchTime
{
get
{
return mstrSynchTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchTime = value;
}
else
{
 mstrSynchTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SynchTime);
}
}
/// <summary>
/// 发送邮件用户(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenderUser
{
get
{
return mstrSenderUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenderUser = value;
}
else
{
 mstrSenderUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SenderUser);
}
}
/// <summary>
/// 发送邮件口令(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenderPwd
{
get
{
return mstrSenderPwd;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenderPwd = value;
}
else
{
 mstrSenderPwd = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SenderPwd);
}
}
/// <summary>
/// 发送邮件服务器(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string smtp
{
get
{
return mstrsmtp;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsmtp = value;
}
else
{
 mstrsmtp = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.smtp);
}
}
/// <summary>
/// 接收者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Receiver
{
get
{
return mstrReceiver;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReceiver = value;
}
else
{
 mstrReceiver = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.Receiver);
}
}
/// <summary>
/// 最后发邮件日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string lastMailDate
{
get
{
return mstrlastMailDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrlastMailDate = value;
}
else
{
 mstrlastMailDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.lastMailDate);
}
}
/// <summary>
/// 最后执行日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string lastExecuteDate
{
get
{
return mstrlastExecuteDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrlastExecuteDate = value;
}
else
{
 mstrlastExecuteDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.lastExecuteDate);
}
}
/// <summary>
/// 同步开始时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchStartTime
{
get
{
return mstrSynchStartTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchStartTime = value;
}
else
{
 mstrSynchStartTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SynchStartTime);
}
}
/// <summary>
/// 同步结束时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchEndTime
{
get
{
return mstrSynchEndTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchEndTime = value;
}
else
{
 mstrSynchEndTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conDataSynConfig.SynchEndTime);
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
 AddUpdatedFld(conDataSynConfig.OrderNum);
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
 AddUpdatedFld(conDataSynConfig.Memo);
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
 /// 同步配置(DataSynConfig)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDataSynConfig
{
public new const string _CurrTabName = "DataSynConfig"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TabName", "IsSynch", "SynCondition", "SynCondition4Web", "SynchCycle", "SynchDate", "SynchTime", "SenderUser", "SenderPwd", "smtp", "Receiver", "lastMailDate", "lastExecuteDate", "SynchStartTime", "SynchEndTime", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"IsSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynch = "IsSynch";    //是否同步

 /// <summary>
 /// 常量:"SynCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynCondition = "SynCondition";    //同步条件

 /// <summary>
 /// 常量:"SynCondition4Web"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynCondition4Web = "SynCondition4Web";    //同步条件4Web

 /// <summary>
 /// 常量:"SynchCycle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchCycle = "SynchCycle";    //同步周期

 /// <summary>
 /// 常量:"SynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchDate = "SynchDate";    //同步日期

 /// <summary>
 /// 常量:"SynchTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchTime = "SynchTime";    //同步时间

 /// <summary>
 /// 常量:"SenderUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenderUser = "SenderUser";    //发送邮件用户

 /// <summary>
 /// 常量:"SenderPwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenderPwd = "SenderPwd";    //发送邮件口令

 /// <summary>
 /// 常量:"smtp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string smtp = "smtp";    //发送邮件服务器

 /// <summary>
 /// 常量:"Receiver"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Receiver = "Receiver";    //接收者

 /// <summary>
 /// 常量:"lastMailDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string lastMailDate = "lastMailDate";    //最后发邮件日期

 /// <summary>
 /// 常量:"lastExecuteDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string lastExecuteDate = "lastExecuteDate";    //最后执行日期

 /// <summary>
 /// 常量:"SynchStartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchStartTime = "SynchStartTime";    //同步开始时间

 /// <summary>
 /// 常量:"SynchEndTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchEndTime = "SynchEndTime";    //同步结束时间

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}