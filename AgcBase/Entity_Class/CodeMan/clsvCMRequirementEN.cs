
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMRequirementEN
 表名:vCMRequirement(00050260)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:38
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
 /// 表vCMRequirement的关键字(ReqId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReqId_vCMRequirement
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
public K_ReqId_vCMRequirement(string strReqId)
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
 /// <returns>返回:[K_ReqId_vCMRequirement]类型的对象</returns>
public static implicit operator K_ReqId_vCMRequirement(string value)
{
return new K_ReqId_vCMRequirement(value);
}
}
 /// <summary>
 /// vCM需求(vCMRequirement)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMRequirementEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReqId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 19;
public static string[] _AttributeName = new string[] {"ReqId", "RequirementName", "FuncModuleAgcId", "FuncModuleName", "ReqContent", "UpReqId", "RequirementTypeId", "RequirementTypeName", "IsFinished", "CmPrjId", "CmPrjName", "PrjId", "PrjName", "ApplicationTypeId", "ApplicationTypeSimName", "ProjectFileName", "UpdUser", "UpdDate", "Memo"};

protected string mstrReqId;    //需求Id
protected string mstrRequirementName;    //需求名称
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrReqContent;    //需求内容
protected string mstrUpReqId;    //上级需求Id
protected string mstrRequirementTypeId;    //需求类型Id
protected string mstrRequirementTypeName;    //需求类型名
protected bool mbolIsFinished;    //是否完成
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeSimName;    //应用程序类型简称
protected string mstrProjectFileName;    //工程文件名
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMRequirementEN()
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
public clsvCMRequirementEN(string strReqId)
 {
strReqId = strReqId.Replace("'", "''");
if (strReqId.Length > 8)
{
throw new Exception("在表:vCMRequirement中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReqId)  ==  true)
{
throw new Exception("在表:vCMRequirement中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convCMRequirement.ReqId)
{
return mstrReqId;
}
else if (strAttributeName  ==  convCMRequirement.RequirementName)
{
return mstrRequirementName;
}
else if (strAttributeName  ==  convCMRequirement.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convCMRequirement.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCMRequirement.ReqContent)
{
return mstrReqContent;
}
else if (strAttributeName  ==  convCMRequirement.UpReqId)
{
return mstrUpReqId;
}
else if (strAttributeName  ==  convCMRequirement.RequirementTypeId)
{
return mstrRequirementTypeId;
}
else if (strAttributeName  ==  convCMRequirement.RequirementTypeName)
{
return mstrRequirementTypeName;
}
else if (strAttributeName  ==  convCMRequirement.IsFinished)
{
return mbolIsFinished;
}
else if (strAttributeName  ==  convCMRequirement.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCMRequirement.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convCMRequirement.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMRequirement.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convCMRequirement.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convCMRequirement.ApplicationTypeSimName)
{
return mstrApplicationTypeSimName;
}
else if (strAttributeName  ==  convCMRequirement.ProjectFileName)
{
return mstrProjectFileName;
}
else if (strAttributeName  ==  convCMRequirement.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMRequirement.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMRequirement.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCMRequirement.ReqId)
{
mstrReqId = value.ToString();
 AddUpdatedFld(convCMRequirement.ReqId);
}
else if (strAttributeName  ==  convCMRequirement.RequirementName)
{
mstrRequirementName = value.ToString();
 AddUpdatedFld(convCMRequirement.RequirementName);
}
else if (strAttributeName  ==  convCMRequirement.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMRequirement.FuncModuleAgcId);
}
else if (strAttributeName  ==  convCMRequirement.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMRequirement.FuncModuleName);
}
else if (strAttributeName  ==  convCMRequirement.ReqContent)
{
mstrReqContent = value.ToString();
 AddUpdatedFld(convCMRequirement.ReqContent);
}
else if (strAttributeName  ==  convCMRequirement.UpReqId)
{
mstrUpReqId = value.ToString();
 AddUpdatedFld(convCMRequirement.UpReqId);
}
else if (strAttributeName  ==  convCMRequirement.RequirementTypeId)
{
mstrRequirementTypeId = value.ToString();
 AddUpdatedFld(convCMRequirement.RequirementTypeId);
}
else if (strAttributeName  ==  convCMRequirement.RequirementTypeName)
{
mstrRequirementTypeName = value.ToString();
 AddUpdatedFld(convCMRequirement.RequirementTypeName);
}
else if (strAttributeName  ==  convCMRequirement.IsFinished)
{
mbolIsFinished = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMRequirement.IsFinished);
}
else if (strAttributeName  ==  convCMRequirement.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMRequirement.CmPrjId);
}
else if (strAttributeName  ==  convCMRequirement.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMRequirement.CmPrjName);
}
else if (strAttributeName  ==  convCMRequirement.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMRequirement.PrjId);
}
else if (strAttributeName  ==  convCMRequirement.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMRequirement.PrjName);
}
else if (strAttributeName  ==  convCMRequirement.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMRequirement.ApplicationTypeId);
}
else if (strAttributeName  ==  convCMRequirement.ApplicationTypeSimName)
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMRequirement.ApplicationTypeSimName);
}
else if (strAttributeName  ==  convCMRequirement.ProjectFileName)
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(convCMRequirement.ProjectFileName);
}
else if (strAttributeName  ==  convCMRequirement.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMRequirement.UpdUser);
}
else if (strAttributeName  ==  convCMRequirement.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMRequirement.UpdDate);
}
else if (strAttributeName  ==  convCMRequirement.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMRequirement.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMRequirement.ReqId  ==  _AttributeName[intIndex])
{
return mstrReqId;
}
else if (convCMRequirement.RequirementName  ==  _AttributeName[intIndex])
{
return mstrRequirementName;
}
else if (convCMRequirement.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convCMRequirement.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCMRequirement.ReqContent  ==  _AttributeName[intIndex])
{
return mstrReqContent;
}
else if (convCMRequirement.UpReqId  ==  _AttributeName[intIndex])
{
return mstrUpReqId;
}
else if (convCMRequirement.RequirementTypeId  ==  _AttributeName[intIndex])
{
return mstrRequirementTypeId;
}
else if (convCMRequirement.RequirementTypeName  ==  _AttributeName[intIndex])
{
return mstrRequirementTypeName;
}
else if (convCMRequirement.IsFinished  ==  _AttributeName[intIndex])
{
return mbolIsFinished;
}
else if (convCMRequirement.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCMRequirement.CmPrjName  ==  _AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convCMRequirement.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMRequirement.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convCMRequirement.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convCMRequirement.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
return mstrApplicationTypeSimName;
}
else if (convCMRequirement.ProjectFileName  ==  _AttributeName[intIndex])
{
return mstrProjectFileName;
}
else if (convCMRequirement.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMRequirement.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMRequirement.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCMRequirement.ReqId  ==  _AttributeName[intIndex])
{
mstrReqId = value.ToString();
 AddUpdatedFld(convCMRequirement.ReqId);
}
else if (convCMRequirement.RequirementName  ==  _AttributeName[intIndex])
{
mstrRequirementName = value.ToString();
 AddUpdatedFld(convCMRequirement.RequirementName);
}
else if (convCMRequirement.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMRequirement.FuncModuleAgcId);
}
else if (convCMRequirement.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMRequirement.FuncModuleName);
}
else if (convCMRequirement.ReqContent  ==  _AttributeName[intIndex])
{
mstrReqContent = value.ToString();
 AddUpdatedFld(convCMRequirement.ReqContent);
}
else if (convCMRequirement.UpReqId  ==  _AttributeName[intIndex])
{
mstrUpReqId = value.ToString();
 AddUpdatedFld(convCMRequirement.UpReqId);
}
else if (convCMRequirement.RequirementTypeId  ==  _AttributeName[intIndex])
{
mstrRequirementTypeId = value.ToString();
 AddUpdatedFld(convCMRequirement.RequirementTypeId);
}
else if (convCMRequirement.RequirementTypeName  ==  _AttributeName[intIndex])
{
mstrRequirementTypeName = value.ToString();
 AddUpdatedFld(convCMRequirement.RequirementTypeName);
}
else if (convCMRequirement.IsFinished  ==  _AttributeName[intIndex])
{
mbolIsFinished = TransNullToBool(value.ToString());
 AddUpdatedFld(convCMRequirement.IsFinished);
}
else if (convCMRequirement.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMRequirement.CmPrjId);
}
else if (convCMRequirement.CmPrjName  ==  _AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMRequirement.CmPrjName);
}
else if (convCMRequirement.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMRequirement.PrjId);
}
else if (convCMRequirement.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convCMRequirement.PrjName);
}
else if (convCMRequirement.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMRequirement.ApplicationTypeId);
}
else if (convCMRequirement.ApplicationTypeSimName  ==  _AttributeName[intIndex])
{
mstrApplicationTypeSimName = value.ToString();
 AddUpdatedFld(convCMRequirement.ApplicationTypeSimName);
}
else if (convCMRequirement.ProjectFileName  ==  _AttributeName[intIndex])
{
mstrProjectFileName = value.ToString();
 AddUpdatedFld(convCMRequirement.ProjectFileName);
}
else if (convCMRequirement.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMRequirement.UpdUser);
}
else if (convCMRequirement.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMRequirement.UpdDate);
}
else if (convCMRequirement.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMRequirement.Memo);
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
 AddUpdatedFld(convCMRequirement.ReqId);
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
 AddUpdatedFld(convCMRequirement.RequirementName);
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
 AddUpdatedFld(convCMRequirement.FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMRequirement.FuncModuleName);
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
 AddUpdatedFld(convCMRequirement.ReqContent);
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
 AddUpdatedFld(convCMRequirement.UpReqId);
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
 AddUpdatedFld(convCMRequirement.RequirementTypeId);
}
}
/// <summary>
/// 需求类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequirementTypeName
{
get
{
return mstrRequirementTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequirementTypeName = value;
}
else
{
 mstrRequirementTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMRequirement.RequirementTypeName);
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
 AddUpdatedFld(convCMRequirement.IsFinished);
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
 AddUpdatedFld(convCMRequirement.CmPrjId);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMRequirement.CmPrjName);
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
 AddUpdatedFld(convCMRequirement.PrjId);
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
 AddUpdatedFld(convCMRequirement.PrjName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convCMRequirement.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeSimName
{
get
{
return mstrApplicationTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeSimName = value;
}
else
{
 mstrApplicationTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMRequirement.ApplicationTypeSimName);
}
}
/// <summary>
/// 工程文件名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProjectFileName
{
get
{
return mstrProjectFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProjectFileName = value;
}
else
{
 mstrProjectFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMRequirement.ProjectFileName);
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
 AddUpdatedFld(convCMRequirement.UpdUser);
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
 AddUpdatedFld(convCMRequirement.UpdDate);
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
 AddUpdatedFld(convCMRequirement.Memo);
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
 /// vCM需求(vCMRequirement)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMRequirement
{
public const string _CurrTabName = "vCMRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReqId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"ReqId", "RequirementName", "FuncModuleAgcId", "FuncModuleName", "ReqContent", "UpReqId", "RequirementTypeId", "RequirementTypeName", "IsFinished", "CmPrjId", "CmPrjName", "PrjId", "PrjName", "ApplicationTypeId", "ApplicationTypeSimName", "ProjectFileName", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

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
 /// 常量:"RequirementTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementTypeId = "RequirementTypeId";    //需求类型Id

 /// <summary>
 /// 常量:"RequirementTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementTypeName = "RequirementTypeName";    //需求类型名

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
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeSimName = "ApplicationTypeSimName";    //应用程序类型简称

 /// <summary>
 /// 常量:"ProjectFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProjectFileName = "ProjectFileName";    //工程文件名

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
}

}