
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeature_SimEN
 表名:vTabFeature_Sim(00050613)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:32
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
 /// 表vTabFeature_Sim的关键字(TabFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabFeatureId_vTabFeature_Sim
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
public K_TabFeatureId_vTabFeature_Sim(string strTabFeatureId)
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
 /// <returns>返回:[K_TabFeatureId_vTabFeature_Sim]类型的对象</returns>
public static implicit operator K_TabFeatureId_vTabFeature_Sim(string value)
{
return new K_TabFeatureId_vTabFeature_Sim(value);
}
}
 /// <summary>
 /// v表功能_Sim(vTabFeature_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTabFeature_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTabFeature_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 19;
public static string[] _AttributeName = new string[] {"TabFeatureId", "TabFeatureName", "TabId", "OrderNum", "InUse", "UpdUser", "UpdDate", "Memo", "FeatureId", "FuncNameCs", "GetDdlDataFuncName4Ex", "CmPrjId", "FuncNameJs", "IsForDiv", "IsForCSharp", "IsForTypeScript", "IsExtendedClass", "IsNeedGC", "ToolTipText"};

protected string mstrTabFeatureId;    //表功能Id
protected string mstrTabFeatureName;    //表功能名
protected string mstrTabId;    //表ID
protected int mintOrderNum;    //序号
protected bool mbolInUse;    //是否在用
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrFeatureId;    //功能Id
protected string mstrFuncNameCs;    //Cs函数名
protected string mstrGetDdlDataFuncName4Ex;    //获取Ddl函数名
protected string mstrCmPrjId;    //Cm工程Id
protected string mstrFuncNameJs;    //Js函数名
protected bool mbolIsForDiv;    //是否针对Div内控件
protected bool mbolIsForCSharp;    //是否ForCSharp
protected bool mbolIsForTypeScript;    //是否ForTypeScript
protected bool mbolIsExtendedClass;    //是否在扩展类
protected bool mbolIsNeedGC;    //是否需要生成代码
protected string mstrToolTipText;    //提示文字

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvTabFeature_SimEN()
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
public clsvTabFeature_SimEN(string strTabFeatureId)
 {
strTabFeatureId = strTabFeatureId.Replace("'", "''");
if (strTabFeatureId.Length > 8)
{
throw new Exception("在表:vTabFeature_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabFeatureId)  ==  true)
{
throw new Exception("在表:vTabFeature_Sim中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convTabFeature_Sim.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  convTabFeature_Sim.TabFeatureName)
{
return mstrTabFeatureName;
}
else if (strAttributeName  ==  convTabFeature_Sim.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convTabFeature_Sim.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convTabFeature_Sim.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convTabFeature_Sim.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convTabFeature_Sim.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTabFeature_Sim.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTabFeature_Sim.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  convTabFeature_Sim.FuncNameCs)
{
return mstrFuncNameCs;
}
else if (strAttributeName  ==  convTabFeature_Sim.GetDdlDataFuncName4Ex)
{
return mstrGetDdlDataFuncName4Ex;
}
else if (strAttributeName  ==  convTabFeature_Sim.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convTabFeature_Sim.FuncNameJs)
{
return mstrFuncNameJs;
}
else if (strAttributeName  ==  convTabFeature_Sim.IsForDiv)
{
return mbolIsForDiv;
}
else if (strAttributeName  ==  convTabFeature_Sim.IsForCSharp)
{
return mbolIsForCSharp;
}
else if (strAttributeName  ==  convTabFeature_Sim.IsForTypeScript)
{
return mbolIsForTypeScript;
}
else if (strAttributeName  ==  convTabFeature_Sim.IsExtendedClass)
{
return mbolIsExtendedClass;
}
else if (strAttributeName  ==  convTabFeature_Sim.IsNeedGC)
{
return mbolIsNeedGC;
}
else if (strAttributeName  ==  convTabFeature_Sim.ToolTipText)
{
return mstrToolTipText;
}
return null;
}
set
{
if (strAttributeName  ==  convTabFeature_Sim.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.TabFeatureId);
}
else if (strAttributeName  ==  convTabFeature_Sim.TabFeatureName)
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.TabFeatureName);
}
else if (strAttributeName  ==  convTabFeature_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.TabId);
}
else if (strAttributeName  ==  convTabFeature_Sim.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.OrderNum);
}
else if (strAttributeName  ==  convTabFeature_Sim.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.InUse);
}
else if (strAttributeName  ==  convTabFeature_Sim.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.UpdUser);
}
else if (strAttributeName  ==  convTabFeature_Sim.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.UpdDate);
}
else if (strAttributeName  ==  convTabFeature_Sim.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.Memo);
}
else if (strAttributeName  ==  convTabFeature_Sim.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.FeatureId);
}
else if (strAttributeName  ==  convTabFeature_Sim.FuncNameCs)
{
mstrFuncNameCs = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.FuncNameCs);
}
else if (strAttributeName  ==  convTabFeature_Sim.GetDdlDataFuncName4Ex)
{
mstrGetDdlDataFuncName4Ex = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.GetDdlDataFuncName4Ex);
}
else if (strAttributeName  ==  convTabFeature_Sim.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.CmPrjId);
}
else if (strAttributeName  ==  convTabFeature_Sim.FuncNameJs)
{
mstrFuncNameJs = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.FuncNameJs);
}
else if (strAttributeName  ==  convTabFeature_Sim.IsForDiv)
{
mbolIsForDiv = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsForDiv);
}
else if (strAttributeName  ==  convTabFeature_Sim.IsForCSharp)
{
mbolIsForCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsForCSharp);
}
else if (strAttributeName  ==  convTabFeature_Sim.IsForTypeScript)
{
mbolIsForTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsForTypeScript);
}
else if (strAttributeName  ==  convTabFeature_Sim.IsExtendedClass)
{
mbolIsExtendedClass = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsExtendedClass);
}
else if (strAttributeName  ==  convTabFeature_Sim.IsNeedGC)
{
mbolIsNeedGC = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsNeedGC);
}
else if (strAttributeName  ==  convTabFeature_Sim.ToolTipText)
{
mstrToolTipText = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.ToolTipText);
}
}
}
public object this[int intIndex]
{
get
{
if (convTabFeature_Sim.TabFeatureId  ==  _AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (convTabFeature_Sim.TabFeatureName  ==  _AttributeName[intIndex])
{
return mstrTabFeatureName;
}
else if (convTabFeature_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convTabFeature_Sim.OrderNum  ==  _AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convTabFeature_Sim.InUse  ==  _AttributeName[intIndex])
{
return mbolInUse;
}
else if (convTabFeature_Sim.UpdUser  ==  _AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convTabFeature_Sim.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTabFeature_Sim.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTabFeature_Sim.FeatureId  ==  _AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (convTabFeature_Sim.FuncNameCs  ==  _AttributeName[intIndex])
{
return mstrFuncNameCs;
}
else if (convTabFeature_Sim.GetDdlDataFuncName4Ex  ==  _AttributeName[intIndex])
{
return mstrGetDdlDataFuncName4Ex;
}
else if (convTabFeature_Sim.CmPrjId  ==  _AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convTabFeature_Sim.FuncNameJs  ==  _AttributeName[intIndex])
{
return mstrFuncNameJs;
}
else if (convTabFeature_Sim.IsForDiv  ==  _AttributeName[intIndex])
{
return mbolIsForDiv;
}
else if (convTabFeature_Sim.IsForCSharp  ==  _AttributeName[intIndex])
{
return mbolIsForCSharp;
}
else if (convTabFeature_Sim.IsForTypeScript  ==  _AttributeName[intIndex])
{
return mbolIsForTypeScript;
}
else if (convTabFeature_Sim.IsExtendedClass  ==  _AttributeName[intIndex])
{
return mbolIsExtendedClass;
}
else if (convTabFeature_Sim.IsNeedGC  ==  _AttributeName[intIndex])
{
return mbolIsNeedGC;
}
else if (convTabFeature_Sim.ToolTipText  ==  _AttributeName[intIndex])
{
return mstrToolTipText;
}
return null;
}
set
{
if (convTabFeature_Sim.TabFeatureId  ==  _AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.TabFeatureId);
}
else if (convTabFeature_Sim.TabFeatureName  ==  _AttributeName[intIndex])
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.TabFeatureName);
}
else if (convTabFeature_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.TabId);
}
else if (convTabFeature_Sim.OrderNum  ==  _AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.OrderNum);
}
else if (convTabFeature_Sim.InUse  ==  _AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.InUse);
}
else if (convTabFeature_Sim.UpdUser  ==  _AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.UpdUser);
}
else if (convTabFeature_Sim.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.UpdDate);
}
else if (convTabFeature_Sim.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.Memo);
}
else if (convTabFeature_Sim.FeatureId  ==  _AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.FeatureId);
}
else if (convTabFeature_Sim.FuncNameCs  ==  _AttributeName[intIndex])
{
mstrFuncNameCs = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.FuncNameCs);
}
else if (convTabFeature_Sim.GetDdlDataFuncName4Ex  ==  _AttributeName[intIndex])
{
mstrGetDdlDataFuncName4Ex = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.GetDdlDataFuncName4Ex);
}
else if (convTabFeature_Sim.CmPrjId  ==  _AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.CmPrjId);
}
else if (convTabFeature_Sim.FuncNameJs  ==  _AttributeName[intIndex])
{
mstrFuncNameJs = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.FuncNameJs);
}
else if (convTabFeature_Sim.IsForDiv  ==  _AttributeName[intIndex])
{
mbolIsForDiv = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsForDiv);
}
else if (convTabFeature_Sim.IsForCSharp  ==  _AttributeName[intIndex])
{
mbolIsForCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsForCSharp);
}
else if (convTabFeature_Sim.IsForTypeScript  ==  _AttributeName[intIndex])
{
mbolIsForTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsForTypeScript);
}
else if (convTabFeature_Sim.IsExtendedClass  ==  _AttributeName[intIndex])
{
mbolIsExtendedClass = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsExtendedClass);
}
else if (convTabFeature_Sim.IsNeedGC  ==  _AttributeName[intIndex])
{
mbolIsNeedGC = TransNullToBool(value.ToString());
 AddUpdatedFld(convTabFeature_Sim.IsNeedGC);
}
else if (convTabFeature_Sim.ToolTipText  ==  _AttributeName[intIndex])
{
mstrToolTipText = value.ToString();
 AddUpdatedFld(convTabFeature_Sim.ToolTipText);
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
 AddUpdatedFld(convTabFeature_Sim.TabFeatureId);
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
 AddUpdatedFld(convTabFeature_Sim.TabFeatureName);
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
 AddUpdatedFld(convTabFeature_Sim.TabId);
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
 AddUpdatedFld(convTabFeature_Sim.OrderNum);
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
 AddUpdatedFld(convTabFeature_Sim.InUse);
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
 AddUpdatedFld(convTabFeature_Sim.UpdUser);
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
 AddUpdatedFld(convTabFeature_Sim.UpdDate);
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
 AddUpdatedFld(convTabFeature_Sim.Memo);
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
 AddUpdatedFld(convTabFeature_Sim.FeatureId);
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
 AddUpdatedFld(convTabFeature_Sim.FuncNameCs);
}
}
/// <summary>
/// 获取Ddl函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GetDdlDataFuncName4Ex
{
get
{
return mstrGetDdlDataFuncName4Ex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGetDdlDataFuncName4Ex = value;
}
else
{
 mstrGetDdlDataFuncName4Ex = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature_Sim.GetDdlDataFuncName4Ex);
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
 AddUpdatedFld(convTabFeature_Sim.CmPrjId);
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
 AddUpdatedFld(convTabFeature_Sim.FuncNameJs);
}
}
/// <summary>
/// 是否针对Div内控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForDiv
{
get
{
return mbolIsForDiv;
}
set
{
 mbolIsForDiv = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeature_Sim.IsForDiv);
}
}
/// <summary>
/// 是否ForCSharp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForCSharp
{
get
{
return mbolIsForCSharp;
}
set
{
 mbolIsForCSharp = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeature_Sim.IsForCSharp);
}
}
/// <summary>
/// 是否ForTypeScript(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForTypeScript
{
get
{
return mbolIsForTypeScript;
}
set
{
 mbolIsForTypeScript = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeature_Sim.IsForTypeScript);
}
}
/// <summary>
/// 是否在扩展类(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExtendedClass
{
get
{
return mbolIsExtendedClass;
}
set
{
 mbolIsExtendedClass = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeature_Sim.IsExtendedClass);
}
}
/// <summary>
/// 是否需要生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGC
{
get
{
return mbolIsNeedGC;
}
set
{
 mbolIsNeedGC = value;
//记录修改过的字段
 AddUpdatedFld(convTabFeature_Sim.IsNeedGC);
}
}
/// <summary>
/// 提示文字(说明:;字段类型:varchar;字段长度:150;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ToolTipText
{
get
{
return mstrToolTipText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrToolTipText = value;
}
else
{
 mstrToolTipText = value;
}
//记录修改过的字段
 AddUpdatedFld(convTabFeature_Sim.ToolTipText);
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
}
 /// <summary>
 /// v表功能_Sim(vTabFeature_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTabFeature_Sim
{
public const string _CurrTabName = "vTabFeature_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabFeatureId", "TabFeatureName", "TabId", "OrderNum", "InUse", "UpdUser", "UpdDate", "Memo", "FeatureId", "FuncNameCs", "GetDdlDataFuncName4Ex", "CmPrjId", "FuncNameJs", "IsForDiv", "IsForCSharp", "IsForTypeScript", "IsExtendedClass", "IsNeedGC", "ToolTipText"};
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
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FuncNameCs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNameCs = "FuncNameCs";    //Cs函数名

 /// <summary>
 /// 常量:"GetDdlDataFuncName4Ex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetDdlDataFuncName4Ex = "GetDdlDataFuncName4Ex";    //获取Ddl函数名

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //Cm工程Id

 /// <summary>
 /// 常量:"FuncNameJs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNameJs = "FuncNameJs";    //Js函数名

 /// <summary>
 /// 常量:"IsForDiv"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForDiv = "IsForDiv";    //是否针对Div内控件

 /// <summary>
 /// 常量:"IsForCSharp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForCSharp = "IsForCSharp";    //是否ForCSharp

 /// <summary>
 /// 常量:"IsForTypeScript"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForTypeScript = "IsForTypeScript";    //是否ForTypeScript

 /// <summary>
 /// 常量:"IsExtendedClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExtendedClass = "IsExtendedClass";    //是否在扩展类

 /// <summary>
 /// 常量:"IsNeedGC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGC = "IsNeedGC";    //是否需要生成代码

 /// <summary>
 /// 常量:"ToolTipText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ToolTipText = "ToolTipText";    //提示文字
}

}