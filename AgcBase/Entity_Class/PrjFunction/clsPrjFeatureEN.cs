
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFeatureEN
 表名:PrjFeature(00050322)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 表PrjFeature的关键字(FeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FeatureId_PrjFeature
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFeatureId">表关键字</param>
public K_FeatureId_PrjFeature(string strFeatureId)
{
if (IsValid(strFeatureId)) Value = strFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return false;
if (strFeatureId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FeatureId_PrjFeature]类型的对象</returns>
public static implicit operator K_FeatureId_PrjFeature(string value)
{
return new K_FeatureId_PrjFeature(value);
}
}
 /// <summary>
 /// 功能(PrjFeature)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjFeatureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 22;
public static string[] _AttributeName = new string[] {"FeatureId", "FeatureName", "FeatureENName", "KeyWords", "DefaButtonName", "DefaButtonName4Mvc", "RegionTypeId", "GroupName", "FeatureDescription", "InOutTypeId", "IsNeedField", "IsNeedTabFeature", "ParentFeatureId", "ParentFeatureName", "FunctionGroupId", "FeatureTypeId", "CreateUserId", "InUse", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrFeatureENName;    //功能英文名
protected string mstrKeyWords;    //关键字
protected string mstrDefaButtonName;    //默认按钮名
protected string mstrDefaButtonName4Mvc;    //默认按钮名4Mvc
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrGroupName;    //组名
protected string mstrFeatureDescription;    //功能说明
protected string mstrInOutTypeId;    //INOUT类型ID
protected bool mbolIsNeedField;    //是否需要字段
protected bool mbolIsNeedTabFeature;    //是否需要表功能
protected string mstrParentFeatureId;    //父功能Id
protected string mstrParentFeatureName;    //父功能名
protected string mstrFunctionGroupId;    //函数组Id
protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrCreateUserId;    //建立用户Id
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjFeatureEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strFeatureId">关键字:功能Id</param>
public clsPrjFeatureEN(string strFeatureId)
 {
strFeatureId = strFeatureId.Replace("'", "''");
if (strFeatureId.Length > 4)
{
throw new Exception("在表:PrjFeature中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFeatureId)  ==  true)
{
throw new Exception("在表:PrjFeature中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFeatureId = strFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeatureId");
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
if (strAttributeName  ==  conPrjFeature.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  conPrjFeature.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  conPrjFeature.FeatureENName)
{
return mstrFeatureENName;
}
else if (strAttributeName  ==  conPrjFeature.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  conPrjFeature.DefaButtonName)
{
return mstrDefaButtonName;
}
else if (strAttributeName  ==  conPrjFeature.DefaButtonName4Mvc)
{
return mstrDefaButtonName4Mvc;
}
else if (strAttributeName  ==  conPrjFeature.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  conPrjFeature.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  conPrjFeature.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  conPrjFeature.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  conPrjFeature.IsNeedField)
{
return mbolIsNeedField;
}
else if (strAttributeName  ==  conPrjFeature.IsNeedTabFeature)
{
return mbolIsNeedTabFeature;
}
else if (strAttributeName  ==  conPrjFeature.ParentFeatureId)
{
return mstrParentFeatureId;
}
else if (strAttributeName  ==  conPrjFeature.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  conPrjFeature.FunctionGroupId)
{
return mstrFunctionGroupId;
}
else if (strAttributeName  ==  conPrjFeature.FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  conPrjFeature.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  conPrjFeature.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conPrjFeature.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conPrjFeature.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjFeature.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPrjFeature.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjFeature.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureId);
}
else if (strAttributeName  ==  conPrjFeature.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureName);
}
else if (strAttributeName  ==  conPrjFeature.FeatureENName)
{
mstrFeatureENName = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureENName);
}
else if (strAttributeName  ==  conPrjFeature.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(conPrjFeature.KeyWords);
}
else if (strAttributeName  ==  conPrjFeature.DefaButtonName)
{
mstrDefaButtonName = value.ToString();
 AddUpdatedFld(conPrjFeature.DefaButtonName);
}
else if (strAttributeName  ==  conPrjFeature.DefaButtonName4Mvc)
{
mstrDefaButtonName4Mvc = value.ToString();
 AddUpdatedFld(conPrjFeature.DefaButtonName4Mvc);
}
else if (strAttributeName  ==  conPrjFeature.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conPrjFeature.RegionTypeId);
}
else if (strAttributeName  ==  conPrjFeature.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conPrjFeature.GroupName);
}
else if (strAttributeName  ==  conPrjFeature.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureDescription);
}
else if (strAttributeName  ==  conPrjFeature.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conPrjFeature.InOutTypeId);
}
else if (strAttributeName  ==  conPrjFeature.IsNeedField)
{
mbolIsNeedField = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFeature.IsNeedField);
}
else if (strAttributeName  ==  conPrjFeature.IsNeedTabFeature)
{
mbolIsNeedTabFeature = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFeature.IsNeedTabFeature);
}
else if (strAttributeName  ==  conPrjFeature.ParentFeatureId)
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(conPrjFeature.ParentFeatureId);
}
else if (strAttributeName  ==  conPrjFeature.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(conPrjFeature.ParentFeatureName);
}
else if (strAttributeName  ==  conPrjFeature.FunctionGroupId)
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(conPrjFeature.FunctionGroupId);
}
else if (strAttributeName  ==  conPrjFeature.FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureTypeId);
}
else if (strAttributeName  ==  conPrjFeature.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conPrjFeature.CreateUserId);
}
else if (strAttributeName  ==  conPrjFeature.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFeature.InUse);
}
else if (strAttributeName  ==  conPrjFeature.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFeature.OrderNum);
}
else if (strAttributeName  ==  conPrjFeature.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFeature.UpdDate);
}
else if (strAttributeName  ==  conPrjFeature.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjFeature.UpdUser);
}
else if (strAttributeName  ==  conPrjFeature.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFeature.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjFeature.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (conPrjFeature.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (conPrjFeature.FeatureENName  ==  _AttributeName[intIndex])
{
return mstrFeatureENName;
}
else if (conPrjFeature.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (conPrjFeature.DefaButtonName  ==  _AttributeName[intIndex])
{
return mstrDefaButtonName;
}
else if (conPrjFeature.DefaButtonName4Mvc  ==  _AttributeName[intIndex])
{
return mstrDefaButtonName4Mvc;
}
else if (conPrjFeature.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (conPrjFeature.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (conPrjFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (conPrjFeature.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (conPrjFeature.IsNeedField  ==  _AttributeName[intIndex])
{
return mbolIsNeedField;
}
else if (conPrjFeature.IsNeedTabFeature  ==  _AttributeName[intIndex])
{
return mbolIsNeedTabFeature;
}
else if (conPrjFeature.ParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrParentFeatureId;
}
else if (conPrjFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (conPrjFeature.FunctionGroupId  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupId;
}
else if (conPrjFeature.FeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (conPrjFeature.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (conPrjFeature.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (conPrjFeature.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conPrjFeature.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjFeature.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPrjFeature.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPrjFeature.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureId);
}
else if (conPrjFeature.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureName);
}
else if (conPrjFeature.FeatureENName  ==  _AttributeName[intIndex])
{
mstrFeatureENName = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureENName);
}
else if (conPrjFeature.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(conPrjFeature.KeyWords);
}
else if (conPrjFeature.DefaButtonName  ==  _AttributeName[intIndex])
{
mstrDefaButtonName = value.ToString();
 AddUpdatedFld(conPrjFeature.DefaButtonName);
}
else if (conPrjFeature.DefaButtonName4Mvc  ==  _AttributeName[intIndex])
{
mstrDefaButtonName4Mvc = value.ToString();
 AddUpdatedFld(conPrjFeature.DefaButtonName4Mvc);
}
else if (conPrjFeature.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(conPrjFeature.RegionTypeId);
}
else if (conPrjFeature.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conPrjFeature.GroupName);
}
else if (conPrjFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureDescription);
}
else if (conPrjFeature.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(conPrjFeature.InOutTypeId);
}
else if (conPrjFeature.IsNeedField  ==  _AttributeName[intIndex])
{
mbolIsNeedField = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFeature.IsNeedField);
}
else if (conPrjFeature.IsNeedTabFeature  ==  _AttributeName[intIndex])
{
mbolIsNeedTabFeature = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFeature.IsNeedTabFeature);
}
else if (conPrjFeature.ParentFeatureId  ==  _AttributeName[intIndex])
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(conPrjFeature.ParentFeatureId);
}
else if (conPrjFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(conPrjFeature.ParentFeatureName);
}
else if (conPrjFeature.FunctionGroupId  ==  _AttributeName[intIndex])
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(conPrjFeature.FunctionGroupId);
}
else if (conPrjFeature.FeatureTypeId  ==  _AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(conPrjFeature.FeatureTypeId);
}
else if (conPrjFeature.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(conPrjFeature.CreateUserId);
}
else if (conPrjFeature.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjFeature.InUse);
}
else if (conPrjFeature.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjFeature.OrderNum);
}
else if (conPrjFeature.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjFeature.UpdDate);
}
else if (conPrjFeature.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPrjFeature.UpdUser);
}
else if (conPrjFeature.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjFeature.Memo);
}
}
}

/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.FeatureId);
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
 AddUpdatedFld(conPrjFeature.FeatureName);
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
 AddUpdatedFld(conPrjFeature.FeatureENName);
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
 AddUpdatedFld(conPrjFeature.KeyWords);
}
}
/// <summary>
/// 默认按钮名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaButtonName
{
get
{
return mstrDefaButtonName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaButtonName = value;
}
else
{
 mstrDefaButtonName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.DefaButtonName);
}
}
/// <summary>
/// 默认按钮名4Mvc(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaButtonName4Mvc
{
get
{
return mstrDefaButtonName4Mvc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaButtonName4Mvc = value;
}
else
{
 mstrDefaButtonName4Mvc = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.DefaButtonName4Mvc);
}
}
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeId
{
get
{
return mstrRegionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeId = value;
}
else
{
 mstrRegionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.RegionTypeId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.GroupName);
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
 AddUpdatedFld(conPrjFeature.FeatureDescription);
}
}
/// <summary>
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeId
{
get
{
return mstrInOutTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeId = value;
}
else
{
 mstrInOutTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.InOutTypeId);
}
}
/// <summary>
/// 是否需要字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedField
{
get
{
return mbolIsNeedField;
}
set
{
 mbolIsNeedField = value;
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.IsNeedField);
}
}
/// <summary>
/// 是否需要表功能(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedTabFeature
{
get
{
return mbolIsNeedTabFeature;
}
set
{
 mbolIsNeedTabFeature = value;
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.IsNeedTabFeature);
}
}
/// <summary>
/// 父功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentFeatureId
{
get
{
return mstrParentFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentFeatureId = value;
}
else
{
 mstrParentFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.ParentFeatureId);
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
 AddUpdatedFld(conPrjFeature.ParentFeatureName);
}
}
/// <summary>
/// 函数组Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionGroupId
{
get
{
return mstrFunctionGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionGroupId = value;
}
else
{
 mstrFunctionGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.FunctionGroupId);
}
}
/// <summary>
/// 功能类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeId
{
get
{
return mstrFeatureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeId = value;
}
else
{
 mstrFeatureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjFeature.FeatureTypeId);
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
 AddUpdatedFld(conPrjFeature.CreateUserId);
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
 AddUpdatedFld(conPrjFeature.InUse);
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
 AddUpdatedFld(conPrjFeature.OrderNum);
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
 AddUpdatedFld(conPrjFeature.UpdDate);
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
 AddUpdatedFld(conPrjFeature.UpdUser);
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
 AddUpdatedFld(conPrjFeature.Memo);
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
  return mstrFeatureId;
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
 /// 功能(PrjFeature)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjFeature
{
public const string _CurrTabName = "PrjFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FeatureId", "FeatureName", "FeatureENName", "KeyWords", "DefaButtonName", "DefaButtonName4Mvc", "RegionTypeId", "GroupName", "FeatureDescription", "InOutTypeId", "IsNeedField", "IsNeedTabFeature", "ParentFeatureId", "ParentFeatureName", "FunctionGroupId", "FeatureTypeId", "CreateUserId", "InUse", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

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
 /// 常量:"DefaButtonName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaButtonName = "DefaButtonName";    //默认按钮名

 /// <summary>
 /// 常量:"DefaButtonName4Mvc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaButtonName4Mvc = "DefaButtonName4Mvc";    //默认按钮名4Mvc

 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"FeatureDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureDescription = "FeatureDescription";    //功能说明

 /// <summary>
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //INOUT类型ID

 /// <summary>
 /// 常量:"IsNeedField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedField = "IsNeedField";    //是否需要字段

 /// <summary>
 /// 常量:"IsNeedTabFeature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTabFeature = "IsNeedTabFeature";    //是否需要表功能

 /// <summary>
 /// 常量:"ParentFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureId = "ParentFeatureId";    //父功能Id

 /// <summary>
 /// 常量:"ParentFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentFeatureName = "ParentFeatureName";    //父功能名

 /// <summary>
 /// 常量:"FunctionGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupId = "FunctionGroupId";    //函数组Id

 /// <summary>
 /// 常量:"FeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeId = "FeatureTypeId";    //功能类型Id

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