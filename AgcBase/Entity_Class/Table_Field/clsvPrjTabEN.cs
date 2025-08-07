
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabEN
 表名:vPrjTab(00050124)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:17
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
 /// 表vPrjTab的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vPrjTab
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
public K_TabId_vPrjTab(string strTabId)
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
 /// <returns>返回:[K_TabId_vPrjTab]类型的对象</returns>
public static implicit operator K_TabId_vPrjTab(string value)
{
return new K_TabId_vPrjTab(value);
}
}
 /// <summary>
 /// v工程表(vPrjTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPrjTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 44;
public static string[] _AttributeName = new string[] {"TabId", "TabName", "TabCnName", "PrjId", "SqlDsTypeId", "TabStateId", "FuncModuleAgcId", "FuncModuleEnName", "IsReleToSqlTab", "Keyword", "TabTypeId", "TabMainTypeId", "RelaTabId4View", "IsNeedGeneIndexer", "ParentClass", "IsUseCache", "IsShare", "CacheClassifyField", "CacheModeId", "IsRefresh4RelaView", "TabRecNum", "ErrMsg", "UpdUserId", "UpdDate", "Memo", "OrderNum4Refer", "FuncModuleName", "FldNum", "SqlDsTypeName", "TabStateName", "TabMainTypeName", "TabTypeName", "RelaTabName4View", "PrjName", "IsChecked", "Owner", "TabEnName", "IsNeedTransCode", "TabNameB", "IsNationStandard", "IsParaTab", "IsArchive", "UpdDate2", "DataBaseNameTab"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrPrjId;    //工程Id
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrTabStateId;    //表状态ID
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleEnName;    //功能模块英文名称
protected bool mbolIsReleToSqlTab;    //是否与SQL表相关
protected string mstrKeyword;    //关键字
protected string mstrTabTypeId;    //表类型Id
protected string mstrTabMainTypeId;    //表主类型Id
protected string mstrRelaTabId4View;    //视图的相关表ID
protected bool mbolIsNeedGeneIndexer;    //是否需要生成索引器
protected string mstrParentClass;    //父类
protected bool mbolIsUseCache;    //是否使用Cache
protected bool mbolIsShare;    //是否共享
protected string mstrCacheClassifyField;    //缓存分类字段
protected string mstrCacheModeId;    //缓存方式Id
protected bool mbolIsRefresh4RelaView;    //是否刷新相关视图
protected int? mintTabRecNum;    //记录数
protected string mstrErrMsg;    //错误信息
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected int? mintOrderNum4Refer;    //引用序号
protected string mstrFuncModuleName;    //功能模块名称
protected int? mintFldNum;    //字段数
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrTabStateName;    //表状态名称
protected string mstrTabMainTypeName;    //表主类型名
protected string mstrTabTypeName;    //表类型名
protected string mstrRelaTabName4View;    //RelaTabName4View
protected string mstrPrjName;    //工程名称
protected bool mbolIsChecked;    //是否核实
protected string mstrOwner;    //拥有者
protected string mstrTabEnName;    //表英文详细名
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected string mstrTabNameB;    //表名_后备
protected bool mbolIsNationStandard;    //是否国标
protected bool mbolIsParaTab;    //是否参数表
protected bool mbolIsArchive;    //是否存档
protected string mstrUpdDate2;    //UpdDate2
protected string mstrDataBaseNameTab;    //DataBaseName_Tab

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsvPrjTabEN()
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
public clsvPrjTabEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vPrjTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vPrjTab中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convPrjTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convPrjTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convPrjTab.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convPrjTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPrjTab.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convPrjTab.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convPrjTab.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convPrjTab.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convPrjTab.IsReleToSqlTab)
{
return mbolIsReleToSqlTab;
}
else if (strAttributeName  ==  convPrjTab.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPrjTab.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  convPrjTab.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  convPrjTab.RelaTabId4View)
{
return mstrRelaTabId4View;
}
else if (strAttributeName  ==  convPrjTab.IsNeedGeneIndexer)
{
return mbolIsNeedGeneIndexer;
}
else if (strAttributeName  ==  convPrjTab.ParentClass)
{
return mstrParentClass;
}
else if (strAttributeName  ==  convPrjTab.IsUseCache)
{
return mbolIsUseCache;
}
else if (strAttributeName  ==  convPrjTab.IsShare)
{
return mbolIsShare;
}
else if (strAttributeName  ==  convPrjTab.CacheClassifyField)
{
return mstrCacheClassifyField;
}
else if (strAttributeName  ==  convPrjTab.CacheModeId)
{
return mstrCacheModeId;
}
else if (strAttributeName  ==  convPrjTab.IsRefresh4RelaView)
{
return mbolIsRefresh4RelaView;
}
else if (strAttributeName  ==  convPrjTab.TabRecNum)
{
return mintTabRecNum;
}
else if (strAttributeName  ==  convPrjTab.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  convPrjTab.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convPrjTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPrjTab.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPrjTab.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  convPrjTab.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convPrjTab.FldNum)
{
return mintFldNum;
}
else if (strAttributeName  ==  convPrjTab.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convPrjTab.TabStateName)
{
return mstrTabStateName;
}
else if (strAttributeName  ==  convPrjTab.TabMainTypeName)
{
return mstrTabMainTypeName;
}
else if (strAttributeName  ==  convPrjTab.TabTypeName)
{
return mstrTabTypeName;
}
else if (strAttributeName  ==  convPrjTab.RelaTabName4View)
{
return mstrRelaTabName4View;
}
else if (strAttributeName  ==  convPrjTab.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convPrjTab.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convPrjTab.Owner)
{
return mstrOwner;
}
else if (strAttributeName  ==  convPrjTab.TabEnName)
{
return mstrTabEnName;
}
else if (strAttributeName  ==  convPrjTab.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  convPrjTab.TabNameB)
{
return mstrTabNameB;
}
else if (strAttributeName  ==  convPrjTab.IsNationStandard)
{
return mbolIsNationStandard;
}
else if (strAttributeName  ==  convPrjTab.IsParaTab)
{
return mbolIsParaTab;
}
else if (strAttributeName  ==  convPrjTab.IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  convPrjTab.UpdDate2)
{
return mstrUpdDate2;
}
else if (strAttributeName  ==  convPrjTab.DataBaseNameTab)
{
return mstrDataBaseNameTab;
}
return null;
}
set
{
if (strAttributeName  ==  convPrjTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab.TabId);
}
else if (strAttributeName  ==  convPrjTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab.TabName);
}
else if (strAttributeName  ==  convPrjTab.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjTab.TabCnName);
}
else if (strAttributeName  ==  convPrjTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab.PrjId);
}
else if (strAttributeName  ==  convPrjTab.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab.SqlDsTypeId);
}
else if (strAttributeName  ==  convPrjTab.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab.TabStateId);
}
else if (strAttributeName  ==  convPrjTab.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab.FuncModuleAgcId);
}
else if (strAttributeName  ==  convPrjTab.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convPrjTab.FuncModuleEnName);
}
else if (strAttributeName  ==  convPrjTab.IsReleToSqlTab)
{
mbolIsReleToSqlTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsReleToSqlTab);
}
else if (strAttributeName  ==  convPrjTab.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPrjTab.Keyword);
}
else if (strAttributeName  ==  convPrjTab.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab.TabTypeId);
}
else if (strAttributeName  ==  convPrjTab.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convPrjTab.TabMainTypeId);
}
else if (strAttributeName  ==  convPrjTab.RelaTabId4View)
{
mstrRelaTabId4View = value.ToString();
 AddUpdatedFld(convPrjTab.RelaTabId4View);
}
else if (strAttributeName  ==  convPrjTab.IsNeedGeneIndexer)
{
mbolIsNeedGeneIndexer = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsNeedGeneIndexer);
}
else if (strAttributeName  ==  convPrjTab.ParentClass)
{
mstrParentClass = value.ToString();
 AddUpdatedFld(convPrjTab.ParentClass);
}
else if (strAttributeName  ==  convPrjTab.IsUseCache)
{
mbolIsUseCache = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsUseCache);
}
else if (strAttributeName  ==  convPrjTab.IsShare)
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsShare);
}
else if (strAttributeName  ==  convPrjTab.CacheClassifyField)
{
mstrCacheClassifyField = value.ToString();
 AddUpdatedFld(convPrjTab.CacheClassifyField);
}
else if (strAttributeName  ==  convPrjTab.CacheModeId)
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convPrjTab.CacheModeId);
}
else if (strAttributeName  ==  convPrjTab.IsRefresh4RelaView)
{
mbolIsRefresh4RelaView = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsRefresh4RelaView);
}
else if (strAttributeName  ==  convPrjTab.TabRecNum)
{
mintTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab.TabRecNum);
}
else if (strAttributeName  ==  convPrjTab.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convPrjTab.ErrMsg);
}
else if (strAttributeName  ==  convPrjTab.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPrjTab.UpdUserId);
}
else if (strAttributeName  ==  convPrjTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjTab.UpdDate);
}
else if (strAttributeName  ==  convPrjTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjTab.Memo);
}
else if (strAttributeName  ==  convPrjTab.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab.OrderNum4Refer);
}
else if (strAttributeName  ==  convPrjTab.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convPrjTab.FuncModuleName);
}
else if (strAttributeName  ==  convPrjTab.FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab.FldNum);
}
else if (strAttributeName  ==  convPrjTab.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convPrjTab.SqlDsTypeName);
}
else if (strAttributeName  ==  convPrjTab.TabStateName)
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(convPrjTab.TabStateName);
}
else if (strAttributeName  ==  convPrjTab.TabMainTypeName)
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convPrjTab.TabMainTypeName);
}
else if (strAttributeName  ==  convPrjTab.TabTypeName)
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convPrjTab.TabTypeName);
}
else if (strAttributeName  ==  convPrjTab.RelaTabName4View)
{
mstrRelaTabName4View = value.ToString();
 AddUpdatedFld(convPrjTab.RelaTabName4View);
}
else if (strAttributeName  ==  convPrjTab.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjTab.PrjName);
}
else if (strAttributeName  ==  convPrjTab.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsChecked);
}
else if (strAttributeName  ==  convPrjTab.Owner)
{
mstrOwner = value.ToString();
 AddUpdatedFld(convPrjTab.Owner);
}
else if (strAttributeName  ==  convPrjTab.TabEnName)
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(convPrjTab.TabEnName);
}
else if (strAttributeName  ==  convPrjTab.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsNeedTransCode);
}
else if (strAttributeName  ==  convPrjTab.TabNameB)
{
mstrTabNameB = value.ToString();
 AddUpdatedFld(convPrjTab.TabNameB);
}
else if (strAttributeName  ==  convPrjTab.IsNationStandard)
{
mbolIsNationStandard = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsNationStandard);
}
else if (strAttributeName  ==  convPrjTab.IsParaTab)
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsParaTab);
}
else if (strAttributeName  ==  convPrjTab.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsArchive);
}
else if (strAttributeName  ==  convPrjTab.UpdDate2)
{
mstrUpdDate2 = value.ToString();
 AddUpdatedFld(convPrjTab.UpdDate2);
}
else if (strAttributeName  ==  convPrjTab.DataBaseNameTab)
{
mstrDataBaseNameTab = value.ToString();
 AddUpdatedFld(convPrjTab.DataBaseNameTab);
}
}
}
public object this[int intIndex]
{
get
{
if (convPrjTab.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (convPrjTab.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (convPrjTab.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convPrjTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPrjTab.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convPrjTab.TabStateId  ==  _AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convPrjTab.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convPrjTab.FuncModuleEnName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convPrjTab.IsReleToSqlTab  ==  _AttributeName[intIndex])
{
return mbolIsReleToSqlTab;
}
else if (convPrjTab.Keyword  ==  _AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPrjTab.TabTypeId  ==  _AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (convPrjTab.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (convPrjTab.RelaTabId4View  ==  _AttributeName[intIndex])
{
return mstrRelaTabId4View;
}
else if (convPrjTab.IsNeedGeneIndexer  ==  _AttributeName[intIndex])
{
return mbolIsNeedGeneIndexer;
}
else if (convPrjTab.ParentClass  ==  _AttributeName[intIndex])
{
return mstrParentClass;
}
else if (convPrjTab.IsUseCache  ==  _AttributeName[intIndex])
{
return mbolIsUseCache;
}
else if (convPrjTab.IsShare  ==  _AttributeName[intIndex])
{
return mbolIsShare;
}
else if (convPrjTab.CacheClassifyField  ==  _AttributeName[intIndex])
{
return mstrCacheClassifyField;
}
else if (convPrjTab.CacheModeId  ==  _AttributeName[intIndex])
{
return mstrCacheModeId;
}
else if (convPrjTab.IsRefresh4RelaView  ==  _AttributeName[intIndex])
{
return mbolIsRefresh4RelaView;
}
else if (convPrjTab.TabRecNum  ==  _AttributeName[intIndex])
{
return mintTabRecNum;
}
else if (convPrjTab.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (convPrjTab.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convPrjTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPrjTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPrjTab.OrderNum4Refer  ==  _AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (convPrjTab.FuncModuleName  ==  _AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convPrjTab.FldNum  ==  _AttributeName[intIndex])
{
return mintFldNum;
}
else if (convPrjTab.SqlDsTypeName  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convPrjTab.TabStateName  ==  _AttributeName[intIndex])
{
return mstrTabStateName;
}
else if (convPrjTab.TabMainTypeName  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeName;
}
else if (convPrjTab.TabTypeName  ==  _AttributeName[intIndex])
{
return mstrTabTypeName;
}
else if (convPrjTab.RelaTabName4View  ==  _AttributeName[intIndex])
{
return mstrRelaTabName4View;
}
else if (convPrjTab.PrjName  ==  _AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convPrjTab.IsChecked  ==  _AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convPrjTab.Owner  ==  _AttributeName[intIndex])
{
return mstrOwner;
}
else if (convPrjTab.TabEnName  ==  _AttributeName[intIndex])
{
return mstrTabEnName;
}
else if (convPrjTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (convPrjTab.TabNameB  ==  _AttributeName[intIndex])
{
return mstrTabNameB;
}
else if (convPrjTab.IsNationStandard  ==  _AttributeName[intIndex])
{
return mbolIsNationStandard;
}
else if (convPrjTab.IsParaTab  ==  _AttributeName[intIndex])
{
return mbolIsParaTab;
}
else if (convPrjTab.IsArchive  ==  _AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (convPrjTab.UpdDate2  ==  _AttributeName[intIndex])
{
return mstrUpdDate2;
}
else if (convPrjTab.DataBaseNameTab  ==  _AttributeName[intIndex])
{
return mstrDataBaseNameTab;
}
return null;
}
set
{
if (convPrjTab.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convPrjTab.TabId);
}
else if (convPrjTab.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convPrjTab.TabName);
}
else if (convPrjTab.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convPrjTab.TabCnName);
}
else if (convPrjTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPrjTab.PrjId);
}
else if (convPrjTab.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convPrjTab.SqlDsTypeId);
}
else if (convPrjTab.TabStateId  ==  _AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convPrjTab.TabStateId);
}
else if (convPrjTab.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convPrjTab.FuncModuleAgcId);
}
else if (convPrjTab.FuncModuleEnName  ==  _AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convPrjTab.FuncModuleEnName);
}
else if (convPrjTab.IsReleToSqlTab  ==  _AttributeName[intIndex])
{
mbolIsReleToSqlTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsReleToSqlTab);
}
else if (convPrjTab.Keyword  ==  _AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPrjTab.Keyword);
}
else if (convPrjTab.TabTypeId  ==  _AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convPrjTab.TabTypeId);
}
else if (convPrjTab.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(convPrjTab.TabMainTypeId);
}
else if (convPrjTab.RelaTabId4View  ==  _AttributeName[intIndex])
{
mstrRelaTabId4View = value.ToString();
 AddUpdatedFld(convPrjTab.RelaTabId4View);
}
else if (convPrjTab.IsNeedGeneIndexer  ==  _AttributeName[intIndex])
{
mbolIsNeedGeneIndexer = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsNeedGeneIndexer);
}
else if (convPrjTab.ParentClass  ==  _AttributeName[intIndex])
{
mstrParentClass = value.ToString();
 AddUpdatedFld(convPrjTab.ParentClass);
}
else if (convPrjTab.IsUseCache  ==  _AttributeName[intIndex])
{
mbolIsUseCache = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsUseCache);
}
else if (convPrjTab.IsShare  ==  _AttributeName[intIndex])
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsShare);
}
else if (convPrjTab.CacheClassifyField  ==  _AttributeName[intIndex])
{
mstrCacheClassifyField = value.ToString();
 AddUpdatedFld(convPrjTab.CacheClassifyField);
}
else if (convPrjTab.CacheModeId  ==  _AttributeName[intIndex])
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(convPrjTab.CacheModeId);
}
else if (convPrjTab.IsRefresh4RelaView  ==  _AttributeName[intIndex])
{
mbolIsRefresh4RelaView = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsRefresh4RelaView);
}
else if (convPrjTab.TabRecNum  ==  _AttributeName[intIndex])
{
mintTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab.TabRecNum);
}
else if (convPrjTab.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convPrjTab.ErrMsg);
}
else if (convPrjTab.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convPrjTab.UpdUserId);
}
else if (convPrjTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPrjTab.UpdDate);
}
else if (convPrjTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPrjTab.Memo);
}
else if (convPrjTab.OrderNum4Refer  ==  _AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab.OrderNum4Refer);
}
else if (convPrjTab.FuncModuleName  ==  _AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convPrjTab.FuncModuleName);
}
else if (convPrjTab.FldNum  ==  _AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPrjTab.FldNum);
}
else if (convPrjTab.SqlDsTypeName  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convPrjTab.SqlDsTypeName);
}
else if (convPrjTab.TabStateName  ==  _AttributeName[intIndex])
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(convPrjTab.TabStateName);
}
else if (convPrjTab.TabMainTypeName  ==  _AttributeName[intIndex])
{
mstrTabMainTypeName = value.ToString();
 AddUpdatedFld(convPrjTab.TabMainTypeName);
}
else if (convPrjTab.TabTypeName  ==  _AttributeName[intIndex])
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convPrjTab.TabTypeName);
}
else if (convPrjTab.RelaTabName4View  ==  _AttributeName[intIndex])
{
mstrRelaTabName4View = value.ToString();
 AddUpdatedFld(convPrjTab.RelaTabName4View);
}
else if (convPrjTab.PrjName  ==  _AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convPrjTab.PrjName);
}
else if (convPrjTab.IsChecked  ==  _AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsChecked);
}
else if (convPrjTab.Owner  ==  _AttributeName[intIndex])
{
mstrOwner = value.ToString();
 AddUpdatedFld(convPrjTab.Owner);
}
else if (convPrjTab.TabEnName  ==  _AttributeName[intIndex])
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(convPrjTab.TabEnName);
}
else if (convPrjTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsNeedTransCode);
}
else if (convPrjTab.TabNameB  ==  _AttributeName[intIndex])
{
mstrTabNameB = value.ToString();
 AddUpdatedFld(convPrjTab.TabNameB);
}
else if (convPrjTab.IsNationStandard  ==  _AttributeName[intIndex])
{
mbolIsNationStandard = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsNationStandard);
}
else if (convPrjTab.IsParaTab  ==  _AttributeName[intIndex])
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsParaTab);
}
else if (convPrjTab.IsArchive  ==  _AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(convPrjTab.IsArchive);
}
else if (convPrjTab.UpdDate2  ==  _AttributeName[intIndex])
{
mstrUpdDate2 = value.ToString();
 AddUpdatedFld(convPrjTab.UpdDate2);
}
else if (convPrjTab.DataBaseNameTab  ==  _AttributeName[intIndex])
{
mstrDataBaseNameTab = value.ToString();
 AddUpdatedFld(convPrjTab.DataBaseNameTab);
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
 AddUpdatedFld(convPrjTab.TabId);
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
 AddUpdatedFld(convPrjTab.TabName);
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
 AddUpdatedFld(convPrjTab.TabCnName);
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
 AddUpdatedFld(convPrjTab.PrjId);
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
 AddUpdatedFld(convPrjTab.SqlDsTypeId);
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
 AddUpdatedFld(convPrjTab.TabStateId);
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
 AddUpdatedFld(convPrjTab.FuncModuleAgcId);
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
 AddUpdatedFld(convPrjTab.FuncModuleEnName);
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
 AddUpdatedFld(convPrjTab.IsReleToSqlTab);
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
 AddUpdatedFld(convPrjTab.Keyword);
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
 AddUpdatedFld(convPrjTab.TabTypeId);
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
 AddUpdatedFld(convPrjTab.TabMainTypeId);
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
 AddUpdatedFld(convPrjTab.RelaTabId4View);
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
 AddUpdatedFld(convPrjTab.IsNeedGeneIndexer);
}
}
/// <summary>
/// 父类(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentClass
{
get
{
return mstrParentClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentClass = value;
}
else
{
 mstrParentClass = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab.ParentClass);
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
 AddUpdatedFld(convPrjTab.IsUseCache);
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
 AddUpdatedFld(convPrjTab.IsShare);
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
 AddUpdatedFld(convPrjTab.CacheClassifyField);
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
 AddUpdatedFld(convPrjTab.CacheModeId);
}
}
/// <summary>
/// 是否刷新相关视图(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRefresh4RelaView
{
get
{
return mbolIsRefresh4RelaView;
}
set
{
 mbolIsRefresh4RelaView = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab.IsRefresh4RelaView);
}
}
/// <summary>
/// 记录数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TabRecNum
{
get
{
return mintTabRecNum;
}
set
{
 mintTabRecNum = value;
//记录修改过的字段
 AddUpdatedFld(convPrjTab.TabRecNum);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab.ErrMsg);
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
 AddUpdatedFld(convPrjTab.UpdUserId);
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
 AddUpdatedFld(convPrjTab.UpdDate);
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
 AddUpdatedFld(convPrjTab.Memo);
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
 AddUpdatedFld(convPrjTab.OrderNum4Refer);
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
 AddUpdatedFld(convPrjTab.FuncModuleName);
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
 AddUpdatedFld(convPrjTab.FldNum);
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
 AddUpdatedFld(convPrjTab.SqlDsTypeName);
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
 AddUpdatedFld(convPrjTab.TabStateName);
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
 AddUpdatedFld(convPrjTab.TabMainTypeName);
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
 AddUpdatedFld(convPrjTab.TabTypeName);
}
}
/// <summary>
/// RelaTabName4View(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabName4View
{
get
{
return mstrRelaTabName4View;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabName4View = value;
}
else
{
 mstrRelaTabName4View = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab.RelaTabName4View);
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
 AddUpdatedFld(convPrjTab.PrjName);
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
 AddUpdatedFld(convPrjTab.IsChecked);
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
 AddUpdatedFld(convPrjTab.Owner);
}
}
/// <summary>
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabEnName
{
get
{
return mstrTabEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabEnName = value;
}
else
{
 mstrTabEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab.TabEnName);
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
 AddUpdatedFld(convPrjTab.IsNeedTransCode);
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
 AddUpdatedFld(convPrjTab.TabNameB);
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
 AddUpdatedFld(convPrjTab.IsNationStandard);
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
 AddUpdatedFld(convPrjTab.IsParaTab);
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
 AddUpdatedFld(convPrjTab.IsArchive);
}
}
/// <summary>
/// UpdDate2(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate2
{
get
{
return mstrUpdDate2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate2 = value;
}
else
{
 mstrUpdDate2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convPrjTab.UpdDate2);
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
 AddUpdatedFld(convPrjTab.DataBaseNameTab);
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
}
 /// <summary>
 /// v工程表(vPrjTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPrjTab
{
public const string _CurrTabName = "vPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "TabName", "TabCnName", "PrjId", "SqlDsTypeId", "TabStateId", "FuncModuleAgcId", "FuncModuleEnName", "IsReleToSqlTab", "Keyword", "TabTypeId", "TabMainTypeId", "RelaTabId4View", "IsNeedGeneIndexer", "ParentClass", "IsUseCache", "IsShare", "CacheClassifyField", "CacheModeId", "IsRefresh4RelaView", "TabRecNum", "ErrMsg", "UpdUserId", "UpdDate", "Memo", "OrderNum4Refer", "FuncModuleName", "FldNum", "SqlDsTypeName", "TabStateName", "TabMainTypeName", "TabTypeName", "RelaTabName4View", "PrjName", "IsChecked", "Owner", "TabEnName", "IsNeedTransCode", "TabNameB", "IsNationStandard", "IsParaTab", "IsArchive", "UpdDate2", "DataBaseNameTab"};
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
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

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
 /// 常量:"TabMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeId = "TabMainTypeId";    //表主类型Id

 /// <summary>
 /// 常量:"RelaTabId4View"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId4View = "RelaTabId4View";    //视图的相关表ID

 /// <summary>
 /// 常量:"IsNeedGeneIndexer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGeneIndexer = "IsNeedGeneIndexer";    //是否需要生成索引器

 /// <summary>
 /// 常量:"ParentClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentClass = "ParentClass";    //父类

 /// <summary>
 /// 常量:"IsUseCache"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseCache = "IsUseCache";    //是否使用Cache

 /// <summary>
 /// 常量:"IsShare"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShare = "IsShare";    //是否共享

 /// <summary>
 /// 常量:"CacheClassifyField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheClassifyField = "CacheClassifyField";    //缓存分类字段

 /// <summary>
 /// 常量:"CacheModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheModeId = "CacheModeId";    //缓存方式Id

 /// <summary>
 /// 常量:"IsRefresh4RelaView"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRefresh4RelaView = "IsRefresh4RelaView";    //是否刷新相关视图

 /// <summary>
 /// 常量:"TabRecNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRecNum = "TabRecNum";    //记录数

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

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
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum4Refer = "OrderNum4Refer";    //引用序号

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldNum = "FldNum";    //字段数

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"TabStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateName = "TabStateName";    //表状态名称

 /// <summary>
 /// 常量:"TabMainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeName = "TabMainTypeName";    //表主类型名

 /// <summary>
 /// 常量:"TabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeName = "TabTypeName";    //表类型名

 /// <summary>
 /// 常量:"RelaTabName4View"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabName4View = "RelaTabName4View";    //RelaTabName4View

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否核实

 /// <summary>
 /// 常量:"Owner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Owner = "Owner";    //拥有者

 /// <summary>
 /// 常量:"TabEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabEnName = "TabEnName";    //表英文详细名

 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

 /// <summary>
 /// 常量:"TabNameB"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabNameB = "TabNameB";    //表名_后备

 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNationStandard = "IsNationStandard";    //是否国标

 /// <summary>
 /// 常量:"IsParaTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsParaTab = "IsParaTab";    //是否参数表

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsArchive = "IsArchive";    //是否存档

 /// <summary>
 /// 常量:"UpdDate2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate2 = "UpdDate2";    //UpdDate2

 /// <summary>
 /// 常量:"DataBaseNameTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseNameTab = "DataBaseNameTab";    //DataBaseName_Tab
}

}