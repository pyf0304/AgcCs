
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimEN
 表名:vPrjTab_Sim(00050597)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:09
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
 /// 表vPrjTab_Sim的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTab_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_vPrjTab_Sim(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_vPrjTab_Sim]类型的对象</returns>
public static implicit operator K_TabId_vPrjTab_Sim(string value)
{
return new K_TabId_vPrjTab_Sim(value);
}
}
 /// <summary>
 /// v工程表_Sim(vPrjTab_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTab_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTab_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 12;
public static string[] _AttributeName = new string[] {"TabId", "TabName", "SqlDsTypeId", "FuncModuleAgcId", "TabTypeId", "CacheModeId", "TabStateId", "PrjId", "DataBaseName", "UpdDate", "FldNum", "IsShare"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrTabTypeId;    //表类型Id
protected string mstrCacheModeId;    //缓存方式Id
protected string mstrTabStateId;    //表状态ID
protected string mstrPrjId;    //工程Id
protected string mstrDataBaseName;    //数据库名
protected string mstrUpdDate;    //修改日期
protected int? mintFldNum;    //字段数
protected bool mbolIsShare;    //是否共享

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTab_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsvPrjTab_SimEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTab_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTab_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  convPrjTab_Sim.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTab_Sim.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convPrjTab_Sim.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convPrjTab_Sim.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convPrjTab_Sim.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  convPrjTab_Sim.CacheModeId)
{
return mstrCacheModeId;
}
else if (strAttributeName  ==  convPrjTab_Sim.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convPrjTab_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjTab_Sim.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convPrjTab_Sim.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjTab_Sim.FldNum)
{
return mintFldNum;
}
else if (strAttributeName  ==  convPrjTab_Sim.IsShare)
{
return mbolIsShare;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTab_Sim.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabId);
}
else if (strAttributeName  ==  convPrjTab_Sim.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabName);
}
else if (strAttributeName  ==  convPrjTab_Sim.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.SqlDsTypeId);
}
else if (strAttributeName  ==  convPrjTab_Sim.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.FuncModuleAgcId);
}
else if (strAttributeName  ==  convPrjTab_Sim.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabTypeId);
}
else if (strAttributeName  ==  convPrjTab_Sim.CacheModeId)
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.CacheModeId);
}
else if (strAttributeName  ==  convPrjTab_Sim.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabStateId);
}
else if (strAttributeName  ==  convPrjTab_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.PrjId);
}
else if (strAttributeName  ==  convPrjTab_Sim.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.DataBaseName);
}
else if (strAttributeName  ==  convPrjTab_Sim.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.UpdDate);
}
else if (strAttributeName  ==  convPrjTab_Sim.FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab_Sim.FldNum);
}
else if (strAttributeName  ==  convPrjTab_Sim.IsShare)
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab_Sim.IsShare);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTab_Sim.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTab_Sim.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convPrjTab_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convPrjTab_Sim.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convPrjTab_Sim.TabTypeId  ==  _AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (convPrjTab_Sim.CacheModeId  ==  _AttributeName[intIndex])
{
return mstrCacheModeId;
}
else if (convPrjTab_Sim.TabStateId  ==  _AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convPrjTab_Sim.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjTab_Sim.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convPrjTab_Sim.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjTab_Sim.FldNum  ==  _AttributeName[intIndex])
{
return mintFldNum;
}
else if (convPrjTab_Sim.IsShare  ==  _AttributeName[intIndex])
{
return mbolIsShare;
}
return null;
}
set
{
if (convPrjTab_Sim.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabId);
}
else if (convPrjTab_Sim.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabName);
}
else if (convPrjTab_Sim.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.SqlDsTypeId);
}
else if (convPrjTab_Sim.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.FuncModuleAgcId);
}
else if (convPrjTab_Sim.TabTypeId  ==  _AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabTypeId);
}
else if (convPrjTab_Sim.CacheModeId  ==  _AttributeName[intIndex])
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.CacheModeId);
}
else if (convPrjTab_Sim.TabStateId  ==  _AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.TabStateId);
}
else if (convPrjTab_Sim.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.PrjId);
}
else if (convPrjTab_Sim.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.DataBaseName);
}
else if (convPrjTab_Sim.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjTab_Sim.UpdDate);
}
else if (convPrjTab_Sim.FldNum  ==  _AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab_Sim.FldNum);
}
else if (convPrjTab_Sim.IsShare  ==  _AttributeName[intIndex])
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab_Sim.IsShare);
}
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
 AddUpdatedFld(convPrjTab_Sim.TabId);
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
 AddUpdatedFld(convPrjTab_Sim.TabName);
}
}
/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_Sim.SqlDsTypeId);
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
 AddUpdatedFld(convPrjTab_Sim.FuncModuleAgcId);
}
}
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeId
{
get
{
return mstrTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeId = value;
}
else
{
 mstrTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_Sim.TabTypeId);
}
}
/// <summary>
/// 缓存方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheModeId
{
get
{
return mstrCacheModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheModeId = value;
}
else
{
 mstrCacheModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_Sim.CacheModeId);
}
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_Sim.TabStateId);
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
 AddUpdatedFld(convPrjTab_Sim.PrjId);
}
}
/// <summary>
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseName = value;
}
else
{
 mstrDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab_Sim.DataBaseName);
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
 AddUpdatedFld(convPrjTab_Sim.UpdDate);
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
 AddUpdatedFld(convPrjTab_Sim.FldNum);
}
}
/// <summary>
/// 是否共享(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShare
{
get
{
return mbolIsShare;
}
set
{
 mbolIsShare = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab_Sim.IsShare);
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
  return mstrTabId;
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
  return mstrTabName;
 }
 }
}
 /// <summary>
 /// v工程表_Sim(vPrjTab_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTab_Sim
{
public const string _CurrTabName = "vPrjTab_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "TabName", "SqlDsTypeId", "FuncModuleAgcId", "TabTypeId", "CacheModeId", "TabStateId", "PrjId", "DataBaseName", "UpdDate", "FldNum", "IsShare"};
//以下是属性变量


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
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"CacheModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheModeId = "CacheModeId";    //缓存方式Id

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程Id

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldNum = "FldNum";    //字段数

 /// <summary>
 /// 常量:"IsShare"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShare = "IsShare";    //是否共享
}

}