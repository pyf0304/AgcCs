
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFeatureRequirementEN
 表名:vCMFeatureRequirement(00050521)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// 表vCMFeatureRequirement的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCMFeatureRequirement
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
public K_mId_vCMFeatureRequirement(long lngmId)
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
 /// <returns>返回:[K_mId_vCMFeatureRequirement]类型的对象</returns>
public static implicit operator K_mId_vCMFeatureRequirement(long value)
{
return new K_mId_vCMFeatureRequirement(value);
}
}
 /// <summary>
 /// vCM功能需求关系(vCMFeatureRequirement)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMFeatureRequirementEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMFeatureRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 15;
public static string[] _AttributeName = new string[] {"mId", "CmFeatureId", "FeatureName", "CmParentFeatureId", "ParentFeatureName", "FuncModuleAgcId", "CmPrjId", "ReqId", "PrjId", "RequirementName", "OrderNum", "ReqContent", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCmFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrCmParentFeatureId;    //父功能Id
protected string mstrParentFeatureName;    //父功能名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrReqId;    //需求Id
protected string mstrPrjId;    //工程Id
protected string mstrRequirementName;    //需求名称
protected int mintOrderNum;    //序号
protected string mstrReqContent;    //需求内容
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvCMFeatureRequirementEN()
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
public clsvCMFeatureRequirementEN(long lngmId)
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
if (strAttributeName  ==  convCMFeatureRequirement.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCMFeatureRequirement.CmFeatureId)
{
return mstrCmFeatureId;
}
else if (strAttributeName  ==  convCMFeatureRequirement.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convCMFeatureRequirement.CmParentFeatureId)
{
return mstrCmParentFeatureId;
}
else if (strAttributeName  ==  convCMFeatureRequirement.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  convCMFeatureRequirement.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convCMFeatureRequirement.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCMFeatureRequirement.ReqId)
{
return mstrReqId;
}
else if (strAttributeName  ==  convCMFeatureRequirement.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMFeatureRequirement.RequirementName)
{
return mstrRequirementName;
}
else if (strAttributeName  ==  convCMFeatureRequirement.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCMFeatureRequirement.ReqContent)
{
return mstrReqContent;
}
else if (strAttributeName  ==  convCMFeatureRequirement.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMFeatureRequirement.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMFeatureRequirement.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCMFeatureRequirement.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeatureRequirement.mId);
}
else if (strAttributeName  ==  convCMFeatureRequirement.CmFeatureId)
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.CmFeatureId);
}
else if (strAttributeName  ==  convCMFeatureRequirement.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.FeatureName);
}
else if (strAttributeName  ==  convCMFeatureRequirement.CmParentFeatureId)
{
mstrCmParentFeatureId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.CmParentFeatureId);
}
else if (strAttributeName  ==  convCMFeatureRequirement.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.ParentFeatureName);
}
else if (strAttributeName  ==  convCMFeatureRequirement.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.FuncModuleAgcId);
}
else if (strAttributeName  ==  convCMFeatureRequirement.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.CmPrjId);
}
else if (strAttributeName  ==  convCMFeatureRequirement.ReqId)
{
mstrReqId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.ReqId);
}
else if (strAttributeName  ==  convCMFeatureRequirement.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.PrjId);
}
else if (strAttributeName  ==  convCMFeatureRequirement.RequirementName)
{
mstrRequirementName = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.RequirementName);
}
else if (strAttributeName  ==  convCMFeatureRequirement.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeatureRequirement.OrderNum);
}
else if (strAttributeName  ==  convCMFeatureRequirement.ReqContent)
{
mstrReqContent = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.ReqContent);
}
else if (strAttributeName  ==  convCMFeatureRequirement.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.UpdDate);
}
else if (strAttributeName  ==  convCMFeatureRequirement.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.UpdUser);
}
else if (strAttributeName  ==  convCMFeatureRequirement.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMFeatureRequirement.mId  ==  _AttributeName[intIndex])
{
return mlngmId;
}
else if (convCMFeatureRequirement.CmFeatureId  ==  _AttributeName[intIndex])
{
return mstrCmFeatureId;
}
else if (convCMFeatureRequirement.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convCMFeatureRequirement.CmParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrCmParentFeatureId;
}
else if (convCMFeatureRequirement.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (convCMFeatureRequirement.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convCMFeatureRequirement.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCMFeatureRequirement.ReqId  ==  _AttributeName[intIndex])
{
return mstrReqId;
}
else if (convCMFeatureRequirement.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMFeatureRequirement.RequirementName  ==  _AttributeName[intIndex])
{
return mstrRequirementName;
}
else if (convCMFeatureRequirement.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCMFeatureRequirement.ReqContent  ==  _AttributeName[intIndex])
{
return mstrReqContent;
}
else if (convCMFeatureRequirement.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMFeatureRequirement.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMFeatureRequirement.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCMFeatureRequirement.mId  ==  _AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeatureRequirement.mId);
}
else if (convCMFeatureRequirement.CmFeatureId  ==  _AttributeName[intIndex])
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.CmFeatureId);
}
else if (convCMFeatureRequirement.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.FeatureName);
}
else if (convCMFeatureRequirement.CmParentFeatureId  ==  _AttributeName[intIndex])
{
mstrCmParentFeatureId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.CmParentFeatureId);
}
else if (convCMFeatureRequirement.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.ParentFeatureName);
}
else if (convCMFeatureRequirement.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.FuncModuleAgcId);
}
else if (convCMFeatureRequirement.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.CmPrjId);
}
else if (convCMFeatureRequirement.ReqId  ==  _AttributeName[intIndex])
{
mstrReqId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.ReqId);
}
else if (convCMFeatureRequirement.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.PrjId);
}
else if (convCMFeatureRequirement.RequirementName  ==  _AttributeName[intIndex])
{
mstrRequirementName = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.RequirementName);
}
else if (convCMFeatureRequirement.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMFeatureRequirement.OrderNum);
}
else if (convCMFeatureRequirement.ReqContent  ==  _AttributeName[intIndex])
{
mstrReqContent = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.ReqContent);
}
else if (convCMFeatureRequirement.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.UpdDate);
}
else if (convCMFeatureRequirement.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.UpdUser);
}
else if (convCMFeatureRequirement.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMFeatureRequirement.Memo);
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
 AddUpdatedFld(convCMFeatureRequirement.mId);
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
 AddUpdatedFld(convCMFeatureRequirement.CmFeatureId);
}
}
/// <summary>
/// 功能名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName
{
get
{
return mstrFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName = value;
}
else
{
 mstrFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeatureRequirement.FeatureName);
}
}
/// <summary>
/// 父功能Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmParentFeatureId
{
get
{
return mstrCmParentFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmParentFeatureId = value;
}
else
{
 mstrCmParentFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeatureRequirement.CmParentFeatureId);
}
}
/// <summary>
/// 父功能名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentFeatureName
{
get
{
return mstrParentFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentFeatureName = value;
}
else
{
 mstrParentFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMFeatureRequirement.ParentFeatureName);
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
 AddUpdatedFld(convCMFeatureRequirement.FuncModuleAgcId);
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
 AddUpdatedFld(convCMFeatureRequirement.CmPrjId);
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
 AddUpdatedFld(convCMFeatureRequirement.ReqId);
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
 AddUpdatedFld(convCMFeatureRequirement.PrjId);
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
 AddUpdatedFld(convCMFeatureRequirement.RequirementName);
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
 AddUpdatedFld(convCMFeatureRequirement.OrderNum);
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
 AddUpdatedFld(convCMFeatureRequirement.ReqContent);
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
 AddUpdatedFld(convCMFeatureRequirement.UpdDate);
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
 AddUpdatedFld(convCMFeatureRequirement.UpdUser);
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
 AddUpdatedFld(convCMFeatureRequirement.Memo);
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
 /// vCM功能需求关系(vCMFeatureRequirement)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMFeatureRequirement
{
public const string _CurrTabName = "vCMFeatureRequirement"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"mId", "CmFeatureId", "FeatureName", "CmParentFeatureId", "ParentFeatureName", "FuncModuleAgcId", "CmPrjId", "ReqId", "PrjId", "RequirementName", "OrderNum", "ReqContent", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"FeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName = "FeatureName";    //功能名称

 /// <summary>
 /// 常量:"CmParentFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmParentFeatureId = "CmParentFeatureId";    //父功能Id

 /// <summary>
 /// 常量:"ParentFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureName = "ParentFeatureName";    //父功能名

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"ReqId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReqId = "ReqId";    //需求Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"RequirementName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequirementName = "RequirementName";    //需求名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ReqContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReqContent = "ReqContent";    //需求内容

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