
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMRequirementEN
 表名:CMRequirement(00050075)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:38
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
 /// 表CMRequirement的关键字(ReqId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReqId_CMRequirement
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strReqId">表关键字</param>
public K_ReqId_CMRequirement(string strReqId)
{
if (IsValid(strReqId)) Value = strReqId;
else
{
Value = null;
}
}
private static bool IsValid(string strReqId)
{
if (string.IsNullOrEmpty(strReqId) == true) return false;
if (strReqId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ReqId_CMRequirement]类型的对象</returns>
public static implicit operator K_ReqId_CMRequirement(string value)
{
return new K_ReqId_CMRequirement(value);
}
}
 /// <summary>
 /// 项目需求(CMRequirement)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMRequirementEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReqId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 19;
public static string[] _AttributeName = new string[] {"ReqId", "RequirementName", "RequirementTypeId", "ReqContent", "UpReqId", "IsFinished", "CmPrjId", "FuncModuleAgcId", "PrjId", "UpdUser", "UpdDate", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};

protected string mstrReqId;    //需求Id
protected string mstrRequirementName;    //需求名称
protected string mstrRequirementTypeId;    //需求类型Id
protected string mstrReqContent;    //需求内容
protected string mstrUpReqId;    //上级需求Id
protected bool mbolIsFinished;    //是否完成
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
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
 public clsCMRequirementEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReqId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strReqId">关键字:需求Id</param>
public clsCMRequirementEN(string strReqId)
 {
strReqId = strReqId.Replace("'", "''");
if (strReqId.Length > 8)
{
throw new Exception("在表:CMRequirement中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReqId)  ==  true)
{
throw new Exception("在表:CMRequirement中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReqId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrReqId = strReqId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReqId");
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
if (strAttributeName  ==  conCMRequirement.ReqId)
{
return mstrReqId;
}
else if (strAttributeName  ==  conCMRequirement.RequirementName)
{
return mstrRequirementName;
}
else if (strAttributeName  ==  conCMRequirement.RequirementTypeId)
{
return mstrRequirementTypeId;
}
else if (strAttributeName  ==  conCMRequirement.ReqContent)
{
return mstrReqContent;
}
else if (strAttributeName  ==  conCMRequirement.UpReqId)
{
return mstrUpReqId;
}
else if (strAttributeName  ==  conCMRequirement.IsFinished)
{
return mbolIsFinished;
}
else if (strAttributeName  ==  conCMRequirement.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conCMRequirement.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conCMRequirement.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMRequirement.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMRequirement.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMRequirement.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conCMRequirement.IsSynchToServer)
{
return mbolIsSynchToServer;
}
else if (strAttributeName  ==  conCMRequirement.SynchToServerDate)
{
return mstrSynchToServerDate;
}
else if (strAttributeName  ==  conCMRequirement.SynchToServerUser)
{
return mstrSynchToServerUser;
}
else if (strAttributeName  ==  conCMRequirement.IsSynchToClient)
{
return mbolIsSynchToClient;
}
else if (strAttributeName  ==  conCMRequirement.SynchToClientDate)
{
return mstrSynchToClientDate;
}
else if (strAttributeName  ==  conCMRequirement.SynchToClientUser)
{
return mstrSynchToClientUser;
}
else if (strAttributeName  ==  conCMRequirement.SynSource)
{
return mstrSynSource;
}
return null;
}
set
{
if (strAttributeName  ==  conCMRequirement.ReqId)
{
mstrReqId = value.ToString();
 AddUpdatedFld(conCMRequirement.ReqId);
}
else if (strAttributeName  ==  conCMRequirement.RequirementName)
{
mstrRequirementName = value.ToString();
 AddUpdatedFld(conCMRequirement.RequirementName);
}
else if (strAttributeName  ==  conCMRequirement.RequirementTypeId)
{
mstrRequirementTypeId = value.ToString();
 AddUpdatedFld(conCMRequirement.RequirementTypeId);
}
else if (strAttributeName  ==  conCMRequirement.ReqContent)
{
mstrReqContent = value.ToString();
 AddUpdatedFld(conCMRequirement.ReqContent);
}
else if (strAttributeName  ==  conCMRequirement.UpReqId)
{
mstrUpReqId = value.ToString();
 AddUpdatedFld(conCMRequirement.UpReqId);
}
else if (strAttributeName  ==  conCMRequirement.IsFinished)
{
mbolIsFinished = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMRequirement.IsFinished);
}
else if (strAttributeName  ==  conCMRequirement.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMRequirement.CmPrjId);
}
else if (strAttributeName  ==  conCMRequirement.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conCMRequirement.FuncModuleAgcId);
}
else if (strAttributeName  ==  conCMRequirement.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMRequirement.PrjId);
}
else if (strAttributeName  ==  conCMRequirement.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMRequirement.UpdUser);
}
else if (strAttributeName  ==  conCMRequirement.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMRequirement.UpdDate);
}
else if (strAttributeName  ==  conCMRequirement.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMRequirement.Memo);
}
else if (strAttributeName  ==  conCMRequirement.IsSynchToServer)
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMRequirement.IsSynchToServer);
}
else if (strAttributeName  ==  conCMRequirement.SynchToServerDate)
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToServerDate);
}
else if (strAttributeName  ==  conCMRequirement.SynchToServerUser)
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToServerUser);
}
else if (strAttributeName  ==  conCMRequirement.IsSynchToClient)
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMRequirement.IsSynchToClient);
}
else if (strAttributeName  ==  conCMRequirement.SynchToClientDate)
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToClientDate);
}
else if (strAttributeName  ==  conCMRequirement.SynchToClientUser)
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToClientUser);
}
else if (strAttributeName  ==  conCMRequirement.SynSource)
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMRequirement.SynSource);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMRequirement.ReqId  ==  _AttributeName[intIndex])
{
return mstrReqId;
}
else if (conCMRequirement.RequirementName  ==  _AttributeName[intIndex])
{
return mstrRequirementName;
}
else if (conCMRequirement.RequirementTypeId  ==  _AttributeName[intIndex])
{
return mstrRequirementTypeId;
}
else if (conCMRequirement.ReqContent  ==  _AttributeName[intIndex])
{
return mstrReqContent;
}
else if (conCMRequirement.UpReqId  ==  _AttributeName[intIndex])
{
return mstrUpReqId;
}
else if (conCMRequirement.IsFinished  ==  _AttributeName[intIndex])
{
return mbolIsFinished;
}
else if (conCMRequirement.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conCMRequirement.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conCMRequirement.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMRequirement.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMRequirement.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMRequirement.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conCMRequirement.IsSynchToServer  ==  _AttributeName[intIndex])
{
return mbolIsSynchToServer;
}
else if (conCMRequirement.SynchToServerDate  ==  _AttributeName[intIndex])
{
return mstrSynchToServerDate;
}
else if (conCMRequirement.SynchToServerUser  ==  _AttributeName[intIndex])
{
return mstrSynchToServerUser;
}
else if (conCMRequirement.IsSynchToClient  ==  _AttributeName[intIndex])
{
return mbolIsSynchToClient;
}
else if (conCMRequirement.SynchToClientDate  ==  _AttributeName[intIndex])
{
return mstrSynchToClientDate;
}
else if (conCMRequirement.SynchToClientUser  ==  _AttributeName[intIndex])
{
return mstrSynchToClientUser;
}
else if (conCMRequirement.SynSource  ==  _AttributeName[intIndex])
{
return mstrSynSource;
}
return null;
}
set
{
if (conCMRequirement.ReqId  ==  _AttributeName[intIndex])
{
mstrReqId = value.ToString();
 AddUpdatedFld(conCMRequirement.ReqId);
}
else if (conCMRequirement.RequirementName  ==  _AttributeName[intIndex])
{
mstrRequirementName = value.ToString();
 AddUpdatedFld(conCMRequirement.RequirementName);
}
else if (conCMRequirement.RequirementTypeId  ==  _AttributeName[intIndex])
{
mstrRequirementTypeId = value.ToString();
 AddUpdatedFld(conCMRequirement.RequirementTypeId);
}
else if (conCMRequirement.ReqContent  ==  _AttributeName[intIndex])
{
mstrReqContent = value.ToString();
 AddUpdatedFld(conCMRequirement.ReqContent);
}
else if (conCMRequirement.UpReqId  ==  _AttributeName[intIndex])
{
mstrUpReqId = value.ToString();
 AddUpdatedFld(conCMRequirement.UpReqId);
}
else if (conCMRequirement.IsFinished  ==  _AttributeName[intIndex])
{
mbolIsFinished = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMRequirement.IsFinished);
}
else if (conCMRequirement.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMRequirement.CmPrjId);
}
else if (conCMRequirement.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conCMRequirement.FuncModuleAgcId);
}
else if (conCMRequirement.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMRequirement.PrjId);
}
else if (conCMRequirement.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMRequirement.UpdUser);
}
else if (conCMRequirement.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMRequirement.UpdDate);
}
else if (conCMRequirement.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMRequirement.Memo);
}
else if (conCMRequirement.IsSynchToServer  ==  _AttributeName[intIndex])
{
mbolIsSynchToServer = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMRequirement.IsSynchToServer);
}
else if (conCMRequirement.SynchToServerDate  ==  _AttributeName[intIndex])
{
mstrSynchToServerDate = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToServerDate);
}
else if (conCMRequirement.SynchToServerUser  ==  _AttributeName[intIndex])
{
mstrSynchToServerUser = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToServerUser);
}
else if (conCMRequirement.IsSynchToClient  ==  _AttributeName[intIndex])
{
mbolIsSynchToClient = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMRequirement.IsSynchToClient);
}
else if (conCMRequirement.SynchToClientDate  ==  _AttributeName[intIndex])
{
mstrSynchToClientDate = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToClientDate);
}
else if (conCMRequirement.SynchToClientUser  ==  _AttributeName[intIndex])
{
mstrSynchToClientUser = value.ToString();
 AddUpdatedFld(conCMRequirement.SynchToClientUser);
}
else if (conCMRequirement.SynSource  ==  _AttributeName[intIndex])
{
mstrSynSource = value.ToString();
 AddUpdatedFld(conCMRequirement.SynSource);
}
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
 AddUpdatedFld(conCMRequirement.ReqId);
}
}
/// <summary>
/// 需求名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequirementName
{
get
{
return mstrRequirementName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequirementName = value;
}
else
{
 mstrRequirementName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirement.RequirementName);
}
}
/// <summary>
/// 需求类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequirementTypeId
{
get
{
return mstrRequirementTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequirementTypeId = value;
}
else
{
 mstrRequirementTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirement.RequirementTypeId);
}
}
/// <summary>
/// 需求内容(说明:;字段类型:varchar;字段长度:4000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReqContent
{
get
{
return mstrReqContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReqContent = value;
}
else
{
 mstrReqContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirement.ReqContent);
}
}
/// <summary>
/// 上级需求Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpReqId
{
get
{
return mstrUpReqId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpReqId = value;
}
else
{
 mstrUpReqId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirement.UpReqId);
}
}
/// <summary>
/// 是否完成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsFinished
{
get
{
return mbolIsFinished;
}
set
{
 mbolIsFinished = value;
//记录修改过的字段
 AddUpdatedFld(conCMRequirement.IsFinished);
}
}
/// <summary>
/// Cm工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirement.CmPrjId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMRequirement.FuncModuleAgcId);
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
 AddUpdatedFld(conCMRequirement.PrjId);
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
 AddUpdatedFld(conCMRequirement.UpdUser);
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
 AddUpdatedFld(conCMRequirement.UpdDate);
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
 AddUpdatedFld(conCMRequirement.Memo);
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
 AddUpdatedFld(conCMRequirement.IsSynchToServer);
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
 AddUpdatedFld(conCMRequirement.SynchToServerDate);
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
 AddUpdatedFld(conCMRequirement.SynchToServerUser);
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
 AddUpdatedFld(conCMRequirement.IsSynchToClient);
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
 AddUpdatedFld(conCMRequirement.SynchToClientDate);
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
 AddUpdatedFld(conCMRequirement.SynchToClientUser);
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
 AddUpdatedFld(conCMRequirement.SynSource);
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
  return mstrReqId;
 }
 }
}
 /// <summary>
 /// 项目需求(CMRequirement)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMRequirement
{
public const string _CurrTabName = "CMRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReqId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ReqId", "RequirementName", "RequirementTypeId", "ReqContent", "UpReqId", "IsFinished", "CmPrjId", "FuncModuleAgcId", "PrjId", "UpdUser", "UpdDate", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource"};
//以下是属性变量


 /// <summary>
 /// 常量:"ReqId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReqId = "ReqId";    //需求Id

 /// <summary>
 /// 常量:"RequirementName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementName = "RequirementName";    //需求名称

 /// <summary>
 /// 常量:"RequirementTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementTypeId = "RequirementTypeId";    //需求类型Id

 /// <summary>
 /// 常量:"ReqContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReqContent = "ReqContent";    //需求内容

 /// <summary>
 /// 常量:"UpReqId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpReqId = "UpReqId";    //上级需求Id

 /// <summary>
 /// 常量:"IsFinished"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsFinished = "IsFinished";    //是否完成

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

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