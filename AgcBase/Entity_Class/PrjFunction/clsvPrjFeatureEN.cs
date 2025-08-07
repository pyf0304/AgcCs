
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFeatureEN
 表名:vPrjFeature(00050324)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 表vPrjFeature的关键字(FeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FeatureId_vPrjFeature
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
public K_FeatureId_vPrjFeature(string strFeatureId)
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
 /// <returns>返回:[K_FeatureId_vPrjFeature]类型的对象</returns>
public static implicit operator K_FeatureId_vPrjFeature(string value)
{
return new K_FeatureId_vPrjFeature(value);
}
}
 /// <summary>
 /// v功能(vPrjFeature)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjFeatureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 26;
public static string[] _AttributeName = new string[] {"FeatureId", "FeatureName", "KeyWords", "DefaButtonName", "RegionTypeId", "RegionTypeName", "GroupName", "FeatureDescription", "InOutTypeId", "InOutTypeName", "IsNeedField", "FunctionGroupId", "FunctionGroupName", "FeatureTypeId", "FeatureTypeName", "CreateUserId", "InUse", "OrderNum", "UpdDate", "UpdUser", "Memo", "FuncCount", "FeatureName2", "ParentFeatureId", "ParentFeatureName", "IsNeedTabFeature"};

protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrKeyWords;    //关键字
protected string mstrDefaButtonName;    //默认按钮名
protected string mstrRegionTypeId;    //区域类型Id
protected string mstrRegionTypeName;    //区域类型名称
protected string mstrGroupName;    //组名
protected string mstrFeatureDescription;    //功能说明
protected string mstrInOutTypeId;    //INOUT类型ID
protected string mstrInOutTypeName;    //INOUT类型名称
protected bool mbolIsNeedField;    //是否需要字段
protected string mstrFunctionGroupId;    //函数组Id
protected string mstrFunctionGroupName;    //函数组名称
protected string mstrFeatureTypeId;    //功能类型Id
protected string mstrFeatureTypeName;    //功能类型名称
protected string mstrCreateUserId;    //建立用户Id
protected bool mbolInUse;    //是否在用
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected int? mintFuncCount;    //函数数目
protected string mstrFeatureName2;    //功能名-FuncCount
protected string mstrParentFeatureId;    //父功能Id
protected string mstrParentFeatureName;    //父功能名
protected bool mbolIsNeedTabFeature;    //是否需要表功能

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjFeatureEN()
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
public clsvPrjFeatureEN(string strFeatureId)
 {
strFeatureId = strFeatureId.Replace("'", "''");
if (strFeatureId.Length > 4)
{
throw new Exception("在表:vPrjFeature中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFeatureId)  ==  true)
{
throw new Exception("在表:vPrjFeature中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convPrjFeature.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convPrjFeature.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convPrjFeature.KeyWords)
{
return mstrKeyWords;
}
else if (strAttributeName  ==  convPrjFeature.DefaButtonName)
{
return mstrDefaButtonName;
}
else if (strAttributeName  ==  convPrjFeature.RegionTypeId)
{
return mstrRegionTypeId;
}
else if (strAttributeName  ==  convPrjFeature.RegionTypeName)
{
return mstrRegionTypeName;
}
else if (strAttributeName  ==  convPrjFeature.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convPrjFeature.FeatureDescription)
{
return mstrFeatureDescription;
}
else if (strAttributeName  ==  convPrjFeature.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  convPrjFeature.InOutTypeName)
{
return mstrInOutTypeName;
}
else if (strAttributeName  ==  convPrjFeature.IsNeedField)
{
return mbolIsNeedField;
}
else if (strAttributeName  ==  convPrjFeature.FunctionGroupId)
{
return mstrFunctionGroupId;
}
else if (strAttributeName  ==  convPrjFeature.FunctionGroupName)
{
return mstrFunctionGroupName;
}
else if (strAttributeName  ==  convPrjFeature.FeatureTypeId)
{
return mstrFeatureTypeId;
}
else if (strAttributeName  ==  convPrjFeature.FeatureTypeName)
{
return mstrFeatureTypeName;
}
else if (strAttributeName  ==  convPrjFeature.CreateUserId)
{
return mstrCreateUserId;
}
else if (strAttributeName  ==  convPrjFeature.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convPrjFeature.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convPrjFeature.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjFeature.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPrjFeature.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPrjFeature.FuncCount)
{
return mintFuncCount;
}
else if (strAttributeName  ==  convPrjFeature.FeatureName2)
{
return mstrFeatureName2;
}
else if (strAttributeName  ==  convPrjFeature.ParentFeatureId)
{
return mstrParentFeatureId;
}
else if (strAttributeName  ==  convPrjFeature.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  convPrjFeature.IsNeedTabFeature)
{
return mbolIsNeedTabFeature;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjFeature.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureId);
}
else if (strAttributeName  ==  convPrjFeature.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureName);
}
else if (strAttributeName  ==  convPrjFeature.KeyWords)
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convPrjFeature.KeyWords);
}
else if (strAttributeName  ==  convPrjFeature.DefaButtonName)
{
mstrDefaButtonName = value.ToString();
 AddUpdatedFld(convPrjFeature.DefaButtonName);
}
else if (strAttributeName  ==  convPrjFeature.RegionTypeId)
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convPrjFeature.RegionTypeId);
}
else if (strAttributeName  ==  convPrjFeature.RegionTypeName)
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convPrjFeature.RegionTypeName);
}
else if (strAttributeName  ==  convPrjFeature.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convPrjFeature.GroupName);
}
else if (strAttributeName  ==  convPrjFeature.FeatureDescription)
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureDescription);
}
else if (strAttributeName  ==  convPrjFeature.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convPrjFeature.InOutTypeId);
}
else if (strAttributeName  ==  convPrjFeature.InOutTypeName)
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convPrjFeature.InOutTypeName);
}
else if (strAttributeName  ==  convPrjFeature.IsNeedField)
{
mbolIsNeedField = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeature.IsNeedField);
}
else if (strAttributeName  ==  convPrjFeature.FunctionGroupId)
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convPrjFeature.FunctionGroupId);
}
else if (strAttributeName  ==  convPrjFeature.FunctionGroupName)
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convPrjFeature.FunctionGroupName);
}
else if (strAttributeName  ==  convPrjFeature.FeatureTypeId)
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureTypeId);
}
else if (strAttributeName  ==  convPrjFeature.FeatureTypeName)
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureTypeName);
}
else if (strAttributeName  ==  convPrjFeature.CreateUserId)
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convPrjFeature.CreateUserId);
}
else if (strAttributeName  ==  convPrjFeature.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeature.InUse);
}
else if (strAttributeName  ==  convPrjFeature.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjFeature.OrderNum);
}
else if (strAttributeName  ==  convPrjFeature.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjFeature.UpdDate);
}
else if (strAttributeName  ==  convPrjFeature.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjFeature.UpdUser);
}
else if (strAttributeName  ==  convPrjFeature.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjFeature.Memo);
}
else if (strAttributeName  ==  convPrjFeature.FuncCount)
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjFeature.FuncCount);
}
else if (strAttributeName  ==  convPrjFeature.FeatureName2)
{
mstrFeatureName2 = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureName2);
}
else if (strAttributeName  ==  convPrjFeature.ParentFeatureId)
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeature.ParentFeatureId);
}
else if (strAttributeName  ==  convPrjFeature.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeature.ParentFeatureName);
}
else if (strAttributeName  ==  convPrjFeature.IsNeedTabFeature)
{
mbolIsNeedTabFeature = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeature.IsNeedTabFeature);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjFeature.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convPrjFeature.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convPrjFeature.KeyWords  ==  _AttributeName[intIndex])
{
return mstrKeyWords;
}
else if (convPrjFeature.DefaButtonName  ==  _AttributeName[intIndex])
{
return mstrDefaButtonName;
}
else if (convPrjFeature.RegionTypeId  ==  _AttributeName[intIndex])
{
return mstrRegionTypeId;
}
else if (convPrjFeature.RegionTypeName  ==  _AttributeName[intIndex])
{
return mstrRegionTypeName;
}
else if (convPrjFeature.GroupName  ==  _AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convPrjFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
return mstrFeatureDescription;
}
else if (convPrjFeature.InOutTypeId  ==  _AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (convPrjFeature.InOutTypeName  ==  _AttributeName[intIndex])
{
return mstrInOutTypeName;
}
else if (convPrjFeature.IsNeedField  ==  _AttributeName[intIndex])
{
return mbolIsNeedField;
}
else if (convPrjFeature.FunctionGroupId  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupId;
}
else if (convPrjFeature.FunctionGroupName  ==  _AttributeName[intIndex])
{
return mstrFunctionGroupName;
}
else if (convPrjFeature.FeatureTypeId  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeId;
}
else if (convPrjFeature.FeatureTypeName  ==  _AttributeName[intIndex])
{
return mstrFeatureTypeName;
}
else if (convPrjFeature.CreateUserId  ==  _AttributeName[intIndex])
{
return mstrCreateUserId;
}
else if (convPrjFeature.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convPrjFeature.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convPrjFeature.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjFeature.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPrjFeature.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPrjFeature.FuncCount  ==  _AttributeName[intIndex])
{
return mintFuncCount;
}
else if (convPrjFeature.FeatureName2  ==  _AttributeName[intIndex])
{
return mstrFeatureName2;
}
else if (convPrjFeature.ParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrParentFeatureId;
}
else if (convPrjFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (convPrjFeature.IsNeedTabFeature  ==  _AttributeName[intIndex])
{
return mbolIsNeedTabFeature;
}
return null;
}
set
{
if (convPrjFeature.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureId);
}
else if (convPrjFeature.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureName);
}
else if (convPrjFeature.KeyWords  ==  _AttributeName[intIndex])
{
mstrKeyWords = value.ToString();
 AddUpdatedFld(convPrjFeature.KeyWords);
}
else if (convPrjFeature.DefaButtonName  ==  _AttributeName[intIndex])
{
mstrDefaButtonName = value.ToString();
 AddUpdatedFld(convPrjFeature.DefaButtonName);
}
else if (convPrjFeature.RegionTypeId  ==  _AttributeName[intIndex])
{
mstrRegionTypeId = value.ToString();
 AddUpdatedFld(convPrjFeature.RegionTypeId);
}
else if (convPrjFeature.RegionTypeName  ==  _AttributeName[intIndex])
{
mstrRegionTypeName = value.ToString();
 AddUpdatedFld(convPrjFeature.RegionTypeName);
}
else if (convPrjFeature.GroupName  ==  _AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convPrjFeature.GroupName);
}
else if (convPrjFeature.FeatureDescription  ==  _AttributeName[intIndex])
{
mstrFeatureDescription = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureDescription);
}
else if (convPrjFeature.InOutTypeId  ==  _AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convPrjFeature.InOutTypeId);
}
else if (convPrjFeature.InOutTypeName  ==  _AttributeName[intIndex])
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convPrjFeature.InOutTypeName);
}
else if (convPrjFeature.IsNeedField  ==  _AttributeName[intIndex])
{
mbolIsNeedField = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeature.IsNeedField);
}
else if (convPrjFeature.FunctionGroupId  ==  _AttributeName[intIndex])
{
mstrFunctionGroupId = value.ToString();
 AddUpdatedFld(convPrjFeature.FunctionGroupId);
}
else if (convPrjFeature.FunctionGroupName  ==  _AttributeName[intIndex])
{
mstrFunctionGroupName = value.ToString();
 AddUpdatedFld(convPrjFeature.FunctionGroupName);
}
else if (convPrjFeature.FeatureTypeId  ==  _AttributeName[intIndex])
{
mstrFeatureTypeId = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureTypeId);
}
else if (convPrjFeature.FeatureTypeName  ==  _AttributeName[intIndex])
{
mstrFeatureTypeName = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureTypeName);
}
else if (convPrjFeature.CreateUserId  ==  _AttributeName[intIndex])
{
mstrCreateUserId = value.ToString();
 AddUpdatedFld(convPrjFeature.CreateUserId);
}
else if (convPrjFeature.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeature.InUse);
}
else if (convPrjFeature.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjFeature.OrderNum);
}
else if (convPrjFeature.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjFeature.UpdDate);
}
else if (convPrjFeature.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPrjFeature.UpdUser);
}
else if (convPrjFeature.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjFeature.Memo);
}
else if (convPrjFeature.FuncCount  ==  _AttributeName[intIndex])
{
mintFuncCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjFeature.FuncCount);
}
else if (convPrjFeature.FeatureName2  ==  _AttributeName[intIndex])
{
mstrFeatureName2 = value.ToString();
 AddUpdatedFld(convPrjFeature.FeatureName2);
}
else if (convPrjFeature.ParentFeatureId  ==  _AttributeName[intIndex])
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convPrjFeature.ParentFeatureId);
}
else if (convPrjFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convPrjFeature.ParentFeatureName);
}
else if (convPrjFeature.IsNeedTabFeature  ==  _AttributeName[intIndex])
{
mbolIsNeedTabFeature = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjFeature.IsNeedTabFeature);
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
 AddUpdatedFld(convPrjFeature.FeatureId);
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
 AddUpdatedFld(convPrjFeature.FeatureName);
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
 AddUpdatedFld(convPrjFeature.KeyWords);
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
 AddUpdatedFld(convPrjFeature.DefaButtonName);
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
 AddUpdatedFld(convPrjFeature.RegionTypeId);
}
}
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegionTypeName
{
get
{
return mstrRegionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegionTypeName = value;
}
else
{
 mstrRegionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeature.RegionTypeName);
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
 AddUpdatedFld(convPrjFeature.GroupName);
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
 AddUpdatedFld(convPrjFeature.FeatureDescription);
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
 AddUpdatedFld(convPrjFeature.InOutTypeId);
}
}
/// <summary>
/// INOUT类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeName
{
get
{
return mstrInOutTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeName = value;
}
else
{
 mstrInOutTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeature.InOutTypeName);
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
 AddUpdatedFld(convPrjFeature.IsNeedField);
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
 AddUpdatedFld(convPrjFeature.FunctionGroupId);
}
}
/// <summary>
/// 函数组名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionGroupName
{
get
{
return mstrFunctionGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionGroupName = value;
}
else
{
 mstrFunctionGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeature.FunctionGroupName);
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
 AddUpdatedFld(convPrjFeature.FeatureTypeId);
}
}
/// <summary>
/// 功能类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureTypeName
{
get
{
return mstrFeatureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureTypeName = value;
}
else
{
 mstrFeatureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeature.FeatureTypeName);
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
 AddUpdatedFld(convPrjFeature.CreateUserId);
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
 AddUpdatedFld(convPrjFeature.InUse);
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
 AddUpdatedFld(convPrjFeature.OrderNum);
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
 AddUpdatedFld(convPrjFeature.UpdDate);
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
 AddUpdatedFld(convPrjFeature.UpdUser);
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
 AddUpdatedFld(convPrjFeature.Memo);
}
}
/// <summary>
/// 函数数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FuncCount
{
get
{
return mintFuncCount;
}
set
{
 mintFuncCount = value;
//记录修改过的字段
 AddUpdatedFld(convPrjFeature.FuncCount);
}
}
/// <summary>
/// 功能名-FuncCount(说明:;字段类型:varchar;字段长度:112;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureName2
{
get
{
return mstrFeatureName2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureName2 = value;
}
else
{
 mstrFeatureName2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjFeature.FeatureName2);
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
 AddUpdatedFld(convPrjFeature.ParentFeatureId);
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
 AddUpdatedFld(convPrjFeature.ParentFeatureName);
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
 AddUpdatedFld(convPrjFeature.IsNeedTabFeature);
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
}
 /// <summary>
 /// v功能(vPrjFeature)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjFeature
{
public const string _CurrTabName = "vPrjFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"FeatureId", "FeatureName", "KeyWords", "DefaButtonName", "RegionTypeId", "RegionTypeName", "GroupName", "FeatureDescription", "InOutTypeId", "InOutTypeName", "IsNeedField", "FunctionGroupId", "FunctionGroupName", "FeatureTypeId", "FeatureTypeName", "CreateUserId", "InUse", "OrderNum", "UpdDate", "UpdUser", "Memo", "FuncCount", "FeatureName2", "ParentFeatureId", "ParentFeatureName", "IsNeedTabFeature"};
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
 /// 常量:"RegionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeId = "RegionTypeId";    //区域类型Id

 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegionTypeName = "RegionTypeName";    //区域类型名称

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
 /// 常量:"InOutTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeName = "InOutTypeName";    //INOUT类型名称

 /// <summary>
 /// 常量:"IsNeedField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedField = "IsNeedField";    //是否需要字段

 /// <summary>
 /// 常量:"FunctionGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupId = "FunctionGroupId";    //函数组Id

 /// <summary>
 /// 常量:"FunctionGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionGroupName = "FunctionGroupName";    //函数组名称

 /// <summary>
 /// 常量:"FeatureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeId = "FeatureTypeId";    //功能类型Id

 /// <summary>
 /// 常量:"FeatureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureTypeName = "FeatureTypeName";    //功能类型名称

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

 /// <summary>
 /// 常量:"FuncCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncCount = "FuncCount";    //函数数目

 /// <summary>
 /// 常量:"FeatureName2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureName2 = "FeatureName2";    //功能名-FuncCount

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
 /// 常量:"IsNeedTabFeature"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTabFeature = "IsNeedTabFeature";    //是否需要表功能
}

}