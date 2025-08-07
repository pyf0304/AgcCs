
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureEN
 表名:CMFeature(00050517)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:52
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
 /// 表CMFeature的关键字(CmFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmFeatureId_CMFeature
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmFeatureId">表关键字</param>
public K_CmFeatureId_CMFeature(string strCmFeatureId)
{
if (IsValid(strCmFeatureId)) Value = strCmFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmFeatureId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return false;
if (strCmFeatureId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmFeatureId_CMFeature]类型的对象</returns>
public static implicit operator K_CmFeatureId_CMFeature(string value)
{
return new K_CmFeatureId_CMFeature(value);
}
}
 /// <summary>
 /// CM功能(CMFeature)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCMFeatureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CMFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 17;
public static string[] _AttributeName = new string[] {"CmFeatureId", "FeatureName", "FeatureENName", "KeyWords", "FeatureDescription", "CmParentFeatureId", "ParentFeatureName", "CmFeatureTypeId", "CreateUserId", "InUse", "OrderNum", "FuncModuleAgcId", "CmPrjId", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrCmFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureENName;    //功能英文名
protected string mstrKeyWords;    //关键字
protected string mstrFeatureDescription;    //功能说明
protected string mstrCmParentFeatureId;    //父功能Id
protected string mstrParentFeatureName;    //父功能名
protected string mstrCmFeatureTypeId;    //功能类型Id
protected string mstrCreateUserId;    //建立用户Id
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrPrjId;    //工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsCMFeatureEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strCmFeatureId">关键字:功能Id</param>
public clsCMFeatureEN(string strCmFeatureId)
 {
strCmFeatureId = strCmFeatureId.Replace("'", "''");
if (strCmFeatureId.Length > 8)
{
throw new Exception("在表:CMFeature中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmFeatureId)  ==  true)
{
throw new Exception("在表:CMFeature中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmFeatureId = strCmFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmFeatureId");
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
if (strAttributeName  ==  conCMFeature.CmFeatureId)
{
return mstrCmFeatureId;
}
else if (strAttributeName  ==  conCMFeature.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  conCMFeature.FeatureENName)
{
return mstrFeatureENName;
}
else if (strAttributeName  ==  conCMFeature.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  conCMFeature.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  conCMFeature.CmParentFeatureId)
{
return mstrCmParentFeatureId;
}
else if (strAttributeName  ==  conCMFeature.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  conCMFeature.CmFeatureTypeId)
{
return mstrCmFeatureTypeId;
}
else if (strAttributeName  ==  conCMFeature.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  conCMFeature.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conCMFeature.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCMFeature.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conCMFeature.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conCMFeature.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conCMFeature.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCMFeature.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCMFeature.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCMFeature.CmFeatureId)
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(conCMFeature.CmFeatureId);
}
else if (strAttributeName  ==  conCMFeature.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(conCMFeature.FeatureName);
}
else if (strAttributeName  ==  conCMFeature.FeatureENName)
{
mstrFeatureENName = value.ToString();
 AddUpdatedFld(conCMFeature.FeatureENName);
}
else if (strAttributeName  ==  conCMFeature.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(conCMFeature.KeyWords);
}
else if (strAttributeName  ==  conCMFeature.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(conCMFeature.FeatureDescription);
}
else if (strAttributeName  ==  conCMFeature.CmParentFeatureId)
{
mstrCmParentFeatureId = value.ToString();
 AddUpdatedFld(conCMFeature.CmParentFeatureId);
}
else if (strAttributeName  ==  conCMFeature.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(conCMFeature.ParentFeatureName);
}
else if (strAttributeName  ==  conCMFeature.CmFeatureTypeId)
{
mstrCmFeatureTypeId = value.ToString();
 AddUpdatedFld(conCMFeature.CmFeatureTypeId);
}
else if (strAttributeName  ==  conCMFeature.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conCMFeature.CreateUserId);
}
else if (strAttributeName  ==  conCMFeature.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFeature.InUse);
}
else if (strAttributeName  ==  conCMFeature.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFeature.OrderNum);
}
else if (strAttributeName  ==  conCMFeature.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conCMFeature.FuncModuleAgcId);
}
else if (strAttributeName  ==  conCMFeature.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMFeature.CmPrjId);
}
else if (strAttributeName  ==  conCMFeature.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMFeature.PrjId);
}
else if (strAttributeName  ==  conCMFeature.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFeature.UpdDate);
}
else if (strAttributeName  ==  conCMFeature.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFeature.UpdUser);
}
else if (strAttributeName  ==  conCMFeature.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFeature.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCMFeature.CmFeatureId  ==  _AttributeName[intIndex])
{
return mstrCmFeatureId;
}
else if (conCMFeature.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (conCMFeature.FeatureENName  ==  _AttributeName[intIndex])
{
return mstrFeatureENName;
}
else if (conCMFeature.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (conCMFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (conCMFeature.CmParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrCmParentFeatureId;
}
else if (conCMFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (conCMFeature.CmFeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrCmFeatureTypeId;
}
else if (conCMFeature.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (conCMFeature.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conCMFeature.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCMFeature.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conCMFeature.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conCMFeature.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conCMFeature.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCMFeature.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCMFeature.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCMFeature.CmFeatureId  ==  _AttributeName[intIndex])
{
mstrCmFeatureId = value.ToString();
 AddUpdatedFld(conCMFeature.CmFeatureId);
}
else if (conCMFeature.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(conCMFeature.FeatureName);
}
else if (conCMFeature.FeatureENName  ==  _AttributeName[intIndex])
{
mstrFeatureENName = value.ToString();
 AddUpdatedFld(conCMFeature.FeatureENName);
}
else if (conCMFeature.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(conCMFeature.KeyWords);
}
else if (conCMFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(conCMFeature.FeatureDescription);
}
else if (conCMFeature.CmParentFeatureId  ==  _AttributeName[intIndex])
{
mstrCmParentFeatureId = value.ToString();
 AddUpdatedFld(conCMFeature.CmParentFeatureId);
}
else if (conCMFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(conCMFeature.ParentFeatureName);
}
else if (conCMFeature.CmFeatureTypeId  ==  _AttributeName[intIndex])
{
mstrCmFeatureTypeId = value.ToString();
 AddUpdatedFld(conCMFeature.CmFeatureTypeId);
}
else if (conCMFeature.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conCMFeature.CreateUserId);
}
else if (conCMFeature.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCMFeature.InUse);
}
else if (conCMFeature.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCMFeature.OrderNum);
}
else if (conCMFeature.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conCMFeature.FuncModuleAgcId);
}
else if (conCMFeature.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCMFeature.CmPrjId);
}
else if (conCMFeature.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conCMFeature.PrjId);
}
else if (conCMFeature.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCMFeature.UpdDate);
}
else if (conCMFeature.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCMFeature.UpdUser);
}
else if (conCMFeature.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCMFeature.Memo);
}
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
 AddUpdatedFld(conCMFeature.CmFeatureId);
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
 AddUpdatedFld(conCMFeature.FeatureName);
}
}
/// <summary>
/// 功能英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureENName
{
get
{
return mstrFeatureENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureENName = value;
}
else
{
 mstrFeatureENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeature.FeatureENName);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyWords
{
get
{
return mstrKeyWords;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyWords = value;
}
else
{
 mstrKeyWords = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeature.KeyWords);
}
}
/// <summary>
/// 功能说明(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureDescription
{
get
{
return mstrFeatureDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureDescription = value;
}
else
{
 mstrFeatureDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeature.FeatureDescription);
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
 AddUpdatedFld(conCMFeature.CmParentFeatureId);
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
 AddUpdatedFld(conCMFeature.ParentFeatureName);
}
}
/// <summary>
/// 功能类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmFeatureTypeId
{
get
{
return mstrCmFeatureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmFeatureTypeId = value;
}
else
{
 mstrCmFeatureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeature.CmFeatureTypeId);
}
}
/// <summary>
/// 建立用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserId
{
get
{
return mstrCreateUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserId = value;
}
else
{
 mstrCreateUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCMFeature.CreateUserId);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conCMFeature.InUse);
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
 AddUpdatedFld(conCMFeature.OrderNum);
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
 AddUpdatedFld(conCMFeature.FuncModuleAgcId);
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
 AddUpdatedFld(conCMFeature.CmPrjId);
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
 AddUpdatedFld(conCMFeature.PrjId);
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
 AddUpdatedFld(conCMFeature.UpdDate);
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
 AddUpdatedFld(conCMFeature.UpdUser);
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
 AddUpdatedFld(conCMFeature.Memo);
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
  return mstrCmFeatureId;
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
  return mstrFeatureName;
 }
 }
}
 /// <summary>
 /// CM功能(CMFeature)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCMFeature
{
public const string _CurrTabName = "CMFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"CmFeatureId", "FeatureName", "FeatureENName", "KeyWords", "FeatureDescription", "CmParentFeatureId", "ParentFeatureName", "CmFeatureTypeId", "CreateUserId", "InUse", "OrderNum", "FuncModuleAgcId", "CmPrjId", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"FeatureENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureENName = "FeatureENName";    //功能英文名

 /// <summary>
 /// 常量:"KeyWords"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWords = "KeyWords";    //关键字

 /// <summary>
 /// 常量:"FeatureDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureDescription = "FeatureDescription";    //功能说明

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
 /// 常量:"CmFeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmFeatureTypeId = "CmFeatureTypeId";    //功能类型Id

 /// <summary>
 /// 常量:"CreateUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserId = "CreateUserId";    //建立用户Id

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
}

}