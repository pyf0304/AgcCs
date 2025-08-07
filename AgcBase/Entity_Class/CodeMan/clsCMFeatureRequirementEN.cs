
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureRequirementEN
 表名:CMFeatureRequirement(00050520)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// 表CMFeatureRequirement的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CMFeatureRequirement
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
public K_mId_CMFeatureRequirement(long lngmId)
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
 /// <returns>返回:[K_mId_CMFeatureRequirement]类型的对象</returns>
public static implicit operator K_mId_CMFeatureRequirement(long value)
{
return new K_mId_CMFeatureRequirement(value);
}
}
 /// <summary>
 /// CM功能需求关系(CMFeatureRequirement)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMFeatureRequirementEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMFeatureRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"mId", "CmFeatureId", "ReqId", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};

protected long mlngmId;    //mId
protected string mstrCmFeatureId;    //功能Id
protected string mstrReqId;    //需求Id
protected int mintOrderNum;    //序号
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected bool mbolIsSynchToServer;    //是否同步到Server
protected string mstrSynchToServerDate;    //同步到Server日期
protected string mstrSynchToServerUser;    //同步到Server用户
protected bool mbolIsSynchToClient;    //是否同步到Client
protected string mstrSynchToClientDate;    //同步到Client库日期
protected string mstrSynchToClientUser;    //同步到Client库用户
protected string mstrSynSource;    //同步来源

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMFeatureRequirementEN()
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
public clsCMFeatureRequirementEN(long lngmId)
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
if (strAttributeName  ==  conCMFeatureRequirement.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCMFeatureRequirement.CmFeatureId)
{
return mstrCmFeatureId;
}
else if (strAttributeName  ==  conCMFeatureRequirement.ReqId)
{
return mstrReqId;
}
else if (strAttributeName  ==  conCMFeatureRequirement.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCMFeatureRequirement.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMFeatureRequirement.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMFeatureRequirement.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMFeatureRequirement.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conCMFeatureRequirement.IsSynchToServer)
{
return mbolIsSynchToServer;
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToServerDate)
{
return mstrSynchToServerDate;
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToServerUser)
{
return mstrSynchToServerUser;
}
else if (strAttributeName  ==  conCMFeatureRequirement.IsSynchToClient)
{
return mbolIsSynchToClient;
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToClientDate)
{
return mstrSynchToClientDate;
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToClientUser)
{
return mstrSynchToClientUser;
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynSource)
{
return mstrSynSource;
}
return null;
}
set
{
if (strAttributeName  ==  conCMFeatureRequirement.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.mId);
}
else if (strAttributeName  ==  conCMFeatureRequirement.CmFeatureId)
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.CmFeatureId);
}
else if (strAttributeName  ==  conCMFeatureRequirement.ReqId)
{
mstrReqId = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.ReqId);
}
else if (strAttributeName  ==  conCMFeatureRequirement.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.OrderNum);
}
else if (strAttributeName  ==  conCMFeatureRequirement.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.PrjId);
}
else if (strAttributeName  ==  conCMFeatureRequirement.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.UpdDate);
}
else if (strAttributeName  ==  conCMFeatureRequirement.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.UpdUser);
}
else if (strAttributeName  ==  conCMFeatureRequirement.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.Memo);
}
else if (strAttributeName  ==  conCMFeatureRequirement.IsSynchToServer)
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.IsSynchToServer);
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToServerDate)
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToServerDate);
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToServerUser)
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToServerUser);
}
else if (strAttributeName  ==  conCMFeatureRequirement.IsSynchToClient)
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.IsSynchToClient);
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToClientDate)
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToClientDate);
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynchToClientUser)
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToClientUser);
}
else if (strAttributeName  ==  conCMFeatureRequirement.SynSource)
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynSource);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMFeatureRequirement.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (conCMFeatureRequirement.CmFeatureId  ==  _AttributeName[intIndex])
{
return mstrCmFeatureId;
}
else if (conCMFeatureRequirement.ReqId  ==  _AttributeName[intIndex])
{
return mstrReqId;
}
else if (conCMFeatureRequirement.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCMFeatureRequirement.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMFeatureRequirement.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMFeatureRequirement.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMFeatureRequirement.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conCMFeatureRequirement.IsSynchToServer  ==  _AttributeName[intIndex])
{
return mbolIsSynchToServer;
}
else if (conCMFeatureRequirement.SynchToServerDate  ==  _AttributeName[intIndex])
{
return mstrSynchToServerDate;
}
else if (conCMFeatureRequirement.SynchToServerUser  ==  _AttributeName[intIndex])
{
return mstrSynchToServerUser;
}
else if (conCMFeatureRequirement.IsSynchToClient  ==  _AttributeName[intIndex])
{
return mbolIsSynchToClient;
}
else if (conCMFeatureRequirement.SynchToClientDate  ==  _AttributeName[intIndex])
{
return mstrSynchToClientDate;
}
else if (conCMFeatureRequirement.SynchToClientUser  ==  _AttributeName[intIndex])
{
return mstrSynchToClientUser;
}
else if (conCMFeatureRequirement.SynSource  ==  _AttributeName[intIndex])
{
return mstrSynSource;
}
return null;
}
set
{
if (conCMFeatureRequirement.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.mId);
}
else if (conCMFeatureRequirement.CmFeatureId  ==  _AttributeName[intIndex])
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.CmFeatureId);
}
else if (conCMFeatureRequirement.ReqId  ==  _AttributeName[intIndex])
{
mstrReqId = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.ReqId);
}
else if (conCMFeatureRequirement.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.OrderNum);
}
else if (conCMFeatureRequirement.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.PrjId);
}
else if (conCMFeatureRequirement.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.UpdDate);
}
else if (conCMFeatureRequirement.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.UpdUser);
}
else if (conCMFeatureRequirement.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.Memo);
}
else if (conCMFeatureRequirement.IsSynchToServer  ==  _AttributeName[intIndex])
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.IsSynchToServer);
}
else if (conCMFeatureRequirement.SynchToServerDate  ==  _AttributeName[intIndex])
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToServerDate);
}
else if (conCMFeatureRequirement.SynchToServerUser  ==  _AttributeName[intIndex])
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToServerUser);
}
else if (conCMFeatureRequirement.IsSynchToClient  ==  _AttributeName[intIndex])
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFeatureRequirement.IsSynchToClient);
}
else if (conCMFeatureRequirement.SynchToClientDate  ==  _AttributeName[intIndex])
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToClientDate);
}
else if (conCMFeatureRequirement.SynchToClientUser  ==  _AttributeName[intIndex])
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynchToClientUser);
}
else if (conCMFeatureRequirement.SynSource  ==  _AttributeName[intIndex])
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMFeatureRequirement.SynSource);
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
 AddUpdatedFld(conCMFeatureRequirement.mId);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFeatureId
{
get
{
return mstrCmFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFeatureId = value;
}
else
{
 mstrCmFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.CmFeatureId);
}
}
/// <summary>
/// 需求Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReqId
{
get
{
return mstrReqId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReqId = value;
}
else
{
 mstrReqId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.ReqId);
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
 AddUpdatedFld(conCMFeatureRequirement.OrderNum);
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
 AddUpdatedFld(conCMFeatureRequirement.PrjId);
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
 AddUpdatedFld(conCMFeatureRequirement.UpdDate);
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
 AddUpdatedFld(conCMFeatureRequirement.UpdUser);
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
 AddUpdatedFld(conCMFeatureRequirement.Memo);
}
}
/// <summary>
/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToServer
{
get
{
return mbolIsSynchToServer;
}
set
{
 mbolIsSynchToServer = value;
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.IsSynchToServer);
}
}
/// <summary>
/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerDate
{
get
{
return mstrSynchToServerDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerDate = value;
}
else
{
 mstrSynchToServerDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.SynchToServerDate);
}
}
/// <summary>
/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToServerUser
{
get
{
return mstrSynchToServerUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToServerUser = value;
}
else
{
 mstrSynchToServerUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.SynchToServerUser);
}
}
/// <summary>
/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToClient
{
get
{
return mbolIsSynchToClient;
}
set
{
 mbolIsSynchToClient = value;
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.IsSynchToClient);
}
}
/// <summary>
/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientDate
{
get
{
return mstrSynchToClientDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientDate = value;
}
else
{
 mstrSynchToClientDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.SynchToClientDate);
}
}
/// <summary>
/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchToClientUser
{
get
{
return mstrSynchToClientUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToClientUser = value;
}
else
{
 mstrSynchToClientUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.SynchToClientUser);
}
}
/// <summary>
/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynSource
{
get
{
return mstrSynSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynSource = value;
}
else
{
 mstrSynSource = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeatureRequirement.SynSource);
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
 /// CM功能需求关系(CMFeatureRequirement)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMFeatureRequirement
{
public const string _CurrTabName = "CMFeatureRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CmFeatureId", "ReqId", "OrderNum", "PrjId", "UpdDate", "UpdUser", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CmFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFeatureId = "CmFeatureId";    //功能Id

 /// <summary>
 /// 常量:"ReqId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReqId = "ReqId";    //需求Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

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

 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToServer = "IsSynchToServer";    //是否同步到Server

 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerDate = "SynchToServerDate";    //同步到Server日期

 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToServerUser = "SynchToServerUser";    //同步到Server用户

 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynchToClient = "IsSynchToClient";    //是否同步到Client

 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientDate = "SynchToClientDate";    //同步到Client库日期

 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchToClientUser = "SynchToClientUser";    //同步到Client库用户

 /// <summary>
 /// 常量:"SynSource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynSource = "SynSource";    //同步来源
}

}