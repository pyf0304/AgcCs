
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureEN
 表名:vTabFeature(00050464)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表vTabFeature的关键字(TabFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabFeatureId_vTabFeature
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabFeatureId">表关键字</param>
public K_TabFeatureId_vTabFeature(string strTabFeatureId)
{
if (IsValid(strTabFeatureId)) Value = strTabFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabFeatureId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return false;
if (strTabFeatureId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabFeatureId_vTabFeature]类型的对象</returns>
public static implicit operator K_TabFeatureId_vTabFeature(string value)
{
return new K_TabFeatureId_vTabFeature(value);
}
}
 /// <summary>
 /// v表功能(vTabFeature)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabFeatureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 23;
public static string[] _AttributeName = new string[] {"TabFeatureId", "TabFeatureName", "TabId", "TabName", "TabCnName", "PrjName", "SqlDsTypeName", "FuncModuleAgcId", "FuncModuleName", "OrderNum4Refer", "FeatureId", "FeatureName", "ParentFeatureId", "ParentFeatureName", "FuncNameCs", "FuncNameJs", "OrderNum", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "FldNum"};

protected string mstrTabFeatureId;    //表功能Id
protected string mstrTabFeatureName;    //表功能名
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrPrjName;    //工程名称
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected int? mintOrderNum4Refer;    //引用序号
protected string mstrFeatureId;    //功能Id
protected string mstrFeatureName;    //功能名称
protected string mstrParentFeatureId;    //父功能Id
protected string mstrParentFeatureName;    //父功能名
protected string mstrFuncNameCs;    //Cs函数名
protected string mstrFuncNameJs;    //Js函数名
protected int mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrPrjId;    //工程Id
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected int? mintFldNum;    //字段数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabFeatureEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabFeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabFeatureId">关键字:表功能Id</param>
public clsvTabFeatureEN(string strTabFeatureId)
 {
strTabFeatureId = strTabFeatureId.Replace("'", "''");
if (strTabFeatureId.Length > 8)
{
throw new Exception("在表:vTabFeature中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabFeatureId)  ==  true)
{
throw new Exception("在表:vTabFeature中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabFeatureId = strTabFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabFeatureId");
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
if (strAttributeName  ==  convTabFeature.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  convTabFeature.TabFeatureName)
{
return mstrTabFeatureName;
}
else if (strAttributeName  ==  convTabFeature.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convTabFeature.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convTabFeature.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convTabFeature.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convTabFeature.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convTabFeature.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convTabFeature.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convTabFeature.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  convTabFeature.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convTabFeature.FeatureName)
{
return mstrFeatureName;
}
else if (strAttributeName  ==  convTabFeature.ParentFeatureId)
{
return mstrParentFeatureId;
}
else if (strAttributeName  ==  convTabFeature.ParentFeatureName)
{
return mstrParentFeatureName;
}
else if (strAttributeName  ==  convTabFeature.FuncNameCs)
{
return mstrFuncNameCs;
}
else if (strAttributeName  ==  convTabFeature.FuncNameJs)
{
return mstrFuncNameJs;
}
else if (strAttributeName  ==  convTabFeature.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convTabFeature.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convTabFeature.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convTabFeature.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convTabFeature.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTabFeature.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTabFeature.FldNum)
{
return mintFldNum;
}
return null;
}
set
{
if (strAttributeName  ==  convTabFeature.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature.TabFeatureId);
}
else if (strAttributeName  ==  convTabFeature.TabFeatureName)
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature.TabFeatureName);
}
else if (strAttributeName  ==  convTabFeature.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFeature.TabId);
}
else if (strAttributeName  ==  convTabFeature.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabFeature.TabName);
}
else if (strAttributeName  ==  convTabFeature.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFeature.TabCnName);
}
else if (strAttributeName  ==  convTabFeature.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabFeature.PrjName);
}
else if (strAttributeName  ==  convTabFeature.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convTabFeature.SqlDsTypeName);
}
else if (strAttributeName  ==  convTabFeature.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convTabFeature.FuncModuleAgcId);
}
else if (strAttributeName  ==  convTabFeature.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTabFeature.FuncModuleName);
}
else if (strAttributeName  ==  convTabFeature.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature.OrderNum4Refer);
}
else if (strAttributeName  ==  convTabFeature.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature.FeatureId);
}
else if (strAttributeName  ==  convTabFeature.FeatureName)
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature.FeatureName);
}
else if (strAttributeName  ==  convTabFeature.ParentFeatureId)
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature.ParentFeatureId);
}
else if (strAttributeName  ==  convTabFeature.ParentFeatureName)
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature.ParentFeatureName);
}
else if (strAttributeName  ==  convTabFeature.FuncNameCs)
{
mstrFuncNameCs = value.ToString();
 AddUpdatedFld(convTabFeature.FuncNameCs);
}
else if (strAttributeName  ==  convTabFeature.FuncNameJs)
{
mstrFuncNameJs = value.ToString();
 AddUpdatedFld(convTabFeature.FuncNameJs);
}
else if (strAttributeName  ==  convTabFeature.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature.OrderNum);
}
else if (strAttributeName  ==  convTabFeature.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature.InUse);
}
else if (strAttributeName  ==  convTabFeature.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFeature.PrjId);
}
else if (strAttributeName  ==  convTabFeature.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFeature.UpdUser);
}
else if (strAttributeName  ==  convTabFeature.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFeature.UpdDate);
}
else if (strAttributeName  ==  convTabFeature.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFeature.Memo);
}
else if (strAttributeName  ==  convTabFeature.FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature.FldNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabFeature.TabFeatureId  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (convTabFeature.TabFeatureName  ==  _AttributeName[intIndex])
{
return mstrTabFeatureName;
}
else if (convTabFeature.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convTabFeature.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convTabFeature.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convTabFeature.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convTabFeature.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convTabFeature.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convTabFeature.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convTabFeature.OrderNum4Refer  ==  _AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (convTabFeature.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convTabFeature.FeatureName  ==  _AttributeName[intIndex])
{
return mstrFeatureName;
}
else if (convTabFeature.ParentFeatureId  ==  _AttributeName[intIndex])
{
return mstrParentFeatureId;
}
else if (convTabFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
return mstrParentFeatureName;
}
else if (convTabFeature.FuncNameCs  ==  _AttributeName[intIndex])
{
return mstrFuncNameCs;
}
else if (convTabFeature.FuncNameJs  ==  _AttributeName[intIndex])
{
return mstrFuncNameJs;
}
else if (convTabFeature.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convTabFeature.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convTabFeature.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convTabFeature.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convTabFeature.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTabFeature.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTabFeature.FldNum  ==  _AttributeName[intIndex])
{
return mintFldNum;
}
return null;
}
set
{
if (convTabFeature.TabFeatureId  ==  _AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature.TabFeatureId);
}
else if (convTabFeature.TabFeatureName  ==  _AttributeName[intIndex])
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature.TabFeatureName);
}
else if (convTabFeature.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFeature.TabId);
}
else if (convTabFeature.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convTabFeature.TabName);
}
else if (convTabFeature.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convTabFeature.TabCnName);
}
else if (convTabFeature.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convTabFeature.PrjName);
}
else if (convTabFeature.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convTabFeature.SqlDsTypeName);
}
else if (convTabFeature.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convTabFeature.FuncModuleAgcId);
}
else if (convTabFeature.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTabFeature.FuncModuleName);
}
else if (convTabFeature.OrderNum4Refer  ==  _AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature.OrderNum4Refer);
}
else if (convTabFeature.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature.FeatureId);
}
else if (convTabFeature.FeatureName  ==  _AttributeName[intIndex])
{
mstrFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature.FeatureName);
}
else if (convTabFeature.ParentFeatureId  ==  _AttributeName[intIndex])
{
mstrParentFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature.ParentFeatureId);
}
else if (convTabFeature.ParentFeatureName  ==  _AttributeName[intIndex])
{
mstrParentFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature.ParentFeatureName);
}
else if (convTabFeature.FuncNameCs  ==  _AttributeName[intIndex])
{
mstrFuncNameCs = value.ToString();
 AddUpdatedFld(convTabFeature.FuncNameCs);
}
else if (convTabFeature.FuncNameJs  ==  _AttributeName[intIndex])
{
mstrFuncNameJs = value.ToString();
 AddUpdatedFld(convTabFeature.FuncNameJs);
}
else if (convTabFeature.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature.OrderNum);
}
else if (convTabFeature.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature.InUse);
}
else if (convTabFeature.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convTabFeature.PrjId);
}
else if (convTabFeature.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFeature.UpdUser);
}
else if (convTabFeature.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFeature.UpdDate);
}
else if (convTabFeature.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFeature.Memo);
}
else if (convTabFeature.FldNum  ==  _AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature.FldNum);
}
}
}

/// <summary>
/// 表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureId
{
get
{
return mstrTabFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureId = value;
}
else
{
 mstrTabFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature.TabFeatureId);
}
}
/// <summary>
/// 表功能名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureName
{
get
{
return mstrTabFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureName = value;
}
else
{
 mstrTabFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature.TabFeatureName);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature.TabId);
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
 AddUpdatedFld(convTabFeature.TabName);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature.TabCnName);
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
 AddUpdatedFld(convTabFeature.PrjName);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature.SqlDsTypeName);
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
 AddUpdatedFld(convTabFeature.FuncModuleAgcId);
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
 AddUpdatedFld(convTabFeature.FuncModuleName);
}
}
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum4Refer
{
get
{
return mintOrderNum4Refer;
}
set
{
 mintOrderNum4Refer = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeature.OrderNum4Refer);
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
 AddUpdatedFld(convTabFeature.FeatureId);
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
 AddUpdatedFld(convTabFeature.FeatureName);
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
 AddUpdatedFld(convTabFeature.ParentFeatureId);
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
 AddUpdatedFld(convTabFeature.ParentFeatureName);
}
}
/// <summary>
/// Cs函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncNameCs
{
get
{
return mstrFuncNameCs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncNameCs = value;
}
else
{
 mstrFuncNameCs = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature.FuncNameCs);
}
}
/// <summary>
/// Js函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncNameJs
{
get
{
return mstrFuncNameJs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncNameJs = value;
}
else
{
 mstrFuncNameJs = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature.FuncNameJs);
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
 AddUpdatedFld(convTabFeature.OrderNum);
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
 AddUpdatedFld(convTabFeature.InUse);
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
 AddUpdatedFld(convTabFeature.PrjId);
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
 AddUpdatedFld(convTabFeature.UpdUser);
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
 AddUpdatedFld(convTabFeature.UpdDate);
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
 AddUpdatedFld(convTabFeature.Memo);
}
}
/// <summary>
/// 字段数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldNum
{
get
{
return mintFldNum;
}
set
{
 mintFldNum = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeature.FldNum);
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
  return mstrTabFeatureId;
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
  return mstrTabFeatureName;
 }
 }
}
 /// <summary>
 /// v表功能(vTabFeature)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabFeature
{
public const string _CurrTabName = "vTabFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabFeatureId", "TabFeatureName", "TabId", "TabName", "TabCnName", "PrjName", "SqlDsTypeName", "FuncModuleAgcId", "FuncModuleName", "OrderNum4Refer", "FeatureId", "FeatureName", "ParentFeatureId", "ParentFeatureName", "FuncNameCs", "FuncNameJs", "OrderNum", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "FldNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId = "TabFeatureId";    //表功能Id

 /// <summary>
 /// 常量:"TabFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureName = "TabFeatureName";    //表功能名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

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
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum4Refer = "OrderNum4Refer";    //引用序号

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
 /// 常量:"FuncNameCs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNameCs = "FuncNameCs";    //Cs函数名

 /// <summary>
 /// 常量:"FuncNameJs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNameJs = "FuncNameJs";    //Js函数名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldNum = "FldNum";    //字段数
}

}