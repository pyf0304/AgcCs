
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4GeneCodeEN
 表名:vPrjTab4GeneCode(00050284)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表vPrjTab4GeneCode的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTab4GeneCode
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
public K_TabId_vPrjTab4GeneCode(string strTabId)
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
 /// <returns>返回:[K_TabId_vPrjTab4GeneCode]类型的对象</returns>
public static implicit operator K_TabId_vPrjTab4GeneCode(string value)
{
return new K_TabId_vPrjTab4GeneCode(value);
}
}
 /// <summary>
 /// vPrjTab4GeneCode(vPrjTab4GeneCode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTab4GeneCodeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTab4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 41;
public static string[] _AttributeName = new string[] {"TabId", "FldNum", "GeneCodeDate", "IsNeedGene", "VersionGeneCode", "ApplicationTypeId", "TabName", "TabCnName", "PrjId", "PrjName", "IsNeedTransCode", "SqlDsTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "TabNameB", "IsParaTab", "IsNationStandard", "IsArchive", "IsChecked", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "IsReleToSqlTab", "Keyword", "TabTypeId", "TabTypeName", "TabMainTypeId", "TabMainTypeName", "RelaTabId4View", "OrderNum4Refer", "IsNeedGeneIndexer", "IsUseCache", "CacheClassifyField", "UpdUserId", "UpdDate", "Memo", "ErrMsg2", "DataBaseNameTab", "UserId4GeneCode"};

protected string mstrTabId;    //表ID
protected int? mintFldNum;    //字段数
protected string mstrGeneCodeDate;    //生成代码日期
protected bool mbolIsNeedGene;    //是否需要生成
protected string mstrVersionGeneCode;    //生成代码版本
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrPrjId;    //工程Id
protected string mstrPrjName;    //工程名称
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrTabStateId;    //表状态ID
protected string mstrTabStateName;    //表状态名称
protected string mstrTabNameB;    //表名_后备
protected bool mbolIsParaTab;    //是否参数表
protected bool mbolIsNationStandard;    //是否国标
protected bool mbolIsArchive;    //是否存档
protected bool mbolIsChecked;    //是否核实
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected string mstrOwner;    //拥有者
protected bool mbolIsReleToSqlTab;    //是否与SQL表相关
protected string mstrKeyword;    //关键字
protected string mstrTabTypeId;    //表类型Id
protected string mstrTabTypeName;    //表类型名
protected string mstrTabMainTypeId;    //表主类型Id
protected string mstrTabMainTypeName;    //表主类型名
protected string mstrRelaTabId4View;    //视图的相关表ID
protected int? mintOrderNum4Refer;    //引用序号
protected bool mbolIsNeedGeneIndexer;    //是否需要生成索引器
protected bool mbolIsUseCache;    //是否使用Cache
protected string mstrCacheClassifyField;    //缓存分类字段
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected string mstrErrMsg2;    //ErrMsg2
protected string mstrDataBaseNameTab;    //DataBaseName_Tab
protected string mstrUserId4GeneCode;    //UserId4GeneCode

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTab4GeneCodeEN()
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
public clsvPrjTab4GeneCodeEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTab4GeneCode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTab4GeneCode中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convPrjTab4GeneCode.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FldNum)
{
return mintFldNum;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNeedGene)
{
return mbolIsNeedGene;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.VersionGeneCode)
{
return mstrVersionGeneCode;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabStateName)
{
return mstrTabStateName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabNameB)
{
return mstrTabNameB;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsParaTab)
{
return mbolIsParaTab;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNationStandard)
{
return mbolIsNationStandard;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.Owner)
{
return mstrOwner;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsReleToSqlTab)
{
return mbolIsReleToSqlTab;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabTypeName)
{
return mstrTabTypeName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabMainTypeName)
{
return mstrTabMainTypeName;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.RelaTabId4View)
{
return mstrRelaTabId4View;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNeedGeneIndexer)
{
return mbolIsNeedGeneIndexer;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsUseCache)
{
return mbolIsUseCache;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.CacheClassifyField)
{
return mstrCacheClassifyField;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.ErrMsg2)
{
return mstrErrMsg2;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.DataBaseNameTab)
{
return mstrDataBaseNameTab;
}
else if (strAttributeName  ==  convPrjTab4GeneCode.UserId4GeneCode)
{
return mstrUserId4GeneCode;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTab4GeneCode.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.FldNum);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.GeneCodeDate);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNeedGene)
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedGene);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.VersionGeneCode)
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.VersionGeneCode);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.ApplicationTypeId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabCnName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.PrjId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.PrjName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedTransCode);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.SqlDsTypeId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.SqlDsTypeName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabStateId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabStateName)
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabStateName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabNameB)
{
mstrTabNameB = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabNameB);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsParaTab)
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsParaTab);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNationStandard)
{
mbolIsNationStandard = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNationStandard);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsArchive);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsChecked);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleAgcId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleEnName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.Owner)
{
mstrOwner = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.Owner);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsReleToSqlTab)
{
mbolIsReleToSqlTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsReleToSqlTab);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.Keyword);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabTypeId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabTypeName)
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabTypeName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabMainTypeId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.TabMainTypeName)
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabMainTypeName);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.RelaTabId4View)
{
mstrRelaTabId4View = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.RelaTabId4View);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.OrderNum4Refer);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsNeedGeneIndexer)
{
mbolIsNeedGeneIndexer = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedGeneIndexer);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.IsUseCache)
{
mbolIsUseCache = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsUseCache);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.CacheClassifyField)
{
mstrCacheClassifyField = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.CacheClassifyField);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.UpdUserId);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.UpdDate);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.Memo);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.ErrMsg2)
{
mstrErrMsg2 = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.ErrMsg2);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.DataBaseNameTab)
{
mstrDataBaseNameTab = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.DataBaseNameTab);
}
else if (strAttributeName  ==  convPrjTab4GeneCode.UserId4GeneCode)
{
mstrUserId4GeneCode = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.UserId4GeneCode);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTab4GeneCode.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTab4GeneCode.FldNum  ==  _AttributeName[intIndex])
{
return mintFldNum;
}
else if (convPrjTab4GeneCode.GeneCodeDate  ==  _AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convPrjTab4GeneCode.IsNeedGene  ==  _AttributeName[intIndex])
{
return mbolIsNeedGene;
}
else if (convPrjTab4GeneCode.VersionGeneCode  ==  _AttributeName[intIndex])
{
return mstrVersionGeneCode;
}
else if (convPrjTab4GeneCode.ApplicationTypeId  ==  _AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convPrjTab4GeneCode.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convPrjTab4GeneCode.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convPrjTab4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjTab4GeneCode.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convPrjTab4GeneCode.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (convPrjTab4GeneCode.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convPrjTab4GeneCode.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convPrjTab4GeneCode.TabStateId  ==  _AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convPrjTab4GeneCode.TabStateName  ==  _AttributeName[intIndex])
{
return mstrTabStateName;
}
else if (convPrjTab4GeneCode.TabNameB  ==  _AttributeName[intIndex])
{
return mstrTabNameB;
}
else if (convPrjTab4GeneCode.IsParaTab  ==  _AttributeName[intIndex])
{
return mbolIsParaTab;
}
else if (convPrjTab4GeneCode.IsNationStandard  ==  _AttributeName[intIndex])
{
return mbolIsNationStandard;
}
else if (convPrjTab4GeneCode.IsArchive  ==  _AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (convPrjTab4GeneCode.IsChecked  ==  _AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convPrjTab4GeneCode.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convPrjTab4GeneCode.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convPrjTab4GeneCode.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convPrjTab4GeneCode.Owner  ==  _AttributeName[intIndex])
{
return mstrOwner;
}
else if (convPrjTab4GeneCode.IsReleToSqlTab  ==  _AttributeName[intIndex])
{
return mbolIsReleToSqlTab;
}
else if (convPrjTab4GeneCode.Keyword  ==  _AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPrjTab4GeneCode.TabTypeId  ==  _AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (convPrjTab4GeneCode.TabTypeName  ==  _AttributeName[intIndex])
{
return mstrTabTypeName;
}
else if (convPrjTab4GeneCode.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (convPrjTab4GeneCode.TabMainTypeName  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeName;
}
else if (convPrjTab4GeneCode.RelaTabId4View  ==  _AttributeName[intIndex])
{
return mstrRelaTabId4View;
}
else if (convPrjTab4GeneCode.OrderNum4Refer  ==  _AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (convPrjTab4GeneCode.IsNeedGeneIndexer  ==  _AttributeName[intIndex])
{
return mbolIsNeedGeneIndexer;
}
else if (convPrjTab4GeneCode.IsUseCache  ==  _AttributeName[intIndex])
{
return mbolIsUseCache;
}
else if (convPrjTab4GeneCode.CacheClassifyField  ==  _AttributeName[intIndex])
{
return mstrCacheClassifyField;
}
else if (convPrjTab4GeneCode.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convPrjTab4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjTab4GeneCode.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPrjTab4GeneCode.ErrMsg2  ==  _AttributeName[intIndex])
{
return mstrErrMsg2;
}
else if (convPrjTab4GeneCode.DataBaseNameTab  ==  _AttributeName[intIndex])
{
return mstrDataBaseNameTab;
}
else if (convPrjTab4GeneCode.UserId4GeneCode  ==  _AttributeName[intIndex])
{
return mstrUserId4GeneCode;
}
return null;
}
set
{
if (convPrjTab4GeneCode.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabId);
}
else if (convPrjTab4GeneCode.FldNum  ==  _AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.FldNum);
}
else if (convPrjTab4GeneCode.GeneCodeDate  ==  _AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.GeneCodeDate);
}
else if (convPrjTab4GeneCode.IsNeedGene  ==  _AttributeName[intIndex])
{
mbolIsNeedGene = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedGene);
}
else if (convPrjTab4GeneCode.VersionGeneCode  ==  _AttributeName[intIndex])
{
mstrVersionGeneCode = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.VersionGeneCode);
}
else if (convPrjTab4GeneCode.ApplicationTypeId  ==  _AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.ApplicationTypeId);
}
else if (convPrjTab4GeneCode.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabName);
}
else if (convPrjTab4GeneCode.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabCnName);
}
else if (convPrjTab4GeneCode.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.PrjId);
}
else if (convPrjTab4GeneCode.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.PrjName);
}
else if (convPrjTab4GeneCode.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedTransCode);
}
else if (convPrjTab4GeneCode.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.SqlDsTypeId);
}
else if (convPrjTab4GeneCode.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.SqlDsTypeName);
}
else if (convPrjTab4GeneCode.TabStateId  ==  _AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabStateId);
}
else if (convPrjTab4GeneCode.TabStateName  ==  _AttributeName[intIndex])
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabStateName);
}
else if (convPrjTab4GeneCode.TabNameB  ==  _AttributeName[intIndex])
{
mstrTabNameB = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabNameB);
}
else if (convPrjTab4GeneCode.IsParaTab  ==  _AttributeName[intIndex])
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsParaTab);
}
else if (convPrjTab4GeneCode.IsNationStandard  ==  _AttributeName[intIndex])
{
mbolIsNationStandard = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNationStandard);
}
else if (convPrjTab4GeneCode.IsArchive  ==  _AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsArchive);
}
else if (convPrjTab4GeneCode.IsChecked  ==  _AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsChecked);
}
else if (convPrjTab4GeneCode.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleAgcId);
}
else if (convPrjTab4GeneCode.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleName);
}
else if (convPrjTab4GeneCode.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleEnName);
}
else if (convPrjTab4GeneCode.Owner  ==  _AttributeName[intIndex])
{
mstrOwner = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.Owner);
}
else if (convPrjTab4GeneCode.IsReleToSqlTab  ==  _AttributeName[intIndex])
{
mbolIsReleToSqlTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsReleToSqlTab);
}
else if (convPrjTab4GeneCode.Keyword  ==  _AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.Keyword);
}
else if (convPrjTab4GeneCode.TabTypeId  ==  _AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabTypeId);
}
else if (convPrjTab4GeneCode.TabTypeName  ==  _AttributeName[intIndex])
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabTypeName);
}
else if (convPrjTab4GeneCode.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabMainTypeId);
}
else if (convPrjTab4GeneCode.TabMainTypeName  ==  _AttributeName[intIndex])
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.TabMainTypeName);
}
else if (convPrjTab4GeneCode.RelaTabId4View  ==  _AttributeName[intIndex])
{
mstrRelaTabId4View = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.RelaTabId4View);
}
else if (convPrjTab4GeneCode.OrderNum4Refer  ==  _AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.OrderNum4Refer);
}
else if (convPrjTab4GeneCode.IsNeedGeneIndexer  ==  _AttributeName[intIndex])
{
mbolIsNeedGeneIndexer = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedGeneIndexer);
}
else if (convPrjTab4GeneCode.IsUseCache  ==  _AttributeName[intIndex])
{
mbolIsUseCache = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab4GeneCode.IsUseCache);
}
else if (convPrjTab4GeneCode.CacheClassifyField  ==  _AttributeName[intIndex])
{
mstrCacheClassifyField = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.CacheClassifyField);
}
else if (convPrjTab4GeneCode.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.UpdUserId);
}
else if (convPrjTab4GeneCode.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.UpdDate);
}
else if (convPrjTab4GeneCode.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.Memo);
}
else if (convPrjTab4GeneCode.ErrMsg2  ==  _AttributeName[intIndex])
{
mstrErrMsg2 = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.ErrMsg2);
}
else if (convPrjTab4GeneCode.DataBaseNameTab  ==  _AttributeName[intIndex])
{
mstrDataBaseNameTab = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.DataBaseNameTab);
}
else if (convPrjTab4GeneCode.UserId4GeneCode  ==  _AttributeName[intIndex])
{
mstrUserId4GeneCode = value.ToString();
 AddUpdatedFld(convPrjTab4GeneCode.UserId4GeneCode);
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
 AddUpdatedFld(convPrjTab4GeneCode.TabId);
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
 AddUpdatedFld(convPrjTab4GeneCode.FldNum);
}
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GeneCodeDate
{
get
{
return mstrGeneCodeDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGeneCodeDate = value;
}
else
{
 mstrGeneCodeDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.GeneCodeDate);
}
}
/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGene
{
get
{
return mbolIsNeedGene;
}
set
{
 mbolIsNeedGene = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedGene);
}
}
/// <summary>
/// 生成代码版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionGeneCode
{
get
{
return mstrVersionGeneCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionGeneCode = value;
}
else
{
 mstrVersionGeneCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.VersionGeneCode);
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
 AddUpdatedFld(convPrjTab4GeneCode.ApplicationTypeId);
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
 AddUpdatedFld(convPrjTab4GeneCode.TabName);
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
 AddUpdatedFld(convPrjTab4GeneCode.TabCnName);
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
 AddUpdatedFld(convPrjTab4GeneCode.PrjId);
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
 AddUpdatedFld(convPrjTab4GeneCode.PrjName);
}
}
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedTransCode
{
get
{
return mbolIsNeedTransCode;
}
set
{
 mbolIsNeedTransCode = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedTransCode);
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
 AddUpdatedFld(convPrjTab4GeneCode.SqlDsTypeId);
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
 AddUpdatedFld(convPrjTab4GeneCode.SqlDsTypeName);
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
 AddUpdatedFld(convPrjTab4GeneCode.TabStateId);
}
}
/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateName
{
get
{
return mstrTabStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateName = value;
}
else
{
 mstrTabStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.TabStateName);
}
}
/// <summary>
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabNameB
{
get
{
return mstrTabNameB;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabNameB = value;
}
else
{
 mstrTabNameB = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.TabNameB);
}
}
/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsParaTab
{
get
{
return mbolIsParaTab;
}
set
{
 mbolIsParaTab = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsParaTab);
}
}
/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNationStandard
{
get
{
return mbolIsNationStandard;
}
set
{
 mbolIsNationStandard = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsNationStandard);
}
}
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsArchive
{
get
{
return mbolIsArchive;
}
set
{
 mbolIsArchive = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsArchive);
}
}
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsChecked
{
get
{
return mbolIsChecked;
}
set
{
 mbolIsChecked = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsChecked);
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
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleAgcId);
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
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleName);
}
}
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.FuncModuleEnName);
}
}
/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Owner
{
get
{
return mstrOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwner = value;
}
else
{
 mstrOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.Owner);
}
}
/// <summary>
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReleToSqlTab
{
get
{
return mbolIsReleToSqlTab;
}
set
{
 mbolIsReleToSqlTab = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsReleToSqlTab);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.Keyword);
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
 AddUpdatedFld(convPrjTab4GeneCode.TabTypeId);
}
}
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeName
{
get
{
return mstrTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeName = value;
}
else
{
 mstrTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.TabTypeName);
}
}
/// <summary>
/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeId
{
get
{
return mstrTabMainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeId = value;
}
else
{
 mstrTabMainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.TabMainTypeId);
}
}
/// <summary>
/// 表主类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeName
{
get
{
return mstrTabMainTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeName = value;
}
else
{
 mstrTabMainTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.TabMainTypeName);
}
}
/// <summary>
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabId4View
{
get
{
return mstrRelaTabId4View;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabId4View = value;
}
else
{
 mstrRelaTabId4View = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.RelaTabId4View);
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
 AddUpdatedFld(convPrjTab4GeneCode.OrderNum4Refer);
}
}
/// <summary>
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGeneIndexer
{
get
{
return mbolIsNeedGeneIndexer;
}
set
{
 mbolIsNeedGeneIndexer = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsNeedGeneIndexer);
}
}
/// <summary>
/// 是否使用Cache(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseCache
{
get
{
return mbolIsUseCache;
}
set
{
 mbolIsUseCache = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.IsUseCache);
}
}
/// <summary>
/// 缓存分类字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheClassifyField
{
get
{
return mstrCacheClassifyField;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheClassifyField = value;
}
else
{
 mstrCacheClassifyField = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.CacheClassifyField);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.UpdUserId);
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
 AddUpdatedFld(convPrjTab4GeneCode.UpdDate);
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
 AddUpdatedFld(convPrjTab4GeneCode.Memo);
}
}
/// <summary>
/// ErrMsg2(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg2
{
get
{
return mstrErrMsg2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg2 = value;
}
else
{
 mstrErrMsg2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.ErrMsg2);
}
}
/// <summary>
/// DataBaseName_Tab(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseNameTab
{
get
{
return mstrDataBaseNameTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseNameTab = value;
}
else
{
 mstrDataBaseNameTab = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.DataBaseNameTab);
}
}
/// <summary>
/// UserId4GeneCode(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId4GeneCode
{
get
{
return mstrUserId4GeneCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId4GeneCode = value;
}
else
{
 mstrUserId4GeneCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab4GeneCode.UserId4GeneCode);
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
 /// vPrjTab4GeneCode(vPrjTab4GeneCode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTab4GeneCode
{
public const string _CurrTabName = "vPrjTab4GeneCode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "FldNum", "GeneCodeDate", "IsNeedGene", "VersionGeneCode", "ApplicationTypeId", "TabName", "TabCnName", "PrjId", "PrjName", "IsNeedTransCode", "SqlDsTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "TabNameB", "IsParaTab", "IsNationStandard", "IsArchive", "IsChecked", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "IsReleToSqlTab", "Keyword", "TabTypeId", "TabTypeName", "TabMainTypeId", "TabMainTypeName", "RelaTabId4View", "OrderNum4Refer", "IsNeedGeneIndexer", "IsUseCache", "CacheClassifyField", "UpdUserId", "UpdDate", "Memo", "ErrMsg2", "DataBaseNameTab", "UserId4GeneCode"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldNum = "FldNum";    //字段数

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"IsNeedGene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGene = "IsNeedGene";    //是否需要生成

 /// <summary>
 /// 常量:"VersionGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionGeneCode = "VersionGeneCode";    //生成代码版本

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

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
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"TabStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateName = "TabStateName";    //表状态名称

 /// <summary>
 /// 常量:"TabNameB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNameB = "TabNameB";    //表名_后备

 /// <summary>
 /// 常量:"IsParaTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsParaTab = "IsParaTab";    //是否参数表

 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNationStandard = "IsNationStandard";    //是否国标

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsArchive = "IsArchive";    //是否存档

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否核实

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
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

 /// <summary>
 /// 常量:"Owner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Owner = "Owner";    //拥有者

 /// <summary>
 /// 常量:"IsReleToSqlTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReleToSqlTab = "IsReleToSqlTab";    //是否与SQL表相关

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"TabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeName = "TabTypeName";    //表类型名

 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeId = "TabMainTypeId";    //表主类型Id

 /// <summary>
 /// 常量:"TabMainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeName = "TabMainTypeName";    //表主类型名

 /// <summary>
 /// 常量:"RelaTabId4View"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId4View = "RelaTabId4View";    //视图的相关表ID

 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum4Refer = "OrderNum4Refer";    //引用序号

 /// <summary>
 /// 常量:"IsNeedGeneIndexer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGeneIndexer = "IsNeedGeneIndexer";    //是否需要生成索引器

 /// <summary>
 /// 常量:"IsUseCache"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseCache = "IsUseCache";    //是否使用Cache

 /// <summary>
 /// 常量:"CacheClassifyField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheClassifyField = "CacheClassifyField";    //缓存分类字段

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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
 /// 常量:"ErrMsg2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg2 = "ErrMsg2";    //ErrMsg2

 /// <summary>
 /// 常量:"DataBaseNameTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseNameTab = "DataBaseNameTab";    //DataBaseName_Tab

 /// <summary>
 /// 常量:"UserId4GeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId4GeneCode = "UserId4GeneCode";    //UserId4GeneCode
}

}